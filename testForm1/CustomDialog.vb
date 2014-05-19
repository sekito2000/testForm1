Imports System.Windows.Forms

Public Class CustomDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

	Private Sub btnForm1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForm1.Click
		Dim str As String = CType(Me.Owner, Form1).TextBox1.Text
		Label1.Text = str
	End Sub
End Class
