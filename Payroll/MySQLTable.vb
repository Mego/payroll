Imports MySql.Data.MySqlClient

Public MustInherit Class MySQLTable
    Implements IDisposable

    Private _conn As MySQLConnector
    Private _table As DataTable
    Private _intRow As Integer

    Public Sub New()
        _conn = New MySQLConnector()
        _table = New DataTable()
        _intRow = 0
    End Sub

    Public Overridable Sub ExecuteQuery(ByVal pQuery As String)
        Close()
        Using oQuery As New MySqlCommand(pQuery, _conn.Connection)
            oQuery.ExecuteNonQuery()
            Using dta As New MySqlDataAdapter(oQuery)
                dta.Fill(_table)
                LoadPrimaryKey()
            End Using
        End Using
    End Sub

    Public Sub ExecuteNonQuery(ByVal pCmd As String)
        Close()
        Using oCmd As New MySqlCommand(pCmd, _conn.Connection)
            oCmd.ExecuteNonQuery()
        End Using
    End Sub

    Public ReadOnly Property CurrentRow As DataRow
        Get
            Return _table.Rows(_intRow)
        End Get
    End Property

    Public Function MoveNext() As Boolean
        If _intRow < _table.Rows.Count Then
            _intRow += 1
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub MoveFirst()
        _intRow = 0
    End Sub

    Public Property Field(ByVal pColumn As Integer) As Object
        Get
            Return CurrentRow(pColumn)
        End Get
        Set(value As Object)
            CurrentRow(pColumn) = value
        End Set
    End Property

    Public Property Field(ByVal pColumn As String) As Object
        Get
            Return CurrentRow(pColumn)
        End Get
        Set(value As Object)
            CurrentRow(pColumn) = value
        End Set
    End Property

    Public MustOverride Sub LoadPrimaryKey()

    Public MustOverride Sub UpdateCurrentRow()

    Public Sub Close()
        _table.Clear()
        _intRow = 0
    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                _conn.Dispose()
                _conn = Nothing
            End If
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
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
