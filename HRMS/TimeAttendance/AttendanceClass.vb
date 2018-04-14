Public Class AttendanceClass
    Public Property attendance_id As String
    Public Property people_id As String
    Public Property current_date As Date
    Public Property time_in As Date
    Public Property time_out As Date
    Public Property lunch_in As Date
    Public Property lunch_out As Date


    Public Sub New()

    End Sub
    Public Sub Store(attendance_id As String, people_id As String, current_date As Date, time_in As Date, time_out As Date, lunch_in As Date, lunch_out As Date)
        Me.attendance_id = attendance_id
        Me.people_id = people_id
        Me.current_date = current_date
        Me.time_in = time_in
        Me.time_out = time_out
        Me.lunch_in = lunch_in
        Me.lunch_out = lunch_out
    End Sub



End Class
