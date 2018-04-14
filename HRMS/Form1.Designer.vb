<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGoLeave
        '
        Me.btnGoLeave.AutoSize = True
        Me.btnGoLeave.Location = New System.Drawing.Point(86, 44)
        Me.btnGoLeave.Name = "btnGoLeave"
        Me.btnGoLeave.Size = New System.Drawing.Size(110, 58)
        Me.btnGoLeave.TabIndex = 0
        Me.btnGoLeave.Text = "Go To Leave"
        Me.btnGoLeave.UseVisualStyleBackColor = True
        '
        'btnGoPayroll
        '
        Me.btnGoPayroll.AutoSize = True
        Me.btnGoPayroll.Location = New System.Drawing.Point(328, 44)
        Me.btnGoPayroll.Name = "btnGoPayroll"
        Me.btnGoPayroll.Size = New System.Drawing.Size(113, 58)
        Me.btnGoPayroll.TabIndex = 1
        Me.btnGoPayroll.Text = "Go To Payroll"
        Me.btnGoPayroll.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.Location = New System.Drawing.Point(46, 201)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 58)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Go To Attendance"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.Location = New System.Drawing.Point(328, 201)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(199, 58)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Go To User Management"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 318)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnGoPayroll)
        Me.Controls.Add(Me.btnGoLeave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGoLeave As Button
    Friend WithEvents btnGoPayroll As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
