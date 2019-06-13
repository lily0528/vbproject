Imports System.Data.OleDb
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel


Public Class Form2
    Dim connString As String
    Dim connection As OleDbConnection = New OleDbConnection
    Dim ExcelApp As Microsoft.Office.Interop.Excel.Application
    Dim ExcelWorkbook As Microsoft.Office.Interop.Excel.Workbook
    Dim ExcelWorksheet As Microsoft.Office.Interop.Excel.Worksheet
    Dim ItemVaue As Object = System.Reflection.Missing.Value
    Dim i As Integer
    Dim j As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserManagementDataSet2.Contacts' table. You can move, or remove it, as needed.
        'Me.ContactsTableAdapter.Fill(Me.UserManagementDataSet2.Contacts)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Me.DataGridView1.DataSource = Nothing
        'Me.ContactsTableAdapter.Fill(Me.UserManagementDataSet2.Contacts)
        'Me.DataGridView1.DataSource = Me.ContactsBindingSource
        'Me.DataGridView1.Refresh()
        'Me.ContactsTableAdapter.Fill(Me.UserManagementDataSet2.Contacts)
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim search As New ContactsTableAdapte("select * from contacts", connection)
             

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Text = "Wait Data..."
        ExcelApp = New Microsoft.Office.Interop.Excel.Application
        ExcelWorkbook = ExcelApp.Workbooks.Add(ItemVaue)
        ExcelWorksheet = ExcelWorkbook.Sheets("sheet1")
        Try
            For i = 0 To DataGridView1.RowCount - 2
                For j = 0 To DataGridView1.ColumnCount - 1
                    For k As Integer = 1 To DataGridView1.Columns.Count
                        ExcelWorksheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                        ExcelWorksheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                    Next
                Next
            Next

            ExcelWorksheet.SaveAs("D:\InterViewTest\TestProject\data\data.xlsx")
            ExcelWorkbook.Close()
            ExcelApp.Quit()
        Catch ex As Exception
            MsgBox("Some problems be occurred!", MsgBoxStyle.Critical, "Error")
        End Try

        ReleaseObject(ExcelApp)
        ReleaseObject(ExcelWorkbook)
        ReleaseObject(ExcelWorksheet)

        MsgBox("You could find this file by D:\InterViewTest\TestProject\data\data.xlsx")
        Button3.Text = "Export"
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class