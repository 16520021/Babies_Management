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
        CType(Me.inputDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inputDataGrid
        '
        Me.inputDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.inputDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaTre, Me.HoTenTre})
        Me.inputDataGrid.Location = New System.Drawing.Point(13, 13)
        Me.inputDataGrid.Name = "inputDataGrid"
        Me.inputDataGrid.Size = New System.Drawing.Size(306, 300)
        Me.inputDataGrid.TabIndex = 0
        '
        'MaTre
        '
        Me.MaTre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MaTre.HeaderText = "MaTre"
        Me.MaTre.Name = "MaTre"
        '
        'HoTenTre
        '
        Me.HoTenTre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HoTenTre.HeaderText = "HoTenTre"
        Me.HoTenTre.Name = "HoTenTre"
        '
        'xepLop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 512)
        Me.Controls.Add(Me.inputDataGrid)
        Me.Name = "xepLop"
        Me.Text = "xepLop"
        CType(Me.inputDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents inputDataGrid As DataGridView
    Friend WithEvents MaTre As DataGridViewTextBoxColumn
    Friend WithEvents HoTenTre As DataGridViewTextBoxColumn
End Class
