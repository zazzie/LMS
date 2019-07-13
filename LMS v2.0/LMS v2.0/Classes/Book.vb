Imports System.Drawing.Imaging

Public Class Book
    Private Shared _bookId, _bookPublisherId, _bookCategoryId, _bookMaxBorrowDuration As Integer
    Private Shared _bookISBN, _bookTitle, _bookBorrowType, _bookDescription, _bookPhoto As String
    Private _photo As Byte()

    Public Property Photo As Byte()
        Set(value As Byte())
            _photo = value
        End Set
        Get
            Return _photo
        End Get
    End Property
    Public Property BookId()
        Get
            Return _bookId
        End Get
        Set(value)
            _bookId = value
        End Set
    End Property

    Public Function ConvertImageTo64(img As Image) As String
        Try
            Dim ms As New System.IO.MemoryStream()
            img.Save(ms, ImageFormat.Bmp)
            Photo = ms.ToArray()
            ms.Dispose()
            Dim base64 As String = Convert.ToBase64String(Photo)
            Return base64
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Property BookPhoto()
        Get
            Return _bookPhoto
        End Get
        Set(value)
            _bookPhoto = value
        End Set
    End Property

    Public Property BookPublisherId()
        Get
            Return _bookPublisherId
        End Get
        Set(value)
            _bookPublisherId = value
        End Set
    End Property

    Public Property BookCategoryId()
        Get
            Return _bookCategoryId
        End Get
        Set(value)
            _bookCategoryId = value
        End Set
    End Property

    Public Property BookMaxBorrowDuration()
        Get
            Return _bookMaxBorrowDuration
        End Get
        Set(value)
            _bookMaxBorrowDuration = value
        End Set
    End Property

    Public Property BookISBN()
        Get
            Return _bookISBN
        End Get
        Set(value)
            _bookISBN = value
        End Set
    End Property

    Public Property BookTitle()
        Get
            Return _bookTitle
        End Get
        Set(value)
            _bookTitle = value
        End Set
    End Property

    Public Property BookBorrowType()
        Get
            Return _bookBorrowType
        End Get
        Set(value)
            _bookBorrowType = value
        End Set
    End Property

    Public Property BookDescription()
        Get
            Return _bookDescription
        End Get
        Set(value)
            _bookDescription = value
        End Set
    End Property

    Public Sub addBook()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `book`(`bookId`, `bookISBN`, `bookTitle`, `bookPublisherId`, `bookCategoryId`, `bookBorrowType`, `bookDescription`, `bookMaxBorrowDuration`, `bookPhoto`) VALUES (" & _
                                            BookId.ToString + ",'" & _
                                            BookISBN + "','" & _
                                            BookTitle + "'," & _
                                            BookPublisherId.ToString + "," & _
                                            BookCategoryId.ToString + ",'" & _
                                            BookBorrowType + "','" & _
                                            BookDescription + "'," & _
                                            BookMaxBorrowDuration.ToString + ",'" & _
                                            BookPhoto + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editBook()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `book` SET " & _
            "`bookISBN`='" + BookISBN & _
            "',`bookTitle`='" + BookTitle & _
            "',`bookPublisherId`=" + BookPublisherId.ToString & _
            ",`bookCategoryId`=" + BookCategoryId.ToString & _
            ",`bookBorrowType`='" + BookBorrowType & _
            "',`bookDescription`='" + BookDescription & _
            "',`bookMaxBorrowDuration`=" + BookMaxBorrowDuration.ToString & _
            ",`bookPhoto`='" + BookPhoto & _
            "' WHERE bookId= " + BookId.ToString & ";"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteBook()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM bookcopy " & _
                    "WHERE bookCopyBookId= " + BookId.ToString + ";" & _
                    "DELETE FROM book " & _
                    "WHERE bookId= " + BookId.ToString + ";"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
