Public Class FormBarangayCity
    Dim cityObj As New City
    Dim brgyObj As New Barangay
    Dim availableBrgyId As Integer
    Private addBarangayObj As New FormNewBarangays

    Private Sub renameColumns()
        With dgvBarangay
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "Barangay"
        End With
        With dgvCity
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "City"
        End With
    End Sub
    Private Sub enableButtons(ByVal flag As Boolean)
        btnAddCity.Enabled = flag
        btnEditBrgy.Enabled = flag
        btnEditCity.Enabled = flag
        btnRemoveBrgy.Enabled = flag
        btnRemoveCity.Enabled = flag
    End Sub
    'Private Sub revertFormSettings()
    '    enableButtons(True)
    '    btnAddCity.Text = "Add"
    '    btnRemoveCity.Text = "Remove"
    '    btnEditBrgy.Text = "Edit"
    '    btn()
    '    btnRemoveBrgy.Text = "Remove"
    '    dgvCity.Enabled = True
    '    dgvBarangay.Enabled = True
    '    txtCity.Enabled = False
    '    txtBarangay.Enabled = False
    '    generateCity()
    '    generateBarangay()
    'End Sub
    Private Sub generateCity()
        Dim sqlSearch As String
        Try
            sqlSearch = "SELECT `cityId`, `cityName` FROM `city` ORDER BY cityId ASC ;"
            Dim ds As DataSet
            dgvCity.Rows.Clear()
            ds = LibraryDatabase.fetchSQL(sqlSearch)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With dgvCity
                        dgvCity.Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                        ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                    End With
                    index += 1
                End While
                dgvCity.Refresh()
                dgvCity.Select()
                displayCity()
            Else
                dgvCity.Rows.Clear()
                txtCity.Clear()
                dgvBarangay.Rows.Clear()
                txtBarangay.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        'dgvCity.DataSource = LibraryDatabase.fetchSQL("SELECT `cityId`, `cityName` FROM `city` ORDER BY cityName ASC ;").Tables(0)
        'dgvCity.Refresh()
        'dgvCity.Select()
    End Sub

    Private Sub generateBarangay()
        If dgvCity.Rows.Count > 0 Then
            Dim sqlSearch As String
            Try
                sqlSearch = "SELECT `barangayId`, `barangayName`, `barangayCityId` FROM `barangay` WHERE barangayCityId=" + dgvCity.SelectedRows(0).Cells(0).Value.ToString + " ORDER BY barangayName;"
                Dim ds As DataSet
                dgvBarangay.Rows.Clear()
                ds = LibraryDatabase.fetchSQL(sqlSearch)
                If ds.Tables(0).Rows.Count > 0 Then
                    Dim index As Integer = 0
                    While index < ds.Tables(0).Rows.Count
                        With dgvBarangay
                            dgvBarangay.Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                            ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                        End With
                        index += 1
                    End While
                    dgvBarangay.Refresh()
                    displayBarangay()
                Else
                    dgvBarangay.Rows.Clear()
                    txtBarangay.Clear()
                End If

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub

    Private Sub displayCity()
        If dgvCity.Rows.Count > 0 Then
            txtCity.Text = dgvCity.SelectedRows(0).Cells(1).Value.ToString
        End If
    End Sub

    Private Sub displayBarangay()
        If dgvBarangay.Rows.Count > 0 Then
            txtBarangay.Text = dgvBarangay.SelectedRows(0).Cells(1).Value.ToString
        End If
    End Sub
    Private Sub addNewCityBrgy()
        Dim sqlInsert As String
        cityObj.CityId = LibraryDatabase.GenerateID("SELECT MAX(cityId) FROM city;")
        cityObj.CityName = txtCity.Text

        sqlInsert = "INSERT INTO `city`(`cityId`, `cityName`) VALUES (" & _
                                cityObj.CityId.ToString + ",'" & _
                                cityObj.CityName + "');"

        'adding each barangay/more like listing each
        brgyObj.BarangayCityId = cityObj.CityId
        For Each row As DataGridViewRow In dgvBarangay.Rows
            brgyObj.BarangayId = row.Cells(0).Value.ToString.Trim
            brgyObj.BarangayName = row.Cells(1).Value.ToString.Trim

            sqlInsert += "INSERT INTO `barangay`(`barangayId`, `barangayName`, `barangayCityId`) VALUES (" & _
                                                brgyObj.BarangayId.ToString + ",'" & _
                                                brgyObj.BarangayName + "'," & _
                                                brgyObj.BarangayCityId.ToString + ");"
        Next

        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Private Sub formBarangayCity_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub formBarangayCity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBarangay.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        dgvCity.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        renameColumns()
        generateCity()
        generateBarangay()

    End Sub

    Private Sub txtCity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCity.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetter(c) Or (c = " ") Or (c = "-") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBarangay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBarangay.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetterOrDigit(c) Or (c = " ") Or (c = "-") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgvCity_Click(sender As Object, e As EventArgs) Handles dgvCity.Click
        If dgvCity.Rows.Count > 0 Then
            displayCity()
            generateBarangay()
        Else
            dgvCity.Rows.Clear()
            txtCity.Clear()
            dgvBarangay.Rows.Clear()
            txtBarangay.Clear()
        End If
    End Sub

    Private Sub dgvBarangay_Click(sender As Object, e As EventArgs) Handles dgvBarangay.Click
        If dgvBarangay.Rows.Count > 0 Then
            displayBarangay()
        Else
            dgvBarangay.Rows.Clear()
            txtBarangay.Clear()
        End If
    End Sub

    Private Sub btnAddCity_Click(sender As Object, e As EventArgs) Handles btnAddCity.Click
        If btnAddCity.Text = "Add" Then
            btnAddCity.Text = "Save"
            btnRemoveCity.Text = "Cancel"
            btnEditCity.Enabled = False
            btnEditBrgy.Text = "Add"
            btnRemoveBrgy.Text = "Remove From List"
            dgvCity.Enabled = False
            txtCity.Clear()
            txtBarangay.Clear()
            dgvBarangay.Rows.Clear()
            txtCity.Enabled = True
            txtBarangay.Enabled = True
            txtCity.Focus()
            availableBrgyId = LibraryDatabase.GenerateID("select max(barangayId) from barangay;")
        ElseIf btnAddCity.Text = "Save" Then
            If Not String.IsNullOrWhiteSpace(txtCity.Text) Then
                If dgvCity.Rows.Count > 0 Then
                    If LibraryDatabase.isExisting("SELECT COUNT(*) FROM city WHERE cityName='" + txtCity.Text + "';") = False Then
                        If Not dgvBarangay.Rows.Count = 0 Then

                            addNewCityBrgy()
                            MessageBox.Show("You have successfully added a new City in the record!", "New City Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                            btnAddCity.Text = "Add"
                            btnRemoveCity.Text = "Remove"
                            btnEditCity.Enabled = True
                            btnEditBrgy.Text = "Edit"
                            btnRemoveBrgy.Text = "Remove"
                            dgvCity.Enabled = True
                            txtCity.Enabled = False
                            txtBarangay.Enabled = False
                            generateCity()
                            generateBarangay()
                        Else
                            MessageBox.Show("At least one Barangay Name is required to be added along the City!", "Required Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtBarangay.Focus()
                        End If
                    Else
                        MessageBox.Show("A record of the City Name already exists!", "Existing City", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtCity.Focus()
                    End If
                ElseIf dgvCity.Rows.Count = 0 Then
                    If Not dgvBarangay.Rows.Count = 0 Then

                        addNewCityBrgy()
                        MessageBox.Show("You have successfully added a new City in the record!", "New City Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                        btnAddCity.Text = "Add"
                        btnRemoveCity.Text = "Remove"
                        btnEditCity.Enabled = True
                        btnEditBrgy.Text = "Edit"
                        btnRemoveBrgy.Text = "Remove"
                        dgvCity.Enabled = True
                        txtCity.Enabled = False
                        txtBarangay.Enabled = False
                        generateCity()
                        generateBarangay()
                    Else
                        MessageBox.Show("At least one Barangay Name is required to be added along the City!", "Required Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtBarangay.Focus()
                    End If
                End If
            Else
                MessageBox.Show("City Name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCity.Focus()
            End If
        End If
    End Sub

    Private Sub btnEditCity_Click(sender As Object, e As EventArgs) Handles btnEditCity.Click
        If dgvCity.Rows.Count > 0 Then
            If btnEditCity.Text = "Edit" Then
                enableButtons(False)
                btnEditCity.Enabled = True
                btnRemoveCity.Enabled = True
                txtCity.Enabled = True
                btnRemoveBrgy.Enabled = True
                btnRemoveBrgy.Text = "Add New"
                btnEditCity.Text = "Update"
                btnRemoveCity.Text = "Cancel"
                cityObj.CityId = dgvCity.SelectedRows(0).Cells(0).Value.ToString
                dgvCity.Enabled = False
                dgvBarangay.Enabled = False
            ElseIf btnEditCity.Text = "Update" Then
                If Not String.IsNullOrWhiteSpace(txtCity.Text) Then
                    If dgvCity.Rows.Count > 0 Then
                        If LibraryDatabase.isExisting("SELECT COUNT(*) FROM city WHERE cityName='" + txtCity.Text + "' and cityId!=" + cityObj.CityId.ToString + ";") = False Then
                            'actual updating process here
                            cityObj.CityName = txtCity.Text
                            cityObj.editCity()

                            MessageBox.Show("You have successfully updated a City in the record!", "Updated City", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                            enableButtons(True)
                            btnEditCity.Text = "Edit"
                            btnRemoveCity.Text = "Remove"
                            btnRemoveBrgy.Text = "Remove"
                            dgvCity.Enabled = True
                            dgvBarangay.Enabled = True
                            txtCity.Enabled = False
                            generateCity()
                            generateBarangay()
                        Else
                            MessageBox.Show("A record of the City Name already exists!", "Existing City", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtCity.Focus()
                        End If
                    End If
                Else
                    MessageBox.Show("City Name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCity.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub btnRemoveCity_Click(sender As Object, e As EventArgs) Handles btnRemoveCity.Click
        If btnRemoveCity.Text = "Remove" Then
            If dgvCity.Rows.Count > 0 Then
                'If ClassLibraryDB.isExisting("SELECT COUNT(*) FROM register WHERE registerLevelId=" + dgvLevel.SelectedRows(0).Cells(0).Value.ToString + ";") = False Then
                Dim ans As Integer
                ans = MsgBox("You are about to delete the City: '" + txtCity.Text + "'. By proceeding, barangays affiliated with this city will also be deleted. Proceed?", MsgBoxStyle.YesNo, "Remove City")
                If ans = MsgBoxResult.Yes Then
                    cityObj.CityId = dgvCity.SelectedRows(0).Cells(0).Value.ToString

                    Dim sqlDelete As String
                    sqlDelete = "DELETE FROM `barangay` " & _
                                "WHERE barangayCityId= " + cityObj.CityId.ToString & ";" & _
                                "DELETE FROM `city` " & _
                                "WHERE cityId= " + cityObj.CityId.ToString & ";"

                    LibraryDatabase.execSQL(sqlDelete)

                    MessageBox.Show("You have successfully deleted a city and its affiliated barangays from the record.", "Deleted City", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                    generateCity()
                    generateBarangay()
                End If
                'Else
                '    MessageBox.Show("You are not allowed to delete this student level. An existing record from the registered borrowers is affiliated with this record.", "Unable To Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '    refreshData()
                'End If
            End If
        ElseIf btnRemoveCity.Text = "Cancel" Then
            enableButtons(True)
            btnAddCity.Text = "Add"
            btnRemoveCity.Text = "Remove"
            btnEditBrgy.Text = "Edit"
            btnRemoveBrgy.Text = "Remove"
            btnEditCity.Text = "Edit"
            txtCity.Enabled = False
            txtBarangay.Enabled = False
            dgvCity.Enabled = True
            dgvBarangay.Enabled = True
            generateCity()
            generateBarangay()
        End If
    End Sub
    Private Function isExistInList(ByVal sectionName As String) As Boolean
        Dim count As Integer = 0
        For Each row As DataGridViewRow In dgvBarangay.Rows
            If sectionName = row.Cells(1).Value.ToString.Trim Then
                count += 1
            End If
        Next
        If count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub btnEditBrgy_Click(sender As Object, e As EventArgs) Handles btnEditBrgy.Click
        If btnEditBrgy.Text = "Add" Then
            If Not String.IsNullOrWhiteSpace(txtBarangay.Text) Then
                If isExistInList(txtBarangay.Text) = False Then
                    Dim addRow As String() = New String() {availableBrgyId.ToString, txtBarangay.Text}
                    dgvBarangay.Rows.Add(addRow)
                    availableBrgyId += 1
                    txtBarangay.Clear()
                    txtBarangay.Focus()
                Else
                    MessageBox.Show("Barangay Name is already in the list!", "Already Listed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtBarangay.Focus()
                End If
            Else
                MessageBox.Show("Barangay Name input is empty!", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtBarangay.Focus()
            End If
        ElseIf btnEditBrgy.Text = "Edit" Then
            If dgvBarangay.RowCount > 0 Then

                brgyObj.BarangayId = dgvBarangay.SelectedRows(0).Cells(0).Value.ToString
                brgyObj.BarangayCityId = dgvCity.SelectedRows(0).Cells(0).Value.ToString
                dgvCity.Enabled = False
                dgvBarangay.Enabled = False
                txtCity.Enabled = False
                txtBarangay.Enabled = True
                enableButtons(False)
                btnEditBrgy.Text = "Update"
                btnRemoveBrgy.Text = "Cancel"
                btnEditBrgy.Enabled = True
                btnRemoveBrgy.Enabled = True
                txtBarangay.Focus()
            End If
        ElseIf btnEditBrgy.Text = "Update" Then
            If Not String.IsNullOrWhiteSpace(txtBarangay.Text) Then
                If LibraryDatabase.isExisting("SELECT COUNT(*) FROM barangay WHERE barangayName='" + txtBarangay.Text + "' and barangayCityId=" + brgyObj.BarangayCityId.ToString + " and barangayId !=" + brgyObj.BarangayId.ToString + ";") = False Then
                    brgyObj.BarangayName = txtBarangay.Text
                    brgyObj.editBarangay()
                    MessageBox.Show("You have successfully updated this barangay name!", "Updated Barangay Name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    dgvCity.Enabled = True
                    dgvBarangay.Enabled = True
                    txtCity.Enabled = False
                    txtBarangay.Enabled = False
                    enableButtons(True)
                    btnEditBrgy.Text = "Edit"
                    btnRemoveBrgy.Text = "Remove"
                    generateCity()
                    generateBarangay()
                Else
                    MessageBox.Show("Barangay Name already exist in " + txtCity.Text + "!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtBarangay.Focus()
                End If
            Else
                MessageBox.Show("Barangay Name input is empty!", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtBarangay.Focus()
            End If
        End If
    End Sub

    Private Sub btnRemoveBrgy_Click(sender As Object, e As EventArgs) Handles btnRemoveBrgy.Click
        If btnRemoveBrgy.Text = "Remove" Then
            If dgvBarangay.RowCount > 0 Then
                'If LibraryDatabase.isExisting("SELECT COUNT(*) FROM register WHERE registerSectionId=" + dgvSection.SelectedRows(0).Cells(0).Value.ToString + ";") = False Then
                If LibraryDatabase.fetchSQL("SELECT * FROM barangay WHERE barangayCityId='" + dgvCity.SelectedRows(0).Cells(0).Value.ToString.Trim + "';").Tables(0).Rows.Count = 1 Then
                    Dim ans As Integer
                    ans = MsgBox("This is the last barangay listed from '" + txtCity.Text + "'. By proceeding, '" + txtCity.Text + "'  will also be deleted. Proceed?", MsgBoxStyle.YesNo, "Remove Barangay")
                    If ans = MsgBoxResult.Yes Then
                        brgyObj.BarangayCityId = dgvCity.SelectedRows(0).Cells(0).Value.ToString
                        brgyObj.BarangayId = dgvBarangay.SelectedRows(0).Cells(0).Value.ToString

                        Dim sqlDelete As String
                        sqlDelete = "DELETE FROM `barangay` " & _
                                    "WHERE barangayId= " + brgyObj.BarangayId.ToString & ";" & _
                                    "DELETE FROM `city` " & _
                                    "WHERE cityId= " + brgyObj.BarangayCityId.ToString & ";"

                        LibraryDatabase.execSQL(sqlDelete)

                        MessageBox.Show("You have successfully deleted a city and barangay from the list.", "Deleted Record")
                        generateCity()
                        generateBarangay()

                    End If
                Else
                    Dim ans As Integer
                    ans = MsgBox("Are you sure you want to remove '" + txtBarangay.Text + "' from the barangay list of " + txtCity.Text + "?", MsgBoxStyle.YesNo, "Remove Barangay")
                    If ans = MsgBoxResult.Yes Then
                        brgyObj.BarangayId = dgvBarangay.SelectedRows(0).Cells(0).Value.ToString
                        brgyObj.deleteBarangay()
                        MessageBox.Show("You have successfully deleted " + txtBarangay.Text + " from the list.", "Deleted Barangay")
                        generateCity()
                        generateBarangay()
                    End If
                End If
                'Else
                '    Dim ans As Integer
                '    ans = MsgBox("You are not allowed to delete this section. An existing record from the registered borrowers is affiliated with this record. Proceed archiving this section instead. Continue?", MsgBoxStyle.YesNo, "Restriction On Delete")
                '    If ans = MsgBoxResult.Yes Then
                '        studSecObj.SectionId = dgvSection.SelectedRows(0).Cells(0).Value.ToString
                '        studSecObj.deactivateSection()
                '        MessageBox.Show("You have successfully archived the " + txtSection.Text + " from the list.", "Archived Section")
                '        refreshData()
                '    End If
                'End If
            End If
        ElseIf btnRemoveBrgy.Text = "Remove From List" Then
            If dgvBarangay.RowCount > 0 Then
                For Each removeRow As DataGridViewRow In dgvBarangay.SelectedRows
                    dgvBarangay.Rows.Remove(removeRow)
                Next
            End If
        ElseIf btnRemoveBrgy.Text = "Cancel" Then
            dgvCity.Enabled = True
            dgvBarangay.Enabled = True
            txtCity.Enabled = False
            txtBarangay.Enabled = False
            enableButtons(True)
            btnEditBrgy.Text = "Edit"
            btnRemoveBrgy.Text = "Remove"
            generateCity()
            generateBarangay()

        ElseIf btnRemoveBrgy.Text = "Add New" Then
            addBarangayObj = New formNewBarangays
            addBarangayObj.CityIdSub = dgvCity.SelectedRows(0).Cells(0).Value.ToString
            If addBarangayObj.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    generateBarangay()
                Catch ex As Exception
                    txtBarangay.Clear()
                End Try
            End If
        End If
    End Sub

    Private Sub txtCity_LostFocus(sender As Object, e As EventArgs) Handles txtCity.LostFocus
        txtCity.Text = txtCity.Text.ToUpper
    End Sub

    Private Sub txtCity_TextChanged(sender As Object, e As EventArgs) Handles txtCity.TextChanged

    End Sub

    Private Sub txtBarangay_LostFocus(sender As Object, e As EventArgs) Handles txtBarangay.LostFocus
        txtBarangay.Text = txtBarangay.Text.ToUpper
    End Sub

    Private Sub txtBarangay_TextChanged(sender As Object, e As EventArgs) Handles txtBarangay.TextChanged

    End Sub

    Private Sub dgvCity_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCity.CellContentClick

    End Sub

End Class