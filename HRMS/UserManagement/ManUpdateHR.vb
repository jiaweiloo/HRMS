Public Class ManUpdateHR
    Private Sub BindData()
        Dim staffid As String = txtStaffid.Text
        Dim name As String = txtName.Text
        Dim department As String = cboDepart.Text
        Dim gender As String = cboGender.Text
        Dim role As String = "Staff"
        Dim role2 As String = "HR"
        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs = From a In db.Peoples
                 Where (a.people_role = role Or a.people_role = role2) And a.people_id.Contains(staffid) And a.people_name.Contains(name) And (department = "All" Or a.department_name = department) And (gender = "All" Or a.people_gender = gender)
                 Select a.people_id, a.people_name, a.department_name, a.people_gender
        dgv.DataSource = rs
    End Sub

    Private Sub txtStaffid_TextChanged(sender As Object, e As EventArgs) Handles txtStaffid.TextChanged
        BindData()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        BindData()
    End Sub

    Private Sub cboDepart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepart.SelectedIndexChanged
        BindData()
    End Sub

    Private Sub cboGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGender.SelectedIndexChanged
        BindData()
    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgv.Rows(i).Cells(0).Value)
            ManUpdateForm.SelectedId = id
            ManUpdateForm.ShowDialog(Me)
            BindData()
        End If
    End Sub

    Private Sub ManUpdateHR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboGender.Text = "All"
        cboDepart.Text = "HR Dept."
        lblHRname.Text = HRstaffid.hrname
        lblHRid.Text = HRstaffid.hrstaffid
        MDIManager.AddNewHRToolStripMenuItem.Enabled = True
        MDIManager.UpdateHRFetailsToolStripMenuItem.Enabled = False
        BindData()
    End Sub

    Private Sub ManUpdateHR_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        cboGender.Text = "All"
        cboDepart.Text = "HR Dept."
        lblHRname.Text = HRstaffid.hrname
        lblHRid.Text = HRstaffid.hrstaffid
        MDIManager.AddNewHRToolStripMenuItem.Enabled = True
        MDIManager.UpdateHRFetailsToolStripMenuItem.Enabled = False
        BindData()
    End Sub
End Class