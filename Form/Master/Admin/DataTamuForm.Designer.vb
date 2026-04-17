<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataTamuForm
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
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblIdTamu = New System.Windows.Forms.Label()
        Me.txtIdTamu = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblNoHp = New System.Windows.Forms.Label()
        Me.txtNoHp = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.lblGridTitle = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvTamu = New System.Windows.Forms.DataGridView()

        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        CType(Me.dgvTamu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '
        'pnlHeader
        '
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 56
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(26, 86, 219)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubTitle)

        '
        'lblTitle
        '
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.AutoSize = False
        Me.lblTitle.Size = New System.Drawing.Size(500, 28)
        Me.lblTitle.Location = New System.Drawing.Point(16, 8)
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Text = "Data Tamu"

        '
        'lblSubTitle
        '
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.AutoSize = False
        Me.lblSubTitle.Size = New System.Drawing.Size(500, 18)
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(191, 219, 254)
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Text = "Kelola data tamu hotel"

        '
        'pnlLeft
        '
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Location = New System.Drawing.Point(0, 56)
        Me.pnlLeft.Size = New System.Drawing.Size(300, 580)
        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLeft.Controls.Add(Me.lblFormTitle)
        Me.pnlLeft.Controls.Add(Me.lblIdTamu)
        Me.pnlLeft.Controls.Add(Me.txtIdTamu)
        Me.pnlLeft.Controls.Add(Me.lblNama)
        Me.pnlLeft.Controls.Add(Me.txtNama)
        Me.pnlLeft.Controls.Add(Me.lblEmail)
        Me.pnlLeft.Controls.Add(Me.txtEmail)
        Me.pnlLeft.Controls.Add(Me.lblNoHp)
        Me.pnlLeft.Controls.Add(Me.txtNoHp)
        Me.pnlLeft.Controls.Add(Me.lblGender)
        Me.pnlLeft.Controls.Add(Me.cboGender)
        Me.pnlLeft.Controls.Add(Me.lblAlamat)
        Me.pnlLeft.Controls.Add(Me.txtAlamat)
        Me.pnlLeft.Controls.Add(Me.btnSimpan)
        Me.pnlLeft.Controls.Add(Me.btnBatal)
        Me.pnlLeft.Controls.Add(Me.btnHapus)

        '
        'lblFormTitle
        '
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.AutoSize = False
        Me.lblFormTitle.Size = New System.Drawing.Size(268, 24)
        Me.lblFormTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(26, 86, 219)
        Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFormTitle.Text = "Form Tamu"

        '
        'lblIdTamu
        '
        Me.lblIdTamu.Name = "lblIdTamu"
        Me.lblIdTamu.AutoSize = True
        Me.lblIdTamu.Location = New System.Drawing.Point(16, 50)
        Me.lblIdTamu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdTamu.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblIdTamu.Text = "ID Tamu"

        '
        'txtIdTamu
        '
        Me.txtIdTamu.Name = "txtIdTamu"
        Me.txtIdTamu.Location = New System.Drawing.Point(16, 68)
        Me.txtIdTamu.Size = New System.Drawing.Size(262, 24)
        Me.txtIdTamu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtIdTamu.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtIdTamu.ReadOnly = True
        Me.txtIdTamu.Text = "(auto)"

        '
        'lblNama
        '
        Me.lblNama.Name = "lblNama"
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(16, 104)
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNama.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblNama.Text = "Nama Lengkap"

        '
        'txtNama
        '
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Location = New System.Drawing.Point(16, 122)
        Me.txtNama.Size = New System.Drawing.Size(262, 24)
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 9.0!)

        '
        'lblEmail
        '
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(16, 158)
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblEmail.Text = "Email"

        '
        'txtEmail
        '
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Location = New System.Drawing.Point(16, 176)
        Me.txtEmail.Size = New System.Drawing.Size(262, 24)
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)

        '
        'lblNoHp
        '
        Me.lblNoHp.Name = "lblNoHp"
        Me.lblNoHp.AutoSize = True
        Me.lblNoHp.Location = New System.Drawing.Point(16, 212)
        Me.lblNoHp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNoHp.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblNoHp.Text = "No. HP"

        '
        'txtNoHp
        '
        Me.txtNoHp.Name = "txtNoHp"
        Me.txtNoHp.Location = New System.Drawing.Point(16, 230)
        Me.txtNoHp.Size = New System.Drawing.Size(262, 24)
        Me.txtNoHp.Font = New System.Drawing.Font("Segoe UI", 9.0!)

        '
        'lblGender
        '
        Me.lblGender.Name = "lblGender"
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(16, 266)
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblGender.Text = "Jenis Kelamin"

        '
        'cboGender
        '
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Location = New System.Drawing.Point(16, 284)
        Me.cboGender.Size = New System.Drawing.Size(262, 24)
        Me.cboGender.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})

        '
        'lblAlamat
        '
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(16, 320)
        Me.lblAlamat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAlamat.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblAlamat.Text = "Alamat"

        '
        'txtAlamat
        '
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Location = New System.Drawing.Point(16, 338)
        Me.txtAlamat.Size = New System.Drawing.Size(262, 70)
        Me.txtAlamat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical

        '
        'btnSimpan
        '
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.Location = New System.Drawing.Point(16, 424)
        Me.btnSimpan.Size = New System.Drawing.Size(120, 32)
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(26, 86, 219)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.UseVisualStyleBackColor = False

        '
        'btnBatal
        '
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.Location = New System.Drawing.Point(144, 424)
        Me.btnBatal.Size = New System.Drawing.Size(134, 32)
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(220, 220, 220)
        Me.btnBatal.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.UseVisualStyleBackColor = False

        '
        'btnHapus
        '
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Text = "Hapus Data"
        Me.btnHapus.Location = New System.Drawing.Point(16, 466)
        Me.btnHapus.Size = New System.Drawing.Size(262, 32)
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Enabled = False
        Me.btnHapus.UseVisualStyleBackColor = False

        '
        'pnlRight
        '
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Location = New System.Drawing.Point(304, 56)
        Me.pnlRight.Size = New System.Drawing.Size(676, 580)
        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Anchor = System.Windows.Forms.AnchorStyles.Top Or
                                System.Windows.Forms.AnchorStyles.Bottom Or
                                System.Windows.Forms.AnchorStyles.Left Or
                                System.Windows.Forms.AnchorStyles.Right
        Me.pnlRight.Controls.Add(Me.lblGridTitle)
        Me.pnlRight.Controls.Add(Me.txtCari)
        Me.pnlRight.Controls.Add(Me.btnCari)
        Me.pnlRight.Controls.Add(Me.btnRefresh)
        Me.pnlRight.Controls.Add(Me.dgvTamu)

        '
        'lblGridTitle
        '
        Me.lblGridTitle.Name = "lblGridTitle"
        Me.lblGridTitle.AutoSize = False
        Me.lblGridTitle.Size = New System.Drawing.Size(300, 24)
        Me.lblGridTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblGridTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(26, 86, 219)
        Me.lblGridTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGridTitle.Text = "Daftar Tamu"

        '
        'txtCari
        '
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Location = New System.Drawing.Point(12, 44)
        Me.txtCari.Size = New System.Drawing.Size(220, 24)
        Me.txtCari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCari.Text = ""

        '
        'btnCari
        '
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Text = "Cari"
        Me.btnCari.Location = New System.Drawing.Point(238, 43)
        Me.btnCari.Size = New System.Drawing.Size(70, 26)
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(26, 86, 219)
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.FlatAppearance.BorderSize = 0
        Me.btnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.UseVisualStyleBackColor = False

        '
        'btnRefresh
        '
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.Location = New System.Drawing.Point(314, 43)
        Me.btnRefresh.Size = New System.Drawing.Size(70, 26)
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.UseVisualStyleBackColor = False

        '
        'dgvTamu
        '
        Me.dgvTamu.Name = "dgvTamu"
        Me.dgvTamu.Location = New System.Drawing.Point(12, 80)
        Me.dgvTamu.Size = New System.Drawing.Size(650, 484)
        Me.dgvTamu.Anchor = System.Windows.Forms.AnchorStyles.Top Or
                                       System.Windows.Forms.AnchorStyles.Bottom Or
                                       System.Windows.Forms.AnchorStyles.Left Or
                                       System.Windows.Forms.AnchorStyles.Right
        Me.dgvTamu.BackgroundColor = System.Drawing.Color.White
        Me.dgvTamu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvTamu.RowHeadersVisible = False
        Me.dgvTamu.AllowUserToAddRows = False
        Me.dgvTamu.AllowUserToDeleteRows = False
        Me.dgvTamu.ReadOnly = True
        Me.dgvTamu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTamu.MultiSelect = False
        Me.dgvTamu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTamu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvTamu.ColumnHeadersHeight = 32
        Me.dgvTamu.EnableHeadersVisualStyles = False
        Me.dgvTamu.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(26, 86, 219)
        Me.dgvTamu.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvTamu.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvTamu.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(239, 246, 255)
        Me.dgvTamu.TabIndex = 0

        '
        'DataTamuForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.ClientSize = New System.Drawing.Size(980, 636)
        Me.MinimumSize = New System.Drawing.Size(900, 580)
        Me.Name = "DataTamuForm"
        Me.Text = "Data Tamu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlRight)

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        CType(Me.dgvTamu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblIdTamu As System.Windows.Forms.Label
    Friend WithEvents txtIdTamu As System.Windows.Forms.TextBox
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblNoHp As System.Windows.Forms.Label
    Friend WithEvents txtNoHp As System.Windows.Forms.TextBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents lblGridTitle As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvTamu As System.Windows.Forms.DataGridView

End Class