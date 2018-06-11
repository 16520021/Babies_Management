Public Class PhieuTinhTrangDTO
    Private maPhieu As Integer
    Private maTre As Integer
    Private maTT As Integer
    Private ngayNhap As DateTime

    Sub New()

    End Sub
    Public Property MaPhieu1 As Integer
        Get
            Return maPhieu
        End Get
        Set(value As Integer)
            maPhieu = value
        End Set
    End Property

    Public Property MaTre1 As Integer
        Get
            Return maTre
        End Get
        Set(value As Integer)
            maTre = value
        End Set
    End Property

    Public Property MaTT1 As Integer
        Get
            Return maTT
        End Get
        Set(value As Integer)
            maTT = value
        End Set
    End Property

    Public Property NgayNhap1 As Date
        Get
            Return ngayNhap
        End Get
        Set(value As Date)
            ngayNhap = value
        End Set
    End Property
End Class
