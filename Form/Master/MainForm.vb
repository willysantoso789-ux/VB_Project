Imports VB_PROJECT.HotelDBDataSetTableAdapters

Public Class MainForm

    Public Shared LoggedIn As Boolean = False
    Public Shared ActiveUser As String = ""
    Public Shared SessionRole As String = ""
    Public Shared SessionUserId As Integer = -1

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        SetMenuVisibility(False)
        UpdateStatus()
        CheckDBConnection()
    End Sub

    Private Sub CheckDBConnection()
        If Database.TestConnection() Then
            lblStatusDB.Text = "● DB: Connected"
            lblStatusDB.ForeColor = System.Drawing.Color.LightGreen
        Else
            lblStatusDB.Text = "● DB: Not Connected"
            lblStatusDB.ForeColor = System.Drawing.Color.Yellow
        End If
    End Sub

    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        If AppSettingsManager.ShowClock Then
            lblStatusTime.Text = DateTime.Now.ToString("HH:mm:ss")
            lblStatusDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy")
            lblStatusTime.Visible = True
            lblStatusDate.Visible = True
        Else
            lblStatusTime.Visible = False
        End If
    End Sub

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
        UserManagementToolStripMenuItem.Visible = isAdmin
    End Sub

    Private Sub UpdateStatus()
        If LoggedIn Then
            lblStatusUser.Text = "User: " & ActiveUser & "  |  " & SessionRole
            lblWelcome.Text = "Selamat Datang, " & ActiveUser
            lblWelcomeSub.Text = "Hotel Receptionist System  ·  " &
                                 DateTime.Now.ToString("dddd, dd MMMM yyyy") &
                                 "  ·  " & SessionRole
        Else
            lblStatusUser.Text = "User: -"
        End If
    End Sub

    'Private Sub LoadDashboardSummary()
    '    Try
    '        Dim dt = New sp_GetDashboardSummaryTableAdapter().GetData()
    '        If dt Is Nothing OrElse dt.Rows.Count = 0 Then Exit Sub
    '        Dim dr As System.Data.DataRow = dt.Rows(0)

    '        ' Update label summary di pnlDashboard
    '        ' Sesuaikan nama label dengan yang ada di designer
    '        lblTotalTamu.Text = dr("total_tamu").ToString()
    '        lblKamarTersedia.Text = dr("kamar_tersedia").ToString()
    '        lblKamarTerisi.Text = dr("kamar_terisi").ToString()
    '        lblKamarMaintenance.Text = dr("kamar_maintenance").ToString()
    '        lblReservasiPending.Text = dr("reservasi_pending").ToString()
    '        lblReservasiConfirmed.Text = dr("reservasi_confirmed").ToString()
    '        lblTamuCheckin.Text = dr("tamu_checkin").ToString()
    '        lblPendapatanBulanIni.Text = "Rp " & Convert.ToDecimal(dr("pendapatan_bulan_ini")).ToString("N0")
    '        lblPropertiRusak.Text = dr("properti_rusak").ToString()

    '        ' Warna alert
    '        If Convert.ToInt32(dr("properti_rusak")) > 0 Then
    '            lblPropertiRusak.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
    '        End If
    '        If Convert.ToInt32(dr("reservasi_pending")) > 0 Then
    '            lblReservasiPending.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14)
    '        End If

    '    Catch ex As Exception
    '        ' Dashboard summary tidak critical — silent fail
    '        Console.WriteLine("Dashboard summary error: " & ex.Message)
    '    End Try
    'End Sub

    Private Sub MainForm_MdiChildActivate(sender As Object, e As EventArgs) Handles Me.MdiChildActivate
        If Me.ActiveMdiChild Is Nothing AndAlso LoggedIn Then
            pnlDashboard.Visible = True
        End If
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

    ' ── Menu ──────────────────────────────────────────────
    Private Sub mnuLogin_Click(sender As Object, e As EventArgs) Handles mnuLogin.Click
        Dim frm As New LoginForm()
        frm.ShowDialog()
        If LoggedIn Then
            SetMenuVisibility(True)
            UpdateStatus()
            CheckDBConnection()
        End If
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Dim doLogout As Boolean = True
        If AppSettingsManager.ConfirmLogout Then
            doLogout = (MsgBox("Yakin ingin logout?",
                               MsgBoxStyle.YesNo Or MsgBoxStyle.Question,
                               "Logout") = MsgBoxResult.Yes)
        End If

        If doLogout Then
            LoggedIn = False
            ActiveUser = ""
            SessionRole = ""
            SessionUserId = -1
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
        If MsgBox("Yakin ingin keluar?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question,
                  "Keluar") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' ── Operasional ───────────────────────────────────────
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
    Private Sub mnuNavLaporan_Click(sender As Object, e As EventArgs) Handles mnuNavLaporan.Click
        NavigateTo(New LaporanForm())
    End Sub

    ' ── Master (Admin) ────────────────────────────────────
    Private Sub mnuNavTipeKamar_Click(sender As Object, e As EventArgs) Handles mnuNavTipeKamar.Click
        If SessionRole.ToLower() = "admin" Then NavigateTo(New TipeKamarForm())
    End Sub
    Private Sub mnuNavProperti_Click(sender As Object, e As EventArgs) Handles mnuNavProperti.Click
        If SessionRole.ToLower() = "admin" Then NavigateTo(New PropertiForm())
    End Sub

    ' ── Settings ──────────────────────────────────────────
    Private Sub mnuSettingsPreferensi_Click(sender As Object, e As EventArgs) Handles mnuSettingsPreferensi.Click
        Dim frm As New SettingsForm()
        frm.ShowDialog()
    End Sub

    Private Sub mnuSettingsBackup_Click(sender As Object, e As EventArgs) Handles mnuSettingsBackup.Click
        ProsesBackup()
    End Sub

    Private Sub ProsesBackup()
        Using sfd As New SaveFileDialog()
            sfd.Filter = "SQL Backup (*.bak)|*.bak|Semua File (*.*)|*.*"
            sfd.FileName = "HotelDB_Backup_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".bak"
            sfd.Title = "Simpan Backup Database"

            If sfd.ShowDialog() <> DialogResult.OK Then Exit Sub

            Try
                Dim backupPath As String = sfd.FileName.Replace("'", "''")
                Dim sql As String = $"BACKUP DATABASE [HotelDB] TO DISK = N'{backupPath}' " &
                                 "WITH FORMAT, MEDIANAME = 'HotelDBBackup', " &
                                 "NAME = 'Full Backup HotelDB';"

                Using conn As New System.Data.SqlClient.SqlConnection(AppSettingsManager.ConnString)
                    conn.Open()
                    Using cmd As New System.Data.SqlClient.SqlCommand(sql, conn)
                        cmd.CommandTimeout = 120
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MsgBox("Backup berhasil!" & vbNewLine & "File: " & sfd.FileName,
                   MsgBoxStyle.Information, "Backup Sukses")

            Catch ex As Exception
                MsgBox("Backup gagal:" & vbNewLine & ex.Message,
                   MsgBoxStyle.Critical, "Error Backup")
            End Try
        End Using
    End Sub

    Private Sub UserManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserManagementToolStripMenuItem.Click
        Dim frm As New UserManagementForm()
        frm.ShowDialog()
    End Sub

    Private Sub mnuSettingsAbout_Click(sender As Object, e As EventArgs) Handles mnuSettingsAbout.Click
        MsgBox("Hotel Receptionist System" & vbNewLine &
               "Versi 1.0.0" & vbNewLine & vbNewLine &
               "© 2026 Hotel System",
               MsgBoxStyle.Information, "Tentang Aplikasi")
    End Sub

    ' ── Cards ─────────────────────────────────────────────
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

    ' ── Navigate helper ───────────────────────────────────
    Private Sub NavigateTo(frm As Form)
        For Each child As Form In Me.MdiChildren
            If child.GetType() = frm.GetType() Then
                child.Activate()
                frm.Dispose()
                pnlDashboard.Visible = False
                Exit Sub
            End If
        Next
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
End Class