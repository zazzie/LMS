Public Class Publisher
    Private Shared _publisherId As String
    Private Shared _publisherName As String

    Public Property PublisherId()
        Get
            Return _publisherId
        End Get
        Set(value)
            _publisherId = value
        End Set
    End Property

    Public Property PublisherName()
        Get
            Return _publisherName
        End Get
        Set(value)
            _publisherName = value
        End Set
    End Property

    Public Sub addPublisher()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `publisher`(`publisherId`, `publisherName`) VALUES ('" & _
                                            PublisherId + "','" & _
                                            PublisherName + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editPublisher()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `publisher` SET " & _
            "`publisherName`='" + PublisherName & _
            "' WHERE publisherId='" + PublisherId & "';"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deletePublisher()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM publisher " & _
                    "WHERE publisherId='" + PublisherId & "';"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
