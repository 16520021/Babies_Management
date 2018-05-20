Public Class LopDTO
    Private maLop As Integer
    Private maKhoi As Integer
    Private tenKhoi As String
    Private siSo As Integer

    Public Sub New()

    End Sub
    Public Sub New(malop As Integer)
        Me.maLop = malop
    End Sub
    Public Property MaLop1 As Integer
        Get
            Return maLop
        End Get
        Set(value As Integer)
            maLop = value
        End Set
    End Property

    Public Property MaKhoi1 As Integer
        Get
            Return maKhoi
        End Get
        Set(value As Integer)
            maKhoi = value
        End Set
    End Property

    Public Property TenKhoi1 As String
        Get
            Return tenKhoi
        End Get
        Set(value As String)
            tenKhoi = value
        End Set
    End Property

    Public Property SiSo1 As Integer
        Get
            Return siSo
        End Get
        Set(value As Integer)
            siSo = value
        End Set
    End Property
End Class
