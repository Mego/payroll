Public Class ManagerMainMenu

    Private Sub btn_Scheduler_Click(sender As Object, e As EventArgs) Handles btn_Scheduler.Click
        Dim scheduler As ManagerScheduler
        scheduler = New ManagerScheduler
        scheduler.initTable()
        showForm(CType(scheduler, Form))
    End Sub

    Private Sub btn_MonthlyOverview_Click(sender As Object, e As EventArgs) Handles btn_MonthlyOverview.Click
        Dim monthlyOverview As ManagerMonthlyOverview
        monthlyOverview = New ManagerMonthlyOverview
        showForm(CType(monthlyOverview, Form))
    End Sub

    Private Sub btn_PrintChecks_Click(sender As Object, e As EventArgs) Handles btn_PrintChecks.Click
        Dim checkPrint As ManagerPrintChecks
        checkPrint = New ManagerPrintChecks
        showForm(CType(checkPrint, Form))
    End Sub

    Private Sub btn_TaxInformation_Click(sender As Object, e As EventArgs) Handles btn_TaxInformation.Click
        Dim taxInformation As ManagerTaxInfoOverview
        taxInformation = New ManagerTaxInfoOverview
        showForm(CType(taxInformation, Form))
    End Sub

    Sub showForm(ByRef form As Form)
        form.Location = Me.Location
        form.Show()
        Me.Close()
    End Sub

End Class