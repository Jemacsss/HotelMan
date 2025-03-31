<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Button6 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        DataGridView1 = New DataGridView()
        DataGridView2 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans", 10.75F, FontStyle.Bold)
        Label1.Location = New Point(84, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 17)
        Label1.TabIndex = 1
        Label1.Text = "HOTEL"
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(39, 52)
        Button6.Name = "Button6"
        Button6.Size = New Size(158, 32)
        Button6.TabIndex = 9
        Button6.Text = "Staff"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(39, 166)
        Button2.Name = "Button2"
        Button2.Size = New Size(158, 32)
        Button2.TabIndex = 10
        Button2.Text = "Housekeeping"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(39, 128)
        Button3.Name = "Button3"
        Button3.Size = New Size(158, 32)
        Button3.TabIndex = 11
        Button3.Text = "Rooms"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(39, 90)
        Button4.Name = "Button4"
        Button4.Size = New Size(158, 32)
        Button4.TabIndex = 12
        Button4.Text = "Reservation"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans", 10.75F, FontStyle.Bold)
        Label2.Location = New Point(239, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 17)
        Label2.TabIndex = 16
        Label2.Text = "Current Guest/s:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans", 10.75F, FontStyle.Bold)
        Label3.Location = New Point(233, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 17)
        Label3.TabIndex = 17
        Label3.Text = "Available Rooms:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans", 10.75F, FontStyle.Bold)
        Label4.Location = New Point(232, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 17)
        Label4.TabIndex = 18
        Label4.Text = "Occupied Rooms:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans", 16.25F, FontStyle.Bold)
        Label5.Location = New Point(233, 23)
        Label5.Name = "Label5"
        Label5.Size = New Size(130, 25)
        Label5.TabIndex = 19
        Label5.Text = "OVERVIEW"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Sans", 10.75F, FontStyle.Bold)
        Label6.Location = New Point(238, 136)
        Label6.Name = "Label6"
        Label6.Size = New Size(135, 17)
        Label6.TabIndex = 20
        Label6.Text = "Recent Check-in:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans", 10.75F, FontStyle.Bold)
        Label7.Location = New Point(479, 136)
        Label7.Name = "Label7"
        Label7.Size = New Size(148, 17)
        Label7.TabIndex = 21
        Label7.Text = "Recent Check-out:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(239, 166)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(174, 126)
        DataGridView1.TabIndex = 22
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = SystemColors.ButtonFace
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(479, 166)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(175, 126)
        DataGridView2.TabIndex = 23
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(678, 316)
        Controls.Add(DataGridView2)
        Controls.Add(DataGridView1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button6)
        Controls.Add(Label1)
        Name = "AdminForm"
        Text = "AdminForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
End Class
