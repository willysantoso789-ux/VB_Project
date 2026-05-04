<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PropertiKamarForm
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
        Me.lblPropLabel = New System.Windows.Forms.Label()
        Me.txtNamaProp = New System.Windows.Forms.TextBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.dgvKamar = New System.Windows.Forms.DataGridView()
        Me.colCek = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colIdKamar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNoKamar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKeterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSummary = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()

        Me.pnlHeader.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        CType(Me.dgvKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Me.pnlHeader.Name = "pnlHeader" : Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 56
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.pnlHeader.Controls.Add(Me.lblTitle) : Me.pnlHeader.Controls.Add(Me.lblSubTitle)

        Me.lblTitle.Name = "lblTitle" : Me.lblTitle.AutoSize = False
        Me.lblTitle.Size = New System.Drawing.Size(540, 28) : Me.lblTitle.Location = New System.Drawing.Point(16, 8)
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White : Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Text = "Assign Properti ke Kamar"

        Me.lblSubTitle.Name = "lblSubTitle" : Me.lblSubTitle.AutoSize = False
        Me.lblSubTitle.Size = New System.Drawing.Size(540, 18) : Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(221, 214, 254) : Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Text = "Centang kamar yang akan menerima properti ini"

        Me.pnlBody.Name = "pnlBody" : Me.pnlBody.Location = New System.Drawing.Point(0, 56)
        Me.pnlBody.Size = New System.Drawing.Size(580, 500) : Me.pnlBody.BackColor = System.Drawing.Color.White
        Me.pnlBody.Controls.Add(Me.lblPropLabel) : Me.pnlBody.Controls.Add(Me.txtNamaProp)
        Me.pnlBody.Controls.Add(Me.lblNote) : Me.pnlBody.Controls.Add(Me.dgvKamar)
        Me.pnlBody.Controls.Add(Me.txtSummary) : Me.pnlBody.Controls.Add(Me.btnSimpan)
        Me.pnlBody.Controls.Add(Me.btnTutup)

        Me.lblPropLabel.Name = "lblPropLabel" : Me.lblPropLabel.AutoSize = True
        Me.lblPropLabel.Location = New System.Drawing.Point(16, 16)
        Me.lblPropLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPropLabel.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60) : Me.lblPropLabel.Text = "Properti"

        Me.txtNamaProp.Name = "txtNamaProp" : Me.txtNamaProp.Location = New System.Drawing.Point(16, 34)
        Me.txtNamaProp.Size = New System.Drawing.Size(540, 24) : Me.txtNamaProp.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.txtNamaProp.BackColor = System.Drawing.Color.FromArgb(240, 240, 240) : Me.txtNamaProp.ReadOnly = True

        Me.lblNote.Name = "lblNote" : Me.lblNote.AutoSize = False
        Me.lblNote.Size = New System.Drawing.Size(540, 18) : Me.lblNote.Location = New System.Drawing.Point(16, 68)
        Me.lblNote.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblNote.ForeColor = System.Drawing.Color.FromArgb(91, 33, 182) : Me.lblNote.BackColor = System.Drawing.Color.Transparent
        Me.lblNote.Text = "Centang kamar yang akan di-assign. ✔ = sudah ter-assign sebelumnya"

        Me.dgvKamar.Name = "dgvKamar" : Me.dgvKamar.Location = New System.Drawing.Point(16, 92)
        Me.dgvKamar.Size = New System.Drawing.Size(540, 260)
        Me.dgvKamar.BackgroundColor = System.Drawing.Color.White
        Me.dgvKamar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvKamar.RowHeadersVisible = False : Me.dgvKamar.AllowUserToAddRows = False
        Me.dgvKamar.AllowUserToDeleteRows = False
        Me.dgvKamar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvKamar.ColumnHeadersHeight = 30 : Me.dgvKamar.EnableHeadersVisualStyles = False
        Me.dgvKamar.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.dgvKamar.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvKamar.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvKamar.Columns.Add(Me.colCek) : Me.dgvKamar.Columns.Add(Me.colIdKamar)
        Me.dgvKamar.Columns.Add(Me.colNoKamar) : Me.dgvKamar.Columns.Add(Me.colTipe)
        Me.dgvKamar.Columns.Add(Me.colStatus) : Me.dgvKamar.Columns.Add(Me.colKeterangan)

        Me.colCek.Name = "colCek" : Me.colCek.HeaderText = "Assign" : Me.colCek.Width = 55 : Me.colCek.ReadOnly = False
        Me.colIdKamar.Name = "colIdKamar" : Me.colIdKamar.HeaderText = "ID" : Me.colIdKamar.FillWeight = 35 : Me.colIdKamar.ReadOnly = True
        Me.colNoKamar.Name = "colNoKamar" : Me.colNoKamar.HeaderText = "No. Kamar" : Me.colNoKamar.FillWeight = 80 : Me.colNoKamar.ReadOnly = True
        Me.colTipe.Name = "colTipe" : Me.colTipe.HeaderText = "Tipe" : Me.colTipe.FillWeight = 100 : Me.colTipe.ReadOnly = True
        Me.colStatus.Name = "colStatus" : Me.colStatus.HeaderText = "Status Kamar" : Me.colStatus.FillWeight = 90 : Me.colStatus.ReadOnly = True
        Me.colKeterangan.Name = "colKeterangan" : Me.colKeterangan.HeaderText = "Keterangan" : Me.colKeterangan.FillWeight = 110 : Me.colKeterangan.ReadOnly = True

        Me.txtSummary.Name = "txtSummary" : Me.txtSummary.Location = New System.Drawing.Point(16, 362)
        Me.txtSummary.Size = New System.Drawing.Size(540, 24)
        Me.txtSummary.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtSummary.BackColor = System.Drawing.Color.FromArgb(245, 243, 255)
        Me.txtSummary.ForeColor = System.Drawing.Color.FromArgb(91, 33, 182)
        Me.txtSummary.ReadOnly = True : Me.txtSummary.Text = "0 kamar dipilih"

        Me.btnSimpan.Name = "btnSimpan" : Me.btnSimpan.Text = "Simpan Assignment"
        Me.btnSimpan.Location = New System.Drawing.Point(16, 400) : Me.btnSimpan.Size = New System.Drawing.Size(540, 34)
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(91, 33, 182) : Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat : Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand : Me.btnSimpan.UseVisualStyleBackColor = False

        Me.btnTutup.Name = "btnTutup" : Me.btnTutup.Text = "Tutup"
        Me.btnTutup.Location = New System.Drawing.Point(16, 444) : Me.btnTutup.Size = New System.Drawing.Size(540, 28)
        Me.btnTutup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(220, 220, 220) : Me.btnTutup.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat : Me.btnTutup.FlatAppearance.BorderSize = 0
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand : Me.btnTutup.UseVisualStyleBackColor = False

        Me.BackColor = System.Drawing.Color.White : Me.ClientSize = New System.Drawing.Size(580, 556)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False : Me.MinimizeBox = False
        Me.Name = "AssignPropertiForm" : Me.Text = "Assign Properti ke Kamar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Controls.Add(Me.pnlHeader) : Me.Controls.Add(Me.pnlBody)

        Me.pnlHeader.ResumeLayout(False) : Me.pnlBody.ResumeLayout(False) : Me.pnlBody.PerformLayout()
        CType(Me.dgvKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents lblPropLabel As System.Windows.Forms.Label
    Friend WithEvents txtNamaProp As System.Windows.Forms.TextBox
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents dgvKamar As System.Windows.Forms.DataGridView
    Friend WithEvents colCek As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colIdKamar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNoKamar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKeterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSummary As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button
End Class