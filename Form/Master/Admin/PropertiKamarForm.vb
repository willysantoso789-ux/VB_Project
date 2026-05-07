Imports VB_PROJECT.HotelDBDataSetTableAdapters

Public Class PropertiKamarForm

    Private idProperti As Integer = -1
    Private namaProperti As String = ""

    Public Sub SetProperti(id As Integer, nama As String)
        idProperti = id
        namaProperti = nama
    End Sub

    Private Sub AssignPropertiForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtNamaProp.Text = namaProperti
        LoadKamarGrid()
    End Sub

    Private Sub LoadKamarGrid()
        dgvKamar.Rows.Clear()
        Dim dtKamar = New sp_GetAllKamarTableAdapter().GetData()

        For Each dr As System.Data.DataRow In dtKamar.Rows
            Dim idKamar As Integer = Convert.ToInt32(dr("id_kamar"))
            Dim isAssigned As Boolean = CheckIsAssigned(idKamar)

            Dim i As Integer = dgvKamar.Rows.Add()
            dgvKamar.Rows(i).Cells("colCek").Value = isAssigned
            dgvKamar.Rows(i).Cells("colIdKamar").Value = idKamar
            dgvKamar.Rows(i).Cells("colNoKamar").Value = dr("nomor_kamar")
            dgvKamar.Rows(i).Cells("colTipe").Value = dr("nama_tipe")
            dgvKamar.Rows(i).Cells("colStatus").Value = dr("status")
            dgvKamar.Rows(i).Cells("colKeterangan").Value = If(isAssigned, "✔ Sudah assign", "Belum assign")
            dgvKamar.Rows(i).Tag = idKamar

            If isAssigned Then
                dgvKamar.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 243, 255)
                dgvKamar.Rows(i).DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(91, 33, 182)
            End If
        Next
        UpdateSummary()
    End Sub

    Private Function CheckIsAssigned(idKamar As Integer) As Boolean
        Dim dt = New sp_GetPropertiByKamarTableAdapter().GetData(idKamar)
        For Each dr As System.Data.DataRow In dt.Rows
            If Convert.ToInt32(dr("id_properti")) = idProperti Then Return True
        Next
        Return False
    End Function

    Private Sub dgvKamar_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvKamar.CurrentCellDirtyStateChanged
        If dgvKamar.IsCurrentCellDirty Then
            dgvKamar.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvKamar_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKamar.CellValueChanged
        If e.ColumnIndex = dgvKamar.Columns("colCek").Index Then UpdateSummary()
    End Sub

    Private Sub UpdateSummary()
        Dim count As Integer = 0
        Dim list As New List(Of String)
        For Each row As DataGridViewRow In dgvKamar.Rows
            If Convert.ToBoolean(row.Cells("colCek").Value) Then
                count += 1
                list.Add("No." & row.Cells("colNoKamar").Value?.ToString())
            End If
        Next
        txtSummary.Text = If(count = 0, "0 kamar dipilih",
                             count & " kamar: " & String.Join(", ", list))
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim assigned As New List(Of String)
        Dim unassigned As New List(Of String)
        Dim errors As New List(Of String)

        For Each row As DataGridViewRow In dgvKamar.Rows
            Dim idKamar As Integer = Convert.ToInt32(row.Tag)
            Dim noKamar As String = row.Cells("colNoKamar").Value?.ToString()
            Dim isChecked As Boolean = Convert.ToBoolean(row.Cells("colCek").Value)
            Dim wasAssigned As Boolean = row.Cells("colKeterangan").Value?.ToString().StartsWith("✔")
            Dim qta As New QueriesTableAdapter()

            If isChecked AndAlso Not wasAssigned Then
                Try
                    ' sp_AssignPropertiKamar(@id_properti, @id_kamar)
                    qta.sp_AssignPropertiKamar(idProperti, idKamar)
                    assigned.Add("No." & noKamar)
                Catch ex As Exception
                    errors.Add("No." & noKamar & ": " & ex.Message)
                End Try
            ElseIf Not isChecked AndAlso wasAssigned Then
                Try
                    ' sp_UnassignPropertiKamar(@id_properti, @id_kamar)
                    qta.sp_UnassignPropertiKamar(idProperti, idKamar)
                    unassigned.Add("No." & noKamar)
                Catch ex As Exception
                    errors.Add("No." & noKamar & ": " & ex.Message)
                End Try
            End If
        Next

        Dim msg As String = "Selesai!" & vbNewLine
        If assigned.Count > 0 Then msg &= "✔ Assigned   : " & String.Join(", ", assigned) & vbNewLine
        If unassigned.Count > 0 Then msg &= "✖ Unassigned : " & String.Join(", ", unassigned) & vbNewLine
        If errors.Count > 0 Then msg &= "⚠ Error      : " & String.Join(vbNewLine, errors)
        If assigned.Count = 0 AndAlso unassigned.Count = 0 AndAlso errors.Count = 0 Then
            msg = "Tidak ada perubahan."
        End If

        MsgBox(msg, MsgBoxStyle.Information, "Hasil")
        LoadKamarGrid()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

End Class