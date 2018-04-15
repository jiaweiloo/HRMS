Imports System.Windows.Forms

Public Class MDIParent1
    Private m_ChildFormNumber As Integer

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MDIParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AddNewStaffToolStripMenuItem.Enabled = True
        Me.UpdateStaffDetailsToolStripMenuItem.Enabled = True

        Me.Text = "Human Resource Management System - "
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm = HRHomepage
        ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber
        'AA
        ChildForm.Show()
    End Sub


    Public Sub ShowForm(ChildForm As System.Windows.Forms.Form)
        For Each OldChildForm As Form In Me.MdiChildren
            If (ChildForm IsNot OldChildForm) Then
                OldChildForm.Close()
            End If

        Next
        m_ChildFormNumber += 1
        ChildForm.MdiParent = Me
        ChildForm.Dock = DockStyle.Fill
        ChildForm.Show()
    End Sub

    Private Sub UserManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserManagementToolStripMenuItem.Click

    End Sub

    Private Sub AddNewStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewStaffToolStripMenuItem.Click
        Me.ShowForm(AddNewStaff)
    End Sub

    Private Sub UpdateStaffDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStaffDetailsToolStripMenuItem.Click
        Me.ShowForm(UpdateStaffDetail)
    End Sub

    Private Sub RetrieveStaffDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DeleteStaffDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UpdateLeaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateLeaveToolStripMenuItem.Click
        Me.ShowForm(DisplayLeave)
    End Sub

    Private Sub TimeAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeAttendanceToolStripMenuItem.Click
        ShowForm(Attendance)
    End Sub

    Private Sub HomepagetoolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomepagetoolStripMenuItem.Click
        Me.ShowForm(HRHomepage)
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub pay_HomepageToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HomepageToolStripMenuItem1.Click
        ShowForm(PayrollHomepage)
    End Sub

    Private Sub CheckDeductionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckDeductionToolStripMenuItem.Click
        Me.ShowForm(HRDeductionShow)
    End Sub

    Private Sub CheckMandatoryDeductionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckMandatoryDeductionToolStripMenuItem.Click
        Me.ShowForm(HRMandatoryDdt)
    End Sub

    Private Sub CheckOvertimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckOvertimeToolStripMenuItem.Click
        CalcOvertime.Calculate()
        Me.ShowForm(HROvertimeShow)
    End Sub

    Private Sub CheckNetpayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckNetpayToolStripMenuItem.Click
        CalcPayroll.Calculate()
        Me.ShowForm(HRNetpay)
    End Sub
End Class
