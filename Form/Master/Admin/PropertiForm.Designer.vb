<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PropertiForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblIdProperti = New System.Windows.Forms.Label()
        Me.txtIdProperti = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblBiaya = New System.Windows.Forms.Label()
        Me.txtBiaya = New System.Windows.Forms.TextBox()
        Me.pnlDiv1 = New System.Windows.Forms.Panel()
        Me.lblAssignTitle = New System.Windows.Forms.Label()
        Me.lblAssignNote = New System.Windows.Forms.Label()
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.pnlDiv2 = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.lblGridTitle = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvProperti = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPropertiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BiayaDendaRpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahAssignDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PropertiRusakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PropertiPerbaikanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PropertiBaikDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwDataPropertiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HotelDBDataSet = New VB_PROJECT.HotelDBDataSet()
        Me.QueriesTableAdapter1 = New VB_PROJECT.HotelDBDataSetTableAdapters.QueriesTableAdapter()
        Me.Vw_DataPropertiTableAdapter = New VB_PROJECT.HotelDBDataSetTableAdapters.vw_DataPropertiTableAdapter()
        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        CType(Me.dgvProperti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDataPropertiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(182, Byte), Integer))
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
        Me.lblTitle.Text = "Master Properti"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(500, 18)
        Me.lblSubTitle.TabIndex = 1
        Me.lblSubTitle.Text = "Kelola master properti, assign dan unassign ke kamar"
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLeft.Controls.Add(Me.lblFormTitle)
        Me.pnlLeft.Controls.Add(Me.lblIdProperti)
        Me.pnlLeft.Controls.Add(Me.txtIdProperti)
        Me.pnlLeft.Controls.Add(Me.lblNama)
        Me.pnlLeft.Controls.Add(Me.txtNama)
        Me.pnlLeft.Controls.Add(Me.lblBiaya)
        Me.pnlLeft.Controls.Add(Me.txtBiaya)
        Me.pnlLeft.Controls.Add(Me.pnlDiv1)
        Me.pnlLeft.Controls.Add(Me.lblAssignTitle)
        Me.pnlLeft.Controls.Add(Me.lblAssignNote)
        Me.pnlLeft.Controls.Add(Me.btnAssign)
        Me.pnlLeft.Controls.Add(Me.pnlDiv2)
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
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.lblFormTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(268, 24)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Form Master Properti"
        '
        'lblIdProperti
        '
        Me.lblIdProperti.AutoSize = True
        Me.lblIdProperti.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdProperti.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblIdProperti.Location = New System.Drawing.Point(16, 52)
        Me.lblIdProperti.Name = "lblIdProperti"
        Me.lblIdProperti.Size = New System.Drawing.Size(98, 25)
        Me.lblIdProperti.TabIndex = 1
        Me.lblIdProperti.Text = "ID Properti"
        '
        'txtIdProperti
        '
        Me.txtIdProperti.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtIdProperti.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtIdProperti.Location = New System.Drawing.Point(16, 70)
        Me.txtIdProperti.Name = "txtIdProperti"
        Me.txtIdProperti.ReadOnly = True
        Me.txtIdProperti.Size = New System.Drawing.Size(262, 31)
        Me.txtIdProperti.TabIndex = 2
        Me.txtIdProperti.Text = "(auto)"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblNama.Location = New System.Drawing.Point(16, 106)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(127, 25)
        Me.lblNama.TabIndex = 3
        Me.lblNama.Text = "Nama Properti"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNama.Location = New System.Drawing.Point(16, 124)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(262, 31)
        Me.txtNama.TabIndex = 4
        '
        'lblBiaya
        '
        Me.lblBiaya.AutoSize = True
        Me.lblBiaya.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBiaya.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblBiaya.Location = New System.Drawing.Point(16, 160)
        Me.lblBiaya.Name = "lblBiaya"
        Me.lblBiaya.Size = New System.Drawing.Size(147, 25)
        Me.lblBiaya.TabIndex = 5
        Me.lblBiaya.Text = "Biaya Denda (Rp)"
        '
        'txtBiaya
        '
        Me.txtBiaya.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBiaya.Location = New System.Drawing.Point(16, 178)
        Me.txtBiaya.Name = "txtBiaya"
        Me.txtBiaya.Size = New System.Drawing.Size(262, 31)
        Me.txtBiaya.TabIndex = 6
        '
        'pnlDiv1
        '
        Me.pnlDiv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlDiv1.Location = New System.Drawing.Point(16, 218)
        Me.pnlDiv1.Name = "pnlDiv1"
        Me.pnlDiv1.Size = New System.Drawing.Size(262, 1)
        Me.pnlDiv1.TabIndex = 7
        '
        'lblAssignTitle
        '
        Me.lblAssignTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblAssignTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblAssignTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.lblAssignTitle.Location = New System.Drawing.Point(16, 228)
        Me.lblAssignTitle.Name = "lblAssignTitle"
        Me.lblAssignTitle.Size = New System.Drawing.Size(262, 18)
        Me.lblAssignTitle.TabIndex = 8
        Me.lblAssignTitle.Text = "MANAJEMEN KAMAR"
        '
        'lblAssignNote
        '
        Me.lblAssignNote.BackColor = System.Drawing.Color.Transparent
        Me.lblAssignNote.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblAssignNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblAssignNote.Location = New System.Drawing.Point(16, 250)
        Me.lblAssignNote.Name = "lblAssignNote"
        Me.lblAssignNote.Size = New System.Drawing.Size(262, 28)
        Me.lblAssignNote.TabIndex = 9
        Me.lblAssignNote.Text = "Pilih properti dari tabel terlebih dahulu"
        '
        'btnAssign
        '
        Me.btnAssign.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnAssign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAssign.Enabled = False
        Me.btnAssign.FlatAppearance.BorderSize = 0
        Me.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssign.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAssign.ForeColor = System.Drawing.Color.White
        Me.btnAssign.Location = New System.Drawing.Point(16, 286)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(262, 32)
        Me.btnAssign.TabIndex = 10
        Me.btnAssign.Text = "Assign ke Kamar"
        Me.btnAssign.UseVisualStyleBackColor = False
        '
        'pnlDiv2
        '
        Me.pnlDiv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlDiv2.Location = New System.Drawing.Point(16, 332)
        Me.pnlDiv2.Name = "pnlDiv2"
        Me.pnlDiv2.Size = New System.Drawing.Size(262, 1)
        Me.pnlDiv2.TabIndex = 12
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(16, 344)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(120, 32)
        Me.btnSimpan.TabIndex = 13
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
        Me.btnBatal.Location = New System.Drawing.Point(144, 344)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(134, 32)
        Me.btnBatal.TabIndex = 14
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
        Me.btnHapus.Location = New System.Drawing.Point(16, 384)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(262, 32)
        Me.btnHapus.TabIndex = 15
        Me.btnHapus.Text = "Hapus Properti"
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
        Me.pnlRight.Controls.Add(Me.dgvProperti)
        Me.pnlRight.Location = New System.Drawing.Point(304, 56)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(676, 580)
        Me.pnlRight.TabIndex = 2
        '
        'lblGridTitle
        '
        Me.lblGridTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGridTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.lblGridTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblGridTitle.Name = "lblGridTitle"
        Me.lblGridTitle.Size = New System.Drawing.Size(300, 24)
        Me.lblGridTitle.TabIndex = 0
        Me.lblGridTitle.Text = "Daftar Master Properti"
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
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(182, Byte), Integer))
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
        'dgvProperti
        '
        Me.dgvProperti.AllowUserToAddRows = False
        Me.dgvProperti.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvProperti.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProperti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProperti.AutoGenerateColumns = False
        Me.dgvProperti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProperti.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(182, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProperti.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProperti.ColumnHeadersHeight = 32
        Me.dgvProperti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NamaPropertiDataGridViewTextBoxColumn, Me.BiayaDendaRpDataGridViewTextBoxColumn, Me.JumlahAssignDataGridViewTextBoxColumn, Me.PropertiRusakDataGridViewTextBoxColumn, Me.PropertiPerbaikanDataGridViewTextBoxColumn, Me.PropertiBaikDataGridViewTextBoxColumn})
        Me.dgvProperti.DataSource = Me.VwDataPropertiBindingSource
        Me.dgvProperti.EnableHeadersVisualStyles = False
        Me.dgvProperti.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvProperti.Location = New System.Drawing.Point(12, 80)
        Me.dgvProperti.MultiSelect = False
        Me.dgvProperti.Name = "dgvProperti"
        Me.dgvProperti.ReadOnly = True
        Me.dgvProperti.RowHeadersVisible = False
        Me.dgvProperti.RowHeadersWidth = 62
        Me.dgvProperti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProperti.Size = New System.Drawing.Size(650, 484)
        Me.dgvProperti.TabIndex = 4
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaPropertiDataGridViewTextBoxColumn
        '
        Me.NamaPropertiDataGridViewTextBoxColumn.DataPropertyName = "Nama Properti"
        Me.NamaPropertiDataGridViewTextBoxColumn.HeaderText = "Nama Properti"
        Me.NamaPropertiDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NamaPropertiDataGridViewTextBoxColumn.Name = "NamaPropertiDataGridViewTextBoxColumn"
        Me.NamaPropertiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BiayaDendaRpDataGridViewTextBoxColumn
        '
        Me.BiayaDendaRpDataGridViewTextBoxColumn.DataPropertyName = "Biaya Denda (Rp)"
        Me.BiayaDendaRpDataGridViewTextBoxColumn.HeaderText = "Biaya Denda (Rp)"
        Me.BiayaDendaRpDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.BiayaDendaRpDataGridViewTextBoxColumn.Name = "BiayaDendaRpDataGridViewTextBoxColumn"
        Me.BiayaDendaRpDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JumlahAssignDataGridViewTextBoxColumn
        '
        Me.JumlahAssignDataGridViewTextBoxColumn.DataPropertyName = "Jumlah Assign"
        Me.JumlahAssignDataGridViewTextBoxColumn.HeaderText = "Jumlah Assign"
        Me.JumlahAssignDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.JumlahAssignDataGridViewTextBoxColumn.Name = "JumlahAssignDataGridViewTextBoxColumn"
        Me.JumlahAssignDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PropertiRusakDataGridViewTextBoxColumn
        '
        Me.PropertiRusakDataGridViewTextBoxColumn.DataPropertyName = "Properti Rusak"
        Me.PropertiRusakDataGridViewTextBoxColumn.HeaderText = "Properti Rusak"
        Me.PropertiRusakDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PropertiRusakDataGridViewTextBoxColumn.Name = "PropertiRusakDataGridViewTextBoxColumn"
        Me.PropertiRusakDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PropertiPerbaikanDataGridViewTextBoxColumn
        '
        Me.PropertiPerbaikanDataGridViewTextBoxColumn.DataPropertyName = "Properti Perbaikan"
        Me.PropertiPerbaikanDataGridViewTextBoxColumn.HeaderText = "Properti Perbaikan"
        Me.PropertiPerbaikanDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PropertiPerbaikanDataGridViewTextBoxColumn.Name = "PropertiPerbaikanDataGridViewTextBoxColumn"
        Me.PropertiPerbaikanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PropertiBaikDataGridViewTextBoxColumn
        '
        Me.PropertiBaikDataGridViewTextBoxColumn.DataPropertyName = "Properti Baik"
        Me.PropertiBaikDataGridViewTextBoxColumn.HeaderText = "Properti Baik"
        Me.PropertiBaikDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PropertiBaikDataGridViewTextBoxColumn.Name = "PropertiBaikDataGridViewTextBoxColumn"
        Me.PropertiBaikDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VwDataPropertiBindingSource
        '
        Me.VwDataPropertiBindingSource.DataMember = "vw_DataProperti"
        Me.VwDataPropertiBindingSource.DataSource = Me.HotelDBDataSet
        '
        'HotelDBDataSet
        '
        Me.HotelDBDataSet.DataSetName = "HotelDBDataSet"
        Me.HotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_DataPropertiTableAdapter
        '
        Me.Vw_DataPropertiTableAdapter.ClearBeforeFill = True
        '
        'PropertiForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(980, 636)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlRight)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "PropertiForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Master Properti"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        CType(Me.dgvProperti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDataPropertiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblIdProperti As System.Windows.Forms.Label
    Friend WithEvents txtIdProperti As System.Windows.Forms.TextBox
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblBiaya As System.Windows.Forms.Label
    Friend WithEvents txtBiaya As System.Windows.Forms.TextBox
    Friend WithEvents pnlDiv1 As System.Windows.Forms.Panel
    Friend WithEvents lblAssignTitle As System.Windows.Forms.Label
    Friend WithEvents lblAssignNote As System.Windows.Forms.Label
    Friend WithEvents btnAssign As System.Windows.Forms.Button
    Friend WithEvents pnlDiv2 As System.Windows.Forms.Panel
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents lblGridTitle As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvProperti As System.Windows.Forms.DataGridView
    Friend WithEvents QueriesTableAdapter1 As HotelDBDataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents HotelDBDataSet As HotelDBDataSet
    Friend WithEvents VwDataPropertiBindingSource As BindingSource
    Friend WithEvents Vw_DataPropertiTableAdapter As HotelDBDataSetTableAdapters.vw_DataPropertiTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaPropertiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BiayaDendaRpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahAssignDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PropertiRusakDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PropertiPerbaikanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PropertiBaikDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class