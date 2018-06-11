Imports System.Configuration
Imports System.Data.SqlClient
Imports QuanLyNhaTreDTO
Public Class baocaoTinhTrangTreDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function BaoCao(ByRef tinhtrang As List(Of baocaoTinhTrangTreDTO), dt As DateTime, ml As Integer) As Boolean
        Dim query As String
        query = String.Empty
        If (ml = Nothing) Then
            query &= " SELECT [TRE].[HoTenTre],[PHIEUTINHTRANG].[MaTT],[TRE].[MaLop],[GhiChu]"
            query &= " FROM ([TRE]"
            query &= " INNER JOIN [PHIEUTINHTRANG] ON [TRE].[MaTre] = [PHIEUTINHTRANG].[MaTre])"
            query &= " WHERE [PHIEUTINHTRANG].[NGAY] = @dt"
        Else
            query &= " SELECT [TRE].[HoTenTre],[PHIEUTINHTRANG].[MaTT],[TRE].[MaLop],[GhiChu]"
            query &= " FROM ([TRE]"
            query &= " INNER JOIN [PHIEUTINHTRANG] ON [TRE].[MaTre] = [PHIEUTINHTRANG].[MaTre])"
            query &= " WHERE [PHIEUTINHTRANG].[NGAY] = @dt"
            query &= " AND [TRE].[MaLop] = @ml"
        End If
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand()
                With cmd
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@dt", dt)
                    .Parameters.AddWithValue("@ml", ml)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = cmd.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            tinhtrang.Add(New baocaoTinhTrangTreDTO(reader("HoTenTre"), reader("MaLop"), reader("MaTT"), reader("GhiChu")))
                        End While
                        Return True
                    Else
                        tinhtrang = Nothing
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
