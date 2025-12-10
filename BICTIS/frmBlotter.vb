Imports System.Collections.Generic

Public Class frmBlotter
    Private Sub frmBlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDropdowns()
        LoadIncidents()
        cbStatus.SelectedIndex = 0
    End Sub

    Private Sub LoadDropdowns()
        ' FIX: Select ResidentID (not UserID)
        Dim dt As DataTable = Session.GetDataTable("SELECT ResidentID, FullName FROM tblResidents WHERE Role='User'")
        cbRespondent.DataSource = dt
        cbRespondent.DisplayMember = "FullName"
        cbRespondent.ValueMember = "ResidentID"

        cbComplainant.Items.Clear()
        cbComplainant.Items.AddRange(New String() {"Peace and Order Committee", "Lupon Tagapamayapa", "Barangay Health Office", "VAWC Desk", "Barangay Tanod", "Office of the Captain"})
        cbComplainant.SelectedIndex = 0
    End Sub

    Private Sub LoadIncidents()
        ' FIX: Join with tblResidents ON ResidentID
        Dim sql As String = "SELECT i.IncidentID, i.IncidentType, u.FullName AS Respondent, i.Status, i.IncidentDate, i.Narrative FROM tblIncidents i LEFT JOIN tblResidents u ON i.RespondentID = u.ResidentID ORDER BY i.IncidentID DESC"
        dgvCases.DataSource = Session.GetDataTable(sql)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cbRespondent.SelectedValue Is Nothing Or txtType.Text = "" Then
            MessageBox.Show("Fill all fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim narrative As String = "[Filed by: " & cbComplainant.Text & "] " & txtNarrative.Text
        Dim query As String = "INSERT INTO tblIncidents (ComplainantID, RespondentID, IncidentType, Narrative, Status, IncidentDate) VALUES (@comp, @resp, @type, @narr, @stat, @date)"

        Dim params As New Dictionary(Of String, Object)
        params.Add("@comp", Session.CurrentResidentID)
        params.Add("@resp", cbRespondent.SelectedValue)
        params.Add("@type", txtType.Text)
        params.Add("@narr", narrative)
        params.Add("@stat", cbStatus.Text)
        params.Add("@date", DateTime.Now.ToString())

        If Session.ExecuteQuery(query, params) Then
            MessageBox.Show("Case Filed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadIncidents()
            txtType.Clear()
            txtNarrative.Clear()
        End If
    End Sub

    Private Sub btnResolve_Click(sender As Object, e As EventArgs) Handles btnResolve.Click
        If dgvCases.SelectedRows.Count = 0 Then Exit Sub
        Dim id As Integer = Convert.ToInt32(dgvCases.SelectedRows(0).Cells("IncidentID").Value)

        If MessageBox.Show("Mark RESOLVED?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Session.ExecuteQuery("UPDATE tblIncidents SET Status='Resolved' WHERE IncidentID=" & id)
            LoadIncidents()
            MessageBox.Show("Case Resolved.", "Success")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class