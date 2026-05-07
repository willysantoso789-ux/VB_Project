Imports VB_PROJECT.HotelDBDataSetTableAdapters

Public Class CheckInForm

    Private hargaPerMalam As Decimal = 0

    Private Sub CheckInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboFilter.SelectedIndex = 0
        RefreshData()
        ClearDetail()
    End Sub

    Private Sub RefreshData()
        Me.Vw_CheckInAktifTableAdapter.Fill(Me.HotelDBDataSet.vw_CheckInAktif)
        ApplyFilter()
    End Sub

    Private Sub ApplyFilter()
        Dim status As String = cboFilter.SelectedItem?.ToString()
        Dim kw As String = txtCari.Text.Trim()
        Dim f As String = ""

        If status <> "Semua" AndAlso status <> "" Then
            f = "Status = '" & status & "'"
        End If
        If kw <> "" Then
            Dim cf = "NIK LIKE '" & kw & "%' OR [Nama Tamu] LIKE '%" & kw & "%'"
            f = If(f = "", cf, "(" & f & ") AND (" & cf & ")")
        End If
        VwCheckInAktifBindingSource.Filter = f
    End Sub

    Private Sub dgvCheckin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCheckin.CellClick
        If dgvCheckin.SelectedRows.Count = 0 Then Exit Sub

        ' [0]=ID Reservasi [1]=NIK [2]=Nama Tamu [3]=No.HP [4]=Nomor Kamar
        ' [5]=Tipe Kamar [6]=Tipe Reservasi [7]=Tgl Check-In [8]=Tgl Check-Out Plan
        ' [9]=Durasi [10]=Harga/Malam [11]=Hari Menginap Sekarang [12]=Hari Terlambat [13]=Status
        Dim status As String = dgvCheckin.SelectedRows(0).Cells(13).Value?.ToString()

        hargaPerMalam = ParseRupiah(dgvCheckin.SelectedRows(0).Cells(10).Value?.ToString())
        txtIdReservasi.Text = dgvCheckin.SelectedRows(0).Cells(0).Value
        txtNamaTamu.Text = dgvCheckin.SelectedRows(0).Cells(2).Value?.ToString() &
                           "  (NIK: " & dgvCheckin.SelectedRows(0).Cells(1).Value?.ToString() & ")"
        txtKamar.Text = "No. " & dgvCheckin.SelectedRows(0).Cells(4).Value?.ToString()
        txtHarga.Text = dgvCheckin.SelectedRows(0).Cells(10).Value?.ToString() & " / malam"
        txtTipe.Text = dgvCheckin.SelectedRows(0).Cells(6).Value?.ToString()
        dtpTglCheckin.Value = ParseTanggal(dgvCheckin.SelectedRows(0).Cells(7).Value?.ToString())
        dtpTglCheckout.Value = ParseTanggal(dgvCheckin.SelectedRows(0).Cells(8).Value?.ToString())

        HitungEstimasi()

        Select Case status
            Case "Checked-In"
                btnCheckIn.Enabled = False : btnCheckIn.Text = "Sudah Check-In"
            Case "Checked-Out", "Cancelled"
                btnCheckIn.Enabled = False : btnCheckIn.Text = "Tidak Dapat Diproses"
            Case Else
                btnCheckIn.Enabled = True : btnCheckIn.Text = "Proses Check-In"
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
        If dgvCheckin.SelectedRows.Count = 0 Then Exit Sub
        If dtpTglCheckout.Value.Date <= dtpTglCheckin.Value.Date Then
            MsgBox("Tanggal checkout harus setelah checkin.", MsgBoxStyle.Exclamation) : Exit Sub
        End If

        Dim idRes As Integer = dgvCheckin.SelectedRows(0).Cells(0).Value
        Dim malam As Integer = (dtpTglCheckout.Value.Date - dtpTglCheckin.Value.Date).Days

        If MsgBox("Konfirmasi Check-In:" & vbNewLine &
                  "Tamu  : " & txtNamaTamu.Text & vbNewLine &
                  "Kamar : " & txtKamar.Text & vbNewLine &
                  "Malam : " & malam & " malam — Total: Rp " &
                  (malam * hargaPerMalam).ToString("N0") & vbNewLine & vbNewLine & "Lanjutkan?",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Konfirmasi") = MsgBoxResult.Yes Then
            Try
                ' sp_ProsesCheckIn(@id_reservasi, @tgl_checkin, @tgl_checkout)
                QueriesTableAdapter1.sp_ProsesCheckIn(idRes, dtpTglCheckin.Value.Date, dtpTglCheckout.Value.Date)
                MsgBox("Check-In berhasil!", MsgBoxStyle.Information, "Berhasil")
                RefreshData() : ClearDetail()
            Catch ex As Exception
                MsgBox("Gagal: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub cboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilter.SelectedIndexChanged
        ApplyFilter()
    End Sub
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        ApplyFilter()
    End Sub
    Private Sub txtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then ApplyFilter()
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtCari.Clear() : cboFilter.SelectedIndex = 0 : RefreshData() : ClearDetail()
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearDetail()
    End Sub

    Private Sub ClearDetail()
        hargaPerMalam = 0
        txtIdReservasi.Text = ""
        txtNamaTamu.Text = ""
        txtKamar.Text = ""
        txtHarga.Text = ""
        txtTipe.Text = ""
        dtpTglCheckin.Value = DateTime.Today
        dtpTglCheckout.Value = DateTime.Today.AddDays(1)
        txtEstimasi.Text = "Rp 0"
        txtEstimasi.BackColor = System.Drawing.Color.FromArgb(209, 250, 229)
        txtEstimasi.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70)
        btnCheckIn.Enabled = False
        btnCheckIn.Text = "Proses Check-In"
    End Sub

    Private Function ParseTanggal(val As String) As DateTime
        Dim result As DateTime = DateTime.Today
        If String.IsNullOrEmpty(val) Then Return result
        DateTime.TryParseExact(val, "dd/MM/yyyy",
            Globalization.CultureInfo.InvariantCulture,
            Globalization.DateTimeStyles.None, result)
        Return result
    End Function

    Private Function ParseRupiah(val As String) As Decimal
        If String.IsNullOrEmpty(val) Then Return 0
        Dim cleaned As String = val.Replace("Rp", "").Replace(".", "").Replace(",", "").Trim()
        Dim result As Decimal = 0
        Decimal.TryParse(cleaned, result)
        Return result
    End Function

End Class