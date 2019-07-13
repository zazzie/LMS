Public Class Reservation
    Private Shared _reservationId, _reservationItemId, _reservationBorrowerId As Integer
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
        sqlInsert = "INSERT INTO `reservation`(`reservationId`, `reservationItemId`, `reservationItemType`, `reservationBorrowerId`, `reservationStatus`) VALUES (" & _
                                            ReservationId.ToString + "," & _
                                            ReservationItemId.ToString + ",'" & _
                                            ReservationItemType + "'," & _
                                            ReservationBorrowerId.ToString + ",'" & _
                                            ReservationStatus + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editReservation()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `reservation` SET " & _
            "`reservationItemId`=" + ReservationItemId.ToString & _
            ",`reservationItemType`='" + ReservationItemType & _
            "',`reservationBorrowerId`=" + ReservationBorrowerId.ToString & _
            ",`reservationStatus`='" + ReservationStatus & _
            "' WHERE reservationId= " + ReservationId.ToString & ";"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteReservation()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM reservation " & _
                    "WHERE reservationId= " + ReservationId.ToString & ";"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub

End Class
