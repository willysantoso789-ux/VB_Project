Imports VB_PROJECT.HotelDBDataSetTableAdapters

Public Class CheckOutForm

    Private hargaPerMalam As Decimal = 0
    Private tglCheckin As DateTime
    Private tglCheckoutRencana As DateTime
    Private selectedIdKamar As Integer = -1
    Public dendaKerusakanTotal As Decimal = 0

    Private Sub CheckOutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboFilter.SelectedIndex = 0
        RefreshData()
        ClearBill()
    End Sub

    Private Sub RefreshData()
        Me.Vw_CheckInAktifTableAdapter.Fill(Me.HotelDBDataSet.vw_CheckInAktif)
        ApplyFilter()
    End Sub

    Private Sub ApplyFilter()
        Dim sel As String = cboFilter.SelectedItem?.ToString()
        Dim kw As String = txtCari.Text.Trim()
        Dim f As String = If(sel = "Checked-In (Aktif)" OrElse sel = "", "Status = 'Checked-In'", "")
        If kw <> "" Then
            Dim cf = "[Nomor Kamar] LIKE '%" & kw & "%' OR [Nama Tamu] LIKE '%" & kw & "%'"
            f = If(f = "", cf, "(" & f & ") AND (" & cf & ")")
        End If
        VwCheckInAktifBindingSource.Filter = f
    End Sub

    Private Sub dgvCheckOut_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCheckOut.CellClick
        If dgvCheckOut.SelectedRows.Count = 0 Then Exit Sub

        ' [0]=ID Reservasi [1]=NIK [2]=Nama Tamu [3]=No.HP [4]=Nomor Kamar
        ' [5]=Tipe Kamar [6]=Tipe Reservasi [7]=Tgl Check-In [8]=Tgl Check-Out Plan
        ' [9]=Durasi [10]=Harga/Malam [11]=Hari Menginap Sekarang [12]=Hari Terlambat [13]=Status
        Dim status As String = dgvCheckOut.SelectedRows(0).Cells(13).Value?.ToString()

        hargaPerMalam = ParseRupiah(dgvCheckOut.SelectedRows(0).Cells(10).Value?.ToString())
        tglCheckin = ParseTanggal(dgvCheckOut.SelectedRows(0).Cells(7).Value?.ToString())
        tglCheckoutRencana = ParseTanggal(dgvCheckOut.SelectedRows(0).Cells(8).Value?.ToString())
        dendaKerusakanTotal = 0

        Dim noKamar As String = dgvCheckOut.SelectedRows(0).Cells(4).Value?.ToString()
        selectedIdKamar = GetIdKamarByNomor(noKamar)

        txtIdReservasi.Text = dgvCheckOut.SelectedRows(0).Cells(0).Value
        txtNamaTamu.Text = dgvCheckOut.SelectedRows(0).Cells(2).Value?.ToString()
        txtKamar.Text = "No. " & noKamar
        txtHarga.Text = dgvCheckOut.SelectedRows(0).Cells(10).Value?.ToString() & " / malam"
        txtTglCheckin.Text = tglCheckin.ToString("dd/MM/yyyy")
        txtTglCheckout.Text = tglCheckoutRencana.ToString("dd/MM/yyyy")
        txtTglAktual.Text = DateTime.Today.ToString("dd/MM/yyyy") & "  (Hari Ini)"
        txtDendaKerusakan.Text = "Rp 0"

        HitungSemua()

        If status = "Checked-In" Then
            btnCheckOut.Enabled = True : btnCheckOut.Text = "Proses Check-Out & Bayar"
            btnDenda.Enabled = True
        Else
            btnCheckOut.Enabled = False : btnCheckOut.Text = "Sudah Check-Out"
            btnDenda.Enabled = False
        End If
    End Sub

    Private Sub HitungSemua()
        Dim tglCO As DateTime = DateTime.Today
        If tglCO <= tglCheckin Then
            txtMalam.Text = "Tidak valid" : txtTotal.Text = "Rp 0" : Return
        End If

        Dim malam As Integer = (tglCO - tglCheckin).Days
        Dim biayaKamar As Decimal = malam * hargaPerMalam
        Dim persen As Decimal = AppSettingsManager.PersenDenda / 100D
        Dim hariTelat As Integer = 0
        Dim dendaTelat As Decimal = 0

        If tglCO > tglCheckoutRencana Then
            hariTelat = (tglCO - tglCheckoutRencana).Days
            dendaTelat = hariTelat * (hargaPerMalam * persen)
        End If

        Dim grandTotal As Decimal = biayaKamar + dendaTelat + dendaKerusakanTotal

        txtMalam.Text = malam & " malam"
        txtBiayaKamar.Text = "Rp " & biayaKamar.ToString("N0")
        txtDendaTelat.Text = If(hariTelat > 0,
            "Rp " & dendaTelat.ToString("N0") & " (" & hariTelat & " hari × " & AppSettingsManager.PersenDenda & "%)",
            "Rp 0 (Tepat waktu)")
        txtDendaTelat.BackColor = If(hariTelat > 0,
            System.Drawing.Color.FromArgb(254, 226, 226),
            System.Drawing.Color.FromArgb(209, 250, 229))
        txtDendaTelat.ForeColor = If(hariTelat > 0,
            System.Drawing.Color.FromArgb(153, 27, 27),
            System.Drawing.Color.FromArgb(6, 95, 70))
        txtDendaKerusakan.Text = "Rp " & dendaKerusakanTotal.ToString("N0")
        txtTotal.Text = "Rp " & grandTotal.ToString("N0")
    End Sub

    Private Sub btnDenda_Click(sender As Object, e As EventArgs) Handles btnDenda.Click
        If dgvCheckOut.SelectedRows.Count = 0 Then Exit Sub
        Dim idRes As Integer = dgvCheckOut.SelectedRows(0).Cells(0).Value
        Dim hariTelat As Integer = If(DateTime.Today > tglCheckoutRencana,
                                       (DateTime.Today - tglCheckoutRencana).Days, 0)
        Dim dendaPerHari As Decimal = hargaPerMalam * (AppSettingsManager.PersenDenda / 100D)

        Dim frm As New DendaForm()
        frm.SetData(idRes, txtNamaTamu.Text, txtKamar.Text,
                    selectedIdKamar, hariTelat, dendaPerHari, dendaKerusakanTotal)
        frm.ShowDialog()

        dendaKerusakanTotal = frm.TotalDendaKerusakan
        txtDendaKerusakan.Text = "Rp " & dendaKerusakanTotal.ToString("N0")
        txtDendaKerusakan.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
        txtDendaKerusakan.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        HitungSemua()
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        If dgvCheckOut.SelectedRows.Count = 0 Then Exit Sub
        If cboMetode.SelectedIndex = -1 Then
            MsgBox("Pilih metode pembayaran.", MsgBoxStyle.Exclamation) : cboMetode.Focus() : Exit Sub
        End If

        If MsgBox("Konfirmasi Check-Out:" & vbNewLine &
                  "Tamu   : " & txtNamaTamu.Text & vbNewLine &
                  "Kamar  : " & txtKamar.Text & vbNewLine &
                  "Total  : " & txtTotal.Text & vbNewLine &
                  "Metode : " & cboMetode.SelectedItem.ToString() & vbNewLine & vbNewLine & "Lanjutkan?",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Konfirmasi") = MsgBoxResult.Yes Then
            Try
                Dim idRes As Integer = dgvCheckOut.SelectedRows(0).Cells(0).Value
                Dim idTransOut As Integer = 0
                ' sp_ProsesCheckOut(@id_reservasi, @id_user, @tgl_checkout_aktual,
                '                   @metode_pembayaran, @denda_kerusakan, @persen_denda, @id_transaksi OUTPUT)
                QueriesTableAdapter1.sp_ProsesCheckOut(
                    idRes,
                    MainForm.SessionUserId,
                    DateTime.Today,
                    cboMetode.SelectedItem.ToString(),
                    dendaKerusakanTotal,
                    AppSettingsManager.PersenDenda,
                    idTransOut)

                MsgBox("Check-Out berhasil!" & vbNewLine &
                       "ID Transaksi: " & idTransOut & vbNewLine &
                       "Total Bayar : " & txtTotal.Text,
                       MsgBoxStyle.Information, "Berhasil")

                RefreshData() : ClearBill()
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
        txtCari.Clear() : cboFilter.SelectedIndex = 0 : RefreshData() : ClearBill()
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearBill()
    End Sub

    Private Sub ClearBill()
        hargaPerMalam = 0
        dendaKerusakanTotal = 0
        selectedIdKamar = -1
        txtIdReservasi.Text = ""
        txtNamaTamu.Text = ""
        txtKamar.Text = ""
        txtHarga.Text = ""
        txtTglCheckin.Text = ""
        txtTglCheckout.Text = ""
        txtTglAktual.Text = DateTime.Today.ToString("dd/MM/yyyy") & "  (Hari Ini)"
        txtMalam.Text = ""
        txtBiayaKamar.Text = ""
        txtDendaTelat.Text = "Rp 0"
        txtDendaKerusakan.Text = "Rp 0"
        txtTotal.Text = "Rp 0"
        cboMetode.SelectedIndex = -1
        btnCheckOut.Enabled = False
        btnCheckOut.Text = "Proses Check-Out & Bayar"
        btnDenda.Enabled = False
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

    Private Function GetIdKamarByNomor(nomor As String) As Integer
        Dim dt = New sp_GetAllKamarTableAdapter().GetData()
        For Each dr As System.Data.DataRow In dt.Rows
            If dr("nomor_kamar").ToString() = nomor Then Return Convert.ToInt32(dr("id_kamar"))
        Next
        Return -1
    End Function

End Class