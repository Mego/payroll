Public Class EmployeeCardSwipe

    ' Clockout is true of the clockout button was selected from EmployeeClockInMainMenu

    Private Sub btn_CardSwipe_Click(sender As Object, e As EventArgs) Handles btn_CardSwipe.Click
        ' For now, just load keypad since we don't have a card simulation
        Dim keypadEntry As EmployeeKeypadEntry
        keypadEntry = New EmployeeKeypadEntry
        ' Easy way of tracking clockout I guess Just pass it along
        keypadEntry.ClockOut = Me.ClockOut
        showForm(CType(keypadEntry, Form))
    End Sub

    Private Sub btn_KeypadEntry_Click(sender As Object, e As EventArgs) Handles btn_KeypadEntry.Click
        Dim keypadEntry As EmployeeKeypadEntry
        keypadEntry = New EmployeeKeypadEntry
        ' Easy way of tracking clockout I guess. Just pass it along
        keypadEntry.ClockOut = Me.ClockOut
        showForm(CType(keypadEntry, Form))
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