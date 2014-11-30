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

        Using oEmployee As New Employee
            oEmployee.Insert(dctVals)
        End Using

        MsgBox("Employee Inserted")
    End Sub

End Class
