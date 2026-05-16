<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewRooms
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
        Panel1 = New Panel()
        btnRegRoom = New Button()
        Label1 = New Label()
        btnRefresh = New Button()
        btnBack = New Button()
        btnUpdateRoom = New Button()
        txtSearchRoom = New TextBox()
        dgvRooms = New DataGridView()
        Panel1.SuspendLayout()
        CType(dgvRooms, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(btnRegRoom)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(btnUpdateRoom)
        Panel1.Controls.Add(txtSearchRoom)
        Panel1.Dock = DockStyle.Top
        Panel1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(987, 122)
        Panel1.TabIndex = 0
        ' 
        ' btnRegRoom
        ' 
        btnRegRoom.BackColor = Color.Yellow
        btnRegRoom.Location = New Point(459, 70)
        btnRegRoom.Name = "btnRegRoom"
        btnRegRoom.Size = New Size(152, 49)
        btnRegRoom.TabIndex = 5
        btnRegRoom.Text = "Register Room"
        btnRegRoom.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(335, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(288, 32)
        Label1.TabIndex = 4
        Label1.Text = "View Room Mangement"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnRefresh.Location = New Point(317, 67)
        btnRefresh.Margin = New Padding(4, 3, 4, 3)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(122, 52)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refrash"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Gray
        btnBack.Location = New Point(801, 67)
        btnBack.Margin = New Padding(4, 3, 4, 3)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(178, 53)
        btnBack.TabIndex = 2
        btnBack.Text = " Back to Dashbord"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateRoom
        ' 
        btnUpdateRoom.BackColor = Color.Cyan
        btnUpdateRoom.Location = New Point(631, 66)
        btnUpdateRoom.Margin = New Padding(4, 3, 4, 3)
        btnUpdateRoom.Name = "btnUpdateRoom"
        btnUpdateRoom.Size = New Size(146, 53)
        btnUpdateRoom.TabIndex = 1
        btnUpdateRoom.Text = "Update Room"
        btnUpdateRoom.UseVisualStyleBackColor = False
        ' 
        ' txtSearchRoom
        ' 
        txtSearchRoom.Location = New Point(0, 87)
        txtSearchRoom.Margin = New Padding(4, 3, 4, 3)
        txtSearchRoom.Name = "txtSearchRoom"
        txtSearchRoom.PlaceholderText = "Search by Room Number"
        txtSearchRoom.Size = New Size(290, 29)
        txtSearchRoom.TabIndex = 0
        ' 
        ' dgvRooms
        ' 
        dgvRooms.AllowUserToAddRows = False
        dgvRooms.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRooms.Dock = DockStyle.Fill
        dgvRooms.Location = New Point(0, 122)
        dgvRooms.Margin = New Padding(4, 3, 4, 3)
        dgvRooms.Name = "dgvRooms"
        dgvRooms.Size = New Size(987, 363)
        dgvRooms.TabIndex = 1
        ' 
        ' frmViewRooms
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(987, 485)
        Controls.Add(dgvRooms)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        MaximumSize = New Size(1003, 524)
        MinimumSize = New Size(1003, 524)
        Name = "frmViewRooms"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmViewRooms"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvRooms, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearchRoom As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnUpdateRoom As Button
    Friend WithEvents dgvRooms As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegRoom As Button
End Class
