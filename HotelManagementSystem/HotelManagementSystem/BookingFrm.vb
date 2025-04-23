Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class BookingFrm
    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        If Not OpenConnection() Then Exit Sub

        Dim amenities As String = ""
        Dim accessibility As String = ""

        ' Collect Amenities
        For Each ctrl As Control In grpamenities.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = CType(ctrl, CheckBox)
                If cb.Checked Then
                    amenities &= cb.Text & ", "
                End If
            End If
        Next

        ' Collect Accessibility Features
        For Each ctrl As Control In grpaccesibility.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = CType(ctrl, CheckBox)
                If cb.Checked Then
                    accessibility &= cb.Text & ", "
                End If
            End If
        Next

        ' Determine if input is an email or phone number
        Dim contactInput As String = txtContactInfo.Text
        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Dim phonePattern As String = "^\d{10,15}$"
        Dim email As String = ""
        Dim phoneNumber As String = ""

        If Regex.IsMatch(contactInput, emailPattern) Then
            email = contactInput
        ElseIf Regex.IsMatch(contactInput, phonePattern) Then
            phoneNumber = contactInput
        Else
            MessageBox.Show("Invalid contact information. Please enter a valid email or phone number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Insert into guestTbl
        Dim guestQuery As String = "INSERT INTO guestTbl (gname, [contact-email], [contact-number], [special-request]) VALUES (@gname, @email, @contact, @special)"
        Dim cmdGuest As New OleDbCommand(guestQuery, oledbCnn1)
        cmdGuest.Parameters.AddWithValue("@gname", txtGuestName.Text)
        cmdGuest.Parameters.AddWithValue("@email", email)
        cmdGuest.Parameters.AddWithValue("@contact", phoneNumber)
        cmdGuest.Parameters.AddWithValue("@special", txtSpecialRequest.Text)

        ' Insert into bookedRoomTbl
        Dim roomQuery As String = "INSERT INTO bookedRoomTbl (roomNum, roomFloor, roomCap, pricePerNight, bedType, Amenities, [Accesibility Feature]) VALUES (@roomNum, @roomFloor, @roomCap, @pricePerNight, @bedType, @Amenities, @AccesibilityFeature)"
        Dim cmdRoom As New OleDbCommand(roomQuery, oledbCnn1)
        cmdRoom.Parameters.AddWithValue("@roomNum", txtRoomNumber.Text)
        cmdRoom.Parameters.AddWithValue("@roomFloor", txtRoomFloor.Text)
        cmdRoom.Parameters.AddWithValue("@roomCap", txtRoomCapacity.Text)
        cmdRoom.Parameters.AddWithValue("@pricePerNight", txtPricePerNight.Text)
        cmdRoom.Parameters.AddWithValue("@bedType", txtBedType.SelectedItem.ToString())
        cmdRoom.Parameters.AddWithValue("@Amenities", amenities.TrimEnd(", ".ToCharArray()))
        cmdRoom.Parameters.AddWithValue("@AccesibilityFeature", accessibility.TrimEnd(", ".ToCharArray()))

        Try
            cmdGuest.ExecuteNonQuery()
            cmdRoom.ExecuteNonQuery()
            MessageBox.Show("Booking Successful! Proceeding to Payment Details.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Open Payment Details Form
            Dim paymentForm As New PaymentdetailsFrm()
            paymentForm.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection1()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Manager.Show()
        Me.Hide()
    End Sub

    Private Sub grpaccesibility_Enter(sender As Object, e As EventArgs) Handles grpaccesibility.Enter

    End Sub

    Private Sub BookingFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate Bed Type ComboBox
        txtBedType.Items.Clear()
        txtBedType.Items.Add("Single Bed")
        txtBedType.Items.Add("Double Bed")
        txtBedType.Items.Add("Queen Size")
        txtBedType.Items.Add("King Size")
        txtBedType.Items.Add("Twin Rooms")
        txtBedType.Items.Add("Bunk Bed")
        txtBedType.Items.Add("Presidential")
        txtBedType.SelectedIndex = 0
    End Sub
End Class