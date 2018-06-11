<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class traCuuTre
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
        Me.outputDataGrid = New System.Windows.Forms.DataGridView()
        Me.HoTen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tuoi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Khoi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.comboKhoi = New System.Windows.Forms.ComboBox()
        Me.comboLop = New System.Windows.Forms.ComboBox()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.txtTenBaMe = New System.Windows.Forms.TextBox()
        Me.txtTenNha = New System.Windows.Forms.TextBox()
        Me.comboTuoi = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.comboTinhTrang = New System.Windows.Forms.ComboBox()
        Me.dtNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.radKhoi = New System.Windows.Forms.RadioButton()
        Me.radTT = New System.Windows.Forms.RadioButton()
        Me.radTen = New System.Windows.Forms.RadioButton()
        Me.radInfo = New System.Windows.Forms.RadioButton()
        CType(Me.outputDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'outputDataGrid
        '
        Me.outputDataGrid.AllowUserToAddRows = False
        Me.outputDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.outputDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HoTen, Me.Tuoi, Me.Khoi, Me.GhiChu})
        Me.outputDataGrid.Location = New System.Drawing.Point(13, 235)
        Me.outputDataGrid.Name = "outputDataGrid"
        Me.outputDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.outputDataGrid.Size = New System.Drawing.Size(955, 213)
        Me.outputDataGrid.TabIndex = 0
        '
        'HoTen
        '
        Me.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HoTen.HeaderText = "Họ Tên"
        Me.HoTen.Name = "HoTen"
        '
        'Tuoi
        '
        Me.Tuoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Tuoi.HeaderText = "Tuổi"
        Me.Tuoi.Name = "Tuoi"
        '
        'Khoi
        '
        Me.Khoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Khoi.HeaderText = "Khối Lớp"
        Me.Khoi.Name = "Khoi"
        '
        'GhiChu
        '
        Me.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GhiChu.HeaderText = "Ghi Chú"
        Me.GhiChu.Name = "GhiChu"
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(211, 191)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(162, 29)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(617, 191)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(162, 29)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'comboKhoi
        '
        Me.comboKhoi.Enabled = False
        Me.comboKhoi.FormattingEnabled = True
        Me.comboKhoi.Location = New System.Drawing.Point(106, 12)
        Me.comboKhoi.Name = "comboKhoi"
        Me.comboKhoi.Size = New System.Drawing.Size(165, 21)
        Me.comboKhoi.TabIndex = 3
        '
        'comboLop
        '
        Me.comboLop.Enabled = False
        Me.comboLop.FormattingEnabled = True
        Me.comboLop.Location = New System.Drawing.Point(106, 51)
        Me.comboLop.Name = "comboLop"
        Me.comboLop.Size = New System.Drawing.Size(165, 21)
        Me.comboLop.TabIndex = 4
        '
        'txtTen
        '
        Me.txtTen.Enabled = False
        Me.txtTen.Location = New System.Drawing.Point(106, 91)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(165, 20)
        Me.txtTen.TabIndex = 5
        '
        'txtSDT
        '
        Me.txtSDT.Enabled = False
        Me.txtSDT.Location = New System.Drawing.Point(447, 91)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(174, 20)
        Me.txtSDT.TabIndex = 6
        '
        'txtTenBaMe
        '
        Me.txtTenBaMe.Enabled = False
        Me.txtTenBaMe.Location = New System.Drawing.Point(447, 51)
        Me.txtTenBaMe.Name = "txtTenBaMe"
        Me.txtTenBaMe.Size = New System.Drawing.Size(174, 20)
        Me.txtTenBaMe.TabIndex = 7
        '
        'txtTenNha
        '
        Me.txtTenNha.Enabled = False
        Me.txtTenNha.Location = New System.Drawing.Point(447, 12)
        Me.txtTenNha.Name = "txtTenNha"
        Me.txtTenNha.Size = New System.Drawing.Size(174, 20)
        Me.txtTenNha.TabIndex = 8
        '
        'comboTuoi
        '
        Me.comboTuoi.Enabled = False
        Me.comboTuoi.FormattingEnabled = True
        Me.comboTuoi.Location = New System.Drawing.Point(106, 130)
        Me.comboTuoi.Name = "comboTuoi"
        Me.comboTuoi.Size = New System.Drawing.Size(165, 21)
        Me.comboTuoi.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Khối"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(367, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "SĐT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(367, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tên ba mẹ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(367, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Tên ở nhà"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Tuổi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Họ Tên"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Lớp"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Enabled = False
        Me.txtDiaChi.Location = New System.Drawing.Point(447, 130)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(174, 20)
        Me.txtDiaChi.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(367, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Địa chỉ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(701, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Ngày Sinh"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(701, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Tình Trạng"
        '
        'comboTinhTrang
        '
        Me.comboTinhTrang.Enabled = False
        Me.comboTinhTrang.FormattingEnabled = True
        Me.comboTinhTrang.Location = New System.Drawing.Point(775, 50)
        Me.comboTinhTrang.Name = "comboTinhTrang"
        Me.comboTinhTrang.Size = New System.Drawing.Size(174, 21)
        Me.comboTinhTrang.TabIndex = 30
        '
        'dtNgaySinh
        '
        Me.dtNgaySinh.Enabled = False
        Me.dtNgaySinh.Location = New System.Drawing.Point(775, 19)
        Me.dtNgaySinh.Name = "dtNgaySinh"
        Me.dtNgaySinh.Size = New System.Drawing.Size(174, 20)
        Me.dtNgaySinh.TabIndex = 31
        '
        'radKhoi
        '
        Me.radKhoi.AutoSize = True
        Me.radKhoi.Location = New System.Drawing.Point(775, 98)
        Me.radKhoi.Name = "radKhoi"
        Me.radKhoi.Size = New System.Drawing.Size(63, 17)
        Me.radKhoi.TabIndex = 32
        Me.radKhoi.TabStop = True
        Me.radKhoi.Text = "Khối lớp"
        Me.radKhoi.UseVisualStyleBackColor = True
        '
        'radTT
        '
        Me.radTT.AutoSize = True
        Me.radTT.Location = New System.Drawing.Point(871, 134)
        Me.radTT.Name = "radTT"
        Me.radTT.Size = New System.Drawing.Size(73, 17)
        Me.radTT.TabIndex = 33
        Me.radTT.TabStop = True
        Me.radTT.Text = "Tình trạng"
        Me.radTT.UseVisualStyleBackColor = True
        '
        'radTen
        '
        Me.radTen.AutoSize = True
        Me.radTen.Location = New System.Drawing.Point(775, 134)
        Me.radTen.Name = "radTen"
        Me.radTen.Size = New System.Drawing.Size(72, 17)
        Me.radTen.TabIndex = 34
        Me.radTen.TabStop = True
        Me.radTen.Text = "Họ tên trẻ"
        Me.radTen.UseVisualStyleBackColor = True
        '
        'radInfo
        '
        Me.radInfo.AutoSize = True
        Me.radInfo.Location = New System.Drawing.Point(871, 98)
        Me.radInfo.Name = "radInfo"
        Me.radInfo.Size = New System.Drawing.Size(97, 17)
        Me.radInfo.TabIndex = 35
        Me.radInfo.TabStop = True
        Me.radInfo.Text = "Thông tin khác"
        Me.radInfo.UseVisualStyleBackColor = True
        '
        'traCuuTre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 451)
        Me.Controls.Add(Me.radInfo)
        Me.Controls.Add(Me.radTen)
        Me.Controls.Add(Me.radTT)
        Me.Controls.Add(Me.radKhoi)
        Me.Controls.Add(Me.dtNgaySinh)
        Me.Controls.Add(Me.comboTinhTrang)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboTuoi)
        Me.Controls.Add(Me.txtTenNha)
        Me.Controls.Add(Me.txtTenBaMe)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.txtTen)
        Me.Controls.Add(Me.comboLop)
        Me.Controls.Add(Me.comboKhoi)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.outputDataGrid)
        Me.Name = "traCuuTre"
        Me.Text = "Tra Cứu Trẻ"
        CType(Me.outputDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents outputDataGrid As DataGridView
    Friend WithEvents HoTen As DataGridViewTextBoxColumn
    Friend WithEvents Tuoi As DataGridViewTextBoxColumn
    Friend WithEvents Khoi As DataGridViewTextBoxColumn
    Friend WithEvents GhiChu As DataGridViewTextBoxColumn
    Friend WithEvents OK As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents comboKhoi As ComboBox
    Friend WithEvents comboLop As ComboBox
    Friend WithEvents txtTen As TextBox
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents txtTenBaMe As TextBox
    Friend WithEvents txtTenNha As TextBox
    Friend WithEvents comboTuoi As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents comboTinhTrang As ComboBox
    Friend WithEvents dtNgaySinh As DateTimePicker
    Friend WithEvents radKhoi As RadioButton
    Friend WithEvents radTT As RadioButton
    Friend WithEvents radTen As RadioButton
    Friend WithEvents radInfo As RadioButton
End Class
