Imports System.Data.OleDb

Public Class PaymentdetailsFrm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PaymentdetailsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate PaymentMethod ComboBox
        cmbPaymentMethod.Items.Add("Cash")
        cmbPaymentMethod.Items.Add("Credit Card")
        cmbPaymentMethod.Items.Add("Debit Card")
        cmbPaymentMethod.Items.Add("Online Payment")
        cmbPaymentMethod.SelectedIndex = 0 ' Default selection

        ' Populate Status ComboBox
        cmbStatus.Items.Add("Pending")
        cmbStatus.Items.Add("Paid")
        cmbStatus.Items.Add("Cancelled")
        cmbStatus.SelectedIndex = 0 ' Default selection
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        If Not OpenConnection() Then Exit Sub

        Dim paymentQuery As String = "INSERT INTO paymentTbl (guestID, roomNo, guestName, paymentMethod, status, amountPaid, paymentDate) " &
                                     "VALUES (@guestID, @roomNo, @guestName, @paymentMethod, @status, @amountPaid, @paymentDate)"
        Dim cmdPayment As New OleDbCommand(paymentQuery, oledbCnn1)
        cmdPayment.Parameters.AddWithValue("@guestID", txtGuestID.Text)
        cmdPayment.Parameters.AddWithValue("@roomNo", txtRoomNo.Text)
        cmdPayment.Parameters.AddWithValue("@guestName", txtGuestName.Text)
        cmdPayment.Parameters.AddWithValue("@paymentMethod", cmbPaymentMethod.SelectedItem.ToString())
        cmdPayment.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString())
        cmdPayment.Parameters.AddWithValue("@amountPaid", txtAmountPaid.Text)
        cmdPayment.Parameters.AddWithValue("@paymentDate", dtpPaymentDate.Value)

        Try
            cmdPayment.ExecuteNonQuery()
            MessageBox.Show("Payment Recorded Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection1()
        End Try
    End Sub
End Class