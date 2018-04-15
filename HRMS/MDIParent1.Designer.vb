<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomepagetoolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateStaffDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbsenceLeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateLeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomepageToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckDeductionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckMandatoryDeductionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckOvertimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckNetpayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.UserManagementToolStripMenuItem, Me.AbsenceLeaveToolStripMenuItem, Me.PayrollToolStripMenuItem, Me.TimeAttendanceToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(948, 33)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomepagetoolStripMenuItem, Me.ToolStripSeparator4, Me.LogoutToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(50, 29)
        Me.FileMenu.Text = "&File"
        '
        'HomepagetoolStripMenuItem
        '
        Me.HomepagetoolStripMenuItem.Name = "HomepagetoolStripMenuItem"
        Me.HomepagetoolStripMenuItem.Size = New System.Drawing.Size(186, 30)
        Me.HomepagetoolStripMenuItem.Text = "&Homepage"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(183, 6)
        '
        'LogoutToolStripMenuItem1
        '
        Me.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        Me.LogoutToolStripMenuItem1.Size = New System.Drawing.Size(186, 30)
        Me.LogoutToolStripMenuItem1.Text = "&Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(186, 30)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewStaffToolStripMenuItem, Me.UpdateStaffDetailsToolStripMenuItem})
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(169, 29)
        Me.UserManagementToolStripMenuItem.Text = "User Management"
        '
        'AddNewStaffToolStripMenuItem
        '
        Me.AddNewStaffToolStripMenuItem.Name = "AddNewStaffToolStripMenuItem"
        Me.AddNewStaffToolStripMenuItem.Size = New System.Drawing.Size(255, 30)
        Me.AddNewStaffToolStripMenuItem.Text = "Add New Staff"
        '
        'UpdateStaffDetailsToolStripMenuItem
        '
        Me.UpdateStaffDetailsToolStripMenuItem.Name = "UpdateStaffDetailsToolStripMenuItem"
        Me.UpdateStaffDetailsToolStripMenuItem.Size = New System.Drawing.Size(244, 30)
        Me.UpdateStaffDetailsToolStripMenuItem.Text = "Staff Management"
        '
        'AbsenceLeaveToolStripMenuItem
        '
        Me.AbsenceLeaveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateLeaveToolStripMenuItem})
        Me.AbsenceLeaveToolStripMenuItem.Name = "AbsenceLeaveToolStripMenuItem"
        Me.AbsenceLeaveToolStripMenuItem.Size = New System.Drawing.Size(145, 29)
        Me.AbsenceLeaveToolStripMenuItem.Text = "Absence & Leave"
        '
        'UpdateLeaveToolStripMenuItem
        '
        Me.UpdateLeaveToolStripMenuItem.Name = "UpdateLeaveToolStripMenuItem"
        Me.UpdateLeaveToolStripMenuItem.Size = New System.Drawing.Size(204, 30)
        Me.UpdateLeaveToolStripMenuItem.Text = "&Update Leave"
        '
        'PayrollToolStripMenuItem
        '
        Me.PayrollToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomepageToolStripMenuItem1, Me.CheckDeductionToolStripMenuItem, Me.CheckMandatoryDeductionToolStripMenuItem, Me.CheckOvertimeToolStripMenuItem, Me.CheckNetpayToolStripMenuItem})
        Me.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        Me.PayrollToolStripMenuItem.Size = New System.Drawing.Size(77, 29)
        Me.PayrollToolStripMenuItem.Text = "Payroll"
        '
        'HomepageToolStripMenuItem1
        '
        Me.HomepageToolStripMenuItem1.Name = "HomepageToolStripMenuItem1"
        Me.HomepageToolStripMenuItem1.Size = New System.Drawing.Size(275, 30)
        Me.HomepageToolStripMenuItem1.Text = "Homepage"
        '
        'CheckDeductionToolStripMenuItem
        '
        Me.CheckDeductionToolStripMenuItem.Name = "CheckDeductionToolStripMenuItem"
        Me.CheckDeductionToolStripMenuItem.Size = New System.Drawing.Size(275, 30)
        Me.CheckDeductionToolStripMenuItem.Text = "Check &Deduction"
        '
        'CheckMandatoryDeductionToolStripMenuItem
        '
        Me.CheckMandatoryDeductionToolStripMenuItem.Name = "CheckMandatoryDeductionToolStripMenuItem"
        Me.CheckMandatoryDeductionToolStripMenuItem.Size = New System.Drawing.Size(275, 30)
        Me.CheckMandatoryDeductionToolStripMenuItem.Text = "Check &Mandatory De..."
        '
        'CheckOvertimeToolStripMenuItem
        '
        Me.CheckOvertimeToolStripMenuItem.Name = "CheckOvertimeToolStripMenuItem"
        Me.CheckOvertimeToolStripMenuItem.Size = New System.Drawing.Size(275, 30)
        Me.CheckOvertimeToolStripMenuItem.Text = "Check &Overtime"
        '
        'CheckNetpayToolStripMenuItem
        '
        Me.CheckNetpayToolStripMenuItem.Name = "CheckNetpayToolStripMenuItem"
        Me.CheckNetpayToolStripMenuItem.Size = New System.Drawing.Size(275, 30)
        Me.CheckNetpayToolStripMenuItem.Text = "Check &Netpay"
        '
        'TimeAttendanceToolStripMenuItem
        '
        Me.TimeAttendanceToolStripMenuItem.Name = "TimeAttendanceToolStripMenuItem"
        Me.TimeAttendanceToolStripMenuItem.Size = New System.Drawing.Size(162, 29)
        Me.TimeAttendanceToolStripMenuItem.Text = "Time & Attendance"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 698)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MDIParent1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDIParent"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HomepagetoolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents UserManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbsenceLeaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayrollToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeAttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewStaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateStaffDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateLeaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HomepageToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CheckDeductionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckMandatoryDeductionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckOvertimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckNetpayToolStripMenuItem As ToolStripMenuItem
End Class
