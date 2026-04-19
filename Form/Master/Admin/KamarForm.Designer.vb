<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KamarForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblIdKamar = New System.Windows.Forms.Label()
        Me.txtIdKamar = New System.Windows.Forms.TextBox()
        Me.lblIdTipe = New System.Windows.Forms.Label()
        Me.cboIdTipe = New System.Windows.Forms.ComboBox()
        Me.lblNomorKamar = New System.Windows.Forms.Label()
        Me.txtNomorKamar = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.lblGridTitle = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvKamar = New System.Windows.Forms.DataGridView()
        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        CType(Me.dgvKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(980, 56)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(16, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(500, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Data Kamar"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(500, 18)
        Me.lblSubTitle.TabIndex = 1
        Me.lblSubTitle.Text = "Kelola data kamar dan tipe kamar hotel"
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLeft.Controls.Add(Me.lblFormTitle)
        Me.pnlLeft.Controls.Add(Me.lblIdKamar)
        Me.pnlLeft.Controls.Add(Me.txtIdKamar)
        Me.pnlLeft.Controls.Add(Me.lblIdTipe)
        Me.pnlLeft.Controls.Add(Me.cboIdTipe)
        Me.pnlLeft.Controls.Add(Me.lblNomorKamar)
        Me.pnlLeft.Controls.Add(Me.txtNomorKamar)
        Me.pnlLeft.Controls.Add(Me.lblStatus)
        Me.pnlLeft.Controls.Add(Me.cboStatus)
        Me.pnlLeft.Controls.Add(Me.btnSimpan)
        Me.pnlLeft.Controls.Add(Me.btnBatal)
        Me.pnlLeft.Controls.Add(Me.btnHapus)
        Me.pnlLeft.Location = New System.Drawing.Point(0, 56)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(300, 520)
        Me.pnlLeft.TabIndex = 1
        '
        'lblFormTitle
        '
        Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblFormTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(268, 24)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Form Kamar"
        '
        'lblIdKamar
        '
        Me.lblIdKamar.AutoSize = True
        Me.lblIdKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdKamar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblIdKamar.Location = New System.Drawing.Point(16, 52)
        Me.lblIdKamar.Name = "lblIdKamar"
        Me.lblIdKamar.Size = New System.Drawing.Size(85, 25)
        Me.lblIdKamar.TabIndex = 1
        Me.lblIdKamar.Text = "ID Kamar"
        '
        'txtIdKamar
        '
        Me.txtIdKamar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtIdKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtIdKamar.Location = New System.Drawing.Point(16, 70)
        Me.txtIdKamar.Name = "txtIdKamar"
        Me.txtIdKamar.ReadOnly = True
        Me.txtIdKamar.Size = New System.Drawing.Size(262, 31)
        Me.txtIdKamar.TabIndex = 2
        Me.txtIdKamar.Text = "(auto)"
        '
        'lblIdTipe
        '
        Me.lblIdTipe.AutoSize = True
        Me.lblIdTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdTipe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblIdTipe.Location = New System.Drawing.Point(16, 106)
        Me.lblIdTipe.Name = "lblIdTipe"
        Me.lblIdTipe.Size = New System.Drawing.Size(100, 25)
        Me.lblIdTipe.TabIndex = 3
        Me.lblIdTipe.Text = "Tipe Kamar"
        '
        'cboIdTipe
        '
        Me.cboIdTipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIdTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboIdTipe.Location = New System.Drawing.Point(16, 124)
        Me.cboIdTipe.Name = "cboIdTipe"
        Me.cboIdTipe.Size = New System.Drawing.Size(262, 33)
        Me.cboIdTipe.TabIndex = 4
        '
        'lblNomorKamar
        '
        Me.lblNomorKamar.AutoSize = True
        Me.lblNomorKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNomorKamar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblNomorKamar.Location = New System.Drawing.Point(16, 162)
        Me.lblNomorKamar.Name = "lblNomorKamar"
        Me.lblNomorKamar.Size = New System.Drawing.Size(124, 25)
        Me.lblNomorKamar.TabIndex = 5
        Me.lblNomorKamar.Text = "Nomor Kamar"
        '
        'txtNomorKamar
        '
        Me.txtNomorKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNomorKamar.Location = New System.Drawing.Point(16, 180)
        Me.txtNomorKamar.Name = "txtNomorKamar"
        Me.txtNomorKamar.Size = New System.Drawing.Size(262, 31)
        Me.txtNomorKamar.TabIndex = 6
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(16, 218)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(60, 25)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "Status"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboStatus.Items.AddRange(New Object() {"Tersedia", "Terisi", "Maintenance"})
        Me.cboStatus.Location = New System.Drawing.Point(16, 236)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(262, 33)
        Me.cboStatus.TabIndex = 8
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(16, 280)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(120, 32)
        Me.btnSimpan.TabIndex = 9
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBatal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnBatal.Location = New System.Drawing.Point(144, 280)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(134, 32)
        Me.btnBatal.TabIndex = 10
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Enabled = False
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(16, 322)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(262, 32)
        Me.btnHapus.TabIndex = 11
        Me.btnHapus.Text = "Hapus Data"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'pnlRight
        '
        Me.pnlRight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Controls.Add(Me.lblGridTitle)
        Me.pnlRight.Controls.Add(Me.txtCari)
        Me.pnlRight.Controls.Add(Me.btnCari)
        Me.pnlRight.Controls.Add(Me.btnRefresh)
        Me.pnlRight.Controls.Add(Me.dgvKamar)
        Me.pnlRight.Location = New System.Drawing.Point(304, 56)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(676, 520)
        Me.pnlRight.TabIndex = 2
        '
        'lblGridTitle
        '
        Me.lblGridTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGridTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblGridTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblGridTitle.Name = "lblGridTitle"
        Me.lblGridTitle.Size = New System.Drawing.Size(300, 24)
        Me.lblGridTitle.TabIndex = 0
        Me.lblGridTitle.Text = "Daftar Kamar"
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCari.Location = New System.Drawing.Point(12, 44)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(220, 31)
        Me.txtCari.TabIndex = 1
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.FlatAppearance.BorderSize = 0
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(238, 43)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(70, 26)
        Me.btnCari.TabIndex = 2
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(314, 43)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(70, 26)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'dgvKamar
        '
        Me.dgvKamar.AllowUserToAddRows = False
        Me.dgvKamar.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvKamar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvKamar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvKamar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvKamar.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvKamar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvKamar.ColumnHeadersHeight = 32
        Me.dgvKamar.EnableHeadersVisualStyles = False
        Me.dgvKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvKamar.Location = New System.Drawing.Point(12, 80)
        Me.dgvKamar.MultiSelect = False
        Me.dgvKamar.Name = "dgvKamar"
        Me.dgvKamar.ReadOnly = True
        Me.dgvKamar.RowHeadersVisible = False
        Me.dgvKamar.RowHeadersWidth = 62
        Me.dgvKamar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKamar.Size = New System.Drawing.Size(650, 424)
        Me.dgvKamar.TabIndex = 0
        '
        'DataKamarForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(980, 576)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlRight)
        Me.MinimumSize = New System.Drawing.Size(900, 550)
        Me.Name = "DataKamarForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Data Kamar"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        CType(Me.dgvKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblIdKamar As System.Windows.Forms.Label
    Friend WithEvents txtIdKamar As System.Windows.Forms.TextBox
    Friend WithEvents lblIdTipe As System.Windows.Forms.Label
    Friend WithEvents cboIdTipe As System.Windows.Forms.ComboBox
    Friend WithEvents lblNomorKamar As System.Windows.Forms.Label
    Friend WithEvents txtNomorKamar As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents lblGridTitle As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvKamar As System.Windows.Forms.DataGridView

End Class