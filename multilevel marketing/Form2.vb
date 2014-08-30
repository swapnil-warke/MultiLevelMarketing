
Public Class Form2
    Private Sub MemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberToolStripMenuItem.Click
        cust_info.Show()
    End Sub

    Private Sub ShowToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem1.Click
        frm_show.Show()
         End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        add_admin.Show()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        update_admin.show()
    End Sub
    Private Sub Form2_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ' SplashScreen1.Close()

        Form1.Visible = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub AboutMLMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutMLMToolStripMenuItem.Click
        About_mlm.show()
    End Sub

    Private Sub GenologyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenologyToolStripMenuItem1.Click
        Form4.Show()
    End Sub

    Private Sub valuestrip1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles valuestrip1.Click
        set_values.Show()
    End Sub

    Private Sub TRANSACTIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRANSACTIONToolStripMenuItem.Click
        transtoday.Show()
    End Sub
End Class