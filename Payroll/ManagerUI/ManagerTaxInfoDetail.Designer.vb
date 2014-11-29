<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerTaxInfoDetail
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btn_PrintSummary = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.txt_EmployeeName = New System.Windows.Forms.Label()
        Me.txt_GrossPay = New System.Windows.Forms.Label()
        Me.txt_WithheldPay = New System.Windows.Forms.Label()
        Me.txt_Address = New System.Windows.Forms.Label()
        Me.txt_SSN = New System.Windows.Forms.Label()
        Me.txt_FedID = New System.Windows.Forms.Label()
        Me.txt_Overtime = New System.Windows.Forms.Label()
        Me.txt_HoursWorked = New System.Windows.Forms.Label()
        Me.txt_Medicare = New System.Windows.Forms.Label()
        Me.txt_SocialSecurityTax = New System.Windows.Forms.Label()
        Me.txt_FedIncomeTax = New System.Windows.Forms.Label()
        Me.txt_StateIncomeTax = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.img_Ribbon = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_Ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(645, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Tax Data for Year:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(740, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 31
        '
        'btn_PrintSummary
        '
        Me.btn_PrintSummary.Location = New System.Drawing.Point(832, 569)
        Me.btn_PrintSummary.Name = "btn_PrintSummary"
        Me.btn_PrintSummary.Size = New System.Drawing.Size(88, 38)
        Me.btn_PrintSummary.TabIndex = 36
        Me.btn_PrintSummary.Text = "Print Summary"
        Me.btn_PrintSummary.UseVisualStyleBackColor = True
        '
        'btn_Back
        '
        Me.btn_Back.Location = New System.Drawing.Point(12, 9)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(88, 27)
        Me.btn_Back.TabIndex = 37
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseVisualStyleBackColor = True
        '
        'txt_EmployeeName
        '
        Me.txt_EmployeeName.AutoSize = True
        Me.txt_EmployeeName.BackColor = System.Drawing.Color.Transparent
        Me.txt_EmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EmployeeName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_EmployeeName.Location = New System.Drawing.Point(38, 191)
        Me.txt_EmployeeName.Name = "txt_EmployeeName"
        Me.txt_EmployeeName.Size = New System.Drawing.Size(193, 29)
        Me.txt_EmployeeName.TabIndex = 41
        Me.txt_EmployeeName.Text = "Employee Name"
        '
        'txt_GrossPay
        '
        Me.txt_GrossPay.AutoSize = True
        Me.txt_GrossPay.BackColor = System.Drawing.Color.Transparent
        Me.txt_GrossPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GrossPay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_GrossPay.Location = New System.Drawing.Point(353, 191)
        Me.txt_GrossPay.Name = "txt_GrossPay"
        Me.txt_GrossPay.Size = New System.Drawing.Size(123, 29)
        Me.txt_GrossPay.TabIndex = 42
        Me.txt_GrossPay.Text = "Gross Pay"
        '
        'txt_WithheldPay
        '
        Me.txt_WithheldPay.AutoSize = True
        Me.txt_WithheldPay.BackColor = System.Drawing.Color.Transparent
        Me.txt_WithheldPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_WithheldPay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_WithheldPay.Location = New System.Drawing.Point(673, 191)
        Me.txt_WithheldPay.Name = "txt_WithheldPay"
        Me.txt_WithheldPay.Size = New System.Drawing.Size(153, 29)
        Me.txt_WithheldPay.TabIndex = 43
        Me.txt_WithheldPay.Text = "Withheld Pay"
        '
        'txt_Address
        '
        Me.txt_Address.AutoSize = True
        Me.txt_Address.BackColor = System.Drawing.Color.Transparent
        Me.txt_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Address.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Address.Location = New System.Drawing.Point(40, 241)
        Me.txt_Address.Name = "txt_Address"
        Me.txt_Address.Size = New System.Drawing.Size(51, 15)
        Me.txt_Address.TabIndex = 44
        Me.txt_Address.Text = "Address"
        '
        'txt_SSN
        '
        Me.txt_SSN.AutoSize = True
        Me.txt_SSN.BackColor = System.Drawing.Color.Transparent
        Me.txt_SSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_SSN.Location = New System.Drawing.Point(40, 274)
        Me.txt_SSN.Name = "txt_SSN"
        Me.txt_SSN.Size = New System.Drawing.Size(135, 15)
        Me.txt_SSN.TabIndex = 45
        Me.txt_SSN.Text = "Social Security Number"
        '
        'txt_FedID
        '
        Me.txt_FedID.AutoSize = True
        Me.txt_FedID.BackColor = System.Drawing.Color.Transparent
        Me.txt_FedID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FedID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_FedID.Location = New System.Drawing.Point(40, 307)
        Me.txt_FedID.Name = "txt_FedID"
        Me.txt_FedID.Size = New System.Drawing.Size(64, 15)
        Me.txt_FedID.TabIndex = 46
        Me.txt_FedID.Text = "Federal ID"
        '
        'txt_Overtime
        '
        Me.txt_Overtime.AutoSize = True
        Me.txt_Overtime.BackColor = System.Drawing.Color.Transparent
        Me.txt_Overtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Overtime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Overtime.Location = New System.Drawing.Point(355, 274)
        Me.txt_Overtime.Name = "txt_Overtime"
        Me.txt_Overtime.Size = New System.Drawing.Size(56, 15)
        Me.txt_Overtime.TabIndex = 48
        Me.txt_Overtime.Text = "Overtime"
        '
        'txt_HoursWorked
        '
        Me.txt_HoursWorked.AutoSize = True
        Me.txt_HoursWorked.BackColor = System.Drawing.Color.Transparent
        Me.txt_HoursWorked.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_HoursWorked.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_HoursWorked.Location = New System.Drawing.Point(355, 241)
        Me.txt_HoursWorked.Name = "txt_HoursWorked"
        Me.txt_HoursWorked.Size = New System.Drawing.Size(85, 15)
        Me.txt_HoursWorked.TabIndex = 47
        Me.txt_HoursWorked.Text = "Hours Worked"
        '
        'txt_Medicare
        '
        Me.txt_Medicare.AutoSize = True
        Me.txt_Medicare.BackColor = System.Drawing.Color.Transparent
        Me.txt_Medicare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Medicare.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_Medicare.Location = New System.Drawing.Point(675, 307)
        Me.txt_Medicare.Name = "txt_Medicare"
        Me.txt_Medicare.Size = New System.Drawing.Size(59, 15)
        Me.txt_Medicare.TabIndex = 51
        Me.txt_Medicare.Text = "Medicare"
        '
        'txt_SocialSecurityTax
        '
        Me.txt_SocialSecurityTax.AutoSize = True
        Me.txt_SocialSecurityTax.BackColor = System.Drawing.Color.Transparent
        Me.txt_SocialSecurityTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SocialSecurityTax.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_SocialSecurityTax.Location = New System.Drawing.Point(675, 274)
        Me.txt_SocialSecurityTax.Name = "txt_SocialSecurityTax"
        Me.txt_SocialSecurityTax.Size = New System.Drawing.Size(87, 15)
        Me.txt_SocialSecurityTax.TabIndex = 50
        Me.txt_SocialSecurityTax.Text = "Social Security"
        '
        'txt_FedIncomeTax
        '
        Me.txt_FedIncomeTax.AutoSize = True
        Me.txt_FedIncomeTax.BackColor = System.Drawing.Color.Transparent
        Me.txt_FedIncomeTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FedIncomeTax.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_FedIncomeTax.Location = New System.Drawing.Point(675, 241)
        Me.txt_FedIncomeTax.Name = "txt_FedIncomeTax"
        Me.txt_FedIncomeTax.Size = New System.Drawing.Size(116, 15)
        Me.txt_FedIncomeTax.TabIndex = 49
        Me.txt_FedIncomeTax.Text = "Federal Income Tax"
        '
        'txt_StateIncomeTax
        '
        Me.txt_StateIncomeTax.AutoSize = True
        Me.txt_StateIncomeTax.BackColor = System.Drawing.Color.Transparent
        Me.txt_StateIncomeTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_StateIncomeTax.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_StateIncomeTax.Location = New System.Drawing.Point(675, 338)
        Me.txt_StateIncomeTax.Name = "txt_StateIncomeTax"
        Me.txt_StateIncomeTax.Size = New System.Drawing.Size(102, 15)
        Me.txt_StateIncomeTax.TabIndex = 52
        Me.txt_StateIncomeTax.Text = "State Income Tax"
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox5.Image = Global.Payroll.My.Resources.Resources.Ribbon_TaxSummary
        Me.PictureBox5.Location = New System.Drawing.Point(662, 57)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(261, 53)
        Me.PictureBox5.TabIndex = 40
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Image = Global.Payroll.My.Resources.Resources.Ribbon_PaySummary
        Me.PictureBox4.Location = New System.Drawing.Point(345, 57)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(261, 53)
        Me.PictureBox4.TabIndex = 39
        Me.PictureBox4.TabStop = False
        '
        'img_Ribbon
        '
        Me.img_Ribbon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_Ribbon.Image = Global.Payroll.My.Resources.Resources.Ribbon_EmployeeInfo
        Me.img_Ribbon.Location = New System.Drawing.Point(29, 57)
        Me.img_Ribbon.Name = "img_Ribbon"
        Me.img_Ribbon.Size = New System.Drawing.Size(261, 53)
        Me.img_Ribbon.TabIndex = 38
        Me.img_Ribbon.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Payroll.My.Resources.Resources.Card
        Me.PictureBox3.Location = New System.Drawing.Point(33, 116)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(253, 387)
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Payroll.My.Resources.Resources.Card
        Me.PictureBox2.Location = New System.Drawing.Point(350, 116)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(253, 387)
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Payroll.My.Resources.Resources.Card
        Me.PictureBox1.Location = New System.Drawing.Point(667, 116)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 387)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'ManagerTaxInfoDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 619)
        Me.Controls.Add(Me.txt_StateIncomeTax)
        Me.Controls.Add(Me.txt_Medicare)
        Me.Controls.Add(Me.txt_SocialSecurityTax)
        Me.Controls.Add(Me.txt_FedIncomeTax)
        Me.Controls.Add(Me.txt_Overtime)
        Me.Controls.Add(Me.txt_HoursWorked)
        Me.Controls.Add(Me.txt_FedID)
        Me.Controls.Add(Me.txt_SSN)
        Me.Controls.Add(Me.txt_Address)
        Me.Controls.Add(Me.txt_WithheldPay)
        Me.Controls.Add(Me.txt_GrossPay)
        Me.Controls.Add(Me.txt_EmployeeName)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.img_Ribbon)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btn_PrintSummary)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "ManagerTaxInfoDetail"
        Me.Text = "Pay Tread - Admin"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_Ribbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_PrintSummary As System.Windows.Forms.Button
    Friend WithEvents btn_Back As System.Windows.Forms.Button
    Friend WithEvents img_Ribbon As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_EmployeeName As System.Windows.Forms.Label
    Friend WithEvents txt_GrossPay As System.Windows.Forms.Label
    Friend WithEvents txt_WithheldPay As System.Windows.Forms.Label
    Friend WithEvents txt_Address As System.Windows.Forms.Label
    Friend WithEvents txt_SSN As System.Windows.Forms.Label
    Friend WithEvents txt_FedID As System.Windows.Forms.Label
    Friend WithEvents txt_Overtime As System.Windows.Forms.Label
    Friend WithEvents txt_HoursWorked As System.Windows.Forms.Label
    Friend WithEvents txt_Medicare As System.Windows.Forms.Label
    Friend WithEvents txt_SocialSecurityTax As System.Windows.Forms.Label
    Friend WithEvents txt_FedIncomeTax As System.Windows.Forms.Label
    Friend WithEvents txt_StateIncomeTax As System.Windows.Forms.Label
End Class
