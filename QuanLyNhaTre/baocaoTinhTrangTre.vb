Imports QuanLyNhaTreDTO
Imports QuanLyNhaTreDAL
Imports QuanLyNhaTreBUS
Public Class baocaoTinhTrangTre
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dt.ValueChanged
        Dim baocaoBUS As baocaoTinhTrangTreBUS = New baocaoTinhTrangTreBUS()
        Dim tinhtrangDTO As List(Of baocaoTinhTrangTreDTO) = New List(Of baocaoTinhTrangTreDTO)
        If (baocaoBUS.BaoCao(tinhtrangDTO, dt.Value.Date) = False) Then
            MessageBox.Show("Báo cáo thất bại")
        End If
    End Sub

    Private Sub baocaoTinhTrangTre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim baocaoBUS As baocaoTinhTrangTreBUS = New baocaoTinhTrangTreBUS()
        Dim tinhtrangDTO As List(Of baocaoTinhTrangTreDTO) = New List(Of baocaoTinhTrangTreDTO)
        If (baocaoBUS.BaoCao(tinhtrangDTO, dt.Value.Date) = True) Then
            For i = 0 To tinhtrangDTO.Count - 1 Step 1
                DataGridView1.Rows.Add()
                DataGridView1.Rows(i).Cells(0).Value = i
                DataGridView1.Rows(i).Cells(1).Value = tinhtrangDTO.Item(i).TreDTO1.TenTre1
                DataGridView1.Rows(i).Cells(2).Value = tinhtrangDTO.Item(i).TreDTO1.MaLop1
                DataGridView1.Rows(i).Cells(3).Value = tinhtrangDTO.Item(i).TinhtrangDTO1.MaTT1
                DataGridView1.Rows(i).Cells(4).Value = tinhtrangDTO.Item(i).TreDTO1.GhiChu1
            Next
        Else
            MessageBox.Show("show con hang that bai")
        End If
    End Sub
End Class