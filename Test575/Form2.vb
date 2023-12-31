﻿Imports MySql.Data.MySqlClient
Public Class EmployeeManagement
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click 'Insert new employees into database
        'Making sure new employee data is valid before adding records
        Dim hourlyWage As Double

        If (Double.TryParse(Emp_Wage.Text, hourlyWage)) Then
            addNewEmployee(Emp_Name.Text, Emp_Position.Text, hourlyWage, Emp_Notes.Text)
        Else
            MessageBox.Show("Unable to add employee. Hourly wage is not in correct format.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'Employee Search
        searchEmployees(Update_Name.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'Update employee data
        'Making sure new employee data is valid before updating records
        Dim newHourlyWage As Double

        If (Double.TryParse(Update_Wage.Text, newHourlyWage)) Then
            updateEmployee(Update_Name.Text, Update_Position.Text, newHourlyWage, Update_Notes.Text)
        Else
            MessageBox.Show("Unable to update employee. Hourly wage is not in correct format.")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'Remove Employee from DataBase
        deleteEmployee(Update_Name.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Refresh data viewer w/ employee data
        populateEmployeeViewer()
    End Sub

    Private Sub EmployeeManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateEmployeeViewer()
    End Sub

    Private Sub EmployeeManagement_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        MainMenu.BringToFront()
    End Sub

    Sub populateEmployeeViewer()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=Localhost;Userid=root;password=" & My.Settings.DatabasePassword & ";database=" & My.Settings.DatabaseName

        Try
            MysqlConn.Open()

            Dim command As New MySqlCommand("Select `Name`, `Position`, `HourlyWage`, `Notes` from `" & My.Settings.EmployeeTableName & "`")
            Dim adapter As New MySqlDataAdapter(command)
            Dim employeeTableData As New DataTable

            adapter.SelectCommand.Connection = MysqlConn
            adapter.Fill(employeeTableData)

            Emp_Viewer.DataSource = employeeTableData
        Catch ex As MySqlException
            MessageBox.Show("Error" & ex.Message)
        Finally
            MysqlConn.Close()
            MysqlConn.Dispose()
        End Try
    End Sub

    Sub addNewEmployee(name, position, hourlyWage, notes)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=Localhost;Userid=root;password=" & My.Settings.DatabasePassword & ";database=" & My.Settings.DatabaseName

        Try
            MysqlConn.Open()
            Dim query As String = "INSERT INTO `" & My.Settings.EmployeeTableName & "` (Name, Position, HourlyWage, Notes) VALUES ('" & name & "', '" & position & "', '" & hourlyWage & "', '" & notes & "')"

            Dim command As New MySqlCommand(query, MysqlConn)
            command.ExecuteNonQuery()

            populateEmployeeViewer()
            MessageBox.Show("Employee Added")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Close()
            MysqlConn.Dispose()

        End Try
    End Sub

    Sub updateEmployee(employeeName, position, hourlyWage, notes)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=Localhost;Userid=root;password=" & My.Settings.DatabasePassword & ";database=" & My.Settings.DatabaseName

        Dim reader As MySqlDataReader

        Try
            MysqlConn.Open()

            Dim query As String = "update " & My.Settings.EmployeeTableName & " set `Name`= '" & employeeName & "', Position='" & position & "', HourlyWage='" & hourlyWage & "',Notes= '" & notes & "' Where `Name`= '" & employeeName & "'"
            Dim command As New MySqlCommand(query, MysqlConn)
            reader = command.ExecuteReader

            populateEmployeeViewer()
            MessageBox.Show("Employee Records Updated")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MysqlConn.Close()
            MysqlConn.Dispose()
        End Try
    End Sub

    Sub deleteEmployee(employeeName)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=Localhost;Userid=root;password=" & My.Settings.DatabasePassword & ";database=" & My.Settings.DatabaseName

        Dim reader As MySqlDataReader

        Try
            MysqlConn.Open()

            Dim query As String = "DELETE FROM `" & My.Settings.EmployeeTableName & "` WHERE (`Name` = '" & employeeName & "')"
            Dim command As New MySqlCommand(query, MysqlConn)
            reader = command.ExecuteReader

            populateEmployeeViewer()
            MessageBox.Show("Employee records deleted")
        Catch ex As MySqlException
            MessageBox.Show("Error" & ex.Message)
        Finally
            MysqlConn.Close()
            MysqlConn.Dispose()
        End Try
    End Sub

    Sub searchEmployees(employeeName)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=Localhost;Userid=root;password=" & My.Settings.DatabasePassword & ";database=" & My.Settings.DatabaseName

        Dim reader As MySqlDataReader

        Try
            MysqlConn.Open()

            Dim query As String = "Select * From " & My.Settings.EmployeeTableName & " where (`Name` = '" & employeeName & "')"
            Dim command As New MySqlCommand(query, MysqlConn)
            reader = command.ExecuteReader

            While reader.Read
                Update_Position.Text = reader.GetString("Position")
                Update_Wage.Text = reader.GetString("HourlyWage")
                Update_Notes.Text = reader.GetString("Notes")
            End While
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MysqlConn.Close()
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Emp_Viewer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Emp_Viewer.CellClick
        'Making sure cell clicked is not a header cell
        If e.RowIndex >= 0 Then
            Update_Name.Text = Emp_Viewer.Rows(e.RowIndex).Cells(0).Value
            Update_Position.Text = Emp_Viewer.Rows(e.RowIndex).Cells(1).Value
            Update_Wage.Text = Emp_Viewer.Rows(e.RowIndex).Cells(2).Value
            Update_Notes.Text = Emp_Viewer.Rows(e.RowIndex).Cells(3).Value
        Else
            MessageBox.Show("Please select a valid cell")
        End If
    End Sub

    Private Sub Emp_Viewer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Emp_Viewer.CellContentClick

    End Sub
End Class