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
		lvwElements.Items.Clear()

		lblMessage.Text = "Loading..." : Me.Refresh()

		For Each Section In GetSections(INIPath, Filter)
			lvi = lvwSection.Items.Add(Section.Name.ReplaceMore("[]", ""))
			lvi.SubItems.Add(Section.LineNo)

			lviC = lvwUnsort.Items.Add(Section.Name.ReplaceMore("[]", ""))
			lviC.SubItems.Add(Section.LineNo)
		Next

		pnlInit.Visible = False : Me.Refresh()

		Return lvwSection.Items.Count

	End Function

	Private Sub LoadElement(Section As String)
		Dim lvi As ListViewItem
		Dim src As List(Of ElementData) = GetElements(INIPath, Section)
		If Not src Is Nothing Then
			lblCurrentSection.Text = Section
			lvwElements.Items.Clear()
			For Each LD As ElementData In src
				lvi = lvwElements.Items.Add(LD.Name)
				lvi.SubItems.Add(LD.Value)
				lvi.SubItems.Add(LD.Comment)
				lvi.SubItems.Add(LD.LineNo)
			Next
		Else
			lblCurrentSection.Text = "Section Not Match!"
			lvwElements.Enabled = False
		End If
	End Sub

	Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

		Using dlgOpenFile As New OpenFileDialog
			dlgOpenFile.Filter = "Ini files|*.ini"

			If dlgOpenFile.ShowDialog = DialogResult.OK Then

				lblPath.Text = dlgOpenFile.FileName

				tbxFilter.Text = ""
				INIPath = dlgOpenFile.FileName
				pnlInit.Visible = True : Me.Refresh()
				InitRulesFile(INIPath)
				Dim SectionCount = LoadContent(INIPath)

			End If
		End Using

	End Sub

	Private Sub lvwSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwSection.SelectedIndexChanged

		If lvwSection.SelectedItems.Count = 1 Then

			lblCurrentSectionIndex.Text = lvwSection.SelectedIndices(0)

			Dim Section As String = lvwSection.SelectedItems(0).Text
			Dim LineNo As Integer = lvwSection.SelectedItems(0).SubItems(1).Text
			Dim src As List(Of ElementData) = GetElements(INIPath, Section, LineNo)

			Dim lvi As ListViewItem

			lblCurrentSection.Text = Section
			lvwElements.Items.Clear()

			tsmi_CloneSectionAs.Enabled = True
			tsmi_AppendElement.Enabled = False
			tsmi_RemoveElement.Enabled = False

			If Not src Is Nothing Then
				For Each LD As ElementData In src
					lvi = lvwElements.Items.Add(LD.Name)
					lvi.SubItems.Add(LD.Value)
					lvi.SubItems.Add(LD.Comment)
					lvi.SubItems.Add(LD.LineNo)
				Next
			End If

		Else
			tsmi_CloneSectionAs.Enabled = False
		End If

	End Sub

	Private Sub lvwMember_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvwElements.MouseDoubleClick

		If lvwElements.SelectedItems.Count = 1 And e.Button = MouseButtons.Left Then
			Dim lvi As ListViewItem = lvwElements.SelectedItems(0)
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

	Private Sub lvwMember_KeyDown(sender As Object, e As KeyEventArgs) Handles lvwElements.KeyDown

		If lvwElements.SelectedItems.Count = 1 Then

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

	Private Sub lvwMember_MouseDown(sender As Object, e As MouseEventArgs) Handles lvwElements.MouseDown

		If Not e.Button = Button.MouseButtons.Middle Then Return

		If lvwElements.SelectedItems.Count = 1 Then
			Dim lvi As ListViewItem = lvwElements.SelectedItems(0)
			Dim Section As String = lvi.SubItems(1).Text.Trim
			Dim sm = New frmElementViewers
			sm.lblCurrentSection.Text = Section
			sm.LoadElement(Section)
			sm.ShowDialog()
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

	Private Sub tsmi_AppendElement_Click(sender As Object, e As EventArgs) Handles tsmi_AppendElement.Click

		If lvwElements.SelectedItems.Count = 1 Then
			If frmInsertContent.ShowDialog() = DialogResult.OK Then
				Dim refIndex As Integer = lvwElements.SelectedItems(0).Index
				Dim refLineNo As Integer = lvwElements.SelectedItems(0).SubItems(3).Text
				Dim Contents As New List(Of String)
				Dim Content As String = frmInsertContent.contentName + "=" + frmInsertContent.contentValue
				If frmInsertContent.contentComment <> "" Then Content += "; " + frmInsertContent.contentComment
				Contents.Add(Content)

				If UpdateLinesData(refLineNo, Contents, True) Then lvwSection_SelectedIndexChanged(Nothing, Nothing)
			End If
		End If

	End Sub

	Private Sub tsmi_RemoveElement_Click(sender As Object, e As EventArgs) Handles tsmi_RemoveElement.Click

		If lvwElements.SelectedItems.Count > 0 Then
			If MsgBox("Are you sure to PERMANENTLY delete selected element(s)?", MsgBoxStyle.OkCancel + MessageBoxIcon.Warning, "Remove Element(s)") = MsgBoxResult.Ok Then
				Dim LineNumbers As New List(Of Integer)
				For Each lvi As ListViewItem In lvwElements.SelectedItems
					LineNumbers.Add(lvi.SubItems(3).Text)
				Next
				If RemoveContent(LineNumbers) Then lvwSection_SelectedIndexChanged(Nothing, Nothing)
			End If
		End If

	End Sub

	Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click

		ReloadINI(sender, e)

	End Sub

	Private Sub lvwElements_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwElements.SelectedIndexChanged

		If lvwElements.SelectedItems.Count = 1 Then
			tsmi_AppendElement.Enabled = True
			tsmi_CommentElement.Enabled = True
			tsmi_RemoveElement.Enabled = True
		ElseIf lvwElements.SelectedItems.Count > 1 Then
			tsmi_AppendElement.Enabled = False
			tsmi_CommentElement.Enabled = True
			tsmi_RemoveElement.Enabled = True
		Else
			tsmi_AppendElement.Enabled = False
			tsmi_CommentElement.Enabled = False
			tsmi_RemoveElement.Enabled = False
		End If

	End Sub

	Private Sub btnOpenInEditor_Click(sender As Object, e As EventArgs) Handles btnOpenInEditor.Click

		Dim path = lblPath.Text
		If Not path = "---" Then
			Dim proc = New Process
			proc.StartInfo.FileName = path
			proc.EnableRaisingEvents = True
			'AddHandler proc.Exited, AddressOf ReloadINI
			proc.Start()
		End If

	End Sub

	Private Sub ReloadINI(sender As Object, e As EventArgs)
		Dim path = lblPath.Text.Trim
		If Not path = "---" Then
			If File.Exists(path) Then
				tbxFilter.Text = ""
				INIPath = path
				pnlInit.Visible = True
				Me.Refresh()
				InitRulesFile(INIPath)
				LoadContent(INIPath)
			End If
		End If
	End Sub

	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Control.CheckForIllegalCrossThreadCalls = False

		lblAppVersion.Text = "Version " & Application.ProductVersion

	End Sub

	Private Sub lblCurrentSectionIndex_Click(sender As Object, e As EventArgs) Handles lblCurrentSectionIndex.Click
		Dim prevSectionIndex As Integer = lblCurrentSectionIndex.Text
		If lblCurrentSectionIndex.Text >= 0 Then
			If Not lvwSection.Items Is Nothing Then
				lvwSection.Items(prevSectionIndex).Selected = True
			End If
		End If
	End Sub

	Private Sub lvwSection_MouseDown(sender As Object, e As MouseEventArgs) Handles lvwSection.MouseDown
		If Not e.Button = Button.MouseButtons.Middle Then Return

		If lvwSection.SelectedItems.Count = 1 Then
			Dim lvi As ListViewItem = lvwSection.SelectedItems(0)
			Dim Section As String = lvi.Text.Trim
			Dim ev = New frmElementViewers
			ev.lblCurrentSection.Text = Section
			ev.LoadElement(Section)
			ev.Show()
		End If
	End Sub

	Private Sub tsmi_CloneSectionAs_Click(sender As Object, e As EventArgs) Handles tsmi_CloneSectionAs.Click

		Dim SectionName As String = lvwSection.SelectedItems(0).Text.Trim
		frmCloneSectionAs.tbxName.Text = SectionName
		If frmCloneSectionAs.ShowDialog = DialogResult.OK Then
			Dim CloneSectionName As String = frmCloneSectionAs.tbxName.Text.Trim
			CloneSectionAs(SectionName, CloneSectionName)

			btnReload_Click(Nothing, Nothing)
		End If

	End Sub

	Private Sub tsmi_CommentElement_Click(sender As Object, e As EventArgs) Handles tsmi_CommentElement.Click

		If lvwElements.SelectedItems.Count > 0 Then
			Dim msg As String = "Are you sure to comment out selected elements?" & vbCrLf & "All selected elements will not be appear in an application but still on original file as a comment and not be process."
			If MsgBox(msg, MsgBoxStyle.OkCancel + MessageBoxIcon.Warning, "Comment Elements") = MsgBoxResult.Ok Then
				Dim elementName, elementValue, elementComment As String
				Dim refLineNo As Integer
				Dim GD As GroupData
				Dim GroupDatas As New List(Of GroupData)
				Dim Content As String

				For Each lvi As ListViewItem In lvwElements.SelectedItems
					elementName = lvi.Text
					elementValue = lvi.SubItems(1).Text
					elementComment = lvi.SubItems(2).Text
					refLineNo = lvi.SubItems(3).Text
					Content = "; " & elementName & " = " & elementValue
					If Not elementComment = "" Then Content += "; " & elementComment
					GD.LineNo = refLineNo
					GD.Content = Content
					GroupDatas.Add(GD)
				Next
				If UpdateGroupData(GroupDatas) Then lvwSection_SelectedIndexChanged(Nothing, Nothing)
			End If
		End If

	End Sub

	Private Sub lvwElements_ItemDrag(sender As Object, e As ItemDragEventArgs) Handles lvwElements.ItemDrag

		If lvwElements.SelectedItems.Count > 0 Then
			Dim countElements As Integer = lvwElements.SelectedItems.Count
			ReDim DragDropLVIs(countElements - 1)
			For i = 0 To countElements - 1
				DragDropLVIs(i) = lvwElements.SelectedItems(i).Clone
			Next
			sender.DoDragDrop(New DataObject("System.Windows.Forms.ListViewItem()", DragDropLVIs), DragDropEffects.Copy)
    End If

	End Sub

	Private Sub lvwElements_DragEnter(sender As Object, e As DragEventArgs) Handles lvwElements.DragEnter

		If e.Data.GetDataPresent("System.Windows.Forms.ListViewItem()") Then
			e.Effect = DragDropEffects.Copy
		Else
			e.Effect = DragDropEffects.None
		End If

	End Sub

	Private Sub lvwElements_DragOver(sender As Object, e As DragEventArgs) Handles lvwElements.DragOver

		Dim pt As New Point(e.X, e.Y)
		Dim dropPoint As Point = lvwElements.PointToClient(pt)
		Dim dropNearItem = lvwElements.GetItemAt(dropPoint.X, dropPoint.Y)

		If Not dropNearItem Is Nothing Then
			lblNearDropIndex.Text = dropNearItem.Index

			' Drag target effect
			If (Not LastDragOverItem Is Nothing) And (Not LastDragOverItem Is dropNearItem) Then
				LastDragOverItem.ForeColor = Color.Black
				LastDragOverItem.BackColor = Color.White
			End If

			LastDragOverItem = dropNearItem
			LastDragOverItem.ForeColor = Color.White
			dropNearItem.BackColor = Color.SteelBlue
		Else
				lblNearDropIndex.Text = "-1"
		End If

	End Sub

	Private Sub lvwElements_DragDrop(sender As Object, e As DragEventArgs) Handles lvwElements.DragDrop

		Dim nearDropIndex As Integer = lblNearDropIndex.Text
		Dim refLineNo As Integer
		Dim elementName, elementValue, elementComment, lineContent As String
		Dim Contents As New List(Of String)

		If nearDropIndex > 0 Then
			refLineNo = lvwElements.Items(nearDropIndex).SubItems(3).Text
		Else
			refLineNo = lvwElements.Items(lvwElements.Items.Count - 1).SubItems(3).Text
		End If
		For Each LVI As ListViewItem In DragDropLVIs
			elementName = LVI.Text
			elementValue = LVI.SubItems(1).Text
			elementComment = LVI.SubItems(2).Text
			lineContent = elementName & " = " & elementValue
			If Not elementComment.Trim() = "" Then lineContent &= " ; " & elementComment
			Contents.Add(lineContent)
		Next

		If UpdateLinesData(refLineNo, Contents, True) Then LoadElement(lblCurrentSection.Text)

	End Sub

	Private Sub btnMapTools_Click(sender As Object, e As EventArgs) Handles btnMapTools.Click
		Me.Hide()
		frmMapTools.Show()
	End Sub
End Class
