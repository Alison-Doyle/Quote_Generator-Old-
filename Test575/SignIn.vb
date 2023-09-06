Public Class SignIn
    Public pageToOpen As String

    Private Sub submitCredentialsButton_Click(sender As Object, e As EventArgs) Handles submitCredentialsButton.Click
        Const settingsFormName As String = "settings"
        Dim correctUsername = My.Settings.EmployeeManagerUsername
        Dim correctPassword = My.Settings.EmployeeManagerPassword

        'Checking Credentials and opening appropriate page
        If usernameTextbox.Text = correctUsername Then
            If passwordTextbox.Text = correctPassword Then
                If pageToOpen = settingsFormName Then
                    Dim settingsForm = New Settings()
                    settingsForm.Show()
                    Me.Close()
                Else
                    Dim employeeManagerForm = New EmployeeManagement()
                    employeeManagerForm.Show()
                    Me.Close()
                End If
            Else
                MessageBox.Show("Incorrect password")
            End If
        Else
            MessageBox.Show("Incorrect username")
        End If
    End Sub
End Class