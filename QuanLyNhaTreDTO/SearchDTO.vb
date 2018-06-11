Imports QuanLyNhaTreDTO
Public Class SearchDTO
    Private Tre As TreDTO
    Private lop As LopDTO
    Private khoi As KhoiDTO
    Private tinhTrang As PhieuTinhTrangDTO

    Public Sub New()
        Me.Tre = New TreDTO()
        Me.lop = New LopDTO()
        Me.khoi = New KhoiDTO()
        Me.tinhTrang = New PhieuTinhTrangDTO()
    End Sub
    Public Sub New(hoten As String, tuoi As Integer, lop As Integer, ghichu As String)
        Me.Tre = New TreDTO()
        Me.Tre.TenTre1 = hoten
        Me.Tre.Tuoi1 = tuoi
        Me.Tre.MaLop1 = lop
        Me.Tre.GhiChu1 = ghichu
    End Sub
    Public Sub New(hoten As String, tuoi As Integer)
        Me.Tre = New TreDTO()
        Me.Tre.TenTre1 = hoten
        Me.Tre.Tuoi1 = tuoi
    End Sub
    Public Property Tre1 As TreDTO
        Get
            Return Tre
        End Get
        Set(value As TreDTO)
            Tre = value
        End Set
    End Property

    Public Property Lop1 As LopDTO
        Get
            Return lop
        End Get
        Set(value As LopDTO)
            lop = value
        End Set
    End Property

    Public Property Khoi1 As KhoiDTO
        Get
            Return khoi
        End Get
        Set(value As KhoiDTO)
            khoi = value
        End Set
    End Property

    Public Property TinhTrang1 As PhieuTinhTrangDTO
        Get
            Return tinhTrang
        End Get
        Set(value As PhieuTinhTrangDTO)
            tinhTrang = value
        End Set
    End Property


End Class
