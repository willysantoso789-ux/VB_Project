Imports System.Data

'Public Class KondisiPropertiForm

'    Private idKamar As Integer = -1
'    Private nomorKamar As String = ""

'    Public Sub SetKamar(id As Integer, nomor As String)
'        idKamar = id
'        nomorKamar = nomor
'    End Sub

'    Private Sub KondisiPropertiKamarForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
'        lblTitle.Text = "Kondisi Properti — Kamar No. " & nomorKamar
'        lblSubTitle.Text = "Ubah kondisi properti yang ter-assign di kamar No. " & nomorKamar
'        LoadGrid()
'    End Sub

'    Private Sub LoadGrid()
'        dgvKondisi.Rows.Clear()

'        If idKamar = -1 Then
'            lblNote.Text = "Kamar tidak valid." : Return
'        End If

'        Try
'            Dim params As New Dictionary(Of String, Object) From {{"@id_kamar", idKamar}}
'            Dim dt As DataTable = Database.ExecuteQuery("sp_GetPropertiByKamar", params)

'            If dt.Rows.Count = 0 Then
'                lblNote.Text = "Tidak ada properti yang ter-assign ke kamar ini."
'                lblNote.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
'                Return
'            End If

'            lblNote.Text = "Klik dropdown kolom Kondisi untuk mengubah status"
'            lblNote.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)

'            For Each dr As DataRow In dt.Rows
'                Dim i As Integer = dgvKondisi.Rows.Add()
'                dgvKondisi.Rows(i).Cells("colIdProperti").Value = Convert.ToInt32(dr("id_properti"))
'                dgvKondisi.Rows(i).Cells("colNamaProperti").Value = dr("nama_properti").ToString()
'                dgvKondisi.Rows(i).Cells("colBiayaDenda").Value = Convert.ToDecimal(dr("biaya_denda")).ToString("N0")
'                dgvKondisi.Rows(i).Cells("colKondisi").Value = dr("kondisi").ToString()
'                dgvKondisi.Rows(i).Tag = Convert.ToInt32(dr("id_properti"))
'                StyleRow(dgvKondisi.Rows(i), dr("kondisi").ToString())
'            Next

'        Catch ex As Exception
'            MsgBox("Gagal load properti kamar: " & ex.Message, MsgBoxStyle.Critical)
'        End Try
'    End Sub

'    Private Sub StyleRow(row As DataGridViewRow, kondisi As String)
'        Select Case kondisi
'            Case "Rusak"
'                row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
'                row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
'            Case "Dalam Perbaikan"
'                row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(254, 243, 199)
'                row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14)
'            Case Else
'                row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(209, 250, 229)
'                row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
'        End Select
'    End Sub

'    Private Sub dgvKondisi_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvKondisi.CurrentCellDirtyStateChanged
'        If dgvKondisi.IsCurrentCellDirty Then
'            dgvKondisi.CommitEdit(DataGridViewDataErrorContexts.Commit)
'        End If
'    End Sub

'    Private Sub dgvKondisi_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKondisi.CellValueChanged
'        If e.RowIndex < 0 Then Exit Sub
'        If e.ColumnIndex = dgvKondisi.Columns("colKondisi").Index Then
'            Dim kondisi As String = dgvKondisi.Rows(e.RowIndex).Cells("colKondisi").Value?.ToString()
'            If Not String.IsNullOrEmpty(kondisi) Then
'                StyleRow(dgvKondisi.Rows(e.RowIndex), kondisi)
'            End If
'        End If
'    End Sub

'    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
'        dgvKondisi.EndEdit()
'        If dgvKondisi.Rows.Count = 0 Then
'            MsgBox("Tidak ada properti untuk disimpan.", MsgBoxStyle.Exclamation) : Return
'        End If

'        Dim hasil As New List(Of String)
'        Dim errorCount As Integer = 0

'        For Each row As DataGridViewRow In dgvKondisi.Rows
'            Dim idProp As Integer = Convert.ToInt32(row.Tag)
'            Dim kondisi As String = row.Cells("colKondisi").Value?.ToString()
'            Dim nama As String = row.Cells("colNamaProperti").Value?.ToString()
'            If String.IsNullOrEmpty(kondisi) Then kondisi = "Baik"

'            Try
'                Database.ExecuteNonQuery("sp_UpdateKondisiProperti",
'                    New Dictionary(Of String, Object) From {
'                        {"@id_properti", idProp},
'                        {"@id_kamar", idKamar},
'                        {"@kondisi", kondisi}
'                    })
'                hasil.Add(nama & " → " & kondisi)
'            Catch ex As Exception
'                errorCount += 1
'                hasil.Add("[GAGAL] " & nama & ": " & ex.Message)
'            End Try
'        Next

'        Dim icon As MsgBoxStyle = If(errorCount = 0, MsgBoxStyle.Information, MsgBoxStyle.Exclamation)
'        MsgBox(If(errorCount = 0, "Semua kondisi berhasil disimpan!", errorCount & " item gagal.") &
'               vbNewLine & String.Join(vbNewLine, hasil), icon, "Hasil")

'        LoadGrid()
'    End Sub

'    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
'        Me.Close()
'    End Sub

'End Class