Public Class ManagerMainPage
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        MDIManager.Close()
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        MDIManager.ShowForm(ManAddHR)
    End Sub

    Private Sub btnAttend_Click(sender As Object, e As EventArgs) Handles btnAttend.Click
        MDIManager.ShowForm(Attendance)
    End Sub

    Private Sub btnViewleave_Click(sender As Object, e As EventArgs) Handles btnViewleave.Click
        MDIManager.ShowForm(ManagerViewLeave)
    End Sub

    Private Sub ManagerMainPage_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        MDIManager.AddNewHRToolStripMenuItem.Enabled = True
        MDIManager.UpdateHRFetailsToolStripMenuItem.Enabled = True
        MDIManager.DeleteHRToolStripMenuItem.Enabled = True
    End Sub

    Private Sub ManagerMainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MDIManager.AddNewHRToolStripMenuItem.Enabled = True
        MDIManager.UpdateHRFetailsToolStripMenuItem.Enabled = True
        MDIManager.DeleteHRToolStripMenuItem.Enabled = True
    End Sub
End Class