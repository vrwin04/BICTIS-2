Imports System.Collections.Generic

Public Class frmBlotter
    Private Sub frmBlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDropdowns()
        LoadIncidents()
        ' Trigger the text update initially
        UpdateResolveButtonText()
    End Sub

    Private Sub LoadDropdowns()
        ' 1. SETUP COMPLAINANT (The Resident filing the case)
        Dim dt As DataTable = Session.GetDataTable("SELECT ResidentID, FullName FROM tblResidents WHERE Role='User'")
        cbComplainant.DataSource = dt
        cbComplainant.DisplayMember = "FullName"
        cbComplainant.ValueMember = "ResidentID"

        ' 2. SETUP RESPONDENT
        cbRespondent.DataSource = Nothing
        cbRespondent.Items.Clear()
        cbRespondent.Items.AddRange(New String() {"Peace and Order Committee", "Lupon Tagapamayapa", "Barangay Health Office", "VAWC Desk", "Barangay Tanod", "Office of the Captain", "Barangay Treasurer", "Barangay Secretary"})
        cbRespondent.SelectedIndex = 0

        ' 3. SETUP STATUS (Removed "Pending")
        cbStatus.Items.Clear()
        cbStatus.Items.AddRange(New String() {"Resolved", "Dismissed"})
        cbStatus.SelectedIndex = 0
    End Sub

    Private Sub LoadIncidents()
        ' FIX: Join with tblResidents ON ComplainantID
        Dim sql As String = "SELECT i.IncidentID, i.IncidentType, u.FullName AS Complainant, i.Status, i.IncidentDate, i.Narrative " &
                            "FROM tblIncidents i " &
                            "LEFT JOIN tblResidents u ON i.ComplainantID = u.ResidentID " &
                            "ORDER BY i.IncidentID DESC"

        dgvCases.DataSource = Session.GetDataTable(sql)
    End Sub

    ' NEW: Update button text when dropdown changes
    Private Sub cbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged
        UpdateResolveButtonText()
    End Sub

    Private Sub UpdateResolveButtonText()
        If cbStatus.Text <> "" Then
            btnResolve.Text = "MARK SELECTED AS " & cbStatus.Text.ToUpper()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validation
        If cbComplainant.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a Resident (Complainant).", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If cbIncidentType.Text = "" Then
            MessageBox.Show("Please select an Incident Type.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' FILE THE CASE
        Dim respondentName As String = cbRespondent.Text
        Dim finalNarrative As String = "[Respondent: " & respondentName & "] " & txtNarrative.Text

        Dim query As String = "INSERT INTO tblIncidents (ComplainantID, RespondentID, IncidentType, Narrative, Status, IncidentDate) " &
                              "VALUES (@comp, 0, @type, @narr, @stat, @date)"

        Dim params As New Dictionary(Of String, Object)
        params.Add("@comp", cbComplainant.SelectedValue)
        params.Add("@type", cbIncidentType.Text)
        params.Add("@narr", finalNarrative)
        ' FIX: Automatically set to Pending for new cases
        params.Add("@stat", "Pending")
        params.Add("@date", DateTime.Now.ToString())

        If Session.ExecuteQuery(query, params) Then
            MessageBox.Show("Complaint Filed Successfully!" & vbCrLf &
                            "Complainant: " & cbComplainant.Text & vbCrLf &
                            "Against: " & respondentName,
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh List and Clear Fields
            LoadIncidents()
            txtNarrative.Clear()
        End If
    End Sub

    Private Sub btnResolve_Click(sender As Object, e As EventArgs) Handles btnResolve.Click
        If dgvCases.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a case from the list to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim id As Integer = Convert.ToInt32(dgvCases.SelectedRows(0).Cells("IncidentID").Value)
        Dim newStatus As String = cbStatus.Text

        If MessageBox.Show("Mark this case as " & newStatus.ToUpper() & "?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ' FIX: Use the selected status from the dropdown
            Session.ExecuteQuery("UPDATE tblIncidents SET Status='" & newStatus & "' WHERE IncidentID=" & id)
            LoadIncidents()
            MessageBox.Show("Case updated to " & newStatus & ".", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class