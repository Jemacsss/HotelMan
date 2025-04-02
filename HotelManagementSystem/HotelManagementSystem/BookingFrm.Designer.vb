<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnback = New Button()
        txtRoomNumber = New TextBox()
        txtRoomFloor = New TextBox()
        txtPricePerNight = New TextBox()
        txtRoomCapacity = New TextBox()
        txtBedType = New ComboBox()
        txtGuestName = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        btnBook = New Button()
        Label13 = New Label()
        Label6 = New Label()
        txtContactInfo = New TextBox()
        txtSpecialRequest = New TextBox()
        dtpCheckIn = New DateTimePicker()
        dtpCheckOut = New DateTimePicker()
        grpamenities = New GroupBox()
        cbSeaView = New CheckBox()
        cbTvcable = New CheckBox()
        cbAirConditioner = New CheckBox()
        cbRefrigirator = New CheckBox()
        cbSofaBox = New CheckBox()
        cbShower = New CheckBox()
        cbCityView = New CheckBox()
        cbCoffeeMaker = New CheckBox()
        cbMiniBar = New CheckBox()
        cbWiFi = New CheckBox()
        cbSmoking = New CheckBox()
        cbPetFriendly = New CheckBox()
        grpaccesibility = New GroupBox()
        cb3 = New CheckBox()
        cb2 = New CheckBox()
        cb1 = New CheckBox()
        grpamenities.SuspendLayout()
        grpaccesibility.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 15)
        Label1.TabIndex = 0
        Label1.Text = "Bookings"
        ' 
        ' btnback
        ' 
        btnback.Location = New Point(311, 535)
        btnback.Name = "btnback"
        btnback.Size = New Size(137, 48)
        btnback.TabIndex = 1
        btnback.Text = "Back"
        btnback.UseVisualStyleBackColor = True
        ' 
        ' txtRoomNumber
        ' 
        txtRoomNumber.Location = New Point(52, 69)
        txtRoomNumber.Multiline = True
        txtRoomNumber.Name = "txtRoomNumber"
        txtRoomNumber.Size = New Size(221, 23)
        txtRoomNumber.TabIndex = 2
        ' 
        ' txtRoomFloor
        ' 
        txtRoomFloor.Location = New Point(311, 69)
        txtRoomFloor.Multiline = True
        txtRoomFloor.Name = "txtRoomFloor"
        txtRoomFloor.Size = New Size(221, 23)
        txtRoomFloor.TabIndex = 3
        ' 
        ' txtPricePerNight
        ' 
        txtPricePerNight.Location = New Point(217, 116)
        txtPricePerNight.Multiline = True
        txtPricePerNight.Name = "txtPricePerNight"
        txtPricePerNight.Size = New Size(141, 23)
        txtPricePerNight.TabIndex = 5
        ' 
        ' txtRoomCapacity
        ' 
        txtRoomCapacity.Location = New Point(52, 116)
        txtRoomCapacity.Multiline = True
        txtRoomCapacity.Name = "txtRoomCapacity"
        txtRoomCapacity.Size = New Size(141, 23)
        txtRoomCapacity.TabIndex = 4
        ' 
        ' txtBedType
        ' 
        txtBedType.FormattingEnabled = True
        txtBedType.Location = New Point(391, 116)
        txtBedType.Name = "txtBedType"
        txtBedType.Size = New Size(121, 23)
        txtBedType.TabIndex = 6
        ' 
        ' txtGuestName
        ' 
        txtGuestName.Location = New Point(52, 184)
        txtGuestName.Multiline = True
        txtGuestName.Name = "txtGuestName"
        txtGuestName.Size = New Size(422, 71)
        txtGuestName.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(52, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 15)
        Label2.TabIndex = 13
        Label2.Text = "Room Number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(317, 51)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 15)
        Label3.TabIndex = 14
        Label3.Text = "Room Floor"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(52, 98)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 15)
        Label4.TabIndex = 15
        Label4.Text = "Room Capacity"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(217, 98)
        Label5.Name = "Label5"
        Label5.Size = New Size(121, 15)
        Label5.TabIndex = 16
        Label5.Text = "Room Price Per Night"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(391, 98)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 15)
        Label7.TabIndex = 18
        Label7.Text = "Bed Type"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(531, 98)
        Label8.Name = "Label8"
        Label8.Size = New Size(85, 15)
        Label8.TabIndex = 19
        Label8.Text = "Check-In Date "
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(770, 98)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 15)
        Label9.TabIndex = 20
        Label9.Text = "Check-Out Date"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(52, 166)
        Label10.Name = "Label10"
        Label10.Size = New Size(107, 15)
        Label10.TabIndex = 21
        Label10.Text = "Guest's Full Names"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(52, 265)
        Label11.Name = "Label11"
        Label11.Size = New Size(115, 15)
        Label11.TabIndex = 22
        Label11.Text = "Contact Information"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(52, 372)
        Label12.Name = "Label12"
        Label12.Size = New Size(89, 15)
        Label12.TabIndex = 23
        Label12.Text = "Special Request"
        ' 
        ' btnBook
        ' 
        btnBook.Location = New Point(158, 535)
        btnBook.Name = "btnBook"
        btnBook.Size = New Size(137, 48)
        btnBook.TabIndex = 37
        btnBook.Text = "Book "
        btnBook.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(548, 184)
        Label13.Name = "Label13"
        Label13.Size = New Size(60, 15)
        Label13.TabIndex = 25
        Label13.Text = "Amenities"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(548, 399)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 15)
        Label6.TabIndex = 41
        Label6.Text = "Accessbility Features"
        ' 
        ' txtContactInfo
        ' 
        txtContactInfo.Location = New Point(52, 286)
        txtContactInfo.Multiline = True
        txtContactInfo.Name = "txtContactInfo"
        txtContactInfo.Size = New Size(422, 71)
        txtContactInfo.TabIndex = 42
        ' 
        ' txtSpecialRequest
        ' 
        txtSpecialRequest.Location = New Point(52, 390)
        txtSpecialRequest.Multiline = True
        txtSpecialRequest.Name = "txtSpecialRequest"
        txtSpecialRequest.Size = New Size(422, 71)
        txtSpecialRequest.TabIndex = 45
        ' 
        ' dtpCheckIn
        ' 
        dtpCheckIn.Location = New Point(531, 116)
        dtpCheckIn.Name = "dtpCheckIn"
        dtpCheckIn.Size = New Size(200, 23)
        dtpCheckIn.TabIndex = 46
        ' 
        ' dtpCheckOut
        ' 
        dtpCheckOut.Location = New Point(770, 116)
        dtpCheckOut.Name = "dtpCheckOut"
        dtpCheckOut.Size = New Size(200, 23)
        dtpCheckOut.TabIndex = 47
        ' 
        ' grpamenities
        ' 
        grpamenities.Controls.Add(cbSeaView)
        grpamenities.Controls.Add(cbTvcable)
        grpamenities.Controls.Add(cbAirConditioner)
        grpamenities.Controls.Add(cbRefrigirator)
        grpamenities.Controls.Add(cbSofaBox)
        grpamenities.Controls.Add(cbShower)
        grpamenities.Controls.Add(cbCityView)
        grpamenities.Controls.Add(cbCoffeeMaker)
        grpamenities.Controls.Add(cbMiniBar)
        grpamenities.Controls.Add(cbWiFi)
        grpamenities.Controls.Add(cbSmoking)
        grpamenities.Controls.Add(cbPetFriendly)
        grpamenities.Location = New Point(531, 184)
        grpamenities.Name = "grpamenities"
        grpamenities.Size = New Size(306, 203)
        grpamenities.TabIndex = 48
        grpamenities.TabStop = False
        grpamenities.Text = "GroupBox1"
        ' 
        ' cbSeaView
        ' 
        cbSeaView.AutoSize = True
        cbSeaView.Location = New Point(133, 154)
        cbSeaView.Name = "cbSeaView"
        cbSeaView.Size = New Size(72, 19)
        cbSeaView.TabIndex = 11
        cbSeaView.Text = "Sea View"
        cbSeaView.UseVisualStyleBackColor = True
        ' 
        ' cbTvcable
        ' 
        cbTvcable.AutoSize = True
        cbTvcable.Location = New Point(133, 129)
        cbTvcable.Name = "cbTvcable"
        cbTvcable.Size = New Size(73, 19)
        cbTvcable.TabIndex = 10
        cbTvcable.Text = "TV Cable"
        cbTvcable.UseVisualStyleBackColor = True
        ' 
        ' cbAirConditioner
        ' 
        cbAirConditioner.AutoSize = True
        cbAirConditioner.Location = New Point(133, 104)
        cbAirConditioner.Name = "cbAirConditioner"
        cbAirConditioner.Size = New Size(107, 19)
        cbAirConditioner.TabIndex = 9
        cbAirConditioner.Text = "Air Conditioner"
        cbAirConditioner.UseVisualStyleBackColor = True
        ' 
        ' cbRefrigirator
        ' 
        cbRefrigirator.AutoSize = True
        cbRefrigirator.Location = New Point(133, 77)
        cbRefrigirator.Name = "cbRefrigirator"
        cbRefrigirator.Size = New Size(85, 19)
        cbRefrigirator.TabIndex = 8
        cbRefrigirator.Text = "Refrigirator"
        cbRefrigirator.UseVisualStyleBackColor = True
        ' 
        ' cbSofaBox
        ' 
        cbSofaBox.AutoSize = True
        cbSofaBox.Location = New Point(133, 52)
        cbSofaBox.Name = "cbSofaBox"
        cbSofaBox.Size = New Size(71, 19)
        cbSofaBox.TabIndex = 7
        cbSofaBox.Text = "Sofa Box"
        cbSofaBox.UseVisualStyleBackColor = True
        ' 
        ' cbShower
        ' 
        cbShower.AutoSize = True
        cbShower.Location = New Point(133, 27)
        cbShower.Name = "cbShower"
        cbShower.Size = New Size(65, 19)
        cbShower.TabIndex = 6
        cbShower.Text = "Shower"
        cbShower.UseVisualStyleBackColor = True
        ' 
        ' cbCityView
        ' 
        cbCityView.AutoSize = True
        cbCityView.Location = New Point(30, 154)
        cbCityView.Name = "cbCityView"
        cbCityView.Size = New Size(75, 19)
        cbCityView.TabIndex = 5
        cbCityView.Text = "City View"
        cbCityView.UseVisualStyleBackColor = True
        ' 
        ' cbCoffeeMaker
        ' 
        cbCoffeeMaker.AutoSize = True
        cbCoffeeMaker.Location = New Point(30, 129)
        cbCoffeeMaker.Name = "cbCoffeeMaker"
        cbCoffeeMaker.Size = New Size(97, 19)
        cbCoffeeMaker.TabIndex = 4
        cbCoffeeMaker.Text = "Coffee Maker"
        cbCoffeeMaker.UseVisualStyleBackColor = True
        ' 
        ' cbMiniBar
        ' 
        cbMiniBar.AutoSize = True
        cbMiniBar.Location = New Point(30, 104)
        cbMiniBar.Name = "cbMiniBar"
        cbMiniBar.Size = New Size(72, 19)
        cbMiniBar.TabIndex = 3
        cbMiniBar.Text = "Mini-Bar"
        cbMiniBar.UseVisualStyleBackColor = True
        ' 
        ' cbWiFi
        ' 
        cbWiFi.AutoSize = True
        cbWiFi.Location = New Point(30, 77)
        cbWiFi.Name = "cbWiFi"
        cbWiFi.Size = New Size(54, 19)
        cbWiFi.TabIndex = 2
        cbWiFi.Text = "Wi-Fi"
        cbWiFi.UseVisualStyleBackColor = True
        ' 
        ' cbSmoking
        ' 
        cbSmoking.AutoSize = True
        cbSmoking.Location = New Point(30, 52)
        cbSmoking.Name = "cbSmoking"
        cbSmoking.Size = New Size(73, 19)
        cbSmoking.TabIndex = 1
        cbSmoking.Text = "Smoking"
        cbSmoking.UseVisualStyleBackColor = True
        ' 
        ' cbPetFriendly
        ' 
        cbPetFriendly.AutoSize = True
        cbPetFriendly.Location = New Point(30, 27)
        cbPetFriendly.Name = "cbPetFriendly"
        cbPetFriendly.Size = New Size(90, 19)
        cbPetFriendly.TabIndex = 0
        cbPetFriendly.Text = "Pet-Friendly"
        cbPetFriendly.UseVisualStyleBackColor = True
        ' 
        ' grpaccesibility
        ' 
        grpaccesibility.Controls.Add(cb3)
        grpaccesibility.Controls.Add(cb2)
        grpaccesibility.Controls.Add(cb1)
        grpaccesibility.Location = New Point(531, 431)
        grpaccesibility.Name = "grpaccesibility"
        grpaccesibility.Size = New Size(200, 101)
        grpaccesibility.TabIndex = 49
        grpaccesibility.TabStop = False
        grpaccesibility.Text = "GroupBox2"
        ' 
        ' cb3
        ' 
        cb3.AutoSize = True
        cb3.Location = New Point(26, 72)
        cb3.Name = "cb3"
        cb3.Size = New Size(154, 19)
        cb3.TabIndex = 52
        cb3.Text = "Hearing Aid Compatible"
        cb3.UseVisualStyleBackColor = True
        ' 
        ' cb2
        ' 
        cb2.AutoSize = True
        cb2.Location = New Point(26, 47)
        cb2.Name = "cb2"
        cb2.Size = New Size(118, 19)
        cb2.TabIndex = 51
        cb2.Text = "Shower Grab Bars"
        cb2.UseVisualStyleBackColor = True
        ' 
        ' cb1
        ' 
        cb1.AutoSize = True
        cb1.Location = New Point(26, 22)
        cb1.Name = "cb1"
        cb1.Size = New Size(153, 19)
        cb1.TabIndex = 50
        cb1.Text = "WheelChair - Accessible"
        cb1.UseVisualStyleBackColor = True
        ' 
        ' BookingFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1008, 595)
        Controls.Add(grpaccesibility)
        Controls.Add(grpamenities)
        Controls.Add(dtpCheckOut)
        Controls.Add(dtpCheckIn)
        Controls.Add(txtSpecialRequest)
        Controls.Add(txtContactInfo)
        Controls.Add(Label6)
        Controls.Add(btnBook)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtGuestName)
        Controls.Add(txtBedType)
        Controls.Add(txtPricePerNight)
        Controls.Add(txtRoomCapacity)
        Controls.Add(txtRoomFloor)
        Controls.Add(txtRoomNumber)
        Controls.Add(btnback)
        Controls.Add(Label1)
        Name = "BookingFrm"
        Text = " "
        grpamenities.ResumeLayout(False)
        grpamenities.PerformLayout()
        grpaccesibility.ResumeLayout(False)
        grpaccesibility.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnback As Button
    Friend WithEvents txtRoomNumber As TextBox
    Friend WithEvents txtRoomFloor As TextBox
    Friend WithEvents txtPricePerNight As TextBox
    Friend WithEvents txtRoomCapacity As TextBox
    Friend WithEvents txtBedType As ComboBox
    Friend WithEvents txtGuestName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnBook As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtContactInfo As TextBox
    Friend WithEvents txtSpecialRequest As TextBox
    Friend WithEvents dtpCheckIn As DateTimePicker
    Friend WithEvents dtpCheckOut As DateTimePicker
    Friend WithEvents grpamenities As GroupBox
    Friend WithEvents grpaccesibility As GroupBox
    Friend WithEvents cbSmoking As CheckBox
    Friend WithEvents cbPetFriendly As CheckBox
    Friend WithEvents cbSeaView As CheckBox
    Friend WithEvents cbTvcable As CheckBox
    Friend WithEvents cbAirConditioner As CheckBox
    Friend WithEvents cbRefrigirator As CheckBox
    Friend WithEvents cbSofaBox As CheckBox
    Friend WithEvents cbShower As CheckBox
    Friend WithEvents cbCityView As CheckBox
    Friend WithEvents cbCoffeeMaker As CheckBox
    Friend WithEvents cbMiniBar As CheckBox
    Friend WithEvents cbWiFi As CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb1 As CheckBox
End Class
