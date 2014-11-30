Public Class ManagerTaxInfoDetail

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Me.Close()
    End Sub

    Private Sub btn_PrintSummary_Click(sender As Object, e As EventArgs) Handles btn_PrintSummary.Click
        MsgBox("Printing Tax Summary...")
    End Sub

    Sub initLabels()
        txt_EmployeeName.Text = EmployeeName
        txt_Address.Text = "Address: " & Address
        txt_SSN.Text = "SSN: " & SocialSecurityNum
        txt_FedID.Text = "Fed ID: " & FederalID
        txt_FedIncomeTax.Text = "Fed Income Tax: " & FederalIncomeTax
        txt_WithheldPay.Text = "Withheld: " & WithheldPay
        txt_SocialSecurityTax.Text = "Social Security: " & SocialSecurityTax
        txt_Overtime.Text = "Overtime: " & OverTime
        txt_HoursWorked.Text = "Hours Worked: " & HoursWorked
        txt_Medicare.Text = "Medicare: " & Medicare
        txt_StateIncomeTax.Text = "State Income Tax: " & StateIncomeTax
        txt_GrossPay.Text = "Gross Pay: " & GrossPay
    End Sub

    Private empName As String
    Public Property EmployeeName() As String
        Get
            Return empName
        End Get
        Set(ByVal value As String)
            empName = value
        End Set
    End Property

    Private empAddress As String
    Public Property Address() As String
        Get
            Return empAddress
        End Get
        Set(ByVal value As String)
            empAddress = value
        End Set
    End Property

    Private ssn As String
    Public Property SocialSecurityNum() As String
        Get
            Return ssn
        End Get
        Set(ByVal value As String)
            ssn = value
        End Set
    End Property

    Private fedID As String
    Public Property FederalID() As String
        Get
            Return fedID
        End Get
        Set(ByVal value As String)
            fedID = value
        End Set
    End Property

    Private empGrossPay As String
    Public Property GrossPay() As String
        Get
            Return empGrossPay
        End Get
        Set(ByVal value As String)
            empGrossPay = value
        End Set
    End Property

    Private empHoursWorked As String
    Public Property HoursWorked() As String
        Get
            Return empHoursWorked
        End Get
        Set(ByVal value As String)
            empHoursWorked = value
        End Set
    End Property

    Private empOverTime As String
    Public Property OverTime() As String
        Get
            Return empOverTime
        End Get
        Set(ByVal value As String)
            empOverTime = value
        End Set
    End Property

    Private empWithheldPay As String
    Public Property WithheldPay() As String
        Get
            Return empWithheldPay
        End Get
        Set(ByVal value As String)
            empWithheldPay = value
        End Set
    End Property

    Private empFederalIncomeTax As String
    Public Property FederalIncomeTax() As String
        Get
            Return empFederalIncomeTax
        End Get
        Set(ByVal value As String)
            empFederalIncomeTax = value
        End Set
    End Property

    Private empSocialSecurityTax As String
    Public Property SocialSecurityTax() As String
        Get
            Return empSocialSecurityTax
        End Get
        Set(ByVal value As String)
            empSocialSecurityTax = value
        End Set
    End Property

    Private empMedicare As String
    Public Property Medicare() As String
        Get
            Return empMedicare
        End Get
        Set(ByVal value As String)
            empMedicare = value
        End Set
    End Property

    Private empStateIncomeTax As String
    Public Property StateIncomeTax() As String
        Get
            Return empStateIncomeTax
        End Get
        Set(ByVal value As String)
            empStateIncomeTax = value
        End Set
    End Property


End Class