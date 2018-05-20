Public Class mainFrom
    Private Sub ThêmTrẻToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmTrẻToolStripMenuItem.Click
        Dim f1 As themTre
        f1 = New themTre
        f1.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
