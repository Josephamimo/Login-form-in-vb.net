Imports MySql.Data.MySqlClient
Public Class frmuserpassword
    Dim pos As String
    Private Sub pass()
        con.Open()
        cmd = New MySqlCommand("Select username,pwd,position, status from users where  pwd = sha1('" + txtpass.Text + "') and  status ='ACTIVE' and username='" & frmusername.txtuser.Text & "'", con)
        rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        If rdr.Read = True Then

            If txtpass.Text = rdr(0) Then
                pos = rdr(2).ToString

                Me.Hide()
                con.Close()
                savelog()

                frmmenu.ShowDialog()
                txtpass.ResetText()
            End If
        Else
            MessageBox.Show("Your password is incorrect. If you have forgotten your password, click Forgot Password below.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End If
        con.Close()
    End Sub
    Private Sub savelog()
        sql = "insert into userslog (user,position,date_in,time_in,date_out,time_out)values('" & lblusername.Text & "','" & pos & "','" & Now.Date & "','" & TimeOfDay & "','','')"
        execute_sql()
    End Sub
    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If Len(Trim(txtpass.Text)) = Nothing Then
            MessageBox.Show("Please enter your password", "login info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpass.Focus()
            Exit Sub
        End If
        pass()
    End Sub
    Private Sub frmuserpassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmusername.RetrieveImage()
    End Sub

    Private Sub linkback_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkback.LinkClicked
        frmusername.Show()
        Me.Hide()
    End Sub
End Class