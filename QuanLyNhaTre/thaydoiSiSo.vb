Imports QuanLyNhaTreBUS
Imports QuanLyNhaTreDAL
Public Class thaydoiSiSo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult
        Dim lopdal As LopDAL = New LopDAL()
        Dim tredal As TreDAL = New TreDAL()
        Dim listofclass As List(Of String) = New List(Of String)
        Dim listIDclass As List(Of Integer) = New List(Of Integer)
        Dim sumOfTre As Integer = 0

        If (Integer.Parse(siSo.Text) < lopdal.getMaxSiSo()) Then
            result = MessageBox.Show("Nhập sỉ số bé hơn sỉ số ban đầu có thể sẽ xảy ra một vài thay đổi học sinh tronh lớp, bạn có muốn tiếp tục ?", "caption", MessageBoxButtons.YesNo)
            If (result = DialogResult.No) Then
                Return
            End If
        End If

        For i = 1 To 3 Step 1
            lopdal.getListofClassName_ByMaKhoi(listofclass, i)
            For Each clss In listofclass
                listIDclass.Add(lopdal.getMaLop_ByTenLop(clss))
            Next

            For j = 0 To listIDclass.Count - 1 Step 1
                sumOfTre += lopdal.getSiSo(listIDclass(j))
            Next

            If (sumOfTre > Integer.Parse(siSo.Text) * 4) Then
                result = MessageBox.Show("Số trẻ vượt quá sỉ số mới quy định", "không thành công")
                Return
            Else
                For k = 0 To listIDclass.Count - 1 Step 1
                    If (lopdal.getSiSo(listIDclass(k)) > Integer.Parse(siSo.Text)) Then
                        Dim malop As Integer = listIDclass(k)
                        result = MessageBox.Show("Số trẻ hiện tại trong lớp " & malop.ToString() & " vượt quá sỉ số mới, vui lòng chuyển một vài em sang lớp khác cùng khối!!!")
                        Return
                    End If
                Next
            End If
            sumOfTre = 0
        Next

        If (lopdal.updateMaxSiSo(Integer.Parse(siSo.Text))) Then
            MessageBox.Show("cập nhật quy định thành công")
            Me.Close()
        Else
            MessageBox.Show("cập nhật quy định không thành công")
            Return
        End If

    End Sub

    Private Sub thaydoiSiSo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lopdal As LopDAL = New LopDAL()

        siSo.Text = lopdal.getMaxSiSo().ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class