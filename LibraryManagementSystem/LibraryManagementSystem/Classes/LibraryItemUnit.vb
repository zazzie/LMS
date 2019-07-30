Public Class LibraryItemUnit
    Private Shared _libraryItemUnitId, _libraryItemUnitIdNew, _libraryItemUnitItemId As String
    Private Shared _libraryItemUnitQuality, _libraryItemUnitAquisition, _libraryItemUnitPrice As String
    Private Shared _libraryItemUnitStatus, _libraryItemUnitDateAdded As String

    Public Property LibraryItemUnitId()
        Get
            Return _libraryItemUnitId
        End Get
        Set(value)
            _libraryItemUnitId = value
        End Set
    End Property

    Public Property LibraryItemUnitIdNew()
        Get
            Return _libraryItemUnitIdNew
        End Get
        Set(value)
            _libraryItemUnitIdNew = value
        End Set
    End Property

    Public Property LibraryItemUnitItemId()
        Get
            Return _libraryItemUnitItemId
        End Get
        Set(value)
            _libraryItemUnitItemId = value
        End Set
    End Property

    Public Property LibraryItemUnitQuality()
        Get
            Return _libraryItemUnitQuality
        End Get
        Set(value)
            _libraryItemUnitQuality = value
        End Set
    End Property

    Public Property LibraryItemUnitAquisition()
        Get
            Return _libraryItemUnitAquisition
        End Get
        Set(value)
            _libraryItemUnitAquisition = value
        End Set
    End Property

    Public Property LibraryItemUnitPrice()
        Get
            Return _libraryItemUnitPrice
        End Get
        Set(value)
            _libraryItemUnitPrice = value
        End Set
    End Property

    Public Property LibraryItemUnitStatus()
        Get
            Return _libraryItemUnitStatus
        End Get
        Set(value)
            _libraryItemUnitStatus = value
        End Set
    End Property

    Public Property LibraryItemUnitDateAdded()
        Get
            Return _libraryItemUnitDateAdded
        End Get
        Set(value)
            _libraryItemUnitDateAdded = value
        End Set
    End Property

    Public Sub addLibraryItemUnit()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `libraryitemunit`(`libraryItemUnitId`, `libraryItemUnitItemId`, `libraryItemUnitQuality`, `libraryItemUnitAquisition`, `libraryItemUnitPrice`, `libraryItemUnitStatus`, `libraryItemUnitDateAdded`) VALUES ('" & _
                                            LibraryItemUnitId + "','" & _
                                            LibraryItemUnitItemId + "','" & _
                                            LibraryItemUnitQuality + "','" & _
                                            LibraryItemUnitAquisition + "','" & _
                                            LibraryItemUnitPrice + "','" & _
                                            LibraryItemUnitStatus + "','" & _
                                            LibraryItemUnitDateAdded + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editLibraryItemUnit()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `libraryitemunit` SET " & _
            "`libraryItemUnitId`='" + LibraryItemUnitIdNew & _
            "',`libraryItemUnitItemId`='" + LibraryItemUnitItemId & _
            "',`libraryItemUnitQuality`='" + LibraryItemUnitQuality & _
            "',`libraryItemUnitAquisition`='" + LibraryItemUnitAquisition & _
            "',`libraryItemUnitPrice`='" + LibraryItemUnitPrice & _
            "',`libraryItemUnitStatus`='" + LibraryItemUnitStatus & _
            "',`libraryItemUnitDateAdded`='" + LibraryItemUnitDateAdded & _
            "' WHERE libraryItemUnitId='" + LibraryItemUnitId & "';"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteLibraryItemUnit()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM libraryitemunit " & _
                    "WHERE libraryItemUnitId='" + LibraryItemUnitId & "';"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
