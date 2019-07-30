Public Class StudentSection
    Private Shared _studentSectionId, _studentSectionLevelId, _studentSectionCourseId As Integer
    Private Shared _studentSectionName, _studentSectionStatus As String

    Public Property StudentSectionId()
        Get
            Return _studentSectionId
        End Get
        Set(value)
            _studentSectionId = value
        End Set
    End Property

    Public Property StudentSectionCourseId()
        Get
            Return _studentSectionCourseId
        End Get
        Set(value)
            _studentSectionCourseId = value
        End Set
    End Property

    Public Property StudentSectionStatus()
        Get
            Return _studentSectionStatus
        End Get
        Set(value)
            _studentSectionStatus = value
        End Set
    End Property

    Public Property StudentSectionLevelId()
        Get
            Return _studentSectionLevelId
        End Get
        Set(value)
            _studentSectionLevelId = value
        End Set
    End Property

    Public Property StudentSectionName()
        Get
            Return _studentSectionName
        End Get
        Set(value)
            _studentSectionName = value
        End Set
    End Property

    Public Sub addStudentSection()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `studentsection`(`studentSectionId`, `studentSectionName`, `studentSectionLevelId`, `studentSectionCourseId`, `studentSectionStatus`) VALUES ('" & _
                                            StudentSectionId + "','" & _
                                            StudentSectionName + "','" & _
                                            StudentSectionLevelId + "','" & _
                                            StudentSectionCourseId + "','" & _
                                            StudentSectionStatus + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editStudentSection()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `studentsection` SET " & _
            "`studentSectionName`='" + StudentSectionName & _
            "',`studentSectionLevelId`='" + StudentSectionLevelId & _
            "',`studentSectionStatus`='" + StudentSectionStatus & _
            "',`studentSectionCourseId`='" + StudentSectionCourseId & _
            "' WHERE studentSectionId='" + StudentSectionId & "';"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteStudentSection()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM studentsection " & _
                    "WHERE studentSectionId='" + StudentSectionId & "';"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
