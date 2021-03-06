﻿Public Class HRMandatoryDdt
    Private Sub BindData()
        Dim type As String = txtType.Text

        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs = From c In db.mandatory_deductions
                 Where c.deduction_type.Contains(type)

        dgv.DataSource = rs

        lblCount.Text = rs.Count.ToString("0 record(s)")
    End Sub

    Private Sub HRMandatoryDdt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
        MDIParent1.Text = "Human Resource Management System - HR Show Mandatory Deduction"
    End Sub

    Private Sub txtType_TextChanged(sender As Object, e As EventArgs) Handles txtType.TextChanged
        BindData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        HRAddMandatory.Show()
    End Sub

    Public Sub refresh()
        BindData()
    End Sub
End Class