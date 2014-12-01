<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeClockInMainMenu
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
        Me.btn_ClockIn = New System.Windows.Forms.Button()
        Me.btn_ClockOut = New System.Windows.Forms.Button()
        Me.btn_KeypadEntry = New System.Windows.Forms.Button()
        Me.img_Ribbon = New System.Windows.Forms.PictureBox()
        Me.btn_Back = New System.Windows.Forms.Button()
        CType(Me.img_Ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_ClockIn
        '
        Me.btn_ClockIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ClockIn.Location = New System.Drawing.Point(393, 154)
        Me.btn_ClockIn.Name = "btn_ClockIn"
        Me.btn_ClockIn.Size = New System.Drawing.Size(167, 86)
        Me.btn_ClockIn.TabIndex = 0
        Me.btn_ClockIn.Text = "Clock In"
        Me.btn_ClockIn.UseVisualStyleBackColor = True
        '
        'btn_ClockOut
        '
        Me.btn_ClockOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ClockOut.Location = New System.Drawing.Point(393, 266)
        Me.btn_ClockOut.Name = "btn_ClockOut"
        Me.btn_ClockOut.Size = New System.Drawing.Size(167, 86)
        Me.btn_ClockOut.TabIndex = 1
        Me.btn_ClockOut.Text = "Clock Out"
        Me.btn_ClockOut.UseVisualStyleBackColor = True
        '
        'btn_KeypadEntry
        '
        Me.btn_KeypadEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_KeypadEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_KeypadEntry.Location = New System.Drawing.Point(393, 376)
        Me.btn_KeypadEntry.Name = "btn_KeypadEntry"
        Me.btn_KeypadEntry.Size = New System.Drawing.Size(167, 86)
        Me.btn_KeypadEntry.TabIndex = 2
        Me.btn_KeypadEntry.Text = "Keypad Entry"
        Me.btn_KeypadEntry.UseVisualStyleBackColor = True
        '
        'img_Ribbon
        '
        Me.img_Ribbon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_Ribbon.Image = Global.Payroll.My.Resources.Resources.Ribbon_EmployeeClockIn
        Me.img_Ribbon.Location = New System.Drawing.Point(298, 73)
        Me.img_Ribbon.Name = "img_Ribbon"
        Me.img_Ribbon.Size = New System.Drawing.Size(361, 58)
        Me.img_Ribbon.TabIndex = 3
        Me.img_Ribbon.TabStop = False
        '
        'btn_Back
        '
        Me.btn_Back.Location = New System.Drawing.Point(12, 12)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(75, 23)
        Me.btn_Back.TabIndex = 4
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseVisualStyleBackColor = True
        '
        'EmployeeClockInMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 619)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.img_Ribbon)
        Me.Controls.Add(Me.btn_KeypadEntry)
        Me.Controls.Add(Me.btn_ClockOut)
        Me.Controls.Add(Me.btn_ClockIn)
        Me.Name = "EmployeeClockInMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pay Tread"
        CType(Me.img_Ribbon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_ClockIn As System.Windows.Forms.Button
    Friend WithEvents btn_ClockOut As System.Windows.Forms.Button
    Friend WithEvents btn_KeypadEntry As System.Windows.Forms.Button
    Friend WithEvents img_Ribbon As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Back As System.Windows.Forms.Button
End Class
