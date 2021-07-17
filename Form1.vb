Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str1, str2 As String
        str1 = TextBox1.Text
        str2 = TextBox2.Text
        If (str1 = "admin") & (str2 = "admin") Then
            Form2.Show()
            MsgBox("LoggedIn Successfully")
        Else
            MsgBox("invalid username/password")
        End If
    End Sub
End Class
