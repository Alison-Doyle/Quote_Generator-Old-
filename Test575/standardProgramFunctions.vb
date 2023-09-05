Imports System.Windows

Public Class standardProgramFunctions
    Public Shared Sub returnToMainMenu()
        Dim menuForm = MainMenu
        menuForm.Show()
        endQuoteCreation()
    End Sub

    Public Shared Sub endQuoteCreation()
        Dim formNames As New List(Of String)({"QuoteGen", "QuoteGenerator2", "QuoteGenerator3", "QuoteGenerator4", "QuoteGen5"})
        Dim programForms As FormCollection = My.Application.OpenForms

        'To close any forms related to creating the quote, cycle through all of the open forms and close them if their
        'name is in the array above. Working backwards through open forms to close children before parents and the
        'collection doesn't byte
        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            Dim form = My.Application.OpenForms(i)
            For j As Integer = 0 To formNames.Count - 1 Step +1
                If form.Name.ToString() = formNames(j) Then
                    form.Close()
                End If
            Next
        Next
    End Sub

    Public Shared Sub closeProgram(e As FormClosingEventArgs, applicationClosing As Boolean)
        Const closingDialogBoxCaption As String = "Closing Application"
        Const closingDialogBoxMessage As String = "Are you sure you want to close the application? All unsaved data will be lost"

        MessageBox.Show(e.CloseReason)

        'If only the quote generator section is getting closed, there is no need to end the entire application
        If applicationClosing = True Then
            'Checking if user wants to definitly end the application
            Select Case MessageBox.Show(closingDialogBoxMessage, closingDialogBoxCaption, MessageBoxButtons.OKCancel)
                Case MessageBoxResult.OK
                    'Closing all open forms
                    Dim programForms As FormCollection = My.Application.OpenForms
                    'For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
                    '    Dim currentOpenForm = My.Application.OpenForms(i)
                    '    currentOpenForm.Close()
                    'Next
                    Forms.Application.Exit()
                Case MessageBoxResult.Cancel
                    e.Cancel = True
            End Select
        End If
    End Sub
End Class
