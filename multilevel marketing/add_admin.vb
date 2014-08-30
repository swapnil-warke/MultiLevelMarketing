Public Class add_admin
    Dim cs As New conection

    Private Sub LinkL1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkL1.LinkClicked
        GroupBox1.Visible = True
        LinkL1.Visible = False
        LinkL2.Visible = False
    End Sub

    Private Sub add_admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cs.connect()
        Form2.Visible = False
        GroupBox1.Visible = False
    End Sub

    Private Sub LinkL2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkL2.LinkClicked
        Me.Close()

    End Sub


    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click
        If txtbx_login_id.Text.Trim.Length = 0 Then
            MsgBox("Enter valid ID", MsgBoxStyle.Exclamation)
            txtbx_login_id.Clear()
            txtbx_login_id.Focus()
        End If

        If txtbx_password.Text = txtbx_conpas.Text Then
            cs.done()

            If cs.con.State = ConnectionState.Closed Then
                cs.con.Open()
            End If
            Try
                cs.cmd.CommandText = "Insert into login_auth values (@lid,@name,@password,@post)"
                cs.cmd.Parameters.AddWithValue("@lid", txtbx_login_id.Text)
                cs.cmd.Parameters.AddWithValue("@name", txtbx_adname.Text)
                cs.cmd.Parameters.AddWithValue("@password", txtbx_password.Text)
                cs.cmd.Parameters.AddWithValue("@post", lbl_post.Text)


                cs.cmd.ExecuteNonQuery()
                clear()

            Catch ex As Exception

                MsgBox(ex.Message)
            Finally
                cs.con.Close()
            End Try

        Else
            MsgBox("Passwrd does not match." + vbNewLine + "Try again!", MsgBoxStyle.Critical)
            txtbx_password.Clear()
            txtbx_conpas.Clear()


        End If


    End Sub
    Private Sub clear()
        txtbx_login_id.Clear()

        txtbx_password.Clear()
        txtbx_adname.Clear()
        txtbx_password.Clear()
        txtbx_conpas.Clear()


    End Sub

    Private Sub add_admin_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form2.Visible = True
    End Sub
End Class