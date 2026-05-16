<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageBookings
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
        Label1 = New Label()
        Panel1 = New Panel()
        btnAdminCheckOut = New Button()
        btnDelete = New Button()
        btnRefresh = New Button()
        btnCurrentlyBooking = New Button()
        txtSearch = New TextBox()
        btnBack = New Button()
        dgvBookings = New DataGridView()
        Panel1.SuspendLayout()
        CType(dgvBookings, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(256, 9)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(507, 37)
        Label1.TabIndex = 0
        Label1.Text = "Approved And Reject Booking History"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        Panel1.Controls.Add(btnAdminCheckOut)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(btnCurrentlyBooking)
        Panel1.Controls.Add(txtSearch)
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1011, 117)
        Panel1.TabIndex = 1
        ' 
        ' btnAdminCheckOut
        ' 
        btnAdminCheckOut.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnAdminCheckOut.Location = New Point(398, 52)
        btnAdminCheckOut.Name = "btnAdminCheckOut"
        btnAdminCheckOut.Size = New Size(132, 62)
        btnAdminCheckOut.TabIndex = 6
        btnAdminCheckOut.Text = "Check Out"
        btnAdminCheckOut.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.IndianRed
        btnDelete.Location = New Point(572, 52)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(129, 65)
        btnDelete.TabIndex = 5
        btnDelete.Text = "Delete Booking"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.Lime
        btnRefresh.Location = New Point(256, 52)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(105, 62)
        btnRefresh.TabIndex = 4
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnCurrentlyBooking
        ' 
        btnCurrentlyBooking.BackColor = Color.Cyan
        btnCurrentlyBooking.Location = New Point(730, 52)
        btnCurrentlyBooking.Name = "btnCurrentlyBooking"
        btnCurrentlyBooking.Size = New Size(109, 62)
        btnCurrentlyBooking.TabIndex = 3
        btnCurrentlyBooking.Text = "Currently Booking"
        btnCurrentlyBooking.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(12, 78)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search bookig date"
        txtSearch.Size = New Size(210, 29)
        txtSearch.TabIndex = 2
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Gray
        btnBack.Location = New Point(871, 52)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(128, 62)
        btnBack.TabIndex = 1
        btnBack.Text = "Back to Dashboard"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' dgvBookings
        ' 
        dgvBookings.AllowUserToAddRows = False
        dgvBookings.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBookings.Dock = DockStyle.Fill
        dgvBookings.Location = New Point(0, 117)
        dgvBookings.Name = "dgvBookings"
        dgvBookings.Size = New Size(1011, 341)
        dgvBookings.TabIndex = 2
        ' 
        ' frmManageBookings
        ' 
        AutoScaleDimensions = New SizeF(10F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1011, 458)
        Controls.Add(dgvBookings)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        MaximumSize = New Size(1027, 497)
        MinimumSize = New Size(1027, 497)
        Name = "frmManageBookings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmManageBookings"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvBookings, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnCurrentlyBooking As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvBookings As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdminCheckOut As Button
End Class
