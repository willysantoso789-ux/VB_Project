Public Class MainForm

    Public Shared LoggedIn As Boolean = False
    Public Shared ActiveUser As String = ""
    Public Shared SessionRole As String = ""

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetMenuVisibility(False)
        UpdateStatus()
        lblStatusDB.Text = "● DB: Not Connected"
        lblStatusDB.ForeColor = System.Drawing.Color.Yellow
    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        lblStatusTime.Text = DateTime.Now.ToString("HH:mm:ss")
        lblStatusDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy")
    End Sub

    ' ── Visibility berdasarkan login & role ───────────────
    Public Sub SetMenuVisibility(isLoggedIn As Boolean)
        mnuProfile.Visible = isLoggedIn
        mnuSep1.Visible = isLoggedIn
        mnuLogout.Visible = isLoggedIn
        mnuLogin.Visible = Not isLoggedIn
        pnlDashboard.Visible = isLoggedIn

        ' Card admin only
        Dim isAdmin As Boolean = isLoggedIn AndAlso
                                 SessionRole.ToLower() = "admin"
        pnlCardTipeKamar.Visible = isAdmin
        pnlCardProperti.Visible = isAdmin
    End Sub

    Private Sub UpdateStatus()
        If LoggedIn Then
            lblStatusUser.Text = "User: " & ActiveUser &
                                 "  |  Role: " & SessionRole
            lblWelcome.Text = "Selamat Datang, " & ActiveUser
            lblWelcomeSub.Text = "Hotel Receptionist System  ·  " &
                                 DateTime.Now.ToString("dddd, dd MMMM yyyy") &
                                 "  ·  " & SessionRole
        Else
            lblStatusUser.Text = "User: -"
        End If
    End Sub

    ' ── MDI child activate → dashboard toggle ─────────────
    Private Sub MainForm_MdiChildActivate(sender As Object, e As EventArgs) Handles Me.MdiChildActivate
        If Me.ActiveMdiChild Is Nothing AndAlso LoggedIn Then
            pnlDashboard.Visible = True
        End If
    End Sub

    ' ── Menu ──────────────────────────────────────────────
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
            For Each child As Form In Me.MdiChildren
                child.Close()
            Next
        End If
    End Sub

    Private Sub mnuProfile_Click(sender As Object, e As EventArgs) Handles mnuProfile.Click
        MsgBox("User : " & ActiveUser & vbNewLine &
               "Role : " & SessionRole,
               MsgBoxStyle.Information, "Profile")
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        If MsgBox("Yakin ingin keluar?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Keluar") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' ── Cards semua role ──────────────────────────────────
    Private Sub btnTamu_Click(sender As Object, e As EventArgs) Handles btnTamu.Click
        OpenChild(New DataTamuForm())
    End Sub

    Private Sub btnKamar_Click(sender As Object, e As EventArgs) Handles btnKamar.Click
        OpenChild(New DataKamarForm())
    End Sub

    Private Sub btnReservasi_Click(sender As Object, e As EventArgs) Handles btnReservasi.Click
        OpenChild(New Reservasi())
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        OpenChild(New CheckIn())
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        OpenChild(New CheckOut())
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        MsgBox("Laporan — coming soon", MsgBoxStyle.Information)
    End Sub

    ' ── Cards admin only ──────────────────────────────────
    Private Sub btnTipeKamar_Click(sender As Object, e As EventArgs) Handles btnTipeKamar.Click
        OpenChild(New DataTipeKamar())
    End Sub

    Private Sub btnProperti_Click(sender As Object, e As EventArgs) Handles btnProperti.Click
        OpenChild(New DataProperti())
    End Sub

    ' ── Helper ────────────────────────────────────────────
    Private Sub OpenChild(frm As Form)
        For Each child As Form In Me.MdiChildren
            If child.GetType() = frm.GetType() Then
                child.Activate()
                frm.Dispose()
                pnlDashboard.Visible = False
                Exit Sub
            End If
        Next
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
        pnlDashboard.Visible = False
    End Sub
End Class