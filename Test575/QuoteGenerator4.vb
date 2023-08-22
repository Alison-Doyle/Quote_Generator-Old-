Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data.DataTable
Public Class QuoteGenerator4
    Dim LoadDir As String
    Dim MyExcel As New Excel.Application
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim table As New DataTable("Table")
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click 'Back to MainMenu
        Dim frm = New MainMenu
        frm.Show()
        Me.Hide()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'Back Button (Top)
        QuoteGenerator3.Show()
        Me.Hide()
    End Sub

    Private Sub QuoteGenerator4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True
        LoadDir = Environment.CurrentDirectory & "\"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm = New MainMenu
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click 'Next Page (Top)
        QuoteGen5.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'Next Page (Bottom)
        QuoteGen5.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Back Button (Button)
        QuoteGenerator3.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click   'OPENS EMPLOYEE CALCULATOR
        EmployeeCalculator.Show()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click   'ADD COST OF COMPONANTS TO BREAKDOWN
        Try
            Me.Proj_CostBreakDown.Rows.Add("Cost of Componants", "", Proj_CompTotal.Text)

        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click   'OPENS EXPENCES CALCULATOR
        ExpencesCalculator.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click 'ADDS WEEK AND ACTIVITY DESC TO ACTIVITY VIEWER
        Me.Proj_Activate.Rows.Add(Proj_Week.Text, Proj_ActivityDesc.Text)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click 'INSERT BUTTON @ CYTTOM OF PAGE
        Try                                                                     'Inserting Activity week and desc
            MyExcel.Workbooks.Open("C:\Users\Admin\Desktop\" & QuoteGen.Doc_FileName.Text)
            MyExcel.Sheets("Sheet1").activate()

            Try
                MyExcel.Range("CW8:CX46").Activate()
                For i As Integer = 0 To Proj_Activate.Rows.Count Step +1

                    MyExcel.Range("CW8").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX8").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("CW10").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX10").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("CW12").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX12").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("CW14").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX14").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("CW16").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX16").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("CW18").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX18").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("CW20").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX20").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("CW22").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX22").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("CW24").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX24").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("CW26").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX26").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("CW28").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX28").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("CW30").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX30").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("CW32").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX32").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("CW34").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX34").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("CW36").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX36").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("CW38").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX38").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("CW40").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX40").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("CW42").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX42").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("CW44").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX44").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("CW46").Value = Proj_Activate.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("CX46").Value = Proj_Activate.Rows(i).Cells(1).Value.ToString()
                Next
            Catch
            End Try

            Try
                MyExcel.Range("DF8:DL46").Activate()
                For i As Integer = 0 To Proj_CostBreakDown.Rows.Count Step +1

                    MyExcel.Range("DF8").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ8").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL8").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF9").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ9").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL9").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF10").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ10").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL10").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF11").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ11").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL11").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF12").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ12").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL12").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF13").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ13").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL13").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF14").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ14").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL14").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF15").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ15").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL15").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF16").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ16").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL16").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF17").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ17").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL17").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF18").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ18").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL18").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF19").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ19").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL19").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF20").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ20").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL20").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF21").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ21").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL21").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF22").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ22").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL22").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF23").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ23").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL23").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF24").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ24").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL24").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF25").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ25").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL25").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF26").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ26").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL26").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF27").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ27").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL27").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF28").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ28").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL28").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF29").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ29").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL29").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF30").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ30").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL30").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF31").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ31").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL31").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF32").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ32").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL32").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF33").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ33").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL33").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF34").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ34").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL34").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF35").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ35").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL35").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF36").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ36").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL36").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF37").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ37").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL37").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF38").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ38").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL38").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF39").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ39").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL39").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF40").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ40").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL40").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF41").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ41").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL41").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF42").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ42").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL42").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF43").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ43").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL43").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF44").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ44").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL44").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF45").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ45").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL45").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                    i += 1

                    MyExcel.Range("DF46").Value = Proj_CostBreakDown.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("DJ46").Value = Proj_CostBreakDown.Rows(i).Cells(1).Value.ToString()
                    MyExcel.Range("DL46").Value = Proj_CostBreakDown.Rows(i).Cells(2).Value.ToString()
                Next
            Catch
            End Try

        Catch
        End Try

        MyExcel.ActiveWorkbook.Close(SaveChanges:=True)
        MyExcel.Quit()

        Runtime.InteropServices.Marshal.ReleaseComObject(MyExcel.Workbooks)

        MessageBox.Show("Quote Updated")
    End Sub

    Private Sub Proj_Activate_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Proj_Activate.CellContentClick

    End Sub
End Class