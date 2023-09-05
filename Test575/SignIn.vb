Public Class SignIn
    Public pageToOpen As String

    Private Sub submitCredentialsButton_Click(sender As Object, e As EventArgs) Handles submitCredentialsButton.Click
        Const settingsFormName As String = "settings"
        Dim correctUsername = My.Settings.EmployeeManagerUsername
        Dim correctPassword = My.Settings.EmployeeManagerPassword

        'Checking Credentials and opening appropriate page
        If usernameTextbox.Text = correctUsername And passwordTextbox.Text = correctPassword Then
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
            MessageBox.Show(passwordTextbox.Text)
        End If
    End Sub

    Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class