Imports MySql.Data.MySqlClient
Public Class StockViewer
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        populateStockViewer()
    End Sub

    Private Sub StockViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateStockViewer()
    End Sub

    Sub populateStockViewer()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=Localhost;Userid=root;password=" & My.Settings.DatabasePassword & ";database=" & My.Settings.DatabaseName

        Try
            MysqlConn.Open()

            Dim command As New MySqlCommand("Select `ID`, `VID`, `Supplier`, `Description`, `Cost` from `" & My.Settings.InventoryTableName & "`")
            Dim adapter As New MySqlDataAdapter(command)
            Dim inventoryTable As New DataTable

            adapter.SelectCommand.Connection = MysqlConn
            adapter.Fill(inventoryTable)

            DataGridView1.DataSource = inventoryTable
        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            MysqlConn.Close()
            MysqlConn.Dispose()
        End Try
    End Sub
End Class