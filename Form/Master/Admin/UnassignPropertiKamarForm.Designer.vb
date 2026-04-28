<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UnassignPropertiKamarForm
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
        Me.dgvUnassign = New System.Windows.Forms.DataGridView()
        Me.colCek = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colIdKamar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNoKamar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKondisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUnassign = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()

        Me.pnlHeader.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        CType(Me.dgvUnassign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 56
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubTitle)

        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.AutoSize = False
        Me.lblTitle.Size = New System.Drawing.Size(520, 28)
        Me.lblTitle.Location = New System.Drawing.Point(16, 8)
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Text = "Unassign Properti dari Kamar"

        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.AutoSize = False
        Me.lblSubTitle.Size = New System.Drawing.Size(520, 18)
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(254, 202, 202)
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Text = "Centang kamar yang ingin dicopot dari properti ini"

        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Location = New System.Drawing.Point(0, 56)
        Me.pnlBody.Size = New System.Drawing.Size(560, 480)
        Me.pnlBody.BackColor = System.Drawing.Color.White
        Me.pnlBody.Controls.Add(Me.lblPropLabel)
        Me.pnlBody.Controls.Add(Me.txtNamaProp)
        Me.pnlBody.Controls.Add(Me.lblNote)
        Me.pnlBody.Controls.Add(Me.dgvUnassign)
        Me.pnlBody.Controls.Add(Me.btnUnassign)
        Me.pnlBody.Controls.Add(Me.btnTutup)

        Me.lblPropLabel.Name = "lblPropLabel"
        Me.lblPropLabel.AutoSize = True
        Me.lblPropLabel.Location = New System.Drawing.Point(16, 16)
        Me.lblPropLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblPropLabel.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblPropLabel.Text = "Properti"

        Me.txtNamaProp.Name = "txtNamaProp"
        Me.txtNamaProp.Location = New System.Drawing.Point(16, 34)
        Me.txtNamaProp.Size = New System.Drawing.Size(520, 24)
        Me.txtNamaProp.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.txtNamaProp.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtNamaProp.ReadOnly = True

        Me.lblNote.Name = "lblNote"
        Me.lblNote.AutoSize = False
        Me.lblNote.Size = New System.Drawing.Size(520, 18)
        Me.lblNote.Location = New System.Drawing.Point(16, 68)
        Me.lblNote.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblNote.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.lblNote.BackColor = System.Drawing.Color.Transparent
        Me.lblNote.Text = "Centang kamar yang ingin di-UNASSIGN dari properti ini"

        Me.dgvUnassign.Name = "dgvUnassign"
        Me.dgvUnassign.Location = New System.Drawing.Point(16, 92)
        Me.dgvUnassign.Size = New System.Drawing.Size(520, 280)
        Me.dgvUnassign.BackgroundColor = System.Drawing.Color.White
        Me.dgvUnassign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvUnassign.RowHeadersVisible = False
        Me.dgvUnassign.AllowUserToAddRows = False
        Me.dgvUnassign.AllowUserToDeleteRows = False
        Me.dgvUnassign.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUnassign.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvUnassign.ColumnHeadersHeight = 30
        Me.dgvUnassign.EnableHeadersVisualStyles = False
        Me.dgvUnassign.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.dgvUnassign.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvUnassign.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvUnassign.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 241, 242)
        Me.dgvUnassign.Columns.Add(Me.colCek)
        Me.dgvUnassign.Columns.Add(Me.colIdKamar)
        Me.dgvUnassign.Columns.Add(Me.colNoKamar)
        Me.dgvUnassign.Columns.Add(Me.colTipe)
        Me.dgvUnassign.Columns.Add(Me.colKondisi)

        Me.colCek.Name = "colCek"
        Me.colCek.HeaderText = "Unassign"
        Me.colCek.Width = 65
        Me.colCek.ReadOnly = False

        Me.colIdKamar.Name = "colIdKamar"
        Me.colIdKamar.HeaderText = "ID"
        Me.colIdKamar.FillWeight = 40
        Me.colIdKamar.ReadOnly = True

        Me.colNoKamar.Name = "colNoKamar"
        Me.colNoKamar.HeaderText = "No. Kamar"
        Me.colNoKamar.FillWeight = 80
        Me.colNoKamar.ReadOnly = True

        Me.colTipe.Name = "colTipe"
        Me.colTipe.HeaderText = "Tipe"
        Me.colTipe.FillWeight = 100
        Me.colTipe.ReadOnly = True

        Me.colKondisi.Name = "colKondisi"
        Me.colKondisi.HeaderText = "Kondisi Saat Ini"
        Me.colKondisi.FillWeight = 130
        Me.colKondisi.ReadOnly = True

        Me.btnUnassign.Name = "btnUnassign"
        Me.btnUnassign.Text = "Unassign yang Dicentang"
        Me.btnUnassign.Location = New System.Drawing.Point(16, 386)
        Me.btnUnassign.Size = New System.Drawing.Size(520, 34)
        Me.btnUnassign.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnUnassign.BackColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.btnUnassign.ForeColor = System.Drawing.Color.White
        Me.btnUnassign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnassign.FlatAppearance.BorderSize = 0
        Me.btnUnassign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnassign.UseVisualStyleBackColor = False

        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.Location = New System.Drawing.Point(16, 428)
        Me.btnTutup.Size = New System.Drawing.Size(520, 28)
        Me.btnTutup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(220, 220, 220)
        Me.btnTutup.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTutup.FlatAppearance.BorderSize = 0
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTutup.UseVisualStyleBackColor = False

        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(560, 536)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UnassignPropertiForm"
        Me.Text = "Unassign Properti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlBody)

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBody.PerformLayout()
        CType(Me.dgvUnassign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents lblPropLabel As System.Windows.Forms.Label
    Friend WithEvents txtNamaProp As System.Windows.Forms.TextBox
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents dgvUnassign As System.Windows.Forms.DataGridView
    Friend WithEvents colCek As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colIdKamar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNoKamar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKondisi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnUnassign As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button

End Class