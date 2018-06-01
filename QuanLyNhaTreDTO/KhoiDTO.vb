Public Class KhoiDTO
    Private maKhoi As Integer
    Private tenKhoi As String
    Private soLuongLop As Integer

    Public Sub New()

    End Sub

    Public Sub New(makhoi As Integer, tenkhoi As String, soluonglop As Integer)
        Me.maKhoi = makhoi
        Me.tenKhoi = tenkhoi
        Me.soLuongLop = soluonglop
    End Sub

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

    Public Property SoLuongLop1 As Integer
        Get
            Return soLuongLop
        End Get
        Set(value As Integer)
            soLuongLop = value
        End Set
    End Property
End Class
