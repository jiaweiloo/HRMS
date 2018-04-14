﻿Public Class HRMandatoryDdt
    Private Sub BindData()
        Dim type As String = txtType.Text

        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs = From c In db.mandatory_deductions
                 Where c.deduction_type.Contains(type)

        dgv.DataSource = rs

        lblCount.Text = rs.Count.ToString("0 record(s)")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblShow.Text = DeductionID.GetNextId()
    End Sub
End Class