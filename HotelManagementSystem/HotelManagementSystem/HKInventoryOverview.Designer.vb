<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HKInventoryOverview
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
        DataGridView1 = New DataGridView()
        btnedit = New Button()
        btnback = New Button()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(32, 70)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(732, 353)
        DataGridView1.TabIndex = 0
        ' 
        ' btnedit
        ' 
        btnedit.Location = New Point(558, 463)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(87, 39)
        btnedit.TabIndex = 2
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = True
        ' 
        ' btnback
        ' 
        btnback.Location = New Point(677, 463)
        btnback.Name = "btnback"
        btnback.Size = New Size(87, 39)
        btnback.TabIndex = 3
        btnback.Text = "Back"
        btnback.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(303, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(181, 28)
        Label1.TabIndex = 4
        Label1.Text = "Inventory Overview"
        ' 
        ' HKInventoryOverview
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 514)
        Controls.Add(Label1)
        Controls.Add(btnback)
        Controls.Add(btnedit)
        Controls.Add(DataGridView1)
        Name = "HKInventoryOverview"
        Text = "HKInventoryOverview"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnedit As Button
    Friend WithEvents btnback As Button
    Friend WithEvents Label1 As Label
End Class
