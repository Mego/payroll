Public Class TimeClock
    Inherits MySQLTable

    Private _EssnOriginal As String
    Private _ClockType As ClockType
    Private _ClockTime As String

    Public Sub New()
        MyBase.New()
        _EssnOriginal = ""
        _ClockType = Nothing
        _ClockTime = ""
    End Sub

    Public Property Essn As String
        Get
            Return Field("Essn").ToString
        End Get
        Set(value As String)
            Field("Essn") = value
        End Set
    End Property

    Public Property ClockType As ClockType
        Get
            Return CType(CInt(Field("ClockType")), ClockType)
        End Get
        Set(value As ClockType)
            Field("ClockType") = CInt(value)
        End Set
    End Property

    Public Property ClockTime As DateTime
        Get
            Return DateTime.ParseExact(Field("ClockTime").ToString, "yyyyMMdd HH:mm:ss", Globalization.CultureInfo.InvariantCulture)
        End Get
        Set(value As DateTime)
            Field("ClockTime") = value.ToString("yyyyMMdd HH:mm:ss")
        End Set
    End Property

    Public ReadOnly Property ClockTimeString As String
        Get
            Return ClockTime.ToString("yyyyMMdd HH:mm:ss")
        End Get
    End Property

    Public Overrides Sub LoadPrimaryKey()
        _EssnOriginal = Essn
        _ClockType = ClockType
        _ClockTime = ClockTimeString
    End Sub

    Public Overrides Sub UpdateCurrentRow()
        ExecuteNonQuery("UPDATE SE_TIMECLOCK SET Essn='{0}',ClockType={1},ClockTime='{2}' WHERE Essn='{3}'".FormatWith(Essn, ClockType, ClockTime, _EssnOriginal))
    End Sub

    Public Sub GetTimeClock(ByVal pEssn As String, ByVal pClockType As ClockType, ByVal pClockTime As String)
        ExecuteQuery("SELECT * FROM SE_TIMECLOCK SET Essn='{0}',ClockType={1},ClockTime='{2}'".FormatWith(pEssn, CInt(pClockType), pClockTime))
    End Sub

    Public Overrides Function TableName() As String
        Return "SE_TIMECLOCK"
    End Function
End Class

Public Enum ClockType
    ClockIn = 1
    ClockOut = 2
    MissedPunch = 4
End Enum
