Public Class AttendanceHistory
    Dim peopleid As String = HRstaffid.hrstaffid



    Private Sub AttendanceHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim db As New HRMS_DBLinq2DataContext
        Dim rs = From a In db.attends
                 Where a.people_id.Contains(peopleid)
                 Select a.attendance_id, a.current_date, a.time_in, a.lunch_in, a.lunch_out, a.time_out

        dgvHistory.DataSource = rs
        lblCount.Text = rs.Count.ToString("0 history(s)")
    End Sub
End Class