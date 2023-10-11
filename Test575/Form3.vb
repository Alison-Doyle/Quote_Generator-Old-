Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Windows
Imports Test575.standardProgramFunctions

Public Class QuoteGen
    Public quoteLocation As String
    Private Sub Button2_Click(sender As Object, e As EventArgs)  'Next Page
        goToPage2()
    End Sub
    Private Sub QuoteGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Defining LoadDir/Load Directory
        Me.AutoScroll = True
    End Sub

    Private Sub QuoteGenerator_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        If e.CloseReason = CloseReason.UserClosing Then
            endQuoteCreation(e)
        End If
    End Sub

    Private Sub BackBtn_Click_1(sender As Object, e As EventArgs) Handles BackBtn.Click 'Back to MainMenu (Bottom)
        returnToMainMenu()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click 'Next Page (Bottom)
        goToPage2()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click 'Next Page (top)
        goToPage2()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)  'Back to main menu (top)
        returnToMainMenu()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Proj_DocViewer.Rows.Add(Proj_DocDesc.Text, Proj_DocOwner.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click  'INSERT BUTTON @ BOTTOM OF PAGE
        populateDocumentSection1AndSection2()
    End Sub

    Private Sub selectFileLocationButton_Click(sender As Object, e As EventArgs) Handles selectFileLocationButton.Click
        selectFilePath()
    End Sub

    Sub goToPage2()
        Dim page2 = QuoteGenerator2
        page2.quoteLocation = quoteLocation
        page2.Show()
        Me.Hide()
    End Sub

    Sub createExcelFile()
        Dim companyName = Doc_CompanyName.Text
        Dim quoteNumber = Doc_QuoteNo.Text
        Dim enteredFileName = Doc_FileName.Text
        Dim enteredFilePath = Doc_DocLocation.Text
        Dim quoteTemplatePath As String = Environment.CurrentDirectory & "/Resources/Quote_Template.xlsx"
        Dim quoteFilePath As String
        Dim fileName As String

        'Application Variables
        Dim excelApp As New Excel.Application

        Try
            'Validate file/compnay name=
            Dim fileNameIsValid As Boolean
            If String.IsNullOrEmpty(enteredFileName) Then
                fileNameIsValid = validateName(companyName)
            Else
                fileNameIsValid = validateName(enteredFileName)
            End If

            If fileNameIsValid = False Then
                Throw New customExceptions
            End If

            'Open template
            excelApp.Visible = False
            excelApp.Workbooks.Open(quoteTemplatePath)
            excelApp.Sheets("Sheet1").activate()

            'Fill in template constants
            excelApp.Cells.Replace("þ", companyName)
            excelApp.Cells.Replace("QN", quoteNumber)

            'Getting filepath
            If String.IsNullOrEmpty(enteredFilePath) Then
                quoteFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Else
                quoteFilePath = enteredFilePath
            End If

            'Getting filename
            If String.IsNullOrEmpty(enteredFileName) Then
                fileName = "Quote " & quoteNumber & "(" & companyName & ")"
            Else
                If enteredFileName.Contains(".xlsx") Then
                    fileName = enteredFileName
                ElseIf enteredFileName.Contains(".xls") Then
                    fileName = enteredFileName.Replace(".xls", ".xlsx")
                Else
                    fileName = enteredFileName & ".xlsx"
                End If
            End If

            'Save File and close excel
            excelApp.ActiveWorkbook.SaveAs(quoteFilePath & "\" & fileName)

            quoteLocation = quoteFilePath & "\" & fileName
            MessageBox.Show("Quote document saved at: " & quoteFilePath & "\" & fileName)
        Catch formatEx As customExceptions
            formatEx.incorrectFilenameFormatException()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            'Close Excel Application
            excelApp.Workbooks.Close()
            excelApp.Quit()

            'Must clean up twice to clean up cycles as well
            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub

    Sub selectFilePath()
        Dim folderBrowser As New FolderBrowserDialog

        If folderBrowser.ShowDialog() = DialogResult.OK Then
            Doc_DocLocation.Text = folderBrowser.SelectedPath
        End If
    End Sub

    Sub populateDocumentSection1AndSection2()
        'Simplifying variable names for readablity
        Dim revisionNumber As String = Doc_RevisionNumber.Text
        Dim documentOwner As String = Doc_DocOwner.Text
        Dim referenceNumber As String = Doc_RefNumber.Text
        Dim enquirerName As String = Proj_EquirerName.Text
        Dim enquirerTitle As String = Proj_EnquirerTitle.Text
        Dim enquirerAddress As String = Proj_Address.Text

        Dim projectDocumentsData As New List(Of RelatedDocumentation)

        'Excel Variables
        Const documentLocationCell = "V11"
        Const revisionCell = "V14"
        Const ownerCell = "V17"
        Const referenceNumberCell = "V20"
        Const enquirerNamePlaceholder = "BQ"
        Const enquirerTitlePlaceholder = "BZ"
        Const enquirerAddressPlaceholder = "CF"

        Dim filePath As String = quoteLocation
        Dim excelApp As New Excel.Application

        Try
            excelApp.Visible = False
            excelApp.Workbooks.Open(filePath)
            excelApp.Sheets("Sheet1").activate()

            'Fill in Section 1: Document Details
            excelApp.Range(documentLocationCell).Activate()
            excelApp.Range(documentLocationCell).Value = filePath

            excelApp.Range(revisionCell).Activate()
            excelApp.Range(revisionCell).Value = revisionNumber

            excelApp.Range(ownerCell).Activate()
            excelApp.Range(ownerCell).Value = documentOwner

            excelApp.Range(referenceNumberCell).Activate()
            excelApp.Range(referenceNumberCell).Value = referenceNumber

            'Fill in Section 2: Project Details
            excelApp.Cells.Replace(enquirerNamePlaceholder, enquirerName)
            excelApp.Cells.Replace(enquirerTitlePlaceholder, enquirerTitle)
            excelApp.Cells.Replace(enquirerAddressPlaceholder, enquirerAddress)

            'Fetching data from datatable
            For i As Integer = 0 To Proj_DocViewer.Rows.Count - 1 Step +1
                projectDocumentsData.Add(New RelatedDocumentation(Proj_DocViewer.Rows(i).Cells(0).Value.ToString(), Proj_DocViewer.Rows(i).Cells(1).Value.ToString()))
            Next

            'Filling in related documentation
            excelApp.Range("AC16:AH46").Activate()
            For i As Integer = 0 To projectDocumentsData.Count - 1 Step +1
                Dim index As Integer = 16 + i

                If index <= 46 Then
                    excelApp.Range("AC" & index.ToString()).Value = projectDocumentsData(i).description
                    excelApp.Range("AH" & index.ToString()).Value = projectDocumentsData(i).owner
                End If
            Next

            MessageBox.Show("Sections 1 and 2 filled in")
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

    Private Sub createFileButton_Click(sender As Object, e As EventArgs) Handles createFileButton.Click
        createExcelFile()
    End Sub

    Function validateName(nameToCheck As String)
        Dim forbiddenCharacters As Char() = {
                ".",
                "_",
                "*"
            }
        Dim nameValid As Boolean = True

        For i As Integer = 0 To forbiddenCharacters.Length - 1 Step +1
            If nameToCheck.Contains(forbiddenCharacters(i)) Or String.IsNullOrWhiteSpace(nameToCheck) Then
                nameValid = False
            End If
        Next

        Return nameValid
    End Function
End Class