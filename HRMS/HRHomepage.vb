Public Class HRHomepage

    Private Sub btnGoPayroll_Click(sender As Object, e As EventArgs) Handles btnGoPayroll.Click
        MDIParent1.ShowForm(PayrollHomepage)
    End Sub

    Private Sub btnGoLeave_Click(sender As Object, e As EventArgs) Handles btnGoLeave.Click
        MDIParent1.ShowForm(DisplayLeave)
    End Sub

    Private Sub HRHomepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MDIParent1.AddNewStaffToolStripMenuItem.Enabled = True
        MDIParent1.UpdateStaffDetailsToolStripMenuItem.Enabled = True
        MDIParent1.RetrieveStaffDetailsToolStripMenuItem.Enabled = True
        MDIParent1.DeleteStaffDetailsToolStripMenuItem.Enabled = True

        MDIParent1.Text = MDIParent1.Text & "Home Page"
    End Sub

    Private Sub HRHomepage_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        MDIParent1.AddNewStaffToolStripMenuItem.Enabled = True
        MDIParent1.UpdateStaffDetailsToolStripMenuItem.Enabled = True
        MDIParent1.RetrieveStaffDetailsToolStripMenuItem.Enabled = True
        MDIParent1.DeleteStaffDetailsToolStripMenuItem.Enabled = True
    End Sub

    Private Sub btnAttend_Click(sender As Object, e As EventArgs) Handles btnAttend.Click
        MDIParent1.ShowForm(Attendance)
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        MDIParent1.ShowForm(AddNewStaff)
    End Sub
End Class
