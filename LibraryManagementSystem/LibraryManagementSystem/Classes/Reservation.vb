Public Class Reservation
    Private Shared _reservationId, _reservationItemId, _reservationBorrowerId As String
    Private Shared _reservationItemType, _reservationStatus As String

    Public Property ReservationId()
        Get
            Return _reservationId
        End Get
        Set(value)
            _reservationId = value
        End Set
    End Property

    Public Property ReservationItemId()
        Get
            Return _reservationItemId
        End Get
        Set(value)
            _reservationItemId = value
        End Set
    End Property

    Public Property ReservationBorrowerId()
        Get
            Return _reservationBorrowerId
        End Get
        Set(value)
            _reservationBorrowerId = value
        End Set
    End Property

    Public Property ReservationItemType()
        Get
            Return _reservationItemType
        End Get
        Set(value)
            _reservationItemType = value
        End Set
    End Property

    Public Property ReservationStatus()
        Get
            Return _reservationStatus
        End Get
        Set(value)
            _reservationStatus = value
        End Set
    End Property

    Public Sub addReservation()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `reservation`(`reservationId`, `reservationItemId`, `reservationItemType`, `reservationBorrowerId`, `reservationStatus`) VALUES ('" & _
                                            ReservationId + "','" & _
                                            ReservationItemId + "','" & _
                                            ReservationItemType + "','" & _
                                            ReservationBorrowerId + "','" & _
                                            ReservationStatus + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editReservation()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `reservation` SET " & _
            "`reservationItemId`='" + ReservationItemId & _
            "',`reservationItemType`='" + ReservationItemType & _
            "',`reservationBorrowerId`='" + ReservationBorrowerId & _
            "',`reservationStatus`='" + ReservationStatus & _
            "' WHERE reservationId= '" + ReservationId & "';"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteReservation()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM reservation " & _
                    "WHERE reservationId='" + ReservationId & "';"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub

End Class
