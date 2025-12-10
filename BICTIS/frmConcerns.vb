Imports System.Collections.Generic

Public Class frmConcerns
    Private Sub frmConcerns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        cbStatus.Items.Clear()
        cbStatus.Items.AddRange(New String() {"Acknowledged", "Resolved", "Invalid"})
        cbStatus.SelectedIndex = 0
    End Sub

    Private Sub LoadData()
        ' LOAD ONLY CONCERNS
        Dim sql As String = "SELECT IncidentID, IncidentType, Narrative, Status, IncidentDate FROM tblIncidents WHERE Category='Concern' ORDER BY IncidentID DESC"
        dgvCases.DataSource = Session.GetDataTable(sql)
    End Sub

    Private Sub cbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged
        If cbStatus.Text <> "" Then
            btnUpdate.Text = "MARK AS " & cbStatus.Text.ToUpper()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvCases.SelectedRows.Count = 0 Then
            MessageBox.Show("Select a concern first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim id As Integer = Convert.ToInt32(dgvCases.SelectedRows(0).Cells("IncidentID").Value)
        Dim currentStatus As String = dgvCases.SelectedRows(0).Cells("Status").Value.ToString()
        Dim newStatus As String = cbStatus.Text

        ' LOCK LOGIC: Cannot change if already Resolved or Invalid
        If currentStatus = "Resolved" Or currentStatus = "Invalid" Then
            MessageBox.Show("This concern is already closed (" & currentStatus & ") and cannot be modified.", "Locked", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If MessageBox.Show("Update status to " & newStatus & "? This cannot be undone.", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Session.ExecuteQuery("UPDATE tblIncidents SET Status='" & newStatus & "' WHERE IncidentID=" & id)
            LoadData()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class