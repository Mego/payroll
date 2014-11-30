Public Class ManagerLogIn


    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        checkCredentials()
    End Sub

    Private adminName As String
    Public Property ManagerName() As String
        Get
            Return AdminName
        End Get
        Set(ByVal value As String)
            adminName = value
        End Set
    End Property

    Private adminPassword As String
    Public Property ManagerPassword() As String
        Get
            Return AdminPassword
        End Get
        Set(ByVal value As String)
            adminPassword = value
        End Set
    End Property


    Private Sub ManagerLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set placeholder credentials for demo
        ManagerName = "admin"
        ManagerPassword = "password"
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Dim roleSelect As InitialForm
        roleSelect = New InitialForm
        showForm(CType(roleSelect, Form))
    End Sub

    Sub showForm(ByRef form As Form)
        form.Location = Me.Location
        form.Show()
        Me.Close()
    End Sub

    Private Sub txt_ManagerName_Click(sender As Object, e As EventArgs) Handles txt_ManagerName.GotFocus
        txt_ManagerName.Text = ""
    End Sub

    Private Sub txt_ManagerName_LostFocus(sender As Object, e As EventArgs) Handles txt_ManagerName.LostFocus
        If txt_ManagerName.Text = "" Then
            txt_ManagerName.Text = "Enter admin name..."
        End If
    End Sub

    Private Sub txt_Password_Click(sender As Object, e As EventArgs) Handles txt_Password.GotFocus
        txt_Password.Text = ""
    End Sub

    Private Sub txt_Password_LostFocus(sender As Object, e As EventArgs) Handles txt_Password.LostFocus
        If txt_Password.Text = "" Then
            txt_Password.Text = "Password..."
        End If
    End Sub

    Private Sub txt_Password_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Password.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            checkCredentials()
        End If
    End Sub

    Sub checkCredentials()
        Dim submitAdminName As String = txt_ManagerName.Text
        Dim submitPassword As String = txt_Password.Text

        If submitAdminName = ManagerName And submitPassword = ManagerPassword Then
            Dim managerLaunch As ManagerMainMenu
            managerLaunch = New ManagerMainMenu
            showForm(CType(managerLaunch, Form))
            Me.Close()
        Else
            MsgBox("Invalid login credentials.")
        End If
    End Sub

End Class