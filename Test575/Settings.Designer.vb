<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.componentMarkUp = New System.Windows.Forms.TextBox()
        Me.componentQuantity = New System.Windows.Forms.TextBox()
        Me.openComponentListTextbox = New System.Windows.Forms.Button()
        Me.addComponentButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.componentCode = New System.Windows.Forms.TextBox()
        Me.deletePresetButton = New System.Windows.Forms.Button()
        Me.updatePresetButton = New System.Windows.Forms.Button()
        Me.addPresetButton = New System.Windows.Forms.Button()
        Me.listOfPresets = New System.Windows.Forms.ListBox()
        Me.presetDetailsView = New System.Windows.Forms.DataGridView()
        Me.code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.markUp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalComponentCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.databaseSettingsContainer.SuspendLayout()
        Me.authorizationSettingsContainer.SuspendLayout()
        Me.presets.SuspendLayout()
        CType(Me.presetDetailsView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.databaseSettingsContainer.Location = New System.Drawing.Point(9, 98)
        Me.databaseSettingsContainer.Margin = New System.Windows.Forms.Padding(2)
        Me.databaseSettingsContainer.Name = "databaseSettingsContainer"
        Me.databaseSettingsContainer.Padding = New System.Windows.Forms.Padding(2)
        Me.databaseSettingsContainer.Size = New System.Drawing.Size(630, 142)
        Me.databaseSettingsContainer.TabIndex = 0
        Me.databaseSettingsContainer.TabStop = False
        Me.databaseSettingsContainer.Text = "Database"
        '
        'employeeTableNameTextbox
        '
        Me.employeeTableNameTextbox.Location = New System.Drawing.Point(210, 109)
        Me.employeeTableNameTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.employeeTableNameTextbox.Name = "employeeTableNameTextbox"
        Me.employeeTableNameTextbox.Size = New System.Drawing.Size(146, 26)
        Me.employeeTableNameTextbox.TabIndex = 7
        '
        'updateDatabaseButton
        '
        Me.updateDatabaseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateDatabaseButton.Location = New System.Drawing.Point(488, 112)
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
        Me.inventoryTableNameTextbox.Location = New System.Drawing.Point(210, 80)
        Me.inventoryTableNameTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.inventoryTableNameTextbox.Name = "inventoryTableNameTextbox"
        Me.inventoryTableNameTextbox.Size = New System.Drawing.Size(146, 26)
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
        Me.databasePasswordTextbox.Location = New System.Drawing.Point(210, 50)
        Me.databasePasswordTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.databasePasswordTextbox.Name = "databasePasswordTextbox"
        Me.databasePasswordTextbox.Size = New System.Drawing.Size(146, 26)
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
        Me.databaseNameTextbox.Location = New System.Drawing.Point(210, 21)
        Me.databaseNameTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.databaseNameTextbox.Name = "databaseNameTextbox"
        Me.databaseNameTextbox.Size = New System.Drawing.Size(146, 26)
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
        Me.authorizationSettingsContainer.Size = New System.Drawing.Size(630, 83)
        Me.authorizationSettingsContainer.TabIndex = 1
        Me.authorizationSettingsContainer.TabStop = False
        Me.authorizationSettingsContainer.Text = "Authorization"
        '
        'updateAuthButton
        '
        Me.updateAuthButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateAuthButton.Location = New System.Drawing.Point(488, 53)
        Me.updateAuthButton.Margin = New System.Windows.Forms.Padding(2)
        Me.updateAuthButton.Name = "updateAuthButton"
        Me.updateAuthButton.Size = New System.Drawing.Size(138, 26)
        Me.updateAuthButton.TabIndex = 8
        Me.updateAuthButton.Text = "Update Settings"
        Me.updateAuthButton.UseVisualStyleBackColor = True
        '
        'userPasswordTextbox
        '
        Me.userPasswordTextbox.Location = New System.Drawing.Point(210, 50)
        Me.userPasswordTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.userPasswordTextbox.Name = "userPasswordTextbox"
        Me.userPasswordTextbox.Size = New System.Drawing.Size(146, 26)
        Me.userPasswordTextbox.TabIndex = 7
        '
        'userPasswordLabel
        '
        Me.userPasswordLabel.AutoSize = True
        Me.userPasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userPasswordLabel.Location = New System.Drawing.Point(4, 50)
        Me.userPasswordLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.userPasswordLabel.Name = "userPasswordLabel"
        Me.userPasswordLabel.Size = New System.Drawing.Size(134, 17)
        Me.userPasswordLabel.TabIndex = 6
        Me.userPasswordLabel.Text = "Database Password"
        '
        'userNameTextbox
        '
        Me.userNameTextbox.Location = New System.Drawing.Point(210, 21)
        Me.userNameTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.userNameTextbox.Name = "userNameTextbox"
        Me.userNameTextbox.Size = New System.Drawing.Size(146, 26)
        Me.userNameTextbox.TabIndex = 5
        '
        'userNameLabel
        '
        Me.userNameLabel.AutoSize = True
        Me.userNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userNameLabel.Location = New System.Drawing.Point(4, 21)
        Me.userNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.userNameLabel.Name = "userNameLabel"
        Me.userNameLabel.Size = New System.Drawing.Size(110, 17)
        Me.userNameLabel.TabIndex = 4
        Me.userNameLabel.Text = "Database Name"
        '
        'presets
        '
        Me.presets.Controls.Add(Me.Label6)
        Me.presets.Controls.Add(Me.Label5)
        Me.presets.Controls.Add(Me.componentMarkUp)
        Me.presets.Controls.Add(Me.componentQuantity)
        Me.presets.Controls.Add(Me.openComponentListTextbox)
        Me.presets.Controls.Add(Me.addComponentButton)
        Me.presets.Controls.Add(Me.Label4)
        Me.presets.Controls.Add(Me.componentCode)
        Me.presets.Controls.Add(Me.deletePresetButton)
        Me.presets.Controls.Add(Me.updatePresetButton)
        Me.presets.Controls.Add(Me.addPresetButton)
        Me.presets.Controls.Add(Me.listOfPresets)
        Me.presets.Controls.Add(Me.presetDetailsView)
        Me.presets.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.presets.Location = New System.Drawing.Point(9, 245)
        Me.presets.Name = "presets"
        Me.presets.Size = New System.Drawing.Size(630, 369)
        Me.presets.TabIndex = 3
        Me.presets.TabStop = False
        Me.presets.Text = "Presets"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(483, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Mark-Up"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(485, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Quantity"
        '
        'componentMarkUp
        '
        Me.componentMarkUp.Location = New System.Drawing.Point(486, 140)
        Me.componentMarkUp.Name = "componentMarkUp"
        Me.componentMarkUp.Size = New System.Drawing.Size(138, 26)
        Me.componentMarkUp.TabIndex = 11
        '
        'componentQuantity
        '
        Me.componentQuantity.Location = New System.Drawing.Point(486, 92)
        Me.componentQuantity.Name = "componentQuantity"
        Me.componentQuantity.Size = New System.Drawing.Size(138, 26)
        Me.componentQuantity.TabIndex = 10
        '
        'openComponentListTextbox
        '
        Me.openComponentListTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openComponentListTextbox.Location = New System.Drawing.Point(486, 340)
        Me.openComponentListTextbox.Name = "openComponentListTextbox"
        Me.openComponentListTextbox.Size = New System.Drawing.Size(138, 23)
        Me.openComponentListTextbox.TabIndex = 9
        Me.openComponentListTextbox.Text = "Comp. List"
        Me.openComponentListTextbox.UseVisualStyleBackColor = True
        '
        'addComponentButton
        '
        Me.addComponentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addComponentButton.Location = New System.Drawing.Point(486, 172)
        Me.addComponentButton.Name = "addComponentButton"
        Me.addComponentButton.Size = New System.Drawing.Size(138, 23)
        Me.addComponentButton.TabIndex = 8
        Me.addComponentButton.Text = "Add to Preset"
        Me.addComponentButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(483, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Component Code"
        '
        'componentCode
        '
        Me.componentCode.Location = New System.Drawing.Point(486, 44)
        Me.componentCode.Name = "componentCode"
        Me.componentCode.Size = New System.Drawing.Size(138, 26)
        Me.componentCode.TabIndex = 5
        '
        'deletePresetButton
        '
        Me.deletePresetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletePresetButton.Location = New System.Drawing.Point(7, 340)
        Me.deletePresetButton.Name = "deletePresetButton"
        Me.deletePresetButton.Size = New System.Drawing.Size(104, 23)
        Me.deletePresetButton.TabIndex = 4
        Me.deletePresetButton.Text = "Delete Preset"
        Me.deletePresetButton.UseVisualStyleBackColor = True
        '
        'updatePresetButton
        '
        Me.updatePresetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatePresetButton.Location = New System.Drawing.Point(7, 311)
        Me.updatePresetButton.Name = "updatePresetButton"
        Me.updatePresetButton.Size = New System.Drawing.Size(104, 23)
        Me.updatePresetButton.TabIndex = 3
        Me.updatePresetButton.Text = "Update Preset"
        Me.updatePresetButton.UseVisualStyleBackColor = True
        '
        'addPresetButton
        '
        Me.addPresetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addPresetButton.Location = New System.Drawing.Point(7, 282)
        Me.addPresetButton.Name = "addPresetButton"
        Me.addPresetButton.Size = New System.Drawing.Size(104, 23)
        Me.addPresetButton.TabIndex = 2
        Me.addPresetButton.Text = "Add Preset"
        Me.addPresetButton.UseVisualStyleBackColor = True
        '
        'listOfPresets
        '
        Me.listOfPresets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listOfPresets.FormattingEnabled = True
        Me.listOfPresets.ItemHeight = 16
        Me.listOfPresets.Location = New System.Drawing.Point(7, 25)
        Me.listOfPresets.Name = "listOfPresets"
        Me.listOfPresets.Size = New System.Drawing.Size(104, 244)
        Me.listOfPresets.TabIndex = 1
        '
        'presetDetailsView
        '
        Me.presetDetailsView.AllowUserToAddRows = False
        Me.presetDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.presetDetailsView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code, Me.description, Me.quantity, Me.markUp, Me.totalComponentCost})
        Me.presetDetailsView.Location = New System.Drawing.Point(117, 25)
        Me.presetDetailsView.Name = "presetDetailsView"
        Me.presetDetailsView.Size = New System.Drawing.Size(360, 338)
        Me.presetDetailsView.TabIndex = 0
        '
        'code
        '
        Me.code.HeaderText = "Code"
        Me.code.Name = "code"
        '
        'description
        '
        Me.description.HeaderText = "Description"
        Me.description.Name = "description"
        '
        'quantity
        '
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        '
        'markUp
        '
        Me.markUp.HeaderText = "MarkUp"
        Me.markUp.Name = "markUp"
        '
        'totalComponentCost
        '
        Me.totalComponentCost.HeaderText = "Cost"
        Me.totalComponentCost.Name = "totalComponentCost"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 626)
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
        Me.presets.PerformLayout()
        CType(Me.presetDetailsView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents updatePresetButton As Button
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
End Class
