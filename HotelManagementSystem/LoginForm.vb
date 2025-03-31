Imports System.Data.OleDb
Imports System.Net

Public Class LoginForm
    Dim tryout As Integer = 1
    Dim op As Integer
    Public Shared first, last, username, password As String
    Public Shared Ulevel As Integer

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OpenConnection() Then
            accountSet()
        End If
        txtUsername.Focus()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If tryout < 3 Then
            op = 0
            For ctr = 0 To accountDataSet.Tables("AccountsTbl").Rows.Count - 1
                drow = accountDataSet.Tables("AccountsTbl").Rows(ctr)
                If drow("UName") = txtUsername.Text And drow("Pass") = txtPassword.Text Then
                    first = drow("FName")
                    last = drow("LName")
                    username = drow("UName")
                    password = drow("Pass")

                    Dim dashboard As New AdminForm
                    dashboard.Show()
                    Me.Hide()

                    op = 1

                End If

            Next
            If op = 0 Then
                MessageBox.Show("check your username and password", "Error", MessageBoxButtons.OK)
                tryout += 1
            End If
        Else
            MessageBox.Show("maximum 3 tries only")
            Application.Exit()

        End If
    End Sub
    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub
End Class
