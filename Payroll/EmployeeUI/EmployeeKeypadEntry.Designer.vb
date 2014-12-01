<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeKeypadEntry
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
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.img_Avatar = New System.Windows.Forms.PictureBox()
        Me.img_Ribbon = New System.Windows.Forms.PictureBox()
        CType(Me.img_Avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_Ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Back
        '
        Me.btn_Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Back.Location = New System.Drawing.Point(12, 12)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(86, 34)
        Me.btn_Back.TabIndex = 12
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseVisualStyleBackColor = True
        '
        'btn_Submit
        '
        Me.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Submit.Location = New System.Drawing.Point(401, 327)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(161, 63)
        Me.btn_Submit.TabIndex = 10
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(349, 216)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(295, 20)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = "Employee ID Number..."
        '
        'img_Avatar
        '
        Me.img_Avatar.Image = Global.Payroll.My.Resources.Resources.Icon_Avatar
        Me.img_Avatar.Location = New System.Drawing.Point(290, 199)
        Me.img_Avatar.Name = "img_Avatar"
        Me.img_Avatar.Size = New System.Drawing.Size(53, 50)
        Me.img_Avatar.TabIndex = 14
        Me.img_Avatar.TabStop = False
        '
        'img_Ribbon
        '
        Me.img_Ribbon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_Ribbon.Image = Global.Payroll.My.Resources.Resources.Ribbon_EmployeeKeypad
        Me.img_Ribbon.Location = New System.Drawing.Point(299, 121)
        Me.img_Ribbon.Name = "img_Ribbon"
        Me.img_Ribbon.Size = New System.Drawing.Size(354, 52)
        Me.img_Ribbon.TabIndex = 11
        Me.img_Ribbon.TabStop = False
        '
        'EmployeeKeypadEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 619)
        Me.Controls.Add(Me.img_Avatar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.img_Ribbon)
        Me.Controls.Add(Me.btn_Submit)
        Me.Name = "EmployeeKeypadEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pay Tread"
        CType(Me.img_Avatar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_Ribbon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents img_Ribbon As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Submit As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents img_Avatar As System.Windows.Forms.PictureBox
End Class
