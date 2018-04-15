<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRNetpayUpDel
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPayrollID = New System.Windows.Forms.Label()
        Me.lblGenerateDate = New System.Windows.Forms.Label()
        Me.txtAbsence = New System.Windows.Forms.TextBox()
        Me.txtFinalPay = New System.Windows.Forms.TextBox()
        Me.txtManDdt = New System.Windows.Forms.TextBox()
        Me.txtExtraDdt = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblPplID = New System.Windows.Forms.Label()
        Me.lblAttendance = New System.Windows.Forms.Label()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payroll ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(213, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "People ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Attendance :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Absence :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(197, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Final Salary :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(163, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Generated Date :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(127, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Mandatory Deduction :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(165, 363)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Extra Deduction :"
        '
        'lblPayrollID
        '
        Me.lblPayrollID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayrollID.Location = New System.Drawing.Point(373, 57)
        Me.lblPayrollID.Name = "lblPayrollID"
        Me.lblPayrollID.Size = New System.Drawing.Size(245, 31)
        Me.lblPayrollID.TabIndex = 8
        Me.lblPayrollID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGenerateDate
        '
        Me.lblGenerateDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGenerateDate.Location = New System.Drawing.Point(373, 272)
        Me.lblGenerateDate.Name = "lblGenerateDate"
        Me.lblGenerateDate.Size = New System.Drawing.Size(245, 31)
        Me.lblGenerateDate.TabIndex = 9
        Me.lblGenerateDate.Text = "Label10"
        Me.lblGenerateDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAbsence
        '
        Me.txtAbsence.Location = New System.Drawing.Point(373, 188)
        Me.txtAbsence.Name = "txtAbsence"
        Me.txtAbsence.Size = New System.Drawing.Size(245, 26)
        Me.txtAbsence.TabIndex = 12
        '
        'txtFinalPay
        '
        Me.txtFinalPay.Location = New System.Drawing.Point(373, 231)
        Me.txtFinalPay.Name = "txtFinalPay"
        Me.txtFinalPay.Size = New System.Drawing.Size(245, 26)
        Me.txtFinalPay.TabIndex = 13
        '
        'txtManDdt
        '
        Me.txtManDdt.Location = New System.Drawing.Point(373, 317)
        Me.txtManDdt.Name = "txtManDdt"
        Me.txtManDdt.Size = New System.Drawing.Size(245, 26)
        Me.txtManDdt.TabIndex = 14
        '
        'txtExtraDdt
        '
        Me.txtExtraDdt.Location = New System.Drawing.Point(373, 360)
        Me.txtExtraDdt.Name = "txtExtraDdt"
        Me.txtExtraDdt.Size = New System.Drawing.Size(245, 26)
        Me.txtExtraDdt.TabIndex = 15
        '
        'btnUpdate
        '
        Me.btnUpdate.AutoSize = True
        Me.btnUpdate.Location = New System.Drawing.Point(229, 408)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(99, 30)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(473, 408)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 30)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblPplID
        '
        Me.lblPplID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPplID.Location = New System.Drawing.Point(373, 100)
        Me.lblPplID.Name = "lblPplID"
        Me.lblPplID.Size = New System.Drawing.Size(245, 31)
        Me.lblPplID.TabIndex = 19
        Me.lblPplID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAttendance
        '
        Me.lblAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAttendance.Location = New System.Drawing.Point(373, 143)
        Me.lblAttendance.Name = "lblAttendance"
        Me.lblAttendance.Size = New System.Drawing.Size(245, 31)
        Me.lblAttendance.TabIndex = 20
        Me.lblAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = True
        Me.btnDelete.CausesValidation = False
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelete.Location = New System.Drawing.Point(351, 408)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(99, 30)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(307, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(186, 29)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Netpay Update"
        '
        'HRNetpayUpDel
        '
        Me.AcceptButton = Me.btnUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblAttendance)
        Me.Controls.Add(Me.lblPplID)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtExtraDdt)
        Me.Controls.Add(Me.txtManDdt)
        Me.Controls.Add(Me.txtFinalPay)
        Me.Controls.Add(Me.txtAbsence)
        Me.Controls.Add(Me.lblGenerateDate)
        Me.Controls.Add(Me.lblPayrollID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HRNetpayUpDel"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPayrollID As Label
    Friend WithEvents lblGenerateDate As Label
    Friend WithEvents txtAbsence As TextBox
    Friend WithEvents txtFinalPay As TextBox
    Friend WithEvents txtManDdt As TextBox
    Friend WithEvents txtExtraDdt As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblPplID As Label
    Friend WithEvents lblAttendance As Label
    Friend WithEvents err As ErrorProvider
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label9 As Label
End Class
