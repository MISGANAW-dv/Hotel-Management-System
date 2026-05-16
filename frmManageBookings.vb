Imports System.Data.SqlClient
Imports System.IO

Public Class frmManageBookings

    Private Sub frmManageBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load all history (Approved, Rejected, and Completed) when form starts
        LoadHistory()
    End Sub

    ' Fetch data from database including Approved, Rejected, and Completed statuses
    Public Sub LoadHistory()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' SQL Query: Included 'Completed' to keep checked-out guests in the list
            Dim sql As String = "SELECT BookingID, Username, RoomID, CheckInDate, CheckOutDate, TotalAmount, PaymentStatus, BookingDate " &
                               "FROM Bookings WHERE PaymentStatus IN ('Approved', 'Rejected', 'Completed') ORDER BY BookingDate DESC"

            Dim cmd As New SqlCommand(sql, conn)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adp.Fill(dt)

            dgvBookings.DataSource = dt
            FormatGrid() ' Apply visual formatting
            conn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' Grid formatting and color coding
    Private Sub FormatGrid()
        dgvBookings.ReadOnly = True
        dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBookings.AllowUserToAddRows = False

        ' Hide ID column from user
        If dgvBookings.Columns.Contains("BookingID") Then dgvBookings.Columns("BookingID").Visible = False

        ' Format Date display
        If dgvBookings.Columns.Contains("BookingDate") Then
            dgvBookings.Columns("BookingDate").DefaultCellStyle.Format = "yyyy-MM-dd HH:mm"
        End If

        ' Apply colors based on PaymentStatus
        For Each row As DataGridViewRow In dgvBookings.Rows
            Dim status As String = row.Cells("PaymentStatus").Value.ToString()

            If status = "Approved" Then
                row.DefaultCellStyle.ForeColor = Color.DarkGreen
            ElseIf status = "Rejected" Then
                row.DefaultCellStyle.ForeColor = Color.Firebrick
            ElseIf status = "Completed" Then
                ' Blue color for checked-out guests
                row.DefaultCellStyle.ForeColor = Color.RoyalBlue
            End If
        Next
    End Sub

    ' --- Delete Booking History ---
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvBookings.SelectedRows.Count > 0 Then
            Dim ask = MsgBox("Do you want to permanently delete this booking history?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Delete")

            If ask = MsgBoxResult.Yes Then
                Try
                    Dim selectedID As Integer = dgvBookings.SelectedRows(0).Cells("BookingID").Value
                    If conn.State = ConnectionState.Closed Then conn.Open()

                    Dim sql As String = "DELETE FROM Bookings WHERE BookingID = @id"
                    Dim cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", selectedID)

                    cmd.ExecuteNonQuery()
                    MsgBox("Record deleted successfully!", MsgBoxStyle.Information)
                    conn.Close()

                    LoadHistory() ' Refresh list
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
                    If conn.State = ConnectionState.Open Then conn.Close()
                End Try
            End If
        Else
            MsgBox("Please select a row to delete!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    ' Refresh the data grid
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        LoadHistory()
    End Sub

    ' Navigate to Pending Bookings page
    Private Sub btnCurrentlyBooking_Click(sender As Object, e As EventArgs) Handles btnCurrentlyBooking.Click
        frmPendingBookings.Show()
        Me.Hide()
    End Sub

    ' Back to Admin Dashboard
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmAdminDashboard.Show()
        Me.Close()
    End Sub

    ' Search by Username or Date
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim dt As DataTable = CType(dgvBookings.DataSource, DataTable)
            If dt IsNot Nothing Then
                dt.DefaultView.RowFilter = String.Format("Username LIKE '%{0}%' OR Convert(BookingDate, 'System.String') LIKE '%{0}%'", txtSearch.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    ' Admin manual Check-out logic
    Private Sub btnAdminCheckOut_Click(sender As Object, e As EventArgs) Handles btnAdminCheckOut.Click
        If dgvBookings.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvBookings.SelectedRows(0)

            Dim bID As Integer = row.Cells("BookingID").Value
            Dim rID As String = row.Cells("RoomID").Value.ToString()
            Dim currentStatus As String = row.Cells("PaymentStatus").Value.ToString()

            ' Check if guest is already checked out or rejected
            If currentStatus <> "Approved" Then
                MsgBox("Only 'Approved' bookings can be checked out!", MsgBoxStyle.Exclamation)
                Return
            End If

            ' Confirmation prompt
            If MsgBox("Are you sure you want to Check-out this guest? Room " & rID & " will become Available.",
                      MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Try
                    If conn.State = ConnectionState.Closed Then conn.Open()

                    ' Use Transaction to ensure both updates succeed
                    Dim transaction As SqlTransaction = conn.BeginTransaction()
                    Try
                        ' A. Update Room status to Available
                        Dim cmdRoom As New SqlCommand("UPDATE Rooms SET Status = 'Available' WHERE RoomID = @rid", conn, transaction)
                        cmdRoom.Parameters.AddWithValue("@rid", rID)
                        cmdRoom.ExecuteNonQuery()

                        ' B. Update Booking status to Completed
                        Dim cmdBook As New SqlCommand("UPDATE Bookings SET PaymentStatus = 'Completed' WHERE BookingID = @bid", conn, transaction)
                        cmdBook.Parameters.AddWithValue("@bid", bID)
                        cmdBook.ExecuteNonQuery()

                        transaction.Commit()
                        MsgBox("Check-out successful!", MsgBoxStyle.Information)

                    Catch ex As Exception
                        transaction.Rollback()
                        Throw ex
                    End Try

                    conn.Close()
                    LoadHistory() ' Refresh grid to show 'Completed' status

                Catch ex As Exception
                    MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
                    If conn.State = ConnectionState.Open Then conn.Close()
                End Try
            End If
        Else
            MsgBox("Please select a booking to Check-out!")
        End If
    End Sub

End Class