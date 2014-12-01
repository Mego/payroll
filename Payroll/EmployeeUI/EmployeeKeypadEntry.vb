Public Class EmployeeKeypadEntry

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        'Right now it defaults to loading clock in success
        ' Logic could be added here to check if the employee has a missed punch
        Dim clockInSuccess As EmployeeClockInSuccess
        clockInSuccess = New EmployeeClockInSuccess
        showForm(CType(clockInSuccess, Form))

        'Load miss punch like this:
        ' Dim missedPunch As EmployeeMissedPunch
        ' missedPunch = New EmployeeMissedPunch
        ' showForm(CType(missedPunch, Form))
    End Sub

    Sub showForm(ByRef form As Form)
        form.Location = Me.Location
        form.Show()
        Me.Close()
    End Sub

End Class