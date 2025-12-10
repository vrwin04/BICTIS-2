<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBlotter
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlEditor = New System.Windows.Forms.Panel()
        Me.btnResolve = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlLine2 = New System.Windows.Forms.Panel()
        Me.txtNarrative = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlLine1 = New System.Windows.Forms.Panel()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbRespondent = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbComplainant = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvCases = New System.Windows.Forms.DataGridView()
        Me.pnlHeader.SuspendLayout()
        Me.pnlEditor.SuspendLayout()
        CType(Me.dgvCases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(44, 62, 80)
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1000, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(309, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "INCIDENT BLOTTER RECORDS"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(950, 10)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 40)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'pnlEditor
        '
        Me.pnlEditor.BackColor = System.Drawing.Color.White
        Me.pnlEditor.Controls.Add(Me.btnResolve)
        Me.pnlEditor.Controls.Add(Me.btnSave)
        Me.pnlEditor.Controls.Add(Me.cbStatus)
        Me.pnlEditor.Controls.Add(Me.Label5)
        Me.pnlEditor.Controls.Add(Me.pnlLine2)
        Me.pnlEditor.Controls.Add(Me.txtNarrative)
        Me.pnlEditor.Controls.Add(Me.Label4)
        Me.pnlEditor.Controls.Add(Me.pnlLine1)
        Me.pnlEditor.Controls.Add(Me.txtType)
        Me.pnlEditor.Controls.Add(Me.Label3)
        Me.pnlEditor.Controls.Add(Me.Label2)
        Me.pnlEditor.Controls.Add(Me.cbRespondent)
        Me.pnlEditor.Controls.Add(Me.Label1)
        Me.pnlEditor.Controls.Add(Me.cbComplainant)
        Me.pnlEditor.Controls.Add(Me.Label6)
        Me.pnlEditor.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlEditor.Location = New System.Drawing.Point(650, 60)
        Me.pnlEditor.Name = "pnlEditor"
        Me.pnlEditor.Size = New System.Drawing.Size(350, 540)
        Me.pnlEditor.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185)
        Me.Label6.Location = New System.Drawing.Point(20, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "File / Edit Case"
        '
        'cbComplainant
        '
        Me.cbComplainant.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbComplainant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbComplainant.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbComplainant.FormattingEnabled = True
        Me.cbComplainant.Location = New System.Drawing.Point(25, 80)
        Me.cbComplainant.Name = "cbComplainant"
        Me.cbComplainant.Size = New System.Drawing.Size(300, 25)
        Me.cbComplainant.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(22, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Complainant"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(22, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Respondent"
        '
        'cbRespondent
        '
        Me.cbRespondent.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbRespondent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbRespondent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbRespondent.FormattingEnabled = True
        Me.cbRespondent.Location = New System.Drawing.Point(25, 140)
        Me.cbRespondent.Name = "cbRespondent"
        Me.cbRespondent.Size = New System.Drawing.Size(300, 25)
        Me.cbRespondent.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(22, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Incident Type"
        '
        'txtType
        '
        Me.txtType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtType.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtType.Location = New System.Drawing.Point(25, 200)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(300, 20)
        Me.txtType.TabIndex = 6
        '
        'pnlLine1
        '
        Me.pnlLine1.BackColor = System.Drawing.Color.Silver
        Me.pnlLine1.Location = New System.Drawing.Point(25, 222)
        Me.pnlLine1.Name = "pnlLine1"
        Me.pnlLine1.Size = New System.Drawing.Size(300, 2)
        Me.pnlLine1.TabIndex = 7
        '
        'pnlLine2
        '
        Me.pnlLine2.BackColor = System.Drawing.Color.Silver
        Me.pnlLine2.Location = New System.Drawing.Point(25, 332)
        Me.pnlLine2.Name = "pnlLine2"
        Me.pnlLine2.Size = New System.Drawing.Size(300, 2)
        Me.pnlLine2.TabIndex = 10
        '
        'txtNarrative
        '
        Me.txtNarrative.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNarrative.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNarrative.Location = New System.Drawing.Point(25, 260)
        Me.txtNarrative.Multiline = True
        Me.txtNarrative.Name = "txtNarrative"
        Me.txtNarrative.Size = New System.Drawing.Size(300, 70)
        Me.txtNarrative.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(22, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Description / Narrative"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(22, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Case Status"
        '
        'cbStatus
        '
        Me.cbStatus.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Pending", "Resolved", "Dismissed"})
        Me.cbStatus.Location = New System.Drawing.Point(25, 370)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(300, 25)
        Me.cbStatus.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(231, 76, 60)
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(25, 420)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(300, 40)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "FILE NEW CASE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnResolve
        '
        Me.btnResolve.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
        Me.btnResolve.FlatAppearance.BorderSize = 0
        Me.btnResolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResolve.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnResolve.ForeColor = System.Drawing.Color.White
        Me.btnResolve.Location = New System.Drawing.Point(25, 470)
        Me.btnResolve.Name = "btnResolve"
        Me.btnResolve.Size = New System.Drawing.Size(300, 40)
        Me.btnResolve.TabIndex = 14
        Me.btnResolve.Text = "MARK AS RESOLVED"
        Me.btnResolve.UseVisualStyleBackColor = False
        '
        'dgvCases
        '
        Me.dgvCases.AllowUserToAddRows = False
        Me.dgvCases.AllowUserToDeleteRows = False
        Me.dgvCases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCases.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvCases.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185)
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCases.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCases.ColumnHeadersHeight = 40
        Me.dgvCases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCases.EnableHeadersVisualStyles = False
        Me.dgvCases.Location = New System.Drawing.Point(0, 60)
        Me.dgvCases.Name = "dgvCases"
        Me.dgvCases.ReadOnly = True
        Me.dgvCases.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(230, 240, 250)
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvCases.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCases.RowTemplate.Height = 35
        Me.dgvCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCases.Size = New System.Drawing.Size(650, 540)
        Me.dgvCases.TabIndex = 2
        '
        'frmBlotter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.dgvCases)
        Me.Controls.Add(Me.pnlEditor)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBlotter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blotter Manager"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlEditor.ResumeLayout(False)
        Me.pnlEditor.PerformLayout()
        CType(Me.dgvCases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlEditor As Panel
    Friend WithEvents dgvCases As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cbComplainant As ComboBox
    Friend WithEvents cbRespondent As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents pnlLine1 As Panel
    Friend WithEvents pnlLine2 As Panel
    Friend WithEvents txtNarrative As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnResolve As Button
    Friend WithEvents Label6 As Label
End Class