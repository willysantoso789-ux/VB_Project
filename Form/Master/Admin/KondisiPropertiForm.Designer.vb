<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KondisiPropertiKamarForm
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
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.dgvKondisi = New System.Windows.Forms.DataGridView()
        Me.colIdProperti = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNamaProperti = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBiayaDenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKondisi = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.pnlLegend = New System.Windows.Forms.Panel()
        Me.lblLegend = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()

        Me.pnlHeader.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        CType(Me.dgvKondisi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' pnlHeader
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 56
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubTitle)

        Me.lblTitle.Name = "lblTitle" : Me.lblTitle.AutoSize = False
        Me.lblTitle.Size = New System.Drawing.Size(560, 28)
        Me.lblTitle.Location = New System.Drawing.Point(16, 8)
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Text = "Kondisi Properti Kamar"

        Me.lblSubTitle.Name = "lblSubTitle" : Me.lblSubTitle.AutoSize = False
        Me.lblSubTitle.Size = New System.Drawing.Size(560, 18)
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(221, 214, 254)
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Text = "Ubah kondisi properti yang ter-assign di kamar ini"

        ' pnlBody
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Location = New System.Drawing.Point(0, 56)
        Me.pnlBody.Size = New System.Drawing.Size(600, 500)
        Me.pnlBody.BackColor = System.Drawing.Color.White
        Me.pnlBody.Controls.Add(Me.lblNote)
        Me.pnlBody.Controls.Add(Me.dgvKondisi)
        Me.pnlBody.Controls.Add(Me.pnlLegend)
        Me.pnlBody.Controls.Add(Me.btnSimpan)
        Me.pnlBody.Controls.Add(Me.btnTutup)

        Me.lblNote.Name = "lblNote" : Me.lblNote.AutoSize = False
        Me.lblNote.Size = New System.Drawing.Size(564, 18)
        Me.lblNote.Location = New System.Drawing.Point(16, 14)
        Me.lblNote.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblNote.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Me.lblNote.BackColor = System.Drawing.Color.Transparent
        Me.lblNote.Text = "Klik dropdown kolom Kondisi untuk mengubah status properti"

        ' dgvKondisi
        Me.dgvKondisi.Name = "dgvKondisi"
        Me.dgvKondisi.Location = New System.Drawing.Point(16, 38)
        Me.dgvKondisi.Size = New System.Drawing.Size(564, 280)
        Me.dgvKondisi.BackgroundColor = System.Drawing.Color.White
        Me.dgvKondisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvKondisi.RowHeadersVisible = False
        Me.dgvKondisi.AllowUserToAddRows = False
        Me.dgvKondisi.AllowUserToDeleteRows = False
        Me.dgvKondisi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKondisi.MultiSelect = False
        Me.dgvKondisi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvKondisi.ColumnHeadersHeight = 30
        Me.dgvKondisi.EnableHeadersVisualStyles = False
        Me.dgvKondisi.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.dgvKondisi.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvKondisi.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvKondisi.Columns.Add(Me.colIdProperti)
        Me.dgvKondisi.Columns.Add(Me.colNamaProperti)
        Me.dgvKondisi.Columns.Add(Me.colBiayaDenda)
        Me.dgvKondisi.Columns.Add(Me.colKondisi)

        Me.colIdProperti.Name = "colIdProperti"
        Me.colIdProperti.HeaderText = "ID"
        Me.colIdProperti.Width = 0
        Me.colIdProperti.Visible = False
        Me.colIdProperti.ReadOnly = True

        Me.colNamaProperti.Name = "colNamaProperti"
        Me.colNamaProperti.HeaderText = "Nama Properti"
        Me.colNamaProperti.FillWeight = 200
        Me.colNamaProperti.ReadOnly = True

        Me.colBiayaDenda.Name = "colBiayaDenda"
        Me.colBiayaDenda.HeaderText = "Biaya Denda (Rp)"
        Me.colBiayaDenda.FillWeight = 120
        Me.colBiayaDenda.ReadOnly = True

        Me.colKondisi.Name = "colKondisi"
        Me.colKondisi.HeaderText = "Kondisi"
        Me.colKondisi.FillWeight = 150
        Me.colKondisi.ReadOnly = False
        Me.colKondisi.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.colKondisi.Items.AddRange(New Object() {"Baik", "Rusak", "Dalam Perbaikan"})

        ' pnlLegend
        Me.pnlLegend.Name = "pnlLegend"
        Me.pnlLegend.Location = New System.Drawing.Point(16, 328)
        Me.pnlLegend.Size = New System.Drawing.Size(564, 54)
        Me.pnlLegend.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.pnlLegend.Controls.Add(Me.lblLegend)

        Me.lblLegend.Name = "lblLegend" : Me.lblLegend.AutoSize = False
        Me.lblLegend.Size = New System.Drawing.Size(552, 46)
        Me.lblLegend.Location = New System.Drawing.Point(6, 4)
        Me.lblLegend.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblLegend.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80)
        Me.lblLegend.BackColor = System.Drawing.Color.Transparent
        Me.lblLegend.Text = "Baik = Properti normal, siap digunakan" & vbNewLine &
                            "Rusak = Perlu penggantian / dikenakan denda" & vbNewLine &
                            "Dalam Perbaikan = Sedang diperbaiki, belum siap"

        Me.btnSimpan.Name = "btnSimpan" : Me.btnSimpan.Text = "Simpan Kondisi"
        Me.btnSimpan.Location = New System.Drawing.Point(16, 396)
        Me.btnSimpan.Size = New System.Drawing.Size(564, 34)
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.UseVisualStyleBackColor = False

        Me.btnTutup.Name = "btnTutup" : Me.btnTutup.Text = "Tutup"
        Me.btnTutup.Location = New System.Drawing.Point(16, 440)
        Me.btnTutup.Size = New System.Drawing.Size(564, 28)
        Me.btnTutup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(220, 220, 220)
        Me.btnTutup.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTutup.FlatAppearance.BorderSize = 0
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTutup.UseVisualStyleBackColor = False

        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 556)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False : Me.MinimizeBox = False
        Me.Name = "KondisiPropertiKamarForm"
        Me.Text = "Kondisi Properti Kamar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlBody)

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBody.PerformLayout()
        CType(Me.dgvKondisi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents dgvKondisi As System.Windows.Forms.DataGridView
    Friend WithEvents colIdProperti As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNamaProperti As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBiayaDenda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKondisi As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents pnlLegend As System.Windows.Forms.Panel
    Friend WithEvents lblLegend As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button
End Class