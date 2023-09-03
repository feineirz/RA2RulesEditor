Public Class frmEditValue

#Region "Moveable Form Code"
	<System.Runtime.InteropServices.DllImportAttribute("user32.dll")>
	Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
	End Function

	<System.Runtime.InteropServices.DllImportAttribute("user32.dll")>
	Public Shared Function ReleaseCapture() As Boolean
	End Function

	Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, pnlHeader.MouseDown
		Const WM_NCLBUTTONDOWN As Integer = &HA1
		Const HT_CAPTION As Integer = &H2

		If e.Button = MouseButtons.Left Then
			ReleaseCapture()
			SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
		End If
	End Sub

#End Region

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

		Me.Dispose()

	End Sub

	Private Sub tbxValue_GotFocus(sender As Object, e As EventArgs) Handles tbxValue.GotFocus

		tbxValue.SelectAll()

	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

		Dim keyField As ListViewItem = curLVI
		Dim valueField As ListViewItem.ListViewSubItem = curLVI.SubItems(1)
		Dim commentField As ListViewItem.ListViewSubItem = curLVI.SubItems(2)

		Dim newKey As String = tbxKeyName.Text.Trim
		Dim prevValue As String = valueField.Text.Trim
		Dim newValue As String = tbxValue.Text.Trim
		Dim newComment As String = tbxComment.Text.Replace(vbCr, "").Replace(vbLf, " ").Trim
		keyField.Text = newKey
		If Not valueField.Text.Trim = newValue Then
			valueField.Text = newValue
			commentField.Text = prevValue
			If Not newComment.Trim = "" Then commentField.Text = commentField.Text.Trim & " ;" & newComment.Trim
		Else
			commentField.Text = tbxComment.Text.Trim.Replace(vbCr, "").Replace(vbLf, "")
		End If

		Dim Content As String = keyField.Text.Trim & "=" & valueField.Text.Trim
		If Not commentField.Text.Trim = "" Then Content = Content.Trim & " ;" & commentField.Text.Trim
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

	Private Sub frmEditValue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Me.Width = 500
		Me.Height = 320
		tbxValue.Focus()

	End Sub

	Private Sub btnUnlockKeyInput_Click(sender As Object, e As EventArgs) Handles btnUnlockKeyInput.Click

		If tbxKeyName.ReadOnly Then
			tbxKeyName.ReadOnly = False
			btnUnlockKeyInput.Text = "Lock"
		Else
			tbxKeyName.ReadOnly = True
			btnUnlockKeyInput.Text = "Unlock"
		End If

	End Sub
End Class