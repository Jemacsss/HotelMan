Public Class HKInventoryOverview
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim hksupervisorform As New HKsupervisor
        hksupervisorform.Show()
        Me.Hide()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim hkinv As New HKinventory
        hkinv.Show()
        Me.Hide()
    End Sub

End Class