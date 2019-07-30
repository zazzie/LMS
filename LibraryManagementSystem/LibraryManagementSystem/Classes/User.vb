Public Class User
    Private Shared _userBorrowerId, _userTypeId As String
    Private Shared _userPassword, _userRecoveryQuestion As String
    Private Shared _userRecoveryAnswer, _userLoginStatus, _userStatus, _userId As String
    Private Shared _userIdNew As String

    Public Property UserId()
        Get
            Return _userId
        End Get
        Set(value)
            _userId = value
        End Set
    End Property

    Public Property UserIdNew()
        Get
            Return _userIdNew
        End Get
        Set(value)
            _userIdNew = value
        End Set
    End Property

    Public Property UserBorrowerId()
        Get
            Return _userBorrowerId
        End Get
        Set(value)
            _userBorrowerId = value
        End Set
    End Property

    Public Property UserPassword()
        Get
            Return _userPassword
        End Get
        Set(value)
            _userPassword = value
        End Set
    End Property

    Public Property UserTypeId()
        Get
            Return _userTypeId
        End Get
        Set(value)
            _userTypeId = value
        End Set
    End Property

    Public Property UserRecoveryQuestion()
        Get
            Return _userRecoveryQuestion
        End Get
        Set(value)
            _userRecoveryQuestion = value
        End Set
    End Property

    Public Property UserRecoveryAnswer()
        Get
            Return _userRecoveryAnswer
        End Get
        Set(value)
            _userRecoveryAnswer = value
        End Set
    End Property

    Public Property UserLoginStatus()
        Get
            Return _userLoginStatus
        End Get
        Set(value)
            _userLoginStatus = value
        End Set
    End Property

    Public Property UserStatus()
        Get
            Return _userStatus
        End Get
        Set(value)
            _userStatus = value
        End Set
    End Property

    Public Sub addUser()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `user`(`userId`, `userBorrowerId`, `userPassword`, `userTypeId`, `userRecoveryQuestion`, `userRecoveryAnswer`, `userLoginStatus`, `userStatus`) VALUES ('" & _
                                            UserId + "','" & _
                                            UserBorrowerId + "','" & _
                                            UserPassword + "','" & _
                                            UserTypeId + "','" & _
                                            UserRecoveryQuestion + "','" & _
                                            UserRecoveryAnswer + "','" & _
                                            UserLoginStatus + "','" & _
                                            UserStatus + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editUser()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `user` SET " & _
            "`userId`='" + UserIdNew & _
            "',`userBorrowerId`='" + UserBorrowerId & _
            "',`userPassword`='" + UserPassword & _
            "',`userTypeId`='" + UserTypeId & _
            "',`userRecoveryQuestion`='" + UserRecoveryQuestion & _
            "',`userRecoveryAnswer`='" + UserRecoveryAnswer & _
            "' WHERE userId='" + UserId & "';"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteUser()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM user " & _
                    "WHERE userId= '" + UserId & "';"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
