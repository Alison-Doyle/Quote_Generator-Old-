
Imports Excel = Microsoft.Office.Interop.Excel
Imports Test575.standardProgramFunctions

Public Class QuoteGenerator2
    Public quoteLocation As String
    Private Sub QuoteGenerator2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True
    End Sub
    Private Sub QuoteGenerator2_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        If e.CloseReason = CloseReason.UserClosing Then
            endQuoteCreation(e)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Previous Page Button
        goToLastPage()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'Next Page Button
        goToNextPage()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click 'Menu Button
        returnToMainMenu()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click ' Add to DGV
        Me.Proj_FunctView.Rows.Add(Proj_Function.Text, Proj_FunctQuantity.Text, Proj_FunctDesc.Text)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click 'Next Page(top button)
        goToNextPage()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click 'Previous Page (top)
        goToLastPage()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click 'Main Menu (top)
        returnToMainMenu()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click 'INSERT BUTTON @ BOTTOM OF FORM
        populateDocumentSection3()
    End Sub

    Sub goToLastPage()
        Dim page1 = QuoteGen
        page1.quoteLocation = quoteLocation
        QuoteGen.Show()
        Me.Hide()
    End Sub

    Sub goToNextPage()
        Dim page3 = QuoteGenerator3
        page3.quoteLocation = quoteLocation
        QuoteGenerator3.Show()
        Me.Hide()
    End Sub

    Sub populateDocumentSection3()
        'Simplifiying variable names for readability
        Dim projectDescription As String = Proj_Desc.Text
        Dim imageFilePath As String = Proj_DiagramPath.Text

        Dim machineFunctions As New List(Of Machine)

        'Excel Variables
        Dim excelApp As New Excel.Application
        Const projectDescriptionCell = "AL6"
        Const maxImageWidth = 574 * 0.6 '(Ideal width of image in px) * (px to pt ratio)

        Try
            'Opening Excel and file
            excelApp.Visible = False
            excelApp.Workbooks.Open(quoteLocation)
            excelApp.Sheets("Sheet1").activate()

            'Filling in section 3
            excelApp.Range(projectDescriptionCell).Activate()
            excelApp.Range(projectDescriptionCell).Value = projectDescription

            'Add image to quote
            Dim bmp As New Bitmap(imageFilePath)
            Dim imageWidth As Double = bmp.Width
            Dim imageHeight As Double = bmp.Height
            Dim adjustedHeight As Double = imageHeight * (maxImageWidth / imageWidth)
            excelApp.ActiveSheet.Shapes.AddPicture(imageFilePath, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 2262, 76, maxImageWidth, adjustedHeight) 'Last 4 digits: Disatnce from Left(px), Distance from Top(px), Width, Height

            'Fetch Data from data grid view
            For i As Integer = 0 To Proj_FunctView.Rows.Count - 1 Step +1
                machineFunctions.Add(New Machine(Proj_FunctView.Rows(i).Cells(2).Value.ToString(), Proj_FunctView.Rows(i).Cells(0).Value.ToString(), Proj_FunctView.Rows(i).Cells(1).Value.ToString()))
            Next

            'Add machine data to quote
            excelApp.Range("BD16:BJ45").Activate()
            For i As Integer = 0 To machineFunctions.Count - 1 Step +1
                'Multiplying i by 2 because each function is 2 cells high
                Dim cellIndex As Integer = 16 + (i * 2)

                If cellIndex <= 44 Then
                    excelApp.Range("BD" + cellIndex.ToString()).Value = machineFunctions(i).MachineFunction
                    excelApp.Range("BF" + cellIndex.ToString()).Value = machineFunctions(i).Quantity
                    excelApp.Range("BG" + cellIndex.ToString()).Value = machineFunctions(i).Deliverables
                End If
            Next

            MessageBox.Show("Section 3 filled in")
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        getImagePathViaFileExplorer()
    End Sub

    Sub getImagePathViaFileExplorer()
        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "png Images|*.png|jpeg Images|*.jpg,*.jpeg"}
            If ofd.ShowDialog() = DialogResult.OK Then
                Proj_DiagramPath.Text = ofd.FileName
            End If
        End Using
    End Sub
End Class