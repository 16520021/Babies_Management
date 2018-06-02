Imports System.Configuration
Imports System.Data.SqlClient
Imports QuanLyNhaTreDTO
Public Class TreDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function insert(Tre As TreDTO) As Boolean
        Dim query As String
        query = String.Empty
        query &= "INSERT INTO TRE([MaTre],[HoTenTre],[TenNha],[NgaySinh],[PhuHuynh],[DienThoai],[DiaChi],[Tuoi])"
        query &= "VALUES(@MaTre,@HoTenTre,@TenNha,@NgaySinh,@PhuHuynh,@DienThoai,@DiaChi,@Tuoi)"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand()
                With cmd
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaTre", Tre.MaTre1)
                    .Parameters.AddWithValue("@HoTenTre", Tre.TenTre1)
                    .Parameters.AddWithValue("@TenNha", Tre.TenNha1)
                    .Parameters.AddWithValue("@NgaySinh", Tre.NgaySinh1)
                    .Parameters.AddWithValue("@PhuHuynh", Tre.PhuHuynh1)
                    .Parameters.AddWithValue("@DienThoai", Tre.Sdt1)
                    .Parameters.AddWithValue("@DiaChi", Tre.DiaChi1)
                    .Parameters.AddWithValue("@Tuoi", Tre.Tuoi1)
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

    Public Function getLastMaTre() As Integer
        Dim maTr As Integer
        Dim query As String = String.Empty
        Dim year As String
        year = DateTime.Now.Year.ToString().Substring(2)
        query &= "SELECT TOP 1 [MaTre] "
        query &= "FROM [TRE] "
        query &= "ORDER BY [MaTre] DESC "
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
                            maTr = reader("MaTre")
                            Return maTr
                        End While
                    Else
                        maTr = Integer.Parse(year + "0000")
                        Return maTr
                    End If
                Catch ex As Exception
                    conn.Close()
                    Return maTr
                End Try
            End Using
        End Using
        Return maTr
    End Function

    Public Function gettuoimin() As Integer
        Dim query = String.Empty
        Dim tuoimin As Integer
        query &= "SELECT [TuoiMin]"
        query &= "FROM [THAMSO]"
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
                            tuoimin = reader("TuoiMin")
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                End Try
            End Using
        End Using
        Return tuoimin
    End Function

    Public Function gettuoimax() As Integer
        Dim query = String.Empty
        Dim tuoimax As Integer
        query &= "SELECT [TuoiMax]"
        query &= "FROM [THAMSO]"
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
                            tuoimax = reader("TuoiMax")
                        End While
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                End Try
            End Using
        End Using
        Return tuoimax
    End Function

    Public Function getListOfTre_byMaLop(ByRef listoftre As List(Of TreDTO), malop As Integer) As List(Of TreDTO)
        Dim query As String = String.Empty

        query &= "SELECT [MaTre],[HoTenTre],[Tuoi] "
        query &= " FROM [TRE]"
        If (malop <> 0) Then
            query &= " WHERE [MaLop] = @malop"
        Else
            query &= "WHERE [MaLop] IS NULL"
        End If

        Using conn As New SqlConnection(connectionString)
            Using com As New SqlCommand
                With com
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    If (malop <> 0) Then
                        .Parameters.AddWithValue("@malop", malop)
                    End If
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = com.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            listoftre.Add(New TreDTO(reader("MaTre"), reader("HoTenTre"), reader("Tuoi")))
                        End While
                    Else
                        listoftre = Nothing
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                End Try
            End Using
        End Using
        Return listoftre
    End Function

    Public Function updateTre_NullField(matre As Integer, ngaynhaphoc As DateTime, ghichu As String, malop As Integer) As Boolean
        Dim query As String = String.Empty
        query &= "UPDATE [TRE]"
        query &= " SET [NgayNhapHoc] = @ngaynhaphoc,[GhiChu] = @ghichu,[MaLop] = @malop"
        query &= " WHERE [MaTre] = @matre"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ngaynhaphoc", ngaynhaphoc)
                    .Parameters.AddWithValue("@malop", malop)
                    .Parameters.AddWithValue("@ghichu", ghichu)
                    .Parameters.AddWithValue("@matre", matre)
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
