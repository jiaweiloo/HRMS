﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayLeave
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
        Me.lblCount = New System.Windows.Forms.Label()
        Me.dgvLeave = New System.Windows.Forms.DataGridView()
        Me.cboLeave = New System.Windows.Forms.ComboBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.dgvLeave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(94, 383)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(51, 17)
        Me.lblCount.TabIndex = 5
        Me.lblCount.Text = "Label1"
        '
        'dgvLeave
        '
        Me.dgvLeave.AllowUserToAddRows = False
        Me.dgvLeave.AllowUserToDeleteRows = False
        Me.dgvLeave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLeave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvLeave.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLeave.Location = New System.Drawing.Point(21, 60)
        Me.dgvLeave.Name = "dgvLeave"
        Me.dgvLeave.ReadOnly = True
        Me.dgvLeave.RowTemplate.Height = 24
        Me.dgvLeave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLeave.Size = New System.Drawing.Size(765, 298)
        Me.dgvLeave.TabIndex = 4
        '
        'cboLeave
        '
        Me.cboLeave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLeave.FormattingEnabled = True
        Me.cboLeave.Items.AddRange(New Object() {"Pending", "Rejected", "Approved", "All"})
        Me.cboLeave.Location = New System.Drawing.Point(24, 12)
        Me.cboLeave.Name = "cboLeave"
        Me.cboLeave.Size = New System.Drawing.Size(121, 24)
        Me.cboLeave.TabIndex = 3
        '
        'lblID
        '
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblID.Location = New System.Drawing.Point(245, 18)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(130, 39)
        Me.lblID.TabIndex = 6
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Location = New System.Drawing.Point(469, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(130, 38)
        Me.lblName.TabIndex = 7
        '
        'DisplayLeave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 407)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.dgvLeave)
        Me.Controls.Add(Me.cboLeave)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "DisplayLeave"
        Me.Text = "DisplayLeave"
        CType(Me.dgvLeave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCount As Label
    Friend WithEvents dgvLeave As DataGridView
    Friend WithEvents cboLeave As ComboBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblName As Label
End Class
