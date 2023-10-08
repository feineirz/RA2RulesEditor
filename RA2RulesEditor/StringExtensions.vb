Imports System.Runtime.CompilerServices

Module StringExtensions

	<Extension()>
	Public Function ReplaceMore(sourceString As String, filterSet As String, replaceWith As String) As String
		For Each s As String In filterSet.ToCharArray
			sourceString = sourceString.Replace(s, replaceWith)
		Next
		Return sourceString
	End Function


End Module
