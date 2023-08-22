Public Class QuoteGenerator4
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click 'Back to MainMenu
        Dim frm = New MainMenu
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'Back Button (Top)
        QuoteGenerator3.Show()
        Me.Hide()
    End Sub

    Private Sub QuoteGenerator4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm = New MainMenu
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click 'Next Page (Top)
        QuoteGen5.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'Next Page (Bottom)
        QuoteGen5.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Back Button (Button)
        QuoteGenerator3.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class