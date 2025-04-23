<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        btnLogin = New Button()
        txtUser = New TextBox()
        txtPass = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        PanelHeader = New Panel()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(355, 432)
        btnLogin.Margin = New Padding(3, 4, 3, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(86, 31)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(355, 196)
        txtUser.Margin = New Padding(3, 4, 3, 4)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(114, 27)
        txtUser.TabIndex = 1
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(355, 277)
        txtPass.Margin = New Padding(3, 4, 3, 4)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(114, 27)
        txtPass.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(203, 200)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 3
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(203, 281)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 4
        Label2.Text = "Password"
        ' 
        ' PanelHeader
        ' 
        PanelHeader.Location = New Point(-5, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(924, 125)
        PanelHeader.TabIndex = 5
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(PanelHeader)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(btnLogin)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelHeader As Panel
End Class
