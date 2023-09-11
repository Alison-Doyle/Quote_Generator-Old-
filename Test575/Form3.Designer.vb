<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuoteGen
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.createFileButton = New System.Windows.Forms.Button()
        Me.selectFileLocationButton = New System.Windows.Forms.Button()
        Me.Doc_FileName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Doc_CompanyName = New System.Windows.Forms.TextBox()
        Me.Doc_QuoteNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Doc_DocLocation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Doc_DocOwner = New System.Windows.Forms.TextBox()
        Me.Doc_RefNumber = New System.Windows.Forms.TextBox()
        Me.Doc_RevisionNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Proj_DocViewer = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proj_DocDesc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Proj_DocOwner = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Proj_Address = New System.Windows.Forms.TextBox()
        Me.Proj_EnquirerTitle = New System.Windows.Forms.TextBox()
        Me.Proj_EquirerName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.BackBtn = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Proj_DocViewer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.createFileButton)
        Me.GroupBox1.Controls.Add(Me.selectFileLocationButton)
        Me.GroupBox1.Controls.Add(Me.Doc_FileName)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Doc_CompanyName)
        Me.GroupBox1.Controls.Add(Me.Doc_QuoteNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Doc_DocLocation)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 159)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General Details"
        '
        'createFileButton
        '
        Me.createFileButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createFileButton.Location = New System.Drawing.Point(570, 130)
        Me.createFileButton.Name = "createFileButton"
        Me.createFileButton.Size = New System.Drawing.Size(75, 23)
        Me.createFileButton.TabIndex = 6
        Me.createFileButton.Text = "Create File"
        Me.createFileButton.UseVisualStyleBackColor = True
        '
        'selectFileLocationButton
        '
        Me.selectFileLocationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectFileLocationButton.Location = New System.Drawing.Point(444, 110)
        Me.selectFileLocationButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.selectFileLocationButton.Name = "selectFileLocationButton"
        Me.selectFileLocationButton.Size = New System.Drawing.Size(91, 23)
        Me.selectFileLocationButton.TabIndex = 5
        Me.selectFileLocationButton.Text = "Pick Location"
        Me.selectFileLocationButton.UseVisualStyleBackColor = True
        '
        'Doc_FileName
        '
        Me.Doc_FileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doc_FileName.Location = New System.Drawing.Point(234, 27)
        Me.Doc_FileName.Name = "Doc_FileName"
        Me.Doc_FileName.Size = New System.Drawing.Size(206, 22)
        Me.Doc_FileName.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "File Name:"
        '
        'Doc_CompanyName
        '
        Me.Doc_CompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doc_CompanyName.Location = New System.Drawing.Point(234, 55)
        Me.Doc_CompanyName.Name = "Doc_CompanyName"
        Me.Doc_CompanyName.Size = New System.Drawing.Size(206, 22)
        Me.Doc_CompanyName.TabIndex = 0
        '
        'Doc_QuoteNo
        '
        Me.Doc_QuoteNo.BackColor = System.Drawing.SystemColors.Window
        Me.Doc_QuoteNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doc_QuoteNo.Location = New System.Drawing.Point(234, 83)
        Me.Doc_QuoteNo.Name = "Doc_QuoteNo"
        Me.Doc_QuoteNo.Size = New System.Drawing.Size(206, 22)
        Me.Doc_QuoteNo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quote Number:"
        '
        'Doc_DocLocation
        '
        Me.Doc_DocLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doc_DocLocation.Location = New System.Drawing.Point(234, 110)
        Me.Doc_DocLocation.Name = "Doc_DocLocation"
        Me.Doc_DocLocation.ReadOnly = True
        Me.Doc_DocLocation.Size = New System.Drawing.Size(206, 22)
        Me.Doc_DocLocation.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Document Location:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Company Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Doc_DocOwner)
        Me.GroupBox2.Controls.Add(Me.Doc_RefNumber)
        Me.GroupBox2.Controls.Add(Me.Doc_RevisionNumber)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 261)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(651, 118)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "1. Document Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Document Reference Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Owner:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Revision Number (if Applicable):"
        '
        'Doc_DocOwner
        '
        Me.Doc_DocOwner.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doc_DocOwner.Location = New System.Drawing.Point(234, 58)
        Me.Doc_DocOwner.Name = "Doc_DocOwner"
        Me.Doc_DocOwner.Size = New System.Drawing.Size(206, 22)
        Me.Doc_DocOwner.TabIndex = 2
        '
        'Doc_RefNumber
        '
        Me.Doc_RefNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doc_RefNumber.Location = New System.Drawing.Point(234, 87)
        Me.Doc_RefNumber.Name = "Doc_RefNumber"
        Me.Doc_RefNumber.Size = New System.Drawing.Size(206, 22)
        Me.Doc_RefNumber.TabIndex = 3
        '
        'Doc_RevisionNumber
        '
        Me.Doc_RevisionNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doc_RevisionNumber.Location = New System.Drawing.Point(234, 31)
        Me.Doc_RevisionNumber.Name = "Doc_RevisionNumber"
        Me.Doc_RevisionNumber.Size = New System.Drawing.Size(206, 22)
        Me.Doc_RevisionNumber.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Proj_DocViewer)
        Me.GroupBox3.Controls.Add(Me.Proj_DocDesc)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Proj_DocOwner)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Proj_Address)
        Me.GroupBox3.Controls.Add(Me.Proj_EnquirerTitle)
        Me.GroupBox3.Controls.Add(Me.Proj_EquirerName)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 385)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(651, 531)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "2. Project Details"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(490, 295)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(155, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Add to Documentation"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Proj_DocViewer
        '
        Me.Proj_DocViewer.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proj_DocViewer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Proj_DocViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Proj_DocViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Proj_DocViewer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.Proj_DocViewer.EnableHeadersVisualStyles = False
        Me.Proj_DocViewer.Location = New System.Drawing.Point(9, 324)
        Me.Proj_DocViewer.Name = "Proj_DocViewer"
        Me.Proj_DocViewer.RowHeadersVisible = False
        Me.Proj_DocViewer.RowHeadersWidth = 51
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proj_DocViewer.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.Proj_DocViewer.Size = New System.Drawing.Size(636, 191)
        Me.Proj_DocViewer.TabIndex = 17
        '
        'Column1
        '
        Me.Column1.HeaderText = "Doc. Description"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Owner"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Proj_DocDesc
        '
        Me.Proj_DocDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proj_DocDesc.Location = New System.Drawing.Point(9, 199)
        Me.Proj_DocDesc.Multiline = True
        Me.Proj_DocDesc.Name = "Proj_DocDesc"
        Me.Proj_DocDesc.Size = New System.Drawing.Size(476, 119)
        Me.Proj_DocDesc.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Document Description:"
        '
        'Proj_DocOwner
        '
        Me.Proj_DocOwner.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proj_DocOwner.Location = New System.Drawing.Point(9, 155)
        Me.Proj_DocOwner.Name = "Proj_DocOwner"
        Me.Proj_DocOwner.Size = New System.Drawing.Size(219, 22)
        Me.Proj_DocOwner.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 16)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Owner:"
        '
        'Proj_Address
        '
        Me.Proj_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proj_Address.Location = New System.Drawing.Point(234, 93)
        Me.Proj_Address.Name = "Proj_Address"
        Me.Proj_Address.Size = New System.Drawing.Size(206, 22)
        Me.Proj_Address.TabIndex = 2
        '
        'Proj_EnquirerTitle
        '
        Me.Proj_EnquirerTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proj_EnquirerTitle.Location = New System.Drawing.Point(234, 65)
        Me.Proj_EnquirerTitle.Name = "Proj_EnquirerTitle"
        Me.Proj_EnquirerTitle.Size = New System.Drawing.Size(206, 22)
        Me.Proj_EnquirerTitle.TabIndex = 1
        '
        'Proj_EquirerName
        '
        Me.Proj_EquirerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proj_EquirerName.Location = New System.Drawing.Point(234, 37)
        Me.Proj_EquirerName.Name = "Proj_EquirerName"
        Me.Proj_EquirerName.Size = New System.Drawing.Size(206, 22)
        Me.Proj_EquirerName.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Address of Enquirer:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Title:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(202, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Name of Person who left Enquiry:"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(300, 922)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Insert Page"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(579, 12)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(84, 23)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Next Page"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(12, 12)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(84, 23)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "Back to Menu"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'BackBtn
        '
        Me.BackBtn.Location = New System.Drawing.Point(12, 922)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(84, 23)
        Me.BackBtn.TabIndex = 5
        Me.BackBtn.Text = "Back to Menu"
        Me.BackBtn.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(579, 922)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(84, 23)
        Me.Button9.TabIndex = 6
        Me.Button9.Text = "Next Page"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Test575.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(21, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(653, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'QuoteGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 689)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "QuoteGen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quote Generator - Page 1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Proj_DocViewer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Doc_CompanyName As TextBox
    Friend WithEvents Doc_QuoteNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Doc_DocLocation As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Doc_DocOwner As TextBox
    Friend WithEvents Doc_RefNumber As TextBox
    Friend WithEvents Doc_RevisionNumber As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Proj_Address As TextBox
    Friend WithEvents Proj_EnquirerTitle As TextBox
    Friend WithEvents Proj_EquirerName As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Proj_DocViewer As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Proj_DocDesc As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Proj_DocOwner As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents BackBtn As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Doc_FileName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents selectFileLocationButton As Button
    Friend WithEvents createFileButton As Button
End Class
