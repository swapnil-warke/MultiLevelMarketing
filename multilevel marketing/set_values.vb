Public Class set_values

    Private Sub set_values_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form2.Visible = False
    End Sub

    Private Sub set_values_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form2.Visible = True
    End Sub
End Class