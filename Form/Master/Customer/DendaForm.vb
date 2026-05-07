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

        For Each dr As System.Data.DataRow In dt.Rows
            Dim kondisiAwal As String = dr("kondisi").ToString()
            Dim i As Integer = dgvProperti.Rows.Add()
            dgvProperti.Rows(i).Cells("colCekRusak").Value = (kondisiAwal = "Rusak")
            dgvProperti.Rows(i).Cells("colNamaItem").Value = dr("nama_properti")
            dgvProperti.Rows(i).Cells("colBiayaDenda").Value = Convert.ToDecimal(dr("biaya_denda")).ToString("N0")
            dgvProperti.Rows(i).Cells("colKondisiAwal").Value = kondisiAwal
            dgvProperti.Rows(i).Tag = Convert.ToInt32(dr("id_properti"))

            If kondisiAwal = "Rusak" Then
                dgvProperti.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
                dgvProperti.Rows(i).DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
            End If
        Next
    End Sub

    Private Sub dgvProperti_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvProperti.CurrentCellDirtyStateChanged
        If dgvProperti.IsCurrentCellDirty Then
            dgvProperti.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvProperti_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProperti.CellValueChanged
        If e.ColumnIndex = dgvProperti.Columns("colCekRusak").Index Then HitungTotal()
    End Sub

    Private Sub HitungTotal()
        Dim totalKerusakan As Decimal = 0
        For Each row As DataGridViewRow In dgvProperti.Rows
            If Convert.ToBoolean(row.Cells("colCekRusak").Value) Then
                Dim biayaStr As String = row.Cells("colBiayaDenda").Value?.ToString().Replace(".", "").Replace(",", "")
                Dim biaya As Decimal = 0
                Decimal.TryParse(biayaStr, biaya)
                totalKerusakan += biaya
                row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
            Else
                row.DefaultCellStyle.BackColor = System.Drawing.Color.White
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
            End If
        Next

        TotalDendaKerusakan = totalKerusakan
        txtDendaTelat.Text = "Rp " & (hariTelat * dendaPerHari).ToString("N0") &
                                 If(hariTelat > 0, " (" & hariTelat & " hari)", " (Tepat waktu)")
        txtDendaKerusakan.Text = "Rp " & totalKerusakan.ToString("N0")
        txtTotalDenda.Text = "Rp " & (hariTelat * dendaPerHari + totalKerusakan).ToString("N0")
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        For Each row As DataGridViewRow In dgvProperti.Rows
            Dim idProp As Integer = Convert.ToInt32(row.Tag)
            Dim isRusak As Boolean = Convert.ToBoolean(row.Cells("colCekRusak").Value)
            Dim kondisiLama As String = row.Cells("colKondisiAwal").Value?.ToString()
            Dim kondisiBaru As String = If(isRusak, "Rusak", kondisiLama)
            Dim qta As New QueriesTableAdapter()

            If kondisiBaru <> kondisiLama Then
                Try
                    ' sp_UpdateKondisiProperti(@id_properti, @id_kamar, @kondisi)
                    qta.sp_UpdateKondisiProperti(idProp, idKamar, kondisiBaru)
                Catch
                End Try
            End If
        Next

        MsgBox("Data kerusakan disimpan. Total: Rp " & TotalDendaKerusakan.ToString("N0"),
               MsgBoxStyle.Information, "Berhasil")
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

End Class