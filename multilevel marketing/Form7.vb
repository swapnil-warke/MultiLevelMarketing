Imports System.Data.SqlClient

Public Class Form7
    Dim q As New Queue
    Dim mem As String
    Dim cs As New conection
    Dim da As SqlDataAdapter
    Dim cmbld As SqlCommandBuilder
    Dim ds As New DataSet
    Dim dtr As DataRow
    Dim temp As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button3.Enabled = True
        
        If TextBox1.Text = "" Then
            MsgBox("INSERT MEMBER ID")
        Else
            mem = TextBox1.Text
            q.Enqueue(mem)
            Try
                'MsgBox(mem + q.Count.ToString() + " " + q.Peek().ToString())
            Catch ex As Exception

                MsgBox(ex.Message)
            End Try

            Do While q.Count <> 0

                mem = q.Peek().ToString()
                'MsgBox(mem)
                cs.done()

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

                            ListBox1.Items.Add(cs.dr(0) + "   " + cs.dr(1))
                            If IsDBNull(cs.dr(2)) <> True Then
                                q.Enqueue(cs.dr(2).ToString())

                                'MsgBox ()
                            End If

                            If IsDBNull(cs.dr(3)) <> True Then
                                q.Enqueue(cs.dr(3).ToString())
                            End If

                            If IsDBNull(cs.dr(4)) <> True Then
                                q.Enqueue(cs.dr(4).ToString())
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
        End If
        Button1.Enabled = False
    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form4.Visible = False
        Button3.Enabled = False
        cs.connect()
        cs.con.Open()
        da = New SqlDataAdapter("SELECT cust_info.mem_id, cust_info.name, cust_tree.parent_id, cust_tree.mem1, cust_tree.mem2, cust_tree.mem3 FROM cust_info INNER JOIN cust_tree ON cust_info.mem_id = cust_tree.mem_id", cs.con)
        ds = New DataSet()

        da.Fill(ds)
        dgv.DataSource = ds.Tables(0)


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button1.Enabled = True
        TextBox1.Text = ""
        Button3.Enabled = False
    End Sub

    Private Sub Form7_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form4.Visible = True
    End Sub
End Class