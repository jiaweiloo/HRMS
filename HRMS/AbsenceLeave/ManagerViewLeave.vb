Imports System.Text

Public Class ManagerViewLeave
    Private Sub BindData()

        Dim status As String = cboStatus.Text

        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs = From c In db.Leaves
                 Where (status = "All" Or c.status = status)
        dgvLeave.DataSource = rs

        lblCount.Text = rs.Count().ToString("0 record(s)")
        lblCount.ForeColor = Color.Red
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        BindData()
    End Sub

    Private Sub ManagerViewLeave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboStatus.Text = "All"
        lblID.Text = HRstaffid.hrstaffid
        lblName.Text = HRstaffid.hrname
        lblID.BackColor = Color.AliceBlue
        lblName.BackColor = Color.AliceBlue
        Dim style As FontStyle
        style = FontStyle.Bold
        Dim timesNewRoman As Font = New Font("Times New Roman", 12, style)
        Dim fore As Color = Color.GreenYellow
        lblID.ForeColor = fore
        lblName.ForeColor = fore
        Label1.ForeColor = fore
        Label3.ForeColor = fore
        lblID.Font = timesNewRoman
        lblName.Font = timesNewRoman
        Label1.Font = timesNewRoman
        Label3.Font = timesNewRoman

        BindData()
        MDIManager.AddNewHRToolStripMenuItem.Enabled = True
        MDIManager.UpdateHRFetailsToolStripMenuItem.Enabled = True
        MDIManager.DeleteHRToolStripMenuItem.Enabled = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        MessageBox.Show("Programmed By JJ", "About")
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        dlgPreview.Document = doc
        dlgPreview.ShowDialog(Me)
    End Sub

    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Dim db As New HRMS_DBLinq2DataContext()
        ' (1) Fonts 
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 12)
        Dim fontBody As New Font("Consolas", 10)

        ' (2) Prepare header and sub-header 
        Dim header As String = "Leave Listing"
        Dim subHeader As String = String.Format("Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
                                                "Prepared by JUNKIT", DateTime.Now)

        ' (3) Prepare body 
        Dim body As New StringBuilder()
        body.AppendLine("Leave ID     Staff ID     Leave Date    Apply Date   Duration    Status")
        body.AppendLine("----------   --------     -----------   ----------   ---------   -------")
        Dim cnt As Integer = 0


        For Each item In db.Leaves
            cnt += 1
            body.AppendFormat("{0,10} {1,10} {2,13} {3,12} {4,10} {5,13}" & vbNewLine, item.leave_id, item.people_id, item.leave_date.ToShortTimeString, item.apply_date.ToShortTimeString, item.leave_duration, item.status)
        Next
        body.AppendLine()
        body.AppendFormat("{0,2} record(s)", cnt)

        ' (4) Print 
        With e.Graphics
            .DrawImage(My.Resources.left, 0, 0, 80, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 100, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
        End With

    End Sub
End Class