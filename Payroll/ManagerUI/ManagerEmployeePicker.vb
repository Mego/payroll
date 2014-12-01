Public Class ManagerEmployeePicker
    Public selectedEmployees As ArrayList
    Public employeesToSelectFrom As ArrayList

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
        Else
            selectedEmployees = New ArrayList
            For i As Integer = 0 To employeeSelect.CheckedItems.Count - 1
                'MsgBox(checkBox.CheckedItems.Item(i).ToString)
                selectedEmployees.Add(employeeSelect.CheckedItems.Item(i).ToString)
            Next
        End If
        Me.Close()
    End Sub

    Private Sub ManagerEmployeePicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim firstNames As New ArrayList
        'Dim splitString As String()

        'For i As Integer = 0 To employeesToSelectFrom.Count - 1
        'splitString = Split(CStr(employeesToSelectFrom(i)), " ")
        'firstNames.Add(splitString(0))
        ' MsgBox(firstNames(i))
        ' Next

        For i As Integer = 0 To employeesToSelectFrom.Count - 1
            employeeSelect.Items.Add(employeesToSelectFrom(i))
            ' MsgBox(firstNames(i))
        Next

    End Sub

End Class
