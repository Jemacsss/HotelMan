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
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnAddSched = New Button()
        Label1 = New Label()
        dtpStartdate = New DateTimePicker()
        dtpEnddate = New DateTimePicker()
        txtRoomnumber = New TextBox()
        txtStaff = New TextBox()
        Label4 = New Label()
        txtChores = New TextBox()
        txtRoomtype = New TextBox()
        Label7 = New Label()
        txtStatus = New TextBox()
        Label8 = New Label()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15F)
        Label6.Location = New Point(23, 209)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 28)
        Label6.TabIndex = 35
        Label6.Text = "Start date:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15F)
        Label5.Location = New Point(22, 111)
        Label5.Name = "Label5"
        Label5.Size = New Size(141, 28)
        Label5.TabIndex = 34
        Label5.Text = "Room number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(22, 237)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 28)
        Label3.TabIndex = 32
        Label3.Text = "End date:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(22, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 28)
        Label2.TabIndex = 31
        Label2.Text = "Staff:"
        ' 
        ' btnAddSched
        ' 
        btnAddSched.Font = New Font("Segoe UI", 10F)
        btnAddSched.Location = New Point(218, 313)
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
        Label1.Location = New Point(23, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 28)
        Label1.TabIndex = 28
        Label1.Text = "Add New Schedule"
        ' 
        ' dtpStartdate
        ' 
        dtpStartdate.Location = New Point(198, 214)
        dtpStartdate.Name = "dtpStartdate"
        dtpStartdate.Size = New Size(143, 23)
        dtpStartdate.TabIndex = 39
        ' 
        ' dtpEnddate
        ' 
        dtpEnddate.Location = New Point(198, 242)
        dtpEnddate.Name = "dtpEnddate"
        dtpEnddate.Size = New Size(142, 23)
        dtpEnddate.TabIndex = 40
        ' 
        ' txtRoomnumber
        ' 
        txtRoomnumber.Location = New Point(198, 115)
        txtRoomnumber.Name = "txtRoomnumber"
        txtRoomnumber.Size = New Size(142, 23)
        txtRoomnumber.TabIndex = 42
        ' 
        ' txtStaff
        ' 
        txtStaff.Location = New Point(199, 60)
        txtStaff.Name = "txtStaff"
        txtStaff.Size = New Size(143, 23)
        txtStaff.TabIndex = 43
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(22, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 28)
        Label4.TabIndex = 44
        Label4.Text = "Chores:"
        ' 
        ' txtChores
        ' 
        txtChores.Location = New Point(198, 144)
        txtChores.Name = "txtChores"
        txtChores.Size = New Size(142, 23)
        txtChores.TabIndex = 45
        ' 
        ' txtRoomtype
        ' 
        txtRoomtype.Location = New Point(199, 87)
        txtRoomtype.Name = "txtRoomtype"
        txtRoomtype.Size = New Size(142, 23)
        txtRoomtype.TabIndex = 47
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15F)
        Label7.Location = New Point(23, 83)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 28)
        Label7.TabIndex = 46
        Label7.Text = "Room type:"
        ' 
        ' txtStatus
        ' 
        txtStatus.Location = New Point(198, 172)
        txtStatus.Name = "txtStatus"
        txtStatus.Size = New Size(142, 23)
        txtStatus.TabIndex = 49
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15F)
        Label8.Location = New Point(22, 167)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 28)
        Label8.TabIndex = 48
        Label8.Text = "Status:"
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(23, 318)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 50
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' HKAddSchedule
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(363, 388)
        Controls.Add(btnBack)
        Controls.Add(txtStatus)
        Controls.Add(Label8)
        Controls.Add(txtRoomtype)
        Controls.Add(Label7)
        Controls.Add(txtChores)
        Controls.Add(Label4)
        Controls.Add(txtStaff)
        Controls.Add(txtRoomnumber)
        Controls.Add(dtpEnddate)
        Controls.Add(dtpStartdate)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnAddSched)
        Controls.Add(Label1)
        Name = "HKAddSchedule"
        Text = "HKAddSchedule"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddSched As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpStartdate As DateTimePicker
    Friend WithEvents dtpEnddate As DateTimePicker
    Friend WithEvents txtRoomnumber As TextBox
    Friend WithEvents txtStaff As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtChores As TextBox
    Friend WithEvents txtRoomtype As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBack As Button
End Class
