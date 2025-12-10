Public Class frmManageResidents
    Private Sub frmManageResidents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadResidents("")
    End Sub

    Private Sub LoadResidents(search As String)
        ' FIX: Select ResidentID
        Dim query As String = "SELECT ResidentID, Username, FullName, Role FROM tblResidents WHERE Role='User'"
        If search <> "" Then
            query &= " AND (FullName LIKE '%" & search & "%' OR Username LIKE '%" & search & "%')"
        End If
        dgvResidents.DataSource = Session.GetDataTable(query)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadResidents(txtSearch.Text)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvResidents.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' FIX: Use ResidentID
        Dim uid As Integer = Convert.ToInt32(dgvResidents.SelectedRows(0).Cells("ResidentID").Value)

        If MessageBox.Show("Delete this resident?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Session.ExecuteQuery("DELETE FROM tblResidents WHERE ResidentID=" & uid)
            MessageBox.Show("User Deleted.", "Success")
            LoadResidents(txtSearch.Text)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class