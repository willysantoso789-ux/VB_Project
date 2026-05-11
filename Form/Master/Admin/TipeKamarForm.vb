Imports VB_PROJECT.HotelDBDataSetTableAdapters

Public Class TipeKamarForm

    Private isEdit As Boolean = False

    Private Sub TipeKamarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        ClearForm()
    End Sub

    Private Sub RefreshData()
        Me.Vw_DataTipeKamarTableAdapter.Fill(Me.HotelDBDataSet.vw_DataTipeKamar)
    End Sub

    Private Sub dgvTipe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipe.CellClick
        If dgvTipe.SelectedRows.Count = 0 Then Exit Sub

        ' [0]=ID Tipe [1]=Nama Tipe [2]=Harga per Malam [3]=Deskripsi
        ' [4]=Jumlah Kamar [5]=Kamar Tersedia [6]=Kamar Terisi [7]=Kamar Maintenance [8]=Dibuat
        txtIdTipe.Text = dgvTipe.SelectedRows(0).Cells(0).Value?.ToString()
        txtNamaTipe.Text = dgvTipe.SelectedRows(0).Cells(1).Value?.ToString()

        ' Harga dari view sudah format "N0" (misal "350.000") — parse untuk edit
        Dim hargaStr As String = dgvTipe.SelectedRows(0).Cells(2).Value?.ToString()
        txtHarga.Text = hargaStr?.Replace(".", "").Replace(",", "")

        txtDeskripsi.Text = dgvTipe.SelectedRows(0).Cells(3).Value?.ToString()

        ' Cegah hapus jika ada kamar terdaftar
        Dim jumlah As Integer = 0
        Integer.TryParse(dgvTipe.SelectedRows(0).Cells(4).Value?.ToString(), jumlah)
        btnHapus.Enabled = True
        btnSimpan.Text = "Update"
        isEdit = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidateForm() Then Exit Sub
        Dim harga As Decimal = 0
        Decimal.TryParse(txtHarga.Text.Replace(".", "").Replace(",", ""), harga)
        Try
            If isEdit Then
                Dim id As Integer = Convert.ToInt32(dgvTipe.SelectedRows(0).Cells(0).Value)
                ' sp_UpdateTipeKamar(@id_tipe, @nama_tipe, @harga, @deskripsi)
                QueriesTableAdapter1.sp_UpdateTipeKamar(
                    id, txtNamaTipe.Text.Trim(), harga, txtDeskripsi.Text.Trim())
                MsgBox("Tipe kamar berhasil diupdate.", MsgBoxStyle.Information, "Berhasil")
            Else
                ' sp_InsertTipeKamar(@nama_tipe, @harga, @deskripsi)
                QueriesTableAdapter1.sp_InsertTipeKamar(
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

        ' Cek apakah ada kamar yang memakai tipe ini
        Dim jumlah As Integer = 0
        Integer.TryParse(dgvTipe.SelectedRows(0).Cells(4).Value?.ToString(), jumlah)
        If jumlah > 0 Then
            MsgBox("Tipe kamar ini masih digunakan oleh " & jumlah & " kamar." & vbNewLine &
                   "Hapus atau pindahkan kamar tersebut terlebih dahulu.",
                   MsgBoxStyle.Exclamation, "Tidak Dapat Dihapus")
            Return
        End If

        Dim konfirm As Boolean = True
        If AppSettingsManager.ConfirmHapus Then
            konfirm = (MsgBox("Yakin hapus tipe " & txtNamaTipe.Text & "?",
                              MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Hapus") = MsgBoxResult.Yes)
        End If
        If Not konfirm Then Exit Sub

        Try
            Dim id As Integer = Convert.ToInt32(dgvTipe.SelectedRows(0).Cells(0).Value)
            ' sp_DeleteTipeKamar(@id_tipe)
            QueriesTableAdapter1.sp_DeleteTipeKamar(id)
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
        ' Filter via BindingSource — kolom dari vw_DataTipeKamar
        VwDataTipeKamarBindingSource.Filter = If(keyword = "", "",
            "[Nama Tipe] LIKE '%" & keyword & "%'")
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtCari.Clear()
        VwDataTipeKamarBindingSource.Filter = ""
        RefreshData() : ClearForm()
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