Imports System.Data.OleDb
Imports System.Data
Public Class Form3
    Dim connection As New OleDbConnection(My.Settings.UserManagementConnectionString)

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'connection.Open()
        'Dim cmd As New OleDbCommand("select * from Contacts", connection)
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        connection.Close()

    End Sub

    Private Sub Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Phone.KeyPress
        If Asc(e.KeyChar) <> 10 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If connection.State = ConnectionState.Closed Then
            connection.Open()

        End If

        Dim cmd As New OleDbCommand("select * from Contacts", connection)
        If FirstName.Text = "" Or LastName.Text = "" Or Email.Text = "" Or Address.Text = "" Or Phone.Text = "" Then
            MsgBox("Please fill those details!")
        End If
        cmd.CommandText = "insert into Contacts(FirstName,LastName,NickName,Email,Phone,Address) values('" & FirstName.Text & "','" & LastName.Text & "','" & NickName.Text & "', '" & Email.Text & "', '" & Phone.Text & "', '" & Address.Text & "')"
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        connection.Close()
        MsgBox("Data Inserted!", MsgBoxStyle.Information)


    End Sub
End Class