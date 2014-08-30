Public Class Form1
    Dim a As New conection
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        a.connect()
        txtbx_pwd.Enabled = False
        btn_reset.Enabled = False
        btn_ok.Enabled = False
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reset.Click
        txtbx_id.Clear()
        txtbx_pwd.Clear()
        txtbx_id.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbx_id.TextChanged
        validation()
    End Sub
    Public Sub validation()
        Dim s As Integer
        s = txtbx_id.Text.Trim.Length

        If (s) Then
            If (s = 1) Then
                txtbx_pwd.Enabled = True
                btn_ok.Enabled = True
                btn_reset.Enabled = True
                '  MsgBox(s)
            End If
        Else
            txtbx_pwd.Enabled = False
            btn_reset.Enabled = False
            btn_ok.Enabled = False
        End If
    End Sub

    Private Sub btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ok.Click

        Dim id As String = ""
        Dim password As String = ""
        Dim post As String = ""
        a.done()
        a.cmd.CommandText = "select * from login_auth where log_id='" + txtbx_id.Text + "'"
        If a.con.State = ConnectionState.Closed Then
            Try
                a.con.Open()
            Catch ex As Exception

            End Try

        End If

        Try

            a.dr = a.cmd.ExecuteReader
            If a.dr.HasRows = True Then
                While (a.dr.Read)
                    id = a.dr(0).ToString.Trim()
                    password = a.dr(2).ToString.Trim()
                    post = a.dr(3).ToString.Trim()

                End While
            End If
            a.dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If (post = "manager" And txtbx_id.Text.Trim() = id And txtbx_pwd.Text.Trim() = password) Then
            Me.Visible = False
            Form2.Show()


            Form2.valuestrip1.Enabled = True
            Form2.adminstrip.Enabled = True
            txtbx_id.Text = ""
            txtbx_pwd.Text = ""
        ElseIf (post = "Admin" And txtbx_id.Text = id And txtbx_pwd.Text = password) Then
            Me.Visible = False
            Form2.Show()

            Form2.valuestrip1.Enabled = False
            Form2.adminstrip.Enabled = False
            txtbx_id.Text = ""
            txtbx_pwd.Text = ""
        Else
            MsgBox("Invalid username/password", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            txtbx_id.Text = ""
            txtbx_pwd.Text = ""
        End If

        a.con.Close()
    End Sub
    
    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        SplashScreen1.Close()
    End Sub
End Class
