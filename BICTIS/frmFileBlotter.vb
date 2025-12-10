Imports System.Collections.Generic

Public Class frmFileBlotter
    Private Sub frmFileBlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' POPULATE DROPDOWN WITH FORMAL CASES / DISPUTES ONLY
        cbType.Items.Clear()
        cbType.Items.AddRange(New String() {
            "Physical Injury",
            "Theft / Robbery",
            "Property / Land Dispute",
            "Harassment / Threats",
            "Unjust Vexation",
            "Malicious Mischief",
            "Estafa / Swindling",
            "Libel / Slander",
            "Other"
        })
        cbType.SelectedIndex = 0
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' VALIDATION
        If String.IsNullOrWhiteSpace(cbType.Text) OrElse
           String.IsNullOrWhiteSpace(txtNarrative.Text) OrElse
           String.IsNullOrWhiteSpace(txtRespondent.Text) Then

            MessageBox.Show("Please fill in all details, including the Respondent's name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim respondentInfo As String = "[Respondent: " & txtRespondent.Text & "] " & txtNarrative.Text

        ' Save with Category = 'Blotter'
        Dim query As String = "INSERT INTO tblIncidents (ComplainantID, RespondentID, IncidentType, Narrative, Status, IncidentDate, Category) " &
                              "VALUES (@uid, 0, @type, @narr, 'Pending', @date, 'Blotter')"

        Dim params As New Dictionary(Of String, Object)
        params.Add("@uid", Session.CurrentResidentID)
        params.Add("@type", cbType.Text)
        params.Add("@narr", respondentInfo)
        params.Add("@date", DateTime.Now.ToString())

        If Session.ExecuteQuery(query, params) Then
            MessageBox.Show("Blotter case filed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class