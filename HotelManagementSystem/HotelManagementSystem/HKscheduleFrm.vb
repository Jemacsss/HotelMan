Imports System.Data.OleDb

' Helper class to hold a housekeeping record.
Public Class HousekeepingRecord
    Public Property ID As Integer
    Public Property RoomNumber As Integer
    Public Property RoomType As String
    Public Property StaffAssigned As String
    Public Property ChoresToDo As String
    Public Property StartDate As DateTime
    Public Property EndDate As DateTime
    Public Property Status As String

    ' Display a summary in the ListBox.
    Public Overrides Function ToString() As String
        Return $"ID: {ID}, Room: {RoomNumber}, Type: {RoomType}, Status: {Status}"
    End Function
End Class

Public Class HKscheduleFrm

    ' When the form loads, ensure a default filter is selected and load the data.
    Private Sub HKscheduleFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure ComboBox1 has a default selection ("All")
        If ComboBox1.SelectedIndex = -1 Then
            ComboBox1.SelectedIndex = 0
        End If
        LoadHousekeepingData()
    End Sub

    ' When the ComboBox selection changes, reload the data.
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        LoadHousekeepingData()
    End Sub

    ' Retrieves data from HouseKeepingTbl and populates ListBox1.
    Private Sub LoadHousekeepingData()
        Try
            ListBox1.Items.Clear()
            Dim sql As String = "SELECT * FROM HouseKeepingTbl"

            ' If filtering is not "All", add a WHERE clause.
            If ComboBox1.SelectedItem.ToString() <> "All" Then
                sql &= " WHERE [Status] = @Status"
            End If

            If DbCon.OpenConnection() Then
                Using cmd As New OleDbCommand(sql, DbCon.oledbCnn1)
                    If ComboBox1.SelectedItem.ToString() <> "All" Then
                        cmd.Parameters.AddWithValue("@Status", ComboBox1.SelectedItem.ToString())
                    End If

                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Create a new record object from the database row.
                            Dim rec As New HousekeepingRecord With {
                                .ID = Convert.ToInt32(reader("ID")),
                                .RoomNumber = Convert.ToInt32(reader("RoomNumber")),
                                .RoomType = reader("RoomType").ToString(),
                                .StaffAssigned = reader("StaffAssigned").ToString(),
                                .ChoresToDo = reader("ChoresToDo").ToString(),
                                .StartDate = Convert.ToDateTime(reader("StartDate")),
                                .EndDate = Convert.ToDateTime(reader("EndDate")),
                                .Status = reader("Status").ToString()
                            }
                            ' Add the record to the ListBox.
                            ListBox1.Items.Add(rec)
                        End While
                    End Using
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DbCon.CloseConnection1()
        End Try
    End Sub

    ' When a record is selected from ListBox1, display its details in the textboxes and date pickers.
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem IsNot Nothing Then
            Dim rec As HousekeepingRecord = DirectCast(ListBox1.SelectedItem, HousekeepingRecord)
            txtRoomtype.Text = rec.RoomType
            txtRoomnumber.Text = rec.RoomNumber.ToString()
            txtStaff.Text = rec.StaffAssigned
            txtChores.Text = rec.ChoresToDo
            dtpStartdate.Value = rec.StartDate
            dtpEnddate.Value = rec.EndDate
            txtStatus.Text = rec.Status
        End If
    End Sub

    ' Navigation button to go back.
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Manager.Show()
        Me.Hide()
    End Sub

    ' Navigation button to open HKinventory form.
    Private Sub btnHkInventory_Click(sender As Object, e As EventArgs) Handles btnHkInventory.Click
        Dim hkinventory As New HKinventory
        hkinventory.Show()
        Me.Close()
    End Sub

    ' Navigation button to open HKAddSchedule form.
    Private Sub btnAddSched_Click(sender As Object, e As EventArgs) Handles btnAddSched.Click
        Dim hkaddsched As New HKAddSchedule
        hkaddsched.Show()
        Me.Close()
    End Sub

End Class
