<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeClockIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeClockIn))
        Me.btn_ClockIn = New System.Windows.Forms.Button()
        Me.btn_ClockOut = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.img_Ribbon = New System.Windows.Forms.PictureBox()
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
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(393, 376)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 86)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Keypad Entry"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'img_Ribbon
        '
        Me.img_Ribbon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_Ribbon.Image = CType(resources.GetObject("img_Ribbon.Image"), System.Drawing.Image)
        Me.img_Ribbon.Location = New System.Drawing.Point(298, 73)
        Me.img_Ribbon.Name = "img_Ribbon"
        Me.img_Ribbon.Size = New System.Drawing.Size(361, 58)
        Me.img_Ribbon.TabIndex = 3
        Me.img_Ribbon.TabStop = False
        '
        'EmployeeClockIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 619)
        Me.Controls.Add(Me.img_Ribbon)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_ClockOut)
        Me.Controls.Add(Me.btn_ClockIn)
        Me.Name = "EmployeeClockIn"
        Me.Text = "Pay Tread"
        CType(Me.img_Ribbon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_ClockIn As System.Windows.Forms.Button
    Friend WithEvents btn_ClockOut As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents img_Ribbon As System.Windows.Forms.PictureBox
End Class
