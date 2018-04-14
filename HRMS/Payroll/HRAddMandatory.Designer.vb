<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRAddMandatory
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cBoxFormat = New System.Windows.Forms.ComboBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Type :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(170, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Value :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Format :"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(268, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 33)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "40001"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cBoxFormat
        '
        Me.cBoxFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxFormat.FormattingEnabled = True
        Me.cBoxFormat.Items.AddRange(New Object() {"actual deduction", "percentage deduction"})
        Me.cBoxFormat.Location = New System.Drawing.Point(268, 255)
        Me.cBoxFormat.Name = "cBoxFormat"
        Me.cBoxFormat.Size = New System.Drawing.Size(232, 28)
        Me.cBoxFormat.TabIndex = 7
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(268, 188)
        Me.txtValue.MaxLength = 50
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(232, 26)
        Me.txtValue.TabIndex = 8
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(268, 121)
        Me.txtType.MaxLength = 50
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(232, 26)
        Me.txtType.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Location = New System.Drawing.Point(176, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 30)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "&Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Location = New System.Drawing.Point(408, 310)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 30)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.Location = New System.Drawing.Point(292, 310)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 30)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "&Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'HRAddMandatory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 366)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.cBoxFormat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HRAddMandatory"
        Me.Text = "Add Mandatory Deduction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cBoxFormat As ComboBox
    Friend WithEvents txtValue As TextBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
