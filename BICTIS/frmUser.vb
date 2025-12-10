Imports System.Collections.Generic

Public Class frmUser
    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & Session.CurrentFullName
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ' OPEN CONCERN FORM
        Dim frm As New frmReportConcern()
        frm.ShowDialog()
    End Sub

    Private Sub btnFileBlotter_Click(sender As Object, e As EventArgs) Handles btnFileBlotter.Click
        ' OPEN BLOTTER FORM
        Dim frm As New frmFileBlotter()
        frm.ShowDialog()
    End Sub

    Private Sub btnMyBlotter_Click(sender As Object, e As EventArgs) Handles btnMyBlotter.Click
        ' Show History of both Blotters and Concerns
        Dim sql As String = "SELECT Category, IncidentType, Status, IncidentDate FROM tblIncidents " &
                            "WHERE ComplainantID=" & Session.CurrentResidentID & " ORDER BY IncidentID DESC"
        Dim dt As DataTable = Session.GetDataTable(sql)

        If dt.Rows.Count > 0 Then
            Dim msg As String = "YOUR HISTORY:" & vbCrLf & vbCrLf
            For Each row As DataRow In dt.Rows
                ' Display Category to distinguish between the two
                msg &= "[" & row("Category").ToString().ToUpper() & "] " & row("IncidentType").ToString() & " - " & row("Status").ToString() & vbCrLf
            Next
            MessageBox.Show(msg, "My Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No records found.", "Clean Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Session.CurrentResidentID = 0
        Dim login As New frmLogin()
        login.Show()
        Me.Close()
    End Sub
End Class