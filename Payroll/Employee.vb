Public Class Employee
    Inherits MySQLTable

    Private _ssnOriginal As String

    Public Sub New()
        MyBase.New()
        _ssnOriginal = ""
    End Sub

    Public Overrides Sub LoadPrimaryKey()
        _ssnOriginal = Ssn
    End Sub

    Public Property Ssn As String
        Get
            Return CStr(Field("Ssn"))
        End Get
        Set(value As String)
            Field("Ssn") = value
        End Set
    End Property

    Public Property FirstName As String
        Get
            Return CStr(Field("Fname"))
        End Get
        Set(value As String)
            Field("Fname") = value
        End Set
    End Property

    Public Property MiddleName As String
        Get
            Return CStr(Field("Mname"))
        End Get
        Set(value As String)
            Field("Mname") = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return CStr(Field("Lname"))
        End Get
        Set(value As String)
            Field("Lname") = value
        End Set
    End Property

    Public Property BirthDate As Date
        Get
            Return Date.ParseExact(CStr(Field("Bdate")), "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
        End Get
        Set(value As Date)
            Field("Bdate") = value.ToString("yyyyMMdd")
        End Set
    End Property

    Public ReadOnly Property BirthDateString As String
        Get
            Return BirthDate.ToString("yyyyMMdd")
        End Get
    End Property

    Public Property PhoneNumber As String
        Get
            Return CStr(Field("PhoneNum"))
        End Get
        Set(value As String)
            Field("PhoneNum") = value
        End Set
    End Property

    Public Property Sex As Char
        Get
            Return CChar(Field("Sex"))
        End Get
        Set(value As Char)
            Field("Sex") = value
        End Set
    End Property

    Public Overrides Sub UpdateCurrentRow()
        Dim strSql As String =
            "UPDATE SE_EMPLOYEE SET Ssn='{0}',Fname='{1}',Mname='{2}',Lname='{3}',Bdate='{4}',PhoneNum='{5}',Sex='{6}' WHERE Ssn='{7}'".FormatWith(
                Ssn, FirstName, MiddleName, LastName, BirthDateString, PhoneNumber, Sex, _ssnOriginal)
        ExecuteNonQuery(strSql)
    End Sub

    Public Sub GetEmployee(ByVal pSsn As String)
        ExecuteQuery("SELECT * FROM SE_EMPLOYEE WHERE Ssn='{0}'".FormatWith(pSsn))
    End Sub

End Class
