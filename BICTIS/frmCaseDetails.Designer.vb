<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCaseDetails
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.txtNarrative = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblComplainant = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(52, 73, 94)
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(600, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(550, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 40)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(135, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "CASE DETAILS"
        '
        'pnlBody
        '
        Me.pnlBody.BackColor = System.Drawing.Color.White
        Me.pnlBody.Controls.Add(Me.txtNarrative)
        Me.pnlBody.Controls.Add(Me.Label5)
        Me.pnlBody.Controls.Add(Me.lblStatus)
        Me.pnlBody.Controls.Add(Me.Label4)
        Me.pnlBody.Controls.Add(Me.lblDate)
        Me.pnlBody.Controls.Add(Me.Label3)
        Me.pnlBody.Controls.Add(Me.lblType)
        Me.pnlBody.Controls.Add(Me.Label2)
        Me.pnlBody.Controls.Add(Me.lblComplainant)
        Me.pnlBody.Controls.Add(Me.Label1)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(0, 60)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(600, 440)
        Me.pnlBody.TabIndex = 1
        '
        'txtNarrative
        '
        Me.txtNarrative.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNarrative.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNarrative.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtNarrative.Location = New System.Drawing.Point(30, 200)
        Me.txtNarrative.Multiline = True
        Me.txtNarrative.Name = "txtNarrative"
        Me.txtNarrative.ReadOnly = True
        Me.txtNarrative.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNarrative.Size = New System.Drawing.Size(540, 210)
        Me.txtNarrative.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(26, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Full Narrative / Log"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(350, 130)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(66, 21)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "[Status]"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(350, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Current Status"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.Location = New System.Drawing.Point(30, 130)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(53, 21)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "[Date]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(26, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Incident Date"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblType.ForeColor = System.Drawing.Color.Black
        Me.lblType.Location = New System.Drawing.Point(350, 60)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(53, 21)
        Me.lblType.TabIndex = 3
        Me.lblType.Text = "[Type]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(350, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Incident Type"
        '
        'lblComplainant
        '
        Me.lblComplainant.AutoSize = True
        Me.lblComplainant.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblComplainant.ForeColor = System.Drawing.Color.Black
        Me.lblComplainant.Location = New System.Drawing.Point(30, 60)
        Me.lblComplainant.Name = "lblComplainant"
        Me.lblComplainant.Size = New System.Drawing.Size(63, 21)
        Me.lblComplainant.TabIndex = 1
        Me.lblComplainant.Text = "[Name]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(26, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Complainant / Reporter"
        '
        'frmCaseDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 500)
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCaseDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Details"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBody.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlBody As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblComplainant As Label
    Friend WithEvents lblType As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNarrative As TextBox
End Class