<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConcerns
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlEditor = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.dgvCases = New System.Windows.Forms.DataGridView()
        Me.pnlHeader.SuspendLayout()
        Me.pnlEditor.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvCases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(41, 128, 185)
        Me.pnlHeader.Controls.Add(Me.btnClose)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(900, 70)
        Me.pnlHeader.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(840, 15)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 40)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "X"
        Me.btnClose.FlatAppearance.BorderSize = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(250, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "RESIDENT CONCERNS"
        '
        'pnlEditor
        '
        Me.pnlEditor.BackColor = System.Drawing.Color.White
        Me.pnlEditor.Controls.Add(Me.Label6)
        Me.pnlEditor.Controls.Add(Me.btnUpdate)
        Me.pnlEditor.Controls.Add(Me.cbStatus)
        Me.pnlEditor.Controls.Add(Me.Label5)
        Me.pnlEditor.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlEditor.Location = New System.Drawing.Point(600, 70)
        Me.pnlEditor.Name = "pnlEditor"
        Me.pnlEditor.Size = New System.Drawing.Size(300, 530)
        Me.pnlEditor.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(20, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Text = "Take Action"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(25, 130)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(250, 45)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "UPDATE STATUS"
        Me.btnUpdate.UseVisualStyleBackColor = False
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        '
        'cbStatus
        '
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(25, 80)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(250, 28)
        Me.cbStatus.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(22, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Text = "Set Status To:"
        '
        'pnlGrid
        '
        Me.pnlGrid.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlGrid.Controls.Add(Me.dgvCases)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(0, 70)
        Me.pnlGrid.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlGrid.Size = New System.Drawing.Size(600, 530)
        Me.pnlGrid.TabIndex = 2
        '
        'dgvCases
        '
        Me.dgvCases.AllowUserToAddRows = False
        Me.dgvCases.AllowUserToDeleteRows = False
        Me.dgvCases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCases.BackgroundColor = System.Drawing.Color.White
        Me.dgvCases.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCases.ColumnHeadersHeight = 40
        Me.dgvCases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCases.EnableHeadersVisualStyles = False
        Me.dgvCases.Location = New System.Drawing.Point(20, 20)
        Me.dgvCases.Name = "dgvCases"
        Me.dgvCases.ReadOnly = True
        Me.dgvCases.RowHeadersVisible = False
        Me.dgvCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCases.Size = New System.Drawing.Size(560, 490)
        Me.dgvCases.TabIndex = 0
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dgvCases.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(200, 230, 255)
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvCases.RowsDefaultCellStyle = DataGridViewCellStyle2
        '
        'frmConcerns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.pnlEditor)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Name = "frmConcerns"
        Me.Text = "Concerns"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlEditor.ResumeLayout(False)
        Me.pnlEditor.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.dgvCases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlEditor As Panel
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents dgvCases As DataGridView
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class