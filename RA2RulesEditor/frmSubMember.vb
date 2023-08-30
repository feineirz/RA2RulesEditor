Public Class frmSubMember
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

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

		Me.Dispose()

	End Sub

	Private Sub lvwMember_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvwMember.MouseDoubleClick

		If lvwMember.SelectedItems.Count = 1 Then
			Dim lvi As ListViewItem = lvwMember.SelectedItems(0)
			curLVI = lvi
			With frmEditValue
				.tbxKeyName.Text = lvi.Text.Trim
				.tbxValue.Text = lvi.SubItems(1).Text.Trim
				.tbxComment.Text = lvi.SubItems(2).Text.Trim
				OldValue = .tbxValue.Text
				.lblRefIndex.Text = lvi.Index
				.lblRefLineNo.Text = lvi.SubItems(3).Text
				.ShowDialog()
			End With
		End If

	End Sub

	Private Sub lvwMember_MouseUp(sender As Object, e As MouseEventArgs) Handles lvwMember.MouseUp

		If e.Button = Button.MouseButtons.Middle Then
			If lvwMember.SelectedItems.Count = 1 Then
				Dim lvi As ListViewItem = lvwMember.SelectedItems(0)
				Dim Section As String = "[" & lvi.SubItems(1).Text.Trim & "]"
				Dim src As LineData() = GetMember(INIPath, Section)
				If Not src Is Nothing Then
					Dim sm As New frmSubMember
					With sm
						sm.lblTitle.Text = Section
						.lvwMember.Items.Clear()

						For Each LD As LineData In src
							lvi = .lvwMember.Items.Add(LD.Name)
							lvi.SubItems.Add(LD.Value)
							lvi.SubItems.Add(LD.Comment)
							lvi.SubItems.Add(LD.LineNo)
						Next
						.ShowDialog()
					End With

				End If
			End If
		End If

	End Sub

	Private Sub lvwMember_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwMember.SelectedIndexChanged

		If lvwMember.SelectedItems.Count = 1 Then
			tsmi_AppendElement.Enabled = True
			tsmi_RemoveElement.Enabled = True
		Else
			tsmi_AppendElement.Enabled = False
			tsmi_RemoveElement.Enabled = False
		End If

	End Sub

	Private Sub tsmi_AppendElement_Click(sender As Object, e As EventArgs) Handles tsmi_AppendElement.Click

		If lvwMember.SelectedItems.Count = 1 Then
			If frmInsertContent.ShowDialog() = DialogResult.OK Then
				Dim refIndex As Integer = lvwMember.SelectedItems(0).Index
				Dim refLineNo As Integer = lvwMember.SelectedItems(0).SubItems(3).Text
				Dim Content As String = frmInsertContent.contentName + "=" + frmInsertContent.contentValue
				If frmInsertContent.contentComment <> "" Then Content += "; " + frmInsertContent.contentComment
				If UpdateLineData(refLineNo, Content, True) Then Me.Dispose()
			End If
		End If

	End Sub

	Private Sub tsmi_RemoveElement_Click(sender As Object, e As EventArgs) Handles tsmi_RemoveElement.Click

		If lvwMember.SelectedItems.Count = 1 Then
			If RemoveContent(lvwMember.SelectedItems(0).SubItems(3).Text) Then Me.Dispose()
		End If

	End Sub
End Class