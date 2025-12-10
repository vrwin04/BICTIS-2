Imports System.Collections.Generic

' MUST BE "frmReportConcern" (Singular) to match Designer
Public Class frmReportConcern
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Use cbType because that is the name in Designer
        If cbType.Text = "" Or txtNarrative.Text = "" Then
            MessageBox.Show("Please fill in all details.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2. Save to Database
        Dim query As String = "INSERT INTO tblIncidents (ComplainantID, RespondentID, IncidentType, Narrative, Status, IncidentDate) " &
                              "VALUES (@uid, 0, @type, @narr, 'Pending', @date)"

        Dim params As New Dictionary(Of String, Object)
        params.Add("@uid", Session.CurrentResidentID)
        params.Add("@type", cbType.Text)
        params.Add("@narr", txtNarrative.Text)
        params.Add("@date", DateTime.Now.ToString())

        If Session.ExecuteQuery(query, params) Then
            MessageBox.Show("Your concern has been reported to the Barangay." & vbCrLf &
                            "Please check 'My Blotter Cases' for updates.", "Report Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class