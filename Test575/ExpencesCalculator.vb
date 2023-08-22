Public Class ExpencesCalculator
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Travel_Update.Click 'Update Travel Expences
        Try
            If Travel_UnitCost.TextLength > 0 Then
                If Travel_Miles.TextLength > 0 Then
                    If Travel_Trips.TextLength > 0 Then
                        Total_Travel.Text = Convert.ToInt32(Travel_Trips.Text) * Convert.ToDecimal(Travel_Miles.Text) * Convert.ToInt32(Travel_UnitCost.Text)
                    End If
                End If
            End If
        Catch
            MessageBox.Show("Incorrect Input")
        End Try
    End Sub

    Private Sub Meals_Update_Click(sender As Object, e As EventArgs) Handles Meals_Update.Click 'Update Meal Expences
        Try
            If Meals_UnitCost.TextLength > 0 Then
                If Meals_People.TextLength > 0 Then
                    If Meals_Days.TextLength > 0 Then
                        Total_Meals.Text = Convert.ToInt32(Meals_Days.Text) * Convert.ToInt32(Meals_People.Text) * Convert.ToDecimal(Meals_UnitCost.Text)
                    End If
                End If
            End If
        Catch
            MessageBox.Show("Incorrect Input")
        End Try
    End Sub

    Private Sub Accomodation_Update_Click(sender As Object, e As EventArgs) Handles Accomodation_Update.Click   'Update Accomodation Expences
        Try
            If Accomodation_Cost.TextLength > 0 Then
                If Accomodation_Nights.TextLength > 0 Then
                    If Accomodation_People.TextLength > 0 Then
                        Total_Accomodation.Text = Convert.ToInt32(Accomodation_Nights.Text) * Convert.ToDecimal(Accomodation_Cost.Text) * Convert.ToInt32(Accomodation_People.Text)
                    End If
                End If
            End If
        Catch
            MessageBox.Show("Incorrect Input")
        End Try
    End Sub

    Private Sub Telephone_Update_Click(sender As Object, e As EventArgs) Handles Telephone_Update.Click     'UPDATE TELEPHONE EXPENCES
        Try
            If Tele_Cost.TextLength > 0 Then
                If Tele_Days.TextLength > 0 Then
                    If Tele_CpD.TextLength > 0 Then
                        Total_Telephone.Text = Convert.ToDecimal(Tele_Cost.Text) * Convert.ToInt32(Tele_CpD.Text) * Convert.ToInt32(Tele_Days.Text)
                    End If
                End If
            End If
        Catch
            MessageBox.Show("Incorrect Input")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'INSERT DATA INTO PROJECT COST BREAKDOWN
        QuoteGenerator4.Proj_CostBreakDown.Rows.Add("Travel Expences", "", Total_Travel.Text)
        QuoteGenerator4.Proj_CostBreakDown.Rows.Add("Meal Expences", "", Total_Meals.Text)
        QuoteGenerator4.Proj_CostBreakDown.Rows.Add("Accomodation Expences", "", Total_Accomodation.Text)
        QuoteGenerator4.Proj_CostBreakDown.Rows.Add("Specialist Equipment (Purchase/Rental)", "", Total_SpecialistEquip.Text)
        QuoteGenerator4.Proj_CostBreakDown.Rows.Add("PPE Expences", "", Total_PPE.Text)
        QuoteGenerator4.Proj_CostBreakDown.Rows.Add("Training Expences", "", Total_Training.Text)
        QuoteGenerator4.Proj_CostBreakDown.Rows.Add("Wear & Tear on Equipment/Consumables", "", Total_WearTear.Text)
        QuoteGenerator4.Proj_CostBreakDown.Rows.Add("Telephone Expences", "", Total_Telephone.Text)
        QuoteGenerator4.Proj_CostBreakDown.Rows.Add("Site Allowance", "", Total_SiteAllowance.Text)
    End Sub
End Class