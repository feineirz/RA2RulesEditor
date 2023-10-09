Imports System.Runtime.CompilerServices

Module StringExtensions
	''' <summary>
	''' Repalce original string with new string.
	''' </summary>
	''' <param name="sourceString">Original string</param>
	''' <param name="filterSet">Set of string to be replaces</param>
	''' <param name="replaceWith">New string to replace</param>
	''' <returns>Modified string</returns>

	<Extension()>
	Public Function ReplaceMore(sourceString As String, filterSet As String, replaceWith As String) As String
		For Each s As String In filterSet.ToCharArray
			sourceString = sourceString.Replace(s, replaceWith)
		Next
		Return sourceString
	End Function


End Module
