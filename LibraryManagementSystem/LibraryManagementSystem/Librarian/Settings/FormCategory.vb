Public Class FormCategory

    Dim objCategory As New Category
    Dim dsCategory As DataSet

    Private Sub renameColumns()
        With dgvCategory
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "Category"
        End With
    End Sub

    Private Sub clearInputs()
        txtCategoryId.Clear()
        txtCategoryName.Clear()
        rtbDescription.Clear()
    End Sub

    Private Sub enableInput(ByVal flag As Boolean)
        txtCategoryId.Enabled = flag
        txtCategoryName.Enabled = flag
        rtbDescription.Enabled = flag
    End Sub

    Private Sub revertFormSettings()
        enableInput(False)
        enableButtons(True)
        dgvCategory.Enabled = True
        btnAddCategory.Text = "Add"
        btnEditCategory.Text = "Edit"
        btnRemoveCategory.Text = "Remove"
        btnAddCategory.Visible = True
        btnGenerate.Visible = True
    End Sub

    Private Sub enableButtons(ByVal flag As Boolean)
        btnAddCategory.Enabled = flag
        btnEditCategory.Enabled = flag
        btnRemoveCategory.Enabled = flag
    End Sub

    Private Sub displayCategory()
        If dgvCategory.Rows.Count > 0 Then
            txtCategoryId.Text = dgvCategory.SelectedRows(0).Cells(0).Value.ToString
            txtCategoryName.Text = dgvCategory.SelectedRows(0).Cells(1).Value.ToString
            rtbDescription.Text = dsCategory.Tables(0).Rows(dgvCategory.CurrentRow.Index).Item(2).ToString.Trim
        End If
    End Sub

    Private Sub generateCategory()
        Dim sqlSearch As String
        Try
            sqlSearch = "SELECT `categoryId`, `categoryName`, `categoryDescription` FROM `category`;"
            Dim ds As DataSet
            dgvCategory.Rows.Clear()
            ds = LibraryDatabase.fetchSQL(sqlSearch)
            If ds.Tables(0).Rows.Count > 0 Then
                dsCategory = ds
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With dgvCategory
                        dgvCategory.Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                        ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                    End With
                    index += 1
                End While
                dgvCategory.Refresh()
                dgvCategory.Select()
                displayCategory()
            Else
                Dim sqlInsert As String = "INSERT INTO `category`(`categoryId`, `categoryName`) VALUES ('CA00000001','N/A');"
                LibraryDatabase.execSQL(sqlInsert)
                generateCategory()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub addNewCategory()
        objCategory.CategoryId = txtCategoryId.Text
        objCategory.CategoryName = txtCategoryName.Text
        objCategory.CategoryDescription = rtbDescription.Text
        objCategory.addCategory()
    End Sub

    Private Sub editCategory()
        objCategory.CategoryIdNew = txtCategoryId.Text
        objCategory.CategoryName = txtCategoryName.Text
        objCategory.CategoryDescription = rtbDescription.Text
        objCategory.editCategory()
    End Sub

    Private Sub deleteCategory()
        objCategory.CategoryId = txtCategoryId.Text
        objCategory.deleteCategory()
    End Sub

    Private Sub formCategory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub formCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCategory.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        renameColumns()
        revertFormSettings()
        generateCategory()
    End Sub

    Private Sub txtCategoryId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCategoryId.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or (c = "." And txtCategoryId.Text.IndexOf(".") = -1) Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCategoryId_LostFocus(sender As Object, e As EventArgs) Handles txtCategoryId.LostFocus

    End Sub

    Private Sub txtCategoryName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCategoryName.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetterOrDigit(c) Or (c = " ") Or (c = "-") Or (c = ".") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCategoryName_LostFocus(sender As Object, e As EventArgs) Handles txtCategoryName.LostFocus
        txtCategoryName.Text = txtCategoryName.Text.ToUpper
    End Sub

    Private Sub rtbDescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtbDescription.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetterOrDigit(c) Or (c = " ") Or (c = "-") Or (c = ".") Or (c = "!") Or (c = "`") Or (c = "~") Or (c = "@") Or (c = "#") Or (c = "$") Or (c = "%") Or (c = "^") Or (c = "&") Or (c = "*") Or (c = ")") Or (c = "(") Or (c = ";") Or (c = "[") Or (c = ":") Or (c = "]") Or (c = "{") Or (c = "}") Or (c = "?") Or (c = ">") Or (c = ",") Or (c = "/") Or (c = "\") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub rtbDescription_LostFocus(sender As Object, e As EventArgs) Handles rtbDescription.LostFocus
        rtbDescription.Text = rtbDescription.Text.ToUpper
    End Sub

    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        btnEditCategory.Text = "Save"
        btnRemoveCategory.Text = "Cancel"
        btnAddCategory.Enabled = False
        btnAddCategory.Visible = False
        clearInputs()
        enableInput(True)
        dgvCategory.Enabled = False
        txtCategoryId.Focus()
    End Sub

    Private Sub btnRemoveCategory_Click(sender As Object, e As EventArgs) Handles btnRemoveCategory.Click
        If btnRemoveCategory.Text = "Cancel" Then
            revertFormSettings()
            generateCategory()
        ElseIf btnRemoveCategory.Text = "Remove" Then
            If dgvCategory.Rows.Count > 0 Then
                Dim ans As Integer
                ans = MsgBox("Are you sure you want to remove '" + dgvCategory.SelectedRows(0).Cells(1).Value.ToString + "' from the List?", MsgBoxStyle.YesNo, "Remove Record")
                If ans = MsgBoxResult.Yes Then
                    deleteCategory()
                    MessageBox.Show("You have successfully deleted " + dgvCategory.SelectedRows(0).Cells(1).Value.ToString + " from the list.", "Deleted Record")
                    revertFormSettings()
                    generateCategory()
                End If
            End If
        End If
    End Sub

    Private Sub btnEditCategory_Click(sender As Object, e As EventArgs) Handles btnEditCategory.Click
        If btnEditCategory.Text = "Save" Then
            If Not String.IsNullOrWhiteSpace(txtCategoryId.Text) Then
                If Not String.IsNullOrWhiteSpace(txtCategoryName.Text) Then
                    If dgvCategory.Rows.Count > 0 Then
                        If LibraryDatabase.isExisting("SELECT COUNT(*) FROM category WHERE categoryId='" + txtCategoryId.Text + "';") = False Then
                            If LibraryDatabase.isExisting("SELECT COUNT(*) FROM category WHERE categoryName='" + txtCategoryName.Text + "';") = False Then
                                addNewCategory()
                                MessageBox.Show("You have successfully added a new Category!", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                                revertFormSettings()
                                generateCategory()
                            Else
                                MessageBox.Show("A record of the same Category Name already exists!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtCategoryName.Focus()
                            End If
                        Else
                            MessageBox.Show("A record of the same Category ID already exists!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtCategoryId.Focus()
                        End If
                    ElseIf dgvCategory.Rows.Count = 0 Then
                        addNewCategory()
                        MessageBox.Show("You have successfully added a new Category!", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        revertFormSettings()
                        generateCategory()
                    End If
                Else
                    MessageBox.Show("Category Name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCategoryId.Focus()
                End If

            Else
                MessageBox.Show("Category ID field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCategoryId.Focus()
            End If
        ElseIf btnEditCategory.Text = "Edit" Then
            If dgvCategory.Rows.Count > 0 Then
                btnGenerate.Visible = False
                objCategory.CategoryId = txtCategoryId.Text
                btnEditCategory.Text = "Update"
                btnRemoveCategory.Text = "Cancel"
                btnAddCategory.Enabled = False
                btnAddCategory.Visible = False
                enableInput(True)
                dgvCategory.Enabled = False
                txtCategoryName.Focus()
            End If

        ElseIf btnEditCategory.Text = "Update" Then
            If Not String.IsNullOrWhiteSpace(txtCategoryId.Text) Then
                If Not String.IsNullOrWhiteSpace(txtCategoryName.Text) Then
                    If dgvCategory.Rows.Count > 0 Then
                        If LibraryDatabase.isExisting("SELECT COUNT(*) FROM category WHERE categoryName='" + txtCategoryName.Text + "' AND categoryId!='" + objCategory.CategoryId + "';") = False Then

                            'update
                            editCategory()

                            MessageBox.Show("You have successfully updated a category!", "Successfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            revertFormSettings()
                            generateCategory()
                        Else
                            MessageBox.Show("A record of the same Category Name already exists!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtCategoryName.Focus()
                        End If
                    End If
                Else
                    MessageBox.Show("Category Name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCategoryName.Focus()
                End If

            Else
                MessageBox.Show("Category ID field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCategoryId.Focus()
            End If
        End If
    End Sub

    Private Sub dgvCategory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategory.CellContentClick

    End Sub

    Private Sub dgvCategory_Click(sender As Object, e As EventArgs) Handles dgvCategory.Click
        displayCategory()
    End Sub

    Private Sub rtbDescription_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        txtCategoryId.Text = generateId("category", "categoryId", "CA")
    End Sub
End Class