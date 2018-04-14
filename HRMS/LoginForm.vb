Public Class LoginForm
    Dim userid As String
    Dim password As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        userid = txtUserID.Text
        password = txtPassword.Text
        If ValidateLogin(userid, password) = "Staff" Then
            MDIStaff.Show()
            'NormalStaffPage.Show()
        ElseIf ValidateLogin(userid, password) = "HR" Then
            MDIParent1.Show()
        ElseIf ValidateLogin(userid, password) = "Manager" Then
            MDIManager.Show()
        ElseIf ValidateLogin(userid, password) = "invalidaccount" Then
            MessageBox.Show("Invalid User ID", "Invalid User ID !")
        End If
    End Sub

    Function ValidateLogin(ByVal username As String, ByVal password As String) As String
        ' create LINQ context to the access database
        Dim db As New HRMS_DBLinq2DataContext
        ' check credentials against User table
        'Dim rs As People = db.Peoples.FirstOrDefault(Function(o) o.people_id = username And o.people_password = password)
        Try
            For Each a In db.Peoples
                If userid.ToLower = a.people_id.ToLower And password = a.people_password Then
                    If (a.people_role.Equals("Staff")) Then
                        HRstaffid.StoreId(userid, a.people_name, a.people_role)
                        Return "Staff"
                    ElseIf (a.people_role.Equals("Manager")) Then
                        HRstaffid.StoreId(userid, a.people_name, a.people_role)
                        Return "Manager"
                    ElseIf (a.people_role.Equals("HR")) Then
                        HRstaffid.StoreId(userid, a.people_name, a.people_role)
                        Return "HR"
                    Else
                        Return "cantfindrole"
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("something")
        End Try
        Return "invalidaccount"
    End Function

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        MDIParent1.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class