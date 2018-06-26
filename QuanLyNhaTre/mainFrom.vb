Public Class mainFrom
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ThemTreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles themTre.Click
        Dim tr As themTre = New themTre
        If (Application.OpenForms().OfType(Of themTre).Any = Nothing) Then
            tr.Show()
        End If
    End Sub

    Private Sub xepLop_Click(sender As Object, e As EventArgs) Handles xepLop.Click
        Dim xl As xepLop = New xepLop
        If (Application.OpenForms().OfType(Of xepLop).Any = Nothing) Then
            xl.Show()
        End If
    End Sub

    Private Sub TT_Click(sender As Object, e As EventArgs) Handles TT.Click
        Dim tt As tinhTrangTre = New tinhTrangTre
        If (Application.OpenForms().OfType(Of tinhTrangTre).Any = Nothing) Then
            tt.Show()
        End If

    End Sub

    Private Sub traCuu_Click(sender As Object, e As EventArgs) Handles traCuu.Click
        Dim tc As traCuuTre = New traCuuTre
        If (Application.OpenForms().OfType(Of traCuuTre).Any = Nothing) Then
            tc.Show()
        End If
    End Sub

    Private Sub TìnhTrạngTrẻToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìnhTrạngTrẻToolStripMenuItem.Click
        Dim bc As baocaoTinhTrangTre = New baocaoTinhTrangTre
        If (Application.OpenForms().OfType(Of baocaoTinhTrangTre).Any = Nothing) Then
            bc.Show()
        End If
    End Sub

    Private Sub thayDoiSiSo_Click(sender As Object, e As EventArgs) Handles thayDoiSiSo.Click
        Dim ss As thaydoiSiSo = New thaydoiSiSo
        If (Application.OpenForms().OfType(Of thaydoiSiSo).Any = Nothing) Then
            ss.Show()
        End If
    End Sub
End Class
