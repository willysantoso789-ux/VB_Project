<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataTipeKamar
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

        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        CType(Me.dgvTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '
        'pnlHeader
        '
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 56
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(22, 101, 52)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubTitle)

        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.AutoSize = False
        Me.lblTitle.Size = New System.Drawing.Size(500, 28)
        Me.lblTitle.Location = New System.Drawing.Point(16, 8)
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Text = "Tipe Kamar"

        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.AutoSize = False
        Me.lblSubTitle.Size = New System.Drawing.Size(500, 18)
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(187, 247, 208)
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Text = "Kelola tipe kamar dan harga per malam"

        '
        'pnlLeft
        '
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Location = New System.Drawing.Point(0, 56)
        Me.pnlLeft.Size = New System.Drawing.Size(300, 520)
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

        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.AutoSize = False
        Me.lblFormTitle.Size = New System.Drawing.Size(268, 24)
        Me.lblFormTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
        Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFormTitle.Text = "Form Tipe Kamar"

        Me.lblIdTipe.Name = "lblIdTipe"
        Me.lblIdTipe.AutoSize = True
        Me.lblIdTipe.Location = New System.Drawing.Point(16, 50)
        Me.lblIdTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdTipe.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblIdTipe.Text = "ID Tipe"

        Me.txtIdTipe.Name = "txtIdTipe"
        Me.txtIdTipe.Location = New System.Drawing.Point(16, 68)
        Me.txtIdTipe.Size = New System.Drawing.Size(262, 24)
        Me.txtIdTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtIdTipe.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtIdTipe.ReadOnly = True
        Me.txtIdTipe.Text = "(auto)"

        Me.lblNamaTipe.Name = "lblNamaTipe"
        Me.lblNamaTipe.AutoSize = True
        Me.lblNamaTipe.Location = New System.Drawing.Point(16, 104)
        Me.lblNamaTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNamaTipe.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblNamaTipe.Text = "Nama Tipe"

        Me.txtNamaTipe.Name = "txtNamaTipe"
        Me.txtNamaTipe.Location = New System.Drawing.Point(16, 122)
        Me.txtNamaTipe.Size = New System.Drawing.Size(262, 24)
        Me.txtNamaTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)

        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Location = New System.Drawing.Point(16, 158)
        Me.lblHarga.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHarga.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblHarga.Text = "Harga Per Malam (Rp)"

        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Location = New System.Drawing.Point(16, 176)
        Me.txtHarga.Size = New System.Drawing.Size(262, 24)
        Me.txtHarga.Font = New System.Drawing.Font("Segoe UI", 9.0!)

        Me.lblDeskripsi.Name = "lblDeskripsi"
        Me.lblDeskripsi.AutoSize = True
        Me.lblDeskripsi.Location = New System.Drawing.Point(16, 212)
        Me.lblDeskripsi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDeskripsi.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblDeskripsi.Text = "Deskripsi"

        Me.txtDeskripsi.Name = "txtDeskripsi"
        Me.txtDeskripsi.Location = New System.Drawing.Point(16, 230)
        Me.txtDeskripsi.Size = New System.Drawing.Size(262, 80)
        Me.txtDeskripsi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDeskripsi.Multiline = True
        Me.txtDeskripsi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical

        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.Location = New System.Drawing.Point(16, 328)
        Me.btnSimpan.Size = New System.Drawing.Size(120, 32)
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(22, 101, 52)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.UseVisualStyleBackColor = False

        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.Location = New System.Drawing.Point(144, 328)
        Me.btnBatal.Size = New System.Drawing.Size(134, 32)
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(220, 220, 220)
        Me.btnBatal.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.UseVisualStyleBackColor = False

        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Text = "Hapus Data"
        Me.btnHapus.Location = New System.Drawing.Point(16, 370)
        Me.btnHapus.Size = New System.Drawing.Size(262, 32)
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
        Me.pnlRight.Location = New System.Drawing.Point(304, 56)
        Me.pnlRight.Size = New System.Drawing.Size(676, 520)
        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Anchor = System.Windows.Forms.AnchorStyles.Top Or
                                System.Windows.Forms.AnchorStyles.Bottom Or
                                System.Windows.Forms.AnchorStyles.Left Or
                                System.Windows.Forms.AnchorStyles.Right
        Me.pnlRight.Controls.Add(Me.lblGridTitle)
        Me.pnlRight.Controls.Add(Me.txtCari)
        Me.pnlRight.Controls.Add(Me.btnCari)
        Me.pnlRight.Controls.Add(Me.btnRefresh)
        Me.pnlRight.Controls.Add(Me.dgvTipe)

        Me.lblGridTitle.Name = "lblGridTitle"
        Me.lblGridTitle.AutoSize = False
        Me.lblGridTitle.Size = New System.Drawing.Size(300, 24)
        Me.lblGridTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblGridTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
        Me.lblGridTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGridTitle.Text = "Daftar Tipe Kamar"

        Me.txtCari.Name = "txtCari"
        Me.txtCari.Location = New System.Drawing.Point(12, 44)
        Me.txtCari.Size = New System.Drawing.Size(220, 24)
        Me.txtCari.Font = New System.Drawing.Font("Segoe UI", 9.0!)

        Me.btnCari.Name = "btnCari"
        Me.btnCari.Text = "Cari"
        Me.btnCari.Location = New System.Drawing.Point(238, 43)
        Me.btnCari.Size = New System.Drawing.Size(70, 26)
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(22, 101, 52)
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.FlatAppearance.BorderSize = 0
        Me.btnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.UseVisualStyleBackColor = False

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

        Me.dgvTipe.Name = "dgvTipe"
        Me.dgvTipe.Location = New System.Drawing.Point(12, 80)
        Me.dgvTipe.Size = New System.Drawing.Size(650, 424)
        Me.dgvTipe.Anchor = System.Windows.Forms.AnchorStyles.Top Or
                                       System.Windows.Forms.AnchorStyles.Bottom Or
                                       System.Windows.Forms.AnchorStyles.Left Or
                                       System.Windows.Forms.AnchorStyles.Right
        Me.dgvTipe.BackgroundColor = System.Drawing.Color.White
        Me.dgvTipe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvTipe.RowHeadersVisible = False
        Me.dgvTipe.AllowUserToAddRows = False
        Me.dgvTipe.AllowUserToDeleteRows = False
        Me.dgvTipe.ReadOnly = True
        Me.dgvTipe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTipe.MultiSelect = False
        Me.dgvTipe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvTipe.ColumnHeadersHeight = 32
        Me.dgvTipe.EnableHeadersVisualStyles = False
        Me.dgvTipe.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 101, 52)
        Me.dgvTipe.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvTipe.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvTipe.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 248, 243)
        Me.dgvTipe.TabIndex = 0

        '
        'TipeKamarForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.ClientSize = New System.Drawing.Size(980, 576)
        Me.MinimumSize = New System.Drawing.Size(900, 550)
        Me.Name = "TipeKamarForm"
        Me.Text = "Tipe Kamar"
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
        CType(Me.dgvTipe, System.ComponentModel.ISupportInitialize).EndInit()
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

End Class