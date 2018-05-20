Imports QuanLyNhaTreBUS
Imports QuanLyNhaTreDAL
Imports QuanLyNhaTreDTO

Public Class xepLop
    Private Sub xepLop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim treDAL As TreDAL
        treDAL = New TreDAL()
        Dim listoftre As List(Of TreDTO)
        listoftre = New List(Of TreDTO)
        treDAL.getListOfTre_byMaLop(listoftre, 0)

        For i = 0 To listoftre.Count - 1 Step 1
            inputDataGrid.Rows(i).Cells(0).Value = listoftre.Item(i).MaTre1
            inputDataGrid.Rows(i).Cells(1).Value = listoftre.Item(i).TenTre1
        Next

    End Sub
End Class