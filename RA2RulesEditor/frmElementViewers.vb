Imports System.Collections.Specialized.BitVector32

Public Class frmElementViewers
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

	Public Sub LoadElement(Section As String)
		Dim lvi As ListViewItem
		Dim src As List(Of LineData) = GetMember(INIPath, Section)
		If Not src Is Nothing Then
			lblTitle.Text = Section
			lvwElements.Items.Clear()
			For Each LD As LineData In src
				lvi = lvwElements.Items.Add(LD.Name)
				lvi.SubItems.Add(LD.Value)
				lvi.SubItems.Add(LD.Comment)
				lvi.SubItems.Add(LD.LineNo)
			Next
		Else
			lblTitle.Text = "Section Not Match!"
			lvwElements.Enabled = False
		End If
	End Sub

	Private Sub lvwMember_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvwElements.MouseDoubleClick

		If lvwElements.SelectedItems.Count = 1 Then
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

	Private Sub lvwMember_MouseDown(sender As Object, e As MouseEventArgs) Handles lvwElements.MouseDown

		If Not e.Button = Button.MouseButtons.Middle Then Return

		If lvwElements.SelectedItems.Count = 1 Then
			Dim lvi As ListViewItem = lvwElements.SelectedItems(0)
			Dim Section As String = lvi.SubItems(1).Text.Trim
			Dim ev = New frmElementViewers
			ev.lblCurrentSection.Text = Section
			ev.LoadElement(Section)
			ev.ShowDialog()
		End If

	End Sub

	Private Sub lvwElements_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwElements.SelectedIndexChanged

		If lvwElements.SelectedItems.Count = 1 Then
			tsmi_AppendElement.Enabled = True
			tsmi_RemoveElement.Enabled = True
		Else
			tsmi_AppendElement.Enabled = False
			tsmi_RemoveElement.Enabled = False
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
				If UpdateLinesData(refLineNo, Contents, True) Then LoadElement(lblCurrentSection.Text)
			End If
		End If

	End Sub

	Private Sub tsmi_RemoveElement_Click(sender As Object, e As EventArgs) Handles tsmi_RemoveElement.Click

		If lvwElements.SelectedItems.Count = 1 Then
			If MsgBox("Are you sure to PERMANENTLY delete this element?", MsgBoxStyle.OkCancel + MessageBoxIcon.Warning, "Element Delete") = MsgBoxResult.Ok Then
				Dim LineNumbers As New List(Of Integer)
				For Each lvi As ListViewItem In lvwElements.SelectedItems
					LineNumbers.Add(lvi.SubItems(3).Text)
				Next
				If RemoveContent(LineNumbers) Then LoadElement(lblCurrentSection.Text)
			End If
		End If

	End Sub

	Private Sub frmElementViewers_Load(sender As Object, e As EventArgs) Handles Me.Load

		Me.BringToFront()

	End Sub

	Private Sub frmElementViewers_Shown(sender As Object, e As EventArgs) Handles Me.Shown

		Me.BringToFront()

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
			If (Not LastDragOverItem Is Nothing) And (Not LastDragOverItem Is dropNearItem) Then
				LastDragOverItem.ForeColor = Color.Black
				LastDragOverItem.BackColor = Color.White
			End If
			LastDragOverItem = dropNearItem
			LastDragOverItem.ForeColor = Color.White
			LastDragOverItem.BackColor = Color.LightSteelBlue
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

End Class