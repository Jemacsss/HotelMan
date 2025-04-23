<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HKoverview
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
        btnback = New Button()
        DataGridView2 = New DataGridView()
        lbl1 = New Label()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 102)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(551, 379)
        DataGridView1.TabIndex = 0
        ' 
        ' btnback
        ' 
        btnback.Location = New Point(1158, 529)
        btnback.Name = "btnback"
        btnback.Size = New Size(75, 40)
        btnback.TabIndex = 1
        btnback.Text = "Back"
        btnback.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(682, 102)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(551, 379)
        DataGridView2.TabIndex = 2
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Font = New Font("Segoe UI", 15F)
        lbl1.Location = New Point(227, 23)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(91, 28)
        lbl1.TabIndex = 3
        lbl1.Text = "Schedule"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(915, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 28)
        Label1.TabIndex = 4
        Label1.Text = "Inventory"
        ' 
        ' HKoverview
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1282, 603)
        Controls.Add(Label1)
        Controls.Add(lbl1)
        Controls.Add(DataGridView2)
        Controls.Add(btnback)
        Controls.Add(DataGridView1)
        Name = "HKoverview"
        Text = "HKOverview"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnback As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents lbl1 As Label
    Friend WithEvents Label1 As Label
End Class
