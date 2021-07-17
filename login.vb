Imports System.Data.SqlClient
Public Class login

    Dim connection As New SqlConnection("Data Source=LAPTOP-SLT3PTMR\SQLEXPRESS;Initial Catalog=gms;Integrated Security=True")

    Private Sub BTN_CANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_CANCEL.Click
        Me.Close()

    End Sub

    Private Sub BTN_LOGIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_LOGIN.Click
        Dim command As New SqlCommand("SELECT username, password FROM login WHERE username = @username AND password = @password", connection)

        command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBoxUsername.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxPassword.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Invalid Username Or Password")

        Else

            MessageBox.Show("Logged In")

            ' Dim newForm As New Insert_Update_Delete_Search()
            Form2.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If TextBoxPassword.UseSystemPasswordChar = True Then

            ' show password
            TextBoxPassword.UseSystemPasswordChar = False

        Else

            ' hide password
            TextBoxPassword.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBoxPassword.UseSystemPasswordChar = True
    End Sub
End Class