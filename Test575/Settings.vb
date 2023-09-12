Imports System.IO
Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json

Public Class Settings
    Private arePresetChangesSaved As Boolean = False

    Public availablePresets As ComponentListPreset()

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fill in textboxes with current settings
        userNameTextbox.Text = My.Settings.EmployeeManagerUsername
        userPasswordTextbox.Text = My.Settings.EmployeeManagerPassword
        databaseNameTextbox.Text = My.Settings.DatabaseName
        databasePasswordTextbox.Text = My.Settings.DatabasePassword
        employeeTableNameTextbox.Text = My.Settings.EmployeeTableName
        inventoryTableNameTextbox.Text = My.Settings.InventoryTableName

        jsonToPresetList()
        populatePresetsListView()
    End Sub

    Private Sub updateDatabaseButton_Click(sender As Object, e As EventArgs) Handles updateDatabaseButton.Click
        'Update Settings
        If databaseNameTextbox.Text <> My.Settings.DatabaseName Then
            My.Settings.DatabaseName = databaseNameTextbox.Text
        End If

        If databasePasswordTextbox.Text <> My.Settings.DatabasePassword Then
            My.Settings.DatabasePassword = databasePasswordTextbox.Text
        End If

        If employeeTableNameTextbox.Text <> My.Settings.EmployeeTableName Then
            My.Settings.EmployeeTableName = employeeTableNameTextbox.Text
        End If

        If inventoryTableNameTextbox.Text <> My.Settings.InventoryTableName Then
            My.Settings.InventoryTableName = inventoryTableNameTextbox.Text
        End If

        MessageBox.Show("Settings Updated")
    End Sub

    Private Sub updateAuthButton_Click(sender As Object, e As EventArgs) Handles updateAuthButton.Click
        Try
            'Update Settings
            If userNameTextbox.Text <> My.Settings.EmployeeManagerUsername Then
                My.Settings.EmployeeManagerUsername = userNameTextbox.Text
            End If

            If userPasswordTextbox.Text <> My.Settings.EmployeeManagerPassword Then
                My.Settings.EmployeeManagerPassword = userPasswordTextbox.Text
            End If
        Catch ex As Exception
            MessageBox.Show(ex, "Error")
        End Try
    End Sub

    Private Sub openComponentListTextbox_Click(sender As Object, e As EventArgs) Handles openComponentListTextbox.Click
        StockViewer.Show()
    End Sub

    Private Sub listOfPresets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listOfPresets.SelectedIndexChanged
        populatePresetDetailsView(listOfPresets.SelectedItem.ToString())
        Console.WriteLine(listOfPresets.SelectedItem.ToString())
    End Sub

    Sub jsonToPresetList()
        Dim presetFileLocation As String = "../../Resources/presets.json"

        If File.Exists(presetFileLocation) Then
            Dim presetJsonData As String = File.ReadAllText(presetFileLocation)
            availablePresets = JsonConvert.DeserializeObject(Of ComponentListPreset())(presetJsonData)
        End If
    End Sub

    Sub populatePresetsListView()
        For i As Int32 = 0 To availablePresets.Length - 1 Step +1
            listOfPresets.Items.Add(availablePresets(i).presetName)
        Next
    End Sub

    Sub populatePresetDetailsView(presetSelected As String)
        presetDetailsView.Rows.Clear()

        For i As Int32 = 0 To availablePresets.Length - 1 Step +1
            If availablePresets(i).presetName = presetSelected Then
                For j As Int32 = 0 To availablePresets(i).components.Count - 1 Step +1
                    Dim componentCode As String = availablePresets(i).components(j).code
                    Dim quantity As Int32 = availablePresets(i).components(j).quantity
                    Dim markUp As String = availablePresets(i).components(j).markUp.ToString() + "%"

                    Dim descAndCost As (String, Double) = findItemInDatabase(componentCode)

                    Dim description As String = descAndCost.Item1
                    Dim cost As Double = descAndCost.Item2

                    Console.WriteLine(componentCode & ": " & cost)

                    Dim totalCost As Double = calculateCostOfComponent(cost, quantity, availablePresets(i).components(j).markUp)

                    presetDetailsView.Rows.Add(componentCode, description, quantity, markUp, totalCost)
                Next
            End If
        Next
    End Sub

    Sub addNewComponent()
        Dim quantity = componentQuantity.Text
        Dim percentageAddOn = componentMarkUp.Text

        If String.IsNullOrEmpty(quantity) = False And String.IsNullOrEmpty(percentageAddOn) = False Then
            Dim totalCost As Double

            'Simplifying variable names
            Dim description As String = ""
            Dim cost As String = ""

            If String.IsNullOrWhiteSpace(componentCode.Text) = False Then
                'Fetching missing data from database
                Dim databaseInformation As (String, Double)
                databaseInformation = findItemInDatabase(componentCode.Text)
                description = databaseInformation.Item1
                cost = databaseInformation.Item2
            End If

            'Calculating cost of componant
            totalCost = calculateCostOfComponent(cost, quantity, percentageAddOn)

            'Checking if componant already exists in table and adding componant appropriatly depending on if it is or not
            Dim componantExists As Boolean = False
            Dim componantIndex As Int32
            For i As Int32 = 0 To presetDetailsView.Rows.Count - 1 Step +1
                If presetDetailsView.Rows(i).Cells(0).Value.ToString() = componentCode.Text.ToUpper() Then
                    componantExists = True
                    componantIndex = i
                End If
            Next

            If componantExists = True Then
                presetDetailsView.Rows(componantIndex).Cells(2).Value = quantity + Convert.ToInt32(presetDetailsView.Rows(componantIndex).Cells(2).Value)
                presetDetailsView.Rows(componantIndex).Cells(4).Value = totalCost + Convert.ToDouble(presetDetailsView.Rows(componantIndex).Cells(4).Value)
            Else
                Dim markupTaxt = percentageAddOn.ToString() & "%"
                presetDetailsView.Rows.Add((componentCode.Text).ToUpper(), description, quantity, markupTaxt, totalCost)
            End If
        Else
            MessageBox.Show("Please make sure the estimated needed amount and percentage add-on are filled in")
        End If
    End Sub

    Function calculateCostOfComponent(unitCost As Double, quantity As Int32, markUp As Double)
        Return (unitCost * quantity) * ((100 + markUp) / 100)
    End Function

    Function findItemInDatabase(componentCode As String)
        Dim databaseSearchResults As (String, Double) = ("", 0.00)

        Dim sqlConnection As New MySqlConnection
        sqlConnection.ConnectionString = "Server=Localhost;Userid=root;password=" & My.Settings.DatabasePassword & ";database=" & My.Settings.DatabaseName

        Dim reader As MySqlDataReader

        Try
            sqlConnection.Open()

            Dim query As String = "Select * From " & My.Settings.InventoryTableName & " where (`ID` = '" & componentCode & "')"
            Dim command As New MySqlCommand(query, sqlConnection)
            reader = command.ExecuteReader

            While reader.Read
                databaseSearchResults.Item1 = reader.GetString("Description")
                databaseSearchResults.Item2 = reader.GetDouble("Cost")
            End While

            Console.WriteLine(databaseSearchResults.Item2)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            sqlConnection.Close()
            sqlConnection.Dispose()
        End Try

        Return databaseSearchResults
    End Function

    Private Sub addComponentButton_Click(sender As Object, e As EventArgs) Handles addComponentButton.Click
        addNewComponent()
    End Sub
End Class