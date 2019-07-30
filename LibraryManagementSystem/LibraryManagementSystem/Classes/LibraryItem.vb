Imports System.Drawing.Imaging

Public Class LibraryItem
    Private Shared _libraryItemId, _libraryItemIdNew, _libraryItemBorrowDuration, _libraryItemTypeId As String
    Private Shared _libraryItemName, _libraryItemDescription, _libraryItemBorrowType, _libraryItemPhoto As String
    Private _photo As Byte()

    Public Property Photo As Byte()
        Set(value As Byte())
            _photo = value
        End Set
        Get
            Return _photo
        End Get
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

    Public Property LibraryItemId()
        Get
            Return _libraryItemId
        End Get
        Set(value)
            _libraryItemId = value
        End Set
    End Property

    Public Property LibraryItemIdNew()
        Get
            Return _libraryItemIdNew
        End Get
        Set(value)
            _libraryItemIdNew = value
        End Set
    End Property

    Public Property LibraryItemBorrowType()
        Get
            Return _libraryItemBorrowType
        End Get
        Set(value)
            _libraryItemBorrowType = value
        End Set
    End Property

    Public Property LibraryItemPhoto()
        Get
            Return _libraryItemPhoto
        End Get
        Set(value)
            _libraryItemPhoto = value
        End Set
    End Property

    Public Property LibraryItemBorrowDuration()
        Get
            Return _libraryItemBorrowDuration
        End Get
        Set(value)
            _libraryItemBorrowDuration = value
        End Set
    End Property

    Public Property LibraryItemName()
        Get
            Return _libraryItemName
        End Get
        Set(value)
            _libraryItemName = value
        End Set
    End Property

    Public Property LibraryItemTypeId()
        Get
            Return _libraryItemTypeId
        End Get
        Set(value)
            _libraryItemTypeId = value
        End Set
    End Property

    Public Property LibraryItemDescription()
        Get
            Return _libraryItemDescription
        End Get
        Set(value)
            _libraryItemDescription = value
        End Set
    End Property

    Public Sub addLibraryItem()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `libraryitem`(`libraryItemId`, `libraryItemName`, `libraryItemType`, `libraryItemBorrowType`, `libraryItemBorrowDuration`, `libraryItemDescription`, `libraryItemPhoto`) VALUES ('" & _
                                            LibraryItemId + "','" & _
                                            LibraryItemName + "','" & _
                                            LibraryItemTypeId + "','" & _
                                            LibraryItemBorrowType + "'," & _
                                            LibraryItemBorrowDuration + ",'" & _
                                            LibraryItemDescription + "','" & _
                                            LibraryItemPhoto + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editLibraryItem()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `libraryitem` SET " & _
            "`libraryItemId`='" + LibraryItemIdNew & _
            "',`libraryItemName`='" + LibraryItemName & _
            "',`libraryItemType`='" + LibraryItemTypeId & _
            "',`libraryItemBorrowType`='" + LibraryItemBorrowType & _
            "',`libraryItemBorrowDuration`=" + LibraryItemBorrowDuration & _
            ",`libraryItemDescription`='" + LibraryItemDescription & _
            "',`libraryItemPhoto`='" + LibraryItemPhoto & _
            "' WHERE libraryItemId= '" + LibraryItemId & "';"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteLibraryItem()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM libraryitemunit " & _
                    "WHERE libraryItemUnitItemId='" + LibraryItemId + "';" & _
                    "DELETE FROM libraryitem " & _
                    "WHERE libraryItemId='" + LibraryItemId & "';"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
