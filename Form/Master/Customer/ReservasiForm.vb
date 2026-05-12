Imports VB_PROJECT.HotelDBDataSetTableAdapters

Public Class ReservasiForm

    Private isEdit As Boolean = False

    Private Sub ReservasiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTamuCombo()
        LoadKamarCombo()
        RefreshData()
        ClearForm()
    End Sub

    Private Sub RefreshData()
        Me.Vw_DataReservasiTableAdapter.Fill(Me.HotelDBDataSet.vw_DataReservasi)
    End Sub

    Private Sub LoadTamuCombo()
        ' sp_GetAllTamu punya @filter → GetData(@filter)
        Dim dt = New sp_GetAllTamuTableAdapter().GetData(Nothing)
        cboTamu.DataSource = dt
        cboTamu.DisplayMember = "nama"
        cboTamu.ValueMember = "id_tamu"
        cboTamu.SelectedIndex = -1
    End Sub

    Private Sub LoadKamarCombo()
        Dim dt = New sp_GetKamarTersediaTableAdapter().GetData()
        cboKamar.DataSource = dt
        cboKamar.DisplayMember = "nomor_kamar"
        cboKamar.ValueMember = "id_kamar"
        cboKamar.SelectedIndex = -1
    End Sub

    Private Sub cboKamar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKamar.SelectedIndexChanged
        If cboKamar.SelectedIndex = -1 Then txtHargaKamar.Text = "" : Exit Sub
        Dim row As System.Data.DataRowView = CType(cboKamar.SelectedItem, System.Data.DataRowView)
        txtHargaKamar.Text = "Rp " & Convert.ToDecimal(row("harga")).ToString("N0") & " / malam"
    End Sub

    Private Sub cboTipe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipe.SelectedIndexChanged
        cboStatus.SelectedItem = "Pending"
    End Sub

    Private Sub dgvReservasi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservasi.CellClick
        If dgvReservasi.SelectedRows.Count = 0 Then Exit Sub

        ' [0]=ID Reservasi [1]=NIK Tamu [2]=Nama Tamu [3]=No.HP [4]=Nomor Kamar
        ' [5]=Tipe Kamar [6]=Tipe Reservasi [7]=Tgl Reservasi [8]=Tgl Check-In
        ' [9]=Tgl Check-Out [10]=Durasi [11]=Harga/Malam [12]=Estimasi Biaya [13]=Status
        txtIdReservasi.Text = dgvReservasi.SelectedRows(0).Cells(0).Value
        cboStatus.SelectedItem = dgvReservasi.SelectedRows(0).Cells(13).Value

        dtpTglReservasi.Value = ParseTanggal(dgvReservasi.SelectedRows(0).Cells(7).Value?.ToString())
        dtpTglCheckin.Value = ParseTanggal(dgvReservasi.SelectedRows(0).Cells(8).Value?.ToString())
        dtpTglCheckout.Value = ParseTanggal(dgvReservasi.SelectedRows(0).Cells(9).Value?.ToString())

        cboTipe.SelectedItem = dgvReservasi.SelectedRows(0).Cells(6).Value?.ToString()
        txtHargaKamar.Text = dgvReservasi.SelectedRows(0).Cells(11).Value?.ToString()

        ' Set tamu via NIK [1]
        Dim nik As String = dgvReservasi.SelectedRows(0).Cells(1).Value?.ToString()
        Dim dtTamu As System.Data.DataTable = CType(cboTamu.DataSource, System.Data.DataTable)
        If dtTamu IsNot Nothing Then
            For Each dr As System.Data.DataRow In dtTamu.Rows
                If dr("nik").ToString() = nik Then
                    cboTamu.SelectedValue = dr("id_tamu") : Exit For
                End If
            Next
        End If

        Dim st As String = dgvReservasi.SelectedRows(0).Cells(13).Value?.ToString()
        btnHapus.Enabled = st = "Pending"
        btnSimpan.Text = "Update"
        isEdit = True
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidateForm() Then Exit Sub
        Try
            If isEdit Then
                Dim idRes As Integer = Convert.ToInt32(dgvReservasi.SelectedRows(0).Cells(0).Value)
                Dim idTamu As Integer = Convert.ToInt32(cboTamu.SelectedValue)
                Dim noKamar As String = dgvReservasi.SelectedRows(0).Cells(4).Value?.ToString()
                Dim idKamar As Integer = GetIdKamarByNomor(noKamar)
                ' sp_UpdateReservasi(@id_reservasi, @id_tamu, @id_kamar, @tipe_reservasi,
                '                    @tgl_reservasi, @tgl_checkin, @tgl_checkout, @status)
                QueriesTableAdapter1.sp_UpdateReservasi(
                    idRes, idTamu, idKamar,
                    cboTipe.SelectedItem.ToString(),
                    dtpTglReservasi.Value.Date, dtpTglCheckin.Value.Date, dtpTglCheckout.Value.Date,
                    cboStatus.SelectedItem.ToString())
                MsgBox("Reservasi berhasil diupdate.", MsgBoxStyle.Information, "Berhasil")
            Else
                Dim idTamu As Integer = Convert.ToInt32(cboTamu.SelectedValue)
                Dim idKamar As Integer = Convert.ToInt32(cboKamar.SelectedValue)
                Dim status As String = "Pending"
                ' sp_InsertReservasi(@id_tamu, @id_kamar, @tipe_reservasi,
                '                    @tgl_reservasi, @tgl_checkin, @tgl_checkout, @status)
                QueriesTableAdapter1.sp_InsertReservasi(
                    idTamu, idKamar,
                    cboTipe.SelectedItem.ToString(),
                    dtpTglReservasi.Value.Date, dtpTglCheckin.Value.Date, dtpTglCheckout.Value.Date, status)
                MsgBox("Reservasi berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")
            End If
            RefreshData() : LoadKamarCombo() : ClearForm()
        Catch ex As Exception
            MsgBox("Gagal: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvReservasi.SelectedRows.Count = 0 Then Exit Sub
        Dim konfirm As Boolean = True
        If AppSettingsManager.ConfirmHapus Then
            konfirm = (MsgBox("Yakin hapus reservasi ini?",
                              MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Hapus") = MsgBoxResult.Yes)
        End If
        If Not konfirm Then Exit Sub
        Try
            Dim id As Integer = Convert.ToInt32(dgvReservasi.SelectedRows(0).Cells(0).Value)
            ' sp_DeleteReservasi(@id_reservasi)
            QueriesTableAdapter1.sp_DeleteReservasi(id)
            MsgBox("Reservasi berhasil dihapus.", MsgBoxStyle.Information, "Berhasil")
            RefreshData() : LoadKamarCombo() : ClearForm()
        Catch ex As Exception
            MsgBox("Gagal: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        ApplyFilter(txtCari.Text.Trim())
    End Sub
    Private Sub txtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then ApplyFilter(txtCari.Text.Trim())
    End Sub
    Private Sub ApplyFilter(keyword As String)
        VwDataReservasiBindingSource.Filter = If(keyword = "", "",
            "[NIK Tamu] LIKE '" & keyword & "%' OR [Nama Tamu] LIKE '%" & keyword &
            "%' OR [Nomor Kamar] LIKE '%" & keyword & "%'")
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtCari.Clear() : VwDataReservasiBindingSource.Filter = ""
        RefreshData() : LoadKamarCombo() : ClearForm()
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        txtIdReservasi.Text = "(auto)"
        cboTipe.SelectedIndex = -1
        cboTamu.SelectedIndex = -1
        cboKamar.SelectedIndex = -1
        txtHargaKamar.Text = ""
        dtpTglReservasi.Value = DateTime.Today
        dtpTglCheckin.Value = DateTime.Today
        dtpTglCheckout.Value = DateTime.Today.AddDays(1)
        cboStatus.SelectedIndex = -1
        btnHapus.Enabled = False
        btnSimpan.Text = "Simpan"
        isEdit = False
        LoadKamarCombo()
    End Sub

    Private Function ParseTanggal(val As String) As DateTime
        Dim result As DateTime = DateTime.Today
        If String.IsNullOrEmpty(val) Then Return result
        DateTime.TryParseExact(val, "dd/MM/yyyy",
            Globalization.CultureInfo.InvariantCulture,
            Globalization.DateTimeStyles.None, result)
        Return result
    End Function


    Private Function GetIdKamarByNomor(nomor As String) As Integer
        Dim dt = New sp_GetAllKamarTableAdapter().GetData()
        For Each dr As System.Data.DataRow In dt.Rows
            If dr("nomor_kamar").ToString() = nomor Then Return Convert.ToInt32(dr("id_kamar"))
        Next
        Return -1
    End Function

    Private Function ValidateForm() As Boolean
        If cboTipe.SelectedIndex = -1 Then
            MsgBox("Pilih tipe reservasi.", MsgBoxStyle.Exclamation) : cboTipe.Focus() : Return False
        End If
        If cboTamu.SelectedIndex = -1 Then
            MsgBox("Pilih tamu.", MsgBoxStyle.Exclamation) : cboTamu.Focus() : Return False
        End If
        If Not isEdit AndAlso cboKamar.SelectedIndex = -1 Then
            MsgBox("Pilih kamar.", MsgBoxStyle.Exclamation) : cboKamar.Focus() : Return False
        End If
        If dtpTglCheckout.Value.Date <= dtpTglCheckin.Value.Date Then
            MsgBox("Tanggal check-out harus setelah check-in.", MsgBoxStyle.Exclamation) : Return False
        End If
        Return True
    End Function

End Class