﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManUpdateHR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManUpdateHR))
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.cboDepart = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtStaffid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblHRname = New System.Windows.Forms.Label()
        Me.lblHRid = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.doc = New System.Drawing.Printing.PrintDocument()
        Me.dlgPreview = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"All", "Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(857, 97)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(110, 28)
        Me.cboGender.TabIndex = 4
        '
        'cboDepart
        '
        Me.cboDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepart.FormattingEnabled = True
        Me.cboDepart.Items.AddRange(New Object() {"All", "IT Dept.", "HR Dept.", "Accounting Dept.", "Marketing Dept."})
        Me.cboDepart.Location = New System.Drawing.Point(604, 96)
        Me.cboDepart.Name = "cboDepart"
        Me.cboDepart.Size = New System.Drawing.Size(152, 28)
        Me.cboDepart.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(772, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Gender :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(484, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Department :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(247, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Name : "
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(323, 97)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(155, 26)
        Me.txtName.TabIndex = 2
        '
        'txtStaffid
        '
        Me.txtStaffid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffid.Location = New System.Drawing.Point(125, 98)
        Me.txtStaffid.Name = "txtStaffid"
        Me.txtStaffid.Size = New System.Drawing.Size(116, 26)
        Me.txtStaffid.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "HR Staff ID :"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 152)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowTemplate.Height = 28
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(963, 293)
        Me.dgv.TabIndex = 76
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(236, 59)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Select a HR/Staff to Update or Delete"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(275, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(172, 20)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "Welcome, Manager !"
        '
        'lblHRname
        '
        Me.lblHRname.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblHRname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHRname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHRname.Location = New System.Drawing.Point(595, 45)
        Me.lblHRname.Name = "lblHRname"
        Me.lblHRname.Size = New System.Drawing.Size(125, 30)
        Me.lblHRname.TabIndex = 86
        '
        'lblHRid
        '
        Me.lblHRid.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblHRid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHRid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHRid.Location = New System.Drawing.Point(464, 45)
        Me.lblHRid.Name = "lblHRid"
        Me.lblHRid.Size = New System.Drawing.Size(125, 30)
        Me.lblHRid.TabIndex = 85
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(8, 459)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(98, 20)
        Me.lblCount.TabIndex = 89
        Me.lblCount.Text = "X record(s)"
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.IndianRed
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHome.Location = New System.Drawing.Point(849, 43)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(118, 40)
        Me.btnHome.TabIndex = 6
        Me.btnHome.Text = "&HomePage"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPrint.Location = New System.Drawing.Point(734, 45)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(109, 37)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'doc
        '
        '
        'dlgPreview
        '
        Me.dlgPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreview.Enabled = True
        Me.dlgPreview.Icon = CType(resources.GetObject("dlgPreview.Icon"), System.Drawing.Icon)
        Me.dlgPreview.Name = "dlgPreview"
        Me.dlgPreview.Visible = False
        '
        'ManUpdateHR
        '
        Me.AcceptButton = Me.btnPrint
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CancelButton = Me.btnHome
        Me.ClientSize = New System.Drawing.Size(996, 504)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblHRname)
        Me.Controls.Add(Me.lblHRid)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.cboDepart)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtStaffid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManUpdateHR"
        Me.Text = "ManUpdateHR"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboGender As ComboBox
    Friend WithEvents cboDepart As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtStaffid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblHRname As Label
    Friend WithEvents lblHRid As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents doc As Printing.PrintDocument
    Friend WithEvents dlgPreview As PrintPreviewDialog
End Class
