Imports DocumentFormat.OpenXml.Drawing

Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fill in textboxes with current settings
        userNameTextbox.Text = My.Settings.EmployeeManagerUsername
        userPasswordTextbox.Text = My.Settings.EmployeeManagerPassword
        databaseNameTextbox.Text = My.Settings.DatabaseName
        databasePasswordTextbox.Text = My.Settings.DatabasePassword
        employeeTableNameTextbox.Text = My.Settings.EmployeeTableName
        inventoryTableNameTextbox.Text = My.Settings.InventoryTableName
    End Sub

    Private Sub updateSettingsButton_Click(sender As Object, e As EventArgs) Handles updateSettingsButton.Click
        'Update Settings
        If userNameTextbox.Text <> My.Settings.EmployeeManagerUsername Then
            My.Settings.EmployeeManagerUsername = userNameTextbox.Text
        End If

        If userPasswordTextbox.Text <> My.Settings.EmployeeManagerPassword Then
            My.Settings.EmployeeManagerPassword = userPasswordTextbox.Text
        End If

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
End Class