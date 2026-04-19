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

        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        CType(Me.dgvCheckin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '
        'pnlHeader
        '
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 56
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(6, 95, 70)
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
        Me.lblTitle.Text = "Check-In"

        '
        'lblSubTitle
        '
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.AutoSize = False
        Me.lblSubTitle.Size = New System.Drawing.Size(500, 18)
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(167, 243, 208)
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Text = "Proses check-in tamu berdasarkan reservasi"

        '
        'pnlLeft
        '
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Location = New System.Drawing.Point(0, 56)
        Me.pnlLeft.Size = New System.Drawing.Size(310, 660)
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

        '
        'lblFormTitle
        '
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.AutoSize = False
        Me.lblFormTitle.Size = New System.Drawing.Size(278, 24)
        Me.lblFormTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70)
        Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFormTitle.Text = "Form Check-In"

        '
        'lblInfoTitle
        '
        Me.lblInfoTitle.Name = "lblInfoTitle"
        Me.lblInfoTitle.AutoSize = False
        Me.lblInfoTitle.Size = New System.Drawing.Size(278, 18)
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
        Me.txtIdReservasi.Size = New System.Drawing.Size(272, 24)
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
        Me.txtNamaTamu.Size = New System.Drawing.Size(272, 24)
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
        Me.txtKamar.Size = New System.Drawing.Size(272, 24)
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
        Me.txtHarga.Size = New System.Drawing.Size(272, 24)
        Me.txtHarga.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtHarga.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtHarga.ReadOnly = True

        '
        'lblTipe
        '
        Me.lblTipe.Name = "lblTipe"
        Me.lblTipe.AutoSize = True
        Me.lblTipe.Location = New System.Drawing.Point(16, 276)
        Me.lblTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTipe.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblTipe.Text = "Tipe Reservasi"

        '
        'txtTipe
        '
        Me.txtTipe.Name = "txtTipe"
        Me.txtTipe.Location = New System.Drawing.Point(16, 294)
        Me.txtTipe.Size = New System.Drawing.Size(272, 24)
        Me.txtTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTipe.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtTipe.ReadOnly = True

        '
        'pnlDivider
        '
        Me.pnlDivider.Name = "pnlDivider"
        Me.pnlDivider.Location = New System.Drawing.Point(16, 330)
        Me.pnlDivider.Size = New System.Drawing.Size(272, 1)
        Me.pnlDivider.BackColor = System.Drawing.Color.FromArgb(210, 215, 225)

        '
        'lblCheckinTitle
        '
        Me.lblCheckinTitle.Name = "lblCheckinTitle"
        Me.lblCheckinTitle.AutoSize = False
        Me.lblCheckinTitle.Size = New System.Drawing.Size(278, 18)
        Me.lblCheckinTitle.Location = New System.Drawing.Point(16, 340)
        Me.lblCheckinTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblCheckinTitle.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70)
        Me.lblCheckinTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblCheckinTitle.Text = "PROSES CHECK-IN"

        '
        'lblTglCheckin
        '
        Me.lblTglCheckin.Name = "lblTglCheckin"
        Me.lblTglCheckin.AutoSize = True
        Me.lblTglCheckin.Location = New System.Drawing.Point(16, 366)
        Me.lblTglCheckin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTglCheckin.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblTglCheckin.Text = "Tanggal Check-In"

        '
        'dtpTglCheckin
        '
        Me.dtpTglCheckin.Name = "dtpTglCheckin"
        Me.dtpTglCheckin.Location = New System.Drawing.Point(16, 384)
        Me.dtpTglCheckin.Size = New System.Drawing.Size(272, 24)
        Me.dtpTglCheckin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTglCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpTglCheckin.Value = DateTime.Today

        '
        'lblTglCheckout
        '
        Me.lblTglCheckout.Name = "lblTglCheckout"
        Me.lblTglCheckout.AutoSize = True
        Me.lblTglCheckout.Location = New System.Drawing.Point(16, 418)
        Me.lblTglCheckout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTglCheckout.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblTglCheckout.Text = "Tanggal Check-Out (Rencana)"

        '
        'dtpTglCheckout
        '
        Me.dtpTglCheckout.Name = "dtpTglCheckout"
        Me.dtpTglCheckout.Location = New System.Drawing.Point(16, 436)
        Me.dtpTglCheckout.Size = New System.Drawing.Size(272, 24)
        Me.dtpTglCheckout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTglCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpTglCheckout.Value = DateTime.Today.AddDays(1)

        '
        'lblEstimasi
        '
        Me.lblEstimasi.Name = "lblEstimasi"
        Me.lblEstimasi.AutoSize = True
        Me.lblEstimasi.Location = New System.Drawing.Point(16, 470)
        Me.lblEstimasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblEstimasi.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblEstimasi.Text = "Estimasi Total Biaya"

        '
        'txtEstimasi
        '
        Me.txtEstimasi.Name = "txtEstimasi"
        Me.txtEstimasi.Location = New System.Drawing.Point(16, 488)
        Me.txtEstimasi.Size = New System.Drawing.Size(272, 24)
        Me.txtEstimasi.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.txtEstimasi.BackColor = System.Drawing.Color.FromArgb(209, 250, 229)
        Me.txtEstimasi.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70)
        Me.txtEstimasi.ReadOnly = True
        Me.txtEstimasi.Text = "Rp 0"

        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(16, 524)
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblStatus.Text = "Status"

        '
        'cboStatus
        '
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Location = New System.Drawing.Point(16, 542)
        Me.cboStatus.Size = New System.Drawing.Size(272, 24)
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Items.AddRange(New Object() {"Checked-In"})
        Me.cboStatus.SelectedIndex = 0

        '
        'btnCheckIn
        '
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Text = "Proses Check-In"
        Me.btnCheckIn.Location = New System.Drawing.Point(16, 584)
        Me.btnCheckIn.Size = New System.Drawing.Size(272, 36)
        Me.btnCheckIn.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(6, 95, 70)
        Me.btnCheckIn.ForeColor = System.Drawing.Color.White
        Me.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckIn.FlatAppearance.BorderSize = 0
        Me.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckIn.Enabled = False
        Me.btnCheckIn.UseVisualStyleBackColor = False

        '
        'btnBatal
        '
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.Location = New System.Drawing.Point(16, 628)
        Me.btnBatal.Size = New System.Drawing.Size(272, 30)
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
        Me.pnlRight.Location = New System.Drawing.Point(314, 56)
        Me.pnlRight.Size = New System.Drawing.Size(666, 660)
        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Anchor = System.Windows.Forms.AnchorStyles.Top Or
                                System.Windows.Forms.AnchorStyles.Bottom Or
                                System.Windows.Forms.AnchorStyles.Left Or
                                System.Windows.Forms.AnchorStyles.Right
        Me.pnlRight.Controls.Add(Me.lblGridTitle)
        Me.pnlRight.Controls.Add(Me.lblFilterTitle)
        Me.pnlRight.Controls.Add(Me.cboFilter)
        Me.pnlRight.Controls.Add(Me.txtCari)
        Me.pnlRight.Controls.Add(Me.btnCari)
        Me.pnlRight.Controls.Add(Me.btnRefresh)
        Me.pnlRight.Controls.Add(Me.dgvCheckin)

        '
        'lblGridTitle
        '
        Me.lblGridTitle.Name = "lblGridTitle"
        Me.lblGridTitle.AutoSize = False
        Me.lblGridTitle.Size = New System.Drawing.Size(300, 24)
        Me.lblGridTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblGridTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70)
        Me.lblGridTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGridTitle.Text = "Daftar Reservasi — Siap Check-In"

        '
        'lblFilterTitle
        '
        Me.lblFilterTitle.Name = "lblFilterTitle"
        Me.lblFilterTitle.AutoSize = True
        Me.lblFilterTitle.Location = New System.Drawing.Point(12, 46)
        Me.lblFilterTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblFilterTitle.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80)
        Me.lblFilterTitle.Text = "Filter:"

        '
        'cboFilter
        '
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Location = New System.Drawing.Point(54, 43)
        Me.cboFilter.Size = New System.Drawing.Size(140, 24)
        Me.cboFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilter.Items.AddRange(New Object() {"Semua", "Pending", "Confirmed", "Checked-In"})
        Me.cboFilter.SelectedIndex = 0

        '
        'txtCari
        '
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Location = New System.Drawing.Point(204, 43)
        Me.txtCari.Size = New System.Drawing.Size(180, 24)
        Me.txtCari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCari.Text = ""

        '
        'btnCari
        '
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Text = "Cari"
        Me.btnCari.Location = New System.Drawing.Point(390, 42)
        Me.btnCari.Size = New System.Drawing.Size(60, 26)
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(6, 95, 70)
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
        Me.btnRefresh.Location = New System.Drawing.Point(456, 42)
        Me.btnRefresh.Size = New System.Drawing.Size(70, 26)
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.UseVisualStyleBackColor = False

        '
        'dgvCheckin
        '
        Me.dgvCheckin.Name = "dgvCheckin"
        Me.dgvCheckin.Location = New System.Drawing.Point(12, 80)
        Me.dgvCheckin.Size = New System.Drawing.Size(640, 564)
        Me.dgvCheckin.Anchor = System.Windows.Forms.AnchorStyles.Top Or
                                          System.Windows.Forms.AnchorStyles.Bottom Or
                                          System.Windows.Forms.AnchorStyles.Left Or
                                          System.Windows.Forms.AnchorStyles.Right
        Me.dgvCheckin.BackgroundColor = System.Drawing.Color.White
        Me.dgvCheckin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvCheckin.RowHeadersVisible = False
        Me.dgvCheckin.AllowUserToAddRows = False
        Me.dgvCheckin.AllowUserToDeleteRows = False
        Me.dgvCheckin.ReadOnly = True
        Me.dgvCheckin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCheckin.MultiSelect = False
        Me.dgvCheckin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCheckin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvCheckin.ColumnHeadersHeight = 32
        Me.dgvCheckin.EnableHeadersVisualStyles = False
        Me.dgvCheckin.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(6, 95, 70)
        Me.dgvCheckin.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCheckin.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvCheckin.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(209, 250, 229)
        Me.dgvCheckin.TabIndex = 0

        '
        'CheckInForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.ClientSize = New System.Drawing.Size(980, 716)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "CheckInForm"
        Me.Text = "Check-In"
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
        CType(Me.dgvCheckin, System.ComponentModel.ISupportInitialize).EndInit()
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

End Class