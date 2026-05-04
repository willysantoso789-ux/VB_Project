Imports System.Data

Public Class UnassignPropertiForm

    Private idProperti As Integer = -1
    Private namaProperti As String = ""

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
        Try
            ' Ambil semua kamar, cek mana yang punya properti ini
            Dim dtAllKamar As DataTable = Database.ExecuteQuery("sp_GetAllKamar", Nothing)
            Dim found As Boolean = False

            For Each drKamar As DataRow In dtAllKamar.Rows
                Dim idKamar As Integer = Convert.ToInt32(drKamar("id_kamar"))

                ' Cek apakah kamar ini punya properti yang dicari
                Dim dtProp As DataTable = Database.ExecuteQuery("sp_GetPropertiByKamar",
                    New Dictionary(Of String, Object) From {{"@id_kamar", idKamar}})

                For Each drProp As DataRow In dtProp.Rows
                    If Convert.ToInt32(drProp("id_properti")) = idProperti Then
                        ' Kamar ini ter-assign
                        Dim kondisi As String = drProp("kondisi").ToString()
                        Dim i As Integer = dgvUnassign.Rows.Add()
                        dgvUnassign.Rows(i).Cells("colCek").Value = False
                        dgvUnassign.Rows(i).Cells("colIdKamar").Value = idKamar
                        dgvUnassign.Rows(i).Cells("colNoKamar").Value = drKamar("nomor_kamar").ToString()
                        dgvUnassign.Rows(i).Cells("colTipe").Value = drKamar("nama_tipe").ToString()
                        dgvUnassign.Rows(i).Cells("colKondisi").Value = kondisi
                        dgvUnassign.Rows(i).Tag = idKamar

                        StyleKondisiCell(dgvUnassign.Rows(i), kondisi)
                        found = True
                        Exit For
                    End If
                Next
            Next

            If Not found Then
                lblNote.Text = "Properti ini belum ter-assign ke kamar manapun."
                lblNote.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
            End If

        Catch ex As Exception
            MsgBox("Gagal load data: " & ex.Message, MsgBoxStyle.Critical)
        End Try
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
                noKamarList.Add("No." & row.Cells("colNoKamar").Value?.ToString())
            End If
        Next

        If toUnassign.Count = 0 Then
            MsgBox("Centang kamar yang ingin di-unassign.", MsgBoxStyle.Exclamation) : Return
        End If

        If MsgBox("Unassign " & namaProperti & " dari:" & vbNewLine &
                  String.Join(", ", noKamarList) & vbNewLine & vbNewLine & "Lanjutkan?",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Konfirmasi") = MsgBoxResult.Yes Then

            Dim errors As New List(Of String)
            For Each idKamar As Integer In toUnassign
                Try
                    Database.ExecuteNonQuery("sp_UnassignPropertiKamar",
                        New Dictionary(Of String, Object) From {
                            {"@id_properti", idProperti},
                            {"@id_kamar", idKamar}
                        })
                Catch ex As Exception
                    errors.Add(ex.Message)
                End Try
            Next

            If errors.Count = 0 Then
                MsgBox("Unassign berhasil dari: " & String.Join(", ", noKamarList),
                       MsgBoxStyle.Information, "Berhasil")
            Else
                MsgBox("Sebagian gagal: " & String.Join(vbNewLine, errors),
                       MsgBoxStyle.Exclamation, "Error")
            End If

            LoadAssignedKamar()
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

End Class