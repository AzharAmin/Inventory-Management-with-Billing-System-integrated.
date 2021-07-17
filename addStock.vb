Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging


Public Class addStock
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim adpt As SqlDataAdapter
    Dim dt As New DataTable
    Dim connection As New SqlConnection("Data Source=LAPTOP-SLT3PTMR\SQLEXPRESS;Initial Catalog=gms;Integrated Security=True")
    Private Sub addStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=LAPTOP-SLT3PTMR\SQLEXPRESS;Initial Catalog=gms;Integrated Security=True")
        Dim adapter As New SqlDataAdapter("SELECT pid FROM product", connection)
        Dim table As New DataTable()

        adapter.Fill(table)

        ComboBox1.DataSource = table

        ComboBox1.ValueMember = "pid"
        ComboBox1.DisplayMember = "pid"


        'con = New SqlConnection("Data Source=LAPTOP-SLT3PTMR\SQLEXPRESS;Initial Catalog=gms;Integrated Security=True")
        Dim command1 As New SqlCommand("select pid,cname,prod_name,stock from product", con)
        Dim adapter1 As New SqlDataAdapter(command1)
        Dim table1 As New DataTable()
        adapter1.Fill(table1)

        DataGridView1.AllowUserToAddRows = False

        DataGridView1.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table1
        'imgc = DataGridView1.Columns(9)
        'imgc.ImageLayout = DataGridViewImageCellLayout.Stretch


        'pid,prod_name,mno,warranty,stock
    End Sub
    Private Sub BTN_SHOW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SHOW.Click
        Dim adapter2 As New SqlDataAdapter("SELECT * FROM product WHERE pid='" & ComboBox1.Text & "'", connection)
        Dim table1 As New DataTable()

        adapter2.Fill(table1)
        TextBoxPNAME.Text = table1(0)(3)
        TextBoxMNO.Text = table1(0)(4)
        TextBoxTYPE.Text = table1(0)(1)
        TextBoxSNAME.Text = table1(0)(8)
    End Sub

    Private Sub BTN_ADDSTOCK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_ADDSTOCK.Click
        Dim updateQuery As String = "UPDATE product SET stock =  stock +'" & Val(TextBoxSTOCK.Text) & "' WHERE pid = '" & ComboBox1.Text & "'"

        Dim command As New SqlCommand(updateQuery, con)

        ExecuteMyQuery(command, "Record Updated ")
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

    Private Sub BTN_CANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_CANCEL.Click
        Me.Close()

    End Sub
End Class
