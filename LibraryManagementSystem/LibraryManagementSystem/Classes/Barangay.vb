Public Class Barangay
    Private Shared _barangayId, _barangayCityId As String
    Private Shared _barangayName As String

    Public Property BarangayId()
        Get
            Return _barangayId
        End Get
        Set(value)
            _barangayId = value
        End Set
    End Property

    Public Property BarangayCityId()
        Get
            Return _barangayCityId
        End Get
        Set(value)
            _barangayCityId = value
        End Set
    End Property

    Public Property BarangayName()
        Get
            Return _barangayName
        End Get
        Set(value)
            _barangayName = value
        End Set
    End Property

    Public Sub addBarangay()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `barangay`(`barangayId`, `barangayName`, `barangayCityId`) VALUES ('" & _
                                            BarangayId + "','" & _
                                            BarangayName + "','" & _
                                            BarangayCityId + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editBarangay()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `barangay` SET " & _
            "`barangayName`='" + BarangayName & _
            "',`barangayCityId`='" + BarangayCityId & _
            "' WHERE barangayId= '" + BarangayId & "';"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteBarangay()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM barangay " & _
                    "WHERE barangayId= '" + BarangayId & "';"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub

End Class