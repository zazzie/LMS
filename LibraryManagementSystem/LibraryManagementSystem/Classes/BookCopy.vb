Public Class BookCopy
    Private Shared _bookAccessionId, _bookAccessionIdNew, _bookCopyBookId, _bookCopyShelfSectionId, _bookCopyShelfId As Integer
    Private Shared _bookCopyQuality, _bookCopyAquisition, _bookCopyPrice, _bookCopyDateAdded, _bookCopyStatus As String

    Public Property BookAccessionId()
        Get
            Return _bookAccessionId
        End Get
        Set(value)
            _bookAccessionId = value
        End Set
    End Property

    Public Property BookAccessionIdNew()
        Get
            Return _bookAccessionIdNew
        End Get
        Set(value)
            _bookAccessionIdNew = value
        End Set
    End Property

    Public Property BookCopyBookId()
        Get
            Return _bookCopyBookId
        End Get
        Set(value)
            _bookCopyBookId = value
        End Set
    End Property

    Public Property BookCopyShelfSectionId()
        Get
            Return _bookCopyShelfSectionId
        End Get
        Set(value)
            _bookCopyShelfSectionId = value
        End Set
    End Property

    Public Property BookCopyShelfId()
        Get
            Return _bookCopyShelfId
        End Get
        Set(value)
            _bookCopyShelfId = value
        End Set
    End Property

    Public Property BookCopyQuality()
        Get
            Return _bookCopyQuality
        End Get
        Set(value)
            _bookCopyQuality = value
        End Set
    End Property

    Public Property BookCopyAquisition()
        Get
            Return _bookCopyAquisition
        End Get
        Set(value)
            _bookCopyAquisition = value
        End Set
    End Property

    Public Property BookCopyPrice()
        Get
            Return _bookCopyPrice
        End Get
        Set(value)
            _bookCopyPrice = value
        End Set
    End Property

    Public Property BookCopyDateAdded()
        Get
            Return _bookCopyDateAdded
        End Get
        Set(value)
            _bookCopyDateAdded = value
        End Set
    End Property

    Public Property BookCopyStatus()
        Get
            Return _bookCopyStatus
        End Get
        Set(value)
            _bookCopyStatus = value
        End Set
    End Property

    Public Sub addBookCopy()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `bookcopy`(`bookAccessionId`, `bookCopyBookId`, `bookCopyNumber`, `bookCopyQuality`, `bookCopyAquisition`, `bookCopyPrice`, `bookCopyDateAdded`, `bookCopyShelfId`, `bookCopyShelfSectionId`, `bookCopyStatus`) VALUES ('" & _
                                            BookAccessionId + "','" & _
                                            BookCopyBookId + "','" & _
                                            BookCopyQuality + "','" & _
                                            BookCopyAquisition + "','" & _
                                            BookCopyPrice + "','" & _
                                            BookCopyDateAdded + "','" & _
                                            BookCopyShelfId + "','" & _
                                            BookCopyShelfSectionId + "','IN');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editBookCopy()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `bookcopy` SET " & _
            "`bookAccessionId`='" + BookAccessionIdNew & _
            "',`bookCopyBookId`='" + BookCopyBookId & _
            "',`bookCopyQuality`='" + BookCopyQuality & _
            "',`bookCopyAquisition`='" + BookCopyAquisition & _
            "',`bookCopyPrice`='" + BookCopyPrice & _
            "',`bookCopyDateAdded`='" + BookCopyDateAdded & _
            "',`bookCopyShelfId`='" + BookCopyShelfId & _
            "',`bookCopyShelfSectionId`='" + BookCopyShelfSectionId & _
            "',`bookCopyStatus`='" + BookCopyStatus & _
            "' WHERE bookAccessionId= '" + BookAccessionId & "';"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteBookCopy()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM bookcopy " & _
                    "WHERE bookAccessionId= '" + BookAccessionId & "';"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub

End Class
