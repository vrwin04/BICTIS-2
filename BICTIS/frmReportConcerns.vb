Imports System.Collections.Generic

' FILENAME: frmReportConcerns.vb
Public Class frmReportConcern
    Private Sub frmReportConcern_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' POPULATE DROPDOWN WITH COMMUNITY CONCERNS ONLY
        cbType.Items.Clear()
        cbType.Items.AddRange(New String() {
            "Noise Complaint",
            "Waste Disposal / Trash",
            "Suspicious Activity",
            "Public Disturbance",
            "Broken Street Light / Infrastructure",
            "Animal Control / Stray Pets",
            "Curfew Violation",
            "Other"
        })
        cbType.SelectedIndex = 0
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' VALIDATION
        If String.IsNullOrWhiteSpace(cbType.Text) OrElse String.IsNullOrWhiteSpace(txtNarrative.Text) Then
            MessageBox.Show("Please select a category and enter the details of your concern.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Save with Category = 'Concern'
        Dim query As String = "INSERT INTO tblIncidents (ComplainantID, RespondentID, IncidentType, Narrative, Status, IncidentDate, Category) " &
                              "VALUES (@uid, 0, @type, @narr, 'Pending', @date, 'Concern')"

        Dim params As New Dictionary(Of String, Object)
        params.Add("@uid", Session.CurrentResidentID)
        params.Add("@type", cbType.Text)
        params.Add("@narr", txtNarrative.Text)
        params.Add("@date", DateTime.Now.ToString())

        If Session.ExecuteQuery(query, params) Then
            MessageBox.Show("Concern reported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class