Imports System.Data

Public Class PropertiKamarForm

    ' Shared members used by other forms to check and access assignments
    Public Shared IsAssignLoaded As Boolean = False
    Public Shared dtAssignment As DataTable = CreateDefaultAssignmentTable()

    Private Shared Function CreateDefaultAssignmentTable() As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("id_properti", GetType(Integer))
        dt.Columns.Add("id_kamar", GetType(Integer))
        dt.Columns.Add("kondisi", GetType(String))
        Return dt
    End Function

    Private idProperti As Integer = -1
    Private namaProperti As String = ""

    Private ReadOnly KamarList As New List(Of Object()) From {
        New Object() {1, "101", "Standard", "Tersedia"},
        New Object() {2, "102", "Standard", "Terisi"},
        New Object() {3, "201", "Deluxe", "Tersedia"},
        New Object() {4, "202", "Deluxe", "Maintenance"},
        New Object() {5, "301", "Suite", "Tersedia"}
    }

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

        For Each k As Object() In KamarList
            Dim idKamar As Integer = Convert.ToInt32(k(0))
            Dim sudahAssign As Boolean = IsAssigned(idKamar)
            Dim kondisi As String = GetKondisi(idKamar)

            Dim i As Integer = dgvKamar.Rows.Add()
            dgvKamar.Rows(i).Cells("colCek").Value = sudahAssign
            dgvKamar.Rows(i).Cells("colIdKamar").Value = idKamar
            dgvKamar.Rows(i).Cells("colNoKamar").Value = k(1).ToString()
            dgvKamar.Rows(i).Cells("colTipe").Value = k(2).ToString()
            dgvKamar.Rows(i).Cells("colStatus").Value = k(3).ToString()
            dgvKamar.Rows(i).Cells("colSudahAssign").Value = If(sudahAssign, "✔ Sudah assign (" & kondisi & ")", "Belum assign")
            dgvKamar.Rows(i).Tag = idKamar

            StyleRow(dgvKamar.Rows(i), sudahAssign, kondisi)
        Next

        UpdateSummary()
    End Sub

    Private Function IsAssigned(idKamar As Integer) As Boolean
        If Not PropertiKamarForm.IsAssignLoaded Then Return False
        For Each dr As DataRow In PropertiKamarForm.dtAssignment.Rows
            If Convert.ToInt32(dr("id_properti")) = idProperti AndAlso
               Convert.ToInt32(dr("id_kamar")) = idKamar Then Return True
        Next
        Return False
    End Function

    Private Function GetKondisi(idKamar As Integer) As String
        If Not PropertiKamarForm.IsAssignLoaded Then Return ""
        For Each dr As DataRow In PropertiKamarForm.dtAssignment.Rows
            If Convert.ToInt32(dr("id_properti")) = idProperti AndAlso
               Convert.ToInt32(dr("id_kamar")) = idKamar Then
                Return dr("kondisi").ToString()
            End If
        Next
        Return ""
    End Function

    Private Sub StyleRow(row As DataGridViewRow, isAssigned As Boolean, kondisi As String)
        If isAssigned Then
            Select Case kondisi
                Case "Rusak"
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
                Case "Dalam Perbaikan"
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(254, 243, 199)
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14)
                Case Else
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 243, 255)
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(91, 33, 182)
            End Select
        Else
            row.DefaultCellStyle.BackColor = System.Drawing.Color.White
            row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
        End If
    End Sub

    Private Sub dgvKamar_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvKamar.CurrentCellDirtyStateChanged
        If dgvKamar.IsCurrentCellDirty Then
            dgvKamar.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvKamar_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKamar.CellValueChanged
        If e.ColumnIndex = dgvKamar.Columns("colCek").Index AndAlso e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvKamar.Rows(e.RowIndex)
            Dim isChecked As Boolean = Convert.ToBoolean(row.Cells("colCek").Value)
            StyleRow(row, isChecked, If(isChecked, "Baik", ""))
            UpdateSummary()
        End If
    End Sub

    Private Sub UpdateSummary()
        Dim count As Integer = 0
        Dim list As New List(Of String)
        For Each row As DataGridViewRow In dgvKamar.Rows
            If Convert.ToBoolean(row.Cells("colCek").Value) Then
                count += 1
                list.Add("No." & row.Cells("colNoKamar").Value.ToString())
            End If
        Next
        txtSummary.Text = If(count = 0, "0 kamar dipilih",
                             count & " kamar: " & String.Join(", ", list))
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Hapus semua assignment lama untuk properti ini
        Dim toRemove As New List(Of DataRow)
        For Each dr As DataRow In PropertiKamarForm.dtAssignment.Rows
            If Convert.ToInt32(dr("id_properti")) = idProperti Then toRemove.Add(dr)
        Next
        For Each dr As DataRow In toRemove
            PropertiKamarForm.dtAssignment.Rows.Remove(dr)
        Next

        ' Tambah assignment baru yang dicentang
        Dim assigned As New List(Of String)
        Dim unassigned As New List(Of String)

        For Each row As DataGridViewRow In dgvKamar.Rows
            Dim idKamar As Integer = Convert.ToInt32(row.Tag)
            Dim noKamar As String = row.Cells("colNoKamar").Value.ToString()
            Dim isChecked As Boolean = Convert.ToBoolean(row.Cells("colCek").Value)

            If isChecked Then
                PropertiKamarForm.dtAssignment.Rows.Add(idProperti, idKamar, "Baik")
                assigned.Add("No." & noKamar)
            Else
                unassigned.Add("No." & noKamar)
            End If
        Next

        Dim msg As String = "Assignment berhasil disimpan!" & vbNewLine
        If assigned.Count > 0 Then msg &= "✔ Assigned   : " & String.Join(", ", assigned) & vbNewLine
        If unassigned.Count > 0 Then msg &= "✖ Unassigned : " & String.Join(", ", unassigned)

        MsgBox(msg, MsgBoxStyle.Information, "Berhasil")
        LoadKamarGrid()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

End Class