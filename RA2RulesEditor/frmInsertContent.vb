Public Class frmInsertContent

	Public contentName, contentValue, contentComment As String

	Sub ClearForm()
		tbxName.Text = ""
		tbxValue.Text = ""
		tbxComment.Text = ""
	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

		contentName = tbxName.Text.Trim
		contentValue = tbxValue.Text.Trim
		contentComment = tbxComment.Text.Trim
		ClearForm()

	End Sub

	Sub validateInput() Handles tbxName.TextChanged, tbxValue.TextChanged
		Dim contentName As String = tbxName.Text.Trim()
		Dim contentValue As String = tbxValue.Text.Trim()

		If contentName <> "" And contentValue <> "" Then
			btnSave.Enabled = True
		Else
			btnSave.Enabled = False
		End If
	End Sub

End Class