Imports System.Runtime.CompilerServices

Module modExtensions

    <Extension()>
    Public Function FormatWith(ByVal s As String, ParamArray args() As Object) As String
        Return String.Format(s, args)
    End Function

End Module
