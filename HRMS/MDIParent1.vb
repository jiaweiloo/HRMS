Imports System.Windows.Forms

Public Class MDIParent1
    Private m_ChildFormNumber As Integer
    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub MDIParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub PayrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayrollToolStripMenuItem.Click
        ShowForm(EmpHistoryPayroll)
    End Sub

    Private Sub AddNewStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewStaffToolStripMenuItem.Click
        Me.ShowForm(AddNewStaff)
    End Sub

    Private Sub UpdateStaffDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateStaffDetailsToolStripMenuItem.Click
        Me.ShowForm(UpdateStaffDetail)
    End Sub

    Private Sub RetrieveStaffDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetrieveStaffDetailsToolStripMenuItem.Click

    End Sub

    Private Sub DeleteStaffDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteStaffDetailsToolStripMenuItem.Click

    End Sub

    Private Sub UpdateLeaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateLeaveToolStripMenuItem.Click
        ShowForm(DisplayLeave)
    End Sub
End Class
