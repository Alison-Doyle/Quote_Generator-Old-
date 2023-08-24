Public Class MainMenu
    Private Sub Employees_Click(sender As Object, e As EventArgs) Handles Employees.Click 'Login Button
        Dim allCredentialsCorrect As Boolean = checkCredentials(Username.Text, Password.Text)

        If allCredentialsCorrect = True Then
            Dim employeeManagement As New EmployeeManagement
            employeeManagement.Show()
            Me.Hide()
        Else
            MessageBox.Show("Credentials Incorrect")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Quote Generator Button
        If Application.OpenForms().OfType(Of QuoteGen).Any Then
            Dim quote = QuoteGen
            quote.Show()
            Me.Hide()
        Else
            Dim newQuote = New QuoteGen
            newQuote.Show()
            Me.Hide()
        End If
    End Sub

    Function checkCredentials(enteredUsername, enteredPassword)
        Dim correctUsername As String = My.Settings.EmployeeManagerUsername
        Dim correctPassword As String = My.Settings.EmployeeManagerPassword
        Dim allCredentialsCorrect As Boolean

        If enteredUsername = correctUsername And enteredPassword = correctPassword Then
            allCredentialsCorrect = True
        Else
            allCredentialsCorrect = False
        End If

        Return allCredentialsCorrect
    End Function

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
