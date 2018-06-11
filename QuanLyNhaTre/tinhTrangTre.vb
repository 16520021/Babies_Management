Imports QuanLyNhaTreDAL
Imports QuanLyNhaTreBUS
Imports QuanLyNhaTreDTO

Public Class tinhTrangTre

    Dim TT As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
    Dim lopdal As LopDAL = New LopDAL()

    Private Sub tinhTrangTre_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim phieutinhtrangbus As PhieuTinhTrangBUS = New PhieuTinhTrangBUS()
        Dim maph As Integer = 0
        phieutinhtrangbus.getNextMaPhieu(maph)
        maPhieu.Text = maph.ToString()

        Dim listofclass As List(Of String) = New List(Of String)
        lopdal.getListofClass(listofclass)
        ComboLop.Items.AddRange(listofclass.ToArray())

        Dim phieutinhtrang As PhieuTinhTrangDAL = New PhieuTinhTrangDAL()
        phieutinhtrang.getTinhTrang(TT)
        ComboTT.Items.AddRange(TT.Keys.ToArray())

    End Sub

    Private Sub ComboTT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTT.SelectedIndexChanged

        maTT.Text = TT(ComboTT.SelectedItem)

    End Sub

    Private Sub ComboLop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboLop.SelectedIndexChanged

        maLop.Text = lopdal.getMaLop_ByTenLop(ComboLop.SelectedItem)
        hoTen.Enabled = True
        ngayNhap.Enabled = True
        maTT.Enabled = True
        ComboTT.Enabled = True

    End Sub

    Private Sub hoTen_TextChanged(sender As Object, e As EventArgs) Handles hoTen.TextChanged

        Dim phieutinhtrang As PhieuTinhTrangBUS = New PhieuTinhTrangBUS()
        Dim lopdal As LopDAL = New LopDAL()
        maTre.Text = phieutinhtrang.isValid_Name(hoTen.Text, lopdal.getMaLop_ByTenLop(ComboLop.SelectedItem))

    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim tinhtrang As PhieuTinhTrangDTO = New PhieuTinhTrangDTO()
        Dim ttbus As PhieuTinhTrangBUS = New PhieuTinhTrangBUS()
        Try
            tinhtrang.MaPhieu1 = Convert.ToInt32(maPhieu.Text)
            tinhtrang.MaTre1 = Convert.ToInt32(maTre.Text)
            tinhtrang.MaTT1 = Convert.ToInt32(maTT.Text)
            tinhtrang.NgayNhap1 = ngayNhap.Value.Date
            If (ttbus.insert(tinhtrang) = False) Then
                MessageBox.Show("ghi nhan tinh trang khong thanh cong")
                Return
            Else
                MessageBox.Show("ghi nhan tinh trang thanh cong")
                Me.Close()
            End If

        Catch Ex As Exception
            MessageBox.Show("ghi nhan tinh trang khong thanh cong")
            Return
        End Try

    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
End Class