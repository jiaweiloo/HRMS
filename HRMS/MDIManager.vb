﻿Imports System.Windows.Forms

Public Class MDIManager
    Private m_ChildFormNumber As Integer

    Private Sub MDIManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AddNewHRToolStripMenuItem.Enabled = True
        Me.UpdateHRFetailsToolStripMenuItem.Enabled = True
        Me.DeleteHRToolStripMenuItem.Enabled = True
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm = ManagerMainPage
        ChildForm.MdiParent = Me
        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber
        'AA
        ChildForm.Show()

        Me.Text = "Human Resource Management System - "
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

    Private Sub TimeAndAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeAndAttendanceToolStripMenuItem.Click
        ShowForm(Attendance)
    End Sub

    Private Sub ViewTheLeaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTheLeaveToolStripMenuItem.Click
        ShowForm(ManagerViewLeave)
    End Sub

    Private Sub AddNewHRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewHRToolStripMenuItem.Click
        ShowForm(ManAddHR)
    End Sub

    Private Sub UpdateHRFetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateHRFetailsToolStripMenuItem.Click
        ShowForm(ManUpdateHR)
    End Sub

    Private Sub DeleteHRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteHRToolStripMenuItem.Click
        ShowForm(ManUpdateHR)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
