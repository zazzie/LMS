Public Class Semester
    Private Shared _semesterId, _semesterSchoolYearId As Integer
    Private Shared _semesterName As String

    Public Property SemesterId()
        Get
            Return _semesterId
        End Get
        Set(value)
            _semesterId = value
        End Set
    End Property

    Public Property SemesterSchoolYearId()
        Get
            Return _semesterSchoolYearId
        End Get
        Set(value)
            _semesterSchoolYearId = value
        End Set
    End Property

    Public Property SemesterName()
        Get
            Return _semesterName
        End Get
        Set(value)
            _semesterName = value
        End Set
    End Property

    Public Sub addSemester()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `semester`(`semesterId`, `semesterName`, `semesterSchoolYearId`) VALUES (" & _
                                            SemesterId.ToString + ",'" & _
                                            SemesterName + "'," & _
                                            SemesterSchoolYearId.ToString + ");"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editSemester()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `semester` SET " & _
            "`semesterName`='" + SemesterName & _
            "',`semesterSchoolYearId`=" + SemesterSchoolYearId.ToString & _
            " WHERE semesterId= " + SemesterId.ToString & ";"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteSemester()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM semester " & _
                    "WHERE semesterId= " + SemesterId.ToString & ";"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
