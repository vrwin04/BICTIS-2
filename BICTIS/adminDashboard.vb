' ALIAS TO FIX CHART ERRORS
Imports SysChart = System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms
Imports System.Data
Imports System.Collections.Generic
Imports System.Threading.Tasks ' Required for Async
Imports System.Drawing ' Required for Color

Public Class adminDashboard
    Private Async Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPageTitle.Text = "Dashboard - " & Session.CurrentUserRole

        Try
            ' Load Filters first (Fast, no DB)
            LoadFilterOptions()

            ' Run DB tasks concurrently for speed
            Dim taskStats = LoadStatsAsync()
            Dim taskChart = LoadChartAsync()

            Await Task.WhenAll(taskStats, taskChart)

        Catch ex As Exception
            MessageBox.Show("Error loading dashboard: " & ex.Message)
        End Try
    End Sub

    Private Async Function LoadStatsAsync() As Task
        ' Fetch both counts in parallel
        Dim taskUserCount = Session.GetCountAsync("SELECT COUNT(*) FROM tblResidents WHERE Role='User'")
        Dim taskPending = Session.GetCountAsync("SELECT COUNT(*) FROM tblIncidents WHERE Status='Pending'")

        ' Wait for both
        Dim userCount As Integer = Await taskUserCount
        Dim pending As Integer = Await taskPending

        ' Update UI
        lblTotalUsers.Text = userCount.ToString()
        lblPendingCases.Text = pending.ToString()

        If pending > 0 Then
            lblPendingCases.ForeColor = Color.Red
        Else
            lblPendingCases.ForeColor = Color.Green
        End If
    End Function

    Private Sub LoadFilterOptions()
        cbIncidentType.Items.Clear()
        cbIncidentType.Items.Add("All Incidents")

        ' --- BLOTTER CASES ---
        cbIncidentType.Items.Add("Physical Injury")
        cbIncidentType.Items.Add("Theft / Robbery")
        cbIncidentType.Items.Add("Property / Land Dispute")
        cbIncidentType.Items.Add("Harassment / Threats")
        cbIncidentType.Items.Add("Unjust Vexation")
        cbIncidentType.Items.Add("Malicious Mischief")
        cbIncidentType.Items.Add("Estafa / Swindling")
        cbIncidentType.Items.Add("Libel / Slander")

        ' --- COMMUNITY CONCERNS ---
        cbIncidentType.Items.Add("Noise Complaint")
        cbIncidentType.Items.Add("Waste Disposal / Trash")
        cbIncidentType.Items.Add("Suspicious Activity")
        cbIncidentType.Items.Add("Public Disturbance")
        cbIncidentType.Items.Add("Broken Street Light / Infrastructure")
        cbIncidentType.Items.Add("Animal Control / Stray Pets")
        cbIncidentType.Items.Add("Curfew Violation")

        cbIncidentType.Items.Add("Other")
        cbIncidentType.SelectedIndex = 0
    End Sub

    Private Async Sub cbIncidentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIncidentType.SelectedIndexChanged
        Await LoadChartAsync()
    End Sub

    Private Async Function LoadChartAsync() As Task
        If chartIncidents Is Nothing Then Exit Function

        ' We need to manipulate the chart on the UI thread, but fetch data Async
        Dim selection As String = cbIncidentType.Text
        Dim query As String
        Dim params As New Dictionary(Of String, Object)
        Dim isAllIncidents As Boolean = (selection = "All Incidents")

        If isAllIncidents Then
            query = "SELECT IncidentType, COUNT(*) as [Count] FROM tblIncidents GROUP BY IncidentType"
        Else
            query = "SELECT Status, COUNT(*) as [Count] FROM tblIncidents WHERE IncidentType=@type GROUP BY Status"
            params.Add("@type", selection)
        End If

        ' Fetch Data Background
        Dim dt As DataTable = Await Session.GetDataTableAsync(query, params)

        ' Update UI
        chartIncidents.Series.Clear()
        chartIncidents.Titles.Clear()

        Dim seriesName As String = If(isAllIncidents, "Incidents", "Status")
        Dim series As New SysChart.Series(seriesName)

        If isAllIncidents Then
            series.ChartType = SysChart.SeriesChartType.Column
            ' We will set colors manually per point below
            chartIncidents.Titles.Add("All Incidents Overview")
        Else
            series.ChartType = SysChart.SeriesChartType.Pie
            chartIncidents.Palette = SysChart.ChartColorPalette.SeaGreen
            chartIncidents.Titles.Add("Status Breakdown: " & selection)
        End If

        series.IsValueShownAsLabel = True

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                Dim xVal As String = If(isAllIncidents, row("IncidentType").ToString(), row("Status").ToString())
                ' Handle nulls
                If String.IsNullOrEmpty(xVal) Then xVal = "Unknown"

                Dim yVal As Integer = Convert.ToInt32(row("Count"))

                ' Add Point
                Dim pIndex As Integer = series.Points.AddXY(xVal, yVal)
                Dim p As SysChart.DataPoint = series.Points(pIndex)

                ' --- COLOR CODING LOGIC ---
                If isAllIncidents Then
                    Select Case xVal
                        ' CRIMES (Reds/Purples)
                        Case "Physical Injury" : p.Color = Color.Crimson
                        Case "Theft / Robbery" : p.Color = Color.DarkRed
                        Case "Harassment / Threats" : p.Color = Color.OrangeRed
                        Case "Unjust Vexation" : p.Color = Color.Purple
                        Case "Malicious Mischief" : p.Color = Color.DarkMagenta
                        Case "Estafa / Swindling" : p.Color = Color.Indigo
                        Case "Libel / Slander" : p.Color = Color.SlateBlue
                        Case "Property / Land Dispute" : p.Color = Color.SaddleBrown

                        ' CONCERNS (Greens/Yellows/Blues)
                        Case "Noise Complaint" : p.Color = Color.DarkOrange
                        Case "Waste Disposal / Trash" : p.Color = Color.ForestGreen
                        Case "Suspicious Activity" : p.Color = Color.DimGray
                        Case "Public Disturbance" : p.Color = Color.Goldenrod
                        Case "Broken Street Light / Infrastructure" : p.Color = Color.Teal
                        Case "Animal Control / Stray Pets" : p.Color = Color.OliveDrab
                        Case "Curfew Violation" : p.Color = Color.MidnightBlue

                        Case Else : p.Color = Color.SteelBlue
                    End Select
                End If
            Next
        Else
            series.Points.AddXY("No Data", 0)
        End If

        chartIncidents.Series.Add(series)
    End Function

    ' --- NAVIGATION BUTTONS ---

    Private Async Sub btnResidents_Click(sender As Object, e As EventArgs) Handles btnResidents.Click
        Dim frm As New frmManageResidents()
        frm.ShowDialog()
        Await LoadStatsAsync()
    End Sub

    Private Async Sub btnBlotter_Click(sender As Object, e As EventArgs) Handles btnBlotter.Click
        Dim frm As New frmBlotter()
        frm.ShowDialog()
        Await LoadStatsAsync()
        Await LoadChartAsync()
    End Sub

    Private Async Sub btnConcerns_Click(sender As Object, e As EventArgs) Handles btnConcerns.Click
        Dim frm As New frmConcerns()
        frm.ShowDialog()
        Await LoadStatsAsync()
        Await LoadChartAsync()
    End Sub

    Private Sub btnClearance_Click(sender As Object, e As EventArgs) Handles btnClearance.Click
        Dim frm As New frmClearance()
        frm.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Sign out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Session.CurrentResidentID = 0
            Dim login As New frmLogin()
            login.Show()
            Me.Close()
        End If
    End Sub
End Class