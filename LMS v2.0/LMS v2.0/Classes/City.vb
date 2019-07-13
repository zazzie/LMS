Public Class City
    Private Shared _cityId As Integer
    Private Shared _cityName As String

    Public Property CityId()
        Get
            Return _cityId
        End Get
        Set(value)
            _cityId = value
        End Set
    End Property

    Public Property CityName()
        Get
            Return _cityName
        End Get
        Set(value)
            _cityName = value
        End Set
    End Property

    Public Sub addCity()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `city`(`cityId`, `cityName`) VALUES (" & _
                                            CityId.ToString + ",'" & _
                                            CityName + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editCity()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `city` SET " & _
            "`cityName`='" + CityName & _
            "' WHERE cityId= " + CityId.ToString & ";"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteCity()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM city " & _
                    "WHERE cityId= " + CityId.ToString & ";"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class