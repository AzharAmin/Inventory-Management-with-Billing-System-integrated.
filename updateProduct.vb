Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class updateProduct
    Dim con As SqlConnection
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
    Private Sub ButtonUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUPDATE.Click
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Dim img() As Byte
        img = ms.ToArray()
        Dim updateQuery As String = "UPDATE product SET type = '" & TextBoxTYPE.Text & "',cname = '" & TextBoxCNAME.Text & "',prod_name = '" & TextBoxPNAME.Text & "',mno = '" & TextBoxMNO.Text & "',warranty = '" & TextBoxWARRANTY.Text & "',cprice = '" & TextBoxCPRICE.Text & "',image = @img WHERE pid = " & TextBoxID.Text

        Dim command As New SqlCommand(updateQuery, con)
        command.Parameters.Add("@img", SqlDbType.Image).Value = img

        ExecuteMyQuery(command, "Record Updated ")
    End Sub

    Private Sub updateProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=LAPTOP-SLT3PTMR\SQLEXPRESS;Initial Catalog=gms;Integrated Security=True")
        Dim command1 As New SqlCommand("select * from product", con)
        Dim adapter1 As New SqlDataAdapter(command1)
        Dim table1 As New DataTable()
        adapter1.Fill(table1)

        DataGridView1.AllowUserToAddRows = False

        DataGridView1.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table1
        imgc = DataGridView1.Columns(9)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch

        TextBoxID.Enabled = False
        Label5.Visible = False
        TextBoxSTOCK.Visible = False
        Label7.Visible = False
        ComboBox1.Visible = False



    End Sub
    Public Sub ExecuteMyQuery(ByVal MyCommand As SqlCommand, ByVal MyMessage As String)

        con.Open()

        If MyCommand.ExecuteNonQuery = 1 Then

            MessageBox.Show(MyMessage)

        Else

            MessageBox.Show("Query Not Executed")

        End If
    End Sub
    Private Sub DataGridView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        TextBoxID.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBoxTYPE.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBoxCNAME.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBoxPNAME.Text = DataGridView1.CurrentRow.Cells(3).Value
        TextBoxMNO.Text = DataGridView1.CurrentRow.Cells(4).Value
        TextBoxWARRANTY.Text = DataGridView1.CurrentRow.Cells(5).Value
        TextBoxSTOCK.Text = DataGridView1.CurrentRow.Cells(6).Value
        TextBoxCPRICE.Text = DataGridView1.CurrentRow.Cells(7).Value
        ComboBox1.Text = DataGridView1.CurrentRow.Cells(8).Value
        Dim img As Byte()
        img = DataGridView1.CurrentRow.Cells(9).Value
        Dim ms As New MemoryStream(img)
        PictureBox1.Image = Image.FromStream(ms)
    End Sub

    Private Sub BTN_CANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_CANCEL.Click
        Me.Close()
    End Sub
End Class