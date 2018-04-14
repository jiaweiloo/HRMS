Module peopleid
    Public Peoples(99999) As People
    Public Count As Integer = 0
    Public newindex As Integer = 0

    Public Function GetNextId() As String
        Dim peopleid As String
        Dim db As New HRMS_DBLinqDataContext
        Dim lastindex As Integer
        Try
            For Each a In db.Peoples
                lastindex = a.people_index
            Next
        Catch ex As Exception
            Return "Fail to connect database"
        End Try
        newindex = lastindex + 1
        peopleid = "STF" + newindex.ToString
        Return peopleid
    End Function
End Module
