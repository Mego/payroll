<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeCardSwipe
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_CardSwipe = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.img_Ribbon = New System.Windows.Forms.PictureBox()
        CType(Me.img_Ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(391, 313)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 86)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Keypad Entry"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_CardSwipe
        '
        Me.btn_CardSwipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CardSwipe.Location = New System.Drawing.Point(391, 196)
        Me.btn_CardSwipe.Name = "btn_CardSwipe"
        Me.btn_CardSwipe.Size = New System.Drawing.Size(167, 86)
        Me.btn_CardSwipe.TabIndex = 4
        Me.btn_CardSwipe.Text = "Card Swipe"
        Me.btn_CardSwipe.UseVisualStyleBackColor = True
        '
        'btn_Back
        '
        Me.btn_Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.Location = New System.Drawing.Point(12, 12)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(86, 34)
        Me.btn_Back.TabIndex = 8
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseVisualStyleBackColor = True
        '
        'img_Ribbon
        '
        Me.img_Ribbon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_Ribbon.ErrorImage = Global.Payroll.My.Resources.Resources.Ribbon_EmployeeClockIn
        Me.img_Ribbon.Image = Global.Payroll.My.Resources.Resources.Ribbon_SwipeCard
        Me.img_Ribbon.Location = New System.Drawing.Point(288, 115)
        Me.img_Ribbon.Name = "img_Ribbon"
        Me.img_Ribbon.Size = New System.Drawing.Size(372, 57)
        Me.img_Ribbon.TabIndex = 7
        Me.img_Ribbon.TabStop = False
        '
        'EmployeeCardSwipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 619)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.img_Ribbon)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_CardSwipe)
        Me.Name = "EmployeeCardSwipe"
        Me.Text = "Pay Tread"
        CType(Me.img_Ribbon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents img_Ribbon As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_CardSwipe As System.Windows.Forms.Button
    Friend WithEvents btn_Back As System.Windows.Forms.Button
End Class
