Public Class Category
    Private Shared _categoryId, _categoryIdNew As Integer
    Private Shared _categoryName, _categoryDescription As String

    Public Property CategoryId()
        Get
            Return _categoryId
        End Get
        Set(value)
            _categoryId = value
        End Set
    End Property

    Public Property CategoryIdNew()
        Get
            Return _categoryIdNew
        End Get
        Set(value)
            _categoryIdNew = value
        End Set
    End Property

    Public Property CategoryName()
        Get
            Return _categoryName
        End Get
        Set(value)
            _categoryName = value
        End Set
    End Property

    Public Property CategoryDescription()
        Get
            Return _categoryDescription
        End Get
        Set(value)
            _categoryDescription = value
        End Set
    End Property

    Public Sub addCategory()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `category`(`categoryId`, `categoryName`, `categoryDescription`) VALUES (" & _
                                            CategoryId.ToString + ",'" & _
                                            CategoryName + "','" & _
                                            CategoryDescription + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editCategory()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `category` SET " & _
            "`categoryName`='" + CategoryName & _
            "',`categoryDescription`='" + CategoryDescription & _
            "',`categoryId`=" + CategoryIdNew.ToString & _
            " WHERE categoryId= " + CategoryId.ToString & ";"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteCategory()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM category " & _
                    "WHERE categoryId= " + CategoryId.ToString & ";"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
