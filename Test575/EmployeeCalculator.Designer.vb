<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeCalculator
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Emp_Viewer = New System.Windows.Forms.DataGridView()
        Me.Emp_Name = New System.Windows.Forms.TextBox()
        Me.Emp_Hours = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Emp_Position = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Job_Viewer = New System.Windows.Forms.DataGridView()
        Me.EMPLOYEE_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSITION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.Emp_Viewer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Job_Viewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Emp_Viewer
        '
        Me.Emp_Viewer.AllowUserToAddRows = False
        Me.Emp_Viewer.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_Viewer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Emp_Viewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Emp_Viewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Emp_Viewer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Emp_Viewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Emp_Viewer.Location = New System.Drawing.Point(16, 66)
        Me.Emp_Viewer.Margin = New System.Windows.Forms.Padding(4)
        Me.Emp_Viewer.Name = "Emp_Viewer"
        Me.Emp_Viewer.ReadOnly = True
        Me.Emp_Viewer.RowHeadersVisible = False
        Me.Emp_Viewer.RowHeadersWidth = 51
        Me.Emp_Viewer.Size = New System.Drawing.Size(528, 474)
        Me.Emp_Viewer.TabIndex = 64
        '
        'Emp_Name
        '
        Me.Emp_Name.Location = New System.Drawing.Point(636, 66)
        Me.Emp_Name.Margin = New System.Windows.Forms.Padding(4)
        Me.Emp_Name.Name = "Emp_Name"
        Me.Emp_Name.Size = New System.Drawing.Size(177, 22)
        Me.Emp_Name.TabIndex = 68
        '
        'Emp_Hours
        '
        Me.Emp_Hours.Location = New System.Drawing.Point(636, 131)
        Me.Emp_Hours.Margin = New System.Windows.Forms.Padding(4)
        Me.Emp_Hours.Name = "Emp_Hours"
        Me.Emp_Hours.Size = New System.Drawing.Size(177, 22)
        Me.Emp_Hours.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(552, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Full Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 11)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(264, 31)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Employee Calculator"
        '
        'Emp_Position
        '
        Me.Emp_Position.FormattingEnabled = True
        Me.Emp_Position.Items.AddRange(New Object() {"Design", "Programming", "Assembly", "Testing", "Documentation", "Site Installation"})
        Me.Emp_Position.Location = New System.Drawing.Point(636, 98)
        Me.Emp_Position.Margin = New System.Windows.Forms.Padding(4)
        Me.Emp_Position.Name = "Emp_Position"
        Me.Emp_Position.Size = New System.Drawing.Size(177, 24)
        Me.Emp_Position.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(552, 131)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Hours:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(552, 98)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Position"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(555, 163)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 77
        Me.Button2.Text = "Add to Job"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Job_Viewer
        '
        Me.Job_Viewer.AllowUserToAddRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Job_Viewer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Job_Viewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Job_Viewer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Job_Viewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Job_Viewer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EMPLOYEE_NAME, Me.POSITION, Me.PAY})
        Me.Job_Viewer.Location = New System.Drawing.Point(821, 66)
        Me.Job_Viewer.Margin = New System.Windows.Forms.Padding(4)
        Me.Job_Viewer.Name = "Job_Viewer"
        Me.Job_Viewer.RowHeadersWidth = 51
        Me.Job_Viewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Job_Viewer.Size = New System.Drawing.Size(528, 474)
        Me.Job_Viewer.TabIndex = 78
        '
        'EMPLOYEE_NAME
        '
        Me.EMPLOYEE_NAME.HeaderText = "Employee"
        Me.EMPLOYEE_NAME.MinimumWidth = 6
        Me.EMPLOYEE_NAME.Name = "EMPLOYEE_NAME"
        '
        'POSITION
        '
        Me.POSITION.HeaderText = "Position"
        Me.POSITION.MinimumWidth = 6
        Me.POSITION.Name = "POSITION"
        '
        'PAY
        '
        Me.PAY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PAY.HeaderText = "Pay"
        Me.PAY.MinimumWidth = 6
        Me.PAY.Name = "PAY"
        Me.PAY.Width = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "List of Employees"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(820, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(194, 20)
        Me.Label12.TabIndex = 92
        Me.Label12.Text = "Employees Added to Job"
        '
        'EmployeeCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1365, 557)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Job_Viewer)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Emp_Position)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Emp_Hours)
        Me.Controls.Add(Me.Emp_Name)
        Me.Controls.Add(Me.Emp_Viewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "EmployeeCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmployeeCalculator"
        CType(Me.Emp_Viewer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Job_Viewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Emp_Viewer As DataGridView
    Friend WithEvents Emp_Name As TextBox
    Friend WithEvents Emp_Hours As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Emp_Position As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Job_Viewer As DataGridView
    Friend WithEvents EMPLOYEE_NAME As DataGridViewTextBoxColumn
    Friend WithEvents POSITION As DataGridViewTextBoxColumn
    Friend WithEvents PAY As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
End Class
