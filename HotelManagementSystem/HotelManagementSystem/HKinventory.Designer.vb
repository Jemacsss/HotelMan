<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HKinventory
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
        ComboBox1 = New ComboBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        CheckedListBox1 = New CheckedListBox()
        Button1 = New Button()
        Label1 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"All", "Cleaning Supplies", "Equipment", "Linens"})
        ComboBox1.Location = New Point(142, 39)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(81, 23)
        ComboBox1.TabIndex = 21
        ComboBox1.Text = "All"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15F)
        Label6.Location = New Point(348, 152)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 28)
        Label6.TabIndex = 19
        Label6.Text = "Category:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15F)
        Label5.Location = New Point(348, 128)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 28)
        Label5.TabIndex = 18
        Label5.Text = "Item name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(348, 205)
        Label4.Name = "Label4"
        Label4.Size = New Size(158, 28)
        Label4.TabIndex = 17
        Label4.Text = "Item description:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(347, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 28)
        Label3.TabIndex = 16
        Label3.Text = "Quantity:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(348, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 28)
        Label2.TabIndex = 15
        Label2.Text = "Item Details"
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Location = New Point(30, 78)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(299, 202)
        CheckedListBox1.TabIndex = 14
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10F)
        Button1.Location = New Point(348, 299)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 28)
        Button1.TabIndex = 13
        Button1.Text = "Add Supply"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(30, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 28)
        Label1.TabIndex = 12
        Label1.Text = "Inventory"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 10F)
        Button2.Location = New Point(566, 299)
        Button2.Name = "Button2"
        Button2.Size = New Size(93, 28)
        Button2.TabIndex = 22
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 10F)
        Button3.Location = New Point(458, 299)
        Button3.Name = "Button3"
        Button3.Size = New Size(93, 28)
        Button3.TabIndex = 23
        Button3.Text = "Edit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(509, 133)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 23)
        TextBox1.TabIndex = 24
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(509, 156)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 23)
        TextBox2.TabIndex = 25
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(509, 179)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(150, 23)
        TextBox3.TabIndex = 26
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(354, 236)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(305, 23)
        TextBox4.TabIndex = 27
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(30, 304)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 28
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' HKinventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(687, 354)
        Controls.Add(btnBack)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(CheckedListBox1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "HKinventory"
        Text = "HKinventory"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btnBack As Button
End Class
