<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.lblPrefTitle = New System.Windows.Forms.Label()
        Me.lblUserInfo = New System.Windows.Forms.Label()
        Me.pnlDiv1 = New System.Windows.Forms.Panel()
        Me.lblDisplayTitle = New System.Windows.Forms.Label()
        Me.chkShowClock = New System.Windows.Forms.CheckBox()
        Me.chkConfirmLogout = New System.Windows.Forms.CheckBox()
        Me.chkConfirmHapus = New System.Windows.Forms.CheckBox()
        Me.pnlDiv2 = New System.Windows.Forms.Panel()
        Me.lblDendaTitle = New System.Windows.Forms.Label()
        Me.lblDendaNote = New System.Windows.Forms.Label()
        Me.lblDendaPersen = New System.Windows.Forms.Label()
        Me.nudDendaPersen = New System.Windows.Forms.NumericUpDown()
        Me.lblDendaSatuan = New System.Windows.Forms.Label()
        Me.lblDendaWarning = New System.Windows.Forms.Label()
        Me.pnlDiv3 = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        CType(Me.nudDendaPersen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(423, 56)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(16, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(400, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Preferensi Tampilan"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(400, 18)
        Me.lblSubTitle.TabIndex = 1
        Me.lblSubTitle.Text = "Pengaturan tampilan per pengguna"
        '
        'pnlBody
        '
        Me.pnlBody.BackColor = System.Drawing.Color.White
        Me.pnlBody.Controls.Add(Me.lblPrefTitle)
        Me.pnlBody.Controls.Add(Me.lblUserInfo)
        Me.pnlBody.Controls.Add(Me.pnlDiv1)
        Me.pnlBody.Controls.Add(Me.lblDisplayTitle)
        Me.pnlBody.Controls.Add(Me.chkShowClock)
        Me.pnlBody.Controls.Add(Me.chkConfirmLogout)
        Me.pnlBody.Controls.Add(Me.chkConfirmHapus)
        Me.pnlBody.Controls.Add(Me.pnlDiv2)
        Me.pnlBody.Controls.Add(Me.lblDendaTitle)
        Me.pnlBody.Controls.Add(Me.lblDendaNote)
        Me.pnlBody.Controls.Add(Me.lblDendaPersen)
        Me.pnlBody.Controls.Add(Me.nudDendaPersen)
        Me.pnlBody.Controls.Add(Me.lblDendaSatuan)
        Me.pnlBody.Controls.Add(Me.lblDendaWarning)
        Me.pnlBody.Controls.Add(Me.pnlDiv3)
        Me.pnlBody.Controls.Add(Me.btnSimpan)
        Me.pnlBody.Controls.Add(Me.btnReset)
        Me.pnlBody.Controls.Add(Me.btnTutup)
        Me.pnlBody.Location = New System.Drawing.Point(0, 56)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(420, 460)
        Me.pnlBody.TabIndex = 1
        '
        'lblPrefTitle
        '
        Me.lblPrefTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblPrefTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblPrefTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblPrefTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblPrefTitle.Name = "lblPrefTitle"
        Me.lblPrefTitle.Size = New System.Drawing.Size(388, 18)
        Me.lblPrefTitle.TabIndex = 0
        Me.lblPrefTitle.Text = "PREFERENSI PENGGUNA"
        '
        'lblUserInfo
        '
        Me.lblUserInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblUserInfo.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblUserInfo.Location = New System.Drawing.Point(16, 36)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Size = New System.Drawing.Size(388, 20)
        Me.lblUserInfo.TabIndex = 1
        Me.lblUserInfo.Text = "User: —"
        '
        'pnlDiv1
        '
        Me.pnlDiv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlDiv1.Location = New System.Drawing.Point(16, 66)
        Me.pnlDiv1.Name = "pnlDiv1"
        Me.pnlDiv1.Size = New System.Drawing.Size(388, 1)
        Me.pnlDiv1.TabIndex = 2
        '
        'lblDisplayTitle
        '
        Me.lblDisplayTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDisplayTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblDisplayTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblDisplayTitle.Location = New System.Drawing.Point(16, 76)
        Me.lblDisplayTitle.Name = "lblDisplayTitle"
        Me.lblDisplayTitle.Size = New System.Drawing.Size(388, 18)
        Me.lblDisplayTitle.TabIndex = 3
        Me.lblDisplayTitle.Text = "TAMPILAN"
        '
        'chkShowClock
        '
        Me.chkShowClock.Checked = True
        Me.chkShowClock.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowClock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkShowClock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.chkShowClock.Location = New System.Drawing.Point(16, 100)
        Me.chkShowClock.Name = "chkShowClock"
        Me.chkShowClock.Size = New System.Drawing.Size(388, 22)
        Me.chkShowClock.TabIndex = 4
        Me.chkShowClock.Text = "Tampilkan jam di status bar"
        '
        'chkConfirmLogout
        '
        Me.chkConfirmLogout.Checked = True
        Me.chkConfirmLogout.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkConfirmLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkConfirmLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.chkConfirmLogout.Location = New System.Drawing.Point(16, 128)
        Me.chkConfirmLogout.Name = "chkConfirmLogout"
        Me.chkConfirmLogout.Size = New System.Drawing.Size(388, 22)
        Me.chkConfirmLogout.TabIndex = 5
        Me.chkConfirmLogout.Text = "Tampilkan konfirmasi saat logout"
        '
        'chkConfirmHapus
        '
        Me.chkConfirmHapus.Checked = True
        Me.chkConfirmHapus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkConfirmHapus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkConfirmHapus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.chkConfirmHapus.Location = New System.Drawing.Point(16, 156)
        Me.chkConfirmHapus.Name = "chkConfirmHapus"
        Me.chkConfirmHapus.Size = New System.Drawing.Size(388, 22)
        Me.chkConfirmHapus.TabIndex = 6
        Me.chkConfirmHapus.Text = "Tampilkan konfirmasi saat hapus data"
        '
        'pnlDiv2
        '
        Me.pnlDiv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlDiv2.Location = New System.Drawing.Point(16, 192)
        Me.pnlDiv2.Name = "pnlDiv2"
        Me.pnlDiv2.Size = New System.Drawing.Size(388, 1)
        Me.pnlDiv2.TabIndex = 7
        '
        'lblDendaTitle
        '
        Me.lblDendaTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDendaTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblDendaTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblDendaTitle.Location = New System.Drawing.Point(16, 202)
        Me.lblDendaTitle.Name = "lblDendaTitle"
        Me.lblDendaTitle.Size = New System.Drawing.Size(388, 18)
        Me.lblDendaTitle.TabIndex = 8
        Me.lblDendaTitle.Text = "ATURAN DENDA KETERLAMBATAN"
        '
        'lblDendaNote
        '
        Me.lblDendaNote.BackColor = System.Drawing.Color.Transparent
        Me.lblDendaNote.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblDendaNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblDendaNote.Location = New System.Drawing.Point(16, 224)
        Me.lblDendaNote.Name = "lblDendaNote"
        Me.lblDendaNote.Size = New System.Drawing.Size(388, 32)
        Me.lblDendaNote.TabIndex = 9
        Me.lblDendaNote.Text = "Persentase denda per hari dari harga kamar." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Minimum 100% agar hotel tidak rugi."
        '
        'lblDendaPersen
        '
        Me.lblDendaPersen.AutoSize = True
        Me.lblDendaPersen.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDendaPersen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblDendaPersen.Location = New System.Drawing.Point(16, 264)
        Me.lblDendaPersen.Name = "lblDendaPersen"
        Me.lblDendaPersen.Size = New System.Drawing.Size(220, 25)
        Me.lblDendaPersen.TabIndex = 10
        Me.lblDendaPersen.Text = "Persentase Denda per Hari"
        '
        'nudDendaPersen
        '
        Me.nudDendaPersen.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.nudDendaPersen.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudDendaPersen.Location = New System.Drawing.Point(16, 284)
        Me.nudDendaPersen.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudDendaPersen.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.nudDendaPersen.Name = "nudDendaPersen"
        Me.nudDendaPersen.Size = New System.Drawing.Size(100, 34)
        Me.nudDendaPersen.TabIndex = 11
        Me.nudDendaPersen.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'lblDendaSatuan
        '
        Me.lblDendaSatuan.AutoSize = True
        Me.lblDendaSatuan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDendaSatuan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblDendaSatuan.Location = New System.Drawing.Point(124, 290)
        Me.lblDendaSatuan.Name = "lblDendaSatuan"
        Me.lblDendaSatuan.Size = New System.Drawing.Size(256, 25)
        Me.lblDendaSatuan.TabIndex = 12
        Me.lblDendaSatuan.Text = "% dari harga kamar per malam"
        '
        'lblDendaWarning
        '
        Me.lblDendaWarning.BackColor = System.Drawing.Color.Transparent
        Me.lblDendaWarning.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Italic)
        Me.lblDendaWarning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblDendaWarning.Location = New System.Drawing.Point(16, 316)
        Me.lblDendaWarning.Name = "lblDendaWarning"
        Me.lblDendaWarning.Size = New System.Drawing.Size(388, 18)
        Me.lblDendaWarning.TabIndex = 13
        Me.lblDendaWarning.Text = "Min: 100%  |  Max: 500%  |  Default: 100%"
        '
        'pnlDiv3
        '
        Me.pnlDiv3.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlDiv3.Location = New System.Drawing.Point(16, 344)
        Me.pnlDiv3.Name = "pnlDiv3"
        Me.pnlDiv3.Size = New System.Drawing.Size(388, 1)
        Me.pnlDiv3.TabIndex = 14
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(16, 358)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(180, 32)
        Me.btnSimpan.TabIndex = 15
        Me.btnSimpan.Text = "Simpan Preferensi"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnReset.Location = New System.Drawing.Point(204, 358)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(110, 32)
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "Reset Default"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnTutup
        '
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTutup.FlatAppearance.BorderSize = 0
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTutup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTutup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnTutup.Location = New System.Drawing.Point(16, 400)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(388, 30)
        Me.btnTutup.TabIndex = 17
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = False
        '
        'SettingsForm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(420, 516)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Preferensi Tampilan"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBody.PerformLayout()
        CType(Me.nudDendaPersen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents lblPrefTitle As System.Windows.Forms.Label
    Friend WithEvents lblUserInfo As System.Windows.Forms.Label
    Friend WithEvents pnlDiv1 As System.Windows.Forms.Panel
    Friend WithEvents lblDisplayTitle As System.Windows.Forms.Label
    Friend WithEvents chkShowClock As System.Windows.Forms.CheckBox
    Friend WithEvents chkConfirmLogout As System.Windows.Forms.CheckBox
    Friend WithEvents chkConfirmHapus As System.Windows.Forms.CheckBox
    Friend WithEvents pnlDiv2 As System.Windows.Forms.Panel
    Friend WithEvents lblDendaTitle As System.Windows.Forms.Label
    Friend WithEvents lblDendaNote As System.Windows.Forms.Label
    Friend WithEvents lblDendaPersen As System.Windows.Forms.Label
    Friend WithEvents nudDendaPersen As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDendaSatuan As System.Windows.Forms.Label
    Friend WithEvents lblDendaWarning As System.Windows.Forms.Label
    Friend WithEvents pnlDiv3 As System.Windows.Forms.Panel
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button

End Class