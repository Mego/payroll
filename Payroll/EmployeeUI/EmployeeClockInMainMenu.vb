﻿Public Class EmployeeClockInMainMenu

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Dim roleSelect As InitialForm
        roleSelect = New InitialForm
        showForm(CType(roleSelect, Form))
    End Sub

    Private Sub btn_ClockIn_Click(sender As Object, e As EventArgs) Handles btn_ClockIn.Click
        Dim cardSwipe As EmployeeCardSwipe
        cardSwipe = New EmployeeCardSwipe
        ' Set form to clock in instead of clock out
        cardSwipe.ClockOut = False
        showForm(CType(cardSwipe, Form))
    End Sub

    Private Sub btn_KeypadEntry_Click(sender As Object, e As EventArgs) Handles btn_KeypadEntry.Click
        Dim keypadEntry As EmployeeKeypadEntry
        keypadEntry = New EmployeeKeypadEntry
        showForm(CType(keypadEntry, Form))
    End Sub

    Private Sub btn_ClockOut_Click(sender As Object, e As EventArgs) Handles btn_ClockOut.Click
        MsgBox("Clocking out")
        Dim cardSwipe As EmployeeCardSwipe
        cardSwipe = New EmployeeCardSwipe
        ' Set form to clock out instead of clock in
        cardSwipe.ClockOut = True
        showForm(CType(cardSwipe, Form))
    End Sub

    Sub showForm(ByRef form As Form)
        form.Location = Me.Location
        form.Show()
        Me.Close()
    End Sub

End Class