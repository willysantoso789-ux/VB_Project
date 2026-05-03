Imports System.IO
Imports System.Xml

Public Module AppSettingsManager

    ' ── Setiap user punya file XML sendiri ────────────────
    ' Path: AppData\Roaming\HotelApp\settings_{username}.xml
    Private Function GetSettingsPath(username As String) As String
        Dim folder As String = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "HotelReceptionistApp")
        If Not Directory.Exists(folder) Then Directory.CreateDirectory(folder)
        Return Path.Combine(folder, "settings_" & SanitizeFilename(username) & ".xml")
    End Function

    Private Function SanitizeFilename(name As String) As String
        Dim invalid As Char() = Path.GetInvalidFileNameChars()
        Dim result As String = name
        For Each c As Char In invalid
            result = result.Replace(c, "_"c)
        Next
        Return result.ToLower()
    End Function

    ' ── Properties preferensi tampilan per user ───────────
    Public ShowClock As Boolean = True
    Public ConfirmLogout As Boolean = True
    Public ConfirmHapus As Boolean = True
    Public PersenDenda As Integer = 100  ' Minimum 100%
    Public CurrentUsername As String = ""

    ' ── Connection string — hardcode atau dari config ──────
    ' Ubah sesuai server kamu
    Public ReadOnly Property ConnString As String
        Get
            Return "Data Source=localhost\SQLEXPRESS;" &
                   "Initial Catalog=HotelDB;" &
                   "Integrated Security=True;" &
                   "Connect Timeout=10;"
        End Get
    End Property

    ' ── Load settings untuk user yang login ───────────────
    Public Sub LoadSettings(username As String)
        CurrentUsername = username
        Dim path As String = GetSettingsPath(username)

        If Not File.Exists(path) Then
            SaveSettings(username)
            Return
        End If

        Try
            Dim doc As New XmlDocument()
            doc.Load(path)

            ShowClock = ReadBool(doc, "Preferensi/ShowClock", True)
            ConfirmLogout = ReadBool(doc, "Preferensi/ConfirmLogout", True)
            ConfirmHapus = ReadBool(doc, "Preferensi/ConfirmHapus", True)
            PersenDenda = ReadInt(doc, "Preferensi/PersenDenda", 100)

            ' Validasi: denda tidak boleh di bawah 100%
            If PersenDenda < 100 Then PersenDenda = 100

        Catch ex As Exception
            ResetToDefault(username)
        End Try
    End Sub

    ' ── Simpan settings untuk user tertentu ───────────────
    Public Sub SaveSettings(username As String)
        Try
            Dim path As String = GetSettingsPath(username)
            Dim doc As New XmlDocument()

            Dim decl As XmlDeclaration = doc.CreateXmlDeclaration("1.0", "utf-8", Nothing)
            doc.AppendChild(decl)

            Dim root As XmlElement = doc.CreateElement("HotelUserSettings")
            doc.AppendChild(root)

            ' Metadata
            Dim meta As XmlElement = doc.CreateElement("Metadata")
            AppendChild(doc, meta, "Username", username)
            AppendChild(doc, meta, "LastSaved", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            root.AppendChild(meta)

            ' Preferensi
            Dim pref As XmlElement = doc.CreateElement("Preferensi")
            AppendChild(doc, pref, "ShowClock", ShowClock.ToString().ToLower())
            AppendChild(doc, pref, "ConfirmLogout", ConfirmLogout.ToString().ToLower())
            AppendChild(doc, pref, "ConfirmHapus", ConfirmHapus.ToString().ToLower())
            AppendChild(doc, pref, "PersenDenda", PersenDenda.ToString())
            root.AppendChild(pref)

            Dim writerSettings As New XmlWriterSettings()
            writerSettings.Indent = True
            writerSettings.IndentChars = "  "
            writerSettings.Encoding = System.Text.Encoding.UTF8

            Using writer As XmlWriter = XmlWriter.Create(path, writerSettings)
                doc.WriteTo(writer)
            End Using

        Catch ex As Exception
            MsgBox("Gagal menyimpan preferensi: " & ex.Message,
                   MsgBoxStyle.Critical, "Error Settings")
        End Try
    End Sub

    Public Sub ResetToDefault(username As String)
        ShowClock = True
        ConfirmLogout = True
        ConfirmHapus = True
        PersenDenda = 100
        SaveSettings(username)
    End Sub

    ' ── Helpers baca XML ──────────────────────────────────
    Private Function ReadBool(doc As XmlDocument, path As String,
                              def As Boolean) As Boolean
        Dim node As XmlNode = doc.SelectSingleNode("HotelUserSettings/" & path)
        If node Is Nothing Then Return def
        Dim result As Boolean
        Return If(Boolean.TryParse(node.InnerText, result), result, def)
    End Function

    Private Function ReadInt(doc As XmlDocument, path As String,
                             def As Integer) As Integer
        Dim node As XmlNode = doc.SelectSingleNode("HotelUserSettings/" & path)
        If node Is Nothing Then Return def
        Dim result As Integer
        Return If(Integer.TryParse(node.InnerText, result), result, def)
    End Function

    Private Sub AppendChild(doc As XmlDocument, parent As XmlElement,
                             name As String, value As String)
        Dim node As XmlElement = doc.CreateElement(name)
        node.InnerText = If(value, "")
        parent.AppendChild(node)
    End Sub

End Module
