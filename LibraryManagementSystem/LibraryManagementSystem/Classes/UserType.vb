Public Class UserType
    Private Shared _userTypeId As String
    Private Shared _userTypeName, _userTypePrivilege As String

    Public Property UserTypeId()
        Get
            Return _userTypeId
        End Get
        Set(value)
            _userTypeId = value
        End Set
    End Property

    Public Property UserTypeName()
        Get
            Return _userTypeName
        End Get
        Set(value)
            _userTypeName = value
        End Set
    End Property

    Public Property UserTypePrivilege()
        Get
            Return _userTypePrivilege
        End Get
        Set(value)
            _userTypePrivilege = value
        End Set
    End Property

    Public Sub addUserType()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `usertype`(`userTypeId`, `userType`, `userTypePrivilege`) VALUES ('" & _
                                            UserTypeId + "','" & _
                                            UserTypeName + "','" & _
                                            UserTypePrivilege + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editUserType()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `usertype` SET " & _
            "`userType`='" + UserTypeName & _
            "', `userTypePrivilege`='" + UserTypePrivilege & _
            "' WHERE userTypeId='" + UserTypeId & "';"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteUserType()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM usertype " & _
                    "WHERE userTypeId='" + UserTypeId & "';"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
