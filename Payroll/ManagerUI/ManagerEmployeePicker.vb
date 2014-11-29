Public Class ManagerEmployeePicker
    Public selectedEmployees As ArrayList

    Private Sub employeeSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles employeeSelect.SelectedIndexChanged
        Dim checkBox As CheckedListBox = CType(sender, CheckedListBox)
        selectedEmployees = New ArrayList
        For i As Integer = 0 To checkBox.CheckedItems.Count - 1
            'MsgBox(checkBox.CheckedItems.Item(i).ToString)
            selectedEmployees.Add(checkBox.CheckedItems.Item(i).ToString)
        Next
    End Sub

    Private Sub btn_Finished_Click(sender As Object, e As EventArgs) Handles btn_Finished.Click
        If selectedEmployees.Count = 0 Then
            selectedEmployees = New ArrayList
        End If
        Me.Close()
    End Sub

End Class