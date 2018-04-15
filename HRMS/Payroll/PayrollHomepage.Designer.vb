<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayrollHomepage
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
        Me.btnPrepPayroll = New System.Windows.Forms.Button()
        Me.btnCheckMdDdt = New System.Windows.Forms.Button()
        Me.btnOvertime = New System.Windows.Forms.Button()
        Me.btnDeduction = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPrepPayroll
        '
        Me.btnPrepPayroll.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnPrepPayroll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrepPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrepPayroll.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPrepPayroll.Location = New System.Drawing.Point(258, 344)
        Me.btnPrepPayroll.Name = "btnPrepPayroll"
        Me.btnPrepPayroll.Size = New System.Drawing.Size(281, 77)
        Me.btnPrepPayroll.TabIndex = 3
        Me.btnPrepPayroll.Text = "&Prepare this month payroll for all"
        Me.btnPrepPayroll.UseVisualStyleBackColor = False
        '
        'btnCheckMdDdt
        '
        Me.btnCheckMdDdt.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCheckMdDdt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckMdDdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckMdDdt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCheckMdDdt.Location = New System.Drawing.Point(258, 100)
        Me.btnCheckMdDdt.Name = "btnCheckMdDdt"
        Me.btnCheckMdDdt.Size = New System.Drawing.Size(281, 77)
        Me.btnCheckMdDdt.TabIndex = 0
        Me.btnCheckMdDdt.Text = "Check and &Manage Mandatory Deduction"
        Me.btnCheckMdDdt.UseVisualStyleBackColor = False
        '
        'btnOvertime
        '
        Me.btnOvertime.AutoSize = True
        Me.btnOvertime.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnOvertime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOvertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOvertime.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnOvertime.Location = New System.Drawing.Point(258, 183)
        Me.btnOvertime.Name = "btnOvertime"
        Me.btnOvertime.Size = New System.Drawing.Size(281, 77)
        Me.btnOvertime.TabIndex = 1
        Me.btnOvertime.Text = "Check &Overtime"
        Me.btnOvertime.UseVisualStyleBackColor = False
        '
        'btnDeduction
        '
        Me.btnDeduction.AutoSize = True
        Me.btnDeduction.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnDeduction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeduction.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDeduction.Location = New System.Drawing.Point(258, 261)
        Me.btnDeduction.Name = "btnDeduction"
        Me.btnDeduction.Size = New System.Drawing.Size(281, 77)
        Me.btnDeduction.TabIndex = 2
        Me.btnDeduction.Text = "Check &Deduction"
        Me.btnDeduction.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "HR Management"
        '
        'PayrollHomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 489)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDeduction)
        Me.Controls.Add(Me.btnOvertime)
        Me.Controls.Add(Me.btnCheckMdDdt)
        Me.Controls.Add(Me.btnPrepPayroll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PayrollHomepage"
        Me.Text = "Payroll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrepPayroll As Button
    Friend WithEvents btnCheckMdDdt As Button
    Friend WithEvents btnOvertime As Button
    Friend WithEvents btnDeduction As Button
    Friend WithEvents Label1 As Label
End Class
