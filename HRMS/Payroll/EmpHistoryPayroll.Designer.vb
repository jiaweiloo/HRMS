<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpHistoryPayroll
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
        Me.btnGoHome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGoHome
        '
        Me.btnGoHome.AutoSize = True
        Me.btnGoHome.Location = New System.Drawing.Point(320, 210)
        Me.btnGoHome.Name = "btnGoHome"
        Me.btnGoHome.Size = New System.Drawing.Size(151, 30)
        Me.btnGoHome.TabIndex = 0
        Me.btnGoHome.Text = "back to homepage"
        Me.btnGoHome.UseVisualStyleBackColor = True
        '
        'EmpHistoryPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGoHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EmpHistoryPayroll"
        Me.Text = "EmpHistoryPayroll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGoHome As Button
End Class
