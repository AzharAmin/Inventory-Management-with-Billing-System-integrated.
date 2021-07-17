Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class stockdetails
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim adpt As SqlDataAdapter
    Dim dt As New DataTable

    Private Sub stockdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=LAPTOP-SLT3PTMR\SQLEXPRESS;Initial Catalog=gms;Integrated Security=True")
        Dim command As New SqlCommand("select pid,prod_name,stock from product", con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False

        DataGridView1.RowTemplate.Height = 100
        'Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table
    End Sub
    Public Sub populateDatagridview(ByVal valueToSearch As String)
        Dim searchQuery As String = "SELECT pid,prod_name,stock From product WHERE prod_name  like '%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.AllowUserToAddRows = False


        DataGridView1.RowTemplate.Height = 100
        ' Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table

        ' imgc = DataGridView1.Columns(3)
        ' imgc.ImageLayout = DataGridViewImageCellLayout.Stretch

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSearch.TextChanged
        populateDatagridview(TextBoxSearch.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()


    End Sub
End Class