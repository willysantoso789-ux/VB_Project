Public Class SettingsForm

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserInfo.Text = "User aktif: " & MainForm.ActiveUser &
                               "  |  Role: " & MainForm.SessionRole
        chkShowClock.Checked = AppSettingsManager.ShowClock
        chkConfirmLogout.Checked = AppSettingsManager.ConfirmLogout
        chkConfirmHapus.Checked = AppSettingsManager.ConfirmHapus
        nudDendaPersen.Value = Math.Max(100, AppSettingsManager.PersenDenda)
    End Sub

    Private Sub nudDendaPersen_ValueChanged(sender As Object, e As EventArgs) Handles nudDendaPersen.ValueChanged
        ' Real-time feedback warna
        If nudDendaPersen.Value = 100 Then
            lblDendaWarning.Text = "100% = tepat harga kamar per malam (minimum)"
            lblDendaWarning.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
        ElseIf nudDendaPersen.Value <= 200 Then
            lblDendaWarning.Text = nudDendaPersen.Value & "% per hari"
            lblDendaWarning.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14)
        Else
            lblDendaWarning.Text = nudDendaPersen.Value & "% per hari (denda tinggi)"
            lblDendaWarning.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim persen As Integer = Convert.ToInt32(nudDendaPersen.Value)

        ' Double-check validasi
        If persen < 100 Then
            MsgBox("Persentase denda minimum adalah 100%." & vbNewLine &
                   "Hotel akan rugi jika denda di bawah harga kamar.",
                   MsgBoxStyle.Exclamation, "Validasi Denda")
            nudDendaPersen.Value = 100
            nudDendaPersen.Focus()
            Return
        End If

        AppSettingsManager.ShowClock = chkShowClock.Checked
        AppSettingsManager.ConfirmLogout = chkConfirmLogout.Checked
        AppSettingsManager.ConfirmHapus = chkConfirmHapus.Checked
        AppSettingsManager.PersenDenda = persen

        AppSettingsManager.SaveSettings(MainForm.ActiveUser)

        MsgBox("Preferensi berhasil disimpan untuk user: " & MainForm.ActiveUser,
               MsgBoxStyle.Information, "Tersimpan")
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If MsgBox("Reset preferensi ke default untuk user " & MainForm.ActiveUser & "?",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Reset") = MsgBoxResult.Yes Then
            AppSettingsManager.ResetToDefault(MainForm.ActiveUser)
            ' Reload ke UI
            chkShowClock.Checked = True
            chkConfirmLogout.Checked = True
            chkConfirmHapus.Checked = True
            nudDendaPersen.Value = 100
            MsgBox("Preferensi direset ke default.", MsgBoxStyle.Information, "Reset")
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

End Class