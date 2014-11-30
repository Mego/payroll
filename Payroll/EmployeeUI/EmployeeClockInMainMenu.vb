Public Class EmployeeClockInMainMenu

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Dim roleSelect As InitialForm
        roleSelect = New InitialForm
        showForm(CType(roleSelect, Form))
    End Sub

    Sub showForm(ByRef form As Form)
        form.Location = Me.Location
        form.Show()
        Me.Close()
    End Sub

End Class