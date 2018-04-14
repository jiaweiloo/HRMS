<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateForm
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
        Me.lblhourpay = New System.Windows.Forms.Label()
        Me.lblextra = New System.Windows.Forms.Label()
        Me.cboLeave = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblIndex = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.cboDepart = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.DateDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtIC = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblStaffID = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblhourpay
        '
        Me.lblhourpay.AutoSize = True
        Me.lblhourpay.ForeColor = System.Drawing.SystemColors.Control
        Me.lblhourpay.Location = New System.Drawing.Point(441, 458)
        Me.lblhourpay.Name = "lblhourpay"
        Me.lblhourpay.Size = New System.Drawing.Size(0, 20)
        Me.lblhourpay.TabIndex = 106
        '
        'lblextra
        '
        Me.lblextra.AutoSize = True
        Me.lblextra.ForeColor = System.Drawing.SystemColors.Control
        Me.lblextra.Location = New System.Drawing.Point(411, 450)
        Me.lblextra.Name = "lblextra"
        Me.lblextra.Size = New System.Drawing.Size(0, 20)
        Me.lblextra.TabIndex = 105
        '
        'cboLeave
        '
        Me.cboLeave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLeave.FormattingEnabled = True
        Me.cboLeave.Items.AddRange(New Object() {"5", "4", "3", "2", "1", "0"})
        Me.cboLeave.Location = New System.Drawing.Point(309, 450)
        Me.cboLeave.Name = "cboLeave"
        Me.cboLeave.Size = New System.Drawing.Size(80, 28)
        Me.cboLeave.TabIndex = 104
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(161, 450)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 20)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "LeaveApplyLeft :"
        '
        'lblIndex
        '
        Me.lblIndex.AutoSize = True
        Me.lblIndex.Location = New System.Drawing.Point(534, 21)
        Me.lblIndex.Name = "lblIndex"
        Me.lblIndex.Size = New System.Drawing.Size(0, 20)
        Me.lblIndex.TabIndex = 102
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(417, 491)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 33)
        Me.btnDelete.TabIndex = 101
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(158, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(484, 49)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Update Personal Details"
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(98, 6)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(87, 24)
        Me.radFemale.TabIndex = 18
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'cboDepart
        '
        Me.cboDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepart.FormattingEnabled = True
        Me.cboDepart.Items.AddRange(New Object() {"IT Dept.", "HR Dept.", "Accounting Dept.", "Marketing Dept."})
        Me.cboDepart.Location = New System.Drawing.Point(309, 117)
        Me.cboDepart.Name = "cboDepart"
        Me.cboDepart.Size = New System.Drawing.Size(273, 28)
        Me.cboDepart.TabIndex = 99
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(158, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 20)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Department :"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(506, 491)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(76, 33)
        Me.btnCancel.TabIndex = 97
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(336, 491)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 33)
        Me.btnUpdate.TabIndex = 96
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(309, 408)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(273, 26)
        Me.txtAddress.TabIndex = 95
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(309, 366)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(273, 26)
        Me.txtEmail.TabIndex = 94
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(309, 324)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(273, 26)
        Me.txtPhone.TabIndex = 93
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radFemale)
        Me.GroupBox1.Controls.Add(Me.radMale)
        Me.GroupBox1.Location = New System.Drawing.Point(309, 282)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(273, 36)
        Me.GroupBox1.TabIndex = 92
        Me.GroupBox1.TabStop = False
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Checked = True
        Me.radMale.Location = New System.Drawing.Point(0, 6)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(68, 24)
        Me.radMale.TabIndex = 0
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'DateDOB
        '
        Me.DateDOB.Location = New System.Drawing.Point(309, 242)
        Me.DateDOB.Name = "DateDOB"
        Me.DateDOB.Size = New System.Drawing.Size(273, 26)
        Me.DateDOB.TabIndex = 91
        '
        'txtIC
        '
        Me.txtIC.Location = New System.Drawing.Point(309, 202)
        Me.txtIC.Name = "txtIC"
        Me.txtIC.Size = New System.Drawing.Size(273, 26)
        Me.txtIC.TabIndex = 90
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(309, 163)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(273, 26)
        Me.txtName.TabIndex = 89
        '
        'lblStaffID
        '
        Me.lblStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStaffID.Location = New System.Drawing.Point(309, 72)
        Me.lblStaffID.Name = "lblStaffID"
        Me.lblStaffID.Size = New System.Drawing.Size(273, 33)
        Me.lblStaffID.TabIndex = 88
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(158, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 20)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "StaffID : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(158, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Date Of Birth :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Name : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(164, 366)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Email : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(158, 408)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Address : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(158, 327)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Phone No :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Gender : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "IC number :"
        '
        'UpdateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 544)
        Me.Controls.Add(Me.lblhourpay)
        Me.Controls.Add(Me.lblextra)
        Me.Controls.Add(Me.cboLeave)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblIndex)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboDepart)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateDOB)
        Me.Controls.Add(Me.txtIC)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblStaffID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Name = "UpdateForm"
        Me.Text = "UpdateForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblhourpay As Label
    Friend WithEvents lblextra As Label
    Friend WithEvents cboLeave As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblIndex As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents cboDepart As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radMale As RadioButton
    Friend WithEvents DateDOB As DateTimePicker
    Friend WithEvents txtIC As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblStaffID As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
End Class
