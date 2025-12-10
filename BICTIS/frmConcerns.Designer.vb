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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        btnClose = New Button()
        lblTitle = New Label()
        pnlEditor = New Panel()
        Label6 = New Label()
        btnUpdate = New Button()
        cbStatus = New ComboBox()
        Label5 = New Label()
        pnlGrid = New Panel()
        dgvCases = New DataGridView()
        pnlHeader.SuspendLayout()
        pnlEditor.SuspendLayout()
        pnlGrid.SuspendLayout()
        CType(dgvCases, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        pnlHeader.Controls.Add(btnClose)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(900, 70)
        pnlHeader.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(840, 15)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(40, 40)
        btnClose.TabIndex = 1
        btnClose.Text = "X"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(20, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(239, 30)
        lblTitle.TabIndex = 0
        lblTitle.Text = "RESIDENT CONCERNS"
        ' 
        ' pnlEditor
        ' 
        pnlEditor.BackColor = Color.White
        pnlEditor.Controls.Add(Label6)
        pnlEditor.Controls.Add(btnUpdate)
        pnlEditor.Controls.Add(cbStatus)
        pnlEditor.Controls.Add(Label5)
        pnlEditor.Dock = DockStyle.Right
        pnlEditor.Location = New Point(600, 70)
        pnlEditor.Name = "pnlEditor"
        pnlEditor.Size = New Size(300, 530)
        pnlEditor.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label6.ForeColor = Color.Gray
        Label6.Location = New Point(20, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 21)
        Label6.TabIndex = 0
        Label6.Text = "Take Action"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(25, 130)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(250, 45)
        btnUpdate.TabIndex = 12
        btnUpdate.Text = "UPDATE STATUS"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' cbStatus
        ' 
        cbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbStatus.Font = New Font("Segoe UI", 11F)
        cbStatus.FormattingEnabled = True
        cbStatus.Location = New Point(25, 80)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(250, 28)
        cbStatus.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.ForeColor = Color.Gray
        Label5.Location = New Point(22, 55)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 19)
        Label5.TabIndex = 13
        Label5.Text = "Set Status To:"
        ' 
        ' pnlGrid
        ' 
        pnlGrid.BackColor = Color.WhiteSmoke
        pnlGrid.Controls.Add(dgvCases)
        pnlGrid.Dock = DockStyle.Fill
        pnlGrid.Location = New Point(0, 70)
        pnlGrid.Name = "pnlGrid"
        pnlGrid.Padding = New Padding(20)
        pnlGrid.Size = New Size(600, 530)
        pnlGrid.TabIndex = 2
        ' 
        ' dgvCases
        ' 
        dgvCases.AllowUserToAddRows = False
        dgvCases.AllowUserToDeleteRows = False
        dgvCases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCases.BackgroundColor = Color.White
        dgvCases.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(41), CByte(128), CByte(185))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        dgvCases.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvCases.ColumnHeadersHeight = 40
        dgvCases.Dock = DockStyle.Fill
        dgvCases.EnableHeadersVisualStyles = False
        dgvCases.Location = New Point(20, 20)
        dgvCases.Name = "dgvCases"
        dgvCases.ReadOnly = True
        dgvCases.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(200), CByte(230), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        dgvCases.RowsDefaultCellStyle = DataGridViewCellStyle2
        dgvCases.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCases.Size = New Size(560, 490)
        dgvCases.TabIndex = 0
        ' 
        ' frmConcerns
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(900, 600)
        Controls.Add(pnlGrid)
        Controls.Add(pnlEditor)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmConcerns"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Concerns"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlEditor.ResumeLayout(False)
        pnlEditor.PerformLayout()
        pnlGrid.ResumeLayout(False)
        CType(dgvCases, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

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