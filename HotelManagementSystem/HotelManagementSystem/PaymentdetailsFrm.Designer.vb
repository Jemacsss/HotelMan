<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentdetailsFrm
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
        txtGuestID = New TextBox()
        txtRoomNo = New TextBox()
        txtGuestName = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnBook = New Button()
        btnBack = New Button()
        cmbPaymentMethod = New ComboBox()
        dtpPaymentDate = New DateTimePicker()
        Label5 = New Label()
        Label6 = New Label()
        cmbStatus = New ComboBox()
        Payment = New Label()
        txtAmountPaid = New TextBox()
        SuspendLayout()
        ' 
        ' txtGuestID
        ' 
        txtGuestID.Location = New Point(97, 28)
        txtGuestID.Multiline = True
        txtGuestID.Name = "txtGuestID"
        txtGuestID.Size = New Size(123, 39)
        txtGuestID.TabIndex = 0
        ' 
        ' txtRoomNo
        ' 
        txtRoomNo.Location = New Point(97, 82)
        txtRoomNo.Multiline = True
        txtRoomNo.Name = "txtRoomNo"
        txtRoomNo.Size = New Size(123, 39)
        txtRoomNo.TabIndex = 1
        ' 
        ' txtGuestName
        ' 
        txtGuestName.Location = New Point(97, 152)
        txtGuestName.Multiline = True
        txtGuestName.Name = "txtGuestName"
        txtGuestName.Size = New Size(123, 39)
        txtGuestName.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(97, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 4
        Label1.Text = "Guest ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(97, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 5
        Label2.Text = "RoomNo."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(97, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 15)
        Label3.TabIndex = 6
        Label3.Text = "GuestName"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(97, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 15)
        Label4.TabIndex = 7
        Label4.Text = "PaymentDate"
        ' 
        ' btnBook
        ' 
        btnBook.Location = New Point(175, 287)
        btnBook.Name = "btnBook"
        btnBook.Size = New Size(94, 51)
        btnBook.TabIndex = 8
        btnBook.Text = "Book"
        btnBook.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(275, 287)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 51)
        btnBack.TabIndex = 9
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' cmbPaymentMethod
        ' 
        cmbPaymentMethod.FormattingEnabled = True
        cmbPaymentMethod.Location = New Point(275, 26)
        cmbPaymentMethod.Name = "cmbPaymentMethod"
        cmbPaymentMethod.Size = New Size(121, 23)
        cmbPaymentMethod.TabIndex = 10
        ' 
        ' dtpPaymentDate
        ' 
        dtpPaymentDate.Location = New Point(97, 228)
        dtpPaymentDate.Name = "dtpPaymentDate"
        dtpPaymentDate.Size = New Size(200, 23)
        dtpPaymentDate.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(275, 8)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 15)
        Label5.TabIndex = 12
        Label5.Text = "PaymentMethod"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(275, 73)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 15)
        Label6.TabIndex = 14
        Label6.Text = "Status"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(275, 91)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(121, 23)
        cmbStatus.TabIndex = 13
        ' 
        ' Payment
        ' 
        Payment.AutoSize = True
        Payment.Location = New Point(275, 134)
        Payment.Name = "Payment"
        Payment.Size = New Size(74, 15)
        Payment.TabIndex = 16
        Payment.Text = "AmountPaid"
        ' 
        ' txtAmountPaid
        ' 
        txtAmountPaid.Location = New Point(275, 152)
        txtAmountPaid.Multiline = True
        txtAmountPaid.Name = "txtAmountPaid"
        txtAmountPaid.Size = New Size(123, 39)
        txtAmountPaid.TabIndex = 15
        ' 
        ' PaymentdetailsFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(524, 443)
        Controls.Add(Payment)
        Controls.Add(txtAmountPaid)
        Controls.Add(Label6)
        Controls.Add(cmbStatus)
        Controls.Add(Label5)
        Controls.Add(dtpPaymentDate)
        Controls.Add(cmbPaymentMethod)
        Controls.Add(btnBack)
        Controls.Add(btnBook)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtGuestName)
        Controls.Add(txtRoomNo)
        Controls.Add(txtGuestID)
        Name = "PaymentdetailsFrm"
        Text = "PaymentdetailsFrm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtGuestID As TextBox
    Friend WithEvents txtRoomNo As TextBox
    Friend WithEvents txtGuestName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBook As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Payment As Label
    Friend WithEvents txtAmountPaid As TextBox
End Class
