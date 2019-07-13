Public Class StudentRegistry
    Private Shared _studentRegistryId, _studentRegistryBorrowerId, _studentRegistrySchoolYearId As Integer
    Private Shared _studentRegistrySemesterId, _studentRegistryLevelId, _studentRegistrySectionId As Integer
    Private Shared _studentRegistryCourseId, _studentRegistryDepartmentId As Integer
    Private Shared _studentRegistryType As String

    Public Property StudentRegistryId()
        Get
            Return _studentRegistryId
        End Get
        Set(value)
            _studentRegistryId = value
        End Set
    End Property

    Public Property StudentRegistryBorrowerId()
        Get
            Return _studentRegistryBorrowerId
        End Get
        Set(value)
            _studentRegistryBorrowerId = value
        End Set
    End Property

    Public Property StudentRegistrySchoolYearId()
        Get
            Return _studentRegistrySchoolYearId
        End Get
        Set(value)
            _studentRegistrySchoolYearId = value
        End Set
    End Property

    Public Property StudentRegistrySemesterId()
        Get
            Return _studentRegistrySemesterId
        End Get
        Set(value)
            _studentRegistrySemesterId = value
        End Set
    End Property

    Public Property StudentRegistryLevelId()
        Get
            Return _studentRegistryLevelId
        End Get
        Set(value)
            _studentRegistryLevelId = value
        End Set
    End Property

    Public Property StudentRegistrySectionId()
        Get
            Return _studentRegistrySectionId
        End Get
        Set(value)
            _studentRegistrySectionId = value
        End Set
    End Property

    Public Property StudentRegistryCourseId()
        Get
            Return _studentRegistryCourseId
        End Get
        Set(value)
            _studentRegistryCourseId = value
        End Set
    End Property

    Public Property StudentRegistryDepartmentId()
        Get
            Return _studentRegistryDepartmentId
        End Get
        Set(value)
            _studentRegistryDepartmentId = value
        End Set
    End Property

    Public Property StudentRegistryType()
        Get
            Return _studentRegistryType
        End Get
        Set(value)
            _studentRegistryType = value
        End Set
    End Property

    Public Sub addStudentRegistry()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `studentregistry`(`studentRegistryId`, `studentRegistryBorrowerId`, `studentRegistrySchoolYearId`, `studentRegistrySemesterId`, `studentRegistryLevelId`, `studentRegistrySectionId`, `studentRegistryCourseId`, `studentRegistryDepartmentId`, `studentRegistryType`) VALUES (" & _
                                            StudentRegistryId.ToString + "," & _
                                            StudentRegistryBorrowerId.ToString + "," & _
                                            StudentRegistrySchoolYearId.ToString + "," & _
                                            StudentRegistrySemesterId.ToString + "," & _
                                            StudentRegistryLevelId.ToString + "," & _
                                            StudentRegistrySectionId.ToString + "," & _
                                            StudentRegistryCourseId.ToString + "," & _
                                            StudentRegistryDepartmentId.ToString + ",'" & _
                                            StudentRegistryType + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editStudentRegistry()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `studentregistry` SET " & _
            "`studentRegistryBorrowerId`=" + StudentRegistryBorrowerId.ToString & _
            ",`studentRegistrySchoolYearId`=" + StudentRegistrySchoolYearId.ToString & _
            ",`studentRegistrySemesterId`=" + StudentRegistrySemesterId.ToString & _
            ",`studentRegistryLevelId`=" + StudentRegistryLevelId.ToString & _
            ",`studentRegistrySectionId`=" + StudentRegistrySectionId.ToString & _
            ",`studentRegistryCourseId`=" + StudentRegistryCourseId.ToString & _
            ",`studentRegistryDepartmentId`=" + StudentRegistryDepartmentId.ToString & _
            ",`studentRegistryType`='" + StudentRegistryType & _
            "' WHERE studentRegistryId= " + StudentRegistryId.ToString & ";"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteStudentRegistry()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM studentregistry " & _
                    "WHERE studentRegistryId= " + StudentRegistryId.ToString & ";"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub

End Class