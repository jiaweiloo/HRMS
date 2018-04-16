Module HRstaffid
    Public hrstaffid As String
    Public hrname As String
    Public hrrole As String
    Public Function StoreId(userid As String, name As String, role As String) As String
        hrstaffid = userid
        hrname = name
        hrrole = role
        Return hrstaffid
        Return hrname
        Return hrrole
    End Function
    Public Function GetHRNextId() As String
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
        peopleid = "HR" + newindex.ToString
        Return peopleid
    End Function
End Module