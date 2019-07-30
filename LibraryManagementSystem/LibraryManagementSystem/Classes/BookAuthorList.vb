Public Class BookAuthorList
    Private Shared _bookAuthorListId, _bookAuthorListBookId, _bookAuthorListAuthorId As String

    Public Property BookAuthorListId()
        Get
            Return _bookAuthorListId
        End Get
        Set(value)
            _bookAuthorListId = value
        End Set
    End Property

    Public Property BookAuthorListBookId()
        Get
            Return _bookAuthorListBookId
        End Get
        Set(value)
            _bookAuthorListBookId = value
        End Set
    End Property

    Public Property BookAuthorListAuthorId()
        Get
            Return _bookAuthorListAuthorId
        End Get
        Set(value)
            _bookAuthorListAuthorId = value
        End Set
    End Property

    Public Sub addBookAuthorList()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `bookauthorlist`(`bookAuthorListId`, `bookAuthorListBookId`, `bookAuthorListAuthorId`) VALUES ('" & _
                                            BookAuthorListId + "','" & _
                                            BookAuthorListBookId + "','" & _
                                            BookAuthorListAuthorId + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editBookAuthorList()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `bookauthorlist` SET " & _
            "`bookAuthorListBookId`='" + BookAuthorListBookId & _
            "',`bookAuthorListAuthorId`='" + BookAuthorListAuthorId & _
            "' WHERE bookAuthorListId= '" + BookAuthorListId & "';"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteBookAuthorList()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM bookauthorlist " & _
                    "WHERE bookAuthorListBookId= '" + BookAuthorListBookId & "';"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
