Imports System.Data.SqlClient
Public Class transtoday
    Dim cs As New conection
    Dim da As SqlDataAdapter
    Dim ds As DataSet

    Private Sub transtoday_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Form2.Visible = False
        cs.connect()

        cs.con.Open()


        Dim txt As String
        txt = Today
        da = New SqlDataAdapter("SELECT mem_id, name, address, date, cell, dob, parent_id FROM cust_info WHERE (date = '" + txt + "')", cs.con)
        ds = New DataSet()

        da.Fill(ds, "cust_info")
        dg.DataSource = ds.Tables("cust_info")
       
    End Sub

    Private Sub transtoday_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form2.Visible = True
    End Sub
End Class