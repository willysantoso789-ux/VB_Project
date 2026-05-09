Imports VB_PROJECT.HotelDBDataSetTableAdapters

Public Class DendaForm

    Private idReservasi As Integer = -1
    Private idKamar As Integer = -1
    Private hariTelat As Integer = 0
    Private dendaPerHari As Decimal = 0
    Public TotalDendaKerusakan As Decimal = 0

    Public Sub SetData(idRes As Integer, namaTamu As String, kamar As String,
                       idKamarVal As Integer, hariTelatVal As Integer,
                       dendaPerHariVal As Decimal, existingKerusakan As Decimal)
        idReservasi = idRes
        idKamar = idKamarVal
        hariTelat = hariTelatVal
        dendaPerHari = dendaPerHariVal
        TotalDendaKerusakan = existingKerusakan
    End Sub

    Private Sub DendaForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadPropertiGrid()
        HitungTotal()
    End Sub

    Private Sub LoadPropertiGrid()
        dgvProperti.Rows.Clear()

        Dim dt = New sp_GetPropertiByKamarTableAdapter().GetData(idKamar)

        ' ── Hanya tampilkan yang kondisinya "Baik" ────────
        Dim adaData As Boolean = False
        For Each dr As System.Data.DataRow In dt.Rows
            Dim kondisiStr As String = dr("kondisi").ToString()

            ' Skip kondisi Rusak dan Dalam Perbaikan
            ' (tidak ditampilkan agar tidak terjadi kesalahan perhitungan)
            If kondisiStr <> "Baik" Then Continue For

            adaData = True
            Dim i As Integer = dgvProperti.Rows.Add()
            dgvProperti.Rows(i).Cells("colCekRusak").Value = False
            dgvProperti.Rows(i).Cells("colNamaItem").Value = dr("nama_properti")
            dgvProperti.Rows(i).Cells("colBiayaDenda").Value = Convert.ToDecimal(dr("biaya_denda")).ToString("N0")
            dgvProperti.Rows(i).Cells("colKondisiAwal").Value = kondisiStr
            dgvProperti.Rows(i).Tag = Convert.ToInt32(dr("id_properti"))

            dgvProperti.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.White
            dgvProperti.Rows(i).DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        Next

        If Not adaData Then
            lblNote.Text = "Tidak ada properti dengan kondisi 'Baik' di kamar ini."
            lblNote.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Else
            lblNote.Text = "Centang properti yang ditemukan rusak saat check-out."
            lblNote.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub dgvProperti_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvProperti.CurrentCellDirtyStateChanged
        If dgvProperti.IsCurrentCellDirty Then
            dgvProperti.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvProperti_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProperti.CellValueChanged
        If e.ColumnIndex <> dgvProperti.Columns("colCekRusak").Index Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub

        ' Semua baris di sini kondisi Baik — user bebas centang/uncentang
        Dim row As DataGridViewRow = dgvProperti.Rows(e.RowIndex)
        Dim isChecked As Boolean = Convert.ToBoolean(row.Cells("colCekRusak").Value)

        If isChecked Then
            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
            row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Else
            row.DefaultCellStyle.BackColor = System.Drawing.Color.White
            row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        End If

        HitungTotal()
    End Sub

    Private Sub HitungTotal()
        Dim totalKerusakan As Decimal = 0

        For Each row As DataGridViewRow In dgvProperti.Rows
            If Convert.ToBoolean(row.Cells("colCekRusak").Value) Then
                Dim biaya As Decimal = ParseBiaya(row.Cells("colBiayaDenda").Value?.ToString())
                totalKerusakan += biaya
            End If
        Next

        TotalDendaKerusakan = totalKerusakan
        txtDendaTelat.Text = "Rp " & (hariTelat * dendaPerHari).ToString("N0") &
                                 If(hariTelat > 0,
                                    " (" & hariTelat & " hari × " &
                                    AppSettingsManager.PersenDenda & "% harga kamar)",
                                    " (Tepat waktu)")
        txtDendaKerusakan.Text = "Rp " & totalKerusakan.ToString("N0")
        txtTotalDenda.Text = "Rp " & (hariTelat * dendaPerHari + totalKerusakan).ToString("N0")

        If totalKerusakan > 0 Then
            txtDendaKerusakan.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
            txtDendaKerusakan.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Else
            txtDendaKerusakan.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
            txtDendaKerusakan.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        End If

        Dim grandTotal As Decimal = hariTelat * dendaPerHari + totalKerusakan
        If grandTotal > 0 Then
            txtTotalDenda.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
            txtTotalDenda.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Else
            txtTotalDenda.BackColor = System.Drawing.Color.FromArgb(209, 250, 229)
            txtTotalDenda.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
        End If
    End Sub

    ' ── Dipanggil CheckOutForm setelah sp_ProsesCheckOut berhasil ──
    Public Sub UpdateKondisiRusakKeDB()
        For Each row As DataGridViewRow In dgvProperti.Rows
            Dim idProp As Integer = Convert.ToInt32(row.Tag)
            Dim isChecked As Boolean = Convert.ToBoolean(row.Cells("colCekRusak").Value)

            ' Semua baris kondisi Baik — update ke Rusak hanya yang dicentang
            If isChecked Then
                Try
                    Dim qta As New QueriesTableAdapter()
                    qta.sp_UpdateKondisiProperti(idProp, idKamar, "Rusak")
                Catch
                End Try
            End If
        Next
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("Ringkasan Denda Kerusakan:")
        sb.AppendLine("")

        Dim ada As Boolean = False
        For Each row As DataGridViewRow In dgvProperti.Rows
            If Convert.ToBoolean(row.Cells("colCekRusak").Value) Then
                sb.AppendLine("✖ " & row.Cells("colNamaItem").Value?.ToString() &
                              " — Rp " & ParseBiaya(row.Cells("colBiayaDenda").Value?.ToString()).ToString("N0"))
                ada = True
            End If
        Next

        If Not ada Then sb.AppendLine("(Tidak ada properti yang dilaporkan rusak)")

        sb.AppendLine("")
        sb.AppendLine("Total Denda Kerusakan : Rp " & TotalDendaKerusakan.ToString("N0"))
        sb.AppendLine("Kondisi properti akan diupdate ke DB saat proses checkout.")

        MsgBox(sb.ToString(), MsgBoxStyle.Information, "Info Denda Kerusakan")
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        TotalDendaKerusakan = 0
        Me.Close()
    End Sub

    Private Function ParseBiaya(val As String) As Decimal
        If String.IsNullOrEmpty(val) Then Return 0
        Dim result As Decimal = 0
        Decimal.TryParse(val.Replace(".", "").Replace(",", "").Trim(), result)
        Return result
    End Function

End Class