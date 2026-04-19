Imports System.Data

Public Class KamarForm
    Private dtKamar As New DataTable()
    Private isEdit As Boolean = False

    Private Sub DataKamarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDummyData()
        LoadTipeKamar()
        LoadGrid()
        ClearForm()
    End Sub

    ' ── Dummy data (ganti ke DB nanti) ────────────────────
    Private Sub InitDummyData()
        dtKamar.Columns.Add("id_kamar", GetType(Integer))
        dtKamar.Columns.Add("id_tipe", GetType(Integer))
        dtKamar.Columns.Add("nama_tipe", GetType(String))
        dtKamar.Columns.Add("nomor_kamar", GetType(String))
        dtKamar.Columns.Add("status", GetType(String))

        dtKamar.Rows.Add(1, 1, "Standard", "101", "Tersedia")
        dtKamar.Rows.Add(2, 1, "Standard", "102", "Terisi")
        dtKamar.Rows.Add(3, 2, "Deluxe", "201", "Tersedia")
        dtKamar.Rows.Add(4, 2, "Deluxe", "202", "Maintenance")
        dtKamar.Rows.Add(5, 3, "Suite", "301", "Tersedia")
    End Sub

    ' ── Isi ComboBox Tipe Kamar ───────────────────────────
    Private Sub LoadTipeKamar()
        cboIdTipe.Items.Clear()
        cboIdTipe.Items.Add(New TipeItem(1, "Standard"))
        cboIdTipe.Items.Add(New TipeItem(2, "Deluxe"))
        cboIdTipe.Items.Add(New TipeItem(3, "Suite"))
        cboIdTipe.DisplayMember = "Nama"
        cboIdTipe.ValueMember = "Id"
    End Sub

    ' ── Load DataGridView ─────────────────────────────────
    Private Sub LoadGrid(Optional filter As String = "")
        Dim view As New DataView(dtKamar)
        If filter <> "" Then
            view.RowFilter = "nomor_kamar LIKE '%" & filter & "%'"
        End If
        dgvKamar.DataSource = view.ToTable()
        StyleGrid()
    End Sub

    ' ── Style header & status warna ───────────────────────
    Private Sub StyleGrid()
        If dgvKamar.Columns.Count = 0 Then Exit Sub

        dgvKamar.Columns("id_kamar").HeaderText = "ID"
        dgvKamar.Columns("id_tipe").HeaderText = "ID Tipe"
        dgvKamar.Columns("nama_tipe").HeaderText = "Tipe Kamar"
        dgvKamar.Columns("nomor_kamar").HeaderText = "Nomor Kamar"
        dgvKamar.Columns("status").HeaderText = "Status"

        dgvKamar.Columns("id_kamar").FillWeight = 40
        dgvKamar.Columns("id_tipe").FillWeight = 50
        dgvKamar.Columns("nama_tipe").FillWeight = 120
        dgvKamar.Columns("nomor_kamar").FillWeight = 100
        dgvKamar.Columns("status").FillWeight = 90

        For Each row As DataGridViewRow In dgvKamar.Rows
            Dim status As String = row.Cells("status").Value?.ToString()
            Select Case status
                Case "Tersedia"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Terisi"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Maintenance"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            End Select
        Next
    End Sub

    ' ── Kosongkan form ────────────────────────────────────
    Private Sub ClearForm()
        txtIdKamar.Text = "(auto)"
        cboIdTipe.SelectedIndex = -1
        txtNomorKamar.Clear()
        cboStatus.SelectedIndex = -1
        btnHapus.Enabled = False
        btnSimpan.Text = "Simpan"
        isEdit = False
        txtNomorKamar.Focus()
    End Sub

    ' ── Klik baris grid → isi form ────────────────────────
    Private Sub dgvKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKamar.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvKamar.Rows(e.RowIndex)
        txtIdKamar.Text = row.Cells("id_kamar").Value.ToString()
        txtNomorKamar.Text = row.Cells("nomor_kamar").Value.ToString()

        Dim idTipe As Integer = Convert.ToInt32(row.Cells("id_tipe").Value)
        For i As Integer = 0 To cboIdTipe.Items.Count - 1
            If CType(cboIdTipe.Items(i), TipeItem).Id = idTipe Then
                cboIdTipe.SelectedIndex = i
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

        Dim selectedTipe As TipeItem = CType(cboIdTipe.SelectedItem, TipeItem)

        If isEdit Then
            Dim id As Integer = Convert.ToInt32(txtIdKamar.Text)
            For Each dr As DataRow In dtKamar.Rows
                If Convert.ToInt32(dr("id_kamar")) = id Then
                    dr("id_tipe") = selectedTipe.Id
                    dr("nama_tipe") = selectedTipe.Nama
                    dr("nomor_kamar") = txtNomorKamar.Text.Trim()
                    dr("status") = cboStatus.SelectedItem.ToString()
                    Exit For
                End If
            Next
            MsgBox("Data kamar berhasil diupdate.", MsgBoxStyle.Information, "Berhasil")
        Else
            Dim newId As Integer = dtKamar.Rows.Count + 1
            dtKamar.Rows.Add(
                newId,
                selectedTipe.Id,
                selectedTipe.Nama,
                txtNomorKamar.Text.Trim(),
                cboStatus.SelectedItem.ToString()
            )
            MsgBox("Data kamar berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")
        End If

        LoadGrid()
        ClearForm()
    End Sub

    ' ── Hapus ─────────────────────────────────────────────
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Yakin ingin menghapus kamar ini?",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Hapus") = MsgBoxResult.Yes Then

            Dim id As Integer = Convert.ToInt32(txtIdKamar.Text)
            Dim toDelete As DataRow = Nothing

            For Each dr As DataRow In dtKamar.Rows
                If Convert.ToInt32(dr("id_kamar")) = id Then
                    toDelete = dr
                    Exit For
                End If
            Next

            If toDelete IsNot Nothing Then
                dtKamar.Rows.Remove(toDelete)
                MsgBox("Data kamar berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
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
        If e.KeyCode = Keys.Enter Then
            LoadGrid(txtCari.Text.Trim())
        End If
    End Sub

    ' ── Refresh ───────────────────────────────────────────
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtCari.Clear()
        LoadGrid()
        ClearForm()
    End Sub

    ' ── Validasi form sebelum simpan ──────────────────────
    Private Function ValidateForm() As Boolean
        If cboIdTipe.SelectedIndex = -1 Then
            MsgBox("Pilih tipe kamar terlebih dahulu.", MsgBoxStyle.Exclamation, "Perhatian")
            cboIdTipe.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtNomorKamar.Text) Then
            MsgBox("Nomor kamar tidak boleh kosong.", MsgBoxStyle.Exclamation, "Perhatian")
            txtNomorKamar.Focus()
            Return False
        End If
        If cboStatus.SelectedIndex = -1 Then
            MsgBox("Pilih status kamar terlebih dahulu.", MsgBoxStyle.Exclamation, "Perhatian")
            cboStatus.Focus()
            Return False
        End If
        Return True
    End Function

End Class

' ── Helper class ComboBox tipe ────────────────────────────
Public Class TipeItem
    Public Property Id As Integer
    Public Property Nama As String

    Public Sub New(id As Integer, nama As String)
        Me.Id = id
        Me.Nama = nama
    End Sub

    Public Overrides Function ToString() As String
        Return Nama
    End Function
End Class