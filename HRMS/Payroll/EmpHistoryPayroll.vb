Public Class EmpHistoryPayroll
    Private Sub BindData()

        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs = From c In db.netpays
                 Where c.people_id = HRstaffid.hrstaffid

        dgv.DataSource = rs

        lblCount.Text = rs.Count.ToString("0 record(s)")
    End Sub

    Private Sub EmpHistoryPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MDIParent1.AddNewStaffToolStripMenuItem.Enabled = True
        MDIParent1.UpdateStaffDetailsToolStripMenuItem.Enabled = True
        MDIParent1.RetrieveStaffDetailsToolStripMenuItem.Enabled = True
        MDIParent1.DeleteStaffDetailsToolStripMenuItem.Enabled = True

        BindData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        BindData()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub
End Class