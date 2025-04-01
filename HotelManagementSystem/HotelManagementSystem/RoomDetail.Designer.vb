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
        txtBedType = New TextBox()
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
        gbRoomDet.SuspendLayout()
        gbAmenities.SuspendLayout()
        gbAccessibilty.SuspendLayout()
        CType(picRoomImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtRoomType
        ' 
        txtRoomType.Location = New Point(509, 70)
        txtRoomType.Multiline = True
        txtRoomType.Name = "txtRoomType"
        txtRoomType.Size = New Size(100, 23)
        txtRoomType.TabIndex = 35
        ' 
        ' txtBedType
        ' 
        txtBedType.Location = New Point(330, 182)
        txtBedType.Multiline = True
        txtBedType.Name = "txtBedType"
        txtBedType.Size = New Size(100, 23)
        txtBedType.TabIndex = 34
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(330, 149)
        Label9.Name = "Label9"
        Label9.Size = New Size(55, 15)
        Label9.TabIndex = 33
        Label9.Text = "Bed Type"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(165, 182)
        txtPrice.Multiline = True
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(100, 23)
        txtPrice.TabIndex = 32
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(165, 148)
        Label8.Name = "Label8"
        Label8.Size = New Size(33, 15)
        Label8.TabIndex = 31
        Label8.Text = "Price"
        ' 
        ' txtRoomCap
        ' 
        txtRoomCap.Location = New Point(13, 182)
        txtRoomCap.Multiline = True
        txtRoomCap.Name = "txtRoomCap"
        txtRoomCap.Size = New Size(100, 23)
        txtRoomCap.TabIndex = 30
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(16, 149)
        Label7.Name = "Label7"
        Label7.Size = New Size(88, 15)
        Label7.TabIndex = 29
        Label7.Text = "Room Capacity"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(509, 37)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 15)
        Label6.TabIndex = 28
        Label6.Text = "Room Type"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(330, 37)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 15)
        Label5.TabIndex = 27
        Label5.Text = "Reservation Status"
        ' 
        ' cbReserveStatus
        ' 
        cbReserveStatus.FormattingEnabled = True
        cbReserveStatus.Items.AddRange(New Object() {"Vacant", "Reserved", "Occupied"})
        cbReserveStatus.Location = New Point(330, 70)
        cbReserveStatus.Name = "cbReserveStatus"
        cbReserveStatus.Size = New Size(121, 23)
        cbReserveStatus.TabIndex = 26
        ' 
        ' txtRoomFlr
        ' 
        txtRoomFlr.Location = New Point(163, 70)
        txtRoomFlr.Multiline = True
        txtRoomFlr.Name = "txtRoomFlr"
        txtRoomFlr.Size = New Size(100, 23)
        txtRoomFlr.TabIndex = 25
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(163, 36)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 15)
        Label4.TabIndex = 24
        Label4.Text = "Room Floor"
        ' 
        ' txtRoomNum
        ' 
        txtRoomNum.Location = New Point(13, 70)
        txtRoomNum.Multiline = True
        txtRoomNum.Name = "txtRoomNum"
        txtRoomNum.Size = New Size(100, 23)
        txtRoomNum.TabIndex = 23
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 22
        Label3.Text = "Room number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(144, 369)
        Label2.Name = "Label2"
        Label2.Size = New Size(155, 32)
        Label2.TabIndex = 21
        Label2.Text = "Room Details"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(85, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 32)
        Label1.TabIndex = 20
        Label1.Text = "Room Picture"
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(532, 696)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(109, 63)
        btnBack.TabIndex = 19
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(869, 90)
        Label10.Name = "Label10"
        Label10.Size = New Size(120, 32)
        Label10.TabIndex = 36
        Label10.Text = "Amenities"
        ' 
        ' gbRoomDet
        ' 
        gbRoomDet.Controls.Add(cbReserveStatus)
        gbRoomDet.Controls.Add(Label3)
        gbRoomDet.Controls.Add(txtRoomType)
        gbRoomDet.Controls.Add(txtBedType)
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
        gbRoomDet.Location = New Point(144, 415)
        gbRoomDet.Name = "gbRoomDet"
        gbRoomDet.Size = New Size(624, 222)
        gbRoomDet.TabIndex = 37
        gbRoomDet.TabStop = False
        ' 
        ' chkPetFriendly
        ' 
        chkPetFriendly.AutoSize = True
        chkPetFriendly.Location = New Point(15, 32)
        chkPetFriendly.Name = "chkPetFriendly"
        chkPetFriendly.Size = New Size(90, 19)
        chkPetFriendly.TabIndex = 38
        chkPetFriendly.Text = "Pet-Friendly"
        chkPetFriendly.UseVisualStyleBackColor = True
        ' 
        ' chkWiFi
        ' 
        chkWiFi.AutoSize = True
        chkWiFi.Location = New Point(15, 67)
        chkWiFi.Name = "chkWiFi"
        chkWiFi.Size = New Size(54, 19)
        chkWiFi.TabIndex = 39
        chkWiFi.Text = "Wi-Fi"
        chkWiFi.UseVisualStyleBackColor = True
        ' 
        ' chkCoffeeMaker
        ' 
        chkCoffeeMaker.AutoSize = True
        chkCoffeeMaker.Location = New Point(15, 101)
        chkCoffeeMaker.Name = "chkCoffeeMaker"
        chkCoffeeMaker.Size = New Size(97, 19)
        chkCoffeeMaker.TabIndex = 40
        chkCoffeeMaker.Text = "Coffee maker"
        chkCoffeeMaker.UseVisualStyleBackColor = True
        ' 
        ' chkShower
        ' 
        chkShower.AutoSize = True
        chkShower.Location = New Point(15, 137)
        chkShower.Name = "chkShower"
        chkShower.Size = New Size(65, 19)
        chkShower.TabIndex = 41
        chkShower.Text = "Shower"
        chkShower.UseVisualStyleBackColor = True
        ' 
        ' chkRef
        ' 
        chkRef.AutoSize = True
        chkRef.Location = New Point(15, 171)
        chkRef.Name = "chkRef"
        chkRef.Size = New Size(88, 19)
        chkRef.TabIndex = 42
        chkRef.Text = "Refrigerator"
        chkRef.UseVisualStyleBackColor = True
        ' 
        ' chkTVCable
        ' 
        chkTVCable.AutoSize = True
        chkTVCable.Location = New Point(15, 207)
        chkTVCable.Name = "chkTVCable"
        chkTVCable.Size = New Size(73, 19)
        chkTVCable.TabIndex = 43
        chkTVCable.Text = "TV Cable"
        chkTVCable.UseVisualStyleBackColor = True
        ' 
        ' chkSmoking
        ' 
        chkSmoking.AutoSize = True
        chkSmoking.Location = New Point(122, 32)
        chkSmoking.Name = "chkSmoking"
        chkSmoking.Size = New Size(73, 19)
        chkSmoking.TabIndex = 44
        chkSmoking.Text = "Smoking"
        chkSmoking.UseVisualStyleBackColor = True
        ' 
        ' chkMiniBar
        ' 
        chkMiniBar.AutoSize = True
        chkMiniBar.Location = New Point(122, 67)
        chkMiniBar.Name = "chkMiniBar"
        chkMiniBar.Size = New Size(72, 19)
        chkMiniBar.TabIndex = 45
        chkMiniBar.Text = "Mini-bar"
        chkMiniBar.UseVisualStyleBackColor = True
        ' 
        ' chkCityView
        ' 
        chkCityView.AutoSize = True
        chkCityView.Location = New Point(122, 101)
        chkCityView.Name = "chkCityView"
        chkCityView.Size = New Size(75, 19)
        chkCityView.TabIndex = 46
        chkCityView.Text = "City View"
        chkCityView.UseVisualStyleBackColor = True
        ' 
        ' chkSofaBox
        ' 
        chkSofaBox.AutoSize = True
        chkSofaBox.Location = New Point(122, 137)
        chkSofaBox.Name = "chkSofaBox"
        chkSofaBox.Size = New Size(71, 19)
        chkSofaBox.TabIndex = 47
        chkSofaBox.Text = "Sofa box"
        chkSofaBox.UseVisualStyleBackColor = True
        ' 
        ' chkAC
        ' 
        chkAC.AutoSize = True
        chkAC.Location = New Point(122, 171)
        chkAC.Name = "chkAC"
        chkAC.Size = New Size(105, 19)
        chkAC.TabIndex = 48
        chkAC.Text = "Air conditioner"
        chkAC.UseVisualStyleBackColor = True
        ' 
        ' chkSeaview
        ' 
        chkSeaview.AutoSize = True
        chkSeaview.Location = New Point(122, 207)
        chkSeaview.Name = "chkSeaview"
        chkSeaview.Size = New Size(72, 19)
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
        gbAmenities.Location = New Point(869, 136)
        gbAmenities.Name = "gbAmenities"
        gbAmenities.Size = New Size(248, 249)
        gbAmenities.TabIndex = 50
        gbAmenities.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(869, 451)
        Label11.Name = "Label11"
        Label11.Size = New Size(239, 32)
        Label11.TabIndex = 51
        Label11.Text = "Accessibility Features"
        ' 
        ' gbAccessibilty
        ' 
        gbAccessibilty.Controls.Add(chkNone)
        gbAccessibilty.Controls.Add(chkWheelchair)
        gbAccessibilty.Controls.Add(chkHearinAid)
        gbAccessibilty.Controls.Add(chkShowergrab)
        gbAccessibilty.Location = New Point(869, 500)
        gbAccessibilty.Name = "gbAccessibilty"
        gbAccessibilty.Size = New Size(193, 137)
        gbAccessibilty.TabIndex = 51
        gbAccessibilty.TabStop = False
        ' 
        ' chkNone
        ' 
        chkNone.AutoSize = True
        chkNone.Location = New Point(15, 107)
        chkNone.Name = "chkNone"
        chkNone.Size = New Size(55, 19)
        chkNone.TabIndex = 45
        chkNone.Text = "None"
        chkNone.UseVisualStyleBackColor = True
        ' 
        ' chkWheelchair
        ' 
        chkWheelchair.AutoSize = True
        chkWheelchair.Location = New Point(15, 32)
        chkWheelchair.Name = "chkWheelchair"
        chkWheelchair.Size = New Size(141, 19)
        chkWheelchair.TabIndex = 38
        chkWheelchair.Text = "Wheelchair accessible"
        chkWheelchair.UseVisualStyleBackColor = True
        ' 
        ' chkHearinAid
        ' 
        chkHearinAid.AutoSize = True
        chkHearinAid.Location = New Point(15, 82)
        chkHearinAid.Name = "chkHearinAid"
        chkHearinAid.Size = New Size(150, 19)
        chkHearinAid.TabIndex = 39
        chkHearinAid.Text = "Hearing aid compatible"
        chkHearinAid.UseVisualStyleBackColor = True
        ' 
        ' chkShowergrab
        ' 
        chkShowergrab.AutoSize = True
        chkShowergrab.Location = New Point(15, 57)
        chkShowergrab.Name = "chkShowergrab"
        chkShowergrab.Size = New Size(117, 19)
        chkShowergrab.TabIndex = 44
        chkShowergrab.Text = "Shower grab bars"
        chkShowergrab.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(149, 696)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(130, 63)
        btnSave.TabIndex = 52
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(343, 696)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(130, 63)
        btnCancel.TabIndex = 53
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(226, 43)
        Label12.Name = "Label12"
        Label12.Size = New Size(181, 32)
        Label12.TabIndex = 54
        Label12.Text = "Add New Room"
        ' 
        ' picRoomImage
        ' 
        picRoomImage.Location = New Point(95, 145)
        picRoomImage.Name = "picRoomImage"
        picRoomImage.Size = New Size(420, 221)
        picRoomImage.SizeMode = PictureBoxSizeMode.StretchImage
        picRoomImage.TabIndex = 55
        picRoomImage.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(549, 214)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(109, 63)
        btnBrowse.TabIndex = 56
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' txtImagePath
        ' 
        txtImagePath.Location = New Point(549, 307)
        txtImagePath.Name = "txtImagePath"
        txtImagePath.Size = New Size(92, 23)
        txtImagePath.TabIndex = 57
        ' 
        ' RoomDetail
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1196, 862)
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
    Friend WithEvents txtBedType As TextBox
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
End Class
