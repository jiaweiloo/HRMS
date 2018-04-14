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
End Module