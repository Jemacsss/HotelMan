<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HKsupervisor
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
        btnBack = New Button()
        btnlog = New Button()
        btnhkinv = New Button()
        btnOverview = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(319, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 15)
        Label1.TabIndex = 0
        Label1.Text = "Housekeeping Supervisor"
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(334, 386)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(113, 52)
        btnBack.TabIndex = 1
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnlog
        ' 
        btnlog.Location = New Point(334, 289)
        btnlog.Name = "btnlog"
        btnlog.Size = New Size(113, 52)
        btnlog.TabIndex = 2
        btnlog.Text = "Log Details"
        btnlog.UseVisualStyleBackColor = True
        ' 
        ' btnhkinv
        ' 
        btnhkinv.Location = New Point(334, 190)
        btnhkinv.Name = "btnhkinv"
        btnhkinv.Size = New Size(113, 52)
        btnhkinv.TabIndex = 3
        btnhkinv.Text = "Housekeeping"
        btnhkinv.UseVisualStyleBackColor = True
        ' 
        ' btnOverview
        ' 
        btnOverview.Location = New Point(334, 87)
        btnOverview.Name = "btnOverview"
        btnOverview.Size = New Size(113, 52)
        btnOverview.TabIndex = 5
        btnOverview.Text = "Overview"
        btnOverview.UseVisualStyleBackColor = True
        ' 
        ' HKsupervisor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnOverview)
        Controls.Add(btnhkinv)
        Controls.Add(btnlog)
        Controls.Add(btnBack)
        Controls.Add(Label1)
        Name = "HKsupervisor"
        Text = "HKsupervisor"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnlog As Button
    Friend WithEvents btnhkinv As Button
    Friend WithEvents btnOverview As Button
End Class
