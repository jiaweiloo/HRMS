Imports System.Text

Public Class MgrReportForm
    Dim printedlist As New List(Of netpay)

    Private Sub ResetForm()
        cBoxMonth.SelectedIndex = 0
        cBoxYear.SelectedIndex = 0
    End Sub

    Private Sub BindData()
        Dim db As New HRMS_DBLinq2DataContext()
        If (cBoxMonth.SelectedItem.ToString().Equals("All")) Then
            If (cBoxYear.SelectedItem.ToString().Equals("All")) Then
                Dim rs = From c In db.netpays
                dgv.DataSource = rs
                lblCount.Text = rs.Count.ToString("0 record(s)")
                printedlist = rs.ToList
            Else
                Dim year As Integer = Integer.Parse(cBoxYear.SelectedItem.ToString)
                Dim rs = From c In db.netpays
                         Where c.generated_date.Value.Year.Equals(year)
                dgv.DataSource = rs
                lblCount.Text = rs.Count.ToString("0 record(s)")
                printedlist = rs.ToList
            End If
        ElseIf (cBoxYear.SelectedItem.ToString().Equals("All")) Then
            Dim month As Integer = Integer.Parse(cBoxMonth.SelectedItem.ToString)
            Dim rs = From c In db.netpays
                     Where c.generated_date.Value.Month.Equals(month)
            dgv.DataSource = rs
            lblCount.Text = rs.Count.ToString("0 record(s)")
            printedlist = rs.ToList
        Else
            Dim year As Integer = Integer.Parse(cBoxYear.SelectedItem.ToString)
            Dim month As Integer = Integer.Parse(cBoxMonth.SelectedItem.ToString)
            Dim rs = From c In db.netpays
                     Where c.generated_date.Value.Month.Equals(month) And c.generated_date.Value.Year.Equals(year)
            dgv.DataSource = rs
            lblCount.Text = rs.Count.ToString("0 record(s)")
            printedlist = rs.ToList
        End If
    End Sub

    Private Sub MgrReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
        BindData()
    End Sub

    Private Sub MgrReportForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ResetForm()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        BindData()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        dlgPreview.Document = doc
        Try
            dlgPreview.ShowDialog(Me)
        Catch ex As Exception
            dlgPreview.Close()
        End Try
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
        body.AppendLine("No  PayrollID     user id   Attd  Pay      Date          Mandatory Ddt      Extra deduction")
        body.AppendLine("--  ---------     -------   ----   -------  ------------  -------------      ----------------")
        Dim cnt As Integer = 0
        For Each item As netpay In printedlist
            cnt += 1
            'parts = CStr(item).Split(CChar(vbTab))
            body.AppendFormat("{0,3} {1,-8} {2,-8} {3,3} {4,3}{5,11} {6,10} {7,10} {8,26}",
                vbNewLine, cnt, item.payroll_id, item.people_id, item.total_attendance, item.final_pay, item.generated_date.Value.ToShortDateString, item.ttl_mandatory_ddt, item.ttl_deduction)
        Next
        'CStr(item.total_attendance.Value)
        body.AppendLine()
        body.AppendLine()
        body.AppendFormat("{0,2} record(s)", cnt)

        ' (4) Print 
        With e.Graphics
            .DrawImage(My.Resources.Mypayrollhistory1, 0, 0, 100, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 100, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
        End With
    End Sub
End Class