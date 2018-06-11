Imports QuanLyNhaTreDAL
Imports QuanLyNhaTreDTO
Public Class PhieuTinhTrangBUS
    Private tinhtrangDAL As PhieuTinhTrangDAL
    Public Sub New()
        tinhtrangDAL = New PhieuTinhTrangDAL()
    End Sub
    Public Function insert(tinhtrang As PhieuTinhTrangDTO) As Boolean
        Return tinhtrangDAL.insert(tinhtrang)
    End Function

    Public Function isValid_Name(tentre As String, malop As Integer) As Integer
        Dim treDAL As TreDAL = New TreDAL()
        Dim list As List(Of TreDTO) = New List(Of TreDTO)
        treDAL.getListOfTre_byMaLop(list, malop)

        For i = 0 To list.Count - 1 Step 1
            If (list.Item(i).TenTre1.Contains(tentre)) Then
                Return list.Item(i).MaTre1
            End If
        Next
        Return 0
    End Function

    Public Function getNextMaPhieu(ByRef maphieu As Integer) As Integer
        Dim tinhtrangdal As PhieuTinhTrangDAL = New PhieuTinhTrangDAL()
        maphieu = tinhtrangdal.getLastMaPhieu
        Return maphieu
    End Function
End Class
