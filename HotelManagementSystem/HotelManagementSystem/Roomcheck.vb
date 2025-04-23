Imports System.Data.OleDb

Public Class Roomcheck

    Private roomtable As DataTable

    Private Sub Roomcheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OpenConnection() Then
            roomsSet() ' Load initial data
            LoadRoomData()
            CloseConnection1()
        End If
    End Sub

    Private Sub LoadRoomData()
        Try
            ' Refresh dataset first
            If OpenConnection() Then
                roomsSet() ' Repopulate dataset RoomTbl
                CloseConnection1()
            End If

            If accountDataSet.Tables.Contains("RoomTbl") Then
                roomtable = accountDataSet.Tables("RoomTbl")
                DataGridView1.DataSource = roomtable
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Else
                MessageBox.Show("RoomTbl not found in dataset.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading room data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim frm As New RoomDetail With {
            .EditMode = False
        }
        frm.ShowDialog()
        LoadRoomData() ' Refresh after adding
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If DataGridView1.CurrentRow IsNot Nothing Then
            Dim selectedRoomNum As String = DataGridView1.CurrentRow.Cells("roomNum").Value.ToString()

            Dim frm As New RoomDetail With {
                .EditMode = True,
                .EditingRoomNum = selectedRoomNum
            }
            frm.ShowDialog()
            LoadRoomData() ' Refresh after editing
        Else
            MessageBox.Show("Please select a room to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        If DataGridView1.CurrentRow IsNot Nothing Then
            Dim selectedRoomNum As String = DataGridView1.CurrentRow.Cells("roomNum").Value.ToString()
            Dim result = MessageBox.Show("Are you sure you want to delete this room?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                If DbCon.OpenConnection() Then
                    Dim query As String = "DELETE FROM RoomTbl WHERE roomNum = @roomNum"
                    Using cmd As New OleDbCommand(query, DbCon.oledbCnn1)
                        cmd.Parameters.AddWithValue("@roomNum", selectedRoomNum)
                        cmd.ExecuteNonQuery()
                    End Using
                    DbCon.CloseConnection1()
                    MessageBox.Show("Room deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadRoomData() ' Refresh list after deletion
                End If
            End If
        Else
            MessageBox.Show("Please select a room to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Manager.Show()
        Me.Close()
    End Sub
End Class
