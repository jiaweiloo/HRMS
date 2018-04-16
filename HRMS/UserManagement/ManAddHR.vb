Imports System.Text

Public Class ManAddHR
    Public Sub ResetForm()
        txtName.Text = ""
        txtIC.Text = ""
        DateDOB.ResetText()
        radMale.Checked = True
        txtPhone.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        cboDepartment.SelectedIndex = 1
        txtName.Focus()
        Err.Clear()
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If Me.ValidateChildren() = False Then
            Return
        End If
        Try
            Dim err As New StringBuilder()
            Dim ctr As Control = Nothing

            Dim id As String = ""
            Dim name As String = ""
            Dim IC As String = ""
            Dim dob As String = ""
            Dim gender As String = ""
            Dim phone As String = ""
            Dim email As String = ""
            Dim address As String = ""
            Dim role As String = ""
            Dim depart As String = ""

            id = lblStaffID.Text
            name = txtName.Text
            IC = If(txtIC.MaskCompleted, txtIC.Text, "")
            dob = DateDOB.Value.ToString("yyyy-MM-dd")
            If (radFemale.Checked = True) Then
                gender = "Female"
            ElseIf (radMale.Checked = True) Then
                gender = "Male"
            Else
                MessageBox.Show("Please select gender !", "error")
                Return
            End If
            phone = If(txtPhone.MaskCompleted, txtPhone.Text, "")
            email = txtEmail.Text
            address = txtAddress.Text
            depart = cboDepartment.SelectedItem.ToString
            If depart = "HR Dept." Then
                role = "HR"
            Else
                role = "Staff"
            End If
            If dob = "" Then
                err.AppendLine("- Please Enter Correct Birthday")
                ctr = If(ctr, DateDOB)
            End If
            If name = "" Then
                err.AppendLine("- Please Enter Name")
                ctr = If(ctr, txtName)
            End If
            If IC = "" Then
                err.AppendLine("- Please Enter Correct IC Format")
                ctr = If(ctr, txtIC)
            End If
            If phone = "" Then
                err.AppendLine("- Please Enter Correct Phone")
                ctr = If(ctr, txtPhone)
            End If
            If email = "" Then
                err.AppendLine("- Please Enter Email")
                ctr = If(ctr, txtEmail)
            End If
            If address = "" Then
                err.AppendLine("- Please Enter Address")
                ctr = If(ctr, txtAddress)
            End If
            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ctr.Focus()
            Else

                Dim ppl As New People
                ppl.people_id = id
                ppl.people_index = peopleid.newindex
                ppl.people_password = IC
                ppl.people_name = name
                ppl.people_ic = IC
                ppl.people_DOB = dob
                ppl.people_gender = gender
                ppl.people_phone = phone
                ppl.people_email = email
                ppl.people_address = address
                ppl.people_role = role
                ppl.department_name = depart
                ppl.leave_num = 5
                ppl.extra_leave = 0
                ppl.hourly_rates = 15
                ppl.joined_year = Date.Parse(lblTimeNow.Text)

                Dim db As New HRMS_DBLinq2DataContext()
                db.Peoples.InsertOnSubmit(ppl)
                db.SubmitChanges()

                MessageBox.Show("Insert complete", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ResetForm()
                lblStaffID.Text = HRstaffid.GetHRNextId
            End If
        Catch ex As Exception
            MessageBox.Show("Input Error ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ResetForm()
    End Sub

    Private Sub ManAddHR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTimeNow.Text = Date.Now.ToShortDateString
        lblStaffID.Text = HRstaffid.GetHRNextId
        lblHRname.Text = HRstaffid.hrname
        lblHRid.Text = HRstaffid.hrstaffid
        cboDepartment.SelectedIndex = 1
        txtName.Focus()
        Dim maxdate As System.TimeSpan = New TimeSpan(4748, 0, 0, 0, 0)
        DateDOB.MaxDate = DateTime.Now.Subtract(maxdate)
        MDIManager.AddNewHRToolStripMenuItem.Enabled = False
        MDIManager.UpdateHRFetailsToolStripMenuItem.Enabled = True
        MDIManager.Text = "Human Resource Management System (Manager)- Add HR Employee"
    End Sub

    Private Sub ManAddHR_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        lblTimeNow.Text = Date.Now.ToShortDateString
        lblStaffID.Text = HRstaffid.GetHRNextId
        lblHRname.Text = HRstaffid.hrname
        lblHRid.Text = HRstaffid.hrstaffid
        cboDepartment.SelectedIndex = 1
        txtName.Focus()
        Dim maxdate As System.TimeSpan = New TimeSpan(4748, 0, 0, 0, 0)
        DateDOB.MaxDate = DateTime.Now.Subtract(maxdate)
        MDIManager.AddNewHRToolStripMenuItem.Enabled = False
        MDIManager.UpdateHRFetailsToolStripMenuItem.Enabled = True
    End Sub

    Private Sub cboDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepartment.SelectedIndexChanged
        If cboDepartment.SelectedIndex = 1 Then
            lblStaffID.Text = HRstaffid.GetHRNextId
        Else
            lblStaffID.Text = peopleid.GetNextId
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        MDIManager.ShowForm(ManagerMainPage)
    End Sub
End Class