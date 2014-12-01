Public Class EmployeeCardSwipe

    Private Sub btn_CardSwipe_Click(sender As Object, e As EventArgs) Handles btn_CardSwipe.Click
        Dim cardSwipe As EmployeeCardSwipe
        cardSwipe = New EmployeeCardSwipe
        showForm(CType(cardSwipe, Form))
    End Sub

    Private Sub btn_KeypadEntry_Click(sender As Object, e As EventArgs) Handles btn_KeypadEntry.Click
        Dim keypadEntry As EmployeeKeypadEntry
        keypadEntry = New EmployeeKeypadEntry
        showForm(CType(keypadEntry, Form))
    End Sub

    Sub showForm(ByRef form As Form)
        form.Location = Me.Location
        form.Show()
        Me.Close()
    End Sub


End Class