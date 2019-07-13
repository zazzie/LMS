Public Class Rent
    Private Shared _rentId, _rentBorrowerId, _rentIssuedById As Integer
    Private Shared _rentDate As String

    Public Property RentId()
        Get
            Return _rentId
        End Get
        Set(value)
            _rentId = value
        End Set
    End Property

    Public Property RentBorrowerId()
        Get
            Return _rentBorrowerId
        End Get
        Set(value)
            _rentBorrowerId = value
        End Set
    End Property

    Public Property RentIssuedById()
        Get
            Return _rentIssuedById
        End Get
        Set(value)
            _rentIssuedById = value
        End Set
    End Property

    Public Property RentDate()
        Get
            Return _rentDate
        End Get
        Set(value)
            _rentDate = value
        End Set
    End Property

    Public Sub addRent()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `rent`(`rentId`, `rentDate`, `rentBorrowerId`, `rentIssuedById`) VALUES (" & _
                                            RentId.ToString + ",'" & _
                                            RentDate + "'," & _
                                            RentBorrowerId.ToString + "," & _
                                            RentIssuedById.ToString + ");"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editRent()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `rent` SET " & _
            "`rentDate`='" + RentDate & _
            "',`rentBorrowerId`=" + RentBorrowerId.ToString & _
            ",`rentIssuedById`=" + RentIssuedById.ToString & _
            " WHERE rentId= " + RentId.ToString & ";"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteRent()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM rent " & _
                    "WHERE rentId= " + RentId.ToString & ";"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
