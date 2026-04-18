Imports System.Data

Public Class DataTipeKamar

    Private dtTipe As New DataTable()
    Private isEdit As Boolean = False

    ' Shared supaya bisa diakses DataKamarForm & PropertiKamarForm
    Public Shared dtTipeShared As New DataTable()
    Public Shared IsSharedLoaded As Boolean = False

    Private Sub TipeKamarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDummyData()
        LoadGrid()
        ClearForm()
    End Sub

    Private Sub InitDummyData()
        dtTipe.Columns.Add("id_tipe", GetType(Integer))
        dtTipe.Columns.Add("nama_tipe", GetType(String))
        dtTipe.Columns.Add("harga", GetType(Decimal))
        dtTipe.Columns.Add("deskripsi", GetType(String))

        dtTipe.Rows.Add(1, "Standard", 350000D, "Kamar standar dengan fasilitas dasar.")
        dtTipe.Rows.Add(2, "Deluxe", 600000D, "Kamar deluxe dengan pemandangan taman.")
        dtTipe.Rows.Add(3, "Suite", 1200000D, "Kamar suite mewah dengan ruang tamu.")

        dtTipeShared = dtTipe
        IsSharedLoaded = True
    End Sub

    Private Sub LoadGrid(Optional filter As String = "")
        Dim view As New DataView(dtTipe)
        If filter <> "" Then
            view.RowFilter = "nama_tipe LIKE '%" & filter & "%'"
        End If
        dgvTipe.DataSource = view.ToTable()
        StyleGrid()
    End Sub

    Private Sub StyleGrid()
        If dgvTipe.Columns.Count = 0 Then Exit Sub
        dgvTipe.Columns("id_tipe").HeaderText = "ID"
        dgvTipe.Columns("nama_tipe").HeaderText = "Nama Tipe"
        dgvTipe.Columns("harga").HeaderText = "Harga / Malam"
        dgvTipe.Columns("deskripsi").HeaderText = "Deskripsi"

        dgvTipe.Columns("id_tipe").FillWeight = 40
        dgvTipe.Columns("nama_tipe").FillWeight = 120
        dgvTipe.Columns("harga").FillWeight = 110
        dgvTipe.Columns("deskripsi").FillWeight = 280

        dgvTipe.Columns("harga").DefaultCellStyle.Format = "N0"
    End Sub

    Private Sub ClearForm()
        txtIdTipe.Text = "(auto)"
        txtNamaTipe.Clear()
        txtHarga.Clear()
        txtDeskripsi.Clear()
        btnHapus.Enabled = False
        btnSimpan.Text = "Simpan"
        isEdit = False
        txtNamaTipe.Focus()
    End Sub

    Private Sub dgvTipe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipe.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim row As DataGridViewRow = dgvTipe.Rows(e.RowIndex)
        txtIdTipe.Text = row.Cells("id_tipe").Value.ToString()
        txtNamaTipe.Text = row.Cells("nama_tipe").Value.ToString()
        txtHarga.Text = Convert.ToDecimal(row.Cells("harga").Value).ToString("N0")
        txtDeskripsi.Text = row.Cells("deskripsi").Value.ToString()
        btnHapus.Enabled = True
        btnSimpan.Text = "Update"
        isEdit = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidateForm() Then Exit Sub

        Dim harga As Decimal = 0
        Decimal.TryParse(txtHarga.Text.Replace(".", "").Replace(",", ""), harga)

        If isEdit Then
            Dim id As Integer = Convert.ToInt32(txtIdTipe.Text)
            For Each dr As DataRow In dtTipe.Rows
                If Convert.ToInt32(dr("id_tipe")) = id Then
                    dr("nama_tipe") = txtNamaTipe.Text.Trim()
                    dr("harga") = harga
                    dr("deskripsi") = txtDeskripsi.Text.Trim()
                    Exit For
                End If
            Next
            MsgBox("Tipe kamar berhasil diupdate.", MsgBoxStyle.Information, "Berhasil")
        Else
            Dim newId As Integer = dtTipe.Rows.Count + 1
            dtTipe.Rows.Add(newId, txtNamaTipe.Text.Trim(), harga, txtDeskripsi.Text.Trim())
            MsgBox("Tipe kamar berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")
        End If

        dtTipeShared = dtTipe
        LoadGrid()
        ClearForm()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Yakin ingin menghapus tipe kamar ini?",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Hapus") = MsgBoxResult.Yes Then
            Dim id As Integer = Convert.ToInt32(txtIdTipe.Text)
            Dim toDelete As DataRow = Nothing
            For Each dr As DataRow In dtTipe.Rows
                If Convert.ToInt32(dr("id_tipe")) = id Then
                    toDelete = dr : Exit For
                End If
            Next
            If toDelete IsNot Nothing Then
                dtTipe.Rows.Remove(toDelete)
                dtTipeShared = dtTipe
                MsgBox("Tipe kamar berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
            End If
            LoadGrid()
            ClearForm()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearForm()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        LoadGrid(txtCari.Text.Trim())
    End Sub

    Private Sub txtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then LoadGrid(txtCari.Text.Trim())
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtCari.Clear()
        LoadGrid()
        ClearForm()
    End Sub

    Private Function ValidateForm() As Boolean
        If String.IsNullOrWhiteSpace(txtNamaTipe.Text) Then
            MsgBox("Nama tipe tidak boleh kosong.", MsgBoxStyle.Exclamation)
            txtNamaTipe.Focus() : Return False
        End If
        Dim h As Decimal = 0
        If Not Decimal.TryParse(txtHarga.Text.Replace(".", "").Replace(",", ""), h) OrElse h <= 0 Then
            MsgBox("Harga harus berupa angka lebih dari 0.", MsgBoxStyle.Exclamation)
            txtHarga.Focus() : Return False
        End If
        Return True
    End Function

End Class