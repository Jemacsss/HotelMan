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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(321, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 15)
        Label1.TabIndex = 0
        Label1.Text = "Housekeeping Schedule"
        ' 
        ' btnback
        ' 
        btnback.Location = New Point(364, 301)
        btnback.Name = "btnback"
        btnback.Size = New Size(75, 23)
        btnback.TabIndex = 1
        btnback.Text = "Back"
        btnback.UseVisualStyleBackColor = True
        ' 
        ' HKscheduleFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnback)
        Controls.Add(Label1)
        Name = "HKscheduleFrm"
        Text = "HKscheduleFrm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnback As Button
End Class
