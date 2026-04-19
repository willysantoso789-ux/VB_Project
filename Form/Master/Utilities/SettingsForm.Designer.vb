<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
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

        ' Preferensi UI
        Me.lblPrefTitle = New System.Windows.Forms.Label()
        Me.lblBahasa = New System.Windows.Forms.Label()
        Me.cboBahasa = New System.Windows.Forms.ComboBox()
        Me.lblTema = New System.Windows.Forms.Label()
        Me.cboTema = New System.Windows.Forms.ComboBox()
        Me.chkShowClock = New System.Windows.Forms.CheckBox()
        Me.chkConfirmLogout = New System.Windows.Forms.CheckBox()
        Me.chkConfirmHapus = New System.Windows.Forms.CheckBox()

        ' Preferensi laporan
        Me.pnlDiv1 = New System.Windows.Forms.Panel()
        Me.lblLapTitle = New System.Windows.Forms.Label()
        Me.lblNamaHotel = New System.Windows.Forms.Label()
        Me.txtNamaHotel = New System.Windows.Forms.TextBox()
        Me.lblAlamatHotel = New System.Windows.Forms.Label()
        Me.txtAlamatHotel = New System.Windows.Forms.TextBox()
        Me.lblTelpHotel = New System.Windows.Forms.Label()
        Me.txtTelpHotel = New System.Windows.Forms.TextBox()

        ' Preferensi denda
        Me.pnlDiv2 = New System.Windows.Forms.Panel()
        Me.lblDendaTitle = New System.Windows.Forms.Label()
        Me.lblDendaPersen = New System.Windows.Forms.Label()
        Me.nudDendaPersen = New System.Windows.Forms.NumericUpDown()
        Me.lblDendaNote = New System.Windows.Forms.Label()

        ' Database (placeholder)
        Me.pnlDiv3 = New System.Windows.Forms.Panel()
        Me.lblDbTitle = New System.Windows.Forms.Label()
        Me.lblDbServer = New System.Windows.Forms.Label()
        Me.txtDbServer = New System.Windows.Forms.TextBox()
        Me.lblDbName = New System.Windows.Forms.Label()
        Me.txtDbName = New System.Windows.Forms.TextBox()
        Me.btnTestConn = New System.Windows.Forms.Button()

        ' Tombol
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()

        Me.pnlHeader.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        CType(Me.nudDendaPersen, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Size = New System.Drawing.Size(500, 28)
        Me.lblTitle.Location = New System.Drawing.Point(16, 8)
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Text = "Settings"

        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.AutoSize = False
        Me.lblSubTitle.Size = New System.Drawing.Size(500, 18)
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 34)
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(180, 200, 240)
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.Text = "Preferensi aplikasi dan konfigurasi sistem"

        '
        'pnlBody
        '
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Location = New System.Drawing.Point(0, 56)
        Me.pnlBody.Size = New System.Drawing.Size(540, 700)
        Me.pnlBody.BackColor = System.Drawing.Color.White
        Me.pnlBody.AutoScroll = True
        Me.pnlBody.Controls.Add(Me.lblPrefTitle)
        Me.pnlBody.Controls.Add(Me.lblBahasa)
        Me.pnlBody.Controls.Add(Me.cboBahasa)
        Me.pnlBody.Controls.Add(Me.lblTema)
        Me.pnlBody.Controls.Add(Me.cboTema)
        Me.pnlBody.Controls.Add(Me.chkShowClock)
        Me.pnlBody.Controls.Add(Me.chkConfirmLogout)
        Me.pnlBody.Controls.Add(Me.chkConfirmHapus)
        Me.pnlBody.Controls.Add(Me.pnlDiv1)
        Me.pnlBody.Controls.Add(Me.lblLapTitle)
        Me.pnlBody.Controls.Add(Me.lblNamaHotel)
        Me.pnlBody.Controls.Add(Me.txtNamaHotel)
        Me.pnlBody.Controls.Add(Me.lblAlamatHotel)
        Me.pnlBody.Controls.Add(Me.txtAlamatHotel)
        Me.pnlBody.Controls.Add(Me.lblTelpHotel)
        Me.pnlBody.Controls.Add(Me.txtTelpHotel)
        Me.pnlBody.Controls.Add(Me.pnlDiv2)
        Me.pnlBody.Controls.Add(Me.lblDendaTitle)
        Me.pnlBody.Controls.Add(Me.lblDendaPersen)
        Me.pnlBody.Controls.Add(Me.nudDendaPersen)
        Me.pnlBody.Controls.Add(Me.lblDendaNote)
        Me.pnlBody.Controls.Add(Me.pnlDiv3)
        Me.pnlBody.Controls.Add(Me.lblDbTitle)
        Me.pnlBody.Controls.Add(Me.lblDbServer)
        Me.pnlBody.Controls.Add(Me.txtDbServer)
        Me.pnlBody.Controls.Add(Me.lblDbName)
        Me.pnlBody.Controls.Add(Me.txtDbName)
        Me.pnlBody.Controls.Add(Me.btnTestConn)
        Me.pnlBody.Controls.Add(Me.btnSimpan)
        Me.pnlBody.Controls.Add(Me.btnBatal)
        Me.pnlBody.Controls.Add(Me.btnReset)

        ' ── Preferensi UI ─────────────────────────────────
        Me.lblPrefTitle.Name = "lblPrefTitle"
        Me.lblPrefTitle.AutoSize = False
        Me.lblPrefTitle.Size = New System.Drawing.Size(500, 18)
        Me.lblPrefTitle.Location = New System.Drawing.Point(16, 14)
        Me.lblPrefTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblPrefTitle.ForeColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.lblPrefTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblPrefTitle.Text = "PREFERENSI TAMPILAN"

        Me.lblBahasa.Name = "lblBahasa"
        Me.lblBahasa.AutoSize = True
        Me.lblBahasa.Location = New System.Drawing.Point(16, 40)
        Me.lblBahasa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblBahasa.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblBahasa.Text = "Bahasa"

        Me.cboBahasa.Name = "cboBahasa"
        Me.cboBahasa.Location = New System.Drawing.Point(16, 58)
        Me.cboBahasa.Size = New System.Drawing.Size(240, 24)
        Me.cboBahasa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboBahasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBahasa.Items.AddRange(New Object() {"Bahasa Indonesia", "English"})

        Me.lblTema.Name = "lblTema"
        Me.lblTema.AutoSize = True
        Me.lblTema.Location = New System.Drawing.Point(16, 94)
        Me.lblTema.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTema.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblTema.Text = "Tema Warna"

        Me.cboTema.Name = "cboTema"
        Me.cboTema.Location = New System.Drawing.Point(16, 112)
        Me.cboTema.Size = New System.Drawing.Size(240, 24)
        Me.cboTema.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTema.Items.AddRange(New Object() {"Biru (Default)", "Hijau", "Ungu"})

        Me.chkShowClock.Name = "chkShowClock"
        Me.chkShowClock.Location = New System.Drawing.Point(16, 148)
        Me.chkShowClock.Size = New System.Drawing.Size(300, 22)
        Me.chkShowClock.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkShowClock.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.chkShowClock.Text = "Tampilkan jam di status bar"
        Me.chkShowClock.Checked = True

        Me.chkConfirmLogout.Name = "chkConfirmLogout"
        Me.chkConfirmLogout.Location = New System.Drawing.Point(16, 176)
        Me.chkConfirmLogout.Size = New System.Drawing.Size(300, 22)
        Me.chkConfirmLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkConfirmLogout.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.chkConfirmLogout.Text = "Konfirmasi saat logout"
        Me.chkConfirmLogout.Checked = True

        Me.chkConfirmHapus.Name = "chkConfirmHapus"
        Me.chkConfirmHapus.Location = New System.Drawing.Point(16, 204)
        Me.chkConfirmHapus.Size = New System.Drawing.Size(300, 22)
        Me.chkConfirmHapus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkConfirmHapus.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.chkConfirmHapus.Text = "Konfirmasi saat hapus data"
        Me.chkConfirmHapus.Checked = True

        ' ── Divider 1 ──
        Me.pnlDiv1.Name = "pnlDiv1"
        Me.pnlDiv1.Location = New System.Drawing.Point(16, 238)
        Me.pnlDiv1.Size = New System.Drawing.Size(500, 1)
        Me.pnlDiv1.BackColor = System.Drawing.Color.FromArgb(210, 215, 225)

        ' ── Preferensi Laporan ────────────────────────────
        Me.lblLapTitle.Name = "lblLapTitle"
        Me.lblLapTitle.AutoSize = False
        Me.lblLapTitle.Size = New System.Drawing.Size(500, 18)
        Me.lblLapTitle.Location = New System.Drawing.Point(16, 248)
        Me.lblLapTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblLapTitle.ForeColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.lblLapTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblLapTitle.Text = "INFO HOTEL (UNTUK LAPORAN & PDF)"

        Me.lblNamaHotel.Name = "lblNamaHotel"
        Me.lblNamaHotel.AutoSize = True
        Me.lblNamaHotel.Location = New System.Drawing.Point(16, 274)
        Me.lblNamaHotel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblNamaHotel.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblNamaHotel.Text = "Nama Hotel"

        Me.txtNamaHotel.Name = "txtNamaHotel"
        Me.txtNamaHotel.Location = New System.Drawing.Point(16, 292)
        Me.txtNamaHotel.Size = New System.Drawing.Size(500, 24)
        Me.txtNamaHotel.Font = New System.Drawing.Font("Segoe UI", 9.0!)

        Me.lblAlamatHotel.Name = "lblAlamatHotel"
        Me.lblAlamatHotel.AutoSize = True
        Me.lblAlamatHotel.Location = New System.Drawing.Point(16, 328)
        Me.lblAlamatHotel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblAlamatHotel.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblAlamatHotel.Text = "Alamat Hotel"

        Me.txtAlamatHotel.Name = "txtAlamatHotel"
        Me.txtAlamatHotel.Location = New System.Drawing.Point(16, 346)
        Me.txtAlamatHotel.Size = New System.Drawing.Size(500, 24)
        Me.txtAlamatHotel.Font = New System.Drawing.Font("Segoe UI", 9.0!)

        Me.lblTelpHotel.Name = "lblTelpHotel"
        Me.lblTelpHotel.AutoSize = True
        Me.lblTelpHotel.Location = New System.Drawing.Point(16, 382)
        Me.lblTelpHotel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTelpHotel.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblTelpHotel.Text = "No. Telepon Hotel"

        Me.txtTelpHotel.Name = "txtTelpHotel"
        Me.txtTelpHotel.Location = New System.Drawing.Point(16, 400)
        Me.txtTelpHotel.Size = New System.Drawing.Size(500, 24)
        Me.txtTelpHotel.Font = New System.Drawing.Font("Segoe UI", 9.0!)

        ' ── Divider 2 ──
        Me.pnlDiv2.Name = "pnlDiv2"
        Me.pnlDiv2.Location = New System.Drawing.Point(16, 438)
        Me.pnlDiv2.Size = New System.Drawing.Size(500, 1)
        Me.pnlDiv2.BackColor = System.Drawing.Color.FromArgb(210, 215, 225)

        ' ── Preferensi Denda ──────────────────────────────
        Me.lblDendaTitle.Name = "lblDendaTitle"
        Me.lblDendaTitle.AutoSize = False
        Me.lblDendaTitle.Size = New System.Drawing.Size(500, 18)
        Me.lblDendaTitle.Location = New System.Drawing.Point(16, 448)
        Me.lblDendaTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblDendaTitle.ForeColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.lblDendaTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDendaTitle.Text = "ATURAN DENDA"

        Me.lblDendaPersen.Name = "lblDendaPersen"
        Me.lblDendaPersen.AutoSize = True
        Me.lblDendaPersen.Location = New System.Drawing.Point(16, 474)
        Me.lblDendaPersen.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDendaPersen.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblDendaPersen.Text = "Persentase denda keterlambatan per hari (%)"

        Me.nudDendaPersen.Name = "nudDendaPersen"
        Me.nudDendaPersen.Location = New System.Drawing.Point(16, 492)
        Me.nudDendaPersen.Size = New System.Drawing.Size(100, 24)
        Me.nudDendaPersen.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nudDendaPersen.Minimum = 0
        Me.nudDendaPersen.Maximum = 100
        Me.nudDendaPersen.Value = 50

        Me.lblDendaNote.Name = "lblDendaNote"
        Me.lblDendaNote.AutoSize = False
        Me.lblDendaNote.Size = New System.Drawing.Size(380, 18)
        Me.lblDendaNote.Location = New System.Drawing.Point(124, 496)
        Me.lblDendaNote.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblDendaNote.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Me.lblDendaNote.Text = "% dari harga kamar per malam"

        ' ── Divider 3 ──
        Me.pnlDiv3.Name = "pnlDiv3"
        Me.pnlDiv3.Location = New System.Drawing.Point(16, 530)
        Me.pnlDiv3.Size = New System.Drawing.Size(500, 1)
        Me.pnlDiv3.BackColor = System.Drawing.Color.FromArgb(210, 215, 225)

        ' ── Database ──────────────────────────────────────
        Me.lblDbTitle.Name = "lblDbTitle"
        Me.lblDbTitle.AutoSize = False
        Me.lblDbTitle.Size = New System.Drawing.Size(500, 18)
        Me.lblDbTitle.Location = New System.Drawing.Point(16, 540)
        Me.lblDbTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblDbTitle.ForeColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.lblDbTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDbTitle.Text = "KONEKSI DATABASE"

        Me.lblDbServer.Name = "lblDbServer"
        Me.lblDbServer.AutoSize = True
        Me.lblDbServer.Location = New System.Drawing.Point(16, 566)
        Me.lblDbServer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDbServer.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblDbServer.Text = "Server"

        Me.txtDbServer.Name = "txtDbServer"
        Me.txtDbServer.Location = New System.Drawing.Point(16, 584)
        Me.txtDbServer.Size = New System.Drawing.Size(240, 24)
        Me.txtDbServer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDbServer.Text = "localhost\SQLEXPRESS"

        Me.lblDbName.Name = "lblDbName"
        Me.lblDbName.AutoSize = True
        Me.lblDbName.Location = New System.Drawing.Point(268, 566)
        Me.lblDbName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDbName.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.lblDbName.Text = "Nama Database"

        Me.txtDbName.Name = "txtDbName"
        Me.txtDbName.Location = New System.Drawing.Point(268, 584)
        Me.txtDbName.Size = New System.Drawing.Size(248, 24)
        Me.txtDbName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDbName.Text = "HotelDB"

        Me.btnTestConn.Name = "btnTestConn"
        Me.btnTestConn.Text = "Test Koneksi"
        Me.btnTestConn.Location = New System.Drawing.Point(16, 618)
        Me.btnTestConn.Size = New System.Drawing.Size(120, 28)
        Me.btnTestConn.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnTestConn.BackColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.btnTestConn.ForeColor = System.Drawing.Color.White
        Me.btnTestConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestConn.FlatAppearance.BorderSize = 0
        Me.btnTestConn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTestConn.UseVisualStyleBackColor = False

        ' ── Tombol simpan ─────────────────────────────────
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Text = "Simpan Settings"
        Me.btnSimpan.Location = New System.Drawing.Point(16, 660)
        Me.btnSimpan.Size = New System.Drawing.Size(160, 32)
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(45, 74, 138)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpan.UseVisualStyleBackColor = False

        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.Location = New System.Drawing.Point(184, 660)
        Me.btnBatal.Size = New System.Drawing.Size(100, 32)
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(220, 220, 220)
        Me.btnBatal.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60)
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBatal.UseVisualStyleBackColor = False

        Me.btnReset.Name = "btnReset"
        Me.btnReset.Text = "Reset Default"
        Me.btnReset.Location = New System.Drawing.Point(292, 660)
        Me.btnReset.Size = New System.Drawing.Size(120, 32)
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.UseVisualStyleBackColor = False

        '
        'SettingsForm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(540, 756)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsForm"
        Me.Text = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlBody)

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBody.PerformLayout()
        CType(Me.nudDendaPersen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents lblPrefTitle As System.Windows.Forms.Label
    Friend WithEvents lblBahasa As System.Windows.Forms.Label
    Friend WithEvents cboBahasa As System.Windows.Forms.ComboBox
    Friend WithEvents lblTema As System.Windows.Forms.Label
    Friend WithEvents cboTema As System.Windows.Forms.ComboBox
    Friend WithEvents chkShowClock As System.Windows.Forms.CheckBox
    Friend WithEvents chkConfirmLogout As System.Windows.Forms.CheckBox
    Friend WithEvents chkConfirmHapus As System.Windows.Forms.CheckBox
    Friend WithEvents pnlDiv1 As System.Windows.Forms.Panel
    Friend WithEvents lblLapTitle As System.Windows.Forms.Label
    Friend WithEvents lblNamaHotel As System.Windows.Forms.Label
    Friend WithEvents txtNamaHotel As System.Windows.Forms.TextBox
    Friend WithEvents lblAlamatHotel As System.Windows.Forms.Label
    Friend WithEvents txtAlamatHotel As System.Windows.Forms.TextBox
    Friend WithEvents lblTelpHotel As System.Windows.Forms.Label
    Friend WithEvents txtTelpHotel As System.Windows.Forms.TextBox
    Friend WithEvents pnlDiv2 As System.Windows.Forms.Panel
    Friend WithEvents lblDendaTitle As System.Windows.Forms.Label
    Friend WithEvents lblDendaPersen As System.Windows.Forms.Label
    Friend WithEvents nudDendaPersen As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDendaNote As System.Windows.Forms.Label
    Friend WithEvents pnlDiv3 As System.Windows.Forms.Panel
    Friend WithEvents lblDbTitle As System.Windows.Forms.Label
    Friend WithEvents lblDbServer As System.Windows.Forms.Label
    Friend WithEvents txtDbServer As System.Windows.Forms.TextBox
    Friend WithEvents lblDbName As System.Windows.Forms.Label
    Friend WithEvents txtDbName As System.Windows.Forms.TextBox
    Friend WithEvents btnTestConn As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class