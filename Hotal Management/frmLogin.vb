Imports System.Data.OleDb
Public Class frmLogin
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If txtUsername.Text = "" Or txtUsername.Text = "" Then
            MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Both fields was supply
            ' Check if user exist in database
            ' Connect to DB
            Dim conn As New System.Data.OleDb.OleDbConnection()
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PANKAJ\Documents\database.accdb"

            Try
                'conn.Open()
                'MsgBox("Susscess")

                Dim sql As String = "SELECT * FROM tblUser WHERE username='" & txtUsername.Text & "' AND password = '" & txtPassword.Text & "'"
                Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

                'Open Database Connection
                sqlCom.Connection = conn
                conn.Open()

                Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

                If sqlRead.Read() Then
                    frmMain.ShowDialog()
                    Me.Hide()

                Else
                    ' If user enter wrong username and password combination
                    ' Throw an error message
                    MessageBox.Show("Username and Password do not match..", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    'Clear all fields
                    txtPassword.Text = ""
                    txtUsername.Text = ""

                    'Focus on Username field
                    txtUsername.Focus()
                End If

            Catch ex As Exception
                MessageBox.Show("Failed to connect to Database..", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        End
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Label1.Text = txtPassword.Text
    End Sub
    
End Class
