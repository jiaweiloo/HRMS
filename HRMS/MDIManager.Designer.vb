<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIManager
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
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewHRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateHRFetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeAndAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewLeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTheLeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.AccountManagementToolStripMenuItem, Me.TimeAndAttendanceToolStripMenuItem, Me.ViewLeaveToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(948, 33)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripSeparator3, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(50, 29)
        Me.FileMenu.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(211, 30)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(208, 6)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(208, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(211, 30)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'AccountManagementToolStripMenuItem
        '
        Me.AccountManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewHRToolStripMenuItem, Me.UpdateHRFetailsToolStripMenuItem, Me.ReportStaffToolStripMenuItem})
        Me.AccountManagementToolStripMenuItem.Name = "AccountManagementToolStripMenuItem"
        Me.AccountManagementToolStripMenuItem.Size = New System.Drawing.Size(199, 29)
        Me.AccountManagementToolStripMenuItem.Text = "Account Management"
        '
        'AddNewHRToolStripMenuItem
        '
        Me.AddNewHRToolStripMenuItem.Name = "AddNewHRToolStripMenuItem"
        Me.AddNewHRToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddNewHRToolStripMenuItem.Size = New System.Drawing.Size(298, 30)
        Me.AddNewHRToolStripMenuItem.Text = "Add New HR"
        '
        'UpdateHRFetailsToolStripMenuItem
        '
        Me.UpdateHRFetailsToolStripMenuItem.Name = "UpdateHRFetailsToolStripMenuItem"
        Me.UpdateHRFetailsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.UpdateHRFetailsToolStripMenuItem.Size = New System.Drawing.Size(298, 30)
        Me.UpdateHRFetailsToolStripMenuItem.Text = "HR Management"
        '
        'ReportStaffToolStripMenuItem
        '
        Me.ReportStaffToolStripMenuItem.Name = "ReportStaffToolStripMenuItem"
        Me.ReportStaffToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReportStaffToolStripMenuItem.Size = New System.Drawing.Size(298, 30)
        Me.ReportStaffToolStripMenuItem.Text = "Report (Staff)"
        '
        'TimeAndAttendanceToolStripMenuItem
        '
        Me.TimeAndAttendanceToolStripMenuItem.Name = "TimeAndAttendanceToolStripMenuItem"
        Me.TimeAndAttendanceToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TimeAndAttendanceToolStripMenuItem.Size = New System.Drawing.Size(192, 29)
        Me.TimeAndAttendanceToolStripMenuItem.Text = "Time and Attendance"
        '
        'ViewLeaveToolStripMenuItem
        '
        Me.ViewLeaveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewTheLeaveToolStripMenuItem})
        Me.ViewLeaveToolStripMenuItem.Name = "ViewLeaveToolStripMenuItem"
        Me.ViewLeaveToolStripMenuItem.Size = New System.Drawing.Size(110, 29)
        Me.ViewLeaveToolStripMenuItem.Text = "&View Leave"
        '
        'ViewTheLeaveToolStripMenuItem
        '
        Me.ViewTheLeaveToolStripMenuItem.Name = "ViewTheLeaveToolStripMenuItem"
        Me.ViewTheLeaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ViewTheLeaveToolStripMenuItem.Size = New System.Drawing.Size(272, 30)
        Me.ViewTheLeaveToolStripMenuItem.Text = "View the Leave"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(89, 29)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'MDIManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 698)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MDIManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDIManager"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents AccountManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateHRFetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewHRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeAndAttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewLeaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewTheLeaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportStaffToolStripMenuItem As ToolStripMenuItem
End Class
