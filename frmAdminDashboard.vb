Imports System.Data.SqlClient

Public Class frmAdminDashboard

    ' 1. ፎርሙ ሲከፈት የሚሰሩ ስራዎች
    Private Sub frmAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' የበተኖቹን መልክ ማስተካከል
        DesignButtons()
        ' የተጠቃሚዎችን መረጃ መጫን
        LoadUsers()
    End Sub

    ' 2. የበተኖቹን ዲዛይን ማስተካከያ (ለፕሮፌሽናል እይታ)
    Private Sub DesignButtons()
        Dim adminButtons() As Button = {btnUpdateRoom, btnUpdateStaff, btnGoBookings, btnLogout, btnRefresh}

        For Each btn In adminButtons
            If btn IsNot Nothing Then
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderSize = 0
                btn.BackColor = Color.FromArgb(52, 152, 219) ' ሰማያዊ ቀለም
                btn.ForeColor = Color.White
                btn.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                btn.Cursor = Cursors.Hand
            End If
        Next

        ' መውጫ በተን ቀይ እንዲሆን
        If btnLogout IsNot Nothing Then btnLogout.BackColor = Color.Firebrick
    End Sub

    ' 3. መረጃ ከዳታቤዝ አውጥቶ DataGridView ላይ መጫን
    Public Sub LoadUsers()
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' ሁሉንም ተጠቃሚዎች ማምጣት
            Dim sql As String = "SELECT UserID, FirstName, LastName, Username, Password, PhoneNumber, Address, Role FROM Users"

            Dim cmd As New SqlCommand(sql, conn)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adp.Fill(dt)

            ' መረጃውን በሰንጠረዡ ላይ መጫን
            dgvUsers.DataSource = dt

            ' የኮለሞቹን ርዕስ ማስተካከል
            If dgvUsers.Columns.Count > 0 Then
                If dgvUsers.Columns.Contains("UserID") Then dgvUsers.Columns("UserID").Visible = False
                dgvUsers.Columns("FirstName").HeaderText = "First Name"
                dgvUsers.Columns("LastName").HeaderText = "Last Name"
                dgvUsers.Columns("Username").HeaderText = "User Name"
                dgvUsers.Columns("Password").HeaderText = "Password"
                dgvUsers.Columns("PhoneNumber").HeaderText = "Phone"
                dgvUsers.Columns("Address").HeaderText = "Address"
                dgvUsers.Columns("Role").HeaderText = "Role"

                dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                dgvUsers.MultiSelect = False
                dgvUsers.ReadOnly = True
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox("Error loading users: " & ex.Message, MsgBoxStyle.Critical)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' 4. በፍለጋ ሳጥኑ ሲጻፍ መረጃን ማጣራት (Search)
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim dt As DataTable = CType(dgvUsers.DataSource, DataTable)
            If dt IsNot Nothing Then
                dt.DefaultView.RowFilter = String.Format("Username LIKE '%{0}%' OR FirstName LIKE '%{0}%' OR Role LIKE '%{0}%'", txtSearch.Text)
            End If
        Catch ex As Exception
            ' ስህተት ቢፈጠር ችላ በለው
        End Try
    End Sub

    ' 5. የአዲስ ክፍል ምዝገባ ገጽ መክፈቻ
    Private Sub btnRegRoom_Click(sender As Object, e As EventArgs)
        frmRegisterRoom.Show()
    End Sub

    ' 6. የክፍሎች ዝርዝር ማሳያ ገጽ መክፈቻ
    Private Sub btnUpdateRoom_Click(sender As Object, e As EventArgs) Handles btnUpdateRoom.Click
        frmViewRooms.Show()
        Me.Hide()
    End Sub
    Private Sub btnUpdateStaff_Click(sender As Object, e As EventArgs) Handles btnUpdateStaff.Click
        If dgvUsers.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvUsers.SelectedRows(0)

            ' የሪጅስተር ፎርሙን ለ Update አዘጋጅ
            frmRegister.IsUpdate = True
            frmRegister.OpenedByAdmin = True
            frmRegister.TargetUserID = row.Cells("UserID").Value

            ' መረጃዎቹን ወደ ፎርሙ ሳጥኖች መጫን
            frmRegister.txtFirstName.Text = row.Cells("FirstName").Value.ToString()
            frmRegister.txtLastName.Text = row.Cells("LastName").Value.ToString()
            frmRegister.txtUsername.Text = row.Cells("Username").Value.ToString()
            frmRegister.txtPassword.Text = row.Cells("Password").Value.ToString()
            frmRegister.txtConfirmPass.Text = row.Cells("Password").Value.ToString()
            frmRegister.txtAddress.Text = row.Cells("Address").Value.ToString()
            frmRegister.txtPhone.Text = row.Cells("PhoneNumber").Value.ToString()

            ' Role መቀየር እንዲችል ቴክስት ቦክሱ ላይ ጫንለት
            frmRegister.txtRole.Text = row.Cells("Role").Value.ToString()

            ' በተኖቹን መቀየር
            frmRegister.btnRegister.Text = "Update Staff"
            frmRegister.btnBackToLogin.Text = "Back to Dashboard"
            Me.Hide()
            frmRegister.ShowDialog()
            Me.Show()
            LoadUsers() ' ሲመለስ ዳታውን አድስ
        Else
            MsgBox("እባክዎ መጀመሪያ ማስተካከል የሚፈልጉትን ሰው በሰንጠረዡ ላይ ይምረጡ!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    ' 9. ወደ ቡኪንግ ማስተዳደሪያ ገጽ መሄጃ
    Private Sub btnGoBookings_Click(sender As Object, e As EventArgs) Handles btnGoBookings.Click
        frmManageBookings.Show()
        Me.Hide()
    End Sub

    ' 10. መረጃን ማደሻ (Refresh)
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadUsers()
    End Sub

    ' 11. መውጫ (Logout)
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Logout")
        If result = MsgBoxResult.Yes Then
            frmLogin.txtUser.Clear()
            frmLogin.txtPass.Clear()
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick

    End Sub
End Class