Imports MySql.Data.MySqlClient
Public Class EmployeeManagement
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click 'Insert new employees into database
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=Localhost;Userid=root;password=Stiefel123;database=test_quotes"

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO `test_quotes`.`employeewages` (Name, Position, HourlyWage, Notes) VALUES ('" & Emp_Name.Text & "', '" & Emp_Position.Text & "', '" & Emp_Wage.Text & "', '" & Emp_Notes.Text & "')"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            COMMAND.ExecuteNonQuery()

            MessageBox.Show("Data Saved")
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'Employee Search
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=Localhost;Userid=root;password=Stiefel123;database=test_quotes"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select * From test_quotes.employeewages where `Name`='" & Update_Name.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)

            READER = COMMAND.ExecuteReader
            While READER.Read
                Update_Position.Text = READER.GetString("Position")
                Update_Wage.Text = READER.GetString("HourlyWage")
                Update_Notes.Text = READER.GetString("Notes")
            End While

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'Update employee data
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=Localhost;Userid=root;password=Stiefel123;database=test_quotes"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update test_quotes.employeewages set `Name`= '" & Update_Name.Text & "', Position='" & Update_Position.Text & "', HourlyWage='" & Update_Wage.Text & "',Notes= '" & Update_Notes.Text & "' Where `Name`= '" & Update_Name.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Employee Records Updated")

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'Remove Employee from DataBase
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=Localhost;Userid=root;password=Stiefel123;database=test_quotes"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "DELETE FROM `test_quotes`.`employeewages` WHERE (`Name` = '" & Update_Name.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Employee Records Deleted")

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Refresh dataviewer w/ employee data
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=Localhost;Userid=root;password=Stiefel123;database=test_quotes"

        Try
            MysqlConn.Open()
            Dim cmd As New MySqlCommand("Select `Name`, `Position`, `HourlyWage`, `Notes` from `test_quotes`.`employeewages`")
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable

            adapter.SelectCommand.Connection = MysqlConn
            adapter.Fill(table)

            Emp_Viewer.DataSource = table



        Catch myerror As MySqlException
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click 'Back Button
        Dim frm = New MainMenu
        frm.Show()
        Me.Hide()
    End Sub
End Class