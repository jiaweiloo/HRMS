Public Class DisplayLeave
    Private Sub BindData()

        Dim status As String = cboLeave.Text

        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs = From c In db.Leaves
                 Where (status = "All" Or c.status = status)
        dgvLeave.DataSource = rs

        lblCount.Text = rs.Count().ToString("0 record(s)")
        lblCount.ForeColor = Color.Red
    End Sub

    Private Sub LeaveDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboLeave.Text = "All"
        lblID.Text = HRstaffid.hrstaffid
        lblName.Text = HRstaffid.hrname
        'lblID.BackColor = Color.AliceBlue
        'lblName.BackColor = Color.AliceBlue
        Dim style As FontStyle
        style = FontStyle.Bold
        Dim timesNewRoman As Font = New Font("Times New Roman", 12, style)
        Dim fore As Color = Color.GreenYellow
        lblID.ForeColor = fore
        lblName.ForeColor = fore
        lblID.Font = timesNewRoman
        lblName.Font = timesNewRoman

        BindData()
        MDIParent1.AddNewStaffToolStripMenuItem.Enabled = True
        MDIParent1.UpdateStaffDetailsToolStripMenuItem.Enabled = True
        MDIParent1.RetrieveStaffDetailsToolStripMenuItem.Enabled = True
        MDIParent1.DeleteStaffDetailsToolStripMenuItem.Enabled = True
    End Sub

    Private Sub cboLeave_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLeave.SelectedIndexChanged
        BindData()
    End Sub

    Private Sub dgvLeave_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeave.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 And CStr(dgvLeave.Rows(i).Cells(6).Value) = "Pending" Then
            Dim id As String = CStr(dgvLeave.Rows(i).Cells(0).Value)
            Dim peopleid As String = CStr(dgvLeave.Rows(i).Cells(5).Value)
            Update_Leave.peopleID = peopleid.ToString()
            Update_Leave.selected_id = id

            MDIParent1.ShowForm(Update_Leave)
            'Update_Leave.Show(Me)
            'BindData()
        End If
        MDIStaff.ShowForm(ManagerViewLeave)
    End Sub

    Private Sub DisplayLeave_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        lblID.Text = HRstaffid.hrstaffid
        lblName.Text = HRstaffid.hrname
        MDIParent1.AddNewStaffToolStripMenuItem.Enabled = True
        MDIParent1.UpdateStaffDetailsToolStripMenuItem.Enabled = True
        MDIParent1.RetrieveStaffDetailsToolStripMenuItem.Enabled = True
        MDIParent1.DeleteStaffDetailsToolStripMenuItem.Enabled = True
    End Sub
End Class