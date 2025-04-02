Imports System.Data.OleDb

Public Class HKAddSchedule

    ' Event handlers for text changes (if needed)
    Private Sub txtStaff_TextChanged(sender As Object, e As EventArgs) Handles txtStaff.TextChanged
    End Sub

    Private Sub txtRoomtype_TextChanged(sender As Object, e As EventArgs) Handles txtRoomtype.TextChanged
    End Sub

    Private Sub txtRoomnumber_TextChanged(sender As Object, e As EventArgs) Handles txtRoomnumber.TextChanged
    End Sub

    Private Sub txtChores_TextChanged(sender As Object, e As EventArgs) Handles txtChores.TextChanged
    End Sub

    Private Sub txtStatus_TextChanged(sender As Object, e As EventArgs) Handles txtStatus.TextChanged
    End Sub

    Private Sub dtpStartdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartdate.ValueChanged
    End Sub

    Private Sub dtpEnddate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEnddate.ValueChanged
    End Sub

    ' Button click event to add a new schedule
    Private Sub btnAddSched_Click(sender As Object, e As EventArgs) Handles btnAddSched.Click
        ' Validate inputs for required fields
        If String.IsNullOrWhiteSpace(txtRoomtype.Text) OrElse
           String.IsNullOrWhiteSpace(txtRoomnumber.Text) OrElse
           String.IsNullOrWhiteSpace(txtStaff.Text) OrElse
           String.IsNullOrWhiteSpace(txtChores.Text) OrElse
           String.IsNullOrWhiteSpace(txtStatus.Text) Then

            MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validate and parse RoomNumber
        Dim roomNumberVal As Integer
        If Not Integer.TryParse(txtRoomnumber.Text, roomNumberVal) Then
            MessageBox.Show("Room Number must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Open the connection using the DbCon module
            If DbCon.OpenConnection() Then
                ' Define the INSERT SQL using named parameters
                Dim sql As String =
                    "INSERT INTO HouseKeepingTbl " &
                    "([RoomType], [ChoresToDo], [StaffAssigned], [StartDate], [EndDate], [RoomNumber], [Status]) " &
                    "VALUES (@RoomType, @ChoresToDo, @StaffAssigned, @StartDate, @EndDate, @RoomNumber, @Status)"

                Using cmd As New OleDbCommand(sql, DbCon.oledbCnn1)
                    ' Add parameters with explicit types and sizes
                    cmd.Parameters.Add("@RoomType", OleDbType.VarWChar, 50).Value = txtRoomtype.Text
                    cmd.Parameters.Add("@ChoresToDo", OleDbType.VarWChar, 255).Value = txtChores.Text
                    cmd.Parameters.Add("@StaffAssigned", OleDbType.VarWChar, 50).Value = txtStaff.Text
                    cmd.Parameters.Add("@StartDate", OleDbType.Date).Value = dtpStartdate.Value
                    cmd.Parameters.Add("@EndDate", OleDbType.Date).Value = dtpEnddate.Value
                    cmd.Parameters.Add("@RoomNumber", OleDbType.Integer).Value = roomNumberVal
                    cmd.Parameters.Add("@Status", OleDbType.VarWChar, 50).Value = txtStatus.Text

                    ' Execute the command
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Schedule added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim schedulefrm As New HKscheduleFrm
                schedulefrm.Show()
                Me.Close()

            End If
        Catch ex As Exception
            MessageBox.Show("Error adding schedule: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            DbCon.CloseConnection1()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim hkschedfrm As New HKscheduleFrm
        hkschedfrm.Show()
        Me.Hide()
    End Sub
End Class
