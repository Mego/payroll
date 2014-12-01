﻿Imports System.IO

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

        Dim clickedName As Button = CType(tableView.GetControlFromPosition(0, CInt(clickedCell.Tag)), Button)

        With taxDetail
            'taxDetail.EmployeeName = "Johnny Appleseed"
            taxDetail.EmployeeName = clickedName.Text
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
        Dim spath As String = Directory.GetCurrentDirectory
        Dim employees As ArrayList
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

        Dim rowHeaders = New String() {"Name", "Hourly Pay", "Hours Worked", "Overtime", "Gross Pay", "Withheld", "YTD Pay"}

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

        'Dim columnHeaders = New String() {"Lucy", "William", "Sam", "Ryan", "John", "Scott", "Sara", "Andrew"}

        tableView.RowCount = names.Count + 1

        For i As Integer = 1 To names.Count
            ctrl = New Button
            ctrl.Dock = DockStyle.Fill
            ctrl.FlatStyle = FlatStyle.Flat
            ctrl.BackColor = Color.LightGray
            ctrl.Text = CStr(names(i - 1))
            'MsgBox(names(i - 1))
            tableView.Controls.Add(ctrl, 0, i)
        Next

        'init table contents
        For rowNo As Integer = 1 To tableView.RowCount - 1
            For columnNo As Integer = 1 To tableView.ColumnCount - 1
                ctrl = New Button
                ctrl.Tag = rowNo
                ctrl.Dock = DockStyle.Fill
                ' AddHandler ctrl.Click, AddressOf addEmployeeToTimeSlot
                ctrl.FlatStyle = FlatStyle.Flat


                If columnNo = 1 Then
                    ' Hourly Pay
                    ctrl.Text = CStr(8)
                ElseIf columnNo = 2 Then
                    ' Hours Worked
                    Dim randomValue As Integer = CInt(Math.Floor((1200 - 500 + 1) * Rnd())) + 500
                    ctrl.Text = CStr(randomValue)
                ElseIf columnNo = 3 Then
                    ' Overtime
                    Dim randomValue As Integer = CInt(Math.Floor((400 - 50 + 1) * Rnd())) + 50
                    ctrl.Text = CStr(randomValue)
                ElseIf columnNo = 4 Then
                    ' Gross Pay
                    Dim wage As Button = CType(tableView.GetControlFromPosition(1, CInt(ctrl.Tag)), Button)
                    Dim hoursWorked As Button = CType(tableView.GetControlFromPosition(2, CInt(ctrl.Tag)), Button)
                    Dim overTime As Button = CType(tableView.GetControlFromPosition(3, CInt(ctrl.Tag)), Button)

                    Dim totalPay As Double = CInt(wage.Text) * CInt(hoursWorked.Text) + (CInt(wage.Text) * 1.5) * CInt(overTime.Text)
                    ctrl.Text = CStr(totalPay)
                ElseIf columnNo = 5 Then
                    ' Withheld
                    Dim gross As Button = CType(tableView.GetControlFromPosition(4, CInt(ctrl.Tag)), Button)
                    Dim withheld As Double = 0.25 * CInt(gross.Text)
                    ctrl.Text = CStr(withheld)
                ElseIf columnNo = 6 Then
                    ' YTD Pay
                    Dim gross As Button = CType(tableView.GetControlFromPosition(4, CInt(ctrl.Tag)), Button)
                    Dim withheld As Button = CType(tableView.GetControlFromPosition(5, CInt(ctrl.Tag)), Button)

                    Dim YTD As Double = CInt(gross.Text) - CInt(withheld.Text)
                    ctrl.Text = CStr(YTD)
                End If

                tableView.Controls.Add(ctrl, columnNo, rowNo)
            Next
        Next
    End Sub


End Class