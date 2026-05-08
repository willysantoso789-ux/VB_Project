Imports VB_PROJECT.HotelDBDataSetTableAdapters

Public Class LoginForm

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" OrElse txtPassword.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong!",
                   MsgBoxStyle.Exclamation, "Perhatian")
            Exit Sub
        End If

        Try
            Dim dt = New sp_LoginUserTableAdapter().GetData(
                         txtUsername.Text.Trim(),
                         txtPassword.Text)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Dim row As System.Data.DataRow = dt.Rows(0)
                MainForm.LoggedIn = True
                MainForm.ActiveUser = row("nama").ToString()
                MainForm.SessionRole = row("role").ToString()
                MainForm.SessionUserId = Convert.ToInt32(row("id_user"))

                ' Load preferensi per-user (ShowClock, Confirm, dll)
                AppSettingsManager.LoadSettings(row("email").ToString())

                Me.Close()
            Else
                MsgBox("Email atau Password salah!",
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

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then btnLogin_Click(Nothing, Nothing)
    End Sub

End Class