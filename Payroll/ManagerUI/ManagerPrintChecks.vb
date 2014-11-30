Public Class ManagerPrintChecks

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

    Sub initTable()
        Dim rowHeaders = New String() {"Last Name", "First Name", "Hours Worked", "Overtime", "Gross Pay", "Net Pay"}

        tableView.ColumnCount = rowHeaders.Count

        Dim ctrl As Button
        For i As Integer = 0 To rowHeaders.Count - 1
            ctrl = New Button
            ctrl.Dock = DockStyle.Fill
            ctrl.FlatStyle = FlatStyle.Flat
            ctrl.BackColor = Color.LightGray
            ctrl.Text = rowHeaders(i)
            tableView.Controls.Add(ctrl, i, 0)
        Next

        Dim columnHeaders = New String() {"Lucy", "William", "Sam", "Ryan", "John", "Scott", "Sara", "Andrew"}

        tableView.RowCount = columnHeaders.Count

        For i As Integer = 1 To columnHeaders.Count - 1
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
                ' AddHandler ctrl.Click, AddressOf addEmployeeToTimeSlot
                ctrl.FlatStyle = FlatStyle.Flat
                tableView.Controls.Add(ctrl, columnNo, rowNo)
            Next
        Next
    End Sub

    Private Sub btn_PrintChecks_Click(sender As Object, e As EventArgs) Handles btn_PrintChecks.Click
        MsgBox("Printing Checks...")
    End Sub

End Class