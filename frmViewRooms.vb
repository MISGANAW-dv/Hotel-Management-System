Imports System.Data.SqlClient

Public Class frmViewRooms

    ' ፎርሙ ሲከፈት መረጃውን ይጭናል
    Private Sub frmViewRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllRooms()
    End Sub

    ' ሁሉንም ክፍሎች ከዳታቤዝ አምጥቶ DataGridView ላይ መጫን
    Public Sub LoadAllRooms()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' በ image_784999.png መዋቅር መሰረት የተዘጋጀ SQL
            Dim sql As String = "SELECT RoomID, RoomNumber, RoomType, PricePerNight, Status FROM Rooms"
            Dim cmd As New SqlCommand(sql, conn)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adp.Fill(dt)

            dgvRooms.DataSource = dt

            ' የሰንጠረዥ ዲዛይን ማስተካከያ
            If dgvRooms.Columns.Count > 0 Then
                dgvRooms.Columns("RoomID").Visible = False
                dgvRooms.Columns("RoomNumber").HeaderText = "Room #"
                dgvRooms.Columns("RoomType").HeaderText = "Type"
                dgvRooms.Columns("PricePerNight").HeaderText = "Price/Night"
                dgvRooms.Columns("Status").HeaderText = "Status"

                ' ሰንጠረዡ ፓናሉን ሳይነካ ቀሪውን ቦታ እንዲሞላ
                dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox("Error loading rooms: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' የፍለጋ ሳጥኑ ስራ (በፓናሉ ውስጥ ያለ)
    Private Sub txtSearchRoom_TextChanged(sender As Object, e As EventArgs) Handles txtSearchRoom.TextChanged
        Try
            Dim dt As DataTable = CType(dgvRooms.DataSource, DataTable)
            If dt IsNot Nothing Then
                ' በክፍል ቁጥር መፈለግ
                dt.DefaultView.RowFilter = String.Format("RoomNumber LIKE '%{0}%'", txtSearchRoom.Text)
            End If
        Catch ex As Exception
            ' ስህተት ቢኖር ችላ በለው
        End Try
    End Sub

    ' መረጃ ማደሻ በተን
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadAllRooms()
    End Sub

    ' ወደ አድሚን ዳሽቦርድ መመለሻ
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmAdminDashboard.Show()
        Me.Close()
    End Sub

    ' ማስተካከያ (Update) - የተመረጠውን ክፍል መረጃ ይዞ ይሄዳል
    Private Sub btnUpdateRoom_Click(sender As Object, e As EventArgs) Handles btnUpdateRoom.Click
        ' 1. ረድፍ መመረጡን ቼክ ማድረግ
        If dgvRooms.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvRooms.SelectedRows(0)

            ' 2. የሪጅስተር ፎርሙን መጥራትና መረጃ መጫን
            Dim regForm As New frmRegisterRoom()
            regForm.IsUpdate = True ' ለማስተካከያ መሆኑን ንገረው
            regForm.TargetRoomID = row.Cells("RoomID").Value

            ' መረጃዎቹን ወደ ቴክስት ቦክሶች መጫን
            regForm.txtRoomNumber.Text = row.Cells("RoomNumber").Value.ToString()
            regForm.cmbRoomType.Text = row.Cells("RoomType").Value.ToString()
            regForm.txtPrice.Text = row.Cells("PricePerNight").Value.ToString()
            regForm.cmbStatus.Text = row.Cells("Status").Value.ToString()

            regForm.btnSave.Text = "Update Information" ' በተኑ ላይ ያለውን ጽሁፍ ቀይረው
            regForm.ShowDialog() ' ፎርሙን ክፈት
            Me.Hide()
        Else
            MsgBox("እባክዎ መጀመሪያ ማስተካከል የሚፈልጉትን ረድፍ ይምረጡ!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnRegRoom_Click(sender As Object, e As EventArgs) Handles btnRegRoom.Click
        frmRegisterRoom.Show()
        Me.Hide()
    End Sub
End Class