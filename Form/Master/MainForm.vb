Public Class MainForm

    Public Shared LoggedIn As Boolean = False
    Public Shared ActiveUser As String = ""
    Public Shared SessionRole As String = ""

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetMenuVisibility(False)
        UpdateStatus()
        lblStatusDB.Text = "● DB: Not Connected"
        lblStatusDB.ForeColor = System.Drawing.Color.Yellow
        Me.KeyPreview = True
    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        lblStatusTime.Text = DateTime.Now.ToString("HH:mm:ss")
        lblStatusDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy")
    End Sub

    ' ── Keyboard shortcuts ────────────────────────────────
    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If Not LoggedIn Then Exit Sub
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.T : NavigateTo(New TamuForm())
                Case Keys.K : NavigateTo(New KamarForm())
                Case Keys.R : NavigateTo(New ReservasiForm())
                Case Keys.I : NavigateTo(New CheckInForm())
                Case Keys.O : NavigateTo(New CheckOutForm())
                Case Keys.L : NavigateTo(New LaporanForm())
                Case Keys.Y
                    If SessionRole.ToLower() = "admin" Then NavigateTo(New TipeKamarForm())
                Case Keys.P
                    If SessionRole.ToLower() = "admin" Then NavigateTo(New PropertiForm())
            End Select
            e.Handled = True
        End If
    End Sub

    ' ── Visibility berdasarkan login & role ───────────────
    Public Sub SetMenuVisibility(isLoggedIn As Boolean)
        mnuProfile.Visible = isLoggedIn
        mnuSep1.Visible = isLoggedIn
        mnuLogout.Visible = isLoggedIn
        mnuLogin.Visible = Not isLoggedIn
        pnlDashboard.Visible = isLoggedIn
        mnuItemOperasional.Visible = isLoggedIn
        mnuItemLaporanNav.Visible = isLoggedIn
        mnuItemSettings.Visible = isLoggedIn

        Dim isAdmin As Boolean = isLoggedIn AndAlso SessionRole.ToLower() = "admin"
        pnlCardTipeKamar.Visible = isAdmin
        pnlCardProperti.Visible = isAdmin
        mnuItemMaster.Visible = isAdmin
    End Sub

    Private Sub UpdateStatus()
        If LoggedIn Then
            lblStatusUser.Text = "User: " & ActiveUser & "  |  Role: " & SessionRole
            lblWelcome.Text = "Selamat Datang, " & ActiveUser
            lblWelcomeSub.Text = "Hotel Receptionist System  ·  " &
                                 DateTime.Now.ToString("dddd, dd MMMM yyyy") &
                                 "  ·  " & SessionRole
        Else
            lblStatusUser.Text = "User: -"
        End If
    End Sub

    Private Sub MainForm_MdiChildActivate(sender As Object, e As EventArgs) Handles Me.MdiChildActivate
        If Me.ActiveMdiChild Is Nothing AndAlso LoggedIn Then
            pnlDashboard.Visible = True
        End If
    End Sub

    ' ════════════════════════════════════════════════════
    ' MENU EVENTS
    ' ════════════════════════════════════════════════════
    Private Sub mnuLogin_Click(sender As Object, e As EventArgs) Handles mnuLogin.Click
        Dim frm As New LoginForm()
        frm.ShowDialog()
        If LoggedIn Then
            SetMenuVisibility(True)
            UpdateStatus()
        End If
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        If MsgBox("Yakin ingin logout?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Logout") = MsgBoxResult.Yes Then
            LoggedIn = False
            ActiveUser = ""
            SessionRole = ""
            SetMenuVisibility(False)
            UpdateStatus()
            CloseAllChildren()
        End If
    End Sub

    Private Sub mnuProfile_Click(sender As Object, e As EventArgs) Handles mnuProfile.Click
        MsgBox("User : " & ActiveUser & vbNewLine & "Role : " & SessionRole,
               MsgBoxStyle.Information, "Profile")
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        If MsgBox("Yakin ingin keluar?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Keluar") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' ── Operasional menu ──────────────────────────────────
    Private Sub mnuNavTamu_Click(sender As Object, e As EventArgs) Handles mnuNavTamu.Click
        NavigateTo(New TamuForm())
    End Sub

    Private Sub mnuNavKamar_Click(sender As Object, e As EventArgs) Handles mnuNavKamar.Click
        NavigateTo(New KamarForm())
    End Sub

    Private Sub mnuNavReservasi_Click(sender As Object, e As EventArgs) Handles mnuNavReservasi.Click
        NavigateTo(New ReservasiForm())
    End Sub

    Private Sub mnuNavCheckIn_Click(sender As Object, e As EventArgs) Handles mnuNavCheckIn.Click
        NavigateTo(New CheckInForm())
    End Sub

    Private Sub mnuNavCheckOut_Click(sender As Object, e As EventArgs) Handles mnuNavCheckOut.Click
        NavigateTo(New CheckOutForm())
    End Sub

    ' ── Master menu (admin only) ──────────────────────────
    Private Sub mnuNavTipeKamar_Click(sender As Object, e As EventArgs) Handles mnuNavTipeKamar.Click
        If SessionRole.ToLower() = "admin" Then NavigateTo(New TipeKamarForm())
    End Sub

    Private Sub mnuNavProperti_Click(sender As Object, e As EventArgs) Handles mnuNavProperti.Click
        If SessionRole.ToLower() = "admin" Then NavigateTo(New PropertiForm())
    End Sub

    ' ── Laporan menu ──────────────────────────────────────
    Private Sub mnuNavLaporan_Click(sender As Object, e As EventArgs) Handles mnuNavLaporan.Click
        NavigateTo(New LaporanForm())
    End Sub

    ' ── Settings menu ─────────────────────────────────────
    Private Sub mnuSettingsPreferensi_Click(sender As Object, e As EventArgs) Handles mnuSettingsPreferensi.Click
        Dim frm As New SettingsForm()
        frm.ShowDialog()
    End Sub

    Private Sub mnuSettingsBackup_Click(sender As Object, e As EventArgs) Handles mnuSettingsBackup.Click
        BackupData()
    End Sub

    Private Sub mnuSettingsAbout_Click(sender As Object, e As EventArgs) Handles mnuSettingsAbout.Click
        MsgBox("Hotel Receptionist System" & vbNewLine &
               "Versi 1.0.0" & vbNewLine & vbNewLine &
               "Sistem manajemen resepsionis hotel" & vbNewLine &
               "© 2026 Hotel System",
               MsgBoxStyle.Information, "Tentang Aplikasi")
    End Sub

    ' ── Card buttons ──────────────────────────────────────
    Private Sub btnTamu_Click(sender As Object, e As EventArgs) Handles btnTamu.Click
        NavigateTo(New TamuForm())
    End Sub

    Private Sub btnKamar_Click(sender As Object, e As EventArgs) Handles btnKamar.Click
        NavigateTo(New KamarForm())
    End Sub

    Private Sub btnReservasi_Click(sender As Object, e As EventArgs) Handles btnReservasi.Click
        NavigateTo(New ReservasiForm())
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        NavigateTo(New CheckInForm())
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        NavigateTo(New CheckOutForm())
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        NavigateTo(New LaporanForm())
    End Sub

    Private Sub btnTipeKamar_Click(sender As Object, e As EventArgs) Handles btnTipeKamar.Click
        NavigateTo(New TipeKamarForm())
    End Sub

    Private Sub btnProperti_Click(sender As Object, e As EventArgs) Handles btnProperti.Click
        NavigateTo(New PropertiForm())
    End Sub

    ' ════════════════════════════════════════════════════
    ' NAVIGATE — tutup semua child lalu buka yang baru
    ' ════════════════════════════════════════════════════
    Private Sub NavigateTo(frm As Form)
        ' Kalau form yang sama sudah terbuka, aktifkan saja
        For Each child As Form In Me.MdiChildren
            If child.GetType() = frm.GetType() Then
                child.Activate()
                frm.Dispose()
                pnlDashboard.Visible = False
                Exit Sub
            End If
        Next

        ' Tutup semua child yang sedang terbuka
        CloseAllChildren()

        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
        pnlDashboard.Visible = False
    End Sub

    Private Sub CloseAllChildren()
        For Each child As Form In Me.MdiChildren
            child.Close()
        Next
    End Sub

    ' ════════════════════════════════════════════════════
    ' BACKUP DATA
    ' ════════════════════════════════════════════════════
    Private Sub BackupData()
        Using fbd As New FolderBrowserDialog()
            fbd.Description = "Pilih folder tujuan backup"
            If fbd.ShowDialog() = DialogResult.OK Then
                Try
                    Dim fileName As String = "HotelBackup_" &
                                             DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".csv"
                    Dim filePath As String = IO.Path.Combine(fbd.SelectedPath, fileName)

                    Dim sb As New System.Text.StringBuilder()
                    sb.AppendLine("=== HOTEL RECEPTIONIST SYSTEM BACKUP ===")
                    sb.AppendLine("Tanggal Backup : " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"))
                    sb.AppendLine("User           : " & ActiveUser)
                    sb.AppendLine()

                    ' Backup reservasi
                    If ReservasiForm.IsSharedLoaded Then
                        sb.AppendLine("=== DATA RESERVASI ===")
                        sb.AppendLine("id_reservasi,nama_tamu,nomor_kamar,tipe_reservasi,tgl_reservasi,tgl_checkin,tgl_checkout,harga_kamar,status")
                        For Each dr As DataRow In ReservasiForm.dtReservasiShared.Rows
                            sb.AppendLine(String.Join(",",
                                dr("id_reservasi"), dr("nama_tamu"), dr("nomor_kamar"),
                                dr("tipe_reservasi"), dr("tgl_reservasi"), dr("tgl_checkin"),
                                dr("tgl_checkout"), dr("harga_kamar"), dr("status")))
                        Next
                        sb.AppendLine()
                    End If

                    ' Backup tipe kamar
                    If TipeKamarForm.IsSharedLoaded Then
                        sb.AppendLine("=== DATA TIPE KAMAR ===")
                        sb.AppendLine("id_tipe,nama_tipe,harga,deskripsi")
                        For Each dr As DataRow In TipeKamarForm.dtTipeShared.Rows
                            sb.AppendLine(String.Join(",",
                                dr("id_tipe"), dr("nama_tipe"), dr("harga"), dr("deskripsi")))
                        Next
                        sb.AppendLine()
                    End If

                    ' Backup properti
                    If PropertiForm.IsSharedLoaded Then
                        sb.AppendLine("=== DATA PROPERTI ===")
                        sb.AppendLine("id_properti,nama_properti,biaya_denda")
                        For Each dr As DataRow In PropertiForm.dtPropertiShared.Rows
                            sb.AppendLine(String.Join(",",
                                dr("id_properti"), dr("nama_properti"), dr("biaya_denda")))
                        Next
                    End If

                    IO.File.WriteAllText(filePath, sb.ToString(), System.Text.Encoding.UTF8)
                    MsgBox("Backup berhasil!" & vbNewLine & filePath,
                           MsgBoxStyle.Information, "Backup Selesai")

                Catch ex As Exception
                    MsgBox("Backup gagal: " & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        End Using
    End Sub

End Class