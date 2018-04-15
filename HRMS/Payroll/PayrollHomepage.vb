Public Class PayrollHomepage
    Private Sub btnCheckMdDdt_Click(sender As Object, e As EventArgs) Handles btnCheckMdDdt.Click
        MDIParent1.ShowForm(HRMandatoryDdt)
    End Sub

    Private Sub btnOvertime_Click(sender As Object, e As EventArgs) Handles btnOvertime.Click
        CalcOvertime.Calculate()
        MDIParent1.ShowForm(HROvertimeShow)
    End Sub

    Private Sub btnDeduction_Click(sender As Object, e As EventArgs) Handles btnDeduction.Click
        MDIParent1.ShowForm(HRDeductionShow)
    End Sub

    Private Sub btnPrepPayroll_Click(sender As Object, e As EventArgs) Handles btnPrepPayroll.Click
        CalcPayroll.Calculate()
        MDIParent1.ShowForm(HRNetpay)
    End Sub

    Private Sub PayrollHomepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLogin.Text = "[Login As : " & HRstaffid.hrname & "] ."
        MDIParent1.Text = "Human Resource Management System - Manager payroll report"
    End Sub
End Class