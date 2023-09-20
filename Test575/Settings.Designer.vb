<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.databaseSettingsContainer = New System.Windows.Forms.GroupBox()
        Me.employeeTableNameTextbox = New System.Windows.Forms.TextBox()
        Me.updateDatabaseButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inventoryTableNameTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.databasePasswordTextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.databaseNameTextbox = New System.Windows.Forms.TextBox()
        Me.databaseNameLabel = New System.Windows.Forms.Label()
        Me.authorizationSettingsContainer = New System.Windows.Forms.GroupBox()
        Me.updateAuthButton = New System.Windows.Forms.Button()
        Me.userPasswordTextbox = New System.Windows.Forms.TextBox()
        Me.userPasswordLabel = New System.Windows.Forms.Label()
        Me.userNameTextbox = New System.Windows.Forms.TextBox()
        Me.userNameLabel = New System.Windows.Forms.Label()
        Me.presets = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.componentCode = New System.Windows.Forms.TextBox()
        Me.addComponentButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.openComponentListTextbox = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.componentQuantity = New System.Windows.Forms.TextBox()
        Me.componentMarkUp = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.newPresetName = New System.Windows.Forms.TextBox()
        Me.addPresetButton = New System.Windows.Forms.Button()
        Me.clearPresetButton = New System.Windows.Forms.Button()
        Me.deletePresetButton = New System.Windows.Forms.Button()
        Me.listOfPresets = New System.Windows.Forms.ListBox()
        Me.presetDetailsView = New System.Windows.Forms.DataGridView()
        Me.code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.markUp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalComponentCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DeleteComponentButton = New System.Windows.Forms.Button()
        Me.AddAndUpdateComponentButton = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComponentCost = New System.Windows.Forms.TextBox()
        Me.ComponentSupplier = New System.Windows.Forms.TextBox()
        Me.ComponentId = New System.Windows.Forms.TextBox()
        Me.ComponentDescription = New System.Windows.Forms.TextBox()
        Me.ComponentViewer = New System.Windows.Forms.DataGridView()
        Me.databaseSettingsContainer.SuspendLayout()
        Me.authorizationSettingsContainer.SuspendLayout()
        Me.presets.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.presetDetailsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.ComponentViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'databaseSettingsContainer
        '
        Me.databaseSettingsContainer.Controls.Add(Me.employeeTableNameTextbox)
        Me.databaseSettingsContainer.Controls.Add(Me.updateDatabaseButton)
        Me.databaseSettingsContainer.Controls.Add(Me.Label3)
        Me.databaseSettingsContainer.Controls.Add(Me.inventoryTableNameTextbox)
        Me.databaseSettingsContainer.Controls.Add(Me.Label2)
        Me.databaseSettingsContainer.Controls.Add(Me.databasePasswordTextbox)
        Me.databaseSettingsContainer.Controls.Add(Me.Label1)
        Me.databaseSettingsContainer.Controls.Add(Me.databaseNameTextbox)
        Me.databaseSettingsContainer.Controls.Add(Me.databaseNameLabel)
        Me.databaseSettingsContainer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.databaseSettingsContainer.Location = New System.Drawing.Point(9, 101)
        Me.databaseSettingsContainer.Margin = New System.Windows.Forms.Padding(2)
        Me.databaseSettingsContainer.Name = "databaseSettingsContainer"
        Me.databaseSettingsContainer.Padding = New System.Windows.Forms.Padding(2)
        Me.databaseSettingsContainer.Size = New System.Drawing.Size(674, 142)
        Me.databaseSettingsContainer.TabIndex = 0
        Me.databaseSettingsContainer.TabStop = False
        Me.databaseSettingsContainer.Text = "Database"
        '
        'employeeTableNameTextbox
        '
        Me.employeeTableNameTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeTableNameTextbox.Location = New System.Drawing.Point(341, 109)
        Me.employeeTableNameTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.employeeTableNameTextbox.Name = "employeeTableNameTextbox"
        Me.employeeTableNameTextbox.Size = New System.Drawing.Size(180, 22)
        Me.employeeTableNameTextbox.TabIndex = 7
        '
        'updateDatabaseButton
        '
        Me.updateDatabaseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateDatabaseButton.Location = New System.Drawing.Point(532, 112)
        Me.updateDatabaseButton.Margin = New System.Windows.Forms.Padding(2)
        Me.updateDatabaseButton.Name = "updateDatabaseButton"
        Me.updateDatabaseButton.Size = New System.Drawing.Size(138, 26)
        Me.updateDatabaseButton.TabIndex = 2
        Me.updateDatabaseButton.Text = "Update Settings"
        Me.updateDatabaseButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 109)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Employee Table Name"
        '
        'inventoryTableNameTextbox
        '
        Me.inventoryTableNameTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventoryTableNameTextbox.Location = New System.Drawing.Point(341, 80)
        Me.inventoryTableNameTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.inventoryTableNameTextbox.Name = "inventoryTableNameTextbox"
        Me.inventoryTableNameTextbox.Size = New System.Drawing.Size(180, 22)
        Me.inventoryTableNameTextbox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Inventory Table Name"
        '
        'databasePasswordTextbox
        '
        Me.databasePasswordTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.databasePasswordTextbox.Location = New System.Drawing.Point(341, 50)
        Me.databasePasswordTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.databasePasswordTextbox.Name = "databasePasswordTextbox"
        Me.databasePasswordTextbox.Size = New System.Drawing.Size(180, 22)
        Me.databasePasswordTextbox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Database Password"
        '
        'databaseNameTextbox
        '
        Me.databaseNameTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.databaseNameTextbox.Location = New System.Drawing.Point(341, 21)
        Me.databaseNameTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.databaseNameTextbox.Name = "databaseNameTextbox"
        Me.databaseNameTextbox.Size = New System.Drawing.Size(180, 22)
        Me.databaseNameTextbox.TabIndex = 1
        '
        'databaseNameLabel
        '
        Me.databaseNameLabel.AutoSize = True
        Me.databaseNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.databaseNameLabel.Location = New System.Drawing.Point(4, 21)
        Me.databaseNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.databaseNameLabel.Name = "databaseNameLabel"
        Me.databaseNameLabel.Size = New System.Drawing.Size(107, 16)
        Me.databaseNameLabel.TabIndex = 0
        Me.databaseNameLabel.Text = "Database Name"
        '
        'authorizationSettingsContainer
        '
        Me.authorizationSettingsContainer.Controls.Add(Me.updateAuthButton)
        Me.authorizationSettingsContainer.Controls.Add(Me.userPasswordTextbox)
        Me.authorizationSettingsContainer.Controls.Add(Me.userPasswordLabel)
        Me.authorizationSettingsContainer.Controls.Add(Me.userNameTextbox)
        Me.authorizationSettingsContainer.Controls.Add(Me.userNameLabel)
        Me.authorizationSettingsContainer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorizationSettingsContainer.Location = New System.Drawing.Point(9, 10)
        Me.authorizationSettingsContainer.Margin = New System.Windows.Forms.Padding(2)
        Me.authorizationSettingsContainer.Name = "authorizationSettingsContainer"
        Me.authorizationSettingsContainer.Padding = New System.Windows.Forms.Padding(2)
        Me.authorizationSettingsContainer.Size = New System.Drawing.Size(674, 83)
        Me.authorizationSettingsContainer.TabIndex = 1
        Me.authorizationSettingsContainer.TabStop = False
        Me.authorizationSettingsContainer.Text = "Authorization"
        '
        'updateAuthButton
        '
        Me.updateAuthButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateAuthButton.Location = New System.Drawing.Point(532, 53)
        Me.updateAuthButton.Margin = New System.Windows.Forms.Padding(2)
        Me.updateAuthButton.Name = "updateAuthButton"
        Me.updateAuthButton.Size = New System.Drawing.Size(138, 26)
        Me.updateAuthButton.TabIndex = 8
        Me.updateAuthButton.Text = "Update Settings"
        Me.updateAuthButton.UseVisualStyleBackColor = True
        '
        'userPasswordTextbox
        '
        Me.userPasswordTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userPasswordTextbox.Location = New System.Drawing.Point(341, 50)
        Me.userPasswordTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.userPasswordTextbox.Name = "userPasswordTextbox"
        Me.userPasswordTextbox.Size = New System.Drawing.Size(180, 22)
        Me.userPasswordTextbox.TabIndex = 7
        '
        'userPasswordLabel
        '
        Me.userPasswordLabel.AutoSize = True
        Me.userPasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userPasswordLabel.Location = New System.Drawing.Point(4, 50)
        Me.userPasswordLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.userPasswordLabel.Name = "userPasswordLabel"
        Me.userPasswordLabel.Size = New System.Drawing.Size(69, 17)
        Me.userPasswordLabel.TabIndex = 6
        Me.userPasswordLabel.Text = "Password"
        '
        'userNameTextbox
        '
        Me.userNameTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userNameTextbox.Location = New System.Drawing.Point(341, 21)
        Me.userNameTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.userNameTextbox.Name = "userNameTextbox"
        Me.userNameTextbox.Size = New System.Drawing.Size(180, 22)
        Me.userNameTextbox.TabIndex = 5
        '
        'userNameLabel
        '
        Me.userNameLabel.AutoSize = True
        Me.userNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userNameLabel.Location = New System.Drawing.Point(4, 21)
        Me.userNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.userNameLabel.Name = "userNameLabel"
        Me.userNameLabel.Size = New System.Drawing.Size(73, 17)
        Me.userNameLabel.TabIndex = 4
        Me.userNameLabel.Text = "Username"
        '
        'presets
        '
        Me.presets.Controls.Add(Me.Panel2)
        Me.presets.Controls.Add(Me.Panel1)
        Me.presets.Controls.Add(Me.clearPresetButton)
        Me.presets.Controls.Add(Me.deletePresetButton)
        Me.presets.Controls.Add(Me.listOfPresets)
        Me.presets.Controls.Add(Me.presetDetailsView)
        Me.presets.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.presets.Location = New System.Drawing.Point(9, 256)
        Me.presets.Name = "presets"
        Me.presets.Size = New System.Drawing.Size(674, 426)
        Me.presets.TabIndex = 3
        Me.presets.TabStop = False
        Me.presets.Text = "Presets"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.componentCode)
        Me.Panel2.Controls.Add(Me.addComponentButton)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.openComponentListTextbox)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.componentQuantity)
        Me.Panel2.Controls.Add(Me.componentMarkUp)
        Me.Panel2.Location = New System.Drawing.Point(527, 125)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(141, 295)
        Me.Panel2.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Component Code"
        '
        'componentCode
        '
        Me.componentCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.componentCode.Location = New System.Drawing.Point(3, 22)
        Me.componentCode.Name = "componentCode"
        Me.componentCode.Size = New System.Drawing.Size(133, 22)
        Me.componentCode.TabIndex = 5
        '
        'addComponentButton
        '
        Me.addComponentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addComponentButton.Location = New System.Drawing.Point(4, 150)
        Me.addComponentButton.Name = "addComponentButton"
        Me.addComponentButton.Size = New System.Drawing.Size(132, 23)
        Me.addComponentButton.TabIndex = 8
        Me.addComponentButton.Text = "Add to Preset"
        Me.addComponentButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Mark-Up"
        '
        'openComponentListTextbox
        '
        Me.openComponentListTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openComponentListTextbox.Location = New System.Drawing.Point(4, 267)
        Me.openComponentListTextbox.Name = "openComponentListTextbox"
        Me.openComponentListTextbox.Size = New System.Drawing.Size(132, 23)
        Me.openComponentListTextbox.TabIndex = 9
        Me.openComponentListTextbox.Text = "Comp. List"
        Me.openComponentListTextbox.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Quantity"
        '
        'componentQuantity
        '
        Me.componentQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.componentQuantity.Location = New System.Drawing.Point(4, 70)
        Me.componentQuantity.Name = "componentQuantity"
        Me.componentQuantity.Size = New System.Drawing.Size(132, 22)
        Me.componentQuantity.TabIndex = 10
        '
        'componentMarkUp
        '
        Me.componentMarkUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.componentMarkUp.Location = New System.Drawing.Point(4, 118)
        Me.componentMarkUp.Name = "componentMarkUp"
        Me.componentMarkUp.Size = New System.Drawing.Size(132, 22)
        Me.componentMarkUp.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.newPresetName)
        Me.Panel1.Controls.Add(Me.addPresetButton)
        Me.Panel1.Location = New System.Drawing.Point(527, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(141, 94)
        Me.Panel1.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(2, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Preset Name"
        '
        'newPresetName
        '
        Me.newPresetName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newPresetName.Location = New System.Drawing.Point(2, 21)
        Me.newPresetName.Name = "newPresetName"
        Me.newPresetName.Size = New System.Drawing.Size(133, 22)
        Me.newPresetName.TabIndex = 8
        '
        'addPresetButton
        '
        Me.addPresetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addPresetButton.Location = New System.Drawing.Point(3, 66)
        Me.addPresetButton.Name = "addPresetButton"
        Me.addPresetButton.Size = New System.Drawing.Size(132, 23)
        Me.addPresetButton.TabIndex = 2
        Me.addPresetButton.Text = "Add Preset"
        Me.addPresetButton.UseVisualStyleBackColor = True
        '
        'clearPresetButton
        '
        Me.clearPresetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearPresetButton.Location = New System.Drawing.Point(7, 368)
        Me.clearPresetButton.Name = "clearPresetButton"
        Me.clearPresetButton.Size = New System.Drawing.Size(138, 23)
        Me.clearPresetButton.TabIndex = 14
        Me.clearPresetButton.Text = "Clear Preset"
        Me.clearPresetButton.UseVisualStyleBackColor = True
        '
        'deletePresetButton
        '
        Me.deletePresetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletePresetButton.Location = New System.Drawing.Point(7, 397)
        Me.deletePresetButton.Name = "deletePresetButton"
        Me.deletePresetButton.Size = New System.Drawing.Size(136, 23)
        Me.deletePresetButton.TabIndex = 4
        Me.deletePresetButton.Text = "Delete Preset"
        Me.deletePresetButton.UseVisualStyleBackColor = True
        '
        'listOfPresets
        '
        Me.listOfPresets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listOfPresets.FormattingEnabled = True
        Me.listOfPresets.ItemHeight = 16
        Me.listOfPresets.Location = New System.Drawing.Point(7, 25)
        Me.listOfPresets.Name = "listOfPresets"
        Me.listOfPresets.Size = New System.Drawing.Size(136, 340)
        Me.listOfPresets.TabIndex = 1
        '
        'presetDetailsView
        '
        Me.presetDetailsView.AllowUserToAddRows = False
        Me.presetDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.presetDetailsView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code, Me.description, Me.quantity, Me.markUp, Me.totalComponentCost})
        Me.presetDetailsView.Location = New System.Drawing.Point(149, 25)
        Me.presetDetailsView.Name = "presetDetailsView"
        Me.presetDetailsView.ReadOnly = True
        Me.presetDetailsView.Size = New System.Drawing.Size(372, 395)
        Me.presetDetailsView.TabIndex = 0
        '
        'code
        '
        Me.code.HeaderText = "Code"
        Me.code.Name = "code"
        Me.code.ReadOnly = True
        '
        'description
        '
        Me.description.HeaderText = "Description"
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        '
        'quantity
        '
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        '
        'markUp
        '
        Me.markUp.HeaderText = "MarkUp"
        Me.markUp.Name = "markUp"
        Me.markUp.ReadOnly = True
        '
        'totalComponentCost
        '
        Me.totalComponentCost.HeaderText = "Cost"
        Me.totalComponentCost.Name = "totalComponentCost"
        Me.totalComponentCost.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.ComponentViewer)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 696)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 320)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Components"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.DeleteComponentButton)
        Me.Panel4.Controls.Add(Me.AddAndUpdateComponentButton)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.ComponentCost)
        Me.Panel4.Controls.Add(Me.ComponentSupplier)
        Me.Panel4.Controls.Add(Me.ComponentId)
        Me.Panel4.Controls.Add(Me.ComponentDescription)
        Me.Panel4.Location = New System.Drawing.Point(7, 25)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(189, 289)
        Me.Panel4.TabIndex = 2
        '
        'DeleteComponentButton
        '
        Me.DeleteComponentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteComponentButton.Location = New System.Drawing.Point(52, 261)
        Me.DeleteComponentButton.Name = "DeleteComponentButton"
        Me.DeleteComponentButton.Size = New System.Drawing.Size(132, 23)
        Me.DeleteComponentButton.TabIndex = 14
        Me.DeleteComponentButton.Text = "Delete"
        Me.DeleteComponentButton.UseVisualStyleBackColor = True
        '
        'AddAndUpdateComponentButton
        '
        Me.AddAndUpdateComponentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAndUpdateComponentButton.Location = New System.Drawing.Point(52, 232)
        Me.AddAndUpdateComponentButton.Name = "AddAndUpdateComponentButton"
        Me.AddAndUpdateComponentButton.Size = New System.Drawing.Size(132, 23)
        Me.AddAndUpdateComponentButton.TabIndex = 13
        Me.AddAndUpdateComponentButton.Text = "Add/Update"
        Me.AddAndUpdateComponentButton.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(34, 16)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Cost"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(2, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Supplier"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(2, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Description"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Component ID"
        '
        'ComponentCost
        '
        Me.ComponentCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComponentCost.Location = New System.Drawing.Point(3, 153)
        Me.ComponentCost.Name = "ComponentCost"
        Me.ComponentCost.Size = New System.Drawing.Size(180, 22)
        Me.ComponentCost.TabIndex = 8
        '
        'ComponentSupplier
        '
        Me.ComponentSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComponentSupplier.Location = New System.Drawing.Point(3, 109)
        Me.ComponentSupplier.Name = "ComponentSupplier"
        Me.ComponentSupplier.Size = New System.Drawing.Size(180, 22)
        Me.ComponentSupplier.TabIndex = 7
        '
        'ComponentId
        '
        Me.ComponentId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComponentId.Location = New System.Drawing.Point(3, 21)
        Me.ComponentId.Name = "ComponentId"
        Me.ComponentId.Size = New System.Drawing.Size(180, 22)
        Me.ComponentId.TabIndex = 6
        '
        'ComponentDescription
        '
        Me.ComponentDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComponentDescription.Location = New System.Drawing.Point(3, 65)
        Me.ComponentDescription.Name = "ComponentDescription"
        Me.ComponentDescription.Size = New System.Drawing.Size(180, 22)
        Me.ComponentDescription.TabIndex = 5
        '
        'ComponentViewer
        '
        Me.ComponentViewer.AllowUserToAddRows = False
        Me.ComponentViewer.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.ComponentViewer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ComponentViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ComponentViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ComponentViewer.DefaultCellStyle = DataGridViewCellStyle4
        Me.ComponentViewer.Location = New System.Drawing.Point(202, 25)
        Me.ComponentViewer.Name = "ComponentViewer"
        Me.ComponentViewer.ReadOnly = True
        Me.ComponentViewer.RowHeadersVisible = False
        Me.ComponentViewer.Size = New System.Drawing.Size(466, 289)
        Me.ComponentViewer.TabIndex = 0
        Me.ComponentViewer.VirtualMode = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 691)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.presets)
        Me.Controls.Add(Me.authorizationSettingsContainer)
        Me.Controls.Add(Me.databaseSettingsContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.databaseSettingsContainer.ResumeLayout(False)
        Me.databaseSettingsContainer.PerformLayout()
        Me.authorizationSettingsContainer.ResumeLayout(False)
        Me.authorizationSettingsContainer.PerformLayout()
        Me.presets.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.presetDetailsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.ComponentViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents databaseSettingsContainer As GroupBox
    Friend WithEvents databaseNameTextbox As TextBox
    Friend WithEvents databaseNameLabel As Label
    Friend WithEvents inventoryTableNameTextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents databasePasswordTextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents employeeTableNameTextbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents authorizationSettingsContainer As GroupBox
    Friend WithEvents userPasswordTextbox As TextBox
    Friend WithEvents userPasswordLabel As Label
    Friend WithEvents userNameTextbox As TextBox
    Friend WithEvents userNameLabel As Label
    Friend WithEvents updateDatabaseButton As Button
    Friend WithEvents presets As GroupBox
    Friend WithEvents listOfPresets As ListBox
    Friend WithEvents presetDetailsView As DataGridView
    Friend WithEvents deletePresetButton As Button
    Friend WithEvents addPresetButton As Button
    Friend WithEvents addComponentButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents componentCode As TextBox
    Friend WithEvents openComponentListTextbox As Button
    Friend WithEvents updateAuthButton As Button
    Friend WithEvents componentMarkUp As TextBox
    Friend WithEvents componentQuantity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents code As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents markUp As DataGridViewTextBoxColumn
    Friend WithEvents totalComponentCost As DataGridViewTextBoxColumn
    Friend WithEvents clearPresetButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents newPresetName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComponentViewer As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ComponentDescription As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComponentCost As TextBox
    Friend WithEvents ComponentSupplier As TextBox
    Friend WithEvents ComponentId As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents AddAndUpdateComponentButton As Button
    Friend WithEvents DeleteComponentButton As Button
End Class
