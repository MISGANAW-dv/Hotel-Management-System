<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pnlAdminHeader = New Panel()
        txtSearch = New TextBox()
        btnRefresh = New Button()
        btnLogout = New Button()
        btnGoBookings = New Button()
        btnUpdateStaff = New Button()
        btnUpdateRoom = New Button()
        Label1 = New Label()
        dgvUsers = New DataGridView()
        pnlAdminHeader.SuspendLayout()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlAdminHeader
        ' 
        pnlAdminHeader.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        pnlAdminHeader.Controls.Add(txtSearch)
        pnlAdminHeader.Controls.Add(btnRefresh)
        pnlAdminHeader.Controls.Add(btnLogout)
        pnlAdminHeader.Controls.Add(btnGoBookings)
        pnlAdminHeader.Controls.Add(btnUpdateStaff)
        pnlAdminHeader.Controls.Add(btnUpdateRoom)
        pnlAdminHeader.Controls.Add(Label1)
        pnlAdminHeader.Dock = DockStyle.Top
        pnlAdminHeader.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pnlAdminHeader.ForeColor = Color.Black
        pnlAdminHeader.Location = New Point(0, 0)
        pnlAdminHeader.Name = "pnlAdminHeader"
        pnlAdminHeader.Size = New Size(998, 131)
        pnlAdminHeader.TabIndex = 0
        ' 
        ' txtSearch
        ' 
        txtSearch.AutoCompleteSource = AutoCompleteSource.HistoryList
        txtSearch.Location = New Point(3, 95)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search User/Room"
        txtSearch.Size = New Size(214, 29)
        txtSearch.TabIndex = 8
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnRefresh.Location = New Point(232, 85)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(117, 41)
        btnRefresh.TabIndex = 7
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Red
        btnLogout.Location = New Point(851, 84)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(135, 38)
        btnLogout.TabIndex = 6
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnGoBookings
        ' 
        btnGoBookings.BackColor = Color.Green
        btnGoBookings.Location = New Point(689, 84)
        btnGoBookings.Name = "btnGoBookings"
        btnGoBookings.Size = New Size(135, 39)
        btnGoBookings.TabIndex = 5
        btnGoBookings.Text = "Go to Bookings"
        btnGoBookings.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateStaff
        ' 
        btnUpdateStaff.BackColor = Color.Olive
        btnUpdateStaff.Location = New Point(525, 84)
        btnUpdateStaff.Name = "btnUpdateStaff"
        btnUpdateStaff.Size = New Size(117, 39)
        btnUpdateStaff.TabIndex = 4
        btnUpdateStaff.Text = "Update Staff"
        btnUpdateStaff.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateRoom
        ' 
        btnUpdateRoom.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnUpdateRoom.Location = New Point(372, 85)
        btnUpdateRoom.Name = "btnUpdateRoom"
        btnUpdateRoom.Size = New Size(123, 39)
        btnUpdateRoom.TabIndex = 2
        btnUpdateRoom.Text = "Room books"
        btnUpdateRoom.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(192, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(379, 32)
        Label1.TabIndex = 0
        Label1.Text = "Admin Management Dashboard"
        ' 
        ' dgvUsers
        ' 
        dgvUsers.AllowUserToAddRows = False
        dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvUsers.BackgroundColor = SystemColors.ControlLight
        dgvUsers.BorderStyle = BorderStyle.None
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsers.Dock = DockStyle.Fill
        dgvUsers.Location = New Point(0, 131)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsers.Size = New Size(998, 369)
        dgvUsers.TabIndex = 1
        ' 
        ' frmAdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(998, 500)
        Controls.Add(dgvUsers)
        Controls.Add(pnlAdminHeader)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MaximumSize = New Size(1014, 539)
        MinimumSize = New Size(1014, 539)
        Name = "frmAdminDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmAdminDashboard"
        pnlAdminHeader.ResumeLayout(False)
        pnlAdminHeader.PerformLayout()
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlAdminHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdateRoom As Button
    Friend WithEvents btnUpdateStaff As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnGoBookings As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvUsers As DataGridView
End Class
