Imports VB_PROJECT.HotelDBDataSetTableAdapters

Public Class TipeKamarForm

    Private isEdit As Boolean = False

    Private Sub TipeKamarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        ClearForm()
    End Sub

    Private Sub RefreshData()
        dgvTipe.DataSource = New sp_GetAllTipeKamarTableAdapter().GetData()
    End Sub

    Private Sub dgvTipe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipe.CellClick
        If dgvTipe.SelectedRows.Count = 0 Then Exit Sub

        ' [0]=id_tipe [1]=nama_tipe [2]=harga [3]=deskripsi
        txtIdTipe.Text = dgvTipe.SelectedRows(0).Cells(0).Value
        txtNamaTipe.Text = dgvTipe.SelectedRows(0).Cells(1).Value
        txtHarga.Text = Convert.ToDecimal(dgvTipe.SelectedRows(0).Cells(2).Value).ToString("N0")
        txtDeskripsi.Text = dgvTipe.SelectedRows(0).Cells(3).Value

        btnHapus.Enabled = True
        btnSimpan.Text = "Update"
        isEdit = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidateForm() Then Exit Sub
        Dim harga As Decimal = 0
        Decimal.TryParse(txtHarga.Text.Replace(".", "").Replace(",", ""), harga)
        Try
            Dim qta As New QueriesTableAdapter()
            If isEdit Then
                Dim id As Integer = dgvTipe.SelectedRows(0).Cells(0).Value
                ' sp_UpdateTipeKamar(@id_tipe, @nama_tipe, @harga, @deskripsi)
                qta.sp_UpdateTipeKamar(
                    id, txtNamaTipe.Text.Trim(), harga, txtDeskripsi.Text.Trim())
                MsgBox("Tipe kamar berhasil diupdate.", MsgBoxStyle.Information, "Berhasil")
            Else
                ' sp_InsertTipeKamar(@nama_tipe, @harga, @deskripsi)
                qta.sp_InsertTipeKamar(
                    txtNamaTipe.Text.Trim(), harga, txtDeskripsi.Text.Trim())
                MsgBox("Tipe kamar berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")
            End If
            RefreshData() : ClearForm()
        Catch ex As Exception
            MsgBox("Gagal: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvTipe.SelectedRows.Count = 0 Then Exit Sub
        Dim konfirm As Boolean = True
        If AppSettingsManager.ConfirmHapus Then
            konfirm = (MsgBox("Yakin hapus tipe " & txtNamaTipe.Text & "?",
                              MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Hapus") = MsgBoxResult.Yes)
        End If
        If Not konfirm Then Exit Sub
        Try
            Dim qta As New QueriesTableAdapter()
            Dim id As Integer = dgvTipe.SelectedRows(0).Cells(0).Value
            ' sp_DeleteTipeKamar(@id_tipe)
            qta.sp_DeleteTipeKamar(id)
            MsgBox("Tipe kamar berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
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
        Dim dt = New sp_GetAllTipeKamarTableAdapter().GetData()
        If keyword = "" Then
            dgvTipe.DataSource = dt
        Else
            Dim view As New System.Data.DataView(dt)
            view.RowFilter = "nama_tipe LIKE '%" & keyword & "%'"
            dgvTipe.DataSource = view.ToTable()
        End If
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtCari.Clear() : RefreshData() : ClearForm()
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        txtIdTipe.Text = "(auto)"
        txtNamaTipe.Clear()
        txtHarga.Clear()
        txtDeskripsi.Clear()
        btnHapus.Enabled = False
        btnSimpan.Text = "Simpan"
        isEdit = False
        txtNamaTipe.Focus()
    End Sub

    Private Function ValidateForm() As Boolean
        If String.IsNullOrWhiteSpace(txtNamaTipe.Text) Then
            MsgBox("Nama tipe tidak boleh kosong.", MsgBoxStyle.Exclamation)
            txtNamaTipe.Focus() : Return False
        End If
        Dim h As Decimal = 0
        If Not Decimal.TryParse(txtHarga.Text.Replace(".", "").Replace(",", ""), h) OrElse h <= 0 Then
            MsgBox("Harga harus lebih dari 0.", MsgBoxStyle.Exclamation)
            txtHarga.Focus() : Return False
        End If
        Return True
    End Function

End Class