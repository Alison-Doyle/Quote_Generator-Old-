Public Class ExpencesCalculator
    Private Sub ExpencesCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Removing up/down buttons on side of textbox. 0 corrosponds with arrow controls. 
        numberOfReturnTrips.Controls(0).Visible = False
        numberOfUnitsOfDistance.Controls(0).Visible = False
        costPerUnitOfDistance.Controls(0).Visible = False
        numberOfDaysPeopleMustBeFed.Controls(0).Visible = False
        numberOfPeopleToBeFed.Controls(0).Visible = False
        costPerMeal.Controls(0).Visible = False
        costPerNight.Controls(0).Visible = False
        numberOfNights.Controls(0).Visible = False
        numberOfPeopleToAccomodate.Controls(0).Visible = False
        callsPerDay.Controls(0).Visible = False
        numberOfDaysOfCalls.Controls(0).Visible = False
        costPerCall.Controls(0).Visible = False
        specialistEquipment.Controls(0).Visible = False
        ppe.Controls(0).Visible = False
        training.Controls(0).Visible = False
        wearAndTear.Controls(0).Visible = False
        siteAllowance.Controls(0).Visible = False

        'Setting Decimal points
        numberOfReturnTrips.DecimalPlaces = 0
        numberOfUnitsOfDistance.DecimalPlaces = 2
        costPerUnitOfDistance.DecimalPlaces = 2
        numberOfDaysPeopleMustBeFed.DecimalPlaces = 0
        numberOfPeopleToBeFed.DecimalPlaces = 0
        costPerMeal.DecimalPlaces = 2
        costPerNight.DecimalPlaces = 2
        numberOfNights.DecimalPlaces = 0
        numberOfPeopleToAccomodate.DecimalPlaces = 0
        callsPerDay.DecimalPlaces = 0
        numberOfDaysOfCalls.DecimalPlaces = 0
        costPerCall.DecimalPlaces = 2
        specialistEquipment.DecimalPlaces = 2
        ppe.DecimalPlaces = 2
        training.DecimalPlaces = 2
        wearAndTear.DecimalPlaces = 2
        siteAllowance.DecimalPlaces = 2
    End Sub

    Private Sub ExpencesCalculator_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        addExpencesToFinalQuote()
    End Sub

    Private Sub numberOfReturnTrips_ValueChanged(sender As Object, e As EventArgs) Handles numberOfReturnTrips.ValueChanged
        calculateCostOfTravel()
    End Sub

    Private Sub numberOfUnitsOfDistance_ValueChanged(sender As Object, e As EventArgs) Handles numberOfUnitsOfDistance.ValueChanged
        calculateCostOfTravel()
    End Sub

    Private Sub costPerUnitOfDistance_ValueChanged(sender As Object, e As EventArgs) Handles costPerUnitOfDistance.ValueChanged
        calculateCostOfTravel()
    End Sub

    Private Sub numberOfDaysPeopleMustBeFed_ValueChanged(sender As Object, e As EventArgs) Handles numberOfDaysPeopleMustBeFed.ValueChanged
        calculateCostOfMeals()
    End Sub

    Private Sub numberOfPeopleToBeFed_ValueChanged(sender As Object, e As EventArgs) Handles numberOfPeopleToBeFed.ValueChanged
        calculateCostOfMeals()
    End Sub

    Private Sub costPerMeal_ValueChanged(sender As Object, e As EventArgs) Handles costPerMeal.ValueChanged
        calculateCostOfMeals()
    End Sub

    Private Sub costPerNight_ValueChanged(sender As Object, e As EventArgs) Handles costPerNight.ValueChanged
        calculateCostOfAccomodation()
    End Sub

    Private Sub numberOfNights_ValueChanged(sender As Object, e As EventArgs) Handles numberOfNights.ValueChanged
        calculateCostOfAccomodation()
    End Sub

    Private Sub numberOfPeopleToAccomodate_ValueChanged(sender As Object, e As EventArgs) Handles numberOfPeopleToAccomodate.ValueChanged
        calculateCostOfAccomodation()
    End Sub

    Private Sub callsPerDay_ValueChanged(sender As Object, e As EventArgs) Handles callsPerDay.ValueChanged
        calculateCostOfTelephoneSupport()
    End Sub

    Private Sub numberOfDaysOfCalls_ValueChanged(sender As Object, e As EventArgs) Handles numberOfDaysOfCalls.ValueChanged
        calculateCostOfTelephoneSupport()
    End Sub

    Private Sub costPerCall_ValueChanged(sender As Object, e As EventArgs) Handles costPerCall.ValueChanged
        calculateCostOfTelephoneSupport()
    End Sub

    Private Sub incorrectFormatToolTip(ByRef textbox As Control)
        Dim toolTipMessage = "Please make sure number doesn't contain a decimal place"
        Dim incorrectFormatToolTip As New ToolTip
        incorrectFormatToolTip.SetToolTip(textbox, toolTipMessage)
    End Sub

    Sub calculateCostOfTravel()
        Dim cost As Double = numberOfReturnTrips.Text * numberOfUnitsOfDistance.Text * costPerUnitOfDistance.Text
        totalCostOfTravel.Text = "€" + cost.ToString()
    End Sub

    Sub calculateCostOfMeals()
        Dim cost As Double = numberOfDaysPeopleMustBeFed.Text * numberOfPeopleToBeFed.Text * costPerMeal.Text
        totalCostOfMeals.Text = "€" + cost.ToString()
    End Sub

    Sub calculateCostOfAccomodation()
        Dim cost As Double = costPerNight.Text * numberOfNights.Text * numberOfPeopleToAccomodate.Text
        totalCostOfAccomodation.Text = "€" + cost.ToString()
    End Sub

    Sub calculateCostOfTelephoneSupport()
        Dim cost As Double = callsPerDay.Text * numberOfDaysOfCalls.Text * costPerCall.Text
        totalCostOfTelephoneSupport.Text = "€" + cost.ToString()
    End Sub

    Sub addExpencesToFinalQuote()
        Dim expences As String() = {
            totalCostOfTravel.Text,
            totalCostOfMeals.Text,
            totalCostOfAccomodation.Text,
            totalCostOfTelephoneSupport.Text,
            specialistEquipment.Value,
            ppe.Value,
            training.Value,
            wearAndTear.Value,
            siteAllowance.Value
            }

        Dim expencesNames As String() = {
            "Travel",
            "Meals",
            "Accommodation",
            "Telephone Support",
            "Specialist Equipment (Purchased/Rented)",
            "PPE",
            "Training",
            "Wear and Tear on Equipment",
            "Site Allowance"
            }

        'Remove € from value to keep consistency in quote document
        For i As Integer = 0 To expences.Count - 1 Step +1
            Dim expenceIndex = Nothing

            For j As Integer = 0 To QuoteGenerator4.Proj_CostBreakDown.Rows.Count - 1 Step +1
                If QuoteGenerator4.Proj_CostBreakDown.Rows(j).Cells(0).Value = expencesNames(i) Then
                    expenceIndex = j
                End If
            Next

            If String.IsNullOrEmpty(expences(i)) = False And expences(i) <> "0" Then
                If expenceIndex = Nothing Then
                    QuoteGenerator4.Proj_CostBreakDown.Rows.Add(expencesNames(i), expences(i).Replace("€", ""))
                ElseIf String.IsNullOrWhiteSpace(expences(i)) = False Then
                    QuoteGenerator4.Proj_CostBreakDown.Rows(expenceIndex).Cells(1).Value = expences(i)
                End If
            End If
        Next
    End Sub
End Class
