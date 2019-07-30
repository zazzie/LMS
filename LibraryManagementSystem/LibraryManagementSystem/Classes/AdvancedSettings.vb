Public Class AdvancedSettings
    ' ''' 
    ' ''' `maintenanceId`, `maintenanceMission`, `maintenanceVision`, `maintenanceSchlYrId`, 
    ' ''' `maintenanceSchoolYear`, `maintenanceFine`, `maintenanceBookPriceFine`, 
    ' ''' `maintenanceBookLimit`, `maintenanceAlmostDueDays` 
    ' ''' 
    Private Shared _maintenanceId, _maintenanceMission, _maintenanceVision, _maintenanceSchlYrId, _maintenanceSchoolYear As String
    Private Shared _maintenanceFine, _maintenanceBookPriceFine, _maintenanceBookLimit, _maintenanceAlmostDueDays As String
    Private Shared _maintenanceSemesterId, _maintenanceSemester As String

    Public Property MaintenanceSemesterId()
        Get
            Return _maintenanceSemesterId
        End Get
        Set(ByVal value)
            _maintenanceSemesterId = value
        End Set
    End Property

    Public Property MaintenanceSemester()
        Get
            Return _maintenanceSemester
        End Get
        Set(ByVal value)
            _maintenanceSemester = value
        End Set
    End Property

    Public Property MaintenanceId()
        Get
            Return _maintenanceId
        End Get
        Set(ByVal value)
            _maintenanceId = value
        End Set
    End Property
    Public Property MaintenanceMission()
        Get
            Return _maintenanceMission
        End Get
        Set(ByVal value)
            _maintenanceMission = value
        End Set
    End Property
    Public Property MaintenanceVision()
        Get
            Return _maintenanceVision
        End Get
        Set(ByVal value)
            _maintenanceVision = value
        End Set
    End Property
    Public Property MaintenanceSchlYrId()
        Get
            Return _maintenanceSchlYrId
        End Get
        Set(ByVal value)
            _maintenanceSchlYrId = value
        End Set
    End Property
    Public Property MaintenanceSchoolYear()
        Get
            Return _maintenanceSchoolYear
        End Get
        Set(ByVal value)
            _maintenanceSchoolYear = value
        End Set
    End Property
    Public Property MaintenanceFine()
        Get
            Return _maintenanceFine
        End Get
        Set(ByVal value)
            _maintenanceFine = value
        End Set
    End Property
    Public Property MaintenanceBookPriceFine()
        Get
            Return _maintenanceBookPriceFine
        End Get
        Set(ByVal value)
            _maintenanceBookPriceFine = value
        End Set
    End Property
    Public Property MaintenanceBookLimit()
        Get
            Return _maintenanceBookLimit
        End Get
        Set(ByVal value)
            _maintenanceBookLimit = value
        End Set
    End Property
    Public Property MaintenanceAlmostDueDays()
        Get
            Return _maintenanceAlmostDueDays
        End Get
        Set(ByVal value)
            _maintenanceAlmostDueDays = value
        End Set
    End Property
    'INSERT INTO `maintenance`(`maintenanceId`, `maintenanceMission`, `maintenanceVision`, `maintenanceSchlYrId`, `maintenanceSchoolYear`, `maintenanceFine`, `maintenanceBookPriceFine`, `maintenanceBookLimit`, `maintenanceAlmostDueDays`) VALUES
    Public Sub createMaintenance()
        Dim sqlInsert As String
        sqlInsert = "INSERT INTO `maintenance`(`maintenanceId`) VALUES (1);"
        LibraryDatabase.execSQL(sqlInsert)
    End Sub
    Public Sub editMissionVision()
        Dim sqlEdit As String
        sqlEdit = "UPDATE `maintenance` SET " & _
                    "maintenanceMission='" + MaintenanceMission & _
                    "', maintenanceVision='" + MaintenanceVision & _
                    "' WHERE maintenanceId=1;"
        LibraryDatabase.execSQL(sqlEdit)
    End Sub
    Public Sub editFine()
        Dim sqlEdit As String
        sqlEdit = "UPDATE `maintenance` SET " & _
                    "maintenanceFine=" + MaintenanceFine & _
                    " WHERE maintenanceId=1;"
        LibraryDatabase.execSQL(sqlEdit)
    End Sub
    Public Sub editBookLimit()
        Dim sqlEdit As String
        sqlEdit = "UPDATE `maintenance` SET " & _
                    "maintenanceBookLimit=" + MaintenanceBookLimit & _
                    " WHERE maintenanceId=1;"
        LibraryDatabase.execSQL(sqlEdit)
    End Sub
    Public Sub editSchoolYr()
        Dim sqlEdit As String
        sqlEdit = "UPDATE `maintenance` SET " & _
                    "maintenanceSchlYrId=" + MaintenanceSchlYrId & _
                    ", maintenanceSchoolYear='" + MaintenanceSchoolYear & _
                    "' WHERE maintenanceId=1;"
        sqlEdit += "UPDATE `maintenance` SET " & _
                    "maintenanceSemesterId=" + MaintenanceSemesterId & _
                    ", maintenanceSemester='" + MaintenanceSemester & _
                    "' WHERE maintenanceId=1;"
        LibraryDatabase.execSQL(sqlEdit)
    End Sub
    Public Sub editAlmostDue()
        Dim sqlEdit As String
        sqlEdit = "UPDATE `maintenance` SET " & _
                    "maintenanceAlmostDueDays=" + MaintenanceAlmostDueDays & _
                    " WHERE maintenanceId=1;"
        LibraryDatabase.execSQL(sqlEdit)
    End Sub
End Class
