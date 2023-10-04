Imports Excel = Microsoft.Office.Interop.Excel
Imports Test575.standardProgramFunctions

Public Class QuoteGenerator4
    Public quoteLocation As String
    Public componentsTotal As Double
    Dim i As Integer = 0
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click 'Back to MainMenu
        returnToMainMenu()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'Back Button (Top)
        goToLastPage()
    End Sub

    Private Sub QuoteGenerator4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True
    End Sub

    Private Sub QuoteGenerator4_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        If e.CloseReason = CloseReason.UserClosing Then
            endQuoteCreation(e)
        End If
    End Sub

    Private Sub QuoteGenerator4_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        fillInComponentsTotal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        returnToMainMenu()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click 'Next Page (Top)
        goToNextPage()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'Next Page (Bottom)
        goToNextPage()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Back Button (Button)
        goToLastPage()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click   'OPENS EMPLOYEE CALCULATOR
        EmployeeCalculator.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click   'OPENS EXPENCES CALCULATOR
        ExpencesCalculator.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click 'ADDS WEEK AND ACTIVITY DESC TO ACTIVITY VIEWER
        Me.Proj_Activate.Rows.Add(Proj_Week.Text, Proj_ActivityDesc.Text)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click 'INSERT BUTTON @ CYTTOM OF PAGE
        populateSection5()
    End Sub

    Sub goToLastPage()
        Dim page4 = QuoteGenerator3
        page4.quoteLocation = quoteLocation
        page4.Show()
        Me.Hide()
    End Sub

    Sub goToNextPage()
        Dim page6 = QuoteGen5
        page6.quoteLocation = quoteLocation
        page6.Show()
        Me.Hide()
    End Sub

    Sub fillInComponentsTotal()
        Try
            Dim componentRowHeader As String = "Cost of Components"
            Dim componentsIndex = Nothing

            For i As Integer = 0 To Proj_CostBreakDown.Rows.Count - 1 Step +1
                If Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString() = componentRowHeader Then
                    componentsIndex = i
                End If
            Next

            Dim x As Integer
            If Integer.TryParse(componentsIndex, x) Then
                Proj_CostBreakDown.Rows(componentsIndex).Cells(1).Value = Format(componentsTotal, "N2")
            Else
                Proj_CostBreakDown.Rows.Add(componentRowHeader, Format(componentsTotal, "N2"))
            End If
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub

    Sub populateSection5()
        'Excel Variables
        Dim excelApp As New Excel.Application
        Dim projectsSchedualWeekColumn = "CW"
        Dim projectsSchedualActivityColumn = "CX"
        Dim costBreakdownDescriptionColumn = "DF"
        Dim costBreakdownResourcesColumn = "DJ"
        Dim costBreakdownCostColumn = "DL"

        Try
            'Open Excel + File
            excelApp.Visible = False
            excelApp.Workbooks.Open(quoteLocation)
            excelApp.Sheets("Sheet1").activate()

            'Add Projects Schedule Info
            For i As Integer = 0 To Proj_Activate.Rows.Count - 1 Step +1
                Dim currentRow = 8 + i
                excelApp.Range(projectsSchedualWeekColumn + currentRow.ToString()).Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                excelApp.Range(projectsSchedualActivityColumn + currentRow.ToString()).Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
            Next

            'Add Project Cost Breakdown
            For i As Integer = 0 To Proj_CostBreakDown.Rows.Count - 1 Step +1
                Dim currentRow = 8 + i
                excelApp.Range(costBreakdownDescriptionColumn + currentRow.ToString()).Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                excelApp.Range(costBreakdownCostColumn + currentRow.ToString()).Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
            Next
        Catch ex As Exception
            MessageBox.Show("Error" + ex.Message)
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