Public Class MenuForm

    Private Sub MenuForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    
    Private Sub NewUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewUserToolStripMenuItem.Click
        Me.Hide()

    End Sub

    Private Sub NewUserLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewUserLabel.Click

        UserMaster.Show()
        Me.Hide()
    End Sub
End Class