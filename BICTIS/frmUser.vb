Imports System.Collections.Generic

Public Class frmUser
    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & Session.CurrentFullName
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ' NEW FORM for Reporting
        Dim frm As New frmReportConcern()
        frm.ShowDialog()
    End Sub

    Private Sub btnMyBlotter_Click(sender As Object, e As EventArgs) Handles btnMyBlotter.Click
        ' Check if user is involved in cases (as Complainant OR Respondent)
        Dim sql As String = "SELECT IncidentType, Status, IncidentDate, Narrative FROM tblIncidents " &
                            "WHERE ComplainantID=" & Session.CurrentResidentID & " OR RespondentID=" & Session.CurrentResidentID

        Dim dt As DataTable = Session.GetDataTable(sql)

        If dt.Rows.Count > 0 Then
            Dim msg As String = "Your Cases:" & vbCrLf
            For Each row As DataRow In dt.Rows
                msg &= "- " & row("IncidentType").ToString() & " [" & row("Status").ToString() & "]" & vbCrLf
            Next
            MessageBox.Show(msg, "My Blotter History", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("You have no blotter records.", "Clean Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Session.CurrentResidentID = 0
        Dim login As New frmLogin()
        login.Show()
        Me.Close()
    End Sub
End Class