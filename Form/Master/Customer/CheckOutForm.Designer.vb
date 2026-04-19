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
        Me.dtpTglAktual = New System.Windows.Forms.DateTimePicker()
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

        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        CType(Me.dgvCheckOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '
        'pnlHeader
        '
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 56
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(153, 27, 27)
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
        Me.lblTitle.Text = "Check-Out"

        '
        'lblSubTitle
        '
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.AutoSize = False
        Me.lblSubTitle.Size = New System.Drawing.Size(500, 18)
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(254, 202, 202)
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Text = "Proses check-out dan perhitungan biaya tamu"

        '
        'pnlLeft
        '
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Location = New System.Drawing.Point(0, 56)
        Me.pnlLeft.Size = New System.Drawing.Size(320, 820)
        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLeft.AutoScroll = True
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
        Me.pnlLeft.Controls.Add(Me.dtpTglAktual)
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

        '
        'lblFormTitle
        '
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.AutoSize = False
        Me.lblFormTitle.Size = New System.Drawing.Size(288, 24)
        Me.lblFormTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFormTitle.Text = "Form Check-Out"

        '
        'lblInfoTitle
        '
        Me.lblInfoTitle.Name = "lblInfoTitle"
        Me.lblInfoTitle.AutoSize = False
        Me.lblInfoTitle.Size = New System.Drawing.Size(288, 18)
        Me.lblInfoTitle.Location = New System.Drawing.Point(16, 44)
        Me.lblInfoTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(130, 130, 130)
        Me.lblInfoTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblInfoTitle.Text = "INFO RESERVASI (READ ONLY)"

        '
        'lblIdReservasi
        '
        Me.lblIdReservasi.Name = "lblIdReservasi"
        Me.lblIdReservasi.AutoSize = True
        Me.lblIdReservasi.Location = New System.Drawing.Point(16, 68)
        Me.lblIdReservasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdReservasi.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblIdReservasi.Text = "ID Reservasi"

        '
        'txtIdReservasi
        '
        Me.txtIdReservasi.Name = "txtIdReservasi"
        Me.txtIdReservasi.Location = New System.Drawing.Point(16, 86)
        Me.txtIdReservasi.Size = New System.Drawing.Size(282, 24)
        Me.txtIdReservasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtIdReservasi.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtIdReservasi.ReadOnly = True

        '
        'lblNamaTamu
        '
        Me.lblNamaTamu.Name = "lblNamaTamu"
        Me.lblNamaTamu.AutoSize = True
        Me.lblNamaTamu.Location = New System.Drawing.Point(16, 120)
        Me.lblNamaTamu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNamaTamu.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblNamaTamu.Text = "Nama Tamu"

        '
        'txtNamaTamu
        '
        Me.txtNamaTamu.Name = "txtNamaTamu"
        Me.txtNamaTamu.Location = New System.Drawing.Point(16, 138)
        Me.txtNamaTamu.Size = New System.Drawing.Size(282, 24)
        Me.txtNamaTamu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNamaTamu.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtNamaTamu.ReadOnly = True

        '
        'lblKamar
        '
        Me.lblKamar.Name = "lblKamar"
        Me.lblKamar.AutoSize = True
        Me.lblKamar.Location = New System.Drawing.Point(16, 172)
        Me.lblKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKamar.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblKamar.Text = "Kamar"

        '
        'txtKamar
        '
        Me.txtKamar.Name = "txtKamar"
        Me.txtKamar.Location = New System.Drawing.Point(16, 190)
        Me.txtKamar.Size = New System.Drawing.Size(282, 24)
        Me.txtKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtKamar.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtKamar.ReadOnly = True

        '
        'lblHarga
        '
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Location = New System.Drawing.Point(16, 224)
        Me.lblHarga.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHarga.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblHarga.Text = "Harga / Malam"

        '
        'txtHarga
        '
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Location = New System.Drawing.Point(16, 242)
        Me.txtHarga.Size = New System.Drawing.Size(282, 24)
        Me.txtHarga.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtHarga.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtHarga.ReadOnly = True

        '
        'lblTglCheckin
        '
        Me.lblTglCheckin.Name = "lblTglCheckin"
        Me.lblTglCheckin.AutoSize = True
        Me.lblTglCheckin.Location = New System.Drawing.Point(16, 276)
        Me.lblTglCheckin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTglCheckin.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblTglCheckin.Text = "Tanggal Check-In"

        '
        'txtTglCheckin
        '
        Me.txtTglCheckin.Name = "txtTglCheckin"
        Me.txtTglCheckin.Location = New System.Drawing.Point(16, 294)
        Me.txtTglCheckin.Size = New System.Drawing.Size(282, 24)
        Me.txtTglCheckin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTglCheckin.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtTglCheckin.ReadOnly = True

        '
        'lblTglCheckout
        '
        Me.lblTglCheckout.Name = "lblTglCheckout"
        Me.lblTglCheckout.AutoSize = True
        Me.lblTglCheckout.Location = New System.Drawing.Point(16, 328)
        Me.lblTglCheckout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTglCheckout.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblTglCheckout.Text = "Tanggal Check-Out (Rencana)"

        '
        'txtTglCheckout
        '
        Me.txtTglCheckout.Name = "txtTglCheckout"
        Me.txtTglCheckout.Location = New System.Drawing.Point(16, 346)
        Me.txtTglCheckout.Size = New System.Drawing.Size(282, 24)
        Me.txtTglCheckout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTglCheckout.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtTglCheckout.ReadOnly = True

        '
        'pnlDivider1
        '
        Me.pnlDivider1.Name = "pnlDivider1"
        Me.pnlDivider1.Location = New System.Drawing.Point(16, 382)
        Me.pnlDivider1.Size = New System.Drawing.Size(282, 1)
        Me.pnlDivider1.BackColor = System.Drawing.Color.FromArgb(210, 215, 225)

        '
        'lblBiayaTitle
        '
        Me.lblBiayaTitle.Name = "lblBiayaTitle"
        Me.lblBiayaTitle.AutoSize = False
        Me.lblBiayaTitle.Size = New System.Drawing.Size(288, 18)
        Me.lblBiayaTitle.Location = New System.Drawing.Point(16, 392)
        Me.lblBiayaTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblBiayaTitle.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.lblBiayaTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblBiayaTitle.Text = "PERHITUNGAN BIAYA"

        '
        'lblTglAktual
        '
        Me.lblTglAktual.Name = "lblTglAktual"
        Me.lblTglAktual.AutoSize = True
        Me.lblTglAktual.Location = New System.Drawing.Point(16, 418)
        Me.lblTglAktual.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTglAktual.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblTglAktual.Text = "Tanggal Check-Out Aktual"

        '
        'dtpTglAktual
        '
        Me.dtpTglAktual.Name = "dtpTglAktual"
        Me.dtpTglAktual.Location = New System.Drawing.Point(16, 436)
        Me.dtpTglAktual.Size = New System.Drawing.Size(282, 24)
        Me.dtpTglAktual.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTglAktual.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpTglAktual.Value = DateTime.Today

        '
        'lblMalam
        '
        Me.lblMalam.Name = "lblMalam"
        Me.lblMalam.AutoSize = True
        Me.lblMalam.Location = New System.Drawing.Point(16, 470)
        Me.lblMalam.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblMalam.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblMalam.Text = "Jumlah Malam"

        '
        'txtMalam
        '
        Me.txtMalam.Name = "txtMalam"
        Me.txtMalam.Location = New System.Drawing.Point(16, 488)
        Me.txtMalam.Size = New System.Drawing.Size(282, 24)
        Me.txtMalam.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMalam.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtMalam.ReadOnly = True

        '
        'lblBiayaKamar
        '
        Me.lblBiayaKamar.Name = "lblBiayaKamar"
        Me.lblBiayaKamar.AutoSize = True
        Me.lblBiayaKamar.Location = New System.Drawing.Point(16, 522)
        Me.lblBiayaKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBiayaKamar.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblBiayaKamar.Text = "Biaya Kamar"

        '
        'txtBiayaKamar
        '
        Me.txtBiayaKamar.Name = "txtBiayaKamar"
        Me.txtBiayaKamar.Location = New System.Drawing.Point(16, 540)
        Me.txtBiayaKamar.Size = New System.Drawing.Size(282, 24)
        Me.txtBiayaKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBiayaKamar.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtBiayaKamar.ReadOnly = True

        '
        'lblDendaTelat
        '
        Me.lblDendaTelat.Name = "lblDendaTelat"
        Me.lblDendaTelat.AutoSize = True
        Me.lblDendaTelat.Location = New System.Drawing.Point(16, 574)
        Me.lblDendaTelat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDendaTelat.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.lblDendaTelat.Text = "Denda Keterlambatan"

        '
        'txtDendaTelat
        '
        Me.txtDendaTelat.Name = "txtDendaTelat"
        Me.txtDendaTelat.Location = New System.Drawing.Point(16, 592)
        Me.txtDendaTelat.Size = New System.Drawing.Size(282, 24)
        Me.txtDendaTelat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDendaTelat.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
        Me.txtDendaTelat.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.txtDendaTelat.ReadOnly = True
        Me.txtDendaTelat.Text = "Rp 0"

        '
        'lblDendaKerusakan
        '
        Me.lblDendaKerusakan.Name = "lblDendaKerusakan"
        Me.lblDendaKerusakan.AutoSize = True
        Me.lblDendaKerusakan.Location = New System.Drawing.Point(16, 626)
        Me.lblDendaKerusakan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDendaKerusakan.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.lblDendaKerusakan.Text = "Denda Kerusakan Properti"

        '
        'txtDendaKerusakan
        '
        Me.txtDendaKerusakan.Name = "txtDendaKerusakan"
        Me.txtDendaKerusakan.Location = New System.Drawing.Point(16, 644)
        Me.txtDendaKerusakan.Size = New System.Drawing.Size(190, 24)
        Me.txtDendaKerusakan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDendaKerusakan.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
        Me.txtDendaKerusakan.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.txtDendaKerusakan.ReadOnly = True
        Me.txtDendaKerusakan.Text = "Rp 0"

        '
        'btnDenda
        '
        Me.btnDenda.Name = "btnDenda"
        Me.btnDenda.Text = "+ Detail"
        Me.btnDenda.Location = New System.Drawing.Point(212, 644)
        Me.btnDenda.Size = New System.Drawing.Size(86, 26)
        Me.btnDenda.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnDenda.BackColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.btnDenda.ForeColor = System.Drawing.Color.White
        Me.btnDenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDenda.FlatAppearance.BorderSize = 0
        Me.btnDenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDenda.Enabled = False
        Me.btnDenda.UseVisualStyleBackColor = False

        '
        'pnlDivider2
        '
        Me.pnlDivider2.Name = "pnlDivider2"
        Me.pnlDivider2.Location = New System.Drawing.Point(16, 682)
        Me.pnlDivider2.Size = New System.Drawing.Size(282, 1)
        Me.pnlDivider2.BackColor = System.Drawing.Color.FromArgb(210, 215, 225)

        '
        'lblTotalTitle
        '
        Me.lblTotalTitle.Name = "lblTotalTitle"
        Me.lblTotalTitle.AutoSize = True
        Me.lblTotalTitle.Location = New System.Drawing.Point(16, 692)
        Me.lblTotalTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblTotalTitle.Text = "TOTAL PEMBAYARAN"

        '
        'txtTotal
        '
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Location = New System.Drawing.Point(16, 712)
        Me.txtTotal.Size = New System.Drawing.Size(282, 28)
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
        Me.txtTotal.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Text = "Rp 0"

        '
        'lblMetode
        '
        Me.lblMetode.Name = "lblMetode"
        Me.lblMetode.AutoSize = True
        Me.lblMetode.Location = New System.Drawing.Point(16, 750)
        Me.lblMetode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblMetode.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblMetode.Text = "Metode Pembayaran"

        '
        'cboMetode
        '
        Me.cboMetode.Name = "cboMetode"
        Me.cboMetode.Location = New System.Drawing.Point(16, 768)
        Me.cboMetode.Size = New System.Drawing.Size(282, 24)
        Me.cboMetode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboMetode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMetode.Items.AddRange(New Object() {"Tunai", "Kartu Debit", "Kartu Kredit", "Transfer Bank", "QRIS"})

        '
        'btnCheckOut
        '
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Text = "Proses Check-Out"
        Me.btnCheckOut.Location = New System.Drawing.Point(16, 808)
        Me.btnCheckOut.Size = New System.Drawing.Size(282, 36)
        Me.btnCheckOut.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.btnCheckOut.ForeColor = System.Drawing.Color.White
        Me.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckOut.FlatAppearance.BorderSize = 0
        Me.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckOut.Enabled = False
        Me.btnCheckOut.UseVisualStyleBackColor = False

        '
        'btnBatal
        '
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.Location = New System.Drawing.Point(16, 852)
        Me.btnBatal.Size = New System.Drawing.Size(282, 30)
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(220, 220, 220)
        Me.btnBatal.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.UseVisualStyleBackColor = False

        '
        'pnlRight
        '
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Location = New System.Drawing.Point(324, 56)
        Me.pnlRight.Size = New System.Drawing.Size(656, 660)
        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Anchor = System.Windows.Forms.AnchorStyles.Top Or
                                System.Windows.Forms.AnchorStyles.Bottom Or
                                System.Windows.Forms.AnchorStyles.Left Or
                                System.Windows.Forms.AnchorStyles.Right
        Me.pnlRight.Controls.Add(Me.lblGridTitle)
        Me.pnlRight.Controls.Add(Me.cboFilter)
        Me.pnlRight.Controls.Add(Me.txtCari)
        Me.pnlRight.Controls.Add(Me.btnCari)
        Me.pnlRight.Controls.Add(Me.btnRefresh)
        Me.pnlRight.Controls.Add(Me.dgvCheckOut)

        '
        'lblGridTitle
        '
        Me.lblGridTitle.Name = "lblGridTitle"
        Me.lblGridTitle.AutoSize = False
        Me.lblGridTitle.Size = New System.Drawing.Size(300, 24)
        Me.lblGridTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblGridTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.lblGridTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGridTitle.Text = "Daftar Tamu — Checked-In"

        '
        'cboFilter
        '
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Location = New System.Drawing.Point(12, 44)
        Me.cboFilter.Size = New System.Drawing.Size(140, 24)
        Me.cboFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilter.Items.AddRange(New Object() {"Checked-In", "Checked-Out", "Semua"})
        Me.cboFilter.SelectedIndex = 0

        '
        'txtCari
        '
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Location = New System.Drawing.Point(160, 43)
        Me.txtCari.Size = New System.Drawing.Size(180, 24)
        Me.txtCari.Font = New System.Drawing.Font("Segoe UI", 9.0!)

        '
        'btnCari
        '
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Text = "Cari"
        Me.btnCari.Location = New System.Drawing.Point(346, 42)
        Me.btnCari.Size = New System.Drawing.Size(60, 26)
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(153, 27, 27)
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
        Me.btnRefresh.Location = New System.Drawing.Point(412, 42)
        Me.btnRefresh.Size = New System.Drawing.Size(70, 26)
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.UseVisualStyleBackColor = False

        '
        'dgvCheckOut
        '
        Me.dgvCheckOut.Name = "dgvCheckOut"
        Me.dgvCheckOut.Location = New System.Drawing.Point(12, 80)
        Me.dgvCheckOut.Size = New System.Drawing.Size(630, 564)
        Me.dgvCheckOut.Anchor = System.Windows.Forms.AnchorStyles.Top Or
                                           System.Windows.Forms.AnchorStyles.Bottom Or
                                           System.Windows.Forms.AnchorStyles.Left Or
                                           System.Windows.Forms.AnchorStyles.Right
        Me.dgvCheckOut.BackgroundColor = System.Drawing.Color.White
        Me.dgvCheckOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvCheckOut.RowHeadersVisible = False
        Me.dgvCheckOut.AllowUserToAddRows = False
        Me.dgvCheckOut.AllowUserToDeleteRows = False
        Me.dgvCheckOut.ReadOnly = True
        Me.dgvCheckOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCheckOut.MultiSelect = False
        Me.dgvCheckOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCheckOut.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvCheckOut.ColumnHeadersHeight = 32
        Me.dgvCheckOut.EnableHeadersVisualStyles = False
        Me.dgvCheckOut.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.dgvCheckOut.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCheckOut.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvCheckOut.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 241, 242)
        Me.dgvCheckOut.TabIndex = 0

        '
        'CheckOutForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.ClientSize = New System.Drawing.Size(980, 716)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "CheckOutForm"
        Me.Text = "Check-Out"
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
        CType(Me.dgvCheckOut, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dtpTglAktual As System.Windows.Forms.DateTimePicker
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

End Class
