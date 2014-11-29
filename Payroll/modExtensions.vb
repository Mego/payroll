Imports System.Runtime.CompilerServices

Module modExtensions

    <Extension()>
    Public Function FormatWith(ByVal s As String, ParamArray args() As Object) As String
        Return String.Format(s, args)
    End Function

    <Extension()>
    Public Function Join(Of TValue)(ByVal pCollection As IEnumerable(Of TValue), ByVal pSep As String) As String
        Dim strRes As String = pCollection.First.ToString
        For i As Integer = 1 To pCollection.Count - 1
            strRes &= pSep & pCollection(i).ToString
        Next
        Return strRes
    End Function

End Module
