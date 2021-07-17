Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Text.RegularExpressions

Public Class updateSupplier
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim adpt As SqlDataAdapter
    Dim dt As New DataTable

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=LAPTOP-SLT3PTMR\SQLEXPRESS;Initial Catalog=gms;Integrated Security=True")
        Dim command As New SqlCommand("select * from supplier", con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False

        DataGridView1.RowTemplate.Height = 100
        DataGridView1.DataSource = table
    End Sub
    Public Sub ExecuteMyQuery(ByVal MyCommand As SqlCommand, ByVal MyMessage As String)

        con.Open()

        If MyCommand.ExecuteNonQuery = 1 Then

            MessageBox.Show(MyMessage)

        Else

            MessageBox.Show("Query Not Executed")

        End If

        con.Close()



    End Sub

    Private Sub DataGridView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        TextBoxID.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBoxNAME.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBoxPRODUCT.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBoxEMAIL.Text = DataGridView1.CurrentRow.Cells(3).Value
        TextBoxCONTACT.Text = DataGridView1.CurrentRow.Cells(4).Value
        TextBoxADDR.Text = DataGridView1.CurrentRow.Cells(5).Value
    End Sub
    Public Sub populateDatagridview(ByVal valueToSearch As String)
        Dim searchQuery As String = "SELECT * From supplier WHERE sname+ '-' +sid+ '-' +pname like '%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False

        DataGridView1.RowTemplate.Height = 100
        'Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table

        'imgc = DataGridView1.Columns(3)
        'imgc.ImageLayout = DataGridViewImageCellLayout.Stretch

    End Sub

    Private Sub TextBoxSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSearch.TextChanged
        populateDatagridview(TextBoxSearch.Text)
    End Sub

    Private Sub BTN_UPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_UPDATE.Click
        Dim updateQuery As String = "UPDATE supplier SET sname = '" & TextBoxNAME.Text & "',pname = '" & TextBoxPRODUCT.Text & "',email = '" & TextBoxEMAIL.Text & "',contact = '" & TextBoxCONTACT.Text & "',addr = '" & TextBoxADDR.Text & "' WHERE sid = " & TextBoxID.Text

        Dim command As New SqlCommand(updateQuery, con)
        ExecuteMyQuery(command, "Record Updated ")
    End Sub

    Private Sub BTN_CANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_CANCEL.Click
        Me.Close()

    End Sub

    Private Sub BTN_DELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_DELETE.Click
        Dim deleteQuery As String = "DELETE FROM supplier WHERE sid = " & TextBoxID.Text

        Dim command As New SqlCommand(deleteQuery, con)

        ExecuteMyQuery(command, "Record Deleted ")

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class