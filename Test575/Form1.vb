Imports System.IO

Public Class MainMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Quote Generator Button

        Dim newQuote = New QuoteGen
        newQuote.Show()
        Me.Hide()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles openSettingsButton.Click
        Dim credentialCheckForm = New SignIn()
        credentialCheckForm.pageToOpen = "settings"
        credentialCheckForm.Show()
    End Sub

    Private Sub openEmployeeManagerButton_Click(sender As Object, e As EventArgs) Handles openEmployeeManagerButton.Click
        Dim credentialCheckForm = New SignIn()
        credentialCheckForm.pageToOpen = "employeeManager"
        credentialCheckForm.Show()
    End Sub

    Private Sub MainMenu_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        standardProgramFunctions.closeProgram(e, True)
    End Sub
End Class
