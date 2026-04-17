<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuItemMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ssBottom = New System.Windows.Forms.StatusStrip()
        Me.lblStatusDB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatusSep1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatusUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatusSep2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatusTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatusDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblWelcomeSub = New System.Windows.Forms.Label()
        Me.lblSectionTitle = New System.Windows.Forms.Label()
        Me.pnlSectionLine = New System.Windows.Forms.Panel()
        Me.pnlCardTamu = New System.Windows.Forms.Panel()
        Me.lblCardTamuTitle = New System.Windows.Forms.Label()
        Me.lblCardTamuDesc = New System.Windows.Forms.Label()
        Me.btnTamu = New System.Windows.Forms.Button()
        Me.pnlCardKamar = New System.Windows.Forms.Panel()
        Me.lblCardKamarTitle = New System.Windows.Forms.Label()
        Me.lblCardKamarDesc = New System.Windows.Forms.Label()
        Me.btnKamar = New System.Windows.Forms.Button()
        Me.pnlCardReservasi = New System.Windows.Forms.Panel()
        Me.lblCardReservasiTitle = New System.Windows.Forms.Label()
        Me.lblCardReservasiDesc = New System.Windows.Forms.Label()
        Me.btnReservasi = New System.Windows.Forms.Button()
        Me.pnlCardCheckIn = New System.Windows.Forms.Panel()
        Me.lblCardCheckInTitle = New System.Windows.Forms.Label()
        Me.lblCardCheckInDesc = New System.Windows.Forms.Label()
        Me.btnCheckIn = New System.Windows.Forms.Button()
        Me.pnlCardCheckOut = New System.Windows.Forms.Panel()
        Me.lblCardCheckOutTitle = New System.Windows.Forms.Label()
        Me.lblCardCheckOutDesc = New System.Windows.Forms.Label()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.pnlCardLaporan = New System.Windows.Forms.Panel()
        Me.lblCardLaporanTitle = New System.Windows.Forms.Label()
        Me.lblCardLaporanDesc = New System.Windows.Forms.Label()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.picTamu = New System.Windows.Forms.PictureBox()
        Me.picKamar = New System.Windows.Forms.PictureBox()
        Me.picReservasi = New System.Windows.Forms.PictureBox()
        Me.picCheckIn = New System.Windows.Forms.PictureBox()
        Me.picCheckOut = New System.Windows.Forms.PictureBox()
        Me.picLaporan = New System.Windows.Forms.PictureBox()
        Me.mnuMain.SuspendLayout()
        Me.ssBottom.SuspendLayout()
        Me.pnlDashboard.SuspendLayout()
        Me.pnlCardTamu.SuspendLayout()
        Me.pnlCardKamar.SuspendLayout()
        Me.pnlCardReservasi.SuspendLayout()
        Me.pnlCardCheckIn.SuspendLayout()
        Me.pnlCardCheckOut.SuspendLayout()
        Me.pnlCardLaporan.SuspendLayout()
        CType(Me.picTamu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picReservasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCheckOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mnuMain.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mnuMain.ForeColor = System.Drawing.Color.White
        Me.mnuMain.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuMain.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItemMain})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(947, 36)
        Me.mnuMain.TabIndex = 3
        '
        'mnuItemMain
        '
        Me.mnuItemMain.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProfile, Me.mnuSep1, Me.mnuLogin, Me.mnuLogout, Me.mnuSep2, Me.mnuExit})
        Me.mnuItemMain.ForeColor = System.Drawing.Color.White
        Me.mnuItemMain.Name = "mnuItemMain"
        Me.mnuItemMain.Size = New System.Drawing.Size(73, 30)
        Me.mnuItemMain.Text = "Menu"
        '
        'mnuProfile
        '
        Me.mnuProfile.Name = "mnuProfile"
        Me.mnuProfile.Size = New System.Drawing.Size(171, 34)
        Me.mnuProfile.Text = "Profile"
        Me.mnuProfile.Visible = False
        '
        'mnuSep1
        '
        Me.mnuSep1.Name = "mnuSep1"
        Me.mnuSep1.Size = New System.Drawing.Size(168, 6)
        Me.mnuSep1.Visible = False
        '
        'mnuLogin
        '
        Me.mnuLogin.Name = "mnuLogin"
        Me.mnuLogin.Size = New System.Drawing.Size(171, 34)
        Me.mnuLogin.Text = "Login"
        '
        'mnuLogout
        '
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(171, 34)
        Me.mnuLogout.Text = "Logout"
        Me.mnuLogout.Visible = False
        '
        'mnuSep2
        '
        Me.mnuSep2.Name = "mnuSep2"
        Me.mnuSep2.Size = New System.Drawing.Size(168, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(171, 34)
        Me.mnuExit.Text = "Keluar"
        '
        'ssBottom
        '
        Me.ssBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ssBottom.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.ssBottom.ForeColor = System.Drawing.Color.White
        Me.ssBottom.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ssBottom.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatusDB, Me.lblStatusSep1, Me.lblStatusUser, Me.lblStatusSep2, Me.lblStatusTime, Me.lblStatusDate})
        Me.ssBottom.Location = New System.Drawing.Point(0, 609)
        Me.ssBottom.Name = "ssBottom"
        Me.ssBottom.Size = New System.Drawing.Size(947, 30)
        Me.ssBottom.TabIndex = 2
        '
        'lblStatusDB
        '
        Me.lblStatusDB.ForeColor = System.Drawing.Color.Yellow
        Me.lblStatusDB.Name = "lblStatusDB"
        Me.lblStatusDB.Size = New System.Drawing.Size(173, 23)
        Me.lblStatusDB.Text = "● DB: Not Connected"
        '
        'lblStatusSep1
        '
        Me.lblStatusSep1.Name = "lblStatusSep1"
        Me.lblStatusSep1.Size = New System.Drawing.Size(34, 23)
        Me.lblStatusSep1.Text = "  |  "
        '
        'lblStatusUser
        '
        Me.lblStatusUser.ForeColor = System.Drawing.Color.White
        Me.lblStatusUser.Name = "lblStatusUser"
        Me.lblStatusUser.Size = New System.Drawing.Size(60, 23)
        Me.lblStatusUser.Text = "User: -"
        '
        'lblStatusSep2
        '
        Me.lblStatusSep2.Name = "lblStatusSep2"
        Me.lblStatusSep2.Size = New System.Drawing.Size(34, 23)
        Me.lblStatusSep2.Text = "  |  "
        '
        'lblStatusTime
        '
        Me.lblStatusTime.ForeColor = System.Drawing.Color.White
        Me.lblStatusTime.Name = "lblStatusTime"
        Me.lblStatusTime.Size = New System.Drawing.Size(72, 23)
        Me.lblStatusTime.Text = "00:00:00"
        '
        'lblStatusDate
        '
        Me.lblStatusDate.ForeColor = System.Drawing.Color.LightCyan
        Me.lblStatusDate.Name = "lblStatusDate"
        Me.lblStatusDate.Size = New System.Drawing.Size(559, 23)
        Me.lblStatusDate.Spring = True
        Me.lblStatusDate.Text = "01/01/2026"
        Me.lblStatusDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tmrClock
        '
        Me.tmrClock.Enabled = True
        Me.tmrClock.Interval = 1000
        '
        'pnlDashboard
        '
        Me.pnlDashboard.AutoScroll = True
        Me.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlDashboard.Controls.Add(Me.lblWelcome)
        Me.pnlDashboard.Controls.Add(Me.lblWelcomeSub)
        Me.pnlDashboard.Controls.Add(Me.lblSectionTitle)
        Me.pnlDashboard.Controls.Add(Me.pnlSectionLine)
        Me.pnlDashboard.Controls.Add(Me.pnlCardTamu)
        Me.pnlDashboard.Controls.Add(Me.pnlCardKamar)
        Me.pnlDashboard.Controls.Add(Me.pnlCardReservasi)
        Me.pnlDashboard.Controls.Add(Me.pnlCardCheckIn)
        Me.pnlDashboard.Controls.Add(Me.pnlCardCheckOut)
        Me.pnlDashboard.Controls.Add(Me.pnlCardLaporan)
        Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboard.Location = New System.Drawing.Point(0, 36)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(947, 573)
        Me.pnlDashboard.TabIndex = 1
        Me.pnlDashboard.Visible = False
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(24, 24)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(800, 34)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Selamat Datang"
        '
        'lblWelcomeSub
        '
        Me.lblWelcomeSub.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcomeSub.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblWelcomeSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblWelcomeSub.Location = New System.Drawing.Point(24, 60)
        Me.lblWelcomeSub.Name = "lblWelcomeSub"
        Me.lblWelcomeSub.Size = New System.Drawing.Size(800, 22)
        Me.lblWelcomeSub.TabIndex = 1
        Me.lblWelcomeSub.Text = "Hotel Receptionist System  ·  Senin, 31 Maret 2026"
        '
        'lblSectionTitle
        '
        Me.lblSectionTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSectionTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblSectionTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblSectionTitle.Location = New System.Drawing.Point(24, 98)
        Me.lblSectionTitle.Name = "lblSectionTitle"
        Me.lblSectionTitle.Size = New System.Drawing.Size(200, 18)
        Me.lblSectionTitle.TabIndex = 2
        Me.lblSectionTitle.Text = "FITUR UTAMA"
        '
        'pnlSectionLine
        '
        Me.pnlSectionLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlSectionLine.Location = New System.Drawing.Point(24, 118)
        Me.pnlSectionLine.Name = "pnlSectionLine"
        Me.pnlSectionLine.Size = New System.Drawing.Size(900, 1)
        Me.pnlSectionLine.TabIndex = 3
        '
        'pnlCardTamu
        '
        Me.pnlCardTamu.BackColor = System.Drawing.Color.White
        Me.pnlCardTamu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCardTamu.Controls.Add(Me.picTamu)
        Me.pnlCardTamu.Controls.Add(Me.lblCardTamuTitle)
        Me.pnlCardTamu.Controls.Add(Me.lblCardTamuDesc)
        Me.pnlCardTamu.Controls.Add(Me.btnTamu)
        Me.pnlCardTamu.Location = New System.Drawing.Point(24, 128)
        Me.pnlCardTamu.Name = "pnlCardTamu"
        Me.pnlCardTamu.Size = New System.Drawing.Size(280, 200)
        Me.pnlCardTamu.TabIndex = 4
        '
        'lblCardTamuTitle
        '
        Me.lblCardTamuTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCardTamuTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardTamuTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lblCardTamuTitle.Location = New System.Drawing.Point(16, 70)
        Me.lblCardTamuTitle.Name = "lblCardTamuTitle"
        Me.lblCardTamuTitle.Size = New System.Drawing.Size(248, 22)
        Me.lblCardTamuTitle.TabIndex = 1
        Me.lblCardTamuTitle.Text = "Data Tamu"
        '
        'lblCardTamuDesc
        '
        Me.lblCardTamuDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblCardTamuDesc.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblCardTamuDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblCardTamuDesc.Location = New System.Drawing.Point(16, 96)
        Me.lblCardTamuDesc.Name = "lblCardTamuDesc"
        Me.lblCardTamuDesc.Size = New System.Drawing.Size(248, 50)
        Me.lblCardTamuDesc.TabIndex = 2
        Me.lblCardTamuDesc.Text = "Kelola data tamu hotel, tambah, edit, dan hapus data."
        '
        'btnTamu
        '
        Me.btnTamu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnTamu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTamu.FlatAppearance.BorderSize = 0
        Me.btnTamu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTamu.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnTamu.ForeColor = System.Drawing.Color.White
        Me.btnTamu.Location = New System.Drawing.Point(16, 152)
        Me.btnTamu.Name = "btnTamu"
        Me.btnTamu.Size = New System.Drawing.Size(90, 32)
        Me.btnTamu.TabIndex = 3
        Me.btnTamu.Text = "Buka"
        Me.btnTamu.UseVisualStyleBackColor = False
        '
        'pnlCardKamar
        '
        Me.pnlCardKamar.BackColor = System.Drawing.Color.White
        Me.pnlCardKamar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCardKamar.Controls.Add(Me.picKamar)
        Me.pnlCardKamar.Controls.Add(Me.lblCardKamarTitle)
        Me.pnlCardKamar.Controls.Add(Me.lblCardKamarDesc)
        Me.pnlCardKamar.Controls.Add(Me.btnKamar)
        Me.pnlCardKamar.Location = New System.Drawing.Point(324, 128)
        Me.pnlCardKamar.Name = "pnlCardKamar"
        Me.pnlCardKamar.Size = New System.Drawing.Size(280, 200)
        Me.pnlCardKamar.TabIndex = 5
        '
        'lblCardKamarTitle
        '
        Me.lblCardKamarTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCardKamarTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardKamarTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblCardKamarTitle.Location = New System.Drawing.Point(16, 70)
        Me.lblCardKamarTitle.Name = "lblCardKamarTitle"
        Me.lblCardKamarTitle.Size = New System.Drawing.Size(248, 22)
        Me.lblCardKamarTitle.TabIndex = 1
        Me.lblCardKamarTitle.Text = "Data Kamar"
        '
        'lblCardKamarDesc
        '
        Me.lblCardKamarDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblCardKamarDesc.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblCardKamarDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblCardKamarDesc.Location = New System.Drawing.Point(16, 96)
        Me.lblCardKamarDesc.Name = "lblCardKamarDesc"
        Me.lblCardKamarDesc.Size = New System.Drawing.Size(248, 50)
        Me.lblCardKamarDesc.TabIndex = 2
        Me.lblCardKamarDesc.Text = "Kelola inventaris kamar dan tipe kamar hotel."
        '
        'btnKamar
        '
        Me.btnKamar.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnKamar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKamar.FlatAppearance.BorderSize = 0
        Me.btnKamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKamar.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnKamar.ForeColor = System.Drawing.Color.White
        Me.btnKamar.Location = New System.Drawing.Point(16, 152)
        Me.btnKamar.Name = "btnKamar"
        Me.btnKamar.Size = New System.Drawing.Size(90, 32)
        Me.btnKamar.TabIndex = 3
        Me.btnKamar.Text = "Buka"
        Me.btnKamar.UseVisualStyleBackColor = False
        '
        'pnlCardReservasi
        '
        Me.pnlCardReservasi.BackColor = System.Drawing.Color.White
        Me.pnlCardReservasi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCardReservasi.Controls.Add(Me.picReservasi)
        Me.pnlCardReservasi.Controls.Add(Me.lblCardReservasiTitle)
        Me.pnlCardReservasi.Controls.Add(Me.lblCardReservasiDesc)
        Me.pnlCardReservasi.Controls.Add(Me.btnReservasi)
        Me.pnlCardReservasi.Location = New System.Drawing.Point(624, 128)
        Me.pnlCardReservasi.Name = "pnlCardReservasi"
        Me.pnlCardReservasi.Size = New System.Drawing.Size(280, 200)
        Me.pnlCardReservasi.TabIndex = 6
        '
        'lblCardReservasiTitle
        '
        Me.lblCardReservasiTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCardReservasiTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardReservasiTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.lblCardReservasiTitle.Location = New System.Drawing.Point(16, 70)
        Me.lblCardReservasiTitle.Name = "lblCardReservasiTitle"
        Me.lblCardReservasiTitle.Size = New System.Drawing.Size(248, 22)
        Me.lblCardReservasiTitle.TabIndex = 1
        Me.lblCardReservasiTitle.Text = "Reservasi"
        '
        'lblCardReservasiDesc
        '
        Me.lblCardReservasiDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblCardReservasiDesc.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblCardReservasiDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblCardReservasiDesc.Location = New System.Drawing.Point(16, 96)
        Me.lblCardReservasiDesc.Name = "lblCardReservasiDesc"
        Me.lblCardReservasiDesc.Size = New System.Drawing.Size(248, 50)
        Me.lblCardReservasiDesc.TabIndex = 2
        Me.lblCardReservasiDesc.Text = "Buat dan kelola reservasi tamu hotel."
        '
        'btnReservasi
        '
        Me.btnReservasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnReservasi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReservasi.FlatAppearance.BorderSize = 0
        Me.btnReservasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservasi.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnReservasi.ForeColor = System.Drawing.Color.White
        Me.btnReservasi.Location = New System.Drawing.Point(16, 152)
        Me.btnReservasi.Name = "btnReservasi"
        Me.btnReservasi.Size = New System.Drawing.Size(90, 32)
        Me.btnReservasi.TabIndex = 3
        Me.btnReservasi.Text = "Buka"
        Me.btnReservasi.UseVisualStyleBackColor = False
        '
        'pnlCardCheckIn
        '
        Me.pnlCardCheckIn.BackColor = System.Drawing.Color.White
        Me.pnlCardCheckIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCardCheckIn.Controls.Add(Me.picCheckIn)
        Me.pnlCardCheckIn.Controls.Add(Me.lblCardCheckInTitle)
        Me.pnlCardCheckIn.Controls.Add(Me.lblCardCheckInDesc)
        Me.pnlCardCheckIn.Controls.Add(Me.btnCheckIn)
        Me.pnlCardCheckIn.Location = New System.Drawing.Point(24, 348)
        Me.pnlCardCheckIn.Name = "pnlCardCheckIn"
        Me.pnlCardCheckIn.Size = New System.Drawing.Size(280, 200)
        Me.pnlCardCheckIn.TabIndex = 7
        '
        'lblCardCheckInTitle
        '
        Me.lblCardCheckInTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCardCheckInTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardCheckInTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblCardCheckInTitle.Location = New System.Drawing.Point(16, 70)
        Me.lblCardCheckInTitle.Name = "lblCardCheckInTitle"
        Me.lblCardCheckInTitle.Size = New System.Drawing.Size(248, 22)
        Me.lblCardCheckInTitle.TabIndex = 1
        Me.lblCardCheckInTitle.Text = "Check-In"
        '
        'lblCardCheckInDesc
        '
        Me.lblCardCheckInDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblCardCheckInDesc.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblCardCheckInDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblCardCheckInDesc.Location = New System.Drawing.Point(16, 96)
        Me.lblCardCheckInDesc.Name = "lblCardCheckInDesc"
        Me.lblCardCheckInDesc.Size = New System.Drawing.Size(248, 50)
        Me.lblCardCheckInDesc.TabIndex = 2
        Me.lblCardCheckInDesc.Text = "Proses check-in tamu yang memiliki reservasi."
        '
        'btnCheckIn
        '
        Me.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckIn.FlatAppearance.BorderSize = 0
        Me.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckIn.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnCheckIn.ForeColor = System.Drawing.Color.White
        Me.btnCheckIn.Location = New System.Drawing.Point(16, 152)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(90, 32)
        Me.btnCheckIn.TabIndex = 3
        Me.btnCheckIn.Text = "Buka"
        Me.btnCheckIn.UseVisualStyleBackColor = False
        '
        'pnlCardCheckOut
        '
        Me.pnlCardCheckOut.BackColor = System.Drawing.Color.White
        Me.pnlCardCheckOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCardCheckOut.Controls.Add(Me.picCheckOut)
        Me.pnlCardCheckOut.Controls.Add(Me.lblCardCheckOutTitle)
        Me.pnlCardCheckOut.Controls.Add(Me.lblCardCheckOutDesc)
        Me.pnlCardCheckOut.Controls.Add(Me.btnCheckOut)
        Me.pnlCardCheckOut.Location = New System.Drawing.Point(324, 348)
        Me.pnlCardCheckOut.Name = "pnlCardCheckOut"
        Me.pnlCardCheckOut.Size = New System.Drawing.Size(280, 200)
        Me.pnlCardCheckOut.TabIndex = 8
        '
        'lblCardCheckOutTitle
        '
        Me.lblCardCheckOutTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCardCheckOutTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardCheckOutTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblCardCheckOutTitle.Location = New System.Drawing.Point(16, 70)
        Me.lblCardCheckOutTitle.Name = "lblCardCheckOutTitle"
        Me.lblCardCheckOutTitle.Size = New System.Drawing.Size(248, 22)
        Me.lblCardCheckOutTitle.TabIndex = 1
        Me.lblCardCheckOutTitle.Text = "Check-Out"
        '
        'lblCardCheckOutDesc
        '
        Me.lblCardCheckOutDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblCardCheckOutDesc.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblCardCheckOutDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblCardCheckOutDesc.Location = New System.Drawing.Point(16, 96)
        Me.lblCardCheckOutDesc.Name = "lblCardCheckOutDesc"
        Me.lblCardCheckOutDesc.Size = New System.Drawing.Size(248, 50)
        Me.lblCardCheckOutDesc.TabIndex = 2
        Me.lblCardCheckOutDesc.Text = "Proses check-out dan hitung total biaya tamu."
        '
        'btnCheckOut
        '
        Me.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckOut.FlatAppearance.BorderSize = 0
        Me.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckOut.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnCheckOut.ForeColor = System.Drawing.Color.White
        Me.btnCheckOut.Location = New System.Drawing.Point(16, 152)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(90, 32)
        Me.btnCheckOut.TabIndex = 3
        Me.btnCheckOut.Text = "Buka"
        Me.btnCheckOut.UseVisualStyleBackColor = False
        '
        'pnlCardLaporan
        '
        Me.pnlCardLaporan.BackColor = System.Drawing.Color.White
        Me.pnlCardLaporan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCardLaporan.Controls.Add(Me.picLaporan)
        Me.pnlCardLaporan.Controls.Add(Me.lblCardLaporanTitle)
        Me.pnlCardLaporan.Controls.Add(Me.lblCardLaporanDesc)
        Me.pnlCardLaporan.Controls.Add(Me.btnLaporan)
        Me.pnlCardLaporan.Location = New System.Drawing.Point(624, 348)
        Me.pnlCardLaporan.Name = "pnlCardLaporan"
        Me.pnlCardLaporan.Size = New System.Drawing.Size(280, 200)
        Me.pnlCardLaporan.TabIndex = 9
        '
        'lblCardLaporanTitle
        '
        Me.lblCardLaporanTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCardLaporanTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardLaporanTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.lblCardLaporanTitle.Location = New System.Drawing.Point(16, 70)
        Me.lblCardLaporanTitle.Name = "lblCardLaporanTitle"
        Me.lblCardLaporanTitle.Size = New System.Drawing.Size(248, 22)
        Me.lblCardLaporanTitle.TabIndex = 1
        Me.lblCardLaporanTitle.Text = "Laporan"
        '
        'lblCardLaporanDesc
        '
        Me.lblCardLaporanDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblCardLaporanDesc.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblCardLaporanDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblCardLaporanDesc.Location = New System.Drawing.Point(16, 96)
        Me.lblCardLaporanDesc.Name = "lblCardLaporanDesc"
        Me.lblCardLaporanDesc.Size = New System.Drawing.Size(248, 50)
        Me.lblCardLaporanDesc.TabIndex = 2
        Me.lblCardLaporanDesc.Text = "Lihat laporan transaksi dan rekap reservasi."
        '
        'btnLaporan
        '
        Me.btnLaporan.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnLaporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLaporan.FlatAppearance.BorderSize = 0
        Me.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporan.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnLaporan.ForeColor = System.Drawing.Color.White
        Me.btnLaporan.Location = New System.Drawing.Point(16, 152)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(90, 32)
        Me.btnLaporan.TabIndex = 3
        Me.btnLaporan.Text = "Buka"
        Me.btnLaporan.UseVisualStyleBackColor = False
        '
        'picTamu
        '
        Me.picTamu.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.picTamu.Image = Global.VB_PROJECT.My.Resources.Resources.group
        Me.picTamu.Location = New System.Drawing.Point(16, 16)
        Me.picTamu.Name = "picTamu"
        Me.picTamu.Size = New System.Drawing.Size(44, 44)
        Me.picTamu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTamu.TabIndex = 0
        Me.picTamu.TabStop = False
        '
        'picKamar
        '
        Me.picKamar.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.picKamar.Image = Global.VB_PROJECT.My.Resources.Resources.sleeping
        Me.picKamar.Location = New System.Drawing.Point(16, 16)
        Me.picKamar.Name = "picKamar"
        Me.picKamar.Size = New System.Drawing.Size(44, 44)
        Me.picKamar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKamar.TabIndex = 0
        Me.picKamar.TabStop = False
        '
        'picReservasi
        '
        Me.picReservasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.picReservasi.Image = Global.VB_PROJECT.My.Resources.Resources.calendar
        Me.picReservasi.Location = New System.Drawing.Point(16, 16)
        Me.picReservasi.Name = "picReservasi"
        Me.picReservasi.Size = New System.Drawing.Size(44, 44)
        Me.picReservasi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picReservasi.TabIndex = 0
        Me.picReservasi.TabStop = False
        '
        'picCheckIn
        '
        Me.picCheckIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.picCheckIn.Image = Global.VB_PROJECT.My.Resources.Resources.check_in_desk
        Me.picCheckIn.Location = New System.Drawing.Point(16, 16)
        Me.picCheckIn.Name = "picCheckIn"
        Me.picCheckIn.Size = New System.Drawing.Size(44, 44)
        Me.picCheckIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCheckIn.TabIndex = 0
        Me.picCheckIn.TabStop = False
        '
        'picCheckOut
        '
        Me.picCheckOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.picCheckOut.Image = Global.VB_PROJECT.My.Resources.Resources.check_out
        Me.picCheckOut.Location = New System.Drawing.Point(16, 16)
        Me.picCheckOut.Name = "picCheckOut"
        Me.picCheckOut.Size = New System.Drawing.Size(44, 44)
        Me.picCheckOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCheckOut.TabIndex = 0
        Me.picCheckOut.TabStop = False
        '
        'picLaporan
        '
        Me.picLaporan.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.picLaporan.Image = Global.VB_PROJECT.My.Resources.Resources.report
        Me.picLaporan.Location = New System.Drawing.Point(16, 16)
        Me.picLaporan.Name = "picLaporan"
        Me.picLaporan.Size = New System.Drawing.Size(44, 44)
        Me.picLaporan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLaporan.TabIndex = 0
        Me.picLaporan.TabStop = False
        '
        'MainForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(947, 639)
        Me.Controls.Add(Me.pnlDashboard)
        Me.Controls.Add(Me.ssBottom)
        Me.Controls.Add(Me.mnuMain)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMain
        Me.MinimumSize = New System.Drawing.Size(900, 550)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel Receptionist System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ssBottom.ResumeLayout(False)
        Me.ssBottom.PerformLayout()
        Me.pnlDashboard.ResumeLayout(False)
        Me.pnlCardTamu.ResumeLayout(False)
        Me.pnlCardKamar.ResumeLayout(False)
        Me.pnlCardReservasi.ResumeLayout(False)
        Me.pnlCardCheckIn.ResumeLayout(False)
        Me.pnlCardCheckOut.ResumeLayout(False)
        Me.pnlCardLaporan.ResumeLayout(False)
        CType(Me.picTamu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKamar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picReservasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCheckOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' ════════════════════════════════════════════════════
    ' DECLARATIONS
    ' ════════════════════════════════════════════════════
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuItemMain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProfile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ssBottom As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatusDB As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStatusSep1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStatusUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStatusSep2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStatusTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblStatusDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrClock As System.Windows.Forms.Timer
    Friend WithEvents pnlDashboard As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblWelcomeSub As System.Windows.Forms.Label
    Friend WithEvents lblSectionTitle As System.Windows.Forms.Label
    Friend WithEvents pnlSectionLine As System.Windows.Forms.Panel
    Friend WithEvents pnlCardTamu As System.Windows.Forms.Panel
    Friend WithEvents picTamu As System.Windows.Forms.PictureBox
    Friend WithEvents lblCardTamuTitle As System.Windows.Forms.Label
    Friend WithEvents lblCardTamuDesc As System.Windows.Forms.Label
    Friend WithEvents btnTamu As System.Windows.Forms.Button
    Friend WithEvents pnlCardKamar As System.Windows.Forms.Panel
    Friend WithEvents picKamar As System.Windows.Forms.PictureBox
    Friend WithEvents lblCardKamarTitle As System.Windows.Forms.Label
    Friend WithEvents lblCardKamarDesc As System.Windows.Forms.Label
    Friend WithEvents btnKamar As System.Windows.Forms.Button
    Friend WithEvents pnlCardReservasi As System.Windows.Forms.Panel
    Friend WithEvents picReservasi As System.Windows.Forms.PictureBox
    Friend WithEvents lblCardReservasiTitle As System.Windows.Forms.Label
    Friend WithEvents lblCardReservasiDesc As System.Windows.Forms.Label
    Friend WithEvents btnReservasi As System.Windows.Forms.Button
    Friend WithEvents pnlCardCheckIn As System.Windows.Forms.Panel
    Friend WithEvents picCheckIn As System.Windows.Forms.PictureBox
    Friend WithEvents lblCardCheckInTitle As System.Windows.Forms.Label
    Friend WithEvents lblCardCheckInDesc As System.Windows.Forms.Label
    Friend WithEvents btnCheckIn As System.Windows.Forms.Button
    Friend WithEvents pnlCardCheckOut As System.Windows.Forms.Panel
    Friend WithEvents picCheckOut As System.Windows.Forms.PictureBox
    Friend WithEvents lblCardCheckOutTitle As System.Windows.Forms.Label
    Friend WithEvents lblCardCheckOutDesc As System.Windows.Forms.Label
    Friend WithEvents btnCheckOut As System.Windows.Forms.Button
    Friend WithEvents pnlCardLaporan As System.Windows.Forms.Panel
    Friend WithEvents picLaporan As System.Windows.Forms.PictureBox
    Friend WithEvents lblCardLaporanTitle As System.Windows.Forms.Label
    Friend WithEvents lblCardLaporanDesc As System.Windows.Forms.Label
    Friend WithEvents btnLaporan As System.Windows.Forms.Button
End Class