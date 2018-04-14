Public Class UpdateForm
    Public SelectedId As String

    Private Sub UpdateForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim db As New HRMS_DBLinqDataContext()
        Dim a As People = db.Peoples.FirstOrDefault(Function(o) o.people_id = SelectedId)

        If a Is Nothing Then
            MessageBox.Show("Staff not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        lblIndex.Text = a.people_index.ToString
        lblStaffID.Text = a.people_id
        txtName.Text = a.people_name
        txtIC.Text = a.people_ic
        DateDOB.Value = Date.Parse(a.people_DOB)
        txtPhone.Text = a.people_phone
        txtEmail.Text = a.people_email
        txtAddress.Text = a.people_address
        lblextra.Text = a.extra_leave.ToString
        lblhourpay.Text = a.hourly_rates.ToString

        Select Case a.department_name
            Case "IT Dept." : cboDepart.SelectedIndex = 0
            Case "HR Dept." : cboDepart.SelectedIndex = 1
            Case "Accounting Dept." : cboDepart.SelectedIndex = 2
            Case "Marketing Dept." : cboDepart.SelectedIndex = 3
        End Select
        Select Case a.people_gender
            Case "Male" : radMale.Checked = True
            Case "Female" : radFemale.Checked = True
        End Select
        Select Case a.leave_num
            Case 5 : cboLeave.SelectedIndex = 0
            Case 4 : cboLeave.SelectedIndex = 1
            Case 3 : cboLeave.SelectedIndex = 2
            Case 2 : cboLeave.SelectedIndex = 3
            Case 1 : cboLeave.SelectedIndex = 4
            Case 0 : cboLeave.SelectedIndex = 5
        End Select
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim db As New HRMS_DBLinqDataContext()
        Dim a As People = db.Peoples.FirstOrDefault(Function(o) o.people_id = SelectedId)

        If a Is Nothing Then
            MessageBox.Show("Customer not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        db.Peoples.DeleteOnSubmit(a)
        db.SubmitChanges()

        Dim index As Integer
        Dim gender As String = ""
        Dim role As String = ""

        Try
            If cboDepart.SelectedIndex = 1 Then
                role = "HR"
            Else
                role = "Staff"
            End If

            If (radFemale.Checked = True) Then
                gender = "Female"
            ElseIf (radMale.Checked = True) Then
                gender = "Male"
            Else
                MessageBox.Show("Please select gender !", "error")
                Return
            End If

            Dim ppl As New People
            ppl.people_id = lblStaffID.Text
            ppl.people_index = Integer.Parse(lblIndex.Text)
            ppl.people_password = txtIC.Text
            ppl.people_name = txtName.Text
            ppl.people_ic = txtIC.Text
            ppl.people_DOB = DateDOB.Value.ToString("yyyy-MM-dd")
            ppl.people_gender = gender
            ppl.people_phone = txtPhone.Text
            ppl.people_email = txtEmail.Text
            ppl.people_address = txtAddress.Text
            ppl.people_role = role
            ppl.department_name = cboDepart.SelectedItem.ToString
            ppl.leave_num = Integer.Parse(cboLeave.SelectedItem.ToString)
            ppl.extra_leave = Integer.Parse(lblextra.Text)
            ppl.hourly_rates = Integer.Parse(lblhourpay.Text)

            'Dim db2 As New HRDatabaseDataContext()
            db.Peoples.InsertOnSubmit(ppl)
            'Submit the change to the database.
            Try
                db.SubmitChanges()
            Catch ex As Exception
                MessageBox.Show("Error : " & ex.Message, "error")
            End Try
            MessageBox.Show("Staff [" + lblStaffID.Text + "] updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "error")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim db As New HRMS_DBLinqDataContext()
        Dim a As People = db.Peoples.FirstOrDefault(Function(o) o.people_id = SelectedId)
        If a Is Nothing Then
            MessageBox.Show("Staff not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If
        '1 : Delete the customer record using LINQ
        db.Peoples.DeleteOnSubmit(a)
        db.SubmitChanges()
        '2: Show a message box to indicate deletion done
        MessageBox.Show("Staff [" & a.people_id & "] deleted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class