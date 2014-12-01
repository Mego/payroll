Public Class EmployeeCardSwipe

    Private Sub btn_CardSwipe_Click(sender As Object, e As EventArgs) Handles btn_CardSwipe.Click
        Dim cardSwipe As EmployeeCardSwipe
        cardSwipe = New EmployeeCardSwipe
        showForm(CType(cardSwipe, Form))
    End Sub

    Sub showForm(ByRef form As Form)
        form.Location = Me.Location
        form.Show()
        Me.Close()
    End Sub
End Class