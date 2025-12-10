' ALIAS TO FIX CHART ERRORS
Imports SysChart = System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms
Imports System.Data
Imports System.Collections.Generic

Public Class adminDashboard
    Private Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPageTitle.Text = "Dashboard - " & Session.CurrentUserRole

        Try
            LoadStats()
            LoadFilterOptions()
            LoadChart() ' Initial Load (All)
        Catch ex As Exception
            MessageBox.Show("Error loading dashboard: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadStats()
        ' Count Users (Residents)
        Dim userCount As Integer = Session.GetCount("SELECT COUNT(*) FROM tblResidents WHERE Role='User'")
        lblTotalUsers.Text = userCount.ToString()

        ' Count Pending Cases
        Dim pending As Integer = Session.GetCount("SELECT COUNT(*) FROM tblIncidents WHERE Status='Pending'")
        lblPendingCases.Text = pending.ToString()

        ' Visual Alert
        If pending > 0 Then
            lblPendingCases.ForeColor = Color.Red
        Else
            lblPendingCases.ForeColor = Color.Green
        End If
    End Sub

    Private Sub LoadFilterOptions()
        ' Hardcode or Fetch from DB. Here we hardcode for simplicity + "All"
        cbIncidentType.Items.Clear()
        cbIncidentType.Items.Add("All Incidents")
        cbIncidentType.Items.Add("Noise Complaint")
        cbIncidentType.Items.Add("Waste Disposal")
        cbIncidentType.Items.Add("Neighborhood Dispute")
        cbIncidentType.Items.Add("Suspicious Activity")
        cbIncidentType.Items.Add("Other")
        cbIncidentType.SelectedIndex = 0 ' Default to All
    End Sub

    Private Sub cbIncidentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIncidentType.SelectedIndexChanged
        LoadChart()
    End Sub

    Private Sub LoadChart()
        If chartIncidents Is Nothing Then Exit Sub

        chartIncidents.Series.Clear()
        chartIncidents.Titles.Clear()

        Dim selection As String = cbIncidentType.Text

        If selection = "All Incidents" Then
            ' MODE 1: Show Bar Chart of ALL Types
            Dim query As String = "SELECT IncidentType, COUNT(*) as [Count] FROM tblIncidents GROUP BY IncidentType"
            Dim dt As DataTable = Session.GetDataTable(query)

            Dim series As New SysChart.Series("Incidents")
            series.ChartType = SysChart.SeriesChartType.Column
            series.IsValueShownAsLabel = True
            series.Color = Color.FromArgb(41, 128, 185)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    Dim iType As String = If(IsDBNull(row("IncidentType")), "Unknown", row("IncidentType").ToString())
                    Dim iCount As Integer = Convert.ToInt32(row("Count"))
                    series.Points.AddXY(iType, iCount)
                Next
            End If
            chartIncidents.Series.Add(series)
            chartIncidents.Titles.Add("All Incidents Overview")

        Else
            ' MODE 2: Show Pie Chart of STATUS for Selected Type
            Dim query As String = "SELECT Status, COUNT(*) as [Count] FROM tblIncidents WHERE IncidentType=@type GROUP BY Status"
            Dim params As New Dictionary(Of String, Object)
            params.Add("@type", selection)

            Dim dt As DataTable = Session.GetDataTable(query, params)

            Dim series As New SysChart.Series("Status")
            series.ChartType = SysChart.SeriesChartType.Pie
            series.IsValueShownAsLabel = True

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    series.Points.AddXY(row("Status").ToString(), row("Count"))
                Next
            Else
                ' Show empty placeholder if no data
                series.Points.AddXY("No Data", 0)
            End If

            chartIncidents.Series.Add(series)
            chartIncidents.Titles.Add("Status Breakdown: " & selection)
        End If
    End Sub

    ' --- NAVIGATION BUTTONS ---

    Private Sub btnResidents_Click(sender As Object, e As EventArgs) Handles btnResidents.Click
        Dim frm As New frmManageResidents()
        frm.ShowDialog()
        LoadStats()
    End Sub

    Private Sub btnBlotter_Click(sender As Object, e As EventArgs) Handles btnBlotter.Click
        Dim frm As New frmBlotter()
        frm.ShowDialog()
        LoadStats()
        LoadChart()
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