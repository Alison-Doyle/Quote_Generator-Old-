Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data.DataTable
Imports GemBox.Spreadsheet

Public Class QuoteGenerator2
    Dim LoadDir As String
    Dim MyExcel As New Excel.Application
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim table As New DataTable("Table")
    Private Sub QuoteGenerator2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDir = Environment.CurrentDirectory & "\"
        Me.AutoScroll = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Previous Page Button
        QuoteGen.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'Next Page Button
        QuoteGenerator3.Show()
        Me.Hide()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click 'Menu Button
        Dim frm = New MainMenu
        frm.Show()
        Me.Hide()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs)
        'Try
        'MyExcel.Workbooks.Open(LoadDir & "Quote_Template(ReadOnly).xlsx")
        'MyExcel.Sheets("Sheet1").activate()

        'MyExcel.Range("AD18:AH45").Activate()
        'MyExcel.Range("AD18:AH45").Value = Proj_DocViewer


        'MyExcel.ActiveWorkbook.Close(SaveChanges:=True)
        'MyExcel.Quit()

        'Runtime.InteropServices.Marshal.ReleaseComObject(MyExcel.Workbooks)

        'MessageBox.Show("Quote Updated")

        ' Catch ex As Exception


        ' End Try

    End Sub

    Private Sub Proj_DocViewer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Proj_DocDesc_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Proj_DocOwner_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        MyExcel.Workbooks.Open(LoadDir & "Quote_Template(ReadOnly).xlsx")
        MyExcel.Sheets("Sheet1").activate()

        MyExcel.Cells.Replace("þ", QuoteGen.Doc_CompanyName.Text)
        MyExcel.Cells.Replace("QN", QuoteGen.Doc_QuoteNo.Text)

        MyExcel.Workbooks.Open(LoadDir & "Quote_Template(ReadOnly).xlsx")   'Inserting desc of line/machine + diagram
        MyExcel.Sheets("Sheet1").activate()
        MyExcel.Range("AL6").Activate()
        MyExcel.Range("AL6").Value = Proj_Desc.Text



        MyExcel.ActiveWorkbook.Close(SaveChanges:=True)
        MyExcel.Quit()

        Runtime.InteropServices.Marshal.ReleaseComObject(MyExcel.Workbooks) 'ᚹ

        MessageBox.Show("Quote Updated")
    End Sub

    Private Sub Proj_Desc_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click ' Add to DGV
        Me.Proj_FunctView.Rows.Add(Proj_Function.Text, Proj_FunctQuantity.Text, Proj_FunctDesc.Text)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click 'Next Page(top button)
        QuoteGenerator3.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click 'Previous Page (top)
        QuoteGen.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click 'Main Menu (top)
        Dim frm = New MainMenu
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub Proj_FunctDesc_TextChanged(sender As Object, e As EventArgs) Handles Proj_FunctDesc.TextChanged

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) 
        Try
            MyExcel.Workbooks.Open(LoadDir & "Quote_Template(ReadOnly).xlsx")
            MyExcel.Sheets("Sheet1").Activate()

            MyExcel.Workbooks.Open(LoadDir & "Quote_Template(ReadOnly).xlsx") 'Replace QN and COMPANY
            MyExcel.Sheets("Sheet1").activate()

            MyExcel.Cells.Replace("þ", QuoteGen.Doc_CompanyName.Text)
            MyExcel.Cells.Replace("QN", QuoteGen.Doc_QuoteNo.Text)


            Try                                                                 'Inserting Document Details
                MyExcel.Workbooks.Open(LoadDir & "Quote_Template(ReadOnly).xlsx")
                MyExcel.Sheets("Sheet1").activate()

                MyExcel.Range("V11").Activate()
                MyExcel.Range("V11").Value = QuoteGen.Doc_DocLocation.Text

                MyExcel.Range("V14").Activate()
                MyExcel.Range("V14").Value = QuoteGen.Doc_RevisionNumber.Text

                MyExcel.Range("V17").Activate()
                MyExcel.Range("V17").Value = QuoteGen.Doc_DocOwner.Text

                MyExcel.Range("V20").Activate()
                MyExcel.Range("V20").Value = QuoteGen.Doc_RevisionNumber.Text

                MyExcel.Workbooks.Open(LoadDir & "Quote_Template(ReadOnly).xlsx") 'Replace QN and COMPANY
                MyExcel.Sheets("Sheet1").activate()

                MyExcel.Cells.Replace("þ", QuoteGen.Doc_CompanyName.Text)
                MyExcel.Cells.Replace("QN", QuoteGen.Doc_QuoteNo.Text)

                MyExcel.Workbooks.Open(LoadDir & "Quote_Template(ReadOnly).xlsx") 'Replacing (EN)Enquirer Name, (ET)Enquirer Title, (EA)Enquirer Address
                MyExcel.Sheets("Sheet1").activate()

                MyExcel.Cells.Replace("BQ", QuoteGen.Proj_EquirerName.Text)
                MyExcel.Cells.Replace("BZ", QuoteGen.Proj_EnquirerTitle.Text)
                MyExcel.Cells.Replace("CF", QuoteGen.Proj_Address.Text)

                MyExcel.Workbooks.Open(LoadDir & "Quote_Template(ReadOnly).xlsx")   'Inserting desc of line/machine + diagram
                MyExcel.Sheets("Sheet1").activate()
                MyExcel.Range("AL6").Activate()
                MyExcel.Range("AL6").Value = Proj_Desc.Text

                MyExcel.Range("BD16:BG44").Activate() 'filling in table

                For i As Integer = 0 To Proj_FunctView.Rows.Count Step +1

                    MyExcel.Range("BD16").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BF16").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("BG16").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("BD18").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BF18").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("BG18").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("BD20").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BF20").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("BG20").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("BD22").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BF22").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("BG22").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("BD24").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BF24").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("BG24").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("BD26").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BF26").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("BG26").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("BD28").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BF28").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("BG28").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("BD30").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BF30").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("BG30").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("BD32").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BF32").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("BG32").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("BD34").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BF34").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("BG34").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("BD36").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BF36").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("BG36").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("BD38").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BF38").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("BG38").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("BD40").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BF40").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("BG40").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("BD44").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BF44").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("BG44").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("BD46").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BF46").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("BG46").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                Next

            Catch
            End Try
        Catch ex As Exception
        End Try
        MyExcel.ActiveWorkbook.Close(SaveChanges:=True)
        MyExcel.Quit()

        Runtime.InteropServices.Marshal.ReleaseComObject(MyExcel.Workbooks)
    End Sub

    Private Sub Proj_FunctView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Proj_FunctView.CellContentClick


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click 'INSERT BUTTON @ BOTTOM OF FORM
        MyExcel.Workbooks.Open(LoadDir & "Quote_Template(ReadOnly).xlsx")
        MyExcel.Sheets("Sheet1").activate()

        MyExcel.Workbooks.Open(LoadDir & "Quote_Template(ReadOnly).xlsx")   'Inserting desc of line/machine + diagram
        MyExcel.Sheets("Sheet1").activate()
        MyExcel.Range("AL6").Activate()
        MyExcel.Range("AL6").Value = Proj_Desc.Text

        MyExcel.Range("BD16:BG44").Activate() 'FILLING IN FUNCTIONS OF PANEL

        For i As Integer = 0 To Proj_FunctView.Rows.Count Step +1

            MyExcel.Range("BD16").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
            MyExcel.Range("BF16").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
            MyExcel.Range("BG16").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
            i += 1

            MyExcel.Range("BD18").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
            MyExcel.Range("BF18").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
            MyExcel.Range("BG18").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
            i += 1

            MyExcel.Range("BD20").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
            MyExcel.Range("BF20").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
            MyExcel.Range("BG20").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
            i += 1

            MyExcel.Range("BD22").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
            MyExcel.Range("BF22").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
            MyExcel.Range("BG22").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
            i += 1

            MyExcel.Range("BD24").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
            MyExcel.Range("BF24").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
            MyExcel.Range("BG24").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
            i += 1

            MyExcel.Range("BD26").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
            MyExcel.Range("BF26").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
            MyExcel.Range("BG26").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
            i += 1

            MyExcel.Range("BD28").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
            MyExcel.Range("BF28").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
            MyExcel.Range("BG28").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
            i += 1

            MyExcel.Range("BD30").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
            MyExcel.Range("BF30").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
            MyExcel.Range("BG30").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
            i += 1

            MyExcel.Range("BD32").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
            MyExcel.Range("BF32").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
            MyExcel.Range("BG32").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
            i += 1

            MyExcel.Range("BD34").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
            MyExcel.Range("BF34").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
            MyExcel.Range("BG34").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
            i += 1

            MyExcel.Range("BD36").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
            MyExcel.Range("BF36").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
            MyExcel.Range("BG36").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
            i += 1

            MyExcel.Range("BD38").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
            MyExcel.Range("BF38").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
            MyExcel.Range("BG38").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
            i += 1

            MyExcel.Range("BD40").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
            MyExcel.Range("BF40").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
            MyExcel.Range("BG40").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
            i += 1

            MyExcel.Range("BD44").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
            MyExcel.Range("BF44").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
            MyExcel.Range("BG44").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
            i += 1

            MyExcel.Range("BD46").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
            MyExcel.Range("BF46").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
            MyExcel.Range("BG46").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
        Next

        MyExcel.ActiveWorkbook.Close(SaveChanges:=True)
        MyExcel.Quit()

        Runtime.InteropServices.Marshal.ReleaseComObject(MyExcel.Workbooks)



        MessageBox.Show("Quote Updated")
    End Sub
End Class

'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum