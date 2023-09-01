Public Class frmCloneSectionAs
	Private Sub tbxName_TextChanged(sender As Object, e As EventArgs) Handles tbxName.TextChanged
		If Not tbxName.Text.Trim = "" Then
			btnClone.Enabled = True
		Else
			btnClone.Enabled = False
		End If
	End Sub
End Class