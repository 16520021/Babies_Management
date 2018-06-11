Imports QuanLyNhaTreDTO

Public Class baocaoTinhTrangTreDTO
    Private treDTO As TreDTO
    Private tinhtrangDTO As PhieuTinhTrangDTO

    Public Property TreDTO1 As TreDTO
        Get
            Return treDTO
        End Get
        Set(value As TreDTO)
            treDTO = value
        End Set
    End Property

    Public Property TinhtrangDTO1 As PhieuTinhTrangDTO
        Get
            Return tinhtrangDTO
        End Get
        Set(value As PhieuTinhTrangDTO)
            tinhtrangDTO = value
        End Set
    End Property

    Public Sub New()
        Me.tinhtrangDTO = New PhieuTinhTrangDTO()
        Me.treDTO = New TreDTO()
    End Sub
    Public Sub New(hoten As String, khoilop As Integer, tinhtrang As Integer, ghichu As String)
        Me.tinhtrangDTO = New PhieuTinhTrangDTO()
        Me.treDTO = New TreDTO()
        Me.treDTO.TenTre1 = hoten
        Me.treDTO.MaLop1 = khoilop
        Me.tinhtrangDTO.MaTT1 = tinhtrang
        Me.treDTO.GhiChu1 = ghichu
    End Sub
End Class
