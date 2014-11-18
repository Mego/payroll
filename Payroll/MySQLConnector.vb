Imports MySql.Data.MySqlClient

Public Class MySQLConnector
    Implements IDisposable

    Private _conn As MySqlConnection

    Public Sub New()
        _conn = New MySqlConnection
        _conn.ConnectionString = "server={0};user id={1};password={2};database={3}".FormatWith(My.Settings.DB_HOST, My.Settings.DB_USER, My.Settings.DB_PASS, My.Settings.DB_NAME)
        _conn.Open()
    End Sub

    Public ReadOnly Property Connection As MySqlConnection
        Get
            Return _conn
        End Get
    End Property

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                _conn.Close()
                _conn.Dispose()
                _conn = Nothing
            End If
        End If
        Me.disposedValue = True
    End Sub

    ' override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
