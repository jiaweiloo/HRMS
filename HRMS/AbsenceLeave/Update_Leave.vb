Public Class Update_Leave
    Public manager_id As String
    Public selected_id As String
    Public peopleID As String

    Private Sub resetform()
        Label1.Text = ""
        Label2.Text = ""
        radRejected.Checked = True
        Label3.Text = ""
        Label4.Text = ""


    End Sub

    Private Sub Update_Leave_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        lblID.Text = HRstaffid.hrstaffid
        lblName.Text = HRstaffid.hrname
        resetform()
        Dim db As New HRMS_DBLinq2DataContext()
        Dim c As Leave = db.Leaves.FirstOrDefault(Function(o) o.leave_id = selected_id)
        If c Is Nothing Then
            MessageBox.Show("Customer not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        Label1.Text = c.leave_id
        Label2.Text = c.people_id
        Label3.Text = c.reason
        Label4.Text = c.leave_duration.ToString()
        Select Case c.status
            Case "Rejected" : radRejected.Checked = True
            Case "Approved" : radApproved.Checked = True
        End Select

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim db As New HRMS_DBLinq2DataContext()
        Dim c As Leave = db.Leaves.FirstOrDefault(Function(o) o.leave_id = selected_id)
        Dim emp As People = db.Peoples.FirstOrDefault(Function(a) a.people_id = peopleID)

        If c Is Nothing Then
            MessageBox.Show("Leave Application not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        If emp Is Nothing Then
            MessageBox.Show("Staff not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        c.Reject_approve_date = CDate(Today.ToShortDateString)
        c.status = If(radRejected.Checked = True, "Rejected", "Approved")
        db.SubmitChanges()
        Dim extra_leave As Integer

        If (emp.leave_num < c.leave_duration) Then
            extra_leave = emp.extra_leave - c.leave_duration

        End If

        If (radApproved.Checked = True) Then
            emp.leave_num = emp.leave_num - c.leave_duration
        End If
        db.SubmitChanges()


        MessageBox.Show("Leave [" & c.leave_id & "]updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()

    End Sub

    Private Sub Update_Leave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblID.Text = HRstaffid.hrstaffid
        lblName.Text = HRstaffid.hrname
    End Sub
End Class