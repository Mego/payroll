Public Class EmployeeMissedPunch

    Private Sub btn_SubmitClockOut_Click(sender As Object, e As EventArgs) Handles btn_SubmitClockOut.Click
        ' Use the text in the forms to perform a clockout
        MsgBox("Clockout successful")
        Dim mainMenu As EmployeeClockInMainMenu
        mainMenu = New EmployeeClockInMainMenu
        showForm(CType(mainMenu, Form))
        Me.Close()
    End Sub

    Sub showForm(ByRef form As Form)
        form.Location = Me.Location
        form.Show()
        Me.Close()
    End Sub

End Class