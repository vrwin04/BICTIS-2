Imports System.Collections.Generic

Public Class frmReportConcern
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' VALIDATION CONDITION
        If String.IsNullOrWhiteSpace(cbType.Text) OrElse String.IsNullOrWhiteSpace(txtNarrative.Text) Then
            MessageBox.Show("Please select a category and enter the details of your concern.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Insert
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