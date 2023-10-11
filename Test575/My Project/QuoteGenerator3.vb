Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Imports Test575.standardProgramFunctions
Imports Newtonsoft.Json
Imports System.IO

Public Class QuoteGenerator3
    Public presetsData As List(Of ComponentListPreset)
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

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        'Getting Componant Information
        Dim componantInformation As (String, String, Double)
        componantInformation = findItemInDatabase(Proj_CompID.Text, False)

        'Filling in textboxes
        Proj_CompSupply.Text = componantInformation.Item1
        Proj_CompDesc.Text = componantInformation.Item2
        Proj_CompCost.Text = componantInformation.Item3
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'cost of component + percentage add on calculator and adding to dgv
        addItemToProposedHardwareTable()
    End Sub

    Private Sub QuoteGenerator3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate preset dropdown
        JsonToPresetList()
        For i As Integer = 0 To presetsData.Count - 1 Step +1
            Presets.Items.Add(presetsData(i).presetName)
        Next

        Proj_CompTotal.Text = "€" + componantsTotal.ToString()
        Me.AutoScroll = True
    End Sub

    Private Sub QuoteGenerator_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        If e.CloseReason = CloseReason.UserClosing Then
            endQuoteCreation(e)
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click ' Next Page(Top)
        goToNextPage()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        goToLastPage()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FillDatagridViewWithPresetData()
    End Sub

    Private Sub Proj_CompID_TextChanged(sender As Object, e As EventArgs) Handles Proj_CompID.TextChanged
        Dim componentInformation = findItemInDatabase(Proj_CompID.Text, False)

        Proj_CompSupply.Text = componentInformation.Item1
        Proj_CompDesc.Text = componentInformation.Item2
        Proj_CompCost.Text = componentInformation.Item3
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
        page4.componentsTotal = Proj_CompTotal.Text.Replace("€", "")
        page4.Show()
        Me.Hide()
    End Sub

    Sub JsonToPresetList()
        Dim presetFileLocation As String = "../../Resources/presets.json"
        Dim presetArray As ComponentListPreset()

        If File.Exists(presetFileLocation) Then
            Dim presetJsonData As String = File.ReadAllText(presetFileLocation)
            presetArray = JsonConvert.DeserializeObject(Of ComponentListPreset())(presetJsonData)
            presetsData = presetArray.ToList()
        End If
    End Sub

    Private Sub PresetDetailsView_Delete(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Proj_CompViewer.KeyDown
        ' If Delete button on keyboard is pressed
        If (e.KeyCode = Keys.Delete) Then
            Dim componentIndex As Integer = Proj_CompViewer.SelectedCells.Item(0).RowIndex

            componantsTotal -= Proj_CompViewer.Rows(componentIndex).Cells(3).Value
            Proj_CompTotal.Text = componantsTotal.ToString("C2")
        End If
    End Sub

    Function findItemInDatabase(componentCode, calledFromButton)
        Dim databaseSearchResults As (String, String, Double, Boolean) = ("", "", 0.00, False)

        'Simplifying variable names
        Dim componentId = componentCode

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
                databaseSearchResults.Item4 = True
            Else
                If calledFromButton Then
                    MessageBox.Show("Something went wrong")
                End If
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
        Dim code = Proj_CompID.Text
        Dim quantity = Proj_CompTakeOut.Text
        Dim percentageAddOn = Proj_CompPrecentage.Text

        If ValidateComponentExists(code) Then
            If String.IsNullOrEmpty(quantity) = False And String.IsNullOrEmpty(percentageAddOn) = False And String.IsNullOrEmpty(Proj_CompID.Text) = False Then
                Dim totalCost As Decimal

                'Simplifying variable names
                Dim supplier As String = Proj_CompSupply.Text
                Dim description As String = Proj_CompDesc.Text
                Dim cost As String = Proj_CompCost.Text

                If String.IsNullOrWhiteSpace(supplier) Or String.IsNullOrWhiteSpace(description) Or String.IsNullOrWhiteSpace(cost) Then
                    'Fetching missing data from database
                    Dim databaseInformation As (String, String, Double)
                    Dim componentCode As String = Proj_CompID.Text
                    databaseInformation = findItemInDatabase(componentCode, False)
                    supplier = databaseInformation.Item1
                    description = databaseInformation.Item2
                    cost = databaseInformation.Item3
                End If

                'Calculating cost of component
                totalCost = (cost * quantity) * ((100 + percentageAddOn) / 100)

                'Checking if component already exists in table and adding component appropriately depending on if it is or not
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
                    Dim newTotal As Double = totalCost + Proj_CompViewer.Rows(componantIndex).Cells(3).Value
                    Proj_CompViewer.Rows(componantIndex).Cells(3).Value = newTotal.ToString("C")
                Else
                    Proj_CompViewer.Rows.Add(supplier, description, quantity, totalCost.ToString("C"))
                End If

                'Increasing total componants value
                componantsTotal += totalCost
                Proj_CompTotal.Text = componantsTotal.ToString("c")

            Else
                MessageBox.Show("Please make sure all necessary boxes are filled in before adding a component")
            End If
        Else
            MessageBox.Show("Component does not exist in database", "Error")
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

    Sub FillDatagridViewWithPresetData()
        Dim presetName As String = Presets.Text
        Dim presetExists As Boolean = False
        Dim presetIndex As Integer
        Dim atLeastOneMissingComponet As Boolean
        Dim missingComponants As New List(Of String)

        For i As Integer = 0 To presetsData.Count - 1 Step +1
            If presetsData(i).presetName = presetName Then
                presetExists = True
                presetIndex = i
            End If
        Next

        If presetExists = True Then
            'Reset table/remove any existing stuff
            For i As Integer = 0 To Proj_CompViewer.Rows.Count - 1 Step +1
                componantsTotal -= Proj_CompViewer.Rows(i).Cells(3).Value
            Next
            Proj_CompViewer.Rows.Clear()

            For i As Integer = 0 To presetsData(presetIndex).components.Count - 1 Step +1
                'Fill in component missing data
                Dim databaseSearchResults As (String, String, Double, Boolean)
                Dim componentCode As String = presetsData(presetIndex).components(i).code
                Dim supplier As String
                Dim description As String
                Dim costPerUnit As Double
                Dim componantExistsInDatabase As Boolean

                databaseSearchResults = findItemInDatabase(componentCode, False)

                supplier = databaseSearchResults.Item1
                description = databaseSearchResults.Item2
                costPerUnit = databaseSearchResults.Item3
                componantExistsInDatabase = databaseSearchResults.Item4

                'Calculate total cost of component type
                Dim quantity = presetsData(presetIndex).components(i).quantity
                Dim markUp = presetsData(presetIndex).components(i).markUp

                Dim totalCost = (costPerUnit * quantity) * ((100 + markUp) / 100)

                'Adding line to Data Grid View
                If componantExistsInDatabase = True Then
                    Dim componentExistsInDgvAlready As Boolean = False
                    Dim componentIndex As Integer
                    For j As Integer = 0 To Proj_CompViewer.Rows.Count - 1 Step +1
                        If Proj_CompViewer.Rows(j).Cells(1).Value.ToString() = description Then
                            componentExistsInDgvAlready = True
                            componentIndex = j
                        End If
                    Next

                    If componentExistsInDgvAlready = True Then
                        Proj_CompViewer.Rows(componentIndex).Cells(2).Value = quantity + Convert.ToInt32(Proj_CompViewer.Rows(componentIndex).Cells(2).Value)
                        Proj_CompViewer.Rows(componentIndex).Cells(3).Value = totalCost + Convert.ToDouble(Proj_CompViewer.Rows(componentIndex).Cells(3).Value)
                    Else
                        Proj_CompViewer.Rows.Add(supplier, description, quantity, totalCost.ToString("C"))
                    End If
                Else
                    missingComponants.Add(componentCode.ToString())
                    atLeastOneMissingComponet = True
                End If

                'Updating componentns total
                componantsTotal += totalCost
                Proj_CompTotal.Text = componantsTotal.ToString("C")
            Next
            'If there were components missing, alert use to which ones are
            If atLeastOneMissingComponet = True Then
                MessageBox.Show($"Some componants could not be found in the database and were skipped. Missing compnants: {String.Join(", ", missingComponants)}")
            End If
        End If
    End Sub

    Function ValidateComponentExists(componentCode)
        Dim componentExists As Boolean = False

        Dim sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "Server=Localhost;Userid=root;password=" & My.Settings.DatabasePassword & ";database=" & My.Settings.DatabaseName

        Try
            sqlConnection.Open()

            Dim query As String = $"SELECT COUNT(*) FROM {My.Settings.InventoryTableName} WHERE (`ID` = '{componentCode}')"
            Dim command As New MySqlCommand(query, sqlConnection)

            If (command.ExecuteScalar() >= 1) Then
                componentExists = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            sqlConnection.Close()
            sqlConnection.Dispose()
        End Try

        Return componentExists
    End Function

End Class