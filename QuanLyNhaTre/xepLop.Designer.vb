<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xepLop
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
        Me.inputDataGrid = New System.Windows.Forms.DataGridView()
        Me.MaTre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoTenTre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayNhapHoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tuoi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.newInputDataGrid = New System.Windows.Forms.DataGridView()
        Me.MaTr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoTenTr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgayHocTr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TuoiTr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChuTr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.forward = New System.Windows.Forms.Button()
        Me.backward = New System.Windows.Forms.Button()
        Me.lhClass = New System.Windows.Forms.Label()
        Me.rhClass = New System.Windows.Forms.Label()
        Me.toLop = New System.Windows.Forms.ComboBox()
        Me.ngayhoc = New System.Windows.Forms.DateTimePicker()
        Me.comboKhoi = New System.Windows.Forms.ComboBox()
        Me.Grade = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.frmLop = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ghChu = New System.Windows.Forms.TextBox()
        Me.Nhan = New System.Windows.Forms.Button()
        Me.update = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        CType(Me.inputDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.newInputDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inputDataGrid
        '
        Me.inputDataGrid.AllowUserToAddRows = False
        Me.inputDataGrid.AllowUserToOrderColumns = True
        Me.inputDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.inputDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaTre, Me.HoTenTre, Me.NgayNhapHoc, Me.Tuoi, Me.GhiChu})
        Me.inputDataGrid.Location = New System.Drawing.Point(33, 109)
        Me.inputDataGrid.Name = "inputDataGrid"
        Me.inputDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.inputDataGrid.Size = New System.Drawing.Size(511, 398)
        Me.inputDataGrid.TabIndex = 0
        '
        'MaTre
        '
        Me.MaTre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MaTre.HeaderText = "Mã Trẻ"
        Me.MaTre.Name = "MaTre"
        Me.MaTre.ReadOnly = True
        '
        'HoTenTre
        '
        Me.HoTenTre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HoTenTre.HeaderText = "Họ Tên Trẻ"
        Me.HoTenTre.Name = "HoTenTre"
        Me.HoTenTre.ReadOnly = True
        '
        'NgayNhapHoc
        '
        Me.NgayNhapHoc.HeaderText = "Ngày Nhập Học"
        Me.NgayNhapHoc.Name = "NgayNhapHoc"
        Me.NgayNhapHoc.ReadOnly = True
        '
        'Tuoi
        '
        Me.Tuoi.HeaderText = "Tuổi"
        Me.Tuoi.Name = "Tuoi"
        Me.Tuoi.ReadOnly = True
        '
        'GhiChu
        '
        Me.GhiChu.HeaderText = "Ghi Chú"
        Me.GhiChu.Name = "GhiChu"
        Me.GhiChu.ReadOnly = True
        '
        'newInputDataGrid
        '
        Me.newInputDataGrid.AllowUserToAddRows = False
        Me.newInputDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.newInputDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaTr, Me.HoTenTr, Me.NgayHocTr, Me.TuoiTr, Me.GhiChuTr})
        Me.newInputDataGrid.Location = New System.Drawing.Point(626, 109)
        Me.newInputDataGrid.Name = "newInputDataGrid"
        Me.newInputDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.newInputDataGrid.Size = New System.Drawing.Size(540, 398)
        Me.newInputDataGrid.TabIndex = 1
        '
        'MaTr
        '
        Me.MaTr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MaTr.HeaderText = "Mã Trẻ"
        Me.MaTr.Name = "MaTr"
        '
        'HoTenTr
        '
        Me.HoTenTr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HoTenTr.HeaderText = "Họ Tên Trẻ"
        Me.HoTenTr.Name = "HoTenTr"
        '
        'NgayHocTr
        '
        Me.NgayHocTr.HeaderText = "Ngày Nhập Học"
        Me.NgayHocTr.Name = "NgayHocTr"
        '
        'TuoiTr
        '
        Me.TuoiTr.HeaderText = "Tuổi"
        Me.TuoiTr.Name = "TuoiTr"
        '
        'GhiChuTr
        '
        Me.GhiChuTr.HeaderText = "Ghi Chú"
        Me.GhiChuTr.Name = "GhiChuTr"
        '
        'forward
        '
        Me.forward.Location = New System.Drawing.Point(550, 210)
        Me.forward.Name = "forward"
        Me.forward.Size = New System.Drawing.Size(66, 64)
        Me.forward.TabIndex = 2
        Me.forward.Text = "Chuyển >>"
        Me.forward.UseVisualStyleBackColor = True
        '
        'backward
        '
        Me.backward.Location = New System.Drawing.Point(550, 310)
        Me.backward.Name = "backward"
        Me.backward.Size = New System.Drawing.Size(66, 67)
        Me.backward.TabIndex = 3
        Me.backward.Text = "<< Trở lại"
        Me.backward.UseVisualStyleBackColor = True
        '
        'lhClass
        '
        Me.lhClass.AutoSize = True
        Me.lhClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lhClass.Location = New System.Drawing.Point(29, 73)
        Me.lhClass.Name = "lhClass"
        Me.lhClass.Size = New System.Drawing.Size(58, 20)
        Me.lhClass.TabIndex = 4
        Me.lhClass.Text = "Từ Lớp"
        '
        'rhClass
        '
        Me.rhClass.AutoSize = True
        Me.rhClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rhClass.Location = New System.Drawing.Point(618, 74)
        Me.rhClass.Name = "rhClass"
        Me.rhClass.Size = New System.Drawing.Size(76, 20)
        Me.rhClass.TabIndex = 5
        Me.rhClass.Text = " Đến lớp :"
        '
        'toLop
        '
        Me.toLop.FormattingEnabled = True
        Me.toLop.Location = New System.Drawing.Point(767, 74)
        Me.toLop.Name = "toLop"
        Me.toLop.Size = New System.Drawing.Size(200, 21)
        Me.toLop.TabIndex = 7
        '
        'ngayhoc
        '
        Me.ngayhoc.Location = New System.Drawing.Point(767, 33)
        Me.ngayhoc.Name = "ngayhoc"
        Me.ngayhoc.Size = New System.Drawing.Size(200, 20)
        Me.ngayhoc.TabIndex = 8
        '
        'comboKhoi
        '
        Me.comboKhoi.FormattingEnabled = True
        Me.comboKhoi.Location = New System.Drawing.Point(95, 33)
        Me.comboKhoi.Name = "comboKhoi"
        Me.comboKhoi.Size = New System.Drawing.Size(196, 21)
        Me.comboKhoi.TabIndex = 9
        '
        'Grade
        '
        Me.Grade.AutoSize = True
        Me.Grade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grade.Location = New System.Drawing.Point(29, 31)
        Me.Grade.Name = "Grade"
        Me.Grade.Size = New System.Drawing.Size(40, 20)
        Me.Grade.TabIndex = 10
        Me.Grade.Text = "Khối"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(622, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Ngày Nhập Học"
        '
        'frmLop
        '
        Me.frmLop.FormattingEnabled = True
        Me.frmLop.Location = New System.Drawing.Point(95, 74)
        Me.frmLop.Name = "frmLop"
        Me.frmLop.Size = New System.Drawing.Size(196, 21)
        Me.frmLop.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(995, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Ghi Chú"
        '
        'ghChu
        '
        Me.ghChu.Location = New System.Drawing.Point(1069, 33)
        Me.ghChu.Name = "ghChu"
        Me.ghChu.Size = New System.Drawing.Size(97, 20)
        Me.ghChu.TabIndex = 14
        '
        'Nhan
        '
        Me.Nhan.Location = New System.Drawing.Point(999, 70)
        Me.Nhan.Name = "Nhan"
        Me.Nhan.Size = New System.Drawing.Size(167, 23)
        Me.Nhan.TabIndex = 15
        Me.Nhan.Text = "Nhận thông tin"
        Me.Nhan.UseVisualStyleBackColor = True
        '
        'update
        '
        Me.update.Location = New System.Drawing.Point(222, 529)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(123, 46)
        Me.update.TabIndex = 16
        Me.update.Text = "Nhập"
        Me.update.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Location = New System.Drawing.Point(844, 529)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(123, 46)
        Me.cancel.TabIndex = 17
        Me.cancel.Text = "Hủy"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'xepLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 599)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.Nhan)
        Me.Controls.Add(Me.ghChu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.frmLop)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Grade)
        Me.Controls.Add(Me.comboKhoi)
        Me.Controls.Add(Me.ngayhoc)
        Me.Controls.Add(Me.toLop)
        Me.Controls.Add(Me.rhClass)
        Me.Controls.Add(Me.lhClass)
        Me.Controls.Add(Me.backward)
        Me.Controls.Add(Me.forward)
        Me.Controls.Add(Me.newInputDataGrid)
        Me.Controls.Add(Me.inputDataGrid)
        Me.Name = "xepLop"
        Me.Text = "xepLop"
        CType(Me.inputDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.newInputDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inputDataGrid As DataGridView
    Friend WithEvents newInputDataGrid As DataGridView
    Friend WithEvents MaTre As DataGridViewTextBoxColumn
    Friend WithEvents HoTenTre As DataGridViewTextBoxColumn
    Friend WithEvents NgayNhapHoc As DataGridViewTextBoxColumn
    Friend WithEvents Tuoi As DataGridViewTextBoxColumn
    Friend WithEvents GhiChu As DataGridViewTextBoxColumn
    Friend WithEvents MaTr As DataGridViewTextBoxColumn
    Friend WithEvents HoTenTr As DataGridViewTextBoxColumn
    Friend WithEvents NgayHocTr As DataGridViewTextBoxColumn
    Friend WithEvents TuoiTr As DataGridViewTextBoxColumn
    Friend WithEvents GhiChuTr As DataGridViewTextBoxColumn
    Friend WithEvents forward As Button
    Friend WithEvents backward As Button
    Friend WithEvents lhClass As Label
    Friend WithEvents rhClass As Label
    Friend WithEvents toLop As ComboBox
    Friend WithEvents ngayhoc As DateTimePicker
    Friend WithEvents comboKhoi As ComboBox
    Friend WithEvents Grade As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents frmLop As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ghChu As TextBox
    Friend WithEvents Nhan As Button
    Friend WithEvents update As Button
    Friend WithEvents cancel As Button
End Class
