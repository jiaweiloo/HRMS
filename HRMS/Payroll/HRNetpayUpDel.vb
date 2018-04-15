Public Class HRNetpayUpDel
    Public SelectedId As Integer
    Private Sub HRNetpayUpDel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim db As New HRMS_DBLinq2DataContext()
        Dim c As netpay = db.netpays.FirstOrDefault(Function(o) o.payroll_id = SelectedId)

        If c Is Nothing Then
            MessageBox.Show("Netpay not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        Try
            c.total_attendance = Integer.Parse(lblAttendance.Text)
            c.total_absence = Integer.Parse(txtAbsence.Text)
            c.final_pay = Decimal.Parse(txtFinalPay.Text)
            c.ttl_mandatory_ddt = Decimal.Parse(txtManDdt.Text)
            c.ttl_deduction = Decimal.Parse(txtExtraDdt.Text)

            '2: Update the Netpay record using LINQ
            db.SubmitChanges()

            '3: Show a message box to indicate updating done
            MessageBox.Show("Payroll [" & c.payroll_id & "] updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Fail :" & ex.Message, "Done", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub HRNetpayUpDel_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs As netpay = db.netpays.FirstOrDefault(Function(o) o.payroll_id = SelectedId)

        If rs Is Nothing Then
            MessageBox.Show("Netpay not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        lblPayrollID.Text = SelectedId.ToString("0")
        lblPplID.Text = rs.people_id
        lblAttendance.Text = CStr(rs.total_attendance)
        txtAbsence.Text = CStr(rs.total_absence)
        txtFinalPay.Text = CStr(rs.final_pay)
        lblGenerateDate.Text = CStr(rs.generated_date)
        txtManDdt.Text = CStr(rs.ttl_mandatory_ddt)
        txtExtraDdt.Text = CStr(rs.ttl_deduction)
    End Sub

    Private Sub txtAbsence_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAbsence.Validating
        Dim value As String = txtAbsence.Text
        If String.IsNullOrEmpty(value) Then
            err.SetError(txtAbsence, "Absence should not left blank")
            e.Cancel = True
        ElseIf (IsNumeric(value) = False) Then
            err.SetError(txtAbsence, "Absence should be made of numeric")
            e.Cancel = True
        Else
            err.SetError(txtAbsence, Nothing)
        End If
    End Sub

    Private Sub txtFinalPay_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFinalPay.Validating
        Dim value As String = txtFinalPay.Text
        If String.IsNullOrEmpty(value) Then
            err.SetError(txtFinalPay, "Final Pay should not left blank")
            e.Cancel = True
        ElseIf (IsNumeric(value) = False) Then
            err.SetError(txtFinalPay, "Final Pay should be made of numeric")
            e.Cancel = True
        Else
            err.SetError(txtFinalPay, Nothing)
        End If
    End Sub

    Private Sub txtExtraDdt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtExtraDdt.Validating
        Dim value As String = txtExtraDdt.Text
        If String.IsNullOrEmpty(value) Then
            err.SetError(txtExtraDdt, "Extra deduction should not left blank")
            e.Cancel = True
        ElseIf (IsNumeric(value) = False) Then
            err.SetError(txtExtraDdt, "Extra deduction be made of numeric")
            e.Cancel = True
        Else
            err.SetError(txtExtraDdt, Nothing)
        End If
    End Sub

    Private Sub txtManDdt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtManDdt.Validating
        Dim value As String = txtManDdt.Text
        If String.IsNullOrEmpty(value) Then
            err.SetError(txtManDdt, "Mandatory Deduction should not left blank")
            e.Cancel = True
        ElseIf (IsNumeric(value) = False) Then
            err.SetError(txtManDdt, "Mandatory Deduction should be made of numeric")
            e.Cancel = True
        Else
            err.SetError(txtManDdt, Nothing)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim db As New HRMS_DBLinq2DataContext()
        Dim np As netpay = db.netpays.FirstOrDefault(Function(o) o.payroll_id = SelectedId)

        If np Is Nothing Then
            MessageBox.Show("Netpay not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        '1 : Delete the customer record using LINQ
        db.netpays.DeleteOnSubmit(np)
        db.SubmitChanges()
        '2: Show a message box to indicate deletion done
        MessageBox.Show("Netpay [" & np.payroll_id & "] deleted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class