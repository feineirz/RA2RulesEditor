Public Class frmEditValue
	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

		Me.Dispose()

	End Sub

	Private Sub tbxValue_GotFocus(sender As Object, e As EventArgs) Handles tbxValue.GotFocus

		tbxValue.SelectAll()

	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

		curLVI.SubItems(1).Text = tbxValue.Text.Trim
		curLVI.SubItems(3).Text = tbxComment.Text.Trim.Replace(vbCr, "").Replace(vbLf, " ")
		Dim Content As String = curLVI.Text & "=" & curLVI.SubItems(1).Text & Chr(9) & ";" & Chr(9) & OldValue & Chr(9) & ";" & curLVI.SubItems(3).Text

		UpdateLineData(lblRefLineNo.Text, Content)
		Me.Dispose()

	End Sub

	Private Sub tbxValue_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxValue.KeyDown

		If e.KeyData = Keys.Enter Then
			e.Handled = True
			e.SuppressKeyPress = False
			btnSave_Click(Nothing, Nothing)
		End If

	End Sub
End Class