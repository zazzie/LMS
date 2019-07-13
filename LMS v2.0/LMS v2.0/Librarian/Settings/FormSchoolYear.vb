Public Class FormSchoolYear
    Private objSchlYr As New SchoolYear
    Private objSemester As New Semester
    Private ObjMaintenance As New AdvancedSettings
    Private ObjSemesterForm As New FormSemester
    Public Shared Sem As String = ""

    Private Sub clearAllText()
        txtSchlYrA.Clear()
        txtSchlYrB.Clear()
    End Sub

    Private Sub displaySchlYr()
        If dgvSchoolYear.Rows.Count > 0 Then
            txtSchlYrA.Text = dgvSchoolYear.SelectedRows(0).Cells(1).Value.ToString
            txtSchlYrB.Text = dgvSchoolYear.SelectedRows(0).Cells(2).Value.ToString
        End If
    End Sub

    Private Sub generateSchoolYr()
        Dim sqlSearch As String
        Try
            sqlSearch = "SELECT `schoolyearId`, `schoolyearFrom`, `schoolyearTo` FROM `schoolyear` ;"
            Dim ds As DataSet
            dgvSchoolYear.Rows.Clear()
            ds = LibraryDatabase.fetchSQL(sqlSearch)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With dgvSchoolYear
                        dgvSchoolYear.Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                               ds.Tables(0).Rows(index).Item(1).ToString.Trim, _
                                               ds.Tables(0).Rows(index).Item(2).ToString.Trim)
                    End With
                    index += 1
                End While
                dgvSchoolYear.Refresh()
                dgvSchoolYear.Select()
                displaySchlYr()
            Else
                dgvSchoolYear.Rows.Clear()
                txtSchlYrA.Clear()
                txtSchlYrB.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub RenameColumns()
        With dgvSchoolYear
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID" 'RENAMING COLUMNS
            .Columns(0).FillWeight = 30
            .Columns(1).HeaderCell.Value = "School Year"
            .Columns(1).FillWeight = 100
            .Columns(2).HeaderCell.Value = "  "
            .Columns(2).FillWeight = 100
        End With
    End Sub

    Private Sub enableText(ByVal flag As Boolean)
        txtSchlYrA.Enabled = flag
        txtSchlYrB.Enabled = flag
    End Sub

    Private Sub renameButtons()
        btnAdd.Text = "Add"
        btnEdit.Text = "Edit"
        btnClose.Text = "Close"
        btnRemove.Text = "Remove"
        btnSetSchlYr.Text = "Set As Current School Year"
    End Sub

    Private Sub enableButtons(ByVal flag As Boolean)
        btnAdd.Enabled = flag
        btnEdit.Enabled = flag
        btnRemove.Enabled = flag
        btnSetSchlYr.Enabled = flag
        btnClose.Enabled = flag
    End Sub

    Private Sub revertFormSettings()
        enableButtons(True)
        enableText(False)
        renameButtons()
        dgvSchoolYear.Enabled = True

    End Sub

    Private Sub formSchoolYear_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If btnRemove.Text = "Cancel" Then
            Dim ans As Integer
            ans = MsgBox("There are unsaved changes. Do you want to exit without saving?", MsgBoxStyle.YesNo, "Unsaved Changes")
            If ans = MsgBoxResult.Yes Then
                Me.Dispose()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub formSchoolYear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvSchoolYear.Font = New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        revertFormSettings()
        generateSchoolYr()
        RenameColumns()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Add" Then

            enableText(True)
            clearAllText()
            dgvSchoolYear.Enabled = False
            btnEdit.Enabled = False
            btnSetSchlYr.Enabled = False
            btnClose.Enabled = False

            btnAdd.Text = "Save"
            btnRemove.Text = "Cancel"
            txtSchlYrA.Focus()
        ElseIf btnAdd.Text = "Save" Then
            If Not String.IsNullOrWhiteSpace(txtSchlYrA.Text) And txtSchlYrB.TextLength = 4 Then
                If LibraryDatabase.isExisting("SELECT COUNT(*) FROM schoolyear WHERE schoolyearFrom='" + txtSchlYrA.Text + "' and schoolyearTo='" + txtSchlYrB.Text + "';") = False Then
                    Dim sqlInsert As String
                    objSchlYr.SchoolyearId = LibraryDatabase.GenerateID("select max(schoolyearId) from schoolyear;")
                    objSchlYr.SchoolyearFrom = txtSchlYrA.Text
                    objSchlYr.SchoolyearTo = txtSchlYrB.Text

                    'adding schlyr

                    sqlInsert = "INSERT INTO `schoolyear`(`schoolyearId`, `schoolyearFrom`, `schoolyearTo`) VALUES (" & _
                                            objSchlYr.SchoolyearId.ToString + ",'" & _
                                            objSchlYr.SchoolyearFrom + "','" & _
                                            objSchlYr.SchoolyearTo + "');"

                    'adding each sem
                    objSemester.SemesterSchoolYearId = objSchlYr.SchoolyearId
                    Dim id As Integer
                    id = LibraryDatabase.GenerateID("select max(semesterId) from semester;")

                    '1stsem
                    objSemester.SemesterId = id
                    sqlInsert += "INSERT INTO `semester`(`semesterId`, `semesterName`, `semesterSchoolYearId`) VALUES (" & _
                                objSemester.SemesterId.ToString + "," & _
                                "'First Semester'," & _
                                objSemester.SemesterSchoolYearId.ToString + ");"
                    '2ndsem
                    id += 1
                    objSemester.SemesterId = id
                    sqlInsert += "INSERT INTO `semester`(`semesterId`, `semesterName`, `semesterSchoolYearId`) VALUES (" & _
                                objSemester.SemesterId.ToString + "," & _
                                "'Second Semester'," & _
                                objSemester.SemesterSchoolYearId.ToString + ");"

                    LibraryDatabase.execSQL(sqlInsert)

                    MessageBox.Show("You have successfully added a new school year!", "Success Added School Year", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    generateSchoolYr()
                    revertFormSettings()

                Else
                    MessageBox.Show("School Year already exist!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtSchlYrA.Focus()
                End If
            Else
                MessageBox.Show("School Year input is invalid!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSchlYrA.Focus()
            End If

        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvSchoolYear.RowCount > 0 Then
            If btnEdit.Text = "Edit" Then
                enableText(True)
                objSchlYr.SchoolyearId = dgvSchoolYear.SelectedRows(0).Cells(0).Value.ToString
                dgvSchoolYear.Enabled = False
                btnAdd.Enabled = False
                btnSetSchlYr.Enabled = False
                btnClose.Enabled = False

                btnEdit.Text = "Update"
                btnRemove.Text = "Cancel"
                txtSchlYrA.Focus()
            ElseIf btnEdit.Text = "Update" Then
                If Not String.IsNullOrWhiteSpace(txtSchlYrA.Text) And txtSchlYrB.TextLength = 4 Then
                    If LibraryDatabase.isExisting("SELECT COUNT(*) FROM schoolyear WHERE schoolyearFrom='" + txtSchlYrA.Text + "' and schoolyearTo='" + txtSchlYrB.Text + "' and schoolyearId!=" + objSchlYr.SchoolyearId.ToString + ";") = False Then
                        objSchlYr.SchoolyearFrom = txtSchlYrA.Text
                        objSchlYr.SchoolyearTo = txtSchlYrB.Text

                        objSchlYr.editSchoolYear()
                        MessageBox.Show("You have successfully updated the school year!", "Updated School Year", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        generateSchoolYr()
                        revertFormSettings()
                    Else
                        MessageBox.Show("School Year already exist!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtSchlYrA.Focus()
                    End If
                Else
                    MessageBox.Show("School Year input is invalid!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtSchlYrA.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If btnRemove.Text = "Remove" Then
            If dgvSchoolYear.RowCount > 0 Then
                'If LibraryDatabase.isExisting("SELECT COUNT(*) FROM register WHERE registerSchoolYearId=" + dgvSchoolYear.SelectedRows(0).Cells(0).Value.ToString + ";") = False Then
                Dim ans As Integer
                ans = MsgBox("Are you sure you want to remove the school year  " + txtSchlYrA.Text + "-" + txtSchlYrB.Text + " from the list?", MsgBoxStyle.YesNo, "Remove School Year")
                If ans = MsgBoxResult.Yes Then
                    objSchlYr.SchoolyearId = dgvSchoolYear.SelectedRows(0).Cells(0).Value.ToString

                    Dim sqlDelete As String
                    sqlDelete = "DELETE FROM schoolyear " & _
                                "WHERE schoolyearId= " + objSchlYr.SchoolyearId.ToString & ";" & _
                                "DELETE FROM semester " & _
                                "WHERE semesterSchoolYearId= " + objSchlYr.SchoolyearId.ToString & ";"

                    LibraryDatabase.execSQL(sqlDelete)

                    'objSchlYr.deleteSchoolYear()
                    MessageBox.Show("You have successfully deleted the school year " + txtSchlYrA.Text + "-" + txtSchlYrB.Text + ".", "Deleted Record")
                    generateSchoolYr()
                    revertFormSettings()
                End If
                'Else
                '    MessageBox.Show("You are not allowed to delete this school year because a record from the borrower is registered to this school year.", "Restriction On Delete", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '    refreshData()
                'End If
            End If
        ElseIf btnRemove.Text = "Cancel" Then
            generateSchoolYr()
            revertFormSettings()
        End If
    End Sub

    Private Sub dgvSchoolYear_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSchoolYear.CellContentClick

    End Sub

    Private Sub dgvSchoolYear_Click(sender As Object, e As EventArgs) Handles dgvSchoolYear.Click
        displaySchlYr()
    End Sub

    Private Sub btnSetSchlYr_Click(sender As Object, e As EventArgs) Handles btnSetSchlYr.Click
        If dgvSchoolYear.RowCount > 0 Then
            Dim ans As Integer
            ans = MsgBox("Set semester under school year: " + txtSchlYrA.Text + "-" + txtSchlYrB.Text + " as current school year?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Set School Year")
            If ans = MsgBoxResult.Yes Then
                ObjSemesterForm = New formSemester
                If ObjSemesterForm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If Not Sem = "" Then
                        ObjMaintenance.MaintenanceSchlYrId = dgvSchoolYear.SelectedRows(0).Cells(0).Value.ToString
                        ObjMaintenance.MaintenanceSchoolYear = dgvSchoolYear.SelectedRows(0).Cells(1).Value.ToString + "-" + dgvSchoolYear.SelectedRows(0).Cells(2).Value.ToString

                        Dim SemId As Integer
                        SemId = LibraryDatabase.fetchSQL("SELECT `semesterId` FROM `semester` WHERE `semesterName`='" + Sem + "' AND `semesterSchoolYearId`=" + ObjMaintenance.MaintenanceSchlYrId.ToString + ";").Tables(0).Rows(0).Item(0)
                        ObjMaintenance.MaintenanceSemester = Sem
                        ObjMaintenance.MaintenanceSemesterId = SemId.ToString

                        ObjMaintenance.editSchoolYr()

                        MessageBox.Show("You have successfully set " + txtSchlYrA.Text + "-" + txtSchlYrB.Text + ", " + Sem + " as your current school year and semester.", "School Year Set")
                        FormLogin.ObjMaintenance.MaintenanceSchlYrId = ObjMaintenance.MaintenanceSchlYrId
                        FormLogin.ObjMaintenance.MaintenanceSchoolYear = ObjMaintenance.MaintenanceSchoolYear
                        FormLogin.ObjMaintenance.MaintenanceSemester = ObjMaintenance.MaintenanceSemester
                        FormLogin.ObjMaintenance.MaintenanceSemesterId = ObjMaintenance.MaintenanceSemesterId
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Dispose()
                    Else
                        MsgBox("HI " + Sem)
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub txtSchlYrA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSchlYrA.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSchlYrA_TextChanged(sender As Object, e As EventArgs) Handles txtSchlYrA.TextChanged
        If btnRemove.Text = "Cancel" Then
            txtSchlYrB.Text = Val(txtSchlYrA.Text) + 1
        End If
    End Sub

    Private Sub txtSchlYrB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSchlYrB.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSchlYrB_TextChanged(sender As Object, e As EventArgs) Handles txtSchlYrB.TextChanged
        If btnRemove.Text = "Cancel" Then
            txtSchlYrA.Text = Val(txtSchlYrB.Text) - 1
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Dispose()
    End Sub
End Class