<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DendaForm
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
        Me.dgvProperti = New System.Windows.Forms.DataGridView()
        Me.colCekRusak = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colNamaItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBiayaDenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKondisiAwal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlSummary = New System.Windows.Forms.Panel()
        Me.lblDendaTelat = New System.Windows.Forms.Label()
        Me.txtDendaTelat = New System.Windows.Forms.TextBox()
        Me.lblDendaRusak = New System.Windows.Forms.Label()
        Me.txtDendaKerusakan = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotalDenda = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()

        Me.pnlHeader.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.pnlSummary.SuspendLayout()
        CType(Me.dgvProperti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Me.pnlHeader.Name = "pnlHeader" : Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 56 : Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.pnlHeader.Controls.Add(Me.lblTitle) : Me.pnlHeader.Controls.Add(Me.lblSubTitle)

        Me.lblTitle.Name = "lblTitle" : Me.lblTitle.AutoSize = False
        Me.lblTitle.Size = New System.Drawing.Size(500, 28) : Me.lblTitle.Location = New System.Drawing.Point(16, 8)
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White : Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Text = "Detail Denda Kerusakan"

        Me.lblSubTitle.Name = "lblSubTitle" : Me.lblSubTitle.AutoSize = False
        Me.lblSubTitle.Size = New System.Drawing.Size(500, 18) : Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(254, 202, 202) : Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Text = "Centang properti yang rusak untuk menghitung denda"

        Me.pnlBody.Name = "pnlBody" : Me.pnlBody.Location = New System.Drawing.Point(0, 56)
        Me.pnlBody.Size = New System.Drawing.Size(580, 520) : Me.pnlBody.BackColor = System.Drawing.Color.White
        Me.pnlBody.Controls.Add(Me.lblNote) : Me.pnlBody.Controls.Add(Me.dgvProperti)
        Me.pnlBody.Controls.Add(Me.pnlSummary) : Me.pnlBody.Controls.Add(Me.btnSimpan)
        Me.pnlBody.Controls.Add(Me.btnBatal)

        Me.lblNote.Name = "lblNote" : Me.lblNote.AutoSize = False
        Me.lblNote.Size = New System.Drawing.Size(548, 18) : Me.lblNote.Location = New System.Drawing.Point(16, 14)
        Me.lblNote.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblNote.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100) : Me.lblNote.BackColor = System.Drawing.Color.Transparent
        Me.lblNote.Text = "Centang properti yang rusak"

        Me.dgvProperti.Name = "dgvProperti" : Me.dgvProperti.Location = New System.Drawing.Point(16, 38)
        Me.dgvProperti.Size = New System.Drawing.Size(548, 240)
        Me.dgvProperti.BackgroundColor = System.Drawing.Color.White
        Me.dgvProperti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvProperti.RowHeadersVisible = False : Me.dgvProperti.AllowUserToAddRows = False
        Me.dgvProperti.AllowUserToDeleteRows = False
        Me.dgvProperti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProperti.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvProperti.ColumnHeadersHeight = 30 : Me.dgvProperti.EnableHeadersVisualStyles = False
        Me.dgvProperti.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.dgvProperti.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvProperti.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvProperti.Columns.Add(Me.colCekRusak) : Me.dgvProperti.Columns.Add(Me.colNamaItem)
        Me.dgvProperti.Columns.Add(Me.colBiayaDenda) : Me.dgvProperti.Columns.Add(Me.colKondisiAwal)

        Me.colCekRusak.Name = "colCekRusak" : Me.colCekRusak.HeaderText = "Rusak" : Me.colCekRusak.Width = 55 : Me.colCekRusak.ReadOnly = False
        Me.colNamaItem.Name = "colNamaItem" : Me.colNamaItem.HeaderText = "Nama Properti" : Me.colNamaItem.FillWeight = 200 : Me.colNamaItem.ReadOnly = True
        Me.colBiayaDenda.Name = "colBiayaDenda" : Me.colBiayaDenda.HeaderText = "Biaya Denda (Rp)" : Me.colBiayaDenda.FillWeight = 110 : Me.colBiayaDenda.ReadOnly = True
        Me.colKondisiAwal.Name = "colKondisiAwal" : Me.colKondisiAwal.HeaderText = "Kondisi Awal" : Me.colKondisiAwal.FillWeight = 100 : Me.colKondisiAwal.ReadOnly = True

        ' pnlSummary
        Me.pnlSummary.Name = "pnlSummary" : Me.pnlSummary.Location = New System.Drawing.Point(16, 288)
        Me.pnlSummary.Size = New System.Drawing.Size(548, 120) : Me.pnlSummary.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.pnlSummary.Controls.Add(Me.lblDendaTelat) : Me.pnlSummary.Controls.Add(Me.txtDendaTelat)
        Me.pnlSummary.Controls.Add(Me.lblDendaRusak) : Me.pnlSummary.Controls.Add(Me.txtDendaKerusakan)
        Me.pnlSummary.Controls.Add(Me.lblTotal) : Me.pnlSummary.Controls.Add(Me.txtTotalDenda)

        Me.lblDendaTelat.Name = "lblDendaTelat" : Me.lblDendaTelat.AutoSize = True
        Me.lblDendaTelat.Location = New System.Drawing.Point(12, 12) : Me.lblDendaTelat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDendaTelat.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60) : Me.lblDendaTelat.Text = "Denda Keterlambatan"

        Me.txtDendaTelat.Name = "txtDendaTelat" : Me.txtDendaTelat.Location = New System.Drawing.Point(200, 10)
        Me.txtDendaTelat.Size = New System.Drawing.Size(330, 22) : Me.txtDendaTelat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDendaTelat.ReadOnly = True : Me.txtDendaTelat.BackColor = System.Drawing.Color.FromArgb(240, 240, 240) : Me.txtDendaTelat.Text = "Rp 0"

        Me.lblDendaRusak.Name = "lblDendaRusak" : Me.lblDendaRusak.AutoSize = True
        Me.lblDendaRusak.Location = New System.Drawing.Point(12, 44) : Me.lblDendaRusak.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDendaRusak.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60) : Me.lblDendaRusak.Text = "Denda Kerusakan"

        Me.txtDendaKerusakan.Name = "txtDendaKerusakan" : Me.txtDendaKerusakan.Location = New System.Drawing.Point(200, 42)
        Me.txtDendaKerusakan.Size = New System.Drawing.Size(330, 22) : Me.txtDendaKerusakan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDendaKerusakan.ReadOnly = True : Me.txtDendaKerusakan.BackColor = System.Drawing.Color.FromArgb(240, 240, 240) : Me.txtDendaKerusakan.Text = "Rp 0"

        Me.lblTotal.Name = "lblTotal" : Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(12, 82) : Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27) : Me.lblTotal.Text = "TOTAL DENDA"

        Me.txtTotalDenda.Name = "txtTotalDenda" : Me.txtTotalDenda.Location = New System.Drawing.Point(200, 78)
        Me.txtTotalDenda.Size = New System.Drawing.Size(330, 26) : Me.txtTotalDenda.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalDenda.ReadOnly = True : Me.txtTotalDenda.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
        Me.txtTotalDenda.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27) : Me.txtTotalDenda.Text = "Rp 0"

        Me.btnSimpan.Name = "btnSimpan" : Me.btnSimpan.Text = "Simpan & Tutup"
        Me.btnSimpan.Location = New System.Drawing.Point(16, 422) : Me.btnSimpan.Size = New System.Drawing.Size(548, 34)
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(153, 27, 27) : Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat : Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand : Me.btnSimpan.UseVisualStyleBackColor = False

        Me.btnBatal.Name = "btnBatal" : Me.btnBatal.Text = "Batal"
        Me.btnBatal.Location = New System.Drawing.Point(16, 464) : Me.btnBatal.Size = New System.Drawing.Size(548, 28)
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(220, 220, 220) : Me.btnBatal.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat : Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand : Me.btnBatal.UseVisualStyleBackColor = False

        Me.BackColor = System.Drawing.Color.White : Me.ClientSize = New System.Drawing.Size(580, 576)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False : Me.MinimizeBox = False
        Me.Name = "DendaForm" : Me.Text = "Detail Denda Kerusakan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Controls.Add(Me.pnlHeader) : Me.Controls.Add(Me.pnlBody)

        Me.pnlHeader.ResumeLayout(False) : Me.pnlBody.ResumeLayout(False) : Me.pnlBody.PerformLayout()
        Me.pnlSummary.ResumeLayout(False) : Me.pnlSummary.PerformLayout()
        CType(Me.dgvProperti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents dgvProperti As System.Windows.Forms.DataGridView
    Friend WithEvents colCekRusak As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colNamaItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBiayaDenda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKondisiAwal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlSummary As System.Windows.Forms.Panel
    Friend WithEvents lblDendaTelat As System.Windows.Forms.Label
    Friend WithEvents txtDendaTelat As System.Windows.Forms.TextBox
    Friend WithEvents lblDendaRusak As System.Windows.Forms.Label
    Friend WithEvents txtDendaKerusakan As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotalDenda As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
End Class