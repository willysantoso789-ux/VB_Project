Imports System.Data

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
        Try
            ' Ambil semua kamar dari DB
            Dim dtAllKamar As DataTable = Database.ExecuteQuery("sp_GetAllKamar", Nothing)

            ' Ambil kamar yang sudah ter-assign untuk properti ini
            Dim assignedIds As New HashSet(Of Integer)
            Try
                Dim dtAssigned As DataTable = Database.ExecuteQuery("sp_GetPropertiByKamar",
                    New Dictionary(Of String, Object) From {{"@id_kamar", -1}})
                ' Cara alternatif: cari dari semua kamar yang punya properti ini
            Catch
            End Try

            ' Cek assignment per kamar
            For Each dr As DataRow In dtAllKamar.Rows
                Dim idKamar As Integer = Convert.ToInt32(dr("id_kamar"))
                Dim isAssigned As Boolean = CheckIsAssigned(idKamar)
                Dim kondisi As String = If(isAssigned, GetKondisiAssigned(idKamar), "")

                Dim i As Integer = dgvKamar.Rows.Add()
                dgvKamar.Rows(i).Cells("colCek").Value = isAssigned
                dgvKamar.Rows(i).Cells("colIdKamar").Value = idKamar
                dgvKamar.Rows(i).Cells("colNoKamar").Value = dr("nomor_kamar").ToString()
                dgvKamar.Rows(i).Cells("colTipe").Value = dr("nama_tipe").ToString()
                dgvKamar.Rows(i).Cells("colStatus").Value = dr("status").ToString()
                dgvKamar.Rows(i).Cells("colKeterangan").Value = If(isAssigned,
                    "✔ Sudah assign (" & kondisi & ")", "Belum assign")
                dgvKamar.Rows(i).Tag = idKamar

                StyleRow(dgvKamar.Rows(i), isAssigned, kondisi)
            Next

            UpdateSummary()
        Catch ex As Exception
            MsgBox("Gagal load data kamar: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Function CheckIsAssigned(idKamar As Integer) As Boolean
        Try
            Dim dt As DataTable = Database.ExecuteQuery("sp_GetPropertiByKamar",
                New Dictionary(Of String, Object) From {{"@id_kamar", idKamar}})
            For Each dr As DataRow In dt.Rows
                If Convert.ToInt32(dr("id_properti")) = idProperti Then Return True
            Next
        Catch
        End Try
        Return False
    End Function

    Private Function GetKondisiAssigned(idKamar As Integer) As String
        Try
            Dim dt As DataTable = Database.ExecuteQuery("sp_GetPropertiByKamar",
                New Dictionary(Of String, Object) From {{"@id_kamar", idKamar}})
            For Each dr As DataRow In dt.Rows
                If Convert.ToInt32(dr("id_properti")) = idProperti Then
                    Return dr("kondisi").ToString()
                End If
            Next
        Catch
        End Try
        Return "Baik"
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
            UpdateSummary()
        End If
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
        Dim errors As New List(Of String)
        Dim assigned As New List(Of String)
        Dim unassigned As New List(Of String)

        For Each row As DataGridViewRow In dgvKamar.Rows
            Dim idKamar As Integer = Convert.ToInt32(row.Tag)
            Dim noKamar As String = row.Cells("colNoKamar").Value?.ToString()
            Dim isChecked As Boolean = Convert.ToBoolean(row.Cells("colCek").Value)
            Dim wasAssigned As Boolean = row.Cells("colKeterangan").Value?.ToString().StartsWith("✔")

            If isChecked AndAlso Not wasAssigned Then
                ' Assign baru
                Try
                    Database.ExecuteNonQuery("sp_AssignPropertiKamar",
                        New Dictionary(Of String, Object) From {
                            {"@id_properti", idProperti},
                            {"@id_kamar", idKamar}
                        })
                    assigned.Add("No." & noKamar)
                Catch ex As Exception
                    errors.Add("No." & noKamar & ": " & ex.Message)
                End Try
            ElseIf Not isChecked AndAlso wasAssigned Then
                ' Unassign
                Try
                    Database.ExecuteNonQuery("sp_UnassignPropertiKamar",
                        New Dictionary(Of String, Object) From {
                            {"@id_properti", idProperti},
                            {"@id_kamar", idKamar}
                        })
                    unassigned.Add("No." & noKamar)
                Catch ex As Exception
                    errors.Add("No." & noKamar & ": " & ex.Message)
                End Try
            End If
        Next

        Dim msg As String = "Selesai!" & vbNewLine
        If assigned.Count > 0 Then msg &= "✔ Assigned   : " & String.Join(", ", assigned) & vbNewLine
        If unassigned.Count > 0 Then msg &= "✖ Unassigned : " & String.Join(", ", unassigned) & vbNewLine
        If errors.Count > 0 Then msg &= "⚠ Error      : " & String.Join(", ", errors)
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