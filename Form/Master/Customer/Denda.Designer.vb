<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Denda
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
        Me.lblIdRes = New System.Windows.Forms.Label()
        Me.txtIdRes = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblKamar = New System.Windows.Forms.Label()
        Me.txtKamar = New System.Windows.Forms.TextBox()
        Me.pnlDiv1 = New System.Windows.Forms.Panel()
        Me.lblTelatTitle = New System.Windows.Forms.Label()
        Me.lblHariTelat = New System.Windows.Forms.Label()
        Me.txtHariTelat = New System.Windows.Forms.TextBox()
        Me.lblDendaPerHari = New System.Windows.Forms.Label()
        Me.txtDendaPerHari = New System.Windows.Forms.TextBox()
        Me.lblTotalTelat = New System.Windows.Forms.Label()
        Me.txtTotalTelat = New System.Windows.Forms.TextBox()
        Me.pnlDiv2 = New System.Windows.Forms.Panel()
        Me.lblKerusakanTitle = New System.Windows.Forms.Label()
        Me.lblKerusakanNote = New System.Windows.Forms.Label()
        Me.dgvProperti = New System.Windows.Forms.DataGridView()
        Me.colCek = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colNamaItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKondisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBiayaDenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTotalKerusakan = New System.Windows.Forms.Label()
        Me.txtTotalKerusakan = New System.Windows.Forms.TextBox()
        Me.pnlDiv3 = New System.Windows.Forms.Panel()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()

        Me.pnlHeader.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        CType(Me.dgvProperti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '
        'pnlHeader
        '
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 56
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubTitle)

        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.AutoSize = False
        Me.lblTitle.Size = New System.Drawing.Size(460, 28)
        Me.lblTitle.Location = New System.Drawing.Point(16, 8)
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Text = "Detail Denda"

        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.AutoSize = False
        Me.lblSubTitle.Size = New System.Drawing.Size(460, 18)
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(254, 202, 202)
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Text = "Keterlambatan & kerusakan properti kamar"

        '
        'pnlBody
        '
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Location = New System.Drawing.Point(0, 56)
        Me.pnlBody.Size = New System.Drawing.Size(500, 760)
        Me.pnlBody.BackColor = System.Drawing.Color.White
        Me.pnlBody.AutoScroll = True
        Me.pnlBody.Controls.Add(Me.lblInfoTitle)
        Me.pnlBody.Controls.Add(Me.lblIdRes)
        Me.pnlBody.Controls.Add(Me.txtIdRes)
        Me.pnlBody.Controls.Add(Me.lblNama)
        Me.pnlBody.Controls.Add(Me.txtNama)
        Me.pnlBody.Controls.Add(Me.lblKamar)
        Me.pnlBody.Controls.Add(Me.txtKamar)
        Me.pnlBody.Controls.Add(Me.pnlDiv1)
        Me.pnlBody.Controls.Add(Me.lblTelatTitle)
        Me.pnlBody.Controls.Add(Me.lblHariTelat)
        Me.pnlBody.Controls.Add(Me.txtHariTelat)
        Me.pnlBody.Controls.Add(Me.lblDendaPerHari)
        Me.pnlBody.Controls.Add(Me.txtDendaPerHari)
        Me.pnlBody.Controls.Add(Me.lblTotalTelat)
        Me.pnlBody.Controls.Add(Me.txtTotalTelat)
        Me.pnlBody.Controls.Add(Me.pnlDiv2)
        Me.pnlBody.Controls.Add(Me.lblKerusakanTitle)
        Me.pnlBody.Controls.Add(Me.lblKerusakanNote)
        Me.pnlBody.Controls.Add(Me.dgvProperti)
        Me.pnlBody.Controls.Add(Me.lblTotalKerusakan)
        Me.pnlBody.Controls.Add(Me.txtTotalKerusakan)
        Me.pnlBody.Controls.Add(Me.pnlDiv3)
        Me.pnlBody.Controls.Add(Me.lblGrandTotal)
        Me.pnlBody.Controls.Add(Me.txtGrandTotal)
        Me.pnlBody.Controls.Add(Me.btnSimpan)
        Me.pnlBody.Controls.Add(Me.btnTutup)

        '── Info section ──
        Me.lblInfoTitle.Name = "lblInfoTitle"
        Me.lblInfoTitle.AutoSize = False
        Me.lblInfoTitle.Size = New System.Drawing.Size(460, 18)
        Me.lblInfoTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblInfoTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblInfoTitle.ForeColor = System.Drawing.Color.FromArgb(130, 130, 130)
        Me.lblInfoTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblInfoTitle.Text = "INFO RESERVASI"

        Me.lblIdRes.Name = "lblIdRes"
        Me.lblIdRes.AutoSize = True
        Me.lblIdRes.Location = New System.Drawing.Point(16, 38)
        Me.lblIdRes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblIdRes.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblIdRes.Text = "ID Reservasi"

        Me.txtIdRes.Name = "txtIdRes"
        Me.txtIdRes.Location = New System.Drawing.Point(16, 56)
        Me.txtIdRes.Size = New System.Drawing.Size(460, 24)
        Me.txtIdRes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtIdRes.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtIdRes.ReadOnly = True

        Me.lblNama.Name = "lblNama"
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(16, 90)
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNama.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblNama.Text = "Nama Tamu"

        Me.txtNama.Name = "txtNama"
        Me.txtNama.Location = New System.Drawing.Point(16, 108)
        Me.txtNama.Size = New System.Drawing.Size(460, 24)
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNama.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtNama.ReadOnly = True

        Me.lblKamar.Name = "lblKamar"
        Me.lblKamar.AutoSize = True
        Me.lblKamar.Location = New System.Drawing.Point(16, 142)
        Me.lblKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblKamar.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblKamar.Text = "Kamar"

        Me.txtKamar.Name = "txtKamar"
        Me.txtKamar.Location = New System.Drawing.Point(16, 160)
        Me.txtKamar.Size = New System.Drawing.Size(460, 24)
        Me.txtKamar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtKamar.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtKamar.ReadOnly = True

        '── Divider 1 ──
        Me.pnlDiv1.Name = "pnlDiv1"
        Me.pnlDiv1.Location = New System.Drawing.Point(16, 196)
        Me.pnlDiv1.Size = New System.Drawing.Size(460, 1)
        Me.pnlDiv1.BackColor = System.Drawing.Color.FromArgb(210, 215, 225)

        '── Denda telat section ──
        Me.lblTelatTitle.Name = "lblTelatTitle"
        Me.lblTelatTitle.AutoSize = False
        Me.lblTelatTitle.Size = New System.Drawing.Size(460, 18)
        Me.lblTelatTitle.Location = New System.Drawing.Point(16, 206)
        Me.lblTelatTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblTelatTitle.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.lblTelatTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTelatTitle.Text = "DENDA KETERLAMBATAN"

        Me.lblHariTelat.Name = "lblHariTelat"
        Me.lblHariTelat.AutoSize = True
        Me.lblHariTelat.Location = New System.Drawing.Point(16, 230)
        Me.lblHariTelat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblHariTelat.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblHariTelat.Text = "Hari Terlambat"

        Me.txtHariTelat.Name = "txtHariTelat"
        Me.txtHariTelat.Location = New System.Drawing.Point(16, 248)
        Me.txtHariTelat.Size = New System.Drawing.Size(460, 24)
        Me.txtHariTelat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtHariTelat.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtHariTelat.ReadOnly = True

        Me.lblDendaPerHari.Name = "lblDendaPerHari"
        Me.lblDendaPerHari.AutoSize = True
        Me.lblDendaPerHari.Location = New System.Drawing.Point(16, 282)
        Me.lblDendaPerHari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDendaPerHari.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblDendaPerHari.Text = "Denda Per Hari (50% harga kamar)"

        Me.txtDendaPerHari.Name = "txtDendaPerHari"
        Me.txtDendaPerHari.Location = New System.Drawing.Point(16, 300)
        Me.txtDendaPerHari.Size = New System.Drawing.Size(460, 24)
        Me.txtDendaPerHari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDendaPerHari.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.txtDendaPerHari.ReadOnly = True

        Me.lblTotalTelat.Name = "lblTotalTelat"
        Me.lblTotalTelat.AutoSize = True
        Me.lblTotalTelat.Location = New System.Drawing.Point(16, 334)
        Me.lblTotalTelat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalTelat.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.lblTotalTelat.Text = "Total Denda Keterlambatan"

        Me.txtTotalTelat.Name = "txtTotalTelat"
        Me.txtTotalTelat.Location = New System.Drawing.Point(16, 352)
        Me.txtTotalTelat.Size = New System.Drawing.Size(460, 24)
        Me.txtTotalTelat.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.txtTotalTelat.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
        Me.txtTotalTelat.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.txtTotalTelat.ReadOnly = True
        Me.txtTotalTelat.Text = "Rp 0"

        '── Divider 2 ──
        Me.pnlDiv2.Name = "pnlDiv2"
        Me.pnlDiv2.Location = New System.Drawing.Point(16, 390)
        Me.pnlDiv2.Size = New System.Drawing.Size(460, 1)
        Me.pnlDiv2.BackColor = System.Drawing.Color.FromArgb(210, 215, 225)

        '── Kerusakan section ──
        Me.lblKerusakanTitle.Name = "lblKerusakanTitle"
        Me.lblKerusakanTitle.AutoSize = False
        Me.lblKerusakanTitle.Size = New System.Drawing.Size(460, 18)
        Me.lblKerusakanTitle.Location = New System.Drawing.Point(16, 400)
        Me.lblKerusakanTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblKerusakanTitle.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.lblKerusakanTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblKerusakanTitle.Text = "DENDA KERUSAKAN PROPERTI"

        Me.lblKerusakanNote.Name = "lblKerusakanNote"
        Me.lblKerusakanNote.AutoSize = False
        Me.lblKerusakanNote.Size = New System.Drawing.Size(460, 18)
        Me.lblKerusakanNote.Location = New System.Drawing.Point(16, 420)
        Me.lblKerusakanNote.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblKerusakanNote.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Me.lblKerusakanNote.BackColor = System.Drawing.Color.Transparent
        Me.lblKerusakanNote.Text = "Centang properti yang rusak — biaya denda otomatis terhitung"

        '── DataGridView properti checklist ──
        Me.dgvProperti.Name = "dgvProperti"
        Me.dgvProperti.Location = New System.Drawing.Point(16, 444)
        Me.dgvProperti.Size = New System.Drawing.Size(460, 200)
        Me.dgvProperti.BackgroundColor = System.Drawing.Color.White
        Me.dgvProperti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvProperti.RowHeadersVisible = False
        Me.dgvProperti.AllowUserToAddRows = False
        Me.dgvProperti.AllowUserToDeleteRows = False
        Me.dgvProperti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProperti.MultiSelect = False
        Me.dgvProperti.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvProperti.ColumnHeadersHeight = 28
        Me.dgvProperti.EnableHeadersVisualStyles = False
        Me.dgvProperti.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.dgvProperti.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvProperti.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvProperti.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 241, 242)
        Me.dgvProperti.Columns.Add(Me.colCek)
        Me.dgvProperti.Columns.Add(Me.colNamaItem)
        Me.dgvProperti.Columns.Add(Me.colKondisi)
        Me.dgvProperti.Columns.Add(Me.colBiayaDenda)

        Me.colCek.Name = "colCek"
        Me.colCek.HeaderText = "Rusak"
        Me.colCek.Width = 50
        Me.colCek.ReadOnly = False

        Me.colNamaItem.Name = "colNamaItem"
        Me.colNamaItem.HeaderText = "Nama Properti"
        Me.colNamaItem.FillWeight = 160
        Me.colNamaItem.ReadOnly = True

        Me.colKondisi.Name = "colKondisi"
        Me.colKondisi.HeaderText = "Kondisi"
        Me.colKondisi.FillWeight = 120
        Me.colKondisi.ReadOnly = True

        Me.colBiayaDenda.Name = "colBiayaDenda"
        Me.colBiayaDenda.HeaderText = "Biaya Denda (Rp)"
        Me.colBiayaDenda.FillWeight = 120
        Me.colBiayaDenda.ReadOnly = True

        Me.lblTotalKerusakan.Name = "lblTotalKerusakan"
        Me.lblTotalKerusakan.AutoSize = True
        Me.lblTotalKerusakan.Location = New System.Drawing.Point(16, 654)
        Me.lblTotalKerusakan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTotalKerusakan.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.lblTotalKerusakan.Text = "Total Denda Kerusakan"

        Me.txtTotalKerusakan.Name = "txtTotalKerusakan"
        Me.txtTotalKerusakan.Location = New System.Drawing.Point(16, 672)
        Me.txtTotalKerusakan.Size = New System.Drawing.Size(460, 24)
        Me.txtTotalKerusakan.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.txtTotalKerusakan.BackColor = System.Drawing.Color.FromArgb(209, 250, 229)
        Me.txtTotalKerusakan.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70)
        Me.txtTotalKerusakan.ReadOnly = True
        Me.txtTotalKerusakan.Text = "Rp 0"

        '── Divider 3 ──
        Me.pnlDiv3.Name = "pnlDiv3"
        Me.pnlDiv3.Location = New System.Drawing.Point(16, 708)
        Me.pnlDiv3.Size = New System.Drawing.Size(460, 1)
        Me.pnlDiv3.BackColor = System.Drawing.Color.FromArgb(210, 215, 225)

        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Location = New System.Drawing.Point(16, 718)
        Me.lblGrandTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblGrandTotal.Text = "TOTAL DENDA KESELURUHAN"

        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.Location = New System.Drawing.Point(16, 736)
        Me.txtGrandTotal.Size = New System.Drawing.Size(460, 28)
        Me.txtGrandTotal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtGrandTotal.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
        Me.txtGrandTotal.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.txtGrandTotal.ReadOnly = True
        Me.txtGrandTotal.Text = "Rp 0"

        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Text = "Simpan & Terapkan Denda"
        Me.btnSimpan.Location = New System.Drawing.Point(16, 776)
        Me.btnSimpan.Size = New System.Drawing.Size(460, 34)
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.UseVisualStyleBackColor = False

        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.Location = New System.Drawing.Point(16, 818)
        Me.btnTutup.Size = New System.Drawing.Size(460, 30)
        Me.btnTutup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTutup.BackColor = System.Drawing.Color.FromArgb(220, 220, 220)
        Me.btnTutup.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTutup.FlatAppearance.BorderSize = 0
        Me.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTutup.UseVisualStyleBackColor = False

        '
        'DendaForm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(500, 848)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DendaForm"
        Me.Text = "Detail Denda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlBody)

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBody.PerformLayout()
        CType(Me.dgvProperti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents lblInfoTitle As System.Windows.Forms.Label
    Friend WithEvents lblIdRes As System.Windows.Forms.Label
    Friend WithEvents txtIdRes As System.Windows.Forms.TextBox
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblKamar As System.Windows.Forms.Label
    Friend WithEvents txtKamar As System.Windows.Forms.TextBox
    Friend WithEvents pnlDiv1 As System.Windows.Forms.Panel
    Friend WithEvents lblTelatTitle As System.Windows.Forms.Label
    Friend WithEvents lblHariTelat As System.Windows.Forms.Label
    Friend WithEvents txtHariTelat As System.Windows.Forms.TextBox
    Friend WithEvents lblDendaPerHari As System.Windows.Forms.Label
    Friend WithEvents txtDendaPerHari As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalTelat As System.Windows.Forms.Label
    Friend WithEvents txtTotalTelat As System.Windows.Forms.TextBox
    Friend WithEvents pnlDiv2 As System.Windows.Forms.Panel
    Friend WithEvents lblKerusakanTitle As System.Windows.Forms.Label
    Friend WithEvents lblKerusakanNote As System.Windows.Forms.Label
    Friend WithEvents dgvProperti As System.Windows.Forms.DataGridView
    Friend WithEvents colCek As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colNamaItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKondisi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBiayaDenda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTotalKerusakan As System.Windows.Forms.Label
    Friend WithEvents txtTotalKerusakan As System.Windows.Forms.TextBox
    Friend WithEvents pnlDiv3 As System.Windows.Forms.Panel
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button

End Class