﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Leave
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
        Me.radApproved = New System.Windows.Forms.RadioButton()
        Me.radRejected = New System.Windows.Forms.RadioButton()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'radApproved
        '
        Me.radApproved.AutoSize = True
        Me.radApproved.Location = New System.Drawing.Point(326, 404)
        Me.radApproved.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radApproved.Name = "radApproved"
        Me.radApproved.Size = New System.Drawing.Size(102, 24)
        Me.radApproved.TabIndex = 16
        Me.radApproved.TabStop = True
        Me.radApproved.Text = "Approved"
        Me.radApproved.UseVisualStyleBackColor = True
        '
        'radRejected
        '
        Me.radRejected.AutoSize = True
        Me.radRejected.Location = New System.Drawing.Point(326, 251)
        Me.radRejected.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radRejected.Name = "radRejected"
        Me.radRejected.Size = New System.Drawing.Size(98, 24)
        Me.radRejected.TabIndex = 15
        Me.radRejected.TabStop = True
        Me.radRejected.Text = "Rejected"
        Me.radRejected.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(553, 368)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(84, 29)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 537)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 429)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Label1"
        '
        'lblWelcome
        '
        Me.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWelcome.Location = New System.Drawing.Point(38, 74)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(1084, 68)
        Me.lblWelcome.TabIndex = 9
        '
        'Update_Leave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 630)
        Me.Controls.Add(Me.radApproved)
        Me.Controls.Add(Me.radRejected)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "Update_Leave"
        Me.Text = "Update_Leave"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radApproved As RadioButton
    Friend WithEvents radRejected As RadioButton
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblWelcome As Label
End Class
