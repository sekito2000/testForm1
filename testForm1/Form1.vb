Public Class Form1

	Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		'[設定]ﾂｰﾙﾁｯﾌﾟ
		ToolTip1.SetToolTip(btnToolTip2, "ｿｰｽより設定分")
		ToolTip1.InitialDelay = 50	'表示までの時間(ﾐﾘ秒)
		ToolTip1.AutoPopDelay = 1000	'表示時間(ﾐﾘ秒)
	End Sub


	Private Sub btnDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDialog.Click
		Using dialog As New CustomDialog
			dialog.ShowDialog(Me)
		End Using
	End Sub
End Class
