Imports System.Data

Public Class PropertiKamarForm

    Private idProperti As Integer = -1
    Private namaProperti As String = ""

    ' Shared table: properti_kamar (id_properti, id_kamar)
    ' Nanti ganti ke DB
    Public Shared dtAssignment As New DataTable()
    Public Shared IsAssignLoaded As Boolean = False

    Private Sub PropertiKamarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitAssignmentTable()
        LoadKamarGrid()
    End Sub

    ' ── Init tabel assignment kalau belum ada ─────────────
    Private Sub InitAssignmentTable()
        If Not IsAssignLoaded Then
            dtAssignment.Columns.Add("id_properti", GetType(Integer))
            dtAssignment.Columns.Add("id_kamar", GetType(Integer))
            IsAssignLoaded = True
        End If
    End Sub

    ' ── Dipanggil dari PropertiForm ───────────────────────
    Public Sub SetProperti(id As Integer, nama As String)
        idProperti = id
        namaProperti = nama
    End Sub

    Private Sub PropertiKamarForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Isi info properti
        txtNamaProp.Text = namaProperti

        ' Cari biaya denda dari shared data
        If PropertiForm.IsSharedLoaded Then
            For Each dr As DataRow In PropertiForm.dtPropertiShared.Rows
                If Convert.ToInt32(dr("id_properti")) = idProperti Then
                    txtBiaya.Text = "Rp " & Convert.ToDecimal(dr("biaya_denda")).ToString("N0")
                    Exit For
                End If
            Next
        End If

        LoadKamarGrid()
    End Sub

    ' ── Load semua kamar dengan checkbox assignment ────────
    Private Sub LoadKamarGrid()
        dgvKamar.Rows.Clear()

        ' Dummy kamar — nanti dari DataKamarForm.dtKamarShared
        Dim kamarList As New List(Of Object()) From {
            New Object() {1, "101", "Standard", "Tersedia"},
            New Object() {2, "102", "Standard", "Terisi"},
            New Object() {3, "201", "Deluxe", "Tersedia"},
            New Object() {4, "202", "Deluxe", "Maintenance"},
            New Object() {5, "301", "Suite", "Tersedia"}
        }

        For Each k As Object() In kamarList
            Dim idKamar As Integer = Convert.ToInt32(k(0))

            ' Cek apakah sudah di-assign
            Dim sudahAssign As Boolean = False
            For Each dr As DataRow In dtAssignment.Rows
                If Convert.ToInt32(dr("id_properti")) = idProperti AndAlso
                   Convert.ToInt32(dr("id_kamar")) = idKamar Then
                    sudahAssign = True
                    Exit For
                End If
            Next

            Dim i As Integer = dgvKamar.Rows.Add()
            dgvKamar.Rows(i).Cells("colCek").Value = sudahAssign
            dgvKamar.Rows(i).Cells("colIdKamar").Value = idKamar
            dgvKamar.Rows(i).Cells("colNomorKamar").Value = k(1).ToString()
            dgvKamar.Rows(i).Cells("colTipeKamar").Value = k(2).ToString()
            dgvKamar.Rows(i).Cells("colStatusKamar").Value = k(3).ToString()

            If sudahAssign Then
                dgvKamar.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 243, 255)
                dgvKamar.Rows(i).DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(91, 33, 182)
            End If
        Next

        UpdateSummary()
    End Sub

    ' ── Checkbox berubah → update summary ─────────────────
    Private Sub dgvKamar_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKamar.CellValueChanged
        If e.RowIndex < 0 OrElse e.RowIndex >= dgvKamar.Rows.Count Then Exit Sub
        If e.ColumnIndex = dgvKamar.Columns("colCek").Index Then
            Dim row As DataGridViewRow = dgvKamar.Rows(e.RowIndex)
            Dim isChecked As Boolean = Convert.ToBoolean(row.Cells("colCek").Value)

            If isChecked Then
                row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 243, 255)
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(91, 33, 182)
            Else
                row.DefaultCellStyle.BackColor = System.Drawing.Color.White
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
            End If

            UpdateSummary()
        End If
    End Sub

    Private Sub dgvKamar_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvKamar.CurrentCellDirtyStateChanged
        If dgvKamar.IsCurrentCellDirty Then
            dgvKamar.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub UpdateSummary()
        Dim count As Integer = 0
        Dim nomorList As New List(Of String)

        For Each row As DataGridViewRow In dgvKamar.Rows
            If Convert.ToBoolean(row.Cells("colCek").Value) Then
                count += 1
                nomorList.Add("No." & row.Cells("colNomorKamar").Value.ToString())
            End If
        Next

        If count = 0 Then
            txtSummary.Text = "0 kamar dipilih"
            txtSummary.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
            txtSummary.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
        Else
            txtSummary.Text = count & " kamar: " & String.Join(", ", nomorList)
            txtSummary.BackColor = System.Drawing.Color.FromArgb(245, 243, 255)
            txtSummary.ForeColor = System.Drawing.Color.FromArgb(91, 33, 182)
        End If
    End Sub

    ' ── Simpan assignment ─────────────────────────────────
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Hapus assignment lama untuk properti ini
        Dim toRemove As New List(Of DataRow)
        For Each dr As DataRow In dtAssignment.Rows
            If Convert.ToInt32(dr("id_properti")) = idProperti Then
                toRemove.Add(dr)
            End If
        Next
        For Each dr As DataRow In toRemove
            dtAssignment.Rows.Remove(dr)
        Next

        ' Simpan assignment baru dari checklist
        Dim assignedKamar As New List(Of String)
        For Each row As DataGridViewRow In dgvKamar.Rows
            If Convert.ToBoolean(row.Cells("colCek").Value) Then
                Dim idKamar As Integer = Convert.ToInt32(row.Cells("colIdKamar").Value)
                dtAssignment.Rows.Add(idProperti, idKamar)
                assignedKamar.Add("No." & row.Cells("colNomorKamar").Value.ToString())
            End If
        Next

        Dim detail As String = If(assignedKamar.Count > 0,
                                  vbNewLine & String.Join(", ", assignedKamar),
                                  "Tidak ada kamar")

        MsgBox("Assignment berhasil disimpan!" & vbNewLine &
               namaProperti & " → " & detail,
               MsgBoxStyle.Information, "Berhasil")

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

End Class