Public Class StudentLevel
    Private Shared _studentLevelId, _studentLevelOrder As Integer
    Private Shared _studentLevelName, _studentLevelClass As String

    Public Property StudentLevelId()
        Get
            Return _studentLevelId
        End Get
        Set(value)
            _studentLevelId = value
        End Set
    End Property

    Public Property StudentLevelOrder()
        Get
            Return _studentLevelOrder
        End Get
        Set(value)
            _studentLevelOrder = value
        End Set
    End Property

    Public Property StudentLevelClass()
        Get
            Return _studentLevelClass
        End Get
        Set(value)
            _studentLevelClass = value
        End Set
    End Property

    Public Property StudentLevelName()
        Get
            Return _studentLevelName
        End Get
        Set(value)
            _studentLevelName = value
        End Set
    End Property

    Public Sub addStudentLevel()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `studentlevel`(`studentLevelId`, `studentLevelName`, `studentLevelOrder`, `studentLevelClass`) VALUES (" & _
                                            StudentLevelId.ToString + ",'" & _
                                            StudentLevelName + "'," & _
                                            StudentLevelOrder.ToString + ",'" & _
                                            StudentLevelClass + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editStudentLevel()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `studentlevel` SET " & _
            "`studentLevelName`='" + StudentLevelName & _
            "',`studentLevelOrder`=" + StudentLevelOrder.ToString & _
            ",`studentLevelClass`='" + StudentLevelClass & _
            "' WHERE studentLevelId= " + StudentLevelId.ToString & ";"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteStudentLevel()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM studentlevel " & _
                    "WHERE studentLevelId= " + StudentLevelId.ToString & ";"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
