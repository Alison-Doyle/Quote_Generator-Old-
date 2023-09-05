Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Imports Test575.standardProgramFunctions

Public Class QuoteGenerator3
    Public componantsTotal As Double = 0
    Public quoteLocation As String
    Dim MysqlConn As MySqlConnection
    Dim SQL As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Previous Page Button (bottom)
        goToLastPage()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click 'Menu Button (bottom)
        returnToMainMenu()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Getting Componant Information
        Dim componantInformation As (String, String, Long)
        componantInformation = findItemInDatabase()

        'Filling in textboxes
        Proj_CompSupply.Text = componantInformation.Item1
        Proj_CompDesc.Text = componantInformation.Item2
        Proj_CompCost.Text = componantInformation.Item3
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'cost of componants + percentage add on calculator and adding to dgv
        addItemToProposedHardwareTable()
    End Sub

    Private Sub QuoteGenerator3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Proj_CompTotal.Text = "€" + componantsTotal.ToString()
        Me.AutoScroll = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click ' Next Page(Top)
        goToNextPage()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        goToLastPage()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        returnToMainMenu()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click ' Next Page(Bottom)
        goToNextPage()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        StockViewer.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click 'INSERT BUTTON @ BOTTOM OF PAGE
        populateDocumentSection4()
    End Sub

    Sub goToLastPage()
        Dim page2 = QuoteGenerator2
        page2.quoteLocation = quoteLocation
        page2.Show()
        Me.Hide()
    End Sub

    Sub goToNextPage()
        Dim page4 = QuoteGenerator4
        page4.quoteLocation = quoteLocation
        page4.componantsTotal = componantsTotal
        page4.Show()
        Me.Hide()
    End Sub

    Function findItemInDatabase()
        Dim databaseSearchResults As (String, String, Long) = ("", "", 0.00)

        'Simplifying variable names
        Dim componentId = Proj_CompID.Text

        'Connection Variables
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "Server=Localhost;Userid=root;password=" & My.Settings.DatabasePassword & ";database=" & My.Settings.DatabaseName

        Try
            MysqlConn.Open()

            Dim query As String = "Select * from " & My.Settings.DatabaseName & "." & My.Settings.InventoryTableName & " where ID='" & componentId & "'"
            Dim command As New MySqlCommand(query, MysqlConn)
            Dim reader As MySqlDataReader

            reader = command.ExecuteReader

            'Checking if item exists
            Dim i As Integer = 0
            While reader.Read
                i += 1
            End While

            If i = 1 Then
                databaseSearchResults.Item1 = reader.GetString("Supplier")
                databaseSearchResults.Item2 = reader.GetString("Description")
                databaseSearchResults.Item3 = reader.GetDouble("Cost")
            Else
                MessageBox.Show("Something went wrong")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Close()
            MysqlConn.Dispose()
        End Try

        Return databaseSearchResults
    End Function

    Sub addItemToProposedHardwareTable()
        Dim quantity = Proj_CompTakeOut.Text
        Dim percentageAddOn = Proj_CompPrecentage.Text

        If String.IsNullOrEmpty(quantity) = False And String.IsNullOrEmpty(percentageAddOn) = False Then
            Dim totalCost As Decimal

            'Simplifying variable names
            Dim supplier As String = Proj_CompSupply.Text
            Dim description As String = Proj_CompDesc.Text
            Dim cost As String = Proj_CompCost.Text

            If String.IsNullOrWhiteSpace(supplier) Or String.IsNullOrWhiteSpace(description) Or String.IsNullOrWhiteSpace(cost) Then
                'Fetching missing data from database
                Dim databaseInformation As (String, String, Long)
                databaseInformation = findItemInDatabase()
                supplier = databaseInformation.Item1
                description = databaseInformation.Item2
                cost = databaseInformation.Item3
            End If

            'Calculating cost of componant
            totalCost = (cost * quantity) + (percentageAddOn * (cost * quantity))

            'Checking if componant already exists in table and adding componant appropriatly depending on if it is or not
            Dim componantExists As Boolean = False
            Dim componantIndex As Integer
            For i As Integer = 0 To Proj_CompViewer.Rows.Count - 1 Step +1
                If Proj_CompViewer.Rows(i).Cells(1).Value.ToString() = description Then
                    componantExists = True
                    componantIndex = i
                End If
            Next

            If componantExists = True Then
                Proj_CompViewer.Rows(componantIndex).Cells(2).Value = quantity + Convert.ToInt32(Proj_CompViewer.Rows(componantIndex).Cells(2).Value)
                Proj_CompViewer.Rows(componantIndex).Cells(3).Value = totalCost + Convert.ToDouble(Proj_CompViewer.Rows(componantIndex).Cells(3).Value)
            Else
                Proj_CompViewer.Rows.Add(supplier, description, quantity, totalCost)
            End If

            'Increasing total componants value
            componantsTotal += totalCost
            Proj_CompTotal.Text = "€" + componantsTotal.ToString()

        Else
            MessageBox.Show("Please make sure the estimated needed amount and percentage add-on are filled in")
        End If
    End Sub

    Sub populateDocumentSection4()
        'Simplifying Names
        Dim plcDescription As String = Proj_DescPLC.Text
        Dim scadaAndHmiDescription As String = Proj_DescSCADA.Text

        'Excel Variables
        Dim excelApp As New Excel.Application
        Const firstHardwareCellYAxisValue = 8
        Const plcDescriptionCell = "BV7"
        Const scadaAndHmiDescriptionCell = "CE7"

        Try
            'Open Excel and File
            excelApp.Visible = False
            excelApp.Workbooks.Open(quoteLocation)
            excelApp.Sheets("Sheet1").activate()

            'Filling in hardware
            For i As Integer = 0 To Proj_CompViewer.Rows.Count - 1 Step +1
                If i + firstHardwareCellYAxisValue <= 46 Then
                    excelApp.Range("BM" + (firstHardwareCellYAxisValue + i).ToString()).Value = Proj_CompViewer.Rows(i).Cells(0).Value.ToString()
                    excelApp.Range("BO" + (firstHardwareCellYAxisValue + i).ToString()).Value = Proj_CompViewer.Rows(i).Cells(1).Value.ToString()
                End If
            Next

            'Filling in descriptions
            excelApp.Range(plcDescriptionCell).Value = plcDescription
            excelApp.Range(scadaAndHmiDescriptionCell).Value = scadaAndHmiDescription

            MessageBox.Show("Section 4 filled in")
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