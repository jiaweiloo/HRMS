Public Class EmpHistoryPayroll
    Private Sub btnGoHome_Click(sender As Object, e As EventArgs) Handles btnGoHome.Click
        MDIParent1.ShowForm(HRHomepage)
    End Sub

    Private Sub ShowHistory()
        Dim netpaysss As New netpay

    End Sub

    Private Sub EmpHistoryPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MDIParent1.AddNewStaffToolStripMenuItem.Enabled = True
        MDIParent1.UpdateStaffDetailsToolStripMenuItem.Enabled = True
        MDIParent1.RetrieveStaffDetailsToolStripMenuItem.Enabled = True
        MDIParent1.DeleteStaffDetailsToolStripMenuItem.Enabled = True
    End Sub
End Class