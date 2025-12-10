Imports System.Collections.Generic

Public Class frmBlotter
    Private Sub frmBlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = "BLOTTER CASES (Admin)"
        LoadDropdowns()
        LoadIncidents()
    End Sub

    Private Sub LoadDropdowns()
        ' Setup Status Dropdown
        cbStatus.Items.Clear()
        cbStatus.Items.AddRange(New String() {"Resolved", "Dismissed", "Escalated"})
        cbStatus.SelectedIndex = 0

        ' Setup Complainant (Residents)
        Dim dt As DataTable = Session.GetDataTable("SELECT ResidentID, FullName FROM tblResidents WHERE Role='User'")
        cbComplainant.DataSource = dt
        cbComplainant.DisplayMember = "FullName"
        cbComplainant.ValueMember = "ResidentID"
        cbComplainant.SelectedIndex = -1 ' Start empty

        ' Setup Respondent (Departments/Entities for Admin view)
        cbRespondent.DataSource = Nothing
        cbRespondent.Items.Clear()
        cbRespondent.Items.AddRange(New String() {"Peace and Order Committee", "Lupon Tagapamayapa", "Barangay Health Office", "Resident (See Narrative)"})
        cbRespondent.SelectedIndex = 0
    End Sub

    Private Sub LoadIncidents()
        ' FILTER: Category = 'Blotter'
        Dim sql As String = "SELECT i.IncidentID, i.IncidentType, u.FullName AS Complainant, i.Status, i.IncidentDate, i.Narrative " &
                            "FROM tblIncidents i " &
                            "LEFT JOIN tblResidents u ON i.ComplainantID = u.ResidentID " &
                            "WHERE i.Category='Blotter' " &
                            "ORDER BY i.IncidentID DESC"
        dgvCases.DataSource = Session.GetDataTable(sql)
    End Sub

    ' Button Text Update Logic
    Private Sub cbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged
        If cbStatus.Text <> "" Then
            btnResolve.Text = "SET STATUS TO " & cbStatus.Text.ToUpper()
        End If
    End Sub

    ' FILE NEW CASE LOGIC (Fixed)
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' 1. VALIDATION
        If cbComplainant.SelectedValue Is Nothing OrElse String.IsNullOrWhiteSpace(cbComplainant.Text) Then
            MessageBox.Show("Please select a Complainant (Resident).", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(cbRespondent.Text) Then
            MessageBox.Show("Please select or enter a Respondent.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(cbIncidentType.Text) Then
            MessageBox.Show("Please select an Incident Type.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtNarrative.Text) Then
            MessageBox.Show("Please enter the narrative details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2. PREPARE DATA
        Dim respondentName As String = cbRespondent.Text
        Dim finalNarrative As String = "[Respondent: " & respondentName & "] " & txtNarrative.Text

        ' 3. INSERT (Always 'Pending' and 'Blotter')
        Dim query As String = "INSERT INTO tblIncidents (ComplainantID, RespondentID, IncidentType, Narrative, Status, IncidentDate, Category) " &
                              "VALUES (@comp, 0, @type, @narr, 'Pending', @date, 'Blotter')"

        Dim params As New Dictionary(Of String, Object)
        params.Add("@comp", cbComplainant.SelectedValue)
        params.Add("@type", cbIncidentType.Text)
        params.Add("@narr", finalNarrative)
        params.Add("@date", DateTime.Now.ToString())

        If Session.ExecuteQuery(query, params) Then
            MessageBox.Show("Blotter case filed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear fields
            txtNarrative.Clear()
            cbIncidentType.SelectedIndex = -1
            cbComplainant.SelectedIndex = -1
            LoadIncidents()
        End If
    End Sub

    ' UPDATE STATUS LOGIC
    Private Sub btnResolve_Click(sender As Object, e As EventArgs) Handles btnResolve.Click
        If dgvCases.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a case to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim id As Integer = Convert.ToInt32(dgvCases.SelectedRows(0).Cells("IncidentID").Value)
        Dim currentStatus As String = dgvCases.SelectedRows(0).Cells("Status").Value.ToString()
        Dim newStatus As String = cbStatus.Text

        ' Prevent changing closed cases
        If currentStatus <> "Pending" Then
            MessageBox.Show("This case is already closed (" & currentStatus & ") and cannot be modified.", "Locked", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If MessageBox.Show("Mark case as " & newStatus & "? This cannot be undone.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Session.ExecuteQuery("UPDATE tblIncidents SET Status='" & newStatus & "' WHERE IncidentID=" & id)
            LoadIncidents()
            MessageBox.Show("Case updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class