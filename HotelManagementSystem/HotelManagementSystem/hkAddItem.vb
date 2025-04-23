Imports System.Data.OleDb

Public Class HKAddItem

    ' 1) Form Load: populate category ComboBox
    Private Sub HKAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Not DbCon.OpenConnection() Then Return

            Dim dt As New DataTable()
            Using da As New OleDbDataAdapter(
                    "SELECT categoryID, categoryName FROM itemCatTbl",
                    DbCon.oledbCnn1)
                da.Fill(dt)
            End Using

            cboCat.DataSource = dt
            cboCat.DisplayMember = "categoryName"
            cboCat.ValueMember = "categoryID"
            cboCat.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message,
                            "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DbCon.CloseConnection1()
        End Try
    End Sub

    ' 2) Add button: validate inputs and insert into database
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Basic validation
        Dim qty As Integer
        If cboCat.SelectedIndex < 0 Then
            MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf String.IsNullOrWhiteSpace(txtItemName.Text) Then
            MessageBox.Show("Please enter the item name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf String.IsNullOrWhiteSpace(txtItemUnit.Text) Then
            MessageBox.Show("Please enter the unit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf Not Integer.TryParse(txtQty.Text, qty) OrElse qty < 0 Then
            MessageBox.Show("Please enter a non‑negative integer for quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf String.IsNullOrWhiteSpace(txtSupplier.Text) Then
            MessageBox.Show("Please enter the supplier name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Insert into itemDetailsTbl
        Try
            If Not DbCon.OpenConnection() Then Return

            Dim sql As String =
                "INSERT INTO itemDetailsTbl " &
                "(categoryID, itemName, itemUnit, itemQty, itemSupplier) " &
                "VALUES (?,?,?,?,?)"

            Using cmd As New OleDbCommand(sql, DbCon.oledbCnn1)
                cmd.Parameters.AddWithValue("?", CInt(cboCat.SelectedValue))
                cmd.Parameters.AddWithValue("?", txtItemName.Text.Trim())
                cmd.Parameters.AddWithValue("?", txtItemUnit.Text.Trim())
                cmd.Parameters.AddWithValue("?", qty)
                cmd.Parameters.AddWithValue("?", txtSupplier.Text.Trim())

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error adding item: " & ex.Message,
                            "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DbCon.CloseConnection1()
        End Try
    End Sub

    ' 3) Back button: close this form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class
