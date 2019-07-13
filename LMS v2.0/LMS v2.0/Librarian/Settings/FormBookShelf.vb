Public Class FormBookShelf
    ''' <summary>
    ''' 'restriction on input needs additional revisions
    ''' 
    ''' </summary>
    ''' <remarks></remarks>

    Dim objBookshelf As New BookShelf
    Dim objBookshelfSection As New BookShelfSection
    Dim availableSectionId As Integer
    Private objFormBookshelfSection As New FormBookShelfSectionNew

    Private Sub renameColumns()
        With dgvBookShelf
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID" 'renaming
            .Columns(1).HeaderCell.Value = "Bookshelf"
        End With
        With dgvShelfSection
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID"
            .Columns(1).HeaderCell.Value = "Bookshelf Section"
        End With
    End Sub
    Private Sub enableButtons(ByVal flag As Boolean)
        btnAddShelf.Enabled = flag
        btnEditShelf.Enabled = flag
        btnRemoveShelf.Enabled = flag
        btnEditShelfSection.Enabled = flag
        btnRemoveShelfSection.Enabled = flag
    End Sub
    Private Sub revertFormSettings()
        btnAddShelf.Text = "Add"
        btnEditShelf.Text = "Edit"
        btnRemoveShelf.Text = "Remove"
        btnEditShelfSection.Text = "Edit"
        btnRemoveShelfSection.Text = "Remove"

        btnAddShelf.Visible = True
        btnEditShelfSection.Visible = True
        enableButtons(True)

        dgvBookShelf.Enabled = True
        dgvShelfSection.Enabled = True

        txtShelf.Enabled = False
        txtShelfSection.Enabled = False
    End Sub

    Private Sub displayBookshelf()
        If dgvBookShelf.Rows.Count > 0 Then
            txtShelf.Text = dgvBookShelf.SelectedRows(0).Cells(1).Value.ToString.Trim
        End If
    End Sub

    Private Sub displayBookshelfSection()
        If dgvShelfSection.Rows.Count > 0 Then
            txtShelfSection.Text = dgvShelfSection.SelectedRows(0).Cells(1).Value.ToString.Trim
        End If
    End Sub

    Private Sub generateBookshelf()
        Dim sqlSearch As String
        Try
            sqlSearch = "SELECT `bookshelfId`, `bookshelfName` FROM `bookshelf` ORDER BY bookshelfName ASC;"
            Dim ds As DataSet
            dgvBookShelf.Rows.Clear()
            ds = LibraryDatabase.fetchSQL(sqlSearch)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With dgvBookShelf
                        .Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                  ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                    End With
                    index += 1
                End While
                dgvBookShelf.Refresh()
                dgvBookShelf.Select()
                displayBookshelf()
            Else
                Dim sqlInsert As String = "INSERT INTO `bookshelf`(`bookshelfId`, `bookshelfName`) VALUES (0,'N/A');" & _
                    "INSERT INTO `bookshelfsection`(`bookShelfSectionId`, `bookShelfSectionName`, `bookShelfSectionBookShelfId`) VALUES (0,'N/A',0);"
                LibraryDatabase.execSQL(sqlInsert)
                generateBookshelf()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub generateBookshelfSection()
        If dgvBookShelf.Rows.Count > 0 Then
            Dim sqlSearch As String
            Try
                sqlSearch = "SELECT `bookShelfSectionId`, `bookShelfSectionName`, `bookShelfSectionBookShelfId` FROM `bookshelfsection` JOIN bookshelf ON bookshelf.bookshelfId=bookshelfsection.bookShelfSectionBookShelfId WHERE bookshelf.bookshelfId=" + dgvBookShelf.SelectedRows(0).Cells(0).Value.ToString.Trim + ";"
                Dim ds As DataSet
                dgvShelfSection.Rows.Clear()
                ds = LibraryDatabase.fetchSQL(sqlSearch)
                If ds.Tables(0).Rows.Count > 0 Then
                    Dim index As Integer = 0
                    While index < ds.Tables(0).Rows.Count
                        With dgvShelfSection
                            .Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                      ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                        End With
                        index += 1
                    End While
                    dgvShelfSection.Refresh()
                    dgvShelfSection.Select()
                    displayBookshelfSection()
                Else
                    'MsgBox("HELLOOO")
                    dgvShelfSection.Rows.Clear()
                    txtShelfSection.Clear()
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            'MsgBox("hey zero bookshelf")
            dgvShelfSection.Rows.Clear()
            txtShelfSection.Clear()
        End If
    End Sub

    Private Sub addNewBookshelfAndSection()
        Dim sqlInsert As String
        objBookshelf.BookshelfId = LibraryDatabase.GenerateID("SELECT MAX(bookshelfid) FROM bookshelf;")
        objBookshelf.BookshelfName = txtShelf.Text

        sqlInsert = "INSERT INTO `bookshelf`(`bookshelfId`, `bookshelfName`) VALUES (" & _
            objBookshelf.BookshelfId.ToString + ",'" & _
            objBookshelf.BookshelfName + "');"

        'adding each item from gridview
        objBookshelfSection.BookShelfSectionBookShelfId = objBookshelf.BookshelfId
        For Each row As DataGridViewRow In dgvShelfSection.Rows
            objBookshelfSection.BookShelfSectionId = row.Cells(0).Value.ToString.Trim
            objBookshelfSection.BookShelfSectionName = row.Cells(1).Value.ToString.Trim

            sqlInsert += "INSERT INTO `bookshelfsection`(`bookShelfSectionId`, `bookShelfSectionName`, `bookShelfSectionBookShelfId`) VALUES (" & _
                objBookshelfSection.BookShelfSectionId.ToString + ",'" & _
                objBookshelfSection.BookShelfSectionName + "'," & _
                objBookshelfSection.BookShelfSectionBookShelfId.ToString + ");"
        Next
        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Private Sub FormBookShelf_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub FormBookShelf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBookShelf.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        dgvShelfSection.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        renameColumns()
        txtShelf.Clear()
        txtShelfSection.Clear()
        generateBookshelf()
        generateBookshelfSection()
    End Sub

    Private Sub txtShelf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtShelf.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetterOrDigit(c) Or (c = " ") Or (c = "#") Or (c = "*") Or (c = "`") Or (c = "-") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtShelfSection_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtShelfSection.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetterOrDigit(c) Or (c = " ") Or (c = "#") Or (c = "`") Or (c = "-") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtShelf_LostFocus(sender As Object, e As EventArgs) Handles txtShelf.LostFocus
        txtShelf.Text = txtShelf.Text.ToUpper
    End Sub

    Private Sub txtShelfSection_LostFocus(sender As Object, e As EventArgs) Handles txtShelfSection.LostFocus
        txtShelfSection.Text = txtShelfSection.Text.ToUpper
    End Sub

    Private Sub dgvBookShelf_Click(sender As Object, e As EventArgs) Handles dgvBookShelf.Click
        If dgvBookShelf.Rows.Count > 0 Then
            displayBookshelf()
            generateBookshelfSection()
        Else
            dgvBookShelf.Rows.Clear()
            txtShelf.Clear()
            dgvShelfSection.Rows.Clear()
            txtShelfSection.Clear()
        End If
    End Sub

    Private Sub dgvShelfSection_Click(sender As Object, e As EventArgs) Handles dgvShelfSection.Click
        If dgvShelfSection.Rows.Count > 0 Then
            displayBookshelfSection()
        Else
            dgvShelfSection.Rows.Clear()
            txtShelfSection.Clear()
        End If
    End Sub

    Private Sub btnAddShelf_Click(sender As Object, e As EventArgs) Handles btnAddShelf.Click
        btnAddShelf.Enabled = False
        btnAddShelf.Visible = False
        btnEditShelf.Text = "Save"
        btnRemoveShelf.Text = "Cancel"
        btnEditShelfSection.Text = "Add"
        btnRemoveShelfSection.Text = "Remove From List"
        dgvBookShelf.Enabled = False
        txtShelf.Clear()
        txtShelfSection.Clear()
        dgvShelfSection.Rows.Clear()
        txtShelf.Enabled = True
        txtShelfSection.Enabled = True
        txtShelf.Focus()
        availableSectionId = LibraryDatabase.GenerateID("SELECT MAX(bookShelfSectionId) FROM bookshelfsection;")
    End Sub

    Private Sub btnEditShelf_Click(sender As Object, e As EventArgs) Handles btnEditShelf.Click
        If btnEditShelf.Text = "Save" Then
            If Not String.IsNullOrWhiteSpace(txtShelf.Text) Then
                If dgvBookShelf.Rows.Count > 0 Then
                    Try
                        If LibraryDatabase.isExisting("SELECT COUNT(*) FROM bookshelf WHERE bookshelfName='" + txtShelf.Text + "';") = False Then
                            If Not dgvShelfSection.Rows.Count = 0 Then
                                Try
                                    addNewBookshelfAndSection()
                                    MessageBox.Show("You have successfully added a new bookshelf in the record!", "New Bookshelf Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                                    revertFormSettings()
                                    generateBookshelf()
                                    generateBookshelfSection()
                                Catch ex As Exception
                                    MsgBox(ex.Message.ToString)
                                End Try
                            Else
                                MessageBox.Show("At least one section from the new bookshelf is required!", "Required Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtShelfSection.Focus()
                            End If
                        Else
                            MessageBox.Show("A record of the same Bookshelf name already exists!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtShelf.Focus()
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try
                ElseIf dgvBookShelf.Rows.Count = 0 Then
                    If Not dgvShelfSection.Rows.Count = 0 Then
                        Try
                            addNewBookshelfAndSection()
                            MessageBox.Show("You have successfully added a new bookshelf in the record!", "New Bookshelf Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            revertFormSettings()
                            generateBookshelf()
                            generateBookshelfSection()
                        Catch ex As Exception
                            MsgBox(ex.Message.ToString)
                        End Try
                    Else
                        MessageBox.Show("At least one section from the new bookshelf is required!", "Required Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtShelfSection.Focus()
                    End If
                End If
            Else
                MessageBox.Show("Bookshelf input field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtShelf.Focus()
            End If
        ElseIf btnEditShelf.Text = "Edit" Then
            If dgvBookShelf.Rows.Count > 0 Then
                enableButtons(False)
                btnEditShelf.Enabled = True
                btnRemoveShelf.Enabled = True
                btnAddShelf.Visible = False
                btnEditShelfSection.Visible = False
                txtShelf.Enabled = True
                btnRemoveShelfSection.Enabled = True
                btnEditShelfSection.Enabled = True
                btnRemoveShelfSection.Text = "Add New Section"
                btnEditShelf.Text = "Update"
                btnRemoveShelf.Text = "Cancel"
                objBookshelf.BookshelfId = dgvBookShelf.SelectedRows(0).Cells(0).Value.ToString
                dgvBookShelf.Enabled = False
                dgvShelfSection.Enabled = False
                txtShelf.Focus()
            End If
        ElseIf btnEditShelf.Text = "Update" Then
            If Not String.IsNullOrWhiteSpace(txtShelf.Text) Then
                Try
                    If LibraryDatabase.isExisting("SELECT COUNT(*) FROM bookshelf WHERE bookshelfName='" + txtShelf.Text + "' and bookshelfId!=" + objBookshelf.BookshelfId.ToString + ";") = False Then
                        'actual updating process here
                        objBookshelf.BookshelfName = txtShelf.Text
                        objBookshelf.editBookShelf()

                        MessageBox.Show("You have successfully updated a bookshelf in the record!", "Updated Record", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                        revertFormSettings()
                        generateBookshelf()
                        generateBookshelfSection()
                    Else
                        MessageBox.Show("A record of the bookshelf name already exists!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtShelf.Focus()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
            Else
                MessageBox.Show("City Name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtShelf.Focus()
            End If
        End If
    End Sub

    Private Sub btnRemoveShelf_Click(sender As Object, e As EventArgs) Handles btnRemoveShelf.Click
        If btnRemoveShelf.Text = "Remove" Then
            If dgvBookShelf.Rows.Count > 0 Then
                'If ClassLibraryDB.isExisting("SELECT COUNT(*) FROM register WHERE registerLevelId=" + dgvLevel.SelectedRows(0).Cells(0).Value.ToString + ";") = False Then
                Dim ans As Integer
                ans = MsgBox("You are about to delete the bookshelf: '" + txtShelf.Text + "'. By proceeding, affiliated sections with this bookshelf will also be deleted. Proceed?", MsgBoxStyle.YesNo, "Remove Bookshelf")
                If ans = MsgBoxResult.Yes Then
                    objBookshelf.BookshelfId = dgvBookShelf.SelectedRows(0).Cells(0).Value.ToString

                    Dim sqlDelete As String
                    sqlDelete = "DELETE FROM `bookshelfsection` " & _
                                "WHERE bookShelfSectionBookShelfId= " + objBookshelf.BookshelfId.ToString & ";" & _
                                "DELETE FROM `bookshelf` " & _
                                "WHERE bookshelfId= " + objBookshelf.BookshelfId.ToString & ";"
                    Try
                        LibraryDatabase.execSQL(sqlDelete)

                        MessageBox.Show("You have successfully deleted a bookshelf.", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                        'revertFormSettings()
                        generateBookshelf()
                        generateBookshelfSection()
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try

                End If
                'Else
                '    MessageBox.Show("You are not allowed to delete this student level. An existing record from the registered borrowers is affiliated with this record.", "Unable To Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '    refreshData()
                'End If
            End If
        ElseIf btnRemoveShelf.Text = "Cancel" Then
            revertFormSettings()
            generateBookshelf()
            generateBookshelfSection()
        End If
    End Sub
    Private Function isExistInList(ByVal sectionName As String) As Boolean
        Dim count As Integer = 0
        For Each row As DataGridViewRow In dgvShelfSection.Rows
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

    Private Sub btnEditShelfSection_Click(sender As Object, e As EventArgs) Handles btnEditShelfSection.Click
        If btnEditShelfSection.Text = "Add" Then
            If Not String.IsNullOrWhiteSpace(txtShelfSection.Text) Then
                If isExistInList(txtShelfSection.Text) = False Then
                    Dim addRow As String() = New String() {availableSectionId.ToString, txtShelfSection.Text}
                    dgvShelfSection.Rows.Add(addRow)
                    availableSectionId += 1
                    txtShelfSection.Clear()
                    txtShelfSection.Focus()
                Else
                    MessageBox.Show("Section is already in the list!", "Already Listed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtShelfSection.Focus()
                End If
            Else
                MessageBox.Show("Section input is empty!", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtShelfSection.Focus()
            End If
        ElseIf btnEditShelfSection.Text = "Edit" Then
            If dgvShelfSection.RowCount > 0 Then

                objBookshelfSection.BookShelfSectionId = dgvShelfSection.SelectedRows(0).Cells(0).Value.ToString
                objBookshelfSection.BookShelfSectionBookShelfId = dgvBookShelf.SelectedRows(0).Cells(0).Value.ToString
                dgvBookShelf.Enabled = False
                dgvShelfSection.Enabled = False
                txtShelf.Enabled = False
                txtShelfSection.Enabled = True
                enableButtons(False)
                btnEditShelfSection.Text = "Update"
                btnRemoveShelfSection.Text = "Cancel"
                btnEditShelfSection.Enabled = True
                btnRemoveShelfSection.Enabled = True
                txtShelfSection.Focus()
            End If
        ElseIf btnEditShelfSection.Text = "Update" Then
            If Not String.IsNullOrWhiteSpace(txtShelfSection.Text) Then
                Try
                    If LibraryDatabase.isExisting("SELECT COUNT(*) FROM bookshelfsection WHERE bookShelfSectionName='" + txtShelfSection.Text + "' and bookShelfSectionBookShelfId=" + objBookshelfSection.BookShelfSectionBookShelfId.ToString + " and bookShelfSectionId !=" + objBookshelfSection.BookShelfSectionId.ToString + ";") = False Then
                        objBookshelfSection.BookShelfSectionName = txtShelfSection.Text
                        objBookshelfSection.editBookShelfSection()
                        MessageBox.Show("You have successfully updated this bookshelf section!", "Updated Record", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        revertFormSettings()
                        generateBookshelf()
                        generateBookshelfSection()
                    Else
                        MessageBox.Show("Section Name already exist in " + txtShelf.Text + "!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtShelfSection.Focus()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
            Else
                MessageBox.Show("Section input field is empty!", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtShelfSection.Focus()
            End If
        End If
    End Sub

    Private Sub btnRemoveShelfSection_Click(sender As Object, e As EventArgs) Handles btnRemoveShelfSection.Click
        If btnRemoveShelfSection.Text = "Remove" Then
            If dgvShelfSection.RowCount > 0 Then
                'If LibraryDatabase.isExisting("SELECT COUNT(*) FROM register WHERE registerSectionId=" + dgvSection.SelectedRows(0).Cells(0).Value.ToString + ";") = False Then
                If LibraryDatabase.fetchSQL("SELECT * FROM bookshelfsection WHERE bookShelfSectionBookShelfId='" + dgvBookShelf.SelectedRows(0).Cells(0).Value.ToString.Trim + "';").Tables(0).Rows.Count = 1 Then
                    Dim ans As Integer
                    ans = MsgBox("This is the last bookshelf section listed from '" + txtShelf.Text + "'. By proceeding, '" + txtShelf.Text + "'  will also be deleted. Proceed?", MsgBoxStyle.YesNo, "Remove Section")
                    If ans = MsgBoxResult.Yes Then
                        objBookshelfSection.BookShelfSectionBookShelfId = dgvBookShelf.SelectedRows(0).Cells(0).Value.ToString
                        objBookshelfSection.BookShelfSectionId = dgvShelfSection.SelectedRows(0).Cells(0).Value.ToString

                        Dim sqlDelete As String
                        sqlDelete = "DELETE FROM `bookshelfsection` " & _
                                    "WHERE bookShelfSectionId= " + objBookshelfSection.BookShelfSectionId.ToString & ";" & _
                                    "DELETE FROM `bookshelf` " & _
                                    "WHERE bookshelfId= " + objBookshelfSection.BookShelfSectionBookShelfId.ToString & ";"

                        LibraryDatabase.execSQL(sqlDelete)

                        MessageBox.Show("You have successfully deleted " + txtShelf.Text + " from the list.", "Deleted Record")
                        generateBookshelf()
                        generateBookshelfSection()
                    End If
                Else
                    Dim ans As Integer
                    ans = MsgBox("Are you sure you want to remove '" + txtShelfSection.Text + "' from the sections of " + txtShelf.Text + "?", MsgBoxStyle.YesNo, "Remove Barangay")
                    If ans = MsgBoxResult.Yes Then
                        objBookshelfSection.BookShelfSectionId = dgvShelfSection.SelectedRows(0).Cells(0).Value.ToString
                        objBookshelfSection.deleteBookShelfSection()
                        MessageBox.Show("You have successfully deleted " + txtShelfSection.Text + " from the list.", "Deleted Section")
                        generateBookshelf()
                        generateBookshelfSection()
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
        ElseIf btnRemoveShelfSection.Text = "Remove From List" Then
            If dgvShelfSection.RowCount > 0 Then
                For Each removeRow As DataGridViewRow In dgvShelfSection.SelectedRows
                    dgvShelfSection.Rows.Remove(removeRow)
                    txtShelfSection.Clear()
                    txtShelfSection.Focus()
                Next
            End If
        ElseIf btnRemoveShelfSection.Text = "Cancel" Then
            revertFormSettings()
            generateBookshelf()
            generateBookshelfSection()

        ElseIf btnRemoveShelfSection.Text = "Add New Section" Then
            objFormBookshelfSection = New FormBookShelfSectionNew
            objFormBookshelfSection.BookshelfIdSub = dgvBookShelf.SelectedRows(0).Cells(0).Value.ToString
            If objFormBookshelfSection.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    revertFormSettings()
                    generateBookshelf()
                    generateBookshelfSection()
                Catch ex As Exception
                    txtShelfSection.Clear()
                End Try
            End If
        End If
    End Sub

    
    Private Sub txtShelf_TextChanged(sender As Object, e As EventArgs) Handles txtShelf.TextChanged

    End Sub
End Class