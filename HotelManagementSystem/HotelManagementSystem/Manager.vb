﻿Public Class Manager
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim hkschedform As New HKscheduleFrm
        hkschedform.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim loginfrm As New Login
        loginfrm.Show()
        Me.Close()
    End Sub

    Private Sub btnAcc_Click(sender As Object, e As EventArgs) Handles btnAcc.Click
        Dim accfrm As New Accounts
        accfrm.Show()
        Me.Close()
    End Sub

    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        Dim roomcheckfrm As New Roomcheck
        roomcheckfrm.Show()
        'Dim roomfrm As New RoomDetail
        'roomfrm.Show()
        Me.Close()
    End Sub

    Private Sub btnreserve_Click(sender As Object, e As EventArgs) Handles btnreserve.Click
        Dim reservationfrm As New BookingFrm
        reservationfrm.Show()
        Me.Close()
    End Sub
End Class