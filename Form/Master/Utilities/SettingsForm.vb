Public Class SettingsForm

    ' Settings disimpan di My.Settings
    ' Tambahkan di Project → Properties → Settings:
    ' NamaHotel     (String)
    ' AlamatHotel   (String)
    ' TelpHotel     (String)
    ' DendaPersen   (Integer) default 50
    ' ConfirmLogout (Boolean) default True
    ' ConfirmHapus  (Boolean) default True
    ' ShowClock     (Boolean) default True
    ' DbServer      (String)  default localhost\SQLEXPRESS
    ' DbName        (String)  default HotelDB
    ' Tema          (String)  default Biru (Default)
    ' Bahasa        (String)  default Bahasa Indonesia

    Public Shared NamaHotel As String = "Hotel Receptionist System"
    Public Shared AlamatHotel As String = ""
    Public Shared TelpHotel As String = ""
    Public Shared DendaPersen As Integer = 50
    Public Shared ConfirmLogout As Boolean = True
    Public Shared ConfirmHapus As Boolean = True

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub

    Private Sub LoadSettings()
        txtNamaHotel.Text = NamaHotel
        txtAlamatHotel.Text = AlamatHotel
        txtTelpHotel.Text = TelpHotel
        nudDendaPersen.Value = DendaPersen
        chkConfirmLogout.Checked = ConfirmLogout
        chkConfirmHapus.Checked = ConfirmHapus
        chkShowClock.Checked = True
        cboBahasa.SelectedIndex = 0
        cboTema.SelectedIndex = 0
        txtDbServer.Text = "localhost\SQLEXPRESS"
        txtDbName.Text = "HotelDB"
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        NamaHotel = txtNamaHotel.Text.Trim()
        AlamatHotel = txtAlamatHotel.Text.Trim()
        TelpHotel = txtTelpHotel.Text.Trim()
        DendaPersen = Convert.ToInt32(nudDendaPersen.Value)
        ConfirmLogout = chkConfirmLogout.Checked
        ConfirmHapus = chkConfirmHapus.Checked

        MsgBox("Settings berhasil disimpan.", MsgBoxStyle.Information, "Berhasil")
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If MsgBox("Reset semua settings ke default?",
                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Reset") = MsgBoxResult.Yes Then
            NamaHotel = "Hotel Receptionist System"
            AlamatHotel = ""
            TelpHotel = ""
            DendaPersen = 50
            ConfirmLogout = True
            ConfirmHapus = True
            LoadSettings()
            MsgBox("Settings berhasil direset.", MsgBoxStyle.Information, "Reset")
        End If
    End Sub

    Private Sub btnTestConn_Click(sender As Object, e As EventArgs) Handles btnTestConn.Click
        Try
            Dim connStr As String = "Data Source=" & txtDbServer.Text &
                                    ";Initial Catalog=" & txtDbName.Text &
                                    ";Integrated Security=True;"
            Using conn As New System.Data.SqlClient.SqlConnection(connStr)
                conn.Open()
                MsgBox("Koneksi database berhasil!", MsgBoxStyle.Information, "Koneksi OK")
            End Using
        Catch ex As Exception
            MsgBox("Koneksi gagal:" & vbNewLine & ex.Message,
                   MsgBoxStyle.Critical, "Koneksi Gagal")
        End Try
    End Sub

End Class