<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerMainPage
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.btnAttend = New System.Windows.Forms.Button()
        Me.btnViewleave = New System.Windows.Forms.Button()
        Me.btnPayroll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAccount
        '
        Me.btnAccount.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccount.Location = New System.Drawing.Point(4, -12)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(434, 279)
        Me.btnAccount.TabIndex = 1
        Me.btnAccount.Text = "&Account Management"
        Me.btnAccount.UseVisualStyleBackColor = False
        '
        'btnAttend
        '
        Me.btnAttend.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAttend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAttend.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttend.Location = New System.Drawing.Point(447, -12)
        Me.btnAttend.Name = "btnAttend"
        Me.btnAttend.Size = New System.Drawing.Size(396, 279)
        Me.btnAttend.TabIndex = 2
        Me.btnAttend.Text = "&Time and Attendance"
        Me.btnAttend.UseVisualStyleBackColor = False
        '
        'btnViewleave
        '
        Me.btnViewleave.BackColor = System.Drawing.Color.SpringGreen
        Me.btnViewleave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewleave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewleave.Location = New System.Drawing.Point(4, 263)
        Me.btnViewleave.Name = "btnViewleave"
        Me.btnViewleave.Size = New System.Drawing.Size(434, 282)
        Me.btnViewleave.TabIndex = 3
        Me.btnViewleave.Text = "&View Leave"
        Me.btnViewleave.UseVisualStyleBackColor = False
        '
        'btnPayroll
        '
        Me.btnPayroll.BackColor = System.Drawing.Color.IndianRed
        Me.btnPayroll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayroll.Location = New System.Drawing.Point(447, 263)
        Me.btnPayroll.Name = "btnPayroll"
        Me.btnPayroll.Size = New System.Drawing.Size(396, 282)
        Me.btnPayroll.TabIndex = 4
        Me.btnPayroll.Text = "&Payroll"
        Me.btnPayroll.UseVisualStyleBackColor = False
        '
        'ManagerMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 547)
        Me.Controls.Add(Me.btnPayroll)
        Me.Controls.Add(Me.btnViewleave)
        Me.Controls.Add(Me.btnAttend)
        Me.Controls.Add(Me.btnAccount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ManagerMainPage"
        Me.Text = "ManagerMainPage"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAccount As Button
    Friend WithEvents btnAttend As Button
    Friend WithEvents btnViewleave As Button
    Friend WithEvents btnPayroll As Button
End Class
