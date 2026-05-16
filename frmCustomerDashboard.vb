Imports System.Data.SqlClient

Public Class frmCustomerDashboard

    Private Sub frmCustomerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. የደንበኛውን ስም ማሳየት
        lblWelcome.Text = "Welcome, " & UserFirstName & "!"

        SetupGridDesign()
        LoadRoomsIntoDashboard()
    End Sub

    Private Sub SetupGridDesign()
        dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRooms.MultiSelect = False
        dgvRooms.ReadOnly = True
        dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Public Sub LoadRoomsIntoDashboard()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' የሚታዩት Available የሆኑ ክፍሎች ብቻ ናቸው
            Dim sql As String = "SELECT RoomID, RoomNumber, RoomType, PricePerNight FROM Rooms WHERE Status = 'Available'"

            If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                sql &= " AND (RoomType LIKE @search OR RoomNumber LIKE @search)"
            End If

            Dim cmd As New SqlCommand(sql, conn)
            If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text.Trim() & "%")
            End If

            Dim adp As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adp.Fill(dt)

            dgvRooms.DataSource = dt
            If dgvRooms.Columns.Contains("RoomID") Then dgvRooms.Columns("RoomID").Visible = False

            conn.Close()
        Catch ex As Exception
            MsgBox("Error loading rooms: " & ex.Message)
        End Try
    End Sub

    ' *** አዲሱ የ Book Now በተን ኮድ ***
    Private Sub btnBookNow_Click(sender As Object, e As EventArgs) Handles btnBookNow.Click
        ' 1. ረድፍ መመረጡን ማረጋገጥ
        If dgvRooms.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvRooms.SelectedRows(0)

            ' 2. መረጃውን ለቀጣዩ ፎርም ማስተላለፍ
            frmBookingDetails.TargetRoomID = row.Cells("RoomID").Value
            frmBookingDetails.RoomPrice = row.Cells("PricePerNight").Value

            ' 3. ወደ ቀጣዩ ፎርም መሄድ
            frmBookingDetails.Show()
            Me.Hide()
        Else
            MsgBox("እባክዎ መጀመሪያ የሚፈልጉትን ክፍል ከሰንጠረዡ ላይ ይምረጡ!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadRoomsIntoDashboard()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.txtUser.Clear()
        frmLogin.txtPass.Clear()
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnMyBookings_Click(sender As Object, e As EventArgs) Handles btnMyBookings.Click
        frmMyBookings.Show()
        Me.Hide()
    End Sub
End Class