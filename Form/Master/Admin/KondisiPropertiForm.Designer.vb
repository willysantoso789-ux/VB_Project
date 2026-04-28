<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KondisiPropertiForm
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
        Me.lblPropLabel = New System.Windows.Forms.Label()
        Me.txtNamaProp = New System.Windows.Forms.TextBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.dgvAdjust = New System.Windows.Forms.DataGridView()
        Me.colIdKamar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNoKamar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKondisi = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.pnlLegend = New System.Windows.Forms.Panel()
        Me.lblLegend = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()

        Me.pnlHeader.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        CType(Me.dgvAdjust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 56
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubTitle)

        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.AutoSize = False
        Me.lblTitle.Size = New System.Drawing.Size(520, 28)
        Me.lblTitle.Location = New System.Drawing.Point(16, 8)
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Text = "Adjust Kondisi Properti"

        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.AutoSize = False
        Me.lblSubTitle.Size = New System.Drawing.Size(520, 18)
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(180, 200, 240)
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Text = "Ubah kondisi properti per kamar yang ter-assign"

        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Location = New System.Drawing.Point(0, 56)
        Me.pnlBody.Size = New System.Drawing.Size(580, 520)
        Me.pnlBody.BackColor = System.Drawing.Color.White
        Me.pnlBody.Controls.Add(Me.lblPropLabel)
        Me.pnlBody.Controls.Add(Me.txtNamaProp)
        Me.pnlBody.Controls.Add(Me.lblNote)
        Me.pnlBody.Controls.Add(Me.dgvAdjust)
        Me.pnlBody.Controls.Add(Me.pnlLegend)
        Me.pnlBody.Controls.Add(Me.btnSimpan)
        Me.pnlBody.Controls.Add(Me.btnTutup)

        Me.lblPropLabel.Name = "lblPropLabel"
        Me.lblPropLabel.AutoSize = True
        Me.lblPropLabel.Location = New System.Drawing.Point(16, 16)
        Me.lblPropLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPropLabel.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblPropLabel.Text = "Properti"

        Me.txtNamaProp.Name = "txtNamaProp"
        Me.txtNamaProp.Location = New System.Drawing.Point(16, 34)
        Me.txtNamaProp.Size = New System.Drawing.Size(540, 24)
        Me.txtNamaProp.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.txtNamaProp.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtNamaProp.ReadOnly = True

        Me.lblNote.Name = "lblNote"
        Me.lblNote.AutoSize = False
        Me.lblNote.Size = New System.Drawing.Size(540, 18)
        Me.lblNote.Location = New System.Drawing.Point(16, 68)
        Me.lblNote.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblNote.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Me.lblNote.BackColor = System.Drawing.Color.Transparent
        Me.lblNote.Text = "Klik dropdown pada kolom Kondisi untuk mengubah status per kamar"

        Me.dgvAdjust.Name = "dgvAdjust"
        Me.dgvAdjust.Location = New System.Drawing.Point(16, 92)
        Me.dgvAdjust.Size = New System.Drawing.Size(540, 240)
        Me.dgvAdjust.BackgroundColor = System.Drawing.Color.White
        Me.dgvAdjust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvAdjust.RowHeadersVisible = False
        Me.dgvAdjust.AllowUserToAddRows = False
        Me.dgvAdjust.AllowUserToDeleteRows = False
        Me.dgvAdjust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAdjust.MultiSelect = False
        Me.dgvAdjust.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvAdjust.ColumnHeadersHeight = 30
        Me.dgvAdjust.EnableHeadersVisualStyles = False
        Me.dgvAdjust.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.dgvAdjust.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvAdjust.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvAdjust.Columns.Add(Me.colIdKamar)
        Me.dgvAdjust.Columns.Add(Me.colNoKamar)
        Me.dgvAdjust.Columns.Add(Me.colTipe)
        Me.dgvAdjust.Columns.Add(Me.colKondisi)

        Me.colIdKamar.Name = "colIdKamar"
        Me.colIdKamar.HeaderText = "ID"
        Me.colIdKamar.FillWeight = 40
        Me.colIdKamar.ReadOnly = True

        Me.colNoKamar.Name = "colNoKamar"
        Me.colNoKamar.HeaderText = "No. Kamar"
        Me.colNoKamar.FillWeight = 90
        Me.colNoKamar.ReadOnly = True

        Me.colTipe.Name = "colTipe"
        Me.colTipe.HeaderText = "Tipe Kamar"
        Me.colTipe.FillWeight = 120
        Me.colTipe.ReadOnly = True

        Me.colKondisi.Name = "colKondisi"
        Me.colKondisi.HeaderText = "Kondisi"
        Me.colKondisi.FillWeight = 160
        Me.colKondisi.ReadOnly = False
        Me.colKondisi.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.colKondisi.Items.AddRange(New Object() {"Baik", "Rusak", "Dalam Perbaikan"})

        Me.pnlLegend.Name = "pnlLegend"
        Me.pnlLegend.Location = New System.Drawing.Point(16, 342)
        Me.pnlLegend.Size = New System.Drawing.Size(540, 54)
        Me.pnlLegend.BackColor = System.Drawing.Color.FromArgb(235, 238, 245)
        Me.pnlLegend.Controls.Add(Me.lblLegend)

        Me.lblLegend.Name = "lblLegend"
        Me.lblLegend.AutoSize = False
        Me.lblLegend.Size = New System.Drawing.Size(520, 46)
        Me.lblLegend.Location = New System.Drawing.Point(8, 4)
        Me.lblLegend.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblLegend.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80)
        Me.lblLegend.BackColor = System.Drawing.Color.Transparent
        Me.lblLegend.Text = "Baik = Properti normal, siap digunakan" & vbNewLine &
                                  "Rusak = Perlu penggantian / dikenakan denda" & vbNewLine &
                                  "Dalam Perbaikan = Sedang diperbaiki, belum siap"

        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Text = "Simpan Kondisi"
        Me.btnSimpan.Location = New System.Drawing.Point(16, 410)
        Me.btnSimpan.Size = New System.Drawing.Size(540, 34)
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.UseVisualStyleBackColor = False

        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.Location = New System.Drawing.Point(16, 452)
        Me.btnTutup.Size = New System.Drawing.Size(540, 28)
        Me.btnTutup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(220, 220, 220)
        Me.btnTutup.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTutup.FlatAppearance.BorderSize = 0
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTutup.UseVisualStyleBackColor = False

        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(580, 576)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdjustKondisiForm"
        Me.Text = "Adjust Kondisi Properti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlBody)

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBody.PerformLayout()
        CType(Me.dgvAdjust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents lblPropLabel As System.Windows.Forms.Label
    Friend WithEvents txtNamaProp As System.Windows.Forms.TextBox
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents dgvAdjust As System.Windows.Forms.DataGridView
    Friend WithEvents colIdKamar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNoKamar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKondisi As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents pnlLegend As System.Windows.Forms.Panel
    Friend WithEvents lblLegend As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button

End Class