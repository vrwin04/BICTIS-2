Imports System.Collections.Generic

Public Class frmManageResidents
    Private Async Sub frmManageResidents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadResidentsAsync("")
    End Sub

    Private Async Function LoadResidentsAsync(search As String) As Task
        Dim query As String = "SELECT ResidentID, Username, FullName, Role FROM tblResidents WHERE Role='User'"
        Dim params As New Dictionary(Of String, Object)

        If Not String.IsNullOrWhiteSpace(search) Then
            ' Using Parameters is cleaner and safer
            query &= " AND (FullName LIKE @search OR Username LIKE @search)"
            params.Add("@search", "%" & search & "%")
        End If

        Dim dt As DataTable = Await Session.GetDataTableAsync(query, params)
        dgvResidents.DataSource = dt
    End Function

    ' Async Search on Text Change
    Private Async Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ' Optional: Small delay could be added here to prevent querying on every single keystroke rapidly
        Await LoadResidentsAsync(txtSearch.Text)
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvResidents.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim uid As Integer = Convert.ToInt32(dgvResidents.SelectedRows(0).Cells("ResidentID").Value)

        If MessageBox.Show("Delete this resident?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Session.ExecuteQuery("DELETE FROM tblResidents WHERE ResidentID=" & uid)
            MessageBox.Show("User Deleted.", "Success")
            Await LoadResidentsAsync(txtSearch.Text)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class