Imports System.Runtime.InteropServices
Imports System.IO

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
			lvi = lvwSection.Items.Add(Line)
			lviC = lvwUnsort.Items.Add(Line)
		Next

		pnlInit.Visible = False : Me.Refresh()

	End Function

	Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

		Dim dlgOpenFile As New OpenFileDialog
		dlgOpenFile.Filter = "RA2 Rules File|rules.ini;rulesmd.ini"

		If dlgOpenFile.ShowDialog = DialogResult.OK Then

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
			Dim src As LineData() = GetMember(INIPath, Section)

			Dim lvi As ListViewItem

			lblCurSection.Text = Section
			lvwMember.Items.Clear()

			If Not src Is Nothing Then
				For Each LD As LineData In src
					lvi = lvwMember.Items.Add(LD.Name)
					lvi.SubItems.Add(LD.Value)
					lvi.SubItems.Add(LD.LineNo)
					lvi.SubItems.Add(LD.Comment)
				Next
			End If
		End If

	End Sub

	Private Sub lvwMember_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvwMember.MouseDoubleClick

		If lvwMember.SelectedItems.Count = 1 Then
			Dim lvi As ListViewItem = lvwMember.SelectedItems(0)
			curLVI = lvi
			Dim F As New Font("Microsoft Sans Serif", 9.75)
			With frmEditValue
				.lblMemberName.Text = lvi.Text.Trim
				.tbxValue.Text = lvi.SubItems(1).Text.Trim
				.tbxComment.Text = lvi.SubItems(3).Text.Trim
				OldValue = .tbxValue.Text
				.lblRefIndex.Text = lvi.Index
				.lblRefLineNo.Text = lvi.SubItems(2).Text

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
							lvi.SubItems.Add(LD.LineNo)
							lvi.SubItems.Add(LD.Comment)
						Next
						.ShowDialog()
					End With

				End If
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
End Class
