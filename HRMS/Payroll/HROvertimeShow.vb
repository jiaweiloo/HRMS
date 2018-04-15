Public Class HROvertimeShow

    Private Sub BindData()

        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs = From c In db.overtimes

        dgv.DataSource = rs

        lblCount.Text = rs.Count.ToString("0 record(s)")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim type As String = DateTimePicker1.Text

        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs = From c In db.overtimes
                 Where c.overtime_date.Equals(Date.Parse(type))

        dgv.DataSource = rs

        lblCount.Text = rs.Count.ToString("0 record(s)")
    End Sub

    Private Sub HROvertimeShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
        MDIParent1.Text = MDIParent1.Text & "HR Show Overtime"
    End Sub
End Class