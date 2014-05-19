<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.btnToolTip = New System.Windows.Forms.Button()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.btnToolTip2 = New System.Windows.Forms.Button()
		Me.btnDialog = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'btnToolTip
		'
		Me.btnToolTip.Location = New System.Drawing.Point(45, 48)
		Me.btnToolTip.Name = "btnToolTip"
		Me.btnToolTip.Size = New System.Drawing.Size(137, 23)
		Me.btnToolTip.TabIndex = 0
		Me.btnToolTip.Text = "ToolTip表示されるﾎﾞﾀﾝ"
		Me.ToolTip1.SetToolTip(Me.btnToolTip, "ﾎﾞﾀﾝのToolTip")
		Me.btnToolTip.UseVisualStyleBackColor = True
		'
		'btnToolTip2
		'
		Me.btnToolTip2.Location = New System.Drawing.Point(45, 77)
		Me.btnToolTip2.Name = "btnToolTip2"
		Me.btnToolTip2.Size = New System.Drawing.Size(137, 23)
		Me.btnToolTip2.TabIndex = 1
		Me.btnToolTip2.Text = "ToolTip表示されるﾎﾞﾀﾝ2"
		Me.btnToolTip2.UseVisualStyleBackColor = True
		'
		'btnDialog
		'
		Me.btnDialog.Location = New System.Drawing.Point(45, 131)
		Me.btnDialog.Name = "btnDialog"
		Me.btnDialog.Size = New System.Drawing.Size(137, 23)
		Me.btnDialog.TabIndex = 2
		Me.btnDialog.Text = "独自ﾀﾞｲｱﾛｸﾞ表示"
		Me.btnDialog.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(45, 106)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(100, 19)
		Me.TextBox1.TabIndex = 3
		'
		'TextBox2
		'
		Me.TextBox2.AcceptsReturn = True
		Me.TextBox2.Location = New System.Drawing.Point(45, 177)
		Me.TextBox2.Multiline = True
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(100, 73)
		Me.TextBox2.TabIndex = 4
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(43, 162)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(121, 12)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "MultiLineのﾃｷｽﾄﾎﾞｯｸｽ"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(185, 162)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(72, 12)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "ﾊﾟｽﾜｰﾄﾞ伏字"
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(187, 177)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBox3.Size = New System.Drawing.Size(100, 19)
		Me.TextBox3.TabIndex = 7
		'
		'Form1
		'
		Me.AcceptButton = Me.btnDialog
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 262)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.btnDialog)
		Me.Controls.Add(Me.btnToolTip2)
		Me.Controls.Add(Me.btnToolTip)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents btnToolTip As System.Windows.Forms.Button
	Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
	Friend WithEvents btnToolTip2 As System.Windows.Forms.Button
	Friend WithEvents btnDialog As System.Windows.Forms.Button
	Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
	Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents TextBox3 As System.Windows.Forms.TextBox

End Class
