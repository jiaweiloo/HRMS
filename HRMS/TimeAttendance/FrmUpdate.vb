Public Class FrmUpdate
    Public SelectedId As String
    Public Sub ResetForm()
        lblid.Text = ""
        lbldate.Text = ""
        txtlunchin.Text = ""
        txtlunchout.Text = ""
        txtTimein.Text = ""
        txtTimeout.Text = ""
        txtTimein.Focus()
    End Sub

    Private Sub FrmUpdate_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ResetForm()

        Dim db As New HRMS_DBLinq2DataContext()
        Dim a As attend = db.attends.FirstOrDefault(Function(o) o.attendance_id = SelectedId)

        If a Is Nothing Then
            MessageBox.Show("Attendance not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        'Customer found --> Display details
        lblid.Text = a.attendance_id
        lbldate.Text = a.current_date.ToString
        txtTimein.Text = a.time_in.ToString
        txtTimeout.Text = a.time_out.ToString
        txtlunchin.Text = a.lunch_in.ToString
        txtlunchout.Text = a.lunch_out.ToString


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Me.ValidateChildren() = False Then
            Return
        End If

        Dim db As New HRMS_DBLinq2DataContext()
        Dim a As attend = db.attends.FirstOrDefault(Function(o) o.attendance_id = SelectedId)

        If a Is Nothing Then
            MessageBox.Show("Attendance not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.Close()
            Return

        End If

        '1: Set the Customer object's properties accordingly
        Dim cust As New attend


        a.attendance_id = lblid.Text
        Try
            If txtTimein.Text <> "" Then
                a.time_in = Date.ParseExact(txtTimein.Text, "HH:mm:ss",
                System.Globalization.DateTimeFormatInfo.InvariantInfo).TimeOfDay
            End If

            If txtTimeout.Text <> "" Then
                a.time_out = Date.ParseExact(txtTimeout.Text, "HH:mm:ss",
                System.Globalization.DateTimeFormatInfo.InvariantInfo).TimeOfDay
            End If
            If txtlunchin.Text <> "" Then
                a.lunch_in = Date.ParseExact(txtlunchin.Text, "HH:mm:ss",
                System.Globalization.DateTimeFormatInfo.InvariantInfo).TimeOfDay
            End If

            If txtlunchout.Text <> "" Then

                a.lunch_out = Date.ParseExact(txtlunchout.Text, "HH:mm:ss",
                    System.Globalization.DateTimeFormatInfo.InvariantInfo).TimeOfDay
            End If


            MessageBox.Show("Attendance [" & a.attendance_id & "] updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Make sure time is in corrent format hh:mm:ss in 24 hour format", "Format Incorrent", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


        '2: Update the Customer record using LINQ
        db.SubmitChanges()


    End Sub
End Class