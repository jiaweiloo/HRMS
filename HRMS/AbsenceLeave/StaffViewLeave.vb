Public Class StaffViewLeave

    Private Sub BindData()

        Dim staffid As String = lblID.Text

        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs = From c In db.Leaves
                 Where (c.people_id = staffid)
        dgvstaffleave.DataSource = rs


    End Sub
    Private Sub StaffViewLeave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblID.Text = HRstaffid.hrstaffid
        lblName.Text = HRstaffid.hrname
        Dim style As FontStyle
        style = FontStyle.Bold
        Dim timesNewRoman As Font = New Font("Times New Roman", 12, style)
        'Dim fore As Color = Color.DarkSeaGreen
        'lblID.ForeColor = fore
        'lblName.ForeColor = fore
        lblID.Font = timesNewRoman
        lblName.Font = timesNewRoman

        BindData()
    End Sub

    Private Sub StaffViewLeave_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        lblID.Text = HRstaffid.hrstaffid
        lblName.Text = HRstaffid.hrname
        Dim style As FontStyle
        style = FontStyle.Bold
        Dim timesNewRoman As Font = New Font("Times New Roman", 12, style)
        'Dim fore As Color = Color.GreenYellow
        'lblID.ForeColor = fore
        'lblName.ForeColor = fore
        lblID.Font = timesNewRoman
        lblName.Font = timesNewRoman

        BindData()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        MDIStaff.ShowForm(NormalStaffPage)
    End Sub
End Class