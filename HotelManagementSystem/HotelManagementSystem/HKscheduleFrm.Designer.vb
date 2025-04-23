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
        btnDelete = New Button()
        Label8 = New Label()
        txtChores = New TextBox()
        Label4 = New Label()
        dtpEnddate = New DateTimePicker()
        dtpStartdate = New DateTimePicker()
        Label6 = New Label()
        Label3 = New Label()
        Label9 = New Label()
        cbostatus = New ComboBox()
        Label10 = New Label()
        cboStaff = New ComboBox()
        txtRoomID = New TextBox()
        txtRoomNumber = New TextBox()
        Label5 = New Label()
        btnDone = New Button()
        btnEdit = New Button()
        BtnSave = New Button()
        ListView1 = New ListView()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(40, 342)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 28)
        Label1.TabIndex = 0
        Label1.Text = "Housekeeping Schedule"
        ' 
        ' btnback
        ' 
        btnback.Location = New Point(543, 504)
        btnback.Name = "btnback"
        btnback.Size = New Size(75, 23)
        btnback.TabIndex = 1
        btnback.Text = "Back"
        btnback.UseVisualStyleBackColor = True
        ' 
        ' btnHkInventory
        ' 
        btnHkInventory.Font = New Font("Segoe UI", 12F)
        btnHkInventory.Location = New Point(427, 340)
        btnHkInventory.Name = "btnHkInventory"
        btnHkInventory.Size = New Size(191, 36)
        btnHkInventory.TabIndex = 2
        btnHkInventory.Text = "Housekeeping Inventory"
        btnHkInventory.UseVisualStyleBackColor = True
        ' 
        ' btnAddSched
        ' 
        btnAddSched.Font = New Font("Segoe UI", 12F)
        btnAddSched.Location = New Point(40, 303)
        btnAddSched.Name = "btnAddSched"
        btnAddSched.Size = New Size(136, 36)
        btnAddSched.TabIndex = 3
        btnAddSched.Text = "New Schedule"
        btnAddSched.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(35, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(203, 28)
        Label2.TabIndex = 5
        Label2.Text = "Housekeeping details:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"All", "In Progress", "Done"})
        ComboBox1.Location = New Point(267, 347)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(67, 23)
        ComboBox1.TabIndex = 11
        ComboBox1.Text = "All"
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(438, 504)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 31
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15F)
        Label8.Location = New Point(364, 82)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 28)
        Label8.TabIndex = 62
        Label8.Text = "Status:"
        ' 
        ' txtChores
        ' 
        txtChores.Location = New Point(364, 160)
        txtChores.Multiline = True
        txtChores.Name = "txtChores"
        txtChores.Size = New Size(254, 112)
        txtChores.TabIndex = 59
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(364, 126)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 28)
        Label4.TabIndex = 58
        Label4.Text = "Chores:"
        ' 
        ' dtpEnddate
        ' 
        dtpEnddate.Format = DateTimePickerFormat.Time
        dtpEnddate.Location = New Point(197, 249)
        dtpEnddate.Name = "dtpEnddate"
        dtpEnddate.Size = New Size(143, 23)
        dtpEnddate.TabIndex = 55
        ' 
        ' dtpStartdate
        ' 
        dtpStartdate.Format = DateTimePickerFormat.Time
        dtpStartdate.Location = New Point(197, 208)
        dtpStartdate.Name = "dtpStartdate"
        dtpStartdate.Size = New Size(143, 23)
        dtpStartdate.TabIndex = 54
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15F)
        Label6.Location = New Point(35, 205)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 28)
        Label6.TabIndex = 53
        Label6.Text = "Start date:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(35, 244)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 28)
        Label3.TabIndex = 51
        Label3.Text = "End date:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 15F)
        Label9.Location = New Point(35, 85)
        Label9.Name = "Label9"
        Label9.Size = New Size(55, 28)
        Label9.TabIndex = 50
        Label9.Text = "Staff:"
        ' 
        ' cbostatus
        ' 
        cbostatus.FormattingEnabled = True
        cbostatus.Items.AddRange(New Object() {"In Progress", "Done"})
        cbostatus.Location = New Point(454, 87)
        cbostatus.Name = "cbostatus"
        cbostatus.Size = New Size(164, 23)
        cbostatus.TabIndex = 63
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 15F)
        Label10.Location = New Point(35, 124)
        Label10.Name = "Label10"
        Label10.Size = New Size(92, 28)
        Label10.TabIndex = 64
        Label10.Text = "Room ID:"
        ' 
        ' cboStaff
        ' 
        cboStaff.FormattingEnabled = True
        cboStaff.Location = New Point(197, 85)
        cboStaff.Name = "cboStaff"
        cboStaff.Size = New Size(143, 23)
        cboStaff.TabIndex = 66
        ' 
        ' txtRoomID
        ' 
        txtRoomID.Location = New Point(197, 126)
        txtRoomID.Name = "txtRoomID"
        txtRoomID.Size = New Size(143, 23)
        txtRoomID.TabIndex = 68
        ' 
        ' txtRoomNumber
        ' 
        txtRoomNumber.Location = New Point(197, 162)
        txtRoomNumber.Name = "txtRoomNumber"
        txtRoomNumber.Size = New Size(143, 23)
        txtRoomNumber.TabIndex = 70
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15F)
        Label5.Location = New Point(35, 160)
        Label5.Name = "Label5"
        Label5.Size = New Size(145, 28)
        Label5.TabIndex = 69
        Label5.Text = "Room Number:"
        ' 
        ' btnDone
        ' 
        btnDone.Font = New Font("Segoe UI", 12F)
        btnDone.Location = New Point(551, 298)
        btnDone.Name = "btnDone"
        btnDone.Size = New Size(67, 36)
        btnDone.TabIndex = 71
        btnDone.Text = "Done"
        btnDone.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Segoe UI", 12F)
        btnEdit.Location = New Point(405, 298)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(67, 36)
        btnEdit.TabIndex = 72
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' BtnSave
        ' 
        BtnSave.Font = New Font("Segoe UI", 12F)
        BtnSave.Location = New Point(478, 298)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(67, 36)
        BtnSave.TabIndex = 73
        BtnSave.Text = "Save"
        BtnSave.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(46, 388)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(572, 98)
        ListView1.TabIndex = 74
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' HKscheduleFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(656, 553)
        Controls.Add(ListView1)
        Controls.Add(BtnSave)
        Controls.Add(btnEdit)
        Controls.Add(btnDone)
        Controls.Add(txtRoomNumber)
        Controls.Add(Label5)
        Controls.Add(txtRoomID)
        Controls.Add(cboStaff)
        Controls.Add(Label10)
        Controls.Add(cbostatus)
        Controls.Add(Label8)
        Controls.Add(txtChores)
        Controls.Add(Label4)
        Controls.Add(dtpEnddate)
        Controls.Add(dtpStartdate)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label9)
        Controls.Add(btnDelete)
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
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtChores As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpEnddate As DateTimePicker
    Friend WithEvents dtpStartdate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents cbostatus As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboStaff As ComboBox
    Friend WithEvents txtRoomID As TextBox
    Friend WithEvents txtRoomNumber As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDone As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents ListView1 As ListView
End Class
