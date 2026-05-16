<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        lblFirstName = New Label()
        lblLastName = New Label()
        lblPhone = New Label()
        lblAddress = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        txtPhone = New TextBox()
        txtAddress = New TextBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        txtConfirmPass = New TextBox()
        btnRegister = New Button()
        btnBackToLogin = New Button()
        txtRole = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(54, 9)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(691, 37)
        Label1.TabIndex = 0
        Label1.Text = "Register - Hotel Room Banking Management System"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFirstName.Location = New Point(21, 83)
        lblFirstName.Margin = New Padding(2, 0, 2, 0)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(176, 30)
        lblFirstName.TabIndex = 1
        lblFirstName.Text = "Enter First Name"
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLastName.Location = New Point(21, 143)
        lblLastName.Margin = New Padding(2, 0, 2, 0)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(173, 30)
        lblLastName.TabIndex = 2
        lblLastName.Text = "Enter Last Name"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPhone.Location = New Point(21, 206)
        lblPhone.Margin = New Padding(2, 0, 2, 0)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(212, 30)
        lblPhone.TabIndex = 3
        lblPhone.Text = "Ener Phone Number"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddress.Location = New Point(21, 265)
        lblAddress.Margin = New Padding(2, 0, 2, 0)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(148, 30)
        lblAddress.TabIndex = 4
        lblAddress.Text = "Enter Address"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(21, 319)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(167, 30)
        Label6.TabIndex = 5
        Label6.Text = "Enter Username"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(21, 384)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(162, 30)
        Label7.TabIndex = 6
        Label7.Text = "Enter Password"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(-5, 448)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(248, 30)
        Label8.TabIndex = 7
        Label8.Text = "Enter Confirm Password"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(236, 83)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(397, 43)
        txtFirstName.TabIndex = 8
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(236, 143)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(397, 43)
        txtLastName.TabIndex = 9
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(236, 197)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(397, 43)
        txtPhone.TabIndex = 10
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(236, 256)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(397, 43)
        txtAddress.TabIndex = 11
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(236, 319)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(397, 43)
        txtUsername.TabIndex = 12
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(236, 384)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(397, 43)
        txtPassword.TabIndex = 13
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtConfirmPass
        ' 
        txtConfirmPass.Location = New Point(236, 439)
        txtConfirmPass.Name = "txtConfirmPass"
        txtConfirmPass.Size = New Size(397, 43)
        txtConfirmPass.TabIndex = 14
        txtConfirmPass.UseSystemPasswordChar = True
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnRegister.Location = New Point(171, 586)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(232, 66)
        btnRegister.TabIndex = 15
        btnRegister.Text = " Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnBackToLogin
        ' 
        btnBackToLogin.BackColor = Color.Silver
        btnBackToLogin.Location = New Point(446, 586)
        btnBackToLogin.Name = "btnBackToLogin"
        btnBackToLogin.Size = New Size(272, 66)
        btnBackToLogin.TabIndex = 16
        btnBackToLogin.Text = "Have an account?"
        btnBackToLogin.UseVisualStyleBackColor = False
        ' 
        ' txtRole
        ' 
        txtRole.Location = New Point(236, 499)
        txtRole.Name = "txtRole"
        txtRole.Size = New Size(397, 43)
        txtRole.TabIndex = 17
        ' 
        ' frmRegister
        ' 
        AutoScaleDimensions = New SizeF(16.0F, 37.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        ClientSize = New Size(781, 656)
        Controls.Add(txtRole)
        Controls.Add(btnBackToLogin)
        Controls.Add(btnRegister)
        Controls.Add(txtConfirmPass)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(txtAddress)
        Controls.Add(txtPhone)
        Controls.Add(txtLastName)
        Controls.Add(txtFirstName)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(lblAddress)
        Controls.Add(lblPhone)
        Controls.Add(lblLastName)
        Controls.Add(lblFirstName)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(7)
        MaximumSize = New Size(797, 695)
        MinimumSize = New Size(797, 695)
        Name = "frmRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmRegister"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnBackToLogin As Button
    Friend WithEvents txtRole As TextBox
End Class
