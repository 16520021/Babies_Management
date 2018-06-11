Public Class TreDTO
    Private maTre As Integer
    Private tenTre As String
    Private tenNha As String
    Private ngaySinh As DateTime
    Private phuHuynh As String
    Private diaChi As String
    Private sdt As String
    Private maLop As Integer
    Private tuoi As Integer
    Private ngayHoc As DateTime
    Private ghiChu As String

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

    Public Property TenNha1 As String
        Get
            Return tenNha
        End Get
        Set(value As String)
            tenNha = value
        End Set
    End Property

    Public Property Tuoi1 As Integer
        Get
            Return tuoi
        End Get
        Set(value As Integer)
            tuoi = value
        End Set
    End Property


    Public Property GhiChu1 As String
        Get
            Return ghiChu
        End Get
        Set(value As String)
            ghiChu = value
        End Set
    End Property

    Public Property NgayHoc1 As Date
        Get
            Return ngayHoc
        End Get
        Set(value As Date)
            ngayHoc = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(matre As Integer, tentre As String, tuoi As Integer)
        Me.maTre = matre
        Me.tenTre = tentre
        Me.tuoi = tuoi
    End Sub

    Public Sub New(tentre As String, tuoi As Integer, malop As Integer, ghichu As String)
        Me.tenTre = tentre
        Me.tuoi = tuoi
        Me.maLop = malop
        Me.ghiChu = ghichu
    End Sub
End Class
