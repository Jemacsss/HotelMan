<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manager
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
        btnAcc = New Button()
        btnreserve = New Button()
        btnManage = New Button()
        Button4 = New Button()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' btnAcc
        ' 
        btnAcc.Location = New Point(301, 457)
        btnAcc.Margin = New Padding(3, 4, 3, 4)
        btnAcc.Name = "btnAcc"
        btnAcc.Size = New Size(221, 91)
        btnAcc.TabIndex = 0
        btnAcc.Text = "Accounts"
        btnAcc.UseVisualStyleBackColor = True
        ' 
        ' btnreserve
        ' 
        btnreserve.Location = New Point(301, 112)
        btnreserve.Margin = New Padding(3, 4, 3, 4)
        btnreserve.Name = "btnreserve"
        btnreserve.Size = New Size(221, 77)
        btnreserve.TabIndex = 1
        btnreserve.Text = "Booking"
        btnreserve.UseVisualStyleBackColor = True
        ' 
        ' btnManage
        ' 
        btnManage.Location = New Point(301, 227)
        btnManage.Margin = New Padding(3, 4, 3, 4)
        btnManage.Name = "btnManage"
        btnManage.Size = New Size(221, 84)
        btnManage.TabIndex = 2
        btnManage.Text = "Manage Rooms"
        btnManage.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(301, 333)
        Button4.Margin = New Padding(3, 4, 3, 4)
        Button4.Name = "Button4"
        Button4.Size = New Size(221, 88)
        Button4.TabIndex = 3
        Button4.Text = "Housekeeping"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(301, 580)
        btnBack.Margin = New Padding(3, 4, 3, 4)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(221, 91)
        btnBack.TabIndex = 4
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Manager
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 780)
        Controls.Add(btnBack)
        Controls.Add(Button4)
        Controls.Add(btnManage)
        Controls.Add(btnreserve)
        Controls.Add(btnAcc)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Manager"
        Text = "AdminView"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAcc As Button
    Friend WithEvents btnreserve As Button
    Friend WithEvents btnManage As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnBack As Button
End Class
