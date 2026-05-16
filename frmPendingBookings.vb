Imports System.Data.SqlClient
Imports System.IO

Public Class frmPendingBookings

    Private Sub frmPendingBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load only pending bookings when form opens
        LoadPendingBookings()
        dgvPending.AllowUserToAddRows = False
    End Sub

    ' 1. Load Pending Bookings from Database
    Public Sub LoadPendingBookings()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim sql As String = "SELECT BookingID, Username, RoomID, CheckInDate, CheckOutDate, TotalAmount, PaymentStatus, BookingDate " &
                               "FROM Bookings WHERE PaymentStatus = 'Pending' ORDER BY BookingDate ASC"

            Dim cmd As New SqlCommand(sql, conn)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adp.Fill(dt)

            dgvPending.DataSource = dt
            FormatGrid()
            conn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub FormatGrid()
        dgvPending.ReadOnly = True
        dgvPending.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        If dgvPending.Columns.Contains("BookingID") Then dgvPending.Columns("BookingID").Visible = False
    End Sub

    ' 2. Display receipt image when a row is selected
    Private Sub dgvPending_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPending.SelectionChanged
        If dgvPending.SelectedRows.Count > 0 Then
            Dim selectedCell = dgvPending.SelectedRows(0).Cells("BookingID").Value

            If selectedCell IsNot DBNull.Value AndAlso selectedCell IsNot Nothing Then
                Dim bID As Integer = Convert.ToInt32(selectedCell)
                DisplayReceiptImage(bID)
            Else
                picReceipt.Image = Nothing
            End If
        End If
    End Sub

    ' Fetch and display the payment receipt image from DB
    Private Sub DisplayReceiptImage(bookingID As Integer)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim cmd As New SqlCommand("SELECT ReceiptImage FROM Bookings WHERE BookingID = @id", conn)
            cmd.Parameters.AddWithValue("@id", bookingID)

            Dim imgData As Byte() = TryCast(cmd.ExecuteScalar(), Byte())

            If imgData IsNot Nothing Then
                Dim ms As New MemoryStream(imgData)
                picReceipt.Image = Image.FromStream(ms)
            Else
                picReceipt.Image = Nothing
            End If
            conn.Close()
        Catch ex As Exception
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' 3. Approve Button - Approves booking and generates text receipt for customer
    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If dgvPending.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvPending.SelectedRows(0)
            Dim bID As Integer = row.Cells("BookingID").Value
            Dim uName As String = row.Cells("Username").Value.ToString()
            Dim rID As String = row.Cells("RoomID").Value.ToString()
            Dim amount As String = row.Cells("TotalAmount").Value.ToString()

            ' Enhanced professional receipt format
            Dim myReceipt As String = "======================================" & vbCrLf &
                                 "        OFFICIAL HOTEL RECEIPT        " & vbCrLf &
                                 "======================================" & vbCrLf &
                                 "Receipt Number : REC-" & bID & vbCrLf &
                                 "Customer Name  : " & uName & vbCrLf &
                                 "Room Assigned  : Room " & rID & vbCrLf &
                                 "Total Paid     : " & amount & " ETB" & vbCrLf &
                                 "Status         : PAYMENT APPROVED" & vbCrLf &
                                 "Date of Issue  : " & DateTime.Now.ToString("dd/MM/yyyy HH:mm") & vbCrLf &
                                 "======================================" & vbCrLf &
                                 "   Thank you for staying with us!     " & vbCrLf &
                                 "======================================"

            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                ' Updating both the booking status and the generated receipt text
                Dim sql As String = "UPDATE Bookings SET PaymentStatus = 'Approved', ReceiptText = @receipt WHERE BookingID = @id"
                Dim cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@receipt", myReceipt)
                cmd.Parameters.AddWithValue("@id", bID)

                cmd.ExecuteNonQuery()
                MsgBox("Booking successfully approved and receipt generated!", MsgBoxStyle.Information)

                conn.Close()
                LoadPendingBookings() ' Refresh the list
                picReceipt.Image = Nothing ' Clear the proof of payment preview
            Catch ex As Exception
                MsgBox("Approval Error: " & ex.Message, MsgBoxStyle.Critical)
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End If
    End Sub

    ' 4. Reject Button - Rejects booking and makes the room 'Available' again
    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        If dgvPending.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvPending.SelectedRows(0)
            Dim bID As Integer = row.Cells("BookingID").Value
            Dim rID As String = row.Cells("RoomID").Value.ToString()

            If MsgBox("Are you sure you want to reject this booking? The room will be set to Available again.", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Try
                    If conn.State = ConnectionState.Closed Then conn.Open()

                    ' Step 1: Update Booking Status to Rejected
                    Dim sqlReject As String = "UPDATE Bookings SET PaymentStatus = 'Rejected', ReceiptText = NULL WHERE BookingID = @id"
                    Dim cmdReject As New SqlCommand(sqlReject, conn)
                    cmdReject.Parameters.AddWithValue("@id", bID)
                    cmdReject.ExecuteNonQuery()

                    ' Step 2: Set the Room status back to Available
                    Dim sqlRoom As String = "UPDATE Rooms SET Status = 'Available' WHERE RoomID = @rid"
                    Dim cmdRoom As New SqlCommand(sqlRoom, conn)
                    cmdRoom.Parameters.AddWithValue("@rid", rID)
                    cmdRoom.ExecuteNonQuery()

                    MsgBox("Booking Rejected! The room is now open for others.", MsgBoxStyle.Exclamation)

                    conn.Close()
                    LoadPendingBookings()
                    picReceipt.Image = Nothing
                Catch ex As Exception
                    MsgBox("Reject Error: " & ex.Message)
                    If conn.State = ConnectionState.Open Then conn.Close()
                End Try
            End If
        End If
    End Sub

    ' 5. Navigation & Refresh
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmManageBookings.Show()
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadPendingBookings()
    End Sub

End Class