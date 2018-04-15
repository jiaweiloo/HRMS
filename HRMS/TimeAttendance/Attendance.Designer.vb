<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Attendance))
        Me.btnReport = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnLunchOut = New System.Windows.Forms.Button()
        Me.btnCheckIn = New System.Windows.Forms.Button()
        Me.btnAttendance = New System.Windows.Forms.Button()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.lblAttID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLunchIn = New System.Windows.Forms.Button()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(722, 185)
        Me.btnReport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(146, 102)
        Me.btnReport.TabIndex = 31
        Me.btnReport.Text = "Manager Report"
        Me.btnReport.UseVisualStyleBackColor = True
        Me.btnReport.Visible = False
        '
        'Timer1
        '
        '
        'btnLunchOut
        '
        Me.btnLunchOut.Enabled = False
        Me.btnLunchOut.Location = New System.Drawing.Point(117, 190)
        Me.btnLunchOut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLunchOut.Name = "btnLunchOut"
        Me.btnLunchOut.Size = New System.Drawing.Size(150, 66)
        Me.btnLunchOut.TabIndex = 1
        Me.btnLunchOut.Text = "Lunch Out"
        Me.btnLunchOut.UseVisualStyleBackColor = True
        '
        'btnCheckIn
        '
        Me.btnCheckIn.Location = New System.Drawing.Point(117, 79)
        Me.btnCheckIn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(150, 66)
        Me.btnCheckIn.TabIndex = 0
        Me.btnCheckIn.Text = "Check In"
        Me.btnCheckIn.UseVisualStyleBackColor = True
        '
        'btnAttendance
        '
        Me.btnAttendance.Location = New System.Drawing.Point(722, 40)
        Me.btnAttendance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(146, 102)
        Me.btnAttendance.TabIndex = 30
        Me.btnAttendance.Text = "Attendance History"
        Me.btnAttendance.UseVisualStyleBackColor = True
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Enabled = False
        Me.btnCheckOut.Location = New System.Drawing.Point(340, 190)
        Me.btnCheckOut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(150, 66)
        Me.btnCheckOut.TabIndex = 3
        Me.btnCheckOut.Text = "Check Out"
        Me.btnCheckOut.UseVisualStyleBackColor = True
        '
        'lblAttID
        '
        Me.lblAttID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAttID.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttID.Location = New System.Drawing.Point(172, 64)
        Me.lblAttID.Name = "lblAttID"
        Me.lblAttID.Size = New System.Drawing.Size(112, 28)
        Me.lblAttID.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 26)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Attendance ID :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 26)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Current Time :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCheckOut)
        Me.GroupBox1.Controls.Add(Me.btnLunchIn)
        Me.GroupBox1.Controls.Add(Me.btnLunchOut)
        Me.GroupBox1.Controls.Add(Me.btnCheckIn)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 245)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(623, 278)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'btnLunchIn
        '
        Me.btnLunchIn.Enabled = False
        Me.btnLunchIn.Location = New System.Drawing.Point(340, 79)
        Me.btnLunchIn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLunchIn.Name = "btnLunchIn"
        Me.btnLunchIn.Size = New System.Drawing.Size(150, 66)
        Me.btnLunchIn.TabIndex = 2
        Me.btnLunchIn.Text = "Lunch In"
        Me.btnLunchIn.UseVisualStyleBackColor = True
        '
        'lblDepartment
        '
        Me.lblDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDepartment.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.Location = New System.Drawing.Point(495, 154)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(139, 28)
        Me.lblDepartment.TabIndex = 24
        Me.lblDepartment.Text = "Label5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(369, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 26)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Department :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(369, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 26)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 28)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Label1"
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(495, 64)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(139, 28)
        Me.lblName.TabIndex = 23
        Me.lblName.Text = "Label4"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HRMS.My.Resources.Resources.checkinout
        Me.PictureBox1.Location = New System.Drawing.Point(695, 324)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'dlgPreview
        '
        Me.dlgPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreview.Enabled = True
        Me.dlgPreview.Icon = CType(resources.GetObject("dlgPreview.Icon"), System.Drawing.Icon)
        Me.dlgPreview.Name = "dlgPreview"
        Me.dlgPreview.UseAntiAlias = True
        Me.dlgPreview.Visible = False
        '
        'doc
        '
        Me.doc.DocumentName = "DailyReport"
        Me.doc.OriginAtMargins = True
        '
        'Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 562)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnAttendance)
        Me.Controls.Add(Me.lblAttID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Attendance"
        Me.Text = "Attendance"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReport As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnLunchOut As Button
    Friend WithEvents btnCheckIn As Button
    Friend WithEvents btnAttendance As Button
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents lblAttID As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLunchIn As Button
    Friend WithEvents lblDepartment As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents dlgPreview As PrintPreviewDialog
    Friend WithEvents doc As Printing.PrintDocument
End Class
