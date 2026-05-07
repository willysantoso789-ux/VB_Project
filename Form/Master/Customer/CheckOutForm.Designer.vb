<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CheckOutForm
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
        Me.lblInfoTitle = New System.Windows.Forms.Label()
        Me.lblIdReservasi = New System.Windows.Forms.Label()
        Me.txtIdReservasi = New System.Windows.Forms.TextBox()
        Me.lblNamaTamu = New System.Windows.Forms.Label()
        Me.txtNamaTamu = New System.Windows.Forms.TextBox()
        Me.lblKamar = New System.Windows.Forms.Label()
        Me.txtKamar = New System.Windows.Forms.TextBox()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.lblTglCheckin = New System.Windows.Forms.Label()
        Me.txtTglCheckin = New System.Windows.Forms.TextBox()
        Me.lblTglCheckout = New System.Windows.Forms.Label()
        Me.txtTglCheckout = New System.Windows.Forms.TextBox()
        Me.pnlDivider1 = New System.Windows.Forms.Panel()
        Me.lblBiayaTitle = New System.Windows.Forms.Label()
        Me.lblTglAktual = New System.Windows.Forms.Label()
        Me.txtTglAktual = New System.Windows.Forms.TextBox()
        Me.lblMalam = New System.Windows.Forms.Label()
        Me.txtMalam = New System.Windows.Forms.TextBox()
        Me.lblBiayaKamar = New System.Windows.Forms.Label()
        Me.txtBiayaKamar = New System.Windows.Forms.TextBox()
        Me.lblDendaTelat = New System.Windows.Forms.Label()
        Me.txtDendaTelat = New System.Windows.Forms.TextBox()
        Me.lblDendaKerusakan = New System.Windows.Forms.Label()
        Me.txtDendaKerusakan = New System.Windows.Forms.TextBox()
        Me.btnDenda = New System.Windows.Forms.Button()
        Me.pnlDivider2 = New System.Windows.Forms.Panel()
        Me.lblTotalTitle = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblMetode = New System.Windows.Forms.Label()
        Me.cboMetode = New System.Windows.Forms.ComboBox()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.lblGridTitle = New System.Windows.Forms.Label()
        Me.cboFilter = New System.Windows.Forms.ComboBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvCheckOut = New System.Windows.Forms.DataGridView()
        Me.HotelDBDataSet = New VB_PROJECT.HotelDBDataSet()
        Me.VwCheckInAktifBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_CheckInAktifTableAdapter = New VB_PROJECT.HotelDBDataSetTableAdapters.vw_CheckInAktifTableAdapter()
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
        Me.QueriesTableAdapter1 = New VB_PROJECT.HotelDBDataSetTableAdapters.QueriesTableAdapter()
        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        CType(Me.dgvCheckOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwCheckInAktifBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
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
        Me.lblTitle.Text = "Check-Out"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(500, 18)
        Me.lblSubTitle.TabIndex = 1
        Me.lblSubTitle.Text = "Proses check-out dan perhitungan biaya tamu"
        '
        'pnlLeft
        '
        Me.pnlLeft.AutoScroll = True
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
        Me.pnlLeft.Controls.Add(Me.lblTglCheckin)
        Me.pnlLeft.Controls.Add(Me.txtTglCheckin)
        Me.pnlLeft.Controls.Add(Me.lblTglCheckout)
        Me.pnlLeft.Controls.Add(Me.txtTglCheckout)
        Me.pnlLeft.Controls.Add(Me.pnlDivider1)
        Me.pnlLeft.Controls.Add(Me.lblBiayaTitle)
        Me.pnlLeft.Controls.Add(Me.lblTglAktual)
        Me.pnlLeft.Controls.Add(Me.txtTglAktual)
        Me.pnlLeft.Controls.Add(Me.lblMalam)
        Me.pnlLeft.Controls.Add(Me.txtMalam)
        Me.pnlLeft.Controls.Add(Me.lblBiayaKamar)
        Me.pnlLeft.Controls.Add(Me.txtBiayaKamar)
        Me.pnlLeft.Controls.Add(Me.lblDendaTelat)
        Me.pnlLeft.Controls.Add(Me.txtDendaTelat)
        Me.pnlLeft.Controls.Add(Me.lblDendaKerusakan)
        Me.pnlLeft.Controls.Add(Me.txtDendaKerusakan)
        Me.pnlLeft.Controls.Add(Me.btnDenda)
        Me.pnlLeft.Controls.Add(Me.pnlDivider2)
        Me.pnlLeft.Controls.Add(Me.lblTotalTitle)
        Me.pnlLeft.Controls.Add(Me.txtTotal)
        Me.pnlLeft.Controls.Add(Me.lblMetode)
        Me.pnlLeft.Controls.Add(Me.cboMetode)
        Me.pnlLeft.Controls.Add(Me.btnCheckOut)
        Me.pnlLeft.Controls.Add(Me.btnBatal)
        Me.pnlLeft.Location = New System.Drawing.Point(0, 56)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(320, 820)
        Me.pnlLeft.TabIndex = 1
        '
        'lblFormTitle
        '
        Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblFormTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(288, 24)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Form Check-Out"
        '
        'lblInfoTitle
        '
        Me.lblInfoTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblInfoTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblInfoTitle.Location = New System.Drawing.Point(16, 44)
        Me.lblInfoTitle.Name = "lblInfoTitle"
        Me.lblInfoTitle.Size = New System.Drawing.Size(288, 18)
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
        Me.txtIdReservasi.Size = New System.Drawing.Size(282, 31)
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
        Me.txtNamaTamu.Size = New System.Drawing.Size(282, 31)
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
        Me.txtKamar.Size = New System.Drawing.Size(282, 31)
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
        Me.txtHarga.Size = New System.Drawing.Size(282, 31)
        Me.txtHarga.TabIndex = 9
        '
        'lblTglCheckin
        '
        Me.lblTglCheckin.AutoSize = True
        Me.lblTglCheckin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTglCheckin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTglCheckin.Location = New System.Drawing.Point(16, 276)
        Me.lblTglCheckin.Name = "lblTglCheckin"
        Me.lblTglCheckin.Size = New System.Drawing.Size(147, 25)
        Me.lblTglCheckin.TabIndex = 10
        Me.lblTglCheckin.Text = "Tanggal Check-In"
        '
        'txtTglCheckin
        '
        Me.txtTglCheckin.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtTglCheckin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTglCheckin.Location = New System.Drawing.Point(16, 294)
        Me.txtTglCheckin.Name = "txtTglCheckin"
        Me.txtTglCheckin.ReadOnly = True
        Me.txtTglCheckin.Size = New System.Drawing.Size(282, 31)
        Me.txtTglCheckin.TabIndex = 11
        '
        'lblTglCheckout
        '
        Me.lblTglCheckout.AutoSize = True
        Me.lblTglCheckout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTglCheckout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTglCheckout.Location = New System.Drawing.Point(16, 328)
        Me.lblTglCheckout.Name = "lblTglCheckout"
        Me.lblTglCheckout.Size = New System.Drawing.Size(242, 25)
        Me.lblTglCheckout.TabIndex = 12
        Me.lblTglCheckout.Text = "Tanggal Check-Out (Rencana)"
        '
        'txtTglCheckout
        '
        Me.txtTglCheckout.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtTglCheckout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTglCheckout.Location = New System.Drawing.Point(16, 346)
        Me.txtTglCheckout.Name = "txtTglCheckout"
        Me.txtTglCheckout.ReadOnly = True
        Me.txtTglCheckout.Size = New System.Drawing.Size(282, 31)
        Me.txtTglCheckout.TabIndex = 13
        '
        'pnlDivider1
        '
        Me.pnlDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlDivider1.Location = New System.Drawing.Point(16, 382)
        Me.pnlDivider1.Name = "pnlDivider1"
        Me.pnlDivider1.Size = New System.Drawing.Size(282, 1)
        Me.pnlDivider1.TabIndex = 14
        '
        'lblBiayaTitle
        '
        Me.lblBiayaTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblBiayaTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblBiayaTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblBiayaTitle.Location = New System.Drawing.Point(16, 392)
        Me.lblBiayaTitle.Name = "lblBiayaTitle"
        Me.lblBiayaTitle.Size = New System.Drawing.Size(288, 18)
        Me.lblBiayaTitle.TabIndex = 15
        Me.lblBiayaTitle.Text = "PERHITUNGAN BIAYA"
        '
        'lblTglAktual
        '
        Me.lblTglAktual.AutoSize = True
        Me.lblTglAktual.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTglAktual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTglAktual.Location = New System.Drawing.Point(16, 418)
        Me.lblTglAktual.Name = "lblTglAktual"
        Me.lblTglAktual.Size = New System.Drawing.Size(217, 25)
        Me.lblTglAktual.TabIndex = 16
        Me.lblTglAktual.Text = "Tanggal Check-Out Aktual"
        '
        'txtTglAktual
        '
        Me.txtTglAktual.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtTglAktual.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.txtTglAktual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTglAktual.Location = New System.Drawing.Point(16, 436)
        Me.txtTglAktual.Name = "txtTglAktual"
        Me.txtTglAktual.ReadOnly = True
        Me.txtTglAktual.Size = New System.Drawing.Size(282, 33)
        Me.txtTglAktual.TabIndex = 17
        Me.txtTglAktual.Text = "07/05/2026 (Hari Ini)"
        '
        'lblMalam
        '
        Me.lblMalam.AutoSize = True
        Me.lblMalam.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblMalam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblMalam.Location = New System.Drawing.Point(16, 470)
        Me.lblMalam.Name = "lblMalam"
        Me.lblMalam.Size = New System.Drawing.Size(126, 25)
        Me.lblMalam.TabIndex = 18
        Me.lblMalam.Text = "Jumlah Malam"
        '
        'txtMalam
        '
        Me.txtMalam.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtMalam.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMalam.Location = New System.Drawing.Point(16, 488)
        Me.txtMalam.Name = "txtMalam"
        Me.txtMalam.ReadOnly = True
        Me.txtMalam.Size = New System.Drawing.Size(282, 31)
        Me.txtMalam.TabIndex = 19
        '
        'lblBiayaKamar
        '
        Me.lblBiayaKamar.AutoSize = True
        Me.lblBiayaKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBiayaKamar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblBiayaKamar.Location = New System.Drawing.Point(16, 522)
        Me.lblBiayaKamar.Name = "lblBiayaKamar"
        Me.lblBiayaKamar.Size = New System.Drawing.Size(108, 25)
        Me.lblBiayaKamar.TabIndex = 20
        Me.lblBiayaKamar.Text = "Biaya Kamar"
        '
        'txtBiayaKamar
        '
        Me.txtBiayaKamar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtBiayaKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBiayaKamar.Location = New System.Drawing.Point(16, 540)
        Me.txtBiayaKamar.Name = "txtBiayaKamar"
        Me.txtBiayaKamar.ReadOnly = True
        Me.txtBiayaKamar.Size = New System.Drawing.Size(282, 31)
        Me.txtBiayaKamar.TabIndex = 21
        '
        'lblDendaTelat
        '
        Me.lblDendaTelat.AutoSize = True
        Me.lblDendaTelat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDendaTelat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblDendaTelat.Location = New System.Drawing.Point(16, 574)
        Me.lblDendaTelat.Name = "lblDendaTelat"
        Me.lblDendaTelat.Size = New System.Drawing.Size(183, 25)
        Me.lblDendaTelat.TabIndex = 22
        Me.lblDendaTelat.Text = "Denda Keterlambatan"
        '
        'txtDendaTelat
        '
        Me.txtDendaTelat.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDendaTelat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDendaTelat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.txtDendaTelat.Location = New System.Drawing.Point(16, 592)
        Me.txtDendaTelat.Name = "txtDendaTelat"
        Me.txtDendaTelat.ReadOnly = True
        Me.txtDendaTelat.Size = New System.Drawing.Size(282, 31)
        Me.txtDendaTelat.TabIndex = 23
        Me.txtDendaTelat.Text = "Rp 0"
        '
        'lblDendaKerusakan
        '
        Me.lblDendaKerusakan.AutoSize = True
        Me.lblDendaKerusakan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDendaKerusakan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblDendaKerusakan.Location = New System.Drawing.Point(16, 626)
        Me.lblDendaKerusakan.Name = "lblDendaKerusakan"
        Me.lblDendaKerusakan.Size = New System.Drawing.Size(217, 25)
        Me.lblDendaKerusakan.TabIndex = 24
        Me.lblDendaKerusakan.Text = "Denda Kerusakan Properti"
        '
        'txtDendaKerusakan
        '
        Me.txtDendaKerusakan.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDendaKerusakan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDendaKerusakan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.txtDendaKerusakan.Location = New System.Drawing.Point(16, 644)
        Me.txtDendaKerusakan.Name = "txtDendaKerusakan"
        Me.txtDendaKerusakan.ReadOnly = True
        Me.txtDendaKerusakan.Size = New System.Drawing.Size(190, 31)
        Me.txtDendaKerusakan.TabIndex = 25
        Me.txtDendaKerusakan.Text = "Rp 0"
        '
        'btnDenda
        '
        Me.btnDenda.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnDenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDenda.Enabled = False
        Me.btnDenda.FlatAppearance.BorderSize = 0
        Me.btnDenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDenda.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnDenda.ForeColor = System.Drawing.Color.White
        Me.btnDenda.Location = New System.Drawing.Point(212, 644)
        Me.btnDenda.Name = "btnDenda"
        Me.btnDenda.Size = New System.Drawing.Size(86, 26)
        Me.btnDenda.TabIndex = 26
        Me.btnDenda.Text = "+ Detail"
        Me.btnDenda.UseVisualStyleBackColor = False
        '
        'pnlDivider2
        '
        Me.pnlDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlDivider2.Location = New System.Drawing.Point(16, 682)
        Me.pnlDivider2.Name = "pnlDivider2"
        Me.pnlDivider2.Size = New System.Drawing.Size(282, 1)
        Me.pnlDivider2.TabIndex = 27
        '
        'lblTotalTitle
        '
        Me.lblTotalTitle.AutoSize = True
        Me.lblTotalTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTotalTitle.Location = New System.Drawing.Point(16, 692)
        Me.lblTotalTitle.Name = "lblTotalTitle"
        Me.lblTotalTitle.Size = New System.Drawing.Size(196, 25)
        Me.lblTotalTitle.TabIndex = 28
        Me.lblTotalTitle.Text = "TOTAL PEMBAYARAN"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.txtTotal.Location = New System.Drawing.Point(16, 712)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(282, 37)
        Me.txtTotal.TabIndex = 29
        Me.txtTotal.Text = "Rp 0"
        '
        'lblMetode
        '
        Me.lblMetode.AutoSize = True
        Me.lblMetode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblMetode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblMetode.Location = New System.Drawing.Point(16, 750)
        Me.lblMetode.Name = "lblMetode"
        Me.lblMetode.Size = New System.Drawing.Size(176, 25)
        Me.lblMetode.TabIndex = 30
        Me.lblMetode.Text = "Metode Pembayaran"
        '
        'cboMetode
        '
        Me.cboMetode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMetode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboMetode.Items.AddRange(New Object() {"Tunai", "Kartu Debit", "Kartu Kredit", "Transfer Bank", "QRIS"})
        Me.cboMetode.Location = New System.Drawing.Point(16, 768)
        Me.cboMetode.Name = "cboMetode"
        Me.cboMetode.Size = New System.Drawing.Size(282, 33)
        Me.cboMetode.TabIndex = 31
        '
        'btnCheckOut
        '
        Me.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckOut.Enabled = False
        Me.btnCheckOut.FlatAppearance.BorderSize = 0
        Me.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckOut.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCheckOut.ForeColor = System.Drawing.Color.White
        Me.btnCheckOut.Location = New System.Drawing.Point(16, 808)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(282, 36)
        Me.btnCheckOut.TabIndex = 32
        Me.btnCheckOut.Text = "Proses Check-Out"
        Me.btnCheckOut.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBatal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnBatal.Location = New System.Drawing.Point(16, 852)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(282, 30)
        Me.btnBatal.TabIndex = 33
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
        Me.pnlRight.Controls.Add(Me.cboFilter)
        Me.pnlRight.Controls.Add(Me.txtCari)
        Me.pnlRight.Controls.Add(Me.btnCari)
        Me.pnlRight.Controls.Add(Me.btnRefresh)
        Me.pnlRight.Controls.Add(Me.dgvCheckOut)
        Me.pnlRight.Location = New System.Drawing.Point(324, 56)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(656, 660)
        Me.pnlRight.TabIndex = 2
        '
        'lblGridTitle
        '
        Me.lblGridTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGridTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblGridTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblGridTitle.Name = "lblGridTitle"
        Me.lblGridTitle.Size = New System.Drawing.Size(300, 24)
        Me.lblGridTitle.TabIndex = 0
        Me.lblGridTitle.Text = "Daftar Tamu — Checked-In"
        '
        'cboFilter
        '
        Me.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboFilter.Items.AddRange(New Object() {"Checked-In", "Checked-Out", "Semua"})
        Me.cboFilter.Location = New System.Drawing.Point(12, 44)
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(140, 33)
        Me.cboFilter.TabIndex = 1
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCari.Location = New System.Drawing.Point(160, 43)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(180, 31)
        Me.txtCari.TabIndex = 2
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.FlatAppearance.BorderSize = 0
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(346, 42)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(60, 26)
        Me.btnCari.TabIndex = 3
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
        Me.btnRefresh.Location = New System.Drawing.Point(412, 42)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(70, 26)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'dgvCheckOut
        '
        Me.dgvCheckOut.AllowUserToAddRows = False
        Me.dgvCheckOut.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgvCheckOut.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCheckOut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCheckOut.AutoGenerateColumns = False
        Me.dgvCheckOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCheckOut.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCheckOut.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCheckOut.ColumnHeadersHeight = 32
        Me.dgvCheckOut.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDReservasiDataGridViewTextBoxColumn, Me.NIKDataGridViewTextBoxColumn, Me.NamaTamuDataGridViewTextBoxColumn, Me.NoHPDataGridViewTextBoxColumn, Me.NomorKamarDataGridViewTextBoxColumn, Me.TipeKamarDataGridViewTextBoxColumn, Me.TipeReservasiDataGridViewTextBoxColumn, Me.TglCheckInDataGridViewTextBoxColumn, Me.TglCheckOutPlanDataGridViewTextBoxColumn, Me.DurasiMalamDataGridViewTextBoxColumn, Me.HargaMalamDataGridViewTextBoxColumn, Me.HariMenginapSekarangDataGridViewTextBoxColumn, Me.HariTerlambatDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.dgvCheckOut.DataSource = Me.VwCheckInAktifBindingSource
        Me.dgvCheckOut.EnableHeadersVisualStyles = False
        Me.dgvCheckOut.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvCheckOut.Location = New System.Drawing.Point(12, 80)
        Me.dgvCheckOut.MultiSelect = False
        Me.dgvCheckOut.Name = "dgvCheckOut"
        Me.dgvCheckOut.ReadOnly = True
        Me.dgvCheckOut.RowHeadersVisible = False
        Me.dgvCheckOut.RowHeadersWidth = 62
        Me.dgvCheckOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCheckOut.Size = New System.Drawing.Size(630, 564)
        Me.dgvCheckOut.TabIndex = 0
        '
        'HotelDBDataSet
        '
        Me.HotelDBDataSet.DataSetName = "HotelDBDataSet"
        Me.HotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwCheckInAktifBindingSource
        '
        Me.VwCheckInAktifBindingSource.DataMember = "vw_CheckInAktif"
        Me.VwCheckInAktifBindingSource.DataSource = Me.HotelDBDataSet
        '
        'Vw_CheckInAktifTableAdapter
        '
        Me.Vw_CheckInAktifTableAdapter.ClearBeforeFill = True
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
        'CheckOutForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(980, 716)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlRight)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "CheckOutForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Check-Out"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        CType(Me.dgvCheckOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwCheckInAktifBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblTglCheckin As System.Windows.Forms.Label
    Friend WithEvents txtTglCheckin As System.Windows.Forms.TextBox
    Friend WithEvents lblTglCheckout As System.Windows.Forms.Label
    Friend WithEvents txtTglCheckout As System.Windows.Forms.TextBox
    Friend WithEvents pnlDivider1 As System.Windows.Forms.Panel
    Friend WithEvents lblBiayaTitle As System.Windows.Forms.Label
    Friend WithEvents lblTglAktual As System.Windows.Forms.Label
    Friend WithEvents txtTglAktual As System.Windows.Forms.TextBox
    Friend WithEvents lblMalam As System.Windows.Forms.Label
    Friend WithEvents txtMalam As System.Windows.Forms.TextBox
    Friend WithEvents lblBiayaKamar As System.Windows.Forms.Label
    Friend WithEvents txtBiayaKamar As System.Windows.Forms.TextBox
    Friend WithEvents lblDendaTelat As System.Windows.Forms.Label
    Friend WithEvents txtDendaTelat As System.Windows.Forms.TextBox
    Friend WithEvents lblDendaKerusakan As System.Windows.Forms.Label
    Friend WithEvents txtDendaKerusakan As System.Windows.Forms.TextBox
    Friend WithEvents btnDenda As System.Windows.Forms.Button
    Friend WithEvents pnlDivider2 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalTitle As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblMetode As System.Windows.Forms.Label
    Friend WithEvents cboMetode As System.Windows.Forms.ComboBox
    Friend WithEvents btnCheckOut As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents lblGridTitle As System.Windows.Forms.Label
    Friend WithEvents cboFilter As System.Windows.Forms.ComboBox
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvCheckOut As System.Windows.Forms.DataGridView
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
End Class
