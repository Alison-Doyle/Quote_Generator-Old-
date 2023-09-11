<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpencesCalculator
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totalCostOfTravel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.travelContainer = New System.Windows.Forms.GroupBox()
        Me.costPerUnitOfDistance = New System.Windows.Forms.NumericUpDown()
        Me.numberOfUnitsOfDistance = New System.Windows.Forms.NumericUpDown()
        Me.numberOfReturnTrips = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.numberOfPeopleToBeFed = New System.Windows.Forms.NumericUpDown()
        Me.costPerMeal = New System.Windows.Forms.NumericUpDown()
        Me.numberOfDaysPeopleMustBeFed = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.totalCostOfMeals = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.numberOfNights = New System.Windows.Forms.NumericUpDown()
        Me.numberOfPeopleToAccomodate = New System.Windows.Forms.NumericUpDown()
        Me.costPerNight = New System.Windows.Forms.NumericUpDown()
        Me.totalCostOfAccomodation = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.numberOfDaysOfCalls = New System.Windows.Forms.NumericUpDown()
        Me.costPerCall = New System.Windows.Forms.NumericUpDown()
        Me.callsPerDay = New System.Windows.Forms.NumericUpDown()
        Me.totalCostOfTelephoneSupport = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Other = New System.Windows.Forms.GroupBox()
        Me.siteAllowance = New System.Windows.Forms.NumericUpDown()
        Me.wearAndTear = New System.Windows.Forms.NumericUpDown()
        Me.training = New System.Windows.Forms.NumericUpDown()
        Me.ppe = New System.Windows.Forms.NumericUpDown()
        Me.specialistEquipment = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.travelContainer.SuspendLayout()
        CType(Me.costPerUnitOfDistance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numberOfUnitsOfDistance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numberOfReturnTrips, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numberOfPeopleToBeFed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.costPerMeal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numberOfDaysPeopleMustBeFed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numberOfNights, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numberOfPeopleToAccomodate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.costPerNight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.numberOfDaysOfCalls, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.costPerCall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.callsPerDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Other.SuspendLayout()
        CType(Me.siteAllowance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wearAndTear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.training, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ppe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.specialistEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. of Km/Mile"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cost per Km/Mile"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total:"
        '
        'totalCostOfTravel
        '
        Me.totalCostOfTravel.Location = New System.Drawing.Point(135, 103)
        Me.totalCostOfTravel.Name = "totalCostOfTravel"
        Me.totalCostOfTravel.ReadOnly = True
        Me.totalCostOfTravel.Size = New System.Drawing.Size(120, 20)
        Me.totalCostOfTravel.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Expences Calculator"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "No. Of Return Trips:"
        '
        'travelContainer
        '
        Me.travelContainer.Controls.Add(Me.costPerUnitOfDistance)
        Me.travelContainer.Controls.Add(Me.numberOfUnitsOfDistance)
        Me.travelContainer.Controls.Add(Me.numberOfReturnTrips)
        Me.travelContainer.Controls.Add(Me.Label6)
        Me.travelContainer.Controls.Add(Me.Label2)
        Me.travelContainer.Controls.Add(Me.Label3)
        Me.travelContainer.Controls.Add(Me.Label4)
        Me.travelContainer.Controls.Add(Me.totalCostOfTravel)
        Me.travelContainer.Location = New System.Drawing.Point(9, 37)
        Me.travelContainer.Margin = New System.Windows.Forms.Padding(2)
        Me.travelContainer.Name = "travelContainer"
        Me.travelContainer.Padding = New System.Windows.Forms.Padding(2)
        Me.travelContainer.Size = New System.Drawing.Size(260, 128)
        Me.travelContainer.TabIndex = 52
        Me.travelContainer.TabStop = False
        Me.travelContainer.Text = "Travel"
        '
        'costPerUnitOfDistance
        '
        Me.costPerUnitOfDistance.Location = New System.Drawing.Point(135, 63)
        Me.costPerUnitOfDistance.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.costPerUnitOfDistance.Name = "costPerUnitOfDistance"
        Me.costPerUnitOfDistance.Size = New System.Drawing.Size(120, 20)
        Me.costPerUnitOfDistance.TabIndex = 12
        '
        'numberOfUnitsOfDistance
        '
        Me.numberOfUnitsOfDistance.Location = New System.Drawing.Point(135, 39)
        Me.numberOfUnitsOfDistance.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numberOfUnitsOfDistance.Name = "numberOfUnitsOfDistance"
        Me.numberOfUnitsOfDistance.Size = New System.Drawing.Size(120, 20)
        Me.numberOfUnitsOfDistance.TabIndex = 11
        '
        'numberOfReturnTrips
        '
        Me.numberOfReturnTrips.Location = New System.Drawing.Point(135, 15)
        Me.numberOfReturnTrips.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numberOfReturnTrips.Name = "numberOfReturnTrips"
        Me.numberOfReturnTrips.Size = New System.Drawing.Size(120, 20)
        Me.numberOfReturnTrips.TabIndex = 10
        Me.numberOfReturnTrips.ThousandsSeparator = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numberOfPeopleToBeFed)
        Me.GroupBox1.Controls.Add(Me.costPerMeal)
        Me.GroupBox1.Controls.Add(Me.numberOfDaysPeopleMustBeFed)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.totalCostOfMeals)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 170)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(260, 128)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Meals"
        '
        'numberOfPeopleToBeFed
        '
        Me.numberOfPeopleToBeFed.Location = New System.Drawing.Point(135, 39)
        Me.numberOfPeopleToBeFed.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numberOfPeopleToBeFed.Name = "numberOfPeopleToBeFed"
        Me.numberOfPeopleToBeFed.Size = New System.Drawing.Size(120, 20)
        Me.numberOfPeopleToBeFed.TabIndex = 12
        '
        'costPerMeal
        '
        Me.costPerMeal.Location = New System.Drawing.Point(135, 63)
        Me.costPerMeal.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.costPerMeal.Name = "costPerMeal"
        Me.costPerMeal.Size = New System.Drawing.Size(120, 20)
        Me.costPerMeal.TabIndex = 11
        '
        'numberOfDaysPeopleMustBeFed
        '
        Me.numberOfDaysPeopleMustBeFed.Location = New System.Drawing.Point(135, 15)
        Me.numberOfDaysPeopleMustBeFed.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numberOfDaysPeopleMustBeFed.Name = "numberOfDaysPeopleMustBeFed"
        Me.numberOfDaysPeopleMustBeFed.Size = New System.Drawing.Size(120, 20)
        Me.numberOfDaysPeopleMustBeFed.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Days"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "No. People"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Cost per Meal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Total:"
        '
        'totalCostOfMeals
        '
        Me.totalCostOfMeals.Location = New System.Drawing.Point(135, 103)
        Me.totalCostOfMeals.Name = "totalCostOfMeals"
        Me.totalCostOfMeals.ReadOnly = True
        Me.totalCostOfMeals.Size = New System.Drawing.Size(120, 20)
        Me.totalCostOfMeals.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.numberOfNights)
        Me.GroupBox2.Controls.Add(Me.numberOfPeopleToAccomodate)
        Me.GroupBox2.Controls.Add(Me.costPerNight)
        Me.GroupBox2.Controls.Add(Me.totalCostOfAccomodation)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 303)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(260, 128)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Accomodation"
        '
        'numberOfNights
        '
        Me.numberOfNights.Location = New System.Drawing.Point(135, 39)
        Me.numberOfNights.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numberOfNights.Name = "numberOfNights"
        Me.numberOfNights.Size = New System.Drawing.Size(120, 20)
        Me.numberOfNights.TabIndex = 16
        '
        'numberOfPeopleToAccomodate
        '
        Me.numberOfPeopleToAccomodate.Location = New System.Drawing.Point(135, 63)
        Me.numberOfPeopleToAccomodate.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numberOfPeopleToAccomodate.Name = "numberOfPeopleToAccomodate"
        Me.numberOfPeopleToAccomodate.Size = New System.Drawing.Size(120, 20)
        Me.numberOfPeopleToAccomodate.TabIndex = 15
        '
        'costPerNight
        '
        Me.costPerNight.Location = New System.Drawing.Point(135, 15)
        Me.costPerNight.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.costPerNight.Name = "costPerNight"
        Me.costPerNight.Size = New System.Drawing.Size(120, 20)
        Me.costPerNight.TabIndex = 14
        '
        'totalCostOfAccomodation
        '
        Me.totalCostOfAccomodation.Location = New System.Drawing.Point(135, 103)
        Me.totalCostOfAccomodation.Name = "totalCostOfAccomodation"
        Me.totalCostOfAccomodation.ReadOnly = True
        Me.totalCostOfAccomodation.Size = New System.Drawing.Size(120, 20)
        Me.totalCostOfAccomodation.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Cost Per Night"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "No. Nights"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "No. People"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Total:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.numberOfDaysOfCalls)
        Me.GroupBox3.Controls.Add(Me.costPerCall)
        Me.GroupBox3.Controls.Add(Me.callsPerDay)
        Me.GroupBox3.Controls.Add(Me.totalCostOfTelephoneSupport)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 435)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(260, 128)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Telphone Support"
        '
        'numberOfDaysOfCalls
        '
        Me.numberOfDaysOfCalls.Location = New System.Drawing.Point(135, 39)
        Me.numberOfDaysOfCalls.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numberOfDaysOfCalls.Name = "numberOfDaysOfCalls"
        Me.numberOfDaysOfCalls.Size = New System.Drawing.Size(120, 20)
        Me.numberOfDaysOfCalls.TabIndex = 16
        '
        'costPerCall
        '
        Me.costPerCall.Location = New System.Drawing.Point(135, 63)
        Me.costPerCall.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.costPerCall.Name = "costPerCall"
        Me.costPerCall.Size = New System.Drawing.Size(120, 20)
        Me.costPerCall.TabIndex = 15
        '
        'callsPerDay
        '
        Me.callsPerDay.Location = New System.Drawing.Point(135, 15)
        Me.callsPerDay.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.callsPerDay.Name = "callsPerDay"
        Me.callsPerDay.Size = New System.Drawing.Size(120, 20)
        Me.callsPerDay.TabIndex = 14
        '
        'totalCostOfTelephoneSupport
        '
        Me.totalCostOfTelephoneSupport.Location = New System.Drawing.Point(135, 103)
        Me.totalCostOfTelephoneSupport.Name = "totalCostOfTelephoneSupport"
        Me.totalCostOfTelephoneSupport.ReadOnly = True
        Me.totalCostOfTelephoneSupport.Size = New System.Drawing.Size(120, 20)
        Me.totalCostOfTelephoneSupport.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Calls per Day"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "No. Days"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 63)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Cost per Call"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(5, 101)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 13)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Total:"
        '
        'Other
        '
        Me.Other.Controls.Add(Me.siteAllowance)
        Me.Other.Controls.Add(Me.wearAndTear)
        Me.Other.Controls.Add(Me.training)
        Me.Other.Controls.Add(Me.ppe)
        Me.Other.Controls.Add(Me.specialistEquipment)
        Me.Other.Controls.Add(Me.Label22)
        Me.Other.Controls.Add(Me.Label21)
        Me.Other.Controls.Add(Me.Label20)
        Me.Other.Controls.Add(Me.Label19)
        Me.Other.Controls.Add(Me.Label18)
        Me.Other.Location = New System.Drawing.Point(9, 568)
        Me.Other.Name = "Other"
        Me.Other.Size = New System.Drawing.Size(260, 148)
        Me.Other.TabIndex = 56
        Me.Other.TabStop = False
        Me.Other.Text = "Other"
        '
        'siteAllowance
        '
        Me.siteAllowance.Location = New System.Drawing.Point(135, 120)
        Me.siteAllowance.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.siteAllowance.Name = "siteAllowance"
        Me.siteAllowance.Size = New System.Drawing.Size(120, 20)
        Me.siteAllowance.TabIndex = 9
        '
        'wearAndTear
        '
        Me.wearAndTear.Location = New System.Drawing.Point(135, 94)
        Me.wearAndTear.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.wearAndTear.Name = "wearAndTear"
        Me.wearAndTear.Size = New System.Drawing.Size(120, 20)
        Me.wearAndTear.TabIndex = 8
        '
        'training
        '
        Me.training.Location = New System.Drawing.Point(135, 68)
        Me.training.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.training.Name = "training"
        Me.training.Size = New System.Drawing.Size(120, 20)
        Me.training.TabIndex = 7
        '
        'ppe
        '
        Me.ppe.Location = New System.Drawing.Point(135, 42)
        Me.ppe.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.ppe.Name = "ppe"
        Me.ppe.Size = New System.Drawing.Size(120, 20)
        Me.ppe.TabIndex = 6
        '
        'specialistEquipment
        '
        Me.specialistEquipment.Location = New System.Drawing.Point(135, 16)
        Me.specialistEquipment.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.specialistEquipment.Name = "specialistEquipment"
        Me.specialistEquipment.Size = New System.Drawing.Size(120, 20)
        Me.specialistEquipment.TabIndex = 5
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(5, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(77, 13)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Site Allowance"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(5, 94)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(123, 13)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "Wear and tear on Equip."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(5, 68)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Training"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(5, 42)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 13)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "PPE"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(5, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Specialist Equipment"
        '
        'ExpencesCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 724)
        Me.Controls.Add(Me.Other)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.travelContainer)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ExpencesCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expences Calculator"
        Me.travelContainer.ResumeLayout(False)
        Me.travelContainer.PerformLayout()
        CType(Me.costPerUnitOfDistance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numberOfUnitsOfDistance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numberOfReturnTrips, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numberOfPeopleToBeFed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.costPerMeal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numberOfDaysPeopleMustBeFed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numberOfNights, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numberOfPeopleToAccomodate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.costPerNight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.numberOfDaysOfCalls, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.costPerCall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.callsPerDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Other.ResumeLayout(False)
        Me.Other.PerformLayout()
        CType(Me.siteAllowance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wearAndTear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.training, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ppe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.specialistEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents totalCostOfTravel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents travelContainer As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents totalCostOfMeals As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents totalCostOfAccomodation As TextBox
    Friend WithEvents numberOfReturnTrips As NumericUpDown
    Friend WithEvents costPerUnitOfDistance As NumericUpDown
    Friend WithEvents numberOfUnitsOfDistance As NumericUpDown
    Friend WithEvents numberOfPeopleToBeFed As NumericUpDown
    Friend WithEvents costPerMeal As NumericUpDown
    Friend WithEvents numberOfDaysPeopleMustBeFed As NumericUpDown
    Friend WithEvents numberOfNights As NumericUpDown
    Friend WithEvents numberOfPeopleToAccomodate As NumericUpDown
    Friend WithEvents costPerNight As NumericUpDown
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents numberOfDaysOfCalls As NumericUpDown
    Friend WithEvents costPerCall As NumericUpDown
    Friend WithEvents callsPerDay As NumericUpDown
    Friend WithEvents totalCostOfTelephoneSupport As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Other As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents siteAllowance As NumericUpDown
    Friend WithEvents wearAndTear As NumericUpDown
    Friend WithEvents training As NumericUpDown
    Friend WithEvents ppe As NumericUpDown
    Friend WithEvents specialistEquipment As NumericUpDown
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
End Class
