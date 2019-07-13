Public Class EmployeeRegistry
    Private Shared _employeeRegistryId, _employeeRegistryBorrowerId As Integer
    Private Shared _employeeRegistryDepartmentId, _employeeRegistrySchoolYearId As Integer
    Private Shared _employeeRegistryPositionId As Integer

    Public Property EmployeeRegistryId()
        Get
            Return _employeeRegistryId
        End Get
        Set(value)
            _employeeRegistryId = value
        End Set
    End Property

    Public Property EmployeeRegistryBorrowerId()
        Get
            Return _employeeRegistryBorrowerId
        End Get
        Set(value)
            _employeeRegistryBorrowerId = value
        End Set
    End Property

    Public Property EmployeeRegistryPositionId()
        Get
            Return _employeeRegistryPositionId
        End Get
        Set(value)
            _employeeRegistryPositionId = value
        End Set
    End Property

    Public Property EmployeeRegistryDepartmentId()
        Get
            Return _employeeRegistryDepartmentId
        End Get
        Set(value)
            _employeeRegistryDepartmentId = value
        End Set
    End Property

    Public Property EmployeeRegistrySchoolYearId()
        Get
            Return _employeeRegistrySchoolYearId
        End Get
        Set(value)
            _employeeRegistrySchoolYearId = value
        End Set
    End Property


    Public Sub addEmployeeRegistry()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `employeeregistry`(`employeeRegistryId`, `employeeRegistryBorrowerId`, `employeeRegistryPositionId`, `employeeRegistryDepartmentId`, `employeeRegistrySchoolYearId`) VALUES (" & _
                                            EmployeeRegistryId.ToString + "," & _
                                            EmployeeRegistryBorrowerId.ToString + "," & _
                                            EmployeeRegistryPositionId.ToString + "," & _
                                            EmployeeRegistryDepartmentId.ToString + "," & _
                                            EmployeeRegistrySchoolYearId.ToString + ");"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editEmployeeRegistry()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `employeeregistry` SET " & _
            "`employeeRegistryBorrowerId`=" + EmployeeRegistryBorrowerId.ToString & _
            ",`employeeRegistryDepartmentId`=" + EmployeeRegistryDepartmentId.ToString & _
            ",`employeeRegistrySchoolYearId`=" + EmployeeRegistrySchoolYearId.ToString & _
            ",`employeeRegistryPositionId`=" + EmployeeRegistryPositionId.ToString & _
            " WHERE employeeRegistryId= " + EmployeeRegistryId.ToString & ";"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteEmployeeRegistry()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM employeeregistry " & _
                    "WHERE employeeRegistryId= " + EmployeeRegistryId.ToString & ";"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
