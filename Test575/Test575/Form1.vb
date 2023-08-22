Public Class MainMenu
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Employees_Click(sender As Object, e As EventArgs) Handles Employees.Click 'Login Button
        Dim User As String
        Dim PAss As String
        User = "test"
        PAss = "test"
        If Username.Text = User And Password.Text = PAss Then
            EmployeeManagement.Show()
            Me.Hide()
        Else
            MessageBox.Show("Failure! Access Is Not Granted")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Quote Generator Button
        QuoteGen.Show()
        Me.Hide()
    End Sub
End Class
