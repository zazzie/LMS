Imports System.Drawing.Imaging

Public Class Borrower
    Private Shared _borrowerId, _borrowerBarangayId, _borrowerCityId, _borrowerIdNew As Integer
    Private Shared _borrowerFirst, _borrowerMiddle, _borrowerLast, _borrowerGender, _borrowerBirth, _borrowerPhone, _borrowerStreet, _borrowerType As String
    Private Shared _borrowerPhoto As String
    Private _photo As Byte()

    Public Property Photo As Byte()
        Set(value As Byte())
            _photo = value
        End Set
        Get
            Return _photo
        End Get
    End Property

    Public Property BorrowerId()
        Get
            Return _borrowerId
        End Get
        Set(value)
            _borrowerId = value
        End Set
    End Property

    Public Property BorrowerIdNew()
        Get
            Return _borrowerIdNew
        End Get
        Set(value)
            _borrowerIdNew = value
        End Set
    End Property

    Public Property BorrowerBarangayId()
        Get
            Return _borrowerBarangayId
        End Get
        Set(value)
            _borrowerBarangayId = value
        End Set
    End Property

    Public Property BorrowerCityId()
        Get
            Return _borrowerCityId
        End Get
        Set(value)
            _borrowerCityId = value
        End Set
    End Property

    Public Property BorrowerFirst()
        Get
            Return _borrowerFirst
        End Get
        Set(value)
            _borrowerFirst = value
        End Set
    End Property

    Public Property BorrowerMiddle()
        Get
            Return _borrowerMiddle
        End Get
        Set(value)
            _borrowerMiddle = value
        End Set
    End Property

    Public Property BorrowerGender()
        Get
            Return _borrowerGender
        End Get
        Set(value)
            _borrowerGender = value
        End Set
    End Property

    Public Property BorrowerBirth()
        Get
            Return _borrowerBirth
        End Get
        Set(value)
            _borrowerBirth = value
        End Set
    End Property

    Public Property BorrowerPhone()
        Get
            Return _borrowerPhone
        End Get
        Set(value)
            _borrowerPhone = value
        End Set
    End Property

    Public Property BorrowerStreet()
        Get
            Return _borrowerStreet
        End Get
        Set(value)
            _borrowerStreet = value
        End Set
    End Property

    Public Property BorrowerLast()
        Get
            Return _borrowerLast
        End Get
        Set(value)
            _borrowerLast = value
        End Set
    End Property

    Public Property BorrowerType()
        Get
            Return _borrowerType
        End Get
        Set(value)
            _borrowerType = value
        End Set
    End Property

    Public Property BorrowerPhoto()
        Get
            Return _borrowerPhoto
        End Get
        Set(value)
            _borrowerPhoto = value
        End Set
    End Property

    Public Sub addBorrower()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `borrower`(`borrowerId`, `borrowerFirst`, `borrowerMiddle`, `borrowerLast`, `borrowerGender`, `borrowerBirth`, `borrowerPhone`, `borrowerStreet`, `borrowerBarangayId`, `borrowerCityId`, `borrowerType`, `borrowerPhoto`) VALUES (" & _
                                            BorrowerId.ToString + ",'" & _
                                            BorrowerFirst + "','" & _
                                            BorrowerMiddle + "','" & _
                                            BorrowerLast + "','" & _
                                            BorrowerGender + "','" & _
                                            BorrowerBirth + "','" & _
                                            BorrowerPhone + "','" & _
                                            BorrowerStreet + "'," & _
                                            BorrowerBarangayId.ToString + "," & _
                                            BorrowerCityId.ToString + ",'" & _
                                            BorrowerType + "','" & _
                                            BorrowerPhoto + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editBorrower()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `borrower` SET " & _
            " `borrowerId`=" + BorrowerIdNew.ToString & _
            ",`borrowerFirst`='" + BorrowerFirst & _
            "',`borrowerMiddle`='" + BorrowerMiddle & _
            "',`borrowerLast`='" + BorrowerLast & _
            "',`borrowerGender`='" + BorrowerGender & _
            "',`borrowerBirth`='" + BorrowerBirth & _
            "',`borrowerPhone`='" + BorrowerPhone & _
            "',`borrowerStreet`='" + BorrowerStreet & _
            "',`borrowerBarangayId`=" + BorrowerBarangayId.ToString & _
            ",`borrowerCityId`=" + BorrowerCityId.ToString & _
            ",`borrowerType`='" + BorrowerType & _
            "',`borrowerPhoto`='" + BorrowerPhoto & _
            "' WHERE borrowerId= " + BorrowerId.ToString & ";"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteBorrower()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM borrower " & _
                    "WHERE borrowerId= " + BorrowerId.ToString & ";"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub

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
End Class
