<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frontdesk
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
        btnbooking = New Button()
        btnhksched = New Button()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(366, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 0
        Label1.Text = "Frontdesk"
        ' 
        ' btnbooking
        ' 
        btnbooking.Location = New Point(291, 128)
        btnbooking.Name = "btnbooking"
        btnbooking.Size = New Size(204, 83)
        btnbooking.TabIndex = 1
        btnbooking.Text = "Bookings"
        btnbooking.UseVisualStyleBackColor = True
        ' 
        ' btnhksched
        ' 
        btnhksched.Location = New Point(291, 237)
        btnhksched.Name = "btnhksched"
        btnhksched.Size = New Size(204, 83)
        btnhksched.TabIndex = 2
        btnhksched.Text = "Housekeeping Schedule"
        btnhksched.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(350, 392)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 3
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Frontdesk
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(btnhksched)
        Controls.Add(btnbooking)
        Controls.Add(Label1)
        Name = "Frontdesk"
        Text = "FrondDesk"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnbooking As Button
    Friend WithEvents btnhksched As Button
    Friend WithEvents btnBack As Button
End Class
