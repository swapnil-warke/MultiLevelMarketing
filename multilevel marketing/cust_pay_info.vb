Public Class cust_pay_info

  
    Private Sub cust_pay_info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GB3.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GB3.Visible = True
    End Sub
End Class