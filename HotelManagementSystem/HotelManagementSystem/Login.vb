Imports System.Data.OleDb
Imports System.Net
Imports System.Windows.Forms.AxHost

Public Class Login

    Dim tryout As Integer = 1
    Dim op As Integer
    Public Shared first, last, username, password As String
    Public Shared Ulevel As Integer

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OpenConnection() Then
            accountSet()
        End If
        txtUser.Focus()
        Me.BackColor = ColorTranslator.FromHtml("#FAFAFA")
        PanelHeader.BackColor = ColorTranslator.FromHtml("#007C91")

        'LabelHeader.ForeColor = Color.White
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tryout < 3 Then
            Try
                ' Use a query instead of looping through the dataset
                Dim query As String = "SELECT * FROM AccountsTbl WHERE UName = ? AND Pass = ?"
                Dim command As New OleDbCommand(query, oledbCnn1)
                command.Parameters.AddWithValue("?", txtUser.Text)
                command.Parameters.AddWithValue("?", txtPass.Text)

                Dim reader As OleDbDataReader = command.ExecuteReader()

                If reader.Read() Then
                    ' Retrieve user details
                    username = reader("UName").ToString()
                    password = reader("Pass").ToString()
                    Ulevel = Convert.ToInt32(reader("Lvl"))

                    ' Open the appropriate form
                    Select Case Ulevel
                        Case 0
                            Dim Manager As New Manager()
                            Manager.Show()
                        Case 1
                            Dim HKSup As New HKsupervisor()
                            HKSup.Show()
                        Case 2
                            Dim FD As New Frontdesk()
                            Frontdesk.Show()
                        Case 3
                            Dim HK As New Housekeeping()
                            Housekeeping.Show()
                        Case Else
                            MessageBox.Show("Invalid user level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Select

                    Me.Hide() ' Hide the login form

                Else
                    MessageBox.Show("Check your username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tryout += 1
                End If

                reader.Close()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Maximum 3 tries only", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Application.Exit()
        End If
    End Sub
    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

End Class
