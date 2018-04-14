Module overtimeID
    Public initial As Integer = 1

    Public Function GetNextId() As String
        Dim db As New HRMS_DBLinq2DataContext
        Dim otList = (From c In db.overtimes).ToList
        Dim ot As overtime
        Try
            ot = otList.ElementAt(otList.Count - 1)
            Return (ot.overtime_id + 1).ToString("00000")
        Catch ex As Exception
            Return (initial).ToString("30000")
        End Try
    End Function
End Module
