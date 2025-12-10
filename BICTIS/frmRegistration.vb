Imports System.Collections.Generic

Public Class frmRegistration
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtFullName.Text = "" Then
            MessageBox.Show("All fields required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtPassword.Text <> txtConfirmPass.Text Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' FIX: Check duplicate in tblResidents
        Dim checkParams As New Dictionary(Of String, Object)
        checkParams.Add("@user", txtUsername.Text)
        If Session.GetCount("SELECT COUNT(*) FROM tblResidents WHERE Username=@user", checkParams) > 0 Then
            MessageBox.Show("Username taken.", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        ' FIX: Insert into tblResidents
        Dim query As String = "INSERT INTO tblResidents (Username, [Password], Role, FullName, IsActive) VALUES (@user, @pass, 'User', @full, True)"
        Dim params As New Dictionary(Of String, Object)
        params.Add("@user", txtUsername.Text)
        params.Add("@pass", txtPassword.Text)
        params.Add("@full", txtFullName.Text)

        If Session.ExecuteQuery(query, params) Then
            MessageBox.Show("Account Created! Please Login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim login As New frmLogin()
            login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked Then
            txtPassword.PasswordChar = ControlChars.NullChar
            txtConfirmPass.PasswordChar = ControlChars.NullChar
        Else
            txtPassword.PasswordChar = "•"c
            txtConfirmPass.PasswordChar = "•"c
        End If
    End Sub

    Private Sub lblLoginLink_Click(sender As Object, e As EventArgs) Handles lblLoginLink.Click
        Dim login As New frmLogin()
        login.Show()
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class