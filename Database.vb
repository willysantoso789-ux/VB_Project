Imports System.Data
Imports System.Data.SqlClient

Public Module Database

    Public Function ExecuteQuery(spName As String,
                                 params As Dictionary(Of String, Object)) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SqlConnection(AppSettingsManager.ConnString)
                conn.Open()
                Using cmd As New SqlCommand(spName, conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 30
                    AddParams(cmd, params)
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As SqlException
            Throw New Exception(ParseSqlError(ex))
        End Try
        Return dt
    End Function

    Public Sub ExecuteNonQuery(spName As String,
                               params As Dictionary(Of String, Object))
        Try
            Using conn As New SqlConnection(AppSettingsManager.ConnString)
                conn.Open()
                Using cmd As New SqlCommand(spName, conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 30
                    AddParams(cmd, params)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As SqlException
            Throw New Exception(ParseSqlError(ex))
        End Try
    End Sub

    Public Function ExecuteWithOutput(spName As String,
                                      params As Dictionary(Of String, Object),
                                      outputParam As String) As Object
        Dim result As Object = Nothing
        Try
            Using conn As New SqlConnection(AppSettingsManager.ConnString)
                conn.Open()
                Using cmd As New SqlCommand(spName, conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandTimeout = 30
                    AddParams(cmd, params)
                    Dim outP As New SqlParameter(outputParam, SqlDbType.Int)
                    outP.Direction = ParameterDirection.Output
                    cmd.Parameters.Add(outP)
                    cmd.ExecuteNonQuery()
                    result = outP.Value
                End Using
            End Using
        Catch ex As SqlException
            Throw New Exception(ParseSqlError(ex))
        End Try
        Return result
    End Function

    Public Function TestConnection() As Boolean
        Try
            Using conn As New SqlConnection(AppSettingsManager.ConnString)
                conn.Open()
                Return True
            End Using
        Catch
            Return False
        End Try
    End Function

    Private Sub AddParams(cmd As SqlCommand,
                          params As Dictionary(Of String, Object))
        If params Is Nothing Then Exit Sub
        For Each kv As KeyValuePair(Of String, Object) In params
            cmd.Parameters.AddWithValue(kv.Key,
                If(kv.Value Is Nothing, DBNull.Value, kv.Value))
        Next
    End Sub

    Private Function ParseSqlError(ex As SqlException) As String
        If ex.Number >= 50000 Then Return ex.Message
        Select Case ex.Number
            Case 2, 53 : Return "Tidak dapat terhubung ke server database."
            Case 4060 : Return "Database tidak ditemukan."
            Case 18456 : Return "Login database gagal."
            Case 547 : Return "Data masih digunakan, tidak dapat dihapus."
            Case 2601, 2627 : Return "Data duplikat."
            Case -2 : Return "Koneksi timeout."
            Case Else : Return "Error database: " & ex.Message
        End Select
    End Function

End Module