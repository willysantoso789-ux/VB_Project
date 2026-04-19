Imports System.Data

Public Class ReservasiForm

    Private dtReservasi As New DataTable()
    Private isEdit As Boolean = False

    ' ── Shared data — nanti diganti DB ───────────────────
    ' Data ini dishare ke CheckInForm nanti
    Public Shared dtReservasiShared As New DataTable()
    Public Shared IsSharedLoaded As Boolean = False

    Private Sub ReservasiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDummyData()
        LoadTamu()
        LoadKamar()
        LoadGrid()
        ClearForm()
    End Sub

    ' ── Dummy data reservasi ──────────────────────────────
    Private Sub InitDummyData()
        dtReservasi.Columns.Add("id_reservasi", GetType(Integer))
        dtReservasi.Columns.Add("id_tamu", GetType(Integer))
        dtReservasi.Columns.Add("nama_tamu", GetType(String))
        dtReservasi.Columns.Add("id_kamar", GetType(Integer))
        dtReservasi.Columns.Add("nomor_kamar", GetType(String))
        dtReservasi.Columns.Add("harga_kamar", GetType(Decimal))
        dtReservasi.Columns.Add("tgl_reservasi", GetType(DateTime))
        dtReservasi.Columns.Add("tgl_checkin", GetType(DateTime))
        dtReservasi.Columns.Add("tgl_checkout", GetType(DateTime))
        dtReservasi.Columns.Add("tipe_reservasi", GetType(String))
        dtReservasi.Columns.Add("status", GetType(String))

        dtReservasi.Rows.Add(1, 1, "Budi Santoso", 1, "101", 350000D, DateTime.Today, DateTime.Today, DateTime.Today.AddDays(2), "Walk-in (Langsung)", "Confirmed")
        dtReservasi.Rows.Add(2, 2, "Siti Rahayu", 3, "201", 600000D, DateTime.Today, DateTime.Today.AddDays(3), DateTime.Today.AddDays(5), "Online / Contact", "Pending")
        dtReservasi.Rows.Add(3, 3, "Agus Prasetyo", 5, "301", 1200000D, DateTime.Today, DateTime.Today.AddDays(1), DateTime.Today.AddDays(4), "Online / Contact", "Confirmed")

        ' Sync ke shared
        dtReservasiShared = dtReservasi
        IsSharedLoaded = True
    End Sub

    ' ── Isi ComboBox Tamu ─────────────────────────────────
    Private Sub LoadTamu()
        cboTamu.Items.Clear()
        cboTamu.Items.Add(New TamuItem(1, "Budi Santoso"))
        cboTamu.Items.Add(New TamuItem(2, "Siti Rahayu"))
        cboTamu.Items.Add(New TamuItem(3, "Agus Prasetyo"))
        cboTamu.Items.Add(New TamuItem(4, "Dewi Lestari"))
        cboTamu.DisplayMember = "Nama"
        cboTamu.ValueMember = "Id"
    End Sub

    ' ── Isi ComboBox Kamar (hanya Tersedia) ───────────────
    Private Sub LoadKamar()
        cboKamar.Items.Clear()
        cboKamar.Items.Add(New KamarItem(1, "101", "Standard", 350000D))
        cboKamar.Items.Add(New KamarItem(2, "102", "Standard", 350000D))
        cboKamar.Items.Add(New KamarItem(3, "201", "Deluxe", 600000D))
        cboKamar.Items.Add(New KamarItem(4, "202", "Deluxe", 600000D))
        cboKamar.Items.Add(New KamarItem(5, "301", "Suite", 1200000D))
        cboKamar.DisplayMember = "Display"
        cboKamar.ValueMember = "Id"
    End Sub

    ' ── Kamar dipilih → auto isi harga ───────────────────
    Private Sub cboKamar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKamar.SelectedIndexChanged
        If cboKamar.SelectedIndex = -1 Then
            txtHargaKamar.Text = "Rp 0"
            Exit Sub
        End If
        Dim k As KamarItem = CType(cboKamar.SelectedItem, KamarItem)
        txtHargaKamar.Text = "Rp " & k.Harga.ToString("N0")
    End Sub

    ' ── Walk-in → set tanggal checkin = hari ini otomatis ─
    Private Sub cboTipe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipe.SelectedIndexChanged
        If cboTipe.SelectedIndex = 0 Then   ' Walk-in
            dtpTglCheckin.Value = DateTime.Today
            dtpTglReservasi.Value = DateTime.Today
            cboStatus.SelectedItem = "Confirmed"
        End If
    End Sub

    ' ── Load grid ─────────────────────────────────────────
    Private Sub LoadGrid(Optional filter As String = "")
        Dim view As New DataView(dtReservasi)
        If filter <> "" Then
            view.RowFilter = "nama_tamu LIKE '%" & filter & "%' OR nomor_kamar LIKE '%" & filter & "%'"
        End If
        dgvReservasi.DataSource = view.ToTable()
        StyleGrid()
    End Sub

    Private Sub StyleGrid()
        If dgvReservasi.Columns.Count = 0 Then Exit Sub

        dgvReservasi.Columns("id_reservasi").HeaderText = "ID"
        dgvReservasi.Columns("id_tamu").HeaderText = "ID Tamu"
        dgvReservasi.Columns("nama_tamu").HeaderText = "Nama Tamu"
        dgvReservasi.Columns("id_kamar").HeaderText = "ID Kamar"
        dgvReservasi.Columns("nomor_kamar").HeaderText = "No. Kamar"
        dgvReservasi.Columns("harga_kamar").HeaderText = "Harga/Malam"
        dgvReservasi.Columns("tgl_reservasi").HeaderText = "Tgl Reservasi"
        dgvReservasi.Columns("tgl_checkin").HeaderText = "Check-In"
        dgvReservasi.Columns("tgl_checkout").HeaderText = "Check-Out"
        dgvReservasi.Columns("tipe_reservasi").HeaderText = "Tipe"
        dgvReservasi.Columns("status").HeaderText = "Status"

        dgvReservasi.Columns("id_reservasi").FillWeight = 35
        dgvReservasi.Columns("id_tamu").FillWeight = 45
        dgvReservasi.Columns("nama_tamu").FillWeight = 120
        dgvReservasi.Columns("id_kamar").FillWeight = 45
        dgvReservasi.Columns("nomor_kamar").FillWeight = 60
        dgvReservasi.Columns("harga_kamar").FillWeight = 90
        dgvReservasi.Columns("tgl_reservasi").FillWeight = 90
        dgvReservasi.Columns("tgl_checkin").FillWeight = 80
        dgvReservasi.Columns("tgl_checkout").FillWeight = 80
        dgvReservasi.Columns("tipe_reservasi").FillWeight = 100
        dgvReservasi.Columns("status").FillWeight = 80

        ' Format harga
        dgvReservasi.Columns("harga_kamar").DefaultCellStyle.Format = "N0"

        ' Warna status
        For Each row As DataGridViewRow In dgvReservasi.Rows
            Dim st As String = row.Cells("status").Value?.ToString()
            Select Case st
                Case "Confirmed"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Pending"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Checked-In"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(26, 86, 219)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Checked-Out"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Cancelled"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            End Select
        Next
    End Sub

    ' ── Clear form ────────────────────────────────────────
    Private Sub ClearForm()
        txtIdReservasi.Text = "(auto)"
        cboTipe.SelectedIndex = -1
        cboTamu.SelectedIndex = -1
        cboKamar.SelectedIndex = -1
        txtHargaKamar.Text = "Rp 0"
        dtpTglReservasi.Value = DateTime.Today
        dtpTglCheckin.Value = DateTime.Today
        dtpTglCheckout.Value = DateTime.Today.AddDays(1)
        cboStatus.SelectedIndex = -1
        btnHapus.Enabled = False
        btnSimpan.Text = "Simpan"
        isEdit = False
    End Sub

    ' ── Klik baris grid → isi form ────────────────────────
    Private Sub dgvReservasi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservasi.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvReservasi.Rows(e.RowIndex)

        txtIdReservasi.Text = row.Cells("id_reservasi").Value.ToString()
        dtpTglReservasi.Value = Convert.ToDateTime(row.Cells("tgl_reservasi").Value)
        dtpTglCheckin.Value = Convert.ToDateTime(row.Cells("tgl_checkin").Value)
        dtpTglCheckout.Value = Convert.ToDateTime(row.Cells("tgl_checkout").Value)
        txtHargaKamar.Text = "Rp " & Convert.ToDecimal(row.Cells("harga_kamar").Value).ToString("N0")

        ' Set tipe
        cboTipe.SelectedItem = row.Cells("tipe_reservasi").Value.ToString()

        ' Set tamu
        Dim idTamu As Integer = Convert.ToInt32(row.Cells("id_tamu").Value)
        For i As Integer = 0 To cboTamu.Items.Count - 1
            If CType(cboTamu.Items(i), TamuItem).Id = idTamu Then
                cboTamu.SelectedIndex = i
                Exit For
            End If
        Next

        ' Set kamar
        Dim idKamar As Integer = Convert.ToInt32(row.Cells("id_kamar").Value)
        For i As Integer = 0 To cboKamar.Items.Count - 1
            If CType(cboKamar.Items(i), KamarItem).Id = idKamar Then
                cboKamar.SelectedIndex = i
                Exit For
            End If
        Next

        cboStatus.SelectedItem = row.Cells("status").Value.ToString()

        btnHapus.Enabled = True
        btnSimpan.Text = "Update"
        isEdit = True
    End Sub

    ' ── Simpan / Update ───────────────────────────────────
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidateForm() Then Exit Sub

        Dim tamu As TamuItem = CType(cboTamu.SelectedItem, TamuItem)
        Dim kamar As KamarItem = CType(cboKamar.SelectedItem, KamarItem)

        If dtpTglCheckout.Value <= dtpTglCheckin.Value Then
            MsgBox("Tanggal check-out harus setelah tanggal check-in.", MsgBoxStyle.Exclamation, "Perhatian")
            Return
        End If

        If isEdit Then
            Dim id As Integer = Convert.ToInt32(txtIdReservasi.Text)
            For Each dr As DataRow In dtReservasi.Rows
                If Convert.ToInt32(dr("id_reservasi")) = id Then
                    dr("id_tamu") = tamu.Id
                    dr("nama_tamu") = tamu.Nama
                    dr("id_kamar") = kamar.Id
                    dr("nomor_kamar") = kamar.Nomor
                    dr("harga_kamar") = kamar.Harga
                    dr("tgl_reservasi") = dtpTglReservasi.Value.Date
                    dr("tgl_checkin") = dtpTglCheckin.Value.Date
                    dr("tgl_checkout") = dtpTglCheckout.Value.Date
                    dr("tipe_reservasi") = cboTipe.SelectedItem.ToString()
                    dr("status") = cboStatus.SelectedItem.ToString()
                    Exit For
                End If
            Next
            MsgBox("Reservasi berhasil diupdate.", MsgBoxStyle.Information, "Berhasil")
        Else
            Dim newId As Integer = dtReservasi.Rows.Count + 1
            dtReservasi.Rows.Add(
                newId,
                tamu.Id,
                tamu.Nama,
                kamar.Id,
                kamar.Nomor,
                kamar.Harga,
                dtpTglReservasi.Value.Date,
                dtpTglCheckin.Value.Date,
                dtpTglCheckout.Value.Date,
                cboTipe.SelectedItem.ToString(),
                cboStatus.SelectedItem.ToString()
            )
            MsgBox("Reservasi berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")
        End If

        ' Sync shared
        dtReservasiShared = dtReservasi

        LoadGrid()
        ClearForm()
    End Sub

    ' ── Hapus ─────────────────────────────────────────────
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Yakin ingin menghapus reservasi ini?",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Hapus") = MsgBoxResult.Yes Then

            Dim id As Integer = Convert.ToInt32(txtIdReservasi.Text)
            Dim toDelete As DataRow = Nothing

            For Each dr As DataRow In dtReservasi.Rows
                If Convert.ToInt32(dr("id_reservasi")) = id Then
                    toDelete = dr
                    Exit For
                End If
            Next

            If toDelete IsNot Nothing Then
                dtReservasi.Rows.Remove(toDelete)
                dtReservasiShared = dtReservasi
                MsgBox("Reservasi berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
            End If

            LoadGrid()
            ClearForm()
        End If
    End Sub

    ' ── Batal ─────────────────────────────────────────────
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearForm()
    End Sub

    ' ── Cari ──────────────────────────────────────────────
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        LoadGrid(txtCari.Text.Trim())
    End Sub

    Private Sub txtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then LoadGrid(txtCari.Text.Trim())
    End Sub

    ' ── Refresh ───────────────────────────────────────────
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtCari.Clear()
        LoadGrid()
        ClearForm()
    End Sub

    ' ── Validasi ──────────────────────────────────────────
    Private Function ValidateForm() As Boolean
        If cboTipe.SelectedIndex = -1 Then
            MsgBox("Pilih tipe reservasi.", MsgBoxStyle.Exclamation, "Perhatian")
            cboTipe.Focus() : Return False
        End If
        If cboTamu.SelectedIndex = -1 Then
            MsgBox("Pilih nama tamu.", MsgBoxStyle.Exclamation, "Perhatian")
            cboTamu.Focus() : Return False
        End If
        If cboKamar.SelectedIndex = -1 Then
            MsgBox("Pilih kamar.", MsgBoxStyle.Exclamation, "Perhatian")
            cboKamar.Focus() : Return False
        End If
        If cboStatus.SelectedIndex = -1 Then
            MsgBox("Pilih status reservasi.", MsgBoxStyle.Exclamation, "Perhatian")
            cboStatus.Focus() : Return False
        End If
        Return True
    End Function

End Class

' ── Helper classes ────────────────────────────────────────
Public Class TamuItem
    Public Property Id As Integer
    Public Property Nama As String
    Public Sub New(id As Integer, nama As String)
        Me.Id = id : Me.Nama = nama
    End Sub
    Public Overrides Function ToString() As String
        Return Nama
    End Function
End Class

Public Class KamarItem
    Public Property Id As Integer
    Public Property Nomor As String
    Public Property Tipe As String
    Public Property Harga As Decimal
    Public Property Display As String
    Public Sub New(id As Integer, nomor As String, tipe As String, harga As Decimal)
        Me.Id = id
        Me.Nomor = nomor
        Me.Tipe = tipe
        Me.Harga = harga
        Me.Display = nomor & " - " & tipe & " (Rp " & harga.ToString("N0") & ")"
    End Sub
    Public Overrides Function ToString() As String
        Return Display
    End Function
End Class