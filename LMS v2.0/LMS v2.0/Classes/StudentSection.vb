Public Class StudentSection
    Private Shared _studentSectionId, _studentSectionLevelId As Integer
    Private Shared _studentSectionName, _studentSectionStatus As String

    Public Property StudentSectionId()
        Get
            Return _studentSectionId
        End Get
        Set(value)
            _studentSectionId = value
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
        sqlInsert = "INSERT INTO `studentsection`(`studentSectionId`, `studentSectionName`, `studentSectionLevelId`, `studentSectionStatus`) VALUES (" & _
                                            StudentSectionId.ToString + ",'" & _
                                            StudentSectionName + "'," & _
                                            StudentSectionLevelId.ToString + ",'" & _
                                            StudentSectionStatus + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editStudentSection()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `studentsection` SET " & _
            "`studentSectionName`='" + StudentSectionName & _
            "',`studentSectionLevelId`=" + StudentSectionLevelId.ToString & _
            ",`studentSectionStatus`='" + StudentSectionStatus & _
            "' WHERE studentSectionId= " + StudentSectionId.ToString & ";"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteStudentSection()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM studentsection " & _
                    "WHERE studentSectionId= " + StudentSectionId.ToString & ";"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
