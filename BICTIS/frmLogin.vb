Imports System.Collections.Generic

Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Please enter credentials.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' FIX: Correct Column Names for tblResidents
        Dim query As String = "SELECT * FROM tblResidents WHERE Username=@user AND [Password]=@pass"
        Dim params As New Dictionary(Of String, Object)
        params.Add("@user", txtUsername.Text)
        params.Add("@pass", txtPassword.Text)

        Dim dt As DataTable = Session.GetDataTable(query, params)

        If dt.Rows.Count > 0 Then
            ' FIX: Using ResidentID instead of UserID
            Session.CurrentResidentID = Convert.ToInt32(dt.Rows(0)("ResidentID"))
            Session.CurrentUserRole = dt.Rows(0)("Role").ToString()
            Session.CurrentUserName = dt.Rows(0)("Username").ToString()
            Session.CurrentFullName = dt.Rows(0)("FullName").ToString()

            MessageBox.Show("Welcome, " & Session.CurrentFullName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If Session.CurrentUserRole = "Admin" Or Session.CurrentUserRole = "Secretary" Then
                Dim dash As New adminDashboard()
                dash.Show()
            Else
                Dim userDash As New frmUser()
                userDash.Show()
            End If
            Me.Hide()
        Else
            MessageBox.Show("Invalid Username or Password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked Then
            txtPassword.PasswordChar = ControlChars.NullChar
        Else
            txtPassword.PasswordChar = "•"c
        End If
    End Sub

    Private Sub lblRegisterLink_Click(sender As Object, e As EventArgs) Handles lblRegisterLink.Click
        Dim reg As New frmRegistration()
        reg.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class