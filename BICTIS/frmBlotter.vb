Imports System.Collections.Generic

Public Class frmBlotter
    Private Sub frmBlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDropdowns()
        LoadIncidents()
        cbStatus.SelectedIndex = 0
        cbIncidentType.SelectedIndex = 0
    End Sub

    Private Sub LoadDropdowns()
        ' 1. SETUP COMPLAINANT (The Resident filing the case)
        ' We load residents from the database
        Dim dt As DataTable = Session.GetDataTable("SELECT ResidentID, FullName FROM tblResidents WHERE Role='User'")
        cbComplainant.DataSource = dt
        cbComplainant.DisplayMember = "FullName"
        cbComplainant.ValueMember = "ResidentID"

        ' 2. SETUP RESPONDENT (The Department/Official being reported)
        ' We load the hardcoded Barangay Departments here
        cbRespondent.DataSource = Nothing
        cbRespondent.Items.Clear()
        cbRespondent.Items.AddRange(New String() {"Peace and Order Committee", "Lupon Tagapamayapa", "Barangay Health Office", "VAWC Desk", "Barangay Tanod", "Office of the Captain", "Barangay Treasurer", "Barangay Secretary"})
        cbRespondent.SelectedIndex = 0
    End Sub

    Private Sub LoadIncidents()
        ' FIX: Join with tblResidents ON ComplainantID (Since Complainant is now the Resident)
        ' We display the Resident's Name as "Complainant"
        Dim sql As String = "SELECT i.IncidentID, i.IncidentType, u.FullName AS Complainant, i.Status, i.IncidentDate, i.Narrative " &
                            "FROM tblIncidents i " &
                            "LEFT JOIN tblResidents u ON i.ComplainantID = u.ResidentID " &
                            "ORDER BY i.IncidentID DESC"
        dgvCases.DataSource = Session.GetDataTable(sql)
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
        ' Logic:
        ' - ComplainantID = The Selected Resident's ID
        ' - RespondentID = 0 (Since Departments don't have IDs in the user table)
        ' - Narrative = We save the [Respondent Department] inside the text so we know who it is.

        Dim respondentName As String = cbRespondent.Text
        Dim finalNarrative As String = "[Respondent: " & respondentName & "] " & txtNarrative.Text

        Dim query As String = "INSERT INTO tblIncidents (ComplainantID, RespondentID, IncidentType, Narrative, Status, IncidentDate) " &
                              "VALUES (@comp, 0, @type, @narr, @stat, @date)"

        Dim params As New Dictionary(Of String, Object)
        params.Add("@comp", cbComplainant.SelectedValue) ' Resident ID
        params.Add("@type", cbIncidentType.Text) ' Fixed: Uses Dropdown
        params.Add("@narr", finalNarrative)
        params.Add("@stat", cbStatus.Text)
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
            MessageBox.Show("Please select a case from the list to resolve.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim id As Integer = Convert.ToInt32(dgvCases.SelectedRows(0).Cells("IncidentID").Value)

        If MessageBox.Show("Mark this case as RESOLVED?", "Confirm Resolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Session.ExecuteQuery("UPDATE tblIncidents SET Status='Resolved' WHERE IncidentID=" & id)
            LoadIncidents()
            MessageBox.Show("Case Closed.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class