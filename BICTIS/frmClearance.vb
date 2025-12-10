Public Class frmClearance
    Private Sub frmClearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRequests()
    End Sub

    Private Sub LoadRequests()
        ' FIX: Join on ResidentID
        Dim sql As String = "SELECT c.ClearanceID, u.FullName, c.Purpose, c.DateIssued, c.Status FROM tblClearances c INNER JOIN tblResidents u ON c.ResidentID = u.ResidentID ORDER BY c.DateIssued DESC"
        dgvRequests.DataSource = Session.GetDataTable(sql)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dgvRequests.SelectedRows.Count = 0 Then Exit Sub
        Dim cid As Integer = Convert.ToInt32(dgvRequests.SelectedRows(0).Cells("ClearanceID").Value)

        Session.ExecuteQuery("UPDATE tblClearances SET Status='Approved' WHERE ClearanceID=" & cid)
        MessageBox.Show("Approved & Printed.", "Success")
        LoadRequests()
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        If dgvRequests.SelectedRows.Count = 0 Then Exit Sub
        Dim cid As Integer = Convert.ToInt32(dgvRequests.SelectedRows(0).Cells("ClearanceID").Value)

        If MessageBox.Show("Reject?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Session.ExecuteQuery("UPDATE tblClearances SET Status='Rejected' WHERE ClearanceID=" & cid)
            LoadRequests()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class