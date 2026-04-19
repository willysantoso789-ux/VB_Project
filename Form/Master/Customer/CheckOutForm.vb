Imports System.Data

Public Class CheckOutForm

    Private dtCheckOut As New DataTable()
    Private selectedId As Integer = -1
    Private hargaPerMalam As Decimal = 0
    Private tglCheckinAktual As DateTime
    Private tglCheckoutRencana As DateTime

    ' Denda dari DendaForm
    Public dendaKerusakanTotal As Decimal = 0

    Private Sub CheckOutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFromReservasi()
        LoadGrid()
        ClearForm()
    End Sub

    Private Sub LoadFromReservasi()
        dtCheckOut = New DataTable()
        dtCheckOut.Columns.Add("id_reservasi", GetType(Integer))
        dtCheckOut.Columns.Add("nama_tamu", GetType(String))
        dtCheckOut.Columns.Add("nomor_kamar", GetType(String))
        dtCheckOut.Columns.Add("harga_kamar", GetType(Decimal))
        dtCheckOut.Columns.Add("tgl_checkin", GetType(DateTime))
        dtCheckOut.Columns.Add("tgl_checkout", GetType(DateTime))
        dtCheckOut.Columns.Add("status", GetType(String))

        If Not ReservasiForm.IsSharedLoaded Then
            dtCheckOut.Rows.Add(1, "Budi Santoso", "101", 350000D, DateTime.Today.AddDays(-2), DateTime.Today, "Checked-In")
            dtCheckOut.Rows.Add(2, "Agus Prasetyo", "301", 1200000D, DateTime.Today.AddDays(-3), DateTime.Today.AddDays(1), "Checked-In")
        Else
            For Each dr As DataRow In ReservasiForm.dtReservasiShared.Rows
                dtCheckOut.Rows.Add(
                    dr("id_reservasi"),
                    dr("nama_tamu"),
                    dr("nomor_kamar"),
                    dr("harga_kamar"),
                    dr("tgl_checkin"),
                    dr("tgl_checkout"),
                    dr("status")
                )
            Next
        End If
    End Sub

    Private Sub LoadGrid(Optional filter As String = "")
        If dtCheckOut.Columns.Count = 0 Then Exit Sub

        Dim filterStatus As String = cboFilter.SelectedItem?.ToString()
        Dim view As New DataView(dtCheckOut)
        Dim rowFilter As String = ""

        If filterStatus = "Checked-In" Then
            rowFilter = "status = 'Checked-In'"
        ElseIf filterStatus = "Checked-Out" Then
            rowFilter = "status = 'Checked-Out'"
        End If

        If filter <> "" Then
            Dim s = "nama_tamu LIKE '%" & filter & "%' OR nomor_kamar LIKE '%" & filter & "%'"
            rowFilter = If(rowFilter = "", s, rowFilter & " AND " & s)
        End If

        view.RowFilter = rowFilter
        dgvCheckOut.DataSource = view.ToTable()
        StyleGrid()
    End Sub

    Private Sub StyleGrid()
        If dgvCheckOut.Columns.Count = 0 Then Exit Sub

        dgvCheckOut.Columns("id_reservasi").HeaderText = "ID Res."
        dgvCheckOut.Columns("nama_tamu").HeaderText = "Nama Tamu"
        dgvCheckOut.Columns("nomor_kamar").HeaderText = "Kamar"
        dgvCheckOut.Columns("harga_kamar").HeaderText = "Harga/Malam"
        dgvCheckOut.Columns("tgl_checkin").HeaderText = "Check-In"
        dgvCheckOut.Columns("tgl_checkout").HeaderText = "Check-Out (Rencana)"
        dgvCheckOut.Columns("status").HeaderText = "Status"

        dgvCheckOut.Columns("id_reservasi").FillWeight = 50
        dgvCheckOut.Columns("nama_tamu").FillWeight = 140
        dgvCheckOut.Columns("nomor_kamar").FillWeight = 55
        dgvCheckOut.Columns("harga_kamar").FillWeight = 90
        dgvCheckOut.Columns("tgl_checkin").FillWeight = 90
        dgvCheckOut.Columns("tgl_checkout").FillWeight = 110
        dgvCheckOut.Columns("status").FillWeight = 80

        dgvCheckOut.Columns("harga_kamar").DefaultCellStyle.Format = "N0"

        For Each row As DataGridViewRow In dgvCheckOut.Rows
            Dim st As String = row.Cells("status").Value?.ToString()
            Select Case st
                Case "Checked-In"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(26, 86, 219)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Checked-Out"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            End Select
        Next
    End Sub

    ' ── Klik baris → isi form ─────────────────────────────
    Private Sub dgvCheckOut_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCheckOut.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvCheckOut.Rows(e.RowIndex)
        Dim status As String = row.Cells("status").Value?.ToString()

        selectedId = Convert.ToInt32(row.Cells("id_reservasi").Value)
        hargaPerMalam = Convert.ToDecimal(row.Cells("harga_kamar").Value)
        tglCheckinAktual = Convert.ToDateTime(row.Cells("tgl_checkin").Value)
        tglCheckoutRencana = Convert.ToDateTime(row.Cells("tgl_checkout").Value)
        dendaKerusakanTotal = 0

        txtIdReservasi.Text = selectedId.ToString()
        txtNamaTamu.Text = row.Cells("nama_tamu").Value.ToString()
        txtKamar.Text = "No. " & row.Cells("nomor_kamar").Value.ToString()
        txtHarga.Text = "Rp " & hargaPerMalam.ToString("N0") & " / malam"
        txtTglCheckin.Text = tglCheckinAktual.ToString("dd/MM/yyyy")
        txtTglCheckout.Text = tglCheckoutRencana.ToString("dd/MM/yyyy")
        dtpTglAktual.Value = DateTime.Today
        txtDendaKerusakan.Text = "Rp 0"

        HitungSemua()

        If status = "Checked-Out" Then
            btnCheckOut.Enabled = False
            btnCheckOut.Text = "Sudah Check-Out"
            btnDenda.Enabled = False
        ElseIf status = "Checked-In" Then
            btnCheckOut.Enabled = True
            btnCheckOut.Text = "Proses Check-Out"
            btnDenda.Enabled = True
        Else
            btnCheckOut.Enabled = False
            btnDenda.Enabled = False
        End If
    End Sub

    ' ── Tanggal aktual berubah → hitung ulang ─────────────
    Private Sub dtpTglAktual_ValueChanged(sender As Object, e As EventArgs) Handles dtpTglAktual.ValueChanged
        If selectedId = -1 Then Exit Sub
        HitungSemua()
    End Sub

    Private Sub HitungSemua()
        Dim tglCI As DateTime = tglCheckinAktual
        Dim tglCO As DateTime = dtpTglAktual.Value.Date

        If tglCO <= tglCI Then
            txtMalam.Text = "Tanggal tidak valid"
            txtBiayaKamar.Text = "Rp 0"
            txtDendaTelat.Text = "Rp 0"
            txtTotal.Text = "Rp 0"
            Exit Sub
        End If

        Dim totalMalam As Integer = (tglCO - tglCI).Days
        Dim biayaKamar As Decimal = totalMalam * hargaPerMalam

        ' Hitung denda telat
        Dim hariTelat As Integer = 0
        Dim dendaTelat As Decimal = 0
        Dim dendaPerHari As Decimal = hargaPerMalam * 0.5D

        If tglCO > tglCheckoutRencana Then
            hariTelat = (tglCO - tglCheckoutRencana).Days
            dendaTelat = hariTelat * dendaPerHari
        End If

        Dim grandTotal As Decimal = biayaKamar + dendaTelat + dendaKerusakanTotal

        txtMalam.Text = totalMalam & " malam"
        txtBiayaKamar.Text = "Rp " & biayaKamar.ToString("N0")
        txtDendaTelat.Text = If(hariTelat > 0, "Rp " & dendaTelat.ToString("N0") & " (" & hariTelat & " hari telat)", "Rp 0")
        txtDendaKerusakan.Text = "Rp " & dendaKerusakanTotal.ToString("N0")
        txtTotal.Text = "Rp " & grandTotal.ToString("N0")

        ' Warna total merah kalau ada denda
        If dendaTelat > 0 OrElse dendaKerusakanTotal > 0 Then
            txtDendaTelat.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
            txtDendaKerusakan.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
        Else
            txtDendaTelat.BackColor = System.Drawing.Color.FromArgb(209, 250, 229)
            txtDendaTelat.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70)
            txtDendaKerusakan.BackColor = System.Drawing.Color.FromArgb(209, 250, 229)
            txtDendaKerusakan.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70)
        End If
    End Sub

    ' ── Buka DendaForm ────────────────────────────────────
    Private Sub btnDenda_Click(sender As Object, e As EventArgs) Handles btnDenda.Click
        If selectedId = -1 Then Exit Sub

        Dim tglCO As DateTime = dtpTglAktual.Value.Date
        Dim hariTelat As Integer = 0
        Dim dendaPerHari As Decimal = hargaPerMalam * 0.5D

        If tglCO > tglCheckoutRencana Then
            hariTelat = (tglCO - tglCheckoutRencana).Days
        End If

        Dim frm As New DendaForm()
        frm.SetData(
            selectedId,
            txtNamaTamu.Text,
            txtKamar.Text,
            hariTelat,
            dendaPerHari,
            dendaKerusakanTotal
        )
        frm.ShowDialog()

        ' Ambil hasil denda kerusakan dari DendaForm
        dendaKerusakanTotal = frm.TotalDendaKerusakan
        txtDendaKerusakan.Text = "Rp " & dendaKerusakanTotal.ToString("N0")
        txtDendaKerusakan.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        txtDendaKerusakan.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)

        HitungSemua()
    End Sub

    ' ── Proses Check-Out ──────────────────────────────────
    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        If selectedId = -1 Then
            MsgBox("Pilih tamu dari daftar.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If cboMetode.SelectedIndex = -1 Then
            MsgBox("Pilih metode pembayaran.", MsgBoxStyle.Exclamation)
            cboMetode.Focus()
            Exit Sub
        End If

        Dim konfirmasi = MsgBox(
            "Konfirmasi Check-Out:" & vbNewLine &
            "Tamu   : " & txtNamaTamu.Text & vbNewLine &
            "Kamar  : " & txtKamar.Text & vbNewLine &
            "Total  : " & txtTotal.Text & vbNewLine &
            "Metode : " & cboMetode.SelectedItem.ToString() & vbNewLine & vbNewLine &
            "Lanjutkan?",
            MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Konfirmasi Check-Out")

        If konfirmasi = MsgBoxResult.Yes Then
            ' Update status di dtCheckOut
            For Each dr As DataRow In dtCheckOut.Rows
                If Convert.ToInt32(dr("id_reservasi")) = selectedId Then
                    dr("status") = "Checked-Out"
                    Exit For
                End If
            Next

            ' Sync ke ReservasiForm
            If ReservasiForm.IsSharedLoaded Then
                For Each dr As DataRow In ReservasiForm.dtReservasiShared.Rows
                    If Convert.ToInt32(dr("id_reservasi")) = selectedId Then
                        dr("status") = "Checked-Out"
                        Exit For
                    End If
                Next
            End If

            MsgBox("Check-Out berhasil!" & vbNewLine &
                   txtNamaTamu.Text & " telah check-out." & vbNewLine &
                   "Total Bayar : " & txtTotal.Text,
                   MsgBoxStyle.Information, "Check-Out Berhasil")

            LoadGrid()
            ClearForm()
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
        txtCari.Clear()
        cboFilter.SelectedIndex = 0
        LoadFromReservasi()
        LoadGrid()
        ClearForm()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        selectedId = -1
        hargaPerMalam = 0
        dendaKerusakanTotal = 0
        txtIdReservasi.Text = ""
        txtNamaTamu.Text = ""
        txtKamar.Text = ""
        txtHarga.Text = ""
        txtTglCheckin.Text = ""
        txtTglCheckout.Text = ""
        dtpTglAktual.Value = DateTime.Today
        txtMalam.Text = ""
        txtBiayaKamar.Text = ""
        txtDendaTelat.Text = "Rp 0"
        txtDendaKerusakan.Text = "Rp 0"
        txtTotal.Text = "Rp 0"
        cboMetode.SelectedIndex = -1
        btnCheckOut.Enabled = False
        btnCheckOut.Text = "Proses Check-Out"
        btnDenda.Enabled = False
    End Sub

End Class