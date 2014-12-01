﻿Imports System.IO

Public Class InitialForm

    Private Sub btn_Employee_Click(sender As Object, e As EventArgs) Handles btn_Employee.Click
        Dim employeeLaunch As EmployeeClockInMainMenu
        employeeLaunch = New EmployeeClockInMainMenu
        showForm(CType(employeeLaunch, Form))
    End Sub

    Private Sub btn_Manager_Click(sender As Object, e As EventArgs) Handles btn_Manager.Click
        Dim managerLaunch As ManagerLogIn
        managerLaunch = New ManagerLogIn
        showForm(CType(managerLaunch, Form))
    End Sub

    Sub showForm(ByRef form As Form)
        form.Location = Me.Location
        Me.Hide()
        form.Show()
        Me.Close()
    End Sub

    Private Sub InitialForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim spath As String = Directory.GetCurrentDirectory

        ' creates file that will contain employee data if none is found in current directory
        Dim paramArray1(2) As String
        paramArray1(1) = spath
        paramArray1(2) = "EmployeeData"
        Dim paramArray2(2) As String
        paramArray2(1) = spath
        paramArray2(2) = "EmployeeData\Data.csv"
        If (Not Directory.Exists(Path.Combine(paramArray1))) Then
            Directory.CreateDirectory(Path.Combine(paramArray1))
            If (Not File.Exists(Path.Combine(paramArray2))) Then
                File.Create(Path.Combine(paramArray2))
                ' initializes the file that is created to hold the four default names and their data
                My.Computer.FileSystem.WriteAllText("EmployeeData\Data.csv", "Al Pacino,11111,0;", True)
                My.Computer.FileSystem.WriteAllText("EmployeeData\Data.csv", "James Cameron,22222,0;", True)
                My.Computer.FileSystem.WriteAllText("EmployeeData\Data.csv", "Martin Scorcese,33333,0;", True)
                My.Computer.FileSystem.WriteAllText("EmployeeData\Data.csv", "Ridley Scott,44444,0;", True)
            End If
        End If

        Dim currentFile(10) As String
        Dim i As Integer
        i = 0

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("EmployeeData\Data.csv")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(";")
            While Not MyReader.EndOfData
                currentFile(i) = MyReader.ReadToEnd()
                i = i + 1
            End While
        End Using
    End Sub
End Class