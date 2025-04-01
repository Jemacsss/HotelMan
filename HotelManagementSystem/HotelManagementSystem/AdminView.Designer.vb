<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminView
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
        btnstaff = New Button()
        btnreserve = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' btnstaff
        ' 
        btnstaff.Location = New Point(102, 125)
        btnstaff.Name = "btnstaff"
        btnstaff.Size = New Size(98, 23)
        btnstaff.TabIndex = 0
        btnstaff.Text = "Staff"
        btnstaff.UseVisualStyleBackColor = True
        ' 
        ' btnreserve
        ' 
        btnreserve.Location = New Point(102, 168)
        btnreserve.Name = "btnreserve"
        btnreserve.Size = New Size(98, 23)
        btnreserve.TabIndex = 1
        btnreserve.Text = "Reservation"
        btnreserve.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(102, 207)
        Button3.Name = "Button3"
        Button3.Size = New Size(98, 23)
        Button3.TabIndex = 2
        Button3.Text = "Rooms"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(102, 245)
        Button4.Name = "Button4"
        Button4.Size = New Size(98, 23)
        Button4.TabIndex = 3
        Button4.Text = "Housekeeping"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' AdminView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(btnreserve)
        Controls.Add(btnstaff)
        Name = "AdminView"
        Text = "AdminView"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnstaff As Button
    Friend WithEvents btnreserve As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
