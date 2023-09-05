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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inventoryTableNameTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.databasePasswordTextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.databaseNameTextbox = New System.Windows.Forms.TextBox()
        Me.databaseNameLabel = New System.Windows.Forms.Label()
        Me.applicationSettingsContainer = New System.Windows.Forms.GroupBox()
        Me.userPasswordTextbox = New System.Windows.Forms.TextBox()
        Me.userPasswordLabel = New System.Windows.Forms.Label()
        Me.userNameTextbox = New System.Windows.Forms.TextBox()
        Me.userNameLabel = New System.Windows.Forms.Label()
        Me.updateSettingsButton = New System.Windows.Forms.Button()
        Me.databaseSettingsContainer.SuspendLayout()
        Me.applicationSettingsContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'databaseSettingsContainer
        '
        Me.databaseSettingsContainer.Controls.Add(Me.employeeTableNameTextbox)
        Me.databaseSettingsContainer.Controls.Add(Me.Label3)
        Me.databaseSettingsContainer.Controls.Add(Me.inventoryTableNameTextbox)
        Me.databaseSettingsContainer.Controls.Add(Me.Label2)
        Me.databaseSettingsContainer.Controls.Add(Me.databasePasswordTextbox)
        Me.databaseSettingsContainer.Controls.Add(Me.Label1)
        Me.databaseSettingsContainer.Controls.Add(Me.databaseNameTextbox)
        Me.databaseSettingsContainer.Controls.Add(Me.databaseNameLabel)
        Me.databaseSettingsContainer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.databaseSettingsContainer.Location = New System.Drawing.Point(12, 120)
        Me.databaseSettingsContainer.Name = "databaseSettingsContainer"
        Me.databaseSettingsContainer.Size = New System.Drawing.Size(480, 175)
        Me.databaseSettingsContainer.TabIndex = 0
        Me.databaseSettingsContainer.TabStop = False
        Me.databaseSettingsContainer.Text = "Database"
        '
        'employeeTableNameTextbox
        '
        Me.employeeTableNameTextbox.Location = New System.Drawing.Point(280, 134)
        Me.employeeTableNameTextbox.Name = "employeeTableNameTextbox"
        Me.employeeTableNameTextbox.Size = New System.Drawing.Size(194, 30)
        Me.employeeTableNameTextbox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Employee Table Name"
        '
        'inventoryTableNameTextbox
        '
        Me.inventoryTableNameTextbox.Location = New System.Drawing.Point(280, 98)
        Me.inventoryTableNameTextbox.Name = "inventoryTableNameTextbox"
        Me.inventoryTableNameTextbox.Size = New System.Drawing.Size(194, 30)
        Me.inventoryTableNameTextbox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Inventory Table Name"
        '
        'databasePasswordTextbox
        '
        Me.databasePasswordTextbox.Location = New System.Drawing.Point(280, 62)
        Me.databasePasswordTextbox.Name = "databasePasswordTextbox"
        Me.databasePasswordTextbox.Size = New System.Drawing.Size(194, 30)
        Me.databasePasswordTextbox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Database Password"
        '
        'databaseNameTextbox
        '
        Me.databaseNameTextbox.Location = New System.Drawing.Point(280, 26)
        Me.databaseNameTextbox.Name = "databaseNameTextbox"
        Me.databaseNameTextbox.Size = New System.Drawing.Size(194, 30)
        Me.databaseNameTextbox.TabIndex = 1
        '
        'databaseNameLabel
        '
        Me.databaseNameLabel.AutoSize = True
        Me.databaseNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.databaseNameLabel.Location = New System.Drawing.Point(6, 26)
        Me.databaseNameLabel.Name = "databaseNameLabel"
        Me.databaseNameLabel.Size = New System.Drawing.Size(130, 20)
        Me.databaseNameLabel.TabIndex = 0
        Me.databaseNameLabel.Text = "Database Name"
        '
        'applicationSettingsContainer
        '
        Me.applicationSettingsContainer.Controls.Add(Me.userPasswordTextbox)
        Me.applicationSettingsContainer.Controls.Add(Me.userPasswordLabel)
        Me.applicationSettingsContainer.Controls.Add(Me.userNameTextbox)
        Me.applicationSettingsContainer.Controls.Add(Me.userNameLabel)
        Me.applicationSettingsContainer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.applicationSettingsContainer.Location = New System.Drawing.Point(12, 12)
        Me.applicationSettingsContainer.Name = "applicationSettingsContainer"
        Me.applicationSettingsContainer.Size = New System.Drawing.Size(480, 102)
        Me.applicationSettingsContainer.TabIndex = 1
        Me.applicationSettingsContainer.TabStop = False
        Me.applicationSettingsContainer.Text = "Application"
        '
        'userPasswordTextbox
        '
        Me.userPasswordTextbox.Location = New System.Drawing.Point(280, 62)
        Me.userPasswordTextbox.Name = "userPasswordTextbox"
        Me.userPasswordTextbox.Size = New System.Drawing.Size(194, 30)
        Me.userPasswordTextbox.TabIndex = 7
        '
        'userPasswordLabel
        '
        Me.userPasswordLabel.AutoSize = True
        Me.userPasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userPasswordLabel.Location = New System.Drawing.Point(6, 62)
        Me.userPasswordLabel.Name = "userPasswordLabel"
        Me.userPasswordLabel.Size = New System.Drawing.Size(160, 20)
        Me.userPasswordLabel.TabIndex = 6
        Me.userPasswordLabel.Text = "Database Password"
        '
        'userNameTextbox
        '
        Me.userNameTextbox.Location = New System.Drawing.Point(280, 26)
        Me.userNameTextbox.Name = "userNameTextbox"
        Me.userNameTextbox.Size = New System.Drawing.Size(194, 30)
        Me.userNameTextbox.TabIndex = 5
        '
        'userNameLabel
        '
        Me.userNameLabel.AutoSize = True
        Me.userNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userNameLabel.Location = New System.Drawing.Point(6, 26)
        Me.userNameLabel.Name = "userNameLabel"
        Me.userNameLabel.Size = New System.Drawing.Size(130, 20)
        Me.userNameLabel.TabIndex = 4
        Me.userNameLabel.Text = "Database Name"
        '
        'updateSettingsButton
        '
        Me.updateSettingsButton.Location = New System.Drawing.Point(369, 301)
        Me.updateSettingsButton.Name = "updateSettingsButton"
        Me.updateSettingsButton.Size = New System.Drawing.Size(123, 32)
        Me.updateSettingsButton.TabIndex = 2
        Me.updateSettingsButton.Text = "Update Settings"
        Me.updateSettingsButton.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 342)
        Me.Controls.Add(Me.updateSettingsButton)
        Me.Controls.Add(Me.applicationSettingsContainer)
        Me.Controls.Add(Me.databaseSettingsContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.databaseSettingsContainer.ResumeLayout(False)
        Me.databaseSettingsContainer.PerformLayout()
        Me.applicationSettingsContainer.ResumeLayout(False)
        Me.applicationSettingsContainer.PerformLayout()
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
    Friend WithEvents applicationSettingsContainer As GroupBox
    Friend WithEvents userPasswordTextbox As TextBox
    Friend WithEvents userPasswordLabel As Label
    Friend WithEvents userNameTextbox As TextBox
    Friend WithEvents userNameLabel As Label
    Friend WithEvents updateSettingsButton As Button
End Class
