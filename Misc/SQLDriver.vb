Imports System.Data.Odbc
Imports System.Data
Imports System.Data.SqlClient
Imports PLFE.Misc.Globals
Imports System.Text
Imports System.IO

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

        Public Function sqlAddImage(ByVal pic As Picture)
            Dim st As New StackTrace
            Dim watch = System.Diagnostics.Stopwatch.StartNew()
            Dim ret As Integer = -1
            Dim s = "INSERT INTO INV_pictures(pic_name, picture) VALUES('" & pic.name & "',@PIC" & ")"

            Try
                sqlConn = New SqlConnection(getODBCConnectionString())
                sqlCmd = New SqlCommand(s, sqlConn)

                Dim ms = New MemoryStream
                Dim pb = New PictureBox
                pb.BackgroundImage = pic.image
                pb.BackgroundImage.Save(ms, pb.BackgroundImage.RawFormat)
                Dim data As Byte() = ms.GetBuffer()
                Dim p As New SqlParameter("@PIC", SqlDbType.Image)

                p.Value = data

                sqlCmd.Parameters.Add(p)


                sqlConn.Open()
                sqlCmd.ExecuteNonQuery()
                sqlConn.Close()
            Catch ex As Exception
                MsgBox("Error ocurred." & vbCrLf & ex.Message)
                sqlError = ex
                'Return False
            End Try
            Return ret
        End Function
        Public Function sqlDeleteImage(ByVal pic As Picture)
            Dim st As New StackTrace
            Dim watch = System.Diagnostics.Stopwatch.StartNew()
            Dim ret As Integer = -1
            Dim s = "DELETE FROM INV_pictures WHERE id = " & pic.id

            Try
                sqlConn = New SqlConnection(getODBCConnectionString())
                sqlCmd = New SqlCommand(s, sqlConn)
                sqlConn.Open()
                sqlCmd.ExecuteNonQuery()
                sqlConn.Close()
            Catch ex As Exception
                MsgBox("Error ocurred." & vbCrLf & ex.Message)
                sqlError = ex
                'Return False
            End Try
            Return ret
        End Function

        Public Function sqlCheckImageUsage(pic As Picture)
            Dim ret = -1
            ret = sqlExeQueryCount("INV_machinery", "id", pic.id)
            If ret > 0 Then
                Return True
            End If

            ''next table
            'ret = sqlExeQueryCount("INV_machinery", "id", pic.id)
            'If ret > 0 Then
            '    Return True
            'End If

            Return ret
        End Function

        Public Function sqlCheckImageUsage(picID As Integer)
            Dim ret = 0
            ret = sqlExeQueryCount("INV_machinery", "id", " picture_id = " & picID)
            If ret > 0 Then
                Return True
            End If

            'next table
            'ret = sqlExeQueryCount("INV_machinery", "id", picID)
            'If ret > 0 Then
            '    Return True
            'End If

            Return False
        End Function
        Public Function sqlDeleteImage(ByVal picID As Integer)
            Dim st As New StackTrace
            Dim watch = System.Diagnostics.Stopwatch.StartNew()
            Dim ret As Integer = False
            Dim s = "DELETE FROM INV_pictures WHERE id = " & picID
            If Not sqlCheckImageUsage(picID) Then
                Try
                    sqlConn = New SqlConnection(getODBCConnectionString())
                    sqlCmd = New SqlCommand(s, sqlConn)
                    sqlConn.Open()
                    sqlCmd.ExecuteNonQuery()
                    sqlConn.Close()
                    ret = True
                Catch ex As Exception
                    MsgBox("Error ocurred." & vbCrLf & ex.Message)
                    sqlError = ex
                    'Return False
                End Try
            End If
            Return ret
        End Function

        Public Function sqlRetreiveImage(ByVal id As Integer) As Image
            Dim st As New StackTrace
            Dim watch = System.Diagnostics.Stopwatch.StartNew()
            Dim ret As Image = New Bitmap(1, 1)
            Dim s = "SELECT picture FROM INV_pictures WHERE id = " & id

            Try
                sqlConn = New SqlConnection(getODBCConnectionString())
                sqlCmd = New SqlCommand(s, sqlConn)
                sqlConn.Open()

                Dim imagedata As Byte() = DirectCast(sqlCmd.ExecuteScalar(), Byte())
                If imagedata IsNot Nothing Then
                    Using ms As New MemoryStream(imagedata, 0, imagedata.Length)
                        ms.Write(imagedata, 0, imagedata.Length)
                        ret = Image.FromStream(ms, True)
                    End Using
                End If
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
        Public Function sqlExeQueryScalar(ByVal s As String)
            Dim st As New StackTrace
            Dim watch = System.Diagnostics.Stopwatch.StartNew()
            Try
                Dim dr As SqlDataReader
                sqlConn = New SqlConnection(getODBCConnectionString())
                sqlCmd = New SqlCommand(s, sqlConn)
                sqlConn.Open()
                sqlCmd.ExecuteNonQuery()
                Return sqlCmd.ExecuteScalar()
                sqlConn.Close()

            Catch ex As Exception
                sqlError = ex
                MsgBox(ex.Message)
            End Try

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
