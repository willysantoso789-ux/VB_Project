Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong!", MsgBoxStyle.Exclamation, "Perhatian")
            Exit Sub
        End If

        ' Hardcode — nanti ganti ke DB
        ' admin   / admin   → role Admin
        ' resep01 / resep01 → role Resepsionis
        If txtUsername.Text = "admin" AndAlso txtPassword.Text = "admin" Then
            MainForm.LoggedIn = True
            MainForm.ActiveUser = txtUsername.Text
            MainForm.SessionRole = "Admin"
            Me.Close()
        ElseIf txtUsername.Text = "resep01" AndAlso txtPassword.Text = "resep01" Then
            MainForm.LoggedIn = True
            MainForm.ActiveUser = txtUsername.Text
            MainForm.SessionRole = "Resepsionis"
            Me.Close()
        Else
            MsgBox("Username atau Password salah!", MsgBoxStyle.Critical, "Login Gagal")
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class