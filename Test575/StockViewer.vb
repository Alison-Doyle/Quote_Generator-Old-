Imports System.IO
Imports MySql.Data.MySqlClient
Public Class StockViewer
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=Localhost;Userid=root;password=Stiefel123;database=inventory"

        Try
            MysqlConn.Open()
            Dim cmd As New MySqlCommand("Select `ID`, `VID`, `Supplier`, `Description`, `Quantity`, `Cost` from test.`new_table`")
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable

            adapter.SelectCommand.Connection = MysqlConn
            adapter.Fill(table)

            DataGridView1.DataSource = table



        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub StockViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class