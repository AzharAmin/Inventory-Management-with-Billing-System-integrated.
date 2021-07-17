Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class addProduct
    Dim con, con1 As SqlConnection
    Dim cmd As SqlCommand
    Dim adpt As SqlDataAdapter
    Dim dt As New DataTable
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBoxTYPE.Text = "PC"
            RadioButton4.Text = "DELL"
            RadioButton5.Text = "HP"
            RadioButton6.Text = "APPLE"
            RadioButton7.Text = "LENOVO"
            RadioButton8.Text = "ASUS"
            RadioButton9.Text = "SONY"

        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TextBoxTYPE.Text = "Camera"
            RadioButton4.Text = "NIKON"
            RadioButton5.Text = "SONY"
            RadioButton6.Text = "PANASONIC"
            RadioButton7.Text = "GoPro"
            RadioButton8.Text = "SAMSUNG"
            RadioButton9.Text = "CANON"
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            TextBoxTYPE.Text = "Smart Phones"
            RadioButton4.Text = "APPLE"
            RadioButton5.Text = "XIAOMI"
            RadioButton6.Text = "OPPO"
            RadioButton7.Text = "HUAWEI"
            RadioButton8.Text = "GOOGLE"
            RadioButton9.Text = "SAMSUNG"
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBoxCNAME.Text = "DELL"
        Else


            If RadioButton2.Checked = True Then
                TextBoxCNAME.Text = "NIKON"
            Else
                If RadioButton3.Checked = True Then
                    TextBoxCNAME.Text = "APPLE"
                End If

            End If

        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBoxCNAME.Text = "HP"
        Else
            If RadioButton2.Checked = True Then
                TextBoxCNAME.Text = "SONY"
            Else
                If RadioButton3.Checked = True Then
                    TextBoxCNAME.Text = "XIAOMI"
                End If
            End If
        End If

    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBoxCNAME.Text = "APPLE"
        Else
            If RadioButton2.Checked = True Then
                TextBoxCNAME.Text = "PANASONIC"
            End If
            If RadioButton3.Checked = True Then
                TextBoxCNAME.Text = "OPPO"
            End If
        End If




    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBoxCNAME.Text = "LENOVO"
        Else
            If RadioButton2.Checked = True Then
                TextBoxCNAME.Text = "GoPro"
            End If
            If RadioButton3.Checked = True Then
                TextBoxCNAME.Text = "HUAWEI"
            End If
        End If

    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBoxCNAME.Text = "ASUS"
        Else
            If RadioButton2.Checked = True Then
                TextBoxCNAME.Text = "SAMSUNG"
            End If
            If RadioButton3.Checked = True Then
                TextBoxCNAME.Text = "GOOGLE"
            End If
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBoxCNAME.Text = "SONY"
        Else
            If RadioButton2.Checked = True Then
                TextBoxCNAME.Text = "CANON"
            End If
            If RadioButton3.Checked = True Then
                TextBoxCNAME.Text = "SAMSUNG"
            End If
        End If

    End Sub

    Private Sub ButtonBROWSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBROWSE.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)

        End If

        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
    End Sub

    Private Sub addStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=LAPTOP-SLT3PTMR\SQLEXPRESS;Initial Catalog=gms;Integrated Security=True")
        con1 = New SqlConnection("Data Source=LAPTOP-SLT3PTMR\SQLEXPRESS;Initial Catalog=gms;Integrated Security=True")
        Dim command As New SqlCommand("select * from supplier", con)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        ComboBox1.DataSource = table

        ComboBox1.DisplayMember = "sname"
        ComboBox1.ValueMember = "sid"


        Dim command1 As New SqlCommand("select * from product", con1)
        Dim adapter1 As New SqlDataAdapter(command1)
        Dim table1 As New DataTable()
        adapter1.Fill(table1)

        DataGridView1.AllowUserToAddRows = False

        DataGridView1.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table1
        imgc = DataGridView1.Columns(9)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch


    End Sub

    Private Sub BTN_INSERT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_INSERT.Click
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Dim img() As Byte
        img = ms.ToArray()
        Dim insertQuery As String = "INSERT INTO product(pid,type,cname,prod_name,mno,warranty,stock,cprice,sname,image) VALUES('" & TextBoxID.Text & "','" & TextBoxTYPE.Text & "','" & TextBoxCNAME.Text & "','" & TextBoxPNAME.Text & "','" & TextBoxMNO.Text & "','" & TextBoxWARRANTY.Text & "','" & TextBoxSTOCK.Text & "','" & TextBoxCPRICE.Text & "','" & ComboBox1.Text & "', @img )"

        Dim command As New SqlCommand(insertQuery, con1)
        command.Parameters.Add("@img", SqlDbType.Image).Value = img

        ExecuteMyQuery(command, " Record Inserted ")
    End Sub
    Public Sub ExecuteMyQuery(ByVal MyCommand As SqlCommand, ByVal MyMessage As String)

        con1.Open()

        If MyCommand.ExecuteNonQuery = 1 Then

            MessageBox.Show(MyMessage)

        Else

            MessageBox.Show("Query Not Executed")

        End If
    End Sub

    Private Sub BTN_CANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_CANCEL.Click
        Me.Close()

    End Sub

    Private Sub ButtonUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

 
   
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
