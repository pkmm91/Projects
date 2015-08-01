Imports System.Data.OleDb
Public Class frmRoom
    Dim id As Integer
    Dim con As New OleDbConnection

    Private Sub frmRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        txtID.Clear()
        txtRoomType.Clear()
        txtRoomRate.Clear()
        txtNoOfOccupancy.Clear()
    End Sub

    Private Sub bttnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSave.Click
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PANKAJ\Documents\database.accdb"
        con.Open()
        Dim num As String = Trim(txtID.Text)
        Dim type As String = Trim(txtRoomType.Text)
        Dim rate As String = Trim(txtRoomRate.Text)
        Dim occupancy As String = Trim(txtNoOfOccupancy.Text)
        Dim stat As String = "Available"
        If type = Nothing Or rate = Nothing Or occupancy = Nothing Then
            MsgBox("Please Fill All Fields", vbInformation, "Note")
        Else
                Dim sql = "SELECT * FROM tblRoom WHERE RoomNumber = " & num & ""

                Dim cmd = New OleDbCommand(sql, con)
                Dim dr As OleDbDataReader = cmd.ExecuteReader

                Try
                    If dr.Read = False Then
                        Dim add_room As New OleDbCommand("INSERT INTO tblRoom(RoomNumber,RoomType,RoomRate,NoOfOccupancy,Status) values ('" &
                                                 num & "','" &
                                                 type & "','" &
                                                 rate & "','" &
                                                 occupancy & "','" &
                                                 stat & "')", con)
                        add_room.ExecuteNonQuery()
                        add_room.Dispose()
                        MsgBox("Room Added!", vbInformation, "Note")
                        txtID.Clear()
                        txtRoomType.Clear()
                        txtRoomRate.Clear()
                        txtNoOfOccupancy.Clear()
                    Else
                        MsgBox("Room Number Existed!", vbExclamation, "Note")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
        End If
        con.Close()
    End Sub
End Class