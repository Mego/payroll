Imports MySql.Data.MySqlClient
Imports System.Net

Public Class MySQLConnector
    Implements IDisposable

    Private _conn As MySqlConnection

    Public Sub New()
        _conn = New MySqlConnection
        _conn.ConnectionString = "Server={0};Uid={1};Pwd={2};Database={3}".FormatWith(My.Settings.DB_HOST, My.Settings.DB_USER, My.Settings.DB_PASS, My.Settings.DB_NAME)
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
                If _conn.State = ConnectionState.Open Then
                    _conn.Close()
                End If
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
