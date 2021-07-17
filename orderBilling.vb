Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class orderBilling
    Dim con, con1 As SqlConnection
    Dim cmd As SqlCommand
    Dim adpt As SqlDataAdapter
    Dim dt As New DataTable

    Private Sub orderBilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=LAPTOP-SLT3PTMR\SQLEXPRESS;Initial Catalog=gms;Integrated Security=True")
        con1 = New SqlConnection("Data Source=LAPTOP-SLT3PTMR\SQLEXPRESS;Initial Catalog=gms;Integrated Security=True")
        LabelSum.AutoSize = True

        ' DataGridView1.DataSource = ds.Tables("product")
        ' With DataGridView1
        '.RowHeadersVisible = False
        ' DataGridView1.Columns(0).HeaderText = "pid"
        '  End With

    End Sub

    Private Sub ComboBox1_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.DropDown
        Dim command As New SqlCommand("select * from product", con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        ComboBox1.DataSource = table

        ComboBox1.DisplayMember = "prod_name"
        ComboBox1.ValueMember = "prod_name"



      
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim adapter2 As New SqlDataAdapter("SELECT * FROM product WHERE prod_name='" & ComboBox1.Text & "'", con1)
        Dim table1 As New DataTable()

        Dim s As String = "UPDATE product SET stock = stock - 1 WHERE prod_name =  & ComboBox1.Text"


        adapter2.Fill(table1)
        Dim rnum As Integer = DataGridView1.Rows.Add()

        DataGridView1.Rows.Item(rnum).Cells(0).Value = table1(0)(0)
        DataGridView1.Rows.Item(rnum).Cells(1).Value = table1(0)(3)
        DataGridView1.Rows.Item(rnum).Cells(2).Value = table1(0)(4)
        DataGridView1.Rows.Item(rnum).Cells(3).Value = table1(0)(1)
        DataGridView1.Rows.Item(rnum).Cells(4).Value = table1(0)(2)
        DataGridView1.Rows.Item(rnum).Cells(5).Value = table1(0)(5)
        DataGridView1.Rows.Item(rnum).Cells(7).Value = TextBoxQuantity.Text

        DataGridView1.Rows.Item(rnum).Cells(6).Value = table1(0)(7)
        DataGridView1.Rows.Item(rnum).Cells(8).Value = TextBoxQuantity.Text * table1(0)(7)



        ComboBox1.Text = "Select"
        TextBoxQuantity.Text = ""


        Dim sum As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(8).Value
        Next

        ' Dim updateQuery As String = "UPDATE product SET stock =  stock -'" & Val(TextBoxQuantity.Text) & "' WHERE pid = '" & DataGridView1.Rows.Item(rnum).Cells(0).Value & "'"

        Dim updateQuery As String = "UPDATE product SET stock =  stock -'" & DataGridView1.Rows.Item(rnum).Cells(7).Value & "' WHERE pid = '" & DataGridView1.Rows.Item(rnum).Cells(0).Value & "'"

        Dim command1 As New SqlCommand(updateQuery, con1)

        ExecuteMyQuery(command1, "Stock Updated")
        LabelSum.Text = sum.ToString()
        billing.LabelSum.Text = sum.ToString()



        

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBoxDate.Text = Date.Today.ToLongDateString



    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Me.Close()

    End Sub
    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        Dim rnum As Integer
        Dim ms As New MemoryStream
        Dim insertQuery As String = "INSERT INTO customer(cid,cust_name,date,email,addr,phone) VALUES('" & TextBoxCid.Text & "','" & TextBoxCName.Text & "','" & TextBoxDate.Text & "','" & TextBoxEmailId.Text & "','" & TextBoxAddr.Text & "','" & TextBoxPhone.Text & "')"
        Dim command As New SqlCommand(insertQuery, con1)

        ExecuteMyQuery(command, " Record Inserted ")
       
        With DataGridView1
            rnum = 0
            Do While rnum < .RowCount - 1
                Dim Sql As String = "INSERT INTO orderDetails(cid,pid,prod_name,mno,type,cname,warranty,rate,quantity,amount) VALUES('" & TextBoxCid.Text & "','" & DataGridView1.Rows.Item(rnum).Cells(0).Value & "','" & DataGridView1.Rows.Item(rnum).Cells(1).Value & "','" & DataGridView1.Rows.Item(rnum).Cells(2).Value & "','" & DataGridView1.Rows.Item(rnum).Cells(3).Value & "','" & DataGridView1.Rows.Item(rnum).Cells(4).Value & "','" & DataGridView1.Rows.Item(rnum).Cells(5).Value & "','" & DataGridView1.Rows.Item(rnum).Cells(6).Value & "','" & DataGridView1.Rows.Item(rnum).Cells(7).Value & "','" & DataGridView1.Rows.Item(rnum).Cells(8).Value & "')"
                Dim command2 As New SqlCommand(Sql, con1)

                rnum = rnum + 1
                ExecuteMyQuery(command2, " Record Inserted ")
            Loop

        End With


        





        Me.Hide()
        billing.Show()

        billing.LabelCust_name.Text = Me.TextBoxCName.Text



        Dim dr As New System.Windows.Forms.DataGridViewRow
        For Each dr In Me.DataGridView1.Rows
            billing.DataGridView1.Rows.Add(dr.Cells(1).Value, dr.Cells(6).Value, dr.Cells(7).Value, dr.Cells(8).Value)
        Next



        billing.Labelcgst.Text = ((9 * billing.LabelSum.Text) / 100)
        billing.Labelsgst.Text = ((9 * billing.LabelSum.Text) / 100)
        billing.Labelgrandtotal.Text = Val(billing.LabelSum.Text) + Val(billing.Labelcgst.Text) + Val(billing.Labelsgst.Text)




    End Sub
    Public Sub ExecuteMyQuery(ByVal MyCommand As SqlCommand, ByVal MyMessage As String)

        con1.Open()

        If MyCommand.ExecuteNonQuery = 1 Then

            MessageBox.Show(MyMessage)

        Else

            MessageBox.Show("Query Not Executed")

        End If
        con1.Close()

    End Sub

    
    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        ' MsgBox("Saved Successfully..!")
        'Dim insertQueryy As String = "INSERT INTO orderDetails(cid,prod_name,mno,rate,quantity,amount) VALUES('" & TextBoxCid.Text & "','" & DataGridView1.Rows.Item(rnum).Cells(1).Value & "','" & DataGridView1.Rows.Item(rnum).Cells(2).Value & "','" & DataGridView1.Rows.Item(rnum).Cells(7).Value & "','" & DataGridView1.Rows.Item(rnum).Cells(6).Value & "','" & DataGridView1.Rows.Item(rnum).Cells(8).Value & "')"

        '  Dim command2 As New SqlCommand(insertQueryy, con1)
        '   ExecuteMyQuery(command2, " Record Inserted ")
        '   r = r + 1

        '  Loop
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Dim deleteQuery As String = "DELETE FROM orderDetails WHERE cid = " & TextBoxCid.Text

        ' Dim command As New SqlCommand(deleteQuery, con1)

        ' ExecuteMyQuery(command, "Record Deleted ")


    End Sub
End Class