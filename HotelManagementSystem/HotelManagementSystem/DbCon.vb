Imports System.Data.OleDb

Module DbCon

    '"C:\Users\Jec\Documents\GitHub\HotelMan\HotelManagementSystem\HotelManagementDB.accdb"
    '"C:\Users\paulj\OneDrive\Documents\GitHub\HotelMan\HotelManagementSystem\HotelManagementDB.accdb"
    '"C:\Users\Jec\Desktop\HotelManagementSystem\HotelManagementDB.accdb"
    'C:\Users\Jec\Desktop\.net\HotelManagementSystem
    'C:\Users\User\Desktop\HotelManagementSystem
    'C:\Users\Jec\Desktop\Test\HotelManagementSystem\HotelManagementDB.accdb

    Private connection1 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jec\Desktop\Test\HotelManagementSystem\HotelManagementDB.accdb"

    Public oledbCnn1 As OleDbConnection
    Public oledbAdapterAccounts As OleDbDataAdapter
    Public drow As DataRow
    Public accountDataSet As New DataSet
    Public roomDataSet As New DataSet
    Public sql As String

    Public Function OpenConnection() As Boolean
        oledbCnn1 = New OleDbConnection(connection1)
        Try
            oledbCnn1.Open()
        Catch ex As Exception
            MessageBox.Show($"Failed to connect to the first database: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function
    Public Sub accountSet()
        Try
            sql = "SELECT * FROM AccountsTbl"
            oledbAdapterAccounts = New OleDbDataAdapter(sql, oledbCnn1)
            oledbAdapterAccounts.Fill(accountDataSet, "AccountsTbl")

        Catch ex As Exception
            MessageBox.Show($"Error loading HotelManagementDB: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub guestSet()
        Try
            sql = "SELECT * FROM GuestTbl"
            oledbAdapterAccounts = New OleDbDataAdapter(sql, oledbCnn1)
            oledbAdapterAccounts.Fill(accountDataSet, "GuestTbl")
        Catch ex As Exception
            MessageBox.Show($"Error loading HotelManagementDB: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub roomsSet()
        Try
            If accountDataSet.Tables.Contains("RoomTbl") Then
                accountDataSet.Tables("RoomTbl").Clear()
            End If

            Dim query As String = "SELECT * FROM RoomTbl"
            Dim adapter As New OleDbDataAdapter(query, oledbCnn1)
            adapter.Fill(accountDataSet, "RoomTbl")

        Catch ex As Exception
            MessageBox.Show("Error loading RoomTbl: " & ex.Message)
        End Try
    End Sub

    Public Sub bookedSet()
        Try
            sql = "SELECT * FROM BookedTbl"
            oledbAdapterAccounts = New OleDbDataAdapter(sql, oledbCnn1)
            oledbAdapterAccounts.Fill(accountDataSet, "BookedTbl")
        Catch ex As Exception
            MessageBox.Show($"Error loading HotelManagementDB: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub hkSet()
        Try
            ' Clear existing table if already loaded
            If accountDataSet.Tables.Contains("HousekeepingTbl") Then
                accountDataSet.Tables("HousekeepingTbl").Clear()
            End If

            ' Load fresh data from HouseKeepingTbl
            sql = "SELECT * FROM HousekeepingTbl"
            oledbAdapterAccounts = New OleDbDataAdapter(sql, oledbCnn1)
            oledbAdapterAccounts.Fill(accountDataSet, "HousekeepingTbl")

        Catch ex As Exception
            MessageBox.Show($"Error loading HousekeepingTbl: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub itemsSet()
        Try
            ' Clear existing table if already loaded
            If accountDataSet.Tables.Contains("itemDetailsTbl") Then
                accountDataSet.Tables("itemDetailsTbl").Clear()
            End If

            ' Load fresh data from HouseKeepingTbl
            sql = "SELECT * FROM itemDetailsTbl"
            oledbAdapterAccounts = New OleDbDataAdapter(sql, oledbCnn1)
            oledbAdapterAccounts.Fill(accountDataSet, "itemDetailsTbl")

        Catch ex As Exception
            MessageBox.Show($"Error loading itemDetailsTbl: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub CloseConnection1()
        If oledbCnn1 IsNot Nothing AndAlso oledbCnn1.State = ConnectionState.Open Then
            oledbCnn1.Close()
        End If
    End Sub

    Public Sub BuilderConn(ByVal b As OleDbDataAdapter)
        Dim builder As New OleDbCommandBuilder(b)
        builder.GetUpdateCommand()
        builder.ConflictOption = ConflictOption.OverwriteChanges
    End Sub

End Module