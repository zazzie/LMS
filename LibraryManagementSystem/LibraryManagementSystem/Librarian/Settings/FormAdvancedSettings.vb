Public Class FormAdvancedSettings
    Dim objThisMaintenance As New AdvancedSettings
    Dim objSchoolYear As New FormSchoolYear

    Dim objFormPublisher As New FormPublisher
    Dim objFormCategory As New FormCategory
    Dim objFormAuthor As New FormAuthor
    Dim objFormCourse As New FormCourse
    Dim objFormDepartment As New FormDepartment
    Dim objFormLevelSection As New FormStudentLevelSection

    Private Sub enablePanel(ByVal flag As Boolean)
        pnlAlmostDue.Enabled = flag
        pnlBookLimit.Enabled = flag
        pnlFine.Enabled = flag
        pnlMissionVision.Enabled = flag
        pnlSY.Enabled = flag
        pnlOtherSettings.Enabled = flag
    End Sub

    Private Sub renameButton()
        btnAlmostDue.Text = "Edit"
        btnEditBookLimit.Text = "Edit"
        btnClose.Text = "Close"
        btnEditFine.Text = "Edit"
        btnEditMissionVision.Text = "Edit"
        btnSchoolYear.Text = "Set School Year"
    End Sub

    Private Sub enableInput(ByVal flag As Boolean)
        rtbMission.Enabled = flag
        rtbVision.Enabled = flag
        txtAlmostDue.Enabled = flag
        txtBorrowLimit.Enabled = flag
        txtFine.Enabled = flag
    End Sub

    Private Sub revertFormSettings()
        enablePanel(True)
        enableInput(False)
        renameButton()
    End Sub

    Private Sub formAdvancedSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If btnClose.Text = "Cancel" Then
            Dim ans As Integer
            ans = MsgBox("There are unsaved changes. Do you want to exit without saving?", MsgBoxStyle.YesNo, "Unsaved Changes")
            If ans = MsgBoxResult.Yes Then
                Me.Dispose()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub loadData()
        rtbMission.Text = FormLogin.ObjMaintenance.MaintenanceMission
        rtbVision.Text = FormLogin.ObjMaintenance.MaintenanceVision
        lblSchlYr.Text = FormLogin.ObjMaintenance.MaintenanceSchoolYear
        txtAlmostDue.Text = FormLogin.ObjMaintenance.MaintenanceAlmostDueDays
        txtBorrowLimit.Text = FormLogin.ObjMaintenance.MaintenanceBookLimit
        txtFine.Text = FormLogin.ObjMaintenance.MaintenanceFine
        lblSemester.Text = FormLogin.ObjMaintenance.MaintenanceSemester
    End Sub

    Private Sub formAdvancedSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        txtFine.Text = Val(txtFine.Text).ToString("###,###,###.00")
        revertFormSettings()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If btnClose.Text = "Close" Then
            Me.Dispose()
        ElseIf btnClose.Text = "Cancel" Then
            loadData()
            revertFormSettings()
        End If
    End Sub

    Private Sub txtFine_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFine.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or (c = "." And txtFine.Text.IndexOf(".") = -1) Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtFine_LostFocus(sender As Object, e As EventArgs) Handles txtFine.LostFocus
        txtFine.Text = Val(txtFine.Text).ToString("###,###,###.00")
    End Sub

    Private Sub txtFine_TextChanged(sender As Object, e As EventArgs) Handles txtFine.TextChanged

    End Sub

    Private Sub btnEditMissionVision_Click(sender As Object, e As EventArgs) Handles btnEditMissionVision.Click
        If btnEditMissionVision.Text = "Edit" Then
            enablePanel(False)
            pnlMissionVision.Enabled = True
            rtbMission.Enabled = True
            rtbVision.Enabled = True
            btnEditMissionVision.Text = "Save"
            btnClose.Text = "Cancel"
        ElseIf btnEditMissionVision.Text = "Save" Then
            objThisMaintenance.MaintenanceMission = rtbMission.Text
            objThisMaintenance.MaintenanceVision = rtbVision.Text
            objThisMaintenance.editMissionVision()
            FormLogin.ObjMaintenance.MaintenanceVision = objThisMaintenance.MaintenanceVision
            FormLogin.ObjMaintenance.MaintenanceMission = objThisMaintenance.MaintenanceMission
            MsgBox("You have successfully updated the Mission and Vision.", MsgBoxStyle.Information, "Successfully Updated")
            loadData()
            revertFormSettings()
        End If
    End Sub

    Private Sub btnEditFine_Click(sender As Object, e As EventArgs) Handles btnEditFine.Click
        If btnEditFine.Text = "Edit" Then
            enablePanel(False)
            pnlFine.Enabled = True
            txtFine.Enabled = True
            btnEditFine.Text = "Save Changes"
            btnClose.Text = "Cancel"
        ElseIf btnEditFine.Text = "Save Changes" Then
            objThisMaintenance.MaintenanceFine = txtFine.Text
            objThisMaintenance.editFine()
            FormLogin.ObjMaintenance.MaintenanceFine = objThisMaintenance.MaintenanceFine
            MsgBox("You have successfully updated the Fine for late return of books.", MsgBoxStyle.Information, "Successfully Updated")
            loadData()
            revertFormSettings()
        End If
    End Sub

    Private Sub btnEditBookLimit_Click(sender As Object, e As EventArgs) Handles btnEditBookLimit.Click
        If btnEditBookLimit.Text = "Edit" Then
            enablePanel(False)
            pnlBookLimit.Enabled = True
            txtBorrowLimit.Enabled = True
            btnEditBookLimit.Text = "Save Changes"
            btnClose.Text = "Cancel"
        ElseIf btnEditBookLimit.Text = "Save Changes" Then
            objThisMaintenance.MaintenanceBookLimit = txtBorrowLimit.Text
            objThisMaintenance.editBookLimit()
            FormLogin.ObjMaintenance.MaintenanceBookLimit = objThisMaintenance.MaintenanceBookLimit
            MsgBox("You have successfully updated the Book Limit for all borrowers.", MsgBoxStyle.Information, "Successfully Updated")
            loadData()
            revertFormSettings()
        End If
    End Sub

    Private Sub btnAlmostDue_Click(sender As Object, e As EventArgs) Handles btnAlmostDue.Click
        If btnAlmostDue.Text = "Edit" Then
            enablePanel(False)
            pnlAlmostDue.Enabled = True
            txtAlmostDue.Enabled = True
            btnAlmostDue.Text = "Save Changes"
            btnClose.Text = "Cancel"
        ElseIf btnAlmostDue.Text = "Save Changes" Then
            objThisMaintenance.MaintenanceAlmostDueDays = txtAlmostDue.Text
            objThisMaintenance.editAlmostDue()
            FormLogin.ObjMaintenance.MaintenanceAlmostDueDays = objThisMaintenance.MaintenanceAlmostDueDays
            MsgBox("You have successfully set the days left as almost due for book returns.", MsgBoxStyle.Information, "Successfully Updated")
            loadData()
            revertFormSettings()
        End If
    End Sub

    Private Sub btnSchoolYear_Click(sender As Object, e As EventArgs) Handles btnSchoolYear.Click
        objSchoolYear = New FormSchoolYear
        If objSchoolYear.ShowDialog() = Windows.Forms.DialogResult.OK Then
            loadData()
            revertFormSettings()
        End If
    End Sub

    Private Sub btnPublisher_Click(sender As Object, e As EventArgs) Handles btnPublisher.Click
        objFormPublisher = New FormPublisher
        objFormPublisher.ShowDialog()
    End Sub

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        objFormCategory = New FormCategory
        objFormCategory.ShowDialog()
    End Sub

    Private Sub btnAuthor_Click(sender As Object, e As EventArgs) Handles btnAuthor.Click
        objFormAuthor = New FormAuthor
        objFormAuthor.ShowDialog()
    End Sub

    Private Sub btnCourse_Click(sender As Object, e As EventArgs) Handles btnCourse.Click
        objFormCourse = New FormCourse
        objFormCourse.ShowDialog()
    End Sub

    Private Sub btnDepartment_Click(sender As Object, e As EventArgs) Handles btnDepartment.Click
        objFormDepartment = New FormDepartment
        objFormDepartment.ShowDialog()
    End Sub

    Private Sub btnStudentLevel_Click(sender As Object, e As EventArgs) Handles btnStudentLevel.Click
        objFormLevelSection = New FormStudentLevelSection
        objFormLevelSection.ShowDialog()
    End Sub

End Class