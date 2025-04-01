﻿Imports System.Data.OleDb

Module Dbcon
    Private connection1 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C\Documents\GitHub\HotelMan\HotelManagementDB.accdb"

    Public oledbCnn1 As OleDbConnection
    Public oledbAdapterAccounts As OleDbDataAdapter
    Public drow As DataRow
    Public accountDataSet As New DataSet
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
