Public Class EmployeeKeypadEntry

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        'Right now it defaults to loading clock in success
        ' Logic could be added here to check if the employee has a missed punch

        If Me.ClockOut = False Then
            Dim clockInSuccess As EmployeeClockInSuccess
            clockInSuccess = New EmployeeClockInSuccess
            showForm(CType(clockInSuccess, Form))
        Else
            MsgBox("Clocked Out")
            ' Now load the main menu for clockin in
            Dim mainMenu As EmployeeClockInMainMenu
            mainMenu = New EmployeeClockInMainMenu
            showForm(CType(mainMenu, Form))
        End If

        'Load miss punch like this:
        ' Dim missedPunch As EmployeeMissedPunch
        ' missedPunch = New EmployeeMissedPunch
        ' showForm(CType(missedPunch, Form))
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