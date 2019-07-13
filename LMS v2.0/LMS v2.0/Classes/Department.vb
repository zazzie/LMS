Public Class Department
    Private Shared _departmentId As Integer
    Private Shared _departmentName, _departmentLevel As String

    Public Property DepartmentId()
        Get
            Return _departmentId
        End Get
        Set(value)
            _departmentId = value
        End Set
    End Property

    Public Property DepartmentName()
        Get
            Return _departmentName
        End Get
        Set(value)
            _departmentName = value
        End Set
    End Property

    Public Property DepartmentLevel()
        Get
            Return _departmentLevel
        End Get
        Set(value)
            _departmentLevel = value
        End Set
    End Property

    Public Sub addDepartment()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `department`(`departmentId`, `departmentName`, `departmentLevel`) VALUES (" & _
                                            DepartmentId.ToString + ",'" & _
                                            DepartmentName + "','" & _
                                            DepartmentLevel + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editDepartment()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `department` SET " & _
            "`departmentName`='" + DepartmentName & _
            "', `departmentLevel`='" + DepartmentLevel & _
            "' WHERE departmentId= " + DepartmentId.ToString & ";"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteDepartment()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM department " & _
                    "WHERE departmentId= " + DepartmentId.ToString & ";"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
