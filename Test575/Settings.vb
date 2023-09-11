Imports System.IO
Imports System.Reflection.Emit
Imports DocumentFormat.OpenXml.Drawing
Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Settings
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
        For i As Integer = 0 To availablePresets.Length - 1 Step +1
            listOfPresets.Items.Add(availablePresets(i).presetName)
        Next
    End Sub

    Sub populatePresetDetailsView(presetSelected As String)
        presetDetailsView.Rows.Clear()

        For i As Integer = 0 To availablePresets.Length - 1 Step +1
            If availablePresets(i).presetName = presetSelected Then
                For j As Integer = 0 To availablePresets(i).components.Count - 1 Step +1
                    Dim componentCode As String = availablePresets(i).components(j).code
                    Dim quantity As Integer = availablePresets(i).components(j).quantity
                    Dim markUp As String = availablePresets(i).components(j).markUp.ToString() + "%"

                    Dim description As String

                    presetDetailsView.Rows.Add(componentCode, description, quantity, markUp, "")
                Next
            End If
        Next
    End Sub

    Function fetchComponentData(componentCode As String)
        Dim componentData As Tuple(Of String, Double)
        Dim description As String = ""
        Dim cost As Double = 0
        Dim sqlConnection As MySqlConnection

        sqlConnection = New MySqlConnection
        sqlConnection.ConnectionString = "Server=Localhost;Userid=root;password=" & My.Settings.DatabasePassword & ";database=" & My.Settings.DatabaseName

        Try
            sqlConnection.Open()

            Dim descriptionCommand As New MySqlCommand("SELECT `Description` FROM `" & My.Settings.InventoryTableName & "` WHERE ID = '" & componentCode & "';", sqlConnection)
            Dim costCommand As New MySqlCommand("SELECT `Cost` FROM `" & My.Settings.InventoryTableName & "` WHERE ID = '" & componentCode & "';", sqlConnection)
            Dim reader As MySqlDataReader
            Dim costReader As MySqlDataReader

            reader = descriptionCommand.ExecuteReader
            If reader.Read Then
                description = reader.GetString("Description")
            End If
        Catch ex As Exception
            MessageBox.Show(ex, "Error")
        Finally
            sqlConnection.Close()
            sqlConnection.Dispose()
        End Try

        Return description
    End Function

    Sub addNewComponent()

    End Sub
End Class