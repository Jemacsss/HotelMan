Imports System.Data
Imports System.Data.OleDb

Public Class HKinventory

    Private dtCategories As New DataTable()
    Private dtItems As New DataTable()
    Private currentItemID As Integer

    ' 1) Form load: configure ListView, load categories, select “All”
    Private Sub HKinventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigureListView()
        LoadCategories()
        cboItemCat.SelectedIndex = 0
    End Sub

    ' Configure ListView columns (no IDs)
    Private Sub ConfigureListView()
        With ListView1
            .Clear()
            .View = View.Details
            .FullRowSelect = True
            .Columns.Clear()
            .Columns.Add("Name", 140)
            .Columns.Add("Unit", 80)
            .Columns.Add("Qty", 60)
            .Columns.Add("Supplier", 120)
        End With
    End Sub

    ' 2) Load categories into cboItemCat and cboCat, with “All”
    Private Sub LoadCategories()
        dtCategories.Clear()
        Try
            If DbCon.OpenConnection() Then
                Using da As New OleDbDataAdapter(
                        "SELECT categoryID, categoryName FROM itemCatTbl",
                        DbCon.oledbCnn1)
                    da.Fill(dtCategories)
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DbCon.CloseConnection1()
        End Try

        ' Insert “All” at top
        Dim drAll = dtCategories.NewRow()
        drAll("categoryID") = 0
        drAll("categoryName") = "All"
        dtCategories.Rows.InsertAt(drAll, 0)

        cboItemCat.DataSource = dtCategories
        cboItemCat.DisplayMember = "categoryName"
        cboItemCat.ValueMember = "categoryID"

        ' Detail category ComboBox – read‑only
        cboCat.DataSource = dtCategories.Copy()
        cboCat.DisplayMember = "categoryName"
        cboCat.ValueMember = "categoryID"
        cboCat.Enabled = False
    End Sub

    ' 3) When filter changes, reload items
    Private Sub cboItemCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItemCat.SelectedIndexChanged
        LoadItemsByCategory()
    End Sub

    Private Sub LoadItemsByCategory()
        dtItems.Clear()
        Try
            If Not DbCon.OpenConnection() Then Return

            Dim sql As String =
                "SELECT itemID, categoryID, itemName, itemUnit, itemQty, itemSupplier " &
                "FROM itemDetailsTbl"

            ' Get selected categoryID reliably
            Dim catID As Integer = 0
            If cboItemCat.SelectedValue IsNot Nothing AndAlso
               Integer.TryParse(cboItemCat.SelectedValue.ToString(), catID) AndAlso catID > 0 Then
                sql &= " WHERE categoryID = @cat"
            End If

            Using cmd As New OleDbCommand(sql, DbCon.oledbCnn1)
                If catID > 0 Then
                    cmd.Parameters.AddWithValue("@cat", catID)
                End If
                Using da As New OleDbDataAdapter(cmd)
                    da.Fill(dtItems)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading items: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DbCon.CloseConnection1()
        End Try

        ' Populate ListView
        ListView1.Items.Clear()
        For Each row As DataRow In dtItems.Rows
            Dim lvi = New ListViewItem(row("itemName").ToString()) With {.Tag = row}
            lvi.SubItems.Add(row("itemUnit").ToString())
            lvi.SubItems.Add(row("itemQty").ToString())
            lvi.SubItems.Add(row("itemSupplier").ToString())
            ListView1.Items.Add(lvi)
        Next

        ClearDetailFields()
        LockDetailControls()
    End Sub

    ' 4) Clear & lock detail controls
    Private Sub ClearDetailFields()
        currentItemID = 0
        cboCat.SelectedIndex = -1
        txtItemName.Clear()
        txtItemUnit.Clear()
        txtQty.Clear()
        txtSupplier.Clear()
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub LockDetailControls()
        cboCat.Enabled = False
        txtItemName.Enabled = False
        txtItemUnit.Enabled = False
        txtQty.Enabled = False
        txtSupplier.Enabled = False
    End Sub

    Private Sub UnlockDetailControls()
        txtItemName.Enabled = True
        txtItemUnit.Enabled = True
        txtQty.Enabled = True
        txtSupplier.Enabled = True
        btnSave.Enabled = True
    End Sub

    ' 5) Show details when an item is selected
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count = 0 Then
            ClearDetailFields() : Return
        End If

        Dim row = CType(ListView1.SelectedItems(0).Tag, DataRow)
        currentItemID = CInt(row("itemID"))

        cboCat.SelectedValue = CInt(row("categoryID"))
        txtItemName.Text = row("itemName").ToString()
        txtItemUnit.Text = row("itemUnit").ToString()
        txtQty.Text = row("itemQty").ToString()
        txtSupplier.Text = row("itemSupplier").ToString()

        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        LockDetailControls()
    End Sub

    ' 6) Edit – unlock fields
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If currentItemID = 0 Then Return
        UnlockDetailControls()
        btnEdit.Enabled = False
    End Sub

    ' 7) Save edits to database
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim qty As Integer
        If String.IsNullOrWhiteSpace(txtItemName.Text) OrElse
           String.IsNullOrWhiteSpace(txtItemUnit.Text) OrElse
           Not Integer.TryParse(txtQty.Text, qty) OrElse qty < 0 OrElse
           String.IsNullOrWhiteSpace(txtSupplier.Text) Then

            MessageBox.Show("Enter valid Name, Unit, non‑negative Qty, and Supplier.",
                            "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If Not DbCon.OpenConnection() Then Return
            Using cmd As New OleDbCommand(
                    "UPDATE itemDetailsTbl SET categoryID=@cat, itemName=@nm, itemUnit=@ut, itemQty=@qty, itemSupplier=@sup " &
                    "WHERE itemID=@id", DbCon.oledbCnn1)
                cmd.Parameters.AddWithValue("@cat", CInt(cboCat.SelectedValue))
                cmd.Parameters.AddWithValue("@nm", txtItemName.Text.Trim())
                cmd.Parameters.AddWithValue("@ut", txtItemUnit.Text.Trim())
                cmd.Parameters.AddWithValue("@qty", qty)
                cmd.Parameters.AddWithValue("@sup", txtSupplier.Text.Trim())
                cmd.Parameters.AddWithValue("@id", currentItemID)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Item saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving item: " & ex.Message,
                            "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DbCon.CloseConnection1()
        End Try

        LoadItemsByCategory()
    End Sub

    ' 8) Delete item
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If currentItemID = 0 Then Return
        If MessageBox.Show("Delete this item?", "Confirm Delete",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

        Try
            If Not DbCon.OpenConnection() Then Return
            Using cmd As New OleDbCommand("DELETE FROM itemDetailsTbl WHERE itemID=@id", DbCon.oledbCnn1)
                cmd.Parameters.AddWithValue("@id", currentItemID)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Item deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error deleting item: " & ex.Message,
                            "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DbCon.CloseConnection1()
        End Try

        LoadItemsByCategory()
        ClearDetailFields()
    End Sub

    ' 9) Back navigation
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim overview As New HKInventoryOverview()
        overview.Show()
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim add As New hkAddItem()
        add.Show()

    End Sub
End Class
