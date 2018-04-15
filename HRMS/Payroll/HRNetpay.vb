Public Class HRNetpay
    Private Sub BindData()
        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs = From c In db.netpays
        dgv.DataSource = rs
        lblCount.Text = rs.Count.ToString("0 record(s)")
    End Sub

    Private Sub HRNetpay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
        MDIParent1.Text = MDIParent1.Text & "HR Show Netpay"
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim type As String = DateTimePicker1.Text

        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs = From c In db.netpays
                 Where c.generated_date.Equals(Date.Parse(type))

        dgv.DataSource = rs

        lblCount.Text = rs.Count.ToString("0 record(s)")
    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgv.Rows(i).Cells(0).Value)
            HRNetpayUpDel.SelectedId = Integer.Parse(id)
            HRNetpayUpDel.ShowDialog(Me)
            BindData()
        End If
    End Sub
End Class