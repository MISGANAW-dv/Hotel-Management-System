<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerDashboard
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
        pnlHeader = New Panel()
        btnBookNow = New Button()
        btnLogout = New Button()
        btnMyBookings = New Button()
        txtSearch = New TextBox()
        lblWelcome = New Label()
        Panel2 = New Panel()
        dgvRooms = New DataGridView()
        pnlHeader.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgvRooms, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.DarkSlateBlue
        pnlHeader.Controls.Add(btnBookNow)
        pnlHeader.Controls.Add(btnLogout)
        pnlHeader.Controls.Add(btnMyBookings)
        pnlHeader.Controls.Add(txtSearch)
        pnlHeader.Controls.Add(lblWelcome)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pnlHeader.ForeColor = Color.White
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(921, 147)
        pnlHeader.TabIndex = 0
        ' 
        ' btnBookNow
        ' 
        btnBookNow.BackColor = Color.Silver
        btnBookNow.ForeColor = Color.Black
        btnBookNow.Location = New Point(360, 98)
        btnBookNow.Name = "btnBookNow"
        btnBookNow.Size = New Size(149, 43)
        btnBookNow.TabIndex = 4
        btnBookNow.Text = "Book Naw"
        btnBookNow.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Red
        btnLogout.ForeColor = Color.Black
        btnLogout.Location = New Point(764, 101)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(130, 43)
        btnLogout.TabIndex = 3
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnMyBookings
        ' 
        btnMyBookings.BackColor = Color.Lime
        btnMyBookings.ForeColor = Color.Black
        btnMyBookings.Location = New Point(547, 101)
        btnMyBookings.Name = "btnMyBookings"
        btnMyBookings.Size = New Size(182, 43)
        btnMyBookings.TabIndex = 2
        btnMyBookings.Text = "My Bookings"
        btnMyBookings.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(3, 101)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search by room type..."
        txtSearch.Size = New Size(308, 35)
        txtSearch.TabIndex = 1
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblWelcome.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.Location = New Point(198, 31)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(311, 37)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = " Welcome to Our Hotel"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(dgvRooms)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 147)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(921, 353)
        Panel2.TabIndex = 1
        ' 
        ' dgvRooms
        ' 
        dgvRooms.AllowUserToAddRows = False
        dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRooms.BorderStyle = BorderStyle.None
        dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRooms.Dock = DockStyle.Fill
        dgvRooms.Location = New Point(0, 0)
        dgvRooms.Name = "dgvRooms"
        dgvRooms.Size = New Size(921, 353)
        dgvRooms.TabIndex = 0
        ' 
        ' frmCustomerDashboard
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 17.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(921, 500)
        Controls.Add(Panel2)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MaximumSize = New Size(937, 539)
        MinimumSize = New Size(937, 539)
        Name = "frmCustomerDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmCustomerDashboard"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(dgvRooms, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvRooms As DataGridView
    Friend WithEvents btnMyBookings As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnBookNow As Button
End Class
