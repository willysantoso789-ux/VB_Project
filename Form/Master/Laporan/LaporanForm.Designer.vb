<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LaporanForm
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
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.cboJenis = New System.Windows.Forms.ComboBox()
        Me.lblDari = New System.Windows.Forms.Label()
        Me.dtpDari = New System.Windows.Forms.DateTimePicker()
        Me.lblSampai = New System.Windows.Forms.Label()
        Me.dtpSampai = New System.Windows.Forms.DateTimePicker()
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExportCSV = New System.Windows.Forms.Button()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.dgvLaporan = New System.Windows.Forms.DataGridView()

        Me.pnlHeader.SuspendLayout()
        Me.pnlFilter.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Me.pnlHeader.Name = "pnlHeader" : Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 56 : Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.pnlHeader.Controls.Add(Me.lblTitle) : Me.pnlHeader.Controls.Add(Me.lblSubTitle)

        Me.lblTitle.Name = "lblTitle" : Me.lblTitle.AutoSize = False
        Me.lblTitle.Size = New System.Drawing.Size(600, 28) : Me.lblTitle.Location = New System.Drawing.Point(16, 8)
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White : Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Text = "Laporan"

        Me.lblSubTitle.Name = "lblSubTitle" : Me.lblSubTitle.AutoSize = False
        Me.lblSubTitle.Size = New System.Drawing.Size(600, 18) : Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(180, 200, 240) : Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Text = "Reservasi | Check-In/Out | Pendapatan | Denda | Tamu | Kamar"

        Me.pnlFilter.Name = "pnlFilter" : Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.Location = New System.Drawing.Point(0, 56)
        Me.pnlFilter.Height = 56 : Me.pnlFilter.BackColor = System.Drawing.Color.FromArgb(235, 238, 245)
        Me.pnlFilter.Controls.Add(Me.lblJenis) : Me.pnlFilter.Controls.Add(Me.cboJenis)
        Me.pnlFilter.Controls.Add(Me.lblDari) : Me.pnlFilter.Controls.Add(Me.dtpDari)
        Me.pnlFilter.Controls.Add(Me.lblSampai) : Me.pnlFilter.Controls.Add(Me.dtpSampai)
        Me.pnlFilter.Controls.Add(Me.btnTampilkan) : Me.pnlFilter.Controls.Add(Me.btnRefresh)
        Me.pnlFilter.Controls.Add(Me.btnExportCSV)

        Me.lblJenis.Name = "lblJenis" : Me.lblJenis.AutoSize = True
        Me.lblJenis.Location = New System.Drawing.Point(12, 10) : Me.lblJenis.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblJenis.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60) : Me.lblJenis.Text = "Jenis Laporan"

        Me.cboJenis.Name = "cboJenis" : Me.cboJenis.Location = New System.Drawing.Point(12, 28)
        Me.cboJenis.Size = New System.Drawing.Size(220, 24) : Me.cboJenis.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJenis.Items.AddRange(New Object() {
            "Laporan Reservasi", "Laporan Check-In & Check-Out",
            "Laporan Pendapatan", "Laporan Denda",
            "Laporan Tamu", "Laporan Kamar"})

        Me.lblDari.Name = "lblDari" : Me.lblDari.AutoSize = True
        Me.lblDari.Location = New System.Drawing.Point(244, 10) : Me.lblDari.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblDari.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60) : Me.lblDari.Text = "Dari"

        Me.dtpDari.Name = "dtpDari" : Me.dtpDari.Location = New System.Drawing.Point(244, 28)
        Me.dtpDari.Size = New System.Drawing.Size(130, 22) : Me.dtpDari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDari.Format = System.Windows.Forms.DateTimePickerFormat.Short

        Me.lblSampai.Name = "lblSampai" : Me.lblSampai.AutoSize = True
        Me.lblSampai.Location = New System.Drawing.Point(386, 10) : Me.lblSampai.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSampai.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60) : Me.lblSampai.Text = "Sampai"

        Me.dtpSampai.Name = "dtpSampai" : Me.dtpSampai.Location = New System.Drawing.Point(386, 28)
        Me.dtpSampai.Size = New System.Drawing.Size(130, 22) : Me.dtpSampai.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpSampai.Format = System.Windows.Forms.DateTimePickerFormat.Short

        Me.btnTampilkan.Name = "btnTampilkan" : Me.btnTampilkan.Text = "Tampilkan"
        Me.btnTampilkan.Location = New System.Drawing.Point(530, 24) : Me.btnTampilkan.Size = New System.Drawing.Size(100, 28)
        Me.btnTampilkan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTampilkan.BackColor = System.Drawing.Color.FromArgb(45, 74, 138) : Me.btnTampilkan.ForeColor = System.Drawing.Color.White
        Me.btnTampilkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat : Me.btnTampilkan.FlatAppearance.BorderSize = 0
        Me.btnTampilkan.Cursor = System.Windows.Forms.Cursors.Hand : Me.btnTampilkan.UseVisualStyleBackColor = False

        Me.btnRefresh.Name = "btnRefresh" : Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.Location = New System.Drawing.Point(638, 24) : Me.btnRefresh.Size = New System.Drawing.Size(80, 28)
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(100, 100, 100) : Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat : Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand : Me.btnRefresh.UseVisualStyleBackColor = False

        Me.btnExportCSV.Name = "btnExportCSV" : Me.btnExportCSV.Text = "Export CSV"
        Me.btnExportCSV.Location = New System.Drawing.Point(726, 24) : Me.btnExportCSV.Size = New System.Drawing.Size(100, 28)
        Me.btnExportCSV.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnExportCSV.BackColor = System.Drawing.Color.FromArgb(22, 101, 52) : Me.btnExportCSV.ForeColor = System.Drawing.Color.White
        Me.btnExportCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat : Me.btnExportCSV.FlatAppearance.BorderSize = 0
        Me.btnExportCSV.Cursor = System.Windows.Forms.Cursors.Hand : Me.btnExportCSV.UseVisualStyleBackColor = False

        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Location = New System.Drawing.Point(0, 112)
        Me.pnlBody.Size = New System.Drawing.Size(1100, 560)
        Me.pnlBody.Anchor = System.Windows.Forms.AnchorStyles.Top Or
                           System.Windows.Forms.AnchorStyles.Bottom Or
                           System.Windows.Forms.AnchorStyles.Left Or
                           System.Windows.Forms.AnchorStyles.Right
        Me.pnlBody.BackColor = System.Drawing.Color.White
        Me.pnlBody.Controls.Add(Me.lblInfo)
        Me.pnlBody.Controls.Add(Me.dgvLaporan)

        Me.lblInfo.Name = "lblInfo" : Me.lblInfo.AutoSize = False
        Me.lblInfo.Size = New System.Drawing.Size(1060, 20) : Me.lblInfo.Location = New System.Drawing.Point(12, 8)
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblInfo.ForeColor = System.Drawing.Color.FromArgb(45, 74, 138) : Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Text = "Pilih jenis laporan dan klik Tampilkan"

        Me.dgvLaporan.Name = "dgvLaporan"
        Me.dgvLaporan.Location = New System.Drawing.Point(12, 32)
        Me.dgvLaporan.Size = New System.Drawing.Size(1076, 516)
        Me.dgvLaporan.Anchor = System.Windows.Forms.AnchorStyles.Top Or
                              System.Windows.Forms.AnchorStyles.Bottom Or
                              System.Windows.Forms.AnchorStyles.Left Or
                              System.Windows.Forms.AnchorStyles.Right
        Me.dgvLaporan.BackgroundColor = System.Drawing.Color.White
        Me.dgvLaporan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvLaporan.RowHeadersVisible = False
        Me.dgvLaporan.AllowUserToAddRows = False : Me.dgvLaporan.AllowUserToDeleteRows = False
        Me.dgvLaporan.ReadOnly = True
        Me.dgvLaporan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLaporan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvLaporan.ColumnHeadersHeight = 32
        Me.dgvLaporan.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(235, 238, 245)

        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 672)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "LaporanForm" : Me.Text = "Laporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.Controls.Add(Me.pnlBody) : Me.Controls.Add(Me.pnlFilter) : Me.Controls.Add(Me.pnlHeader)

        Me.pnlHeader.ResumeLayout(False) : Me.pnlFilter.ResumeLayout(False) : Me.pnlFilter.PerformLayout()
        Me.pnlBody.ResumeLayout(False) : Me.pnlBody.PerformLayout()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlFilter As System.Windows.Forms.Panel
    Friend WithEvents lblJenis As System.Windows.Forms.Label
    Friend WithEvents cboJenis As System.Windows.Forms.ComboBox
    Friend WithEvents lblDari As System.Windows.Forms.Label
    Friend WithEvents dtpDari As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSampai As System.Windows.Forms.Label
    Friend WithEvents dtpSampai As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnTampilkan As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnExportCSV As System.Windows.Forms.Button
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents dgvLaporan As System.Windows.Forms.DataGridView
End Class