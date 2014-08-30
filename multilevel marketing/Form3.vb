Imports System.Data.SqlClient
Imports System.IO
Public Class frm_show
    Dim cs As New conection

    Dim photo() As Byte
    Public flag As Boolean = True
    Public txt As String
    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cs.connect()
        start()
        If flag Then
            txt_id.ReadOnly = False
            PictureBox2.Visible = True
            Form2.Visible = False
            btn_ok.Enabled = False
        Else
            txt_id.Text = txt
            Threegtre.Visible = False
            txt_id.ReadOnly = True
            btn_clear.Visible = False
            btn_ok.Visible = False
            search()
        End If


        
        ' con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Documents and Settings\PIYUSH HURPADE\Desktop\project database\multi_lm.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        'cmd = New SqlCommand
        'cmd.Connection = con


    End Sub

    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click

        search()

    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        PictureBox2.Visible = True
        ' txt_id.ReadOnly = True
        start()
    End Sub
    Public Sub start()
        GroupBox4.Visible = False
        Label2.Visible = False
        btn_update.Visible = False
        lbl_update.Visible = False
        pbox.Visible = False
        Label4.Visible = True
        ' btn_ok.Enabled = True
        If flag Then
            txt_id.Text = ""
            Threegtre.Visible = False
            txt_id.ReadOnly = False
        End If
        Threegtre.Visible = False

        btn_clear.Enabled = False
        GroupBox2.Visible = False
        Label2.Visible = False
        Label1.Visible = False
        lbl_rdate.Visible = False
    End Sub

    Private Sub txt_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_id.TextChanged
        validation()
    End Sub

    Private Sub validation()
        Dim s As Integer
        s = txt_id.Text.Trim.Length

        If (s) Then
            If (s = 1) Then
                btn_ok.Enabled = True
                ' btn_clear.Enabled = True
                '  MsgBox(s)
            End If
        Else
            '.Enabled = False
            'btn_reset.Enabled = False
            btn_ok.Enabled = False
        End If
    End Sub
    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        cs.done()
            
        If cs.con.State = ConnectionState.Closed Then
            cs.con.Open()
        End If
        Try

            cs.cmd.CommandText = "update cust_info set name='" + txtbx_name.Text + "',address='" + txtbx_add.Text + "',cell='" + txtbx_cell.Text + "',dob='" + txt_dob.Text + "'where mem_id='" + txt_id.Text + "'"

            cs.cmd.ExecuteNonQuery()
            MsgBox("Data updated successfully!", MsgBoxStyle.Information)

            txtbx_name.ReadOnly = True
            txtbx_add.ReadOnly = True
            txt_dob.ReadOnly = True
            txtbx_cell.ReadOnly = True


            btn_update.Enabled = False
            lbl_update.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub lbl_update_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbl_update.LinkClicked
        If MsgBox("Do you want to update your information", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then

            txtbx_name.ReadOnly = False
            txtbx_add.ReadOnly = False
            txt_dob.ReadOnly = False
            txtbx_cell.ReadOnly = False

            ' MsgBox("You can update now")
            btn_update.Enabled = True
            lbl_update.Enabled = False
        End If
    End Sub

   
    Private Sub frm_show_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If flag Then
            Form2.Visible = True
        Else
            Threegtre.Visible = True
        End If

    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
    Private Sub search()
        PictureBox2.Visible = False
        btn_ok.Enabled = False

        Dim member As String
        member = txt_id.Text
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
                btn_clear.Enabled = True
                pbox.Visible = True
                Label4.Visible = False
                GroupBox2.Visible = True
                Label2.Visible = True
                Label1.Visible = True
                lbl_rdate.Visible = True
                While (cs.dr.Read)
                    txt_id.Text = cs.dr(1)
                    txt_id.ReadOnly = True
                    txtbx_name.Text = cs.dr(2)
                    txtbx_add.Text = cs.dr(3)
                    lbl_rdate.Text = cs.dr(4)
                    photo = cs.dr(5)

                    File.WriteAllBytes("photo.jpg", photo)
                    pbox.Load("photo.jpg")
                    txtbx_cell.Text = cs.dr(6)
                    txt_dob.Text = cs.dr(7)
                End While
                If flag Then
                    lbl_update.Visible = True
                    lbl_update.Enabled = True
                    btn_update.Visible = True
                    btn_update.Enabled = False
                End If

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

    
End Class