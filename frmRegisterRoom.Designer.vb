<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterRoom
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtRoomNumber = New TextBox()
        cmbRoomType = New ComboBox()
        txtPrice = New TextBox()
        cmbStatus = New ComboBox()
        Label5 = New Label()
        btnBack = New Button()
        btnSave = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(65, 97)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 25)
        Label1.TabIndex = 0
        Label1.Text = "Room Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(65, 173)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 25)
        Label2.TabIndex = 1
        Label2.Text = "Room Type"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(65, 237)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 25)
        Label3.TabIndex = 2
        Label3.Text = "Price Per Night"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(65, 312)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 25)
        Label4.TabIndex = 3
        Label4.Text = "Room Status:"
        ' 
        ' txtRoomNumber
        ' 
        txtRoomNumber.Location = New Point(257, 97)
        txtRoomNumber.Name = "txtRoomNumber"
        txtRoomNumber.Size = New Size(277, 33)
        txtRoomNumber.TabIndex = 4
        ' 
        ' cmbRoomType
        ' 
        cmbRoomType.FormattingEnabled = True
        cmbRoomType.Items.AddRange(New Object() {"Single", "", "", "Double", "", "", "Suite"})
        cmbRoomType.Location = New Point(257, 173)
        cmbRoomType.Name = "cmbRoomType"
        cmbRoomType.Size = New Size(277, 33)
        cmbRoomType.TabIndex = 5
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(257, 234)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(277, 33)
        txtPrice.TabIndex = 6
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Available", "Booked", "Maintenance"})
        cmbStatus.Location = New Point(257, 304)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(277, 33)
        cmbStatus.TabIndex = 7
        cmbStatus.Text = "Available"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(199, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(350, 37)
        Label5.TabIndex = 8
        Label5.Text = "Register New Hotel Room"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Silver
        btnBack.Location = New Point(223, 384)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(189, 57)
        btnBack.TabIndex = 9
        btnBack.Text = "Back to Dashboard"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Lime
        btnSave.Location = New Point(455, 384)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(150, 57)
        btnSave.TabIndex = 10
        btnSave.Text = "Save Room"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' frmRegisterRoom
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(827, 480)
        Controls.Add(btnSave)
        Controls.Add(btnBack)
        Controls.Add(Label5)
        Controls.Add(cmbStatus)
        Controls.Add(txtPrice)
        Controls.Add(cmbRoomType)
        Controls.Add(txtRoomNumber)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(5)
        MaximumSize = New Size(843, 519)
        MinimumSize = New Size(843, 519)
        Name = "frmRegisterRoom"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmRegisterRoom"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRoomNumber As TextBox
    Friend WithEvents cmbRoomType As ComboBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSave As Button
End Class
