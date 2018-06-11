Imports QuanLyNhaTreDAL
Imports QuanLyNhaTreDTO
Public Class baocaoTinhTrangTreBUS
    Public baocaoDAL As baocaoTinhTrangTreDAL
    Sub New()
        baocaoDAL = New baocaoTinhTrangTreDAL()
    End Sub

    Public Function BaoCao(ByRef tinhtrang As List(Of baocaoTinhTrangTreDTO), dt As DateTime) As Boolean
        Return (baocaoDAL.BaoCao(tinhtrang, dt.Date))
    End Function
End Class
