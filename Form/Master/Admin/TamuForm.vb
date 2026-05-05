Imports VB_PROJECT.HotelDBDataSetTableAdapters

Public Class TamuForm

    Private isEdit As Boolean = False

    ' ── Load ──────────────────────────────────────────────
    Private Sub TamuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        ClearForm()
    End Sub

    Private Sub RefreshData()
        ' Pakai TableAdapter langsung — pattern dari referensi
        Me.Vw_DataTamuTableAdapter.Fill(Me.HotelDBDataSet.vw_DataTamu)
    End Sub

    ' ── Klik baris ────────────────────────────────────────
    Private Sub dgvTamu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTamu.CellClick
        If dgvTamu.SelectedRows.Count < 0 Then Exit Sub

        txtNIK.Text = dgvTamu.SelectedRows(0).Cells(1).Value
        txtNama.Text = dgvTamu.SelectedRows(0).Cells(2).Value
        txtEmail.Text = dgvTamu.SelectedRows(0).Cells(3).Value
        txtNoHp.Text = dgvTamu.SelectedRows(0).Cells(4).Value
        cboGender.SelectedItem = dgvTamu.SelectedRows(0).Cells(5).Value
        txtAlamat.Text = dgvTamu.SelectedRows(0).Cells(6).Value

        btnHapus.Enabled = True
        btnSimpan.Text = "Update"
        isEdit = True
    End Sub

    ' ── Simpan / Update ───────────────────────────────────
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidateForm() Then Exit Sub

        Try
            If isEdit Then
                ' Update via QueriesTableAdapter
                QueriesTableAdapter1.sp_UpdateTamu(
                    dgvTamu.SelectedRows(0).Cells(0).Value,
                    txtNIK.Text.Trim(),
                    txtNama.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtNoHp.Text.Trim(),
                    cboGender.SelectedItem.ToString(),
                    txtAlamat.Text.Trim())
                MsgBox("Data tamu berhasil diupdate.", MsgBoxStyle.Information, "Berhasil")
            Else
                ' Insert via QueriesTableAdapter
                QueriesTableAdapter1.sp_InsertTamu(
                    txtNIK.Text.Trim(),
                    txtNama.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtNoHp.Text.Trim(),
                    cboGender.SelectedItem.ToString(),
                    txtAlamat.Text.Trim())
                MsgBox("Data tamu berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")
            End If

            RefreshData()
            ClearForm()

        Catch ex As Exception
            MsgBox("Gagal menyimpan: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ' ── Hapus ─────────────────────────────────────────────
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvTamu.SelectedRows.Count < 0 Then Exit Sub

        Dim konfirm As Boolean = True
        If AppSettingsManager.ConfirmHapus Then
            konfirm = (MsgBox("Yakin ingin menghapus tamu " & txtNama.Text & "?",
                              MsgBoxStyle.YesNo Or MsgBoxStyle.Question,
                              "Hapus") = MsgBoxResult.Yes)
        End If
        If Not konfirm Then Exit Sub

        Try
            Dim id As Integer = dgvTamu.SelectedRows(0).Cells(0).Value
            QueriesTableAdapter1.sp_DeleteTamu(id)
            MsgBox("Data tamu berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
            RefreshData()
            ClearForm()
        Catch ex As Exception
            MsgBox("Gagal menghapus: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ' ── Cari — filter BindingSource ───────────────────────
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        ApplyFilter(txtCari.Text.Trim())
    End Sub

    Private Sub txtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then ApplyFilter(txtCari.Text.Trim())
    End Sub

    Private Sub ApplyFilter(keyword As String)
        If keyword = "" Then
            VwDataTamuBindingSource.Filter = ""
        Else
            ' Filter di BindingSource — NIK prefix atau Nama contains
            VwDataTamuBindingSource.Filter =
                "NIK LIKE '" & keyword & "%' OR [Nama Lengkap] LIKE '%" & keyword & "%'"
        End If
    End Sub

    ' ── Refresh ───────────────────────────────────────────
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtCari.Clear()
        VwDataTamuBindingSource.Filter = ""
        RefreshData()
        ClearForm()
    End Sub

    ' ── Clear form ────────────────────────────────────────
    Private Sub ClearForm()
        txtIdTamu.Text = "(auto)"
        txtNIK.Clear()
        txtNama.Clear()
        txtEmail.Clear()
        txtNoHp.Clear()
        cboGender.SelectedIndex = -1
        txtAlamat.Clear()
        btnHapus.Enabled = False
        btnSimpan.Text = "Simpan"
        isEdit = False
        txtNIK.Focus()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearForm()
    End Sub

    ' ── Validasi ──────────────────────────────────────────
    Private Function ValidateForm() As Boolean
        If String.IsNullOrWhiteSpace(txtNIK.Text) OrElse txtNIK.Text.Trim().Length <> 16 Then
            MsgBox("NIK harus 16 digit.", MsgBoxStyle.Exclamation)
            txtNIK.Focus() : Return False
        End If
        If Not txtNIK.Text.Trim().All(Function(c) Char.IsDigit(c)) Then
            MsgBox("NIK harus berupa angka.", MsgBoxStyle.Exclamation)
            txtNIK.Focus() : Return False
        End If
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MsgBox("Nama tidak boleh kosong.", MsgBoxStyle.Exclamation)
            txtNama.Focus() : Return False
        End If
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MsgBox("Email tidak boleh kosong.", MsgBoxStyle.Exclamation)
            txtEmail.Focus() : Return False
        End If
        If cboGender.SelectedIndex = -1 Then
            MsgBox("Pilih jenis kelamin.", MsgBoxStyle.Exclamation)
            cboGender.Focus() : Return False
        End If
        Return True
    End Function

End Class