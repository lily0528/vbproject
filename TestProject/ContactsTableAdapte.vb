Imports System.Data.OleDb

Friend Class ContactsTableAdapte
    Private v As String
    Private connection As OleDbConnection

    Public Sub New(v As String, connection As OleDbConnection)
        Me.v = v
        Me.connection = connection
    End Sub
End Class
