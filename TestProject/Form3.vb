Imports System.Data.OleDb
Imports System.IO

Public Class Form3
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim connection As OleDbConnection = New OleDbConnection

    Dim er, pho As Integer
    Dim Photos1() As Byte

    Private Sub Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Phone.KeyPress
        If Asc(e.KeyChar) <> 10 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FirstName.Text = "" Or LastName.Text = "" Or Email.Text = "" Or Address.Text = "" Or Phone.Text = "" Then
            MsgBox("Please fill those details!")
        End If


        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
        dataFile = "D:\InterViewTest\TestProject\TestProject\UserManagement.mdb"
        connString = provider & dataFile
        connection.ConnectionString = connString
        connection.Open()
        Dim str As String
        str = "insert into Contacts(FirstName,LastName,NickName,BirthDay,Email,Phone,Address) values(?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, connection)
        cmd.Parameters.Add(New OleDbParameter("FirstName", FirstName.Text))
        cmd.Parameters.Add(New OleDbParameter("LastName", LastName.Text))
        cmd.Parameters.Add(New OleDbParameter("NickName", NickName.Text))
        cmd.Parameters.Add(New OleDbParameter("BirthDay", DateTimePicker1.Value))
        cmd.Parameters.Add(New OleDbParameter("Email", Email.Text))
        cmd.Parameters.Add(New OleDbParameter("Phone", Phone.Text))
        cmd.Parameters.Add(New OleDbParameter("Address", Address.Text))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            connection.Close()

            FirstName.Clear()
            LastName.Clear()
            NickName.Clear()
            Email.Clear()
            Phone.Clear()
            Address.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        connection.Close()

    End Sub

    Private Sub Button3_Click(Bysender As Object, e As EventArgs) Handles Button3.Click
        'If OpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then

        'End If
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pho = 0
    End Sub
End Class