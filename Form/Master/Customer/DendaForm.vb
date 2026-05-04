Imports System.Data

Public Class DendaForm

    Private idReservasi As Integer = -1
    Private idKamar As Integer = -1
    Private hariTelat As Integer = 0
    Private dendaPerHari As Decimal = 0
    Private dendaExisting As Decimal = 0
    Public TotalDendaKerusakan As Decimal = 0

    Public Sub SetData(idRes As Integer, namaTamu As String, kamar As String,
                       idKamarVal As Integer, hariTelatVal As Integer,
                       dendaPerHariVal As Decimal, existingKerusakan As Decimal)
        idReservasi = idRes
        idKamar = idKamarVal
        hariTelat = hariTelatVal
        dendaPerHari = dendaPerHariVal
        dendaExisting = existingKerusakan
        TotalDendaKerusakan = existingKerusakan
    End Sub

    Private Sub DendaForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadPropertiGrid()
        HitungTotal()
    End Sub

    Private Sub LoadPropertiGrid()
        dgvProperti.Rows.Clear()

        If idKamar = -1 Then
            lblNote.Text = "ID kamar tidak valid." : Return
        End If

        Try
            Dim params As New Dictionary(Of String, Object) From {{"@id_kamar", idKamar}}
            Dim dt As DataTable = Database.ExecuteQuery("sp_GetPropertiByKamar", params)

            If dt.Rows.Count = 0 Then
                lblNote.Text = "Tidak ada properti yang ter-assign ke kamar ini."
                lblNote.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
                Return
            End If

            lblNote.Text = "Centang properti yang rusak untuk menghitung denda kerusakan"
            lblNote.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)

            For Each dr As DataRow In dt.Rows
                Dim kondisiSaatIni As String = dr("kondisi").ToString()
                Dim isRusak As Boolean = (kondisiSaatIni = "Rusak")
                Dim biaya As Decimal = Convert.ToDecimal(dr("biaya_denda"))

                Dim i As Integer = dgvProperti.Rows.Add()
                dgvProperti.Rows(i).Cells("colCekRusak").Value = isRusak
                dgvProperti.Rows(i).Cells("colNamaItem").Value = dr("nama_properti").ToString()
                dgvProperti.Rows(i).Cells("colBiayaDenda").Value = biaya.ToString("N0")
                dgvProperti.Rows(i).Cells("colKondisiAwal").Value = kondisiSaatIni
                dgvProperti.Rows(i).Tag = Convert.ToInt32(dr("id_properti"))

                If isRusak Then
                    dgvProperti.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
                    dgvProperti.Rows(i).DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
                End If
            Next

        Catch ex As Exception
            MsgBox("Gagal load properti kamar: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub dgvProperti_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvProperti.CurrentCellDirtyStateChanged
        If dgvProperti.IsCurrentCellDirty Then
            dgvProperti.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvProperti_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProperti.CellValueChanged
        If e.ColumnIndex = dgvProperti.Columns("colCekRusak").Index Then
            HitungTotal()
        End If
    End Sub

    Private Sub HitungTotal()
        Dim totalKerusakan As Decimal = 0

        For Each row As DataGridViewRow In dgvProperti.Rows
            Dim isChecked As Boolean = Convert.ToBoolean(row.Cells("colCekRusak").Value)
            If isChecked Then
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
        ' Update kondisi properti yang dicentang rusak ke DB
        Dim updated As New List(Of String)

        For Each row As DataGridViewRow In dgvProperti.Rows
            Dim isChecked As Boolean = Convert.ToBoolean(row.Cells("colCekRusak").Value)
            Dim idProp As Integer = Convert.ToInt32(row.Tag)
            Dim nama As String = row.Cells("colNamaItem").Value?.ToString()
            Dim kondisiLama As String = row.Cells("colKondisiAwal").Value?.ToString()
            Dim kondisiBaru As String = If(isChecked, "Rusak", kondisiLama)

            ' Hanya update kalau ada perubahan
            If kondisiBaru <> kondisiLama Then
                Try
                    Database.ExecuteNonQuery("sp_UpdateKondisiProperti",
                        New Dictionary(Of String, Object) From {
                            {"@id_properti", idProp},
                            {"@id_kamar", idKamar},
                            {"@kondisi", kondisiBaru}
                        })
                    updated.Add(nama & " → " & kondisiBaru)
                Catch ex As Exception
                    ' Tidak stop, lanjut saja
                End Try
            End If
        Next

        MsgBox("Data kerusakan disimpan." &
               If(updated.Count > 0, vbNewLine & String.Join(vbNewLine, updated), ""),
               MsgBoxStyle.Information, "Berhasil")
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

End Class