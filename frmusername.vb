Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class frmusername
    Private Sub user()
        con.Open()
        cmd = New MySqlCommand("Select username, position,fullname, status from  users where username ='" & txtuser.Text.ToLower & "' and  status ='ACTIVE'", con)
        rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        If rdr.Read = True Then

            If txtuser.Text = rdr(0) Then
                frmuserpassword.lblrole.Text = rdr(1)
                frmuserpassword.lblusername.Text = rdr(2)

                Me.Hide()
                con.Close()


                frmuserpassword.ShowDialog()
                txtuser.ResetText()
            End If
        Else
            MessageBox.Show("No account with that username. Please contact the administrator for assistance.", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        End If
        con.Close()
    End Sub
    Public Sub RetrieveImage()
        Dim da As MySqlDataAdapter
        Dim ds As DataSet
        Dim row As DataRow
        Try
            sql = "SELECT username,user_photo FROM users"
            da = New MySqlDataAdapter(sql, sqlcon.dbPath)

            Dim autogen As New MySqlCommandBuilder(da)
            ds = New DataSet()
            da.Fill(ds, "users")
            Dim dt As DataTable = ds.Tables("users")
            row = dt.Select("username = '" & txtuser.Text & "'")(0)
            sqlcon.Byte2Image(frmuserpassword.picbox.Image, row("user_photo"))

        Catch ex As Exception
            Beep()
            MsgBox("USER NOT FOUND")
            Exit Sub
        End Try
    End Sub
    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If Len(Trim(txtuser.Text)) = 0 Then
            MessageBox.Show("Please enter your username", "login info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtuser.Focus()
            Exit Sub
        End If
        user()
    End Sub
End Class
