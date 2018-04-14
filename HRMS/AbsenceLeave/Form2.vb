Public Class Form2
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        LeaveDisplay.ShowDialog()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim peopleid As String
        Dim leaveid As String
        Dim apply_date As Date
        Dim leave_date As Date
        Dim duration As Integer
        Dim reason As String
        Dim status As String
        Dim attempt As Integer
        Try
            Dim err As New StringBuilder()
            Dim ctr As Control = Nothing
            If txtReason.Text = "" Then
                err.AppendLine("-Reason empty")
                ctr = If(ctr, txtReason)
            End If
            If cboDuration.SelectedIndex < 0 Then
                err.AppendLine("-No duration selected")
                ctr = If(ctr, cboDuration)
            End If
            If err.Length > 0 Then
                MessageBox.Show(err.ToString(), "Input error")
                ctr.Focus()
                Return
            End If
            peopleid = "haha"
            leaveid = lbl_Leave_ID.Text
            apply_date = CDate(Today.ToShortDateString)
            leave_date = CDate(chooseDate.SelectionRange.Start.ToShortDateString())
            duration = Integer.Parse(cboDuration.Text)
            reason = txtReason.Text
            status = "Pending"





        Catch ex As Exception
            'MessageBox.Show("Invalid Input", "Error")


            txtReason.Select()
        End Try

        Dim leave As New Leave
        leave.leave_id = leaveid
        leave.people_id = peopleid
        leave.apply_date = apply_date
        leave.leave_date = leave_date
        leave.reason = reason
        leave.status = status
        leave.leave_duration = duration
        leave.leave_attempt = leave.leave_attempt - 1

        Dim db As New DataClasses1DataContext
        db.Leaves.InsertOnSubmit(leave)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
        MessageBox.Show("Leave " & leaveid & " submitted", "Submit")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Leave_ID.Text = NextLeaveID.GetNextId()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        lbl_Leave_ID.Text = NextLeaveID.GetNextId()
    End Sub

    Private Sub txtReason_TextChanged(sender As Object, e As EventArgs) Handles txtReason.TextChanged
        Dim reason As String = txtReason.Text
        If reason = "" Then
            err.SetError(txtReason, "Please Give Reason")
        Else
            err.SetError(txtReason, Nothing)
        End If
    End Sub

    Private Sub cboDuration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDuration.SelectedIndexChanged
        Dim duration As String = cboDuration.SelectedIndex.ToString()
        Dim duration2 As Integer = Integer.Parse(duration)
        If duration = "" Then
            err.SetError(cboDuration, "Please Select Duration")
        Else
            err.SetError(cboDuration, Nothing)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Update_Leave.ShowDialog()
    End Sub
End Class