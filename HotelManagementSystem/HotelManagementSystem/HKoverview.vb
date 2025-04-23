Public Class HKoverview

    Private hkBindingSource As New BindingSource()
    Private itemBindingSource As New BindingSource()

    Private Sub HKoverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not DbCon.OpenConnection() Then Exit Sub
        DbCon.hkSet()
        DbCon.itemsSet()

        ' Bind housekeeping data to DataGridView1
        If DbCon.accountDataSet.Tables("HouseKeepingTbl") IsNot Nothing Then
            Dim housekeepingTable As New DataTable()
            housekeepingTable.Columns.Add("roomChores")
            housekeepingTable.Columns.Add("StaffAssigned")
            housekeepingTable.Columns.Add("StartDate")
            housekeepingTable.Columns.Add("EndDate")
            housekeepingTable.Columns.Add("roomNum")
            housekeepingTable.Columns.Add("Status")

            For Each row As DataRow In DbCon.accountDataSet.Tables("HouseKeepingTbl").Rows
                housekeepingTable.Rows.Add(
                row("roomChores"),
                row("StaffAssigned"),
                row("StartDate"),
                row("EndDate"),
                row("roomNum"),
                row("Status")
            )
            Next

            DataGridView1.DataSource = housekeepingTable
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Optional: Rename headers for housekeeping
            With DataGridView1
                .Columns("roomChores").HeaderText = "Task"
                .Columns("StaffAssigned").HeaderText = "Assigned"
                .Columns("StartDate").HeaderText = "Start"
                .Columns("EndDate").HeaderText = "End"
                .Columns("roomNum").HeaderText = "Room"
                .Columns("Status").HeaderText = "Status"
            End With
        End If

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

            DataGridView2.DataSource = itemTable
            DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Optional: Rename headers for item details
            With DataGridView2
                .Columns("itemName").HeaderText = "Item Name"
                .Columns("itemUnit").HeaderText = "Unit"
                .Columns("itemQty").HeaderText = "Quantity"
                .Columns("itemReorder").HeaderText = "Reorder Level"
                .Columns("ItemSupplier").HeaderText = "Supplier"
            End With
        End If

        DbCon.CloseConnection1()
    End Sub


    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim hksup As New HKsupervisor
        hksup.Show()
        Me.Hide()
    End Sub

End Class
