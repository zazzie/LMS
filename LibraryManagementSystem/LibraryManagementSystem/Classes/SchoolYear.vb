Public Class SchoolYear
    Private Shared _schoolyearId As String
    Private Shared _schoolyearFrom, _schoolyearTo As String

    Public Property SchoolyearId()
        Get
            Return _schoolyearId
        End Get
        Set(value)
            _schoolyearId = value
        End Set
    End Property

    Public Property SchoolyearFrom()
        Get
            Return _schoolyearFrom
        End Get
        Set(value)
            _schoolyearFrom = value
        End Set
    End Property

    Public Property SchoolyearTo()
        Get
            Return _schoolyearTo
        End Get
        Set(value)
            _schoolyearTo = value
        End Set
    End Property

    Public Sub addSchoolYear()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `schoolyear`(`schoolyearId`, `schoolyearFrom`, `schoolyearTo`) VALUES ('" & _
                                            SchoolyearId + "','" & _
                                            SchoolyearFrom + "','" & _
                                            SchoolyearTo + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editSchoolYear()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `schoolyear` SET " & _
            "`schoolyearFrom`='" + SchoolyearFrom & _
            "',`schoolyearTo`='" + SchoolyearTo & _
            "' WHERE schoolyearId='" + SchoolyearId & "';"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteSchoolYear()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM schoolyear " & _
                    "WHERE schoolyearId='" + SchoolyearId & "';"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
