Imports System.Data.OleDb
Imports System.Runtime.ConstrainedExecution


Public Class RoomDetail

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate required fields before proceeding
        If Not ValidateFields() Then Exit Sub

        Try
            If Not DbCon.OpenConnection Then Exit Sub

            Dim query As String = "INSERT INTO RoomTbl
            (roomNum, RoomFloor, RoomCap, pricePerNight, amenities, accesibilityFeature, ReservationStatus, RoomType, BedType)
            VALUES 
            (@roomNum, @RoomFloor, @RoomCap, @pricePerNight, @amenities, @accesibilityFeature, @ReservationStatus, @RoomType, @BedType)"

            Using cmd As New OleDbCommand(query, DbCon.oledbCnn1)
                cmd.Parameters.AddWithValue("@roomNum", txtRoomNum.Text)
                cmd.Parameters.AddWithValue("@RoomFloor", txtRoomFlr.Text)
                cmd.Parameters.AddWithValue("@RoomCap", txtRoomCap.Text)
                cmd.Parameters.AddWithValue("@pricePerNight", txtPrice.Text)
                cmd.Parameters.AddWithValue("@RoomType", txtRoomType.Text)
                cmd.Parameters.AddWithValue("@BedType", txtBedType.Text)
                cmd.Parameters.AddWithValue("@reservationStatus", cbReserveStatus.Text)

                Dim amenitiesList As New List(Of String)
                If chkPetFriendly.Checked Then amenitiesList.Add("Pet-Friendly")
                If chkSmoking.Checked Then amenitiesList.Add("Smoking")
                If chkWiFi.Checked Then amenitiesList.Add("Wi-Fi")
                If chkMiniBar.Checked Then amenitiesList.Add("Mini-bar")
                If chkCoffeeMaker.Checked Then amenitiesList.Add("Coffee maker")
                If chkCityView.Checked Then amenitiesList.Add("City View")
                If chkShower.Checked Then amenitiesList.Add("Shower")
                If chkSofaBox.Checked Then amenitiesList.Add("Sofa box")
                If chkRef.Checked Then amenitiesList.Add("Refrigerator")
                If chkAC.Checked Then amenitiesList.Add("Air conditioner")
                If chkTVCable.Checked Then amenitiesList.Add("TV Cable")
                If chkSeaview.Checked Then amenitiesList.Add("Sea View")
                cmd.Parameters.AddWithValue("@amenities", String.Join(", ", amenitiesList))

                Dim accessibilityList As New List(Of String)
                If chkWheelchair.Checked Then accessibilityList.Add("Wheelchair accessible")
                If chkShowergrab.Checked Then accessibilityList.Add("Shower grab bars")
                If chkHearinAid.Checked Then accessibilityList.Add("Hearing aid compatible")
                If chkNone.Checked Then accessibilityList.Add("None")
                cmd.Parameters.AddWithValue("@accesibilityFeature", String.Join(", ", accessibilityList))

                cmd.ExecuteNonQuery()
            End Using

            DbCon.CloseConnection1()
            MessageBox.Show("Room details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DbCon.CloseConnection1()
        End Try

        clear()
        uncheck()
    End Sub

    ' Validation Function
    Private Function ValidateFields() As Boolean
        If String.IsNullOrWhiteSpace(txtRoomNum.Text) Then
            MessageBox.Show("Please enter the room number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRoomNum.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtRoomFlr.Text) Then
            MessageBox.Show("Please enter the room floor.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRoomFlr.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtRoomCap.Text) Then
            MessageBox.Show("Please enter the room capacity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRoomCap.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPrice.Text) Then
            MessageBox.Show("Please enter the price per night.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPrice.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtRoomType.Text) Then
            MessageBox.Show("Please enter the room type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtRoomType.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtBedType.Text) Then
            MessageBox.Show("Please select a bed type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBedType.Focus()
            Return False
        End If

        If cbReserveStatus.SelectedIndex = -1 Then
            MessageBox.Show("Please select the reservation status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbReserveStatus.Focus()
            Return False
        End If

        Return True ' All fields are valid
    End Function

    ' Clear Textboxes and Comboboxes
    Private Sub clear()
        txtRoomNum.Clear()
        txtRoomFlr.Clear()
        txtRoomCap.Clear()
        txtPrice.Clear()
        txtRoomType.Clear()
        txtBedType.Clear()
        cbReserveStatus.SelectedIndex = -1
    End Sub

    ' Uncheck Checkboxes
    Private Sub uncheck()
        chkPetFriendly.Checked = False
        chkSmoking.Checked = False
        chkWiFi.Checked = False
        chkMiniBar.Checked = False
        chkCoffeeMaker.Checked = False
        chkCityView.Checked = False
        chkShower.Checked = False
        chkSofaBox.Checked = False
        chkRef.Checked = False
        chkAC.Checked = False
        chkTVCable.Checked = False
        chkSeaview.Checked = False
        chkWheelchair.Checked = False
        chkShowergrab.Checked = False
        chkHearinAid.Checked = False
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Manager.Show()
        Me.Hide()
    End Sub
End Class