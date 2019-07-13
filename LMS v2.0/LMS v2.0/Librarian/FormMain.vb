Public Class FormMain

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo, "Confirm Logout")
        If ans = MsgBoxResult.Yes Then
            FormLogin.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub btnSearchBook_Click(sender As Object, e As EventArgs) Handles btnSearchBook.Click
        'formLibrarianSearchBook.Show()
        'Me.Hide()
    End Sub

    Private Sub btnSearchBorrower_Click(sender As Object, e As EventArgs) Handles btnSearchBorrower.Click
        'formLibrarianSearchBorrower.Show()
        'Me.Hide()
    End Sub

    Private Sub btnIssueBook_Click(sender As Object, e As EventArgs) Handles btnIssueBook.Click
        'formLibrarianIssueDialog.ShowDialog()
    End Sub

    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        'formLibrarianReturnItem.ShowDialog()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        If FormSettings.ShowDialog() = Windows.Forms.DialogResult.OK Then
            loadMissionVision()
        End If
    End Sub

    Private Sub formLibrarianMain_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        loadMissionVision()
    End Sub

    Private Sub formLibrarianMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadMissionVision()
        Timer1.Enabled = True
        Timer1.Interval = 1
        Dim dateToday As DateTime = DateTime.Now
        lblDate.Text = dateToday.ToString("D")
    End Sub
    Private Sub loadMissionVision()
        Try
            lblMission.Text = FormLogin.ObjMaintenance.MaintenanceMission
            lblVision.Text = FormLogin.ObjMaintenance.MaintenanceVision
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub pnlUp_DoubleClick(sender As Object, e As EventArgs) Handles pnlUp.DoubleClick
        loadMissionVision()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
    End Sub
End Class