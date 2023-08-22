Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Imports Microsoft.Office.Interop
Imports System.IO
Public Class QuoteGenerator3
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim Mysqlred As MySqlDataReader
    Dim myData As DataTable
    Dim myAdapter As MySqlDataAdapter
    Dim SQL As String
    Dim LoadDir As String
    Dim MyExcel As New Excel.Application
    Dim table As New DataTable("Table")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Previous Page Button (bottom)
        QuoteGenerator2.Show()
        Me.Hide()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click 'Menu Button (bottom)
        Dim frm = New MainMenu
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=Localhost;Userid=root;password=Stiefel123;database=test" 'Fetching Item Details from MySQL DataBase
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Select * From test.new_table where ID='" & Proj_CompID.Text & "' "
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim Count As Integer

            Count = 0
            While READER.Read
                Count = Count + 1

            End While

            If Count = 1 Then
                Proj_CompSupply.Text = READER.GetString("Supplier")
                Proj_CompDesc.Text = READER.GetString("Description")
                Proj_CompCost.Text = READER.GetString("Cost")
            Else
                MessageBox.Show("Invalid Input or Item Doesn't Exist")
            End If
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'cost of componants + percentage add on calculator and adding to dgv
        Try
            Dim Sum As Decimal = Proj_CompCost.Text * Proj_CompTakeOut.Text * Proj_CompPrecentage.Text
            Dim Sum2 As Decimal = Sum + (Proj_CompCost.Text * Proj_CompTakeOut.Text)

            Me.Proj_CompViewer.Rows.Add(Proj_CompSupply.Text, Proj_CompDesc.Text, Proj_CompTakeOut.Text, Sum2)

            Dim Total As Decimal = 0
            For i As Decimal = 0 To Proj_CompViewer.Rows.Count - 1 Step +1
                Total += Convert.ToDecimal(Proj_CompViewer.Rows(i).Cells(3).Value)
            Next

            Proj_CompTotal.Text = Total.ToString
        Catch ex As Exception
            MessageBox.Show("Feild Empty or Invalid Entry")
        End Try
    End Sub
    Private Sub QuoteGenerator3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Proj_CompTotal.Text = 0
        Me.AutoScroll = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MyExcel.Workbooks.Open(LoadDir & "C:\Users\Admin\Desktop\Test575\Test575\bin\Debug\Quote_Template(ReadOnly).xlsx") 'Replace QN and COMPANY
        MyExcel.Sheets("Sheet1").activate()
        Try
            Try
                MyExcel.Workbooks.Open(LoadDir & "Quote_Template(ReadOnly).xlsx")
                MyExcel.Sheets("Sheet1").Activate()

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

                    Try
                        For i As Integer = 0 To QuoteGen.Proj_DocViewer.Rows.Count Step +1

                            MyExcel.Range("AC16").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH16").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                            MyExcel.Range("AC17").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH17").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                            MyExcel.Range("AC18").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH18").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                            MyExcel.Range("AC19").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH19").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                            MyExcel.Range("AC20").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH20").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                            MyExcel.Range("AC21").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH21").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                            MyExcel.Range("AC22").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH22").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                            MyExcel.Range("AC23").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH23").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                            MyExcel.Range("AC24").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH24").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                            MyExcel.Range("AC25").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH25").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                            MyExcel.Range("AC26").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH26").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                            MyExcel.Range("AC27").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH27").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                            MyExcel.Range("AC28").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH28").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                            MyExcel.Range("AC29").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH29").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                            MyExcel.Range("AC30").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH30").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                            MyExcel.Range("AC31").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH31").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                            MyExcel.Range("AC32").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH32").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                            MyExcel.Range("AC34").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH34").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                            MyExcel.Range("AC35").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH35").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                            MyExcel.Range("AC36").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(0).Value.ToString()
                            MyExcel.Range("AH36").Value = QuoteGen.Proj_DocViewer.Rows(i).Cells(1).Value.ToString()
                            i += 1
                        Next
                    Catch
                    End Try


                    MyExcel.Workbooks.Open(LoadDir & "Quote_Template(ReadOnly).xlsx")   'Inserting desc of line/machine + diagram
                    MyExcel.Sheets("Sheet1").activate()
                    MyExcel.Range("AL6").Activate()
                    MyExcel.Range("AL6").Value = QuoteGenerator2.Proj_Desc.Text

                    MyExcel.Range("BD16:BG44").Activate() 'filling in table

                    For i As Integer = 0 To QuoteGenerator2.Proj_FunctView.Rows.Count Step +1

                        MyExcel.Range("BD16").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                        MyExcel.Range("BF16").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                        MyExcel.Range("BG16").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                        i += 1

                        MyExcel.Range("BD18").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                        MyExcel.Range("BF18").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                        MyExcel.Range("BG18").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                        i += 1

                        MyExcel.Range("BD20").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                        MyExcel.Range("BF20").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                        MyExcel.Range("BG20").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                        i += 1

                        MyExcel.Range("BD22").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                        MyExcel.Range("BF22").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                        MyExcel.Range("BG22").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                        i += 1

                        MyExcel.Range("BD24").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                        MyExcel.Range("BF24").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                        MyExcel.Range("BG24").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                        i += 1

                        MyExcel.Range("BD26").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                        MyExcel.Range("BF26").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                        MyExcel.Range("BG26").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                        i += 1

                        MyExcel.Range("BD28").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                        MyExcel.Range("BF28").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                        MyExcel.Range("BG28").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                        i += 1

                        MyExcel.Range("BD30").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                        MyExcel.Range("BF30").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                        MyExcel.Range("BG30").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                        i += 1

                        MyExcel.Range("BD32").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                        MyExcel.Range("BF32").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                        MyExcel.Range("BG32").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                        i += 1

                        MyExcel.Range("BD34").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                        MyExcel.Range("BF34").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                        MyExcel.Range("BG34").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                        i += 1

                        MyExcel.Range("BD36").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                        MyExcel.Range("BF36").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                        MyExcel.Range("BG36").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                        i += 1

                        MyExcel.Range("BD38").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                        MyExcel.Range("BF38").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                        MyExcel.Range("BG38").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                        i += 1

                        MyExcel.Range("BD40").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                        MyExcel.Range("BF40").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                        MyExcel.Range("BG40").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                        i += 1

                        MyExcel.Range("BD44").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                        MyExcel.Range("BF44").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                        MyExcel.Range("BG44").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                        i += 1

                        MyExcel.Range("BD46").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                        MyExcel.Range("BF46").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                        MyExcel.Range("BG46").Value = QuoteGenerator2.Proj_FunctView.Rows(i).Cells(2).Value.ToString()
                    Next

                Catch
                End Try
            Catch ex As Exception
            End Try


            MyExcel.Range("BV7").Activate()
            MyExcel.Range("BV7").Value = Proj_DescPLC.Text

            MyExcel.Range("CE7").Activate()
            MyExcel.Range("CE7").Value = Proj_DescPLC.Text


            MyExcel.ActiveWorkbook.Close(SaveChanges:=True)
            MyExcel.Quit()

            Runtime.InteropServices.Marshal.ReleaseComObject(MyExcel.Workbooks) 'ᚹ

            MessageBox.Show("Quote Updated")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click ' Next Page(Top)
        QuoteGenerator4.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        QuoteGenerator2.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim frm = New MainMenu
        frm.Show()
        Me.Hide()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For Each row As DataGridViewRow In Proj_CompViewer.SelectedRows
            Proj_CompViewer.Rows.Remove(row)
        Next
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click ' Next Page(Bottom)
        QuoteGenerator4.Show()
        Me.Hide()
    End Sub
End Class