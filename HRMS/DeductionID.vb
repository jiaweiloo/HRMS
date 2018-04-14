Module DeductionID

    Public initial As Integer = 1

    Public Function GetNextId() As String
        Dim db As New HRMS_DBLinq2DataContext
        Dim deductList = (From c In db.deductions).ToList
        Dim deduct As deduction
        Try
            deduct = deductList.ElementAt(deductList.Count - 1)
            Return (deduct.deduction_id + 1).ToString("00000")
        Catch ex As Exception
            Return (initial).ToString("20000")
        End Try
    End Function
End Module
