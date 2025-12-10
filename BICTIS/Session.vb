Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms
Imports System.Collections.Generic

Public Module Session
    ' CONFIGURATION
    Public dbFile As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BICTIS_DB.accdb")
    Private ReadOnly connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbFile & ";Persist Security Info=False;"

    ' USER STATE
    Public CurrentResidentID As Integer = 0
    Public CurrentUserRole As String = ""
    Public CurrentUserName As String = ""
    Public CurrentFullName As String = ""

    ' DATABASE METHODS
    Public Function GetDataTable(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As DataTable
        Dim dt As New DataTable()
        Using conn As New OleDbConnection(connectionString)
            Using cmd As New OleDbCommand(query, conn)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If
                Try
                    conn.Open()
                    Dim adapter As New OleDbDataAdapter(cmd)
                    adapter.Fill(dt)
                Catch ex As Exception
                    MessageBox.Show("DB Error: " & ex.Message)
                End Try
            End Using
        End Using
        Return dt
    End Function

    Public Function ExecuteQuery(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As Boolean
        Using conn As New OleDbConnection(connectionString)
            Using cmd As New OleDbCommand(query, conn)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    MessageBox.Show("DB Error: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function

    Public Function GetCount(query As String, Optional parameters As Dictionary(Of String, Object) = Nothing) As Integer
        Using conn As New OleDbConnection(connectionString)
            Using cmd As New OleDbCommand(query, conn)
                If parameters IsNot Nothing Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If
                Try
                    conn.Open()
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso IsNumeric(result) Then
                        Return Convert.ToInt32(result)
                    Else
                        Return 0
                    End If
                Catch ex As Exception
                    Return 0
                End Try
            End Using
        End Using
    End Function
End Module