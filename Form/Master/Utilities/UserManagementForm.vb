Imports VB_PROJECT.HotelDBDataSetTableAdapters

Public Class UserManagementForm

    Private isEdit As Boolean = False
    Private selectedId As Integer = -1

    Private Sub UserManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hanya Admin
        If MainForm.SessionRole.ToLower() <> "admin" Then
            MsgBox("Akses ditolak. Hanya Admin yang dapat membuka halaman ini.",
                   MsgBoxStyle.Critical, "Akses Ditolak")
            Me.Close() : Return
        End If
        RefreshData()
        ClearForm()
    End Sub

    Private Sub RefreshData()
        Dim dt = New sp_GetAllUserTableAdapter().GetData()
        dgvUser.DataSource = Nothing
        dgvUser.Rows.Clear()

        If dt Is Nothing Then Exit Sub
        For Each dr As System.Data.DataRow In dt.Rows
            Dim isAktif As Boolean = Convert.ToBoolean(dr("is_active"))
            Dim i As Integer = dgvUser.Rows.Add()
            dgvUser.Rows(i).Cells("colIdUser").Value = dr("id_user")
            dgvUser.Rows(i).Cells("colNama").Value = dr("nama")
            dgvUser.Rows(i).Cells("colEmail").Value = dr("email")
            dgvUser.Rows(i).Cells("colRole").Value = dr("role")
            dgvUser.Rows(i).Cells("colAktif").Value = If(isAktif, "✔ Aktif", "✖ Nonaktif")
            dgvUser.Rows(i).Cells("colTerdaftar").Value = dr("terdaftar")
            dgvUser.Rows(i).Tag = isAktif

            ' Warna status
            dgvUser.Rows(i).Cells("colAktif").Style.ForeColor = If(isAktif,
                System.Drawing.Color.FromArgb(22, 101, 52),
                System.Drawing.Color.FromArgb(153, 27, 27))
            dgvUser.Rows(i).Cells("colAktif").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)

            ' Warna role
            dgvUser.Rows(i).Cells("colRole").Style.ForeColor = If(dr("role").ToString() = "Admin",
                System.Drawing.Color.FromArgb(91, 33, 182),
                System.Drawing.Color.FromArgb(45, 74, 138))
            dgvUser.Rows(i).Cells("colRole").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Next
    End Sub

    Private Sub dgvUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUser.CellClick
        If dgvUser.SelectedRows.Count = 0 Then Exit Sub

        ' [0]=ID [1]=Nama [2]=Email [3]=Role [4]=Status [5]=Terdaftar
        selectedId = dgvUser.SelectedRows(0).Cells(0).Value
        txtIdUser.Text = selectedId.ToString()
        txtNama.Text = dgvUser.SelectedRows(0).Cells(1).Value?.ToString()
        txtEmail.Text = dgvUser.SelectedRows(0).Cells(2).Value?.ToString()
        txtPassword.Text = "" ' Tidak tampilkan password existing
        cboRole.SelectedItem = dgvUser.SelectedRows(0).Cells(3).Value?.ToString()

        Dim isAktif As Boolean = CBool(dgvUser.SelectedRows(0).Tag)
        chkAktif.Checked = isAktif
        btnToggleAktif.Text = If(isAktif, "Nonaktifkan User", "Aktifkan User")
        btnToggleAktif.BackColor = If(isAktif,
            System.Drawing.Color.FromArgb(153, 27, 27),
            System.Drawing.Color.FromArgb(22, 101, 52))
        btnToggleAktif.Enabled = True

        ' Cegah admin menonaktifkan dirinya sendiri
        If selectedId = MainForm.SessionUserId Then
            btnToggleAktif.Enabled = False
        End If

        btnSimpan.Text = "Update User"
        isEdit = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidateForm() Then Exit Sub
        Try
            If isEdit Then
                ' Update nama & role saja (email tidak bisa diubah, password jika diisi = ganti)
                ' Karena sp_InsertUser hanya untuk insert, update manual via QueriesTableAdapter
                ' Untuk update user, tambahkan sp_UpdateUser di SQL dan QueriesTableAdapter
                ' Sementara: update status aktif saja via toggle
                MsgBox("Untuk mengubah data user, gunakan Toggle Aktif/Nonaktif." & vbNewLine &
                       "Insert user baru via form kosong.",
                       MsgBoxStyle.Information, "Info")
            Else
                ' Insert user baru
                Dim qta As New QueriesTableAdapter()
                qta.sp_InsertUser(
                    txtNama.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtPassword.Text,
                    cboRole.SelectedItem.ToString())
                MsgBox("User berhasil ditambahkan.", MsgBoxStyle.Information, "Berhasil")
                RefreshData() : ClearForm()
            End If
        Catch ex As Exception
            MsgBox("Gagal: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnToggleAktif_Click(sender As Object, e As EventArgs) Handles btnToggleAktif.Click
        If selectedId = -1 Then Exit Sub
        Dim isAktif As Boolean = CBool(dgvUser.SelectedRows(0).Tag)
        Dim targetStatus As Boolean = Not isAktif
        Dim pesanAksi As String = If(targetStatus, "mengaktifkan", "menonaktifkan")

        If MsgBox("Yakin ingin " & pesanAksi & " user " & txtNama.Text & "?",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Konfirmasi") = MsgBoxResult.Yes Then
            Try
                Dim qta As New QueriesTableAdapter()
                qta.sp_UpdateUserStatus(selectedId, targetStatus)
                MsgBox("Status user berhasil diubah.", MsgBoxStyle.Information, "Berhasil")
                RefreshData() : ClearForm()
            Catch ex As Exception
                MsgBox("Gagal: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        ApplyFilter(txtCari.Text.Trim())
    End Sub
    Private Sub txtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then ApplyFilter(txtCari.Text.Trim())
    End Sub
    Private Sub ApplyFilter(keyword As String)
        If keyword = "" Then
            RefreshData() : Return
        End If
        ' Filter manual di rows
        For Each row As DataGridViewRow In dgvUser.Rows
            Dim nama As String = row.Cells("colNama").Value?.ToString().ToLower()
            Dim email As String = row.Cells("colEmail").Value?.ToString().ToLower()
            row.Visible = nama.Contains(keyword.ToLower()) OrElse email.Contains(keyword.ToLower())
        Next
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtCari.Clear() : RefreshData() : ClearForm()
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        txtIdUser.Text = "(auto)"
        txtNama.Clear()
        txtEmail.Clear()
        txtPassword.Clear()
        cboRole.SelectedIndex = -1
        chkAktif.Checked = True
        btnToggleAktif.Enabled = False
        btnSimpan.Text = "Simpan User"
        isEdit = False
        selectedId = -1
        txtNama.Focus()
    End Sub

    Private Function ValidateForm() As Boolean
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MsgBox("Nama tidak boleh kosong.", MsgBoxStyle.Exclamation) : txtNama.Focus() : Return False
        End If
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MsgBox("Email tidak boleh kosong.", MsgBoxStyle.Exclamation) : txtEmail.Focus() : Return False
        End If
        If Not isEdit AndAlso String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Password tidak boleh kosong untuk user baru.", MsgBoxStyle.Exclamation) : txtPassword.Focus() : Return False
        End If
        If cboRole.SelectedIndex = -1 Then
            MsgBox("Pilih role.", MsgBoxStyle.Exclamation) : cboRole.Focus() : Return False
        End If
        Return True
    End Function

End Class