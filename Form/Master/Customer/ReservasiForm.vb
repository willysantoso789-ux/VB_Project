Imports System.Data

Public Class ReservasiForm

    Private isEdit As Boolean = False
    Private selectedIdReservasi As Integer = -1
    Private selectedTamu As TamuItem = Nothing
    Private selectedKamar As KamarItem = Nothing
    Private currentHargaKamar As Decimal = 0

    Private Sub ReservasiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTamu()
        LoadKamar()
        LoadGrid()
        ClearForm()
    End Sub

    Private Sub LoadTamu()
        Try
            cboTamu.Items.Clear()
            Dim dt As DataTable = Database.ExecuteQuery("sp_GetAllTamu", Nothing)
            For Each row As DataRow In dt.Rows
                cboTamu.Items.Add(New TamuItem(
                    Convert.ToInt32(row("id_tamu")),
                    row("nik").ToString(),
                    row("nama").ToString()))
            Next
            cboTamu.DisplayMember = "Display"
            cboTamu.ValueMember = "Id"
        Catch ex As Exception
            MsgBox("Gagal load tamu: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub LoadKamar(Optional idKamarCurrent As Integer = -1)
        Try
            cboKamar.Items.Clear()
            Dim dt As DataTable = Database.ExecuteQuery("sp_GetKamarTersedia", Nothing)
            Dim currentIncluded As Boolean = False

            For Each row As DataRow In dt.Rows
                Dim k As New KamarItem(Convert.ToInt32(row("id_kamar")),
                                       row("nomor_kamar").ToString(),
                                       row("nama_tipe").ToString(),
                                       Convert.ToDecimal(row("harga")))
                cboKamar.Items.Add(k)
                If k.Id = idKamarCurrent Then currentIncluded = True
            Next

            ' Saat edit, kamar yang sedang dipakai harus tetap masuk list
            If idKamarCurrent > 0 AndAlso Not currentIncluded Then
                Dim dtKamar As DataTable = Database.ExecuteQuery("sp_GetAllKamar", Nothing)
                For Each row As DataRow In dtKamar.Rows
                    If Convert.ToInt32(row("id_kamar")) = idKamarCurrent Then
                        cboKamar.Items.Insert(0, New KamarItem(
                            idKamarCurrent,
                            row("nomor_kamar").ToString(),
                            row("nama_tipe").ToString(),
                            Convert.ToDecimal(row("harga"))))
                        Exit For
                    End If
                Next
            End If

            cboKamar.DisplayMember = "Display"
            cboKamar.ValueMember = "Id"
        Catch ex As Exception
            MsgBox("Gagal load kamar: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub LoadGrid(Optional filter As String = "")
        Try
            Dim params As New Dictionary(Of String, Object) From {
                {"@filter", If(filter = "", Nothing, filter)},
                {"@status", Nothing}
            }
            Dim dt As DataTable = Database.ExecuteQuery("sp_GetAllReservasi", params)
            dgvReservasi.DataSource = dt
            StyleGrid()
        Catch ex As Exception
            MsgBox("Gagal load reservasi: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub StyleGrid()
        If dgvReservasi.Columns.Count = 0 Then Exit Sub

        Dim headers As New Dictionary(Of String, String) From {
            {"id_reservasi", "ID"}, {"nik", "NIK"}, {"nama_tamu", "Nama Tamu"},
            {"no_hp", "No. HP"}, {"id_kamar", "ID Kamar"}, {"nomor_kamar", "No. Kamar"},
            {"nama_tipe", "Tipe"}, {"harga_kamar", "Harga/Malam"},
            {"tipe_reservasi", "Jenis"}, {"tanggal_reservasi", "Tgl Reservasi"},
            {"tanggal_checkin", "Check-In"}, {"tanggal_checkout", "Check-Out"}, {"status", "Status"}
        }
        For Each kv In headers
            If dgvReservasi.Columns.Contains(kv.Key) Then
                dgvReservasi.Columns(kv.Key).HeaderText = kv.Value
            End If
        Next

        ' Sembunyikan kolom teknis
        For Each col As String In {"id_kamar", "id_tamu"}
            If dgvReservasi.Columns.Contains(col) Then
                dgvReservasi.Columns(col).Visible = False
            End If
        Next

        If dgvReservasi.Columns.Contains("harga_kamar") Then
            dgvReservasi.Columns("harga_kamar").DefaultCellStyle.Format = "N0"
        End If

        For Each row As DataGridViewRow In dgvReservasi.Rows
            Select Case row.Cells("status").Value?.ToString()
                Case "Confirmed"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Pending"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Checked-In"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(26, 86, 219)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Checked-Out"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Cancelled"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            End Select
        Next
    End Sub

    Private Sub cboTamu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTamu.SelectedIndexChanged
        selectedTamu = If(cboTamu.SelectedIndex >= 0,
                          CType(cboTamu.SelectedItem, TamuItem), Nothing)
    End Sub

    Private Sub cboKamar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKamar.SelectedIndexChanged
        If cboKamar.SelectedIndex = -1 Then
            selectedKamar = Nothing : currentHargaKamar = 0
            txtHargaKamar.Text = "Rp 0" : Exit Sub
        End If
        selectedKamar = CType(cboKamar.SelectedItem, KamarItem)
        currentHargaKamar = selectedKamar.Harga
        txtHargaKamar.Text = "Rp " & currentHargaKamar.ToString("N0")
    End Sub

    Private Sub cboTipeReservasi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipe.SelectedIndexChanged
        If cboTipe.SelectedIndex = 0 Then
            dtpTglReservasi.Value = DateTime.Today
            dtpTglCheckin.Value = DateTime.Today
            cboStatus.SelectedItem = "Confirmed"
        End If
    End Sub

    Private Sub dgvReservasi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservasi.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim row As DataGridViewRow = dgvReservasi.Rows(e.RowIndex)

        selectedIdReservasi = Convert.ToInt32(row.Cells("id_reservasi").Value)
        txtIdReservasi.Text = selectedIdReservasi.ToString()
        dtpTglReservasi.Value = Convert.ToDateTime(row.Cells("tanggal_reservasi").Value)
        dtpTglCheckin.Value = Convert.ToDateTime(row.Cells("tanggal_checkin").Value)
        dtpTglCheckout.Value = Convert.ToDateTime(row.Cells("tanggal_checkout").Value)
        currentHargaKamar = Convert.ToDecimal(row.Cells("harga_kamar").Value)
        txtHargaKamar.Text = "Rp " & currentHargaKamar.ToString("N0")

        cboTipe.SelectedItem = row.Cells("tipe_reservasi").Value?.ToString()
        cboStatus.SelectedItem = row.Cells("status").Value?.ToString()

        ' Set tamu
        Dim idTamu As Integer = Convert.ToInt32(row.Cells("id_tamu").Value)
        For i As Integer = 0 To cboTamu.Items.Count - 1
            If CType(cboTamu.Items(i), TamuItem).Id = idTamu Then
                cboTamu.SelectedIndex = i : Exit For
            End If
        Next

        ' Set kamar — reload dengan kamar current
        Dim idKamar As Integer = Convert.ToInt32(row.Cells("id_kamar").Value)
        LoadKamar(idKamar)
        For i As Integer = 0 To cboKamar.Items.Count - 1
            If CType(cboKamar.Items(i), KamarItem).Id = idKamar Then
                cboKamar.SelectedIndex = i : Exit For
            End If
        Next

        btnHapus.Enabled = True
        btnSimpan.Text = "Update"
        isEdit = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidateForm() Then Exit Sub
        Try
            If isEdit Then
                Database.ExecuteNonQuery("sp_UpdateReservasi",
                    New Dictionary(Of String, Object) From {
                        {"@id_reservasi", selectedIdReservasi},
                        {"@id_tamu", selectedTamu.Id},
                        {"@id_kamar", selectedKamar.Id},
                        {"@tipe_reservasi", cboTipe.SelectedItem.ToString()},
                        {"@tgl_reservasi", dtpTglReservasi.Value.Date},
                        {"@tgl_checkin", dtpTglCheckin.Value.Date},
                        {"@tgl_checkout", dtpTglCheckout.Value.Date},
                        {"@status", cboStatus.SelectedItem.ToString()}
                    })
                MsgBox("Reservasi berhasil diupdate.", MsgBoxStyle.Information, "Berhasil")
            Else
                Database.ExecuteNonQuery("sp_InsertReservasi",
                    New Dictionary(Of String, Object) From {
                        {"@id_tamu", selectedTamu.Id},
                        {"@id_kamar", selectedKamar.Id},
                        {"@tipe_reservasi", cboTipe.SelectedItem.ToString()},
                        {"@tgl_reservasi", dtpTglReservasi.Value.Date},
                        {"@tgl_checkin", dtpTglCheckin.Value.Date},
                        {"@tgl_checkout", dtpTglCheckout.Value.Date},
                        {"@status", If(cboStatus.SelectedIndex = 0, "Confirmed", "Pending")}
                    })
                MsgBox("Reservasi berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")
            End If
            LoadGrid() : LoadKamar() : ClearForm()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim konfirm As Boolean = True
        If AppSettingsManager.ConfirmHapus Then
            konfirm = (MsgBox("Yakin hapus reservasi ini?",
                              MsgBoxStyle.YesNo Or MsgBoxStyle.Question,
                              "Hapus") = MsgBoxResult.Yes)
        End If
        If Not konfirm Then Exit Sub
        Try
            Database.ExecuteNonQuery("sp_DeleteReservasi",
                New Dictionary(Of String, Object) From {{"@id_reservasi", selectedIdReservasi}})
            MsgBox("Reservasi berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
            LoadGrid() : LoadKamar() : ClearForm()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        txtIdReservasi.Text = "(auto)"
        cboTipe.SelectedIndex = -1
        cboTamu.SelectedIndex = -1
        cboKamar.SelectedIndex = -1
        cboStatus.SelectedIndex = -1
        txtHargaKamar.Text = "Rp 0"
        dtpTglReservasi.Value = DateTime.Today
        dtpTglCheckin.Value = DateTime.Today
        dtpTglCheckout.Value = DateTime.Today.AddDays(1)
        selectedTamu = Nothing
        selectedKamar = Nothing
        selectedIdReservasi = -1
        currentHargaKamar = 0
        btnHapus.Enabled = False
        btnSimpan.Text = "Simpan"
        isEdit = False
        LoadKamar()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        LoadGrid(txtCari.Text.Trim())
    End Sub
    Private Sub txtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then LoadGrid(txtCari.Text.Trim())
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtCari.Clear() : LoadGrid() : ClearForm()
    End Sub

    Private Function ValidateForm() As Boolean
        If cboTipeReservasi.SelectedIndex = -1 Then
            MsgBox("Pilih tipe reservasi.", MsgBoxStyle.Exclamation) : cboTipeReservasi.Focus() : Return False
        End If
        If selectedTamu Is Nothing Then
            MsgBox("Pilih tamu.", MsgBoxStyle.Exclamation) : cboTamu.Focus() : Return False
        End If
        If selectedKamar Is Nothing Then
            MsgBox("Pilih kamar.", MsgBoxStyle.Exclamation) : cboKamar.Focus() : Return False
        End If
        If cboStatus.SelectedIndex = -1 Then
            MsgBox("Pilih status.", MsgBoxStyle.Exclamation) : cboStatus.Focus() : Return False
        End If
        If dtpTglCheckout.Value.Date <= dtpTglCheckin.Value.Date Then
            MsgBox("Tanggal checkout harus setelah checkin.", MsgBoxStyle.Exclamation) : Return False
        End If
        Return True
    End Function

End Class

' ── Helper classes — letakkan di file terpisah atau di sini ──
Public Class TamuItem
    Public Property Id As Integer
    Public Property NIK As String
    Public Property Nama As String
    Public Property Display As String
    Public Sub New(id As Integer, nik As String, nama As String)
        Me.Id = id : Me.NIK = nik : Me.Nama = nama
        Me.Display = nama & " (" & nik & ")"
    End Sub
    Public Overrides Function ToString() As String
        Return Display
    End Function
End Class

Public Class KamarItem
    Public Property Id As Integer
    Public Property Nomor As String
    Public Property Tipe As String
    Public Property Harga As Decimal
    Public Property Display As String
    Public Sub New(id As Integer, nomor As String, tipe As String, harga As Decimal)
        Me.Id = id : Me.Nomor = nomor : Me.Tipe = tipe : Me.Harga = harga
        Me.Display = "No." & nomor & " — " & tipe & " (Rp " & harga.ToString("N0") & ")"
    End Sub
    Public Overrides Function ToString() As String
        Return Display
    End Function
End Class