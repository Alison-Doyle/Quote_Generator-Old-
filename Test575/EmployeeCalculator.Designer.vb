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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Emp_Viewer = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Emp_Name = New System.Windows.Forms.TextBox()
        Me.Emp_Hours = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Emp_Position = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Total_Design = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Job_Viewer = New System.Windows.Forms.DataGridView()
        Me.EMPLOYEE_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSITION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Testing = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Total_Assembly = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Total_Programming = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Total_Documentation = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Total_Site = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Emp_HourlyPay = New System.Windows.Forms.TextBox()
        CType(Me.Emp_Viewer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Job_Viewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Emp_Viewer
        '
        Me.Emp_Viewer.AllowUserToAddRows = False
        Me.Emp_Viewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Emp_Viewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Emp_Viewer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Emp_Viewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Emp_Viewer.Location = New System.Drawing.Point(12, 435)
        Me.Emp_Viewer.Name = "Emp_Viewer"
        Me.Emp_Viewer.Size = New System.Drawing.Size(521, 282)
        Me.Emp_Viewer.TabIndex = 64
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 723)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 23)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "Refersh Employee Quick View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Emp_Name
        '
        Me.Emp_Name.Location = New System.Drawing.Point(72, 57)
        Me.Emp_Name.Name = "Emp_Name"
        Me.Emp_Name.Size = New System.Drawing.Size(162, 20)
        Me.Emp_Name.TabIndex = 68
        '
        'Emp_Hours
        '
        Me.Emp_Hours.Location = New System.Drawing.Point(72, 110)
        Me.Emp_Hours.Name = "Emp_Hours"
        Me.Emp_Hours.Size = New System.Drawing.Size(162, 20)
        Me.Emp_Hours.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Full Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 25)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Employee Calculator"
        '
        'Emp_Position
        '
        Me.Emp_Position.FormattingEnabled = True
        Me.Emp_Position.Items.AddRange(New Object() {"Design", "Programming", "Assembly", "Testing", "Documentation", "Site Installation"})
        Me.Emp_Position.Location = New System.Drawing.Point(72, 83)
        Me.Emp_Position.Name = "Emp_Position"
        Me.Emp_Position.Size = New System.Drawing.Size(162, 21)
        Me.Emp_Position.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Hours:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Position"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Desgin Total:"
        '
        'Total_Design
        '
        Me.Total_Design.Location = New System.Drawing.Point(129, 220)
        Me.Total_Design.Name = "Total_Design"
        Me.Total_Design.Size = New System.Drawing.Size(105, 20)
        Me.Total_Design.TabIndex = 76
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 77
        Me.Button2.Text = "Add to Job"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Job_Viewer
        '
        Me.Job_Viewer.AllowUserToAddRows = False
        Me.Job_Viewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Job_Viewer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EMPLOYEE_NAME, Me.POSITION, Me.PAY})
        Me.Job_Viewer.Location = New System.Drawing.Point(240, 12)
        Me.Job_Viewer.Name = "Job_Viewer"
        Me.Job_Viewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Job_Viewer.Size = New System.Drawing.Size(293, 417)
        Me.Job_Viewer.TabIndex = 78
        '
        'EMPLOYEE_NAME
        '
        Me.EMPLOYEE_NAME.HeaderText = "Employee"
        Me.EMPLOYEE_NAME.Name = "EMPLOYEE_NAME"
        '
        'POSITION
        '
        Me.POSITION.HeaderText = "Position"
        Me.POSITION.Name = "POSITION"
        '
        'PAY
        '
        Me.PAY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PAY.HeaderText = "Pay"
        Me.PAY.Name = "PAY"
        Me.PAY.Width = 50
        '
        'Total_Testing
        '
        Me.Total_Testing.Location = New System.Drawing.Point(129, 298)
        Me.Total_Testing.Name = "Total_Testing"
        Me.Total_Testing.Size = New System.Drawing.Size(105, 20)
        Me.Total_Testing.TabIndex = 80
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 298)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Testing Total:"
        '
        'Total_Assembly
        '
        Me.Total_Assembly.Location = New System.Drawing.Point(129, 272)
        Me.Total_Assembly.Name = "Total_Assembly"
        Me.Total_Assembly.Size = New System.Drawing.Size(105, 20)
        Me.Total_Assembly.TabIndex = 82
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Assembly Total:"
        '
        'Total_Programming
        '
        Me.Total_Programming.Location = New System.Drawing.Point(129, 246)
        Me.Total_Programming.Name = "Total_Programming"
        Me.Total_Programming.Size = New System.Drawing.Size(105, 20)
        Me.Total_Programming.TabIndex = 84
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 13)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Programming Total:"
        '
        'Total_Documentation
        '
        Me.Total_Documentation.Location = New System.Drawing.Point(129, 324)
        Me.Total_Documentation.Name = "Total_Documentation"
        Me.Total_Documentation.Size = New System.Drawing.Size(105, 20)
        Me.Total_Documentation.TabIndex = 88
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 324)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 13)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Documentaition Total:"
        '
        'Total_Site
        '
        Me.Total_Site.Location = New System.Drawing.Point(129, 350)
        Me.Total_Site.Name = "Total_Site"
        Me.Total_Site.Size = New System.Drawing.Size(105, 20)
        Me.Total_Site.TabIndex = 86
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 350)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 13)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Site Installation Total:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(15, 406)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 23)
        Me.Button3.TabIndex = 89
        Me.Button3.Text = "Insert into Breakdown"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Emp_HourlyPay
        '
        Me.Emp_HourlyPay.Location = New System.Drawing.Point(151, 136)
        Me.Emp_HourlyPay.Name = "Emp_HourlyPay"
        Me.Emp_HourlyPay.Size = New System.Drawing.Size(83, 20)
        Me.Emp_HourlyPay.TabIndex = 90
        Me.Emp_HourlyPay.Visible = False
        '
        'EmployeeCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 757)
        Me.Controls.Add(Me.Emp_HourlyPay)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Total_Documentation)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Total_Site)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Total_Programming)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Total_Assembly)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Total_Testing)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Job_Viewer)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Total_Design)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Emp_Position)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Emp_Hours)
        Me.Controls.Add(Me.Emp_Name)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Emp_Viewer)
        Me.Name = "EmployeeCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmployeeCalculator"
        CType(Me.Emp_Viewer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Job_Viewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Emp_Viewer As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Emp_Name As TextBox
    Friend WithEvents Emp_Hours As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Emp_Position As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Total_Design As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Job_Viewer As DataGridView
    Friend WithEvents Total_Testing As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Total_Assembly As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Total_Programming As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Total_Documentation As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Total_Site As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Emp_HourlyPay As TextBox
    Friend WithEvents EMPLOYEE_NAME As DataGridViewTextBoxColumn
    Friend WithEvents POSITION As DataGridViewTextBoxColumn
    Friend WithEvents PAY As DataGridViewTextBoxColumn
End Class
