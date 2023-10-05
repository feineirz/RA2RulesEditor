Imports System.IO

Module mdlCommon

	Public curLVI As ListViewItem
	Public OldValue As String
	Public INIPath As String = ""
	Public lvwUnsort As New ListView

	Structure SectionData
		Dim Name As String
		Dim LineNo As Integer
	End Structure

	Structure LineData
		Dim Name As String
		Dim Value As String
		Dim LineNo As Integer
		Dim Comment As String
	End Structure

	Public DragDropLVIs As ListViewItem()
	Public LastDragOverItem As ListViewItem

	Sub InitRulesFile(INIPath As String)

		Dim INIContent As New List(Of String)
		Dim splLine As String()
		Dim foundBlankLine As Boolean = False

		For Each Line In File.ReadAllLines(INIPath)
			Line = Line.Trim

			' Filter out double blank line
			If Line = "" Then
				If foundBlankLine Then
					Continue For
				Else
					foundBlankLine = True
				End If
			Else
				foundBlankLine = False
			End If

			splLine = Split(Line, "=", 2)
			If splLine.Length = 2 Then Line = splLine(0).Trim & " = " & splLine(1).Trim
			If Not Line = "{remove this line}" Then
				Line = Line.Replace("//", ";")
				INIContent.Add(Line)
			End If
		Next

		File.WriteAllLines(INIPath, INIContent)

	End Sub

	Function GetSection(INIPath As String, Optional Filter As String = "") As List(Of SectionData)

		Dim Sections As New List(Of SectionData)
		Dim SectionData As SectionData

		Dim LineNumber As Integer = 0

		If File.Exists(INIPath) Then
			For Each Line In File.ReadAllLines(INIPath)
				LineNumber += 1
				Line = Line.Trim()
				If Not Line = "" Then 'Ignore blank line
					If Line.StartsWith("[") Then
						If Filter = "" Then
							Dim spl() As String = Split(Line, ";", 2)
							If Not spl(0).Trim = "" Then
								SectionData.Name = spl(0).Trim
								SectionData.LineNo = LineNumber
								Sections.Add(SectionData)
							End If
						Else
							Dim spl() As String = Split(Line, ";", 2)
							If spl(0).ToLower Like "*" & Filter.ToLower & "*" Then
								If spl(0).Trim <> "" Then
									SectionData.Name = spl(0)
									SectionData.LineNo = LineNumber
									Sections.Add(SectionData)
								End If
							End If
						End If
					End If
				End If
			Next
		End If

		Return Sections

	End Function

	Function CloneSectionAs(SectionName As String, CloneSectionName As String) As Boolean

		' Prepare parameters
		SectionName = SectionName.Trim
		If Not SectionName.StartsWith("[") Then SectionName = "[" & SectionName
		If Not SectionName.EndsWith("]") Then SectionName = SectionName & "]"
		CloneSectionName = CloneSectionName.Trim
		If Not CloneSectionName.StartsWith("[") Then CloneSectionName = "[" & CloneSectionName
		If Not CloneSectionName.EndsWith("]") Then CloneSectionName = CloneSectionName & "]"

		Dim INIContent As New List(Of String)
		Dim CloneContent As New List(Of String)
		Dim State As String = "finding"

		' Clone if INI file is exist
		If Not File.Exists(INIPath) Then Return False

		' Collect INI data
		For Each Line In File.ReadAllLines(INIPath)
				Line = Line.Trim

			' Check if Line is a target section
			If Line.StartsWith("[") Then
				If Line = SectionName Then
					' Found target section
					' Start cloning
					If State = "finding" Then
						State = "cloning"
						CloneContent.Add(CloneSectionName)
					End If

				Else
					' Found next section, pack clone content to ini content
					If State = "cloning" Then
						INIContent.AddRange(CloneContent)
						State = "cloned"
					End If
				End If

			Else
				If State = "cloning" Then
					' Add element to clone content
					CloneContent.Add(Line)
				End If
			End If

				INIContent.Add(Line)
			Next

		If State = "cloning" Then
			' Pack if target section is a last section
			INIContent.Add("")
			INIContent.AddRange(CloneContent)
			State = "cloned"
		End If

		' Write back to INI file
		File.WriteAllLines(INIPath, INIContent)

		Return True

	End Function

	Function GetMember(INIPath As String, Section As String, Optional StartLine As Integer = 1) As List(Of LineData)

		' prepare section format
		Section = Section.Trim
		If Not Section.StartsWith("[") Then Section = "[" & Section
		If Not Section.EndsWith("]") Then Section = Section & "]"

		Dim INIContent As New List(Of String)
		Dim SectionContent As New List(Of LineData)

		Dim Line As String

		Dim LD As LineData = Nothing
		Dim splA(), splB() As String

		If File.Exists(INIPath) Then

			Dim State As String = "finding"
			INIContent.AddRange(File.ReadAllLines(INIPath))

			For i = StartLine - 1 To INIContent.Count - 1
				Line = INIContent(i)
				Line = Line.Trim

				If Line.StartsWith("[") Then
					' Found some section header
					If State = "finding" Then
						If Line.Split(";")(0).Trim = Section Then
							State = "collecting"
						End If
					ElseIf State = "collecting" Then
						State = "finished"
						Exit For
					End If

				Else
					' Collect elements
					If State = "collecting" Then
						' Ignore comments
						If Not Line.StartsWith(";") And Line.Contains("=") Then
							splA = Split(Line, "=", 2)
							LD.Name = splA(0).Trim
							If splA.Length > 1 Then
								If splA(1).Contains(";") Then
									splB = Split(splA(1), ";", 2)
									LD.Value = splB(0).Trim
									LD.Comment = splB(1).Trim
								Else
									LD.Value = splA(1).Trim
									LD.Comment = ""
								End If
							End If

							LD.LineNo = i + 1

							' Pack element
							SectionContent.Add(LD)
						End If
					End If
				End If
			Next
		End If

		Return SectionContent

	End Function

	Public Function UpdateLinesData(LineNo As Integer, Contents As List(Of String), Optional InsertMode As Boolean = False) As Boolean

		If File.Exists(INIPath) Then
			Dim FileContents As String() = File.ReadAllLines(INIPath)
			If FileContents.Length > 0 Then
				If InsertMode Then ' Insert Mode
					If LineNo > 0 And LineNo < FileContents.Length Then
						' Insert after specified line no.
						For Each content In Contents
							InsertArrayElement(Of String)(FileContents, LineNo, content)
							LineNo += 1
						Next
						File.WriteAllLines(INIPath, FileContents)
						Return True

					ElseIf LineNo < 0 Then
						' Insert after last element of current section

					Else
						' Insert at the end of file
						For Each content In Contents
							FileContents.Resize(FileContents, FileContents.Length + 1)
							FileContents(FileContents.Length - 1) = content
						Next
						File.WriteAllLines(INIPath, FileContents)
						Return True
					End If

				Else ' Update Mode
					If Contents.Count = 1 Then
						If LineNo > 0 And LineNo < FileContents.Length Then
							' Update at specified line no
							FileContents(LineNo - 1) = Contents(0)
							File.WriteAllLines(INIPath, FileContents)
							Return True

						Else
							' Insert at the end of file
							FileContents.Resize(FileContents, FileContents.Length + 1)
							FileContents(FileContents.Length - 1) = Contents(0)
							File.WriteAllLines(INIPath, FileContents)
							Return True
						End If
					End If
				End If
			Else
				Return False
			End If
		Else
			Return False
		End If

	End Function

	Public Function RemoveContent(LineNo As Integer) As Boolean

		If File.Exists(INIPath) Then
			Dim Contents As String() = File.ReadAllLines(INIPath)

			Contents(LineNo - 1) = "{remove this line}"
			File.WriteAllLines(INIPath, Contents)
			InitRulesFile(INIPath)
			Return True

		Else
			Return False

		End If

	End Function

	Public Sub InsertArrayElement(Of T)(
		  ByRef sourceArray() As T,
		  ByVal insertIndex As Integer,
		  ByVal newValue As T)

		Dim newPosition As Integer
		Dim counter As Integer

		newPosition = insertIndex
		If (newPosition < 0) Then newPosition = 0
		If (newPosition > sourceArray.Length) Then _
		   newPosition = sourceArray.Length

		Array.Resize(sourceArray, sourceArray.Length + 1)

		For counter = sourceArray.Length - 2 To newPosition Step -1
			sourceArray(counter + 1) = sourceArray(counter)
		Next counter

		sourceArray(newPosition) = newValue
	End Sub

	Public Function StringReplace(Content As String, FilterSet As String, ReplaceString As String) As String
		For Each c As String In FilterSet.ToCharArray()
			Content = Content.Replace(c, ReplaceString)
		Next

		Return Content
	End Function

End Module
