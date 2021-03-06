﻿Imports System.IO

Public Class ManagerMonthlyOverview

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
            'MsgBox(employees(i))
            splitString = Split(CStr(employees(i)), ",")
            names.Add(splitString(1))
            '(names(i))
        Next

        Dim firstNames As New ArrayList
        For i As Integer = 0 To employees.Count - 1
            splitString = Split(CStr(names(i)), " ")
            firstNames.Add(splitString(0))
            '(names(i))
        Next

        Dim rowHeaders = New String() {"EMPLOYEE", "Hourly Pay", "Hours Worked", "Overtime", "Total Pay"}

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
                    ' Wage
                    ctrl.Text = "8"
                ElseIf columnNo = 2 Then
                    ' Hours Worked
                    Dim randomValue As Integer = CInt(Math.Floor((75 - 30 + 1) * Rnd())) + 30
                    ctrl.Text = CStr(randomValue)
                ElseIf columnNo = 3 Then
                    ' Overtime
                    Dim randomValue As Integer = CInt(Math.Floor((10 - 0 + 1) * Rnd())) + 0
                    ctrl.Text = CStr(randomValue)
                ElseIf columnNo = 4 Then
                    ' Pay
                    Dim wage As Button = CType(tableView.GetControlFromPosition(1, CInt(ctrl.Tag)), Button)
                    Dim hoursWorked As Button = CType(tableView.GetControlFromPosition(2, CInt(ctrl.Tag)), Button)
                    Dim overTime As Button = CType(tableView.GetControlFromPosition(3, CInt(ctrl.Tag)), Button)

                    Dim totalPay As Double = CInt(wage.Text) * CInt(hoursWorked.Text) + (CInt(wage.Text) * 1.5) * CInt(overTime.Text)
                    ctrl.Text = CStr(totalPay)

                End If

                tableView.Controls.Add(ctrl, columnNo, rowNo)
            Next
        Next
    End Sub


End Class