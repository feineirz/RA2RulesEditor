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


	Sub InitRulesFile(INIPath As String)

		Dim i As Integer = 0
		Dim s As String() = Nothing

		For Each Line In File.ReadAllLines(INIPath)
			ReDim Preserve s(i)
			s(i) = Line.Replace("//", ";")
			i += 1
		Next

		File.WriteAllLines(INIPath, s)

	End Sub

	Function GetSection(INIPath As String, Optional Filter As String = "") As String()

		Dim ret() As String = Nothing
		If File.Exists(INIPath) Then

			Dim i As Integer = 0

			For Each Line In File.ReadAllLines(INIPath)
				If Not Line.Trim = "" Then 'Ignore blank line
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

	Function UpdateLineData(LineNo As Integer, Content As String) As Boolean

		If File.Exists(INIPath) Then
			Dim S As String() = File.ReadAllLines(INIPath)
			If S.Length >= LineNo Then
				S(LineNo - 1) = Content
				File.WriteAllLines(INIPath, S)
				Return True

			Else
				Return False

			End If

		Else
			Return False

		End If

	End Function

End Module
