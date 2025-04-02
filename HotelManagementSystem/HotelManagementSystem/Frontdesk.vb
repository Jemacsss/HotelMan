Public Class Frontdesk
    Private Sub btnbooking_Click(sender As Object, e As EventArgs) Handles btnbooking.Click
        BookingFrm.Show()
        Me.Hide()
    End Sub

    Private Sub btnhksched_Click(sender As Object, e As EventArgs) Handles btnhksched.Click
        HKscheduleFrm.Show()
        Me.Hide()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim loginfrm As New Login
        loginfrm.Show()
        Me.Hide()
    End Sub
End Class