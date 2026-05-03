Public Class LoginForm

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" OrElse txtPassword.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong!",
                   MsgBoxStyle.Exclamation, "Perhatian")
            Exit Sub
        End If

        Try
            Dim params As New Dictionary(Of String, Object) From {
                {"@email", txtUsername.Text.Trim()},
                {"@password", txtPassword.Text}
            }
            Dim dt As DataTable = Database.ExecuteQuery("sp_LoginUser", params)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                MainForm.LoggedIn = True
                MainForm.ActiveUser = row("nama").ToString()
                MainForm.SessionRole = row("role").ToString()
                MainForm.SessionUserId = Convert.ToInt32(row("id_user"))

                ' Load preferensi XML untuk user ini
                AppSettingsManager.LoadSettings(row("email").ToString())

                Me.Close()
            Else
                MsgBox("Username atau Password salah!",
                       MsgBoxStyle.Critical, "Login Gagal")
                txtPassword.Clear()
                txtPassword.Focus()
            End If

        Catch ex As Exception
            MsgBox("Gagal koneksi database:" & vbNewLine & ex.Message,
                   MsgBoxStyle.Critical, "Error Koneksi")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class