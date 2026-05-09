Imports VB_PROJECT.HotelDBDataSetTableAdapters

Public Class CheckOutForm

    Private hargaPerMalam As Decimal = 0
    Private tglCheckin As DateTime
    Private tglCheckoutRencana As DateTime
    Private selectedIdKamar As Integer = -1
    Public dendaKerusakanTotal As Decimal = 0

    ' Referensi DendaForm untuk update kondisi setelah checkout
    Private dendaFormRef As DendaForm = Nothing

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
        Dim f As String = If(sel = "Checked-In (Aktif)" OrElse sel = "",
                               "Status = 'Checked-In'", "")
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
        dendaFormRef = Nothing

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
            btnCheckOut.Enabled = True
            btnCheckOut.Text = "Proses Check-Out & Bayar"
            btnDenda.Enabled = True
        Else
            btnCheckOut.Enabled = False
            btnCheckOut.Text = "Sudah Check-Out"
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

        If hariTelat > 0 Then
            txtDendaTelat.Text = "Rp " & dendaTelat.ToString("N0") &
                                      " (" & hariTelat & " hari × " &
                                      AppSettingsManager.PersenDenda & "% harga kamar)"
            txtDendaTelat.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
            txtDendaTelat.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Else
            txtDendaTelat.Text = "Rp 0  (Tepat waktu)"
            txtDendaTelat.BackColor = System.Drawing.Color.FromArgb(209, 250, 229)
            txtDendaTelat.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70)
        End If

        txtDendaKerusakan.Text = "Rp " & dendaKerusakanTotal.ToString("N0")
        If dendaKerusakanTotal > 0 Then
            txtDendaKerusakan.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
            txtDendaKerusakan.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Else
            txtDendaKerusakan.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
            txtDendaKerusakan.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        End If

        txtTotal.Text = "Rp " & grandTotal.ToString("N0")
        If grandTotal > biayaKamar Then
            txtTotal.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
            txtTotal.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Else
            txtTotal.BackColor = System.Drawing.Color.FromArgb(209, 250, 229)
            txtTotal.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70)
        End If
    End Sub

    Private Sub btnDenda_Click(sender As Object, e As EventArgs) Handles btnDenda.Click
        If dgvCheckOut.SelectedRows.Count = 0 Then Exit Sub

        Dim idRes As Integer = dgvCheckOut.SelectedRows(0).Cells(0).Value
        Dim hariTelat As Integer = If(DateTime.Today > tglCheckoutRencana,
                                         (DateTime.Today - tglCheckoutRencana).Days, 0)
        Dim dendaPerHari As Decimal = hargaPerMalam * (AppSettingsManager.PersenDenda / 100D)

        ' Buat form denda baru — simpan referensi untuk update DB setelah checkout
        dendaFormRef = New DendaForm()
        dendaFormRef.SetData(idRes, txtNamaTamu.Text, txtKamar.Text,
                             selectedIdKamar, hariTelat, dendaPerHari, dendaKerusakanTotal)
        dendaFormRef.ShowDialog()

        ' Ambil total dari form denda
        dendaKerusakanTotal = dendaFormRef.TotalDendaKerusakan
        txtDendaKerusakan.Text = "Rp " & dendaKerusakanTotal.ToString("N0")

        If dendaKerusakanTotal > 0 Then
            txtDendaKerusakan.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
            txtDendaKerusakan.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Else
            txtDendaKerusakan.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
            txtDendaKerusakan.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        End If

        HitungSemua()
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        If dgvCheckOut.SelectedRows.Count = 0 Then Exit Sub
        If cboMetode.SelectedIndex = -1 Then
            MsgBox("Pilih metode pembayaran.", MsgBoxStyle.Exclamation)
            cboMetode.Focus() : Exit Sub
        End If

        ' Konfirmasi dengan detail lengkap termasuk denda
        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("Konfirmasi Check-Out:")
        sb.AppendLine("")
        sb.AppendLine("Tamu       : " & txtNamaTamu.Text)
        sb.AppendLine("Kamar      : " & txtKamar.Text)
        sb.AppendLine("Durasi     : " & txtMalam.Text)
        sb.AppendLine("Biaya Kamar: " & txtBiayaKamar.Text)
        If txtDendaTelat.Text <> "Rp 0  (Tepat waktu)" Then
            sb.AppendLine("Denda Telat: " & txtDendaTelat.Text)
        End If
        If dendaKerusakanTotal > 0 Then
            sb.AppendLine("Denda Rusak: " & txtDendaKerusakan.Text)
        End If
        sb.AppendLine("─────────────────────────────")
        sb.AppendLine("TOTAL      : " & txtTotal.Text)
        sb.AppendLine("Metode     : " & cboMetode.SelectedItem.ToString())
        sb.AppendLine("")
        sb.AppendLine("Lanjutkan?")

        If MsgBox(sb.ToString(),
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Konfirmasi Check-Out") = MsgBoxResult.Yes Then
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

                ' ── Update kondisi properti ke DB setelah checkout berhasil ──
                ' Properti kondisi Baik → dicentang user → update jadi Rusak
                ' Properti kondisi Rusak → tidak perlu update (sudah rusak)
                ' Properti kondisi Dalam Perbaikan → tidak berubah
                If dendaFormRef IsNot Nothing Then
                    dendaFormRef.UpdateKondisiRusakKeDB()
                    dendaFormRef = Nothing
                End If

                ' Tampilkan struk ringkas
                Dim struk As New System.Text.StringBuilder()
                struk.AppendLine("✔ CHECK-OUT BERHASIL")
                struk.AppendLine("")
                struk.AppendLine("ID Transaksi : " & idTransOut)
                struk.AppendLine("Tamu         : " & txtNamaTamu.Text)
                struk.AppendLine("Kamar        : " & txtKamar.Text)
                struk.AppendLine("Total Bayar  : " & txtTotal.Text)
                struk.AppendLine("Metode       : " & cboMetode.SelectedItem.ToString())
                struk.AppendLine("Waktu        : " & DateTime.Now.ToString("dd/MM/yyyy HH:mm"))

                MsgBox(struk.ToString(), MsgBoxStyle.Information, "Check-Out Berhasil")
                RefreshData() : ClearBill()

            Catch ex As Exception
                MsgBox("Gagal checkout: " & ex.Message, MsgBoxStyle.Critical, "Error")
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
        txtCari.Clear() : cboFilter.SelectedIndex = 0
        RefreshData() : ClearBill()
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearBill()
    End Sub

    Private Sub ClearBill()
        hargaPerMalam = 0
        dendaKerusakanTotal = 0
        selectedIdKamar = -1
        dendaFormRef = Nothing
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
        txtDendaTelat.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        txtDendaTelat.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        txtDendaKerusakan.Text = "Rp 0"
        txtDendaKerusakan.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        txtDendaKerusakan.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        txtTotal.Text = "Rp 0"
        txtTotal.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        txtTotal.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        cboMetode.SelectedIndex = -1
        btnCheckOut.Enabled = False
        btnCheckOut.Text = "Proses Check-Out & Bayar"
        btnDenda.Enabled = False
    End Sub

    ' ── Helpers ───────────────────────────────────────────
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
        ' sp_GetAllKamar — no parameter
        Dim dt = New sp_GetAllKamarTableAdapter().GetData()
        For Each dr As System.Data.DataRow In dt.Rows
            If dr("nomor_kamar").ToString() = nomor Then
                Return Convert.ToInt32(dr("id_kamar"))
            End If
        Next
        Return -1
    End Function

End Class