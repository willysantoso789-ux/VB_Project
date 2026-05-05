<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TamuForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblIdTamu = New System.Windows.Forms.Label()
        Me.txtIdTamu = New System.Windows.Forms.TextBox()
        Me.lblNIK = New System.Windows.Forms.Label()
        Me.txtNIK = New System.Windows.Forms.TextBox()
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
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaLengkapDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoHPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisKelaminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalReservasiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TerakhirCheckInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TerdaftarSejakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwDataTamuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HotelDBDataSet = New VB_PROJECT.HotelDBDataSet()
        Me.Vw_DataTamuTableAdapter = New VB_PROJECT.HotelDBDataSetTableAdapters.vw_DataTamuTableAdapter()
        Me.QueriesTableAdapter1 = New VB_PROJECT.HotelDBDataSetTableAdapters.QueriesTableAdapter()
        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        CType(Me.dgvTamu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDataTamuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(219, Byte), Integer))
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
        Me.lblTitle.Text = "Data Tamu"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(500, 18)
        Me.lblSubTitle.TabIndex = 1
        Me.lblSubTitle.Text = "Kelola data tamu hotel"
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLeft.Controls.Add(Me.lblFormTitle)
        Me.pnlLeft.Controls.Add(Me.lblIdTamu)
        Me.pnlLeft.Controls.Add(Me.txtIdTamu)
        Me.pnlLeft.Controls.Add(Me.lblNIK)
        Me.pnlLeft.Controls.Add(Me.txtNIK)
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
        Me.pnlLeft.Location = New System.Drawing.Point(0, 56)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(300, 580)
        Me.pnlLeft.TabIndex = 1
        '
        'lblFormTitle
        '
        Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lblFormTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(268, 24)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Form Tamu"
        '
        'lblIdTamu
        '
        Me.lblIdTamu.AutoSize = True
        Me.lblIdTamu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdTamu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblIdTamu.Location = New System.Drawing.Point(16, 50)
        Me.lblIdTamu.Name = "lblIdTamu"
        Me.lblIdTamu.Size = New System.Drawing.Size(77, 25)
        Me.lblIdTamu.TabIndex = 1
        Me.lblIdTamu.Text = "ID Tamu"
        '
        'txtIdTamu
        '
        Me.txtIdTamu.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtIdTamu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtIdTamu.Location = New System.Drawing.Point(16, 68)
        Me.txtIdTamu.Name = "txtIdTamu"
        Me.txtIdTamu.ReadOnly = True
        Me.txtIdTamu.Size = New System.Drawing.Size(262, 31)
        Me.txtIdTamu.TabIndex = 2
        Me.txtIdTamu.Text = "(auto)"
        '
        'lblNIK
        '
        Me.lblNIK.AutoSize = True
        Me.lblNIK.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNIK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblNIK.Location = New System.Drawing.Point(16, 104)
        Me.lblNIK.Name = "lblNIK"
        Me.lblNIK.Size = New System.Drawing.Size(40, 25)
        Me.lblNIK.TabIndex = 3
        Me.lblNIK.Text = "NIK"
        '
        'txtNIK
        '
        Me.txtNIK.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNIK.Location = New System.Drawing.Point(16, 122)
        Me.txtNIK.MaxLength = 16
        Me.txtNIK.Name = "txtNIK"
        Me.txtNIK.Size = New System.Drawing.Size(262, 31)
        Me.txtNIK.TabIndex = 4
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblNama.Location = New System.Drawing.Point(16, 158)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(131, 25)
        Me.lblNama.TabIndex = 5
        Me.lblNama.Text = "Nama Lengkap"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNama.Location = New System.Drawing.Point(16, 176)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(262, 31)
        Me.txtNama.TabIndex = 6
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblEmail.Location = New System.Drawing.Point(16, 212)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(54, 25)
        Me.lblEmail.TabIndex = 7
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.Location = New System.Drawing.Point(16, 230)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(262, 31)
        Me.txtEmail.TabIndex = 8
        '
        'lblNoHp
        '
        Me.lblNoHp.AutoSize = True
        Me.lblNoHp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNoHp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblNoHp.Location = New System.Drawing.Point(16, 266)
        Me.lblNoHp.Name = "lblNoHp"
        Me.lblNoHp.Size = New System.Drawing.Size(68, 25)
        Me.lblNoHp.TabIndex = 9
        Me.lblNoHp.Text = "No. HP"
        '
        'txtNoHp
        '
        Me.txtNoHp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNoHp.Location = New System.Drawing.Point(16, 284)
        Me.txtNoHp.Name = "txtNoHp"
        Me.txtNoHp.Size = New System.Drawing.Size(262, 31)
        Me.txtNoHp.TabIndex = 10
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblGender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblGender.Location = New System.Drawing.Point(16, 320)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(116, 25)
        Me.lblGender.TabIndex = 11
        Me.lblGender.Text = "Jenis Kelamin"
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboGender.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cboGender.Location = New System.Drawing.Point(16, 338)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(262, 33)
        Me.cboGender.TabIndex = 12
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAlamat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblAlamat.Location = New System.Drawing.Point(16, 374)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(68, 25)
        Me.lblAlamat.TabIndex = 13
        Me.lblAlamat.Text = "Alamat"
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAlamat.Location = New System.Drawing.Point(16, 392)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAlamat.Size = New System.Drawing.Size(262, 70)
        Me.txtAlamat.TabIndex = 14
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(16, 478)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(120, 32)
        Me.btnSimpan.TabIndex = 15
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
        Me.btnBatal.Location = New System.Drawing.Point(144, 478)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(134, 32)
        Me.btnBatal.TabIndex = 16
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
        Me.btnHapus.Location = New System.Drawing.Point(16, 520)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(262, 32)
        Me.btnHapus.TabIndex = 17
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
        Me.pnlRight.Controls.Add(Me.dgvTamu)
        Me.pnlRight.Location = New System.Drawing.Point(304, 56)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(676, 580)
        Me.pnlRight.TabIndex = 2
        '
        'lblGridTitle
        '
        Me.lblGridTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGridTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lblGridTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblGridTitle.Name = "lblGridTitle"
        Me.lblGridTitle.Size = New System.Drawing.Size(300, 24)
        Me.lblGridTitle.TabIndex = 0
        Me.lblGridTitle.Text = "Daftar Tamu"
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
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(219, Byte), Integer))
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
        'dgvTamu
        '
        Me.dgvTamu.AllowUserToAddRows = False
        Me.dgvTamu.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvTamu.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTamu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTamu.AutoGenerateColumns = False
        Me.dgvTamu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTamu.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTamu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTamu.ColumnHeadersHeight = 32
        Me.dgvTamu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NIKDataGridViewTextBoxColumn, Me.NamaLengkapDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.NoHPDataGridViewTextBoxColumn, Me.JenisKelaminDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.TotalReservasiDataGridViewTextBoxColumn, Me.TerakhirCheckInDataGridViewTextBoxColumn, Me.TerdaftarSejakDataGridViewTextBoxColumn})
        Me.dgvTamu.DataSource = Me.VwDataTamuBindingSource
        Me.dgvTamu.EnableHeadersVisualStyles = False
        Me.dgvTamu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvTamu.Location = New System.Drawing.Point(12, 80)
        Me.dgvTamu.MultiSelect = False
        Me.dgvTamu.Name = "dgvTamu"
        Me.dgvTamu.ReadOnly = True
        Me.dgvTamu.RowHeadersVisible = False
        Me.dgvTamu.RowHeadersWidth = 62
        Me.dgvTamu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTamu.Size = New System.Drawing.Size(650, 484)
        Me.dgvTamu.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NIKDataGridViewTextBoxColumn
        '
        Me.NIKDataGridViewTextBoxColumn.DataPropertyName = "NIK"
        Me.NIKDataGridViewTextBoxColumn.HeaderText = "NIK"
        Me.NIKDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NIKDataGridViewTextBoxColumn.Name = "NIKDataGridViewTextBoxColumn"
        Me.NIKDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaLengkapDataGridViewTextBoxColumn
        '
        Me.NamaLengkapDataGridViewTextBoxColumn.DataPropertyName = "Nama Lengkap"
        Me.NamaLengkapDataGridViewTextBoxColumn.HeaderText = "Nama Lengkap"
        Me.NamaLengkapDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NamaLengkapDataGridViewTextBoxColumn.Name = "NamaLengkapDataGridViewTextBoxColumn"
        Me.NamaLengkapDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoHPDataGridViewTextBoxColumn
        '
        Me.NoHPDataGridViewTextBoxColumn.DataPropertyName = "No_ HP"
        Me.NoHPDataGridViewTextBoxColumn.HeaderText = "No_ HP"
        Me.NoHPDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NoHPDataGridViewTextBoxColumn.Name = "NoHPDataGridViewTextBoxColumn"
        Me.NoHPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JenisKelaminDataGridViewTextBoxColumn
        '
        Me.JenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "Jenis Kelamin"
        Me.JenisKelaminDataGridViewTextBoxColumn.HeaderText = "Jenis Kelamin"
        Me.JenisKelaminDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.JenisKelaminDataGridViewTextBoxColumn.Name = "JenisKelaminDataGridViewTextBoxColumn"
        Me.JenisKelaminDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        Me.AlamatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalReservasiDataGridViewTextBoxColumn
        '
        Me.TotalReservasiDataGridViewTextBoxColumn.DataPropertyName = "Total Reservasi"
        Me.TotalReservasiDataGridViewTextBoxColumn.HeaderText = "Total Reservasi"
        Me.TotalReservasiDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TotalReservasiDataGridViewTextBoxColumn.Name = "TotalReservasiDataGridViewTextBoxColumn"
        Me.TotalReservasiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TerakhirCheckInDataGridViewTextBoxColumn
        '
        Me.TerakhirCheckInDataGridViewTextBoxColumn.DataPropertyName = "Terakhir Check-In"
        Me.TerakhirCheckInDataGridViewTextBoxColumn.HeaderText = "Terakhir Check-In"
        Me.TerakhirCheckInDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TerakhirCheckInDataGridViewTextBoxColumn.Name = "TerakhirCheckInDataGridViewTextBoxColumn"
        Me.TerakhirCheckInDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TerdaftarSejakDataGridViewTextBoxColumn
        '
        Me.TerdaftarSejakDataGridViewTextBoxColumn.DataPropertyName = "Terdaftar Sejak"
        Me.TerdaftarSejakDataGridViewTextBoxColumn.HeaderText = "Terdaftar Sejak"
        Me.TerdaftarSejakDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TerdaftarSejakDataGridViewTextBoxColumn.Name = "TerdaftarSejakDataGridViewTextBoxColumn"
        Me.TerdaftarSejakDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VwDataTamuBindingSource
        '
        Me.VwDataTamuBindingSource.DataMember = "vw_DataTamu"
        Me.VwDataTamuBindingSource.DataSource = Me.HotelDBDataSet
        '
        'HotelDBDataSet
        '
        Me.HotelDBDataSet.DataSetName = "HotelDBDataSet"
        Me.HotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_DataTamuTableAdapter
        '
        Me.Vw_DataTamuTableAdapter.ClearBeforeFill = True
        '
        'TamuForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(980, 636)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlRight)
        Me.MinimumSize = New System.Drawing.Size(900, 580)
        Me.Name = "TamuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Data Tamu"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        CType(Me.dgvTamu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDataTamuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblIdTamu As System.Windows.Forms.Label
    Friend WithEvents txtIdTamu As System.Windows.Forms.TextBox
    Friend WithEvents lblNIK As System.Windows.Forms.Label
    Friend WithEvents txtNIK As System.Windows.Forms.TextBox
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
    Friend WithEvents HotelDBDataSet As HotelDBDataSet
    Friend WithEvents VwDataTamuBindingSource As BindingSource
    Friend WithEvents Vw_DataTamuTableAdapter As HotelDBDataSetTableAdapters.vw_DataTamuTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NIKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaLengkapDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoHPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JenisKelaminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalReservasiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TerakhirCheckInDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TerdaftarSejakDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QueriesTableAdapter1 As HotelDBDataSetTableAdapters.QueriesTableAdapter
End Class