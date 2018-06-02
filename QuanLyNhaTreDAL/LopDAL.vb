Imports System.Configuration
Imports System.Data.SqlClient
Imports QuanLyNhaTreDTO
Public Class LopDAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function getListofClass(ByRef listofclass As List(Of Integer)) As List(Of Integer)
        Dim query = String.Empty
        query &= "SELECT [MaLop]"
        query &= "FROM [LOP]"
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
                        listofclass.Clear()
                        While reader.Read()
                            listofclass.Add(reader("MaLop"))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                End Try
            End Using
        End Using
        Return listofclass
    End Function

    Public Function getSiSo(maLop As Integer) As Integer
        Dim query = String.Empty
        Dim ss As Integer
        query &= "SELECT [SiSo]"
        query &= "FROM [LOP]"
        query &= "WHERE [MaLop] = @maLop"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maLop", maLop)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            ss = reader("SiSo")
                            Return ss
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    Return 0
                End Try
            End Using
        End Using
        Return 0
    End Function

    Public Function increaseSiSo(maLop As Integer) As Boolean
        Dim query As String
        query = String.Empty
        query &= "UPDATE [LOP] SET"
        query &= " [SiSo] = @ss"
        query &= " WHERE "
        query &= "[MaLop] = @maLop"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ss", getSiSo(maLop) + 1)
                    .Parameters.AddWithValue("@maLop", maLop)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    conn.Close()
                    Return False
                End Try
            End Using
        End Using
        Return True
    End Function

    Public Function getListofClassName_ByMaKhoi(ByRef listLop As List(Of String), makhoi As String) As List(Of String)
        Dim query = String.Empty
        query &= "SELECT [TenLop]"
        query &= "FROM [LOP]"
        query &= " WHERE [MaKhoi] = @makhoi "
        Using conn As New SqlConnection(connectionString)
            Using com As New SqlCommand
                With com
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@makhoi", makhoi)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = com.ExecuteReader()
                    If reader.HasRows = True Then
                        listLop.Clear()
                        While reader.Read()
                            listLop.Add(reader("TenLop"))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                End Try
            End Using
        End Using
        Return listLop
    End Function

    Public Function getMaLop_ByTenLop(tenlop As String) As Integer
        Dim query As String = String.Empty
        Dim malop As Integer = 0
        query &= "SELECT [MaLop]"
        query &= " FROM [LOP]"
        query &= " WHERE [TenLop] = @tenlop"
        Using conn As New SqlConnection(connectionString)
            Using com As New SqlCommand
                With com
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tenlop", tenlop)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = com.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            malop = (reader("MaLop"))
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                End Try
            End Using
        End Using
        Return malop
    End Function

    Public Function decreaseSiSo(maLop As Integer) As Boolean
        Dim query As String
        query = String.Empty
        query &= "UPDATE [LOP] SET"
        query &= " [SiSo] = @ss"
        query &= " WHERE "
        query &= "[MaLop] = @maLop"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ss", getSiSo(maLop) - 1)
                    .Parameters.AddWithValue("@maLop", maLop)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()

                Catch ex As Exception
                    conn.Close()
                    Return False
                End Try
            End Using
        End Using
        Return True
    End Function

End Class
