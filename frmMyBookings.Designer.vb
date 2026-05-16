<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMyBookings
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
        btnRefresh = New Button()
        btnDownloadReceipt = New Button()
        btnBack = New Button()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(btnDownloadReceipt)
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1010, 127)
        Panel1.TabIndex = 1
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnRefresh.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.Location = New Point(358, 58)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(152, 66)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnDownloadReceipt
        ' 
        btnDownloadReceipt.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnDownloadReceipt.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDownloadReceipt.Location = New Point(551, 58)
        btnDownloadReceipt.Name = "btnDownloadReceipt"
        btnDownloadReceipt.Size = New Size(208, 62)
        btnDownloadReceipt.TabIndex = 2
        btnDownloadReceipt.Text = "DownloadReceipt"
        btnDownloadReceipt.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        btnBack.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(781, 58)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(185, 62)
        btnBack.TabIndex = 1
        btnBack.Text = "Back to Dashboard"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(232, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(243, 32)
        Label1.TabIndex = 0
        Label1.Text = "My Booking History"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 127)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1010, 399)
        DataGridView1.TabIndex = 2
        ' 
        ' frmMyBookings
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 17.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1010, 526)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MaximumSize = New Size(1026, 565)
        MinimumSize = New Size(1026, 565)
        Name = "frmMyBookings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "My Bookings - Hotel Management System"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnDownloadReceipt As Button
    Friend WithEvents btnRefresh As Button
End Class
