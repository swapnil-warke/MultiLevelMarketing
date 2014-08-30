Imports System.Data.SqlClient
Imports System.IO

Public Class Form4
    Dim member As String
    Dim cs As New conection
    Dim photo() As Byte
    'Dim d As tree
    Dim i As Integer
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form2.Visible = False
        Button2.Visible = False
        Button6.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Me.Height = 512
        Me.Width = 318
        i = 0
        cs.connect()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        get_info(Button2.Text)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        member = TextBox1.Text
        If member.Trim.Length = 0 Then
            MsgBox("Please enter valid member ID.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        Else
            cs.done()
            If cs.con.State = ConnectionState.Closed Then
                cs.con.Open()
            End If


            ' Try
            cs.cmd.CommandText = "select * from cust_tree where mem_id ='" + member + "'"

            'Catch ex As Exception

            ' End Try

            Try
                cs.dr = cs.cmd.ExecuteReader

                If cs.dr.HasRows = True Then
                    While (cs.dr.Read)
                        Button2.Visible = False
                        Button3.Visible = False
                        Button4.Visible = False
                        Button5.Visible = False
                        Button6.Visible = False

                        Button2.Text = ""
                        Button3.Text = ""
                        Button4.Text = ""
                        Button5.Text = ""
                        Button6.Text = ""
                        Button3.Text = cs.dr(0)
                        Button3.Visible = True

                        If IsDBNull(cs.dr(1)) <> True Then
                            Button2.Text = cs.dr(1)
                            Button2.Visible = True


                        End If
                        If IsDBNull(cs.dr(2)) <> True Then
                            Button4.Text = cs.dr(2)
                            Button4.Visible = True
                        End If
                        If IsDBNull(cs.dr(3)) <> True Then
                            Button5.Text = cs.dr(3)
                            Button5.Visible = True
                        End If
                        If IsDBNull(cs.dr(4)) <> True Then
                            Button6.Text = cs.dr(4)
                            Button6.Visible = True
                        End If
                    End While
                Else
                    MsgBox("No such member exist", MsgBoxStyle.Critical)
                    TextBox1.Clear()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cs.dr.Close()
                cs.con.Close()
            End Try


        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Height = 512
        Me.Width = 318
    End Sub


    
    Private Sub get_info(ByVal mem As String)

        Dim member As String
        txt_id.ReadOnly = True
        member = mem
        If (member.Length = 0) Then
            MsgBox("Please enter valid member ID.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End If
        cs.done()
        cs.cmd.CommandText = "select * from cust_info where mem_id ='" + member + "'"

        If cs.con.State = ConnectionState.Closed Then
            cs.con.Open()
        End If

        Try
            cs.dr = cs.cmd.ExecuteReader

            If cs.dr.HasRows = True Then

                

                Me.Height = 518
                Me.Width = 868
                pbox.Visible = True

                'GroupBox2.Visible = True
                Label2.Visible = True
                Label1.Visible = True
                lbl_rdate.Visible = True
                While (cs.dr.Read)
                    txt_id.Text = cs.dr(1)
                    txtbx_fname.Text = cs.dr(2)
                    txtbx_add.Text = cs.dr(3)
                    lbl_rdate.Text = cs.dr(4)
                    photo = cs.dr(5)

                    File.WriteAllBytes("photo.jpg", photo)
                    pbox.Load("photo.jpg")
                    txtbx_cell.Text = cs.dr(6)
                    txt_dob.Text = cs.dr(7)
                End While
            Else
                MsgBox("No such member exist", MsgBoxStyle.Critical)
                txt_id.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cs.dr.Close()
            cs.con.Close()
        End Try

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        get_info(Button3.Text)
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        get_info(Button4.Text)
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        get_info(Button5.Text)
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        get_info(Button6.Text)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Height = 512
        Me.Width = 318

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Form7.Show()
    End Sub

    Private Sub Form4_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form2.Visible = True
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        member = TextBox1.Text
        If member.Trim.Length = 0 Then
            MsgBox("Please enter valid member ID.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        Else

            check()

             End If
    End Sub
    Private Sub check()

        cs.done()
        If cs.con.State = ConnectionState.Closed Then
            cs.con.Open()
        End If


        Try

            cs.cmd.CommandText = "select * from cust_info where mem_id ='" + member + "'"


            cs.dr = cs.cmd.ExecuteReader

        

            If cs.dr.HasRows = True Then
                Threegtre.mem = member.ToUpper
                Threegtre.Show()


            Else
                MsgBox("Invalid parent ID", MsgBoxStyle.Critical)
                TextBox1.Clear()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cs.dr.Close()
            cs.con.Close()
        End Try

    End Sub
End Class