Imports System.IO
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json

Public Class Settings
    Private arePresetChangesSaved As Boolean = False

    Public presetArray As ComponentListPreset()
    Public availablePresets As List(Of ComponentListPreset)

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True

        'Fill in textboxes with current settings
        userNameTextbox.Text = My.Settings.EmployeeManagerUsername
        userPasswordTextbox.Text = My.Settings.EmployeeManagerPassword
        databaseNameTextbox.Text = My.Settings.DatabaseName
        databasePasswordTextbox.Text = My.Settings.DatabasePassword
        employeeTableNameTextbox.Text = My.Settings.EmployeeTableName
        inventoryTableNameTextbox.Text = My.Settings.InventoryTableName

        componentCode.ReadOnly = True
        componentQuantity.ReadOnly = True
        componentMarkUp.ReadOnly = True

        JsonToPresetList()
        PopulatePresetsListView()
    End Sub

    Private Async Sub Settings_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Await PopulateComponentsViewer()
    End Sub

    Private Sub Settings_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        UpdatePresetsJsonFile()
        MainMenu.BringToFront()
    End Sub

    Private Sub UpdateDatabaseButton_Click(sender As Object, e As EventArgs) Handles updateDatabaseButton.Click
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

    Private Sub UpdateAuthButton_Click(sender As Object, e As EventArgs) Handles updateAuthButton.Click
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

    Private Sub OpenComponentListTextbox_Click(sender As Object, e As EventArgs) Handles openComponentListTextbox.Click
        StockViewer.Show()
    End Sub

    Private Sub ListOfPresets_MouseClick(sender As Object, e As EventArgs) Handles listOfPresets.MouseClick
        If listOfPresets.SelectedItem = Nothing Then
            componentCode.ReadOnly = True
            componentQuantity.ReadOnly = True
            componentMarkUp.ReadOnly = True
            Return
        Else
            componentCode.ReadOnly = False
            componentQuantity.ReadOnly = False
            componentMarkUp.ReadOnly = False
            PopulatePresetDetailsView(listOfPresets.SelectedItem.ToString())
        End If
    End Sub

    Private Sub AddComponentButton_Click(sender As Object, e As EventArgs) Handles addComponentButton.Click
        Dim componentExists = False

        For i As Integer = 0 To presetDetailsView.Rows.Count - 1 Step +1
            If (presetDetailsView.Rows(i).Cells(0).Value = componentCode.Text.ToUpper()) Then
                componentExists = True
            End If
        Next

        If componentExists = True Then
            UpdateExistingComponentInPreset()
        Else
            AddComponentToPreset(listOfPresets.SelectedItem)
        End If
    End Sub

    Private Sub DeletePresetButton_Click(sender As Object, e As EventArgs) Handles deletePresetButton.Click
        Dim itemFound As Boolean = False

        For i As Integer = availablePresets.Count - 1 To 0 Step -1
            If availablePresets(i).presetName = listOfPresets.SelectedItem.ToString() Then
                itemFound = True
            End If
        Next

        If itemFound = True Then
            DeletePreset(listOfPresets.SelectedItem.ToString(), listOfPresets.SelectedIndex.ToString())
        End If
    End Sub

    Private Sub AddPresetButton_Click(sender As Object, e As EventArgs) Handles addPresetButton.Click
        If ValidatePresetName(newPresetName.Text) Then
            availablePresets.Add(New ComponentListPreset(newPresetName.Text))
            PopulatePresetsListView()
        Else
            MessageBox.Show("Invalid Name. Please make you entered a name and that the preset doesn't already exist", "Error")
        End If
    End Sub

    Private Sub ClearPresetButton_Click(sender As Object, e As EventArgs) Handles clearPresetButton.Click
        ClearPresetComponents(listOfPresets.SelectedItem)
        listOfPresets.SelectedItem = listOfPresets.Items.Count - 1
    End Sub

    Private Sub ComponentViewer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ComponentViewer.CellClick
        'Making sure cell clicked is not a header cell
        If e.RowIndex >= 0 Then
            ComponentId.Text = ComponentViewer.Rows(e.RowIndex).Cells(0).Value
            ComponentSupplier.Text = ComponentViewer.Rows(e.RowIndex).Cells(1).Value
            ComponentDescription.Text = ComponentViewer.Rows(e.RowIndex).Cells(2).Value
            ComponentCost.Text = ComponentViewer.Rows(e.RowIndex).Cells(3).Value
        Else
            MessageBox.Show("Please select a valid cell")
        End If
    End Sub

    Private Sub PresetDetailsViewer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles presetDetailsView.CellClick

        'Making sure cell clicked is not a header cell
        If e.RowIndex >= 0 Then
            componentCode.Text = presetDetailsView.Rows(e.RowIndex).Cells(0).Value
            componentQuantity.Text = presetDetailsView.Rows(e.RowIndex).Cells(2).Value
            componentMarkUp.Text = presetDetailsView.Rows(e.RowIndex).Cells(3).Value
        Else
            MessageBox.Show("Please select a valid cell")
        End If
    End Sub

    Private Sub PresetDetailsView_Delete(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles presetDetailsView.KeyDown
        ' If Delete button on keyboard is pressed
        If (e.KeyCode = Keys.Delete) Then
            'Variables
            Dim componentToBeDeletedIndex As Integer = presetDetailsView.SelectedCells.Item(0).RowIndex
            Dim presetIndex As Integer
            Dim presetExists As Boolean = False

            'Find preset index
            For i As Integer = 0 To availablePresets.Count - 1 Step +1
                If availablePresets(i).presetName = listOfPresets.SelectedItem Then
                    presetExists = True
                    presetIndex = i
                End If
            Next

            'Removing component from correct preset
            If presetExists = True Then
                For i As Integer = availablePresets(presetIndex).components.Count - 1 To 0 Step -1
                    If availablePresets(presetIndex).components(i).code = presetDetailsView.Rows(componentToBeDeletedIndex).Cells(0).Value Then
                        availablePresets(presetIndex).components.RemoveAt(i)
                    End If
                Next
            End If
        End If
    End Sub

    Sub JsonToPresetList()
        Dim presetFileLocation As String = "../../Resources/presets.json"

        If File.Exists(presetFileLocation) Then
            Dim presetJsonData As String = File.ReadAllText(presetFileLocation)
            presetArray = JsonConvert.DeserializeObject(Of ComponentListPreset())(presetJsonData)
            availablePresets = presetArray.ToList()
        End If
    End Sub

    Function ValidatePresetName(presetName As String)
        Dim nameIsValid = True

        If (String.IsNullOrEmpty(presetName)) Then
            nameIsValid = False
        Else
            For i As Integer = 0 To availablePresets.Count - 1 Step +1
                If availablePresets(i).presetName.ToString().ToUpper() = presetName.ToUpper() Then
                    nameIsValid = False
                End If
            Next
        End If

        Return nameIsValid
    End Function

    Sub PopulatePresetsListView()
        For i As Int32 = 0 To availablePresets.Count - 1 Step +1
            If listOfPresets.Items.Contains(availablePresets(i).presetName) = False Then
                listOfPresets.Items.Add(availablePresets(i).presetName)
            End If
        Next
    End Sub

    Sub PopulatePresetDetailsView(presetSelected As String)
        presetDetailsView.Rows.Clear()

        For i As Int32 = 0 To availablePresets.Count - 1 Step +1
            If availablePresets(i).presetName = presetSelected Then
                For j As Integer = 0 To availablePresets(i).components.Count - 1 Step +1
                    Dim componentCode As String = availablePresets(i).components(j).code
                    Dim quantity As Int32 = availablePresets(i).components(j).quantity
                    Dim markUp As String = availablePresets(i).components(j).markUp.ToString() + "%"

                    Dim descAndCost As (String, Double) = FindItemInDatabase(componentCode)

                    Dim description As String = descAndCost.Item1

                    Dim cost As Double = descAndCost.Item2
                    Dim totalCost As Double = CalculateCostOfComponent(cost, quantity, availablePresets(i).components(j).markUp)

                    presetDetailsView.Rows.Add(componentCode, description, quantity, markUp, Format(totalCost, "N2"))
                Next
            End If
        Next
    End Sub

    Sub AddComponentToPreset(presetName)
        Dim code = componentCode.Text
        Dim quantity = componentQuantity.Text
        Dim percentageAddOn = componentMarkUp.Text
        If listOfPresets.SelectedItem = Nothing Then
            MessageBox.Show("Please select a preset before adding components")
        Else
            If ValidateComponentExists(code) Then
                If String.IsNullOrEmpty(quantity) = False And String.IsNullOrEmpty(percentageAddOn) = False Then

                    Dim totalCost As Double

                    'Simplifying variable names
                    Dim description As String = ""
                    Dim cost As String = ""

                    If String.IsNullOrWhiteSpace(code) = False Then
                        'Fetching missing data from database
                        Dim databaseInformation As (String, Double)
                        databaseInformation = FindItemInDatabase(code)
                        description = databaseInformation.Item1
                        cost = databaseInformation.Item2
                    End If

                    'Calculating cost of component
                    totalCost = CalculateCostOfComponent(cost, quantity, percentageAddOn)

                    'Getting index of preset from List()
                    Console.WriteLine($"Adding object to {presetName}")
                    Dim presetExists As Boolean = False
                    Dim presetIndex As Integer = Nothing
                    For i As Integer = 0 To availablePresets.Count - 1 Step +1
                        If availablePresets(i).presetName = presetName Then
                            presetExists = True
                            presetIndex = i
                        End If
                    Next

                    If presetExists = True Then
                        Dim componentExits As Boolean = False
                        Dim componentIndex As Integer

                        'Cycling through preset's components to see if it exists and to get its index
                        For j As Integer = 0 To availablePresets(presetIndex).components.Count - 1 Step +1
                            If availablePresets(presetIndex).components(j).code = code.ToUpper() Then
                                componentExits = True
                                componentIndex = j
                            End If
                        Next

                        'Adding component or updating component's information based on if it already exists or not
                        If componentExits = True Then
                            availablePresets(presetIndex).components(componentIndex).quantity += quantity
                            availablePresets(presetIndex).components(componentIndex).markUp = percentageAddOn
                            PopulatePresetDetailsView(availablePresets(presetIndex).presetName)
                        Else
                            availablePresets(presetIndex).components.Add(New Component(componentCode.Text.ToUpper(), quantity, percentageAddOn))
                            PopulatePresetDetailsView(availablePresets(presetIndex).presetName)
                        End If
                    Else
                        MessageBox.Show("Cannot find the correct preset to add to")
                    End If

                Else
                    MessageBox.Show("Please make sure the estimated needed amount and percentage add-on are filled in")
                End If
            Else
                MessageBox.Show("Item does not exist")
            End If
        End If
    End Sub

    Sub UpdateExistingComponentInPreset()
        Dim componentIndex As Integer

        For i As Integer = 0 To availablePresets.Count - 1 Step +1
            If (availablePresets(listOfPresets.SelectedIndex).components(i).code = componentCode.Text.ToUpper()) Then
                componentIndex = i
            End If
        Next

        If String.IsNullOrEmpty(componentQuantity.Text) = False Then
            availablePresets(listOfPresets.SelectedIndex).components(componentIndex).quantity = componentQuantity.Text
        End If

        If String.IsNullOrEmpty(componentMarkUp.Text) = False Then
            availablePresets(listOfPresets.SelectedIndex).components(componentIndex).markUp = componentMarkUp.Text
        End If

        PopulatePresetDetailsView(listOfPresets.SelectedItem)
    End Sub

    Function CalculateCostOfComponent(unitCost As Double, quantity As Int32, markUp As Double)
        Return (unitCost * quantity) * ((100 + markUp) / 100)
    End Function

    Function FindItemInDatabase(componentCode As String)
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

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            sqlConnection.Close()
            sqlConnection.Dispose()
        End Try

        Return databaseSearchResults
    End Function

    Sub DeletePreset(presetName, presetIndex)
        Dim confirmationMessage As String = $"Are you sure you want to delete {presetName}?"

        Dim userChoice As DialogResult = MessageBox.Show(confirmationMessage, "", MessageBoxButtons.YesNo)

        If userChoice = DialogResult.Yes Then
            For i As Integer = availablePresets.Count - 1 To 0 Step -1
                If availablePresets(i).presetName = presetName Then
                    availablePresets.RemoveAt(i)
                    listOfPresets.Items.RemoveAt(presetIndex)
                    listOfPresets.SelectedIndex = Nothing
                End If
            Next
        End If
    End Sub

    Sub ClearPresetComponents(presetName)
        Dim confirmationMessage As String = $"Are you sure you want to delete all components from {presetName}?"

        Dim userChoice As DialogResult = MessageBox.Show(confirmationMessage, "", MessageBoxButtons.YesNo)

        If userChoice = DialogResult.Yes Then
            Try
                Dim presetIndex As Integer
                Dim presetExists As Boolean = False

                For i As Integer = 0 To availablePresets.Count - 1 Step +1
                    If availablePresets(i).presetName = presetName Then
                        presetExists = True
                        presetIndex = i
                    End If
                Next

                If presetExists = True Then
                    For i As Integer = availablePresets(presetIndex).components.Count - 1 To 0 Step -1
                        availablePresets(presetIndex).components.RemoveAt(i)
                    Next
                End If

                PopulatePresetDetailsView(presetName)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        End If
    End Sub

    Sub UpdatePresetsJsonFile()
        Dim fileLocation As String = "../../Resources/presets.json"

        If File.Exists(fileLocation) Then
            Dim updatedDataAsJson = JsonConvert.SerializeObject(availablePresets, Formatting.Indented)
            'My.Computer.FileSystem.WriteAllText(fileLocation, updatedDataAsJson, False)
            Using fileWriter As New StreamWriter(fileLocation, False)
                fileWriter.Write(updatedDataAsJson)
            End Using
        End If
    End Sub

    Async Function PopulateComponentsViewer() As Task
        Dim sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "Server=Localhost;Userid=root;password=" & My.Settings.DatabasePassword & ";database=" & My.Settings.DatabaseName

        Try
            sqlConnection.Open()

            Dim command As New MySqlCommand("Select `ID`, `Supplier`, `Description`, `Cost` from `" & My.Settings.InventoryTableName & "`", sqlConnection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim inventoryTable As New DataTable

            Await command.ExecuteNonQueryAsync()

            Using adapter
                adapter.Fill(inventoryTable)
            End Using

            ComponentViewer.DataSource = inventoryTable
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        Finally
            sqlConnection.Close()
            sqlConnection.Dispose()
        End Try
    End Function

    Async Sub AddNewComponent()
        Dim sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "Server=Localhost;Userid=root;password=" & My.Settings.DatabasePassword & ";database=" & My.Settings.DatabaseName
        Try
            sqlConnection.Open()
            Dim query As String = "INSERT INTO `" & My.Settings.InventoryTableName & "` (ID, Description, Supplier, Cost) VALUES ('" & ComponentId.Text.ToUpper() & "', '" & ComponentDescription.Text & "', '" & ComponentSupplier.Text & "', '" & ComponentCost.Text & "')"

            Dim command As New MySqlCommand(query, sqlConnection)
            command.ExecuteNonQuery()

            Await PopulateComponentsViewer()
            ClearComponentTextboxes()
            MessageBox.Show("Component Added")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlConnection.Close()
            sqlConnection.Dispose()
        End Try
    End Sub

    Async Sub UpdateExistingComponent()
        Dim sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "Server=Localhost;Userid=root;password=" & My.Settings.DatabasePassword & ";database=" & My.Settings.DatabaseName

        Try
            sqlConnection.Open()

            Dim query As String = $"UPDATE {My.Settings.InventoryTableName} SET `Description`='{ComponentDescription.Text}', `Supplier`='{ComponentSupplier.Text}', `Cost`='{ComponentCost.Text}' WHERE (`ID`='{ComponentId.Text.ToUpper}')"
            Dim command As New MySqlCommand(query, sqlConnection)
            command.ExecuteNonQuery()

            Await PopulateComponentsViewer()
            ClearComponentTextboxes()
            MessageBox.Show("Component Updated")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlConnection.Close()
            sqlConnection.Dispose()
        End Try
    End Sub

    Async Sub DeleteComponent()
        Dim sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "Server=Localhost;Userid=root;password=" & My.Settings.DatabasePassword & ";database=" & My.Settings.DatabaseName

        Dim reader As MySqlDataReader

        Try
            sqlConnection.Open()

            Dim query As String = $"DELETE FROM `{My.Settings.InventoryTableName}` WHERE (`ID`='{ComponentId.Text}')"
            Dim command As New MySqlCommand(query, sqlConnection)
            reader = command.ExecuteReader

            Await PopulateComponentsViewer()
            ClearComponentTextboxes()
            MessageBox.Show("Component Records Deleted")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            sqlConnection.Close()
            sqlConnection.Dispose()
        End Try
    End Sub

    Private Sub AddAndUpdateComponentButton_Click(sender As Object, e As EventArgs) Handles AddAndUpdateComponentButton.Click
        Dim componentExists = False

        Dim validateCharacteristics As Boolean() = ValidateComponent(ComponentId.Text, ComponentCost.Text)

        If ((validateCharacteristics(0) = True) And (validateCharacteristics(1))) Then
            For i As Integer = 0 To ComponentViewer.Rows.Count - 1 Step +1
                If (ComponentViewer.Rows(i).Cells(0).Value = ComponentId.Text.ToUpper()) Then
                    componentExists = True
                End If
            Next

            If componentExists = True Then
                UpdateExistingComponent()
            Else
                AddNewComponent()
            End If
        End If

    End Sub

    Private Function ValidateComponent(id As String, cost As String)
        Dim validId = False
        Dim validCost = False

        'Validating ID
        If id.Length <> 4 Then
            MessageBox.Show("Make sure the ID you have entered is 4 characters in legnth")
        Else
            Dim test As Double
            If ((Double.TryParse(id(0), test) <> True) And (Double.TryParse(id(1), test) <> False) And (Double.TryParse(id(2), test) <> True) And (Double.TryParse(id(3), test) <> False)) Then
                validId = True
            Else
                MessageBox.Show("Please make sure the ID you have entered is in the format: letter - number - letter - number")
            End If
        End If

        'Validating Cost
        If (String.IsNullOrEmpty(cost) = False) Then
            Dim costTest
            If ((Double.TryParse(cost, costTest)) And (Regex.IsMatch(cost, "\.\d{0,2}$"))) Then
                validCost = True
            Else
                MessageBox.Show("Please make sure the unit cost of component does not contain any letters or special characters (Excluding '.')")
            End If
        End If

        Return {validId, validCost}
    End Function

    Private Sub DeleteComponentButton_Click(sender As Object, e As EventArgs) Handles DeleteComponentButton.Click
        DeleteComponent()
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

    Sub ClearComponentTextboxes()
        ComponentId.Text = ""
        ComponentDescription.Text = ""
        ComponentSupplier.Text = ""
        ComponentCost.Text = ""
    End Sub

    Private Sub presetDetailsView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles presetDetailsView.CellContentClick

    End Sub

    Private Sub ComponentViewer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ComponentViewer.CellContentClick

    End Sub
End Class