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
        cboItemCat = New ComboBox()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnAdd = New Button()
        Label1 = New Label()
        btnDelete = New Button()
        btnEdit = New Button()
        txtItemName = New TextBox()
        txtQty = New TextBox()
        btnBack = New Button()
        Label7 = New Label()
        txtSupplier = New TextBox()
        cboCat = New ComboBox()
        Label8 = New Label()
        txtItemUnit = New TextBox()
        btnSave = New Button()
        ListView1 = New ListView()
        SuspendLayout()
        ' 
        ' cboItemCat
        ' 
        cboItemCat.FormattingEnabled = True
        cboItemCat.Items.AddRange(New Object() {"All", "Cleaning Supplies", "Equipment", "Linens"})
        cboItemCat.Location = New Point(146, 50)
        cboItemCat.Name = "cboItemCat"
        cboItemCat.Size = New Size(81, 23)
        cboItemCat.TabIndex = 21
        cboItemCat.Text = "All"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15F)
        Label6.Location = New Point(358, 95)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 28)
        Label6.TabIndex = 19
        Label6.Text = "Category:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15F)
        Label5.Location = New Point(358, 123)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 28)
        Label5.TabIndex = 18
        Label5.Text = "Item name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(358, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 28)
        Label3.TabIndex = 16
        Label3.Text = "Quantity:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(440, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 28)
        Label2.TabIndex = 15
        Label2.Text = "Item Details"
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 10F)
        btnAdd.Location = New Point(228, 263)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(93, 28)
        btnAdd.TabIndex = 13
        btnAdd.Text = "Add Supply"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(34, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 28)
        Label1.TabIndex = 12
        Label1.Text = "Inventory"
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 10F)
        btnDelete.Location = New Point(570, 263)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(93, 28)
        btnDelete.TabIndex = 22
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Segoe UI", 10F)
        btnEdit.Location = New Point(373, 263)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(93, 28)
        btnEdit.TabIndex = 23
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' txtItemName
        ' 
        txtItemName.Location = New Point(513, 127)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(150, 23)
        txtItemName.TabIndex = 24
        txtItemName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtQty
        ' 
        txtQty.Location = New Point(513, 186)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(150, 23)
        txtQty.TabIndex = 26
        txtQty.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(34, 268)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 28
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15F)
        Label7.Location = New Point(358, 211)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 28)
        Label7.TabIndex = 29
        Label7.Text = "Supplier:"
        ' 
        ' txtSupplier
        ' 
        txtSupplier.Location = New Point(513, 213)
        txtSupplier.Name = "txtSupplier"
        txtSupplier.Size = New Size(150, 23)
        txtSupplier.TabIndex = 30
        txtSupplier.TextAlign = HorizontalAlignment.Center
        ' 
        ' cboCat
        ' 
        cboCat.FormattingEnabled = True
        cboCat.Location = New Point(513, 98)
        cboCat.Name = "cboCat"
        cboCat.Size = New Size(150, 23)
        cboCat.TabIndex = 31
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15F)
        Label8.Location = New Point(358, 152)
        Label8.Name = "Label8"
        Label8.Size = New Size(53, 28)
        Label8.TabIndex = 33
        Label8.Text = "Unit:"
        ' 
        ' txtItemUnit
        ' 
        txtItemUnit.Location = New Point(513, 157)
        txtItemUnit.Name = "txtItemUnit"
        txtItemUnit.Size = New Size(150, 23)
        txtItemUnit.TabIndex = 34
        txtItemUnit.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 10F)
        btnSave.Location = New Point(471, 263)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(93, 28)
        btnSave.TabIndex = 35
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(34, 83)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(287, 156)
        ListView1.TabIndex = 36
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' HKinventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 314)
        Controls.Add(ListView1)
        Controls.Add(btnSave)
        Controls.Add(txtItemUnit)
        Controls.Add(Label8)
        Controls.Add(cboCat)
        Controls.Add(txtSupplier)
        Controls.Add(Label7)
        Controls.Add(btnBack)
        Controls.Add(txtQty)
        Controls.Add(txtItemName)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(cboItemCat)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnAdd)
        Controls.Add(Label1)
        Name = "HKinventory"
        Text = "HKinventory"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboItemCat As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents cboCat As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtItemUnit As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents ListView1 As ListView
End Class
