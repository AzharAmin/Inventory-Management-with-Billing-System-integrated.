Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class example
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim adpt As SqlDataAdapter
    Dim dt As New DataTable


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)

        End If

        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=LAPTOP-SLT3PTMR\SQLEXPRESS;Initial Catalog=gms;Integrated Security=True")
        Dim command As New SqlCommand("select * from images", con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False

        DataGridView1.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table

        imgc = DataGridView1.Columns(3)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch


    End Sub

    Private Sub BTN_INSERT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_INSERT.Click
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Dim img() As Byte
        img = ms.ToArray()
        Dim insertQuery As String = "INSERT INTO images(id,name,description,image) VALUES('" & TextBoxID.Text & "','" & TextBoxName.Text & "','" & TextBoxDesc.Text & "', @img )"

        Dim command As New SqlCommand(insertQuery, con)
        command.Parameters.Add("@img", SqlDbType.Image).Value = img

        ExecuteMyQuery(command, " Record Inserted ")

    End Sub

    Private Sub DataGridView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        Dim img As Byte()
        img = DataGridView1.CurrentRow.Cells(3).Value
        Dim ms As New MemoryStream(img)
        PictureBox1.Image = Image.FromStream(ms)

        TextBoxID.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBoxName.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBoxDesc.Text = DataGridView1.CurrentRow.Cells(2).Value
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

    Private Sub BTN_DELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_DELETE.Click
        Dim deleteQuery As String = "DELETE FROM images WHERE id = " & TextBoxID.Text

        Dim command As New SqlCommand(deleteQuery, con)

        ExecuteMyQuery(command, "Record Deleted ")

    End Sub

    Private Sub BTN_UPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_UPDATE.Click
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Dim img() As Byte
        img = ms.ToArray()
        Dim updateQuery As String = "UPDATE images SET name = '" & TextBoxName.Text & "',description = '" & TextBoxDesc.Text & "',image = @img WHERE id = " & TextBoxID.Text

        Dim command As New SqlCommand(updateQuery, con)
        command.Parameters.Add("@img", SqlDbType.Image).Value = img

        ExecuteMyQuery(command, "Record Updated ")
    End Sub


    Public Sub populateDatagridview(ByVal valueToSearch As String)
        Dim searchQuery As String = "SELECT * From images WHERE name+ '-' +description+ '-' +id like '%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False

        DataGridView1.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table

        imgc = DataGridView1.Columns(3)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch

    End Sub

    Private Sub TextBoxSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSearch.TextChanged
        populateDatagridview(TextBoxSearch.Text)
    End Sub

    Private Sub BTN_FIND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_FIND.Click

        Dim command As New SqlCommand("select * from images WHERE id = @id ", con)
        Command.Parameters.Add("@id", SqlDbType.Int).Value = TextBoxID.Text

        Dim adapter As New SqlDataAdapter(Command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then

            MessageBox.Show("No Data Found")

        Else

            TextBoxID.Text = table.Rows(0)(0).ToString()
            TextBoxName.Text = table.Rows(0)(1).ToString()
            TextBoxDesc.Text = table.Rows(0)(2).ToString()

            Dim img() As Byte

            img = table.Rows(0)(3)

            Dim ms As New MemoryStream(img)

            PictureBox1.Image = Image.FromStream(ms)

        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class