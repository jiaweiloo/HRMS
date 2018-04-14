Module NextLeaveID
    Public Leave(99999) As Leave
    Public Count As Integer = 0

    Public Function GetNextId() As String
        Count = 0
        Dim db As New HRMS_DBLinq2DataContext
        Dim lastid As String
        Dim id As String
        id = "L0000"
        For Each a In db.Leaves
            lastid = a.leave_id
            Count = Count + 1

        Next

        Try
            'Return id & (Count).ToString()
            Return (Count).ToString("00000")
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function
End Module
