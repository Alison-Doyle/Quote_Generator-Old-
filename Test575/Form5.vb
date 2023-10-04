Imports Excel = Microsoft.Office.Interop.Excel
Imports Test575.standardProgramFunctions
Imports System.Windows

Public Class QuoteGen5
    Public quoteLocation As String
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True
    End Sub

    Private Sub Form5_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        If e.CloseReason = CloseReason.UserClosing Then
            endQuoteCreation(e)
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click 'Back to Main Menu
        returnToMainMenu()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'Previous Page
        Dim lastPage = QuoteGenerator4
        lastPage.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'insert training desc
        insertSection5()
        'MessageBox.Show($"File Path: {quoteLocation}")
    End Sub

    Sub insertSection5()
        'Simplifying winform names
        Dim projectTrainingRequirementsandCources As String = Proj_Training.Text

        'Excel Variables
        Dim excelApp As New Excel.Application
        Const trainingAndCourcesCell = "DX7"

        Try
            'Opening Excel and file
            excelApp.Visible = False
            excelApp.Workbooks.Open(quoteLocation)
            excelApp.Sheets("Sheet1").activate()

            excelApp.Range(trainingAndCourcesCell).Value = projectTrainingRequirementsandCources

            MessageBox.Show("Section 5 filled in")

            OpenQuote()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Try
                excelApp.ActiveWorkbook.Save()
            Catch ex As Exception
            End Try

            'Close Excel Application
            excelApp.Workbooks.Close()
            excelApp.Quit()

            'Must clean up twice to ensure everything is disposed of
            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub

    Sub OpenQuote()
        Const DialogBoxCaption As String = "Finishing Quote"
        Const DialogBoxMessage As String = "You have just finished populating your quote. Would you like to open excel and view your quote?"

        Select Case MessageBox.Show(DialogBoxMessage, DialogBoxCaption, MessageBoxButtons.OKCancel)
            Case MessageBoxResult.OK
                MessageBox.Show("Open Excel")
            Case MessageBoxResult.Cancel
                MessageBox.Show("Do Nothing")
        End Select
    End Sub
End Class