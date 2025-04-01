<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HKscheduleFrm
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
        btnHkInventory = New Button()
        btnAddSched = New Button()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        ListBox1 = New ListBox()
        btnDelete = New Button()
        txtStatus = New TextBox()
        Label8 = New Label()
        txtRoomtype = New TextBox()
        Label7 = New Label()
        txtChores = New TextBox()
        Label4 = New Label()
        txtStaff = New TextBox()
        txtRoomnumber = New TextBox()
        dtpEnddate = New DateTimePicker()
        dtpStartdate = New DateTimePicker()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label9 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(37, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 28)
        Label1.TabIndex = 0
        Label1.Text = "Housekeeping Schedule"
        ' 
        ' btnback
        ' 
        btnback.Location = New Point(713, 373)
        btnback.Name = "btnback"
        btnback.Size = New Size(75, 23)
        btnback.TabIndex = 1
        btnback.Text = "Back"
        btnback.UseVisualStyleBackColor = True
        ' 
        ' btnHkInventory
        ' 
        btnHkInventory.Font = New Font("Segoe UI", 12F)
        btnHkInventory.Location = New Point(355, 47)
        btnHkInventory.Name = "btnHkInventory"
        btnHkInventory.Size = New Size(204, 36)
        btnHkInventory.TabIndex = 2
        btnHkInventory.Text = "Housekeeping Inventory"
        btnHkInventory.UseVisualStyleBackColor = True
        ' 
        ' btnAddSched
        ' 
        btnAddSched.Font = New Font("Segoe UI", 12F)
        btnAddSched.Location = New Point(584, 47)
        btnAddSched.Name = "btnAddSched"
        btnAddSched.Size = New Size(204, 36)
        btnAddSched.TabIndex = 3
        btnAddSched.Text = "New Schedule"
        btnAddSched.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(356, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(203, 28)
        Label2.TabIndex = 5
        Label2.Text = "Housekeeping details:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"All", "In Progress", "Pending", "Done"})
        ComboBox1.Location = New Point(37, 90)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(67, 23)
        ComboBox1.TabIndex = 11
        ComboBox1.Text = "All"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(38, 126)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(311, 229)
        ListBox1.TabIndex = 30
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(274, 373)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 31
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' txtStatus
        ' 
        txtStatus.Location = New Point(532, 245)
        txtStatus.Name = "txtStatus"
        txtStatus.Size = New Size(142, 23)
        txtStatus.TabIndex = 63
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15F)
        Label8.Location = New Point(356, 240)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 28)
        Label8.TabIndex = 62
        Label8.Text = "Status:"
        ' 
        ' txtRoomtype
        ' 
        txtRoomtype.Location = New Point(533, 160)
        txtRoomtype.Name = "txtRoomtype"
        txtRoomtype.Size = New Size(141, 23)
        txtRoomtype.TabIndex = 61
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15F)
        Label7.Location = New Point(357, 156)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 28)
        Label7.TabIndex = 60
        Label7.Text = "Room type:"
        ' 
        ' txtChores
        ' 
        txtChores.Location = New Point(532, 217)
        txtChores.Name = "txtChores"
        txtChores.Size = New Size(142, 23)
        txtChores.TabIndex = 59
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(356, 212)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 28)
        Label4.TabIndex = 58
        Label4.Text = "Chores:"
        ' 
        ' txtStaff
        ' 
        txtStaff.Location = New Point(533, 133)
        txtStaff.Name = "txtStaff"
        txtStaff.Size = New Size(141, 23)
        txtStaff.TabIndex = 57
        ' 
        ' txtRoomnumber
        ' 
        txtRoomnumber.Location = New Point(532, 188)
        txtRoomnumber.Name = "txtRoomnumber"
        txtRoomnumber.Size = New Size(142, 23)
        txtRoomnumber.TabIndex = 56
        ' 
        ' dtpEnddate
        ' 
        dtpEnddate.Format = DateTimePickerFormat.Time
        dtpEnddate.Location = New Point(532, 315)
        dtpEnddate.Name = "dtpEnddate"
        dtpEnddate.Size = New Size(142, 23)
        dtpEnddate.TabIndex = 55
        ' 
        ' dtpStartdate
        ' 
        dtpStartdate.Format = DateTimePickerFormat.Time
        dtpStartdate.Location = New Point(532, 287)
        dtpStartdate.Name = "dtpStartdate"
        dtpStartdate.Size = New Size(143, 23)
        dtpStartdate.TabIndex = 54
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15F)
        Label6.Location = New Point(357, 282)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 28)
        Label6.TabIndex = 53
        Label6.Text = "Start date:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15F)
        Label5.Location = New Point(356, 184)
        Label5.Name = "Label5"
        Label5.Size = New Size(141, 28)
        Label5.TabIndex = 52
        Label5.Text = "Room number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(356, 310)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 28)
        Label3.TabIndex = 51
        Label3.Text = "End date:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 15F)
        Label9.Location = New Point(356, 128)
        Label9.Name = "Label9"
        Label9.Size = New Size(55, 28)
        Label9.TabIndex = 50
        Label9.Text = "Staff:"
        ' 
        ' HKscheduleFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(804, 413)
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
        Controls.Add(Label9)
        Controls.Add(btnDelete)
        Controls.Add(ListBox1)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(btnAddSched)
        Controls.Add(btnHkInventory)
        Controls.Add(btnback)
        Controls.Add(Label1)
        Name = "HKscheduleFrm"
        Text = "HKscheduleFrm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnback As Button
    Friend WithEvents btnHkInventory As Button
    Friend WithEvents btnAddSched As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRoomtype As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtChores As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStaff As TextBox
    Friend WithEvents txtRoomnumber As TextBox
    Friend WithEvents dtpEnddate As DateTimePicker
    Friend WithEvents dtpStartdate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button3 As Button
End Class
