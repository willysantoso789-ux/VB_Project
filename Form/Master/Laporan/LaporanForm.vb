Imports VB_PROJECT.HotelDBDataSetTableAdapters
Imports System.IO

Public Class LaporanForm

    Private currentDt As System.Data.DataTable = Nothing
    Private currentJenis As String = ""

    Private Sub LaporanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDari.Value = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        dtpSampai.Value = DateTime.Today
        cboJenis.SelectedIndex = 0
    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        If cboJenis.SelectedIndex = -1 Then
            MsgBox("Pilih jenis laporan.", MsgBoxStyle.Exclamation) : Return
        End If
        If dtpSampai.Value.Date < dtpDari.Value.Date Then
            MsgBox("Tanggal tidak valid.", MsgBoxStyle.Exclamation) : Return
        End If

        currentJenis = cboJenis.SelectedItem?.ToString()
        Try
            Select Case currentJenis
                Case "Laporan Reservasi"
                    currentDt = New sp_LaporanReservasiTableAdapter().GetData(
                        dtpDari.Value.Date, dtpSampai.Value.Date)
                Case "Laporan Check-In & Check-Out"
                    currentDt = New sp_LaporanCheckInCheckOutTableAdapter().GetData(
                        dtpDari.Value.Date, dtpSampai.Value.Date)
                Case "Laporan Pendapatan"
                    currentDt = New sp_LaporanPendapatanTableAdapter().GetData(
                        dtpDari.Value.Date, dtpSampai.Value.Date)
                Case "Laporan Denda"
                    currentDt = New sp_LaporanDendaTableAdapter().GetData(
                        dtpDari.Value.Date, dtpSampai.Value.Date)
                Case "Laporan Tamu"
                    currentDt = New sp_LaporanTamuTableAdapter().GetData(Nothing, Nothing)
                Case "Laporan Kamar"
                    currentDt = New sp_LaporanKamarTableAdapter().GetData(Nothing, Nothing)
            End Select

            dgvLaporan.DataSource = currentDt
            lblInfo.Text = currentJenis & "  |  " &
                           dtpDari.Value.ToString("dd/MM/yyyy") & " — " &
                           dtpSampai.Value.ToString("dd/MM/yyyy") &
                           "  |  " & If(currentDt IsNot Nothing, currentDt.Rows.Count, 0) & " baris"
        Catch ex As Exception
            MsgBox("Gagal load laporan: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ' ── Export CSV ─────────────────────────────────────────
    Private Sub btnExportCSV_Click(sender As Object, e As EventArgs) Handles btnExportCSV.Click
        If currentDt Is Nothing OrElse currentDt.Rows.Count = 0 Then
            MsgBox("Tidak ada data. Tampilkan laporan dulu.", MsgBoxStyle.Exclamation) : Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "CSV Files (*.csv)|*.csv"
            sfd.FileName = currentJenis.Replace(" ", "_") & "_" & DateTime.Today.ToString("yyyyMMdd")
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Dim sb As New System.Text.StringBuilder()
                    Dim cols As New List(Of String)
                    For Each col As System.Data.DataColumn In currentDt.Columns
                        cols.Add("""" & col.ColumnName & """")
                    Next
                    sb.AppendLine(String.Join(",", cols))
                    For Each row As System.Data.DataRow In currentDt.Rows
                        Dim vals As New List(Of String)
                        For Each item As Object In row.ItemArray
                            vals.Add("""" & item.ToString().Replace("""", """""") & """")
                        Next
                        sb.AppendLine(String.Join(",", vals))
                    Next
                    File.WriteAllText(sfd.FileName, sb.ToString(), System.Text.Encoding.UTF8)
                    MsgBox("CSV berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")
                Catch ex As Exception
                    MsgBox("Gagal export CSV: " & ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End Using
    End Sub

    ' ── Export PDF ─────────────────────────────────────────
    Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnExportPDF.Click
        If currentDt Is Nothing OrElse currentDt.Rows.Count = 0 Then
            MsgBox("Tidak ada data. Tampilkan laporan dulu.", MsgBoxStyle.Exclamation) : Return
        End If

        Try
            Dim tmpHtml As String = Path.Combine(
                Path.GetTempPath(),
                "hotel_laporan_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".html")

            File.WriteAllText(tmpHtml, BuildHtmlLaporan(), System.Text.Encoding.UTF8)

            ' Buka di browser default — user gunakan Ctrl+P → Save as PDF
            Dim psi As New ProcessStartInfo()
            psi.FileName = tmpHtml
            psi.UseShellExecute = True
            Process.Start(psi)

            MsgBox("Laporan telah dibuka di browser." & vbNewLine &
                   "Gunakan Ctrl+P lalu pilih 'Save as PDF' atau 'Microsoft Print to PDF'.",
                   MsgBoxStyle.Information, "Export PDF")
        Catch ex As Exception
            MsgBox("Gagal export PDF: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Function BuildHtmlLaporan() As String
        Dim sb As New System.Text.StringBuilder()

        sb.AppendLine("<!DOCTYPE html>")
        sb.AppendLine("<html><head><meta charset='utf-8'>")
        sb.AppendLine("<title>" & currentJenis & "</title>")
        sb.AppendLine("<style>")
        sb.AppendLine("  * { box-sizing: border-box; margin: 0; padding: 0; }")
        sb.AppendLine("  body { font-family: 'Segoe UI', Arial, sans-serif; font-size: 11px; padding: 24px; color: #222; }")
        sb.AppendLine("  .header { border-bottom: 3px solid #2d4a8a; padding-bottom: 10px; margin-bottom: 14px; }")
        sb.AppendLine("  .header h1 { font-size: 18px; color: #2d4a8a; }")
        sb.AppendLine("  .header .meta { font-size: 10px; color: #666; margin-top: 4px; }")
        sb.AppendLine("  table { border-collapse: collapse; width: 100%; margin-top: 8px; }")
        sb.AppendLine("  th { background: #2d4a8a; color: white; padding: 6px 8px; text-align: left; font-size: 10px; white-space: nowrap; }")
        sb.AppendLine("  td { padding: 5px 8px; border-bottom: 1px solid #e8e8e8; font-size: 10px; }")
        sb.AppendLine("  tr:nth-child(even) td { background: #edf2ff; }")
        sb.AppendLine("  tr:hover td { background: #dbe6ff; }")
        sb.AppendLine("  .footer { margin-top: 20px; font-size: 9px; color: #999; text-align: right; border-top: 1px solid #e0e0e0; padding-top: 8px; }")
        sb.AppendLine("  .badge-rusak { color: #991b1b; font-weight: bold; }")
        sb.AppendLine("  .badge-ok { color: #166534; }")
        sb.AppendLine("  @media print { body { padding: 0; } .no-print { display: none; } }")
        sb.AppendLine("</style></head><body>")

        ' Header laporan
        sb.AppendLine("<div class='header'>")
        sb.AppendLine("  <h1>" & HtmlEncode(currentJenis) & "</h1>")
        sb.AppendLine("  <div class='meta'>")
        sb.AppendLine("    Periode: <b>" & dtpDari.Value.ToString("dd/MM/yyyy") &
                      " — " & dtpSampai.Value.ToString("dd/MM/yyyy") & "</b>")
        sb.AppendLine("    &nbsp;|&nbsp; Jumlah data: <b>" & currentDt.Rows.Count & " baris</b>")
        sb.AppendLine("    &nbsp;|&nbsp; Dicetak oleh: <b>" & HtmlEncode(MainForm.ActiveUser) & "</b>")
        sb.AppendLine("    &nbsp;|&nbsp; " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"))
        sb.AppendLine("  </div>")
        sb.AppendLine("</div>")

        ' Tabel
        sb.AppendLine("<table>")
        sb.Append("<thead><tr>")
        For Each col As System.Data.DataColumn In currentDt.Columns
            sb.Append("<th>" & HtmlEncode(col.ColumnName) & "</th>")
        Next
        sb.AppendLine("</tr></thead>")
        sb.AppendLine("<tbody>")

        For Each row As System.Data.DataRow In currentDt.Rows
            sb.Append("<tr>")
            For i As Integer = 0 To currentDt.Columns.Count - 1
                Dim val As String = row(i)?.ToString()
                Dim colName As String = currentDt.Columns(i).ColumnName.ToLower()
                Dim cssClass As String = ""

                ' Highlight kolom tertentu
                If colName.Contains("rusak") OrElse colName.Contains("denda") Then
                    If val <> "0" AndAlso val <> "Rp 0" AndAlso val <> "" Then
                        cssClass = " class='badge-rusak'"
                    End If
                End If

                sb.Append("<td" & cssClass & ">" & HtmlEncode(val) & "</td>")
            Next
            sb.AppendLine("</tr>")
        Next

        sb.AppendLine("</tbody></table>")
        sb.AppendLine("<div class='footer'>Hotel Receptionist System &mdash; " &
                      HtmlEncode(currentJenis) & " &mdash; " &
                      DateTime.Now.ToString("dd/MM/yyyy HH:mm") & "</div>")
        sb.AppendLine("</body></html>")

        Return sb.ToString()
    End Function

    ' ── Helper HtmlEncode tanpa System.Web ─────────────────
    Private Function HtmlEncode(text As String) As String
        If String.IsNullOrEmpty(text) Then Return ""
        Return text.Replace("&", "&amp;") _
                   .Replace("<", "&lt;") _
                   .Replace(">", "&gt;") _
                   .Replace("""", "&quot;") _
                   .Replace("'", "&#39;")
    End Function

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If cboJenis.SelectedIndex >= 0 Then btnTampilkan_Click(Nothing, Nothing)
    End Sub

End Class