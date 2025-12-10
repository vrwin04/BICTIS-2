Imports System.Collections.Generic

Public Class frmBlotter
    Private Sub frmBlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDropdowns()
        LoadIncidents()
        cbStatus.SelectedIndex = 0
        cbIncidentType.SelectedIndex = 0 ' Default to first item
    End Sub

    Private Sub LoadDropdowns()
        ' 1. LOAD RESIDENTS (Respondents)
        Dim dt As DataTable = Session.GetDataTable("SELECT ResidentID, FullName FROM tblResidents WHERE Role='User'")
        cbRespondent.DataSource = dt
        cbRespondent.DisplayMember = "FullName"
        cbRespondent.ValueMember = "ResidentID"

        ' 2. LOAD DEPARTMENTS (Complainants)
        cbComplainant.Items.Clear()
        cbComplainant.Items.Add("Peace and Order Committee")
        cbComplainant.Items.Add("Lupon Tagapamayapa")
        cbComplainant.Items.Add("Barangay Health Office")
        cbComplainant.Items.Add("VAWC Desk")
        cbComplainant.Items.Add("Barangay Tanod")
        cbComplainant.Items.Add("Office of the Captain")
        cbComplainant.SelectedIndex = 0
    End Sub

    Private Sub LoadIncidents()
        ' Show readable names in Grid
        Dim sql As String = "SELECT i.IncidentID, i.IncidentType, u.FullName AS Respondent, i.Status, i.IncidentDate " &
                            "FROM tblIncidents i " &
                            "LEFT JOIN tblResidents u ON i.RespondentID = u.ResidentID " &
                            "ORDER BY i.IncidentID DESC"
        dgvCases.DataSource = Session.GetDataTable(sql)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validation
        If cbRespondent.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a Respondent (Resident).", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If cbIncidentType.Text = "" Then
            MessageBox.Show("Please select an Incident Type.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' FILE CASE
        Dim narrative As String = "[Filed by: " & cbComplainant.Text & "] " & txtNarrative.Text
        Dim query As String = "INSERT INTO tblIncidents (ComplainantID, RespondentID, IncidentType, Narrative, Status, IncidentDate) " &
                              "VALUES (@comp, @resp, @type, @narr, @stat, @date)"

        Dim params As New Dictionary(Of String, Object)
        params.Add("@comp", Session.CurrentResidentID) ' Admin ID
        params.Add("@resp", cbRespondent.SelectedValue)
        params.Add("@type", cbIncidentType.Text) ' NOW USING DROPDOWN
        params.Add("@narr", narrative)
        params.Add("@stat", cbStatus.Text)
        params.Add("@date", DateTime.Now.ToString())

        If Session.ExecuteQuery(query, params) Then
            MessageBox.Show("Case Filed Successfully! Resident is now blocked from clearances.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadIncidents()
            txtNarrative.Clear()
        End If
    End Sub

    Private Sub btnResolve_Click(sender As Object, e As EventArgs) Handles btnResolve.Click
        If dgvCases.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a case to resolve.", "Select Case", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim id As Integer = Convert.ToInt32(dgvCases.SelectedRows(0).Cells("IncidentID").Value)

        If MessageBox.Show("Mark this case as RESOLVED?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Session.ExecuteQuery("UPDATE tblIncidents SET Status='Resolved' WHERE IncidentID=" & id)
            LoadIncidents()
            MessageBox.Show("Case Resolved.", "Updated")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class