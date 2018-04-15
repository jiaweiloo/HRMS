<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRHomepage
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
        Me.btnGoLeave = New System.Windows.Forms.Button()
        Me.btnGoPayroll = New System.Windows.Forms.Button()
        Me.btnAttend = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGoLeave
        '
        Me.btnGoLeave.AutoSize = True
        Me.btnGoLeave.BackColor = System.Drawing.Color.SpringGreen
        Me.btnGoLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoLeave.Location = New System.Drawing.Point(0, 283)
        Me.btnGoLeave.Name = "btnGoLeave"
        Me.btnGoLeave.Size = New System.Drawing.Size(487, 264)
        Me.btnGoLeave.TabIndex = 0
        Me.btnGoLeave.Text = "Go To Leave"
        Me.btnGoLeave.UseVisualStyleBackColor = False
        '
        'btnGoPayroll
        '
        Me.btnGoPayroll.AutoSize = True
        Me.btnGoPayroll.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnGoPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoPayroll.Location = New System.Drawing.Point(493, 283)
        Me.btnGoPayroll.Name = "btnGoPayroll"
        Me.btnGoPayroll.Size = New System.Drawing.Size(449, 264)
        Me.btnGoPayroll.TabIndex = 1
        Me.btnGoPayroll.Text = "Go To Payroll"
        Me.btnGoPayroll.UseVisualStyleBackColor = False
        '
        'btnAttend
        '
        Me.btnAttend.AutoSize = True
        Me.btnAttend.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAttend.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttend.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAttend.Location = New System.Drawing.Point(0, 2)
        Me.btnAttend.Name = "btnAttend"
        Me.btnAttend.Size = New System.Drawing.Size(487, 275)
        Me.btnAttend.TabIndex = 2
        Me.btnAttend.Text = "Go To Attendance"
        Me.btnAttend.UseVisualStyleBackColor = False
        '
        'btnStaff
        '
        Me.btnStaff.AutoSize = True
        Me.btnStaff.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.Location = New System.Drawing.Point(493, 2)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(449, 275)
        Me.btnStaff.TabIndex = 3
        Me.btnStaff.Text = "Go To Staff Management"
        Me.btnStaff.UseVisualStyleBackColor = False
        '
        'HRHomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 549)
        Me.Controls.Add(Me.btnStaff)
        Me.Controls.Add(Me.btnAttend)
        Me.Controls.Add(Me.btnGoPayroll)
        Me.Controls.Add(Me.btnGoLeave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HRHomepage"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGoLeave As Button
    Friend WithEvents btnGoPayroll As Button
    Friend WithEvents btnAttend As Button
    Friend WithEvents btnStaff As Button
End Class
