Module AttendanceApp

    Public Attendance(99999) As AttendanceClass
    Public Count As Integer
    Public attid As String

    Dim db As New HRMS_DBLinq2DataContext

    Public Function GetCount() As Integer
        Count = 0
        For Each a In db.attends
            Count += 1
        Next
        Return Count
    End Function


    Public Function GetNextId() As String
        Count = 0
        For Each a In db.attends
            Count += 1
        Next

        Return (Count + 1).ToString("A10000")

    End Function


End Module
