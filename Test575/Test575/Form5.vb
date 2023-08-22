Public Class QuoteGen5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click 'Back to Main Menu
        Dim frm = New MainMenu
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'Previous Page
        QuoteGenerator4.Show()
        Me.Hide()
    End Sub
End Class