Public Class UpdateStaffDetail
    Private Sub UpdateStaffDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboGender.Text = "All"
        cboDepart.Text = "All"
        BindData()
        lblHRname.Text = HRstaffid.hrname
        lblHRid.Text = HRstaffid.hrstaffid
        txtStaffid.Focus()
        MDIParent1.AddNewStaffToolStripMenuItem.Enabled = True
        MDIParent1.UpdateStaffDetailsToolStripMenuItem.Enabled = False
    End Sub

    Private Sub UpdateStaffDetail_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        cboGender.Text = "All"
        cboDepart.Text = "All"
        BindData()
        lblHRname.Text = HRstaffid.hrname
        lblHRid.Text = HRstaffid.hrstaffid
        txtStaffid.Focus()
        MDIParent1.AddNewStaffToolStripMenuItem.Enabled = True
        MDIParent1.UpdateStaffDetailsToolStripMenuItem.Enabled = False
    End Sub
    Private Sub BindData()
        Dim staffid As String = txtStaffid.Text
        Dim name As String = txtName.Text
        Dim department As String = cboDepart.Text
        Dim gender As String = cboGender.Text
        Dim role As String = "Staff"

        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs = From a In db.Peoples
                 Where a.people_role = role And a.people_id.Contains(staffid) And a.people_name.Contains(name) And (department = "All" Or a.department_name = department) And (gender = "All" Or a.people_gender = gender)
                 Select a.people_id, a.people_name, a.department_name, a.people_gender
        dgv.DataSource = rs
        lblCount.Text = rs.Count().ToString("0 record(s)")
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
            UpdateForm.SelectedId = id
            UpdateForm.ShowDialog(Me)
            BindData()
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        MDIParent1.ShowForm(HRHomepage)
    End Sub
End Class