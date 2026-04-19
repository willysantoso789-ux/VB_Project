Public Class DendaForm

    Public Property TotalDendaKerusakan As Decimal = 0

    Private dendaPerHari As Decimal = 0
    Private hariTelat As Integer = 0

    ' ── Static dummy properti per kamar ───────────────────
    ' Nanti diganti dari DB: SELECT * FROM properti WHERE id_kamar = x
    Private Shared ReadOnly DummyProperti As New List(Of PropertiItem) From {
        New PropertiItem("TV 32 Inch", "Baik", 500000),
        New PropertiItem("AC Split 1 PK", "Baik", 750000),
        New PropertiItem("Remote AC", "Baik", 50000),
        New PropertiItem("Lemari Pakaian", "Baik", 300000),
        New PropertiItem("Cermin Dinding", "Baik", 150000),
        New PropertiItem("Meja Kerja", "Baik", 200000),
        New PropertiItem("Kursi", "Baik", 75000),
        New PropertiItem("Lampu Tidur", "Baik", 60000),
        New PropertiItem("Kasur", "Baik", 800000),
        New PropertiItem("Bantal (2 pcs)", "Baik", 100000),
        New PropertiItem("Selimut", "Baik", 80000),
        New PropertiItem("Shower", "Baik", 400000),
        New PropertiItem("Kloset", "Baik", 600000),
        New PropertiItem("Handuk (2 pcs)", "Baik", 60000),
        New PropertiItem("Sabun & Shampoo", "Baik", 30000)
    }

    ' ── Dipanggil dari CheckOutForm ───────────────────────
    Public Sub SetData(idReservasi As Integer, namaTamu As String,
                       kamar As String, hariTelatVal As Integer,
                       dendaPerHariVal As Decimal, existingKerusakan As Decimal)

        dendaPerHari = dendaPerHariVal
        hariTelat = hariTelatVal

        txtIdRes.Text = idReservasi.ToString()
        txtNama.Text = namaTamu
        txtKamar.Text = kamar

        ' Isi denda telat
        txtHariTelat.Text = hariTelat & " hari"
        txtDendaPerHari.Text = "Rp " & dendaPerHari.ToString("N0")

        Dim totalTelat As Decimal = hariTelat * dendaPerHari
        txtTotalTelat.Text = "Rp " & totalTelat.ToString("N0")

        If totalTelat = 0 Then
            txtTotalTelat.BackColor = System.Drawing.Color.FromArgb(209, 250, 229)
            txtTotalTelat.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70)
        Else
            txtTotalTelat.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
            txtTotalTelat.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        End If

        ' Load properti checklist
        LoadProperti()

        ' Hitung ulang kalau ada existing
        TotalDendaKerusakan = existingKerusakan
        HitungTotal()
    End Sub

    ' ── Load daftar properti ke grid ──────────────────────
    Private Sub LoadProperti()
        dgvProperti.Rows.Clear()
        For Each item As PropertiItem In DummyProperti
            Dim i As Integer = dgvProperti.Rows.Add()
            dgvProperti.Rows(i).Cells("colCek").Value = False
            dgvProperti.Rows(i).Cells("colNamaItem").Value = item.Nama
            dgvProperti.Rows(i).Cells("colKondisi").Value = item.Kondisi
            dgvProperti.Rows(i).Cells("colBiayaDenda").Value = item.BiayaDenda.ToString("N0")
        Next
    End Sub

    ' ── Checkbox berubah → hitung ulang ──────────────────
    Private Sub dgvProperti_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProperti.CellValueChanged
        If e.ColumnIndex = dgvProperti.Columns("colCek").Index Then
            HitungTotal()
        End If
    End Sub

    ' Supaya checkbox langsung commit saat diklik
    Private Sub dgvProperti_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvProperti.CurrentCellDirtyStateChanged
        If dgvProperti.IsCurrentCellDirty Then
            dgvProperti.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    ' ── Hitung total ──────────────────────────────────────
    Private Sub HitungTotal()
        Dim totalKerusakan As Decimal = 0

        For Each row As DataGridViewRow In dgvProperti.Rows
            Dim isChecked As Boolean = Convert.ToBoolean(row.Cells("colCek").Value)
            If isChecked Then
                Dim biayaStr As String = row.Cells("colBiayaDenda").Value?.ToString().Replace(",", "").Replace(".", "")
                Dim biaya As Decimal = 0
                Decimal.TryParse(biayaStr, biaya)
                totalKerusakan += biaya

                ' Warna baris yang dicentang
                row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
            Else
                row.DefaultCellStyle.BackColor = System.Drawing.Color.White
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40)
            End If
        Next

        TotalDendaKerusakan = totalKerusakan

        If totalKerusakan = 0 Then
            txtTotalKerusakan.Text = "Rp 0"
            txtTotalKerusakan.BackColor = System.Drawing.Color.FromArgb(209, 250, 229)
            txtTotalKerusakan.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70)
        Else
            txtTotalKerusakan.Text = "Rp " & totalKerusakan.ToString("N0")
            txtTotalKerusakan.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
            txtTotalKerusakan.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        End If

        ' Grand total denda
        Dim totalTelat As Decimal = hariTelat * dendaPerHari
        Dim grandTotal As Decimal = totalTelat + totalKerusakan

        If grandTotal = 0 Then
            txtGrandTotal.Text = "Rp 0"
            txtGrandTotal.BackColor = System.Drawing.Color.FromArgb(209, 250, 229)
            txtGrandTotal.ForeColor = System.Drawing.Color.FromArgb(6, 95, 70)
        Else
            txtGrandTotal.Text = "Rp " & grandTotal.ToString("N0")
            txtGrandTotal.BackColor = System.Drawing.Color.FromArgb(254, 226, 226)
            txtGrandTotal.ForeColor = System.Drawing.Color.FromArgb(153, 27, 27)
        End If
    End Sub

    ' ── Simpan ────────────────────────────────────────────
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        HitungTotal()

        Dim checkedItems As New List(Of String)
        For Each row As DataGridViewRow In dgvProperti.Rows
            If Convert.ToBoolean(row.Cells("colCek").Value) Then
                checkedItems.Add("• " & row.Cells("colNamaItem").Value.ToString() &
                                 " — Rp " & row.Cells("colBiayaDenda").Value.ToString())
            End If
        Next

        Dim detail As String = ""
        If checkedItems.Count > 0 Then
            detail = vbNewLine & "Item Rusak:" & vbNewLine & String.Join(vbNewLine, checkedItems) & vbNewLine
        End If

        MsgBox("Denda berhasil diterapkan." & detail & vbNewLine &
               "Total Denda Kerusakan : Rp " & TotalDendaKerusakan.ToString("N0"),
               MsgBoxStyle.Information, "Denda Disimpan")

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

End Class

' ── Model properti ────────────────────────────────────────
Public Class PropertiItem
    Public Property Nama As String
    Public Property Kondisi As String
    Public Property BiayaDenda As Decimal

    Public Sub New(nama As String, kondisi As String, biaya As Decimal)
        Me.Nama = nama
        Me.Kondisi = kondisi
        Me.BiayaDenda = biaya
    End Sub
End Class