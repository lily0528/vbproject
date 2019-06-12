Imports System.Data.OleDb
Imports System.Data

Public Class Form1
    Dim connection As New OleDbConnection(My.Settings.UserManagementConnectionString)


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Invalid UserName or Password!", MsgBoxStyle.Critical, "Error")
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("select count(*) from UserInfor where username=? and password=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TextBox1.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = TextBox2.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If (count > 0) Then
                MsgBox("Login succeed!", MsgBoxStyle.Information)
                connection.Close()
                Form2.Show()
                Me.Hide()
            Else
                MsgBox("This account can't be found!", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        connection.Close()
    End Sub
End Class
