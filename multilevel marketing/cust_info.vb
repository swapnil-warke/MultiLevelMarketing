Imports System.Data.SqlClient
Imports System.IO
Public Class cust_info
    Dim conn As New conection

    Dim s1 As String
    Dim check As Integer = 0
    Dim i As Integer
    Public photo() As Byte
    Public da As SqlDataAdapter
    Public cmdbldr As SqlCommandBuilder
    Public ds As DataSet
    Public dtrow As DataRow

    Private Sub cust_info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form2.Visible = False
        ' btn_clear.Enabled = False
        conn.connect()
        lbl_rdate.Text = Today
        Dim str As String = ""
        Dim a1 As Integer = 0

        conn.done()
        da = New SqlDataAdapter("Select * from cust_info", conn.con)

        ds = New DataSet()
        Try
            da.Fill(ds)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' da.Fill(ds)

        i = ds.Tables(0).Rows.Count
        If conn.con.State = ConnectionState.Closed Then
            conn.con.Open()
        End If
        conn.cmd.CommandType = CommandType.Text
        If (i) Then
            Try
                conn.cmd.CommandText = "Select * from cust_info where sr_no=" + CStr(i)


                conn.dr = conn.cmd.ExecuteReader
                If conn.dr.HasRows = True Then
                    While (conn.dr.Read)
                        str = conn.dr("mem_id")
                    End While
                End If
                a1 = str.Length
                s1 = str.Remove(2, a1 - 2)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.dr.Close()

            conn.con.Close()


        Else
            s1 = "MM"

        End If
        i = i + 1
        Dim temp As String
        temp = s1
        temp &= CInt(i)
        lbl_id.Text = temp

        ds.Clear()



        'get_id()
        'If (check) Then
        'btn_ok.Enabled = True
        'End If
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        
        If txtbx_fname.Text = "" Or txtbx_mname.Text = "" Or txtbx_lname.Text = "" Then
            MsgBox("Enter Your full name ", MsgBoxStyle.Critical)
        Else
           
            ' Dim count As Integer = 1
            'count += 1
            


            Dim d As Integer
            Dim demo As String
            d = CInt(dtp.Text.ToString.Length)
            demo = dtp.Text.Remove(0, d - 4)
            'MsgBox(demo)
            Dim d1 As Integer
            Dim demo1 As String
            d1 = CInt(lbl_rdate.Text.ToString.Length)
            demo1 = lbl_rdate.Text.Remove(0, d1 - 4)
            If (CInt(demo1) - CInt(demo)) < 18 Then
                MsgBox("Age below 18 is not allowed")
            Else
                If txtbx_add.Text.Trim.Length = 0 Then
                    MsgBox("Enter your address",MsgBoxStyle.Information)
               
                Else

                    If txtbx_cell.Text.Length < 10 Then
                        txtbx_cell.Clear()
                        MsgBox("Cell no. less than 10 digit is not allowed", MsgBoxStyle.Critical)


                    Else
                        Dim member As String

                        member = txtbx_pid.Text
                        If (member.Length = 0) Then
                            MsgBox("Please enter valid member ID.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)


                        Else
                            conn.done()
                            If conn.con.State = ConnectionState.Closed Then
                                conn.con.Open()
                            End If


                            Try

                                conn.cmd.CommandText = "select * from cust_info where mem_id ='" + member + "'"


                                conn.dr = conn.cmd.ExecuteReader

                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try

                            If conn.dr.HasRows = True Then
                                btn_upload.Enabled = False
                                Dim s As String


                                s = ""
                                s &= txtbx_fname.Text + " " + txtbx_mname.Text + " " + txtbx_lname.Text
                                Try
                                    conn.dr.Close()
                                    conn.cmd.CommandText = "Insert into cust_info values(@sr_no,@mem_id,@name,@add,@date,@photo,@cell,@dob,@parent_id)"
                                    conn.cmd.Parameters.AddWithValue("@sr_no", i)

                                    conn.cmd.Parameters.AddWithValue("@mem_id", lbl_id.Text.Trim())
                                    conn.cmd.Parameters.AddWithValue("@name", s.Trim())

                                    conn.cmd.Parameters.AddWithValue("@add", txtbx_add.Text.Trim())
                                    conn.cmd.Parameters.AddWithValue("@date", lbl_rdate.Text.Trim())
                                    Try
                                        photo = File.ReadAllBytes(ofd.FileName)
                                        conn.cmd.Parameters.AddWithValue("@photo", photo)















































                                    Catch ex As Exception
                                        MsgBox("Error occured while uploading", MsgBoxStyle.Exclamation)
                                    End Try
                                    conn.cmd.Parameters.AddWithValue("@cell", (txtbx_cell.Text))
                                    conn.cmd.Parameters.AddWithValue("@dob", dtp.Text.ToString.Trim())
                                    conn.cmd.Parameters.AddWithValue("@parent_id", txtbx_pid.Text)

                                Catch ex As Exception
                                    MsgBox(ex.Message)
                                End Try
                                If conn.con.State = ConnectionState.Closed Then
                                    conn.con.Open()
                                End If
                                conn.cmd.Connection = conn.con

                                Try
                                    conn.cmd.ExecuteNonQuery()
                                    MsgBox("Now Row is Inserted")

                                    clear()

                                    get_id()

                                Catch ex As Exception
                                    MsgBox(ex.Message)

                                End Try
                            Else
                                MsgBox("Invalid parent ID", MsgBoxStyle.Critical)
                                txtbx_pid.Clear()
                            End If
                        End If
                    End If
                End If
            End If

        End If

        btn_upload.Enabled = True
        conn.con.Close()
    End Sub

    Private Sub btn_upload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_upload.Click
        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If MsgBox("Are you sure to upload this image?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                Try
                    pbox.Load(ofd.FileName)
                    '                    btn_upload.Enabled = False
                Catch ex As Exception

                    MsgBox(ex.Message)
                End Try
            End If
            
        End If



    End Sub
    Private Sub clear()
        txtbx_add.Clear()
        txtbx_cell.Clear()
        txtbx_fname.Clear()
        txtbx_lname.Clear()
        txtbx_mname.Clear()
        txtbx_pid.Clear()

        pbox.Load("D:\vbnetpro\multilevel marketing\multilevel marketing\Resources\blank.png")
    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        clear()
    End Sub

    Private Sub get_id()
        Dim a2 As String
        'a2 = lbl_id.Text.Length
        's1 = lbl_id.Text.Remove(2, a2 - 2)
        a2 = s1
        i = i + 1
        a2 &= CInt(i)
        lbl_id.Text = a2
    End Sub
    
    Private Sub txtbx_fname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbx_fname.TextChanged
        validat(txtbx_fname)
    End Sub

    Private Sub cust_info_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form2.Visible = True
    End Sub
    Private Sub validat(ByRef s As TextBox)
        If (s.Text.Length = 1 And IsNumeric(s.Text)) Then
            MsgBox("Numbers are invalid")
            s.Clear()

        ElseIf (s.Text.Length > 1) Then
            If IsNumeric(s.Text.Remove(0, s.Text.Length - 1)) Then

                MsgBox("Numbers are invalid")
                s.Text = s.Text.Remove(s.Text.Length - 1, 1)


            End If
        End If
    End Sub

    Private Sub txtbx_mname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbx_mname.TextChanged
        validat(txtbx_mname)
    End Sub

    Private Sub txtbx_lname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbx_lname.TextChanged
        validat(txtbx_lname)
    End Sub
End Class