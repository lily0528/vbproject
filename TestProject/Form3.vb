Imports System.Data.OleDb
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form3
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim connection As OleDbConnection = New OleDbConnection

    Dim a As New OpenFileDialog
    Dim IfCheck As Boolean


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FirstName.Text = "" Or LastName.Text = "" Or EmailAddress.Text = "" Or Address.Text = "" Or Phone.Text = "" Then
            MsgBox("Please fill those details!")
        End If

        Dim ms As New MemoryStream()
        Dim Arrimage() As Byte
        If (Picture.Image IsNot Nothing) Then
            Picture.Image.Save(ms, Picture.Image.RawFormat)
            Arrimage = ms.GetBuffer
            ms.Close()

        End If
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        Dim str As String
        str = "insert into Contacts(FirstName,LastName,NickName,BirthDay,Gender,Email,Phone,Address,Photo) values(?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, connection)
        cmd.Parameters.Add(New OleDbParameter("FirstName", FirstName.Text))
        cmd.Parameters.Add(New OleDbParameter("LastName", LastName.Text))
        cmd.Parameters.Add(New OleDbParameter("NickName", NickName.Text))
        cmd.Parameters.Add(New OleDbParameter("BirthDay", DateTimePicker1.Value))
        cmd.Parameters.Add(New OleDbParameter("Gender", IfCheck))
        cmd.Parameters.Add(New OleDbParameter("Email", EmailAddress.Text))
        cmd.Parameters.Add(New OleDbParameter("Phone", Phone.Text))
        cmd.Parameters.Add(New OleDbParameter("Address", Address.Text))
        cmd.Parameters.Add(New OleDbParameter("Photo", IIf(Picture.Image IsNot Nothing, Arrimage, DBNull.Value)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            connection.Close()
            Form2.ContactsBindingSource.EndEdit()



            'Clear text
            FirstName.Clear()
            LastName.Clear()
            NickName.Clear()
            EmailAddress.Clear()
            Phone.Clear()
            Address.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form2.Show()
    End Sub

    'Gender choice
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            IfCheck = 1
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            IfCheck = 0
        End If
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        connection.Close()
        Form2.Show()

    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim piclocation As String
            a.Filter = Nothing
            piclocation = a.FileName
            a.ShowDialog()
            Picture.Image = Image.FromFile(a.FileName)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    'Validate the phone field
    Private Sub Phone_Leave(sender As Object, e As EventArgs) Handles Phone.Leave
        If Not IsPhoneNumberValid(Phone.Text) Then
            MessageBox.Show("Please Enter Phone Number!")
            Phone.Clear()
            Phone.Focus()
        End If
    End Sub

    Private Function IsPhoneNumberValid(ByVal Number As String) As Boolean
        Dim PhoneValid As Boolean
        Dim PhoneNumber As String = "^[1-9]\d{2}-[1-9]\d{2}-\d{4}$"
        Dim ChekPhone As New Regex(PhoneNumber)
        If Not String.IsNullOrEmpty(Number) Then

            PhoneValid = ChekPhone.IsMatch(Number)
        Else
            PhoneValid = False

        End If

        Return PhoneValid
    End Function

    'Validate the Email Address
    Private Sub EmailAddress_Leave(sender As Object, e As EventArgs) Handles EmailAddress.Leave
        Dim Email As Boolean
        Email = Regex.IsMatch(EmailAddress.Text, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$", RegexOptions.IgnoreCase)
        If Not Email Then
            MsgBox("E-mail address is invalid!")
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
        dataFile = "D:\InterViewTest\TestProject\TestProject\UserManagement.mdb"
        connString = provider & dataFile
        connection.ConnectionString = connString
        connection.Open()
    End Sub

    'Validate the Age
    Private Sub DateTimePicker1_Leave(sender As Object, e As EventArgs) Handles DateTimePicker1.Leave
        Dim thisYear As Integer = DateTime.Now.Year
        Dim yourYear As Integer = DateTimePicker1.Value.Year
        If thisYear - yourYear < 18 Then
            MessageBox.Show("Age range must be 18 and above!")
        End If
    End Sub
End Class