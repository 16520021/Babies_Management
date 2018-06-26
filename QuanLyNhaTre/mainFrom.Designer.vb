<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainFrom
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.themTre = New System.Windows.Forms.ToolStripMenuItem()
        Me.traCuu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TT = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lop = New System.Windows.Forms.ToolStripMenuItem()
        Me.xepLop = New System.Windows.Forms.ToolStripMenuItem()
        Me.BáoCáoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TìnhTrạngTrẻToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuiDinh = New System.Windows.Forms.ToolStripMenuItem()
        Me.thayDoiSiSo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TreToolStripMenuItem, Me.Lop, Me.BáoCáoToolStripMenuItem, Me.QuiDinh})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(848, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "&Close"
        '
        'TreToolStripMenuItem
        '
        Me.TreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.themTre, Me.traCuu, Me.TT})
        Me.TreToolStripMenuItem.Name = "TreToolStripMenuItem"
        Me.TreToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.TreToolStripMenuItem.Text = "&Trẻ"
        '
        'themTre
        '
        Me.themTre.Name = "themTre"
        Me.themTre.Size = New System.Drawing.Size(152, 22)
        Me.themTre.Text = "Thêm Trẻ "
        '
        'traCuu
        '
        Me.traCuu.Name = "traCuu"
        Me.traCuu.Size = New System.Drawing.Size(152, 22)
        Me.traCuu.Text = "Tra Cứu Trẻ"
        '
        'TT
        '
        Me.TT.Name = "TT"
        Me.TT.Size = New System.Drawing.Size(152, 22)
        Me.TT.Text = "Tình Trạng Trẻ"
        '
        'Lop
        '
        Me.Lop.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.xepLop})
        Me.Lop.Name = "Lop"
        Me.Lop.Size = New System.Drawing.Size(39, 20)
        Me.Lop.Text = "Lớp"
        '
        'xepLop
        '
        Me.xepLop.Name = "xepLop"
        Me.xepLop.Size = New System.Drawing.Size(152, 22)
        Me.xepLop.Text = "Xếp Lớp"
        '
        'BáoCáoToolStripMenuItem
        '
        Me.BáoCáoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TìnhTrạngTrẻToolStripMenuItem})
        Me.BáoCáoToolStripMenuItem.Name = "BáoCáoToolStripMenuItem"
        Me.BáoCáoToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.BáoCáoToolStripMenuItem.Text = "Báo Cáo"
        '
        'TìnhTrạngTrẻToolStripMenuItem
        '
        Me.TìnhTrạngTrẻToolStripMenuItem.Name = "TìnhTrạngTrẻToolStripMenuItem"
        Me.TìnhTrạngTrẻToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TìnhTrạngTrẻToolStripMenuItem.Text = "Tình Trạng Trẻ"
        '
        'QuiDinh
        '
        Me.QuiDinh.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.thayDoiSiSo})
        Me.QuiDinh.Name = "QuiDinh"
        Me.QuiDinh.Size = New System.Drawing.Size(66, 20)
        Me.QuiDinh.Text = "Qui Định"
        '
        'thayDoiSiSo
        '
        Me.thayDoiSiSo.Name = "thayDoiSiSo"
        Me.thayDoiSiSo.Size = New System.Drawing.Size(152, 22)
        Me.thayDoiSiSo.Text = "Thay Đổi Sỉ Số"
        '
        'mainFrom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 452)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "mainFrom"
        Me.Text = "Quản Lý Nhà Trẻ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents themTre As ToolStripMenuItem
    Friend WithEvents Lop As ToolStripMenuItem
    Friend WithEvents traCuu As ToolStripMenuItem
    Friend WithEvents xepLop As ToolStripMenuItem
    Friend WithEvents TT As ToolStripMenuItem
    Friend WithEvents BáoCáoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TìnhTrạngTrẻToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuiDinh As ToolStripMenuItem
    Friend WithEvents thayDoiSiSo As ToolStripMenuItem
End Class
