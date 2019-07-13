Public Class Course
    Private Shared _studentCourseId, _studentCourseDeptId As Integer
    Private Shared _studentCourseName As String

    Public Property StudentCourseId()
        Get
            Return _studentCourseId
        End Get
        Set(value)
            _studentCourseId = value
        End Set
    End Property

    Public Property StudentCourseName()
        Get
            Return _studentCourseName
        End Get
        Set(value)
            _studentCourseName = value
        End Set
    End Property

    Public Property StudentCourseDeptId()
        Get
            Return _studentCourseDeptId
        End Get
        Set(value)
            _studentCourseDeptId = value
        End Set
    End Property

    Public Sub addStudentCourse()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `studentcourse`(`studentCourseId`, `studentCourseDeptId`, `studentCourseName`) VALUES (" & _
                                            StudentCourseId.ToString + "," & _
                                            StudentCourseDeptId.ToString + ",'" & _
                                            StudentCourseName + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editStudentCourse()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `studentcourse` SET " & _
            "`studentCourseName`='" + StudentCourseName & _
            "', `studentCourseDeptId`=" + StudentCourseDeptId.ToString & _
            " WHERE studentCourseId= " + StudentCourseId.ToString & ";"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteStudentCourse()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM studentcourse " & _
                    "WHERE studentCourseId= " + StudentCourseId.ToString & ";"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
