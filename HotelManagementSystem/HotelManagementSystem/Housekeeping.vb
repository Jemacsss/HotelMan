Public Class Housekeeping
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim loginfrm As New Login
        loginfrm.Show()
        Me.Hide()
    End Sub
End Class