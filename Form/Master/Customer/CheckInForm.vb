Imports System.Data

Public Class CheckInForm

    Private selectedId As Integer = -1
    Private hargaPerMalam As Decimal = 0
    Private tglCheckinRencana As DateTime
    Private tglCheckoutRencana As DateTime

    Private Sub CheckInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        ClearForm()
    End Sub

    Private Sub LoadGrid(Optional filter As String = "")
        Try
            Dim filterStatus As String = cboFilter.SelectedItem?.ToString()
            Dim statusParam As Object = Nothing

            If filterStatus <> "Semua" AndAlso filterStatus <> "" Then
                statusParam = filterStatus
            End If

            Dim params As New Dictionary(Of String, Object) From {
                {"@filter", If(filter = "", Nothing, filter)},
                {"@status", statusParam}
            }

            ' Hanya tampilkan yang bisa di-checkin
            Dim dt As DataTable = Database.ExecuteQuery("sp_GetAllReservasi", params)
            Dim view As New DataView(dt)

            ' Default: tampilkan Pending dan Confirmed saja
            If statusParam Is Nothing Then
                view.RowFilter = "status IN ('Pending', 'Confirmed', 'Checked-In')"
            End If

            dgvCheckin.DataSource = view.ToTable()
            StyleGrid()
        Catch ex As Exception
            MsgBox("Gagal load data: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub StyleGrid()
        If dgvCheckin.Columns.Count = 0 Then Exit Sub

        Dim headers As New Dictionary(Of String, String) From {
            {"id_reservasi", "ID"}, {"nik", "NIK"}, {"nama_tamu", "Nama Tamu"},
            {"nomor_kamar", "Kamar"}, {"tipe_reservasi", "Tipe"},
            {"harga_kamar", "Harga/Malam"}, {"tanggal_checkin", "Tgl Check-In"},
            {"tanggal_checkout", "Tgl Check-Out"}, {"status", "Status"}
        }
        For Each kv In headers
            If dgvCheckin.Columns.Contains(kv.Key) Then
                dgvCheckin.Columns(kv.Key).HeaderText = kv.Value
            End If
        Next

        For Each col As String In {"id_kamar", "id_tamu", "tanggal_reservasi", "nama_tipe", "no_hp"}
            If dgvCheckin.Columns.Contains(col) Then
                dgvCheckin.Columns(col).Visible = False
            End If
        Next

        If dgvCheckin.Columns.Contains("harga_kamar") Then
            dgvCheckin.Columns("harga_kamar").DefaultCellStyle.Format = "N0"
        End If

        For Each row As DataGridViewRow In dgvCheckin.Rows
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
            End Select
        Next
    End Sub

    Private Sub dgvCheckin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCheckin.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim row As DataGridViewRow = dgvCheckin.Rows(e.RowIndex)
        Dim status As String = row.Cells("status").Value?.ToString()

        selectedId = Convert.ToInt32(row.Cells("id_reservasi").Value)
        hargaPerMalam = Convert.ToDecimal(row.Cells("harga_kamar").Value)
        tglCheckinRencana = Convert.ToDateTime(row.Cells("tanggal_checkin").Value)
        tglCheckoutRencana = Convert.ToDateTime(row.Cells("tanggal_checkout").Value)

        txtIdReservasi.Text = selectedId.ToString()
        txtNamaTamu.Text = row.Cells("nama_tamu").Value?.ToString() &
                              "  (NIK: " & row.Cells("nik").Value?.ToString() & ")"
        txtKamar.Text = "No. " & row.Cells("nomor_kamar").Value?.ToString()
        txtHarga.Text = "Rp " & hargaPerMalam.ToString("N0") & " / malam"
        txtTipe.Text = row.Cells("tipe_reservasi").Value?.ToString()
        dtpTglCheckin.Value = tglCheckinRencana
        dtpTglCheckout.Value = tglCheckoutRencana

        HitungEstimasi()

        Select Case status
            Case "Checked-In"
                btnCheckIn.Enabled = False
                btnCheckIn.Text = "Sudah Check-In"
            Case "Checked-Out", "Cancelled"
                btnCheckIn.Enabled = False
                btnCheckIn.Text = "Tidak Dapat Diproses"
            Case Else
                btnCheckIn.Enabled = True
                btnCheckIn.Text = "Proses Check-In"
        End Select
    End Sub

    Private Sub dtpTglCheckin_ValueChanged(sender As Object, e As EventArgs) Handles dtpTglCheckin.ValueChanged
        HitungEstimasi()
    End Sub
    Private Sub dtpTglCheckout_ValueChanged(sender As Object, e As EventArgs) Handles dtpTglCheckout.ValueChanged
        HitungEstimasi()
    End Sub

    Private Sub HitungEstimasi()
        Dim malam As Integer = (dtpTglCheckout.Value.Date - dtpTglCheckin.Value.Date).Days
        If malam <= 0 Then
            txtEstimasi.Text = "Tanggal tidak valid"
            txtEstimasi.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
            txtEstimasi.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Else
            txtEstimasi.Text = "Rp " & (malam * hargaPerMalam).ToString("N0") & " (" & malam & " malam)"
            txtEstimasi.BackColor = System.Drawing.Color.FromArgb(209, 250, 229)
            txtEstimasi.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70)
        End If
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        If selectedId = -1 Then
            MsgBox("Pilih reservasi dari daftar.", MsgBoxStyle.Exclamation) : Exit Sub
        End If
        If dtpTglCheckout.Value.Date <= dtpTglCheckin.Value.Date Then
            MsgBox("Tanggal checkout harus setelah checkin.", MsgBoxStyle.Exclamation) : Exit Sub
        End If

        Dim malam As Integer = (dtpTglCheckout.Value.Date - dtpTglCheckin.Value.Date).Days
        If MsgBox("Konfirmasi Check-In:" & vbNewLine &
                  "Tamu  : " & txtNamaTamu.Text & vbNewLine &
                  "Kamar : " & txtKamar.Text & vbNewLine &
                  "Malam : " & malam & " malam" & vbNewLine &
                  "Total : Rp " & (malam * hargaPerMalam).ToString("N0") & vbNewLine & vbNewLine &
                  "Lanjutkan?",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question,
                  "Konfirmasi Check-In") = MsgBoxResult.Yes Then
            Try
                Database.ExecuteNonQuery("sp_ProsesCheckIn",
                    New Dictionary(Of String, Object) From {
                        {"@id_reservasi", selectedId},
                        {"@tgl_checkin", dtpTglCheckin.Value.Date},
                        {"@tgl_checkout", dtpTglCheckout.Value.Date}
                    })
                MsgBox("Check-In berhasil!", MsgBoxStyle.Information, "Berhasil")
                LoadGrid() : ClearForm()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub cboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilter.SelectedIndexChanged
        LoadGrid(txtCari.Text.Trim())
    End Sub
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        LoadGrid(txtCari.Text.Trim())
    End Sub
    Private Sub txtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then LoadGrid(txtCari.Text.Trim())
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtCari.Clear() : cboFilter.SelectedIndex = 0 : LoadGrid() : ClearForm()
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        selectedId = -1
        hargaPerMalam = 0
        txtIdReservasi.Text = ""
        txtNamaTamu.Text = ""
        txtKamar.Text = ""
        txtHarga.Text = ""
        txtTipe.Text = ""
        txtEstimasi.Text = "Rp 0"
        txtEstimasi.BackColor = System.Drawing.Color.FromArgb(209, 250, 229)
        txtEstimasi.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70)
        dtpTglCheckin.Value = DateTime.Today
        dtpTglCheckout.Value = DateTime.Today.AddDays(1)
        cboStatus.SelectedIndex = 0
        btnCheckIn.Enabled = False
        btnCheckIn.Text = "Proses Check-In"
    End Sub

End Class