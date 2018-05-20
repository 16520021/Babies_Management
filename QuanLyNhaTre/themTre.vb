Imports QuanLyNhaTreBUS
Imports QuanLyNhaTreDAL
Imports QuanLyNhaTreDTO

Public Class themTre
    Private treBUS As TreBUS
    Dim arr = "0123456789"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles nhap.Click
        treBUS = New TreBUS()
        Dim tre = New TreDTO()

        tre.MaTre1 = Integer.Parse(maTr.Text)
        tre.TenTre1 = tenTr.Text
        tre.NgaySinh1 = ngaySinhTr.Value
        tre.TenNha1 = hTenTr.Text
        tre.PhuHuynh1 = tenPH.Text
        tre.DiaChi1 = diaChiTr.Text
        tre.Sdt1 = dth.Text
        tre.MaLop1 = 0
        If (treBUS.isValid_Age(Integer.Parse(tuoi.Text)) = False) Then
            MessageBox.Show("tuoi phai tu 3-5 tuoi")
            tuoi.Focus()
            Return
        End If

        If (treBUS.isValid_Name(tre) = False) Then
            MessageBox.Show("Ten sai qui dinh")
            tenTr.Focus()
            Return
        End If

        If (treBUS.isValid_Phone(tre) = False) Then
            MessageBox.Show("so dien thoai khong hop le")
            dth.Focus()
            Return
        End If

        If (treBUS.isValid_Hname(tre) = False) Then
            MessageBox.Show("ten khong hop le")
            hTenTr.Focus()
            Return
        End If

        If (treBUS.insert(tre) = False) Then
            MessageBox.Show("them tre khong thanh cong")
        Else
            MessageBox.Show("them tre thanh cong")
        End If

    End Sub

    Private Sub themTre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tre = New TreBUS()
        maTr.Text = tre.nxtMaTre().ToString()
    End Sub

    Private Sub dth_TextChanged(sender As Object, e As EventArgs) Handles dth.TextChanged
        dth.Select(dth.TextLength, 0)
        For i = 0 To dth.TextLength - 1 Step 1
            If (arr.Contains(dth.Text(i)) = False) Then
                dth.Text = dth.Text.Remove(dth.TextLength - 1)
                Return
            End If
        Next

    End Sub

    Private Sub ngaySinhTr_ValueChanged(sender As Object, e As EventArgs) Handles ngaySinhTr.ValueChanged
        tuoi.Text = (DateTime.Now.Year - ngaySinhTr.Value.Year).ToString()
    End Sub

    Private Sub thoat_Click(sender As Object, e As EventArgs) Handles thoat.Click
        Me.Close()
    End Sub
End Class