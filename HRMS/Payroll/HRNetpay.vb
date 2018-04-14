Public Class HRNetpay
    Private Sub BindData()
        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs = From c In db.netpays
        dgv.DataSource = rs
        lblCount.Text = rs.Count.ToString("0 record(s)")
    End Sub

    Private Sub HRNetpay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim type As String = DateTimePicker1.Text

        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs = From c In db.netpays
                 Where c.generated_date.Equals(Date.Parse(type))

        dgv.DataSource = rs

        lblCount.Text = rs.Count.ToString("0 record(s)")
    End Sub
End Class