Public Class HKsupervisor
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim loginfrm As New Login
        loginfrm.Show
        Me.Hide()
    End Sub

    Private Sub btnhkinv_Click(sender As Object, e As EventArgs) Handles btnhkinv.Click
        Dim hkschedfrm As New HKscheduleFrm
        hkschedfrm.Show()
        Me.Hide()
    End Sub

    Private Sub btnOverview_Click(sender As Object, e As EventArgs) Handles btnOverview.Click
        Dim overviewfrm As New HKoverview
        overviewfrm.Show()
        Me.Hide()
    End Sub
End Class