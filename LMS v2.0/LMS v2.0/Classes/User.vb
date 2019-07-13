Public Class User
    Private Shared _userId, _userBorrowerId As Integer
    Private Shared _userName, _userPassword, _userType, _userRecoveryQuestion As String
    Private Shared _userRecoveryAnswer, _userLoginStatus, _userStatus As String

    Public Property UserId()
        Get
            Return _userId
        End Get
        Set(value)
            _userId = value
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

    Public Property UserName()
        Get
            Return _userName
        End Get
        Set(value)
            _userName = value
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

    Public Property UserType()
        Get
            Return _userType
        End Get
        Set(value)
            _userType = value
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
        sqlInsert = "INSERT INTO `user`(`userId`, `userBorrowerId`, `userName`, `userPassword`, `userType`, `userRecoveryQuestion`, `userRecoveryAnswer`, `userLoginStatus`, `userStatus`) VALUES (" & _
                                            UserId.ToString + "," & _
                                            UserBorrowerId.ToString + ",'" & _
                                            UserName + "','" & _
                                            UserPassword + "','" & _
                                            UserType + "','" & _
                                            UserRecoveryQuestion + "','" & _
                                            UserRecoveryAnswer + "','" & _
                                            UserLoginStatus + "','" & _
                                            UserStatus + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editUser()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `user` SET " & _
            "`userBorrowerId`=" + UserBorrowerId.ToString & _
            ",`userName`='" + UserName & _
            "',`userPassword`='" + UserPassword & _
            "',`userType`='" + UserType & _
            "',`userRecoveryQuestion`='" + UserRecoveryQuestion & _
            "',`userRecoveryAnswer`='" + UserRecoveryAnswer & _
            "',`userLoginStatus`='" + UserLoginStatus & _
            "',`userStatus`='" + UserStatus & _
            "' WHERE userId= " + UserId.ToString & ";"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteUser()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM user " & _
                    "WHERE userId= " + UserId.ToString & ";"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
