Public Class InitialForm

    Private Sub btn_Employee_Click(sender As Object, e As EventArgs) Handles btn_Employee.Click
        Dim employeeLaunch As EmployeeClockInMainMenu
        employeeLaunch = New EmployeeClockInMainMenu
        showForm(CType(employeeLaunch, Form))
    End Sub

    Private Sub btn_Manager_Click(sender As Object, e As EventArgs) Handles btn_Manager.Click
        Dim managerLaunch As ManagerLogIn
        managerLaunch = New ManagerLogIn
        showForm(CType(managerLaunch, Form))
    End Sub

    Sub showForm(ByRef form As Form)
        form.Location = Me.Location
        Me.Hide()
        form.Show()
        Me.Close()
    End Sub

End Class