Imports System.Collections.Generic

Public Class frmCaseDetails
    Public Sub LoadData(incidentID As Integer)
        ' Load full details from DB including Complainant Name
        Dim query As String = "SELECT i.IncidentType, i.Narrative, i.Status, i.IncidentDate, i.Category, u.FullName " &
                              "FROM tblIncidents i " &
                              "LEFT JOIN tblResidents u ON i.ComplainantID = u.ResidentID " &
                              "WHERE i.IncidentID = @id"

        Dim params As New Dictionary(Of String, Object)
        params.Add("@id", incidentID)

        Dim dt As DataTable = Session.GetDataTable(query, params)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            lblTitle.Text = row("Category").ToString().ToUpper() & " DETAILS #" & incidentID
            lblComplainant.Text = row("FullName").ToString()
            lblType.Text = row("IncidentType").ToString()
            lblDate.Text = row("IncidentDate").ToString()
            lblStatus.Text = row("Status").ToString()
            txtNarrative.Text = row("Narrative").ToString()

            ' Color coding for status
            If lblStatus.Text = "Pending" Then
                lblStatus.ForeColor = Color.OrangeRed
            ElseIf lblStatus.Text = "Resolved" Then
                lblStatus.ForeColor = Color.Green
            Else
                lblStatus.ForeColor = Color.Gray
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class