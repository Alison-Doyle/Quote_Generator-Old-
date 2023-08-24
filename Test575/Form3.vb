﻿Imports Excel = Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient

Public Class QuoteGen
    Dim LoadDir As String
    Dim MyExcel As New Excel.Application
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim table As New DataTable("Table")
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
        Try
            MyExcel.Workbooks.Open("C:\Users\Admin\Desktop\" & Doc_FileName.Text)
            MyExcel.Sheets("Sheet1").activate()

            MyExcel.Range("V11").Activate()                         'DOCUMENT DETAILS
            MyExcel.Range("V11").Value = Doc_DocLocation.Text

            MyExcel.Range("V14").Activate()
            MyExcel.Range("V14").Value = Doc_RevisionNumber.Text

            MyExcel.Range("V17").Activate()
            MyExcel.Range("V17").Value = Doc_DocOwner.Text

            MyExcel.Range("V20").Activate()
            MyExcel.Range("V20").Value = Doc_RefNumber.Text

            MyExcel.Cells.Replace("BQ", Proj_EquirerName.Text)     'FILLING IN ENQUIRER DETAILS
            MyExcel.Cells.Replace("BZ", Proj_EnquirerTitle.Text)
            MyExcel.Cells.Replace("CF", Proj_Address.Text)

            MyExcel.Range("AC16:AH46").Activate()

            Try
                For i As Integer = 0 To Proj_DocViewer.Rows.Count Step +1                               'DOCUMENT TABLE

                    MyExcel.Range("AC16").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH16").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                    MyExcel.Range("AC17").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH17").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                    MyExcel.Range("AC18").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH18").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                    MyExcel.Range("AC19").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH19").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                    MyExcel.Range("AC20").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH20").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                    MyExcel.Range("AC21").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH21").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                    MyExcel.Range("AC22").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH22").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                    MyExcel.Range("AC23").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH23").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                    MyExcel.Range("AC24").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH24").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                    MyExcel.Range("AC25").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH25").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                    MyExcel.Range("AC26").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH26").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                    MyExcel.Range("AC27").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH27").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                    MyExcel.Range("AC28").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH28").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                    MyExcel.Range("AC29").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH29").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                    MyExcel.Range("AC30").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH30").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                    MyExcel.Range("AC31").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH31").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                    MyExcel.Range("AC32").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH32").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                    MyExcel.Range("AC34").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH34").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                    MyExcel.Range("AC35").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH35").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                    MyExcel.Range("AC36").Value = Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("AH36").Value = Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1
                Next
            Catch
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MyExcel.ActiveWorkbook.Close(SaveChanges:=True)
        MyExcel.Quit()
        Runtime.InteropServices.Marshal.ReleaseComObject(MyExcel.Workbooks)
        MessageBox.Show("Quote Updated")
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click 'Create File
        createExcelFile(Doc_CompanyName.Text, Doc_QuoteNo.Text, Doc_FileName.Text, Doc_DocLocation.Text)
    End Sub

    Sub goToMainMenu()
        Dim menuForm = MainMenu
        menuForm.Show()
        Me.Close()
    End Sub

    Sub goToPage2()
        Dim page2 = QuoteGenerator2
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
                quoteFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\"
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
            excelApp.ActiveWorkbook.SaveAs(quoteFilePath & fileName)

            MessageBox.Show("Quote document save at: " & quoteFilePath & fileName)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            'Close Excel Application
            excelApp.Workbooks.Close()
            excelApp.Quit()
        End Try
    End Sub
End Class