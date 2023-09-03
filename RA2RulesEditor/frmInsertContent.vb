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

	Function validateInput() As Boolean

		Dim contentName As String = tbxName.Text.Trim()
		Dim contentValue As String = tbxValue.Text.Trim()

		Return Not (contentName <> "" And contentValue <> "")

	End Function

	Private Sub frmInsertContent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		tbxName.Focus()

	End Sub

	Private Sub preValidateInput(sender As Object, e As KeyEventArgs) Handles tbxName.TextAlignChanged, tbxValue.TextAlignChanged

		btnSave.Enabled = validateInput()

	End Sub

	Private Sub submitForm(sender As Object, e As KeyEventArgs) Handles tbxName.KeyDown, tbxValue.KeyDown

		If e.KeyValue = Keys.Enter Then
			e.SuppressKeyPress = True
			e.Handled = True
			If validateInput() Then
				btnSave_Click(sender, e)
			End If
		End If

	End Sub

End Class