Imports System.Data

Public Class CheckOutForm

    Private selectedId As Integer = -1
    Private selectedIdKamar As Integer = -1
    Private hargaPerMalam As Decimal = 0
    Private tglCheckinAktual As DateTime
    Private tglCheckoutRencana As DateTime
    Public dendaKerusakanTotal As Decimal = 0

    Private Sub CheckOutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        ClearForm()
    End Sub

    Private Sub LoadGrid(Optional filter As String = "")
        Try
            Dim filterStatus As String = cboFilter.SelectedItem?.ToString()
            Dim params As New Dictionary(Of String, Object) From {
                {"@filter", If(filter = "", Nothing, filter)},
                {"@status", If(filterStatus = "Semua" OrElse filterStatus = "", Nothing, filterStatus)}
            }
            Dim dt As DataTable = Database.ExecuteQuery("sp_GetAllReservasi", params)

            ' Default filter: Checked-In
            Dim view As New DataView(dt)
            If filterStatus = "Semua" Then
                view.RowFilter = "status IN ('Checked-In','Checked-Out')"
            ElseIf filterStatus <> "" Then
                view.RowFilter = "status = '" & filterStatus & "'"
            Else
                view.RowFilter = "status = 'Checked-In'"
            End If

            ' Filter tambahan by nomor kamar
            If filter <> "" Then
                Dim existing As String = view.RowFilter
                Dim addFilter As String = "nomor_kamar LIKE '%" & filter & "%'"
                view.RowFilter = If(existing = "", addFilter, "(" & existing & ") AND " & addFilter)
            End If

            dgvCheckOut.DataSource = view.ToTable()
            StyleGrid()
        Catch ex As Exception
            MsgBox("Gagal load data: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub StyleGrid()
        If dgvCheckOut.Columns.Count = 0 Then Exit Sub

        Dim headers As New Dictionary(Of String, String) From {
            {"id_reservasi", "ID"}, {"nama_tamu", "Nama Tamu"}, {"nomor_kamar", "No. Kamar"},
            {"harga_kamar", "Harga/Malam"}, {"tanggal_checkin", "Check-In"},
            {"tanggal_checkout", "Check-Out (Rencana)"}, {"status", "Status"}
        }
        For Each kv In headers
            If dgvCheckOut.Columns.Contains(kv.Key) Then
                dgvCheckOut.Columns(kv.Key).HeaderText = kv.Value
            End If
        Next

        For Each col As String In {"id_kamar", "id_tamu", "nik", "no_hp",
                                    "tipe_reservasi", "tanggal_reservasi", "nama_tipe"}
            If dgvCheckOut.Columns.Contains(col) Then
                dgvCheckOut.Columns(col).Visible = False
            End If
        Next

        If dgvCheckOut.Columns.Contains("harga_kamar") Then
            dgvCheckOut.Columns("harga_kamar").DefaultCellStyle.Format = "N0"
        End If

        For Each row As DataGridViewRow In dgvCheckOut.Rows
            Select Case row.Cells("status").Value?.ToString()
                Case "Checked-In"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(26, 86, 219)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                Case "Checked-Out"
                    row.Cells("status").Style.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100)
                    row.Cells("status").Style.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            End Select
        Next
    End Sub

    Private Sub dgvCheckOut_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCheckOut.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim row As DataGridViewRow = dgvCheckOut.Rows(e.RowIndex)
        Dim status As String = row.Cells("status").Value?.ToString()

        selectedId = Convert.ToInt32(row.Cells("id_reservasi").Value)
        selectedIdKamar = Convert.ToInt32(row.Cells("id_kamar").Value)
        hargaPerMalam = Convert.ToDecimal(row.Cells("harga_kamar").Value)
        tglCheckinAktual = Convert.ToDateTime(row.Cells("tanggal_checkin").Value)
        tglCheckoutRencana = Convert.ToDateTime(row.Cells("tanggal_checkout").Value)
        dendaKerusakanTotal = 0

        txtIdReservasi.Text = selectedId.ToString()
        txtNamaTamu.Text = row.Cells("nama_tamu").Value?.ToString()
        txtKamar.Text = "No. " & row.Cells("nomor_kamar").Value?.ToString()
        txtHarga.Text = "Rp " & hargaPerMalam.ToString("N0") & " / malam"
        txtTglCheckin.Text = tglCheckinAktual.ToString("dd/MM/yyyy")
        txtTglCheckout.Text = tglCheckoutRencana.ToString("dd/MM/yyyy")
        txtTglAktual.Text = DateTime.Today.ToString("dd/MM/yyyy") & "  (Hari Ini — Tidak dapat diubah)"
        txtDendaKerusakan.Text = "Rp 0"

        HitungSemua()

        If status = "Checked-Out" Then
            btnCheckOut.Enabled = False : btnCheckOut.Text = "Sudah Check-Out"
            btnDenda.Enabled = False
        ElseIf status = "Checked-In" Then
            btnCheckOut.Enabled = True : btnCheckOut.Text = "Proses Check-Out"
            btnDenda.Enabled = True
        Else
            btnCheckOut.Enabled = False : btnDenda.Enabled = False
        End If
    End Sub

    Private Sub HitungSemua()
        Dim tglCO As DateTime = DateTime.Today
        If tglCO <= tglCheckinAktual Then
            txtMalam.Text = "Tanggal tidak valid" : txtTotal.Text = "Rp 0" : Return
        End If

        Dim totalMalam As Integer = (tglCO - tglCheckinAktual).Days
        Dim biayaKamar As Decimal = totalMalam * hargaPerMalam

        ' Denda minimum 100% dari settings
        Dim persen As Decimal = AppSettingsManager.PersenDenda / 100D
        Dim dendaPerHari As Decimal = hargaPerMalam * persen
        Dim hariTelat As Integer = 0
        Dim dendaTelat As Decimal = 0

        If tglCO > tglCheckoutRencana Then
            hariTelat = (tglCO - tglCheckoutRencana).Days
            dendaTelat = hariTelat * dendaPerHari
        End If

        Dim grandTotal As Decimal = biayaKamar + dendaTelat + dendaKerusakanTotal

        txtMalam.Text = totalMalam & " malam"
        txtBiayaKamar.Text = "Rp " & biayaKamar.ToString("N0")

        If hariTelat > 0 Then
            txtDendaTelat.Text = "Rp " & dendaTelat.ToString("N0") &
                                      " (" & hariTelat & " hari × " &
                                      AppSettingsManager.PersenDenda & "% harga kamar)"
            txtDendaTelat.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
            txtDendaTelat.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        Else
            txtDendaTelat.Text = "Rp 0  (Tepat waktu)"
            txtDendaTelat.BackColor = System.Drawing.Color.FromArgb(209, 250, 229)
            txtDendaTelat.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70)
        End If

        txtDendaKerusakan.Text = "Rp " & dendaKerusakanTotal.ToString("N0")
        txtTotal.Text = "Rp " & grandTotal.ToString("N0")
    End Sub

    Private Sub btnDenda_Click(sender As Object, e As EventArgs) Handles btnDenda.Click
        If selectedId = -1 Then Exit Sub

        Dim tglCO As DateTime = DateTime.Today
        Dim hariTelat As Integer = 0
        Dim dendaPerHari As Decimal = hargaPerMalam * (AppSettingsManager.PersenDenda / 100D)

        If tglCO > tglCheckoutRencana Then
            hariTelat = (tglCO - tglCheckoutRencana).Days
        End If

        Dim frm As New DendaForm()
        frm.SetData(selectedId, txtNamaTamu.Text, txtKamar.Text,
                    selectedIdKamar, hariTelat, dendaPerHari, dendaKerusakanTotal)
        frm.ShowDialog()

        dendaKerusakanTotal = frm.TotalDendaKerusakan
        txtDendaKerusakan.Text = "Rp " & dendaKerusakanTotal.ToString("N0")
        txtDendaKerusakan.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        txtDendaKerusakan.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)

        HitungSemua()
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        If selectedId = -1 Then
            MsgBox("Pilih tamu dari daftar.", MsgBoxStyle.Exclamation) : Exit Sub
        End If
        If cboMetode.SelectedIndex = -1 Then
            MsgBox("Pilih metode pembayaran.", MsgBoxStyle.Exclamation) : cboMetode.Focus() : Exit Sub
        End If

        If MsgBox("Konfirmasi Check-Out:" & vbNewLine &
                  "Tamu   : " & txtNamaTamu.Text & vbNewLine &
                  "Kamar  : " & txtKamar.Text & vbNewLine &
                  "Total  : " & txtTotal.Text & vbNewLine &
                  "Metode : " & cboMetode.SelectedItem.ToString() & vbNewLine & vbNewLine &
                  "Lanjutkan?",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question,
                  "Konfirmasi Check-Out") = MsgBoxResult.Yes Then
            Try
                ' Hitung denda kerusakan dari DendaForm
                Dim tglCO As DateTime = DateTime.Today
                Dim hariTelat As Integer = 0
                If tglCO > tglCheckoutRencana Then
                    hariTelat = (tglCO - tglCheckoutRencana).Days
                End If
                Dim dendaTelat As Decimal = hariTelat *
                    (hargaPerMalam * (AppSettingsManager.PersenDenda / 100D))

                Dim params As New Dictionary(Of String, Object) From {
                    {"@id_reservasi", selectedId},
                    {"@id_user", MainForm.SessionUserId},
                    {"@tgl_checkout_aktual", tglCO},
                    {"@metode_pembayaran", cboMetode.SelectedItem.ToString()},
                    {"@denda_kerusakan", dendaKerusakanTotal},
                    {"@persen_denda", AppSettingsManager.PersenDenda}
                }

                Dim idTransaksi As Object = Database.ExecuteWithOutput(
                    "sp_ProsesCheckOut", params, "@id_transaksi")

                MsgBox("Check-Out berhasil!" & vbNewLine &
                       "ID Transaksi: " & idTransaksi.ToString() & vbNewLine &
                       "Total Bayar: " & txtTotal.Text,
                       MsgBoxStyle.Information, "Berhasil")

                LoadGrid() : ClearForm()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub

    Private Sub cboFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilter.SelectedIndexChanged
        LoadGrid(txtCari.Text.Trim())
    End Sub
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        LoadGrid(txtCari.Text.Trim())
    End Sub
    Private Sub txtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then LoadGrid(txtCari.Text.Trim())
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtCari.Clear() : cboFilter.SelectedIndex = 0 : LoadGrid() : ClearForm()
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        selectedId = -1
        selectedIdKamar = -1
        hargaPerMalam = 0
        dendaKerusakanTotal = 0
        txtIdReservasi.Text = ""
        txtNamaTamu.Text = ""
        txtKamar.Text = ""
        txtHarga.Text = ""
        txtTglCheckin.Text = ""
        txtTglCheckout.Text = ""
        txtTglAktual.Text = DateTime.Today.ToString("dd/MM/yyyy") & "  (Hari Ini)"
        txtMalam.Text = ""
        txtBiayaKamar.Text = ""
        txtDendaTelat.Text = "Rp 0"
        txtDendaKerusakan.Text = "Rp 0"
        txtTotal.Text = "Rp 0"
        cboMetode.SelectedIndex = -1
        btnCheckOut.Enabled = False
        btnCheckOut.Text = "Proses Check-Out"
        btnDenda.Enabled = False
    End Sub

End Class