<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.chkShowPass = New System.Windows.Forms.CheckBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblRegisterLink = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.pnlPassLine = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlUserLine = New System.Windows.Forms.Panel()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(41, 128, 185)
        Me.pnlLeft.Controls.Add(Me.Label6)
        Me.pnlLeft.Controls.Add(Me.lblBrand)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(300, 500)
        Me.pnlLeft.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(40, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Resident Portal Access"
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrand.ForeColor = System.Drawing.Color.White
        Me.lblBrand.Location = New System.Drawing.Point(35, 160)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(176, 65)
        Me.lblBrand.TabIndex = 0
        Me.lblBrand.Text = "BICTIS"
        '
        'pnlRight
        '
        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Controls.Add(Me.chkShowPass)
        Me.pnlRight.Controls.Add(Me.btnClose)
        Me.pnlRight.Controls.Add(Me.lblRegisterLink)
        Me.pnlRight.Controls.Add(Me.Label5)
        Me.pnlRight.Controls.Add(Me.btnLogin)
        Me.pnlRight.Controls.Add(Me.pnlPassLine)
        Me.pnlRight.Controls.Add(Me.txtPassword)
        Me.pnlRight.Controls.Add(Me.Label2)
        Me.pnlRight.Controls.Add(Me.pnlUserLine)
        Me.pnlRight.Controls.Add(Me.txtUsername)
        Me.pnlRight.Controls.Add(Me.Label1)
        Me.pnlRight.Controls.Add(Me.lblTitle)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRight.Location = New System.Drawing.Point(300, 0)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(450, 500)
        Me.pnlRight.TabIndex = 1
        '
        'chkShowPass
        '
        Me.chkShowPass.AutoSize = True
        Me.chkShowPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkShowPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.chkShowPass.ForeColor = System.Drawing.Color.Gray
        Me.chkShowPass.Location = New System.Drawing.Point(50, 305)
        Me.chkShowPass.Name = "chkShowPass"
        Me.chkShowPass.Size = New System.Drawing.Size(108, 19)
        Me.chkShowPass.TabIndex = 3
        Me.chkShowPass.Text = "Show Password"
        Me.chkShowPass.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.Gray
        Me.btnClose.Location = New System.Drawing.Point(410, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 40)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "×"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblRegisterLink
        '
        Me.lblRegisterLink.AutoSize = True
        Me.lblRegisterLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegisterLink.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblRegisterLink.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185)
        Me.lblRegisterLink.Location = New System.Drawing.Point(265, 430)
        Me.lblRegisterLink.Name = "lblRegisterLink"
        Me.lblRegisterLink.Size = New System.Drawing.Size(60, 19)
        Me.lblRegisterLink.TabIndex = 5
        Me.lblRegisterLink.Text = "Sign Up"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(115, 430)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Don't have an account?"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(41, 128, 185)
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(50, 350)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(350, 50)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'pnlPassLine
        '
        Me.pnlPassLine.BackColor = System.Drawing.Color.Silver
        Me.pnlPassLine.Location = New System.Drawing.Point(50, 290)
        Me.pnlPassLine.Name = "pnlPassLine"
        Me.pnlPassLine.Size = New System.Drawing.Size(350, 2)
        Me.pnlPassLine.TabIndex = 6
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
        Me.txtPassword.Location = New System.Drawing.Point(50, 260)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(350, 25)
        Me.txtPassword.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(46, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'pnlUserLine
        '
        Me.pnlUserLine.BackColor = System.Drawing.Color.Silver
        Me.pnlUserLine.Location = New System.Drawing.Point(50, 200)
        Me.pnlUserLine.Name = "pnlUserLine"
        Me.pnlUserLine.Size = New System.Drawing.Size(350, 2)
        Me.pnlUserLine.TabIndex = 3
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64)
        Me.txtUsername.Location = New System.Drawing.Point(50, 170)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(350, 25)
        Me.txtUsername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(46, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185)
        Me.lblTitle.Location = New System.Drawing.Point(42, 60)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(243, 45)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Welcome Back"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 500)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Name = "frmLogin"
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLeft As Panel
    Friend WithEvents pnlRight As Panel
    Friend WithEvents lblBrand As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblRegisterLink As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlUserLine As Panel
    Friend WithEvents pnlPassLine As Panel
    Friend WithEvents chkShowPass As CheckBox
End Class