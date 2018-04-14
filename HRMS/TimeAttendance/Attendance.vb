
Public Class Attendance


    Dim db As New HRMS_DBLinq2DataContext
    Dim att As New attend
    Dim currentdate As Date

    Dim peopleid As String = HRstaffid.hrstaffid

    Dim displayDate As Date



    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If hrrole.Equals("Manager") Then
            btnReport.Visible = True
        End If
        Timer1.Enabled = True
        Dim peopleObject As People = db.Peoples.FirstOrDefault(Function(o) o.people_id = peopleid)
        Dim currentdate As Date = New Date(2018, 4, 14)

        Dim rs = From a In db.attends
                 Where a.people_id.Contains(peopleid) And (a.current_date.Date = currentdate.Date)

        lblName.Text = peopleObject.people_name
        lblDepartment.Text = peopleObject.department_name
        For Each b In db.attends
            Console.WriteLine(b.current_date.Date & currentdate.Date)
        Next

        If rs.Count = 0 Then
            att.attendance_id = AttendanceApp.GetNextId
            att.people_id = peopleid
            att.current_date = Date.Now
            db.attends.InsertOnSubmit(att)
            db.SubmitChanges()
            lblAttID.Text = att.attendance_id.ToString
        Else
            For Each a In db.attends
                If (String.Equals(a.people_id, peopleid)) And (currentdate.Date = a.current_date.Date) Then
                    'att.Store(a.attendance_id, a.people_id, CDate(a.current_date), CDate(a.time_in), CDate(a.time_out), CDate(a.lunch_in), CDate(a.lunch_out))
                    att = db.attends.FirstOrDefault(Function(o) o.attendance_id = a.attendance_id)
                    Console.WriteLine(att.time_in)
                    'MessageBox.Show("hihi" & att.attendance_id)
                    lblAttID.Text = att.attendance_id.ToString
                End If
            Next
        End If

        If att.time_in IsNot Nothing Then
            btnLunchIn.Enabled = True
        End If

        If att.lunch_in IsNot Nothing Then
            btnLunchOut.Enabled = True
        End If

        If att.lunch_out IsNot Nothing Then
            btnCheckOut.Enabled = True
        End If

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("dd-MM-yyyy" & vbNewLine & "hh:mm:ss tt")
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        Dim s As String = Date.Now.ToString("hh:mm:ss tt")
        Dim expenddt As Date = Date.ParseExact(s, "hh:mm:ss tt",
            System.Globalization.DateTimeFormatInfo.InvariantInfo)
        'MessageBox.Show(expenddt.ToString)
        'Console.WriteLine(att.time_in & att2.time_in)
        If (att.time_in Is Nothing) Then
            att.time_in = expenddt.TimeOfDay
            db.SubmitChanges()
            btnLunchIn.Enabled = True
            MessageBox.Show("Check in sucessfully" & vbNewLine & "You may start your work now.", "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf att.time_in IsNot Nothing Then
            MessageBox.Show("Cannot check in again" & vbNewLine & "Lunch in time : " & att.time_in.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub btnLunchIn_Click(sender As Object, e As EventArgs) Handles btnLunchIn.Click
        Dim s As String = Date.Now.ToString("hh:mm:ss tt")
        Dim expenddt As Date = Date.ParseExact(s, "hh:mm:ss tt",
            System.Globalization.DateTimeFormatInfo.InvariantInfo)
        If (att.lunch_in Is Nothing) Then
            att.lunch_in = expenddt.TimeOfDay
            db.SubmitChanges()
            btnLunchOut.Enabled = True
            MessageBox.Show("Lunch in sucessfully" & vbNewLine & "You may take your lunch now.", "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Cannot lunch in again" & vbNewLine & "Lunch in time : " & att.lunch_in.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnLunchOut_Click(sender As Object, e As EventArgs) Handles btnLunchOut.Click
        Dim s As String = Date.Now.ToString("hh:mm:ss tt")
        Dim expenddt As Date = Date.ParseExact(s, "hh:mm:ss tt",
            System.Globalization.DateTimeFormatInfo.InvariantInfo)
        If (att.lunch_out Is Nothing) Then
            att.lunch_out = expenddt.TimeOfDay
            db.SubmitChanges()
            btnCheckOut.Enabled = True
            MessageBox.Show("Lunch out sucessfully" & vbNewLine & "You may continue your work now.", "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Cannot lunch out again" & vbNewLine & "Lunch in time : " & att.lunch_out.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Dim s As String = Date.Now.ToString("hh:mm:ss tt")
        Dim expenddt As Date = Date.ParseExact(s, "hh:mm:ss tt",
            System.Globalization.DateTimeFormatInfo.InvariantInfo)
        If (att.time_out Is Nothing) Then
            att.time_out = expenddt.TimeOfDay
            db.SubmitChanges()

            MessageBox.Show("Check out sucessfully" & vbNewLine & "You may go back now.", "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Cannot check out again" & vbNewLine & "Lunch in time :" & att.time_out.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        AttendanceHistory.ShowDialog()
    End Sub
End Class
