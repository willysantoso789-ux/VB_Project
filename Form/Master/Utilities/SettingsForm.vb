Public Class SettingsForm

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserInfo.Text = "User aktif: " & MainForm.ActiveUser &
                               "  |  Role: " & MainForm.SessionRole

        chkShowClock.Checked = AppSettingsManager.ShowClock
        chkConfirmLogout.Checked = AppSettingsManager.ConfirmLogout
        chkConfirmHapus.Checked = AppSettingsManager.ConfirmHapus

        ' Denda — hanya admin yang bisa edit
        nudDendaPersen.Minimum = 100
        nudDendaPersen.Maximum = 500
        nudDendaPersen.Value = Math.Max(100, AppSettingsManager.PersenDenda)

        Dim isAdmin As Boolean = MainForm.SessionRole.ToLower() = "admin"
        nudDendaPersen.Enabled = isAdmin
        lblDendaWarning.Text = If(isAdmin,
            "Min 100% — Hanya Admin yang dapat mengubah",
            "Min 100% — Hanya Admin yang dapat mengubah (Read Only)")
        lblDendaWarning.ForeColor = If(isAdmin,
            System.Drawing.Color.FromArgb(22, 101, 52),
            System.Drawing.Color.FromArgb(100, 100, 100))
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Simpan preferensi user (semua role bisa)
        AppSettingsManager.ShowClock = chkShowClock.Checked
        AppSettingsManager.ConfirmLogout = chkConfirmLogout.Checked
        AppSettingsManager.ConfirmHapus = chkConfirmHapus.Checked
        AppSettingsManager.SaveSettings(MainForm.ActiveUser)

        ' Simpan denda — hanya admin
        If MainForm.SessionRole.ToLower() = "admin" Then
            Dim persen As Integer = Convert.ToInt32(nudDendaPersen.Value)
            If persen < 100 Then
                MsgBox("Persentase denda minimum 100%.", MsgBoxStyle.Exclamation)
                nudDendaPersen.Value = 100 : nudDendaPersen.Focus() : Return
            End If
            AppSettingsManager.PersenDenda = persen
            AppSettingsManager.SaveGlobalSettings()
        End If

        MsgBox("Preferensi berhasil disimpan.", MsgBoxStyle.Information, "Tersimpan")
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If MsgBox("Reset preferensi ke default?",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Reset") = MsgBoxResult.Yes Then
            AppSettingsManager.ResetToDefault(MainForm.ActiveUser)
            chkShowClock.Checked = True
            chkConfirmLogout.Checked = True
            chkConfirmHapus.Checked = True
            If MainForm.SessionRole.ToLower() = "admin" Then
                nudDendaPersen.Value = 100
            End If
            MsgBox("Preferensi direset.", MsgBoxStyle.Information, "Reset")
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

End Class