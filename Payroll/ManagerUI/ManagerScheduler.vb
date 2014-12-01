Imports System.IO

Public Class ManagerScheduler

    Dim employees As ArrayList

    Private Sub btn_MainMenu_Click(sender As Object, e As EventArgs) Handles btn_MainMenu.Click
        Dim mainMenu As ManagerMainMenu
        mainMenu = New ManagerMainMenu
        showForm(CType(mainMenu, Form))
    End Sub

    Sub showForm(ByRef form As Form)
        form.Location = Me.Location
        form.Show()
        Me.Close()
    End Sub

    Private Sub addEmployeeToTimeSlot(sender As Object, e As EventArgs)
        Dim spath As String = Directory.GetCurrentDirectory
        employees = New ArrayList

        Dim fileReader As StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(Path.Combine(spath, "EmployeeData\Data.dat"))
        Dim textLine As String
        While Not fileReader.EndOfStream()
            textLine = fileReader.ReadLine()
            employees.Add(textLine)
        End While

        fileReader.Close()

        Dim names As New ArrayList
        Dim splitString As String()
        For i As Integer = 0 To employees.Count - 1
            splitString = Split(CStr(employees(i)), ",")
            names.Add(splitString(1))
            '(names(i))
        Next

        Dim clickedCell As Button = CType(sender, Button)

        Dim employeePicker As ManagerEmployeePicker
        employeePicker = New ManagerEmployeePicker
        employeePicker.employeesToSelectFrom = names
        employeePicker.ShowDialog()
        Dim selectedEmployees As ArrayList = employeePicker.selectedEmployees

        Dim cellText As String
        cellText = ""
        For i As Integer = 0 To selectedEmployees.Count - 1
            ' MsgBox(selectedEmployees.Item(i))
            Dim split As String() = selectedEmployees.Item(i).ToString.Split
            cellText = cellText & split(0)
            If i < selectedEmployees.Count - 1 Then
                cellText = cellText & ", "
            End If
        Next

        clickedCell.Text = cellText
    End Sub

    Sub initTable()
        Dim rowHeaders = New String() {"TIME", "Mon", "Tue", "Wed", "Thur", "Fri"}
        Dim ctrl As Button
        For i As Integer = 0 To 5
            ctrl = New Button
            ctrl.Dock = DockStyle.Fill
            ctrl.FlatStyle = FlatStyle.Flat
            ctrl.BackColor = Color.LightGray
            ctrl.Text = rowHeaders(i)
            tableView.Controls.Add(ctrl, i, 0)
        Next

        Dim columnHeaders = New String() {"8:00 am", "9:00 am", "10:00 am", "11:00 am", "12:00 pm", "1:00 pm", "2:00 pm", "3:00 pm", "4:00 pm", "5:00 pm"}
        For i As Integer = 1 To 10
            ctrl = New Button
            ctrl.Dock = DockStyle.Fill
            ctrl.FlatStyle = FlatStyle.Flat
            ctrl.BackColor = Color.LightGray
            ctrl.Text = columnHeaders(i - 1)
            tableView.Controls.Add(ctrl, 0, i)
        Next

        For rowNo As Integer = 1 To tableView.RowCount - 1
            For columnNo As Integer = 1 To tableView.ColumnCount - 1
                ctrl = New Button
                ctrl.Dock = DockStyle.Fill
                AddHandler ctrl.Click, AddressOf addEmployeeToTimeSlot
                ctrl.FlatStyle = FlatStyle.Flat
                tableView.Controls.Add(ctrl, columnNo, rowNo)
            Next
        Next
    End Sub

End Class