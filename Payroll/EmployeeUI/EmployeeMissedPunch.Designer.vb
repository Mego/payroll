<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeMissedPunch
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
        Me.txt_Time = New System.Windows.Forms.TextBox()
        Me.btn_SubmitClockOut = New System.Windows.Forms.Button()
        Me.txt_ClockOutMessage = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.img_Ribbon = New System.Windows.Forms.PictureBox()
        CType(Me.img_Ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Time
        '
        Me.txt_Time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Time.Location = New System.Drawing.Point(262, 230)
        Me.txt_Time.Name = "txt_Time"
        Me.txt_Time.Size = New System.Drawing.Size(185, 20)
        Me.txt_Time.TabIndex = 18
        Me.txt_Time.Text = "Time..."
        '
        'btn_SubmitClockOut
        '
        Me.btn_SubmitClockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SubmitClockOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SubmitClockOut.Location = New System.Drawing.Point(530, 309)
        Me.btn_SubmitClockOut.Name = "btn_SubmitClockOut"
        Me.btn_SubmitClockOut.Size = New System.Drawing.Size(161, 63)
        Me.btn_SubmitClockOut.TabIndex = 15
        Me.btn_SubmitClockOut.Text = "Submit Clock Out"
        Me.btn_SubmitClockOut.UseVisualStyleBackColor = True
        '
        'txt_ClockOutMessage
        '
        Me.txt_ClockOutMessage.AutoSize = True
        Me.txt_ClockOutMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ClockOutMessage.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txt_ClockOutMessage.Location = New System.Drawing.Point(247, 176)
        Me.txt_ClockOutMessage.Name = "txt_ClockOutMessage"
        Me.txt_ClockOutMessage.Size = New System.Drawing.Size(458, 29)
        Me.txt_ClockOutMessage.TabIndex = 19
        Me.txt_ClockOutMessage.Text = "Enter clock out time for 3:00 pm, 10/27/14:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(463, 230)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 20
        '
        'img_Ribbon
        '
        Me.img_Ribbon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_Ribbon.Image = Global.Payroll.My.Resources.Resources.Ribbon_MissedPunch
        Me.img_Ribbon.Location = New System.Drawing.Point(289, 100)
        Me.img_Ribbon.Name = "img_Ribbon"
        Me.img_Ribbon.Size = New System.Drawing.Size(354, 52)
        Me.img_Ribbon.TabIndex = 16
        Me.img_Ribbon.TabStop = False
        '
        'EmployeeMissedPunch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 619)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txt_ClockOutMessage)
        Me.Controls.Add(Me.txt_Time)
        Me.Controls.Add(Me.img_Ribbon)
        Me.Controls.Add(Me.btn_SubmitClockOut)
        Me.Name = "EmployeeMissedPunch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pay Tread"
        CType(Me.img_Ribbon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Time As System.Windows.Forms.TextBox
    Friend WithEvents img_Ribbon As System.Windows.Forms.PictureBox
    Friend WithEvents btn_SubmitClockOut As System.Windows.Forms.Button
    Friend WithEvents txt_ClockOutMessage As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
