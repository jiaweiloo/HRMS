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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboDuration = New System.Windows.Forms.ComboBox()
        Me.lbl_People_ID = New System.Windows.Forms.Label()
        Me.lbl_Leave_ID = New System.Windows.Forms.Label()
        Me.chooseDate = New System.Windows.Forms.MonthCalendar()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboDuration)
        Me.GroupBox1.Controls.Add(Me.lbl_People_ID)
        Me.GroupBox1.Controls.Add(Me.lbl_Leave_ID)
        Me.GroupBox1.Controls.Add(Me.chooseDate)
        Me.GroupBox1.Controls.Add(Me.txtReason)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(605, 340)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Leave Details"
        '
        'cboDuration
        '
        Me.cboDuration.FormattingEnabled = True
        Me.cboDuration.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cboDuration.Location = New System.Drawing.Point(344, 44)
        Me.cboDuration.Name = "cboDuration"
        Me.cboDuration.Size = New System.Drawing.Size(121, 24)
        Me.cboDuration.TabIndex = 4
        '
        'lbl_People_ID
        '
        Me.lbl_People_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_People_ID.Location = New System.Drawing.Point(12, 44)
        Me.lbl_People_ID.Name = "lbl_People_ID"
        Me.lbl_People_ID.Size = New System.Drawing.Size(116, 23)
        Me.lbl_People_ID.TabIndex = 0
        '
        'lbl_Leave_ID
        '
        Me.lbl_Leave_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Leave_ID.Location = New System.Drawing.Point(191, 42)
        Me.lbl_Leave_ID.Name = "lbl_Leave_ID"
        Me.lbl_Leave_ID.Size = New System.Drawing.Size(125, 23)
        Me.lbl_Leave_ID.TabIndex = 1
        '
        'chooseDate
        '
        Me.chooseDate.Location = New System.Drawing.Point(12, 99)
        Me.chooseDate.Name = "chooseDate"
        Me.chooseDate.TabIndex = 2
        '
        'txtReason
        '
        Me.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReason.Location = New System.Drawing.Point(315, 99)
        Me.txtReason.MaxLength = 100
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(284, 139)
        Me.txtReason.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(558, 445)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(28, 445)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 526)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboDuration As ComboBox
    Friend WithEvents lbl_People_ID As Label
    Friend WithEvents lbl_Leave_ID As Label
    Friend WithEvents chooseDate As MonthCalendar
    Friend WithEvents txtReason As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents err As ErrorProvider
End Class
