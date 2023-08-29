Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmMain

#Region "Moveable Form Code"
	'Imports System.Runtime.InteropServices
	<DllImportAttribute("user32.dll")>
	Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
	End Function

	<DllImportAttribute("user32.dll")>
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

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

		Application.Exit()

	End Sub

#End Region

	Private Function LoadContent(INIPath As String, Optional Filter As String = "") As Integer

		Dim lvi, lviC As ListViewItem
		lvwSection.Items.Clear()
		lvwUnsort.Items.Clear()
		lvwMember.Items.Clear()

		lblMessage.Text = "Loading..." : Me.Refresh()

		For Each Line In GetSection(INIPath, Filter)
			lvi = lvwSection.Items.Add(Line.ReplaceMore("[]", ""))
			lviC = lvwUnsort.Items.Add(Line.ReplaceMore("[]", ""))
		Next

		pnlInit.Visible = False : Me.Refresh()

		Return 0

	End Function

	Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

		Dim dlgOpenFile As New OpenFileDialog
		dlgOpenFile.Filter = "Ini files|*.ini"

		If dlgOpenFile.ShowDialog = DialogResult.OK Then

			lblPath.Text = dlgOpenFile.FileName

			tbxFilter.Text = ""
			INIPath = dlgOpenFile.FileName
			pnlInit.Visible = True : Me.Refresh()
			InitRulesFile(INIPath)
			LoadContent(INIPath)

		End If

	End Sub

	Private Sub lvwSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwSection.SelectedIndexChanged

		If lvwSection.SelectedItems.Count = 1 Then

			Dim Section As String = lvwSection.SelectedItems(0).Text
			Dim src As LineData() = GetMember(INIPath, "[" & Section & "]")

			Dim lvi As ListViewItem

			lblCurSection.Text = Section
			lvwMember.Items.Clear()

			tsmi_AppendElement.Enabled = False
			tsmi_RemoveElement.Enabled = False

			If Not src Is Nothing Then
				For Each LD As LineData In src
					lvi = lvwMember.Items.Add(LD.Name)
					lvi.SubItems.Add(LD.Value)
					lvi.SubItems.Add(LD.Comment)
					lvi.SubItems.Add(LD.LineNo)
				Next
			End If
		End If

	End Sub

	Private Sub lvwMember_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvwMember.MouseDoubleClick

		If lvwMember.SelectedItems.Count = 1 And e.Button = MouseButtons.Left Then
			Dim lvi As ListViewItem = lvwMember.SelectedItems(0)
			curLVI = lvi
			Dim F As New Font("Bahnschrift SemiCondensed", 9.75)
			With frmEditValue
				.lblMemberName.Text = lvi.Text.Trim
				.tbxValue.Text = lvi.SubItems(1).Text.Trim
				.tbxComment.Text = lvi.SubItems(2).Text.Trim
				OldValue = .tbxValue.Text
				.lblRefIndex.Text = lvi.Index
				.lblRefLineNo.Text = lvi.SubItems(3).Text

				.tbxValue.Left = .lblMemberName.Left + .lblMemberName.Width + 10
				.tbxValue.Width = .btnCancel.Left + .btnCancel.Width - .tbxValue.Left

				Dim textSize As Size = TextRenderer.MeasureText(lvi.SubItems(1).Text.Trim, F)
				.Width = .lblMemberName.Left + .lblMemberName.Width + textSize.Width + 30
				If .Width < 230 Then .Width = 230
				.ShowDialog()
			End With
		End If

	End Sub

	Private Sub lvwMember_KeyDown(sender As Object, e As KeyEventArgs) Handles lvwMember.KeyDown

		If lvwMember.SelectedItems.Count = 1 Then

			If e.KeyData = Keys.Enter Then
				lvwMember_MouseDoubleClick(Nothing, Nothing)
			End If

		End If

	End Sub

	Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click

		If File.Exists(INIPath) Then

			LoadContent(INIPath, tbxFilter.Text.Trim)

		End If

	End Sub

	Private Sub lvwMember_MouseUp(sender As Object, e As MouseEventArgs) Handles lvwMember.MouseUp

		If e.Button <> Button.MouseButtons.Middle Then Return

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

	End Sub

	Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click

		If lvwSection.Items.Count > 0 Then
			If btnSort.Text = "Sort" Then
				btnSort.Text = "Unsort"
				lvwSection.Sorting = SortOrder.Ascending

			Else
				btnSort.Text = "Sort"
				lvwSection.Sorting = SortOrder.None

				lvwSection.Items.Clear()
				For Each lvi As ListViewItem In lvwUnsort.Items
					lvwSection.Items.Add(lvi.Clone)
				Next

			End If
		End If

	End Sub

	Private Sub tbxFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles tbxFilter.KeyDown

		If e.KeyCode = Keys.Enter Then
			e.SuppressKeyPress = True
			e.Handled = True
			btnFilter_Click(Nothing, Nothing)
		End If

	End Sub

	Private Sub InsertContentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmi_AppendElement.Click

		If lvwMember.SelectedItems.Count = 1 Then
			If frmInsertContent.ShowDialog() = DialogResult.OK Then
				Dim refIndex As Integer = lvwMember.SelectedItems(0).Index
				Dim refLineNo As Integer = lvwMember.SelectedItems(0).SubItems(3).Text
				Dim Content As String = frmInsertContent.contentName + "=" + frmInsertContent.contentValue
				If frmInsertContent.contentComment <> "" Then Content += "; " + frmInsertContent.contentComment
				If UpdateLineData(refLineNo, Content, True) Then lvwSection_SelectedIndexChanged(Nothing, Nothing)
			End If
		End If

	End Sub

	Private Sub RemoveContentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmi_RemoveElement.Click

		If lvwMember.SelectedItems.Count = 1 Then
			If RemoveContent(lvwMember.SelectedItems(0).SubItems(3).Text) Then lvwSection_SelectedIndexChanged(Nothing, Nothing)
		End If

	End Sub

	Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
		Dim path = lblPath.Text.Trim
		If Not path = "---" Then
			If File.Exists(path) Then
				tbxFilter.Text = ""
				INIPath = path
				pnlInit.Visible = True : Me.Refresh()
				InitRulesFile(INIPath)
				LoadContent(INIPath)
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
End Class
