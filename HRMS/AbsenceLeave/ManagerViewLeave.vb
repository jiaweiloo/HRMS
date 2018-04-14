Public Class ManagerViewLeave
    Private Sub BindData()

        Dim status As String = cboStatus.Text

        Dim db As New HRMS_DBLinq2DataContext()
        Dim rs = From c In db.Leaves
                 Where (status = "All" Or c.status = status)
        dgvLeave.DataSource = rs

        lblCount.Text = rs.Count().ToString("0 record(s)")
        lblCount.ForeColor = Color.Red
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        BindData()
    End Sub

    Private Sub ManagerViewLeave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboStatus.Text = "All"
        lblID.Text = HRstaffid.hrstaffid
        lblName.Text = HRstaffid.hrname
        lblID.BackColor = Color.AliceBlue
        lblName.BackColor = Color.AliceBlue
        Dim style As FontStyle
        style = FontStyle.Bold
        Dim timesNewRoman As Font = New Font("Times New Roman", 12, style)
        Dim fore As Color = Color.GreenYellow
        lblID.ForeColor = fore
        lblName.ForeColor = fore
        Label1.ForeColor = fore
        Label3.ForeColor = fore
        lblID.Font = timesNewRoman
        lblName.Font = timesNewRoman
        Label1.Font = timesNewRoman
        Label3.Font = timesNewRoman

        BindData()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        MessageBox.Show("Programmed By JJ", "About")
    End Sub
End Class