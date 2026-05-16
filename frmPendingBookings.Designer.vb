<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPendingBookings
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
        Label1 = New Label()
        btnRefresh = New Button()
        picReceipt = New PictureBox()
        btnApprove = New Button()
        btnBack = New Button()
        btnReject = New Button()
        dgvPending = New DataGridView()
        Panel1.SuspendLayout()
        CType(picReceipt, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvPending, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(picReceipt)
        Panel1.Controls.Add(btnApprove)
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(btnReject)
        Panel1.Dock = DockStyle.Top
        Panel1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1001, 181)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(358, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(374, 37)
        Label1.TabIndex = 5
        Label1.Text = "Pending Bookings Approval"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        btnRefresh.Location = New Point(314, 127)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(111, 49)
        btnRefresh.TabIndex = 4
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' picReceipt
        ' 
        picReceipt.Location = New Point(0, 0)
        picReceipt.Name = "picReceipt"
        picReceipt.Size = New Size(307, 181)
        picReceipt.SizeMode = PictureBoxSizeMode.StretchImage
        picReceipt.TabIndex = 3
        picReceipt.TabStop = False
        ' 
        ' btnApprove
        ' 
        btnApprove.BackColor = Color.Lime
        btnApprove.Location = New Point(649, 127)
        btnApprove.Name = "btnApprove"
        btnApprove.Size = New Size(136, 49)
        btnApprove.TabIndex = 2
        btnApprove.Text = "Approve"
        btnApprove.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnBack.Location = New Point(831, 126)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(117, 49)
        btnBack.TabIndex = 1
        btnBack.Text = "Back to Manage Bookings"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnReject
        ' 
        btnReject.BackColor = Color.IndianRed
        btnReject.Location = New Point(454, 129)
        btnReject.Name = "btnReject"
        btnReject.Size = New Size(121, 49)
        btnReject.TabIndex = 0
        btnReject.Text = "Reject"
        btnReject.UseVisualStyleBackColor = False
        ' 
        ' dgvPending
        ' 
        dgvPending.AllowUserToAddRows = False
        dgvPending.BackgroundColor = Color.WhiteSmoke
        dgvPending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPending.Dock = DockStyle.Fill
        dgvPending.Location = New Point(0, 181)
        dgvPending.Name = "dgvPending"
        dgvPending.Size = New Size(1001, 381)
        dgvPending.TabIndex = 1
        ' 
        ' frmPendingBookings
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1001, 562)
        Controls.Add(dgvPending)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MaximumSize = New Size(1017, 601)
        MinimumSize = New Size(1017, 601)
        Name = "frmPendingBookings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmPendingBookings"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picReceipt, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvPending, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnReject As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents picReceipt As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvPending As DataGridView
End Class
