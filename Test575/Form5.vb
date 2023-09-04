Imports Excel = Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient
Imports Test575.standardProgramFunctions

Public Class QuoteGen5
    Dim LoadDir As String
    Dim MyExcel As New Excel.Application
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim table As New DataTable("Table")
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True
        LoadDir = Environment.CurrentDirectory & "\"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click 'Back to Main Menu
        returnToMainMenu()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'Previous Page
        QuoteGenerator4.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'insert training desc

        MyExcel.Workbooks.Open("C:\Users\Admin\Desktop\" & QuoteGen.Doc_FileName.Text)
        MyExcel.Sheets("Sheet1").activate()

        MyExcel.Range("DX7").Activate()
        MyExcel.Range("DX7").Value = Proj_Training.Text

        MyExcel.ActiveWorkbook.Close(SaveChanges:=True)
        MyExcel.Quit()

        Runtime.InteropServices.Marshal.ReleaseComObject(MyExcel.Workbooks)

        MessageBox.Show("Quote Updated")
    End Sub
End Class