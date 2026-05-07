<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReservasiForm
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
        Me.lblIdReservasi = New System.Windows.Forms.Label()
        Me.txtIdReservasi = New System.Windows.Forms.TextBox()
        Me.lblTipe = New System.Windows.Forms.Label()
        Me.cboTipe = New System.Windows.Forms.ComboBox()
        Me.lblTamu = New System.Windows.Forms.Label()
        Me.cboTamu = New System.Windows.Forms.ComboBox()
        Me.lblKamar = New System.Windows.Forms.Label()
        Me.cboKamar = New System.Windows.Forms.ComboBox()
        Me.lblHargaKamar = New System.Windows.Forms.Label()
        Me.txtHargaKamar = New System.Windows.Forms.TextBox()
        Me.lblTglReservasi = New System.Windows.Forms.Label()
        Me.dtpTglReservasi = New System.Windows.Forms.DateTimePicker()
        Me.lblTglCheckin = New System.Windows.Forms.Label()
        Me.dtpTglCheckin = New System.Windows.Forms.DateTimePicker()
        Me.lblTglCheckout = New System.Windows.Forms.Label()
        Me.dtpTglCheckout = New System.Windows.Forms.DateTimePicker()
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
        Me.dgvReservasi = New System.Windows.Forms.DataGridView()
        Me.IDReservasiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIKTamuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaTamuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoHPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomorKamarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipeKamarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipeReservasiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglReservasiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglCheckInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglCheckOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DurasiMalamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaMalamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstimasiBiayaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwDataReservasiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HotelDBDataSet = New VB_PROJECT.HotelDBDataSet()
        Me.Vw_DataReservasiTableAdapter = New VB_PROJECT.HotelDBDataSetTableAdapters.vw_DataReservasiTableAdapter()
        Me.QueriesTableAdapter1 = New VB_PROJECT.HotelDBDataSetTableAdapters.QueriesTableAdapter()
        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        CType(Me.dgvReservasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwDataReservasiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(14, Byte), Integer))
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
        Me.lblTitle.Text = "Reservasi"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(500, 18)
        Me.lblSubTitle.TabIndex = 1
        Me.lblSubTitle.Text = "Kelola reservasi tamu hotel"
        '
        'pnlLeft
        '
        Me.pnlLeft.AutoScroll = True
        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLeft.Controls.Add(Me.lblFormTitle)
        Me.pnlLeft.Controls.Add(Me.lblIdReservasi)
        Me.pnlLeft.Controls.Add(Me.txtIdReservasi)
        Me.pnlLeft.Controls.Add(Me.lblTipe)
        Me.pnlLeft.Controls.Add(Me.cboTipe)
        Me.pnlLeft.Controls.Add(Me.lblTamu)
        Me.pnlLeft.Controls.Add(Me.cboTamu)
        Me.pnlLeft.Controls.Add(Me.lblKamar)
        Me.pnlLeft.Controls.Add(Me.cboKamar)
        Me.pnlLeft.Controls.Add(Me.lblHargaKamar)
        Me.pnlLeft.Controls.Add(Me.txtHargaKamar)
        Me.pnlLeft.Controls.Add(Me.lblTglReservasi)
        Me.pnlLeft.Controls.Add(Me.dtpTglReservasi)
        Me.pnlLeft.Controls.Add(Me.lblTglCheckin)
        Me.pnlLeft.Controls.Add(Me.dtpTglCheckin)
        Me.pnlLeft.Controls.Add(Me.lblTglCheckout)
        Me.pnlLeft.Controls.Add(Me.dtpTglCheckout)
        Me.pnlLeft.Controls.Add(Me.lblStatus)
        Me.pnlLeft.Controls.Add(Me.cboStatus)
        Me.pnlLeft.Controls.Add(Me.btnSimpan)
        Me.pnlLeft.Controls.Add(Me.btnBatal)
        Me.pnlLeft.Controls.Add(Me.btnHapus)
        Me.pnlLeft.Location = New System.Drawing.Point(0, 56)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(310, 700)
        Me.pnlLeft.TabIndex = 1
        '
        'lblFormTitle
        '
        Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.lblFormTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(278, 24)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Form Reservasi"
        '
        'lblIdReservasi
        '
        Me.lblIdReservasi.AutoSize = True
        Me.lblIdReservasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdReservasi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblIdReservasi.Location = New System.Drawing.Point(16, 50)
        Me.lblIdReservasi.Name = "lblIdReservasi"
        Me.lblIdReservasi.Size = New System.Drawing.Size(107, 25)
        Me.lblIdReservasi.TabIndex = 1
        Me.lblIdReservasi.Text = "ID Reservasi"
        '
        'txtIdReservasi
        '
        Me.txtIdReservasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtIdReservasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtIdReservasi.Location = New System.Drawing.Point(16, 68)
        Me.txtIdReservasi.Name = "txtIdReservasi"
        Me.txtIdReservasi.ReadOnly = True
        Me.txtIdReservasi.Size = New System.Drawing.Size(272, 31)
        Me.txtIdReservasi.TabIndex = 2
        Me.txtIdReservasi.Text = "(auto)"
        '
        'lblTipe
        '
        Me.lblTipe.AutoSize = True
        Me.lblTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTipe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTipe.Location = New System.Drawing.Point(16, 104)
        Me.lblTipe.Name = "lblTipe"
        Me.lblTipe.Size = New System.Drawing.Size(122, 25)
        Me.lblTipe.TabIndex = 3
        Me.lblTipe.Text = "Tipe Reservasi"
        '
        'cboTipe
        '
        Me.cboTipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboTipe.Items.AddRange(New Object() {"Walk-in (Langsung)", "Online / Contact"})
        Me.cboTipe.Location = New System.Drawing.Point(16, 122)
        Me.cboTipe.Name = "cboTipe"
        Me.cboTipe.Size = New System.Drawing.Size(272, 33)
        Me.cboTipe.TabIndex = 4
        '
        'lblTamu
        '
        Me.lblTamu.AutoSize = True
        Me.lblTamu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTamu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTamu.Location = New System.Drawing.Point(16, 158)
        Me.lblTamu.Name = "lblTamu"
        Me.lblTamu.Size = New System.Drawing.Size(106, 25)
        Me.lblTamu.TabIndex = 5
        Me.lblTamu.Text = "Nama Tamu"
        '
        'cboTamu
        '
        Me.cboTamu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTamu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboTamu.Location = New System.Drawing.Point(16, 176)
        Me.cboTamu.Name = "cboTamu"
        Me.cboTamu.Size = New System.Drawing.Size(272, 33)
        Me.cboTamu.TabIndex = 6
        '
        'lblKamar
        '
        Me.lblKamar.AutoSize = True
        Me.lblKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKamar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblKamar.Location = New System.Drawing.Point(16, 212)
        Me.lblKamar.Name = "lblKamar"
        Me.lblKamar.Size = New System.Drawing.Size(62, 25)
        Me.lblKamar.TabIndex = 7
        Me.lblKamar.Text = "Kamar"
        '
        'cboKamar
        '
        Me.cboKamar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboKamar.Location = New System.Drawing.Point(16, 230)
        Me.cboKamar.Name = "cboKamar"
        Me.cboKamar.Size = New System.Drawing.Size(272, 33)
        Me.cboKamar.TabIndex = 8
        '
        'lblHargaKamar
        '
        Me.lblHargaKamar.AutoSize = True
        Me.lblHargaKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHargaKamar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblHargaKamar.Location = New System.Drawing.Point(16, 266)
        Me.lblHargaKamar.Name = "lblHargaKamar"
        Me.lblHargaKamar.Size = New System.Drawing.Size(186, 25)
        Me.lblHargaKamar.TabIndex = 9
        Me.lblHargaKamar.Text = "Harga Kamar / Malam"
        '
        'txtHargaKamar
        '
        Me.txtHargaKamar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtHargaKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtHargaKamar.Location = New System.Drawing.Point(16, 284)
        Me.txtHargaKamar.Name = "txtHargaKamar"
        Me.txtHargaKamar.ReadOnly = True
        Me.txtHargaKamar.Size = New System.Drawing.Size(272, 31)
        Me.txtHargaKamar.TabIndex = 10
        Me.txtHargaKamar.Text = "Rp 0"
        '
        'lblTglReservasi
        '
        Me.lblTglReservasi.AutoSize = True
        Me.lblTglReservasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTglReservasi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTglReservasi.Location = New System.Drawing.Point(16, 320)
        Me.lblTglReservasi.Name = "lblTglReservasi"
        Me.lblTglReservasi.Size = New System.Drawing.Size(150, 25)
        Me.lblTglReservasi.TabIndex = 11
        Me.lblTglReservasi.Text = "Tanggal Reservasi"
        '
        'dtpTglReservasi
        '
        Me.dtpTglReservasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTglReservasi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTglReservasi.Location = New System.Drawing.Point(16, 338)
        Me.dtpTglReservasi.Name = "dtpTglReservasi"
        Me.dtpTglReservasi.Size = New System.Drawing.Size(272, 31)
        Me.dtpTglReservasi.TabIndex = 12
        Me.dtpTglReservasi.Value = New Date(2026, 5, 7, 0, 0, 0, 0)
        '
        'lblTglCheckin
        '
        Me.lblTglCheckin.AutoSize = True
        Me.lblTglCheckin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTglCheckin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTglCheckin.Location = New System.Drawing.Point(16, 374)
        Me.lblTglCheckin.Name = "lblTglCheckin"
        Me.lblTglCheckin.Size = New System.Drawing.Size(147, 25)
        Me.lblTglCheckin.TabIndex = 13
        Me.lblTglCheckin.Text = "Tanggal Check-In"
        '
        'dtpTglCheckin
        '
        Me.dtpTglCheckin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTglCheckin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTglCheckin.Location = New System.Drawing.Point(16, 392)
        Me.dtpTglCheckin.Name = "dtpTglCheckin"
        Me.dtpTglCheckin.Size = New System.Drawing.Size(272, 31)
        Me.dtpTglCheckin.TabIndex = 14
        Me.dtpTglCheckin.Value = New Date(2026, 5, 7, 0, 0, 0, 0)
        '
        'lblTglCheckout
        '
        Me.lblTglCheckout.AutoSize = True
        Me.lblTglCheckout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTglCheckout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTglCheckout.Location = New System.Drawing.Point(16, 428)
        Me.lblTglCheckout.Name = "lblTglCheckout"
        Me.lblTglCheckout.Size = New System.Drawing.Size(162, 25)
        Me.lblTglCheckout.TabIndex = 15
        Me.lblTglCheckout.Text = "Tanggal Check-Out"
        '
        'dtpTglCheckout
        '
        Me.dtpTglCheckout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTglCheckout.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTglCheckout.Location = New System.Drawing.Point(16, 446)
        Me.dtpTglCheckout.Name = "dtpTglCheckout"
        Me.dtpTglCheckout.Size = New System.Drawing.Size(272, 31)
        Me.dtpTglCheckout.TabIndex = 16
        Me.dtpTglCheckout.Value = New Date(2026, 5, 8, 0, 0, 0, 0)
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(16, 482)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(60, 25)
        Me.lblStatus.TabIndex = 17
        Me.lblStatus.Text = "Status"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboStatus.Items.AddRange(New Object() {"Pending", "Confirmed", "Checked-In", "Checked-Out", "Cancelled"})
        Me.cboStatus.Location = New System.Drawing.Point(16, 500)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(272, 33)
        Me.cboStatus.TabIndex = 18
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(16, 544)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(128, 32)
        Me.btnSimpan.TabIndex = 19
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
        Me.btnBatal.Location = New System.Drawing.Point(152, 544)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(136, 32)
        Me.btnBatal.TabIndex = 20
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
        Me.btnHapus.Location = New System.Drawing.Point(16, 586)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(272, 32)
        Me.btnHapus.TabIndex = 21
        Me.btnHapus.Text = "Hapus Reservasi"
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
        Me.pnlRight.Controls.Add(Me.dgvReservasi)
        Me.pnlRight.Location = New System.Drawing.Point(314, 56)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(666, 700)
        Me.pnlRight.TabIndex = 2
        '
        'lblGridTitle
        '
        Me.lblGridTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGridTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.lblGridTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblGridTitle.Name = "lblGridTitle"
        Me.lblGridTitle.Size = New System.Drawing.Size(300, 24)
        Me.lblGridTitle.TabIndex = 0
        Me.lblGridTitle.Text = "Daftar Reservasi"
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
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(14, Byte), Integer))
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
        'dgvReservasi
        '
        Me.dgvReservasi.AllowUserToAddRows = False
        Me.dgvReservasi.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.dgvReservasi.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReservasi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvReservasi.AutoGenerateColumns = False
        Me.dgvReservasi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReservasi.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(14, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReservasi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvReservasi.ColumnHeadersHeight = 32
        Me.dgvReservasi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDReservasiDataGridViewTextBoxColumn, Me.NIKTamuDataGridViewTextBoxColumn, Me.NamaTamuDataGridViewTextBoxColumn, Me.NoHPDataGridViewTextBoxColumn, Me.NomorKamarDataGridViewTextBoxColumn, Me.TipeKamarDataGridViewTextBoxColumn, Me.TipeReservasiDataGridViewTextBoxColumn, Me.TglReservasiDataGridViewTextBoxColumn, Me.TglCheckInDataGridViewTextBoxColumn, Me.TglCheckOutDataGridViewTextBoxColumn, Me.DurasiMalamDataGridViewTextBoxColumn, Me.HargaMalamDataGridViewTextBoxColumn, Me.EstimasiBiayaDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.dgvReservasi.DataSource = Me.VwDataReservasiBindingSource
        Me.dgvReservasi.EnableHeadersVisualStyles = False
        Me.dgvReservasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvReservasi.Location = New System.Drawing.Point(12, 80)
        Me.dgvReservasi.MultiSelect = False
        Me.dgvReservasi.Name = "dgvReservasi"
        Me.dgvReservasi.ReadOnly = True
        Me.dgvReservasi.RowHeadersVisible = False
        Me.dgvReservasi.RowHeadersWidth = 62
        Me.dgvReservasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservasi.Size = New System.Drawing.Size(640, 604)
        Me.dgvReservasi.TabIndex = 0
        '
        'IDReservasiDataGridViewTextBoxColumn
        '
        Me.IDReservasiDataGridViewTextBoxColumn.DataPropertyName = "ID Reservasi"
        Me.IDReservasiDataGridViewTextBoxColumn.HeaderText = "ID Reservasi"
        Me.IDReservasiDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDReservasiDataGridViewTextBoxColumn.Name = "IDReservasiDataGridViewTextBoxColumn"
        Me.IDReservasiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NIKTamuDataGridViewTextBoxColumn
        '
        Me.NIKTamuDataGridViewTextBoxColumn.DataPropertyName = "NIK Tamu"
        Me.NIKTamuDataGridViewTextBoxColumn.HeaderText = "NIK Tamu"
        Me.NIKTamuDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NIKTamuDataGridViewTextBoxColumn.Name = "NIKTamuDataGridViewTextBoxColumn"
        Me.NIKTamuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaTamuDataGridViewTextBoxColumn
        '
        Me.NamaTamuDataGridViewTextBoxColumn.DataPropertyName = "Nama Tamu"
        Me.NamaTamuDataGridViewTextBoxColumn.HeaderText = "Nama Tamu"
        Me.NamaTamuDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NamaTamuDataGridViewTextBoxColumn.Name = "NamaTamuDataGridViewTextBoxColumn"
        Me.NamaTamuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoHPDataGridViewTextBoxColumn
        '
        Me.NoHPDataGridViewTextBoxColumn.DataPropertyName = "No_ HP"
        Me.NoHPDataGridViewTextBoxColumn.HeaderText = "No_ HP"
        Me.NoHPDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NoHPDataGridViewTextBoxColumn.Name = "NoHPDataGridViewTextBoxColumn"
        Me.NoHPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomorKamarDataGridViewTextBoxColumn
        '
        Me.NomorKamarDataGridViewTextBoxColumn.DataPropertyName = "Nomor Kamar"
        Me.NomorKamarDataGridViewTextBoxColumn.HeaderText = "Nomor Kamar"
        Me.NomorKamarDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NomorKamarDataGridViewTextBoxColumn.Name = "NomorKamarDataGridViewTextBoxColumn"
        Me.NomorKamarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipeKamarDataGridViewTextBoxColumn
        '
        Me.TipeKamarDataGridViewTextBoxColumn.DataPropertyName = "Tipe Kamar"
        Me.TipeKamarDataGridViewTextBoxColumn.HeaderText = "Tipe Kamar"
        Me.TipeKamarDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TipeKamarDataGridViewTextBoxColumn.Name = "TipeKamarDataGridViewTextBoxColumn"
        Me.TipeKamarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipeReservasiDataGridViewTextBoxColumn
        '
        Me.TipeReservasiDataGridViewTextBoxColumn.DataPropertyName = "Tipe Reservasi"
        Me.TipeReservasiDataGridViewTextBoxColumn.HeaderText = "Tipe Reservasi"
        Me.TipeReservasiDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TipeReservasiDataGridViewTextBoxColumn.Name = "TipeReservasiDataGridViewTextBoxColumn"
        Me.TipeReservasiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TglReservasiDataGridViewTextBoxColumn
        '
        Me.TglReservasiDataGridViewTextBoxColumn.DataPropertyName = "Tgl Reservasi"
        Me.TglReservasiDataGridViewTextBoxColumn.HeaderText = "Tgl Reservasi"
        Me.TglReservasiDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TglReservasiDataGridViewTextBoxColumn.Name = "TglReservasiDataGridViewTextBoxColumn"
        Me.TglReservasiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TglCheckInDataGridViewTextBoxColumn
        '
        Me.TglCheckInDataGridViewTextBoxColumn.DataPropertyName = "Tgl Check-In"
        Me.TglCheckInDataGridViewTextBoxColumn.HeaderText = "Tgl Check-In"
        Me.TglCheckInDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TglCheckInDataGridViewTextBoxColumn.Name = "TglCheckInDataGridViewTextBoxColumn"
        Me.TglCheckInDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TglCheckOutDataGridViewTextBoxColumn
        '
        Me.TglCheckOutDataGridViewTextBoxColumn.DataPropertyName = "Tgl Check-Out"
        Me.TglCheckOutDataGridViewTextBoxColumn.HeaderText = "Tgl Check-Out"
        Me.TglCheckOutDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TglCheckOutDataGridViewTextBoxColumn.Name = "TglCheckOutDataGridViewTextBoxColumn"
        Me.TglCheckOutDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DurasiMalamDataGridViewTextBoxColumn
        '
        Me.DurasiMalamDataGridViewTextBoxColumn.DataPropertyName = "Durasi (Malam)"
        Me.DurasiMalamDataGridViewTextBoxColumn.HeaderText = "Durasi (Malam)"
        Me.DurasiMalamDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DurasiMalamDataGridViewTextBoxColumn.Name = "DurasiMalamDataGridViewTextBoxColumn"
        Me.DurasiMalamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HargaMalamDataGridViewTextBoxColumn
        '
        Me.HargaMalamDataGridViewTextBoxColumn.DataPropertyName = "Harga/Malam"
        Me.HargaMalamDataGridViewTextBoxColumn.HeaderText = "Harga/Malam"
        Me.HargaMalamDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.HargaMalamDataGridViewTextBoxColumn.Name = "HargaMalamDataGridViewTextBoxColumn"
        Me.HargaMalamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstimasiBiayaDataGridViewTextBoxColumn
        '
        Me.EstimasiBiayaDataGridViewTextBoxColumn.DataPropertyName = "Estimasi Biaya"
        Me.EstimasiBiayaDataGridViewTextBoxColumn.HeaderText = "Estimasi Biaya"
        Me.EstimasiBiayaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EstimasiBiayaDataGridViewTextBoxColumn.Name = "EstimasiBiayaDataGridViewTextBoxColumn"
        Me.EstimasiBiayaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VwDataReservasiBindingSource
        '
        Me.VwDataReservasiBindingSource.DataMember = "vw_DataReservasi"
        Me.VwDataReservasiBindingSource.DataSource = Me.HotelDBDataSet
        '
        'HotelDBDataSet
        '
        Me.HotelDBDataSet.DataSetName = "HotelDBDataSet"
        Me.HotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_DataReservasiTableAdapter
        '
        Me.Vw_DataReservasiTableAdapter.ClearBeforeFill = True
        '
        'ReservasiForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(980, 756)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlRight)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "ReservasiForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reservasi"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        CType(Me.dgvReservasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwDataReservasiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblIdReservasi As System.Windows.Forms.Label
    Friend WithEvents txtIdReservasi As System.Windows.Forms.TextBox
    Friend WithEvents lblTipe As System.Windows.Forms.Label
    Friend WithEvents cboTipe As System.Windows.Forms.ComboBox
    Friend WithEvents lblTamu As System.Windows.Forms.Label
    Friend WithEvents cboTamu As System.Windows.Forms.ComboBox
    Friend WithEvents lblKamar As System.Windows.Forms.Label
    Friend WithEvents cboKamar As System.Windows.Forms.ComboBox
    Friend WithEvents lblHargaKamar As System.Windows.Forms.Label
    Friend WithEvents txtHargaKamar As System.Windows.Forms.TextBox
    Friend WithEvents lblTglReservasi As System.Windows.Forms.Label
    Friend WithEvents dtpTglReservasi As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTglCheckin As System.Windows.Forms.Label
    Friend WithEvents dtpTglCheckin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTglCheckout As System.Windows.Forms.Label
    Friend WithEvents dtpTglCheckout As System.Windows.Forms.DateTimePicker
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
    Friend WithEvents dgvReservasi As System.Windows.Forms.DataGridView
    Friend WithEvents HotelDBDataSet As HotelDBDataSet
    Friend WithEvents VwDataReservasiBindingSource As BindingSource
    Friend WithEvents Vw_DataReservasiTableAdapter As HotelDBDataSetTableAdapters.vw_DataReservasiTableAdapter
    Friend WithEvents IDReservasiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NIKTamuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaTamuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoHPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomorKamarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipeKamarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipeReservasiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglReservasiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglCheckInDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglCheckOutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DurasiMalamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaMalamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstimasiBiayaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QueriesTableAdapter1 As HotelDBDataSetTableAdapters.QueriesTableAdapter
End Class