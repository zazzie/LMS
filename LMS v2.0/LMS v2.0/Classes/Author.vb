Public Class Author
    Private Shared _authorId As Integer
    Private Shared _authorFirst, _authorMiddle, _authorLast As String

    Public Property AuthorId()
        Get
            Return _authorId
        End Get
        Set(value)
            _authorId = value
        End Set
    End Property

    Public Property AuthorFirst()
        Get
            Return _authorFirst
        End Get
        Set(value)
            _authorFirst = value
        End Set
    End Property

    Public Property AuthorMiddle()
        Get
            Return _authorMiddle
        End Get
        Set(value)
            _authorMiddle = value
        End Set
    End Property

    Public Property AuthorLast()
        Get
            Return _authorLast
        End Get
        Set(value)
            _authorLast = value
        End Set
    End Property

    Public Sub addAuthor()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `author`(`authorId`, `authorFirst`, `authorMiddle`, `authorLast`) VALUES (" & _
                                            AuthorId.ToString + ",'" & _
                                            AuthorFirst + "','" & _
                                            AuthorMiddle + "','" & _
                                            AuthorLast + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editAuthor()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `author` SET " & _
            "`authorFirst`='" + AuthorFirst & _
            "',`authorMiddle`='" + AuthorMiddle & _
            "',`authorLast`='" + AuthorLast & _
            "' WHERE authorId= " + AuthorId.ToString & ";"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteAuthor()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM author " & _
                    "WHERE authorId= " + AuthorId.ToString & ";"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub

End Class
