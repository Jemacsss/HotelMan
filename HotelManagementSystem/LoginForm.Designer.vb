<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtUsername = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtPassword = New TextBox()
        btnlogin = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(106, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(479, 33)
        Label1.TabIndex = 0
        Label1.Text = "HOTEL MANAGEMENT SYSTEM"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(339, 155)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(134, 23)
        txtUsername.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(203, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 23)
        Label2.TabIndex = 2
        Label2.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(208, 200)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 23)
        Label3.TabIndex = 3
        Label3.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(339, 200)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(134, 23)
        txtPassword.TabIndex = 4
        ' 
        ' btnlogin
        ' 
        btnlogin.Font = New Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnlogin.Location = New Point(339, 255)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(100, 35)
        btnlogin.TabIndex = 5
        btnlogin.Text = "Log in"
        btnlogin.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 365)
        Controls.Add(btnlogin)
        Controls.Add(txtPassword)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtUsername)
        Controls.Add(Label1)
        Name = "LoginForm"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnlogin As Button

End Class
