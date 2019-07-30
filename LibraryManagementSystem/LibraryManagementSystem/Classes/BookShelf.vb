Public Class BookShelf
    Private Shared _bookshelfId As String
    Private Shared _bookshelfName As String

    Public Property BookshelfId()
        Get
            Return _bookshelfId
        End Get
        Set(value)
            _bookshelfId = value
        End Set
    End Property

    Public Property BookshelfName()
        Get
            Return _bookshelfName
        End Get
        Set(value)
            _bookshelfName = value
        End Set
    End Property

    Public Sub addBookShelf()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `bookshelf`(`bookshelfId`, `bookshelfName`) VALUES ('" & _
                                            BookshelfId + "','" & _
                                            BookshelfName + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editBookShelf()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `bookshelf` SET " & _
            "`bookshelfName`='" + BookshelfName & _
            "' WHERE bookshelfId= '" + BookshelfId & "';"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteBookShelf()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM bookshelfsection " & _
                    "WHERE bookShelfSectionBookShelfId= '" + BookshelfId + "';" & _
                    "DELETE FROM bookshelf " & _
                    "WHERE bookshelfId= '" + BookshelfId & "';"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
