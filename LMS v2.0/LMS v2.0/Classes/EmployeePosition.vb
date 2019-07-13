Public Class EmployeePosition
    Private Shared _employeePositionId As Integer
    Private Shared _employeePositionName As String

    Public Property EmployeePositionId()
        Get
            Return _employeePositionId
        End Get
        Set(value)
            _employeePositionId = value
        End Set
    End Property

    Public Property EmployeePositionName()
        Get
            Return _employeePositionName
        End Get
        Set(value)
            _employeePositionName = value
        End Set
    End Property

    Public Sub addEmployeePosition()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `employeeposition`(`employeepositionId`, `employeepositionName`) VALUES (" & _
                                            EmployeePositionId.ToString + ",'" & _
                                            EmployeePositionName + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editEmployeePosition()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `employeeposition` SET " & _
            "`employeepositionName`='" + EmployeePositionName & _
            "' WHERE employeepositionId= " + EmployeePositionId.ToString & ";"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteEmployeePosition()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM employeeposition " & _
                    "WHERE employeepositionId= " + EmployeePositionId.ToString & ";"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
