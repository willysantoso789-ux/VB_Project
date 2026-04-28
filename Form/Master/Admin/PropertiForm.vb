Imports System.Data

Public Class PropertiForm

    Private dtProperti As New DataTable()
    Private isEdit As Boolean = False
    Private selectedId As Integer = -1

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
        dtProperti.Rows.Add(8, "Kasur", 800000D)
        dtProperti.Rows.Add(9, "Bantal (2 pcs)", 100000D)
        dtProperti.Rows.Add(10, "Shower", 400000D)
        dtProperti.Rows.Add(11, "Kloset", 600000D)
        dtProperti.Rows.Add(12, "Handuk (2 pcs)", 60000D)

        dtPropertiShared = dtProperti
        IsSharedLoaded = True
    End Sub

    ' ── Grid: tampilkan properti + ringkasan kondisi per kamar ──
    Private Sub LoadGrid(Optional filter As String = "")
        Dim view As New DataView(dtProperti)
        If filter <> "" Then
            view.RowFilter = "nama_properti LIKE '%" & filter & "%'"
        End If

        Dim tbl As DataTable = view.ToTable()

        ' Tambah kolom virtual kondisi
        If Not tbl.Columns.Contains("kondisi_kamar") Then
            tbl.Columns.Add("kondisi_kamar", GetType(String))
        End If
        If Not tbl.Columns.Contains("jumlah_kamar") Then
            tbl.Columns.Add("jumlah_kamar", GetType(String))
        End If

        For Each dr As DataRow In tbl.Rows
            Dim idProp As Integer = Convert.ToInt32(dr("id_properti"))
            Dim info As String = GetKondisiInfo(idProp)
            Dim jumlah As String = GetJumlahAssign(idProp)
            dr("kondisi_kamar") = info
            dr("jumlah_kamar") = jumlah
        Next

        dgvProperti.DataSource = tbl
        StyleGrid()
    End Sub

    Private Function GetKondisiInfo(idProp As Integer) As String
        If Not PropertiKamarForm.IsAssignLoaded Then Return "Belum diassign"
        Dim rusak As Integer = 0
        Dim perbaikan As Integer = 0
        Dim baik As Integer = 0
        For Each dr As DataRow In PropertiKamarForm.dtAssignment.Rows
            If Convert.ToInt32(dr("id_properti")) = idProp Then
                Select Case dr("kondisi").ToString()
                    Case "Rusak" : rusak += 1
                    Case "Dalam Perbaikan" : perbaikan += 1
                    Case Else : baik += 1
                End Select
            End If
        Next
        If rusak = 0 AndAlso perbaikan = 0 AndAlso baik = 0 Then Return "Belum diassign"
        Dim parts As New List(Of String)
        If baik > 0 Then parts.Add(baik & " Baik")
        If perbaikan > 0 Then parts.Add(perbaikan & " Perbaikan")
        If rusak > 0 Then parts.Add(rusak & " Rusak")
        Return String.Join(" | ", parts)
    End Function

    Private Function GetJumlahAssign(idProp As Integer) As String
        If Not PropertiKamarForm.IsAssignLoaded Then Return "0 kamar"
        Dim count As Integer = 0
        For Each dr As DataRow In PropertiKamarForm.dtAssignment.Rows
            If Convert.ToInt32(dr("id_properti")) = idProp Then count += 1
        Next
        Return count & " kamar"
    End Function

    Private Sub StyleGrid()
        If dgvProperti.Columns.Count = 0 Then Exit Sub

        dgvProperti.Columns("id_properti").HeaderText = "ID"
        dgvProperti.Columns("nama_properti").HeaderText = "Nama Properti"
        dgvProperti.Columns("biaya_denda").HeaderText = "Biaya Denda (Rp)"
        dgvProperti.Columns("jumlah_kamar").HeaderText = "Assign"
        dgvProperti.Columns("kondisi_kamar").HeaderText = "Kondisi di Kamar"

        dgvProperti.Columns("id_properti").FillWeight = 35
        dgvProperti.Columns("nama_properti").FillWeight = 160
        dgvProperti.Columns("biaya_denda").FillWeight = 110
        dgvProperti.Columns("jumlah_kamar").FillWeight = 60
        dgvProperti.Columns("kondisi_kamar").FillWeight = 170

        dgvProperti.Columns("biaya_denda").DefaultCellStyle.Format = "N0"

        For Each row As DataGridViewRow In dgvProperti.Rows
            Dim info As String = row.Cells("kondisi_kamar").Value?.ToString()
            If info Is Nothing Then Continue For

            If info = "Belum diassign" Then
                row.Cells("kondisi_kamar").Style.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160)
                row.Cells("jumlah_kamar").Style.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160)
            ElseIf info.Contains("Rusak") Then
                row.Cells("kondisi_kamar").Style.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
                row.Cells("kondisi_kamar").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            ElseIf info.Contains("Perbaikan") Then
                row.Cells("kondisi_kamar").Style.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14)
                row.Cells("kondisi_kamar").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            Else
                row.Cells("kondisi_kamar").Style.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
            End If
        Next
    End Sub

    Private Sub ClearForm()
        txtIdProperti.Text = "(auto)"
        txtNamaProperti.Clear()
        txtBiayaDenda.Clear()
        btnHapus.Enabled = False
        btnAssign.Enabled = False
        btnUnassign.Enabled = False
        btnAdjustStatus.Enabled = False
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

        Dim isAssigned As Boolean = (row.Cells("jumlah_kamar").Value?.ToString() <> "0 kamar" AndAlso
                                     row.Cells("jumlah_kamar").Value?.ToString() <> "")

        btnHapus.Enabled = True
        btnAssign.Enabled = True
        btnUnassign.Enabled = isAssigned
        btnAdjustStatus.Enabled = isAssigned
        btnSimpan.Text = "Update"
        isEdit = True
    End Sub

    '── Assign ─────────────────────────────────────────────
    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        If selectedId = -1 Then Exit Sub
        Dim frm As New PropertiKamarForm()
        frm.SetProperti(selectedId, txtNamaProperti.Text)
        frm.ShowDialog()
        LoadGrid()
        RefreshActionButtons()
    End Sub

    '── Unassign ───────────────────────────────────────────
    Private Sub btnUnassign_Click(sender As Object, e As EventArgs) Handles btnUnassign.Click
        If selectedId = -1 Then Exit Sub
        Dim frm As New UnassignPropertiKamarForm()
        frm.SetProperti(selectedId, txtNamaProperti.Text)
        frm.ShowDialog()
        LoadGrid()
        RefreshActionButtons()
    End Sub

    '── Adjust Status ──────────────────────────────────────
    Private Sub btnAdjustStatus_Click(sender As Object, e As EventArgs) Handles btnAdjustStatus.Click
        If selectedId = -1 Then Exit Sub
        Dim frm As New KondisiPropertiForm()
        frm.SetProperti(selectedId, txtNamaProperti.Text)
        frm.ShowDialog()
        LoadGrid()
    End Sub

    Private Sub RefreshActionButtons()
        If selectedId = -1 Then Exit Sub
        Dim jumlah As String = GetJumlahAssign(selectedId)
        Dim isAssigned As Boolean = (jumlah <> "0 kamar")
        btnUnassign.Enabled = isAssigned
        btnAdjustStatus.Enabled = isAssigned
    End Sub

    '── CRUD ───────────────────────────────────────────────
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
        LoadGrid() : ClearForm()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        ' Cek apakah masih ter-assign
        Dim jumlah As String = GetJumlahAssign(selectedId)
        If jumlah <> "0 kamar" Then
            MsgBox("Properti masih ter-assign ke " & jumlah & "." & vbNewLine &
                   "Unassign semua kamar terlebih dahulu sebelum menghapus.",
                   MsgBoxStyle.Exclamation, "Tidak Dapat Dihapus")
            Return
        End If

        If MsgBox("Yakin ingin menghapus properti ini?",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Hapus") = MsgBoxResult.Yes Then
            Dim toDelete As DataRow = Nothing
            For Each dr As DataRow In dtProperti.Rows
                If Convert.ToInt32(dr("id_properti")) = selectedId Then toDelete = dr : Exit For
            Next
            If toDelete IsNot Nothing Then
                dtProperti.Rows.Remove(toDelete)
                dtPropertiShared = dtProperti
            End If
            MsgBox("Properti berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
            LoadGrid() : ClearForm()
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
        txtCari.Clear() : LoadGrid() : ClearForm()
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