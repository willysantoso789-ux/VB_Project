Imports System.Data

Public Class UnassignPropertiKamarForm

    Private idProperti As Integer = -1
    Private namaProperti As String = ""

    Private ReadOnly KamarData As New Dictionary(Of Integer, String()) From {
        {1, New String() {"101", "Standard"}},
        {2, New String() {"102", "Standard"}},
        {3, New String() {"201", "Deluxe"}},
        {4, New String() {"202", "Deluxe"}},
        {5, New String() {"301", "Suite"}}
    }

    Public Sub SetProperti(id As Integer, nama As String)
        idProperti = id
        namaProperti = nama
    End Sub

    Private Sub UnassignPropertiForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtNamaProp.Text = namaProperti
        LoadAssignedKamar()
    End Sub

    Private Sub LoadAssignedKamar()
        dgvUnassign.Rows.Clear()

        If Not PropertiKamarForm.IsAssignLoaded Then
            lblNote.Text = "Properti ini belum ter-assign ke kamar manapun."
            Return
        End If

        Dim found As Boolean = False
        For Each dr As DataRow In PropertiKamarForm.dtAssignment.Rows
            If Convert.ToInt32(dr("id_properti")) = idProperti Then
                Dim idKamar As Integer = Convert.ToInt32(dr("id_kamar"))
                Dim kondisi As String = dr("kondisi").ToString()
                Dim noKamar As String = If(KamarData.ContainsKey(idKamar), KamarData(idKamar)(0), "?")
                Dim tipe As String = If(KamarData.ContainsKey(idKamar), KamarData(idKamar)(1), "?")

                Dim i As Integer = dgvUnassign.Rows.Add()
                dgvUnassign.Rows(i).Cells("colCek").Value = False
                dgvUnassign.Rows(i).Cells("colIdKamar").Value = idKamar
                dgvUnassign.Rows(i).Cells("colNoKamar").Value = noKamar
                dgvUnassign.Rows(i).Cells("colTipe").Value = tipe
                dgvUnassign.Rows(i).Cells("colKondisi").Value = kondisi
                dgvUnassign.Rows(i).Tag = idKamar

                StyleKondisiCell(dgvUnassign.Rows(i), kondisi)
                found = True
            End If
        Next

        If Not found Then
            lblNote.Text = "Properti ini belum ter-assign ke kamar manapun."
            lblNote.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        End If
    End Sub

    Private Sub StyleKondisiCell(row As DataGridViewRow, kondisi As String)
        Select Case kondisi
            Case "Rusak"
                row.Cells("colKondisi").Style.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
                row.Cells("colKondisi").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            Case "Dalam Perbaikan"
                row.Cells("colKondisi").Style.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14)
                row.Cells("colKondisi").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            Case Else
                row.Cells("colKondisi").Style.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
        End Select
    End Sub

    Private Sub dgvUnassign_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvUnassign.CurrentCellDirtyStateChanged
        If dgvUnassign.IsCurrentCellDirty Then
            dgvUnassign.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvUnassign_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUnassign.CellValueChanged
        If e.ColumnIndex = dgvUnassign.Columns("colCek").Index AndAlso e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUnassign.Rows(e.RowIndex)
            If Convert.ToBoolean(row.Cells("colCek").Value) Then
                row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
            Else
                row.DefaultCellStyle.BackColor = System.Drawing.Color.White
            End If
        End If
    End Sub

    Private Sub btnUnassign_Click(sender As Object, e As EventArgs) Handles btnUnassign.Click
        Dim toUnassign As New List(Of Integer)
        Dim noKamarList As New List(Of String)

        For Each row As DataGridViewRow In dgvUnassign.Rows
            If Convert.ToBoolean(row.Cells("colCek").Value) Then
                toUnassign.Add(Convert.ToInt32(row.Tag))
                noKamarList.Add("No." & row.Cells("colNoKamar").Value.ToString())
            End If
        Next

        If toUnassign.Count = 0 Then
            MsgBox("Centang kamar yang ingin di-unassign.", MsgBoxStyle.Exclamation) : Return
        End If

        If MsgBox("Unassign " & namaProperti & " dari:" & vbNewLine &
                  String.Join(", ", noKamarList) & vbNewLine & vbNewLine &
                  "Properti akan dicopot dari kamar tersebut. Lanjutkan?",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Konfirmasi Unassign") = MsgBoxResult.Yes Then

            Dim toRemove As New List(Of DataRow)
            For Each dr As DataRow In PropertiKamarForm.dtAssignment.Rows
                If Convert.ToInt32(dr("id_properti")) = idProperti AndAlso
                   toUnassign.Contains(Convert.ToInt32(dr("id_kamar"))) Then
                    toRemove.Add(dr)
                End If
            Next
            For Each dr As DataRow In toRemove
                PropertiKamarForm.dtAssignment.Rows.Remove(dr)
            Next

            MsgBox("Unassign berhasil dari: " & String.Join(", ", noKamarList),
                   MsgBoxStyle.Information, "Berhasil")
            LoadAssignedKamar()
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

End Class