Imports QuanLyNhaTreDAL
Imports QuanLyNhaTreDTO
Imports QuanLyNhaTreBUS
Public Class traCuuTre
    Private TT As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
    Dim mode As Integer = 0
    Private Sub traCuuTre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim khoidal As KhoiDAL = New KhoiDAL()
        Dim str As List(Of String) = New List(Of String)
        comboKhoi.Items.Add("NULL")
        khoidal.getListofTenKhoi(str)
        comboKhoi.Items.AddRange(str.ToArray())
        comboKhoi.SelectedIndex = 0

        comboTuoi.Items.Add(0)
        comboTuoi.Items.Add(3)
        comboTuoi.Items.Add(4)
        comboTuoi.Items.Add(5)

        str.Clear()
        Dim tinhtrangdal As PhieuTinhTrangDAL = New PhieuTinhTrangDAL()
        tinhtrangdal.getTinhTrang(TT)
        comboTinhTrang.Items.AddRange(TT.Keys.ToArray())
        comboTinhTrang.SelectedIndex = 0

    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim srhBUS As SearchBUS = New SearchBUS()
        Dim srhDTO As SearchDTO = New SearchDTO()
        Dim lopDAL As LopDAL = New LopDAL()
        Dim srhlist As List(Of SearchDTO) = New List(Of SearchDTO)

        Select Case mode
            Case 1
                srhDTO.Khoi1.TenKhoi1 = comboKhoi.SelectedItem
                srhDTO.Lop1.TenLop1 = comboLop.SelectedItem
            Case 2
                srhDTO.Tre1.TenTre1 = txtTen.Text
            Case 3
                srhDTO.Tre1.TenNha1 = txtTenNha.Text
                srhDTO.Tre1.PhuHuynh1 = txtTenBaMe.Text
                srhDTO.Tre1.Sdt1 = txtSDT.Text
                srhDTO.Tre1.NgaySinh1 = dtNgaySinh.Value.Date
                srhDTO.Tre1.DiaChi1 = txtDiaChi.Text
                srhDTO.Tre1.Tuoi1 = comboTuoi.SelectedItem
            Case 4
                srhDTO.TinhTrang1 = comboTinhTrang.SelectedItem
        End Select
        srhBUS.search(srhDTO, srhlist, mode)

        For i = 0 To srhlist.Count - 1 Step 1
            outputDataGrid.Rows.Add()
            outputDataGrid.Rows(i).Cells(0).Value = srhlist.Item(i).Tre1.TenTre1
            outputDataGrid.Rows(i).Cells(1).Value = srhlist.Item(i).Tre1.Tuoi1
            outputDataGrid.Rows(i).Cells(2).Value = srhlist.Item(i).Tre1.MaLop1
            outputDataGrid.Rows(i).Cells(3).Value = srhlist.Item(i).Tre1.GhiChu1

        Next
    End Sub

    Private Sub comboKhoi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboKhoi.SelectedIndexChanged

        comboLop.Items.Clear()
        Dim lopdal As LopDAL = New LopDAL()
        Dim str As List(Of String) = New List(Of String)
        Dim khoidal As KhoiDAL = New KhoiDAL()
        comboLop.Items.Add("NULL")
        If (comboKhoi.SelectedIndex = 0) Then
            comboLop.SelectedIndex = 0
        Else
            lopdal.getListofClassName_ByMaKhoi(str, khoidal.getMaKhoi_byTenKhoi(comboKhoi.SelectedItem))
            comboLop.Items.AddRange(str.ToArray())
            comboLop.SelectedIndex = 1
        End If


    End Sub

    Private Sub comboLop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboLop.SelectedIndexChanged
        If (comboLop.SelectedIndex = 0) Then
            comboKhoi.SelectedIndex = 0
        End If
    End Sub

    Private Sub radKhoi_CheckedChanged(sender As Object, e As EventArgs) Handles radKhoi.CheckedChanged
        mode = 1
        comboKhoi.Enabled = True
        comboLop.Enabled = True
        txtTen.Enabled = False
        comboTuoi.Enabled = False
        txtTenBaMe.Enabled = False
        txtSDT.Enabled = False
        txtDiaChi.Enabled = False
        txtTenNha.Enabled = False
        dtNgaySinh.Enabled = False
        comboTinhTrang.Enabled = False
    End Sub

    Private Sub radTen_CheckedChanged(sender As Object, e As EventArgs) Handles radTen.CheckedChanged
        mode = 2
        comboKhoi.Enabled = False
        comboLop.Enabled = False
        txtTen.Enabled = True
        comboTuoi.Enabled = False
        txtTenBaMe.Enabled = False
        txtSDT.Enabled = False
        txtDiaChi.Enabled = False
        txtTenNha.Enabled = False
        dtNgaySinh.Enabled = False
        comboTinhTrang.Enabled = False
    End Sub

    Private Sub radInfo_CheckedChanged(sender As Object, e As EventArgs) Handles radInfo.CheckedChanged
        mode = 3
        comboKhoi.Enabled = False
        comboLop.Enabled = False
        txtTen.Enabled = False
        comboTuoi.Enabled = True
        txtTenBaMe.Enabled = True
        txtSDT.Enabled = True
        txtDiaChi.Enabled = True
        txtTenNha.Enabled = True
        dtNgaySinh.Enabled = True
        comboTinhTrang.Enabled = False
    End Sub

    Private Sub radTT_CheckedChanged(sender As Object, e As EventArgs) Handles radTT.CheckedChanged
        mode = 4
        comboKhoi.Enabled = False
        comboLop.Enabled = False
        txtTen.Enabled = False
        comboTuoi.Enabled = False
        txtTenBaMe.Enabled = False
        txtSDT.Enabled = False
        txtDiaChi.Enabled = False
        txtTenNha.Enabled = False
        dtNgaySinh.Enabled = False
        comboTinhTrang.Enabled = True
    End Sub
End Class