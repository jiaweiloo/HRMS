Public Class Form1

    Private Sub btnGoPayroll_Click(sender As Object, e As EventArgs) Handles btnGoPayroll.Click
        MDIParent1.ShowForm(EmpHistoryPayroll)
    End Sub

    Private Sub btnGoLeave_Click(sender As Object, e As EventArgs) Handles btnGoLeave.Click
        MDIParent1.ShowForm(Form2)
    End Sub
End Class
