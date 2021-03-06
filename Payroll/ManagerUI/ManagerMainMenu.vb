﻿Public Class ManagerMainMenu

    Private Sub btn_Scheduler_Click(sender As Object, e As EventArgs) Handles btn_Scheduler.Click
        Dim scheduler As ManagerScheduler
        scheduler = New ManagerScheduler
        scheduler.initTable()
        showForm(CType(scheduler, Form))
    End Sub

    Private Sub btn_MonthlyOverview_Click(sender As Object, e As EventArgs) Handles btn_MonthlyOverview.Click
        Dim monthlyOverview As ManagerMonthlyOverview
        monthlyOverview = New ManagerMonthlyOverview
        monthlyOverview.initTable()
        showForm(CType(monthlyOverview, Form))
    End Sub

    Private Sub btn_PrintChecks_Click(sender As Object, e As EventArgs) Handles btn_PrintChecks.Click
        Dim checkPrint As ManagerPrintChecks
        checkPrint = New ManagerPrintChecks
        checkPrint.initTable()
        showForm(CType(checkPrint, Form))
    End Sub

    Private Sub btn_TaxInformation_Click(sender As Object, e As EventArgs) Handles btn_TaxInformation.Click
        Dim taxInformation As ManagerTaxInfoOverview
        taxInformation = New ManagerTaxInfoOverview
        taxInformation.initTable()
        showForm(CType(taxInformation, Form))
    End Sub

    Private Sub btn_AddEmployee_Click(sender As Object, e As EventArgs) Handles btn_AddEmployee.Click
        Dim addEmployee As InsertEmployee
        addEmployee = New InsertEmployee
        addEmployee.ShowDialog()
    End Sub

    Private Sub btn_LogOut_Click(sender As Object, e As EventArgs) Handles btn_LogOut.Click
        Dim managerLogIn As ManagerLogIn
        managerLogIn = New ManagerLogIn
        showForm(CType(managerLogIn, Form))
    End Sub

    Sub showForm(ByRef form As Form)
        form.Location = Me.Location
        form.Show()
        Me.Close()
    End Sub
End Class