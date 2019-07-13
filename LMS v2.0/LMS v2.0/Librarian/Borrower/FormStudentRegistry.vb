Public Class FormStudentRegistry
    Dim dsLevel As DataSet
    Dim dsSection As DataSet
    Dim dsDept As DataSet
    Dim dsCourse As DataSet
    Dim ObjFormLevelSection As New Form1StudentLevelSection
    Dim ObjFormDepartment As New FormDepartment
    Dim ObjFormCourse As New FormCourse
    Dim ObjStudentRegistry As New StudentRegistry

    Private Sub generateLevel()
        Dim ds As New DataSet
        If rbtElem.Checked = True Then
            Try
                ds = LibraryDatabase.fetchSQL("SELECT DISTINCT `studentLevelId`, `studentLevelName` FROM `studentlevel` WHERE studentLevelClass='ELEM' ORDER BY studentLevelOrder;")
                cboLevel.Items.Clear()
                If ds.Tables(0).Rows.Count > 0 Then
                    dsLevel = New DataSet
                    dsLevel = ds
                    Dim index As Integer = 0
                    While index < ds.Tables(0).Rows.Count
                        With cboLevel
                            .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                        End With
                        index += 1
                    End While
                    cboLevel.Refresh()
                    cboLevel.SelectedIndex = 0
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        ElseIf rbtJH.Checked = True Then
            Try
                ds = LibraryDatabase.fetchSQL("SELECT `studentLevelId`, `studentLevelName` FROM `studentlevel` WHERE studentLevelClass='JH' ORDER BY studentLevelOrder;")
                cboLevel.Items.Clear()
                If ds.Tables(0).Rows.Count > 0 Then
                    dsLevel = New DataSet
                    dsLevel = ds
                    Dim index As Integer = 0
                    While index < ds.Tables(0).Rows.Count
                        With cboLevel
                            .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                        End With
                        index += 1
                    End While
                    cboLevel.Refresh()
                    cboLevel.SelectedIndex = 0
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        ElseIf rbtSH.Checked = True Then
            Try
                ds = LibraryDatabase.fetchSQL("SELECT DISTINCT `studentLevelId`, `studentLevelName` FROM `studentlevel` WHERE studentLevelClass='SH' ORDER BY studentLevelOrder;")
                cboLevel.Items.Clear()
                If ds.Tables(0).Rows.Count > 0 Then
                    dsLevel = New DataSet
                    dsLevel = ds
                    Dim index As Integer = 0
                    While index < ds.Tables(0).Rows.Count
                        With cboLevel
                            .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                        End With
                        index += 1
                    End While
                    cboLevel.Refresh()
                    cboLevel.SelectedIndex = 0
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        ElseIf rbtCol.Checked = True Then
            Try
                ds = LibraryDatabase.fetchSQL("SELECT DISTINCT `studentLevelId`, `studentLevelName` FROM `studentlevel` WHERE studentLevelClass='COL' ORDER BY studentLevelOrder;")
                cboLevel.Items.Clear()
                If ds.Tables(0).Rows.Count > 0 Then
                    dsLevel = New DataSet
                    dsLevel = ds
                    Dim index As Integer = 0
                    While index < ds.Tables(0).Rows.Count
                        With cboLevel
                            .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                        End With
                        index += 1
                    End While
                    cboLevel.Refresh()
                    cboLevel.SelectedIndex = 0
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub

    Private Sub generateSection()
        cboSection.Items.Clear()
        If Not cboLevel.Text = "" Then
            Try
                Dim ds As DataSet
                Dim cbolevelIndex As Integer = cboLevel.SelectedIndex
                'MsgBox(cbolevelIndex.ToString)
                'MsgBox(dsLevel.Tables(0).Rows(cbolevelIndex).Item(0).ToString.Trim + "-level id")
                ds = LibraryDatabase.fetchSQL("SELECT DISTINCT `studentSectionId`, `studentSectionName`, `studentSectionLevelId` FROM `studentsection` WHERE studentSectionLevelId=" + dsLevel.Tables(0).Rows(cbolevelIndex).Item(0).ToString.Trim + " ORDER BY studentSectionName ASC ;")

                If ds.Tables(0).Rows.Count > 0 Then
                    dsSection = New DataSet
                    dsSection = ds
                    Dim index As Integer = 0
                    While index < ds.Tables(0).Rows.Count
                        With cboSection
                            .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                        End With
                        index += 1
                    End While
                    cboSection.Refresh()
                    cboSection.SelectedIndex = 0
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub

    Private Sub generateDepartment()
        cboDepartment.Items.Clear()
        Try
            Dim level As String = ""
            If rbtCol.Checked = True Then
                level = "COL"
            ElseIf rbtSH.Checked = True Then
                level = "SH"
            ElseIf rbtJH.Checked = True Then
                level = "JH"
            ElseIf rbtElem.Checked = True Then
                level = "ELEM"
            End If
            '
            '
            Dim ds As DataSet
            ds = LibraryDatabase.fetchSQL("SELECT DISTINCT `departmentId`, `departmentName` FROM `department` WHERE `departmentLevel`='" + level + "' ORDER BY departmentName ASC;")
            If ds.Tables(0).Rows.Count > 0 Then
                dsDept = New DataSet
                dsDept = ds
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With cboDepartment
                        .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                    End With
                    index += 1
                End While
                cboDepartment.Refresh()
                cboDepartment.SelectedIndex = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub generateCourse()
        cboCourse.Items.Clear()
        Try
            Dim ds As DataSet
            ds = LibraryDatabase.fetchSQL("SELECT `studentCourseId`, `studentCourseName` FROM `studentcourse` ORDER BY studentCourseName ASC;")
            If ds.Tables(0).Rows.Count > 0 Then
                dsCourse = New DataSet
                dsCourse = ds
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With cboCourse
                        .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                    End With
                    index += 1
                End While
                cboCourse.Refresh()
                cboCourse.SelectedIndex = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    ' ''' <summary>
    ' ''' '''''''''''''''''''AAADDDDDDDDDDD
    ' ''' </summary>
    ' ''' <remarks></remarks>

    Private Sub addCollege()
        If Not String.IsNullOrWhiteSpace(cboLevel.Text) Then
            If Not String.IsNullOrWhiteSpace(cboSection.Text) Then
                If Not String.IsNullOrWhiteSpace(cboDepartment.Text) Then
                    If Not String.IsNullOrWhiteSpace(cboCourse.Text) Then
                        ''add
                        Dim cboLevelIndex As Integer = cboLevel.SelectedIndex
                        Dim cboSectionIndex As Integer = cboSection.SelectedIndex
                        Dim cboDeptIndex As Integer = cboDepartment.SelectedIndex
                        Dim cboCourseIndex As Integer = cboCourse.SelectedIndex

                        ObjStudentRegistry.StudentRegistryId = LibraryDatabase.GenerateID("SELECT MAX(studentRegistryId) from studentregistry;")
                        ObjStudentRegistry.StudentRegistryBorrowerId = Val(lblBorrowerId.Text)
                        ObjStudentRegistry.StudentRegistrySchoolYearId = Val(FormLogin.ObjMaintenance.MaintenanceSchlYrId.ToString)
                        ObjStudentRegistry.StudentRegistrySemesterId = Val(FormLogin.ObjMaintenance.MaintenanceSemesterId.ToString)
                        ObjStudentRegistry.StudentRegistryLevelId = Val(dsLevel.Tables(0).Rows(cboLevelIndex).Item(0).ToString)
                        ObjStudentRegistry.StudentRegistrySectionId = Val(dsSection.Tables(0).Rows(cboSectionIndex).Item(0).ToString)
                        ObjStudentRegistry.StudentRegistryCourseId = Val(dsCourse.Tables(0).Rows(cboCourseIndex).Item(0).ToString)
                        ObjStudentRegistry.StudentRegistryDepartmentId = Val(dsDept.Tables(0).Rows(cboDeptIndex).Item(0).ToString)
                        ObjStudentRegistry.StudentRegistryType = "COL"

                        ObjStudentRegistry.addStudentRegistry()
                        MessageBox.Show("You have successfully registered " + lblName.Text + "!", "Successfully Registered", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        'Me.Dispose()
                    Else
                        MessageBox.Show("Course Name is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Deaprtment Name is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Section Name is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Level Name is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub addSenoirHigh()
        If Not String.IsNullOrWhiteSpace(cboLevel.Text) Then
            If Not String.IsNullOrWhiteSpace(cboSection.Text) Then
                If Not String.IsNullOrWhiteSpace(cboDepartment.Text) Then
                    ''add
                    Dim cboLevelIndex As Integer = cboLevel.SelectedIndex
                    Dim cboSectionIndex As Integer = cboSection.SelectedIndex
                    Dim cboDeptIndex As Integer = cboDepartment.SelectedIndex

                    ObjStudentRegistry.StudentRegistryId = LibraryDatabase.GenerateID("SELECT MAX(studentRegistryId) from studentregistry;")
                    ObjStudentRegistry.StudentRegistryBorrowerId = Val(lblBorrowerId.Text)
                    ObjStudentRegistry.StudentRegistrySchoolYearId = Val(FormLogin.ObjMaintenance.MaintenanceSchlYrId.ToString)
                    ObjStudentRegistry.StudentRegistrySemesterId = Val(FormLogin.ObjMaintenance.MaintenanceSemesterId.ToString)
                    ObjStudentRegistry.StudentRegistryLevelId = Val(dsLevel.Tables(0).Rows(cboLevelIndex).Item(0).ToString)
                    ObjStudentRegistry.StudentRegistrySectionId = Val(dsSection.Tables(0).Rows(cboSectionIndex).Item(0).ToString)
                    ObjStudentRegistry.StudentRegistryDepartmentId = Val(dsDept.Tables(0).Rows(cboDeptIndex).Item(0).ToString)
                    ObjStudentRegistry.StudentRegistryType = "SH"

                    ObjStudentRegistry.addStudentRegistry()
                    MessageBox.Show("You have successfully registered " + lblName.Text + "!", "Successfully Registered", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    'Me.Dispose()
                Else
                    MessageBox.Show("Deaprtment Name is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Section Name is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Level Name is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub addJuniorHigh()
        If Not String.IsNullOrWhiteSpace(cboLevel.Text) Then
            If Not String.IsNullOrWhiteSpace(cboSection.Text) Then
                If Not String.IsNullOrWhiteSpace(cboDepartment.Text) Then
                    ''add
                    Dim cboLevelIndex As Integer = cboLevel.SelectedIndex
                    Dim cboSectionIndex As Integer = cboSection.SelectedIndex
                    Dim cboDeptIndex As Integer = cboDepartment.SelectedIndex

                    ObjStudentRegistry.StudentRegistryId = LibraryDatabase.GenerateID("SELECT MAX(studentRegistryId) from studentregistry;")
                    ObjStudentRegistry.StudentRegistryBorrowerId = Val(lblBorrowerId.Text)
                    ObjStudentRegistry.StudentRegistrySchoolYearId = Val(FormLogin.ObjMaintenance.MaintenanceSchlYrId.ToString)
                    'ObjStudentRegistry.StudentRegistrySemesterId = Val(formBorrowerLogin.ObjMaintenance.MaintenanceSemesterId.ToString)
                    ObjStudentRegistry.StudentRegistryLevelId = Val(dsLevel.Tables(0).Rows(cboLevelIndex).Item(0).ToString)
                    ObjStudentRegistry.StudentRegistrySectionId = Val(dsSection.Tables(0).Rows(cboSectionIndex).Item(0).ToString)
                    ObjStudentRegistry.StudentRegistryDepartmentId = Val(dsDept.Tables(0).Rows(cboDeptIndex).Item(0).ToString)
                    ObjStudentRegistry.StudentRegistryType = "JH"

                    ObjStudentRegistry.addStudentRegistry()
                    MessageBox.Show("You have successfully registered " + lblName.Text + "!", "Successfully Registered", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    'Me.Dispose()
                Else
                    MessageBox.Show("Deaprtment Name is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Section Name is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Level Name is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub addElementary()
        If Not String.IsNullOrWhiteSpace(cboLevel.Text) Then
            If Not String.IsNullOrWhiteSpace(cboSection.Text) Then
                If Not String.IsNullOrWhiteSpace(cboDepartment.Text) Then
                    ''add
                    Dim cboLevelIndex As Integer = cboLevel.SelectedIndex
                    Dim cboSectionIndex As Integer = cboSection.SelectedIndex
                    Dim cboDeptIndex As Integer = cboDepartment.SelectedIndex

                    ObjStudentRegistry.StudentRegistryId = LibraryDatabase.GenerateID("SELECT MAX(studentRegistryId) from studentregistry;")
                    ObjStudentRegistry.StudentRegistryBorrowerId = Val(lblBorrowerId.Text)
                    ObjStudentRegistry.StudentRegistrySchoolYearId = Val(FormLogin.ObjMaintenance.MaintenanceSchlYrId.ToString)
                    ObjStudentRegistry.StudentRegistrySemesterId = Val(FormLogin.ObjMaintenance.MaintenanceSemesterId.ToString)
                    ObjStudentRegistry.StudentRegistryLevelId = Val(dsLevel.Tables(0).Rows(cboLevelIndex).Item(0).ToString)
                    ObjStudentRegistry.StudentRegistrySectionId = Val(dsSection.Tables(0).Rows(cboSectionIndex).Item(0).ToString)
                    'MsgBox(cboDeptIndex.ToString)
                    ObjStudentRegistry.StudentRegistryDepartmentId = Val(dsDept.Tables(0).Rows(cboDeptIndex).Item(0).ToString)
                    ObjStudentRegistry.StudentRegistryType = "ELEM"

                    ObjStudentRegistry.addStudentRegistry()
                    MessageBox.Show("You have successfully registered " + lblName.Text + "!", "Successfully Registered", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    'Me.Dispose()
                Else
                    MessageBox.Show("Deaprtment Name is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Section Name is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Level Name is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub displayComboboxes()
        If rbtElem.Checked = True Then
            btnDept.Visible = False
            cboDepartment.Enabled = False
            btnDept.Enabled = False
            lblSemester.Visible = False
            lblSemesterLabel.Visible = False
            lblCourse.Visible = False
            cboCourse.Visible = False
            btnCourse.Visible = False

            cboDepartment.Text = "ELEMENTARY"
        ElseIf rbtJH.Checked = True Then
            btnDept.Visible = False
            cboDepartment.Enabled = False
            btnDept.Enabled = False
            lblSemester.Visible = False
            lblSemesterLabel.Visible = False
            lblCourse.Visible = False
            cboCourse.Visible = False
            btnCourse.Visible = False

            cboDepartment.Text = "JUNIOR HIGH"
        ElseIf rbtSH.Checked = True Then
            cboDepartment.Enabled = True
            btnDept.Enabled = True
            lblSemester.Visible = True
            lblSemesterLabel.Visible = True
            cboDepartment.Visible = True
            btnDept.Visible = True
            lblCourse.Visible = False
            cboCourse.Visible = False
            btnCourse.Visible = False
        ElseIf rbtCol.Checked = True Then
            btnDept.Visible = True
            lblCourse.Visible = True
            cboCourse.Visible = True
            btnCourse.Visible = True
            lblSemester.Visible = True
            lblSemesterLabel.Visible = True
            cboDepartment.Enabled = True
            btnDept.Enabled = True
        End If
    End Sub
    Private Sub displayUponLoad()
        generateLevel()
        generateSection()
        generateDepartment()
        generateCourse()
        displayComboboxes()
    End Sub
    Private Sub formStudentRegistry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayUponLoad()
    End Sub

    Private Sub btnLevelSection_Click(sender As Object, e As EventArgs) Handles btnLevelSection.Click
        ObjFormLevelSection = New Form1StudentLevelSection
        If ObjFormLevelSection.ShowDialog = Windows.Forms.DialogResult.OK Then
            generateLevel()
            generateSection()
        End If
    End Sub

    Private Sub btnDept_Click(sender As Object, e As EventArgs) Handles btnDept.Click
        ObjFormDepartment = New formDepartment
        If ObjFormDepartment.ShowDialog = Windows.Forms.DialogResult.OK Then
            generateDepartment()
        End If
    End Sub

    Private Sub btnCourse_Click(sender As Object, e As EventArgs) Handles btnCourse.Click
        ObjFormCourse = New formCourse
        If ObjFormCourse.ShowDialog = Windows.Forms.DialogResult.OK Then
            generateCourse()
        End If
    End Sub

    Private Sub rbtElem_CheckedChanged(sender As Object, e As EventArgs) Handles rbtElem.CheckedChanged
        generateLevel()
        generateSection()
        displayComboboxes()
        generateDepartment()
    End Sub

    Private Sub rbtJH_CheckedChanged(sender As Object, e As EventArgs) Handles rbtJH.CheckedChanged
        generateLevel()
        generateSection()
        displayComboboxes()
        generateDepartment()
    End Sub

    Private Sub rbtSH_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSH.CheckedChanged
        generateLevel()
        generateSection()
        displayComboboxes()
        generateDepartment()
    End Sub

    Private Sub rbtCol_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCol.CheckedChanged
        generateLevel()
        generateSection()
        displayComboboxes()
        generateDepartment()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ObjStudentRegistry = New StudentRegistry
        If rbtElem.Checked = True Then
            addElementary()
        ElseIf rbtJH.Checked = True Then
            addJuniorHigh()
        ElseIf rbtSH.Checked = True Then
            addSenoirHigh()
        ElseIf rbtCol.Checked = True Then
            addCollege()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cboLevel_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboLevel.SelectedValueChanged
        generateSection()
    End Sub

    'Private Sub cboLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLevel.SelectedIndexChanged
    '    Try
    '        generateSection()
    '    Catch ex As Exception

    '    End Try
    'End Sub
End Class