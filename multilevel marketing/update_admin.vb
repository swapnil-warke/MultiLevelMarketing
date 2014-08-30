Public Class update_admin
    Dim cs As New conection

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click


        btn_search.Enabled = False

        Dim member As String
        member = txt_id.Text
        If (member.Length = 0) Then
            MsgBox("Please enter valid member ID.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
        End If
        cs.done()
        cs.cmd.CommandText = "select * from login_auth where log_id ='" + member + "'"

        If cs.con.State = ConnectionState.Closed Then
            cs.con.Open()
        End If

        Try
            cs.dr = cs.cmd.ExecuteReader

            If cs.dr.HasRows = True Then
                btn_clear.Enabled = True


                gb.Visible = True

                ' Label1.Visible = True

                While (cs.dr.Read)
                    txt_id.Text = cs.dr(0)
                    txt_id.ReadOnly = True
                    lbl_info.Visible = False

                    txtbx_adname.Text = cs.dr(1)
                    'txtbx_password.Text = cs.dr(2)

                    lbl_post.Text = cs.dr(3)

                    txtbx_password.Visible = False
                    txtbx_conpas.Visible = False
                    lbl_conpas.Visible = False
                    lbl_password.Visible = False
                End While
                lbl_update.Visible = True
                lbl_update.Enabled = True
                btn_update.Visible = True
                btn_update.Enabled = False

            Else
                MsgBox("No such member exist", MsgBoxStyle.Critical)
                txt_id.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cs.dr.Close()
    End Sub
    Public Sub start()

        btn_update.Visible = False
        lbl_update.Visible = False

        Label4.Visible = True

        txt_id.Text = ""
        txtbx_password.Text = ""
        txtbx_conpas.Text = ""


        txt_id.ReadOnly = False
        btn_clear.Enabled = False
        gb.Visible = False
       
    End Sub

    Private Sub update_admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cs.connect()
        Form2.Visible = False
        btn_search.Enabled = False
        start()
    End Sub
    Private Sub validation()
        Dim s As Integer
        s = txt_id.Text.Trim.Length

        If (s) Then
            If (s = 1) Then
                btn_search.Enabled = True
                ' btn_clear.Enabled = True
                '  MsgBox(s)
            End If
        Else
            '.Enabled = False
            'btn_reset.Enabled = False
            btn_search.Enabled = False
        End If
    End Sub

    Private Sub txt_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_id.TextChanged
        validation()
    End Sub

    Private Sub lbl_update_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbl_update.LinkClicked
        If MsgBox("Do you want to update your information", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then

            txtbx_adname.ReadOnly = False
            txtbx_password.ReadOnly = False
            txtbx_conpas.ReadOnly = False


            txtbx_password.Clear()
            txtbx_conpas.Clear()


            lbl_conpas.Visible = True
            lbl_password.Visible = True
            txtbx_password.Visible = True
            txtbx_conpas.Visible = True

            btn_update.Enabled = True
            lbl_update.Enabled = False
        End If
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        cs.done()
        If cs.con.State = ConnectionState.Closed Then
            cs.con.Open()
        End If
        If txtbx_password.Text = txtbx_conpas.Text Then

            Try

                cs.cmd.CommandText = "update login_auth set name='" + txtbx_adname.Text + "',password='" + txtbx_password.Text + "' where log_id='" + txt_id.Text + "'"

                cs.cmd.ExecuteNonQuery()
                MsgBox("Data updated successfully!", MsgBoxStyle.Information)

                txtbx_adname.ReadOnly = True
                txtbx_password.ReadOnly = True
                txtbx_conpas.ReadOnly = True

                txtbx_password.Visible = False
                txtbx_conpas.Visible = False
                lbl_conpas.Visible = False
                lbl_password.Visible = False

                btn_update.Enabled = False
                lbl_update.Enabled = True

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Password does not match!" + vbNewLine + "Try again", MsgBoxStyle.Information)
            txtbx_password.Clear()
            txtbx_conpas.Clear()
        End If
    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        lbl_info.Visible = True
        start()
    End Sub

    Private Sub update_admin_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form2.Visible = True
    End Sub
End Class