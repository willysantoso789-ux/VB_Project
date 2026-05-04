Imports System.Data
Imports Org.BouncyCastle.Asn1.Cmp

Public Class KamarForm

    Private isEdit As Boolean = False
    Private selectedId As Integer = -1
    Private selectedNomorKamar As String = ""

    Private Sub DataKamarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTipeKamar()
        LoadGrid()
        ClearForm()
    End Sub

    Private Sub LoadTipeKamar()
        Try
            cboIdTipe.Items.Clear()
            Dim dt As DataTable = Database.ExecuteQuery("sp_GetAllTipeKamar", Nothing)
            For Each row As DataRow In dt.Rows
                cboIdTipe.Items.Add(New TipeItem(
                    Convert.ToInt32(row("id_tipe")),
                    row("nama_tipe").ToString()))
            Next
            cboIdTipe.DisplayMember = "Nama"
            cboIdTipe.ValueMember = "Id"
        Catch ex As Exception
            MsgBox("Gagal load tipe kamar: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub LoadGrid(Optional filter As String = "")
        Try
            Dim dt As DataTable = Database.ExecuteQuery("sp_GetAllKamar", Nothing)

            If filter <> "" Then
                Dim view As New DataView(dt)
                view.RowFilter = "nomor_kamar LIKE '%" & filter & "%'"
                dgvKamar.DataSource = view.ToTable()
            Else
                dgvKamar.DataSource = dt
            End If
            StyleGrid()
        Catch ex As Exception
            MsgBox("Gagal load data kamar: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub StyleGrid()
        If dgvKamar.Columns.Count = 0 Then Exit Sub

        Dim headers As New Dictionary(Of String, String) From {
            {"id_kamar", "ID"},
            {"id_tipe", "ID Tipe"},
            {"nama_tipe", "Tipe Kamar"},
            {"nomor_kamar", "Nomor Kamar"},
            {"status", "Status"},
            {"harga", "Harga/Malam"}
        }
        For Each kv In headers
            If dgvKamar.Columns.Contains(kv.Key) Then
                dgvKamar.Columns(kv.Key).HeaderText = kv.Value
            End If
        Next

        If dgvKamar.Columns.Contains("harga") Then
            dgvKamar.Columns("harga").DefaultCellStyle.Format = "N0"
        End If
        If dgvKamar.Columns.Contains("id_tipe") Then
            dgvKamar.Columns("id_tipe").Visible = False
        End If

        For Each row As DataGridViewRow In dgvKamar.Rows
            Select Case row.Cells("status").Value?.ToString()
                Case "Tersedia"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Terisi"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Maintenance"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            End Select
        Next
    End Sub

    Private Sub dgvKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKamar.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim row As DataGridViewRow = dgvKamar.Rows(e.RowIndex)

        selectedId = Convert.ToInt32(row.Cells("id_kamar").Value)
        selectedNomorKamar = row.Cells("nomor_kamar").Value?.ToString()
        txtIdKamar.Text = selectedId.ToString()
        txtNomorKamar.Text = selectedNomorKamar
        cboStatus.SelectedItem = row.Cells("status").Value?.ToString()

        Dim idTipe As Integer = Convert.ToInt32(row.Cells("id_tipe").Value)
        For i As Integer = 0 To cboIdTipe.Items.Count - 1
            If CType(cboIdTipe.Items(i), TipeItem).Id = idTipe Then
                cboIdTipe.SelectedIndex = i : Exit For
            End If
        Next

        btnHapus.Enabled = True
        btnKondisi.Enabled = True
        btnSimpan.Text = "Update"
        isEdit = True
    End Sub

    '── Adjust Kondisi Properti (dari sini, bukan dari PropertiForm) ──
    'Private Sub btnKondisi_Click(sender As Object, e As EventArgs) Handles btnKondisi.Click
    '    If selectedId = -1 Then
    '        MsgBox("Pilih kamar dari tabel terlebih dahulu.", MsgBoxStyle.Exclamation)
    '        Exit Sub
    '    End If

    '    Dim frm As New KondisiPropertiForm()
    '    frm.SetKamar(selectedId, selectedNomorKamar)
    '    frm.ShowDialog()
    '    LoadGrid()
    'End Sub

    Private Sub ClearForm()
        txtIdKamar.Text = "(auto)"
        cboIdTipe.SelectedIndex = -1
        txtNomorKamar.Clear()
        cboStatus.SelectedIndex = -1
        btnHapus.Enabled = False
        btnKondisi.Enabled = False
        btnSimpan.Text = "Simpan"
        isEdit = False
        selectedId = -1
        selectedNomorKamar = ""
        txtNomorKamar.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidateForm() Then Exit Sub
        Dim tipe As TipeItem = CType(cboIdTipe.SelectedItem, TipeItem)
        Try
            If isEdit Then
                Database.ExecuteNonQuery("sp_UpdateKamar",
                    New Dictionary(Of String, Object) From {
                        {"@id_kamar", selectedId},
                        {"@id_tipe", tipe.Id},
                        {"@nomor_kamar", txtNomorKamar.Text.Trim()},
                        {"@status", cboStatus.SelectedItem.ToString()}
                    })
                MsgBox("Data kamar berhasil diupdate.", MsgBoxStyle.Information, "Berhasil")
            Else
                Database.ExecuteNonQuery("sp_InsertKamar",
                    New Dictionary(Of String, Object) From {
                        {"@id_tipe", tipe.Id},
                        {"@nomor_kamar", txtNomorKamar.Text.Trim()},
                        {"@status", cboStatus.SelectedItem.ToString()}
                    })
                MsgBox("Data kamar berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")
            End If
            LoadGrid() : ClearForm()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim konfirm As Boolean = True
        If AppSettingsManager.ConfirmHapus Then
            konfirm = (MsgBox("Yakin ingin menghapus kamar ini?",
                              MsgBoxStyle.YesNo Or MsgBoxStyle.Question,
                              "Hapus") = MsgBoxResult.Yes)
        End If
        If Not konfirm Then Exit Sub
        Try
            Database.ExecuteNonQuery("sp_DeleteKamar",
                New Dictionary(Of String, Object) From {{"@id_kamar", selectedId}})
            MsgBox("Data kamar berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
            LoadGrid() : ClearForm()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearForm()
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
        If cboIdTipe.SelectedIndex = -1 Then
            MsgBox("Pilih tipe kamar.", MsgBoxStyle.Exclamation) : cboIdTipe.Focus() : Return False
        End If
        If String.IsNullOrWhiteSpace(txtNomorKamar.Text) Then
            MsgBox("Nomor kamar tidak boleh kosong.", MsgBoxStyle.Exclamation) : txtNomorKamar.Focus() : Return False
        End If
        If cboStatus.SelectedIndex = -1 Then
            MsgBox("Pilih status kamar.", MsgBoxStyle.Exclamation) : cboStatus.Focus() : Return False
        End If
        Return True
    End Function

End Class

'── Helper class TipeItem ──────────────────────────────────
Public Class TipeItem
    Public Property Id As Integer
    Public Property Nama As String
    Public Sub New(id As Integer, nama As String)
        Me.Id = id : Me.Nama = nama
    End Sub
    Public Overrides Function ToString() As String
        Return Nama
    End Function
End Class