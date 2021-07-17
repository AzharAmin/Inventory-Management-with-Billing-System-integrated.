Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class billing
    Dim con, con1 As SqlConnection
    Dim cmd As SqlCommand
    Dim adpt As SqlDataAdapter
    Dim dt As New DataTable
    Private Sub billing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con1 = New SqlConnection("Data Source=LAPTOP-SLT3PTMR\SQLEXPRESS;Initial Catalog=gms;Integrated Security=True")
        con = New SqlConnection("Data Source=LAPTOP-SLT3PTMR\SQLEXPRESS;Initial Catalog=gms;Integrated Security=True")

      
        LabelCust_name.AutoSize = True
        LabelDate.AutoSize = True
        LabelSum.AutoSize = True
        Labelcgst.AutoSize = True
        Labelsgst.AutoSize = True
        Labelgrandtotal.AutoSize = True


      

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LabelDate.Text = Date.Today


    End Sub

  
    Private Sub billing_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        ' Dim a, b, c As Double
        '  a = ((9 * LabelSum.Text) / 100)
        '  b = ((9 * LabelSum.Text) / 100)
        ' c = (LabelSum.Text) + (Labelcgst.Text) + (Labelsgst.Text)
        ' Labelgrandtotal.Text = c


     

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rnum As Integer
        Dim insertQuery As String = "INSERT INTO bill(cust_name,date,bno,ntotal,cgst,sgst,gtotal) VALUES('" & LabelCust_name.Text & "','" & LabelDate.Text & "','" & TextBoxBillNo.Text & "','" & LabelSum.Text & "','" & Labelcgst.Text & "','" & Labelsgst.Text & "','" & Labelgrandtotal.Text & "')"
        Dim command As New SqlCommand(insertQuery, con1)
        ExecuteMyQuery(command, " Transaction Completed ")



        With DataGridView1
            rnum = 0
            Do While rnum < .RowCount - 1
                Dim Sql As String = "INSERT INTO bdetails(cust_name,prod_name,rate,quantity,amount) VALUES('" & LabelCust_name.Text & "','" & DataGridView1.Rows.Item(rnum).Cells(0).Value & "','" & DataGridView1.Rows.Item(rnum).Cells(1).Value & "','" & DataGridView1.Rows.Item(rnum).Cells(2).Value & "','" & DataGridView1.Rows.Item(rnum).Cells(3).Value & "')"
                Dim command2 As New SqlCommand(Sql, con1)

                rnum = rnum + 1
                ExecuteMyQuery(command2, " Record Inserted ")
            Loop

        End With

        Me.Close()

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
End Class