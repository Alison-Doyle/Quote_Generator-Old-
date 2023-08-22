
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

    Private Sub Proj_FunctView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Proj_FunctView.CellContentClick


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click 'INSERT BUTTON @ BOTTOM OF FORM
        MyExcel.Workbooks.Open("C:\Users\Admin\Desktop\" & QuoteGen.Doc_FileName.Text)
        MyExcel.Sheets("Sheet1").activate()

        MyExcel.Range("AL6").Activate()             'Proj Desc
        MyExcel.Range("AL6").Value = Proj_Desc.Text



        MyExcel.ActiveSheet.Shapes.AddPicture(Proj_DiagramPath.Text, True, True, 2208, 83, Img_Width.Text, Img_Height.Text)


        MyExcel.Range("BD16:BG44").Activate() 'FILLING IN FUNCTIONS OF PANEL
        Try
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

                MyExcel.Range("BD42").Value = Proj_FunctView.Rows(i).Cells(0).Value.ToString()
                MyExcel.Range("BF42").Value = Proj_FunctView.Rows(i).Cells(1).Value.ToString()
                MyExcel.Range("BG42").Value = Proj_FunctView.Rows(i).Cells(2).Value.ToString()
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

        MyExcel.ActiveWorkbook.Close(SaveChanges:=True)
        MyExcel.Quit()

        Runtime.InteropServices.Marshal.ReleaseComObject(MyExcel.Workbooks)



        MessageBox.Show("Quote Updated")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'ADDING IMAGE
        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "png Images|*.png|jpeg Images|*.jpg,*.jpeg"}
            If ofd.ShowDialog() = DialogResult.OK Then
                Proj_DiagramPath.Text = ofd.FileName
            End If
        End Using

        Dim bmp As New Bitmap(Proj_DiagramPath.Text)
        Img_Height.Text = bmp.Height.ToString() * 0.75
        Img_Width.Text = bmp.Width.ToString() * 0.75
    End Sub
End Class