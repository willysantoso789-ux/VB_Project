<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LaporanForm
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
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblJenisLaporan = New System.Windows.Forms.Label()
        Me.cboJenis = New System.Windows.Forms.ComboBox()
        Me.lblPeriodeTitle = New System.Windows.Forms.Label()
        Me.dtpDari = New System.Windows.Forms.DateTimePicker()
        Me.lblSampai = New System.Windows.Forms.Label()
        Me.dtpSampai = New System.Windows.Forms.DateTimePicker()
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.btnExportPdf = New System.Windows.Forms.Button()
        Me.btnExportCsv = New System.Windows.Forms.Button()
        Me.pnlSummary = New System.Windows.Forms.Panel()
        Me.lblSum1Title = New System.Windows.Forms.Label()
        Me.lblSum1Val = New System.Windows.Forms.Label()
        Me.lblSum2Title = New System.Windows.Forms.Label()
        Me.lblSum2Val = New System.Windows.Forms.Label()
        Me.lblSum3Title = New System.Windows.Forms.Label()
        Me.lblSum3Val = New System.Windows.Forms.Label()
        Me.lblSum4Title = New System.Windows.Forms.Label()
        Me.lblSum4Val = New System.Windows.Forms.Label()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.lblGridTitle = New System.Windows.Forms.Label()
        Me.lblGridSub = New System.Windows.Forms.Label()
        Me.dgvLaporan = New System.Windows.Forms.DataGridView()

        Me.pnlHeader.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlSummary.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '
        'pnlHeader
        '
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 56
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubTitle)

        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.AutoSize = False
        Me.lblTitle.Size = New System.Drawing.Size(600, 28)
        Me.lblTitle.Location = New System.Drawing.Point(16, 8)
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Text = "Laporan"

        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.AutoSize = False
        Me.lblSubTitle.Size = New System.Drawing.Size(600, 18)
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(180, 200, 240)
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Text = "Rekap data dan laporan operasional hotel"

        '
        'pnlTop — filter bar
        '
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Location = New System.Drawing.Point(0, 56)
        Me.pnlTop.Size = New System.Drawing.Size(980, 60)
        Me.pnlTop.BackColor = System.Drawing.Color.White
        Me.pnlTop.Anchor = System.Windows.Forms.AnchorStyles.Top Or
                              System.Windows.Forms.AnchorStyles.Left Or
                              System.Windows.Forms.AnchorStyles.Right
        Me.pnlTop.Controls.Add(Me.lblJenisLaporan)
        Me.pnlTop.Controls.Add(Me.cboJenis)
        Me.pnlTop.Controls.Add(Me.lblPeriodeTitle)
        Me.pnlTop.Controls.Add(Me.dtpDari)
        Me.pnlTop.Controls.Add(Me.lblSampai)
        Me.pnlTop.Controls.Add(Me.dtpSampai)
        Me.pnlTop.Controls.Add(Me.btnTampilkan)
        Me.pnlTop.Controls.Add(Me.btnExportPdf)
        Me.pnlTop.Controls.Add(Me.btnExportCsv)

        Me.lblJenisLaporan.Name = "lblJenisLaporan"
        Me.lblJenisLaporan.AutoSize = True
        Me.lblJenisLaporan.Location = New System.Drawing.Point(12, 10)
        Me.lblJenisLaporan.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblJenisLaporan.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblJenisLaporan.Text = "Jenis Laporan"

        Me.cboJenis.Name = "cboJenis"
        Me.cboJenis.Location = New System.Drawing.Point(12, 30)
        Me.cboJenis.Size = New System.Drawing.Size(210, 24)
        Me.cboJenis.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJenis.Items.AddRange(New Object() {
            "Laporan Reservasi",
            "Laporan Check-In & Check-Out",
            "Laporan Pendapatan",
            "Laporan Denda",
            "Laporan Tamu",
            "Laporan Kamar"
        })

        Me.lblPeriodeTitle.Name = "lblPeriodeTitle"
        Me.lblPeriodeTitle.AutoSize = True
        Me.lblPeriodeTitle.Location = New System.Drawing.Point(234, 10)
        Me.lblPeriodeTitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblPeriodeTitle.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblPeriodeTitle.Text = "Dari"

        Me.dtpDari.Name = "dtpDari"
        Me.dtpDari.Location = New System.Drawing.Point(234, 30)
        Me.dtpDari.Size = New System.Drawing.Size(130, 24)
        Me.dtpDari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpDari.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDari.Value = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)

        Me.lblSampai.Name = "lblSampai"
        Me.lblSampai.AutoSize = True
        Me.lblSampai.Location = New System.Drawing.Point(376, 10)
        Me.lblSampai.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblSampai.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblSampai.Text = "Sampai"

        Me.dtpSampai.Name = "dtpSampai"
        Me.dtpSampai.Location = New System.Drawing.Point(376, 30)
        Me.dtpSampai.Size = New System.Drawing.Size(130, 24)
        Me.dtpSampai.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpSampai.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpSampai.Value = DateTime.Today

        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Text = "Tampilkan"
        Me.btnTampilkan.Location = New System.Drawing.Point(520, 28)
        Me.btnTampilkan.Size = New System.Drawing.Size(100, 28)
        Me.btnTampilkan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTampilkan.BackColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.btnTampilkan.ForeColor = System.Drawing.Color.White
        Me.btnTampilkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTampilkan.FlatAppearance.BorderSize = 0
        Me.btnTampilkan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTampilkan.UseVisualStyleBackColor = False

        Me.btnExportPdf.Name = "btnExportPdf"
        Me.btnExportPdf.Text = "Export PDF"
        Me.btnExportPdf.Location = New System.Drawing.Point(632, 28)
        Me.btnExportPdf.Size = New System.Drawing.Size(100, 28)
        Me.btnExportPdf.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnExportPdf.BackColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.btnExportPdf.ForeColor = System.Drawing.Color.White
        Me.btnExportPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportPdf.FlatAppearance.BorderSize = 0
        Me.btnExportPdf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportPdf.Enabled = False
        Me.btnExportPdf.UseVisualStyleBackColor = False

        Me.btnExportCsv.Name = "btnExportCsv"
        Me.btnExportCsv.Text = "Export CSV"
        Me.btnExportCsv.Location = New System.Drawing.Point(744, 28)
        Me.btnExportCsv.Size = New System.Drawing.Size(100, 28)
        Me.btnExportCsv.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnExportCsv.BackColor = System.Drawing.Color.FromArgb(22, 101, 52)
        Me.btnExportCsv.ForeColor = System.Drawing.Color.White
        Me.btnExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportCsv.FlatAppearance.BorderSize = 0
        Me.btnExportCsv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportCsv.Enabled = False
        Me.btnExportCsv.UseVisualStyleBackColor = False

        '
        'pnlSummary — 4 summary cards
        '
        Me.pnlSummary.Name = "pnlSummary"
        Me.pnlSummary.Location = New System.Drawing.Point(0, 116)
        Me.pnlSummary.Size = New System.Drawing.Size(980, 80)
        Me.pnlSummary.BackColor = System.Drawing.Color.FromArgb(235, 238, 245)
        Me.pnlSummary.Anchor = System.Windows.Forms.AnchorStyles.Top Or
                                  System.Windows.Forms.AnchorStyles.Left Or
                                  System.Windows.Forms.AnchorStyles.Right
        Me.pnlSummary.Controls.Add(Me.lblSum1Title)
        Me.pnlSummary.Controls.Add(Me.lblSum1Val)
        Me.pnlSummary.Controls.Add(Me.lblSum2Title)
        Me.pnlSummary.Controls.Add(Me.lblSum2Val)
        Me.pnlSummary.Controls.Add(Me.lblSum3Title)
        Me.pnlSummary.Controls.Add(Me.lblSum3Val)
        Me.pnlSummary.Controls.Add(Me.lblSum4Title)
        Me.pnlSummary.Controls.Add(Me.lblSum4Val)

        ' Card 1
        Me.lblSum1Title.Name = "lblSum1Title"
        Me.lblSum1Title.AutoSize = False
        Me.lblSum1Title.Size = New System.Drawing.Size(200, 18)
        Me.lblSum1Title.Location = New System.Drawing.Point(16, 10)
        Me.lblSum1Title.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSum1Title.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Me.lblSum1Title.BackColor = System.Drawing.Color.Transparent
        Me.lblSum1Title.Text = "—"

        Me.lblSum1Val.Name = "lblSum1Val"
        Me.lblSum1Val.AutoSize = False
        Me.lblSum1Val.Size = New System.Drawing.Size(200, 30)
        Me.lblSum1Val.Location = New System.Drawing.Point(16, 30)
        Me.lblSum1Val.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblSum1Val.ForeColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.lblSum1Val.BackColor = System.Drawing.Color.Transparent
        Me.lblSum1Val.Text = "—"

        ' Card 2
        Me.lblSum2Title.Name = "lblSum2Title"
        Me.lblSum2Title.AutoSize = False
        Me.lblSum2Title.Size = New System.Drawing.Size(200, 18)
        Me.lblSum2Title.Location = New System.Drawing.Point(256, 10)
        Me.lblSum2Title.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSum2Title.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Me.lblSum2Title.BackColor = System.Drawing.Color.Transparent
        Me.lblSum2Title.Text = "—"

        Me.lblSum2Val.Name = "lblSum2Val"
        Me.lblSum2Val.AutoSize = False
        Me.lblSum2Val.Size = New System.Drawing.Size(200, 30)
        Me.lblSum2Val.Location = New System.Drawing.Point(256, 30)
        Me.lblSum2Val.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblSum2Val.ForeColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.lblSum2Val.BackColor = System.Drawing.Color.Transparent
        Me.lblSum2Val.Text = "—"

        ' Card 3
        Me.lblSum3Title.Name = "lblSum3Title"
        Me.lblSum3Title.AutoSize = False
        Me.lblSum3Title.Size = New System.Drawing.Size(200, 18)
        Me.lblSum3Title.Location = New System.Drawing.Point(496, 10)
        Me.lblSum3Title.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSum3Title.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Me.lblSum3Title.BackColor = System.Drawing.Color.Transparent
        Me.lblSum3Title.Text = "—"

        Me.lblSum3Val.Name = "lblSum3Val"
        Me.lblSum3Val.AutoSize = False
        Me.lblSum3Val.Size = New System.Drawing.Size(200, 30)
        Me.lblSum3Val.Location = New System.Drawing.Point(496, 30)
        Me.lblSum3Val.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblSum3Val.ForeColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.lblSum3Val.BackColor = System.Drawing.Color.Transparent
        Me.lblSum3Val.Text = "—"

        ' Card 4
        Me.lblSum4Title.Name = "lblSum4Title"
        Me.lblSum4Title.AutoSize = False
        Me.lblSum4Title.Size = New System.Drawing.Size(200, 18)
        Me.lblSum4Title.Location = New System.Drawing.Point(736, 10)
        Me.lblSum4Title.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSum4Title.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Me.lblSum4Title.BackColor = System.Drawing.Color.Transparent
        Me.lblSum4Title.Text = "—"

        Me.lblSum4Val.Name = "lblSum4Val"
        Me.lblSum4Val.AutoSize = False
        Me.lblSum4Val.Size = New System.Drawing.Size(200, 30)
        Me.lblSum4Val.Location = New System.Drawing.Point(736, 30)
        Me.lblSum4Val.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblSum4Val.ForeColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.lblSum4Val.BackColor = System.Drawing.Color.Transparent
        Me.lblSum4Val.Text = "—"

        '
        'pnlGrid
        '
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Location = New System.Drawing.Point(0, 196)
        Me.pnlGrid.Size = New System.Drawing.Size(980, 460)
        Me.pnlGrid.BackColor = System.Drawing.Color.White
        Me.pnlGrid.Anchor = System.Windows.Forms.AnchorStyles.Top Or
                               System.Windows.Forms.AnchorStyles.Bottom Or
                               System.Windows.Forms.AnchorStyles.Left Or
                               System.Windows.Forms.AnchorStyles.Right
        Me.pnlGrid.Controls.Add(Me.lblGridTitle)
        Me.pnlGrid.Controls.Add(Me.lblGridSub)
        Me.pnlGrid.Controls.Add(Me.dgvLaporan)

        Me.lblGridTitle.Name = "lblGridTitle"
        Me.lblGridTitle.AutoSize = False
        Me.lblGridTitle.Size = New System.Drawing.Size(500, 24)
        Me.lblGridTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblGridTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.lblGridTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGridTitle.Text = "Pilih jenis laporan dan klik Tampilkan"

        Me.lblGridSub.Name = "lblGridSub"
        Me.lblGridSub.AutoSize = False
        Me.lblGridSub.Size = New System.Drawing.Size(700, 18)
        Me.lblGridSub.Location = New System.Drawing.Point(12, 38)
        Me.lblGridSub.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblGridSub.ForeColor = System.Drawing.Color.FromArgb(130, 130, 130)
        Me.lblGridSub.BackColor = System.Drawing.Color.Transparent
        Me.lblGridSub.Text = ""

        Me.dgvLaporan.Name = "dgvLaporan"
        Me.dgvLaporan.Location = New System.Drawing.Point(12, 64)
        Me.dgvLaporan.Size = New System.Drawing.Size(954, 384)
        Me.dgvLaporan.Anchor = System.Windows.Forms.AnchorStyles.Top Or
                                          System.Windows.Forms.AnchorStyles.Bottom Or
                                          System.Windows.Forms.AnchorStyles.Left Or
                                          System.Windows.Forms.AnchorStyles.Right
        Me.dgvLaporan.BackgroundColor = System.Drawing.Color.White
        Me.dgvLaporan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvLaporan.RowHeadersVisible = False
        Me.dgvLaporan.AllowUserToAddRows = False
        Me.dgvLaporan.AllowUserToDeleteRows = False
        Me.dgvLaporan.ReadOnly = True
        Me.dgvLaporan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLaporan.MultiSelect = False
        Me.dgvLaporan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLaporan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvLaporan.ColumnHeadersHeight = 32
        Me.dgvLaporan.EnableHeadersVisualStyles = False
        Me.dgvLaporan.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.dgvLaporan.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvLaporan.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvLaporan.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(235, 238, 245)
        Me.dgvLaporan.TabIndex = 0

        '
        'LaporanForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.ClientSize = New System.Drawing.Size(980, 656)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "LaporanForm"
        Me.Text = "Laporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlSummary)
        Me.Controls.Add(Me.pnlGrid)

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlSummary.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblJenisLaporan As System.Windows.Forms.Label
    Friend WithEvents cboJenis As System.Windows.Forms.ComboBox
    Friend WithEvents lblPeriodeTitle As System.Windows.Forms.Label
    Friend WithEvents dtpDari As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSampai As System.Windows.Forms.Label
    Friend WithEvents dtpSampai As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnTampilkan As System.Windows.Forms.Button
    Friend WithEvents btnExportPdf As System.Windows.Forms.Button
    Friend WithEvents btnExportCsv As System.Windows.Forms.Button
    Friend WithEvents pnlSummary As System.Windows.Forms.Panel
    Friend WithEvents lblSum1Title As System.Windows.Forms.Label
    Friend WithEvents lblSum1Val As System.Windows.Forms.Label
    Friend WithEvents lblSum2Title As System.Windows.Forms.Label
    Friend WithEvents lblSum2Val As System.Windows.Forms.Label
    Friend WithEvents lblSum3Title As System.Windows.Forms.Label
    Friend WithEvents lblSum3Val As System.Windows.Forms.Label
    Friend WithEvents lblSum4Title As System.Windows.Forms.Label
    Friend WithEvents lblSum4Val As System.Windows.Forms.Label
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents lblGridTitle As System.Windows.Forms.Label
    Friend WithEvents lblGridSub As System.Windows.Forms.Label
    Friend WithEvents dgvLaporan As System.Windows.Forms.DataGridView

End Class