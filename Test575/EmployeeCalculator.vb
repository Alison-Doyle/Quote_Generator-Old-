'Option Strict On
Imports MySql.Data.MySqlClient
Public Class EmployeeCalculator
    Dim MysqlConn As MySqlConnection
    Dim jobTypesNames() As String = {
        "Design",
        "Programming",
        "Assembly",
        "Testing",
        "Documentation",
        "Site Installation"}
    Dim jobTypesCost() As Double = {0, 0, 0, 0, 0, 0}

    Private Sub EmployeeCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fetchEmployeesFromDatabase()
    End Sub

    Private Sub EmployeeCalculator_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        addEmployeeToFinalQuote()
    End Sub

    Private Sub Emp_Viewer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Emp_Viewer.CellContentClick
        populateTextboxesViaCellClick(e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        addEmployeeToJob()
    End Sub

    Sub fetchEmployeesFromDatabase()
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

    Sub addEmployeeToJob()
        ' Variables
        Dim employeeName As String
        Dim position As String
        Dim estimatedHours As Integer
        Dim hourlyPay As Double

        Try
            ' Get user's values
            employeeName = Emp_Name.Text
            position = Emp_Position.Text
            If String.IsNullOrWhiteSpace(Emp_Hours.Text) Then
                Throw New ArithmeticException
            Else
                Integer.TryParse(Emp_Hours.Text, estimatedHours)
            End If

            For i As Integer = 0 To Emp_Viewer.Rows.Count - 1 Step +1
                If Emp_Viewer.Rows(i).Cells(0).Value = employeeName Then
                    Double.TryParse(Emp_Viewer.Rows(i).Cells(2).Value, hourlyPay)
                End If
            Next

            ' Calculate rough total pay
            Dim totalPay = estimatedHours * hourlyPay

            ' Adding pay to jobs array
            For i As Integer = 0 To jobTypesNames.Count - 1 Step +1
                If jobTypesNames(i) = position Then
                    jobTypesCost(i) += totalPay
                End If
            Next

            ' Populate Job Table
            Job_Viewer.Rows.Add(employeeName, position, totalPay)
        Catch arithmticException As ArithmeticException
            MessageBox.Show("Please make sure hours and hourly wage are appropriately filled in. They should not be null or contain any letters or special characters")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub addEmployeeToFinalQuote()
        'Cycle through all job types and if they have people in them/are greater than 0, check if they already exist
        'in the cost breakdown. If they don't, add them else change value
        For i As Integer = 0 To jobTypesNames.Length - 1 Step +1
            If jobTypesCost(i) > 0 Then
                Dim jobIndex = Nothing
                For j As Integer = 0 To QuoteGenerator4.Proj_CostBreakDown.Rows.Count - 1 Step +1
                    If QuoteGenerator4.Proj_CostBreakDown.Rows(j).Cells(0).Value = jobTypesNames(i) Then
                        jobIndex = j
                    End If
                Next

                If jobIndex = Nothing Then
                    QuoteGenerator4.Proj_CostBreakDown.Rows.Add(jobTypesNames(i), jobTypesCost(i))
                Else
                    QuoteGenerator4.Proj_CostBreakDown.Rows(jobIndex).Cells(1).Value = jobTypesCost(i)
                End If
            End If
        Next
    End Sub

    Sub populateTextboxesViaCellClick(e)
        If e.RowIndex >= 0 Then
            Emp_Name.Text = Emp_Viewer.Rows(e.RowIndex).Cells(0).Value
        Else
            MessageBox.Show("Please select a valid cell")
        End If
    End Sub
End Class