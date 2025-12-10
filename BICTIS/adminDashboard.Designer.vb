' ALIAS TO FIX CHART ERRORS
Imports SysChart = System.Windows.Forms.DataVisualization.Charting

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminDashboard
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
        Dim ChartArea1 As SysChart.ChartArea = New SysChart.ChartArea()
        Dim Legend1 As SysChart.Legend = New SysChart.Legend()
        Dim Series1 As SysChart.Series = New SysChart.Series()
        Me.pnlBorder = New System.Windows.Forms.Panel()
        Me.pnlMainContent = New System.Windows.Forms.Panel()
        Me.pnlChartSection = New System.Windows.Forms.Panel()
        Me.chartIncidents = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlFilterBar = New System.Windows.Forms.Panel()
        Me.cbIncidentType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblChartTitle = New System.Windows.Forms.Label()
        Me.pnlStatsRow = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlCard1 = New System.Windows.Forms.Panel()
        Me.lblTotalUsers = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlCard2 = New System.Windows.Forms.Panel()
        Me.lblPendingCases = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblPageTitle = New System.Windows.Forms.Label()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnClearance = New System.Windows.Forms.Button()
        Me.btnBlotter = New System.Windows.Forms.Button()
        Me.btnResidents = New System.Windows.Forms.Button()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.pnlBorder.SuspendLayout()
        Me.pnlMainContent.SuspendLayout()
        Me.pnlChartSection.SuspendLayout()
        CType(Me.chartIncidents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilterBar.SuspendLayout()
        Me.pnlStatsRow.SuspendLayout()
        Me.pnlCard1.SuspendLayout()
        Me.pnlCard2.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBorder
        '
        Me.pnlBorder.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlBorder.Controls.Add(Me.pnlMainContent)
        Me.pnlBorder.Controls.Add(Me.pnlHeader)
        Me.pnlBorder.Controls.Add(Me.pnlSidebar)
        Me.pnlBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBorder.Location = New System.Drawing.Point(2, 2)
        Me.pnlBorder.Name = "pnlBorder"
        Me.pnlBorder.Size = New System.Drawing.Size(1196, 696)
        Me.pnlBorder.TabIndex = 0
        '
        'pnlMainContent
        '
        Me.pnlMainContent.Controls.Add(Me.pnlChartSection)
        Me.pnlMainContent.Controls.Add(Me.pnlStatsRow)
        Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainContent.Location = New System.Drawing.Point(240, 70)
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlMainContent.Size = New System.Drawing.Size(956, 626)
        Me.pnlMainContent.TabIndex = 2
        '
        'pnlChartSection
        '
        Me.pnlChartSection.BackColor = System.Drawing.Color.White
        Me.pnlChartSection.Controls.Add(Me.chartIncidents)
        Me.pnlChartSection.Controls.Add(Me.pnlFilterBar)
        Me.pnlChartSection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlChartSection.Location = New System.Drawing.Point(20, 160)
        Me.pnlChartSection.Name = "pnlChartSection"
        Me.pnlChartSection.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlChartSection.Size = New System.Drawing.Size(916, 446)
        Me.pnlChartSection.TabIndex = 1
        '
        'chartIncidents
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartIncidents.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartIncidents.Legends.Add(Legend1)
        Me.chartIncidents.Location = New System.Drawing.Point(13, 66)
        Me.chartIncidents.Name = "chartIncidents"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartIncidents.Series.Add(Series1)
        Me.chartIncidents.Size = New System.Drawing.Size(880, 350)
        Me.chartIncidents.TabIndex = 1
        Me.chartIncidents.Text = "Chart1"
        '
        'pnlFilterBar
        '
        Me.pnlFilterBar.Controls.Add(Me.cbIncidentType)
        Me.pnlFilterBar.Controls.Add(Me.Label2)
        Me.pnlFilterBar.Controls.Add(Me.lblChartTitle)
        Me.pnlFilterBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilterBar.Location = New System.Drawing.Point(10, 10)
        Me.pnlFilterBar.Name = "pnlFilterBar"
        Me.pnlFilterBar.Size = New System.Drawing.Size(896, 50)
        Me.pnlFilterBar.TabIndex = 0
        '
        'cbIncidentType
        '
        Me.cbIncidentType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbIncidentType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbIncidentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIncidentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbIncidentType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbIncidentType.FormattingEnabled = True
        Me.cbIncidentType.Location = New System.Drawing.Point(680, 12)
        Me.cbIncidentType.Name = "cbIncidentType"
        Me.cbIncidentType.Size = New System.Drawing.Size(200, 25)
        Me.cbIncidentType.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(590, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Filter Graph:"
        '
        'lblChartTitle
        '
        Me.lblChartTitle.AutoSize = True
        Me.lblChartTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblChartTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblChartTitle.Location = New System.Drawing.Point(10, 12)
        Me.lblChartTitle.Name = "lblChartTitle"
        Me.lblChartTitle.Size = New System.Drawing.Size(147, 21)
        Me.lblChartTitle.TabIndex = 0
        Me.lblChartTitle.Text = "Incident Analytics"
        '
        'pnlStatsRow
        '
        Me.pnlStatsRow.Controls.Add(Me.pnlCard1)
        Me.pnlStatsRow.Controls.Add(Me.pnlCard2)
        Me.pnlStatsRow.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStatsRow.Location = New System.Drawing.Point(20, 20)
        Me.pnlStatsRow.Name = "pnlStatsRow"
        Me.pnlStatsRow.Size = New System.Drawing.Size(916, 140)
        Me.pnlStatsRow.TabIndex = 0
        '
        'pnlCard1
        '
        Me.pnlCard1.BackColor = System.Drawing.Color.White
        Me.pnlCard1.Controls.Add(Me.lblTotalUsers)
        Me.pnlCard1.Controls.Add(Me.Label1)
        Me.pnlCard1.Controls.Add(Me.Panel1)
        Me.pnlCard1.Location = New System.Drawing.Point(3, 3)
        Me.pnlCard1.Margin = New System.Windows.Forms.Padding(3, 3, 20, 3)
        Me.pnlCard1.Name = "pnlCard1"
        Me.pnlCard1.Size = New System.Drawing.Size(250, 120)
        Me.pnlCard1.TabIndex = 0
        '
        'lblTotalUsers
        '
        Me.lblTotalUsers.AutoSize = True
        Me.lblTotalUsers.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.lblTotalUsers.Location = New System.Drawing.Point(20, 40)
        Me.lblTotalUsers.Name = "lblTotalUsers"
        Me.lblTotalUsers.Size = New System.Drawing.Size(56, 65)
        Me.lblTotalUsers.TabIndex = 1
        Me.lblTotalUsers.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(20, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL RESIDENTS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 120)
        Me.Panel1.TabIndex = 2
        '
        'pnlCard2
        '
        Me.pnlCard2.BackColor = System.Drawing.Color.White
        Me.pnlCard2.Controls.Add(Me.lblPendingCases)
        Me.pnlCard2.Controls.Add(Me.Label3)
        Me.pnlCard2.Controls.Add(Me.Panel2)
        Me.pnlCard2.Location = New System.Drawing.Point(276, 3)
        Me.pnlCard2.Name = "pnlCard2"
        Me.pnlCard2.Size = New System.Drawing.Size(250, 120)
        Me.pnlCard2.TabIndex = 1
        '
        'lblPendingCases
        '
        Me.lblPendingCases.AutoSize = True
        Me.lblPendingCases.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblPendingCases.ForeColor = System.Drawing.Color.Crimson
        Me.lblPendingCases.Location = New System.Drawing.Point(20, 40)
        Me.lblPendingCases.Name = "lblPendingCases"
        Me.lblPendingCases.Size = New System.Drawing.Size(56, 65)
        Me.lblPendingCases.TabIndex = 1
        Me.lblPendingCases.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(20, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "PENDING CASES"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Crimson
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 120)
        Me.Panel2.TabIndex = 2
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblPageTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(240, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(956, 70)
        Me.pnlHeader.TabIndex = 1
        '
        'lblPageTitle
        '
        Me.lblPageTitle.AutoSize = True
        Me.lblPageTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblPageTitle.Location = New System.Drawing.Point(25, 20)
        Me.lblPageTitle.Name = "lblPageTitle"
        Me.lblPageTitle.Size = New System.Drawing.Size(199, 30)
        Me.lblPageTitle.TabIndex = 0
        Me.lblPageTitle.Text = "Admin Dashboard"
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnClearance)
        Me.pnlSidebar.Controls.Add(Me.btnBlotter)
        Me.pnlSidebar.Controls.Add(Me.btnResidents)
        Me.pnlSidebar.Controls.Add(Me.pnlLogo)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(240, 696)
        Me.pnlSidebar.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.LightGray
        Me.btnLogout.Location = New System.Drawing.Point(0, 636)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(240, 60)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Sign Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnClearance
        '
        Me.btnClearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnClearance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClearance.FlatAppearance.BorderSize = 0
        Me.btnClearance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnClearance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnClearance.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnClearance.Location = New System.Drawing.Point(0, 200)
        Me.btnClearance.Name = "btnClearance"
        Me.btnClearance.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnClearance.Size = New System.Drawing.Size(240, 60)
        Me.btnClearance.TabIndex = 3
        Me.btnClearance.Text = "Manage Clearances"
        Me.btnClearance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClearance.UseVisualStyleBackColor = False
        '
        'btnBlotter
        '
        Me.btnBlotter.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnBlotter.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBlotter.FlatAppearance.BorderSize = 0
        Me.btnBlotter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnBlotter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlotter.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnBlotter.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnBlotter.Location = New System.Drawing.Point(0, 140)
        Me.btnBlotter.Name = "btnBlotter"
        Me.btnBlotter.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnBlotter.Size = New System.Drawing.Size(240, 60)
        Me.btnBlotter.TabIndex = 2
        Me.btnBlotter.Text = "Incident Blotter"
        Me.btnBlotter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBlotter.UseVisualStyleBackColor = False
        '
        'btnResidents
        '
        Me.btnResidents.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnResidents.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnResidents.FlatAppearance.BorderSize = 0
        Me.btnResidents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnResidents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResidents.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnResidents.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnResidents.Location = New System.Drawing.Point(0, 80)
        Me.btnResidents.Name = "btnResidents"
        Me.btnResidents.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnResidents.Size = New System.Drawing.Size(240, 60)
        Me.btnResidents.TabIndex = 1
        Me.btnResidents.Text = "Manage Residents"
        Me.btnResidents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResidents.UseVisualStyleBackColor = False
        '
        'pnlLogo
        '
        Me.pnlLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.pnlLogo.Controls.Add(Me.lblLogo)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(240, 80)
        Me.pnlLogo.TabIndex = 0
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogo.ForeColor = System.Drawing.Color.White
        Me.lblLogo.Location = New System.Drawing.Point(65, 20)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(111, 37)
        Me.lblLogo.TabIndex = 0
        Me.lblLogo.Text = "ADMIN"
        '
        'adminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.pnlBorder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminDashboard"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Dashboard"
        Me.pnlBorder.ResumeLayout(False)
        Me.pnlMainContent.ResumeLayout(False)
        Me.pnlChartSection.ResumeLayout(False)
        CType(Me.chartIncidents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilterBar.ResumeLayout(False)
        Me.pnlFilterBar.PerformLayout()
        Me.pnlStatsRow.ResumeLayout(False)
        Me.pnlCard1.ResumeLayout(False)
        Me.pnlCard1.PerformLayout()
        Me.pnlCard2.ResumeLayout(False)
        Me.pnlCard2.PerformLayout()
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
    Friend WithEvents lblLogo As Label
    Friend WithEvents btnBlotter As Button
    Friend WithEvents btnResidents As Button
    Friend WithEvents btnClearance As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents pnlMainContent As Panel
    Friend WithEvents pnlStatsRow As FlowLayoutPanel
    Friend WithEvents pnlCard1 As Panel
    Friend WithEvents lblTotalUsers As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlCard2 As Panel
    Friend WithEvents lblPendingCases As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlChartSection As Panel
    Friend WithEvents pnlFilterBar As Panel
    Friend WithEvents cbIncidentType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblChartTitle As Label
    ' IMPORTANT: Use the Alias here!
    Friend WithEvents chartIncidents As SysChart.Chart
End Class