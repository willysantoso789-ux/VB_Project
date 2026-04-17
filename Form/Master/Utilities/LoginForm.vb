Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong!", MsgBoxStyle.Exclamation, "Perhatian")
            Exit Sub
        End If

        ' Hardcode for now, no SQL yet
        If txtUsername.Text = "a" And txtPassword.Text = "a" Then
            MainForm.LoggedIn = True
            MainForm.ActiveUser = txtUsername.Text
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