Imports QuanLyNhaTreDAL
Imports QuanLyNhaTreBUS
Imports QuanLyNhaTreDTO
Public Class thaydoiTinhTrang
    Private Sub thaydoiTinhTrang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tinhtrang As PhieuTinhTrangDAL = New PhieuTinhTrangDAL()
        Dim tt As IDictionary(Of String, Integer) = New Dictionary(Of String, Integer)
        Dim tenTinhTrang As List(Of String) = New List(Of String)

        tinhtrang.getTinhTrang(tt)
        tenTinhTrang = tt.Keys.ToList
        comboTinhTrang.Items.AddRange(tenTinhTrang.ToArray())

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tinhtrang As PhieuTinhTrangBUS = New PhieuTinhTrangBUS()
        Dim result As Boolean = False
        If (tinhTrangMoi.Text <> String.Empty) Then
            result = tinhtrang.updateTinhTrang(comboTinhTrang.SelectedItem, tinhTrangMoi.Text)
            If (result = True) Then
                MessageBox.Show("thay đổi tình trạng thành công")
            Else
                MessageBox.Show("thay đổi tình trạng thất bại!")
                Return
            End If
        End If
    End Sub
End Class