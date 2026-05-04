<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KamarForm
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblIdKamar = New System.Windows.Forms.Label()
        Me.txtIdKamar = New System.Windows.Forms.TextBox()
        Me.lblIdTipe = New System.Windows.Forms.Label()
        Me.cboIdTipe = New System.Windows.Forms.ComboBox()
        Me.lblNomorKamar = New System.Windows.Forms.Label()
        Me.txtNomorKamar = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.pnlDivider = New System.Windows.Forms.Panel()
        Me.lblKondisiTitle = New System.Windows.Forms.Label()
        Me.lblKondisiNote = New System.Windows.Forms.Label()
        Me.btnKondisi = New System.Windows.Forms.Button()
        Me.pnlDivider2 = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.lblGridTitle = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvKamar = New System.Windows.Forms.DataGridView()

        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        CType(Me.dgvKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' pnlHeader
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 56
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(22, 101, 52)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubTitle)

        Me.lblTitle.Name = "lblTitle" : Me.lblTitle.AutoSize = False
        Me.lblTitle.Size = New System.Drawing.Size(500, 28)
        Me.lblTitle.Location = New System.Drawing.Point(16, 8)
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Text = "Data Kamar"

        Me.lblSubTitle.Name = "lblSubTitle" : Me.lblSubTitle.AutoSize = False
        Me.lblSubTitle.Size = New System.Drawing.Size(500, 18)
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(187, 247, 208)
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Text = "Kelola data kamar, tipe, dan kondisi properti per kamar"

        ' pnlLeft
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Location = New System.Drawing.Point(0, 56)
        Me.pnlLeft.Size = New System.Drawing.Size(300, 580)
        Me.pnlLeft.BackColor = System.Drawing.Color.White
        Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLeft.Controls.Add(Me.lblFormTitle)
        Me.pnlLeft.Controls.Add(Me.lblIdKamar)
        Me.pnlLeft.Controls.Add(Me.txtIdKamar)
        Me.pnlLeft.Controls.Add(Me.lblIdTipe)
        Me.pnlLeft.Controls.Add(Me.cboIdTipe)
        Me.pnlLeft.Controls.Add(Me.lblNomorKamar)
        Me.pnlLeft.Controls.Add(Me.txtNomorKamar)
        Me.pnlLeft.Controls.Add(Me.lblStatus)
        Me.pnlLeft.Controls.Add(Me.cboStatus)
        Me.pnlLeft.Controls.Add(Me.pnlDivider)
        Me.pnlLeft.Controls.Add(Me.lblKondisiTitle)
        Me.pnlLeft.Controls.Add(Me.lblKondisiNote)
        Me.pnlLeft.Controls.Add(Me.btnKondisi)
        Me.pnlLeft.Controls.Add(Me.pnlDivider2)
        Me.pnlLeft.Controls.Add(Me.btnSimpan)
        Me.pnlLeft.Controls.Add(Me.btnBatal)
        Me.pnlLeft.Controls.Add(Me.btnHapus)

        Me.lblFormTitle.Name = "lblFormTitle" : Me.lblFormTitle.AutoSize = False
        Me.lblFormTitle.Size = New System.Drawing.Size(268, 24)
        Me.lblFormTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
        Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFormTitle.Text = "Form Kamar"

        Me.lblIdKamar.Name = "lblIdKamar" : Me.lblIdKamar.AutoSize = True
        Me.lblIdKamar.Location = New System.Drawing.Point(16, 52)
        Me.lblIdKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdKamar.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblIdKamar.Text = "ID Kamar"

        Me.txtIdKamar.Name = "txtIdKamar"
        Me.txtIdKamar.Location = New System.Drawing.Point(16, 70)
        Me.txtIdKamar.Size = New System.Drawing.Size(262, 24)
        Me.txtIdKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtIdKamar.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtIdKamar.ReadOnly = True : Me.txtIdKamar.Text = "(auto)"

        Me.lblIdTipe.Name = "lblIdTipe" : Me.lblIdTipe.AutoSize = True
        Me.lblIdTipe.Location = New System.Drawing.Point(16, 106)
        Me.lblIdTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdTipe.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblIdTipe.Text = "Tipe Kamar"

        Me.cboIdTipe.Name = "cboIdTipe"
        Me.cboIdTipe.Location = New System.Drawing.Point(16, 124)
        Me.cboIdTipe.Size = New System.Drawing.Size(262, 24)
        Me.cboIdTipe.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboIdTipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList

        Me.lblNomorKamar.Name = "lblNomorKamar" : Me.lblNomorKamar.AutoSize = True
        Me.lblNomorKamar.Location = New System.Drawing.Point(16, 162)
        Me.lblNomorKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNomorKamar.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblNomorKamar.Text = "Nomor Kamar"

        Me.txtNomorKamar.Name = "txtNomorKamar"
        Me.txtNomorKamar.Location = New System.Drawing.Point(16, 180)
        Me.txtNomorKamar.Size = New System.Drawing.Size(262, 24)
        Me.txtNomorKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)

        Me.lblStatus.Name = "lblStatus" : Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(16, 216)
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblStatus.Text = "Status"

        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Location = New System.Drawing.Point(16, 234)
        Me.cboStatus.Size = New System.Drawing.Size(262, 24)
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Items.AddRange(New Object() {"Tersedia", "Terisi", "Maintenance"})

        ' Divider sebelum section kondisi
        Me.pnlDivider.Name = "pnlDivider"
        Me.pnlDivider.Location = New System.Drawing.Point(16, 274)
        Me.pnlDivider.Size = New System.Drawing.Size(262, 1)
        Me.pnlDivider.BackColor = System.Drawing.Color.FromArgb(210, 215, 225)

        Me.lblKondisiTitle.Name = "lblKondisiTitle" : Me.lblKondisiTitle.AutoSize = False
        Me.lblKondisiTitle.Size = New System.Drawing.Size(262, 18)
        Me.lblKondisiTitle.Location = New System.Drawing.Point(16, 284)
        Me.lblKondisiTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblKondisiTitle.ForeColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.lblKondisiTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblKondisiTitle.Text = "KONDISI PROPERTI KAMAR"

        Me.lblKondisiNote.Name = "lblKondisiNote" : Me.lblKondisiNote.AutoSize = False
        Me.lblKondisiNote.Size = New System.Drawing.Size(262, 28)
        Me.lblKondisiNote.Location = New System.Drawing.Point(16, 306)
        Me.lblKondisiNote.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblKondisiNote.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120)
        Me.lblKondisiNote.BackColor = System.Drawing.Color.Transparent
        Me.lblKondisiNote.Text = "Pilih kamar dari tabel → klik tombol untuk kelola kondisi properti"

        Me.btnKondisi.Name = "btnKondisi"
        Me.btnKondisi.Text = "Kelola Kondisi Properti"
        Me.btnKondisi.Location = New System.Drawing.Point(16, 340)
        Me.btnKondisi.Size = New System.Drawing.Size(262, 32)
        Me.btnKondisi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnKondisi.BackColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.btnKondisi.ForeColor = System.Drawing.Color.White
        Me.btnKondisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKondisi.FlatAppearance.BorderSize = 0
        Me.btnKondisi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKondisi.Enabled = False
        Me.btnKondisi.UseVisualStyleBackColor = False

        ' Divider sebelum CRUD
        Me.pnlDivider2.Name = "pnlDivider2"
        Me.pnlDivider2.Location = New System.Drawing.Point(16, 386)
        Me.pnlDivider2.Size = New System.Drawing.Size(262, 1)
        Me.pnlDivider2.BackColor = System.Drawing.Color.FromArgb(210, 215, 225)

        Me.btnSimpan.Name = "btnSimpan" : Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.Location = New System.Drawing.Point(16, 398)
        Me.btnSimpan.Size = New System.Drawing.Size(120, 32)
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(22, 101, 52)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.UseVisualStyleBackColor = False

        Me.btnBatal.Name = "btnBatal" : Me.btnBatal.Text = "Batal"
        Me.btnBatal.Location = New System.Drawing.Point(144, 398)
        Me.btnBatal.Size = New System.Drawing.Size(134, 32)
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(220, 220, 220)
        Me.btnBatal.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.UseVisualStyleBackColor = False

        Me.btnHapus.Name = "btnHapus" : Me.btnHapus.Text = "Hapus Data"
        Me.btnHapus.Location = New System.Drawing.Point(16, 438)
        Me.btnHapus.Size = New System.Drawing.Size(262, 32)
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHapus.Enabled = False
        Me.btnHapus.UseVisualStyleBackColor = False

        ' pnlRight
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Location = New System.Drawing.Point(304, 56)
        Me.pnlRight.Size = New System.Drawing.Size(676, 580)
        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Anchor = System.Windows.Forms.AnchorStyles.Top Or
                             System.Windows.Forms.AnchorStyles.Bottom Or
                             System.Windows.Forms.AnchorStyles.Left Or
                             System.Windows.Forms.AnchorStyles.Right
        Me.pnlRight.Controls.Add(Me.lblGridTitle)
        Me.pnlRight.Controls.Add(Me.txtCari)
        Me.pnlRight.Controls.Add(Me.btnCari)
        Me.pnlRight.Controls.Add(Me.btnRefresh)
        Me.pnlRight.Controls.Add(Me.dgvKamar)

        Me.lblGridTitle.Name = "lblGridTitle" : Me.lblGridTitle.AutoSize = False
        Me.lblGridTitle.Size = New System.Drawing.Size(300, 24)
        Me.lblGridTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblGridTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
        Me.lblGridTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGridTitle.Text = "Daftar Kamar"

        Me.txtCari.Name = "txtCari"
        Me.txtCari.Location = New System.Drawing.Point(12, 44)
        Me.txtCari.Size = New System.Drawing.Size(220, 24)
        Me.txtCari.Font = New System.Drawing.Font("Segoe UI", 9.0!)

        Me.btnCari.Name = "btnCari" : Me.btnCari.Text = "Cari"
        Me.btnCari.Location = New System.Drawing.Point(238, 43)
        Me.btnCari.Size = New System.Drawing.Size(70, 26)
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(22, 101, 52)
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.FlatAppearance.BorderSize = 0
        Me.btnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCari.UseVisualStyleBackColor = False

        Me.btnRefresh.Name = "btnRefresh" : Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.Location = New System.Drawing.Point(314, 43)
        Me.btnRefresh.Size = New System.Drawing.Size(70, 26)
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.UseVisualStyleBackColor = False

        Me.dgvKamar.Name = "dgvKamar"
        Me.dgvKamar.Location = New System.Drawing.Point(12, 80)
        Me.dgvKamar.Size = New System.Drawing.Size(650, 484)
        Me.dgvKamar.Anchor = System.Windows.Forms.AnchorStyles.Top Or
                             System.Windows.Forms.AnchorStyles.Bottom Or
                             System.Windows.Forms.AnchorStyles.Left Or
                             System.Windows.Forms.AnchorStyles.Right
        Me.dgvKamar.BackgroundColor = System.Drawing.Color.White
        Me.dgvKamar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvKamar.RowHeadersVisible = False
        Me.dgvKamar.AllowUserToAddRows = False
        Me.dgvKamar.AllowUserToDeleteRows = False
        Me.dgvKamar.ReadOnly = True
        Me.dgvKamar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKamar.MultiSelect = False
        Me.dgvKamar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvKamar.ColumnHeadersHeight = 32
        Me.dgvKamar.EnableHeadersVisualStyles = False
        Me.dgvKamar.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 101, 52)
        Me.dgvKamar.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvKamar.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvKamar.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 248, 243)
        Me.dgvKamar.TabIndex = 0

        ' DataKamarForm
        Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.ClientSize = New System.Drawing.Size(980, 636)
        Me.MinimumSize = New System.Drawing.Size(900, 550)
        Me.Name = "DataKamarForm"
        Me.Text = "Data Kamar"
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
        CType(Me.dgvKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents lblIdKamar As System.Windows.Forms.Label
    Friend WithEvents txtIdKamar As System.Windows.Forms.TextBox
    Friend WithEvents lblIdTipe As System.Windows.Forms.Label
    Friend WithEvents cboIdTipe As System.Windows.Forms.ComboBox
    Friend WithEvents lblNomorKamar As System.Windows.Forms.Label
    Friend WithEvents txtNomorKamar As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents pnlDivider As System.Windows.Forms.Panel
    Friend WithEvents lblKondisiTitle As System.Windows.Forms.Label
    Friend WithEvents lblKondisiNote As System.Windows.Forms.Label
    Friend WithEvents btnKondisi As System.Windows.Forms.Button
    Friend WithEvents pnlDivider2 As System.Windows.Forms.Panel
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents pnlRight As System.Windows.Forms.Panel
    Friend WithEvents lblGridTitle As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvKamar As System.Windows.Forms.DataGridView
End Class