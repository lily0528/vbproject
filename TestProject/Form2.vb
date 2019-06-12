Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserManagementDataSet.Contacts' table. You can move, or remove it, as needed.
        'Me.ContactsTableAdapter.Fill(Me.UserManagementDataSet.Contacts)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ContactsTableAdapter.Fill(Me.UserManagementDataSet.Contacts)
    End Sub
End Class