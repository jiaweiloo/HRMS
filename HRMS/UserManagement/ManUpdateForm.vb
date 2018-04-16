Imports System.Text

Public Class ManUpdateForm
    Public SelectedId As String

    Private Sub ManUpdateForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtName.Focus()
        Dim maxdate As System.TimeSpan = New TimeSpan(5479, 0, 0, 0, 0)
        DateDOB.MaxDate = DateTime.Now.Subtract(maxdate)
        Dim db As New HRMS_DBLinq2DataContext()
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
        txtHourlyPay.Text = a.hourly_rates.ToString
        lblJoin.Text = a.joined_year.ToShortDateString
        lblPass.Text = a.people_password

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
        Dim db As New HRMS_DBLinq2DataContext()
        Dim a As People = db.Peoples.FirstOrDefault(Function(o) o.people_id = SelectedId)
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
        depart = cboDepart.SelectedItem.ToString
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
        If cboDepart.SelectedIndex < 0 Then
            err.AppendLine("- Please Select Department")
            ctr = If(ctr, cboDepart)
        End If
        If IC = "" Then
            err.AppendLine("- Please Enter Correct IC Format")
            ctr = If(ctr, txtIC)
        End If
        If phone = "" Then
            err.AppendLine("- Please Enter Correct Phone Format")
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
            If a Is Nothing Then
                MessageBox.Show("Staff not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            db.Peoples.DeleteOnSubmit(a)
            db.SubmitChanges()
            Try
                Dim ppl As New People
                ppl.people_id = lblStaffID.Text
                ppl.people_index = Integer.Parse(lblIndex.Text)
                ppl.people_password = lblPass.Text
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
                ppl.hourly_rates = Integer.Parse(txtHourlyPay.Text)
                ppl.joined_year = Date.Parse(lblJoin.Text)

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
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim db As New HRMS_DBLinq2DataContext()
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

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Dim db As New HRMS_DBLinq2DataContext()
        ' (1) Fonts 
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 14, FontStyle.Bold)
        Dim fontBody As New Font("Consolas", 14, FontStyle.Bold)

        ' (2) Prepare header and sub-header 
        Dim header As String = vbNewLine & "Staff Personal Details"
        Dim subHeader As String = String.Format(vbNewLine & vbNewLine & vbNewLine & "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
                                                "Prepared by " & vbNewLine &
                                                "Manager ID : " & HRstaffid.hrstaffid &
                                                "    Manager Name : " & HRstaffid.hrname & vbNewLine &
                                                "Manager from HR Department.", DateTime.Now)
        ' (3) Prepare body 
        Dim body As New StringBuilder()
        Dim gender As String
        If (radFemale.Checked = True) Then
            gender = "Female"
        ElseIf (radMale.Checked = True) Then
            gender = "Male"
        Else
            MessageBox.Show("Please select gender !", "error")
            Return
        End If
        body.AppendLine(vbNewLine)
        body.AppendLine(vbNewLine)
        body.AppendLine("----------------------------------------------------------------------------------------------------------------------------------")
        body.AppendLine(vbNewLine + "         Staff ID          : " & lblStaffID.Text)
        body.AppendLine(vbNewLine + "         Staff Name        : " & txtName.Text)
        body.AppendLine(vbNewLine + "         Department        : " & cboDepart.SelectedItem.ToString)
        body.AppendLine(vbNewLine + "         IC Number         : " & txtIC.Text)
        body.AppendLine(vbNewLine + "         Birthday          : " & DateDOB.Value.ToString("yyyy-MM-dd"))
        body.AppendLine(vbNewLine + "         Gender            : " & gender)
        body.AppendLine(vbNewLine + "         Phone Number      : " & txtPhone.Text)
        body.AppendLine(vbNewLine + "         Email             : " & txtEmail.Text)
        body.AppendLine(vbNewLine + "         Address           : " & txtAddress.Text)
        body.AppendLine(vbNewLine & "----------------------------------------------------------------------------------------------------------------------------------")
        body.AppendLine()

        ' (4) Print 
        With e.Graphics
            .DrawImage(My.Resources.hr2, 450, 20, 200, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 100, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
        End With
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        dlgPreview.Document = doc
        dlgPreview.ShowDialog(Me)
    End Sub


End Class