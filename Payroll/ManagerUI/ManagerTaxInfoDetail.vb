Public Class ManagerTaxInfoDetail

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()
    End Sub

    Private Sub btn_PrintSummary_Click(sender As Object, e As EventArgs) Handles btn_PrintSummary.Click
        MsgBox("Printing Tax Summary...")
    End Sub

End Class