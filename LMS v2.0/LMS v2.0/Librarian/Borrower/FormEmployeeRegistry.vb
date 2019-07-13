Public Class FormEmployeeRegistry
    Dim dsPosition As DataSet
    Dim dsDept As DataSet
    Dim ObjFormDepartment As New FormDepartment
    Dim ObjFormPosition As New FormEmployeePosition
    Dim ObjEmployeeRegistry As New EmployeeRegistry

    Private Sub generateDepartment()
        cboDepartment.Items.Clear()
        Try
            '
            Dim ds As DataSet
            ds = LibraryDatabase.fetchSQL("SELECT DISTINCT `departmentId`, `departmentName` FROM `department` ORDER BY departmentName ASC;")
            If ds.Tables(0).Rows.Count > 0 Then
                dsDept = New DataSet
                dsDept = ds
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With cboDepartment
                        .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                    End With
                    index += 1
                End While
                cboDepartment.Refresh()
                cboDepartment.SelectedIndex = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub generatePosition()
        cboPosition.Items.Clear()
        Try
            '
            Dim ds As DataSet
            ds = LibraryDatabase.fetchSQL("SELECT DISTINCT * FROM `employeeposition` ORDER BY `employeepositionName` ASC;")
            If ds.Tables(0).Rows.Count > 0 Then
                dsPosition = New DataSet
                dsPosition = ds
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With cboPosition
                        .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                    End With
                    index += 1
                End While
                cboPosition.Refresh()
                cboPosition.SelectedIndex = 0
            Else
                Dim sqlInsert As String = "INSERT INTO `employeeposition`(`employeepositionId`, `employeepositionName`) VALUES (0,'N/A');"
                LibraryDatabase.execSQL(sqlInsert)
                generatePosition()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub addEmployee()
        If Not String.IsNullOrWhiteSpace(cboDepartment.Text) Then
            If Not String.IsNullOrWhiteSpace(cboPosition.Text) Then
                ''add
                '`employeepositionId`, `employeepositionName` FROM `employeeposition`
                ObjEmployeeRegistry.EmployeeRegistryId = LibraryDatabase.GenerateID("SELECT MAX(employeepositionId) from employeeposition;")
                ObjEmployeeRegistry.EmployeeRegistryBorrowerId = Val(lblBorrowerId.Text)
                ObjEmployeeRegistry.EmployeeRegistrySchoolYearId = Val(FormLogin.ObjMaintenance.MaintenanceSchlYrId.ToString)
                ObjEmployeeRegistry.EmployeeRegistryDepartmentId = Val(dsDept.Tables(0).Rows(cboDepartment.SelectedIndex).Item(0).ToString)
                ObjEmployeeRegistry.EmployeeRegistryPositionId = Val(dsPosition.Tables(0).Rows(cboPosition.SelectedIndex).Item(0).ToString)
                'MsgBox(cboDeptIndex.ToString)

                ObjEmployeeRegistry.addEmployeeRegistry()
                MessageBox.Show("You have successfully registered " + lblName.Text + "!", "Successfully Registered", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                'Me.Dispose()
            Else
                MessageBox.Show("Position Name is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
        MessageBox.Show("Deaprtment Name is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub displayUponLoad()
        generateDepartment()
        generatePosition()
    End Sub

    Private Sub FormEmployeeRegistry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayUponLoad()
    End Sub

    Private Sub btnDept_Click(sender As Object, e As EventArgs) Handles btnDept.Click
        ObjFormDepartment = New FormDepartment
        If ObjFormDepartment.ShowDialog = Windows.Forms.DialogResult.OK Then
            generateDepartment()
        End If
    End Sub

    Private Sub btnPosition_Click(sender As Object, e As EventArgs) Handles btnPosition.Click
        ObjFormPosition = New FormEmployeePosition
        If ObjFormPosition.ShowDialog = Windows.Forms.DialogResult.OK Then
            generatePosition()
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        addEmployee()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class