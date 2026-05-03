Imports System.Data

Public Class TamuForm

    Private isEdit As Boolean = False
    Private selectedId As Integer = -1

    Private Sub DataTamuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        ClearForm()
    End Sub

    Private Sub LoadGrid(Optional filter As String = "")
        Try
            Dim params As New Dictionary(Of String, Object) From {
                {"@filter", If(filter = "", Nothing, filter)}
            }
            Dim dt As DataTable = Database.ExecuteQuery("sp_GetAllTamu", params)
            dgvTamu.DataSource = dt
            StyleGrid()
        Catch ex As Exception
            MsgBox("Gagal load data tamu:" & vbNewLine & ex.Message,
                   MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub StyleGrid()
        If dgvTamu.Columns.Count = 0 Then Exit Sub

        Dim headers As New Dictionary(Of String, String) From {
            {"id_tamu", "ID"}, {"nik", "NIK"}, {"nama", "Nama Lengkap"},
            {"email", "Email"}, {"no_hp", "No. HP"},
            {"gender", "Gender"}, {"alamat", "Alamat"}
        }
        For Each kv In headers
            If dgvTamu.Columns.Contains(kv.Key) Then
                dgvTamu.Columns(kv.Key).HeaderText = kv.Value
            End If
        Next

        Dim weights As New Dictionary(Of String, Integer) From {
            {"id_tamu", 35}, {"nik", 120}, {"nama", 140},
            {"email", 150}, {"no_hp", 100}, {"gender", 70}, {"alamat", 200}
        }
        For Each kv In weights
            If dgvTamu.Columns.Contains(kv.Key) Then
                dgvTamu.Columns(kv.Key).FillWeight = kv.Value
            End If
        Next

        For Each row As DataGridViewRow In dgvTamu.Rows
            Select Case row.Cells("gender").Value?.ToString()
                Case "Laki-laki"
                    row.Cells("gender").Style.ForeColor = System.Drawing.Color.FromArgb(26, 86, 219)
                    row.Cells("gender").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Perempuan"
                    row.Cells("gender").Style.ForeColor = System.Drawing.Color.FromArgb(157, 23, 77)
                    row.Cells("gender").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            End Select
        Next
    End Sub

    Private Sub ClearForm()
        txtIdTamu.Text = "(auto)"
        txtNIK.Clear()
        txtNama.Clear()
        txtEmail.Clear()
        txtNoHp.Clear()
        cboGender.SelectedIndex = -1
        txtAlamat.Clear()
        btnHapus.Enabled = False
        btnSimpan.Text = "Simpan"
        isEdit = False
        selectedId = -1
        txtNIK.Focus()
    End Sub

    Private Sub dgvTamu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTamu.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim row As DataGridViewRow = dgvTamu.Rows(e.RowIndex)
        selectedId = Convert.ToInt32(row.Cells("id_tamu").Value)
        txtIdTamu.Text = selectedId.ToString()
        txtNIK.Text = row.Cells("nik").Value?.ToString()
        txtNama.Text = row.Cells("nama").Value?.ToString()
        txtEmail.Text = row.Cells("email").Value?.ToString()
        txtNoHp.Text = row.Cells("no_hp").Value?.ToString()
        txtAlamat.Text = row.Cells("alamat").Value?.ToString()
        cboGender.SelectedItem = row.Cells("gender").Value?.ToString()
        btnHapus.Enabled = True
        btnSimpan.Text = "Update"
        isEdit = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidateForm() Then Exit Sub
        Try
            If isEdit Then
                Dim params As New Dictionary(Of String, Object) From {
                    {"@id_tamu", selectedId},
                    {"@nik", txtNIK.Text.Trim()},
                    {"@nama", txtNama.Text.Trim()},
                    {"@email", txtEmail.Text.Trim()},
                    {"@no_hp", txtNoHp.Text.Trim()},
                    {"@gender", cboGender.SelectedItem.ToString()},
                    {"@alamat", txtAlamat.Text.Trim()}
                }
                Database.ExecuteNonQuery("sp_UpdateTamu", params)
                MsgBox("Data tamu berhasil diupdate.", MsgBoxStyle.Information, "Berhasil")
            Else
                Dim params As New Dictionary(Of String, Object) From {
                    {"@nik", txtNIK.Text.Trim()},
                    {"@nama", txtNama.Text.Trim()},
                    {"@email", txtEmail.Text.Trim()},
                    {"@no_hp", txtNoHp.Text.Trim()},
                    {"@gender", cboGender.SelectedItem.ToString()},
                    {"@alamat", txtAlamat.Text.Trim()}
                }
                Database.ExecuteNonQuery("sp_InsertTamu", params)
                MsgBox("Data tamu berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")
            End If
            LoadGrid() : ClearForm()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim konfirm As Boolean = True
        If AppSettingsManager.ConfirmHapus Then
            konfirm = (MsgBox("Yakin ingin menghapus tamu ini?",
                              MsgBoxStyle.YesNo Or MsgBoxStyle.Question,
                              "Hapus") = MsgBoxResult.Yes)
        End If
        If Not konfirm Then Exit Sub

        Try
            Database.ExecuteNonQuery("sp_DeleteTamu",
                New Dictionary(Of String, Object) From {{"@id_tamu", selectedId}})
            MsgBox("Data tamu berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
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
        If String.IsNullOrWhiteSpace(txtNIK.Text) OrElse txtNIK.Text.Trim().Length <> 16 Then
            MsgBox("NIK harus 16 digit.", MsgBoxStyle.Exclamation) : txtNIK.Focus() : Return False
        End If
        If Not txtNIK.Text.Trim().All(Function(c) Char.IsDigit(c)) Then
            MsgBox("NIK harus berupa angka.", MsgBoxStyle.Exclamation) : txtNIK.Focus() : Return False
        End If
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MsgBox("Nama tidak boleh kosong.", MsgBoxStyle.Exclamation) : txtNama.Focus() : Return False
        End If
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MsgBox("Email tidak boleh kosong.", MsgBoxStyle.Exclamation) : txtEmail.Focus() : Return False
        End If
        If cboGender.SelectedIndex = -1 Then
            MsgBox("Pilih jenis kelamin.", MsgBoxStyle.Exclamation) : cboGender.Focus() : Return False
        End If
        Return True
    End Function

End Class