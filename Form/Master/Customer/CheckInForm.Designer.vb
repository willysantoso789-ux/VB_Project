<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CheckInForm
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
        Me.lblInfoTitle = New System.Windows.Forms.Label()
        Me.lblIdReservasi = New System.Windows.Forms.Label()
        Me.txtIdReservasi = New System.Windows.Forms.TextBox()
        Me.lblNamaTamu = New System.Windows.Forms.Label()
        Me.txtNamaTamu = New System.Windows.Forms.TextBox()
        Me.lblKamar = New System.Windows.Forms.Label()
        Me.txtKamar = New System.Windows.Forms.TextBox()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.lblTipe = New System.Windows.Forms.Label()
        Me.txtTipe = New System.Windows.Forms.TextBox()
        Me.pnlDivider = New System.Windows.Forms.Panel()
        Me.lblCheckinTitle = New System.Windows.Forms.Label()
        Me.lblTglCheckin = New System.Windows.Forms.Label()
        Me.dtpTglCheckin = New System.Windows.Forms.DateTimePicker()
        Me.lblTglCheckout = New System.Windows.Forms.Label()
        Me.dtpTglCheckout = New System.Windows.Forms.DateTimePicker()
        Me.lblEstimasi = New System.Windows.Forms.Label()
        Me.txtEstimasi = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.btnCheckIn = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.lblGridTitle = New System.Windows.Forms.Label()
        Me.lblFilterTitle = New System.Windows.Forms.Label()
        Me.cboFilter = New System.Windows.Forms.ComboBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvCheckin = New System.Windows.Forms.DataGridView()
        Me.IDReservasiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaTamuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoHPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomorKamarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipeKamarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipeReservasiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglCheckInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglCheckOutPlanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DurasiMalamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaMalamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HariMenginapSekarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HariTerlambatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwCheckInAktifBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HotelDBDataSet = New VB_PROJECT.HotelDBDataSet()
        Me.Vw_CheckInAktifTableAdapter = New VB_PROJECT.HotelDBDataSetTableAdapters.vw_CheckInAktifTableAdapter()
        Me.QueriesTableAdapter1 = New VB_PROJECT.HotelDBDataSetTableAdapters.QueriesTableAdapter()
        Me.VwCheckInAktifBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        CType(Me.dgvCheckin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCheckInAktifBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCheckInAktifBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(70, Byte), Integer))
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
        Me.lblTitle.Text = "Check-In"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(500, 18)
        Me.lblSubTitle.TabIndex = 1
        Me.lblSubTitle.Text = "Proses check-in tamu berdasarkan reservasi"
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLeft.Controls.Add(Me.lblFormTitle)
        Me.pnlLeft.Controls.Add(Me.lblInfoTitle)
        Me.pnlLeft.Controls.Add(Me.lblIdReservasi)
        Me.pnlLeft.Controls.Add(Me.txtIdReservasi)
        Me.pnlLeft.Controls.Add(Me.lblNamaTamu)
        Me.pnlLeft.Controls.Add(Me.txtNamaTamu)
        Me.pnlLeft.Controls.Add(Me.lblKamar)
        Me.pnlLeft.Controls.Add(Me.txtKamar)
        Me.pnlLeft.Controls.Add(Me.lblHarga)
        Me.pnlLeft.Controls.Add(Me.txtHarga)
        Me.pnlLeft.Controls.Add(Me.lblTipe)
        Me.pnlLeft.Controls.Add(Me.txtTipe)
        Me.pnlLeft.Controls.Add(Me.pnlDivider)
        Me.pnlLeft.Controls.Add(Me.lblCheckinTitle)
        Me.pnlLeft.Controls.Add(Me.lblTglCheckin)
        Me.pnlLeft.Controls.Add(Me.dtpTglCheckin)
        Me.pnlLeft.Controls.Add(Me.lblTglCheckout)
        Me.pnlLeft.Controls.Add(Me.dtpTglCheckout)
        Me.pnlLeft.Controls.Add(Me.lblEstimasi)
        Me.pnlLeft.Controls.Add(Me.txtEstimasi)
        Me.pnlLeft.Controls.Add(Me.lblStatus)
        Me.pnlLeft.Controls.Add(Me.cboStatus)
        Me.pnlLeft.Controls.Add(Me.btnCheckIn)
        Me.pnlLeft.Controls.Add(Me.btnBatal)
        Me.pnlLeft.Location = New System.Drawing.Point(0, 56)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(310, 660)
        Me.pnlLeft.TabIndex = 1
        '
        'lblFormTitle
        '
        Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblFormTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(278, 24)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Form Check-In"
        '
        'lblInfoTitle
        '
        Me.lblInfoTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblInfoTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblInfoTitle.Location = New System.Drawing.Point(16, 44)
        Me.lblInfoTitle.Name = "lblInfoTitle"
        Me.lblInfoTitle.Size = New System.Drawing.Size(278, 18)
        Me.lblInfoTitle.TabIndex = 1
        Me.lblInfoTitle.Text = "INFO RESERVASI (READ ONLY)"
        '
        'lblIdReservasi
        '
        Me.lblIdReservasi.AutoSize = True
        Me.lblIdReservasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdReservasi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblIdReservasi.Location = New System.Drawing.Point(16, 68)
        Me.lblIdReservasi.Name = "lblIdReservasi"
        Me.lblIdReservasi.Size = New System.Drawing.Size(107, 25)
        Me.lblIdReservasi.TabIndex = 2
        Me.lblIdReservasi.Text = "ID Reservasi"
        '
        'txtIdReservasi
        '
        Me.txtIdReservasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtIdReservasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtIdReservasi.Location = New System.Drawing.Point(16, 86)
        Me.txtIdReservasi.Name = "txtIdReservasi"
        Me.txtIdReservasi.ReadOnly = True
        Me.txtIdReservasi.Size = New System.Drawing.Size(272, 31)
        Me.txtIdReservasi.TabIndex = 3
        '
        'lblNamaTamu
        '
        Me.lblNamaTamu.AutoSize = True
        Me.lblNamaTamu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNamaTamu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblNamaTamu.Location = New System.Drawing.Point(16, 120)
        Me.lblNamaTamu.Name = "lblNamaTamu"
        Me.lblNamaTamu.Size = New System.Drawing.Size(106, 25)
        Me.lblNamaTamu.TabIndex = 4
        Me.lblNamaTamu.Text = "Nama Tamu"
        '
        'txtNamaTamu
        '
        Me.txtNamaTamu.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtNamaTamu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNamaTamu.Location = New System.Drawing.Point(16, 138)
        Me.txtNamaTamu.Name = "txtNamaTamu"
        Me.txtNamaTamu.ReadOnly = True
        Me.txtNamaTamu.Size = New System.Drawing.Size(272, 31)
        Me.txtNamaTamu.TabIndex = 5
        '
        'lblKamar
        '
        Me.lblKamar.AutoSize = True
        Me.lblKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKamar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblKamar.Location = New System.Drawing.Point(16, 172)
        Me.lblKamar.Name = "lblKamar"
        Me.lblKamar.Size = New System.Drawing.Size(62, 25)
        Me.lblKamar.TabIndex = 6
        Me.lblKamar.Text = "Kamar"
        '
        'txtKamar
        '
        Me.txtKamar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtKamar.Location = New System.Drawing.Point(16, 190)
        Me.txtKamar.Name = "txtKamar"
        Me.txtKamar.ReadOnly = True
        Me.txtKamar.Size = New System.Drawing.Size(272, 31)
        Me.txtKamar.TabIndex = 7
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHarga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblHarga.Location = New System.Drawing.Point(16, 224)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(131, 25)
        Me.lblHarga.TabIndex = 8
        Me.lblHarga.Text = "Harga / Malam"
        '
        'txtHarga
        '
        Me.txtHarga.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtHarga.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtHarga.Location = New System.Drawing.Point(16, 242)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.ReadOnly = True
        Me.txtHarga.Size = New System.Drawing.Size(272, 31)
        Me.txtHarga.TabIndex = 9
        '
        'lblTipe
        '
        Me.lblTipe.AutoSize = True
        Me.lblTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTipe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTipe.Location = New System.Drawing.Point(16, 276)
        Me.lblTipe.Name = "lblTipe"
        Me.lblTipe.Size = New System.Drawing.Size(122, 25)
        Me.lblTipe.TabIndex = 10
        Me.lblTipe.Text = "Tipe Reservasi"
        '
        'txtTipe
        '
        Me.txtTipe.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTipe.Location = New System.Drawing.Point(16, 294)
        Me.txtTipe.Name = "txtTipe"
        Me.txtTipe.ReadOnly = True
        Me.txtTipe.Size = New System.Drawing.Size(272, 31)
        Me.txtTipe.TabIndex = 11
        '
        'pnlDivider
        '
        Me.pnlDivider.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlDivider.Location = New System.Drawing.Point(16, 330)
        Me.pnlDivider.Name = "pnlDivider"
        Me.pnlDivider.Size = New System.Drawing.Size(272, 1)
        Me.pnlDivider.TabIndex = 12
        '
        'lblCheckinTitle
        '
        Me.lblCheckinTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCheckinTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblCheckinTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblCheckinTitle.Location = New System.Drawing.Point(16, 340)
        Me.lblCheckinTitle.Name = "lblCheckinTitle"
        Me.lblCheckinTitle.Size = New System.Drawing.Size(278, 18)
        Me.lblCheckinTitle.TabIndex = 13
        Me.lblCheckinTitle.Text = "PROSES CHECK-IN"
        '
        'lblTglCheckin
        '
        Me.lblTglCheckin.AutoSize = True
        Me.lblTglCheckin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTglCheckin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTglCheckin.Location = New System.Drawing.Point(16, 366)
        Me.lblTglCheckin.Name = "lblTglCheckin"
        Me.lblTglCheckin.Size = New System.Drawing.Size(147, 25)
        Me.lblTglCheckin.TabIndex = 14
        Me.lblTglCheckin.Text = "Tanggal Check-In"
        '
        'dtpTglCheckin
        '
        Me.dtpTglCheckin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTglCheckin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTglCheckin.Location = New System.Drawing.Point(16, 384)
        Me.dtpTglCheckin.Name = "dtpTglCheckin"
        Me.dtpTglCheckin.Size = New System.Drawing.Size(272, 31)
        Me.dtpTglCheckin.TabIndex = 15
        Me.dtpTglCheckin.Value = New Date(2026, 5, 7, 0, 0, 0, 0)
        '
        'lblTglCheckout
        '
        Me.lblTglCheckout.AutoSize = True
        Me.lblTglCheckout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTglCheckout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTglCheckout.Location = New System.Drawing.Point(16, 418)
        Me.lblTglCheckout.Name = "lblTglCheckout"
        Me.lblTglCheckout.Size = New System.Drawing.Size(242, 25)
        Me.lblTglCheckout.TabIndex = 16
        Me.lblTglCheckout.Text = "Tanggal Check-Out (Rencana)"
        '
        'dtpTglCheckout
        '
        Me.dtpTglCheckout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTglCheckout.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTglCheckout.Location = New System.Drawing.Point(16, 436)
        Me.dtpTglCheckout.Name = "dtpTglCheckout"
        Me.dtpTglCheckout.Size = New System.Drawing.Size(272, 31)
        Me.dtpTglCheckout.TabIndex = 17
        Me.dtpTglCheckout.Value = New Date(2026, 5, 8, 0, 0, 0, 0)
        '
        'lblEstimasi
        '
        Me.lblEstimasi.AutoSize = True
        Me.lblEstimasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblEstimasi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblEstimasi.Location = New System.Drawing.Point(16, 470)
        Me.lblEstimasi.Name = "lblEstimasi"
        Me.lblEstimasi.Size = New System.Drawing.Size(164, 25)
        Me.lblEstimasi.TabIndex = 18
        Me.lblEstimasi.Text = "Estimasi Total Biaya"
        '
        'txtEstimasi
        '
        Me.txtEstimasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtEstimasi.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.txtEstimasi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtEstimasi.Location = New System.Drawing.Point(16, 488)
        Me.txtEstimasi.Name = "txtEstimasi"
        Me.txtEstimasi.ReadOnly = True
        Me.txtEstimasi.Size = New System.Drawing.Size(272, 33)
        Me.txtEstimasi.TabIndex = 19
        Me.txtEstimasi.Text = "Rp 0"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(16, 524)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(60, 25)
        Me.lblStatus.TabIndex = 20
        Me.lblStatus.Text = "Status"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboStatus.Items.AddRange(New Object() {"Checked-In"})
        Me.cboStatus.Location = New System.Drawing.Point(16, 542)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(272, 33)
        Me.cboStatus.TabIndex = 21
        '
        'btnCheckIn
        '
        Me.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckIn.Enabled = False
        Me.btnCheckIn.FlatAppearance.BorderSize = 0
        Me.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckIn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCheckIn.ForeColor = System.Drawing.Color.White
        Me.btnCheckIn.Location = New System.Drawing.Point(16, 584)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(272, 36)
        Me.btnCheckIn.TabIndex = 22
        Me.btnCheckIn.Text = "Proses Check-In"
        Me.btnCheckIn.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBatal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnBatal.Location = New System.Drawing.Point(16, 628)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(272, 30)
        Me.btnBatal.TabIndex = 23
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'pnlRight
        '
        Me.pnlRight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Controls.Add(Me.lblGridTitle)
        Me.pnlRight.Controls.Add(Me.lblFilterTitle)
        Me.pnlRight.Controls.Add(Me.cboFilter)
        Me.pnlRight.Controls.Add(Me.txtCari)
        Me.pnlRight.Controls.Add(Me.btnCari)
        Me.pnlRight.Controls.Add(Me.btnRefresh)
        Me.pnlRight.Controls.Add(Me.dgvCheckin)
        Me.pnlRight.Location = New System.Drawing.Point(314, 56)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(666, 660)
        Me.pnlRight.TabIndex = 2
        '
        'lblGridTitle
        '
        Me.lblGridTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGridTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.lblGridTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblGridTitle.Name = "lblGridTitle"
        Me.lblGridTitle.Size = New System.Drawing.Size(300, 24)
        Me.lblGridTitle.TabIndex = 0
        Me.lblGridTitle.Text = "Daftar Reservasi — Siap Check-In"
        '
        'lblFilterTitle
        '
        Me.lblFilterTitle.AutoSize = True
        Me.lblFilterTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFilterTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblFilterTitle.Location = New System.Drawing.Point(12, 46)
        Me.lblFilterTitle.Name = "lblFilterTitle"
        Me.lblFilterTitle.Size = New System.Drawing.Size(54, 25)
        Me.lblFilterTitle.TabIndex = 1
        Me.lblFilterTitle.Text = "Filter:"
        '
        'cboFilter
        '
        Me.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboFilter.Items.AddRange(New Object() {"Semua", "Pending"})
        Me.cboFilter.Location = New System.Drawing.Point(54, 43)
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(140, 33)
        Me.cboFilter.TabIndex = 2
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCari.Location = New System.Drawing.Point(204, 43)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(180, 31)
        Me.txtCari.TabIndex = 3
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.FlatAppearance.BorderSize = 0
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(390, 42)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(60, 26)
        Me.btnCari.TabIndex = 4
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
        Me.btnRefresh.Location = New System.Drawing.Point(456, 42)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(70, 26)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'dgvCheckin
        '
        Me.dgvCheckin.AllowUserToAddRows = False
        Me.dgvCheckin.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvCheckin.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCheckin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCheckin.AutoGenerateColumns = False
        Me.dgvCheckin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCheckin.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCheckin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCheckin.ColumnHeadersHeight = 32
        Me.dgvCheckin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDReservasiDataGridViewTextBoxColumn, Me.NIKDataGridViewTextBoxColumn, Me.NamaTamuDataGridViewTextBoxColumn, Me.NoHPDataGridViewTextBoxColumn, Me.NomorKamarDataGridViewTextBoxColumn, Me.TipeKamarDataGridViewTextBoxColumn, Me.TipeReservasiDataGridViewTextBoxColumn, Me.TglCheckInDataGridViewTextBoxColumn, Me.TglCheckOutPlanDataGridViewTextBoxColumn, Me.DurasiMalamDataGridViewTextBoxColumn, Me.HargaMalamDataGridViewTextBoxColumn, Me.HariMenginapSekarangDataGridViewTextBoxColumn, Me.HariTerlambatDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.dgvCheckin.DataSource = Me.VwCheckInAktifBindingSource1
        Me.dgvCheckin.EnableHeadersVisualStyles = False
        Me.dgvCheckin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvCheckin.Location = New System.Drawing.Point(12, 80)
        Me.dgvCheckin.MultiSelect = False
        Me.dgvCheckin.Name = "dgvCheckin"
        Me.dgvCheckin.ReadOnly = True
        Me.dgvCheckin.RowHeadersVisible = False
        Me.dgvCheckin.RowHeadersWidth = 62
        Me.dgvCheckin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCheckin.Size = New System.Drawing.Size(640, 564)
        Me.dgvCheckin.TabIndex = 0
        '
        'IDReservasiDataGridViewTextBoxColumn
        '
        Me.IDReservasiDataGridViewTextBoxColumn.DataPropertyName = "ID Reservasi"
        Me.IDReservasiDataGridViewTextBoxColumn.HeaderText = "ID Reservasi"
        Me.IDReservasiDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDReservasiDataGridViewTextBoxColumn.Name = "IDReservasiDataGridViewTextBoxColumn"
        Me.IDReservasiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NIKDataGridViewTextBoxColumn
        '
        Me.NIKDataGridViewTextBoxColumn.DataPropertyName = "NIK"
        Me.NIKDataGridViewTextBoxColumn.HeaderText = "NIK"
        Me.NIKDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NIKDataGridViewTextBoxColumn.Name = "NIKDataGridViewTextBoxColumn"
        Me.NIKDataGridViewTextBoxColumn.ReadOnly = True
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
        'TglCheckInDataGridViewTextBoxColumn
        '
        Me.TglCheckInDataGridViewTextBoxColumn.DataPropertyName = "Tgl Check-In"
        Me.TglCheckInDataGridViewTextBoxColumn.HeaderText = "Tgl Check-In"
        Me.TglCheckInDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TglCheckInDataGridViewTextBoxColumn.Name = "TglCheckInDataGridViewTextBoxColumn"
        Me.TglCheckInDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TglCheckOutPlanDataGridViewTextBoxColumn
        '
        Me.TglCheckOutPlanDataGridViewTextBoxColumn.DataPropertyName = "Tgl Check-Out Plan"
        Me.TglCheckOutPlanDataGridViewTextBoxColumn.HeaderText = "Tgl Check-Out Plan"
        Me.TglCheckOutPlanDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TglCheckOutPlanDataGridViewTextBoxColumn.Name = "TglCheckOutPlanDataGridViewTextBoxColumn"
        Me.TglCheckOutPlanDataGridViewTextBoxColumn.ReadOnly = True
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
        'HariMenginapSekarangDataGridViewTextBoxColumn
        '
        Me.HariMenginapSekarangDataGridViewTextBoxColumn.DataPropertyName = "Hari Menginap Sekarang"
        Me.HariMenginapSekarangDataGridViewTextBoxColumn.HeaderText = "Hari Menginap Sekarang"
        Me.HariMenginapSekarangDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.HariMenginapSekarangDataGridViewTextBoxColumn.Name = "HariMenginapSekarangDataGridViewTextBoxColumn"
        Me.HariMenginapSekarangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HariTerlambatDataGridViewTextBoxColumn
        '
        Me.HariTerlambatDataGridViewTextBoxColumn.DataPropertyName = "Hari Terlambat"
        Me.HariTerlambatDataGridViewTextBoxColumn.HeaderText = "Hari Terlambat"
        Me.HariTerlambatDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.HariTerlambatDataGridViewTextBoxColumn.Name = "HariTerlambatDataGridViewTextBoxColumn"
        Me.HariTerlambatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VwCheckInAktifBindingSource
        '
        Me.VwCheckInAktifBindingSource.DataMember = "vw_CheckInAktif"
        Me.VwCheckInAktifBindingSource.DataSource = Me.HotelDBDataSet
        '
        'HotelDBDataSet
        '
        Me.HotelDBDataSet.DataSetName = "HotelDBDataSet"
        Me.HotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_CheckInAktifTableAdapter
        '
        Me.Vw_CheckInAktifTableAdapter.ClearBeforeFill = True
        '
        'VwCheckInAktifBindingSource1
        '
        Me.VwCheckInAktifBindingSource1.DataMember = "vw_CheckInAktif"
        Me.VwCheckInAktifBindingSource1.DataSource = Me.HotelDBDataSet
        '
        'CheckInForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(980, 716)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlRight)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "CheckInForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Check-In"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        CType(Me.dgvCheckin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCheckInAktifBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCheckInAktifBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblInfoTitle As System.Windows.Forms.Label
    Friend WithEvents lblIdReservasi As System.Windows.Forms.Label
    Friend WithEvents txtIdReservasi As System.Windows.Forms.TextBox
    Friend WithEvents lblNamaTamu As System.Windows.Forms.Label
    Friend WithEvents txtNamaTamu As System.Windows.Forms.TextBox
    Friend WithEvents lblKamar As System.Windows.Forms.Label
    Friend WithEvents txtKamar As System.Windows.Forms.TextBox
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents lblTipe As System.Windows.Forms.Label
    Friend WithEvents txtTipe As System.Windows.Forms.TextBox
    Friend WithEvents pnlDivider As System.Windows.Forms.Panel
    Friend WithEvents lblCheckinTitle As System.Windows.Forms.Label
    Friend WithEvents lblTglCheckin As System.Windows.Forms.Label
    Friend WithEvents dtpTglCheckin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTglCheckout As System.Windows.Forms.Label
    Friend WithEvents dtpTglCheckout As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEstimasi As System.Windows.Forms.Label
    Friend WithEvents txtEstimasi As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnCheckIn As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents lblGridTitle As System.Windows.Forms.Label
    Friend WithEvents lblFilterTitle As System.Windows.Forms.Label
    Friend WithEvents cboFilter As System.Windows.Forms.ComboBox
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvCheckin As System.Windows.Forms.DataGridView
    Friend WithEvents HotelDBDataSet As HotelDBDataSet
    Friend WithEvents VwCheckInAktifBindingSource As BindingSource
    Friend WithEvents Vw_CheckInAktifTableAdapter As HotelDBDataSetTableAdapters.vw_CheckInAktifTableAdapter
    Friend WithEvents IDReservasiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NIKDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaTamuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoHPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomorKamarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipeKamarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipeReservasiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglCheckInDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglCheckOutPlanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DurasiMalamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaMalamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HariMenginapSekarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HariTerlambatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QueriesTableAdapter1 As HotelDBDataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents VwCheckInAktifBindingSource1 As BindingSource
End Class