Imports System.Data

Public Class KondisiPropertiForm

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

    Private Sub AdjustKondisiForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtNamaProp.Text = namaProperti
        LoadGrid()
    End Sub

    Private Sub LoadGrid()
        dgvAdjust.Rows.Clear()

        If Not PropertiKamarForm.IsAssignLoaded Then
            lblNote.Text = "Properti belum ter-assign ke kamar manapun."
            Return
        End If

        Dim found As Boolean = False
        For Each dr As DataRow In PropertiKamarForm.dtAssignment.Rows
            If Convert.ToInt32(dr("id_properti")) = idProperti Then
                Dim idKamar As Integer = Convert.ToInt32(dr("id_kamar"))
                Dim kondisi As String = dr("kondisi").ToString()
                Dim noKamar As String = If(KamarData.ContainsKey(idKamar), KamarData(idKamar)(0), "?")
                Dim tipe As String = If(KamarData.ContainsKey(idKamar), KamarData(idKamar)(1), "?")

                Dim i As Integer = dgvAdjust.Rows.Add()
                dgvAdjust.Rows(i).Cells("colIdKamar").Value = idKamar
                dgvAdjust.Rows(i).Cells("colNoKamar").Value = noKamar
                dgvAdjust.Rows(i).Cells("colTipe").Value = tipe
                dgvAdjust.Rows(i).Cells("colKondisi").Value = kondisi
                dgvAdjust.Rows(i).Tag = idKamar

                StyleRow(dgvAdjust.Rows(i), kondisi)
                found = True
            End If
        Next

        If Not found Then
            lblNote.Text = "Properti ini tidak ter-assign ke kamar manapun."
        End If
    End Sub

    Private Sub StyleRow(row As DataGridViewRow, kondisi As String)
        Select Case kondisi
            Case "Rusak"
                row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
            Case "Dalam Perbaikan"
                row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(254, 243, 199)
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14)
            Case Else
                row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(209, 250, 229)
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
        End Select
    End Sub

    Private Sub dgvAdjust_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvAdjust.CurrentCellDirtyStateChanged
        If dgvAdjust.IsCurrentCellDirty Then
            dgvAdjust.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvAdjust_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdjust.CellValueChanged
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex = dgvAdjust.Columns("colKondisi").Index Then
            Dim row As DataGridViewRow = dgvAdjust.Rows(e.RowIndex)
            Dim kondisi As String = row.Cells("colKondisi").Value?.ToString()
            If Not String.IsNullOrEmpty(kondisi) Then
                StyleRow(row, kondisi)
            End If
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        dgvAdjust.EndEdit()

        Dim hasil As New List(Of String)

        For Each row As DataGridViewRow In dgvAdjust.Rows
            Dim idKamar As Integer = Convert.ToInt32(row.Tag)
            Dim kondisi As String = row.Cells("colKondisi").Value?.ToString()
            Dim noKamar As String = row.Cells("colNoKamar").Value.ToString()

            If String.IsNullOrEmpty(kondisi) Then kondisi = "Baik"

            ' Update di dtAssignment
            For Each dr As DataRow In PropertiKamarForm.dtAssignment.Rows
                If Convert.ToInt32(dr("id_properti")) = idProperti AndAlso
                   Convert.ToInt32(dr("id_kamar")) = idKamar Then
                    dr("kondisi") = kondisi
                    Exit For
                End If
            Next

            hasil.Add("No." & noKamar & " → " & kondisi)
        Next

        MsgBox("Kondisi berhasil disimpan!" & vbNewLine & String.Join(vbNewLine, hasil),
               MsgBoxStyle.Information, "Berhasil")
        LoadGrid()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

End Class