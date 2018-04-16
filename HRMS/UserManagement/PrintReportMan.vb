Imports System.Text

Public Class PrintReportMan
    Private Sub doc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles doc.PrintPage
        Dim join As String = cboDate.Value.ToString("dd/MM/yyyy")
        Dim db As New HRMS_DBLinq2DataContext()
        ' (1) Fonts 
        Dim fontHeader As New Font("Calibri", 24, FontStyle.Bold)
        Dim fontSubHeader As New Font("Calibri", 14, FontStyle.Bold)
        Dim fontBody As New Font("Consolas", 10, FontStyle.Bold)

        ' (2) Prepare header and sub-header 
        Dim header As String = vbNewLine & "Staff Personal Details"
        Dim subHeader As String = String.Format(vbNewLine & vbNewLine & vbNewLine & "Printed on {0:dd-MMMM-yyyy hh:mm:ss tt}" & vbNewLine &
                                                "Prepared by " & vbNewLine &
                                                "Manager ID : " & HRstaffid.hrstaffid &
                                                "    Manager Name : " & HRstaffid.hrname & vbNewLine &
                                                "Manager from HR Department.", DateTime.Now)
        ' (3) Prepare body 
        Dim body As New StringBuilder()
        body.AppendLine(vbNewLine)
        body.AppendLine(vbNewLine)
        body.AppendLine(vbNewLine)
        body.AppendLine(vbNewLine)
        body.AppendLine(" No      Staff ID |  Staff Name  | Department  | Joined Date  |  IC-Number    |   Gender  |  Phone")
        body.AppendLine(" ----------------------------------------------------------------------------------------------------------")
        Dim cnt As Integer = 0
        For Each item In db.Peoples
            If (item.joined_year.ToShortDateString = cboDate.Value.ToShortDateString) Then
                cnt += 1
                'parts = CStr(item).Split(CChar(vbTab))           
                body.AppendFormat("{0,2}       {1,6}      {2,6}       {3,6}    {4,6}     {5,6}     {6,6}   {7,6}" & vbNewLine, cnt, item.people_id, item.people_name, item.department_name, item.joined_year.ToShortDateString, item.people_ic, item.people_gender, item.people_phone)
            End If
        Next
        body.AppendLine()
        body.AppendFormat("{0,2} record(s)", cnt)

        ' (4) Print 
        With e.Graphics
            .DrawImage(My.Resources.hr2, 450, 20, 200, 100)
            .DrawString(header, fontHeader, Brushes.Purple, 100, 0)
            .DrawString(subHeader, fontSubHeader, Brushes.Black, 100, 40)
            .DrawString(body.ToString(), fontBody, Brushes.Black, 0, 120)
        End With
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If (cboDate.Value.ToShortDateString <= Date.Now.ToShortDateString) Then
            Dim db As New HRMS_DBLinq2DataContext()
            Dim checkrow As Integer = 0
            For Each item In db.Peoples
                If (item.joined_year.ToShortDateString = cboDate.Value.ToShortDateString) Then
                    checkrow += 1
                End If
            Next
            If checkrow > 1 Then
                dlgPreview.Document = doc
                dlgPreview.ShowDialog(Me)
            Else
                MessageBox.Show("No Record Found !", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Selected Date must earlier than the system current date !", "Invalid Selected Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MDIManager.ShowForm(ManagerMainPage)
    End Sub

    Private Sub PrintReportMan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHRname.Text = HRstaffid.hrname
        lblHRid.Text = HRstaffid.hrstaffid
        cboDate.MaxDate = DateTime.Now
        MDIManager.Text = "Human Resource Management System (Manager)- Print report employee details"
    End Sub

    Private Sub PrintReportMan_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        lblHRname.Text = HRstaffid.hrname
        lblHRid.Text = HRstaffid.hrstaffid
        cboDate.MaxDate = DateTime.Now
    End Sub
End Class