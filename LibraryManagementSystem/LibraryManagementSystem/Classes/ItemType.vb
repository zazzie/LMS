Public Class ItemType
    Private Shared _itemTypeId As String
    Private Shared _itemTypeName As String

    Public Property ItemTypeId()
        Get
            Return _itemTypeId
        End Get
        Set(value)
            _itemTypeId = value
        End Set
    End Property

    Public Property ItemTypeName()
        Get
            Return _itemTypeName
        End Get
        Set(value)
            _itemTypeName = value
        End Set
    End Property

    Public Sub addItemType()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `itemType`(`itemTypeId`, `itemTypeName`) VALUES ('" & _
                                            ItemTypeId + "','" & _
                                            ItemTypeName + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editItemType()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `itemType` SET " & _
            "`itemTypeName`='" + ItemTypeName & _
            "' WHERE itemTypeId='" + ItemTypeId & "';"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteItemType()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM itemType " & _
                    "WHERE itemTypeId='" + ItemTypeId & "';"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
