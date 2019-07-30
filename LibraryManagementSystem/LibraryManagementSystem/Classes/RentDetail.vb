Public Class RentDetail
    Private Shared _rentDetailId, _rentDetailRentId, _rentDetailItemId As String
    Private Shared _rentDetailItemType, _rentDetailDueDate, _rentDetailReturnedDate, _rentDetailReturnCondition As String
    Private Shared _rentDetailFine, _rentDetailReturnStatus, _rentDetailReceivedById As String

    Public Property RentDetailId()
        Get
            Return _rentDetailId
        End Get
        Set(value)
            _rentDetailId = value
        End Set
    End Property

    Public Property RentDetailRentId()
        Get
            Return _rentDetailRentId
        End Get
        Set(value)
            _rentDetailRentId = value
        End Set
    End Property

    Public Property RentDetailItemId()
        Get
            Return _rentDetailItemId
        End Get
        Set(value)
            _rentDetailItemId = value
        End Set
    End Property

    Public Property RentDetailReceivedById()
        Get
            Return _rentDetailReceivedById
        End Get
        Set(value)
            _rentDetailReceivedById = value
        End Set
    End Property

    Public Property RentDetailItemType()
        Get
            Return _rentDetailItemType
        End Get
        Set(value)
            _rentDetailItemType = value
        End Set
    End Property

    Public Property RentDetailDueDate()
        Get
            Return _rentDetailDueDate
        End Get
        Set(value)
            _rentDetailDueDate = value
        End Set
    End Property

    Public Property RentDetailReturnedDate()
        Get
            Return _rentDetailReturnedDate
        End Get
        Set(value)
            _rentDetailReturnedDate = value
        End Set
    End Property

    Public Property RentDetailReturnCondition()
        Get
            Return _rentDetailReturnCondition
        End Get
        Set(value)
            _rentDetailReturnCondition = value
        End Set
    End Property

    Public Property RentDetailFine()
        Get
            Return _rentDetailFine
        End Get
        Set(value)
            _rentDetailFine = value
        End Set
    End Property

    Public Property RentDetailReturnStatus()
        Get
            Return _rentDetailReturnStatus
        End Get
        Set(value)
            _rentDetailReturnStatus = value
        End Set
    End Property

    Public Sub addRentDetail()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `rentdetail`(`rentDetailId`, `rentDetailRentId`, `rentDetailItemId`, `rentDetailItemType`," & _
            "`rentDetailDueDate`, `rentDetailReturnedDate`, `rentDetailReturnCondition`, `rentDetailFine`," & _
            "`rentDetailReceivedById`, `rentDetailReturnStatus`) VALUES ('" & _
                                            RentDetailId + "','" & _
                                            RentDetailRentId + "','" & _
                                            RentDetailItemId + "','" & _
                                            RentDetailItemType + "','" & _
                                            RentDetailDueDate + "','" & _
                                            RentDetailReturnedDate + "','" & _
                                            RentDetailReturnCondition + "','" & _
                                            RentDetailFine + "','" & _
                                            RentDetailReceivedById + "','" & _
                                            RentDetailReturnStatus + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editRentDetail()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `rentdetail` SET " & _
            "`rentDetailRentId`='" + RentDetailRentId & _
            "',`rentDetailItemId`='" + RentDetailItemId & _
            "',`rentDetailItemType`='" + RentDetailItemType & _
            "',`rentDetailDueDate`='" + RentDetailDueDate & _
            "',`rentDetailReturnedDate`='" + RentDetailReturnedDate & _
            "',`rentDetailReturnCondition`='" + RentDetailReturnCondition & _
            "',`rentDetailFine`='" + RentDetailFine & _
            "',`rentDetailReceivedById`='" + RentDetailReceivedById & _
            "',`rentDetailReturnStatus`='" + RentDetailReturnStatus & _
            "' WHERE rentDetailId= '" + RentDetailId & "';"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteRentDetail()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM rentdetail " & _
                    "WHERE rentDetailId='" + RentDetailId & "';"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
