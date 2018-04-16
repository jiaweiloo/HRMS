Public Class Update_Leave
    Public manager_id As String
    Public selected_id As String
    Public peopleID As String

    Private Sub resetform()
        Label5.Text = ""
        Label6.Text = ""
        radRejected.Checked = True
        Label7.Text = ""
        Label8.Text = ""
    End Sub

    Private Sub Update_Leave_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        resetform()
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
        Label5.Text = c.leave_id
        Label6.Text = c.people_id
        Label7.Text = c.reason
        Label8.Text = c.leave_duration.ToString()
        Dim style As FontStyle
        style = FontStyle.Bold
        Dim timesNewRoman As Font = New Font("Times New Roman", 12, style)
        Dim fore As Color = Color.Brown
        Label5.Font = timesNewRoman
        Label5.ForeColor = fore
        Label6.Font = timesNewRoman
        Label6.ForeColor = fore
        Label7.Font = timesNewRoman
        Label7.ForeColor = fore
        Label8.Font = timesNewRoman
        Label8.ForeColor = fore
        Select Case c.status
            Case "Rejected" : radRejected.Checked = True
            Case "Approved" : radApproved.Checked = True
        End Select
        MDIManager.Text = "Human Resource Management System (Manager) - Leave approval"
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
        'db.SubmitChanges()
        Dim extra_leave As Integer

        If (emp.leave_num < c.leave_duration) And radApproved.Checked = True Then
            extra_leave = Math.Abs(emp.leave_num - c.leave_duration)

            'Dim deduction As New deduction
            'deduction.deduction_id = Integer.Parse(DeductionID.GetNextId())
            'deduction.deduction_type = type
            'deduction.deduction_value = Math.Abs((emp.extra_leave - emp.leave_num) * 200)
            'deduction.people_id = peopleID
            'deduction.deduction_format = format
            'db.deductions.InsertOnSubmit(deduction)

            Dim deduction As New deduction
            deduction.deduction_id = Integer.Parse(DeductionID.GetNextId())
            deduction.deduction_type = "extraholiday"
            deduction.deduction_value = extra_leave * 9 * emp.hourly_rates
            deduction.people_id = peopleID
            deduction.deduction_format = "money"
            deduction.deduction_date = DateTime.Now
            db.deductions.InsertOnSubmit(deduction)

            emp.extra_leave = emp.extra_leave + extra_leave
            db.SubmitChanges()
            emp.leave_num = 0

            '    Try
            '        db.SubmitChanges()
            '    Catch ex As Exception
            '        MessageBox.Show("Error: " & ex.Message, "Error")
            '    End Try
            'MessageBox.Show("Deduction of" & extra_leave.ToString("0") & " for " & peopleID & " submitted", "Submit")
        ElseIf (radApproved.Checked = True) Then
            emp.leave_num = emp.leave_num - c.leave_duration

        End If

        'If (radApproved.Checked = True) Then
        '    emp.leave_num = emp.leave_num - c.leave_duration
        'End If
        db.SubmitChanges()

        MessageBox.Show("Leave [" & c.leave_id & "]updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MDIParent1.ShowForm(DisplayLeave)
        'Me.Close()
    End Sub

    Private Sub Update_Leave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblID.Text = HRstaffid.hrstaffid
        lblName.Text = HRstaffid.hrname
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MDIParent1.Close()
    End Sub
End Class