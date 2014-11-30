<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerLogIn
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
        Me.txt_ManagerName = New System.Windows.Forms.TextBox()
        Me.btn_Submit = New System.Windows.Forms.Button()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.img_Avatar = New System.Windows.Forms.PictureBox()
        Me.img_Ribbon = New System.Windows.Forms.PictureBox()
        Me.btn_Back = New System.Windows.Forms.Button()
        CType(Me.img_Avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_Ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_ManagerName
        '
        Me.txt_ManagerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ManagerName.Location = New System.Drawing.Point(363, 250)
        Me.txt_ManagerName.Name = "txt_ManagerName"
        Me.txt_ManagerName.Size = New System.Drawing.Size(295, 20)
        Me.txt_ManagerName.TabIndex = 17
        Me.txt_ManagerName.Text = "Enter admin name..."
        '
        'btn_Submit
        '
        Me.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Submit.Location = New System.Drawing.Point(406, 381)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(161, 63)
        Me.btn_Submit.TabIndex = 15
        Me.btn_Submit.Text = "Submit"
        Me.btn_Submit.UseVisualStyleBackColor = True
        '
        'txt_Password
        '
        Me.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Password.Location = New System.Drawing.Point(363, 280)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Size = New System.Drawing.Size(295, 20)
        Me.txt_Password.TabIndex = 19
        Me.txt_Password.Text = "Password..."
        Me.txt_Password.UseSystemPasswordChar = True
        '
        'img_Avatar
        '
        Me.img_Avatar.Image = Global.Payroll.My.Resources.Resources.Icon_Avatar
        Me.img_Avatar.Location = New System.Drawing.Point(304, 250)
        Me.img_Avatar.Name = "img_Avatar"
        Me.img_Avatar.Size = New System.Drawing.Size(53, 50)
        Me.img_Avatar.TabIndex = 18
        Me.img_Avatar.TabStop = False
        '
        'img_Ribbon
        '
        Me.img_Ribbon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_Ribbon.Image = Global.Payroll.My.Resources.Resources.Ribbon_ManagerAccess
        Me.img_Ribbon.Location = New System.Drawing.Point(304, 175)
        Me.img_Ribbon.Name = "img_Ribbon"
        Me.img_Ribbon.Size = New System.Drawing.Size(354, 52)
        Me.img_Ribbon.TabIndex = 16
        Me.img_Ribbon.TabStop = False
        '
        'btn_Back
        '
        Me.btn_Back.Location = New System.Drawing.Point(12, 12)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(75, 23)
        Me.btn_Back.TabIndex = 20
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseVisualStyleBackColor = True
        '
        'ManagerLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 619)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.txt_Password)
        Me.Controls.Add(Me.img_Avatar)
        Me.Controls.Add(Me.txt_ManagerName)
        Me.Controls.Add(Me.img_Ribbon)
        Me.Controls.Add(Me.btn_Submit)
        Me.Name = "ManagerLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ManagerLogIn"
        CType(Me.img_Avatar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_Ribbon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents img_Avatar As System.Windows.Forms.PictureBox
    Friend WithEvents txt_ManagerName As System.Windows.Forms.TextBox
    Friend WithEvents img_Ribbon As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Submit As System.Windows.Forms.Button
    Friend WithEvents txt_Password As System.Windows.Forms.TextBox
    Friend WithEvents btn_Back As System.Windows.Forms.Button
End Class
