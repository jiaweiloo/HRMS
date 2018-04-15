Module CalcOvertime
    Public Sub Calculate()
        Dim alreadyexist As String = ""
        Dim difference As TimeSpan
        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs = (From c In db.attends
                  Where c.current_date.Month.Equals(DateTime.Now.Month) And c.current_date.Year.Equals(DateTime.Now.Year)).ToList

        For Each attendance As attend In rs
            If (attendance.time_out > TimeSpan.Parse("17:00:00")) Then
                difference = TimeSpan.Parse(attendance.time_out.ToString) - (TimeSpan.Parse("17:00:00"))

                'Check if overtime already have the records
                If (db.overtimes.Any(Function(o) o.overtime_date.Equals(attendance.current_date) And o.people_id = attendance.people_id)) Then
                    'Useless function
                    'alreadyexist = alreadyexist & " " & attendance.attendance_id
                Else
                    Dim ot As New overtime
                    ot.overtime_id = Integer.Parse(overtimeID.GetNextId())
                    ot.people_id = attendance.people_id
                    ot.overtime_duration = Integer.Parse(difference.TotalHours.ToString("0"))
                    ot.overtime_date = attendance.current_date
                    db.overtimes.InsertOnSubmit(ot)
                    db.SubmitChanges()
                End If
            End If
        Next
    End Sub
End Module
