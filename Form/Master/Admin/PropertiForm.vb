Imports System.Data

Public Class PropertiForm

    Private dtProperti As New DataTable()
    Private isEdit As Boolean = False
    Private selectedId As Integer = -1

    ' Shared supaya bisa diakses DendaForm nanti
    Public Shared dtPropertiShared As New DataTable()
    Public Shared IsSharedLoaded As Boolean = False

    Private Sub PropertiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDummyData()
        LoadGrid()
        ClearForm()
    End Sub

    Private Sub InitDummyData()
        dtProperti.Columns.Add("id_properti", GetType(Integer))
        dtProperti.Columns.Add("nama_properti", GetType(String))
        dtProperti.Columns.Add("biaya_denda", GetType(Decimal))

        dtProperti.Rows.Add(1, "TV 32 Inch", 500000D)
        dtProperti.Rows.Add(2, "AC Split 1 PK", 750000D)
        dtProperti.Rows.Add(3, "Remote AC", 50000D)
        dtProperti.Rows.Add(4, "Lemari Pakaian", 300000D)
        dtProperti.Rows.Add(5, "Cermin Dinding", 150000D)
        dtProperti.Rows.Add(6, "Meja Kerja", 200000D)
        dtProperti.Rows.Add(7, "Kursi", 75000D)
        dtProperti.Rows.Add(8, "Lampu Tidur", 60000D)
        dtProperti.Rows.Add(9, "Kasur", 800000D)
        dtProperti.Rows.Add(10, "Bantal (2 pcs)", 100000D)
        dtProperti.Rows.Add(11, "Selimut", 80000D)
        dtProperti.Rows.Add(12, "Shower", 400000D)
        dtProperti.Rows.Add(13, "Kloset", 600000D)
        dtProperti.Rows.Add(14, "Handuk (2 pcs)", 60000D)
        dtProperti.Rows.Add(15, "Sabun & Shampoo", 30000D)

        dtPropertiShared = dtProperti
        IsSharedLoaded = True
    End Sub

    Private Sub LoadGrid(Optional filter As String = "")
        Dim view As New DataView(dtProperti)
        If filter <> "" Then
            view.RowFilter = "nama_properti LIKE '%" & filter & "%'"
        End If
        dgvProperti.DataSource = view.ToTable()
        StyleGrid()
    End Sub

    Private Sub StyleGrid()
        If dgvProperti.Columns.Count = 0 Then Exit Sub
        dgvProperti.Columns("id_properti").HeaderText = "ID"
        dgvProperti.Columns("nama_properti").HeaderText = "Nama Properti"
        dgvProperti.Columns("biaya_denda").HeaderText = "Biaya Denda (Rp)"

        dgvProperti.Columns("id_properti").FillWeight = 40
        dgvProperti.Columns("nama_properti").FillWeight = 220
        dgvProperti.Columns("biaya_denda").FillWeight = 120

        dgvProperti.Columns("biaya_denda").DefaultCellStyle.Format = "N0"
    End Sub

    Private Sub ClearForm()
        txtIdProperti.Text = "(auto)"
        txtNamaProperti.Clear()
        txtBiayaDenda.Clear()
        btnHapus.Enabled = False
        btnAssign.Enabled = False
        btnSimpan.Text = "Simpan"
        isEdit = False
        selectedId = -1
        txtNamaProperti.Focus()
    End Sub

    Private Sub dgvProperti_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProperti.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim row As DataGridViewRow = dgvProperti.Rows(e.RowIndex)
        selectedId = Convert.ToInt32(row.Cells("id_properti").Value)
        txtIdProperti.Text = selectedId.ToString()
        txtNamaProperti.Text = row.Cells("nama_properti").Value.ToString()
        txtBiayaDenda.Text = Convert.ToDecimal(row.Cells("biaya_denda").Value).ToString("N0")
        btnHapus.Enabled = True
        btnAssign.Enabled = True
        btnSimpan.Text = "Update"
        isEdit = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidateForm() Then Exit Sub

        Dim biaya As Decimal = 0
        Decimal.TryParse(txtBiayaDenda.Text.Replace(".", "").Replace(",", ""), biaya)

        If isEdit Then
            For Each dr As DataRow In dtProperti.Rows
                If Convert.ToInt32(dr("id_properti")) = selectedId Then
                    dr("nama_properti") = txtNamaProperti.Text.Trim()
                    dr("biaya_denda") = biaya
                    Exit For
                End If
            Next
            MsgBox("Properti berhasil diupdate.", MsgBoxStyle.Information, "Berhasil")
        Else
            Dim newId As Integer = dtProperti.Rows.Count + 1
            dtProperti.Rows.Add(newId, txtNamaProperti.Text.Trim(), biaya)
            MsgBox("Properti berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")
        End If

        dtPropertiShared = dtProperti
        LoadGrid()
        ClearForm()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MsgBox("Yakin ingin menghapus properti ini?",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Hapus") = MsgBoxResult.Yes Then
            Dim toDelete As DataRow = Nothing
            For Each dr As DataRow In dtProperti.Rows
                If Convert.ToInt32(dr("id_properti")) = selectedId Then
                    toDelete = dr : Exit For
                End If
            Next
            If toDelete IsNot Nothing Then
                dtProperti.Rows.Remove(toDelete)
                dtPropertiShared = dtProperti
                MsgBox("Properti berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
            End If
            LoadGrid()
            ClearForm()
        End If
    End Sub

    ' ── Buka PropertiKamarForm untuk properti yang dipilih ─
    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        If selectedId = -1 Then Exit Sub
        Dim namaProp As String = txtNamaProperti.Text
        Dim frm As New PropertiKamarForm()
        frm.SetProperti(selectedId, namaProp)
        frm.ShowDialog()
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
        If String.IsNullOrWhiteSpace(txtNamaProperti.Text) Then
            MsgBox("Nama properti tidak boleh kosong.", MsgBoxStyle.Exclamation)
            txtNamaProperti.Focus() : Return False
        End If
        Dim b As Decimal = 0
        If Not Decimal.TryParse(txtBiayaDenda.Text.Replace(".", "").Replace(",", ""), b) OrElse b < 0 Then
            MsgBox("Biaya denda harus berupa angka.", MsgBoxStyle.Exclamation)
            txtBiayaDenda.Focus() : Return False
        End If
        Return True
    End Function

End Class