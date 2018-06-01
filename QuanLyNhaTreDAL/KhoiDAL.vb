Imports QuanLyNhaTreDTO
Imports System.Configuration
Imports System.Data.SqlClient
Public Class KhoiDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function getListofMaKhoi(ByRef listKhoi As List(Of String)) As List(Of String)
        Dim query As String = String.Empty
        query &= "SELECT [TenKhoi] "
        query &= "FROM [KHOI]"
        Using conn As New SqlConnection(connectionString)
            Using com As New SqlCommand
                With com
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = com.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            listKhoi.Add(reader("TenKhoi"))
                        End While
                    Else
                        listKhoi = Nothing
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                End Try
            End Using
        End Using
        Return listKhoi
    End Function

    Public Function getMaKhoi_byTenKhoi(tenkhoi As String) As Integer
        Dim query As String = String.Empty
        query &= "SELECT [MaKhoi] "
        query &= "FROM [KHOI]"
        query &= " WHERE [TenKhoi] = @tenkhoi"
        Using conn As New SqlConnection(connectionString)
            Using com As New SqlCommand
                With com
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tenkhoi", tenkhoi)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = com.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            tenkhoi = reader("MaKhoi")
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                End Try
            End Using
        End Using
        Return tenkhoi
    End Function
End Class
