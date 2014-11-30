Public Class ManagerTaxInfoOverview

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

    Private Sub openTaxDetailForEmployee(sender As Object, e As EventArgs)
        ' Opening Tax detail will be based on the row that is clicked.
        ' Open tax detail for employee row

        Dim clickedCell As Button = CType(sender, Button)

        Dim taxDetail As ManagerTaxInfoDetail
        taxDetail = New ManagerTaxInfoDetail

        With taxDetail
            taxDetail.EmployeeName = "Johnny Appleseed"
            taxDetail.Address = "1234 Wallaby Way"
            taxDetail.SocialSecurityNum = "123456789"
            taxDetail.FederalID = "6789234234"
            taxDetail.FederalIncomeTax = "5000"
            taxDetail.WithheldPay = "4500"
            taxDetail.SocialSecurityTax = "800"
            taxDetail.OverTime = "37"
            taxDetail.HoursWorked = "700"
            taxDetail.Medicare = "500"
            taxDetail.StateIncomeTax = "0"
            taxDetail.GrossPay = "32,000"
        End With

        taxDetail.initLabels()

        taxDetail.Location = Me.Location
        Me.Hide()
        taxDetail.ShowDialog()

        ' Control returned
        Me.Location = taxDetail.Location
        Me.Show()
    End Sub

    Sub initTable()
        Dim rowHeaders = New String() {"Last Name", "First Name", "Hourly Pay", "Hours Worked", "Overtime", "Gross Pay", "Withheld", "YTD Pay"}

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
                AddHandler ctrl.Click, AddressOf openTaxDetailForEmployee
                ctrl.FlatStyle = FlatStyle.Flat
                tableView.Controls.Add(ctrl, columnNo, rowNo)
            Next
        Next
    End Sub


End Class