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
        Me.btnUnassign = New System.Windows.Forms.Button()
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

        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        CType(Me.dgvProperti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' pnlHeader
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 56
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubTitle)

        Me.lblTitle.Name = "lblTitle" : Me.lblTitle.AutoSize = False
        Me.lblTitle.Size = New System.Drawing.Size(500, 28)
        Me.lblTitle.Location = New System.Drawing.Point(16, 8)
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Text = "Master Properti"

        Me.lblSubTitle.Name = "lblSubTitle" : Me.lblSubTitle.AutoSize = False
        Me.lblSubTitle.Size = New System.Drawing.Size(500, 18)
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(221, 214, 254)
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Text = "Kelola master properti, assign dan unassign ke kamar"

        ' pnlLeft
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Location = New System.Drawing.Point(0, 56)
        Me.pnlLeft.Size = New System.Drawing.Size(300, 580)
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
        Me.pnlLeft.Controls.Add(Me.btnUnassign)
        Me.pnlLeft.Controls.Add(Me.pnlDiv2)
        Me.pnlLeft.Controls.Add(Me.btnSimpan)
        Me.pnlLeft.Controls.Add(Me.btnBatal)
        Me.pnlLeft.Controls.Add(Me.btnHapus)

        Me.lblFormTitle.Name = "lblFormTitle" : Me.lblFormTitle.AutoSize = False
        Me.lblFormTitle.Size = New System.Drawing.Size(268, 24)
        Me.lblFormTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFormTitle.Text = "Form Master Properti"

        Me.lblIdProperti.Name = "lblIdProperti" : Me.lblIdProperti.AutoSize = True
        Me.lblIdProperti.Location = New System.Drawing.Point(16, 52)
        Me.lblIdProperti.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdProperti.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblIdProperti.Text = "ID Properti"

        Me.txtIdProperti.Name = "txtIdProperti"
        Me.txtIdProperti.Location = New System.Drawing.Point(16, 70)
        Me.txtIdProperti.Size = New System.Drawing.Size(262, 24)
        Me.txtIdProperti.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtIdProperti.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtIdProperti.ReadOnly = True : Me.txtIdProperti.Text = "(auto)"

        Me.lblNama.Name = "lblNama" : Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(16, 106)
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNama.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblNama.Text = "Nama Properti"

        Me.txtNama.Name = "txtNama"
        Me.txtNama.Location = New System.Drawing.Point(16, 124)
        Me.txtNama.Size = New System.Drawing.Size(262, 24)
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 9.0!)

        Me.lblBiaya.Name = "lblBiaya" : Me.lblBiaya.AutoSize = True
        Me.lblBiaya.Location = New System.Drawing.Point(16, 160)
        Me.lblBiaya.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBiaya.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblBiaya.Text = "Biaya Denda (Rp)"

        Me.txtBiaya.Name = "txtBiaya"
        Me.txtBiaya.Location = New System.Drawing.Point(16, 178)
        Me.txtBiaya.Size = New System.Drawing.Size(262, 24)
        Me.txtBiaya.Font = New System.Drawing.Font("Segoe UI", 9.0!)

        ' Divider 1
        Me.pnlDiv1.Name = "pnlDiv1"
        Me.pnlDiv1.Location = New System.Drawing.Point(16, 218)
        Me.pnlDiv1.Size = New System.Drawing.Size(262, 1)
        Me.pnlDiv1.BackColor = System.Drawing.Color.FromArgb(210, 215, 225)

        Me.lblAssignTitle.Name = "lblAssignTitle" : Me.lblAssignTitle.AutoSize = False
        Me.lblAssignTitle.Size = New System.Drawing.Size(262, 18)
        Me.lblAssignTitle.Location = New System.Drawing.Point(16, 228)
        Me.lblAssignTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblAssignTitle.ForeColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.lblAssignTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblAssignTitle.Text = "MANAJEMEN KAMAR"

        Me.lblAssignNote.Name = "lblAssignNote" : Me.lblAssignNote.AutoSize = False
        Me.lblAssignNote.Size = New System.Drawing.Size(262, 28)
        Me.lblAssignNote.Location = New System.Drawing.Point(16, 250)
        Me.lblAssignNote.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblAssignNote.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120)
        Me.lblAssignNote.BackColor = System.Drawing.Color.Transparent
        Me.lblAssignNote.Text = "Pilih properti dari tabel terlebih dahulu"

        Me.btnAssign.Name = "btnAssign" : Me.btnAssign.Text = "Assign ke Kamar"
        Me.btnAssign.Location = New System.Drawing.Point(16, 286)
        Me.btnAssign.Size = New System.Drawing.Size(262, 32)
        Me.btnAssign.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAssign.BackColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.btnAssign.ForeColor = System.Drawing.Color.White
        Me.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAssign.FlatAppearance.BorderSize = 0
        Me.btnAssign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAssign.Enabled = False
        Me.btnAssign.UseVisualStyleBackColor = False

        Me.btnUnassign.Name = "btnUnassign" : Me.btnUnassign.Text = "Unassign dari Kamar"
        Me.btnUnassign.Location = New System.Drawing.Point(16, 326)
        Me.btnUnassign.Size = New System.Drawing.Size(262, 32)
        Me.btnUnassign.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUnassign.BackColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.btnUnassign.ForeColor = System.Drawing.Color.White
        Me.btnUnassign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnassign.FlatAppearance.BorderSize = 0
        Me.btnUnassign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnassign.Enabled = False
        Me.btnUnassign.UseVisualStyleBackColor = False

        ' Divider 2
        Me.pnlDiv2.Name = "pnlDiv2"
        Me.pnlDiv2.Location = New System.Drawing.Point(16, 372)
        Me.pnlDiv2.Size = New System.Drawing.Size(262, 1)
        Me.pnlDiv2.BackColor = System.Drawing.Color.FromArgb(210, 215, 225)

        Me.btnSimpan.Name = "btnSimpan" : Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.Location = New System.Drawing.Point(16, 384)
        Me.btnSimpan.Size = New System.Drawing.Size(120, 32)
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.UseVisualStyleBackColor = False

        Me.btnBatal.Name = "btnBatal" : Me.btnBatal.Text = "Batal"
        Me.btnBatal.Location = New System.Drawing.Point(144, 384)
        Me.btnBatal.Size = New System.Drawing.Size(134, 32)
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(220, 220, 220)
        Me.btnBatal.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.UseVisualStyleBackColor = False

        Me.btnHapus.Name = "btnHapus" : Me.btnHapus.Text = "Hapus Properti"
        Me.btnHapus.Location = New System.Drawing.Point(16, 424)
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
        Me.pnlRight.Controls.Add(Me.dgvProperti)

        Me.lblGridTitle.Name = "lblGridTitle" : Me.lblGridTitle.AutoSize = False
        Me.lblGridTitle.Size = New System.Drawing.Size(300, 24)
        Me.lblGridTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblGridTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.lblGridTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGridTitle.Text = "Daftar Master Properti"

        Me.txtCari.Name = "txtCari"
        Me.txtCari.Location = New System.Drawing.Point(12, 44)
        Me.txtCari.Size = New System.Drawing.Size(220, 24)
        Me.txtCari.Font = New System.Drawing.Font("Segoe UI", 9.0!)

        Me.btnCari.Name = "btnCari" : Me.btnCari.Text = "Cari"
        Me.btnCari.Location = New System.Drawing.Point(238, 43)
        Me.btnCari.Size = New System.Drawing.Size(70, 26)
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnCari.BackColor = System.Drawing.Color.FromArgb(91, 33, 182)
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

        Me.dgvProperti.Name = "dgvProperti"
        Me.dgvProperti.Location = New System.Drawing.Point(12, 80)
        Me.dgvProperti.Size = New System.Drawing.Size(650, 484)
        Me.dgvProperti.Anchor = System.Windows.Forms.AnchorStyles.Top Or
                               System.Windows.Forms.AnchorStyles.Bottom Or
                               System.Windows.Forms.AnchorStyles.Left Or
                               System.Windows.Forms.AnchorStyles.Right
        Me.dgvProperti.BackgroundColor = System.Drawing.Color.White
        Me.dgvProperti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvProperti.RowHeadersVisible = False
        Me.dgvProperti.AllowUserToAddRows = False
        Me.dgvProperti.AllowUserToDeleteRows = False
        Me.dgvProperti.ReadOnly = True
        Me.dgvProperti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProperti.MultiSelect = False
        Me.dgvProperti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProperti.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvProperti.ColumnHeadersHeight = 32
        Me.dgvProperti.EnableHeadersVisualStyles = False
        Me.dgvProperti.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.dgvProperti.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvProperti.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvProperti.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 243, 255)

        ' PropertiForm
        Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.ClientSize = New System.Drawing.Size(980, 636)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "PropertiForm"
        Me.Text = "Master Properti"
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
        CType(Me.dgvProperti, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnUnassign As System.Windows.Forms.Button
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
End Class