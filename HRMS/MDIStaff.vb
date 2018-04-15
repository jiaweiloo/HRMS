﻿Imports System.Windows.Forms

Public Class MDIStaff
    Private m_ChildFormNumber As Integer

    Private Sub MDIStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm = NormalStaffPage
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

    Private Sub TimeAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeAttendanceToolStripMenuItem.Click
        ShowForm(Attendance)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
