Public Class Department
    Private Shared _departmentId As String
    Private Shared _departmentName As String

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

    Public Sub addDepartment()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `department`(`departmentId`, `departmentName`) VALUES ('" & _
                                            DepartmentId + "','" & _
                                            DepartmentName + "');"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Public Sub editDepartment()
        Dim sqlUpdate As String
        sqlUpdate = "UPDATE `department` SET " & _
            "`departmentName`='" + DepartmentName & _
            "' WHERE departmentId='" + DepartmentId & "';"
        LibraryDatabase.execSQL(sqlUpdate)
    End Sub

    Public Sub deleteDepartment()
        Dim sqlDelete As String
        sqlDelete = "DELETE FROM department " & _
                    "WHERE departmentId='" + DepartmentId & "';"
        LibraryDatabase.execSQL(sqlDelete)
    End Sub
End Class
