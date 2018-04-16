Module peopleid
    Public Peoples(99999) As People
    Public Count As Integer = 0
    Public newindex As Integer = 0

    Public Function GetNextId() As String
        Dim peopleid As String
        Dim db As New HRMS_DBLinq2DataContext
        Dim index As Integer = 10001
        Try
            For Each a In db.Peoples
                index = index + 1
            Next
        Catch ex As Exception
            Return "Fail to connect database"
        End Try

        newindex = index
        Try
            For Each a In db.Peoples
                If newindex = a.people_index Then
                    newindex += 1
                End If
            Next
        Catch ex As Exception
            Return "Fail to connect database"
        End Try
        peopleid = "STF" + newindex.ToString

        Return peopleid
    End Function
End Module
