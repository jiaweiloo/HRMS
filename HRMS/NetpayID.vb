Module NetpayID
    Public initial As Integer = 1

    Public Function GetNextId() As String
        Dim db As New HRMS_DBLinq2DataContext
        Dim netpayList = (From c In db.netpays).ToList
        Dim ntpay As netpay
        Try
            ntpay = netpayList.ElementAt(netpayList.Count - 1)
            Return (ntpay.payroll_id + 1).ToString("00000")
        Catch ex As Exception
            Return (initial).ToString("30000")
        End Try
    End Function
End Module
