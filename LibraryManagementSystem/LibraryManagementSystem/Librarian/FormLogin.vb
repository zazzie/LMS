Public Class FormLogin
    Dim dsMaintenance As DataSet
    Private _objMaintenance As New AdvancedSettings
    Public Property ObjMaintenance
        Get
            Return _objMaintenance
        End Get
        Set(value)
            _objMaintenance = value
        End Set
    End Property
    'Public ObjMaintenance As New AdvancedSettings

    Private Sub loadMaintenance()
        Try
            dsMaintenance = LibraryDatabase.fetchSQL("SELECT * FROM `maintenance` WHERE `maintenanceId`=1")
            If dsMaintenance.Tables(0).Rows.Count > 0 Then
                ObjMaintenance.MaintenanceId = dsMaintenance.Tables(0).Rows(0).Item(0).ToString.Trim
                ObjMaintenance.MaintenanceMission = dsMaintenance.Tables(0).Rows(0).Item(1).ToString.Trim
                ObjMaintenance.MaintenanceVision = dsMaintenance.Tables(0).Rows(0).Item(2).ToString.Trim
                ObjMaintenance.MaintenanceSchlYrId = dsMaintenance.Tables(0).Rows(0).Item(3).ToString.Trim
                ObjMaintenance.MaintenanceSchoolYear = dsMaintenance.Tables(0).Rows(0).Item(4).ToString.Trim
                ObjMaintenance.MaintenanceFine = dsMaintenance.Tables(0).Rows(0).Item(5).ToString.Trim
                ObjMaintenance.MaintenanceBookPriceFine = dsMaintenance.Tables(0).Rows(0).Item(6).ToString.Trim
                ObjMaintenance.MaintenanceBookLimit = dsMaintenance.Tables(0).Rows(0).Item(7).ToString.Trim
                ObjMaintenance.MaintenanceAlmostDueDays = dsMaintenance.Tables(0).Rows(0).Item(8).ToString.Trim
                ObjMaintenance.MaintenanceSemesterId = dsMaintenance.Tables(0).Rows(0).Item(9).ToString.Trim
                ObjMaintenance.MaintenanceSemester = dsMaintenance.Tables(0).Rows(0).Item(10).ToString.Trim
            Else
                ObjMaintenance.createMaintenance()
                loadMaintenance()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnLibrarianLogin_Click(sender As Object, e As EventArgs) Handles btnLibrarianLogin.Click
        FormMain.Show()
        Me.Hide()
    End Sub

    Private Sub FormLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadMaintenance()
    End Sub

    Private Sub btnConfigureDB_Click(sender As Object, e As EventArgs) Handles btnConfigureDB.Click
        FormDatabaseConfiguration.ShowDialog()
    End Sub
End Class