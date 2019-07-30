Public Class StudentRegistry
    Private Shared _studentRegistryId, _studentRegistryBorrowerId, _studentRegistrySchoolYearId As String
    Private Shared _studentRegistrySemesterId, _studentRegistryLevelId, _studentRegistrySectionId As String
    Private Shared _studentRegistryCourseId As String

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

    Public Sub addStudentRegistry()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `studentregistry`(`studentRegistryId`, `studentRegistryBorrowerId`, `studentRegistrySchoolYearId`, `studentRegistrySemesterId`, `studentRegistryLevelId`, `studentRegistrySectionId`, `studentRegistryCourseId`) VALUES ('" & _
                                            StudentRegistryId + "','" & _
                                            StudentRegistryBorrowerId + "','" & _
                                            StudentRegistrySchoolYearId + "','" & _
                                            StudentRegistrySemesterId + "','" & _
                                            StudentRegistryLevelId + "','" & _
                                            StudentRegistrySectionId + "','" & _
                                            StudentRegistryCourseId + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editStudentRegistry()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `studentregistry` SET " & _
            "`studentRegistryBorrowerId`='" + StudentRegistryBorrowerId & _
            "',`studentRegistrySchoolYearId`='" + StudentRegistrySchoolYearId & _
            "',`studentRegistrySemesterId`='" + StudentRegistrySemesterId & _
            "',`studentRegistryLevelId`='" + StudentRegistryLevelId & _
            "',`studentRegistrySectionId`='" + StudentRegistrySectionId & _
            "',`studentRegistryCourseId`='" + StudentRegistryCourseId & _
            "' WHERE studentRegistryId='" + StudentRegistryId & "';"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteStudentRegistry()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM studentregistry " & _
                    "WHERE studentRegistryId='" + StudentRegistryId & "';"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub

End Class