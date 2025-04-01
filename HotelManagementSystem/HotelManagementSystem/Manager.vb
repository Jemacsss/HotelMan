Public Class Manager
    Private Sub Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RoomDetail.Show()
        Me.Hide()
    End Sub

    Private Sub btnAcc_Click(sender As Object, e As EventArgs) Handles btnAcc.Click
        Accounts.Show()
        Me.Hide()
    End Sub
End Class