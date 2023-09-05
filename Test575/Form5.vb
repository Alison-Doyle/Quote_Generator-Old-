Imports Excel = Microsoft.Office.Interop.Excel
Imports Test575.standardProgramFunctions

Public Class QuoteGen5
    Public quoteLocation As String
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click 'Back to Main Menu
        returnToMainMenu()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'Previous Page
        Dim lastPage = QuoteGenerator4
        lastPage.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'insert training desc
        insertSection5()
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

            excelApp.Range(trainingAndCourcesCell).Vlaue = projectTrainingRequirementsandCources

            MessageBox.Show("Section 5 filled in")
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
End Class