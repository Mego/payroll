Public Class ManagerScheduler

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

    Private Sub btn_TableTest_Click(sender As Object, e As EventArgs) Handles btn_TableTest.Click

        Dim rowHeaders = New String() {"TIME", "Mon", "Tue", "Wed", "Thur", "Fri"}
        Dim ctrl As Button
        For i As Integer = 0 To 5
            ctrl = New Button
            ctrl.Dock = DockStyle.Fill
            ctrl.Text = rowHeaders(i)
            tableView.Controls.Add(ctrl, i, 0)
        Next

        Dim columnHeaders = New String() {"8:00 am", "9:00 am", "10:00 am", "11:00 am", "12:00 pm", "1:00 pm", "2:00 pm", "3:00 pm", "4:00 pm", "5:00 pm"}
        For i As Integer = 1 To 10
            ctrl = New Button
            ctrl.Dock = DockStyle.Fill
            ctrl.Text = columnHeaders(i - 1)
            tableView.Controls.Add(ctrl, 0, i)
        Next

        ' For rowNo As Integer = 1 To tableView.RowCount - 1
        'For columnNo As Integer = 1 To tableView.ColumnCount - 1
        'ctrl = New Button
        'tableView.Controls.Add(ctrl, columnNo, rowNo)
        'Next
        'Next

    End Sub


End Class