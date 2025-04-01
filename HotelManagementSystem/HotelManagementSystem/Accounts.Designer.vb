<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accounts
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
        btnBack = New Button()
        txtSearch = New TextBox()
        btnClear = New Button()
        lsbUsers = New ListBox()
        GroupBox1 = New GroupBox()
        txtPos = New TextBox()
        txtPass = New TextBox()
        txtUser = New TextBox()
        txtLname = New TextBox()
        txtFname = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnDel = New Button()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnCancel = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(111, 573)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(110, 47)
        btnBack.TabIndex = 0
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(126, 66)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(278, 23)
        txtSearch.TabIndex = 1
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(427, 58)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(110, 36)
        btnClear.TabIndex = 2
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lsbUsers
        ' 
        lsbUsers.FormattingEnabled = True
        lsbUsers.ItemHeight = 15
        lsbUsers.Location = New Point(129, 134)
        lsbUsers.Name = "lsbUsers"
        lsbUsers.Size = New Size(408, 289)
        lsbUsers.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtPos)
        GroupBox1.Controls.Add(txtPass)
        GroupBox1.Controls.Add(txtUser)
        GroupBox1.Controls.Add(txtLname)
        GroupBox1.Controls.Add(txtFname)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(732, 107)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(301, 326)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "User Info"
        ' 
        ' txtPos
        ' 
        txtPos.Location = New Point(106, 210)
        txtPos.Name = "txtPos"
        txtPos.Size = New Size(172, 23)
        txtPos.TabIndex = 9
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(106, 167)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(172, 23)
        txtPass.TabIndex = 8
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(106, 128)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(172, 23)
        txtUser.TabIndex = 7
        ' 
        ' txtLname
        ' 
        txtLname.Location = New Point(106, 86)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(172, 23)
        txtLname.TabIndex = 6
        ' 
        ' txtFname
        ' 
        txtFname.Location = New Point(106, 44)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(172, 23)
        txtFname.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(18, 213)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 15)
        Label5.TabIndex = 4
        Label5.Text = "Position"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 170)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 3
        Label4.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(18, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 2
        Label3.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 1
        Label2.Text = "Last Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Name"
        ' 
        ' btnDel
        ' 
        btnDel.Location = New Point(427, 452)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(110, 36)
        btnDel.TabIndex = 5
        btnDel.Text = "Delete"
        btnDel.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(732, 452)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(110, 36)
        btnAdd.TabIndex = 6
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(923, 452)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(110, 36)
        btnUpdate.TabIndex = 7
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(828, 521)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(110, 36)
        btnCancel.TabIndex = 8
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Accounts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1167, 678)
        Controls.Add(btnCancel)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(btnDel)
        Controls.Add(GroupBox1)
        Controls.Add(lsbUsers)
        Controls.Add(btnClear)
        Controls.Add(txtSearch)
        Controls.Add(btnBack)
        Name = "Accounts"
        Text = "Accounts"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents lsbUsers As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPos As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtFname As TextBox
End Class
