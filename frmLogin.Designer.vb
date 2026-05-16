<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        lblUser = New Label()
        lblPass = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        btnLogin = New Button()
        btnGoRegister = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(135, 22)
        lblTitle.Margin = New Padding(7, 0, 7, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(657, 37)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Login - Hotel Room Banking Management System"
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Location = New Point(30, 97)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(220, 37)
        lblUser.TabIndex = 1
        lblUser.Text = "Enter Username"
        ' 
        ' lblPass
        ' 
        lblPass.AutoSize = True
        lblPass.Location = New Point(30, 196)
        lblPass.Name = "lblPass"
        lblPass.Size = New Size(213, 37)
        lblPass.TabIndex = 2
        lblPass.Text = "Enter Password"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(359, 97)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(322, 43)
        txtUser.TabIndex = 3
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(359, 190)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(322, 43)
        txtPass.TabIndex = 4
        txtPass.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnLogin.Location = New Point(290, 288)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(192, 85)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnGoRegister
        ' 
        btnGoRegister.BackColor = Color.Silver
        btnGoRegister.Location = New Point(534, 288)
        btnGoRegister.Name = "btnGoRegister"
        btnGoRegister.Size = New Size(295, 85)
        btnGoRegister.TabIndex = 6
        btnGoRegister.Text = "Create New Account"
        btnGoRegister.UseVisualStyleBackColor = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(16F, 37F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSalmon
        ClientSize = New Size(860, 468)
        Controls.Add(btnGoRegister)
        Controls.Add(btnLogin)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(lblPass)
        Controls.Add(lblUser)
        Controls.Add(lblTitle)
        Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(7)
        MaximumSize = New Size(876, 507)
        MinimumSize = New Size(876, 507)
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Hotel Room "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnGoRegister As Button

End Class
