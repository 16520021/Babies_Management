Imports QuanLyNhaTreDAL
Imports QuanLyNhaTreDTO
Public Class TreBUS
    Private treDAL As TreDAL
    Public Sub New()
        treDAL = New TreDAL()
    End Sub
    Public Function isValid_Name(tre As QuanLyNhaTreDTO.TreDTO) As Boolean
        If (tre.TenTre1.Length <= 5 And tre.TenTre1.Length >= 0) Then
            Return False
        End If
        Return True
    End Function
    Public Function isValid_Hname(tre As QuanLyNhaTreDTO.TreDTO) As Boolean
        If (tre.TenNha1.Length > 5) Then
            Return False
        End If
        Return True
    End Function
    Public Function isValid_Age(tuoi As Integer) As Boolean
        If (tuoi < treDAL.gettuoimin() Or tuoi > treDAL.gettuoimax()) Then
            Return False
        End If
        Return True
    End Function
    Public Function nxtMaTre() As Integer
        Dim last As Integer
        last = treDAL.getLastMaTre() + 1
        Return last
    End Function
    Public Function isValid_Phone(tre As QuanLyNhaTreDTO.TreDTO) As Boolean
        If (tre.Sdt1.Length < 9 Or tre.Sdt1.Length > 11) Then
            Return False
        End If
        Return True
    End Function
    Public Function insert(tre As QuanLyNhaTreDTO.TreDTO) As Boolean
        Return treDAL.insert(tre)
    End Function
End Class
