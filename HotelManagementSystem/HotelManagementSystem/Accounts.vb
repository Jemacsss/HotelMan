Imports System.Runtime.ConstrainedExecution

Public Class Accounts

    Dim op, op1 As Integer
    Dim st, sr As String
    Dim username As String
    Dim crt As Integer
    Dim isDirty As Boolean = False

    Private Sub Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accountDataSet.Clear()
        accountSet()
        displayUsers()
        AddHandler txtFname.TextChanged, AddressOf MarkDirty
        AddHandler txtLname.TextChanged, AddressOf MarkDirty
        AddHandler txtUser.TextChanged, AddressOf MarkDirty
        AddHandler txtPass.TextChanged, AddressOf MarkDirty
        AddHandler cboPos.SelectedIndexChanged, AddressOf MarkDirty
        AddHandler cboPos.TextChanged, AddressOf MarkDirty

        ' Disable textboxes and combobox initially
        EnableUserInfoFields(False)

        ' Set password char for password textbox
        txtPass.PasswordChar = "*"c

        ' Add position items if not already added
        If cboPos.Items.Count = 0 Then
            cboPos.Items.AddRange(New String() {"Manager", "Housekeeping Supervisor", "Frontdesk", "Housekeeping"})
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Manager.Show()
        Me.Hide()
    End Sub

    Private Sub lsbUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsbUsers.SelectedIndexChanged
        If lsbUsers.SelectedIndex = -1 Then Exit Sub
        Dim selectedName As String = lsbUsers.SelectedItem.ToString()
        For ctr As Integer = 0 To accountDataSet.Tables("AccountsTbl").Rows.Count - 1
            Dim drow As DataRow = accountDataSet.Tables("AccountsTbl").Rows(ctr)
            Dim fullName As String = drow("Fname").ToString() & " " & drow("Lname").ToString()

            If fullName = selectedName Then

                txtFname.Text = drow("Fname").ToString()
                txtLname.Text = drow("Lname").ToString()
                txtUser.Text = drow("Uname").ToString()
                txtPass.Text = drow("Pass").ToString()
                cboPos.Text = drow("Pos").ToString()
                op1 = ctr
                Exit For
            End If
        Next

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        lsbUsers.Items.Clear()
        op = 0
        st = txtSearch.Text

        For ctr = 0 To accountDataSet.Tables("AccountsTbl").Rows.Count - 1
            drow = accountDataSet.Tables("AccountsTbl").Rows(ctr)
            sr = drow("Fname").ToString() & " " & drow("Lname").ToString()

            If sr.IndexOf(st, StringComparison.OrdinalIgnoreCase) <> -1 Then
                lsbUsers.Items.Add(sr)
                op = 1
            End If
        Next

        If op = 0 Then
            displayUsers()
            MessageBox.Show("User account not found", "Error", MessageBoxButtons.OK)
            txtSearch.Focus()
            txtSearch.Text = ""
        End If

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If lsbUsers.SelectedIndex = -1 Then
            MessageBox.Show("Please select an account to delete.", "Error", MessageBoxButtons.OK)
            Exit Sub
        End If

        If MessageBox.Show("Do you want to delete this account?", "Delete Account", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                accountDataSet.Tables("AccountsTbl").Rows(op1).Delete()
                BuilderConn(oledbAdapterAccounts)
                oledbAdapterAccounts.Update(accountDataSet, "AccountsTbl")
                MessageBox.Show("User account successfully deleted!", "Information", MessageBoxButtons.OK)
                clearRecord()
            Catch ex As Exception
                MessageBox.Show("Error deleting account: " & ex.Message, "Error", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        accountDataSet.Clear()
        accountSet()
        If btnAdd.Text = "Add" Then
            clearRecord()
            EnableUserInfoFields(True)
            ShowPassword(True) ' show password when adding
            btnAdd.Text = "Save"
        ElseIf btnAdd.Text = "Save" Then
            ' validation checks here...

            If txtFname.Text.Trim() = "" Then
                MessageBox.Show("Fill up the First Name!", "Error", MessageBoxButtons.OK)
                ' ... [other checks remain the same]
            Else
                ' Adding user
                op = 0
                searchRecord()
                If op = 0 Then
                    Dim drow As DataRow = accountDataSet.Tables("AccountsTbl").NewRow
                    drow("Fname") = txtFname.Text.Trim()
                    drow("Lname") = txtLname.Text.Trim()
                    drow("Uname") = txtUser.Text.Trim()
                    drow("Pass") = txtPass.Text.Trim()
                    drow("Pos") = cboPos.Text.Trim()
                    drow("Lvl") = GetAccountLevel(cboPos.Text.Trim())

                    accountDataSet.Tables("AccountsTbl").Rows.Add(drow)
                    BuilderConn(oledbAdapterAccounts)
                    oledbAdapterAccounts.Update(accountDataSet, "AccountsTbl")
                    MessageBox.Show("User account successfully added!", "Information", MessageBoxButtons.OK)

                    btnAdd.Text = "Add"
                    clearRecord()
                    EnableUserInfoFields(False)
                    ShowPassword(False) ' hide password after saving
                End If
            End If
        End If
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If btnUpdate.Text = "Update" Then
            If lsbUsers.SelectedIndex = -1 Then
                MessageBox.Show("Please select an account to update.", "Error", MessageBoxButtons.OK)
                Exit Sub
            End If

            EnableUserInfoFields(True)
            ShowPassword(True) ' show password when updating
            btnUpdate.Text = "Save"
            isDirty = False

        ElseIf btnUpdate.Text = "Save" Then
            If Not isDirty Then
                MessageBox.Show("No changes detected.", "Information", MessageBoxButtons.OK)
                Exit Sub
            End If

            If txtFname.Text.Trim() = "" Or txtLname.Text.Trim() = "" Or txtUser.Text.Trim() = "" Or txtPass.Text.Trim() = "" Or cboPos.Text.Trim() = "" Then
                MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK)
                Exit Sub
            End If

            ' Update data
            Dim drow As DataRow = accountDataSet.Tables("AccountsTbl").Rows(op1)
            drow("Fname") = txtFname.Text.Trim()
            drow("Lname") = txtLname.Text.Trim()
            drow("Uname") = txtUser.Text.Trim()
            drow("Pass") = txtPass.Text.Trim()
            drow("Pos") = cboPos.Text.Trim()
            drow("Lvl") = GetAccountLevel(cboPos.Text.Trim())

            Try
                BuilderConn(oledbAdapterAccounts)
                oledbAdapterAccounts.Update(accountDataSet, "AccountsTbl")
                MessageBox.Show("User account successfully updated!", "Information", MessageBoxButtons.OK)
                clearRecord()
                EnableUserInfoFields(False)
                ShowPassword(False) ' hide password after updating
                btnUpdate.Text = "Update"
            Catch ex As Exception
                MessageBox.Show("Error updating account: " & ex.Message, "Error", MessageBoxButtons.OK)
            End Try
        End If
    End Sub


    Sub searchRecord()
        For ctr = 0 To accountDataSet.Tables("AccountsTbl").Rows.Count - 1
            drow = accountDataSet.Tables("AccountsTbl").Rows(ctr)
            If txtUser.Text = drow("Uname") And txtUser.Text <> username Then
                MessageBox.Show("Username already exist", "Error", MessageBoxButtons.OK)
                op = 1
                Exit For
            End If
        Next
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Focus()
        txtSearch.Text = " "
    End Sub

    Sub displayUsers()
        lsbUsers.Items.Clear()
        accountDataSet.Clear()
        accountSet()

        For Each drow As DataRow In accountDataSet.Tables("AccountsTbl").Rows
            Dim fullName As String = drow("Fname").ToString() & " " & drow("Lname").ToString()
            lsbUsers.Items.Add(fullName)
        Next
    End Sub

    Sub clearRecord()
        txtFname.Text = ""
        txtLname.Text = ""
        txtUser.Text = ""
        txtPass.Text = ""
        cboPos.Text = ""
        displayUsers()
        lsbUsers.ClearSelected()
    End Sub

    ' In Accounts.vb (or wherever GetAccountLevel is declared)
    Public Function GetAccountLevel(position As String) As Integer
        Select Case position
            Case "Manager"
                Return 0
            Case "Housekeeping Supervisor"
                Return 1
            Case "Frontdesk"
                Return 2
            Case "Housekeeping"
                Return 3
            Case Else
                ' Default for unknown positions
                Return -1
        End Select
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clearRecord()
        EnableUserInfoFields(False)
        btnAdd.Text = "Add"
        btnUpdate.Text = "Update"
        isDirty = False
        ShowPassword(False) ' always hide when canceling
    End Sub


    Sub EnableUserInfoFields(state As Boolean)
        txtFname.Enabled = state
        txtLname.Enabled = state
        txtUser.Enabled = state
        txtPass.Enabled = state
        cboPos.Enabled = state
    End Sub

    Private Sub MarkDirty(sender As Object, e As EventArgs)
        If btnUpdate.Text = "Save" Then
            isDirty = True
        End If
    End Sub

    Sub ShowPassword(state As Boolean)
        If state Then
            txtPass.PasswordChar = ControlChars.NullChar ' shows text
        Else
            txtPass.PasswordChar = "*"c ' masks text
        End If
    End Sub

End Class