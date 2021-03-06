﻿Imports QuanLyNhaTreBUS
Imports QuanLyNhaTreDAL
Imports QuanLyNhaTreDTO

Public Class xepLop
    Public selectedIndex As Integer
    Public maLopCu As Integer = 0
    Private Sub xepLop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim khoiDAL As KhoiDAL = New KhoiDAL()
        Dim listKhoi As List(Of String) = New List(Of String)
        khoiDAL.getListofTenKhoi(listKhoi)

        For i = 0 To listKhoi.Count - 1 Step 1
            comboKhoi.Items.Add(listKhoi(i))
        Next
        comboKhoi.SelectedIndex = 0

    End Sub

    Private Sub comboKhoi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboKhoi.SelectedIndexChanged

        toLop.Items.Clear()
        frmLop.Items.Clear()

        Dim lopDAL As LopDAL = New LopDAL()
        Dim khoiDAL As KhoiDAL = New KhoiDAL()
        Dim listTenLop As List(Of String) = New List(Of String)

        Dim makhoi As Integer = khoiDAL.getMaKhoi_byTenKhoi(comboKhoi.SelectedItem)
        lopDAL.getListofClassName_ByMaKhoi(listTenLop, makhoi)

        For i = 0 To listTenLop.Count - 1 Step 1
            toLop.Items.Add(listTenLop(i))
        Next
        toLop.SelectedIndex = 0

        frmLop.Items.Add("chua co lop")
        For i = 0 To listTenLop.Count - 1 Step 1
            frmLop.Items.Add(listTenLop(i))
        Next
        frmLop.SelectedIndex = 0
    End Sub

    Private Sub frmLop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles frmLop.SelectedIndexChanged

        inputDataGrid.Rows.Clear()
        Dim treDAL As TreDAL = New TreDAL()
        Dim lopDAL As LopDAL = New LopDAL()
        Dim malop As Integer = 0

        Dim listoftre As List(Of TreDTO) = New List(Of TreDTO)

        If (frmLop.SelectedText = "chua co lop") Then
            treDAL.getListOfTre_byMaLop(listoftre, 0)
        Else
            malop = lopDAL.getMaLop_ByTenLop(frmLop.SelectedItem)
            treDAL.getListOfTre_byMaLop(listoftre, malop)
        End If
        Try
            For i = 0 To listoftre.Count - 1 Step 1
                inputDataGrid.Rows.Add()
                inputDataGrid.Rows(i).Cells(0).Value = listoftre.Item(i).MaTre1
                inputDataGrid.Rows(i).Cells(1).Value = listoftre.Item(i).TenTre1
                inputDataGrid.Rows(i).Cells(2).Value = ngayhoc.Value.Date
                inputDataGrid.Rows(i).Cells(3).Value = listoftre.Item(i).Tuoi1
                inputDataGrid.Rows(i).Cells(4).Value = ghChu.Text
            Next
        Catch ex As Exception
        End Try
        maLopCu = malop
    End Sub

    Private Sub forward_Click(sender As Object, e As EventArgs) Handles forward.Click

        If (inputDataGrid.RowCount() = 0) Then
            Return
        End If

        If (inputDataGrid.Rows(selectedIndex).Cells(3).Value = 3 And comboKhoi.SelectedItem <> "mam") Then
            MessageBox.Show("tre 3 tuoi chi duoc hoc lop mam")
            Return
        End If
        If (inputDataGrid.Rows(selectedIndex).Cells(3).Value = 4 And comboKhoi.SelectedItem <> "choi") Then
            MessageBox.Show("tre 4 tuoi chi duoc hoc lop choi")
            Return
        End If
        If (inputDataGrid.Rows(selectedIndex).Cells(3).Value = 5 And comboKhoi.SelectedItem <> "la") Then
            MessageBox.Show("tre 5 tuoi chi duoc hoc lop la")
            Return
        End If

        Dim n As Integer = newInputDataGrid.Rows.Add()
        Dim lopdal As KhoiDAL = New KhoiDAL()

        newInputDataGrid.Rows(n).Cells(0).Value = inputDataGrid.Rows(selectedIndex).Cells(0).Value
        newInputDataGrid.Rows(n).Cells(1).Value = inputDataGrid.Rows(selectedIndex).Cells(1).Value
        newInputDataGrid.Rows(n).Cells(2).Value = inputDataGrid.Rows(selectedIndex).Cells(2).Value
        newInputDataGrid.Rows(n).Cells(3).Value = inputDataGrid.Rows(selectedIndex).Cells(3).Value
        newInputDataGrid.Rows(n).Cells(4).Value = inputDataGrid.Rows(selectedIndex).Cells(4).Value

        inputDataGrid.Rows.RemoveAt(selectedIndex)
    End Sub

    Private Sub inputDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles inputDataGrid.CellClick
        selectedIndex = e.RowIndex
        newInputDataGrid.ClearSelection()
    End Sub

    Private Sub backward_Click(sender As Object, e As EventArgs) Handles backward.Click

        If (newInputDataGrid.RowCount() = 0) Then
            Return
        End If
        Dim n As Integer = inputDataGrid.Rows.Add()

        inputDataGrid.Rows(n).Cells(0).Value = newInputDataGrid.Rows(selectedIndex).Cells(0).Value
        inputDataGrid.Rows(n).Cells(1).Value = newInputDataGrid.Rows(selectedIndex).Cells(1).Value
        inputDataGrid.Rows(n).Cells(2).Value = newInputDataGrid.Rows(selectedIndex).Cells(2).Value
        inputDataGrid.Rows(n).Cells(3).Value = newInputDataGrid.Rows(selectedIndex).Cells(3).Value
        inputDataGrid.Rows(n).Cells(4).Value = newInputDataGrid.Rows(selectedIndex).Cells(4).Value

        newInputDataGrid.Rows.RemoveAt(selectedIndex)
    End Sub

    Private Sub newInputDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles newInputDataGrid.CellClick
        selectedIndex = e.RowIndex
        inputDataGrid.ClearSelection()
    End Sub

    Private Sub Nhan_Click(sender As Object, e As EventArgs) Handles Nhan.Click
        Try
            inputDataGrid.Rows(selectedIndex).Cells(2).Value = ngayhoc.Value.Date
            inputDataGrid.Rows(selectedIndex).Cells(4).Value = ghChu.Text
        Catch ex As Exception
            MessageBox.Show("vui long nhap ghi chu hoac dung bam nut !")
        End Try
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click

        Dim tredal As TreDAL = New TreDAL()
        Dim lopdal As LopDAL = New LopDAL()
        Dim malop As Integer = 0
        Dim isSucceeded = False
        Try
            malop = lopdal.getMaLop_ByTenLop(toLop.SelectedItem.ToString())
            If (maLopCu = 0) Then
                For i = 0 To newInputDataGrid.Rows.Count() - 1 Step 1
                    tredal.updateTre_NullField(newInputDataGrid.Rows(i).Cells(0).Value, newInputDataGrid.Rows(i).Cells(2).Value, newInputDataGrid.Rows(i).Cells(4).Value, malop)
                    isSucceeded = lopdal.increaseSiSo(malop)
                    If (isSucceeded = False) Then
                        MessageBox.Show(" da du si so gioi han ")
                    Else
                        MessageBox.Show("them thanh cong")
                    End If
                Next
            Else
                For i = 0 To newInputDataGrid.Rows.Count() - 1 Step 1
                    tredal.updateTre_NullField(newInputDataGrid.Rows(i).Cells(0).Value, newInputDataGrid.Rows(i).Cells(2).Value, newInputDataGrid.Rows(i).Cells(4).Value, malop)
                    isSucceeded = lopdal.increaseSiSo(malop)
                    If (isSucceeded = False) Then
                        MessageBox.Show(" da du si so gioi han ")
                    Else
                        MessageBox.Show("them thanh cong")
                        lopdal.decreaseSiSo(maLopCu)
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("khong co hoc sinh nao chuyen lop")
        End Try
        Me.Close()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
End Class