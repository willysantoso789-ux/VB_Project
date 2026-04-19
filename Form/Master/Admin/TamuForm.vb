Imports System.Data

Public Class TamuForm

    Private dtTamu As New DataTable()
    Private isEdit As Boolean = False

    Private Sub DataTamuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDummyData()
        LoadGrid()
        ClearForm()
    End Sub

    ' ── Dummy data (ganti ke DB nanti) ────────────────────
    Private Sub InitDummyData()
        dtTamu.Columns.Add("id_tamu", GetType(Integer))
        dtTamu.Columns.Add("nama", GetType(String))
        dtTamu.Columns.Add("email", GetType(String))
        dtTamu.Columns.Add("no_hp", GetType(String))
        dtTamu.Columns.Add("gender", GetType(String))
        dtTamu.Columns.Add("alamat", GetType(String))

        dtTamu.Rows.Add(1, "Budi Santoso", "budi@email.com", "08123456789", "Laki-laki", "Jl. Merdeka No.1, Jakarta")
        dtTamu.Rows.Add(2, "Siti Rahayu", "siti@email.com", "08234567890", "Perempuan", "Jl. Sudirman No.5, Bandung")
        dtTamu.Rows.Add(3, "Agus Prasetyo", "agus@email.com", "08345678901", "Laki-laki", "Jl. Gatot Subroto No.10, Surabaya")
        dtTamu.Rows.Add(4, "Dewi Lestari", "dewi@email.com", "08456789012", "Perempuan", "Jl. Ahmad Yani No.3, Medan")
    End Sub

    ' ── Load DataGridView ─────────────────────────────────
    Private Sub LoadGrid(Optional filter As String = "")
        Dim view As New DataView(dtTamu)
        If filter <> "" Then
            view.RowFilter = "nama LIKE '%" & filter & "%' OR no_hp LIKE '%" & filter & "%'"
        End If
        dgvTamu.DataSource = view.ToTable()
        StyleGrid()
    End Sub

    ' ── Style kolom grid ──────────────────────────────────
    Private Sub StyleGrid()
        If dgvTamu.Columns.Count = 0 Then Exit Sub

        dgvTamu.Columns("id_tamu").HeaderText = "ID"
        dgvTamu.Columns("nama").HeaderText = "Nama"
        dgvTamu.Columns("email").HeaderText = "Email"
        dgvTamu.Columns("no_hp").HeaderText = "No. HP"
        dgvTamu.Columns("gender").HeaderText = "Gender"
        dgvTamu.Columns("alamat").HeaderText = "Alamat"

        dgvTamu.Columns("id_tamu").FillWeight = 40
        dgvTamu.Columns("nama").FillWeight = 150
        dgvTamu.Columns("email").FillWeight = 160
        dgvTamu.Columns("no_hp").FillWeight = 110
        dgvTamu.Columns("gender").FillWeight = 80
        dgvTamu.Columns("alamat").FillWeight = 200

        For Each row As DataGridViewRow In dgvTamu.Rows
            Dim gender As String = row.Cells("gender").Value?.ToString()
            Select Case gender
                Case "Laki-laki"
                    row.Cells("gender").Style.ForeColor = System.Drawing.Color.FromArgb(26, 86, 219)
                    row.Cells("gender").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Perempuan"
                    row.Cells("gender").Style.ForeColor = System.Drawing.Color.FromArgb(157, 23, 77)
                    row.Cells("gender").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            End Select
        Next
    End Sub

    ' ── Kosongkan form ────────────────────────────────────
    Private Sub ClearForm()
        txtIdTamu.Text = "(auto)"
        txtNama.Clear()
        txtEmail.Clear()
        txtNoHp.Clear()
        cboGender.SelectedIndex = -1
        txtAlamat.Clear()
        btnHapus.Enabled = False
        btnSimpan.Text = "Simpan"
        isEdit = False
        txtNama.Focus()
    End Sub

    ' ── Klik baris grid → isi form ────────────────────────
    Private Sub dgvTamu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTamu.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvTamu.Rows(e.RowIndex)
        txtIdTamu.Text = row.Cells("id_tamu").Value.ToString()
        txtNama.Text = row.Cells("nama").Value.ToString()
        txtEmail.Text = row.Cells("email").Value.ToString()
        txtNoHp.Text = row.Cells("no_hp").Value.ToString()
        txtAlamat.Text = row.Cells("alamat").Value.ToString()

        cboGender.SelectedItem = row.Cells("gender").Value.ToString()

        btnHapus.Enabled = True
        btnSimpan.Text = "Update"
        isEdit = True
    End Sub

    ' ── Simpan / Update ───────────────────────────────────
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidateForm() Then Exit Sub

        If isEdit Then
            Dim id As Integer = Convert.ToInt32(txtIdTamu.Text)
            For Each dr As DataRow In dtTamu.Rows
                If Convert.ToInt32(dr("id_tamu")) = id Then
                    dr("nama") = txtNama.Text.Trim()
                    dr("email") = txtEmail.Text.Trim()
                    dr("no_hp") = txtNoHp.Text.Trim()
                    dr("gender") = cboGender.SelectedItem.ToString()
                    dr("alamat") = txtAlamat.Text.Trim()
                    Exit For
                End If
            Next
            MsgBox("Data tamu berhasil diupdate.", MsgBoxStyle.Information, "Berhasil")
        Else
            Dim newId As Integer = dtTamu.Rows.Count + 1
            dtTamu.Rows.Add(
                newId,
                txtNama.Text.Trim(),
                txtEmail.Text.Trim(),
                txtNoHp.Text.Trim(),
                cboGender.SelectedItem.ToString(),
                txtAlamat.Text.Trim()
            )
            MsgBox("Data tamu berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")
        End If

        LoadGrid()
        ClearForm()
    End Sub

    ' ── Hapus ─────────────────────────────────────────────
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Yakin ingin menghapus tamu ini?",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Hapus") = MsgBoxResult.Yes Then

            Dim id As Integer = Convert.ToInt32(txtIdTamu.Text)
            Dim toDelete As DataRow = Nothing

            For Each dr As DataRow In dtTamu.Rows
                If Convert.ToInt32(dr("id_tamu")) = id Then
                    toDelete = dr
                    Exit For
                End If
            Next

            If toDelete IsNot Nothing Then
                dtTamu.Rows.Remove(toDelete)
                MsgBox("Data tamu berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
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

    ' ── Validasi ──────────────────────────────────────────
    Private Function ValidateForm() As Boolean
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MsgBox("Nama tidak boleh kosong.", MsgBoxStyle.Exclamation, "Perhatian")
            txtNama.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MsgBox("Email tidak boleh kosong.", MsgBoxStyle.Exclamation, "Perhatian")
            txtEmail.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtNoHp.Text) Then
            MsgBox("No. HP tidak boleh kosong.", MsgBoxStyle.Exclamation, "Perhatian")
            txtNoHp.Focus()
            Return False
        End If
        If cboGender.SelectedIndex = -1 Then
            MsgBox("Pilih jenis kelamin terlebih dahulu.", MsgBoxStyle.Exclamation, "Perhatian")
            cboGender.Focus()
            Return False
        End If
        Return True
    End Function

End Class