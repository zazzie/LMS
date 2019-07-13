Public Class FormManageBorrower
    Dim objFormViewBorrower As New FormViewBorrower
    Dim objBorrower As New Borrower
    Dim objFormAddBorrower As New FormAddBorrower
    Dim objFormUpdateBorrower As New FormUpdateBorrower
    Dim formImportFillObj As New FormImportFill

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Dispose()
    End Sub

    Private Sub btnAddBorrower_Click(sender As Object, e As EventArgs) Handles btnAddBorrower.Click
        objFormAddBorrower = New FormAddBorrower
        If objFormAddBorrower.ShowDialog = Windows.Forms.DialogResult.OK Then
            generateSearchAllBorrower()
        End If
    End Sub

    Private Sub btnViewBorrower_Click(sender As Object, e As EventArgs) Handles btnViewBorrower.Click
        If dgvBorrower.Rows.Count > 0 Then
            objFormViewBorrower = New FormViewBorrower
            objFormViewBorrower.viewformBorrowerId = dgvBorrower.SelectedRows(0).Cells(0).Value
            objFormViewBorrower.ShowDialog()
        End If
    End Sub

    Private Sub formSettingManageBorrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBorrower.Font = New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Point)
        rbtShowAll.Checked = True
        renameColumns()
        Timer1.Enabled = True
        Timer1.Interval = 1
        Dim dateToday As DateTime = DateTime.Now
        lblDate.Text = dateToday.ToString("D")
        'generateSearchAllBorrower()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetterOrDigit(c) Or (c = "#") Or (c = "/") Or (c = "|") Or (c = "\") Or (c = ",") Or (c = " ") Or (c = ")") Or (c = "(") Or (c = "`") Or (c = "&") Or (c = ":") Or (c = "-") Or (c = ".") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        txtSearch.Text = txtSearch.Text.ToUpper
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub
    Private Sub renameColumns()
        With dgvBorrower
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Borrower ID" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "Name"
        End With
    End Sub
    Private Sub generateSearchAllBorrowerCurrent()
        Dim sqlSearch As String
        Try
            sqlSearch = "SELECT borrowerid, borrowerFirst, borrowerMiddle, borrowerLast FROM borrower JOIN studentregistry ON borrowerId=studentRegistryBorrowerId " & _
                        "WHERE (borrowerId LIKE '[" & txtSearch.Text & "]%' OR " & _
                        "borrowerFirst LIKE '" & txtSearch.Text & "%' OR " & _
                        "borrowerMiddle LIKE '" & txtSearch.Text & "%' OR " & _
                        "borrowerLast LIKE '" & txtSearch.Text & "%' OR " & _
                        "borrowerGender LIKE '" & txtSearch.Text & "%' OR " &
                        "borrowerBirth LIKE '" & txtSearch.Text & "%' OR " & _
                        "borrowerPhone LIKE '" & txtSearch.Text & "%' OR " & _
                        "borrowerStreet LIKE '" & txtSearch.Text & "%' OR " & _
                        "borrowerType LIKE '" & txtSearch.Text & "%' OR " & _
                        "borrowerBarangayId = (SELECT DISTINCT barangayId FROM barangay WHERE barangayName ='" & txtSearch.Text.ToUpper & "') OR " & _
                        "borrowerCityId = (SELECT DISTINCT cityId FROM city WHERE cityName ='" & txtSearch.Text.ToUpper & "')) " & _
                        "AND studentRegistrySchoolYearId=" + FormLogin.ObjMaintenance.MaintenanceSchlYrId + ";"
            Dim ds As DataSet
            dgvBorrower.Rows.Clear()
            ds = LibraryDatabase.fetchSQL(sqlSearch)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With dgvBorrower
                        dgvBorrower.Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                             ds.Tables(0).Rows(index).Item(3).ToString.Trim + ", " + ds.Tables(0).Rows(index).Item(1).ToString.Trim + " " + ds.Tables(0).Rows(index).Item(2).ToString.Trim)
                    End With
                    index += 1
                End While
                dgvBorrower.Refresh()
                dgvBorrower.Select()
                txtSearch.Select()
            Else
                dgvBorrower.Rows.Clear()
                If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                    MessageBox.Show("No borrower results found for `" + txtSearch.Text + "' from SY " + FormLogin.ObjMaintenance.MaintenanceSchoolYear + ".", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSearch.Select()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub generateSearchAllBorrower()
        Dim sqlSearch As String
        Try
            sqlSearch = "SELECT DISTINCT `borrowerId`, `borrowerFirst`, `borrowerMiddle`, `borrowerLast` " & _
                        "FROM `borrower` " & _
                        "WHERE borrowerId LIKE '[" & txtSearch.Text & "]%' OR " & _
                        "borrowerFirst LIKE '" & txtSearch.Text & "%' OR " & _
                        "borrowerMiddle LIKE '" & txtSearch.Text & "%' OR " & _
                        "borrowerLast LIKE '" & txtSearch.Text & "%' OR " & _
                        "borrowerGender LIKE '" & txtSearch.Text & "%' OR " & _
                        "borrowerBirth LIKE '" & txtSearch.Text & "%' OR " & _
                        "borrowerPhone LIKE '" & txtSearch.Text & "%' OR " & _
                        "borrowerStreet LIKE '" & txtSearch.Text & "%' OR " & _
                        "borrowerType LIKE '" & txtSearch.Text & "%' OR " & _
                        "borrowerBarangayId = (SELECT DISTINCT barangayId FROM barangay WHERE barangayName ='" & txtSearch.Text.ToUpper & "') OR " & _
                        "borrowerCityId = (SELECT DISTINCT cityId FROM city WHERE cityName ='" & txtSearch.Text.ToUpper & "');"
            Dim ds As DataSet
            dgvBorrower.Rows.Clear()
            ds = LibraryDatabase.fetchSQL(sqlSearch)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With dgvBorrower
                        dgvBorrower.Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                             ds.Tables(0).Rows(index).Item(3).ToString.Trim + ", " + ds.Tables(0).Rows(index).Item(1).ToString.Trim + " " + ds.Tables(0).Rows(index).Item(2).ToString.Trim)
                    End With
                    index += 1
                End While
                dgvBorrower.Refresh()
                dgvBorrower.Select()
                txtSearch.Select()
            Else
                dgvBorrower.Rows.Clear()
                If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                    MessageBox.Show("No borrower results found for `" + txtSearch.Text + "'.", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSearch.Select()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub generateSearchBorrowerIDCurrent()
        Dim sqlSearch As String
        Try
            sqlSearch = "SELECT DISTINCT `borrowerId`, `borrowerFirst`, `borrowerMiddle`, `borrowerLast`" & _
                        " FROM `borrower` JOIN `studentregistry` " & _
                        "ON `borrowerId`=`studentRegistryBorrowerId` WHERE borrowerId = " & txtSearch.Text & " AND studentRegistrySchoolYearId=" + FormLogin.ObjMaintenance.MaintenanceSchlYrId + " ;"

            Dim ds As DataSet
            dgvBorrower.Rows.Clear()
            ds = LibraryDatabase.fetchSQL(sqlSearch)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With dgvBorrower
                        dgvBorrower.Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                             ds.Tables(0).Rows(index).Item(3).ToString.Trim + ", " + ds.Tables(0).Rows(index).Item(1).ToString.Trim + " " + ds.Tables(0).Rows(index).Item(2).ToString.Trim)
                    End With
                    index += 1
                End While
                dgvBorrower.Refresh()
                dgvBorrower.Select()
                txtSearch.Select()
            Else
                dgvBorrower.Rows.Clear()
                If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                    MessageBox.Show("No borrower results found from the ID: `" + txtSearch.Text + "' from SY " + FormLogin.ObjMaintenance.MaintenanceSchoolYear + ".", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSearch.Select()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub generateSearchBorrowerNameCurrent()
        Dim sqlSearch As String
        Try
            sqlSearch = "SELECT DISTINCT `borrowerId`, `borrowerFirst`, `borrowerMiddle`, `borrowerLast` " & _
                        "FROM `borrower` JOIN `studentregistry` " & _
                        "ON `borrowerId`=`studentRegistryBorrowerId` WHERE (borrowerFirst LIKE '" & txtSearch.Text & "%' OR " & _
                        "borrowerMiddle LIKE '" & txtSearch.Text & "%' OR " & _
                        "borrowerLast LIKE '" & txtSearch.Text & "%') AND studentRegistrySchoolYearId=" + FormLogin.ObjMaintenance.MaintenanceSchlYrId + " ;"
            Dim ds As DataSet
            dgvBorrower.Rows.Clear()
            ds = LibraryDatabase.fetchSQL(sqlSearch)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With dgvBorrower
                        dgvBorrower.Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                             ds.Tables(0).Rows(index).Item(3).ToString.Trim + ", " + ds.Tables(0).Rows(index).Item(1).ToString.Trim + " " + ds.Tables(0).Rows(index).Item(2).ToString.Trim)
                    End With
                    index += 1
                End While
                dgvBorrower.Refresh()
                dgvBorrower.Select()
                txtSearch.Select()
            Else
                dgvBorrower.Rows.Clear()
                If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                    MessageBox.Show("No borrower name results found for `" + txtSearch.Text + "' from SY " + FormLogin.ObjMaintenance.MaintenanceSchoolYear + ".", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSearch.Select()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub generateSearchBorrowerID()
        Dim sqlSearch As String
        Try
            sqlSearch = "SELECT DISTINCT `borrowerId`, `borrowerFirst`, `borrowerMiddle`, `borrowerLast`" & _
                        " FROM `borrower` " & _
                        "WHERE borrowerId = " & txtSearch.Text & " ;"
            Dim ds As DataSet
            dgvBorrower.Rows.Clear()
            ds = LibraryDatabase.fetchSQL(sqlSearch)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With dgvBorrower
                        dgvBorrower.Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                             ds.Tables(0).Rows(index).Item(3).ToString.Trim + ", " + ds.Tables(0).Rows(index).Item(1).ToString.Trim + " " + ds.Tables(0).Rows(index).Item(2).ToString.Trim)
                    End With
                    index += 1
                End While
                dgvBorrower.Refresh()
                dgvBorrower.Select()
                txtSearch.Select()
            Else
                dgvBorrower.Rows.Clear()
                If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                    MessageBox.Show("No borrower results found from the ID: `" + txtSearch.Text + "'.", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSearch.Select()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub generateSearchBorrowerName()
        Dim sqlSearch As String
        Try
            sqlSearch = "SELECT DISTINCT `borrowerId`, `borrowerFirst`, `borrowerMiddle`, `borrowerLast`, " & _
                        "`borrowerGender`, `borrowerBirth`, `borrowerPhone`, `borrowerStreet`, `borrowerBarangayId`, " & _
                        "`borrowerCityId`, `borrowerType` " & _
                        "FROM `borrower` " & _
                        "WHERE borrowerFirst LIKE '" & txtSearch.Text & "%' OR " & _
                        "borrowerMiddle LIKE '" & txtSearch.Text & "%' OR " & _
                        "borrowerLast LIKE '" & txtSearch.Text & "%' ;"
            Dim ds As DataSet
            dgvBorrower.Rows.Clear()
            ds = LibraryDatabase.fetchSQL(sqlSearch)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With dgvBorrower
                        dgvBorrower.Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                             ds.Tables(0).Rows(index).Item(3).ToString.Trim + ", " + ds.Tables(0).Rows(index).Item(1).ToString.Trim + " " + ds.Tables(0).Rows(index).Item(2).ToString.Trim)
                    End With
                    index += 1
                End While
                dgvBorrower.Refresh()
                dgvBorrower.Select()
                txtSearch.Select()
            Else
                dgvBorrower.Rows.Clear()
                If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                    MessageBox.Show("No borrower name results found for `" + txtSearch.Text + "'.", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSearch.Select()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnSearchAll_Click(sender As Object, e As EventArgs) Handles btnSearchAll.Click
        If rbtShowAll.Checked = True Then
            If IsNumeric(txtSearch.Text) Then
                generateSearchBorrowerID()
            Else
                generateSearchAllBorrower()
            End If
        ElseIf rbtShowCurrent.Checked = True Then
            If IsNumeric(txtSearch.Text) Then
                generateSearchBorrowerIDCurrent()
            Else
                generateSearchAllBorrowerCurrent()
            End If
        End If

    End Sub

    Private Sub btnSearchBorrowerId_Click(sender As Object, e As EventArgs) Handles btnSearchBorrowerId.Click
        If rbtShowAll.Checked = True Then
            If IsNumeric(txtSearch.Text) Then
                generateSearchBorrowerID()
            Else
                dgvBorrower.Rows.Clear()
                If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                    MessageBox.Show("Invalid ID. No results found for ID search: `" + txtSearch.Text + "'.", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSearch.Select()
                End If
            End If
        ElseIf rbtShowCurrent.Checked = True Then
            If IsNumeric(txtSearch.Text) Then
                generateSearchBorrowerIDCurrent()
            Else
                dgvBorrower.Rows.Clear()
                If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                    MessageBox.Show("Invalid ID. No results found for ID search: `" + txtSearch.Text + "' from SY " + FormLogin.ObjMaintenance.MaintenanceSchoolYear + ".", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSearch.Select()
                End If
            End If
        End If

    End Sub

    Private Sub btnSearchName_Click(sender As Object, e As EventArgs) Handles btnSearchName.Click
        If rbtShowAll.Checked = True Then
            generateSearchBorrowerName()
        ElseIf rbtShowCurrent.Checked = True Then
            generateSearchBorrowerNameCurrent()
        End If

    End Sub

    Private Sub btnDeleteBorrower_Click(sender As Object, e As EventArgs) Handles btnDeleteBorrower.Click
        If dgvBorrower.Rows.Count > 0 Then
            Dim ans As Integer
            ans = MsgBox("Are you sure you want to remove '" + dgvBorrower.SelectedRows(0).Cells(1).Value.ToString.Trim + "' from the borrower list?", MsgBoxStyle.YesNo, "Remove Borrower")
            If ans = MsgBoxResult.Yes Then
                objBorrower.BorrowerId = dgvBorrower.SelectedRows(0).Cells(0).Value
                objBorrower.deleteBorrower()
                MessageBox.Show("You have successfully deleted " + dgvBorrower.SelectedRows(0).Cells(1).Value.ToString.Trim + " from the list.", "Deleted Record")
                txtSearch.Clear()
                dgvBorrower.Rows.Clear()
            End If
        End If
    End Sub

    Private Sub btnUpdateBorrower_Click(sender As Object, e As EventArgs) Handles btnUpdateBorrower.Click
        If dgvBorrower.Rows.Count > 0 Then
            objFormUpdateBorrower = New FormUpdateBorrower
            objFormUpdateBorrower.UpdateformBorrowerId = dgvBorrower.SelectedRows(0).Cells(0).Value
            objFormUpdateBorrower.txtBorrowerId.Focus()
            If objFormUpdateBorrower.ShowDialog = Windows.Forms.DialogResult.OK Then
                generateSearchAllBorrower()
            End If
        End If
    End Sub

    Private Sub btnImportBorrower_Click(sender As Object, e As EventArgs) Handles btnImportBorrower.Click
        formImportFillObj = New formImportFill
        formImportFillObj.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
    End Sub

    Private Sub dgvBorrower_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBorrower.CellContentClick

    End Sub

    Private Sub dgvBorrower_DoubleClick(sender As Object, e As EventArgs) Handles dgvBorrower.DoubleClick
        If dgvBorrower.Rows.Count > 0 Then
            objFormViewBorrower = New FormViewBorrower
            objFormViewBorrower.viewformBorrowerId = dgvBorrower.SelectedRows(0).Cells(0).Value
            objFormViewBorrower.ShowDialog()
        End If
    End Sub
End Class