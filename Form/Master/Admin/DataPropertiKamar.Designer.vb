<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataPropertiKamar
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
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.lblInfoTitle = New System.Windows.Forms.Label()
        Me.lblNamaProp = New System.Windows.Forms.Label()
        Me.txtNamaProp = New System.Windows.Forms.TextBox()
        Me.lblBiaya = New System.Windows.Forms.Label()
        Me.txtBiaya = New System.Windows.Forms.TextBox()
        Me.pnlDiv = New System.Windows.Forms.Panel()
        Me.lblKamarTitle = New System.Windows.Forms.Label()
        Me.lblKamarNote = New System.Windows.Forms.Label()
        Me.dgvKamar = New System.Windows.Forms.DataGridView()
        Me.colCek = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colIdKamar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNomorKamar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipeKamar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatusKamar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.txtSummary = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()

        Me.pnlHeader.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        CType(Me.dgvKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '
        'pnlHeader
        '
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 56
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubTitle)

        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.AutoSize = False
        Me.lblTitle.Size = New System.Drawing.Size(540, 28)
        Me.lblTitle.Location = New System.Drawing.Point(16, 8)
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Text = "Assign Properti ke Kamar"

        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.AutoSize = False
        Me.lblSubTitle.Size = New System.Drawing.Size(540, 18)
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(221, 214, 254)
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Text = "Centang kamar yang memiliki properti ini"

        '
        'pnlBody
        '
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Location = New System.Drawing.Point(0, 56)
        Me.pnlBody.Size = New System.Drawing.Size(580, 600)
        Me.pnlBody.BackColor = System.Drawing.Color.White
        Me.pnlBody.AutoScroll = True
        Me.pnlBody.Controls.Add(Me.lblInfoTitle)
        Me.pnlBody.Controls.Add(Me.lblNamaProp)
        Me.pnlBody.Controls.Add(Me.txtNamaProp)
        Me.pnlBody.Controls.Add(Me.lblBiaya)
        Me.pnlBody.Controls.Add(Me.txtBiaya)
        Me.pnlBody.Controls.Add(Me.pnlDiv)
        Me.pnlBody.Controls.Add(Me.lblKamarTitle)
        Me.pnlBody.Controls.Add(Me.lblKamarNote)
        Me.pnlBody.Controls.Add(Me.dgvKamar)
        Me.pnlBody.Controls.Add(Me.lblSummary)
        Me.pnlBody.Controls.Add(Me.txtSummary)
        Me.pnlBody.Controls.Add(Me.btnSimpan)
        Me.pnlBody.Controls.Add(Me.btnTutup)

        Me.lblInfoTitle.Name = "lblInfoTitle"
        Me.lblInfoTitle.AutoSize = False
        Me.lblInfoTitle.Size = New System.Drawing.Size(540, 18)
        Me.lblInfoTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblInfoTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(130, 130, 130)
        Me.lblInfoTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblInfoTitle.Text = "INFO PROPERTI"

        Me.lblNamaProp.Name = "lblNamaProp"
        Me.lblNamaProp.AutoSize = True
        Me.lblNamaProp.Location = New System.Drawing.Point(16, 38)
        Me.lblNamaProp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNamaProp.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblNamaProp.Text = "Nama Properti"

        Me.txtNamaProp.Name = "txtNamaProp"
        Me.txtNamaProp.Location = New System.Drawing.Point(16, 56)
        Me.txtNamaProp.Size = New System.Drawing.Size(540, 24)
        Me.txtNamaProp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNamaProp.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtNamaProp.ReadOnly = True

        Me.lblBiaya.Name = "lblBiaya"
        Me.lblBiaya.AutoSize = True
        Me.lblBiaya.Location = New System.Drawing.Point(16, 90)
        Me.lblBiaya.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBiaya.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblBiaya.Text = "Biaya Denda"

        Me.txtBiaya.Name = "txtBiaya"
        Me.txtBiaya.Location = New System.Drawing.Point(16, 108)
        Me.txtBiaya.Size = New System.Drawing.Size(540, 24)
        Me.txtBiaya.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBiaya.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtBiaya.ReadOnly = True

        Me.pnlDiv.Name = "pnlDiv"
        Me.pnlDiv.Location = New System.Drawing.Point(16, 144)
        Me.pnlDiv.Size = New System.Drawing.Size(540, 1)
        Me.pnlDiv.BackColor = System.Drawing.Color.FromArgb(210, 215, 225)

        Me.lblKamarTitle.Name = "lblKamarTitle"
        Me.lblKamarTitle.AutoSize = False
        Me.lblKamarTitle.Size = New System.Drawing.Size(540, 18)
        Me.lblKamarTitle.Location = New System.Drawing.Point(16, 154)
        Me.lblKamarTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblKamarTitle.ForeColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.lblKamarTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblKamarTitle.Text = "PILIH KAMAR"

        Me.lblKamarNote.Name = "lblKamarNote"
        Me.lblKamarNote.AutoSize = False
        Me.lblKamarNote.Size = New System.Drawing.Size(540, 18)
        Me.lblKamarNote.Location = New System.Drawing.Point(16, 174)
        Me.lblKamarNote.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblKamarNote.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Me.lblKamarNote.BackColor = System.Drawing.Color.Transparent
        Me.lblKamarNote.Text = "Centang kamar yang memiliki properti ini"

        Me.dgvKamar.Name = "dgvKamar"
        Me.dgvKamar.Location = New System.Drawing.Point(16, 198)
        Me.dgvKamar.Size = New System.Drawing.Size(540, 240)
        Me.dgvKamar.BackgroundColor = System.Drawing.Color.White
        Me.dgvKamar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvKamar.RowHeadersVisible = False
        Me.dgvKamar.AllowUserToAddRows = False
        Me.dgvKamar.AllowUserToDeleteRows = False
        Me.dgvKamar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKamar.MultiSelect = False
        Me.dgvKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvKamar.ColumnHeadersHeight = 30
        Me.dgvKamar.EnableHeadersVisualStyles = False
        Me.dgvKamar.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.dgvKamar.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvKamar.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvKamar.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 243, 255)
        Me.dgvKamar.Columns.Add(Me.colCek)
        Me.dgvKamar.Columns.Add(Me.colIdKamar)
        Me.dgvKamar.Columns.Add(Me.colNomorKamar)
        Me.dgvKamar.Columns.Add(Me.colTipeKamar)
        Me.dgvKamar.Columns.Add(Me.colStatusKamar)

        Me.colCek.Name = "colCek"
        Me.colCek.HeaderText = "Assign"
        Me.colCek.Width = 55
        Me.colCek.ReadOnly = False

        Me.colIdKamar.Name = "colIdKamar"
        Me.colIdKamar.HeaderText = "ID"
        Me.colIdKamar.FillWeight = 40
        Me.colIdKamar.ReadOnly = True

        Me.colNomorKamar.Name = "colNomorKamar"
        Me.colNomorKamar.HeaderText = "No. Kamar"
        Me.colNomorKamar.FillWeight = 80
        Me.colNomorKamar.ReadOnly = True

        Me.colTipeKamar.Name = "colTipeKamar"
        Me.colTipeKamar.HeaderText = "Tipe"
        Me.colTipeKamar.FillWeight = 100
        Me.colTipeKamar.ReadOnly = True

        Me.colStatusKamar.Name = "colStatusKamar"
        Me.colStatusKamar.HeaderText = "Status"
        Me.colStatusKamar.FillWeight = 80
        Me.colStatusKamar.ReadOnly = True

        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Location = New System.Drawing.Point(16, 448)
        Me.lblSummary.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSummary.ForeColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.lblSummary.Text = "Kamar yang di-assign"

        Me.txtSummary.Name = "txtSummary"
        Me.txtSummary.Location = New System.Drawing.Point(16, 466)
        Me.txtSummary.Size = New System.Drawing.Size(540, 24)
        Me.txtSummary.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.txtSummary.BackColor = System.Drawing.Color.FromArgb(245, 243, 255)
        Me.txtSummary.ForeColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.txtSummary.ReadOnly = True
        Me.txtSummary.Text = "0 kamar dipilih"

        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Text = "Simpan Assignment"
        Me.btnSimpan.Location = New System.Drawing.Point(16, 506)
        Me.btnSimpan.Size = New System.Drawing.Size(540, 34)
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.UseVisualStyleBackColor = False

        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.Location = New System.Drawing.Point(16, 548)
        Me.btnTutup.Size = New System.Drawing.Size(540, 30)
        Me.btnTutup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(220, 220, 220)
        Me.btnTutup.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTutup.FlatAppearance.BorderSize = 0
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTutup.UseVisualStyleBackColor = False

        '
        'PropertiKamarForm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(580, 656)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PropertiKamarForm"
        Me.Text = "Assign Properti ke Kamar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlBody)

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBody.PerformLayout()
        CType(Me.dgvKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents lblInfoTitle As System.Windows.Forms.Label
    Friend WithEvents lblNamaProp As System.Windows.Forms.Label
    Friend WithEvents txtNamaProp As System.Windows.Forms.TextBox
    Friend WithEvents lblBiaya As System.Windows.Forms.Label
    Friend WithEvents txtBiaya As System.Windows.Forms.TextBox
    Friend WithEvents pnlDiv As System.Windows.Forms.Panel
    Friend WithEvents lblKamarTitle As System.Windows.Forms.Label
    Friend WithEvents lblKamarNote As System.Windows.Forms.Label
    Friend WithEvents dgvKamar As System.Windows.Forms.DataGridView
    Friend WithEvents colCek As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colIdKamar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNomorKamar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipeKamar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatusKamar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblSummary As System.Windows.Forms.Label
    Friend WithEvents txtSummary As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button

End Class