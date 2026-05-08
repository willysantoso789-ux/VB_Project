<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserManagementForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
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
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblIdUser = New System.Windows.Forms.Label()
        Me.txtIdUser = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.chkAktif = New System.Windows.Forms.CheckBox()
        Me.pnlDiv = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnToggleAktif = New System.Windows.Forms.Button()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.lblGridTitle = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.colIdUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAktif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTerdaftar = New System.Windows.Forms.DataGridViewTextBoxColumn()

        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' pnlHeader
        Me.pnlHeader.Name = "pnlHeader" : Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 56 : Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.pnlHeader.Controls.Add(Me.lblTitle) : Me.pnlHeader.Controls.Add(Me.lblSubTitle)

        Me.lblTitle.Name = "lblTitle" : Me.lblTitle.AutoSize = False
        Me.lblTitle.Size = New System.Drawing.Size(500, 28) : Me.lblTitle.Location = New System.Drawing.Point(16, 8)
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White : Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Text = "User Management"

        Me.lblSubTitle.Name = "lblSubTitle" : Me.lblSubTitle.AutoSize = False
        Me.lblSubTitle.Size = New System.Drawing.Size(500, 18) : Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(180, 200, 240) : Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Text = "Kelola akun pengguna sistem — hanya Admin"

        ' pnlLeft
        Me.pnlLeft.Name = "pnlLeft" : Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLeft.Location = New System.Drawing.Point(0, 56) : Me.pnlLeft.Size = New System.Drawing.Size(300, 580)
        Me.pnlLeft.Controls.Add(Me.lblFormTitle) : Me.pnlLeft.Controls.Add(Me.lblIdUser)
        Me.pnlLeft.Controls.Add(Me.txtIdUser) : Me.pnlLeft.Controls.Add(Me.lblNama)
        Me.pnlLeft.Controls.Add(Me.txtNama) : Me.pnlLeft.Controls.Add(Me.lblEmail)
        Me.pnlLeft.Controls.Add(Me.txtEmail) : Me.pnlLeft.Controls.Add(Me.lblPassword)
        Me.pnlLeft.Controls.Add(Me.txtPassword) : Me.pnlLeft.Controls.Add(Me.lblRole)
        Me.pnlLeft.Controls.Add(Me.cboRole) : Me.pnlLeft.Controls.Add(Me.chkAktif)
        Me.pnlLeft.Controls.Add(Me.pnlDiv) : Me.pnlLeft.Controls.Add(Me.btnSimpan)
        Me.pnlLeft.Controls.Add(Me.btnBatal) : Me.pnlLeft.Controls.Add(Me.btnToggleAktif)

        Me.lblFormTitle.Name = "lblFormTitle" : Me.lblFormTitle.AutoSize = False
        Me.lblFormTitle.Size = New System.Drawing.Size(268, 24) : Me.lblFormTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(45, 74, 138) : Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFormTitle.Text = "Form User"

        Me.lblIdUser.AutoSize = True : Me.lblIdUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdUser.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblIdUser.Location = New System.Drawing.Point(16, 50) : Me.lblIdUser.Name = "lblIdUser" : Me.lblIdUser.Text = "ID User"

        Me.txtIdUser.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtIdUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtIdUser.Location = New System.Drawing.Point(16, 68) : Me.txtIdUser.Name = "txtIdUser"
        Me.txtIdUser.ReadOnly = True : Me.txtIdUser.Size = New System.Drawing.Size(262, 31) : Me.txtIdUser.Text = "(auto)"

        Me.lblNama.AutoSize = True : Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNama.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblNama.Location = New System.Drawing.Point(16, 104) : Me.lblNama.Name = "lblNama" : Me.lblNama.Text = "Nama Lengkap"

        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNama.Location = New System.Drawing.Point(16, 122) : Me.txtNama.Name = "txtNama" : Me.txtNama.Size = New System.Drawing.Size(262, 31)

        Me.lblEmail.AutoSize = True : Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblEmail.Location = New System.Drawing.Point(16, 158) : Me.lblEmail.Name = "lblEmail" : Me.lblEmail.Text = "Email (Username Login)"

        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.Location = New System.Drawing.Point(16, 176) : Me.txtEmail.Name = "txtEmail" : Me.txtEmail.Size = New System.Drawing.Size(262, 31)

        Me.lblPassword.AutoSize = True : Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblPassword.Location = New System.Drawing.Point(16, 212) : Me.lblPassword.Name = "lblPassword" : Me.lblPassword.Text = "Password"

        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.Location = New System.Drawing.Point(16, 230) : Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = "●"c : Me.txtPassword.Size = New System.Drawing.Size(262, 31)

        Me.lblRole.AutoSize = True : Me.lblRole.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblRole.Location = New System.Drawing.Point(16, 266) : Me.lblRole.Name = "lblRole" : Me.lblRole.Text = "Role"

        Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRole.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboRole.Items.AddRange(New Object() {"Admin", "Resepsionis"})
        Me.cboRole.Location = New System.Drawing.Point(16, 284) : Me.cboRole.Name = "cboRole" : Me.cboRole.Size = New System.Drawing.Size(262, 33)

        Me.chkAktif.Name = "chkAktif" : Me.chkAktif.Text = "User Aktif"
        Me.chkAktif.Location = New System.Drawing.Point(16, 324) : Me.chkAktif.Size = New System.Drawing.Size(262, 24)
        Me.chkAktif.Font = New System.Drawing.Font("Segoe UI", 9.0!) : Me.chkAktif.Checked = True
        Me.chkAktif.Enabled = False   ' readonly, pakai btnToggleAktif

        Me.pnlDiv.Name = "pnlDiv" : Me.pnlDiv.Location = New System.Drawing.Point(16, 358)
        Me.pnlDiv.Size = New System.Drawing.Size(262, 1) : Me.pnlDiv.BackColor = System.Drawing.Color.FromArgb(210, 215, 225)

        Me.btnSimpan.Name = "btnSimpan" : Me.btnSimpan.Text = "Simpan User"
        Me.btnSimpan.Location = New System.Drawing.Point(16, 370) : Me.btnSimpan.Size = New System.Drawing.Size(120, 32)
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(45, 74, 138) : Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat : Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand : Me.btnSimpan.UseVisualStyleBackColor = False

        Me.btnBatal.Name = "btnBatal" : Me.btnBatal.Text = "Batal"
        Me.btnBatal.Location = New System.Drawing.Point(144, 370) : Me.btnBatal.Size = New System.Drawing.Size(134, 32)
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(220, 220, 220) : Me.btnBatal.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat : Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand : Me.btnBatal.UseVisualStyleBackColor = False

        Me.btnToggleAktif.Name = "btnToggleAktif" : Me.btnToggleAktif.Text = "Toggle Aktif / Nonaktif"
        Me.btnToggleAktif.Location = New System.Drawing.Point(16, 412) : Me.btnToggleAktif.Size = New System.Drawing.Size(262, 32)
        Me.btnToggleAktif.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnToggleAktif.BackColor = System.Drawing.Color.FromArgb(146, 64, 14) : Me.btnToggleAktif.ForeColor = System.Drawing.Color.White
        Me.btnToggleAktif.FlatStyle = System.Windows.Forms.FlatStyle.Flat : Me.btnToggleAktif.FlatAppearance.BorderSize = 0
        Me.btnToggleAktif.Cursor = System.Windows.Forms.Cursors.Hand : Me.btnToggleAktif.Enabled = False
        Me.btnToggleAktif.UseVisualStyleBackColor = False

        ' pnlRight
        Me.pnlRight.Name = "pnlRight" : Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or
                             System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right),
                             System.Windows.Forms.AnchorStyles)
        Me.pnlRight.Location = New System.Drawing.Point(304, 56) : Me.pnlRight.Size = New System.Drawing.Size(676, 580)
        Me.pnlRight.Controls.Add(Me.lblGridTitle) : Me.pnlRight.Controls.Add(Me.txtCari)
        Me.pnlRight.Controls.Add(Me.btnCari) : Me.pnlRight.Controls.Add(Me.btnRefresh)
        Me.pnlRight.Controls.Add(Me.dgvUser)

        Me.lblGridTitle.Name = "lblGridTitle" : Me.lblGridTitle.AutoSize = False
        Me.lblGridTitle.Size = New System.Drawing.Size(300, 24) : Me.lblGridTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblGridTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(45, 74, 138) : Me.lblGridTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGridTitle.Text = "Daftar User"

        Me.txtCari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCari.Location = New System.Drawing.Point(12, 44) : Me.txtCari.Name = "txtCari" : Me.txtCari.Size = New System.Drawing.Size(220, 31)

        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(45, 74, 138) : Me.btnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.FlatAppearance.BorderSize = 0 : Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI", 8.5!) : Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(238, 43) : Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(70, 26) : Me.btnCari.Text = "Cari" : Me.btnCari.UseVisualStyleBackColor = False

        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(100, 100, 100) : Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatAppearance.BorderSize = 0 : Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 8.5!) : Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(314, 43) : Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(70, 26) : Me.btnRefresh.Text = "Refresh" : Me.btnRefresh.UseVisualStyleBackColor = False

        ' dgvUser
        Me.dgvUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or
                            System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right),
                            System.Windows.Forms.AnchorStyles)
        Me.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUser.BackgroundColor = System.Drawing.Color.White
        Me.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvUser.RowHeadersVisible = False : Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToDeleteRows = False : Me.dgvUser.ReadOnly = True
        Me.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUser.MultiSelect = False : Me.dgvUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvUser.ColumnHeadersHeight = 32 : Me.dgvUser.EnableHeadersVisualStyles = False
        Me.dgvUser.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.dgvUser.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvUser.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvUser.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(235, 238, 245)
        Me.dgvUser.Location = New System.Drawing.Point(12, 80) : Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.Size = New System.Drawing.Size(650, 484)
        Me.dgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {
            Me.colIdUser, Me.colNama, Me.colEmail, Me.colRole, Me.colAktif, Me.colTerdaftar})

        Me.colIdUser.Name = "colIdUser" : Me.colIdUser.HeaderText = "ID" : Me.colIdUser.FillWeight = 35 : Me.colIdUser.ReadOnly = True
        Me.colNama.Name = "colNama" : Me.colNama.HeaderText = "Nama" : Me.colNama.FillWeight = 150 : Me.colNama.ReadOnly = True
        Me.colEmail.Name = "colEmail" : Me.colEmail.HeaderText = "Email" : Me.colEmail.FillWeight = 160 : Me.colEmail.ReadOnly = True
        Me.colRole.Name = "colRole" : Me.colRole.HeaderText = "Role" : Me.colRole.FillWeight = 90 : Me.colRole.ReadOnly = True
        Me.colAktif.Name = "colAktif" : Me.colAktif.HeaderText = "Status" : Me.colAktif.FillWeight = 70 : Me.colAktif.ReadOnly = True
        Me.colTerdaftar.Name = "colTerdaftar" : Me.colTerdaftar.HeaderText = "Terdaftar" : Me.colTerdaftar.FillWeight = 80 : Me.colTerdaftar.ReadOnly = True

        ' UserManagementForm
        Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.ClientSize = New System.Drawing.Size(980, 636)
        Me.MinimumSize = New System.Drawing.Size(900, 580)
        Me.Name = "UserManagementForm" : Me.Text = "User Management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.Controls.Add(Me.pnlHeader) : Me.Controls.Add(Me.pnlLeft) : Me.Controls.Add(Me.pnlRight)

        Me.pnlHeader.ResumeLayout(False) : Me.pnlLeft.ResumeLayout(False) : Me.pnlLeft.PerformLayout()
        Me.pnlRight.ResumeLayout(False) : Me.pnlRight.PerformLayout()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblIdUser As System.Windows.Forms.Label
    Friend WithEvents txtIdUser As System.Windows.Forms.TextBox
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents cboRole As System.Windows.Forms.ComboBox
    Friend WithEvents chkAktif As System.Windows.Forms.CheckBox
    Friend WithEvents pnlDiv As System.Windows.Forms.Panel
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnToggleAktif As System.Windows.Forms.Button
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents lblGridTitle As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvUser As System.Windows.Forms.DataGridView
    Friend WithEvents colIdUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRole As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAktif As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTerdaftar As System.Windows.Forms.DataGridViewTextBoxColumn
End Class