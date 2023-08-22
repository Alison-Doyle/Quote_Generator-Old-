'Option Strict On
Imports MySql.Data.MySqlClient
Public Class EmployeeCalculator
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Emp_Hours.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'INSERT INTO TOTALS AND DGV
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=Localhost;Userid=root;password=Stiefel123;database=test_quotes"

        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select `HourlyWage` From test_quotes.employeewages where `Name`='" & Emp_Name.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)

            READER = COMMAND.ExecuteReader
            While READER.Read
                Emp_HourlyPay.Text = READER.GetString("HourlyWage")
            End While
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Try
            Dim sal As Double
            sal = CDec(Emp_Hours.Text) * CDec(Emp_HourlyPay.Text)
            Job_Viewer.Rows.Add(Emp_Name.Text, Emp_Position.Text, sal)

            If Emp_Position.Text = "Design" Then
                Total_Design.Text += sal

            ElseIf Emp_Position.Text = "Programming" Then
                Total_Programming.Text += sal

            ElseIf Emp_Position.Text = "Assembly" Then
                Total_Assembly.Text += sal

            ElseIf Emp_Position.Text = "Testing" Then
                Total_Testing.Text += sal

            ElseIf Emp_Position.Text = "Documentation" Then
                Total_Documentation.Text += sal

            ElseIf Emp_Position.Text = "Site Installation" Then
                Total_Site.Text += sal
            End If

        Catch
            MessageBox.Show("Feilds Empty or Invalid Input")
        End Try


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs, searchString As String, columnToSearch As String)
        'Dim Total As Decimal
        'For i = 0 To Job_Viewer.Rows.Count - 1
        'i += 1
        'If Job_Viewer.Rows(i).Cells(1).Value.ToString = "Design" Then
        'Total += CDec(Job_Viewer.Rows(i).Cells(2).Value)
        'Total_Design.Text = Total.ToString
        'End If
        'Next
    End Sub

    Private Sub EmployeeCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Total_Design.Text = 0
        Total_Programming.Text = 0
        Total_Assembly.Text = 0
        Total_Testing.Text = 0
        Total_Documentation.Text = 0
        Total_Site.Text = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Total_Design.Text > 0 Then
            QuoteGenerator4.Proj_CostBreakDown.Rows.Add("Design", "", Total_Design.Text)
        End If
        If Total_Programming.Text > 0 Then
            QuoteGenerator4.Proj_CostBreakDown.Rows.Add("Programming", "", Total_Programming.Text)
        End If
        If Total_Assembly.Text > 0 Then
            QuoteGenerator4.Proj_CostBreakDown.Rows.Add("Assembly", "", Total_Assembly.Text)
        End If
        If Total_Testing.Text > 0 Then
            QuoteGenerator4.Proj_CostBreakDown.Rows.Add("Testing", "", Total_Testing.Text)
        End If
        If Total_Documentation.Text > 0 Then
            QuoteGenerator4.Proj_CostBreakDown.Rows.Add("Documentation", "", Total_Documentation.Text)
        End If
        If Total_Site.Text > 0 Then
            QuoteGenerator4.Proj_CostBreakDown.Rows.Add("Site Installation", "", Total_Site.Text)
        End If
    End Sub
End Class