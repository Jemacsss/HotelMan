<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hkAddItem
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
        txtItemUnit = New TextBox()
        Label8 = New Label()
        cboCat = New ComboBox()
        txtSupplier = New TextBox()
        Label7 = New Label()
        txtQty = New TextBox()
        txtItemName = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnAdd = New Button()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' txtItemUnit
        ' 
        txtItemUnit.Location = New Point(178, 121)
        txtItemUnit.Name = "txtItemUnit"
        txtItemUnit.Size = New Size(150, 23)
        txtItemUnit.TabIndex = 45
        txtItemUnit.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15F)
        Label8.Location = New Point(23, 116)
        Label8.Name = "Label8"
        Label8.Size = New Size(53, 28)
        Label8.TabIndex = 44
        Label8.Text = "Unit:"
        ' 
        ' cboCat
        ' 
        cboCat.FormattingEnabled = True
        cboCat.Location = New Point(178, 62)
        cboCat.Name = "cboCat"
        cboCat.Size = New Size(150, 23)
        cboCat.TabIndex = 43
        ' 
        ' txtSupplier
        ' 
        txtSupplier.Location = New Point(178, 177)
        txtSupplier.Name = "txtSupplier"
        txtSupplier.Size = New Size(150, 23)
        txtSupplier.TabIndex = 42
        txtSupplier.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15F)
        Label7.Location = New Point(23, 175)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 28)
        Label7.TabIndex = 41
        Label7.Text = "Supplier:"
        ' 
        ' txtQty
        ' 
        txtQty.Location = New Point(178, 150)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(150, 23)
        txtQty.TabIndex = 40
        txtQty.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtItemName
        ' 
        txtItemName.Location = New Point(178, 91)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(150, 23)
        txtItemName.TabIndex = 39
        txtItemName.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15F)
        Label6.Location = New Point(23, 59)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 28)
        Label6.TabIndex = 38
        Label6.Text = "Category:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15F)
        Label5.Location = New Point(23, 87)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 28)
        Label5.TabIndex = 37
        Label5.Text = "Item name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(23, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 28)
        Label3.TabIndex = 36
        Label3.Text = "Quantity:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(23, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 28)
        Label2.TabIndex = 35
        Label2.Text = "Add Item"
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 10F)
        btnAdd.Location = New Point(26, 252)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(93, 32)
        btnAdd.TabIndex = 46
        btnAdd.Text = "Add Supply"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(246, 252)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(82, 32)
        btnBack.TabIndex = 47
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' hkAddItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(374, 321)
        Controls.Add(btnBack)
        Controls.Add(btnAdd)
        Controls.Add(txtItemUnit)
        Controls.Add(Label8)
        Controls.Add(cboCat)
        Controls.Add(txtSupplier)
        Controls.Add(Label7)
        Controls.Add(txtQty)
        Controls.Add(txtItemName)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "hkAddItem"
        Text = "hkAddItem"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtItemUnit As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboCat As ComboBox
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBack As Button
End Class
