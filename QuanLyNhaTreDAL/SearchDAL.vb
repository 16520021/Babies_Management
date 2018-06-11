Imports QuanLyNhaTreDTO
Imports System.Data.SqlClient
Imports System.Configuration
Public Class SearchDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function search(srh As SearchDTO, ByRef listsrh As List(Of SearchDTO), mode As Integer) As Boolean
        Dim query As String = String.Empty
        query &= "SELECT [TRE].[HoTenTre],[TRE].[Tuoi],[TRE].[MaLop],[GhiChu]"
        query &= " FROM ((([TRE]"
        query &= " LEFT JOIN [LOP] ON [TRE].[MaLop] = [LOP].[MaLop] )"
        query &= " LEFT JOIN [KHOI] ON [LOP].[MaKhoi] = [KHOI].[MaKhoi] )"
        query &= " LEFT JOIN [PHIEUTINHTRANG] ON [TRE].[MaTre] = [PHIEUTINHTRANG].[MaTre] )"

        Select Case mode
            Case 1
                If (srh.Khoi1.TenKhoi1 = "NULL") Then
                    query &= "WHERE [TRE].[MaLop] IS NULL "
                Else
                    query &= "WHERE [KHOI].[TenKhoi] = @tenkhoi "
                    query &= "AND [TRE].[MaLop] = @malop "
                End If
            Case 2
                query &= "WHERE  [TRE].[HoTenTre] LIKE '%@hoten%' "
            Case 3
                query &= "WHERE  [Tuoi] = @tuoi "
                query &= "AND [TenNha] = @tennha "
                query &= "AND [DiaChi] = @diachi "
                query &= "AND [PhuHuynh] = @tenbame "
                query &= "AND [DienThoai] = @sdt "
            Case 4
                query &= "WHERE  [PHIEUTINHTRANG].[TinhTrang] = @tt "
        End Select

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand()
                With cmd
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    Select Case mode
                        Case 1
                            .Parameters.AddWithValue("@tenkhoi", srh.Khoi1.TenKhoi1)
                            .Parameters.AddWithValue("@malop", srh.Lop1.MaLop1)
                        Case 2
                            .Parameters.AddWithValue("@hoten", srh.Tre1.TenTre1)
                        Case 3
                            .Parameters.AddWithValue("@tuoi", srh.Tre1.Tuoi1)
                            .Parameters.AddWithValue("@tennha", srh.Tre1.TenNha1)
                            .Parameters.AddWithValue("@diachi", srh.Tre1.DiaChi1)
                            .Parameters.AddWithValue("@tenbame", srh.Tre1.PhuHuynh1)
                            .Parameters.AddWithValue("@sdt", srh.Tre1.Sdt1)
                        Case 4
                            .Parameters.AddWithValue("@tt", srh.TinhTrang1.MaTT1)
                    End Select
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = cmd.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            If (srh.Khoi1.TenKhoi1 = "NULL") Then
                                listsrh.Add(New SearchDTO(reader("HoTenTre"), reader("Tuoi")))
                            Else
                                listsrh.Add(New SearchDTO(reader("HoTenTre"), reader("Tuoi"), reader("MaLop"), reader("GhiChu")))
                            End If
                        End While
                        Return True
                    Else
                        listsrh = Nothing
                    End If
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return False
                End Try
            End Using
        End Using
        Return True

    End Function
End Class
