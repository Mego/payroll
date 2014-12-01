Imports System.IO

Public Class InsertEmployee

    Private Sub txtSsn_Leave(sender As Object, e As EventArgs) Handles txtSsn.Leave
        txtSsn.Text = txtSsn.Text.PadLeft(9, "0"c)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim dctVals As New Dictionary(Of String, String)
        With dctVals
            .Add("Ssn", "'" & txtSsn.Text & "'")
            .Add("Fname", "'" & txtFname.Text & "'")
            .Add("Mname", "'" & txtMname.Text & "'")
            .Add("Lname", "'" & txtLname.Text & "'")
            .Add("Bdate", "'" & calBdate.SelectionStart.ToString("yyyyMMdd") & "'")
            .Add("PhoneNum", "'" & txtPhoneNum.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "") & "'")
            .Add("Sex", If(radMale.Checked, "'M'", "'F'"))
        End With

        ' CHANGE BACK
        Using oEmployee As New Employee
            oEmployee.Insert(dctVals)
        End Using

        ' inserts employee to file when added
        Dim clockStatus(10, 3) As String
        Dim textLine As String
        Dim spath As String = Directory.GetCurrentDirectory
        Dim count1 As Integer = 0
        Dim newEmployee As String

        ' Reads in the current file contents into an array
        Dim fileReader As StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(Path.Combine(spath, "EmployeeData\Data.dat"))
        While Not fileReader.EndOfStream()
            textLine = fileReader.ReadLine()

            count1 = count1 + 1
        End While

        fileReader.Close()

        count1 = count1 + 1
        Dim fs As New System.IO.StreamWriter(Path.Combine(spath, "EmployeeData\Data.dat"), True)
        newEmployee = String.Concat(CStr(count1), CStr(count1), CStr(count1), CStr(count1), CStr(count1), ",", txtFname.Text, " ", txtLname.Text, ",", CStr(0))
        fs.WriteLine(newEmployee)
        fs.Close()

        MsgBox("Employee Inserted")
    End Sub
End Class
