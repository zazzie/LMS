Public Class FormImportFill
    Dim dsLevel As DataSet
    Dim dsSection As DataSet
    Dim dsDept As DataSet
    Dim dsEmpDept As DataSet
    Dim dsCourse As DataSet
    Dim objFormImportList As New formImportList


    Private Sub revertFormSettings()
        rbtStudent.Checked = True
        rbtSchoolEmployee.Checked = False
        rbtElem.Checked = True
        pnlStudent.Enabled = True
        pnlSchoolEmployee.Enabled = False
    End Sub

    Private Sub generateStudentLevel()
        Dim ds As New DataSet
        If rbtElem.Checked = True Then
            Try
                ds = LibraryDatabase.fetchSQL("SELECT DISTINCT `studentLevelId`, `studentLevelName` FROM `studentlevel` WHERE studentLevelClass='ELEM' ORDER BY studentLevelOrder;")
                cboToLevel.Items.Clear()
                If ds.Tables(0).Rows.Count > 0 Then
                    dsLevel = New DataSet
                    dsLevel = ds
                    Dim index As Integer = 0
                    While index < ds.Tables(0).Rows.Count
                        With cboToLevel
                            .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                        End With
                        index += 1
                    End While
                    cboToLevel.Refresh()
                    cboToLevel.Text = ds.Tables(0).Rows(0).Item(1).ToString
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        ElseIf rbtJH.Checked = True Then
            Try
                ds = LibraryDatabase.fetchSQL("SELECT `studentLevelId`, `studentLevelName` FROM `studentlevel` WHERE studentLevelClass='JH' ORDER BY studentLevelOrder;")
                cboToLevel.Items.Clear()
                If ds.Tables(0).Rows.Count > 0 Then
                    dsLevel = New DataSet
                    dsLevel = ds
                    Dim index As Integer = 0
                    While index < ds.Tables(0).Rows.Count
                        With cboToLevel
                            .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                        End With
                        index += 1
                    End While
                    cboToLevel.Refresh()
                    cboToLevel.Text = ds.Tables(0).Rows(0).Item(1).ToString
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        ElseIf rbtSH.Checked = True Then
            Try
                ds = LibraryDatabase.fetchSQL("SELECT DISTINCT `studentLevelId`, `studentLevelName` FROM `studentlevel` WHERE studentLevelClass='SH' ORDER BY studentLevelOrder;")
                cboToLevel.Items.Clear()
                If ds.Tables(0).Rows.Count > 0 Then
                    dsLevel = New DataSet
                    dsLevel = ds
                    Dim index As Integer = 0
                    While index < ds.Tables(0).Rows.Count
                        With cboToLevel
                            .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                        End With
                        index += 1
                    End While
                    cboToLevel.Refresh()
                    cboToLevel.Text = ds.Tables(0).Rows(0).Item(1).ToString
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        ElseIf rbtCol.Checked = True Then
            Try
                ds = LibraryDatabase.fetchSQL("SELECT DISTINCT `studentLevelId`, `studentLevelName` FROM `studentlevel` WHERE studentLevelClass='COL' ORDER BY studentLevelOrder;")
                cboToLevel.Items.Clear()
                If ds.Tables(0).Rows.Count > 0 Then
                    dsLevel = New DataSet
                    dsLevel = ds
                    Dim index As Integer = 0
                    While index < ds.Tables(0).Rows.Count
                        With cboToLevel
                            .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                        End With
                        index += 1
                    End While
                    cboToLevel.Refresh()
                    cboToLevel.Text = ds.Tables(0).Rows(0).Item(1).ToString
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub

    Private Sub generateStudentSection()
        cboSection.Items.Clear()
        If Not cboToLevel.Text = "" Then
            Try
                Dim ds As DataSet
                Dim cbolevelIndex As Integer = cboToLevel.SelectedIndex
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
                    cboSection.Text = ds.Tables(0).Rows(0).Item(1).ToString
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub

    Private Sub generateStudentDepartment()
        cboStudentDepartment.Items.Clear()
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
                    With cboStudentDepartment
                        .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                    End With
                    index += 1
                End While
                cboStudentDepartment.Refresh()
                cboStudentDepartment.Text = ds.Tables(0).Rows(0).Item(1).ToString
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub generateEmployeeDepartment()
        cboEmployeeDept.Items.Clear()
        Try
            Dim ds As DataSet
            ds = LibraryDatabase.fetchSQL("SELECT DISTINCT `departmentId`, `departmentName` FROM `department` ORDER BY departmentName ASC;")
            If ds.Tables(0).Rows.Count > 0 Then
                dsEmpDept = New DataSet
                dsEmpDept = ds
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With cboEmployeeDept
                        .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                    End With
                    index += 1
                End While
                cboEmployeeDept.Refresh()
                cboEmployeeDept.Text = ds.Tables(0).Rows(0).Item(1).ToString
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub generateStudentCourse()
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
                cboCourse.Text = ds.Tables(0).Rows(0).Item(1).ToString
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub displayComboboxes()
        If rbtElem.Checked = True Then
            lblCourse.Visible = False
            cboCourse.Visible = False

        ElseIf rbtJH.Checked = True Then
            lblCourse.Visible = False
            cboCourse.Visible = False

        ElseIf rbtSH.Checked = True Then
            lblCourse.Visible = False
            cboCourse.Visible = False

        ElseIf rbtCol.Checked = True Then
            lblCourse.Visible = True
            cboCourse.Visible = True

        End If
    End Sub



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub rbtStudent_CheckedChanged(sender As Object, e As EventArgs) Handles rbtStudent.CheckedChanged
        If rbtStudent.Checked = True Then
            pnlStudent.Enabled = True
            pnlSchoolEmployee.Enabled = False
        End If
    End Sub

    Private Sub rbtSchoolEmployee_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSchoolEmployee.CheckedChanged
        If rbtSchoolEmployee.Checked = True Then
            pnlStudent.Enabled = False
            pnlSchoolEmployee.Enabled = True
        End If
    End Sub

    Private Sub formImportFill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        revertFormSettings()
        displayComboboxes()
        generateStudentLevel()
        generateStudentSection()
        generateStudentDepartment()
        generateStudentCourse()
        generateEmployeeDepartment()
    End Sub

    Private Sub rbtElem_CheckedChanged(sender As Object, e As EventArgs) Handles rbtElem.CheckedChanged
        generateStudentLevel()
        generateStudentSection()
        generateStudentDepartment()
        displayComboboxes()
    End Sub

    Private Sub rbtJH_CheckedChanged(sender As Object, e As EventArgs) Handles rbtJH.CheckedChanged
        generateStudentLevel()
        generateStudentSection()
        generateStudentDepartment()
        displayComboboxes()
    End Sub

    Private Sub rbtSH_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSH.CheckedChanged
        generateStudentLevel()
        generateStudentSection()
        generateStudentDepartment()
        displayComboboxes()
    End Sub

    Private Sub rbtCol_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCol.CheckedChanged
        generateStudentLevel()
        generateStudentSection()
        generateStudentDepartment()
        displayComboboxes()
    End Sub

    Private Sub btnViewImportList_Click(sender As Object, e As EventArgs) Handles btnViewImportList.Click
        If rbtStudent.Checked = True Then
            If Not String.IsNullOrWhiteSpace(cboToLevel.Text) Then
                If Not String.IsNullOrWhiteSpace(cboSection.Text) Then
                    If Not String.IsNullOrWhiteSpace(cboStudentDepartment.Text) Then
                        If Not String.IsNullOrWhiteSpace(cboCourse.Text) Then

                            objFormImportList = New formImportList

                            Dim cboLevelIndex As Integer = cboToLevel.SelectedIndex
                            Dim cboSectionIndex As Integer = cboSection.SelectedIndex
                            Dim cboDeptIndex As Integer = cboStudentDepartment.SelectedIndex
                            Dim cboCourseIndex As Integer = cboCourse.SelectedIndex

                            objFormImportList.StudentRegistryLevelId = Val(dsLevel.Tables(0).Rows(cboLevelIndex).Item(0).ToString)
                            objFormImportList.StudentRegistrySectionId = Val(dsSection.Tables(0).Rows(cboSectionIndex).Item(0).ToString)
                            objFormImportList.StudentRegistryCourseId = Val(dsCourse.Tables(0).Rows(cboCourseIndex).Item(0).ToString)
                            objFormImportList.RegistryDepartmentId = Val(dsDept.Tables(0).Rows(cboDeptIndex).Item(0).ToString)

                            If rbtElem.Checked = True Then
                                objFormImportList.StudentRegistryType = "ELEM"
                            ElseIf rbtJH.Checked = True Then
                                objFormImportList.StudentRegistryType = "JH"
                            ElseIf rbtSH.Checked = True Then
                                objFormImportList.StudentRegistryType = "SH"
                            ElseIf rbtCol.Checked = True Then
                                objFormImportList.StudentRegistryType = "COL"
                            End If

                            objFormImportList.ImportType = "STUDENT"

                            objFormImportList.ShowDialog()
                            If objFormImportList.DialogResult = Windows.Forms.DialogResult.OK Then
                                Me.DialogResult = Windows.Forms.DialogResult.OK
                            ElseIf objFormImportList.DialogResult = Windows.Forms.DialogResult.Cancel Then
                                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                            End If

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
        ElseIf rbtSchoolEmployee.Checked = True Then
            If Not String.IsNullOrWhiteSpace(cboEmployeeDept.Text) Then
                objFormImportList = New formImportList

                Dim cboDeptIndex As Integer = cboEmployeeDept.SelectedIndex
                objFormImportList.RegistryDepartmentId = Val(dsEmpDept.Tables(0).Rows(cboDeptIndex).Item(0).ToString)

                objFormImportList.ImportType = "SCHOOL EMPLOYEE"
                objFormImportList.ShowDialog()
                If objFormImportList.DialogResult = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                ElseIf objFormImportList.DialogResult = Windows.Forms.DialogResult.Cancel Then
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                End If
            Else
                MessageBox.Show("Deaprtment Name is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class