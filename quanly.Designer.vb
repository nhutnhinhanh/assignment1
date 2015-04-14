<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quanly
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
        Me.txtma = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtten = New System.Windows.Forms.TextBox()
        Me.txtgia = New System.Windows.Forms.TextBox()
        Me.txtso = New System.Windows.Forms.TextBox()
        Me.txtct = New System.Windows.Forms.TextBox()
        Me.txtloai = New System.Windows.Forms.TextBox()
        Me.data1 = New System.Windows.Forms.DataGridView()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnxem = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtma
        '
        Me.txtma.Location = New System.Drawing.Point(141, 6)
        Me.txtma.Name = "txtma"
        Me.txtma.Size = New System.Drawing.Size(157, 20)
        Me.txtma.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "mã sản phẩm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "tên sản phẩm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "đơn giá"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "số lượng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "chi tiết sản phẩm"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "mã loại"
        '
        'txtten
        '
        Me.txtten.Location = New System.Drawing.Point(141, 37)
        Me.txtten.Name = "txtten"
        Me.txtten.Size = New System.Drawing.Size(157, 20)
        Me.txtten.TabIndex = 7
        '
        'txtgia
        '
        Me.txtgia.Location = New System.Drawing.Point(141, 69)
        Me.txtgia.Name = "txtgia"
        Me.txtgia.Size = New System.Drawing.Size(157, 20)
        Me.txtgia.TabIndex = 8
        '
        'txtso
        '
        Me.txtso.Location = New System.Drawing.Point(141, 107)
        Me.txtso.Name = "txtso"
        Me.txtso.Size = New System.Drawing.Size(157, 20)
        Me.txtso.TabIndex = 9
        '
        'txtct
        '
        Me.txtct.Location = New System.Drawing.Point(141, 139)
        Me.txtct.Name = "txtct"
        Me.txtct.Size = New System.Drawing.Size(157, 20)
        Me.txtct.TabIndex = 10
        '
        'txtloai
        '
        Me.txtloai.Location = New System.Drawing.Point(141, 175)
        Me.txtloai.Name = "txtloai"
        Me.txtloai.Size = New System.Drawing.Size(157, 20)
        Me.txtloai.TabIndex = 11
        '
        'data1
        '
        Me.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data1.Location = New System.Drawing.Point(322, 6)
        Me.data1.Name = "data1"
        Me.data1.Size = New System.Drawing.Size(346, 189)
        Me.data1.TabIndex = 12
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(241, 226)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 13
        Me.btnthem.Text = "thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnxem
        '
        Me.btnxem.Location = New System.Drawing.Point(519, 226)
        Me.btnxem.Name = "btnxem"
        Me.btnxem.Size = New System.Drawing.Size(75, 23)
        Me.btnxem.TabIndex = 14
        Me.btnxem.Text = "xem"
        Me.btnxem.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(427, 226)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 15
        Me.btnxoa.Text = "xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(332, 226)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 16
        Me.btnsua.Text = "sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'quanly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(691, 261)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnxem)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.data1)
        Me.Controls.Add(Me.txtloai)
        Me.Controls.Add(Me.txtct)
        Me.Controls.Add(Me.txtso)
        Me.Controls.Add(Me.txtgia)
        Me.Controls.Add(Me.txtten)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtma)
        Me.Name = "quanly"
        Me.Text = "quanly"
        CType(Me.data1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtma As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtten As System.Windows.Forms.TextBox
    Friend WithEvents txtgia As System.Windows.Forms.TextBox
    Friend WithEvents txtso As System.Windows.Forms.TextBox
    Friend WithEvents txtct As System.Windows.Forms.TextBox
    Friend WithEvents txtloai As System.Windows.Forms.TextBox
    Friend WithEvents data1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnxem As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
End Class
