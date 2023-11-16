Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging
Module sqlcon
    Public con As MySqlConnection = New MySqlConnection("server= localhost;Port=3306; database=librarymngt; username= root; password=sms")
    Public result1 As Integer
    Public schlname As String

    'START
    Public dbPath As String = "server= localhost;Port=3306; database=librarymngt; username= root; password=sms"

    Public da As MySqlDataAdapter
    Public cmdb As MySqlCommandBuilder
    Public rdr As MySqlDataReader
    Public cmd As MySqlCommand
    '  Public con As MySqlConnection
    'Public conn As New ADODB.Connection
    Public dt As New DataTable
    Public mychoice As String
    Public dbRESPONSE As Boolean = True
    Public escape As Boolean = False
    Public ds As New DataSet
    Public sql As String
    Public errNo As Integer


    'set Status Based On Login
    Public LogIn As Boolean = True
    '#=======================================================
    Public Sub UpdateDatagrid(ByVal dt As DataTable)
        Try
            Dim cb As New MySqlCommandBuilder(da)
            Dim i As Integer = da.Update(dt)
            MsgBox(i & " records updated")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub updateGrid(ByVal table As String)
        con = New MySqlConnection(dbPath)

        Try
            con.Open()
            da = New MySqlDataAdapter(table, con)
            Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)
            da.Fill(ds, table)
        Catch ex As Common.DbException
            MsgBox(ex.ToString)
            con.Close()
        End Try
    End Sub
    Public Sub modifyTable(ByVal sql As String)

        Try
            con = New MySqlConnection(dbPath)
            con.Open()

            cmd = New MySqlCommand(sql, con)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            escape = False
        Catch ex As MySqlException
            escape = True
            MsgBox(ex.Message)
        End Try
        dbRESPONSE = True
    End Sub
    Public Sub dbOPEN()
        Try
            con = New MySqlConnection(dbPath)
            con.Open()
        Catch ex As Exception
            ' MsgBox(ex.Message)
            '  frmLogin.Show()
            '   LogIn = False
        End Try
    End Sub
    Public Sub CREATETABLE(ByVal sq As String)
        Try
            con = New MySqlConnection(dbPath)
            con.Open()

            cmd = New MySqlCommand(sq, con)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            escape = False
        Catch ex As Exception
            escape = True
            MsgBox(ex.Message)
        End Try
        dbRESPONSE = True
    End Sub
    Public Sub modifyTable(ByVal TABLE As String, ByVal ql As String)

        Try
            con = New MySqlConnection(dbPath)
            con.Open()

            cmd = New MySqlCommand(ql, con)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            escape = False
        Catch ex As Exception
            escape = True
        End Try
        dbRESPONSE = True
    End Sub
    Public Sub loadGrid(ByVal table As String, ByVal sql As String)
        Try
            con = New MySqlConnection(dbPath)
            sql = "SELECT *FROM " & table & ""

            da = New MySqlDataAdapter(sql, con)
            Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(da)
            da.Fill(ds, table)

            'DataGridView1.DataSource = ds
            'DataGridView1.DataMember = "subjects"

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub
    'Public Sub UpdateDatagrid(ByVal dtt As DataTable)
    '    Dim cb As New MySqlCommandBuilder(da)
    '    Dim i As Integer = da.Update(dtt)
    '    MsgBox(i & " records updated")
    'End Sub

    Public Sub insert(ByVal table As String, ByVal inserts As String)
        Try
            con = New MySqlConnection(dbPath)
            con.Open()
            cmd = New MySqlCommand(inserts, con)
            cmd.ExecuteNonQuery()
            escape = False
            'MsgBox("Recorded Successfully", MsgBoxStyle.Information, "Success")
        Catch ex As MySqlException
            '   MsgBox("Error " & ex.Number & "-" & ex.Message)

            errNo = ex.Number
            If dbRESPONSE = True Then
                ' MsgBox("A SIMILAR RECORD ALREADY EXIST")
            End If
            escape = True
        Finally
            cmd.Dispose()
            con.Close()
        End Try
    End Sub
    Public Sub update(ByVal table As String, ByVal upDate As String)
        Try
            con = New MySqlConnection(dbPath)
            con.Open()
            cmd = New MySqlCommand(upDate, con)
            cmd.ExecuteNonQuery()
            escape = False
            'MsgBox("Updated Successfully", MsgBoxStyle.Information, "Updated")
        Catch ex As Exception
            If dbRESPONSE = True Then
                MsgBox(ex.Message)
            End If
        End Try
    End Sub
    Public Sub search(ByVal table As String, ByVal Search As String)
        Try
            con = New MySqlConnection(dbPath)
            con.Open()
            cmd = New MySqlCommand(Search, con)
            cmd.ExecuteNonQuery()
            escape = False
        Catch ex As Exception
            If dbRESPONSE = True Then
                MsgBox(ex.Message)
            End If
        End Try
    End Sub
    Public Sub delete(ByVal table As String, ByVal Del As String)
        Try
            con = New MySqlConnection(dbPath)
            con.Open()
            cmd = New MySqlCommand(Del, con)
            cmd.ExecuteNonQuery()
            escape = False
            ' MsgBox("Delete Successfully")
        Catch ex As Exception
            If dbRESPONSE = True Then
                MsgBox(ex.Message)
            End If
        End Try
    End Sub
    Public Sub createTable(ByVal Table As String, ByVal st As String)
        Try
            con = New MySqlConnection(dbPath)
            con.Open()
            'Dim MyChoice As String = "create database " & Table & ""
            'Da = New MySqlDataAdapter(MyChoice, path
            cmd = New MySqlCommand(st, con)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub fillDataGrid(ByVal table As String)
        Try
            con = New MySqlConnection(dbPath)
            con.Open()
            mychoice = "SELECT *FROM " & table & ""
            cmd = New MySqlCommand(mychoice, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub fillCombo(ByVal combo As ComboBox, ByVal mySelect As String, ByVal header As String)

        Dim RecNum As Integer
        Try
            da = New MySqlDataAdapter(mySelect, dbPath)
            da.Fill(dt)
            da.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        combo.Items.Clear()
        RecNum = dt.Rows.Count
        For i As Integer = 0 To RecNum - 1
            combo.Items.Add(dt.Rows(i)(header).ToString.ToUpper)
        Next

        For i As Int16 = 0 To combo.Items.Count - 2
            For j As Int16 = combo.Items.Count - 1 To i + 1 Step -1
                If combo.Items(i).ToString = combo.Items(j).ToString Then
                    combo.Items.RemoveAt(j)
                End If
            Next
        Next

    End Sub
#Region "FILL COMBOBOX WITH DATABASE RECORDS"
    Public Sub autoFillCombo(ByVal cmb As ComboBox, ByVal str As String)
        Try
            dbOPEN()
            cmd = New MySqlCommand(str, con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            cmb.Items.Clear()
            While rdr.Read = True
                cmb.Items.AddRange(New Object() {rdr(0).ToString()})
            End While

        Catch ex As Exception

        End Try
    End Sub
#End Region
    Public Sub FillComboTOOL(ByVal cmb As ToolStripComboBox, ByVal str As String)
        Try
            dbOPEN()
            cmd = New MySqlCommand(str, con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            cmb.Items.Clear()
            While rdr.Read = True
                cmb.Items.AddRange(New Object() {rdr(0).ToString()})
            End While

        Catch ex As Exception

        End Try
    End Sub
    Public Sub Byte2Image(ByRef NewImage As Image, ByVal ByteArr() As Byte)
        '
        Dim ImageStream As MemoryStream

        Try
            If ByteArr.GetUpperBound(0) > 0 Then
                ImageStream = New MemoryStream(ByteArr)
                NewImage = Image.FromStream(ImageStream)
            Else
                NewImage = Nothing
            End If
        Catch ex As Exception
            NewImage = Nothing
        End Try

    End Sub
    Public Sub Image2Byte(ByRef NewImage As Image, ByRef ByteArr() As Byte)
        '
        Dim ImageStream As MemoryStream

        Try
            ReDim ByteArr(0)
            If NewImage IsNot Nothing Then
                ImageStream = New MemoryStream
                NewImage.Save(ImageStream, ImageFormat.Jpeg)
                ReDim ByteArr(CInt(ImageStream.Length - 1))
                ImageStream.Position = 0
                ImageStream.Read(ByteArr, 0, CInt(ImageStream.Length))
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub imageinsert(ByVal pic As PictureBox, ByVal table As String, ByVal ser As String, ByVal value As String, ByVal col As String)
        Dim da As MySqlDataAdapter
        Dim ds As DataSet
        Dim row As DataRow
        Dim img As Image = pic.Image
        Dim imgbyte As Byte() = Nothing
        Image2Byte(img, imgbyte)



        Dim SELECTsR As String = "SELECT * FROM " & table & ""
        da = New MySqlDataAdapter(SELECTsR, sqlcon.dbPath)

        Dim autogen As New MySqlCommandBuilder(da)
        ds = New DataSet()
        da.Fill(ds, "users")
        Dim dt As DataTable = ds.Tables("users")
        row = dt.Select("" & ser & "  = '" & value & "'")(0)
        row(col) = imgbyte
        'da.Update(ds, "users")
    End Sub


    Public Function GetByIndex(ByVal table As String, ByVal ind As Integer, ByVal col As Integer)

        Try
            con = New MySqlConnection(dbPath)
            con.Open()
            Dim Mychoice As String = " SELECT * FROM " & table & ""
            Dim Ds As New DataSet
            da = New MySqlDataAdapter(Mychoice, con)
            Dim Aut As New MySqlCommandBuilder(da)
            da.Fill(Ds, table)
            Return Ds.Tables(table).Rows(ind).Item(col)
            da.Update(Ds, table)
        Catch ex As Exception

            Return Nothing
        End Try

    End Function
    Public Function SumRow(ByVal ind As Integer, ByVal cond As String, ByVal table As String, ByVal col As Integer)
        Dim amt As Double = 0
        Dim num As Integer

        Try
            con = New MySqlConnection(dbPath)
            con.Open()
            Dim Mychoice As String = cond
            Dim Ds As New DataSet
            da = New MySqlDataAdapter(Mychoice, con)
            Dim Aut As New MySqlCommandBuilder(da)
            da.Fill(Ds, table)
            num = Ds.Tables(table).Rows.Count

            For i As Integer = 0 To num - 1
                amt += Ds.Tables(table).Rows(i).Item(col)
            Next
            Return amt
            da.Update(Ds, table)
        Catch ex As Exception
            MsgBox("ERROR SUMMING UP THE RECORDS")
            Return Nothing
        End Try
    End Function
    Public Function SumRowByIndex(ByVal ind As Integer, ByVal cond As String, ByVal table As String, ByVal col As Integer)
        Dim amt As Double = 0
        Dim num As Integer
        'ind =index
        '
        Try
            con = New MySqlConnection(dbPath)
            con.Open()
            Dim Mychoice As String = "select * from " & table & ""
            Dim Ds As New DataSet
            da = New MySqlDataAdapter(Mychoice, con)
            Dim Aut As New MySqlCommandBuilder(da)
            da.Fill(Ds, table)
            num = Ds.Tables(table).Rows.Count

            For i As Integer = 0 To num - 1
                If Ds.Tables(table).Rows(i).Item(ind) = cond Then
                    amt += Ds.Tables(table).Rows(i).Item(col)
                End If
            Next
            Return amt
            da.Update(Ds, table)
        Catch ex As Exception
            MsgBox("ERROR SUMMING UP THE RECORDS")
            Return Nothing
        End Try
    End Function
    'END
    Public Sub execute_sql()
        dbOPEN()
        Dim cb As String = sql
        cmd = New MySqlCommand(cb)
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Sub usercount()
        con.Open()
        cmd = New MySqlCommand(sql, con)
        rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        rdr.Read()
        If rdr(0) <> 0 Then
            result1 = 1
        Else
            result1 = 0
        End If
        con.Close()
    End Sub
    Public Sub getDataset(ByVal ql As String)
        Try
            con = New MySqlConnection(dbPath)
            con.Open()
            da = New MySqlDataAdapter(ql, con)
            ds = New DataSet()
            da.Fill(ds, 0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub getlogoname()
        con.Open()
        cmd = New MySqlCommand(sql, con)
        rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        If rdr.Read = True Then
            schlname = rdr(0)
        End If
        con.Close()
    End Sub
    Public Sub loadreports(sql As String)
        con.Open()
        cmd = New MySqlCommand()
        da = New MySqlDataAdapter()
        dt = New DataTable()

        cmd.Connection = con
        cmd.CommandText = sql
        da.SelectCommand = cmd
        da.Fill(dt)
        con.Close()
        da.Dispose()
    End Sub
End Module
