Public Class Manager
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim hkschedform As New HKscheduleFrm
        hkschedform.Show()
        Me.Close()

    End Sub
End Class