Public Class LopDTO
    Private maLop As Integer
    Private maKhoi As Integer
    Private tenLop As String
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

    Public Property TenLop1 As String
        Get
            Return tenLop
        End Get
        Set(value As String)
            tenLop = value
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
