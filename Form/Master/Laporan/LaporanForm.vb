Imports System.Data
Imports System.IO

Public Class LaporanForm

    Private currentDt As New DataTable()
    Private currentJenis As String = ""

    Private Sub LaporanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDari.Value = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        dtpSampai.Value = DateTime.Today
        cboJenis.SelectedIndex = 0
    End Sub

    Private Sub cboJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboJenis.SelectedIndexChanged
        ' Auto-tampilkan saat pilih jenis
    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        If cboJenis.SelectedIndex = -1 Then
            MsgBox("Pilih jenis laporan.", MsgBoxStyle.Exclamation) : Return
        End If
        If dtpSampai.Value.Date < dtpDari.Value.Date Then
            MsgBox("Tanggal sampai tidak boleh sebelum tanggal dari.", MsgBoxStyle.Exclamation) : Return
        End If

        currentJenis = cboJenis.SelectedItem?.ToString()

        Select Case currentJenis
            Case "Laporan Reservasi" : TampilkanLaporan("sp_LaporanReservasi")
            Case "Laporan Check-In & Check-Out" : TampilkanLaporan("sp_LaporanCheckInCheckOut")
            Case "Laporan Pendapatan" : TampilkanLaporan("sp_LaporanPendapatan")
            Case "Laporan Denda" : TampilkanLaporan("sp_LaporanDenda")
            Case "Laporan Tamu" : TampilkanLaporanTanpaFilter("sp_LaporanTamu")
            Case "Laporan Kamar" : TampilkanLaporanTanpaFilter("sp_LaporanKamar")
        End Select
    End Sub

    Private Sub TampilkanLaporan(spName As String)
        Try
            Dim params As New Dictionary(Of String, Object) From {
                {"@tgl_dari", dtpDari.Value.Date},
                {"@tgl_sampai", dtpSampai.Value.Date}
            }
            currentDt = Database.ExecuteQuery(spName, params)
            dgvLaporan.DataSource = currentDt
            StyleGrid()
            UpdateInfo()
        Catch ex As Exception
            MsgBox("Gagal load laporan: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub TampilkanLaporanTanpaFilter(spName As String)
        Try
            currentDt = Database.ExecuteQuery(spName, Nothing)
            dgvLaporan.DataSource = currentDt
            StyleGrid()
            UpdateInfo()
        Catch ex As Exception
            MsgBox("Gagal load laporan: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub StyleGrid()
        If dgvLaporan.Columns.Count = 0 Then Exit Sub
        dgvLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvLaporan.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 74, 138)
        dgvLaporan.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        dgvLaporan.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        dgvLaporan.EnableHeadersVisualStyles = False

        ' Highlight baris yang ada denda
        For Each row As DataGridViewRow In dgvLaporan.Rows
            For Each col As DataGridViewColumn In dgvLaporan.Columns
                If col.Name.ToLower().Contains("denda") OrElse
                   col.Name.ToLower().Contains("telat") Then
                    Dim val As String = row.Cells(col.Name).Value?.ToString()
                    If val <> "0" AndAlso val <> "Rp 0" AndAlso val <> "" AndAlso val <> "—" Then
                        row.Cells(col.Name).Style.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
                        row.Cells(col.Name).Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub UpdateInfo()
        lblInfo.Text = currentJenis & "  |  " &
                       dtpDari.Value.ToString("dd/MM/yyyy") & " — " &
                       dtpSampai.Value.ToString("dd/MM/yyyy") &
                       "  |  " & currentDt.Rows.Count & " baris"
    End Sub

    '── Export CSV ─────────────────────────────────────────
    Private Sub btnExportCSV_Click(sender As Object, e As EventArgs) Handles btnExportCsv.Click
        If currentDt.Rows.Count = 0 Then
            MsgBox("Tidak ada data untuk diekspor.", MsgBoxStyle.Exclamation) : Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "CSV Files (*.csv)|*.csv"
            sfd.FileName = currentJenis.Replace(" ", "_") & "_" & DateTime.Today.ToString("yyyyMMdd")

            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Dim sb As New System.Text.StringBuilder()

                    ' Header
                    Dim cols As New List(Of String)
                    For Each col As DataColumn In currentDt.Columns
                        cols.Add("""" & col.ColumnName & """")
                    Next
                    sb.AppendLine(String.Join(",", cols))

                    ' Rows
                    For Each row As DataRow In currentDt.Rows
                        Dim vals As New List(Of String)
                        For Each item As Object In row.ItemArray
                            vals.Add("""" & item.ToString().Replace("""", """""") & """")
                        Next
                        sb.AppendLine(String.Join(",", vals))
                    Next

                    File.WriteAllText(sfd.FileName, sb.ToString(), System.Text.Encoding.UTF8)
                    MsgBox("CSV berhasil disimpan: " & sfd.FileName, MsgBoxStyle.Information, "Berhasil")
                Catch ex As Exception
                    MsgBox("Gagal export CSV: " & ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End Using
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If cboJenis.SelectedIndex >= 0 Then btnTampilkan_Click(Nothing, Nothing)
    End Sub

End Class