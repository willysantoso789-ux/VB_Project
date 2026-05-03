Imports System.Data

Public Class TipeKamarForm

    Private isEdit As Boolean = False
    Private selectedId As Integer = -1

    Public Shared dtTipeShared As New DataTable()
    Public Shared IsSharedLoaded As Boolean = False

    Private Sub TipeKamarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        ClearForm()
    End Sub

    Private Sub LoadGrid(Optional filter As String = "")
        Try
            Dim dt As DataTable = Database.ExecuteQuery("sp_GetAllTipeKamar", Nothing)
            dtTipeShared = dt
            IsSharedLoaded = True

            If filter <> "" Then
                Dim view As New DataView(dt)
                view.RowFilter = "nama_tipe LIKE '%" & filter & "%'"
                dgvTipe.DataSource = view.ToTable()
            Else
                dgvTipe.DataSource = dt
            End If
            StyleGrid()
        Catch ex As Exception
            MsgBox("Gagal load data tipe kamar: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub StyleGrid()
        If dgvTipe.Columns.Count = 0 Then Exit Sub
        Dim headers As New Dictionary(Of String, String) From {
            {"id_tipe", "ID"}, {"nama_tipe", "Nama Tipe"},
            {"harga", "Harga / Malam"}, {"deskripsi", "Deskripsi"}
        }
        For Each kv In headers
            If dgvTipe.Columns.Contains(kv.Key) Then
                dgvTipe.Columns(kv.Key).HeaderText = kv.Value
            End If
        Next
        If dgvTipe.Columns.Contains("harga") Then
            dgvTipe.Columns("harga").DefaultCellStyle.Format = "N0"
        End If
    End Sub

    Private Sub ClearForm()
        txtIdTipe.Text = "(auto)"
        txtNamaTipe.Clear()
        txtHarga.Clear()
        txtDeskripsi.Clear()
        btnHapus.Enabled = False
        btnSimpan.Text = "Simpan"
        isEdit = False
        selectedId = -1
        txtNamaTipe.Focus()
    End Sub

    Private Sub dgvTipe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipe.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim row As DataGridViewRow = dgvTipe.Rows(e.RowIndex)
        selectedId = Convert.ToInt32(row.Cells("id_tipe").Value)
        txtIdTipe.Text = selectedId.ToString()
        txtNamaTipe.Text = row.Cells("nama_tipe").Value?.ToString()
        txtHarga.Text = Convert.ToDecimal(row.Cells("harga").Value).ToString("N0")
        txtDeskripsi.Text = row.Cells("deskripsi").Value?.ToString()
        btnHapus.Enabled = True
        btnSimpan.Text = "Update"
        isEdit = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidateForm() Then Exit Sub
        Dim harga As Decimal = 0
        Decimal.TryParse(txtHarga.Text.Replace(".", "").Replace(",", ""), harga)
        Try
            If isEdit Then
                Database.ExecuteNonQuery("sp_UpdateTipeKamar",
                    New Dictionary(Of String, Object) From {
                        {"@id_tipe", selectedId}, {"@nama_tipe", txtNamaTipe.Text.Trim()},
                        {"@harga", harga}, {"@deskripsi", txtDeskripsi.Text.Trim()}
                    })
                MsgBox("Tipe kamar berhasil diupdate.", MsgBoxStyle.Information, "Berhasil")
            Else
                Database.ExecuteNonQuery("sp_InsertTipeKamar",
                    New Dictionary(Of String, Object) From {
                        {"@nama_tipe", txtNamaTipe.Text.Trim()},
                        {"@harga", harga},
                        {"@deskripsi", txtDeskripsi.Text.Trim()}
                    })
                MsgBox("Tipe kamar berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")
            End If
            LoadGrid() : ClearForm()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim konfirm As Boolean = True
        If AppSettingsManager.ConfirmHapus Then
            konfirm = (MsgBox("Yakin hapus tipe kamar ini?",
                              MsgBoxStyle.YesNo Or MsgBoxStyle.Question,
                              "Hapus") = MsgBoxResult.Yes)
        End If
        If Not konfirm Then Exit Sub
        Try
            Database.ExecuteNonQuery("sp_DeleteTipeKamar",
                New Dictionary(Of String, Object) From {{"@id_tipe", selectedId}})
            MsgBox("Tipe kamar berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
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
        If String.IsNullOrWhiteSpace(txtNamaTipe.Text) Then
            MsgBox("Nama tipe tidak boleh kosong.", MsgBoxStyle.Exclamation) : txtNamaTipe.Focus() : Return False
        End If
        Dim h As Decimal = 0
        If Not Decimal.TryParse(txtHarga.Text.Replace(".", "").Replace(",", ""), h) OrElse h <= 0 Then
            MsgBox("Harga harus lebih dari 0.", MsgBoxStyle.Exclamation) : txtHarga.Focus() : Return False
        End If
        Return True
    End Function

End Class