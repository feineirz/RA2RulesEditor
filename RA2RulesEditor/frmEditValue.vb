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

	Private Sub frmEditValue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Me.Width = 500
		Me.Height = 320

	End Sub
End Class