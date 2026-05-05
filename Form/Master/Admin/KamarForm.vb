Imports VB_PROJECT.HotelDBDataSetTableAdapters

Public Class KamarForm

    Private isEdit As Boolean = False
    Private selectedIdKamar As Integer = -1
    Private selectedNomor As String = ""

    Private Sub KamarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        ClearForm()
    End Sub

    Private Sub RefreshData()
        Me.Vw_DataKamarTableAdapter.Fill(Me.HotelDBDataSet.vw_DataKamar)
        StyleGrid()
    End Sub

    Private Sub StyleGrid()
        For Each row As DataGridViewRow In dgvKamar.Rows
            Select Case row.Cells(4).Value.ToString()
                Case "Tersedia"
                    row.Cells(4).Style.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
                    row.Cells(4).Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Terisi"
                    row.Cells(4).Style.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14)
                    row.Cells(4).Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Maintenance"
                    row.Cells(4).Style.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
                    row.Cells(4).Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            End Select

            ' Highlight baris yang ada properti rusak
            Dim rusak As Integer = 0
            Integer.TryParse(row.Cells(6).Value.ToString(), rusak)
            If rusak > 0 Then
                row.Cells(6).Style.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
                row.Cells(6).Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            End If
        Next
    End Sub

    Private Sub dgvKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKamar.CellClick
        If dgvKamar.SelectedRows.Count = 0 Then Exit Sub

        selectedIdKamar = Convert.ToInt32(dgvKamar.SelectedRows(0).Cells(0).Value)
        selectedNomor = dgvKamar.SelectedRows(0).Cells(1).Value.ToString()
        txtIdKamar.Text = selectedIdKamar.ToString()
        txtNomorKamar.Text = selectedNomor

        ' Set status
        cboStatus.SelectedItem = dgvKamar.SelectedRows(0).Cells(4).Value.ToString()

        ' Set tipe kamar di combo — cari berdasarkan nama tipe
        Dim namaTipe As String = dgvKamar.SelectedRows(0).Cells(2).Value.ToString()
        Dim dt As System.Data.DataTable = CType(cboIdTipe.DataSource, System.Data.DataTable)
        If dt IsNot Nothing Then
            For Each dr As System.Data.DataRow In dt.Rows
                If dr("nama_tipe").ToString() = namaTipe Then
                    cboIdTipe.SelectedItem = dr("id_tipe")
                    Exit For
                End If
            Next
        End If

        btnHapus.Enabled = True
        btnKondisi.Enabled = True
        btnSimpan.Text = "Update"
        isEdit = True
    End Sub

    'Private Sub btnKondisi_Click(sender As Object, e As EventArgs) Handles btnKondisi.Click
    '    If selectedIdKamar = -1 Then
    '        MsgBox("Pilih kamar dari tabel.", MsgBoxStyle.Exclamation) : Exit Sub
    '    End If
    '    Dim frm As New KondisiPropertiKamarForm()
    '    frm.SetKamar(selectedIdKamar, selectedNomor)
    '    frm.ShowDialog()
    '    RefreshData()
    'End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidateForm() Then Exit Sub
        Dim idTipe As Integer = Convert.ToInt32(cboIdTipe.SelectedValue)
        Try
            If isEdit Then
                QueriesTableAdapter1.sp_UpdateKamar(
                    selectedIdKamar, idTipe,
                    txtNomorKamar.Text.Trim(),
                    cboStatus.SelectedItem.ToString())
                MsgBox("Data kamar berhasil diupdate.", MsgBoxStyle.Information, "Berhasil")
            Else
                QueriesTableAdapter1.sp_InsertKamar(
                    idTipe, txtNomorKamar.Text.Trim(),
                    cboStatus.SelectedItem.ToString())
                MsgBox("Data kamar berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")
            End If
            RefreshData() : ClearForm()
        Catch ex As Exception
            MsgBox("Gagal: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedIdKamar = -1 Then Exit Sub
        Dim konfirm As Boolean = True
        If AppSettingsManager.ConfirmHapus Then
            konfirm = (MsgBox("Yakin hapus kamar No. " & selectedNomor & "?",
                              MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Hapus") = MsgBoxResult.Yes)
        End If
        If Not konfirm Then Exit Sub
        Try
            QueriesTableAdapter1.sp_DeleteKamar(selectedIdKamar)
            MsgBox("Data kamar berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
            RefreshData() : ClearForm()
        Catch ex As Exception
            MsgBox("Gagal: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        ApplyFilter(txtCari.Text.Trim())
    End Sub
    Private Sub txtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then ApplyFilter(txtCari.Text.Trim())
    End Sub
    Private Sub ApplyFilter(keyword As String)
        If keyword = "" Then
            VwDataKamarBindingSource.Filter = ""
        Else
            VwDataKamarBindingSource.Filter =
                "[Nomor Kamar] LIKE '%" & keyword & "%' OR [Tipe Kamar] LIKE '%" & keyword & "%'"
        End If
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtCari.Clear() : VwDataKamarBindingSource.Filter = "" : RefreshData() : ClearForm()
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        txtIdKamar.Text = "(auto)"
        cboIdTipe.SelectedIndex = -1
        txtNomorKamar.Clear()
        cboStatus.SelectedIndex = -1
        btnHapus.Enabled = False
        btnKondisi.Enabled = False
        btnSimpan.Text = "Simpan"
        isEdit = False
        selectedIdKamar = -1
        selectedNomor = ""
        txtNomorKamar.Focus()
    End Sub

    Private Function ValidateForm() As Boolean
        If cboIdTipe.SelectedIndex = -1 Then
            MsgBox("Pilih tipe kamar.", MsgBoxStyle.Exclamation) : cboIdTipe.Focus() : Return False
        End If
        If String.IsNullOrWhiteSpace(txtNomorKamar.Text) Then
            MsgBox("Nomor kamar tidak boleh kosong.", MsgBoxStyle.Exclamation) : txtNomorKamar.Focus() : Return False
        End If
        If cboStatus.SelectedIndex = -1 Then
            MsgBox("Pilih status kamar.", MsgBoxStyle.Exclamation) : cboStatus.Focus() : Return False
        End If
        Return True
    End Function

End Class