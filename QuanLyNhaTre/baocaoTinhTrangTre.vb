Imports QuanLyNhaTreDTO
Imports QuanLyNhaTreDAL
Imports QuanLyNhaTreBUS
Public Class baocaoTinhTrangTre
    Dim malop As Integer = Nothing
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dt.ValueChanged

        Dim baocaoBUS As baocaoTinhTrangTreBUS = New baocaoTinhTrangTreBUS()
        Dim tinhtrangDTO As List(Of baocaoTinhTrangTreDTO) = New List(Of baocaoTinhTrangTreDTO)
        If (baocaoBUS.BaoCao(tinhtrangDTO, dt.Value.Date, malop) = True) Then
            For i = 0 To tinhtrangDTO.Count - 1 Step 1
                DataGridView1.Rows.Add()
                DataGridView1.Rows(i).Cells(0).Value = i
                DataGridView1.Rows(i).Cells(1).Value = tinhtrangDTO.Item(i).TreDTO1.TenTre1
                DataGridView1.Rows(i).Cells(2).Value = tinhtrangDTO.Item(i).TreDTO1.MaLop1
                DataGridView1.Rows(i).Cells(3).Value = tinhtrangDTO.Item(i).TinhtrangDTO1.MaTT1
                DataGridView1.Rows(i).Cells(4).Value = tinhtrangDTO.Item(i).TreDTO1.GhiChu1
            Next
        Else
            MessageBox.Show("Báo cáo thất bại")
        End If
    End Sub
    Private Sub ml_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ml.SelectedIndexChanged
        DataGridView1.Rows.Clear()
        Dim baocaoBUS As baocaoTinhTrangTreBUS = New baocaoTinhTrangTreBUS()
        Dim tinhtrangDTO As List(Of baocaoTinhTrangTreDTO) = New List(Of baocaoTinhTrangTreDTO)
        Dim lopdal As LopDAL = New LopDAL()
        malop = lopdal.getMaLop_ByTenLop(ml.SelectedItem)
        If (baocaoBUS.BaoCao(tinhtrangDTO, dt.Value.Date, malop) = True) Then
            Try
                For i = 0 To tinhtrangDTO.Count - 1 Step 1
                    DataGridView1.Rows.Add()
                    DataGridView1.Rows(i).Cells(0).Value = i
                    DataGridView1.Rows(i).Cells(1).Value = tinhtrangDTO.Item(i).TreDTO1.TenTre1
                    DataGridView1.Rows(i).Cells(2).Value = tinhtrangDTO.Item(i).TreDTO1.MaLop1
                    DataGridView1.Rows(i).Cells(3).Value = tinhtrangDTO.Item(i).TinhtrangDTO1.MaTT1
                    DataGridView1.Rows(i).Cells(4).Value = tinhtrangDTO.Item(i).TreDTO1.GhiChu1
                Next
            Catch ex As Exception
                MessageBox.Show("Thiếu dữ liệu")
            End Try
        Else
            MessageBox.Show("Báo cáo thất bại")
        End If
    End Sub

    Private Sub baocaoTinhTrangTre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Clear()
        Dim baocaoBUS As baocaoTinhTrangTreBUS = New baocaoTinhTrangTreBUS()
        Dim tinhtrangDTO As List(Of baocaoTinhTrangTreDTO) = New List(Of baocaoTinhTrangTreDTO)
        Dim khoidal As KhoiDAL = New KhoiDAL()
        Dim str As List(Of String) = New List(Of String)
        khlop.Items.Add("<None>")
        khoidal.getListofTenKhoi(str)
        khlop.Items.AddRange(str.ToArray())
        khlop.SelectedIndex = 0
        If (baocaoBUS.BaoCao(tinhtrangDTO, dt.Value.Date, malop) = True) Then
            For i = 0 To tinhtrangDTO.Count - 1 Step 1
                DataGridView1.Rows.Add()
                DataGridView1.Rows(i).Cells(0).Value = i + 1
                DataGridView1.Rows(i).Cells(1).Value = tinhtrangDTO.Item(i).TreDTO1.TenTre1
                DataGridView1.Rows(i).Cells(2).Value = tinhtrangDTO.Item(i).TreDTO1.MaLop1
                DataGridView1.Rows(i).Cells(3).Value = tinhtrangDTO.Item(i).TinhtrangDTO1.MaTT1
                DataGridView1.Rows(i).Cells(4).Value = tinhtrangDTO.Item(i).TreDTO1.GhiChu1
            Next
        Else
            MessageBox.Show("Báo cáo thất bại")
        End If
    End Sub

    Private Sub khlop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles khlop.SelectedIndexChanged
        DataGridView1.Rows.Clear()
        ml.Items.Clear()
        Dim lopdal As LopDAL = New LopDAL()
        Dim str As List(Of String) = New List(Of String)
        Dim khoidal As KhoiDAL = New KhoiDAL()
        If (khlop.SelectedIndex = 0) Then
            khlop.SelectedIndex = 0
            ml.Enabled = False
            ml.SelectedItem = Nothing
        Else
            ml.Enabled = True
            lopdal.getListofClassName_ByMaKhoi(str, khoidal.getMaKhoi_byTenKhoi(khlop.SelectedItem))
            ml.Items.AddRange(str.ToArray())
            ml.SelectedIndex = 0
            malop = lopdal.getMaLop_ByTenLop(ml.SelectedItem)
        End If
    End Sub
End Class