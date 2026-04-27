Imports System.Data
Imports System.IO
Imports System.Text

Public Class LaporanForm

    Private currentDt As New DataTable()
    Private currentJenis As String = ""

    Private Sub LaporanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboJenis.SelectedIndex = 0
    End Sub

    ' ── Tampilkan laporan ─────────────────────────────────
    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        If cboJenis.SelectedIndex = -1 Then
            MsgBox("Pilih jenis laporan terlebih dahulu.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If dtpSampai.Value.Date < dtpDari.Value.Date Then
            MsgBox("Tanggal sampai tidak boleh sebelum tanggal dari.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        currentJenis = cboJenis.SelectedItem.ToString()

        Select Case currentJenis
            Case "Laporan Reservasi"
                TampilkanLaporanReservasi()
            Case "Laporan Check-In & Check-Out"
                TampilkanLaporanCheckinCheckout()
            Case "Laporan Pendapatan"
                TampilkanLaporanPendapatan()
            Case "Laporan Denda"
                TampilkanLaporanDenda()
            Case "Laporan Tamu"
                TampilkanLaporanTamu()
            Case "Laporan Kamar"
                TampilkanLaporanKamar()
        End Select

        btnExportPdf.Enabled = (currentDt.Rows.Count > 0)
        btnExportCsv.Enabled = (currentDt.Rows.Count > 0)
    End Sub

    ' ════════════════════════════════════════════════════
    ' 1. LAPORAN RESERVASI
    ' ════════════════════════════════════════════════════
    Private Sub TampilkanLaporanReservasi()
        currentDt = New DataTable()
        currentDt.Columns.Add("ID Reservasi", GetType(Integer))
        currentDt.Columns.Add("Nama Tamu", GetType(String))
        currentDt.Columns.Add("No. Kamar", GetType(String))
        currentDt.Columns.Add("Tipe Reservasi", GetType(String))
        currentDt.Columns.Add("Tgl Reservasi", GetType(String))
        currentDt.Columns.Add("Tgl Check-In", GetType(String))
        currentDt.Columns.Add("Tgl Check-Out", GetType(String))
        currentDt.Columns.Add("Harga/Malam", GetType(Decimal))
        currentDt.Columns.Add("Status", GetType(String))

        If ReservasiForm.IsSharedLoaded Then
            For Each dr As DataRow In ReservasiForm.dtReservasiShared.Rows
                Dim tgl As DateTime = Convert.ToDateTime(dr("tgl_reservasi"))
                If tgl.Date >= dtpDari.Value.Date AndAlso tgl.Date <= dtpSampai.Value.Date Then
                    currentDt.Rows.Add(
                        dr("id_reservasi"),
                        dr("nama_tamu"),
                        dr("nomor_kamar"),
                        dr("tipe_reservasi"),
                        tgl.ToString("dd/MM/yyyy"),
                        Convert.ToDateTime(dr("tgl_checkin")).ToString("dd/MM/yyyy"),
                        Convert.ToDateTime(dr("tgl_checkout")).ToString("dd/MM/yyyy"),
                        dr("harga_kamar"),
                        dr("status")
                    )
                End If
            Next
        Else
            ' Dummy data
            currentDt.Rows.Add(1, "Budi Santoso", "101", "Walk-in", DateTime.Today.ToString("dd/MM/yyyy"), DateTime.Today.ToString("dd/MM/yyyy"), DateTime.Today.AddDays(2).ToString("dd/MM/yyyy"), 350000D, "Confirmed")
            currentDt.Rows.Add(2, "Siti Rahayu", "201", "Online/Contact", DateTime.Today.ToString("dd/MM/yyyy"), DateTime.Today.AddDays(3).ToString("dd/MM/yyyy"), DateTime.Today.AddDays(5).ToString("dd/MM/yyyy"), 600000D, "Pending")
            currentDt.Rows.Add(3, "Agus Prasetyo", "301", "Online/Contact", DateTime.Today.ToString("dd/MM/yyyy"), DateTime.Today.AddDays(1).ToString("dd/MM/yyyy"), DateTime.Today.AddDays(4).ToString("dd/MM/yyyy"), 1200000D, "Checked-In")
        End If

        ' Summary
        Dim total = currentDt.Rows.Count
        Dim confirmed = currentDt.Select("Status = 'Confirmed'").Length
        Dim checkedIn = currentDt.Select("Status = 'Checked-In'").Length
        Dim cancelled = currentDt.Select("Status = 'Cancelled'").Length

        SetSummary("Total Reservasi", total.ToString(),
                   "Confirmed", confirmed.ToString(),
                   "Checked-In", checkedIn.ToString(),
                   "Dibatalkan", cancelled.ToString())

        SetGrid(currentDt, "Laporan Reservasi",
                "Periode: " & dtpDari.Value.ToString("dd/MM/yyyy") & " — " & dtpSampai.Value.ToString("dd/MM/yyyy"))
        StyleStatusColumn("Status")
    End Sub

    ' ════════════════════════════════════════════════════
    ' 2. LAPORAN CHECK-IN & CHECK-OUT
    ' ════════════════════════════════════════════════════
    Private Sub TampilkanLaporanCheckinCheckout()
        currentDt = New DataTable()
        currentDt.Columns.Add("ID Reservasi", GetType(Integer))
        currentDt.Columns.Add("Nama Tamu", GetType(String))
        currentDt.Columns.Add("No. Kamar", GetType(String))
        currentDt.Columns.Add("Tgl Check-In", GetType(String))
        currentDt.Columns.Add("Tgl Check-Out", GetType(String))
        currentDt.Columns.Add("Durasi (malam)", GetType(Integer))
        currentDt.Columns.Add("Harga/Malam", GetType(Decimal))
        currentDt.Columns.Add("Subtotal", GetType(Decimal))
        currentDt.Columns.Add("Status", GetType(String))

        If ReservasiForm.IsSharedLoaded Then
            For Each dr As DataRow In ReservasiForm.dtReservasiShared.Rows
                Dim tglCI As DateTime = Convert.ToDateTime(dr("tgl_checkin"))
                Dim tglCO As DateTime = Convert.ToDateTime(dr("tgl_checkout"))
                Dim status As String = dr("status").ToString()

                If (status = "Checked-In" OrElse status = "Checked-Out") AndAlso
                   tglCI.Date >= dtpDari.Value.Date AndAlso
                   tglCI.Date <= dtpSampai.Value.Date Then

                    Dim malam As Integer = (tglCO.Date - tglCI.Date).Days
                    Dim harga As Decimal = Convert.ToDecimal(dr("harga_kamar"))
                    Dim subtotal As Decimal = malam * harga

                    currentDt.Rows.Add(
                        dr("id_reservasi"),
                        dr("nama_tamu"),
                        dr("nomor_kamar"),
                        tglCI.ToString("dd/MM/yyyy"),
                        tglCO.ToString("dd/MM/yyyy"),
                        malam,
                        harga,
                        subtotal,
                        status
                    )
                End If
            Next
        Else
            currentDt.Rows.Add(1, "Budi Santoso", "101", DateTime.Today.AddDays(-2).ToString("dd/MM/yyyy"), DateTime.Today.ToString("dd/MM/yyyy"), 2, 350000D, 700000D, "Checked-Out")
            currentDt.Rows.Add(3, "Agus Prasetyo", "301", DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy"), DateTime.Today.AddDays(3).ToString("dd/MM/yyyy"), 4, 1200000D, 4800000D, "Checked-In")
        End If

        Dim totalMalam As Integer = 0
        Dim totalPendapatan As Decimal = 0
        For Each dr As DataRow In currentDt.Rows
            totalMalam += Convert.ToInt32(dr("Durasi (malam)"))
            totalPendapatan += Convert.ToDecimal(dr("Subtotal"))
        Next

        SetSummary("Total Transaksi", currentDt.Rows.Count.ToString(),
                   "Total Malam", totalMalam.ToString(),
                   "Total Pendapatan", "Rp " & totalPendapatan.ToString("N0"),
                   "Checked-Out", currentDt.Select("Status = 'Checked-Out'").Length.ToString())

        SetGrid(currentDt, "Laporan Check-In & Check-Out",
                "Periode: " & dtpDari.Value.ToString("dd/MM/yyyy") & " — " & dtpSampai.Value.ToString("dd/MM/yyyy"))

        If dgvLaporan.Columns.Contains("Harga/Malam") Then
            dgvLaporan.Columns("Harga/Malam").DefaultCellStyle.Format = "N0"
        End If
        If dgvLaporan.Columns.Contains("Subtotal") Then
            dgvLaporan.Columns("Subtotal").DefaultCellStyle.Format = "N0"
        End If
        StyleStatusColumn("Status")
    End Sub

    ' ════════════════════════════════════════════════════
    ' 3. LAPORAN PENDAPATAN
    ' ════════════════════════════════════════════════════
    Private Sub TampilkanLaporanPendapatan()
        currentDt = New DataTable()
        currentDt.Columns.Add("ID Reservasi", GetType(Integer))
        currentDt.Columns.Add("Nama Tamu", GetType(String))
        currentDt.Columns.Add("No. Kamar", GetType(String))
        currentDt.Columns.Add("Tgl Check-In", GetType(String))
        currentDt.Columns.Add("Tgl Check-Out", GetType(String))
        currentDt.Columns.Add("Durasi", GetType(String))
        currentDt.Columns.Add("Harga/Malam", GetType(String))
        currentDt.Columns.Add("Biaya Kamar", GetType(String))
        currentDt.Columns.Add("Denda Telat", GetType(String))
        currentDt.Columns.Add("Denda Rusak", GetType(String))
        currentDt.Columns.Add("Total Bayar", GetType(String))
        currentDt.Columns.Add("Keterangan", GetType(String))

        Dim totalBiaya As Decimal = 0
        Dim totalDenda As Decimal = 0
        Dim totalBayar As Decimal = 0
        Dim jumlahTrans As Integer = 0

        If ReservasiForm.IsSharedLoaded Then
            For Each dr As DataRow In ReservasiForm.dtReservasiShared.Rows
                If dr("status").ToString() = "Checked-Out" Then
                    Dim tglCI As DateTime = Convert.ToDateTime(dr("tgl_checkin"))
                    Dim tglCO As DateTime = Convert.ToDateTime(dr("tgl_checkout"))
                    Dim harga As Decimal = Convert.ToDecimal(dr("harga_kamar"))
                    Dim malam As Integer = (tglCO - tglCI).Days
                    Dim biaya As Decimal = malam * harga
                    Dim dTelat As Decimal = 0
                    Dim dRusak As Decimal = 0
                    Dim keterangan As String = "Normal"

                    If tglCO > Convert.ToDateTime(dr("tgl_checkout")) Then
                        Dim telat = (tglCO - Convert.ToDateTime(dr("tgl_checkout"))).Days
                        dTelat = telat * harga * 0.5D
                        keterangan = "Terlambat " & telat & " hari"
                    End If

                    Dim total = biaya + dTelat + dRusak
                    totalBiaya += biaya
                    totalDenda += dTelat + dRusak
                    totalBayar += total
                    jumlahTrans += 1

                    ' Hanya tampilkan yang dalam periode filter
                    If tglCI.Date >= dtpDari.Value.Date AndAlso tglCI.Date <= dtpSampai.Value.Date Then
                        currentDt.Rows.Add(
                        dr("id_reservasi"),
                        dr("nama_tamu"),
                        dr("nomor_kamar"),
                        tglCI.ToString("dd/MM/yyyy"),
                        tglCO.ToString("dd/MM/yyyy"),
                        malam & " malam",
                        "Rp " & harga.ToString("N0"),
                        "Rp " & biaya.ToString("N0"),
                        If(dTelat > 0, "Rp " & dTelat.ToString("N0"), "—"),
                        If(dRusak > 0, "Rp " & dRusak.ToString("N0"), "—"),
                        "Rp " & total.ToString("N0"),
                        keterangan
                    )
                    End If
                End If
            Next
        End If

        ' Kalau tidak ada data dari shared, pakai contoh meaningful
        If currentDt.Rows.Count = 0 Then
            currentDt.Rows.Add(1, "Budi Santoso", "101",
            DateTime.Today.AddDays(-4).ToString("dd/MM/yyyy"),
            DateTime.Today.AddDays(-2).ToString("dd/MM/yyyy"),
            "2 malam", "Rp 350.000", "Rp 700.000", "—", "—", "Rp 700.000", "Normal")
            currentDt.Rows.Add(3, "Agus Prasetyo", "301",
            DateTime.Today.AddDays(-5).ToString("dd/MM/yyyy"),
            DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy"),
            "4 malam", "Rp 1.200.000", "Rp 4.800.000",
            "Rp 1.200.000", "Rp 500.000", "Rp 6.500.000", "Terlambat 2 hari + kerusakan")
            totalBiaya = 5500000D
            totalDenda = 1700000D
            totalBayar = 7200000D
            jumlahTrans = 2
        End If

        SetSummary(
        "Jumlah Transaksi", jumlahTrans.ToString() & " transaksi",
        "Total Biaya Kamar", "Rp " & totalBiaya.ToString("N0"),
        "Total Denda", "Rp " & totalDenda.ToString("N0"),
        "Total Pendapatan", "Rp " & totalBayar.ToString("N0"))

        SetGrid(currentDt, "Laporan Pendapatan",
            "Periode: " & dtpDari.Value.ToString("dd/MM/yyyy") &
            " — " & dtpSampai.Value.ToString("dd/MM/yyyy"))

        ' Highlight baris yang ada denda
        For Each row As DataGridViewRow In dgvLaporan.Rows
            Dim ket As String = row.Cells("Keterangan").Value?.ToString()
            If ket <> "Normal" AndAlso ket <> "" Then
                row.Cells("Keterangan").Style.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
                row.Cells("Keterangan").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            End If
        Next
    End Sub

    ' ════════════════════════════════════════════════════
    ' 4. LAPORAN DENDA
    ' ════════════════════════════════════════════════════
    Private Sub TampilkanLaporanDenda()
        currentDt = New DataTable()
        currentDt.Columns.Add("ID Reservasi", GetType(Integer))
        currentDt.Columns.Add("Nama Tamu", GetType(String))
        currentDt.Columns.Add("No. Kamar", GetType(String))
        currentDt.Columns.Add("Tgl Checkout Plan", GetType(String))
        currentDt.Columns.Add("Tgl Checkout Aktual", GetType(String))
        currentDt.Columns.Add("Hari Terlambat", GetType(Integer))
        currentDt.Columns.Add("Denda Keterlambatan", GetType(Decimal))
        currentDt.Columns.Add("Denda Kerusakan", GetType(Decimal))
        currentDt.Columns.Add("Total Denda", GetType(Decimal))

        ' Dummy — nanti dari tabel transaksi + denda DB
        currentDt.Rows.Add(3, "Agus Prasetyo", "301",
                            DateTime.Today.AddDays(3).ToString("dd/MM/yyyy"),
                            DateTime.Today.AddDays(5).ToString("dd/MM/yyyy"),
                            2, 1200000D, 500000D, 1700000D)

        Dim totalDendaTelat As Decimal = 0
        Dim totalDendaKerusakan As Decimal = 0
        Dim totalDenda As Decimal = 0
        For Each dr As DataRow In currentDt.Rows
            totalDendaTelat += Convert.ToDecimal(dr("Denda Keterlambatan"))
            totalDendaKerusakan += Convert.ToDecimal(dr("Denda Kerusakan"))
            totalDenda += Convert.ToDecimal(dr("Total Denda"))
        Next

        SetSummary("Kasus Denda", currentDt.Rows.Count.ToString(),
                   "Denda Keterlambatan", "Rp " & totalDendaTelat.ToString("N0"),
                   "Denda Kerusakan", "Rp " & totalDendaKerusakan.ToString("N0"),
                   "Total Denda", "Rp " & totalDenda.ToString("N0"))

        SetGrid(currentDt, "Laporan Denda",
                "Periode: " & dtpDari.Value.ToString("dd/MM/yyyy") & " — " & dtpSampai.Value.ToString("dd/MM/yyyy"))

        For Each col As String In {"Denda Keterlambatan", "Denda Kerusakan", "Total Denda"}
            If dgvLaporan.Columns.Contains(col) Then
                dgvLaporan.Columns(col).DefaultCellStyle.Format = "N0"
                dgvLaporan.Columns(col).DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
            End If
        Next
    End Sub

    ' ════════════════════════════════════════════════════
    ' 5. LAPORAN TAMU
    ' ════════════════════════════════════════════════════
    Private Sub TampilkanLaporanTamu()
        currentDt = New DataTable()
        currentDt.Columns.Add("ID Tamu", GetType(Integer))
        currentDt.Columns.Add("Nama", GetType(String))
        currentDt.Columns.Add("Email", GetType(String))
        currentDt.Columns.Add("No. HP", GetType(String))
        currentDt.Columns.Add("Gender", GetType(String))
        currentDt.Columns.Add("Alamat", GetType(String))
        currentDt.Columns.Add("Jml Menginap", GetType(Integer))

        ' Dummy — nanti dari DataTamuForm + join reservasi
        currentDt.Rows.Add(1, "Budi Santoso", "budi@email.com", "08123456789", "Laki-laki", "Jakarta", 3)
        currentDt.Rows.Add(2, "Siti Rahayu", "siti@email.com", "08234567890", "Perempuan", "Bandung", 1)
        currentDt.Rows.Add(3, "Agus Prasetyo", "agus@email.com", "08345678901", "Laki-laki", "Surabaya", 2)
        currentDt.Rows.Add(4, "Dewi Lestari", "dewi@email.com", "08456789012", "Perempuan", "Medan", 0)

        Dim totalTamu As Integer = currentDt.Rows.Count
        Dim lakiLaki As Integer = currentDt.Select("Gender = 'Laki-laki'").Length
        Dim perempuan As Integer = currentDt.Select("Gender = 'Perempuan'").Length
        Dim totalMenginap As Integer = 0
        For Each dr As DataRow In currentDt.Rows
            totalMenginap += Convert.ToInt32(dr("Jml Menginap"))
        Next

        SetSummary("Total Tamu", totalTamu.ToString(),
                   "Laki-laki", lakiLaki.ToString(),
                   "Perempuan", perempuan.ToString(),
                   "Total Menginap", totalMenginap.ToString() & "x")

        SetGrid(currentDt, "Laporan Tamu",
                "Data per: " & DateTime.Today.ToString("dd/MM/yyyy"))

        For Each row As DataGridViewRow In dgvLaporan.Rows
            Dim gender As String = row.Cells("Gender").Value?.ToString()
            If gender = "Laki-laki" Then
                row.Cells("Gender").Style.ForeColor = System.Drawing.Color.FromArgb(26, 86, 219)
                row.Cells("Gender").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            ElseIf gender = "Perempuan" Then
                row.Cells("Gender").Style.ForeColor = System.Drawing.Color.FromArgb(157, 23, 77)
                row.Cells("Gender").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            End If
        Next
    End Sub

    ' ════════════════════════════════════════════════════
    ' 6. LAPORAN KAMAR
    ' ════════════════════════════════════════════════════
    Private Sub TampilkanLaporanKamar()
        currentDt = New DataTable()
        currentDt.Columns.Add("ID Kamar", GetType(Integer))
        currentDt.Columns.Add("No. Kamar", GetType(String))
        currentDt.Columns.Add("Tipe", GetType(String))
        currentDt.Columns.Add("Harga/Malam", GetType(Decimal))
        currentDt.Columns.Add("Status", GetType(String))
        currentDt.Columns.Add("Jml Dipesan", GetType(Integer))
        currentDt.Columns.Add("Total Malam", GetType(Integer))
        currentDt.Columns.Add("Pendapatan", GetType(Decimal))

        ' Dummy — nanti dari DataKamarForm + join reservasi
        currentDt.Rows.Add(1, "101", "Standard", 350000D, "Tersedia", 5, 12, 4200000D)
        currentDt.Rows.Add(2, "102", "Standard", 350000D, "Terisi", 3, 7, 2450000D)
        currentDt.Rows.Add(3, "201", "Deluxe", 600000D, "Tersedia", 4, 9, 5400000D)
        currentDt.Rows.Add(4, "202", "Deluxe", 600000D, "Maintenance", 2, 4, 2400000D)
        currentDt.Rows.Add(5, "301", "Suite", 1200000D, "Tersedia", 6, 18, 21600000D)

        Dim totalKamar As Integer = currentDt.Rows.Count
        Dim tersedia As Integer = currentDt.Select("Status = 'Tersedia'").Length
        Dim totalPendapatan As Decimal = 0
        For Each dr As DataRow In currentDt.Rows
            totalPendapatan += Convert.ToDecimal(dr("Pendapatan"))
        Next

        SetSummary("Total Kamar", totalKamar.ToString(),
                   "Tersedia", tersedia.ToString(),
                   "Terisi", currentDt.Select("Status = 'Terisi'").Length.ToString(),
                   "Total Pendapatan", "Rp " & totalPendapatan.ToString("N0"))

        SetGrid(currentDt, "Laporan Kamar",
                "Data per: " & DateTime.Today.ToString("dd/MM/yyyy"))

        If dgvLaporan.Columns.Contains("Harga/Malam") Then
            dgvLaporan.Columns("Harga/Malam").DefaultCellStyle.Format = "N0"
        End If
        If dgvLaporan.Columns.Contains("Pendapatan") Then
            dgvLaporan.Columns("Pendapatan").DefaultCellStyle.Format = "N0"
        End If
        StyleStatusColumn("Status")
    End Sub

    ' ════════════════════════════════════════════════════
    ' HELPERS
    ' ════════════════════════════════════════════════════
    Private Sub SetSummary(t1 As String, v1 As String,
                            t2 As String, v2 As String,
                            t3 As String, v3 As String,
                            t4 As String, v4 As String)
        lblSum1Title.Text = t1 : lblSum1Val.Text = v1
        lblSum2Title.Text = t2 : lblSum2Val.Text = v2
        lblSum3Title.Text = t3 : lblSum3Val.Text = v3
        lblSum4Title.Text = t4 : lblSum4Val.Text = v4
    End Sub

    Private Sub SetGrid(dt As DataTable, title As String, sub_ As String)
        dgvLaporan.DataSource = dt
        lblGridTitle.Text = title
        lblGridSub.Text = sub_ & "  —  " & dt.Rows.Count & " data"
    End Sub

    Private Sub StyleStatusColumn(colName As String)
        If Not dgvLaporan.Columns.Contains(colName) Then Exit Sub
        For Each row As DataGridViewRow In dgvLaporan.Rows
            Dim st As String = row.Cells(colName).Value?.ToString()
            Select Case st
                Case "Confirmed", "Tersedia"
                    row.Cells(colName).Style.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
                    row.Cells(colName).Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Pending"
                    row.Cells(colName).Style.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14)
                    row.Cells(colName).Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Checked-In", "Terisi"
                    row.Cells(colName).Style.ForeColor = System.Drawing.Color.FromArgb(26, 86, 219)
                    row.Cells(colName).Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Checked-Out"
                    row.Cells(colName).Style.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
                    row.Cells(colName).Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Cancelled", "Maintenance"
                    row.Cells(colName).Style.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
                    row.Cells(colName).Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            End Select
        Next
    End Sub

    ' ════════════════════════════════════════════════════
    ' EXPORT CSV
    ' ════════════════════════════════════════════════════
    Private Sub btnExportCsv_Click(sender As Object, e As EventArgs) Handles btnExportCsv.Click
        If currentDt.Rows.Count = 0 Then Exit Sub

        Using sfd As New SaveFileDialog()
            sfd.Filter = "CSV Files (*.csv)|*.csv"
            sfd.FileName = currentJenis.Replace(" ", "_") & "_" &
                           DateTime.Today.ToString("yyyyMMdd") & ".csv"

            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Dim sb As New StringBuilder()

                    ' Header
                    Dim headers As New List(Of String)
                    For Each col As DataColumn In currentDt.Columns
                        headers.Add("""" & col.ColumnName & """")
                    Next
                    sb.AppendLine(String.Join(",", headers))

                    ' Rows
                    For Each row As DataRow In currentDt.Rows
                        Dim fields As New List(Of String)
                        For Each item As Object In row.ItemArray
                            fields.Add("""" & item.ToString().Replace("""", """""") & """")
                        Next
                        sb.AppendLine(String.Join(",", fields))
                    Next

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8)
                    MsgBox("CSV berhasil disimpan!" & vbNewLine & sfd.FileName,
                           MsgBoxStyle.Information, "Export Berhasil")

                Catch ex As Exception
                    MsgBox("Gagal export CSV: " & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        End Using
    End Sub

    ' ════════════════════════════════════════════════════
    ' EXPORT PDF — menggunakan iTextSharp via NuGet
    ' ════════════════════════════════════════════════════
    Private Sub btnExportPdf_Click(sender As Object, e As EventArgs) Handles btnExportPdf.Click
        If currentDt.Rows.Count = 0 Then Exit Sub

        Using sfd As New SaveFileDialog()
            sfd.Filter = "PDF Files (*.pdf)|*.pdf"
            sfd.FileName = currentJenis.Replace(" ", "_") & "_" &
                           DateTime.Today.ToString("yyyyMMdd") & ".pdf"

            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    ExportToPdf(sfd.FileName)
                    MsgBox("PDF berhasil disimpan!" & vbNewLine & sfd.FileName,
                           MsgBoxStyle.Information, "Export Berhasil")
                Catch ex As Exception
                    MsgBox("Gagal export PDF: " & ex.Message & vbNewLine & vbNewLine &
                           "Pastikan package iTextSharp sudah diinstall via NuGet.",
                           MsgBoxStyle.Critical, "Error")
                End Try
            End If
        End Using
    End Sub

    Private Sub ExportToPdf(filePath As String)
        ' Requires NuGet: iTextSharp (Install-Package iTextSharp)
        Dim doc As New iTextSharp.text.Document(
            iTextSharp.text.PageSize.A4.Rotate(), 20, 20, 30, 20)

        Dim writer = iTextSharp.text.pdf.PdfWriter.GetInstance(
            doc, New FileStream(filePath, FileMode.Create))

        doc.Open()

        ' ── Fonts ──
        Dim fontTitle As New iTextSharp.text.Font(
            iTextSharp.text.Font.FontFamily.HELVETICA, 14,
            iTextSharp.text.Font.BOLD,
            New iTextSharp.text.BaseColor(45, 74, 138))

        Dim fontSub As New iTextSharp.text.Font(
            iTextSharp.text.Font.FontFamily.HELVETICA, 9,
            iTextSharp.text.Font.NORMAL,
            New iTextSharp.text.BaseColor(100, 100, 100))

        Dim fontHeader As New iTextSharp.text.Font(
            iTextSharp.text.Font.FontFamily.HELVETICA, 8,
            iTextSharp.text.Font.BOLD,
            New iTextSharp.text.BaseColor(255, 255, 255))

        Dim fontCell As New iTextSharp.text.Font(
            iTextSharp.text.Font.FontFamily.HELVETICA, 8,
            iTextSharp.text.Font.NORMAL,
            iTextSharp.text.BaseColor.BLACK)

        ' ── Title ──
        doc.Add(New iTextSharp.text.Paragraph("Hotel Receptionist System", fontTitle))
        doc.Add(New iTextSharp.text.Paragraph(currentJenis, fontTitle))
        doc.Add(New iTextSharp.text.Paragraph(
            "Periode: " & dtpDari.Value.ToString("dd/MM/yyyy") &
            " — " & dtpSampai.Value.ToString("dd/MM/yyyy") &
            "    Dicetak: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fontSub))
        doc.Add(New iTextSharp.text.Paragraph("User: " & MainForm.ActiveUser, fontSub))
        doc.Add(iTextSharp.text.Chunk.NEWLINE)

        ' ── Summary bar ──
        Dim sumTable As New iTextSharp.text.pdf.PdfPTable(4)
        sumTable.WidthPercentage = 100
        sumTable.SpacingAfter = 10

        Dim sumItems() As String = {
            lblSum1Title.Text, lblSum1Val.Text,
            lblSum2Title.Text, lblSum2Val.Text,
            lblSum3Title.Text, lblSum3Val.Text,
            lblSum4Title.Text, lblSum4Val.Text
        }

        Dim bgSum As New iTextSharp.text.BaseColor(235, 238, 245)
        Dim fontSumTitle As New iTextSharp.text.Font(
            iTextSharp.text.Font.FontFamily.HELVETICA, 7,
            iTextSharp.text.Font.NORMAL,
            New iTextSharp.text.BaseColor(100, 100, 100))
        Dim fontSumVal As New iTextSharp.text.Font(
            iTextSharp.text.Font.FontFamily.HELVETICA, 11,
            iTextSharp.text.Font.BOLD,
            New iTextSharp.text.BaseColor(45, 74, 138))

        For i As Integer = 0 To 3
            Dim cell As New iTextSharp.text.pdf.PdfPCell()
            cell.BackgroundColor = bgSum
            cell.Padding = 8
            cell.Border = iTextSharp.text.Rectangle.NO_BORDER

            Dim p As New iTextSharp.text.Phrase()
            p.Add(New iTextSharp.text.Chunk(sumItems(i * 2) & vbLf, fontSumTitle))
            p.Add(New iTextSharp.text.Chunk(sumItems(i * 2 + 1), fontSumVal))
            cell.AddElement(New iTextSharp.text.Paragraph(p))
            sumTable.AddCell(cell)
        Next
        doc.Add(sumTable)

        ' ── Data table ──
        Dim colCount As Integer = currentDt.Columns.Count
        Dim pdfTable As New iTextSharp.text.pdf.PdfPTable(colCount)
        pdfTable.WidthPercentage = 100

        Dim headerBg As New iTextSharp.text.BaseColor(45, 74, 138)

        ' Header row
        For Each col As DataColumn In currentDt.Columns
            Dim cell As New iTextSharp.text.pdf.PdfPCell(
                New iTextSharp.text.Phrase(col.ColumnName, fontHeader))
            cell.BackgroundColor = headerBg
            cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER
            cell.Padding = 6
            pdfTable.AddCell(cell)
        Next

        ' Data rows
        Dim altBg As New iTextSharp.text.BaseColor(235, 238, 245)
        Dim rowIdx As Integer = 0
        For Each dr As DataRow In currentDt.Rows
            Dim bg = If(rowIdx Mod 2 = 0,
                        iTextSharp.text.BaseColor.WHITE,
                        altBg)
            For Each item As Object In dr.ItemArray
                Dim cell As New iTextSharp.text.pdf.PdfPCell(
                    New iTextSharp.text.Phrase(item.ToString(), fontCell))
                cell.BackgroundColor = bg
                cell.Padding = 5
                pdfTable.AddCell(cell)
            Next
            rowIdx += 1
        Next

        doc.Add(pdfTable)

        ' ── Footer ──
        doc.Add(iTextSharp.text.Chunk.NEWLINE)
        doc.Add(New iTextSharp.text.Paragraph(
            "— Dokumen ini dibuat otomatis oleh sistem —",
            New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 7,
                                     iTextSharp.text.Font.ITALIC,
                                     New iTextSharp.text.BaseColor(150, 150, 150))))

        doc.Close()
    End Sub

End Class