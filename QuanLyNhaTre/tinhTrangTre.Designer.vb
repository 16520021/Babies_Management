<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tinhTrangTre
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
        Me.maTre = New System.Windows.Forms.TextBox()
        Me.hoTen = New System.Windows.Forms.TextBox()
        Me.maLop = New System.Windows.Forms.TextBox()
        Me.ngayNhap = New System.Windows.Forms.DateTimePicker()
        Me.maTT = New System.Windows.Forms.TextBox()
        Me.ComboTT = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboLop = New System.Windows.Forms.ComboBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.maPhieu = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'maTre
        '
        Me.maTre.BackColor = System.Drawing.SystemColors.Control
        Me.maTre.Location = New System.Drawing.Point(93, 154)
        Me.maTre.Name = "maTre"
        Me.maTre.ReadOnly = True
        Me.maTre.Size = New System.Drawing.Size(121, 20)
        Me.maTre.TabIndex = 1
        '
        'hoTen
        '
        Me.hoTen.Enabled = False
        Me.hoTen.Location = New System.Drawing.Point(93, 117)
        Me.hoTen.Name = "hoTen"
        Me.hoTen.Size = New System.Drawing.Size(121, 20)
        Me.hoTen.TabIndex = 2
        '
        'maLop
        '
        Me.maLop.BackColor = System.Drawing.SystemColors.Control
        Me.maLop.Location = New System.Drawing.Point(93, 79)
        Me.maLop.Name = "maLop"
        Me.maLop.ReadOnly = True
        Me.maLop.Size = New System.Drawing.Size(121, 20)
        Me.maLop.TabIndex = 3
        '
        'ngayNhap
        '
        Me.ngayNhap.Enabled = False
        Me.ngayNhap.Location = New System.Drawing.Point(314, 43)
        Me.ngayNhap.Name = "ngayNhap"
        Me.ngayNhap.Size = New System.Drawing.Size(200, 20)
        Me.ngayNhap.TabIndex = 4
        '
        'maTT
        '
        Me.maTT.Enabled = False
        Me.maTT.Location = New System.Drawing.Point(314, 117)
        Me.maTT.Name = "maTT"
        Me.maTT.Size = New System.Drawing.Size(100, 20)
        Me.maTT.TabIndex = 6
        '
        'ComboTT
        '
        Me.ComboTT.Enabled = False
        Me.ComboTT.FormattingEnabled = True
        Me.ComboTT.Location = New System.Drawing.Point(314, 77)
        Me.ComboTT.Name = "ComboTT"
        Me.ComboTT.Size = New System.Drawing.Size(121, 21)
        Me.ComboTT.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Họ Tên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Mã Trẻ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tên Lớp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Mã Lớp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(245, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ngày Nhập"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(245, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Tình Trạng"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(245, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Mã TT"
        '
        'ComboLop
        '
        Me.ComboLop.FormattingEnabled = True
        Me.ComboLop.Location = New System.Drawing.Point(93, 41)
        Me.ComboLop.Name = "ComboLop"
        Me.ComboLop.Size = New System.Drawing.Size(121, 21)
        Me.ComboLop.TabIndex = 15
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(128, 208)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(75, 23)
        Me.OK.TabIndex = 16
        Me.OK.Text = "Ghi Nhận"
        Me.OK.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(339, 208)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 23)
        Me.cancel.TabIndex = 17
        Me.cancel.Text = "Exit"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'maPhieu
        '
        Me.maPhieu.Location = New System.Drawing.Point(314, 154)
        Me.maPhieu.Name = "maPhieu"
        Me.maPhieu.ReadOnly = True
        Me.maPhieu.Size = New System.Drawing.Size(100, 20)
        Me.maPhieu.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(248, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Mã Phiếu"
        '
        'tinhTrangTre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 262)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.maPhieu)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.ComboLop)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboTT)
        Me.Controls.Add(Me.maTT)
        Me.Controls.Add(Me.ngayNhap)
        Me.Controls.Add(Me.maLop)
        Me.Controls.Add(Me.hoTen)
        Me.Controls.Add(Me.maTre)
        Me.Name = "tinhTrangTre"
        Me.Text = "tinhTrangTre"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents maTre As TextBox
    Friend WithEvents hoTen As TextBox
    Friend WithEvents maLop As TextBox
    Friend WithEvents ngayNhap As DateTimePicker
    Friend WithEvents maTT As TextBox
    Friend WithEvents ComboTT As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboLop As ComboBox
    Friend WithEvents OK As Button
    Friend WithEvents cancel As Button
    Friend WithEvents maPhieu As TextBox
    Friend WithEvents Label8 As Label
End Class
