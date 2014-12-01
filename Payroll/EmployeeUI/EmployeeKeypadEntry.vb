Imports System.IO

Public Class EmployeeKeypadEntry

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click

        Dim clockStatus(10, 3) As String
        Dim textLine As String
        Dim currString(3) As String
        Dim spath As String = Directory.GetCurrentDirectory
        Dim count1 As Integer = 0
        Dim currUserClockOutStatus As Integer
        Dim currUserIndex As Integer
        Dim stringToWrite As String

        ' Reads in the current file contents into an array
        Dim fileReader As StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(Path.Combine(spath, "EmployeeData\Data.dat"))
        While Not fileReader.EndOfStream()
            textLine = fileReader.ReadLine()
            currString = textLine.Split(CChar(","))

            For i = 0 To 2
                clockStatus(count1, i) = currString(i)
                'MsgBox(CStr(clockStatus(count1, i)))
            Next i
            count1 = count1 + 1
        End While

        fileReader.Close()

        ' performs operations based on clockin or clockout

        ' clockout
        If Me.ClockOut = False Then
            Dim UserID As String = TextBox1.Text
            For i = 0 To 9
                If (StrComp(clockStatus(i, 0), UserID) = 0) Then
                    currUserIndex = CInt(i)
                End If
            Next i
            If (StrComp(clockStatus(currUserIndex, 2), CStr(0), CompareMethod.Text) = 0) Then
                clockStatus(currUserIndex, 2) = CStr(1)

                Dim fs As New System.IO.StreamWriter(Path.Combine(spath, "EmployeeData\Data.dat"), False)
                For i = 0 To 9
                    If Not StrComp(clockStatus(i, 0), "") = 0 Then
                        stringToWrite = String.Concat(clockStatus(i, 0), ",", clockStatus(i, 1), ",", clockStatus(i, 2))
                        fs.WriteLine(stringToWrite)
                    End If
                Next i
                fs.Close()
                Dim clockInSuccess As EmployeeClockInSuccess
                clockInSuccess = New EmployeeClockInSuccess
                showForm(CType(clockInSuccess, Form))
            Else
                clockStatus(currUserIndex, 2) = CStr(1)

                Dim fs As New System.IO.StreamWriter(Path.Combine(spath, "EmployeeData\Data.dat"), False)
                For i = 0 To 9
                    If Not StrComp(clockStatus(i, 0), "") = 0 Then
                        stringToWrite = String.Concat(clockStatus(i, 0), ",", clockStatus(i, 1), ",", clockStatus(i, 2))
                        fs.WriteLine(stringToWrite)
                    End If
                Next i
                fs.Close()
                ' Load missed punch screen
                Dim missedPunch As EmployeeMissedPunch
                missedPunch = New EmployeeMissedPunch
                showForm(CType(missedPunch, Form))
            End If


            ' clockout
        Else
            Dim UserID As String = TextBox1.Text
            For i = 0 To 9
                If (StrComp(clockStatus(i, 0), UserID) = 0) Then
                    currUserIndex = CInt(i)
                End If
            Next i

            ' Changed this to CStr(0) to reflect clockout
            clockStatus(currUserIndex, 2) = CStr(0)

            ' *** CHANGED THIS FROM TRUE, Fixed duplicating entries
            Dim fs As New System.IO.StreamWriter(Path.Combine(spath, "EmployeeData\Data.dat"), False)
            For i = 0 To 9
                If Not StrComp(clockStatus(i, 0), "") = 0 Then
                    stringToWrite = String.Concat(clockStatus(i, 0), ",", clockStatus(i, 1), ",", clockStatus(i, 2))
                    fs.WriteLine(stringToWrite)
                End If
            Next i
            fs.Close()

            MsgBox("Clocked Out")
            ' Now load the main menu for clockin in
            Dim mainMenu As EmployeeClockInMainMenu
            mainMenu = New EmployeeClockInMainMenu
            showForm(CType(mainMenu, Form))
        End If

    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Dim mainMenu As EmployeeClockInMainMenu
        mainMenu = New EmployeeClockInMainMenu
        showForm(CType(mainMenu, Form))
    End Sub

    Sub showForm(ByRef form As Form)
        form.Location = Me.Location
        form.Show()
        Me.Close()
    End Sub

    Private cOut As Boolean
    Public Property ClockOut() As Boolean
        Get
            Return cOut
        End Get
        Set(ByVal value As Boolean)
            cOut = value
        End Set
    End Property

End Class