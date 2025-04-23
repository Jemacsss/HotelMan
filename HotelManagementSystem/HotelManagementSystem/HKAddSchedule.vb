Imports System.Data.OleDb

Public Class HKAddSchedule

    ' 1) Form Load: populate Staff & RoomNum combos, lock Status, hook events
    Private Sub HKAddSchedule_Load(sender As Object, e As EventArgs) Handles Me.Load
        If DbCon.OpenConnection() Then
            LoadCombo(cboStaff,
                      "SELECT accountID, FName FROM AccountsTbl WHERE lvl = 3",
                      "FName", "accountID")
            LoadCombo(cboRoomNum,
                      "SELECT roomID, roomNum FROM RoomTbl WHERE reservationStatus = 'Available'",
                      "roomNum", "roomID")
            DbCon.CloseConnection1()
        End If

        ' Status fixed to "In Progress"
        cboStatus.Items.Clear()
        cboStatus.Items.Add("In Progress")
        cboStatus.SelectedIndex = 0
        cboStatus.Enabled = False

        ' When a roomNum is picked, auto‐fill txtRoomID
        AddHandler cboRoomNum.SelectedIndexChanged, AddressOf RoomNumChanged
    End Sub

    ' 2) Generic ComboBox loader
    Private Sub LoadCombo(cbo As ComboBox, sql As String, disp As String, val As String)
        Dim dt As New DataTable()
        Using da As New OleDbDataAdapter(sql, DbCon.oledbCnn1)
            da.Fill(dt)
        End Using
        cbo.DataSource = dt
        cbo.DisplayMember = disp
        cbo.ValueMember = val
        cbo.SelectedIndex = -1
    End Sub

    ' 3) Sync selected roomID into textbox
    Private Sub RoomNumChanged(sender As Object, e As EventArgs)
        If cboRoomNum.SelectedIndex >= 0 Then
            txtRoomID.Text = cboRoomNum.SelectedValue.ToString()
        Else
            txtRoomID.Clear()
        End If
    End Sub

    ' 4) Insert new schedule on button click
    Private Sub btnAddSched_Click(sender As Object, e As EventArgs) Handles btnAddSched.Click
        ' validation
        If cboStaff.SelectedIndex < 0 OrElse
           cboRoomNum.SelectedIndex < 0 OrElse
           String.IsNullOrWhiteSpace(txtChores.Text) Then

            MessageBox.Show("Select staff, a room, and enter chores.",
                            "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not DbCon.OpenConnection() Then Return

        Dim sql As String =
            "INSERT INTO HouseKeepingTbl " &
            "(roomID, roomNum, roomChores, StaffAssigned, StartDate, EndDate, Status) " &
            "VALUES (?,?,?,?,?,?,?)"

        Using cmd As New OleDbCommand(sql, DbCon.oledbCnn1)
            ' roomID
            cmd.Parameters.AddWithValue("?", CInt(txtRoomID.Text))
            ' roomNum
            cmd.Parameters.AddWithValue("?", cboRoomNum.Text)
            ' chores
            cmd.Parameters.AddWithValue("?", txtChores.Text.Trim())
            ' staff
            cmd.Parameters.AddWithValue("?", cboStaff.Text)
            ' dates
            cmd.Parameters.AddWithValue("?", dtpStartdate.Value.Date)
            cmd.Parameters.AddWithValue("?", dtpEnddate.Value.Date)
            ' status
            cmd.Parameters.AddWithValue("?", cboStatus.Text)
            cmd.ExecuteNonQuery()
        End Using

        DbCon.CloseConnection1()

        MessageBox.Show("Schedule added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim schedForm As New HKscheduleFrm()
        schedForm.Show()
        Me.Close()
    End Sub

    ' 5) Back button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim schedForm As New HKscheduleFrm()
        schedForm.Show()
        Me.Close()
    End Sub

End Class
