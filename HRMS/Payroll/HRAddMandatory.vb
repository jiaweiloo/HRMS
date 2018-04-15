Public Class HRAddMandatory
    Private Sub HRAddMandatory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblID.Text = MandatoryDeductionID.GetNextId()
        cBoxFormat.SelectedIndex = 0
        txtType.Focus()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            '1: Retrieve the value from the form
            Dim type As String = txtType.Text
            Dim value As Double
            Dim format As String = cBoxFormat.SelectedItem.ToString
            value = Double.Parse(txtValue.Text)
            Dim manDeduction As New mandatory_deduction()
            manDeduction.deduction_id = Integer.Parse(lblID.Text)
            manDeduction.deduction_type = type
            manDeduction.deduction_value = Convert.ToDecimal(value)
            manDeduction.deduction_format = format

            '2: Insert the Customer record using LINQ
            Dim db As New HRMS_DBLinq2DataContext()
            db.mandatory_deductions.InsertOnSubmit(manDeduction)
            'Submit the change to the database.
            Try
                db.SubmitChanges()
                MessageBox.Show("Success ", "Success")
                Me.Close()
                HRMandatoryDdt.refresh()
            Catch ex As Exception
                MessageBox.Show("Error : " & ex.Message, "error")
            End Try
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message, "error")
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtType.Text = ""
        txtValue.Text = ""
        cBoxFormat.SelectedIndex = 0
        txtType.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class