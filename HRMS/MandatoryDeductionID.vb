Module MandatoryDeductionID
    Public initial As Integer = 1
    Public Function GetNextId() As String
        Dim db As New HRMS_DBLinq2DataContext
        Dim mandeductList = (From c In db.mandatory_deductions).ToList
        Dim mandeduct As mandatory_deduction
        Try
            mandeduct = mandeductList.ElementAt(mandeductList.Count - 1)
            Return (mandeduct.deduction_id + 1).ToString("00000")
        Catch ex As Exception
            Return (initial).ToString("40000")
        End Try
    End Function
End Module
