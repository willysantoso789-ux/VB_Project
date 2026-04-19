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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblIdReservasi = New System.Windows.Forms.Label()
        Me.txtIdReservasi = New System.Windows.Forms.TextBox()
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
        Me.lblTipe = New System.Windows.Forms.Label()
        Me.cboTipe = New System.Windows.Forms.ComboBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.lblGridTitle = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvReservasi = New System.Windows.Forms.DataGridView()

        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        CType(Me.dgvReservasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '
        'pnlHeader
        '
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 56
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(146, 64, 14)
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
        Me.lblTitle.Text = "Reservasi"

        '
        'lblSubTitle
        '
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.AutoSize = False
        Me.lblSubTitle.Size = New System.Drawing.Size(500, 18)
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(254, 215, 170)
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Text = "Kelola reservasi tamu hotel"

        '
        'pnlLeft
        '
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Location = New System.Drawing.Point(0, 56)
        Me.pnlLeft.Size = New System.Drawing.Size(310, 700)
        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLeft.AutoScroll = True
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

        '
        'lblFormTitle
        '
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.AutoSize = False
        Me.lblFormTitle.Size = New System.Drawing.Size(278, 24)
        Me.lblFormTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14)
        Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFormTitle.Text = "Form Reservasi"

        '
        'lblIdReservasi
        '
        Me.lblIdReservasi.Name = "lblIdReservasi"
        Me.lblIdReservasi.AutoSize = True
        Me.lblIdReservasi.Location = New System.Drawing.Point(16, 50)
        Me.lblIdReservasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdReservasi.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblIdReservasi.Text = "ID Reservasi"

        '
        'txtIdReservasi
        '
        Me.txtIdReservasi.Name = "txtIdReservasi"
        Me.txtIdReservasi.Location = New System.Drawing.Point(16, 68)
        Me.txtIdReservasi.Size = New System.Drawing.Size(272, 24)
        Me.txtIdReservasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtIdReservasi.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtIdReservasi.ReadOnly = True
        Me.txtIdReservasi.Text = "(auto)"

        '
        'lblTipe
        '
        Me.lblTipe.Name = "lblTipe"
        Me.lblTipe.AutoSize = True
        Me.lblTipe.Location = New System.Drawing.Point(16, 104)
        Me.lblTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTipe.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblTipe.Text = "Tipe Reservasi"

        '
        'cboTipe
        '
        Me.cboTipe.Name = "cboTipe"
        Me.cboTipe.Location = New System.Drawing.Point(16, 122)
        Me.cboTipe.Size = New System.Drawing.Size(272, 24)
        Me.cboTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboTipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipe.Items.AddRange(New Object() {"Walk-in (Langsung)", "Online / Contact"})

        '
        'lblTamu
        '
        Me.lblTamu.Name = "lblTamu"
        Me.lblTamu.AutoSize = True
        Me.lblTamu.Location = New System.Drawing.Point(16, 158)
        Me.lblTamu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTamu.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblTamu.Text = "Nama Tamu"

        '
        'cboTamu
        '
        Me.cboTamu.Name = "cboTamu"
        Me.cboTamu.Location = New System.Drawing.Point(16, 176)
        Me.cboTamu.Size = New System.Drawing.Size(272, 24)
        Me.cboTamu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboTamu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList

        '
        'lblKamar
        '
        Me.lblKamar.Name = "lblKamar"
        Me.lblKamar.AutoSize = True
        Me.lblKamar.Location = New System.Drawing.Point(16, 212)
        Me.lblKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKamar.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblKamar.Text = "Kamar"

        '
        'cboKamar
        '
        Me.cboKamar.Name = "cboKamar"
        Me.cboKamar.Location = New System.Drawing.Point(16, 230)
        Me.cboKamar.Size = New System.Drawing.Size(272, 24)
        Me.cboKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboKamar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList

        '
        'lblHargaKamar
        '
        Me.lblHargaKamar.Name = "lblHargaKamar"
        Me.lblHargaKamar.AutoSize = True
        Me.lblHargaKamar.Location = New System.Drawing.Point(16, 266)
        Me.lblHargaKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHargaKamar.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblHargaKamar.Text = "Harga Kamar / Malam"

        '
        'txtHargaKamar
        '
        Me.txtHargaKamar.Name = "txtHargaKamar"
        Me.txtHargaKamar.Location = New System.Drawing.Point(16, 284)
        Me.txtHargaKamar.Size = New System.Drawing.Size(272, 24)
        Me.txtHargaKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtHargaKamar.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtHargaKamar.ReadOnly = True
        Me.txtHargaKamar.Text = "Rp 0"

        '
        'lblTglReservasi
        '
        Me.lblTglReservasi.Name = "lblTglReservasi"
        Me.lblTglReservasi.AutoSize = True
        Me.lblTglReservasi.Location = New System.Drawing.Point(16, 320)
        Me.lblTglReservasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTglReservasi.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblTglReservasi.Text = "Tanggal Reservasi"

        '
        'dtpTglReservasi
        '
        Me.dtpTglReservasi.Name = "dtpTglReservasi"
        Me.dtpTglReservasi.Location = New System.Drawing.Point(16, 338)
        Me.dtpTglReservasi.Size = New System.Drawing.Size(272, 24)
        Me.dtpTglReservasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTglReservasi.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpTglReservasi.Value = DateTime.Today

        '
        'lblTglCheckin
        '
        Me.lblTglCheckin.Name = "lblTglCheckin"
        Me.lblTglCheckin.AutoSize = True
        Me.lblTglCheckin.Location = New System.Drawing.Point(16, 374)
        Me.lblTglCheckin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTglCheckin.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblTglCheckin.Text = "Tanggal Check-In"

        '
        'dtpTglCheckin
        '
        Me.dtpTglCheckin.Name = "dtpTglCheckin"
        Me.dtpTglCheckin.Location = New System.Drawing.Point(16, 392)
        Me.dtpTglCheckin.Size = New System.Drawing.Size(272, 24)
        Me.dtpTglCheckin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTglCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpTglCheckin.Value = DateTime.Today

        '
        'lblTglCheckout
        '
        Me.lblTglCheckout.Name = "lblTglCheckout"
        Me.lblTglCheckout.AutoSize = True
        Me.lblTglCheckout.Location = New System.Drawing.Point(16, 428)
        Me.lblTglCheckout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTglCheckout.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblTglCheckout.Text = "Tanggal Check-Out"

        '
        'dtpTglCheckout
        '
        Me.dtpTglCheckout.Name = "dtpTglCheckout"
        Me.dtpTglCheckout.Location = New System.Drawing.Point(16, 446)
        Me.dtpTglCheckout.Size = New System.Drawing.Size(272, 24)
        Me.dtpTglCheckout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTglCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpTglCheckout.Value = DateTime.Today.AddDays(1)

        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(16, 482)
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblStatus.Text = "Status"

        '
        'cboStatus
        '
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Location = New System.Drawing.Point(16, 500)
        Me.cboStatus.Size = New System.Drawing.Size(272, 24)
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Items.AddRange(New Object() {"Pending", "Confirmed", "Checked-In", "Checked-Out", "Cancelled"})

        '
        'btnSimpan
        '
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.Location = New System.Drawing.Point(16, 544)
        Me.btnSimpan.Size = New System.Drawing.Size(128, 32)
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(146, 64, 14)
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
        Me.btnBatal.Location = New System.Drawing.Point(152, 544)
        Me.btnBatal.Size = New System.Drawing.Size(136, 32)
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
        Me.btnHapus.Text = "Hapus Reservasi"
        Me.btnHapus.Location = New System.Drawing.Point(16, 586)
        Me.btnHapus.Size = New System.Drawing.Size(272, 32)
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
        Me.pnlRight.Location = New System.Drawing.Point(314, 56)
        Me.pnlRight.Size = New System.Drawing.Size(666, 700)
        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Anchor = System.Windows.Forms.AnchorStyles.Top Or
                                System.Windows.Forms.AnchorStyles.Bottom Or
                                System.Windows.Forms.AnchorStyles.Left Or
                                System.Windows.Forms.AnchorStyles.Right
        Me.pnlRight.Controls.Add(Me.lblGridTitle)
        Me.pnlRight.Controls.Add(Me.txtCari)
        Me.pnlRight.Controls.Add(Me.btnCari)
        Me.pnlRight.Controls.Add(Me.btnRefresh)
        Me.pnlRight.Controls.Add(Me.dgvReservasi)

        '
        'lblGridTitle
        '
        Me.lblGridTitle.Name = "lblGridTitle"
        Me.lblGridTitle.AutoSize = False
        Me.lblGridTitle.Size = New System.Drawing.Size(300, 24)
        Me.lblGridTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblGridTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14)
        Me.lblGridTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGridTitle.Text = "Daftar Reservasi"

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
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(146, 64, 14)
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
        'dgvReservasi
        '
        Me.dgvReservasi.Name = "dgvReservasi"
        Me.dgvReservasi.Location = New System.Drawing.Point(12, 80)
        Me.dgvReservasi.Size = New System.Drawing.Size(640, 604)
        Me.dgvReservasi.Anchor = System.Windows.Forms.AnchorStyles.Top Or
                                            System.Windows.Forms.AnchorStyles.Bottom Or
                                            System.Windows.Forms.AnchorStyles.Left Or
                                            System.Windows.Forms.AnchorStyles.Right
        Me.dgvReservasi.BackgroundColor = System.Drawing.Color.White
        Me.dgvReservasi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvReservasi.RowHeadersVisible = False
        Me.dgvReservasi.AllowUserToAddRows = False
        Me.dgvReservasi.AllowUserToDeleteRows = False
        Me.dgvReservasi.ReadOnly = True
        Me.dgvReservasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservasi.MultiSelect = False
        Me.dgvReservasi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReservasi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvReservasi.ColumnHeadersHeight = 32
        Me.dgvReservasi.EnableHeadersVisualStyles = False
        Me.dgvReservasi.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(146, 64, 14)
        Me.dgvReservasi.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvReservasi.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvReservasi.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 247, 237)
        Me.dgvReservasi.TabIndex = 0

        '
        'ReservasiForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.ClientSize = New System.Drawing.Size(980, 756)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "ReservasiForm"
        Me.Text = "Reservasi"
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
        CType(Me.dgvReservasi, System.ComponentModel.ISupportInitialize).EndInit()
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

End Class