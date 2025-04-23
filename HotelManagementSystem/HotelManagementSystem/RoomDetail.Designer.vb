<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomDetail
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
        txtRoomType = New TextBox()
        Label9 = New Label()
        txtPrice = New TextBox()
        Label8 = New Label()
        txtRoomCap = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        cbReserveStatus = New ComboBox()
        txtRoomFlr = New TextBox()
        Label4 = New Label()
        txtRoomNum = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnBack = New Button()
        Label10 = New Label()
        gbRoomDet = New GroupBox()
        chkPetFriendly = New CheckBox()
        chkWiFi = New CheckBox()
        chkCoffeeMaker = New CheckBox()
        chkShower = New CheckBox()
        chkRef = New CheckBox()
        chkTVCable = New CheckBox()
        chkSmoking = New CheckBox()
        chkMiniBar = New CheckBox()
        chkCityView = New CheckBox()
        chkSofaBox = New CheckBox()
        chkAC = New CheckBox()
        chkSeaview = New CheckBox()
        gbAmenities = New GroupBox()
        Label11 = New Label()
        gbAccessibilty = New GroupBox()
        chkNone = New CheckBox()
        chkWheelchair = New CheckBox()
        chkHearinAid = New CheckBox()
        chkShowergrab = New CheckBox()
        btnSave = New Button()
        btnCancel = New Button()
        Label12 = New Label()
        picRoomImage = New PictureBox()
        btnBrowse = New Button()
        txtImagePath = New TextBox()
        cbBedType = New ComboBox()
        gbRoomDet.SuspendLayout()
        gbAmenities.SuspendLayout()
        gbAccessibilty.SuspendLayout()
        CType(picRoomImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtRoomType
        ' 
        txtRoomType.Location = New Point(582, 93)
        txtRoomType.Margin = New Padding(3, 4, 3, 4)
        txtRoomType.Multiline = True
        txtRoomType.Name = "txtRoomType"
        txtRoomType.Size = New Size(114, 29)
        txtRoomType.TabIndex = 35
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(377, 199)
        Label9.Name = "Label9"
        Label9.Size = New Size(70, 20)
        Label9.TabIndex = 33
        Label9.Text = "Bed Type"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(189, 243)
        txtPrice.Margin = New Padding(3, 4, 3, 4)
        txtPrice.Multiline = True
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(114, 29)
        txtPrice.TabIndex = 32
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(189, 197)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 20)
        Label8.TabIndex = 31
        Label8.Text = "Price"
        ' 
        ' txtRoomCap
        ' 
        txtRoomCap.Location = New Point(15, 243)
        txtRoomCap.Margin = New Padding(3, 4, 3, 4)
        txtRoomCap.Multiline = True
        txtRoomCap.Name = "txtRoomCap"
        txtRoomCap.Size = New Size(114, 29)
        txtRoomCap.TabIndex = 30
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(18, 199)
        Label7.Name = "Label7"
        Label7.Size = New Size(110, 20)
        Label7.TabIndex = 29
        Label7.Text = "Room Capacity"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(582, 49)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 20)
        Label6.TabIndex = 28
        Label6.Text = "Room Type"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(377, 49)
        Label5.Name = "Label5"
        Label5.Size = New Size(130, 20)
        Label5.TabIndex = 27
        Label5.Text = "Reservation Status"
        ' 
        ' cbReserveStatus
        ' 
        cbReserveStatus.FormattingEnabled = True
        cbReserveStatus.Items.AddRange(New Object() {"Vacant", "Reserved", "Occupied"})
        cbReserveStatus.Location = New Point(377, 93)
        cbReserveStatus.Margin = New Padding(3, 4, 3, 4)
        cbReserveStatus.Name = "cbReserveStatus"
        cbReserveStatus.Size = New Size(138, 28)
        cbReserveStatus.TabIndex = 26
        ' 
        ' txtRoomFlr
        ' 
        txtRoomFlr.Location = New Point(186, 93)
        txtRoomFlr.Margin = New Padding(3, 4, 3, 4)
        txtRoomFlr.Multiline = True
        txtRoomFlr.Name = "txtRoomFlr"
        txtRoomFlr.Size = New Size(114, 29)
        txtRoomFlr.TabIndex = 25
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(186, 48)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 20)
        Label4.TabIndex = 24
        Label4.Text = "Room Floor"
        ' 
        ' txtRoomNum
        ' 
        txtRoomNum.Location = New Point(15, 93)
        txtRoomNum.Margin = New Padding(3, 4, 3, 4)
        txtRoomNum.Multiline = True
        txtRoomNum.Name = "txtRoomNum"
        txtRoomNum.Size = New Size(114, 29)
        txtRoomNum.TabIndex = 23
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 48)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 20)
        Label3.TabIndex = 22
        Label3.Text = "Room number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(165, 507)
        Label2.Name = "Label2"
        Label2.Size = New Size(194, 41)
        Label2.TabIndex = 21
        Label2.Text = "Room Details"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(97, 145)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 41)
        Label1.TabIndex = 20
        Label1.Text = "Room Picture"
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(608, 928)
        btnBack.Margin = New Padding(3, 4, 3, 4)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(125, 84)
        btnBack.TabIndex = 19
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(993, 120)
        Label10.Name = "Label10"
        Label10.Size = New Size(149, 41)
        Label10.TabIndex = 36
        Label10.Text = "Amenities"
        ' 
        ' gbRoomDet
        ' 
        gbRoomDet.Controls.Add(cbBedType)
        gbRoomDet.Controls.Add(cbReserveStatus)
        gbRoomDet.Controls.Add(Label3)
        gbRoomDet.Controls.Add(txtRoomType)
        gbRoomDet.Controls.Add(Label4)
        gbRoomDet.Controls.Add(txtRoomNum)
        gbRoomDet.Controls.Add(Label9)
        gbRoomDet.Controls.Add(txtRoomFlr)
        gbRoomDet.Controls.Add(txtPrice)
        gbRoomDet.Controls.Add(Label5)
        gbRoomDet.Controls.Add(Label8)
        gbRoomDet.Controls.Add(Label6)
        gbRoomDet.Controls.Add(txtRoomCap)
        gbRoomDet.Controls.Add(Label7)
        gbRoomDet.Location = New Point(165, 553)
        gbRoomDet.Margin = New Padding(3, 4, 3, 4)
        gbRoomDet.Name = "gbRoomDet"
        gbRoomDet.Padding = New Padding(3, 4, 3, 4)
        gbRoomDet.Size = New Size(713, 296)
        gbRoomDet.TabIndex = 37
        gbRoomDet.TabStop = False
        ' 
        ' chkPetFriendly
        ' 
        chkPetFriendly.AutoSize = True
        chkPetFriendly.Location = New Point(17, 43)
        chkPetFriendly.Margin = New Padding(3, 4, 3, 4)
        chkPetFriendly.Name = "chkPetFriendly"
        chkPetFriendly.Size = New Size(109, 24)
        chkPetFriendly.TabIndex = 38
        chkPetFriendly.Text = "Pet-Friendly"
        chkPetFriendly.UseVisualStyleBackColor = True
        ' 
        ' chkWiFi
        ' 
        chkWiFi.AutoSize = True
        chkWiFi.Location = New Point(17, 89)
        chkWiFi.Margin = New Padding(3, 4, 3, 4)
        chkWiFi.Name = "chkWiFi"
        chkWiFi.Size = New Size(66, 24)
        chkWiFi.TabIndex = 39
        chkWiFi.Text = "Wi-Fi"
        chkWiFi.UseVisualStyleBackColor = True
        ' 
        ' chkCoffeeMaker
        ' 
        chkCoffeeMaker.AutoSize = True
        chkCoffeeMaker.Location = New Point(17, 135)
        chkCoffeeMaker.Margin = New Padding(3, 4, 3, 4)
        chkCoffeeMaker.Name = "chkCoffeeMaker"
        chkCoffeeMaker.Size = New Size(120, 24)
        chkCoffeeMaker.TabIndex = 40
        chkCoffeeMaker.Text = "Coffee maker"
        chkCoffeeMaker.UseVisualStyleBackColor = True
        ' 
        ' chkShower
        ' 
        chkShower.AutoSize = True
        chkShower.Location = New Point(17, 183)
        chkShower.Margin = New Padding(3, 4, 3, 4)
        chkShower.Name = "chkShower"
        chkShower.Size = New Size(80, 24)
        chkShower.TabIndex = 41
        chkShower.Text = "Shower"
        chkShower.UseVisualStyleBackColor = True
        ' 
        ' chkRef
        ' 
        chkRef.AutoSize = True
        chkRef.Location = New Point(17, 228)
        chkRef.Margin = New Padding(3, 4, 3, 4)
        chkRef.Name = "chkRef"
        chkRef.Size = New Size(111, 24)
        chkRef.TabIndex = 42
        chkRef.Text = "Refrigerator"
        chkRef.UseVisualStyleBackColor = True
        ' 
        ' chkTVCable
        ' 
        chkTVCable.AutoSize = True
        chkTVCable.Location = New Point(17, 276)
        chkTVCable.Margin = New Padding(3, 4, 3, 4)
        chkTVCable.Name = "chkTVCable"
        chkTVCable.Size = New Size(90, 24)
        chkTVCable.TabIndex = 43
        chkTVCable.Text = "TV Cable"
        chkTVCable.UseVisualStyleBackColor = True
        ' 
        ' chkSmoking
        ' 
        chkSmoking.AutoSize = True
        chkSmoking.Location = New Point(139, 43)
        chkSmoking.Margin = New Padding(3, 4, 3, 4)
        chkSmoking.Name = "chkSmoking"
        chkSmoking.Size = New Size(89, 24)
        chkSmoking.TabIndex = 44
        chkSmoking.Text = "Smoking"
        chkSmoking.UseVisualStyleBackColor = True
        ' 
        ' chkMiniBar
        ' 
        chkMiniBar.AutoSize = True
        chkMiniBar.Location = New Point(139, 89)
        chkMiniBar.Margin = New Padding(3, 4, 3, 4)
        chkMiniBar.Name = "chkMiniBar"
        chkMiniBar.Size = New Size(88, 24)
        chkMiniBar.TabIndex = 45
        chkMiniBar.Text = "Mini-bar"
        chkMiniBar.UseVisualStyleBackColor = True
        ' 
        ' chkCityView
        ' 
        chkCityView.AutoSize = True
        chkCityView.Location = New Point(139, 135)
        chkCityView.Margin = New Padding(3, 4, 3, 4)
        chkCityView.Name = "chkCityView"
        chkCityView.Size = New Size(92, 24)
        chkCityView.TabIndex = 46
        chkCityView.Text = "City View"
        chkCityView.UseVisualStyleBackColor = True
        ' 
        ' chkSofaBox
        ' 
        chkSofaBox.AutoSize = True
        chkSofaBox.Location = New Point(139, 183)
        chkSofaBox.Margin = New Padding(3, 4, 3, 4)
        chkSofaBox.Name = "chkSofaBox"
        chkSofaBox.Size = New Size(90, 24)
        chkSofaBox.TabIndex = 47
        chkSofaBox.Text = "Sofa box"
        chkSofaBox.UseVisualStyleBackColor = True
        ' 
        ' chkAC
        ' 
        chkAC.AutoSize = True
        chkAC.Location = New Point(139, 228)
        chkAC.Margin = New Padding(3, 4, 3, 4)
        chkAC.Name = "chkAC"
        chkAC.Size = New Size(130, 24)
        chkAC.TabIndex = 48
        chkAC.Text = "Air conditioner"
        chkAC.UseVisualStyleBackColor = True
        ' 
        ' chkSeaview
        ' 
        chkSeaview.AutoSize = True
        chkSeaview.Location = New Point(139, 276)
        chkSeaview.Margin = New Padding(3, 4, 3, 4)
        chkSeaview.Name = "chkSeaview"
        chkSeaview.Size = New Size(91, 24)
        chkSeaview.TabIndex = 49
        chkSeaview.Text = "Sea View"
        chkSeaview.UseVisualStyleBackColor = True
        ' 
        ' gbAmenities
        ' 
        gbAmenities.Controls.Add(chkSeaview)
        gbAmenities.Controls.Add(chkPetFriendly)
        gbAmenities.Controls.Add(chkAC)
        gbAmenities.Controls.Add(chkWiFi)
        gbAmenities.Controls.Add(chkSofaBox)
        gbAmenities.Controls.Add(chkCoffeeMaker)
        gbAmenities.Controls.Add(chkCityView)
        gbAmenities.Controls.Add(chkShower)
        gbAmenities.Controls.Add(chkMiniBar)
        gbAmenities.Controls.Add(chkRef)
        gbAmenities.Controls.Add(chkSmoking)
        gbAmenities.Controls.Add(chkTVCable)
        gbAmenities.Location = New Point(993, 181)
        gbAmenities.Margin = New Padding(3, 4, 3, 4)
        gbAmenities.Name = "gbAmenities"
        gbAmenities.Padding = New Padding(3, 4, 3, 4)
        gbAmenities.Size = New Size(283, 332)
        gbAmenities.TabIndex = 50
        gbAmenities.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(993, 601)
        Label11.Name = "Label11"
        Label11.Size = New Size(298, 41)
        Label11.TabIndex = 51
        Label11.Text = "Accessibility Features"
        ' 
        ' gbAccessibilty
        ' 
        gbAccessibilty.Controls.Add(chkNone)
        gbAccessibilty.Controls.Add(chkWheelchair)
        gbAccessibilty.Controls.Add(chkHearinAid)
        gbAccessibilty.Controls.Add(chkShowergrab)
        gbAccessibilty.Location = New Point(998, 667)
        gbAccessibilty.Margin = New Padding(3, 4, 3, 4)
        gbAccessibilty.Name = "gbAccessibilty"
        gbAccessibilty.Padding = New Padding(3, 4, 3, 4)
        gbAccessibilty.Size = New Size(269, 183)
        gbAccessibilty.TabIndex = 51
        gbAccessibilty.TabStop = False
        ' 
        ' chkNone
        ' 
        chkNone.AutoSize = True
        chkNone.Location = New Point(17, 143)
        chkNone.Margin = New Padding(3, 4, 3, 4)
        chkNone.Name = "chkNone"
        chkNone.Size = New Size(67, 24)
        chkNone.TabIndex = 45
        chkNone.Text = "None"
        chkNone.UseVisualStyleBackColor = True
        ' 
        ' chkWheelchair
        ' 
        chkWheelchair.AutoSize = True
        chkWheelchair.Location = New Point(17, 43)
        chkWheelchair.Margin = New Padding(3, 4, 3, 4)
        chkWheelchair.Name = "chkWheelchair"
        chkWheelchair.Size = New Size(176, 24)
        chkWheelchair.TabIndex = 38
        chkWheelchair.Text = "Wheelchair accessible"
        chkWheelchair.UseVisualStyleBackColor = True
        ' 
        ' chkHearinAid
        ' 
        chkHearinAid.AutoSize = True
        chkHearinAid.Location = New Point(17, 109)
        chkHearinAid.Margin = New Padding(3, 4, 3, 4)
        chkHearinAid.Name = "chkHearinAid"
        chkHearinAid.Size = New Size(189, 24)
        chkHearinAid.TabIndex = 39
        chkHearinAid.Text = "Hearing aid compatible"
        chkHearinAid.UseVisualStyleBackColor = True
        ' 
        ' chkShowergrab
        ' 
        chkShowergrab.AutoSize = True
        chkShowergrab.Location = New Point(17, 76)
        chkShowergrab.Margin = New Padding(3, 4, 3, 4)
        chkShowergrab.Name = "chkShowergrab"
        chkShowergrab.Size = New Size(147, 24)
        chkShowergrab.TabIndex = 44
        chkShowergrab.Text = "Shower grab bars"
        chkShowergrab.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(170, 928)
        btnSave.Margin = New Padding(3, 4, 3, 4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(149, 84)
        btnSave.TabIndex = 52
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(392, 928)
        btnCancel.Margin = New Padding(3, 4, 3, 4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(149, 84)
        btnCancel.TabIndex = 53
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(258, 57)
        Label12.Name = "Label12"
        Label12.Size = New Size(228, 41)
        Label12.TabIndex = 54
        Label12.Text = "Add New Room"
        ' 
        ' picRoomImage
        ' 
        picRoomImage.Location = New Point(97, 193)
        picRoomImage.Margin = New Padding(3, 4, 3, 4)
        picRoomImage.Name = "picRoomImage"
        picRoomImage.Size = New Size(480, 295)
        picRoomImage.SizeMode = PictureBoxSizeMode.StretchImage
        picRoomImage.TabIndex = 55
        picRoomImage.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(627, 285)
        btnBrowse.Margin = New Padding(3, 4, 3, 4)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(125, 84)
        btnBrowse.TabIndex = 56
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' txtImagePath
        ' 
        txtImagePath.Location = New Point(627, 409)
        txtImagePath.Margin = New Padding(3, 4, 3, 4)
        txtImagePath.Name = "txtImagePath"
        txtImagePath.Size = New Size(105, 27)
        txtImagePath.TabIndex = 57
        ' 
        ' cbBedType
        ' 
        cbBedType.FormattingEnabled = True
        cbBedType.Items.AddRange(New Object() {"King", "Queen", "Single", "Double"})
        cbBedType.Location = New Point(377, 243)
        cbBedType.Name = "cbBedType"
        cbBedType.Size = New Size(138, 28)
        cbBedType.TabIndex = 36
        ' 
        ' RoomDetail
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1367, 1055)
        Controls.Add(txtImagePath)
        Controls.Add(btnBrowse)
        Controls.Add(picRoomImage)
        Controls.Add(Label12)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(gbAccessibilty)
        Controls.Add(Label11)
        Controls.Add(gbAmenities)
        Controls.Add(gbRoomDet)
        Controls.Add(Label10)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBack)
        Margin = New Padding(3, 4, 3, 4)
        Name = "RoomDetail"
        Text = "RoomDetail"
        gbRoomDet.ResumeLayout(False)
        gbRoomDet.PerformLayout()
        gbAmenities.ResumeLayout(False)
        gbAmenities.PerformLayout()
        gbAccessibilty.ResumeLayout(False)
        gbAccessibilty.PerformLayout()
        CType(picRoomImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtRoomType As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRoomCap As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbReserveStatus As ComboBox
    Friend WithEvents txtRoomFlr As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRoomNum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents gbRoomDet As GroupBox
    Friend WithEvents chkPetFriendly As CheckBox
    Friend WithEvents chkWiFi As CheckBox
    Friend WithEvents chkCoffeeMaker As CheckBox
    Friend WithEvents chkShower As CheckBox
    Friend WithEvents chkRef As CheckBox
    Friend WithEvents chkTVCable As CheckBox
    Friend WithEvents chkSmoking As CheckBox
    Friend WithEvents chkMiniBar As CheckBox
    Friend WithEvents chkCityView As CheckBox
    Friend WithEvents chkSofaBox As CheckBox
    Friend WithEvents chkAC As CheckBox
    Friend WithEvents chkSeaview As CheckBox
    Friend WithEvents gbAmenities As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents gbAccessibilty As GroupBox
    Friend WithEvents chkWheelchair As CheckBox
    Friend WithEvents chkHearinAid As CheckBox
    Friend WithEvents chkShowergrab As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents chkNone As CheckBox
    Friend WithEvents picRoomImage As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents txtImagePath As TextBox
    Friend WithEvents cbBedType As ComboBox
End Class
