Imports System.Data.Odbc
Imports System.Data
Imports System.Data.SqlClient
Imports PLFE.Misc.Globals
Imports System.Text

Namespace Misc.SQLDriver
    Module SQLDriver
        Private odbcPartsList = "Server=192.168.1.49;Database=Apps;"

        Private sqlConn As SqlConnection
        Private sqlCmd As SqlCommand
        Private sqlError As Exception

        Public Enum Database
            PartsList = 0
            DMAIC
            IMA
        End Enum

        Public Function getODBCConnectionString()
            Return odbcPartsList & "User ID=apps;Password=ajaxT9+"
        End Function

        Public Function getSQLError()
            Return sqlError.ToString()
        End Function
        Public Function sqlExeNonQuery(ByVal s As String)
            Dim st As New StackTrace
            Dim watch = System.Diagnostics.Stopwatch.StartNew()
            Dim ret As Integer = -1
            Try
                sqlConn = New SqlConnection(getODBCConnectionString())
                sqlCmd = New SqlCommand(s, sqlConn)
                sqlConn.Open()
                ret = sqlCmd.ExecuteNonQuery()
                sqlConn.Close()
            Catch ex As Exception
                MsgBox("Error ocurred." & vbCrLf & ex.Message)
                sqlError = ex
                'Return False
            End Try
            Return ret
        End Function

        Public Function sqlExeNonQueryIdentity(ByVal s As String)
            Dim st As New StackTrace
            Dim watch = System.Diagnostics.Stopwatch.StartNew()
            Dim dt As DataTable = New DataTable()
            Dim dr As SqlDataReader
            Dim identity As Integer = -1
            Try
                sqlConn = New SqlConnection(getODBCConnectionString())
                sqlCmd = New SqlCommand(s, sqlConn)
                sqlConn.Open()
                sqlCmd.ExecuteNonQuery()
                sqlCmd.CommandText = "SELECT SCOPE_IDENTITY()"
                sqlCmd.ExecuteNonQuery()
                dr = sqlCmd.ExecuteReader()
                dt.Load(dr)

                identity = dt.Rows(0).Item(0)

                sqlConn.Close()
            Catch ex As Exception
                sqlError = ex
                MsgBox("Error ocurred." & vbCrLf & ex.Message)
                'Return False
            End Try
            Return identity
        End Function



        Public Function sqlExeQuery(ByVal s As String) As DataTable
            Dim st As New StackTrace
            Dim watch = System.Diagnostics.Stopwatch.StartNew()
            Dim dt As DataTable = New DataTable()
            Try
                Dim dr As SqlDataReader
                sqlConn = New SqlConnection(getODBCConnectionString())
                sqlCmd = New SqlCommand(s, sqlConn)
                sqlConn.Open()
                sqlCmd.ExecuteNonQuery()
                dr = sqlCmd.ExecuteReader()
                dt.Load(dr)
                sqlConn.Close()

            Catch ex As Exception
                sqlError = ex
                MsgBox(ex.Message)
            End Try
            Return dt
        End Function

        Public Function sqlExeQueryCount(ByVal tbl As String, ByVal field As String, ByVal condition As String)
            Dim st As New StackTrace
            Dim watch = System.Diagnostics.Stopwatch.StartNew()
            Dim count As Integer = -1
            Try
                Dim dr As SqlDataReader
                sqlConn = New SqlConnection(getODBCConnectionString())
                sqlCmd = New SqlCommand("SELECT COUNT(" & field & ") FROM " & tbl & " WHERE " & condition, sqlConn)
                sqlConn.Open()
                sqlCmd.ExecuteNonQuery()
                dr = sqlCmd.ExecuteReader()
                dr.Read()
                count = dr.GetInt32(0)
                sqlConn.Close()

            Catch ex As Exception
                sqlError = ex
                MsgBox(ex.Message)
            End Try
            Return count
        End Function

        Function createhashMD5(s As String) As String
            Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider
            Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(s)

            bytesToHash = md5Obj.ComputeHash(bytesToHash)
            Dim strResult As New StringBuilder

            For Each b As Byte In bytesToHash
                strResult.Append(b.ToString("x2"))
            Next

            Return strResult.ToString

        End Function



    End Module
End Namespace
