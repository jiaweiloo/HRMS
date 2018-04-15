Public Class HRDeductionShow

    Private Sub BindData()
        Dim type As String = txtType.Text

        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs1 = From c In db.deductions
                  Where c.deduction_type.Contains(type)

        dgv.DataSource = rs1

        lblCount.Text = rs1.Count.ToString("0 record(s)")
    End Sub

    Private Sub HRDeductionShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Public Sub refresh()
        BindData()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        HRDeductionAdd.ShowDialog()
    End Sub

    Private Sub txtType_TextChanged(sender As Object, e As EventArgs) Handles txtType.TextChanged
        BindData()
    End Sub


End Class