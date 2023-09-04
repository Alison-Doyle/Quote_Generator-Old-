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
        For i As Integer = Application.OpenForms.Count - 1 To 0 Step -1
            Dim form = Application.OpenForms(i)
            For j As Integer = 0 To formNames.Count - 1 Step +1
                If form.Name.ToString() = formNames(j) Then
                    form.Close()
                End If
            Next
        Next
    End Sub

    Public Sub closeProgram()

    End Sub
End Class
