<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuoteGenerator3
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Presets = New System.Windows.Forms.ComboBox()
        Me.Proj_DescPLC = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Proj_CompTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Proj_CompPrecentage = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Proj_DescSCADA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Proj_CompCost = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Proj_CompViewer = New System.Windows.Forms.DataGridView()
        Me.Hardware_Supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hardware_Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hardware_Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hardware_Cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Proj_CompID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Proj_CompTakeOut = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Proj_CompSupply = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Proj_CompDesc = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Proj_CompViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(566, 1031)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Next Page"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(459, 1031)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Previous Page"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.SystemColors.Control
        Me.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BackBtn.Location = New System.Drawing.Point(12, 1031)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(101, 23)
        Me.BackBtn.TabIndex = 4
        Me.BackBtn.Text = "Back to Menu"
        Me.BackBtn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Presets)
        Me.GroupBox1.Controls.Add(Me.Proj_DescPLC)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Proj_CompTotal)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Proj_CompPrecentage)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Proj_DescSCADA)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Proj_CompCost)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Proj_CompViewer)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Proj_CompID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Proj_CompTakeOut)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Proj_CompSupply)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Proj_CompDesc)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 971)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "4. Proposed Hardware"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(135, 29)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 23)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Insert Pre-Set"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Presets
        '
        Me.Presets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Presets.FormattingEnabled = True
        Me.Presets.Location = New System.Drawing.Point(6, 30)
        Me.Presets.Name = "Presets"
        Me.Presets.Size = New System.Drawing.Size(125, 24)
        Me.Presets.TabIndex = 0
        '
        'Proj_DescPLC
        '
        Me.Proj_DescPLC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proj_DescPLC.Location = New System.Drawing.Point(9, 525)
        Me.Proj_DescPLC.Multiline = True
        Me.Proj_DescPLC.Name = "Proj_DescPLC"
        Me.Proj_DescPLC.Size = New System.Drawing.Size(631, 206)
        Me.Proj_DescPLC.TabIndex = 13
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(6, 60)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(107, 23)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "Open Stock Menu"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Proj_CompTotal
        '
        Me.Proj_CompTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proj_CompTotal.Location = New System.Drawing.Point(54, 434)
        Me.Proj_CompTotal.Name = "Proj_CompTotal"
        Me.Proj_CompTotal.ReadOnly = True
        Me.Proj_CompTotal.Size = New System.Drawing.Size(170, 22)
        Me.Proj_CompTotal.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 434)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 16)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Total:"
        '
        'Proj_CompPrecentage
        '
        Me.Proj_CompPrecentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proj_CompPrecentage.Location = New System.Drawing.Point(6, 348)
        Me.Proj_CompPrecentage.Name = "Proj_CompPrecentage"
        Me.Proj_CompPrecentage.Size = New System.Drawing.Size(218, 22)
        Me.Proj_CompPrecentage.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 16)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Percentage Add-On"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 461)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(636, 25)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "____________________________________________________"
        '
        'Proj_DescSCADA
        '
        Me.Proj_DescSCADA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proj_DescSCADA.Location = New System.Drawing.Point(9, 753)
        Me.Proj_DescSCADA.Multiline = True
        Me.Proj_DescSCADA.Name = "Proj_DescSCADA"
        Me.Proj_DescSCADA.Size = New System.Drawing.Size(631, 206)
        Me.Proj_DescSCADA.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 16)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Cost:"
        '
        'Proj_CompCost
        '
        Me.Proj_CompCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proj_CompCost.Location = New System.Drawing.Point(6, 260)
        Me.Proj_CompCost.Name = "Proj_CompCost"
        Me.Proj_CompCost.ReadOnly = True
        Me.Proj_CompCost.Size = New System.Drawing.Size(218, 22)
        Me.Proj_CompCost.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(6, 376)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(218, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Insert Componant"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Proj_CompViewer
        '
        Me.Proj_CompViewer.AllowUserToAddRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proj_CompViewer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Proj_CompViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.Proj_CompViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Proj_CompViewer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Hardware_Supplier, Me.Hardware_Desc, Me.Hardware_Quantity, Me.Hardware_Cost})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Proj_CompViewer.DefaultCellStyle = DataGridViewCellStyle4
        Me.Proj_CompViewer.EnableHeadersVisualStyles = False
        Me.Proj_CompViewer.Location = New System.Drawing.Point(233, 18)
        Me.Proj_CompViewer.Name = "Proj_CompViewer"
        Me.Proj_CompViewer.ReadOnly = True
        Me.Proj_CompViewer.RowHeadersWidth = 51
        Me.Proj_CompViewer.Size = New System.Drawing.Size(413, 438)
        Me.Proj_CompViewer.TabIndex = 12
        '
        'Hardware_Supplier
        '
        Me.Hardware_Supplier.HeaderText = "Supplier"
        Me.Hardware_Supplier.MinimumWidth = 6
        Me.Hardware_Supplier.Name = "Hardware_Supplier"
        Me.Hardware_Supplier.ReadOnly = True
        Me.Hardware_Supplier.Width = 116
        '
        'Hardware_Desc
        '
        Me.Hardware_Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Hardware_Desc.HeaderText = "Description"
        Me.Hardware_Desc.MinimumWidth = 6
        Me.Hardware_Desc.Name = "Hardware_Desc"
        Me.Hardware_Desc.ReadOnly = True
        '
        'Hardware_Quantity
        '
        Me.Hardware_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Hardware_Quantity.HeaderText = "Qty"
        Me.Hardware_Quantity.MinimumWidth = 6
        Me.Hardware_Quantity.Name = "Hardware_Quantity"
        Me.Hardware_Quantity.ReadOnly = True
        Me.Hardware_Quantity.Width = 70
        '
        'Hardware_Cost
        '
        Me.Hardware_Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Hardware_Cost.DataPropertyName = "Decimal"
        Me.Hardware_Cost.HeaderText = "Cost"
        Me.Hardware_Cost.MinimumWidth = 6
        Me.Hardware_Cost.Name = "Hardware_Cost"
        Me.Hardware_Cost.ReadOnly = True
        Me.Hardware_Cost.Width = 81
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 16)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "Location/ Sleater ID:"
        '
        'Proj_CompID
        '
        Me.Proj_CompID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proj_CompID.Location = New System.Drawing.Point(6, 105)
        Me.Proj_CompID.Name = "Proj_CompID"
        Me.Proj_CompID.Size = New System.Drawing.Size(218, 22)
        Me.Proj_CompID.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 734)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 16)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Description of SCADA/HMI Software:"
        '
        'Proj_CompTakeOut
        '
        Me.Proj_CompTakeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proj_CompTakeOut.Location = New System.Drawing.Point(6, 304)
        Me.Proj_CompTakeOut.Name = "Proj_CompTakeOut"
        Me.Proj_CompTakeOut.Size = New System.Drawing.Size(218, 22)
        Me.Proj_CompTakeOut.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 506)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 16)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Description of PLC Hardware:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Supplier"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 285)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(171, 16)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Estimated Needed Amount:"
        '
        'Proj_CompSupply
        '
        Me.Proj_CompSupply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proj_CompSupply.Location = New System.Drawing.Point(6, 149)
        Me.Proj_CompSupply.Name = "Proj_CompSupply"
        Me.Proj_CompSupply.ReadOnly = True
        Me.Proj_CompSupply.Size = New System.Drawing.Size(218, 22)
        Me.Proj_CompSupply.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Description"
        '
        'Proj_CompDesc
        '
        Me.Proj_CompDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proj_CompDesc.Location = New System.Drawing.Point(6, 193)
        Me.Proj_CompDesc.Multiline = True
        Me.Proj_CompDesc.Name = "Proj_CompDesc"
        Me.Proj_CompDesc.ReadOnly = True
        Me.Proj_CompDesc.Size = New System.Drawing.Size(218, 45)
        Me.Proj_CompDesc.TabIndex = 5
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 12)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(84, 23)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Previous Page"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(579, 12)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(84, 23)
        Me.Button10.TabIndex = 2
        Me.Button10.Text = "Next Page"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(300, 1031)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(101, 23)
        Me.Button12.TabIndex = 5
        Me.Button12.Text = "Insert Page"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'QuoteGenerator3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(704, 689)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "QuoteGenerator3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quote Generator - Page 3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Proj_CompViewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BackBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Proj_CompViewer As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Proj_CompCost As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Proj_CompID As TextBox
    Friend WithEvents Proj_CompTakeOut As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Proj_CompDesc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Proj_DescSCADA As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Proj_CompSupply As TextBox
    Friend WithEvents Proj_CompPrecentage As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Proj_CompTotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Proj_DescPLC As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Presets As ComboBox
    Friend WithEvents Hardware_Supplier As DataGridViewTextBoxColumn
    Friend WithEvents Hardware_Desc As DataGridViewTextBoxColumn
    Friend WithEvents Hardware_Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Hardware_Cost As DataGridViewTextBoxColumn
End Class
