Imports System.Data

Public Class CheckInForm

    Private dtCheckin As New DataTable()
    Private selectedId As Integer = -1
    Private hargaPerMalam As Decimal = 0
    Private tglCheckinAktual As DateTime
    Private tglCheckoutRencana As DateTime

    Private Sub CheckInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFromReservasi()
        LoadGrid()
        ClearForm()
    End Sub

    Private Sub LoadFromReservasi()
        dtCheckin = New DataTable()
        dtCheckin.Columns.Add("id_reservasi", GetType(Integer))
        dtCheckin.Columns.Add("nik", GetType(String))
        dtCheckin.Columns.Add("nama_tamu", GetType(String))
        dtCheckin.Columns.Add("nomor_kamar", GetType(String))
        dtCheckin.Columns.Add("tipe_reservasi", GetType(String))
        dtCheckin.Columns.Add("harga_kamar", GetType(Decimal))
        dtCheckin.Columns.Add("tgl_checkin", GetType(DateTime))
        dtCheckin.Columns.Add("tgl_checkout", GetType(DateTime))
        dtCheckin.Columns.Add("status", GetType(String))

        If Not ReservasiForm.IsSharedLoaded Then
            ' Dummy — sertakan NIK
            dtCheckin.Rows.Add(1, "3578012345678901", "Budi Santoso", "101", "Walk-in", 350000D, DateTime.Today, DateTime.Today.AddDays(2), "Confirmed")
            dtCheckin.Rows.Add(2, "3578019876543210", "Siti Rahayu", "201", "Online/Contact", 600000D, DateTime.Today.AddDays(3), DateTime.Today.AddDays(5), "Pending")
            dtCheckin.Rows.Add(3, "3578011122334455", "Agus Prasetyo", "301", "Online/Contact", 1200000D, DateTime.Today.AddDays(1), DateTime.Today.AddDays(4), "Confirmed")
        Else
            For Each dr As DataRow In ReservasiForm.dtReservasiShared.Rows
                dtCheckin.Rows.Add(
                    dr("id_reservasi"),
                    If(dr.Table.Columns.Contains("nik"), dr("nik"), "—"),
                    dr("nama_tamu"),
                    dr("nomor_kamar"),
                    dr("tipe_reservasi"),
                    dr("harga_kamar"),
                    dr("tgl_checkin"),
                    dr("tgl_checkout"),
                    dr("status")
                )
            Next
        End If
    End Sub

    Private Sub LoadGrid(Optional filter As String = "")
        Dim filterStatus As String = cboFilter.SelectedItem?.ToString()
        Dim view As New DataView(dtCheckin)
        Dim rowFilter As String = ""

        ' Filter status
        If filterStatus <> "Semua" AndAlso filterStatus <> "" Then
            rowFilter = "status = '" & filterStatus & "'"
        End If

        ' NIK primary, Nama secondary
        If filter <> "" Then
            Dim cariFilter As String = "nik LIKE '" & filter & "%' OR nama_tamu LIKE '%" & filter & "%'"
            rowFilter = If(rowFilter = "", cariFilter, rowFilter & " AND (" & cariFilter & ")")
        End If

        view.RowFilter = rowFilter
        dgvCheckin.DataSource = view.ToTable()
        StyleGrid()
    End Sub

    Private Sub StyleGrid()
        If dgvCheckin.Columns.Count = 0 Then Exit Sub

        dgvCheckin.Columns("id_reservasi").HeaderText = "ID Res."
        dgvCheckin.Columns("nik").HeaderText = "NIK"
        dgvCheckin.Columns("nama_tamu").HeaderText = "Nama Tamu"
        dgvCheckin.Columns("nomor_kamar").HeaderText = "Kamar"
        dgvCheckin.Columns("tipe_reservasi").HeaderText = "Tipe"
        dgvCheckin.Columns("harga_kamar").HeaderText = "Harga/Malam"
        dgvCheckin.Columns("tgl_checkin").HeaderText = "Tgl Check-In"
        dgvCheckin.Columns("tgl_checkout").HeaderText = "Tgl Check-Out"
        dgvCheckin.Columns("status").HeaderText = "Status"

        dgvCheckin.Columns("id_reservasi").FillWeight = 45
        dgvCheckin.Columns("nik").FillWeight = 110
        dgvCheckin.Columns("nama_tamu").FillWeight = 120
        dgvCheckin.Columns("nomor_kamar").FillWeight = 50
        dgvCheckin.Columns("tipe_reservasi").FillWeight = 100
        dgvCheckin.Columns("harga_kamar").FillWeight = 90
        dgvCheckin.Columns("tgl_checkin").FillWeight = 80
        dgvCheckin.Columns("tgl_checkout").FillWeight = 80
        dgvCheckin.Columns("status").FillWeight = 75

        dgvCheckin.Columns("harga_kamar").DefaultCellStyle.Format = "N0"

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
        tglCheckinAktual = Convert.ToDateTime(row.Cells("tgl_checkin").Value)
        tglCheckoutRencana = Convert.ToDateTime(row.Cells("tgl_checkout").Value)

        txtIdReservasi.Text = selectedId.ToString()
        txtNamaTamu.Text = row.Cells("nama_tamu").Value.ToString() &
                              "  (NIK: " & row.Cells("nik").Value.ToString() & ")"
        txtKamar.Text = "No. " & row.Cells("nomor_kamar").Value.ToString()
        txtHarga.Text = "Rp " & hargaPerMalam.ToString("N0") & " / malam"
        txtTipe.Text = row.Cells("tipe_reservasi").Value.ToString()
        dtpTglCheckin.Value = tglCheckinAktual
        dtpTglCheckout.Value = tglCheckoutRencana

        HitungEstimasi()

        If status = "Checked-In" Then
            btnCheckIn.Enabled = False
            btnCheckIn.Text = "Sudah Check-In"
        ElseIf status = "Checked-Out" OrElse status = "Cancelled" Then
            btnCheckIn.Enabled = False
            btnCheckIn.Text = "Tidak Dapat Diproses"
        Else
            btnCheckIn.Enabled = True
            btnCheckIn.Text = "Proses Check-In"
        End If
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
            Dim total As Decimal = malam * hargaPerMalam
            txtEstimasi.Text = "Rp " & total.ToString("N0") & " (" & malam & " malam)"
            txtEstimasi.BackColor = System.Drawing.Color.FromArgb(209, 250, 229)
            txtEstimasi.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70)
        End If
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        If selectedId = -1 Then
            MsgBox("Pilih reservasi dari daftar.", MsgBoxStyle.Exclamation) : Exit Sub
        End If
        If dtpTglCheckout.Value.Date <= dtpTglCheckin.Value.Date Then
            MsgBox("Tanggal check-out harus setelah check-in.", MsgBoxStyle.Exclamation) : Exit Sub
        End If

        Dim malam As Integer = (dtpTglCheckout.Value.Date - dtpTglCheckin.Value.Date).Days
        Dim total As Decimal = malam * hargaPerMalam

        If MsgBox("Konfirmasi Check-In:" & vbNewLine &
                  "Tamu  : " & txtNamaTamu.Text & vbNewLine &
                  "Kamar : " & txtKamar.Text & vbNewLine &
                  "Malam : " & malam & " malam" & vbNewLine &
                  "Total : Rp " & total.ToString("N0") & vbNewLine & vbNewLine & "Lanjutkan?",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Konfirmasi") = MsgBoxResult.Yes Then

            For Each dr As DataRow In dtCheckin.Rows
                If Convert.ToInt32(dr("id_reservasi")) = selectedId Then
                    dr("tgl_checkin") = dtpTglCheckin.Value.Date
                    dr("tgl_checkout") = dtpTglCheckout.Value.Date
                    dr("status") = "Checked-In"
                    Exit For
                End If
            Next

            If ReservasiForm.IsSharedLoaded Then
                For Each dr As DataRow In ReservasiForm.dtReservasiShared.Rows
                    If Convert.ToInt32(dr("id_reservasi")) = selectedId Then
                        dr("tgl_checkin") = dtpTglCheckin.Value.Date
                        dr("tgl_checkout") = dtpTglCheckout.Value.Date
                        dr("status") = "Checked-In"
                        Exit For
                    End If
                Next
            End If

            MsgBox("Check-In berhasil!", MsgBoxStyle.Information, "Berhasil")
            LoadGrid() : ClearForm()
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