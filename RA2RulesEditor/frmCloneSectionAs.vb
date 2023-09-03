Public Class frmCloneSectionAs
	Private Sub tbxName_TextChanged(sender As Object, e As EventArgs) Handles tbxName.TextChanged
		If Not tbxName.Text.Trim = "" Then
			btnClone.Enabled = True
		Else
			btnClone.Enabled = False
		End If
	End Sub

	Private Sub tbxName_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxName.KeyDown

		If e.KeyCode = Keys.Enter Then
			e.SuppressKeyPress = True
			e.Handled = True
			If Not tbxName.Text.Trim = "" Then
				DialogResult = DialogResult.OK
			End If
		End If

	End Sub

	Private Sub frmCloneSectionAs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		tbxName.Focus()

	End Sub
End Class