Imports System.IO

Module mdlCommon

	Public curLVI As ListViewItem
	Public OldValue As String
	Public INIPath As String = ""
	Public lvwUnsort As New ListView

	Structure LineData
		Dim Name As String
		Dim Value As String
		Dim LineNo As Integer
		Dim Comment As String
	End Structure

	Public DragDropLVI As ListViewItem


	Sub InitRulesFile(INIPath As String)

		Dim i As Integer = 0
		Dim s As String() = Nothing
		Dim splLine As String() = Nothing

		For Each Line In File.ReadAllLines(INIPath)
			ReDim Preserve s(i)
			Line = Line.Trim
			splLine = Split(Line, "=", 2)
			If splLine.Length = 2 Then Line = splLine(0).Trim & " = " & splLine(1).Trim
			If Not Line = "{remove this line}" Then
				s(i) = Line.Replace("//", ";")
				i += 1
			End If
		Next

		File.WriteAllLines(INIPath, s)

	End Sub

	Function GetSection(INIPath As String, Optional Filter As String = "") As String()

		Dim ret() As String = Nothing
		If File.Exists(INIPath) Then

			Dim i As Integer = 0

			For Each Line In File.ReadAllLines(INIPath)
				Line = Line.Trim()
				If Not Line = "" Then 'Ignore blank line
					If InStr(Line, "[") = 1 Then
						If Filter = "" Then
							Dim spl() As String = Split(Line, ";", 2)
							If spl(0).Trim <> "" Then
								ReDim Preserve ret(i)
								ret(i) = spl(0)
								i += 1
							End If

						Else
							Dim spl() As String = Split(Line, ";", 2)
							If spl(0).ToLower Like "*" & Filter.ToLower & "*" Then
								If spl(0).Trim <> "" Then
									ReDim Preserve ret(i)
									ret(i) = spl(0)
									i += 1
								End If
							End If

						End If
					End If
				End If
			Next
		End If

		Return ret

	End Function

	Function GetMember(INIPath As String, Section As String) As LineData()

		' prepare section format
		If Not Section.StartsWith("[") Then Section = "[" & Section
		If Not Section.EndsWith("]") Then Section = Section & "]"

		Dim ret As LineData() = Nothing
		Dim splA(), splB() As String

		If File.Exists(INIPath) Then
			Dim i As Integer = 0
			Dim ln As Integer = 0
			Dim flag As Byte = 0

			For Each Line In File.ReadAllLines(INIPath)
				ln += 1

				If Not Line.Trim = "" Then
					If flag = 0 Then
						If InStr(Line, Section) = 1 Then
							flag = 1
						End If

					ElseIf flag = 1 Then
						If InStr(Line, "[") = 1 Then 'End section
							flag = 2
							Exit For

						Else 'Collect data
							If Not InStr(Line.Trim, ";") = 1 Then
								splA = Split(Line, ";", 2)
								splB = Split(splA(0), "=", 2)

								ReDim Preserve ret(i)

								ret(i).Name = splB(0)
								If splB.Length > 1 Then
									ret(i).Value = splB(1)
								Else
									ret(i).Value = ""
								End If

								ret(i).LineNo = ln
								If splA.Length > 1 Then
									ret(i).Comment = splA(1)
								Else
									ret(i).Comment = ""
								End If

								i += 1
							End If
						End If
					End If
				End If
			Next
		End If

		Return ret

	End Function

	Public Function UpdateLineData(LineNo As Integer, Content As String, Optional InsertMode As Boolean = False) As Boolean

		If File.Exists(INIPath) Then
			Dim Contents As String() = File.ReadAllLines(INIPath)
			If Contents.Length > 0 Then
				If Not InsertMode Then
					If Contents.Length >= LineNo Then
						Contents(LineNo - 1) = Content
						File.WriteAllLines(INIPath, Contents)
						Return True

					Else
						Contents.Resize(Contents, Contents.Length + 1)
						Contents(Contents.Length - 1) = Content
						File.WriteAllLines(INIPath, Contents)
						Return True

					End If
				Else
					If Contents.Length >= LineNo Then
						InsertArrayElement(Of String)(Contents, LineNo, Content)
						File.WriteAllLines(INIPath, Contents)
						Return True

					Else
						Contents.Resize(Contents, Contents.Length + 1)
						Contents(Contents.Length - 1) = Content
						File.WriteAllLines(INIPath, Contents)
						Return True
					End If
				End If
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
