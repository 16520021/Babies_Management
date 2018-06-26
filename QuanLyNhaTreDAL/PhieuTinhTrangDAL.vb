Imports System.Configuration
Imports System.Data.SqlClient
Imports QuanLyNhaTreDTO
Public Class PhieuTinhTrangDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(phieutinhtrang As PhieuTinhTrangDTO) As Boolean
        Dim query As String
        query = String.Empty
        query &= "INSERT INTO PHIEUTINHTRANG([MaPhieu],[MaTT],[MaTre],[Ngay])"
        query &= "VALUES(@MaPhieu,@MaTT,@MaTre,@Ngay)"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand()
                With cmd
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaTre", phieutinhtrang.MaTre1)
                    .Parameters.AddWithValue("@MaPhieu", phieutinhtrang.MaPhieu1)
                    .Parameters.AddWithValue("@Ngay", phieutinhtrang.NgayNhap1)
                    .Parameters.AddWithValue("@MaTT", phieutinhtrang.MaTT1)
                End With
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return False
                End Try
            End Using
        End Using
        Return True
    End Function

    Public Function getTinhTrang(ByRef TT As Dictionary(Of String, Integer)) As Dictionary(Of String, Integer)
        Dim query As String = String.Empty
        query &= " SELECT *"
        query &= " FROM [TINHTRANG]"
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
                            TT.Add(reader("TinhTrang"), reader("MaTT"))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                End Try
            End Using
        End Using
        Return TT
    End Function

    Public Function getLastMaPhieu() As Integer
        Dim maP As Integer
        Dim query As String = String.Empty
        Dim year As String
        year = DateTime.Now.Year.ToString().Substring(2)
        query &= "SELECT TOP 1 [MaPhieu] "
        query &= "FROM [PHIEUTINHTRANG] "
        query &= "ORDER BY [MaPhieu] DESC "
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
                            maP = reader("MaPhieu")
                            Return maP
                        End While
                    Else
                        maP = Integer.Parse(year + "0000")
                        Return maP
                    End If
                Catch ex As Exception
                    conn.Close()
                    Return maP
                End Try
            End Using
        End Using
        Return maP
    End Function

    Public Function updateTinhTrang(oldTT As String, str As String) As Boolean
        Dim query As String = String.Empty
        query &= " UPDATE [TINHTRANG]"
        query &= " SET [TinhTrang] = @str"
        query &= " WHERE [TinhTrang] = @oldTT"
        Using conn As New SqlConnection(connectionString)
            Using com As New SqlCommand
                With com
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@str", str)
                    .Parameters.AddWithValue("@oldTT", oldTT)
                End With
                Try
                    conn.Open()
                    com.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                End Try
            End Using
        End Using


    End Function
End Class
