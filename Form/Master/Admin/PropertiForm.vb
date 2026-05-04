Imports System.Data

Public Class PropertiForm

    Private isEdit As Boolean = False
    Private selectedId As Integer = -1
    Private selectedNama As String = ""

    Private Sub PropertiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        ClearForm()
    End Sub

    Private Sub LoadGrid(Optional filter As String = "")
        Try
            Dim dt As DataTable = Database.ExecuteQuery("sp_GetAllProperti", Nothing)

            If filter <> "" Then
                Dim view As New DataView(dt)
                view.RowFilter = "nama_properti LIKE '%" & filter & "%'"
                dgvProperti.DataSource = view.ToTable()
            Else
                dgvProperti.DataSource = dt
            End If
            StyleGrid()
        Catch ex As Exception
            MsgBox("Gagal load data properti: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub StyleGrid()
        If dgvProperti.Columns.Count = 0 Then Exit Sub

        Dim headers As New Dictionary(Of String, String) From {
            {"id_properti", "ID"},
            {"nama_properti", "Nama Properti"},
            {"biaya_denda", "Biaya Denda (Rp)"},
            {"jumlah_assign", "Assigned ke Kamar"}
        }
        For Each kv In headers
            If dgvProperti.Columns.Contains(kv.Key) Then
                dgvProperti.Columns(kv.Key).HeaderText = kv.Value
            End If
        Next

        If dgvProperti.Columns.Contains("biaya_denda") Then
            dgvProperti.Columns("biaya_denda").DefaultCellStyle.Format = "N0"
        End If

        If dgvProperti.Columns.Contains("id_properti") Then
            dgvProperti.Columns("id_properti").FillWeight = 35
        End If
        If dgvProperti.Columns.Contains("nama_properti") Then
            dgvProperti.Columns("nama_properti").FillWeight = 200
        End If
        If dgvProperti.Columns.Contains("biaya_denda") Then
            dgvProperti.Columns("biaya_denda").FillWeight = 120
        End If
        If dgvProperti.Columns.Contains("jumlah_assign") Then
            dgvProperti.Columns("jumlah_assign").FillWeight = 80
        End If

        ' Warna kolom jumlah assign
        For Each row As DataGridViewRow In dgvProperti.Rows
            Dim jumlah As Integer = 0
            Integer.TryParse(row.Cells("jumlah_assign").Value?.ToString(), jumlah)
            If jumlah > 0 Then
                row.Cells("jumlah_assign").Style.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
                row.Cells("jumlah_assign").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            Else
                row.Cells("jumlah_assign").Style.ForeColor = System.Drawing.Color.FromArgb(150, 150, 150)
            End If
        Next
    End Sub

    Private Sub ClearForm()
        txtIdProperti.Text = "(auto)"
        txtNama.Clear()
        txtBiaya.Clear()
        btnHapus.Enabled = False
        btnAssign.Enabled = False
        btnUnassign.Enabled = False
        btnSimpan.Text = "Simpan"
        isEdit = False
        selectedId = -1
        selectedNama = ""
        txtNama.Focus()
    End Sub

    Private Sub dgvProperti_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProperti.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim row As DataGridViewRow = dgvProperti.Rows(e.RowIndex)

        selectedId = Convert.ToInt32(row.Cells("id_properti").Value)
        selectedNama = row.Cells("nama_properti").Value?.ToString()
        txtIdProperti.Text = selectedId.ToString()
        txtNama.Text = selectedNama
        txtBiaya.Text = Convert.ToDecimal(row.Cells("biaya_denda").Value).ToString("N0")

        Dim jumlah As Integer = 0
        Integer.TryParse(row.Cells("jumlah_assign").Value?.ToString(), jumlah)

        btnHapus.Enabled = True
        btnAssign.Enabled = True
        btnUnassign.Enabled = (jumlah > 0)
        btnSimpan.Text = "Update"
        isEdit = True
    End Sub

    '── Assign ─────────────────────────────────────────────
    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        If selectedId = -1 Then Exit Sub
        Dim frm As New PropertiKamarForm()
        frm.SetProperti(selectedId, selectedNama)
        frm.ShowDialog()
        LoadGrid()
        RefreshActionButtons()
    End Sub

    '── Unassign ───────────────────────────────────────────
    Private Sub btnUnassign_Click(sender As Object, e As EventArgs) Handles btnUnassign.Click
        If selectedId = -1 Then Exit Sub
        Dim frm As New UnassignPropertiForm()
        frm.SetProperti(selectedId, selectedNama)
        frm.ShowDialog()
        LoadGrid()
        RefreshActionButtons()
    End Sub

    Private Sub RefreshActionButtons()
        If selectedId = -1 Then Exit Sub
        Try
            Dim dt As DataTable = Database.ExecuteQuery("sp_GetAllProperti", Nothing)
            For Each dr As DataRow In dt.Rows
                If Convert.ToInt32(dr("id_properti")) = selectedId Then
                    Dim jumlah As Integer = Convert.ToInt32(dr("jumlah_assign"))
                    btnUnassign.Enabled = (jumlah > 0)
                    Exit For
                End If
            Next
        Catch
        End Try
    End Sub

    '── CRUD ───────────────────────────────────────────────
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidateForm() Then Exit Sub
        Dim biaya As Decimal = 0
        Decimal.TryParse(txtBiaya.Text.Replace(".", "").Replace(",", ""), biaya)

        Try
            If isEdit Then
                Database.ExecuteNonQuery("sp_UpdateProperti",
                    New Dictionary(Of String, Object) From {
                        {"@id_properti", selectedId},
                        {"@nama_properti", txtNama.Text.Trim()},
                        {"@biaya_denda", biaya}
                    })
                MsgBox("Properti berhasil diupdate.", MsgBoxStyle.Information, "Berhasil")
            Else
                Database.ExecuteNonQuery("sp_InsertProperti",
                    New Dictionary(Of String, Object) From {
                        {"@nama_properti", txtNama.Text.Trim()},
                        {"@biaya_denda", biaya}
                    })
                MsgBox("Properti berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")
            End If
            LoadGrid() : ClearForm()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim konfirm As Boolean = True
        If AppSettingsManager.ConfirmHapus Then
            konfirm = (MsgBox("Yakin ingin menghapus properti ini?",
                              MsgBoxStyle.YesNo Or MsgBoxStyle.Question,
                              "Hapus") = MsgBoxResult.Yes)
        End If
        If Not konfirm Then Exit Sub

        Try
            Database.ExecuteNonQuery("sp_DeleteProperti",
                New Dictionary(Of String, Object) From {{"@id_properti", selectedId}})
            MsgBox("Properti berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
            LoadGrid() : ClearForm()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
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
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MsgBox("Nama properti tidak boleh kosong.", MsgBoxStyle.Exclamation)
            txtNama.Focus() : Return False
        End If
        Dim b As Decimal = 0
        If Not Decimal.TryParse(txtBiaya.Text.Replace(".", "").Replace(",", ""), b) OrElse b < 0 Then
            MsgBox("Biaya denda harus berupa angka >= 0.", MsgBoxStyle.Exclamation)
            txtBiaya.Focus() : Return False
        End If
        Return True
    End Function

End Class