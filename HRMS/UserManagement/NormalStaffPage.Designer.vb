﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NormalStaffPage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnApplyLeave = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblstaffname = New System.Windows.Forms.Label()
        Me.lblstaffid = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STAFF HOME PAGE"
        '
        'btnApplyLeave
        '
        Me.btnApplyLeave.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnApplyLeave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApplyLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApplyLeave.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnApplyLeave.Location = New System.Drawing.Point(584, 171)
        Me.btnApplyLeave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnApplyLeave.Name = "btnApplyLeave"
        Me.btnApplyLeave.Size = New System.Drawing.Size(187, 91)
        Me.btnApplyLeave.TabIndex = 1
        Me.btnApplyLeave.Text = "&Apply Leave"
        Me.btnApplyLeave.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.HRMS.My.Resources.Resources.holiday_mood
        Me.PictureBox1.Location = New System.Drawing.Point(34, 78)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(463, 283)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(584, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 86)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Attendance"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(404, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 20)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Welcome !"
        '
        'lblstaffname
        '
        Me.lblstaffname.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblstaffname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblstaffname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstaffname.Location = New System.Drawing.Point(646, 28)
        Me.lblstaffname.Name = "lblstaffname"
        Me.lblstaffname.Size = New System.Drawing.Size(125, 30)
        Me.lblstaffname.TabIndex = 89
        '
        'lblstaffid
        '
        Me.lblstaffid.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblstaffid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblstaffid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstaffid.Location = New System.Drawing.Point(515, 28)
        Me.lblstaffid.Name = "lblstaffid"
        Me.lblstaffid.Size = New System.Drawing.Size(125, 30)
        Me.lblstaffid.TabIndex = 88
        '
        'NormalStaffPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 558)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblstaffname)
        Me.Controls.Add(Me.lblstaffid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnApplyLeave)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "NormalStaffPage"
        Me.Text = "NormalStaffPage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnApplyLeave As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents lblstaffname As Label
    Friend WithEvents lblstaffid As Label
End Class
