﻿Public Class NormalStaffPage
    Private Sub btnApplyLeave_Click(sender As Object, e As EventArgs) Handles btnApplyLeave.Click
        MDIStaff.ShowForm(Form1)
    End Sub

    Private Sub NormalStaffPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblstaffname.Text = HRstaffid.hrname
        lblstaffid.Text = HRstaffid.hrstaffid
        MDIStaff.Text = "Human Resource Management System (Employee) - Home Page"
    End Sub

    Private Sub NormalStaffPage_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        lblstaffname.Text = HRstaffid.hrname
        lblstaffid.Text = HRstaffid.hrstaffid
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        MDIStaff.ShowForm(StaffViewLeave)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MDIStaff.ShowForm(Attendance)
    End Sub
End Class