Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmMapTools
	Private ElementsContainer As List(Of List(Of ElementData))


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

#End Region

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		frmMain.Show()
		Me.Dispose()
	End Sub

	Private Sub LoadMapList(path As String)
		Dim lvi As ListViewItem

		Dim exts = {".map", ".mpr", ".yrm", ".yrmap"}
		Dim srcDir As New DirectoryInfo(path)
		Dim supportedFiles = From f In srcDir.GetFiles("*.*", SearchOption.AllDirectories)
							 Where exts.Contains(f.Extension)
							 Order By f.Extension, f.Name
							 Select f.FullName

		Dim fi As FileInfo
		Dim mapName As String
		Dim elements As New List(Of ElementData)
		ElementsContainer = New List(Of List(Of ElementData))

		lvwMapList.Items.Clear()

		pnlProgress.Show()
		pnlProgress.Refresh()

		For Each f As String In supportedFiles
			Try
				fi = New FileInfo(f)
				elements = getMapInfo(fi.FullName)
				ElementsContainer.Add(elements)
				mapName = fi.Name.Replace(fi.Extension, "")
				For Each el In elements
					If el.Name = "Name" Then
						mapName = el.Value
						Exit For
					End If
				Next
				lvi = lvwMapList.Items.Add(ReformatFilename(mapName))
				lvi.SubItems.Add(fi.Extension)
				lvi.SubItems.Add(fi.Name)
				lvi.SubItems.Add(fi.FullName)
			Catch ex As Exception
				lvwConversionLog.Items.Add(ex.Message)
				Continue For
			End Try
		Next

		pnlProgress.Hide()
		Dim mapCount As Integer = lvwMapList.Items.Count
		lblStatus.Text = mapCount & " map(s) found."
		If mapCount > 0 Then
			btnConvertMap.Enabled = True
		Else
			btnConvertMap.Enabled = False
		End If

	End Sub

	Public Function ReformatFilename(content As String) As String
		content = Regex.Replace(content, " {2,}", " ")
		content = content.ReplaceMore("�\/:*?<>|=~#!@$%^&", "").Replace(Chr(34), "") ' char(34) = "
		content = CapWord(content)
		Return content
	End Function

	Public Function CapWord(content As String) As String
		Dim words() As String = content.Split(" ")
		Dim buff As String = ""
		For Each w In words
			If Not buff = "" Then buff &= " "
			If w.Length > 1 Then
				buff &= w.Substring(0, 1).ToUpper() & w.Substring(1)
			Else
				buff &= w.ToUpper()
			End If
		Next

		Return buff

	End Function

	Private Function getMapInfo(mapPath As String) As List(Of ElementData)

		Dim elements As List(Of ElementData) = GetElements(mapPath, "Basic")
		Return elements

	End Function

	Private Sub btnBrowseSourcePath_Click(sender As Object, e As EventArgs) Handles btnBrowseSourcePath.Click

		lvwMapInfo.Items.Clear()

		Dim prevPath As String = lblSourcePath.Text
		Dim dlgOpenDir As New FolderBrowserDialog
		If Not prevPath = "---" And Directory.Exists(prevPath) Then
			dlgOpenDir.RootFolder = Environment.SpecialFolder.MyComputer
			dlgOpenDir.SelectedPath = prevPath
		End If
		dlgOpenDir.ShowNewFolderButton = False
		If dlgOpenDir.ShowDialog = DialogResult.OK Then
			lblSourcePath.Text = dlgOpenDir.SelectedPath
			LoadMapList(dlgOpenDir.SelectedPath)
		End If

	End Sub

	Private Sub lvwMapList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwMapList.SelectedIndexChanged

		If lvwMapList.SelectedItems.Count = 1 Then

			Dim elements As List(Of ElementData) = ElementsContainer(lvwMapList.SelectedItems(0).Index)
			Dim lvi As ListViewItem

			lvwMapInfo.Items.Clear()

			For Each element As ElementData In elements
				lvi = lvwMapInfo.Items.Add(element.Name)
				lvi.SubItems.Add(element.Value)
			Next

		End If

	End Sub

	Private Sub frmMapTools_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Dim cmbItems = New List(Of ComboBoxItems)
		cmbItems.Add(New ComboBoxItems(".map to .mpr (Raw format to RA2 format)", "map2mpr"))
		cmbItems.Add(New ComboBoxItems(".map to .ymr (Raw format to Yuri format)", "map2yrm"))
		cmbItems.Add(New ComboBoxItems(".mpr to .yrm (RA2 format to Yuri format)", "mpr2yrm"))
		cmbItems.Add(New ComboBoxItems(".map to .mpr (Raw format to RA2 format) + mpr copy", "map2mpr+"))
		cmbItems.Add(New ComboBoxItems(".map to .ymr (Raw format to Yuri format) + yrm copy", "map2yrm+"))
		cmbItems.Add(New ComboBoxItems(".mpr to .yrm (RA2 format to Yuri format) + yrm copy", "mpr2yrm+"))

		cmbConvertionProfile.ValueMember = "ValueMember"
		cmbConvertionProfile.DisplayMember = "DisplayMember"
		cmbConvertionProfile.DataSource = cmbItems

		cmbConvertionProfile.SelectedItem = cmbConvertionProfile.Items(0)

	End Sub

	Private Sub btnConvertMap_Click(sender As Object, e As EventArgs) Handles btnConvertMap.Click

		If lvwMapList.Items.Count > 0 Then
			Dim prevPath As String = lblSourcePath.Text
			Dim dlgTargetDir As New FolderBrowserDialog
			If Not prevPath = "---" And Directory.Exists(prevPath) Then
				dlgTargetDir.RootFolder = Environment.SpecialFolder.MyComputer
				dlgTargetDir.SelectedPath = prevPath
			End If

			If dlgTargetDir.ShowDialog = DialogResult.OK Then
				Dim conversionProfile As String = cmbConvertionProfile.SelectedValue
				Dim mapType As String
				Dim srcFullpath As String
				Dim targetPath As String = dlgTargetDir.SelectedPath
				Dim targetName As String
				Dim targetExt As String = ".map"

				Select Case conversionProfile
					Case "map2mpr", "map2mpr+" : targetExt = ".mpr"
					Case "map2yrm", "map2yrm+" : targetExt = ".yrm"
					Case "mpr2yrm", "mpr2yrm+" : targetExt = ".yrm"
				End Select

				pnlProgress.Show()
				pnlProgress.Refresh()
				For Each lvi As ListViewItem In lvwMapList.Items
					mapType = lvi.SubItems(1).Text
					srcFullpath = lvi.SubItems(3).Text
					targetName = lvi.Text

					Try
						Select Case conversionProfile
							Case "map2mpr", "map2mpr+"
								If conversionProfile = "map2mpr" And mapType <> ".map" Then Continue For
								If conversionProfile = "map2mpr+" And (mapType <> ".map" And mapType <> ".mpr") Then Continue For
							Case "map2yrm", "map2yrm+"
								If conversionProfile = "map2yrm" And mapType <> ".map" Then Continue For
								If conversionProfile = "map2yrm+" And (mapType <> ".map" And mapType <> ".yrm") Then Continue For
							Case "mpr2yrm", "mpr2yrm+"
								If conversionProfile = "mpr2yrm" And mapType <> ".mpr" Then Continue For
								If conversionProfile = "mpr2yrm+" And (mapType <> ".mpr" And mapType <> ".yrm") Then Continue For
						End Select
						System.IO.File.Copy(srcFullpath, targetPath & "\" & targetName & targetExt, True)

					Catch ex As Exception
						lvwConversionLog.Items.Add(ex.Message)
						Continue For
					End Try
				Next
				pnlProgress.Hide()

			End If
		End If

	End Sub

	Private Sub lvwConversionLog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwConversionLog.SelectedIndexChanged

		If lvwConversionLog.SelectedItems.Count = 1 Then
			lblStatus.Text = lvwConversionLog.SelectedItems(0).Text
		Else
			lblStatus.Text = "Ready"
		End If

	End Sub

	Private Sub btnClearLog_Click(sender As Object, e As EventArgs) Handles btnClearLog.Click

		lvwConversionLog.Items.Clear()

	End Sub
End Class