<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InitialForm
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
        Me.btn_Employee = New System.Windows.Forms.Button()
        Me.btn_Manager = New System.Windows.Forms.Button()
        Me.img_Ribbon = New System.Windows.Forms.PictureBox()
        CType(Me.img_Ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Employee
        '
        Me.btn_Employee.Location = New System.Drawing.Point(362, 216)
        Me.btn_Employee.Name = "btn_Employee"
        Me.btn_Employee.Size = New System.Drawing.Size(229, 123)
        Me.btn_Employee.TabIndex = 0
        Me.btn_Employee.Text = "Employee"
        Me.btn_Employee.UseVisualStyleBackColor = True
        '
        'btn_Manager
        '
        Me.btn_Manager.Location = New System.Drawing.Point(362, 387)
        Me.btn_Manager.Name = "btn_Manager"
        Me.btn_Manager.Size = New System.Drawing.Size(229, 123)
        Me.btn_Manager.TabIndex = 1
        Me.btn_Manager.Text = "Manager"
        Me.btn_Manager.UseVisualStyleBackColor = True
        '
        'img_Ribbon
        '
        Me.img_Ribbon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_Ribbon.Image = Global.Payroll.My.Resources.Resources.Ribbon_ChooseRole
        Me.img_Ribbon.Location = New System.Drawing.Point(300, 105)
        Me.img_Ribbon.Name = "img_Ribbon"
        Me.img_Ribbon.Size = New System.Drawing.Size(354, 52)
        Me.img_Ribbon.TabIndex = 12
        Me.img_Ribbon.TabStop = False
        '
        'InitialForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 619)
        Me.Controls.Add(Me.img_Ribbon)
        Me.Controls.Add(Me.btn_Manager)
        Me.Controls.Add(Me.btn_Employee)
        Me.Name = "InitialForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pay Tread"
        CType(Me.img_Ribbon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Employee As System.Windows.Forms.Button
    Friend WithEvents btn_Manager As System.Windows.Forms.Button
    Friend WithEvents img_Ribbon As System.Windows.Forms.PictureBox
End Class
