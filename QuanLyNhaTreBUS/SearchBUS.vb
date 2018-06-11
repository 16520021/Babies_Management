Imports QuanLyNhaTreDTO
Imports QuanLyNhaTreDAL
Public Class SearchBUS
    Public searchDAL As SearchDAL
    Sub New()
        searchDAL = New SearchDAL()
    End Sub
    Public Function search(srh As SearchDTO, srhlist As List(Of SearchDTO), mode As Integer) As Boolean
        Return (searchDAL.search(srh, srhlist, mode))
    End Function

End Class
