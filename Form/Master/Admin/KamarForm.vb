Imports VB_PROJECT.HotelDBDataSetTableAdapters

Public Class KamarForm

    Private isEdit As Boolean = False

    Private Sub KamarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTipeCombo()
        RefreshData()
        ClearForm()
    End Sub

    Private Sub RefreshData()
        Me.Vw_DataKamarTableAdapter.Fill(Me.HotelDBDataSet.vw_DataKamar)
    End Sub

    Private Sub LoadTipeCombo()
        Dim dt = New sp_GetAllTipeKamarTableAdapter().GetData()
        cboIdTipe.DataSource = dt
        cboIdTipe.DisplayMember = "nama_tipe"
        cboIdTipe.ValueMember = "id_tipe"
        cboIdTipe.SelectedIndex = -1
    End Sub

    Private Sub dgvKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKamar.CellClick
        If dgvKamar.SelectedRows.Count = 0 Then Exit Sub

        ' [0]=ID Kamar [1]=Nomor Kamar [2]=Tipe Kamar [3]=Harga per Malam
        ' [4]=Status   [5]=Jumlah Properti [6]=Properti Rusak [7]=Properti Perbaikan
        txtIdKamar.Text = dgvKamar.SelectedRows(0).Cells(0).Value
        txtNomorKamar.Text = dgvKamar.SelectedRows(0).Cells(1).Value
        cboStatus.SelectedItem = dgvKamar.SelectedRows(0).Cells(4).Value

        ' Set tipe kamar di combo berdasarkan nama tipe [2]
        Dim namaTipe As String = dgvKamar.SelectedRows(0).Cells(2).Value?.ToString()
        Dim dt As System.Data.DataTable = CType(cboIdTipe.DataSource, System.Data.DataTable)
        If dt IsNot Nothing Then
            For Each dr As System.Data.DataRow In dt.Rows
                If dr("nama_tipe").ToString() = namaTipe Then
                    cboIdTipe.SelectedValue = dr("id_tipe")
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
    '    If dgvKamar.SelectedRows.Count = 0 Then
    '        MsgBox("Pilih kamar dari tabel.", MsgBoxStyle.Exclamation) : Exit Sub
    '    End If
    '    Dim idKamar As Integer = dgvKamar.SelectedRows(0).Cells(0).Value
    '    Dim nomor As String = dgvKamar.SelectedRows(0).Cells(1).Value?.ToString()
    '    Dim frm As New KondisiPropertiKamarForm()
    '    frm.SetKamar(idKamar, nomor)
    '    frm.ShowDialog()
    '    RefreshData()
    'End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidateForm() Then Exit Sub
        Dim idTipe As Integer = Convert.ToInt32(cboIdTipe.SelectedValue)
        Try
            If isEdit Then
                Dim idKamar As Integer = dgvKamar.SelectedRows(0).Cells(0).Value
                ' sp_UpdateKamar(@id_kamar, @id_tipe, @nomor_kamar, @status)
                QueriesTableAdapter1.sp_UpdateKamar(
                    idKamar, idTipe,
                    txtNomorKamar.Text.Trim(),
                    cboStatus.SelectedItem.ToString())
                MsgBox("Data kamar berhasil diupdate.", MsgBoxStyle.Information, "Berhasil")
            Else
                ' sp_InsertKamar(@id_tipe, @nomor_kamar, @status)
                QueriesTableAdapter1.sp_InsertKamar(
                    idTipe,
                    txtNomorKamar.Text.Trim(),
                    cboStatus.SelectedItem.ToString())
                MsgBox("Data kamar berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")
            End If
            RefreshData() : ClearForm()
        Catch ex As Exception
            MsgBox("Gagal: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvKamar.SelectedRows.Count = 0 Then Exit Sub
        Dim konfirm As Boolean = True
        If AppSettingsManager.ConfirmHapus Then
            konfirm = (MsgBox("Yakin hapus kamar No. " & txtNomorKamar.Text & "?",
                              MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Hapus") = MsgBoxResult.Yes)
        End If
        If Not konfirm Then Exit Sub
        Try
            Dim id As Integer = dgvKamar.SelectedRows(0).Cells(0).Value
            ' sp_DeleteKamar(@id_kamar)
            QueriesTableAdapter1.sp_DeleteKamar(id)
            MsgBox("Kamar berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
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
        ' Filter via BindingSource — kolom dari vw_DataKamar
        VwDataKamarBindingSource.Filter = If(keyword = "", "",
            "[Nomor Kamar] LIKE '%" & keyword & "%' OR [Tipe Kamar] LIKE '%" & keyword & "%'")
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