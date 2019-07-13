﻿Public Class BookShelfSection
    Private Shared _bookShelfSectionId, _bookShelfSectionBookShelfId As Integer
    Private Shared _bookShelfSectionName As String

    Public Property BookShelfSectionId()
        Get
            Return _bookShelfSectionId
        End Get
        Set(value)
            _bookShelfSectionId = value
        End Set
    End Property

    Public Property BookShelfSectionBookShelfId()
        Get
            Return _bookShelfSectionBookShelfId
        End Get
        Set(value)
            _bookShelfSectionBookShelfId = value
        End Set
    End Property

    Public Property BookShelfSectionName()
        Get
            Return _bookShelfSectionName
        End Get
        Set(value)
            _bookShelfSectionName = value
        End Set
    End Property

    Public Sub addBookShelfSection()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `bookshelfsection`(`bookShelfSectionId`, `bookShelfSectionName`, `bookShelfSectionBookShelfId`) VALUES (" & _
                                            BookShelfSectionId.ToString + ",'" & _
                                            BookShelfSectionName + "'," & _
                                            BookShelfSectionBookShelfId.ToString + ");"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editBookShelfSection()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `bookshelfsection` SET " & _
            "`bookShelfSectionName`='" + BookShelfSectionName & _
            "',`bookShelfSectionBookShelfId`=" + BookShelfSectionBookShelfId.ToString & _
            " WHERE bookShelfSectionId= " + BookShelfSectionId.ToString & ";"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteBookShelfSection()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM bookshelfsection " & _
                    "WHERE bookShelfSectionId= " + BookShelfSectionId.ToString & ";"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub

    Public Sub deleteBookShelfSectionAll()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM bookshelfsection " & _
                    "WHERE bookShelfSectionBookShelfId= " + BookShelfSectionBookShelfId.ToString & ";"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
