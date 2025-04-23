Imports System.Data.OleDb

Public Class HKscheduleFrm

    Private currentRec As HousekeepingRecord

    Private Sub HKscheduleFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigureListView()
        LoadHousekeepingList()
        ClearDetails()
        LockDetails()
    End Sub

    ' Configure columns to omit IDs
    Private Sub ConfigureListView()
        With ListView1
            .Clear()
            .View = View.Details
            .FullRowSelect = True
            .Columns.Clear()
            .Columns.Add("Room#", 80)
            .Columns.Add("Chores", 150)
            .Columns.Add("Staff", 100)
            .Columns.Add("Start", 80)
            .Columns.Add("End", 80)
            .Columns.Add("Status", 80)
        End With
    End Sub

    ' Load all records into ListView1 (hiding IDs)
    Private Sub LoadHousekeepingList()
        ListView1.Items.Clear()
        Try
            If Not DbCon.OpenConnection() Then Return
            Const sql As String =
                "SELECT H.hkID, H.roomID, R.roomNum, H.roomChores, " &
                "H.StaffAssigned, H.StartDate, H.EndDate, H.Status " &
                "FROM HousekeepingTbl AS H " &
                "INNER JOIN RoomTbl AS R ON H.roomID = R.roomID"

            Using cmd As New OleDbCommand(sql, DbCon.oledbCnn1),
                  reader As OleDbDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim rec = New HousekeepingRecord With {
                        .hkID = reader.GetInt32(0),
                        .roomID = reader.GetInt32(1),
                        .roomNum = reader.GetString(2),
                        .roomChores = reader.GetString(3),
                        .StaffAssigned = reader.GetString(4),
                        .StartDate = reader.GetDateTime(5),
                        .EndDate = reader.GetDateTime(6),
                        .Status = reader.GetString(7)
                    }
                    ' First column: roomNum, then chores, staff, dates, status
                    Dim lvi = New ListViewItem(rec.roomNum) With {.Tag = rec}
                    lvi.SubItems.Add(rec.roomChores)
                    lvi.SubItems.Add(rec.StaffAssigned)
                    lvi.SubItems.Add(rec.StartDate.ToShortDateString())
                    lvi.SubItems.Add(rec.EndDate.ToShortDateString())
                    lvi.SubItems.Add(rec.Status)
                    ListView1.Items.Add(lvi)
                End While
            End Using

        Catch ex As Exception
            MessageBox.Show("Error retrieving records: " & ex.Message,
                            "Retrieve Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DbCon.CloseConnection1()
        End Try
    End Sub

    Private Sub ClearDetails()
        currentRec = Nothing
        txtRoomID.Clear()
        txtRoomNumber.Clear()
        txtChores.Clear()
        cboStaff.Text = ""
        dtpStartdate.Value = DateTime.Today
        dtpEnddate.Value = DateTime.Today
        cbostatus.Text = ""
        btnEdit.Enabled = False
        BtnSave.Enabled = False
        btnDone.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub LockDetails()
        txtRoomNumber.Enabled = False
        txtChores.Enabled = False
        dtpEnddate.Enabled = False
    End Sub

    Private Sub UnlockDetails()
        txtRoomNumber.Enabled = True
        txtChores.Enabled = True
        dtpEnddate.Enabled = True
        BtnSave.Enabled = True
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count = 0 Then
            ClearDetails() : Return
        End If
        currentRec = CType(ListView1.SelectedItems(0).Tag, HousekeepingRecord)
        With currentRec
            txtRoomID.Text = .roomID.ToString()
            txtRoomNumber.Text = .roomNum
            txtChores.Text = .roomChores
            cboStaff.Text = .StaffAssigned
            dtpStartdate.Value = .StartDate
            dtpEnddate.Value = .EndDate
            cbostatus.Text = .Status
        End With
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnDone.Enabled = (currentRec.Status = "In Progress")
        BtnSave.Enabled = False
        LockDetails()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If currentRec Is Nothing Then Return
        UnlockDetails()
        btnEdit.Enabled = False
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If currentRec Is Nothing Then Return
        If String.IsNullOrWhiteSpace(txtRoomNumber.Text) OrElse
           String.IsNullOrWhiteSpace(txtChores.Text) OrElse
           dtpEnddate.Value.Date < dtpStartdate.Value.Date Then

            MessageBox.Show("Check Room#, Chores & End Date.",
                            "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If Not DbCon.OpenConnection() Then Return
            Dim newRoomID As Integer
            Using cmd1 As New OleDbCommand("SELECT roomID FROM RoomTbl WHERE roomNum = ?", DbCon.oledbCnn1)
                cmd1.Parameters.AddWithValue("?", txtRoomNumber.Text.Trim())
                Dim o = cmd1.ExecuteScalar()
                If o Is Nothing Then Throw New Exception("Room# not found.")
                newRoomID = Convert.ToInt32(o)
            End Using

            Using cmd2 As New OleDbCommand(
                    "UPDATE HousekeepingTbl SET roomID = ?, roomChores = ?, EndDate = ? WHERE hkID = ?", DbCon.oledbCnn1)
                cmd2.Parameters.AddWithValue("?", newRoomID)
                cmd2.Parameters.AddWithValue("?", txtChores.Text.Trim())
                cmd2.Parameters.AddWithValue("?", dtpEnddate.Value.Date)
                cmd2.Parameters.AddWithValue("?", currentRec.hkID)
                cmd2.ExecuteNonQuery()
            End Using

            MessageBox.Show("Record saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving: " & ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DbCon.CloseConnection1()
        End Try

        LoadHousekeepingList()
        ClearDetails()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If currentRec Is Nothing Then Return
        Try
            If Not DbCon.OpenConnection() Then Return
            Using cmd As New OleDbCommand("UPDATE HousekeepingTbl SET Status='Done' WHERE hkID = ?", DbCon.oledbCnn1)
                cmd.Parameters.AddWithValue("?", currentRec.hkID)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Status set to Done.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DbCon.CloseConnection1()
        End Try
        LoadHousekeepingList()
        ClearDetails()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If currentRec Is Nothing Then Return
        If MessageBox.Show("Delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        Try
            If Not DbCon.OpenConnection() Then Return
            Using cmd As New OleDbCommand("DELETE FROM HousekeepingTbl WHERE hkID = ?", DbCon.oledbCnn1)
                cmd.Parameters.AddWithValue("?", currentRec.hkID)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error deleting: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DbCon.CloseConnection1()
        End Try
        LoadHousekeepingList()
        ClearDetails()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Manager.Show()
        Me.Close()
    End Sub

    Private Sub btnHkInventory_Click(sender As Object, e As EventArgs) Handles btnHkInventory.Click
        Dim inv As New HKInventoryOverview()
        inv.Show()
        Me.Close()
    End Sub

    Private Sub btnAddSched_Click(sender As Object, e As EventArgs) Handles btnAddSched.Click
        Dim add As New HKAddSchedule()
        add.Show()
        Me.Close()
    End Sub

End Class

Public Class HousekeepingRecord
    Public Property hkID As Integer
    Public Property roomID As Integer
    Public Property roomNum As String
    Public Property roomChores As String
    Public Property StaffAssigned As String
    Public Property StartDate As DateTime
    Public Property EndDate As DateTime
    Public Property Status As String
    Public Overrides Function ToString() As String
        Return $"[{hkID}] Room {roomNum} – {Status}"
    End Function
End Class
