Public Class HRDeductionAdd
    Private Sub HRDeductionAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New HRMS_DBLinq2DataContext()
        Dim peopleRS = (From d In db.Peoples).ToList

        For Each ppl As People In peopleRS
            cBoxPplID.Items.Add(ppl.people_id)
        Next
        lblID.Text = DeductionID.GetNextId
        ResetForm()
    End Sub

    Private Sub ResetForm()
        txtType.Text = ""
        txtValue.Text = ""
        cBoxFormat.SelectedIndex = 0
        lblDate.Text = DateTime.Now.ToShortDateString
        cBoxPplID.SelectedIndex = -1
        err.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        Try
            Dim type As String = txtType.Text
            Dim value As String = txtValue.Text
            Dim format As String = cBoxFormat.SelectedItem.ToString
            Dim date1 As Date = DateTime.Now
            Dim pplID As String = cBoxPplID.SelectedItem.ToString

            Dim ded As New deduction
            ded.deduction_id = Integer.Parse(lblID.Text)
            ded.deduction_type = type
            ded.deduction_value = Double.Parse(value)
            ded.deduction_format = format
            ded.deduction_date = date1
            ded.people_id = pplID

            Dim db As New HRMS_DBLinq2DataContext()
            db.deductions.InsertOnSubmit(ded)
            db.SubmitChanges()
            MessageBox.Show("Deduction added to " & pplID, "Success")
            HRDeductionShow.refresh()
            ResetForm()
        Catch ex As Exception
            MessageBox.Show("Deduction failed :" & ex.Message, "Fail")
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtType_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtType.Validating
        Dim type As String = txtType.Text
        If String.IsNullOrEmpty(type) Then
            err.SetError(txtType, "Type should not left blank")
            e.Cancel = True
        Else
            err.SetError(txtType, Nothing)
        End If
    End Sub

    Private Sub txtValue_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtValue.Validating
        Dim value As String = txtValue.Text
        If String.IsNullOrEmpty(value) Then
            err.SetError(txtValue, "Value should not left blank")
            e.Cancel = True
        ElseIf (IsNumeric(value) = False) Then
            err.SetError(txtValue, "Value should be made of numeric")
            e.Cancel = True
        Else
            err.SetError(txtValue, Nothing)
        End If
    End Sub

    Private Sub cBoxPplID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cBoxPplID.Validating
        Dim selected As Integer = cBoxPplID.SelectedIndex
        If (selected < 0) Then
            err.SetError(cBoxPplID, "Please select a people to applied.")
            e.Cancel = True
        Else
            err.SetError(cBoxPplID, Nothing)
        End If
    End Sub
End Class