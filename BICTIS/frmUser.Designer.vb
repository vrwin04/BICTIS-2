<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUser
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
        Me.pnlBorder = New System.Windows.Forms.Panel()
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnMyBlotter = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlBorder.SuspendLayout()
        Me.pnlContainer.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBorder
        '
        Me.pnlBorder.BackColor = System.Drawing.Color.White
        Me.pnlBorder.Controls.Add(Me.pnlContainer)
        Me.pnlBorder.Controls.Add(Me.pnlHeader)
        Me.pnlBorder.Controls.Add(Me.pnlSidebar)
        Me.pnlBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBorder.Location = New System.Drawing.Point(2, 2)
        Me.pnlBorder.Name = "pnlBorder"
        Me.pnlBorder.Size = New System.Drawing.Size(996, 596)
        Me.pnlBorder.TabIndex = 0
        '
        'pnlContainer
        '
        Me.pnlContainer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlContainer.Controls.Add(Me.Label2)
        Me.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContainer.Location = New System.Drawing.Point(220, 80)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(776, 516)
        Me.pnlContainer.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(150, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Text = "Select 'Report a Concern' to file a complaint."
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblWelcome)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(220, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(776, 80)
        Me.pnlHeader.TabIndex = 1
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular)
        Me.lblWelcome.Location = New System.Drawing.Point(25, 25)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(163, 25)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome Resident"
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(0, 150, 136)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnMyBlotter)
        Me.pnlSidebar.Controls.Add(Me.btnReport)
        Me.pnlSidebar.Controls.Add(Me.pnlLogo)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 596)
        Me.pnlSidebar.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(255, 205, 210)
        Me.btnLogout.Location = New System.Drawing.Point(0, 546)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(220, 50)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Sign Out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnMyBlotter
        '
        Me.btnMyBlotter.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMyBlotter.FlatAppearance.BorderSize = 0
        Me.btnMyBlotter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyBlotter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnMyBlotter.ForeColor = System.Drawing.Color.White
        Me.btnMyBlotter.Location = New System.Drawing.Point(0, 130)
        Me.btnMyBlotter.Name = "btnMyBlotter"
        Me.btnMyBlotter.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnMyBlotter.Size = New System.Drawing.Size(220, 50)
        Me.btnMyBlotter.TabIndex = 2
        Me.btnMyBlotter.Text = "My Blotter Cases"
        Me.btnMyBlotter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMyBlotter.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Location = New System.Drawing.Point(0, 80)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnReport.Size = New System.Drawing.Size(220, 50)
        Me.btnReport.TabIndex = 1
        Me.btnReport.Text = "Report a Concern"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'pnlLogo
        '
        Me.pnlLogo.BackColor = System.Drawing.Color.FromArgb(0, 121, 107)
        Me.pnlLogo.Controls.Add(Me.Label1)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(220, 80)
        Me.pnlLogo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(40, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Text = "RESIDENT"
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.pnlBorder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUser"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Dashboard"
        Me.pnlBorder.ResumeLayout(False)
        Me.pnlContainer.ResumeLayout(False)
        Me.pnlContainer.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        Me.pnlLogo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBorder As Panel
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReport As Button
    Friend WithEvents btnMyBlotter As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents Label2 As Label
End Class