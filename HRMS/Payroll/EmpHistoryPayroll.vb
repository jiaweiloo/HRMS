Imports System.Text

Public Class EmpHistoryPayroll
    Private Sub BindData()

        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs = From c In db.netpays
                 Where c.people_id = HRstaffid.hrstaffid

        dgv.DataSource = rs

        lblCount.Text = rs.Count.ToString("0 record(s)")
    End Sub

    Private Sub EmpHistoryPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MDIParent1.AddNewStaffToolStripMenuItem.Enabled = True
        MDIParent1.UpdateStaffDetailsToolStripMenuItem.Enabled = True
        MDIParent1.RetrieveStaffDetailsToolStripMenuItem.Enabled = True
        MDIParent1.DeleteStaffDetailsToolStripMenuItem.Enabled = True

        BindData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        BindData()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        dlgPreview.Document = doc
        dlgPreview.ShowDialog(Me)
        'dlgPreview.Size.Height = 100
    End Sub

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        ' (1) Fonts 
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        ' (2) Prepare header and sub-header 
        Dim header As String = "Payroll history Listing"
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
                                                "Prepared for " & HRstaffid.hrstaffid, DateTime.Now)

        ' (3) Prepare body 
        Dim body As New StringBuilder()
        body.AppendLine("No  PayrollID     Attd     Pay      Date          Mandatory Ddt      Extra deduction")
        body.AppendLine("--  ---------     ----     -------  ------------  -------------      ----------------")
        Dim cnt As Integer = 0
        Dim parts() As String

        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs = (From c In db.netpays
                  Where c.people_id = HRstaffid.hrstaffid).ToList
        For Each item As netpay In rs
            cnt += 1
            'parts = CStr(item).Split(CChar(vbTab))
            body.AppendFormat("{0,3} {1,-8} {2,-8} {3,3} {4,11} {5,10} {6,10} {7,28}",
                vbNewLine, cnt, item.payroll_id, item.total_attendance, item.final_pay, item.generated_date.Value.ToShortDateString, item.ttl_mandatory_ddt, item.ttl_deduction)
        Next
        'CStr(item.total_attendance.Value)
        body.AppendLine()
        body.AppendLine()
        body.AppendFormat("{0,2} record(s)", cnt)

        ' (4) Print 
        With e.Graphics
            .DrawImage(My.Resources.MyPayrollHistory, 0, 0, 400, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 400, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 400, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
        End With
    End Sub
End Class