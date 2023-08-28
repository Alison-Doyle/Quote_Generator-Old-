Imports MySql.Data.MySqlClient
Imports System.Data.DataTable
Imports Microsoft.Office.Interop
Imports System.IO
Public Class QuoteGenerator3
    Public quoteLocation As String

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
        LoadDir = Environment.CurrentDirectory & "\"
        Proj_CompTotal.Text = 0
        Me.AutoScroll = True
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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        StockViewer.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click 'INSERT BUTTON @ BOTTOM OF PAGE
        Try
            MyExcel.Workbooks.Open("C:\Users\Admin\Desktop\" & QuoteGen.Doc_FileName.Text)
            MyExcel.Sheets("Sheet1").activate()

            Try
                For i As Integer = 0 To Proj_CompViewer.Rows.Count Step +1

                    MyExcel.Range("BM8").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO8").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM9").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO9").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM10").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO10").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM11").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO11").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM12").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO12").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM13").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO13").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM14").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO14").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM15").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO15").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM16").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO16").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM17").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO17").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM18").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO18").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM19").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO19").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM20").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO20").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM21").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO21").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM22").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO22").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM23").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO23").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM24").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO24").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM25").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO25").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM26").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO26").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM27").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO27").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM28").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO28").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM29").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO29").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM30").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO30").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM31").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO31").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM32").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO32").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM33").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO33").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM34").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO34").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM35").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO35").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM36").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO36").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM37").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO37").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM38").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO38").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM39").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO39").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM40").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO40").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM41").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO41").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM42").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO42").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM43").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO43").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM44").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO44").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM45").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO45").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                    i += 1

                    MyExcel.Range("BM46").Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    MyExcel.Range("BO46").Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                Next
            Catch
            End Try

            MyExcel.Range("BV7").Activate()                 'PLC & SCADA DESCRIPTION
            MyExcel.Range("BV7").Value = Proj_DescPLC.Text

            MyExcel.Range("CE7").Activate()
            MyExcel.Range("CE7").Value = Proj_DescSCADA.Text


            MyExcel.ActiveWorkbook.Close(SaveChanges:=True)
            MyExcel.Quit()

            Runtime.InteropServices.Marshal.ReleaseComObject(MyExcel.Workbooks)
        Catch
        End Try

        MessageBox.Show("Quote Updated")
    End Sub

    Private Sub Proj_CompViewer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Proj_CompViewer.CellContentClick

    End Sub
    Sub DGV_Total()
        Dim colsum As Decimal
        For Each r As DataGridViewRow In Proj_CompViewer.Rows
            colsum += r.Cells(3).Value
            Proj_CompTotal.Text = colsum
        Next
    End Sub
    Private Sub Proj_CompTotal_TextChanged(sender As Object, e As EventArgs) Handles Proj_CompTotal.TextChanged
        'Proj_CompTotal.Text = Proj_CompViewer.Rows(max).Cells(4).Value += row.Cells(4).Value

        QuoteGenerator4.Proj_CompTotal.Text = Proj_CompTotal.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'INSERT PRESETS

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=Localhost;Userid=root;password=Stiefel123;database=test" 'Fetching Item Details from MySQL DataBase

        MessageBox.Show("This button is under construction. Please enter componants manually.")

        'If Presets.Text = "1 VSD Panel" Then
        'MysqlConn.Open()
        'Dim READER As MySqlDataReader
        'Dim query As String
        'query = "select `Supplier`, `Description`, `Quantity`, `Cost` from `test_quotes`.`1_vsd_panel_preset`"
        '
        'COMMAND = New MySqlCommand(query, MysqlConn)
        'READER = COMMAND.ExecuteReader
        'While READER.Read
        'Me.Proj_CompViewer.Rows.Add(READER.GetString("Supplier"), READER.GetString("Description"), READER.GetString("Quantity"), READER.GetString("Cost"))
        'End While
        '
        'ElseIf Presets.Text = "2 VSD Panel" Then
        'MysqlConn.Open()
        'Dim READER As MySqlDataReader
        'Dim query As String
        'query = "select `Supplier`, `Description`, `Quantity`, `Cost` from `test_quotes`.`2_vsd_panel_preset`"

        'COMMAND = New MySqlCommand(query, MysqlConn)
        'READER = COMMAND.ExecuteReader
        'While READER.Read
        'Me.Proj_CompViewer.Rows.Add(READER.GetString("Supplier"), READER.GetString("Description"), READER.GetString("Quantity"), READER.GetString("Cost"))
        'End While

        'ElseIf Presets.Text = "3 VSD Panel" Then
        'MysqlConn.Open()
        'Dim READER As MySqlDataReader
        'Dim query As String
        'query = "select `Supplier`, `Description`, `Quantity`, `Cost` from `test_quotes`.`3_vsd_panel_preset`"

        'COMMAND = New MySqlCommand(query, MysqlConn)
        'READER = COMMAND.ExecuteReader
        'While READER.Read
        'Me.Proj_CompViewer.Rows.Add(READER.GetString("Supplier"), READER.GetString("Description"), READER.GetString("Quantity"), READER.GetString("Cost"))
        'End While

        'ElseIf Presets.Text = "4 VSD Panel" Then
        'MysqlConn.Open()
        'Dim READER As MySqlDataReader
        'Dim query As String
        'query = "select `Supplier`, `Description`, `Quantity`, `Cost` from `test_quotes`.`4_vsd_panel_preset`"

        'COMMAND = New MySqlCommand(query, MysqlConn)
        'READER = COMMAND.ExecuteReader
        'While READER.Read
        'Me.Proj_CompViewer.Rows.Add(READER.GetString("Supplier"), READER.GetString("Description"), READER.GetString("Quantity"), READER.GetString("Cost"))
        'End While

        'Else
        'MessageBox.Show("Please Select a Preset")
        'End If
    End Sub
End Class