Public Class FormImportList
    Dim ObjStudentRegistry As New StudentRegistry
    Dim ObjEmployeeRegistry As New EmployeeRegistry
    Private Shared _studentRegistryLevelId, _studentRegistrySectionId, _studentRegistryCourseId, _registryDepartmentId As Integer
    Private Shared _studentRegistryType, _importType As String

    Public Property ImportType
        Get
            Return _importType
        End Get
        Set(value)
            _importType = value
        End Set
    End Property

    Public Property StudentRegistryLevelId
        Get
            Return _studentRegistryLevelId
        End Get
        Set(value)
            _studentRegistryLevelId = value
        End Set
    End Property

    Public Property StudentRegistrySectionId
        Get
            Return _studentRegistrySectionId
        End Get
        Set(value)
            _studentRegistrySectionId = value
        End Set
    End Property

    Public Property StudentRegistryCourseId
        Get
            Return _studentRegistryCourseId
        End Get
        Set(value)
            _studentRegistryCourseId = value
        End Set
    End Property

    Public Property RegistryDepartmentId
        Get
            Return _registryDepartmentId
        End Get
        Set(value)
            _registryDepartmentId = value
        End Set
    End Property

    Public Property StudentRegistryType
        Get
            Return _studentRegistryType
        End Get
        Set(value)
            _studentRegistryType = value
        End Set
    End Property



    Private Sub formImportList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub RenameColumns()
        With dgvBorrower
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = " " 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "Borrower ID"
            .Columns(2).HeaderCell.Value = "Name"
        End With
    End Sub

    Private Sub generateAvailableElem()
        'MsgBox("in generateAvailble Elem")
        Dim ds As DataSet
        Dim sqlFetch As String

        sqlFetch = "SELECT DISTINCT `borrowerId`, `borrowerFirst`, `borrowerMiddle`, `borrowerLast` FROM borrower LEFT JOIN studentregistry " & _
            "ON borrowerId=studentregistryBorrowerId WHERE " & _
            "(studentregistryBorrowerId IS NULL " & _
            "OR (studentRegistrySchoolYearId!=" + FormLogin.ObjMaintenance.MaintenanceSchlYrId + "" & _
            " AND studentRegistryType='ELEM')) AND `borrowerType`='STUDENT';"

        dgvBorrower.Rows.Clear()
        ds = LibraryDatabase.fetchSQL(sqlFetch)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim index As Integer = 0
            While index < ds.Tables(0).Rows.Count
                With dgvBorrower
                    dgvBorrower.Rows.Add(False, _
                                         ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                         ds.Tables(0).Rows(index).Item(3).ToString.Trim + ", " + ds.Tables(0).Rows(index).Item(1).ToString.Trim + " " + ds.Tables(0).Rows(index).Item(2).ToString.Trim)
                End With
                index += 1
            End While
            dgvBorrower.Refresh()
            dgvBorrower.Select()
        Else
            dgvBorrower.Rows.Clear()
        End If
    End Sub
    Private Sub generateAvailableJH()
        Dim ds As DataSet
        Dim sqlFetch As String

        sqlFetch = "SELECT DISTINCT `borrowerId`, `borrowerFirst`, `borrowerMiddle`, `borrowerLast` FROM borrower LEFT JOIN studentregistry " & _
            "ON borrowerId=studentregistryBorrowerId WHERE " & _
            "(studentregistryBorrowerId IS NULL OR (studentRegistrySchoolYearId!=" + FormLogin.ObjMaintenance.MaintenanceSchlYrId + "" & _
            " AND studentRegistryType='JH')) AND `borrowerType`='STUDENT';"

        dgvBorrower.Rows.Clear()
        ds = LibraryDatabase.fetchSQL(sqlFetch)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim index As Integer = 0
            While index < ds.Tables(0).Rows.Count
                With dgvBorrower
                    dgvBorrower.Rows.Add(False, _
                                         ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                         ds.Tables(0).Rows(index).Item(3).ToString.Trim + ", " + ds.Tables(0).Rows(index).Item(1).ToString.Trim + " " + ds.Tables(0).Rows(index).Item(2).ToString.Trim)
                End With
                index += 1
            End While
            dgvBorrower.Refresh()
            dgvBorrower.Select()
        Else
            dgvBorrower.Rows.Clear()
        End If
    End Sub

    Private Sub generateAvailableSH()
        Dim ds As DataSet
        Dim sqlFetch As String
        sqlFetch = "SELECT DISTINCT `borrowerId`, `borrowerFirst`, `borrowerMiddle`, `borrowerLast` FROM borrower LEFT JOIN studentregistry " & _
            "ON borrowerId=studentregistryBorrowerId WHERE " & _
            "(studentregistryBorrowerId IS NULL OR (studentRegistrySemesterId!=" + FormLogin.ObjMaintenance.MaintenanceSemesterId + "" & _
            " AND studentRegistryType='SH')) AND `borrowerType`='STUDENT';"

        dgvBorrower.Rows.Clear()
        ds = LibraryDatabase.fetchSQL(sqlFetch)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim index As Integer = 0
            While index < ds.Tables(0).Rows.Count
                With dgvBorrower
                    dgvBorrower.Rows.Add(False, _
                                         ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                         ds.Tables(0).Rows(index).Item(3).ToString.Trim + ", " + ds.Tables(0).Rows(index).Item(1).ToString.Trim + " " + ds.Tables(0).Rows(index).Item(2).ToString.Trim)
                End With
                index += 1
            End While
            dgvBorrower.Refresh()
            dgvBorrower.Select()
        Else
            dgvBorrower.Rows.Clear()
        End If
    End Sub

    Private Sub generateAvailableCOL()
        Dim ds As DataSet
        Dim sqlFetch As String
        sqlFetch = "SELECT DISTINCT `borrowerId`, `borrowerFirst`, `borrowerMiddle`, `borrowerLast` FROM borrower LEFT JOIN studentregistry " & _
            "ON borrowerId=studentregistryBorrowerId WHERE " & _
            "(studentregistryBorrowerId IS NULL OR (studentRegistrySemesterId!=" + FormLogin.ObjMaintenance.MaintenanceSemesterId + "" & _
            " AND studentRegistryType='COL')) AND `borrowerType`='STUDENT';"

        dgvBorrower.Rows.Clear()
        ds = LibraryDatabase.fetchSQL(sqlFetch)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim index As Integer = 0
            While index < ds.Tables(0).Rows.Count
                With dgvBorrower
                    dgvBorrower.Rows.Add(False, _
                                         ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                         ds.Tables(0).Rows(index).Item(3).ToString.Trim + ", " + ds.Tables(0).Rows(index).Item(1).ToString.Trim + " " + ds.Tables(0).Rows(index).Item(2).ToString.Trim)
                End With
                index += 1
            End While
            dgvBorrower.Refresh()
            dgvBorrower.Select()
        Else
            dgvBorrower.Rows.Clear()
        End If
    End Sub

    Private Sub generateAvailableEmployee()
        Dim ds As DataSet
        Dim sqlFetch As String

        sqlFetch = "SELECT DISTINCT `borrowerId`, `borrowerFirst`, `borrowerMiddle`, `borrowerLast` FROM borrower LEFT JOIN employeeregistry " & _
            "ON borrowerId=employeeRegistryBorrowerId WHERE " & _
            "(employeeRegistryBorrowerId IS NULL OR employeeRegistrySchoolYearId!=" + FormLogin.ObjMaintenance.MaintenanceSchlYrId + "" & _
            ") AND `borrowerType`='SCHOOL EMPLOYEE';"

        dgvBorrower.Rows.Clear()
        ds = LibraryDatabase.fetchSQL(sqlFetch)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim index As Integer = 0
            While index < ds.Tables(0).Rows.Count
                With dgvBorrower
                    dgvBorrower.Rows.Add(False, _
                                         ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                         ds.Tables(0).Rows(index).Item(3).ToString.Trim + ", " + ds.Tables(0).Rows(index).Item(1).ToString.Trim + " " + ds.Tables(0).Rows(index).Item(2).ToString.Trim)
                End With
                index += 1
            End While
            dgvBorrower.Refresh()
            dgvBorrower.Select()
        Else
            dgvBorrower.Rows.Clear()
        End If
    End Sub

    Private Sub loadInformation()
        lblSchoolYear.Text = FormLogin.ObjMaintenance.MaintenanceSchoolYear
        If ImportType = "STUDENT" Then
            If StudentRegistryType = "ELEM" Then
                lblSemester.Visible = False
                lblSemesterLabel.Visible = False
                generateAvailableElem()
            ElseIf StudentRegistryType = "JH" Then
                lblSemester.Visible = False
                lblSemesterLabel.Visible = False
                generateAvailableJH()
            ElseIf StudentRegistryType = "SH" Then
                lblSemester.Text = FormLogin.ObjMaintenance.MaintenanceSemester
                generateAvailableSH()
            ElseIf StudentRegistryType = "COL" Then
                lblSemester.Text = formLogin.ObjMaintenance.MaintenanceSemester
                generateAvailableCOL()
            End If
        ElseIf ImportType = "SCHOOL EMPLOYEE" Then
            lblSemester.Visible = False
            lblSemesterLabel.Visible = False
            generateAvailableEmployee()
        End If
    End Sub

    Private Sub FormImportList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBorrower.Font = New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        RenameColumns()
        loadInformation()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dgvBorrower_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBorrower.CellContentClick
        If e.ColumnIndex = 0 And dgvBorrower.SelectedRows.Count > 0 Then
            If dgvBorrower.SelectedRows(0).Cells(0).Value = False Then
                dgvBorrower.SelectedRows(0).Cells(0).Value = True
            ElseIf dgvBorrower.SelectedRows(0).Cells(0).Value = True Then
                dgvBorrower.SelectedRows(0).Cells(0).Value = False
            End If
        End If
    End Sub

    Private Sub registerStudents()
        Dim id As Integer
        id = LibraryDatabase.GenerateID("SELECT MAX(studentRegistryId) from studentregistry;")
        Dim sqlInsert As String = ""
        For Each row As DataGridViewRow In dgvBorrower.Rows
            If row.Cells(0).Value = True Then

                ObjStudentRegistry.StudentRegistryId = id
                ObjStudentRegistry.StudentRegistryBorrowerId = row.Cells(1).Value.ToString.Trim
                ObjStudentRegistry.StudentRegistrySchoolYearId = FormLogin.ObjMaintenance.MaintenanceSchlYrId
                If StudentRegistryType = "COL" Or StudentRegistryType = "SH" Then
                    ObjStudentRegistry.StudentRegistrySemesterId = FormLogin.ObjMaintenance.MaintenanceSemesterId
                End If
                ObjStudentRegistry.StudentRegistryLevelId = StudentRegistryLevelId
                ObjStudentRegistry.StudentRegistrySectionId = StudentRegistrySectionId
                If StudentRegistryType = "COL" Then
                    'dapat pti senior high plz kase program like stem etc
                    ObjStudentRegistry.StudentRegistryCourseId = StudentRegistryCourseId
                End If
                ObjStudentRegistry.StudentRegistryDepartmentId = RegistryDepartmentId
                ObjStudentRegistry.StudentRegistryType = StudentRegistryType

                sqlInsert += "INSERT INTO `studentregistry`(`studentRegistryId`, `studentRegistryBorrowerId`, `studentRegistrySchoolYearId`, `studentRegistrySemesterId`, `studentRegistryLevelId`, `studentRegistrySectionId`, `studentRegistryCourseId`, `studentRegistryDepartmentId`, `studentRegistryType`) VALUES (" & _
                                            ObjStudentRegistry.StudentRegistryId.ToString + "," & _
                                            ObjStudentRegistry.StudentRegistryBorrowerId.ToString + "," & _
                                            ObjStudentRegistry.StudentRegistrySchoolYearId.ToString + "," & _
                                            ObjStudentRegistry.StudentRegistrySemesterId.ToString + "," & _
                                            ObjStudentRegistry.StudentRegistryLevelId.ToString + "," & _
                                            ObjStudentRegistry.StudentRegistrySectionId.ToString + "," & _
                                            ObjStudentRegistry.StudentRegistryCourseId.ToString + "," & _
                                            ObjStudentRegistry.StudentRegistryDepartmentId.ToString + ",'" & _
                                            ObjStudentRegistry.StudentRegistryType + "');"
                id += 1

            End If
        Next
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Private Sub registerEmployee()
        Dim id As Integer
        id = LibraryDatabase.GenerateID("SELECT MAX(employeeRegistryId) from employeeregistry;")
        Dim sqlInsert As String = ""
        Dim sqlFetch As String = ""
        For Each row2 As DataGridViewRow In dgvBorrower.Rows 'in progress
            If row2.Cells(0).Value = True Then
                sqlFetch += "SELECT DISTINCT "
            End If
        Next

        For Each row As DataGridViewRow In dgvBorrower.Rows
            If row.Cells(0).Value = True Then

                ObjEmployeeRegistry.EmployeeRegistryId = id
                ObjEmployeeRegistry.EmployeeRegistryBorrowerId = row.Cells(1).Value.ToString.Trim
                ObjEmployeeRegistry.EmployeeRegistrySchoolYearId = FormLogin.ObjMaintenance.MaintenanceSchlYrId
                ObjEmployeeRegistry.EmployeeRegistryDepartmentId = _registryDepartmentId

                sqlInsert += "INSERT INTO `employeeregistry`(`employeeRegistryId`, `employeeRegistryBorrowerId`, `employeeRegistryDepartmentId`, `employeeRegistrySchoolYearId`, `employeeRegistryPositionId`) VALUES (" & _
                                            ObjEmployeeRegistry.EmployeeRegistryId.ToString + "," & _
                                            ObjEmployeeRegistry.EmployeeRegistryBorrowerId.ToString + "," & _
                                            ObjEmployeeRegistry.EmployeeRegistryDepartmentId.ToString + "," & _
                                            ObjEmployeeRegistry.EmployeeRegistrySchoolYearId.ToString + ",0);"

                id += 1

            End If
        Next
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If dgvBorrower.RowCount > 0 Then
            Dim countCheck As Integer = 0
            For Each row As DataGridViewRow In dgvBorrower.Rows
                If row.Cells(0).Value = True Then
                    countCheck += 1
                End If
            Next

            If countCheck > 0 Then
                If ImportType = "STUDENT" Then
                    Dim ans As Integer
                    ans = MsgBox("You are about to import " + countCheck.ToString + " student/s to School Year " + FormLogin.ObjMaintenance.MaintenanceSchoolYear + " (" + FormLogin.ObjMaintenance.MaintenanceSemester + "). Proceed?", MsgBoxStyle.YesNo, "Confirm Import")
                    If ans = MsgBoxResult.Yes Then
                        registerStudents()
                        MsgBox("Successfully Imported Borrower/s!.", MsgBoxStyle.Information, "Import Success")
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                ElseIf ImportType = "SCHOOL EMPLOYEE" Then
                    Dim ans As Integer
                    ans = MsgBox("You are about to import " + countCheck.ToString + " employee/s to School Year " + FormLogin.ObjMaintenance.MaintenanceSchoolYear + ". Proceed?", MsgBoxStyle.YesNo, "Confirm Import")
                    If ans = MsgBoxResult.Yes Then
                        registerEmployee()
                        MsgBox("Successfully Imported Borrower/s!.", MsgBoxStyle.Information, "Import Success")
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If
            End If
        End If
    End Sub
End Class