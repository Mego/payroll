Public Class Employment
    Inherits MySQLTable

    Private _EssnOriginal As String
    Private _HireDateString As String

    Public Sub New()
        MyBase.New()
        _EssnOriginal = ""
        _HireDateString = ""
    End Sub

    Public Overrides Sub LoadPrimaryKey()
        _EssnOriginal = Essn
        _HireDateString = HireDateString
    End Sub

    Public Property Essn As String
        Get
            Return Field("Essn").ToString
        End Get
        Set(value As String)
            Field("Essn") = value
        End Set
    End Property

    Public Property HireDate As Date
        Get
            Return Date.ParseExact(CStr(Field("HireDate")), "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
        End Get
        Set(value As Date)
            Field("HireDate") = value.ToString("yyyyMMdd")
        End Set
    End Property

    Public ReadOnly Property HireDateString As String
        Get
            Return HireDate.ToString("yyyyMMdd")
        End Get
    End Property

    Public Property TermDate As Date
        Get
            Return Date.ParseExact(CStr(Field("TermDate")), "yyyyMMdd", Globalization.CultureInfo.InvariantCulture)
        End Get
        Set(value As Date)
            Field("TermDate") = value
        End Set
    End Property

    Public ReadOnly Property TermDateString As String
        Get
            Return TermDate.ToString("yyyyMMdd")
        End Get
    End Property

    Public Property PayRate As Double
        Get
            Return CDbl(Field("PayRate"))
        End Get
        Set(value As Double)
            Field("PayRate") = value
        End Set
    End Property

    Public Property Withholding As Double
        Get
            Return CDbl(Field("Withholding"))
        End Get
        Set(value As Double)
            Field("Withholding") = value
        End Set
    End Property

    Public Overrides Sub UpdateCurrentRow()
        ExecuteNonQuery("UPDATE SE_EMPLOYMENT SET Essn='{0}', HireDate='{1}', TermDate='{2}', PayRate={3}, Withholding={4} " &
                        "WHERE Essn='{5}' AND HireDate='{6}'".FormatWith(Essn, _EssnOriginal, HireDateString, TermDateString, PayRate, Withholding, _EssnOriginal, _HireDateString))
    End Sub

    Public Sub GetEmployment(ByVal pEssn As String, ByVal pHireDate As String)
        ExecuteQuery("SELECT * FROM SE_EMPLOYMENT WHERE Essn='{0}' AND HireDate='{1}'".FormatWith(pEssn, pHireDate))
    End Sub

    Public Overrides Function TableName() As String
        Return "SE_EMPLOYMENT"
    End Function
End Class
