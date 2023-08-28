Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Windows

Public Class QuoteGen
    Dim LoadDir As String
    Public quoteLocation As String
    Private Sub Button2_Click(sender As Object, e As EventArgs)  'Next Page
        QuoteGenerator2.Show()
        Me.Close()
    End Sub
    Private Sub QuoteGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Defining LoadDir/Load Directory
        LoadDir = Environment.CurrentDirectory & "\"
        Me.AutoScroll = True
    End Sub
    Private Sub BackBtn_Click_1(sender As Object, e As EventArgs) Handles BackBtn.Click 'Back to MainMenu (Bottom)
        goToMainMenu()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click 'Next Page (Bottom)
        goToPage2()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click 'Next Page (top)
        goToPage2()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click 'Back to main menu (top)
        goToMainMenu()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Proj_DocViewer.Rows.Add(Proj_DocDesc.Text, Proj_DocOwner.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click  'INSERT BUTTON @ BOTTOM OF PAGE
        populateDocumentSection1AndSection2()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click 'Create File
        'Making sure company name and quote number are filled in
        If String.IsNullOrEmpty(Doc_CompanyName.Text) = False And String.IsNullOrEmpty(Doc_QuoteNo.Text) = False Then
            'Checking if user wants to use a custom file path or default file path
            If String.IsNullOrEmpty(Doc_DocLocation.Text) = True Then

                Select Case MessageBox.Show("By continuing with a blank document location, you will save the file in the dafault location (Desktop)", "Note", MessageBoxButtons.OKCancel)
                    Case MessageBoxResult.OK
                        createExcelFile(Doc_CompanyName.Text, Doc_QuoteNo.Text, Doc_FileName.Text, Doc_DocLocation.Text)
                End Select
            Else
                createExcelFile(Doc_CompanyName.Text, Doc_QuoteNo.Text, Doc_FileName.Text, Doc_DocLocation.Text)
            End If
        ElseIf String.IsNullOrEmpty(Doc_CompanyName.Text) = True Or String.IsNullOrEmpty(Doc_QuoteNo.Text) = True Then
            MessageBox.Show("Company name and/or quote number is empty. Please fill these in before proceeding.")
        End If
    End Sub

    Private Sub selectFileLocationButton_Click(sender As Object, e As EventArgs) Handles selectFileLocationButton.Click
        selectFilePath()
    End Sub

    Sub goToMainMenu()
        Dim menuForm = MainMenu
        menuForm.Show()
        Me.Close()
    End Sub

    Sub goToPage2()
        Dim page2 = New QuoteGenerator2
        page2.quoteLocation = quoteLocation
        page2.Show()
        Me.Close()
    End Sub

    Sub createExcelFile(companyName, quoteNumber, enteredFileName, enteredFilePath)
        Dim quoteTemplatePath As String = Environment.CurrentDirectory & "/Resources/Quote_Template.xlsx"
        Dim quoteFilePath As String
        Dim fileName As String

        'Application Variables
        Dim excelApp As New Excel.Application

        Try
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
            MessageBox.Show("Quote document save at: " & quoteFilePath & "\" & fileName)
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
End Class