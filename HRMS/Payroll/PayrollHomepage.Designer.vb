<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnPrepPayroll = New System.Windows.Forms.Button()
        Me.btnCheckMdDdt = New System.Windows.Forms.Button()
        Me.btnOvertime = New System.Windows.Forms.Button()
        Me.btnDeduction = New System.Windows.Forms.Button()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrepPayroll
        '
        Me.btnPrepPayroll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrepPayroll.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnPrepPayroll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrepPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrepPayroll.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPrepPayroll.Location = New System.Drawing.Point(258, 378)
        Me.btnPrepPayroll.Name = "btnPrepPayroll"
        Me.btnPrepPayroll.Size = New System.Drawing.Size(345, 78)
        Me.btnPrepPayroll.TabIndex = 3
        Me.btnPrepPayroll.Text = "&Prepare this month payroll for all"
        Me.btnPrepPayroll.UseVisualStyleBackColor = False
        '
        'btnCheckMdDdt
        '
        Me.btnCheckMdDdt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCheckMdDdt.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCheckMdDdt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckMdDdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckMdDdt.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCheckMdDdt.Location = New System.Drawing.Point(258, 134)
        Me.btnCheckMdDdt.Name = "btnCheckMdDdt"
        Me.btnCheckMdDdt.Size = New System.Drawing.Size(345, 78)
        Me.btnCheckMdDdt.TabIndex = 0
        Me.btnCheckMdDdt.Text = "Check and &Manage Mandatory Deduction"
        Me.btnCheckMdDdt.UseVisualStyleBackColor = False
        '
        'btnOvertime
        '
        Me.btnOvertime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOvertime.AutoSize = True
        Me.btnOvertime.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnOvertime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOvertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOvertime.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnOvertime.Location = New System.Drawing.Point(258, 217)
        Me.btnOvertime.Name = "btnOvertime"
        Me.btnOvertime.Size = New System.Drawing.Size(345, 78)
        Me.btnOvertime.TabIndex = 1
        Me.btnOvertime.Text = "Check &Overtime"
        Me.btnOvertime.UseVisualStyleBackColor = False
        '
        'btnDeduction
        '
        Me.btnDeduction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeduction.AutoSize = True
        Me.btnDeduction.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnDeduction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeduction.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDeduction.Location = New System.Drawing.Point(258, 300)
        Me.btnDeduction.Name = "btnDeduction"
        Me.btnDeduction.Size = New System.Drawing.Size(345, 78)
        Me.btnDeduction.TabIndex = 2
        Me.btnDeduction.Text = "Check &Deduction"
        Me.btnDeduction.UseVisualStyleBackColor = False
        '
        'lblLogin
        '
        Me.lblLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(631, 444)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(206, 34)
        Me.lblLogin.TabIndex = 5
        Me.lblLogin.Text = "Label2"
        Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HRMS.My.Resources.Resources.payroll
        Me.PictureBox1.Location = New System.Drawing.Point(209, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(430, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.IndianRed
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBack.Location = New System.Drawing.Point(734, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(103, 41)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PayrollHomepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(849, 487)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.btnDeduction)
        Me.Controls.Add(Me.btnOvertime)
        Me.Controls.Add(Me.btnCheckMdDdt)
        Me.Controls.Add(Me.btnPrepPayroll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PayrollHomepage"
        Me.Text = "Payroll"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrepPayroll As Button
    Friend WithEvents btnCheckMdDdt As Button
    Friend WithEvents btnOvertime As Button
    Friend WithEvents btnDeduction As Button
    Friend WithEvents lblLogin As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
End Class
