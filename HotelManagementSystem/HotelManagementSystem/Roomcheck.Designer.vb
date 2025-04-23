<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Roomcheck
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
        btnadd = New Button()
        btnedit = New Button()
        btndel = New Button()
        btnback = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(83, 216)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1202, 652)
        DataGridView1.TabIndex = 0
        ' 
        ' btnadd
        ' 
        btnadd.Location = New Point(132, 910)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(110, 56)
        btnadd.TabIndex = 1
        btnadd.Text = "Add"
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' btnedit
        ' 
        btnedit.Location = New Point(275, 910)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(110, 56)
        btnedit.TabIndex = 2
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = True
        ' 
        ' btndel
        ' 
        btndel.Location = New Point(419, 910)
        btndel.Name = "btndel"
        btndel.Size = New Size(110, 56)
        btndel.TabIndex = 3
        btndel.Text = "Delete"
        btndel.UseVisualStyleBackColor = True
        ' 
        ' btnback
        ' 
        btnback.Location = New Point(1184, 910)
        btnback.Name = "btnback"
        btnback.Size = New Size(110, 56)
        btnback.TabIndex = 4
        btnback.Text = "Back"
        btnback.UseVisualStyleBackColor = True
        ' 
        ' Roomcheck
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1326, 1007)
        Controls.Add(btnback)
        Controls.Add(btndel)
        Controls.Add(btnedit)
        Controls.Add(btnadd)
        Controls.Add(DataGridView1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Roomcheck"
        Text = "Roomcheck"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnadd As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btnback As Button
End Class
