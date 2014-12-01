Public Class EmployeeClockInSuccess

    Private Sub EmployeeClockInSuccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This time will close the success form and load the employee main menu after 3 seconds
        Dim t As Timer = New Timer()
        t.Interval = 3000
        AddHandler t.Tick, AddressOf HandleTimerTick
        t.Start()
    End Sub

    Private Sub HandleTimerTick(sender As Object, e As System.EventArgs)
        Dim t As Timer = CType(sender, Timer)
        t.Stop()
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