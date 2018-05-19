Public Class TreDTO
    Private maTre As Integer
    Private tenTre As String
    Private ngaySinh As DateTime
    Private phuHuynh As String
    Private diaChi As String
    Private sdt As String
    Private maLop As Integer

    Public Property MaTre1 As Integer
        Get
            Return maTre
        End Get
        Set(value As Integer)
            maTre = value
        End Set
    End Property

    Public Property TenTre1 As String
        Get
            Return tenTre
        End Get
        Set(value As String)
            tenTre = value
        End Set
    End Property

    Public Property NgaySinh1 As Date
        Get
            Return ngaySinh
        End Get
        Set(value As Date)
            ngaySinh = value
        End Set
    End Property

    Public Property PhuHuynh1 As String
        Get
            Return phuHuynh
        End Get
        Set(value As String)
            phuHuynh = value
        End Set
    End Property

    Public Property DiaChi1 As String
        Get
            Return diaChi
        End Get
        Set(value As String)
            diaChi = value
        End Set
    End Property

    Public Property Sdt1 As String
        Get
            Return sdt
        End Get
        Set(value As String)
            sdt = value
        End Set
    End Property

    Public Property MaLop1 As Integer
        Get
            Return maLop
        End Get
        Set(value As Integer)
            maLop = value
        End Set
    End Property

    Public Sub New()

    End Sub

End Class
