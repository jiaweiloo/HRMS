Imports System.Text

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
        MDIManager.Text = "Human Resource Management System (Manager)- Update HR Details"
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

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        MDIManager.ShowForm(ManagerMainPage)
    End Sub

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Dim db As New HRMS_DBLinq2DataContext()
        ' (1) Fonts 
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 14, FontStyle.Bold)
        Dim fontBody As New Font("Consolas", 10, FontStyle.Bold)

        ' (2) Prepare header and sub-header 
        Dim header As String = vbNewLine & "Staff Personal Details"
        Dim subHeader As String = String.Format(vbNewLine & vbNewLine & vbNewLine & "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
                                                "Prepared by " & vbNewLine &
                                                "Manager ID : " & HRstaffid.hrstaffid &
                                                "    Manager Name : " & HRstaffid.hrname & vbNewLine &
                                                "Manager from HR Department.", DateTime.Now)
        ' (3) Prepare body 
        Dim body As New StringBuilder()
        body.AppendLine(vbNewLine)
        body.AppendLine(vbNewLine)
        body.AppendLine(vbNewLine)
        body.AppendLine(vbNewLine)
        body.AppendLine(" No      Staff ID |  Staff Name  | Department  | Joined Date  |  IC-Number    |   Gender  |  Phone")
        body.AppendLine(" ----------------------------------------------------------------------------------------------------------")
        Dim cnt As Integer = 0
        For Each item In db.Peoples
            cnt += 1
            'parts = CStr(item).Split(CChar(vbTab))
            body.AppendFormat("{0,2}       {1,6}      {2,6}       {3,6}    {4,6}     {5,6}     {6,6}   {7,6}" & vbNewLine, cnt, item.people_id, item.people_name, item.department_name, item.joined_year.ToShortDateString, item.people_ic, item.people_gender, item.people_phone)
        Next
        body.AppendLine()
        body.AppendFormat("{0,2} record(s)", cnt)

        ' (4) Print 
        With e.Graphics
            .DrawImage(My.Resources.hr2, 450, 20, 200, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 100, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
        End With
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        dlgPreview.Document = doc
        dlgPreview.ShowDialog(Me)
    End Sub
End Class