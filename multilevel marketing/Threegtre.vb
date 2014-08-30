Public Class Threegtre
    Dim cs As New conection
    Dim q As New Queue
    ' Dim d As New tree

    Public mem As String
    ' Public mem1 As String
    'Public mem2 As String
    'Public mem3 As String
    

    Private Sub Threegtre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form4.Visible = False
        p.Visible = False
        fc1.Visible = False
        fc1c1.Visible = False
        fc1c2.Visible = False
        fc1c3.Visible = False
        fc2c1.Visible = False
        fc2c2.Visible = False
        fc2c3.Visible = False
        fc3c1.Visible = False
        fc3c2.Visible = False
        fc3c3.Visible = False
        fc2.Visible = False
        fc3.Visible = False

        '  d.drawtree(mem)
        cs.connect()
        cs.done()
        Dim mcount As Integer = 1
        q.Enqueue(mem)
        arrange(mcount, mem)




        Do While q.Count <> 0 And (mcount < 13 Or mcount = 13)

            mem = q.Peek().ToString()
            'MsgBox(mem)
            cs.cmd.CommandText = "select * from cust_tree where mem_id ='" + mem + "'"
            If cs.con.State = ConnectionState.Closed Then
                cs.con.Open()
            End If
            Dim i As Integer = 0

            Try
                cs.dr = cs.cmd.ExecuteReader

                If cs.dr.HasRows = True Then

                    While cs.dr.Read
                        'MsgBox(cs.dr(1) + cs.dr(0) + cs.dr(2) + cs.dr(3) + cs.dr(4))

                        'ListBox1.Items.Add(cs.dr(0) + "   " + cs.dr(1))


                        If IsDBNull(cs.dr(2)) <> True Then
                            q.Enqueue(cs.dr(2).ToString())
                            mcount += 1
                            arrange(mcount, cs.dr(2).ToString())

                            'MsgBox ()
                        End If

                        If IsDBNull(cs.dr(3)) <> True Then
                            q.Enqueue(cs.dr(3).ToString())
                            mcount += 1
                            arrange(mcount, cs.dr(3).ToString())
                        End If

                        If IsDBNull(cs.dr(4)) <> True Then
                            q.Enqueue(cs.dr(4).ToString())
                            mcount += 1
                            arrange(mcount, cs.dr(4).ToString())
                        End If

                    End While
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cs.dr.Close()

            End Try
            q.Dequeue()

        Loop
    End Sub
    Private Sub arrange(ByVal ch As Integer, ByVal txt As String)
        If ch = 1 Then
            p.Text = txt
            p.Visible = True

        ElseIf ch = 2 Then
            fc1.Text = txt
            fc1.Visible = True


        ElseIf ch = 3 Then
            fc2.Text = txt
            fc2.Visible = True


        ElseIf ch = 4 Then
            fc3.Text = txt
            fc3.Visible = True


        ElseIf ch = 5 Then
            fc1c1.Text = txt
            fc1c1.Visible = True


        ElseIf ch = 6 Then
            fc1c2.Text = txt
            fc1c2.Visible = True


        ElseIf ch = 7 Then
            fc1c3.Text = txt
            fc1c3.Visible = True


        ElseIf ch = 8 Then
            fc2c1.Text = txt
            fc2c1.Visible = True


        ElseIf ch = 9 Then
            fc2c2.Text = txt
            fc2c2.Visible = True


        ElseIf ch = 10 Then
            fc2c3.Text = txt
            fc2c3.Visible = True


        ElseIf ch = 11 Then
            fc3c1.Text = txt
            fc3c1.Visible = True


        ElseIf ch = 12 Then
            fc3c2.Text = txt
            fc3c2.Visible = True


        Else
            fc3c3.Text = txt
            fc3c3.Visible = True

        End If

    End Sub
    Private Sub send(ByVal z As Button)
        frm_show.flag = False
        frm_show.txt = z.Text
        frm_show.Show()
    End Sub

    Private Sub p_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p.Click
        send(p)
    End Sub

    Private Sub fc1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fc1.Click
        send(fc1)
    End Sub
    

    Private Sub fc2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fc2.Click
        send(fc2)
    End Sub

    Private Sub fc3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fc3.Click
        send(fc3)
    End Sub

    Private Sub fc1c1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fc1c1.Click
        send(fc1c1)
    End Sub

    Private Sub fc3c3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fc3c3.Click
        send(fc3c3)
    End Sub

    Private Sub fc1c2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fc1c2.Click
        send(fc1c2)
    End Sub

    Private Sub fc3c1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fc3c1.Click
        send(fc3c1)
    End Sub

    Private Sub fc2c3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fc2c3.Click
        send(fc2c3)
    End Sub

    Private Sub fc2c2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fc2c2.Click
        send(fc2c2)
    End Sub

    Private Sub fc2c1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fc2c1.Click
        send(fc2c1)
    End Sub

    Private Sub fc1c3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fc1c3.Click

        send(fc1c3)
    End Sub

    Private Sub fc3c2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fc3c2.Click
        send(fc3c2)
    End Sub

    Private Sub Threegtre_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form4.Visible = True
    End Sub
End Class