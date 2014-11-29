<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerEmployeePicker
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
        Me.employeeSelect = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Finished = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'employeeSelect
        '
        Me.employeeSelect.FormattingEnabled = True
        Me.employeeSelect.Items.AddRange(New Object() {"Al Pacino", "James Cameron", "Martin Scorcese", "Ridley Scott"})
        Me.employeeSelect.Location = New System.Drawing.Point(12, 58)
        Me.employeeSelect.Name = "employeeSelect"
        Me.employeeSelect.Size = New System.Drawing.Size(300, 199)
        Me.employeeSelect.Sorted = True
        Me.employeeSelect.TabIndex = 0
        Me.employeeSelect.ThreeDCheckBoxes = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Employees to Work"
        '
        'btn_Finished
        '
        Me.btn_Finished.Location = New System.Drawing.Point(234, 280)
        Me.btn_Finished.Name = "btn_Finished"
        Me.btn_Finished.Size = New System.Drawing.Size(75, 23)
        Me.btn_Finished.TabIndex = 2
        Me.btn_Finished.Text = "Submit"
        Me.btn_Finished.UseVisualStyleBackColor = True
        '
        'ManagerEmployeePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 315)
        Me.Controls.Add(Me.btn_Finished)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.employeeSelect)
        Me.Name = "ManagerEmployeePicker"
        Me.Text = "Employee Picker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents employeeSelect As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Finished As System.Windows.Forms.Button
End Class
