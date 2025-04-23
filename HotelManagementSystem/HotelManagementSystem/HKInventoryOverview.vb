Public Class HKInventoryOverview

    Private itemBindingSource As New BindingSource()

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim hksupervisorform As New HKsupervisor
        hksupervisorform.Show()
        Me.Hide()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim hkinv As New HKinventory
        hkinv.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub HKInventoryOverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not DbCon.OpenConnection() Then Exit Sub
        DbCon.itemsSet()

        ' Bind item data to DataGridView2
        If DbCon.accountDataSet.Tables("itemDetailsTbl") IsNot Nothing Then
            Dim itemTable As New DataTable()
            itemTable.Columns.Add("itemName")
            itemTable.Columns.Add("itemUnit")
            itemTable.Columns.Add("itemQty")
            itemTable.Columns.Add("itemReorder")
            itemTable.Columns.Add("ItemSupplier")

            For Each row As DataRow In DbCon.accountDataSet.Tables("itemDetailsTbl").Rows
                itemTable.Rows.Add(
                row("itemName"),
                row("itemUnit"),
                row("itemQty"),
                row("itemReorder"),
                row("ItemSupplier")
            )
            Next

            DataGridView1.DataSource = itemTable
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Optional: Rename headers for item details
            With DataGridView1
                .Columns("itemName").HeaderText = "Item Name"
                .Columns("itemUnit").HeaderText = "Unit"
                .Columns("itemQty").HeaderText = "Quantity"
                .Columns("itemReorder").HeaderText = "Reorder Level"
                .Columns("ItemSupplier").HeaderText = "Supplier"
            End With
        End If

        DbCon.CloseConnection1()
    End Sub
End Class