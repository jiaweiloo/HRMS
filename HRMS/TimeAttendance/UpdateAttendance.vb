Public Class UpdateAttendance

    Private Sub BindData()
        Dim db As New HRMS_DBLinq2DataContext
        Dim rs = From a In db.attends
                 Where a.people_id.Chars(0) <> "m" And a.people_id <> HRstaffid.hrstaffid
                 Select a.attendance_id, a.people_id, a.current_date, a.time_in, a.lunch_in, a.lunch_out, a.time_out

        dgv.DataSource = rs
    End Sub
    Private Sub UpdateAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Private Sub dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 Then
            Dim id As String = CStr(dgv.Rows(i).Cells(0).Value)
            FrmUpdate.SelectedId = id
            FrmUpdate.ShowDialog(Me)
            BindData()
        End If
    End Sub
End Class