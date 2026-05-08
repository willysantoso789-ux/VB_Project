Imports System.IO
Imports System.Xml

Public Module AppSettingsManager

    ' ── Path global (satu file untuk semua user) ─────────
    Private ReadOnly GlobalPath As String =
        Path.Combine(Application.StartupPath, "global_settings.xml")

    ' ── Path per-user ────────────────────────────────────
    Private Function GetUserPath(username As String) As String
        Dim folder As String = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "HotelReceptionistApp")
        If Not Directory.Exists(folder) Then Directory.CreateDirectory(folder)
        Return Path.Combine(folder, "settings_" & SanitizeFilename(username) & ".xml")
    End Function

    Private Function SanitizeFilename(name As String) As String
        Dim result As String = name
        For Each c As Char In Path.GetInvalidFileNameChars()
            result = result.Replace(c, "_"c)
        Next
        Return result.ToLower()
    End Function

    ' ── Global settings (admin only) ─────────────────────
    Public PersenDenda As Integer = 100

    ' ── Per-user preferences ─────────────────────────────
    Public ShowClock As Boolean = True
    Public ConfirmLogout As Boolean = True
    Public ConfirmHapus As Boolean = True
    Public CurrentUsername As String = ""

    ' ── Load global (dipanggil saat startup) ─────────────
    Public Sub LoadGlobalSettings()
        If Not File.Exists(GlobalPath) Then SaveGlobalSettings() : Return
        Try
            Dim doc As New XmlDocument()
            doc.Load(GlobalPath)
            PersenDenda = ReadInt(doc, "Global/PersenDenda", 100)
            If PersenDenda < 100 Then PersenDenda = 100
        Catch
            SaveGlobalSettings()
        End Try
    End Sub

    Public Sub SaveGlobalSettings()
        Try
            Dim doc As New XmlDocument()
            Dim decl As XmlDeclaration = doc.CreateXmlDeclaration("1.0", "utf-8", Nothing)
            doc.AppendChild(decl)
            Dim root As XmlElement = doc.CreateElement("HotelGlobalSettings")
            doc.AppendChild(root)
            Dim g As XmlElement = doc.CreateElement("Global")
            AppendNode(doc, g, "PersenDenda", PersenDenda.ToString())
            root.AppendChild(g)
            WriteXml(doc, GlobalPath)
        Catch ex As Exception
            MsgBox("Gagal simpan global settings: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

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

    ' ── Load per-user (dipanggil setelah login) ───────────
    Public Sub LoadSettings(username As String)
        CurrentUsername = username
        Dim path As String = GetUserPath(username)
        If Not File.Exists(path) Then SaveSettings(username) : Return
        Try
            Dim doc As New XmlDocument()
            doc.Load(path)
            ShowClock = ReadBool(doc, "Preferensi/ShowClock", True)
            ConfirmLogout = ReadBool(doc, "Preferensi/ConfirmLogout", True)
            ConfirmHapus = ReadBool(doc, "Preferensi/ConfirmHapus", True)
        Catch
            ResetToDefault(username)
        End Try
    End Sub

    Public Sub SaveSettings(username As String)
        Try
            Dim doc As New XmlDocument()
            Dim decl As XmlDeclaration = doc.CreateXmlDeclaration("1.0", "utf-8", Nothing)
            doc.AppendChild(decl)
            Dim root As XmlElement = doc.CreateElement("HotelUserSettings")
            doc.AppendChild(root)
            Dim meta As XmlElement = doc.CreateElement("Metadata")
            AppendNode(doc, meta, "Username", username)
            AppendNode(doc, meta, "LastSaved", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
            root.AppendChild(meta)
            Dim pref As XmlElement = doc.CreateElement("Preferensi")
            AppendNode(doc, pref, "ShowClock", ShowClock.ToString().ToLower())
            AppendNode(doc, pref, "ConfirmLogout", ConfirmLogout.ToString().ToLower())
            AppendNode(doc, pref, "ConfirmHapus", ConfirmHapus.ToString().ToLower())
            root.AppendChild(pref)
            WriteXml(doc, GetUserPath(username))
        Catch ex As Exception
            MsgBox("Gagal simpan preferensi: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub ResetToDefault(username As String)
        ShowClock = True : ConfirmLogout = True : ConfirmHapus = True
        SaveSettings(username)
    End Sub

    ' ── Helpers ───────────────────────────────────────────
    Private Function ReadBool(doc As XmlDocument, path As String, def As Boolean) As Boolean
        Dim n As XmlNode = doc.SelectSingleNode("HotelUserSettings/" & path)
        If n Is Nothing Then Return def
        Dim r As Boolean : Return If(Boolean.TryParse(n.InnerText, r), r, def)
    End Function

    Private Function ReadInt(doc As XmlDocument, path As String, def As Integer) As Integer
        Dim n As XmlNode = doc.SelectSingleNode("HotelGlobalSettings/" & path)
        If n Is Nothing Then Return def
        Dim r As Integer : Return If(Integer.TryParse(n.InnerText, r), r, def)
    End Function

    Private Sub AppendNode(doc As XmlDocument, parent As XmlElement, name As String, value As String)
        Dim n As XmlElement = doc.CreateElement(name)
        n.InnerText = If(value, "") : parent.AppendChild(n)
    End Sub

    Private Sub WriteXml(doc As XmlDocument, path As String)
        Dim ws As New XmlWriterSettings()
        ws.Indent = True : ws.IndentChars = "  "
        ws.Encoding = System.Text.Encoding.UTF8
        Using w As XmlWriter = XmlWriter.Create(path, ws)
            doc.WriteTo(w)
        End Using
    End Sub

End Module