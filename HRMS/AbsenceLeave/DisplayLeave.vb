﻿Public Class DisplayLeave
    Private Sub BindData()

        Dim status As String = cboLeave.Text

        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs = From c In db.Leaves
                 Where (status = "All" Or c.status = status)
        dgvLeave.DataSource = rs

        lblCount.Text = rs.Count().ToString("0 record(s)")
    End Sub

    Private Sub LeaveDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboLeave.Text = "All"
        lblID.Text = HRstaffid.hrstaffid
        lblName.Text = HRstaffid.hrname
        BindData()
    End Sub

    Private Sub cboLeave_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLeave.SelectedIndexChanged
        BindData()
    End Sub

    Private Sub dgvLeave_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLeave.CellDoubleClick
        Dim i As Integer = e.RowIndex

        If i > -1 And CStr(dgvLeave.Rows(i).Cells(6).Value) = "Pending" Then
            Dim id As String = CStr(dgvLeave.Rows(i).Cells(0).Value)
            Dim peopleid As String = CStr(dgvLeave.Rows(i).Cells(5).Value)
            Update_Leave.peopleID = peopleid.ToString()
            Update_Leave.selected_id = id
            Update_Leave.ShowDialog(Me)
            BindData()
        End If
    End Sub

    Private Sub DisplayLeave_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        lblID.Text = HRstaffid.hrstaffid
        lblName.Text = HRstaffid.hrname
    End Sub
End Class