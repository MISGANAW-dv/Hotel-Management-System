<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookingDetails
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
        dtpCheckIn = New DateTimePicker()
        dtpCheckOut = New DateTimePicker()
        cmbPaymentMethod = New ComboBox()
        Label4 = New Label()
        picReceipt = New PictureBox()
        btnUpload = New Button()
        Label6 = New Label()
        lblAccountDetails = New Label()
        btnConfirm = New Button()
        btnBack = New Button()
        CType(picReceipt, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 34)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 30)
        Label1.TabIndex = 0
        Label1.Text = " cheak in date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(38, 104)
        Label2.Margin = New Padding(6, 0, 6, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 30)
        Label2.TabIndex = 1
        Label2.Text = "cheak out date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(38, 176)
        Label3.Margin = New Padding(6, 0, 6, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(171, 30)
        Label3.TabIndex = 2
        Label3.Text = "pyment mthode"
        ' 
        ' dtpCheckIn
        ' 
        dtpCheckIn.Location = New Point(231, 34)
        dtpCheckIn.Name = "dtpCheckIn"
        dtpCheckIn.Size = New Size(383, 35)
        dtpCheckIn.TabIndex = 3
        ' 
        ' dtpCheckOut
        ' 
        dtpCheckOut.Location = New Point(231, 115)
        dtpCheckOut.Name = "dtpCheckOut"
        dtpCheckOut.Size = New Size(383, 35)
        dtpCheckOut.TabIndex = 4
        ' 
        ' cmbPaymentMethod
        ' 
        cmbPaymentMethod.FormattingEnabled = True
        cmbPaymentMethod.Items.AddRange(New Object() {"Telebirr", "", "CBE Birr", "", "CBE Bank"})
        cmbPaymentMethod.Location = New Point(231, 176)
        cmbPaymentMethod.Name = "cmbPaymentMethod"
        cmbPaymentMethod.Size = New Size(383, 38)
        cmbPaymentMethod.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 289)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 30)
        Label4.TabIndex = 6
        Label4.Text = " Recipte Box"
        ' 
        ' picReceipt
        ' 
        picReceipt.Location = New Point(217, 291)
        picReceipt.Name = "picReceipt"
        picReceipt.Size = New Size(196, 51)
        picReceipt.TabIndex = 7
        picReceipt.TabStop = False
        ' 
        ' btnUpload
        ' 
        btnUpload.BackColor = Color.Cyan
        btnUpload.Location = New Point(454, 283)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(171, 57)
        btnUpload.TabIndex = 8
        btnUpload.Text = "Add Receipt"
        btnUpload.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(66, 237)
        Label6.Name = "Label6"
        Label6.Size = New Size(14, 21)
        Label6.TabIndex = 10
        Label6.Text = " "
        ' 
        ' lblAccountDetails
        ' 
        lblAccountDetails.AutoSize = True
        lblAccountDetails.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        lblAccountDetails.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAccountDetails.Location = New Point(419, 237)
        lblAccountDetails.Name = "lblAccountDetails"
        lblAccountDetails.Size = New Size(14, 21)
        lblAccountDetails.TabIndex = 11
        lblAccountDetails.Text = " "
        ' 
        ' btnConfirm
        ' 
        btnConfirm.BackColor = Color.Lime
        btnConfirm.Location = New Point(199, 398)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(163, 51)
        btnConfirm.TabIndex = 12
        btnConfirm.Text = " Conforim "
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Silver
        btnBack.Location = New Point(419, 398)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(206, 51)
        btnBack.TabIndex = 13
        btnBack.Text = "Back to dashboard"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' frmBookingDetails
        ' 
        AutoScaleDimensions = New SizeF(13F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ClientSize = New Size(884, 500)
        Controls.Add(btnBack)
        Controls.Add(btnConfirm)
        Controls.Add(lblAccountDetails)
        Controls.Add(Label6)
        Controls.Add(btnUpload)
        Controls.Add(picReceipt)
        Controls.Add(Label4)
        Controls.Add(cmbPaymentMethod)
        Controls.Add(dtpCheckOut)
        Controls.Add(dtpCheckIn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(6)
        MaximumSize = New Size(900, 539)
        MinimumSize = New Size(900, 539)
        Name = "frmBookingDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmBookingDetails"
        CType(picReceipt, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpCheckIn As DateTimePicker
    Friend WithEvents dtpCheckOut As DateTimePicker
    Friend WithEvents cmbPaymentMethod As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents picReceipt As PictureBox
    Friend WithEvents btnUpload As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblAccountDetails As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnBack As Button
End Class
