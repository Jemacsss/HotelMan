Imports System.Runtime.ConstrainedExecution

Public Class Accounts

    Dim op, op1 As Integer
    Dim st, sr As String
    Dim username As String
    Dim crt As Integer

    Private Sub Accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accountDataSet.Clear()
        accountSet()
        displayUsers()
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
            'clearRecord()
            btnAdd.Text = "Save"
        ElseIf btnAdd.Text = "Save" Then
            If txtFname.Text = "" Then
                MessageBox.Show("Fill up the First Name!!", "Error", MessageBoxButtons.OK)
            ElseIf txtLname.Text = "" Then
                MessageBox.Show("Fill up the Last Name!!", "Error", MessageBoxButtons.OK)
            ElseIf txtUser.Text = "" Then
                MessageBox.Show("Fill up the Username!!", "Error", MessageBoxButtons.OK)
            ElseIf txtPass.Text = "" Then
                MessageBox.Show("Fill up the Password!!", "Error", MessageBoxButtons.OK)
            ElseIf cboPos.Text = "" Then
                MessageBox.Show("Fill up the Position!!", "Error", MessageBoxButtons.OK)
            Else
                op = 0
                searchRecord()
                If op = 0 Then
                    drow = accountDataSet.Tables("AccountsTbl").NewRow
                    drow("Fname") = txtFname.Text
                    drow("Lname") = txtLname.Text
                    drow("Uname") = txtUser.Text
                    drow("Pass") = txtPass.Text
                    drow("Pos") = cboPos.Text
                    drow("Lvl") = GetAccountLevel(cboPos.Text)

                    accountDataSet.Tables("AccountsTbl").Rows.Add(drow)
                    BuilderConn(oledbAdapterAccounts)
                    oledbAdapterAccounts.Update(accountDataSet, "AccountsTbl")
                    MessageBox.Show("User account Successfully Added!!", "Information", MessageBoxButtons.OK)

                    btnAdd.Text = "Add"
                    clearRecord()
                End If
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If lsbUsers.SelectedIndex = -1 Then
            MessageBox.Show("Please select an account to update.", "Error", MessageBoxButtons.OK)
            Exit Sub
        End If

        If txtFname.Text = "" Or txtLname.Text = "" Or txtUser.Text = "" Or txtPass.Text = "" Or cboPos.Text = "" Then
            MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK)
            Exit Sub
        End If

        Dim drow As DataRow = accountDataSet.Tables("AccountsTbl").Rows(op1)
        drow("Fname") = txtFname.Text
        drow("Lname") = txtLname.Text
        drow("Uname") = txtUser.Text
        drow("Pass") = txtPass.Text
        drow("Pos") = cboPos.Text
        drow("Lvl") = GetAccountLevel(cboPos.Text)

        Try
            BuilderConn(oledbAdapterAccounts)
            oledbAdapterAccounts.Update(accountDataSet, "AccountsTbl")
            MessageBox.Show("User account successfully updated!", "Information", MessageBoxButtons.OK)
            clearRecord()
        Catch ex As Exception
            MessageBox.Show("Error updating account: " & ex.Message, "Error", MessageBoxButtons.OK)
        End Try
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
    End Sub

    Function GetAccountLevel(position As String) As Integer
        Select Case position
            Case "Manager"
                Return 0
            Case "Housekeeping Supervisor"
                Return 1
            Case "Frontdesk"
                Return 2
            Case "Housekeeping"
                Return 3
        End Select
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtFname.Text = ""
        txtLname.Text = ""
        txtUser.Text = ""
        txtPass.Text = ""
        cboPos.Text = ""
    End Sub
End Class