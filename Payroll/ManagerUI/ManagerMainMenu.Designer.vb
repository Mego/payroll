﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_PrintChecks = New System.Windows.Forms.Button()
        Me.btn_MonthlyOverview = New System.Windows.Forms.Button()
        Me.btn_Scheduler = New System.Windows.Forms.Button()
        Me.btn_TaxInformation = New System.Windows.Forms.Button()
        Me.img_Ribbon = New System.Windows.Forms.PictureBox()
        Me.btn_AddEmployee = New System.Windows.Forms.Button()
        Me.btn_LogOut = New System.Windows.Forms.Button()
        CType(Me.img_Ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_PrintChecks
        '
        Me.btn_PrintChecks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_PrintChecks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_PrintChecks.Location = New System.Drawing.Point(404, 279)
        Me.btn_PrintChecks.Name = "btn_PrintChecks"
        Me.btn_PrintChecks.Size = New System.Drawing.Size(144, 86)
        Me.btn_PrintChecks.TabIndex = 6
        Me.btn_PrintChecks.Text = "Print Checks"
        Me.btn_PrintChecks.UseVisualStyleBackColor = True
        '
        'btn_MonthlyOverview
        '
        Me.btn_MonthlyOverview.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_MonthlyOverview.Location = New System.Drawing.Point(219, 279)
        Me.btn_MonthlyOverview.Name = "btn_MonthlyOverview"
        Me.btn_MonthlyOverview.Size = New System.Drawing.Size(144, 86)
        Me.btn_MonthlyOverview.TabIndex = 5
        Me.btn_MonthlyOverview.Text = "Monthly Overview"
        Me.btn_MonthlyOverview.UseVisualStyleBackColor = True
        '
        'btn_Scheduler
        '
        Me.btn_Scheduler.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Scheduler.Location = New System.Drawing.Point(34, 279)
        Me.btn_Scheduler.Name = "btn_Scheduler"
        Me.btn_Scheduler.Size = New System.Drawing.Size(144, 86)
        Me.btn_Scheduler.TabIndex = 4
        Me.btn_Scheduler.Text = "Scheduler"
        Me.btn_Scheduler.UseVisualStyleBackColor = True
        '
        'btn_TaxInformation
        '
        Me.btn_TaxInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_TaxInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_TaxInformation.Location = New System.Drawing.Point(589, 279)
        Me.btn_TaxInformation.Name = "btn_TaxInformation"
        Me.btn_TaxInformation.Size = New System.Drawing.Size(144, 86)
        Me.btn_TaxInformation.TabIndex = 8
        Me.btn_TaxInformation.Text = "Tax Information"
        Me.btn_TaxInformation.UseVisualStyleBackColor = True
        '
        'img_Ribbon
        '
        Me.img_Ribbon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_Ribbon.Image = Global.Payroll.My.Resources.Resources.Ribbon_ManagerMainMenu
        Me.img_Ribbon.Location = New System.Drawing.Point(289, 115)
        Me.img_Ribbon.Name = "img_Ribbon"
        Me.img_Ribbon.Size = New System.Drawing.Size(375, 55)
        Me.img_Ribbon.TabIndex = 7
        Me.img_Ribbon.TabStop = False
        '
        'btn_AddEmployee
        '
        Me.btn_AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddEmployee.Location = New System.Drawing.Point(774, 279)
        Me.btn_AddEmployee.Name = "btn_AddEmployee"
        Me.btn_AddEmployee.Size = New System.Drawing.Size(144, 86)
        Me.btn_AddEmployee.TabIndex = 9
        Me.btn_AddEmployee.Text = "Add Employee"
        Me.btn_AddEmployee.UseVisualStyleBackColor = True
        '
        'btn_LogOut
        '
        Me.btn_LogOut.Location = New System.Drawing.Point(12, 12)
        Me.btn_LogOut.Name = "btn_LogOut"
        Me.btn_LogOut.Size = New System.Drawing.Size(75, 23)
        Me.btn_LogOut.TabIndex = 10
        Me.btn_LogOut.Text = "Log Out"
        Me.btn_LogOut.UseVisualStyleBackColor = True
        '
        'ManagerMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 619)
        Me.Controls.Add(Me.btn_LogOut)
        Me.Controls.Add(Me.btn_AddEmployee)
        Me.Controls.Add(Me.btn_TaxInformation)
        Me.Controls.Add(Me.img_Ribbon)
        Me.Controls.Add(Me.btn_PrintChecks)
        Me.Controls.Add(Me.btn_MonthlyOverview)
        Me.Controls.Add(Me.btn_Scheduler)
        Me.Name = "ManagerMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pay Tread - Admin"
        CType(Me.img_Ribbon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents img_Ribbon As System.Windows.Forms.PictureBox
    Friend WithEvents btn_PrintChecks As System.Windows.Forms.Button
    Friend WithEvents btn_MonthlyOverview As System.Windows.Forms.Button
    Friend WithEvents btn_Scheduler As System.Windows.Forms.Button
    Friend WithEvents btn_TaxInformation As System.Windows.Forms.Button
    Friend WithEvents btn_AddEmployee As System.Windows.Forms.Button
    Friend WithEvents btn_LogOut As System.Windows.Forms.Button
End Class
