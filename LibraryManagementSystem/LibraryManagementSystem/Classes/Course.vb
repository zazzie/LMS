Public Class Course
    Private Shared _studentCourseId, _studentCourseAbbr As String
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

    Public Property StudentCourseAbbr()
        Get
            Return _studentCourseAbbr
        End Get
        Set(value)
            _studentCourseAbbr = value
        End Set
    End Property

    Public Sub addStudentCourse()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `studentcourse`(`studentCourseId`, `studentCourseAbbr`, `studentCourseName`) VALUES ('" & _
                                            StudentCourseId + "','" & _
                                            StudentCourseAbbr + "','" & _
                                            StudentCourseName + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editStudentCourse()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `studentcourse` SET " & _
            "`studentCourseName`='" + StudentCourseName & _
            "', `studentCourseAbbr`='" + StudentCourseAbbr & _
            "' WHERE studentCourseId='" + StudentCourseId & "';"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteStudentCourse()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM studentcourse " & _
                    "WHERE studentCourseId='" + StudentCourseId & "';"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
