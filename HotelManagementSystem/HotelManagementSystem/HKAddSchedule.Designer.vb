<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HKAddSchedule
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
        Label6 = New Label()
        Label3 = New Label()
        btnAddSched = New Button()
        Label1 = New Label()
        dtpStartdate = New DateTimePicker()
        dtpEnddate = New DateTimePicker()
        Label4 = New Label()
        txtChores = New TextBox()
        Label8 = New Label()
        btnBack = New Button()
        cboStaff = New ComboBox()
        cboRoomNum = New ComboBox()
        Label10 = New Label()
        Label9 = New Label()
        cboStatus = New ComboBox()
        Label2 = New Label()
        txtRoomID = New TextBox()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15F)
        Label6.Location = New Point(33, 194)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 28)
        Label6.TabIndex = 35
        Label6.Text = "Start date:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(32, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 28)
        Label3.TabIndex = 32
        Label3.Text = "End date:"
        ' 
        ' btnAddSched
        ' 
        btnAddSched.Font = New Font("Segoe UI", 10F)
        btnAddSched.Location = New Point(204, 375)
        btnAddSched.Name = "btnAddSched"
        btnAddSched.Size = New Size(124, 28)
        btnAddSched.TabIndex = 29
        btnAddSched.Text = "Add schedule"
        btnAddSched.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(33, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 28)
        Label1.TabIndex = 28
        Label1.Text = "Add New Schedule"
        ' 
        ' dtpStartdate
        ' 
        dtpStartdate.Location = New Point(184, 199)
        dtpStartdate.Name = "dtpStartdate"
        dtpStartdate.Size = New Size(143, 23)
        dtpStartdate.TabIndex = 39
        ' 
        ' dtpEnddate
        ' 
        dtpEnddate.Location = New Point(184, 227)
        dtpEnddate.Name = "dtpEnddate"
        dtpEnddate.Size = New Size(143, 23)
        dtpEnddate.TabIndex = 40
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(32, 250)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 28)
        Label4.TabIndex = 44
        Label4.Text = "Chores:"
        ' 
        ' txtChores
        ' 
        txtChores.Location = New Point(33, 290)
        txtChores.Multiline = True
        txtChores.Name = "txtChores"
        txtChores.Size = New Size(294, 61)
        txtChores.TabIndex = 49
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15F)
        Label8.Location = New Point(33, 66)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 28)
        Label8.TabIndex = 48
        Label8.Text = "Status:"
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(33, 375)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 50
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' cboStaff
        ' 
        cboStaff.FormattingEnabled = True
        cboStaff.Location = New Point(184, 98)
        cboStaff.Name = "cboStaff"
        cboStaff.Size = New Size(143, 23)
        cboStaff.TabIndex = 70
        ' 
        ' cboRoomNum
        ' 
        cboRoomNum.FormattingEnabled = True
        cboRoomNum.Location = New Point(184, 127)
        cboRoomNum.Name = "cboRoomNum"
        cboRoomNum.Size = New Size(143, 23)
        cboRoomNum.TabIndex = 69
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 15F)
        Label10.Location = New Point(33, 122)
        Label10.Name = "Label10"
        Label10.Size = New Size(145, 28)
        Label10.TabIndex = 68
        Label10.Text = "Room Number:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 15F)
        Label9.Location = New Point(33, 94)
        Label9.Name = "Label9"
        Label9.Size = New Size(55, 28)
        Label9.TabIndex = 67
        Label9.Text = "Staff:"
        ' 
        ' cboStatus
        ' 
        cboStatus.FormattingEnabled = True
        cboStatus.Items.AddRange(New Object() {"In Progress", "Done"})
        cboStatus.Location = New Point(184, 70)
        cboStatus.Name = "cboStatus"
        cboStatus.Size = New Size(143, 23)
        cboStatus.TabIndex = 71
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(33, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 28)
        Label2.TabIndex = 72
        Label2.Text = "Room ID:"
        ' 
        ' txtRoomID
        ' 
        txtRoomID.Location = New Point(184, 158)
        txtRoomID.Name = "txtRoomID"
        txtRoomID.Size = New Size(144, 23)
        txtRoomID.TabIndex = 73
        ' 
        ' HKAddSchedule
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(363, 409)
        Controls.Add(txtRoomID)
        Controls.Add(Label2)
        Controls.Add(cboStatus)
        Controls.Add(cboStaff)
        Controls.Add(cboRoomNum)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(btnBack)
        Controls.Add(txtChores)
        Controls.Add(Label8)
        Controls.Add(Label4)
        Controls.Add(dtpEnddate)
        Controls.Add(dtpStartdate)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(btnAddSched)
        Controls.Add(Label1)
        Name = "HKAddSchedule"
        Text = "HKAddSchedule"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddSched As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpStartdate As DateTimePicker
    Friend WithEvents dtpEnddate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtChores As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents cboStaff As ComboBox
    Friend WithEvents cboRoomNum As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRoomID As TextBox
End Class
