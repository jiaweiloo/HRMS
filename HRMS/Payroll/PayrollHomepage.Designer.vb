﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCheckMdDdt = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(304, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 52)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Prepare this month payroll for all"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCheckMdDdt
        '
        Me.btnCheckMdDdt.Location = New System.Drawing.Point(304, 100)
        Me.btnCheckMdDdt.Name = "btnCheckMdDdt"
        Me.btnCheckMdDdt.Size = New System.Drawing.Size(192, 52)
        Me.btnCheckMdDdt.TabIndex = 0
        Me.btnCheckMdDdt.Text = "Check and &Manage Mandatory Deduction"
        Me.btnCheckMdDdt.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.Location = New System.Drawing.Point(304, 172)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 52)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Check &Overtime"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.Location = New System.Drawing.Point(304, 244)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(192, 52)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Check &Deduction"
        Me.Button4.UseVisualStyleBackColor = True
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
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnCheckMdDdt)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PayrollHomepage"
        Me.Text = "Payroll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnCheckMdDdt As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
End Class
