Imports System.Data.OleDb
Public Class frmDiscount
    Dim update_discount As Boolean = False
    Dim id As Integer
    Private Sub bttnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnCancel.Click
        clear_txt()
        update_discount = False
    End Sub
    Private Sub frmDiscount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PANKAJ\Documents\database.accdb"
        display_discount()
        clear_txt()
    End Sub
    Private Sub bttnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttnSave.Click
        Dim discontrate As Single = (Val(Trim(txtRate.Text)) / 100)
        If Trim(txtType.Text) = "" Or Trim(txtRate.Text) = "" Then
            MsgBox("Fill All Fields!", vbInformation, "Note")
            Exit Sub
        End If
        Dim a As String = MsgBox("Save Discount Info?", vbQuestion + vbYesNo, "Save")
        If a = vbYes Then
            Try
                If update_discount = False Then
                    con.Open()
                    Dim save As New OleDbCommand("INSERT INTO tblDiscount(DiscountType,DiscountRate,Status) values ('" & Trim(txtType.Text) & "','" & discontrate & "','Active')", con)
                    save.ExecuteNonQuery()
                    con.Close()
                End If
                MsgBox("Data saved successfully!", vbInformation, "Discount")
                display_discount()
                clear_txt()
            Catch ex As Exception
                MessageBox.Show("Failed")
            End Try
        End If

    End Sub

    Private Sub clear_txt()
        txtType.Clear()
        txtRate.Clear()
        update_discount = False
    End Sub

    Private Sub display_discount()
        con.Open()
        Dim dt As New DataTable("tblDiscount")
        rs = New OleDbDataAdapter("SELECT * FROM tblDiscount", con)
        rs.Fill(dt)

        lvlDiscount.Items.Clear()

        Dim indx As Integer
        For indx = 0 To dt.Rows.Count - 1
            Dim lv As New ListViewItem
            lv.Text = dt.Rows(indx).Item("ID")
            lv.SubItems.Add(dt.Rows(indx).Item("DiscountType"))
            lv.SubItems.Add(dt.Rows(indx).Item("DiscountRate"))
            lvlDiscount.Items.Add(lv)
        Next
        rs.Dispose()
        con.Close()
    End Sub

End Class