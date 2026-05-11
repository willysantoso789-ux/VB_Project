<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TipeKamarForm
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblIdTipe = New System.Windows.Forms.Label()
        Me.txtIdTipe = New System.Windows.Forms.TextBox()
        Me.lblNamaTipe = New System.Windows.Forms.Label()
        Me.txtNamaTipe = New System.Windows.Forms.TextBox()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.lblDeskripsi = New System.Windows.Forms.Label()
        Me.txtDeskripsi = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.lblGridTitle = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvTipe = New System.Windows.Forms.DataGridView()
        Me.HotelDBDataSet = New VB_PROJECT.HotelDBDataSet()
        Me.VwDataTipeKamarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_DataTipeKamarTableAdapter = New VB_PROJECT.HotelDBDataSetTableAdapters.vw_DataTipeKamarTableAdapter()
        Me.IDTipeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaTipeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaPerMalamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeskripsiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahKamarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KamarTersediaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KamarTerisiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KamarMaintenanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DibuatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QueriesTableAdapter1 = New VB_PROJECT.HotelDBDataSetTableAdapters.QueriesTableAdapter()
        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        CType(Me.dgvTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDataTipeKamarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Text = "Tipe Kamar"
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
        Me.lblSubTitle.Text = "Kelola tipe kamar dan harga per malam"
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLeft.Controls.Add(Me.lblFormTitle)
        Me.pnlLeft.Controls.Add(Me.lblIdTipe)
        Me.pnlLeft.Controls.Add(Me.txtIdTipe)
        Me.pnlLeft.Controls.Add(Me.lblNamaTipe)
        Me.pnlLeft.Controls.Add(Me.txtNamaTipe)
        Me.pnlLeft.Controls.Add(Me.lblHarga)
        Me.pnlLeft.Controls.Add(Me.txtHarga)
        Me.pnlLeft.Controls.Add(Me.lblDeskripsi)
        Me.pnlLeft.Controls.Add(Me.txtDeskripsi)
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
        Me.lblFormTitle.Text = "Form Tipe Kamar"
        '
        'lblIdTipe
        '
        Me.lblIdTipe.AutoSize = True
        Me.lblIdTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdTipe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblIdTipe.Location = New System.Drawing.Point(16, 50)
        Me.lblIdTipe.Name = "lblIdTipe"
        Me.lblIdTipe.Size = New System.Drawing.Size(68, 25)
        Me.lblIdTipe.TabIndex = 1
        Me.lblIdTipe.Text = "ID Tipe"
        '
        'txtIdTipe
        '
        Me.txtIdTipe.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtIdTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtIdTipe.Location = New System.Drawing.Point(16, 68)
        Me.txtIdTipe.Name = "txtIdTipe"
        Me.txtIdTipe.ReadOnly = True
        Me.txtIdTipe.Size = New System.Drawing.Size(262, 31)
        Me.txtIdTipe.TabIndex = 2
        Me.txtIdTipe.Text = "(auto)"
        '
        'lblNamaTipe
        '
        Me.lblNamaTipe.AutoSize = True
        Me.lblNamaTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNamaTipe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblNamaTipe.Location = New System.Drawing.Point(16, 104)
        Me.lblNamaTipe.Name = "lblNamaTipe"
        Me.lblNamaTipe.Size = New System.Drawing.Size(97, 25)
        Me.lblNamaTipe.TabIndex = 3
        Me.lblNamaTipe.Text = "Nama Tipe"
        '
        'txtNamaTipe
        '
        Me.txtNamaTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNamaTipe.Location = New System.Drawing.Point(16, 122)
        Me.txtNamaTipe.Name = "txtNamaTipe"
        Me.txtNamaTipe.Size = New System.Drawing.Size(262, 31)
        Me.txtNamaTipe.TabIndex = 4
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHarga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblHarga.Location = New System.Drawing.Point(16, 158)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(185, 25)
        Me.lblHarga.TabIndex = 5
        Me.lblHarga.Text = "Harga Per Malam (Rp)"
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtHarga.Location = New System.Drawing.Point(16, 176)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(262, 31)
        Me.txtHarga.TabIndex = 6
        '
        'lblDeskripsi
        '
        Me.lblDeskripsi.AutoSize = True
        Me.lblDeskripsi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDeskripsi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblDeskripsi.Location = New System.Drawing.Point(16, 212)
        Me.lblDeskripsi.Name = "lblDeskripsi"
        Me.lblDeskripsi.Size = New System.Drawing.Size(84, 25)
        Me.lblDeskripsi.TabIndex = 7
        Me.lblDeskripsi.Text = "Deskripsi"
        '
        'txtDeskripsi
        '
        Me.txtDeskripsi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDeskripsi.Location = New System.Drawing.Point(16, 230)
        Me.txtDeskripsi.Multiline = True
        Me.txtDeskripsi.Name = "txtDeskripsi"
        Me.txtDeskripsi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDeskripsi.Size = New System.Drawing.Size(262, 80)
        Me.txtDeskripsi.TabIndex = 8
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(16, 328)
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
        Me.btnBatal.Location = New System.Drawing.Point(144, 328)
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
        Me.btnHapus.Location = New System.Drawing.Point(16, 370)
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
        Me.pnlRight.Controls.Add(Me.dgvTipe)
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
        Me.lblGridTitle.Text = "Daftar Tipe Kamar"
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
        'dgvTipe
        '
        Me.dgvTipe.AllowUserToAddRows = False
        Me.dgvTipe.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvTipe.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTipe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTipe.AutoGenerateColumns = False
        Me.dgvTipe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTipe.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTipe.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTipe.ColumnHeadersHeight = 32
        Me.dgvTipe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDTipeDataGridViewTextBoxColumn, Me.NamaTipeDataGridViewTextBoxColumn, Me.HargaPerMalamDataGridViewTextBoxColumn, Me.DeskripsiDataGridViewTextBoxColumn, Me.JumlahKamarDataGridViewTextBoxColumn, Me.KamarTersediaDataGridViewTextBoxColumn, Me.KamarTerisiDataGridViewTextBoxColumn, Me.KamarMaintenanceDataGridViewTextBoxColumn, Me.DibuatDataGridViewTextBoxColumn})
        Me.dgvTipe.DataSource = Me.VwDataTipeKamarBindingSource
        Me.dgvTipe.EnableHeadersVisualStyles = False
        Me.dgvTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvTipe.Location = New System.Drawing.Point(12, 80)
        Me.dgvTipe.MultiSelect = False
        Me.dgvTipe.Name = "dgvTipe"
        Me.dgvTipe.ReadOnly = True
        Me.dgvTipe.RowHeadersVisible = False
        Me.dgvTipe.RowHeadersWidth = 62
        Me.dgvTipe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTipe.Size = New System.Drawing.Size(650, 424)
        Me.dgvTipe.TabIndex = 0
        '
        'HotelDBDataSet
        '
        Me.HotelDBDataSet.DataSetName = "HotelDBDataSet"
        Me.HotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwDataTipeKamarBindingSource
        '
        Me.VwDataTipeKamarBindingSource.DataMember = "vw_DataTipeKamar"
        Me.VwDataTipeKamarBindingSource.DataSource = Me.HotelDBDataSet
        '
        'Vw_DataTipeKamarTableAdapter
        '
        Me.Vw_DataTipeKamarTableAdapter.ClearBeforeFill = True
        '
        'IDTipeDataGridViewTextBoxColumn
        '
        Me.IDTipeDataGridViewTextBoxColumn.DataPropertyName = "ID Tipe"
        Me.IDTipeDataGridViewTextBoxColumn.HeaderText = "ID Tipe"
        Me.IDTipeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDTipeDataGridViewTextBoxColumn.Name = "IDTipeDataGridViewTextBoxColumn"
        Me.IDTipeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaTipeDataGridViewTextBoxColumn
        '
        Me.NamaTipeDataGridViewTextBoxColumn.DataPropertyName = "Nama Tipe"
        Me.NamaTipeDataGridViewTextBoxColumn.HeaderText = "Nama Tipe"
        Me.NamaTipeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NamaTipeDataGridViewTextBoxColumn.Name = "NamaTipeDataGridViewTextBoxColumn"
        Me.NamaTipeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HargaPerMalamDataGridViewTextBoxColumn
        '
        Me.HargaPerMalamDataGridViewTextBoxColumn.DataPropertyName = "Harga per Malam"
        Me.HargaPerMalamDataGridViewTextBoxColumn.HeaderText = "Harga per Malam"
        Me.HargaPerMalamDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.HargaPerMalamDataGridViewTextBoxColumn.Name = "HargaPerMalamDataGridViewTextBoxColumn"
        Me.HargaPerMalamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeskripsiDataGridViewTextBoxColumn
        '
        Me.DeskripsiDataGridViewTextBoxColumn.DataPropertyName = "Deskripsi"
        Me.DeskripsiDataGridViewTextBoxColumn.HeaderText = "Deskripsi"
        Me.DeskripsiDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DeskripsiDataGridViewTextBoxColumn.Name = "DeskripsiDataGridViewTextBoxColumn"
        Me.DeskripsiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JumlahKamarDataGridViewTextBoxColumn
        '
        Me.JumlahKamarDataGridViewTextBoxColumn.DataPropertyName = "Jumlah Kamar"
        Me.JumlahKamarDataGridViewTextBoxColumn.HeaderText = "Jumlah Kamar"
        Me.JumlahKamarDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.JumlahKamarDataGridViewTextBoxColumn.Name = "JumlahKamarDataGridViewTextBoxColumn"
        Me.JumlahKamarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KamarTersediaDataGridViewTextBoxColumn
        '
        Me.KamarTersediaDataGridViewTextBoxColumn.DataPropertyName = "Kamar Tersedia"
        Me.KamarTersediaDataGridViewTextBoxColumn.HeaderText = "Kamar Tersedia"
        Me.KamarTersediaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.KamarTersediaDataGridViewTextBoxColumn.Name = "KamarTersediaDataGridViewTextBoxColumn"
        Me.KamarTersediaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KamarTerisiDataGridViewTextBoxColumn
        '
        Me.KamarTerisiDataGridViewTextBoxColumn.DataPropertyName = "Kamar Terisi"
        Me.KamarTerisiDataGridViewTextBoxColumn.HeaderText = "Kamar Terisi"
        Me.KamarTerisiDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.KamarTerisiDataGridViewTextBoxColumn.Name = "KamarTerisiDataGridViewTextBoxColumn"
        Me.KamarTerisiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KamarMaintenanceDataGridViewTextBoxColumn
        '
        Me.KamarMaintenanceDataGridViewTextBoxColumn.DataPropertyName = "Kamar Maintenance"
        Me.KamarMaintenanceDataGridViewTextBoxColumn.HeaderText = "Kamar Maintenance"
        Me.KamarMaintenanceDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.KamarMaintenanceDataGridViewTextBoxColumn.Name = "KamarMaintenanceDataGridViewTextBoxColumn"
        Me.KamarMaintenanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DibuatDataGridViewTextBoxColumn
        '
        Me.DibuatDataGridViewTextBoxColumn.DataPropertyName = "Dibuat"
        Me.DibuatDataGridViewTextBoxColumn.HeaderText = "Dibuat"
        Me.DibuatDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DibuatDataGridViewTextBoxColumn.Name = "DibuatDataGridViewTextBoxColumn"
        Me.DibuatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipeKamarForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(980, 576)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlRight)
        Me.MinimumSize = New System.Drawing.Size(900, 550)
        Me.Name = "TipeKamarForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tipe Kamar"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        CType(Me.dgvTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDataTipeKamarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblIdTipe As System.Windows.Forms.Label
    Friend WithEvents txtIdTipe As System.Windows.Forms.TextBox
    Friend WithEvents lblNamaTipe As System.Windows.Forms.Label
    Friend WithEvents txtNamaTipe As System.Windows.Forms.TextBox
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents lblDeskripsi As System.Windows.Forms.Label
    Friend WithEvents txtDeskripsi As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents lblGridTitle As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvTipe As System.Windows.Forms.DataGridView
    Friend WithEvents HotelDBDataSet As HotelDBDataSet
    Friend WithEvents VwDataTipeKamarBindingSource As BindingSource
    Friend WithEvents Vw_DataTipeKamarTableAdapter As HotelDBDataSetTableAdapters.vw_DataTipeKamarTableAdapter
    Friend WithEvents IDTipeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaTipeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaPerMalamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeskripsiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahKamarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KamarTersediaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KamarTerisiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KamarMaintenanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DibuatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QueriesTableAdapter1 As HotelDBDataSetTableAdapters.QueriesTableAdapter
End Class