Public Class FormViewBorrower
    Public viewformBorrowerId As Integer
    Dim dsRegistry As DataSet
    Dim objFormStudentRegistry As New FormStudentRegistry
    Dim objFormEmployeeRegistry As New FormEmployeeRegistry
    Dim objStudentRegistry As New StudentRegistry
    Dim objEmployeeRegistry As New EmployeeRegistry

    Private Function isRegisteredSchlYr() As Boolean
        Dim index As Integer = 0
        While index < dgvRegistry.Rows.Count
            If FormLogin.ObjMaintenance.MaintenanceSchlYrId = dsRegistry.Tables(0).Rows(index).Item(2).ToString.Trim Then
                Return True
                Exit While
            End If
            index += 1
        End While
        Return False
    End Function

    Private Function isRegisteredSchlYrEmployee() As Boolean
        Dim index As Integer = 0
        While index < dgvRegistry.Rows.Count
            If FormLogin.ObjMaintenance.MaintenanceSchlYrId = dsRegistry.Tables(0).Rows(index).Item(4).ToString.Trim Then
                Return True
                Exit While
            End If
            index += 1
        End While
        Return False
    End Function

    Private Function isRegisteredSemester() As Boolean
        Dim index As Integer = 0
        While index < dgvRegistry.Rows.Count
            If FormLogin.ObjMaintenance.MaintenanceSemesterId = dsRegistry.Tables(0).Rows(index).Item(12).ToString.Trim Then
                Return True
                Exit While
            End If
            index += 1
        End While
        Return False
    End Function

    Private Function latestRegId() As Integer
        Try
            Dim maxRegId As Integer = LibraryDatabase.fetchSQL("SELECT MAX(studentRegistryId) FROM studentregistry " & _
                                                               "WHERE studentRegistryBorrowerId=" + lblBorrowerId.Text + ";").Tables(0).Rows(0).Item(0)
            Return maxRegId
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return Nothing
        End Try
    End Function

    Private Function studentType() As String
        Dim index As Integer = 0
        Dim _studentType As String = "NONE"
        'MsgBox("inside student ttype fn")
        Dim ds As DataSet
        ds = LibraryDatabase.fetchSQL("SELECT * FROM studentregistry WHERE studentRegistryBorrowerId=" + lblBorrowerId.Text + ";")
        While index < ds.Tables(0).Rows.Count
            'MsgBox(latestRegId().ToString + "=" + ds.Tables(0).Rows(index).Item(0).ToString)
            If latestRegId() = ds.Tables(0).Rows(index).Item(0) Then
                _studentType = ds.Tables(0).Rows(index).Item(8).ToString.Trim
                Exit While
            End If
            index += 1
        End While
        Return _studentType
    End Function

    Private Sub displayCollegeRegistry()
        lblDepartment.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(11).ToString.Trim
        lblLevel.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(9).ToString.Trim
        lblSection.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(10).ToString.Trim
        lblCourse.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(15).ToString.Trim
        lblSchoolYear.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(7).ToString.Trim + "-" + dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(8).ToString.Trim
        lblSemester.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(13).ToString.Trim
        lblCourse.Visible = True
        lblCourseLabel.Visible = True
        lblSemester.Visible = True
        lblSemesterLabel.Visible = True
    End Sub
    Private Sub displaySeniorHighRegistry()
        lblDepartment.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(11).ToString.Trim
        lblLevel.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(9).ToString.Trim
        lblSection.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(10).ToString.Trim
        'lblCourse.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(15).ToString.Trim
        lblSchoolYear.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(7).ToString.Trim + "-" + dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(8).ToString.Trim
        lblSemester.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(13).ToString.Trim
        lblCourse.Visible = False
        lblCourseLabel.Visible = False
        lblSemester.Visible = True
        lblSemesterLabel.Visible = True
    End Sub
    Private Sub displayElemJuniorRegistry()
        lblDepartment.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(11).ToString.Trim
        lblLevel.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(9).ToString.Trim
        lblSection.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(10).ToString.Trim
        'lblCourse.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(15).ToString.Trim
        lblSchoolYear.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(7).ToString.Trim + "-" + dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(8).ToString.Trim
        'lblSemester.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(13).ToString.Trim
        lblCourse.Visible = False
        lblCourseLabel.Visible = False
        lblSemester.Visible = False
        lblSemesterLabel.Visible = False
    End Sub
    Private Sub displayEmployeeRegistry()
        'SELECT 0`employeeRegistryId`, 1`employeeRegistryBorrowerId`, 2`employeeRegistryPosition`, 3 employeeRegistryDepartmentId
        '``, 4`employeeRegistrySchoolYearId` 5 departmentName  6 schoolyearFrom  7 schoolyearTo 8 namepos

        labelSECTION.Visible = False
        LabelLEVEL.Visible = False
        labelEMPSCHLYR.Visible = True
        labelPOSITION.Visible = True
        lblDepartment.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(5).ToString.Trim
        lblLevel.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(8).ToString.Trim
        lblSection.Text = dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(6).ToString.Trim + "-" + dsRegistry.Tables(0).Rows(dgvRegistry.CurrentCell.RowIndex).Item(7).ToString.Trim

        LabelSCHOOLYEAR.Visible = False
        lblSchoolYear.Visible = False
        lblCourse.Visible = False
        lblCourseLabel.Visible = False
        lblSemester.Visible = False
        lblSemesterLabel.Visible = False
    End Sub
    Private Sub emptyEmployeeRegistryDisplay()
        labelSECTION.Visible = False
        LabelLEVEL.Visible = False
        labelEMPSCHLYR.Visible = True
        labelPOSITION.Visible = True
        lblDepartment.Text = ""
        lblLevel.Text = ""
        lblSection.Text = ""
        lblCourse.Text = ""
        lblSchoolYear.Text = ""
        lblSemester.Text = ""
        LabelSCHOOLYEAR.Visible = False
        lblSchoolYear.Visible = False
        lblCourse.Visible = False
        lblCourseLabel.Visible = False
        lblSemester.Visible = False
        lblSemesterLabel.Visible = False
    End Sub
    Private Sub emptyStudentRegistryDisplay()
        lblDepartment.Text = ""
        lblLevel.Text = ""
        lblSection.Text = ""
        lblCourse.Text = ""
        lblSchoolYear.Text = ""
        lblSemester.Text = ""
    End Sub

    Private Sub renameColumnsStudent()
        With dgvRegistry
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Registration ID" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "School Year"
            .Columns(2).HeaderCell.Value = "Semester"
        End With
    End Sub

    Private Sub renameColumnsEmployee()
        With dgvRegistry
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Registration ID" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "School Year"
            .Columns(2).HeaderCell.Value = ""
        End With
    End Sub

    Private Sub generateCollegeStudentRegistry()
        Dim sqlFetch As String
        '"SELECT DISTINCT (0)studentRegistryId, (1)studentRegistryBorrowerId, (2)studentRegistrySchoolYearId, (3)studentRegistryLevelId, " & _
        '    "(4)studentRegistrySectionId, (5)studentRegistryDepartmentId, (6)studentRegistryType, " & _
        '    " (7)schoolyearFrom, (8)schoolyearTo, (9)studentLevelName, (10)studentSectionName, (11)departmentName, " & _
        '    "(12)studentRegistrySemesterId, (13)semesterName, (14)studentRegistryCourseId, (15)studentCourseName" & _
        '    "FROM studentregistry,schoolyear,semester,studentlevel,studentsection,studentcourse,department " & _

        dgvRegistry.Rows.Clear()
        sqlFetch = "SELECT DISTINCT studentRegistryId, studentRegistryBorrowerId, studentRegistrySchoolYearId, " & _
            "studentRegistryLevelId, studentRegistrySectionId, studentRegistryDepartmentId, studentRegistryType, " & _
            "schoolyearFrom, schoolyearTo, studentLevelName, studentSectionName, departmentName, studentRegistrySemesterId, " & _
            "semesterName, studentRegistryCourseId, studentCourseName FROM studentregistry,schoolyear,semester," & _
            "studentlevel,studentsection,studentcourse,department WHERE studentRegistryBorrowerId=" + lblBorrowerId.Text + " AND " & _
            "schoolyearId=studentRegistrySchoolYearId AND semesterId=studentRegistrySemesterId AND studentSectionId=studentRegistrySectionId " & _
            "AND studentLevelId=studentRegistryLevelId AND studentCourseId=studentRegistryCourseId AND " & _
            "departmentId=studentRegistryDepartmentId AND studentRegistryType='COL';"

        Dim ds As DataSet
        ds = LibraryDatabase.fetchSQL(sqlFetch)
        If ds.Tables(0).Rows.Count > 0 Then
            'MsgBox("in ds")
            dsRegistry = ds
            Dim index As Integer = 0
            While index < ds.Tables(0).Rows.Count
                With dgvRegistry
                    .Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                         ds.Tables(0).Rows(index).Item(7).ToString.Trim + "-" + ds.Tables(0).Rows(index).Item(8).ToString.Trim, _
                                         ds.Tables(0).Rows(index).Item(13).ToString.Trim)
                End With
                index += 1
            End While
            dgvRegistry.Refresh()
            dgvRegistry.Select()
            displayCollegeRegistry()
        Else
            'MsgBox("out ds")
            dgvRegistry.Rows.Clear()
            emptyStudentRegistryDisplay()
        End If
    End Sub

    Private Sub generateSHStudentRegistry()
        Dim sqlFetch As String
        '"SELECT DISTINCT (0)studentRegistryId, (1)studentRegistryBorrowerId, (2)studentRegistrySchoolYearId, (3)studentRegistryLevelId, " & _
        '    "(4)studentRegistrySectionId, (5)studentRegistryDepartmentId, (6)studentRegistryType, " & _
        '    " (7)schoolyearFrom, (8)schoolyearTo, (9)studentLevelName, (10)studentSectionName, (11)departmentName, " & _
        '    "(12)studentRegistrySemesterId, (13)semesterName " & _
        '    "FROM studentregistry,schoolyear,semester,studentlevel,studentsection,department " & _

        dgvRegistry.Rows.Clear()
        sqlFetch = "SELECT DISTINCT studentRegistryId, studentRegistryBorrowerId, studentRegistrySchoolYearId, studentRegistryLevelId, " & _
            "studentRegistrySectionId, studentRegistryDepartmentId, studentRegistryType, " & _
            " schoolyearFrom, schoolyearTo, studentLevelName, studentSectionName, departmentName, " & _
            "studentRegistrySemesterId, semesterName " & _
            "FROM studentregistry,schoolyear,semester,studentlevel,studentsection,department " & _
            "WHERE studentRegistryBorrowerId=" + lblBorrowerId.Text + " AND " & _
            "schoolyearId=studentRegistrySchoolYearId AND " & _
            "semesterId=studentRegistrySemesterId AND " & _
            "studentSectionId=studentRegistrySectionId AND " & _
            "studentLevelId=studentRegistryLevelId AND " & _
            "departmentId=studentRegistryDepartmentId AND studentRegistryType='SH';"

        Dim ds As DataSet
        ds = LibraryDatabase.fetchSQL(sqlFetch)
        If ds.Tables(0).Rows.Count > 0 Then
            'MsgBox("in ds")
            dsRegistry = ds
            Dim index As Integer = 0
            While index < ds.Tables(0).Rows.Count
                With dgvRegistry
                    .Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                         ds.Tables(0).Rows(index).Item(7).ToString.Trim + "-" + ds.Tables(0).Rows(index).Item(8).ToString.Trim, _
                                         ds.Tables(0).Rows(index).Item(13).ToString.Trim)
                End With
                index += 1
            End While
            dgvRegistry.Refresh()
            dgvRegistry.Select()
            displaySeniorHighRegistry()
        Else
            'MsgBox("out ds")
            dgvRegistry.Rows.Clear()
            emptyStudentRegistryDisplay()
        End If
    End Sub

    Private Sub generateELEMJHStudentRegistry()
        Dim sqlFetch As String
        '"SELECT DISTINCT (0)studentRegistryId, (1)studentRegistryBorrowerId, (2)studentRegistrySchoolYearId, (3)studentRegistryLevelId, " & _
        '    "(4)studentRegistrySectionId, (5)studentRegistryDepartmentId, (6)studentRegistryType, " & _
        '    " (7)schoolyearFrom, (8)schoolyearTo, (9)studentLevelName, (10)studentSectionName, (11)departmentName, " & _
        '

        dgvRegistry.Rows.Clear()
        sqlFetch = "SELECT DISTINCT studentRegistryId, studentRegistryBorrowerId, studentRegistrySchoolYearId, studentRegistryLevelId, " & _
            "studentRegistrySectionId, studentRegistryDepartmentId, studentRegistryType, " & _
            " schoolyearFrom, schoolyearTo, studentLevelName, studentSectionName, departmentName " & _
            "FROM studentregistry,schoolyear,studentlevel,studentsection,department " & _
            "WHERE studentRegistryBorrowerId=" + lblBorrowerId.Text + " AND " & _
            "schoolyearId=studentRegistrySchoolYearId AND " & _
            "studentSectionId=studentRegistrySectionId AND " & _
            "studentLevelId=studentRegistryLevelId AND " & _
            "departmentId=studentRegistryDepartmentId AND (studentRegistryType='ELEM' OR studentRegistryType='JH');"

        Dim ds As DataSet
        ds = LibraryDatabase.fetchSQL(sqlFetch)
        If ds.Tables(0).Rows.Count > 0 Then
            'MsgBox("in ds")
            dsRegistry = ds
            Dim index As Integer = 0
            While index < ds.Tables(0).Rows.Count
                With dgvRegistry
                    .Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                         ds.Tables(0).Rows(index).Item(7).ToString.Trim + "-" + ds.Tables(0).Rows(index).Item(8).ToString.Trim, _
                                         "")
                End With
                index += 1
            End While
            dgvRegistry.Refresh()
            dgvRegistry.Select()
            displayElemJuniorRegistry()
        Else
            'MsgBox("out ds")
            dgvRegistry.Rows.Clear()
            emptyStudentRegistryDisplay()
        End If
    End Sub

    Private Sub generateStudentRegistry()
        Dim count As Integer
        Try
            count = LibraryDatabase.fetchSQL("SELECT COUNT(studentRegistryId) FROM studentregistry WHERE " & _
                                         "studentRegistryBorrowerId=" + lblBorrowerId.Text + ";").Tables(0).Rows(0).Item(0)

            If count = 0 Then
                dgvRegistry.Rows.Clear()
                emptyStudentRegistryDisplay()
            Else
                Dim type As String = studentType()
                If type = "COL" Then
                    generateCollegeStudentRegistry()
                ElseIf type = "SH" Then
                    generateSHStudentRegistry()
                ElseIf type = "ELEM" Or type = "JH" Then
                    generateELEMJHStudentRegistry()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


    End Sub

    Private Sub generateEmployeeRegistry()
        'SELECT 0`employeeRegistryId`, 1`employeeRegistryBorrowerId`, 2`employeeRegistryPositionId`, 3 employeeRegistryDepartmentId
        '``, 4`employeeRegistrySchoolYearId` 5 departmentName  6 schoolyearFrom  7 schoolyearTo 8 employeepositionName
        Dim sqlFetch As String
        dgvRegistry.Rows.Clear()
        sqlFetch = "SELECT DISTINCT employeeRegistryId, employeeRegistryBorrowerId, employeeRegistryPositionId, employeeRegistryDepartmentId, " & _
            "employeeRegistrySchoolYearId, departmentName, schoolyearFrom, schoolyearTo, employeepositionName FROM employeeregistry " & _
            "JOIN department ON employeeRegistryDepartmentId=departmentId " & _
            "JOIN schoolyear ON employeeRegistrySchoolYearId=schoolyearId " & _
            "JOIN employeeposition ON employeepositionId=employeeRegistryPositionId " & _
            "WHERE employeeRegistryBorrowerId=" + lblBorrowerId.Text + ";"

        Dim ds As DataSet
        ds = LibraryDatabase.fetchSQL(sqlFetch)
        If ds.Tables(0).Rows.Count > 0 Then
            dsRegistry = ds
            Dim index As Integer = 0
            While index < ds.Tables(0).Rows.Count
                With dgvRegistry
                    .Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                         ds.Tables(0).Rows(index).Item(6).ToString.Trim + "-" + ds.Tables(0).Rows(index).Item(7).ToString.Trim, _
                                         "")
                End With
                index += 1
            End While
            dgvRegistry.Refresh()
            dgvRegistry.Select()
            displayEmployeeRegistry()
        Else
            'MsgBox("out ds")
            dgvRegistry.Rows.Clear()
            emptyEmployeeRegistryDisplay()
        End If
    End Sub

    Private Sub generateBorrowerInformation()
        Try
            Dim sqlFetch As String
            sqlFetch = "SELECT * FROM `borrower` WHERE borrowerId =" + viewformBorrowerId.ToString + ";"
            Dim ds As DataSet
            Dim birth As Date
            ds = LibraryDatabase.fetchSQL(sqlFetch)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim city, brgy As String
                Try

                    city = LibraryDatabase.fetchSQL("SELECT `cityName` FROM `city` WHERE cityId=" + ds.Tables(0).Rows(0).Item(9).ToString.Trim + ";").Tables(0).Rows(0).Item(0).ToString
                    brgy = LibraryDatabase.fetchSQL("SELECT `barangayName` FROM `barangay`  WHERE `barangayId`=" + ds.Tables(0).Rows(0).Item(8).ToString.Trim + " AND `barangayCityId`=" + ds.Tables(0).Rows(0).Item(9).ToString.Trim + ";").Tables(0).Rows(0).Item(0).ToString
                Catch ex As Exception
                    city = ""
                    brgy = ""
                End Try


                lblBorrowerId.Text = ds.Tables(0).Rows(0).Item(0).ToString.Trim
                lblFirst.Text = ds.Tables(0).Rows(0).Item(1).ToString.Trim
                lblMiddle.Text = ds.Tables(0).Rows(0).Item(2).ToString.Trim
                lblLast.Text = ds.Tables(0).Rows(0).Item(3).ToString.Trim
                lblGender.Text = ds.Tables(0).Rows(0).Item(4).ToString.Trim
                lblPhone.Text = ds.Tables(0).Rows(0).Item(6).ToString.Trim
                lblBorrowerType.Text = ds.Tables(0).Rows(0).Item(10).ToString.Trim
                lblBirth.Text = ds.Tables(0).Rows(0).Item(5).ToString.Trim
                birth = DateTime.Parse(ds.Tables(0).Rows(0).Item(5).ToString.Trim)
                lblAge.Text = DateDiff(DateInterval.Year, birth, Now).ToString
                lblAddress.Text = ds.Tables(0).Rows(0).Item(7).ToString.Trim + " " + brgy + ", " + city
                picBorrowerPhoto.BackgroundImage = Base64ToImage(ds.Tables(0).Rows(0).Item(11).ToString.Trim)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub formSettingViewBorrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvRegistry.Font = New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        generateBorrowerInformation()
        'MsgBox(lblBorrowerId.Text)
        If lblBorrowerType.Text = "STUDENT" Then
            generateStudentRegistry()
            renameColumnsStudent()
        ElseIf lblBorrowerType.Text = "SCHOOL EMPLOYEE" Then
            generateEmployeeRegistry()
            renameColumnsEmployee()
        End If

    End Sub

    Private Sub picBorrowerPhoto_LostFocus(sender As Object, e As EventArgs) Handles picBorrowerPhoto.LostFocus
        picBorrowerPhoto.BackgroundImageLayout = ImageLayout.Stretch
    End Sub



    Private Sub btnAddToCurrentSY_Click(sender As Object, e As EventArgs) Handles btnAddToCurrentSY.Click
        If lblBorrowerType.Text = "STUDENT" Then
            If dgvRegistry.Rows.Count = 0 Then
                objFormStudentRegistry = New FormStudentRegistry
                objFormStudentRegistry.lblBorrowerId.Text = lblBorrowerId.Text
                objFormStudentRegistry.lblName.Text = lblLast.Text + ", " + lblFirst.Text + " " + lblMiddle.Text
                objFormStudentRegistry.lblSchoolYear.Text = FormLogin.ObjMaintenance.MaintenanceSchoolYear
                objFormStudentRegistry.lblSemester.Text = FormLogin.ObjMaintenance.MaintenanceSemester
                objFormStudentRegistry.rbtElem.Checked = True
                If objFormStudentRegistry.ShowDialog = Windows.Forms.DialogResult.OK Then
                    generateStudentRegistry()
                End If
            Else
                Dim type As String = studentType()
                If Not String.IsNullOrWhiteSpace(dgvRegistry.SelectedRows(0).Cells(2).Value.ToString) Then
                    If isRegisteredSemester() = False Then
                        objFormStudentRegistry = New FormStudentRegistry
                        objFormStudentRegistry.lblBorrowerId.Text = lblBorrowerId.Text
                        objFormStudentRegistry.lblName.Text = lblLast.Text + ", " + lblFirst.Text + " " + lblMiddle.Text
                        objFormStudentRegistry.lblSchoolYear.Text = FormLogin.ObjMaintenance.MaintenanceSchoolYear
                        objFormStudentRegistry.lblSemester.Text = FormLogin.ObjMaintenance.MaintenanceSemester
                        objFormStudentRegistry.rbtElem.Checked = True
                        If objFormStudentRegistry.ShowDialog = Windows.Forms.DialogResult.OK Then
                            generateStudentRegistry()
                        End If
                    Else
                        MessageBox.Show(lblFirst.Text + " " + lblLast.Text + " is already registered from " & _
                                        "the current School Semester!", "Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    If isRegisteredSchlYr() = False Then
                        objFormStudentRegistry = New FormStudentRegistry
                        objFormStudentRegistry.lblBorrowerId.Text = lblBorrowerId.Text
                        objFormStudentRegistry.lblName.Text = lblLast.Text + ", " + lblFirst.Text + " " + lblMiddle.Text
                        objFormStudentRegistry.lblSchoolYear.Text = FormLogin.ObjMaintenance.MaintenanceSchoolYear
                        objFormStudentRegistry.lblSemester.Text = ""
                        If objFormStudentRegistry.ShowDialog = Windows.Forms.DialogResult.OK Then
                            generateStudentRegistry()
                        End If
                    Else
                        MessageBox.Show(lblFirst.Text + " " + lblLast.Text + " is already registered from " & _
                                        "the current School Year!", "Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        ElseIf lblBorrowerType.Text = "SCHOOL EMPLOYEE" Then
            If dgvRegistry.Rows.Count = 0 Then
                objFormEmployeeRegistry = New FormEmployeeRegistry
                objFormEmployeeRegistry.lblBorrowerId.Text = lblBorrowerId.Text
                objFormEmployeeRegistry.lblName.Text = lblLast.Text + ", " + lblFirst.Text + " " + lblMiddle.Text
                objFormEmployeeRegistry.lblSchoolYear.Text = FormLogin.ObjMaintenance.MaintenanceSchoolYear
                If objFormEmployeeRegistry.ShowDialog = Windows.Forms.DialogResult.OK Then
                    generateEmployeeRegistry()
                End If
            Else

                If isRegisteredSchlYrEmployee() = False Then
                    objFormEmployeeRegistry = New FormEmployeeRegistry
                    objFormEmployeeRegistry.lblBorrowerId.Text = lblBorrowerId.Text
                    objFormEmployeeRegistry.lblName.Text = lblLast.Text + ", " + lblFirst.Text + " " + lblMiddle.Text
                    objFormEmployeeRegistry.lblSchoolYear.Text = FormLogin.ObjMaintenance.MaintenanceSchoolYear
                    If objFormEmployeeRegistry.ShowDialog = Windows.Forms.DialogResult.OK Then
                        generateEmployeeRegistry()
                    End If
                Else
                    MessageBox.Show(lblFirst.Text + " " + lblLast.Text + " is already registered from " & _
                                    "the current School Year!", "Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

    End Sub

    Private Sub dgvRegistry_Click(sender As Object, e As EventArgs) Handles dgvRegistry.Click
        If dgvRegistry.Rows.Count > 0 Then
            Dim type As String = studentType()
            If type = "COL" Then
                displayCollegeRegistry()
            ElseIf type = "SH" Then
                displaySeniorHighRegistry()
            ElseIf type = "ELEM" Or type = "JH" Then
                displayElemJuniorRegistry()
            End If
        End If
    End Sub

    Private Sub dgvRegistry_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnRemoveRegistry_Click(sender As Object, e As EventArgs) Handles btnRemoveRegistry.Click
        If dgvRegistry.Rows.Count > 0 Then
            Dim ans As Integer
            ans = MsgBox("Are you sure you want to remove selected registration record?", MsgBoxStyle.YesNo, "Remove Record")
            If ans = MsgBoxResult.Yes Then

                If lblBorrowerType.Text = "STUDENT" Then
                    objStudentRegistry.StudentRegistryId = dgvRegistry.SelectedRows(0).Cells(0).Value
                    objStudentRegistry.deleteStudentRegistry()
                    MessageBox.Show("You have successfully deleted a registration record of " + lblFirst.Text + " " + lblLast.Text + " from the list.", "Deleted Record")
                    generateStudentRegistry()
                ElseIf lblBorrowerType.Text = "SCHOOL EMPLOYEE" Then
                    objEmployeeRegistry.EmployeeRegistryId = dgvRegistry.SelectedRows(0).Cells(0).Value
                    objEmployeeRegistry.deleteEmployeeRegistry()
                    MessageBox.Show("You have successfully deleted a registration record of " + lblFirst.Text + " " + lblLast.Text + " from the list.", "Deleted Record")
                    generateEmployeeRegistry()
                End If
                
            End If
        End If
    End Sub
End Class