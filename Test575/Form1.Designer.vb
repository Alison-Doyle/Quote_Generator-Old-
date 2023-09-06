<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.openEmployeeManagerButton = New System.Windows.Forms.Button()
        Me.openSettingsButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 114)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Quote Generator"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Button1.Location = New System.Drawing.Point(144, 44)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(264, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Quote Generator"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.openEmployeeManagerButton)
        Me.GroupBox1.Controls.Add(Me.openSettingsButton)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 149)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(549, 239)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'openEmployeeManagerButton
        '
        Me.openEmployeeManagerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.openEmployeeManagerButton.Location = New System.Drawing.Point(144, 96)
        Me.openEmployeeManagerButton.Margin = New System.Windows.Forms.Padding(4)
        Me.openEmployeeManagerButton.Name = "openEmployeeManagerButton"
        Me.openEmployeeManagerButton.Size = New System.Drawing.Size(264, 44)
        Me.openEmployeeManagerButton.TabIndex = 1
        Me.openEmployeeManagerButton.Text = "Employee Manager"
        Me.openEmployeeManagerButton.UseVisualStyleBackColor = True
        '
        'openSettingsButton
        '
        Me.openSettingsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.openSettingsButton.Location = New System.Drawing.Point(144, 148)
        Me.openSettingsButton.Margin = New System.Windows.Forms.Padding(4)
        Me.openSettingsButton.Name = "openSettingsButton"
        Me.openSettingsButton.Size = New System.Drawing.Size(264, 44)
        Me.openSettingsButton.TabIndex = 0
        Me.openSettingsButton.Text = "Settings"
        Me.openSettingsButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Test575.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(16, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(549, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "version 1.0.0.11"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 401)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents openSettingsButton As Button
    Friend WithEvents openEmployeeManagerButton As Button
    Friend WithEvents Label2 As Label
End Class
