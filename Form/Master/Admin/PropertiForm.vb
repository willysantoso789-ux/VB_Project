Imports VB_PROJECT.HotelDBDataSetTableAdapters

Public Class PropertiForm

    Private isEdit As Boolean = False

    Private Sub PropertiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        ClearForm()
    End Sub

    Private Sub RefreshData()
        ' Pakai TableAdapter dari vw_DataProperti
        Me.Vw_DataPropertiTableAdapter.Fill(Me.HotelDBDataSet.vw_DataProperti)
    End Sub

    Private Sub dgvProperti_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProperti.CellClick
        If dgvProperti.SelectedRows.Count = 0 Then Exit Sub

        ' [0]=ID [1]=Nama Properti [2]=Biaya Denda (Rp) [3]=Jumlah Assign
        ' [4]=Properti Rusak [5]=Properti Perbaikan [6]=Properti Baik
        txtIdProperti.Text = dgvProperti.SelectedRows(0).Cells(0).Value
        txtNama.Text = dgvProperti.SelectedRows(0).Cells(1).Value

        ' Biaya denda di view sudah format "N0" (misal "500.000")
        ' Untuk edit, simpan nilai asli dari DB via SP — atau parse dulu
        Dim biayaStr As String = dgvProperti.SelectedRows(0).Cells(2).Value?.ToString()
        txtBiaya.Text = biayaStr?.Replace(".", "").Replace(",", "")

        Dim jumlah As Integer = Convert.ToInt32(dgvProperti.SelectedRows(0).Cells(3).Value)
        btnHapus.Enabled = True
        btnAssign.Enabled = True
        btnUnassign.Enabled = (jumlah > 0)
        btnSimpan.Text = "Update"
        isEdit = True
    End Sub

    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        If dgvProperti.SelectedRows.Count = 0 Then Exit Sub
        Dim frm As New PropertiKamarForm()
        frm.SetProperti(
            Convert.ToInt32(dgvProperti.SelectedRows(0).Cells(0).Value),
            dgvProperti.SelectedRows(0).Cells(1).Value?.ToString())
        frm.ShowDialog()
        RefreshData()
        ' Refresh state tombol unassign setelah dialog tutup
        If dgvProperti.SelectedRows.Count > 0 Then
            Dim jumlah As Integer = Convert.ToInt32(dgvProperti.SelectedRows(0).Cells(3).Value)
            btnUnassign.Enabled = (jumlah > 0)
        End If
    End Sub

    Private Sub btnUnassign_Click(sender As Object, e As EventArgs) Handles btnUnassign.Click
        If dgvProperti.SelectedRows.Count = 0 Then Exit Sub
        Dim frm As New UnassignPropertiForm()
        frm.SetProperti(
            Convert.ToInt32(dgvProperti.SelectedRows(0).Cells(0).Value),
            dgvProperti.SelectedRows(0).Cells(1).Value?.ToString())
        frm.ShowDialog()
        RefreshData()
        If dgvProperti.SelectedRows.Count > 0 Then
            Dim jumlah As Integer = Convert.ToInt32(dgvProperti.SelectedRows(0).Cells(3).Value)
            btnUnassign.Enabled = (jumlah > 0)
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidateForm() Then Exit Sub
        Dim biaya As Decimal = 0
        Decimal.TryParse(txtBiaya.Text.Replace(".", "").Replace(",", ""), biaya)
        Try
            If isEdit Then
                Dim id As Integer = Convert.ToInt32(dgvProperti.SelectedRows(0).Cells(0).Value)
                ' sp_UpdateProperti(@id_properti, @nama_properti, @biaya_denda)
                QueriesTableAdapter1.sp_UpdateProperti(id, txtNama.Text.Trim(), biaya)
                MsgBox("Properti berhasil diupdate.", MsgBoxStyle.Information, "Berhasil")
            Else
                ' sp_InsertProperti(@nama_properti, @biaya_denda)
                QueriesTableAdapter1.sp_InsertProperti(txtNama.Text.Trim(), biaya)
                MsgBox("Properti berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")
            End If
            RefreshData() : ClearForm()
        Catch ex As Exception
            MsgBox("Gagal: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvProperti.SelectedRows.Count = 0 Then Exit Sub
        Dim jumlah As Integer = Convert.ToInt32(dgvProperti.SelectedRows(0).Cells(3).Value)
        If jumlah > 0 Then
            MsgBox("Properti masih ter-assign ke " & jumlah & " kamar." & vbNewLine &
                   "Unassign semua kamar terlebih dahulu.",
                   MsgBoxStyle.Exclamation, "Tidak Dapat Dihapus") : Return
        End If
        Dim konfirm As Boolean = True
        If AppSettingsManager.ConfirmHapus Then
            konfirm = (MsgBox("Yakin hapus properti " & txtNama.Text & "?",
                              MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Hapus") = MsgBoxResult.Yes)
        End If
        If Not konfirm Then Exit Sub
        Try
            Dim id As Integer = Convert.ToInt32(dgvProperti.SelectedRows(0).Cells(0).Value)
            ' sp_DeleteProperti(@id_properti)
            QueriesTableAdapter1.sp_DeleteProperti(id)
            MsgBox("Properti berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
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
        ' Filter via BindingSource — kolom dari vw_DataProperti
        VwDataPropertiBindingSource.Filter = If(keyword = "", "",
            "[Nama Properti] LIKE '%" & keyword & "%'")
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtCari.Clear() : VwDataPropertiBindingSource.Filter = "" : RefreshData() : ClearForm()
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        txtIdProperti.Text = "(auto)"
        txtNama.Clear()
        txtBiaya.Clear()
        btnHapus.Enabled = False
        btnAssign.Enabled = False
        btnUnassign.Enabled = False
        btnSimpan.Text = "Simpan"
        isEdit = False
        txtNama.Focus()
    End Sub

    Private Function ValidateForm() As Boolean
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MsgBox("Nama properti tidak boleh kosong.", MsgBoxStyle.Exclamation)
            txtNama.Focus() : Return False
        End If
        Dim b As Decimal = 0
        If Not Decimal.TryParse(txtBiaya.Text.Replace(".", "").Replace(",", ""), b) OrElse b < 0 Then
            MsgBox("Biaya denda harus angka >= 0.", MsgBoxStyle.Exclamation)
            txtBiaya.Focus() : Return False
        End If
        Return True
    End Function

End Class