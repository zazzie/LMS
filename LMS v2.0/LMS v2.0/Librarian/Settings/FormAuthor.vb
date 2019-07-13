Public Class FormAuthor

    Dim objAuthor As New Author
    Dim dsAuthor As DataSet

    Private Sub renameColumns()
        With dgvAuthor
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Author ID" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "Author Name"
        End With
    End Sub

    Private Sub clearInputs()
        txtAuthorId.Clear()
        txtAuthorFirst.Clear()
        txtAuthorMiddle.Clear()
        txtAuthorLast.Clear()
    End Sub

    Private Sub enableInput(ByVal flag As Boolean)
        txtAuthorFirst.Enabled = flag
        txtAuthorMiddle.Enabled = flag
        txtAuthorLast.Enabled = flag
    End Sub

    Private Sub revertFormSettings()
        enableInput(False)
        enableButtons(True)
        dgvAuthor.Enabled = True
        btnAddAuthor.Text = "Add"
        btnEditAuthor.Text = "Edit"
        btnRemoveAuthor.Text = "Remove"
        btnAddAuthor.Visible = True
    End Sub

    Private Sub enableButtons(ByVal flag As Boolean)
        btnAddAuthor.Enabled = flag
        btnEditAuthor.Enabled = flag
        btnRemoveAuthor.Enabled = flag
    End Sub

    Private Sub displayAuthor()
        If dgvAuthor.Rows.Count > 0 Then
            txtAuthorId.Text = dgvAuthor.SelectedRows(0).Cells(0).Value.ToString
            txtAuthorFirst.Text = dsAuthor.Tables(0).Rows(dgvAuthor.CurrentRow.Index).Item(1).ToString.Trim
            txtAuthorMiddle.Text = dsAuthor.Tables(0).Rows(dgvAuthor.CurrentRow.Index).Item(2).ToString.Trim
            txtAuthorLast.Text = dsAuthor.Tables(0).Rows(dgvAuthor.CurrentRow.Index).Item(3).ToString.Trim
        End If
    End Sub

    Private Sub generateAuthor()
        Dim sqlSearch As String
        Try
            sqlSearch = "SELECT `authorId`, `authorFirst`, `authorMiddle`, `authorLast` FROM `author`;"
            Dim ds As DataSet
            dgvAuthor.Rows.Clear()
            ds = LibraryDatabase.fetchSQL(sqlSearch)
            If ds.Tables(0).Rows.Count > 0 Then
                dsAuthor = ds
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With dgvAuthor
                        dgvAuthor.Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                        ds.Tables(0).Rows(index).Item(3).ToString.Trim + ", " + ds.Tables(0).Rows(index).Item(1).ToString.Trim + " " + ds.Tables(0).Rows(index).Item(2).ToString.Trim)
                    End With
                    index += 1
                End While
                dgvAuthor.Refresh()
                dgvAuthor.Select()
                displayAuthor()
            Else
                dgvAuthor.Rows.Clear()
                clearInputs()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub addNewAuthor()
        objAuthor.AuthorId = txtAuthorId.Text
        objAuthor.AuthorFirst = txtAuthorFirst.Text
        objAuthor.AuthorMiddle = txtAuthorMiddle.Text
        objAuthor.AuthorLast = txtAuthorLast.Text
        objAuthor.addAuthor()
    End Sub

    Private Sub editAuthor()
        objAuthor.AuthorId = txtAuthorId.Text
        objAuthor.AuthorFirst = txtAuthorFirst.Text
        objAuthor.AuthorMiddle = txtAuthorMiddle.Text
        objAuthor.AuthorLast = txtAuthorLast.Text
        objAuthor.editAuthor()
    End Sub

    Private Sub deleteAuthor()
        objAuthor.AuthorId = txtAuthorId.Text
        objAuthor.deleteAuthor()
    End Sub

    Private Sub formAuthor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub formAuthor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvAuthor.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        renameColumns()
        revertFormSettings()
        generateAuthor()
    End Sub

    Private Sub txtAuthorFirst_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAuthorFirst.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetter(c) Or (c = " ") Or (c = "-") Or (c = ".") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAuthorMiddle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAuthorMiddle.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetter(c) Or (c = " ") Or (c = "-") Or (c = ".") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAuthorLast_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAuthorLast.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetter(c) Or (c = " ") Or (c = "-") Or (c = ".") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAuthorFirst_LostFocus(sender As Object, e As EventArgs) Handles txtAuthorFirst.LostFocus
        txtAuthorFirst.Text = txtAuthorFirst.Text.ToUpper
    End Sub

    Private Sub txtAuthorMiddle_LostFocus(sender As Object, e As EventArgs) Handles txtAuthorMiddle.LostFocus
        txtAuthorMiddle.Text = txtAuthorMiddle.Text.ToUpper
    End Sub

    Private Sub txtAuthorLast_LostFocus(sender As Object, e As EventArgs) Handles txtAuthorLast.LostFocus
        txtAuthorLast.Text = txtAuthorLast.Text.ToUpper
    End Sub

    Private Sub btnAddAuthor_Click(sender As Object, e As EventArgs) Handles btnAddAuthor.Click
        btnEditAuthor.Text = "Save"
        btnRemoveAuthor.Text = "Cancel"
        btnAddAuthor.Enabled = False
        btnAddAuthor.Visible = False
        clearInputs()
        enableInput(True)
        dgvAuthor.Enabled = False
        txtAuthorId.Text = LibraryDatabase.GenerateID("SELECT MAX(authorId) FROM `author`;")
        txtAuthorFirst.Focus()
    End Sub

    Private Sub btnRemoveAuthor_Click(sender As Object, e As EventArgs) Handles btnRemoveAuthor.Click
        If btnRemoveAuthor.Text = "Cancel" Then
            revertFormSettings()
            generateAuthor()
        ElseIf btnRemoveAuthor.Text = "Remove" Then
            If dgvAuthor.Rows.Count > 0 Then
                Dim ans As Integer
                ans = MsgBox("Are you sure you want to remove '" + dgvAuthor.SelectedRows(0).Cells(1).Value.ToString + "' from the Author List?", MsgBoxStyle.YesNo, "Remove Record")
                If ans = MsgBoxResult.Yes Then
                    deleteAuthor()
                    MessageBox.Show("You have successfully deleted " + dgvAuthor.SelectedRows(0).Cells(1).Value.ToString + " from the list.", "Deleted Record")
                    revertFormSettings()
                    generateAuthor()
                End If
            End If
        End If
    End Sub

    Private Sub btnEditAuthor_Click(sender As Object, e As EventArgs) Handles btnEditAuthor.Click
        If btnEditAuthor.Text = "Save" Then
            If Not String.IsNullOrWhiteSpace(txtAuthorFirst.Text) Then
                If Not String.IsNullOrWhiteSpace(txtAuthorLast.Text) Then
                    If dgvAuthor.Rows.Count > 0 Then
                        If LibraryDatabase.isExisting("SELECT COUNT(*) FROM author WHERE authorFirst='" + txtAuthorFirst.Text + "' AND authorMiddle='" + txtAuthorMiddle.Text + "' AND authorLast='" + txtAuthorLast.Text + "';") = False Then
                            addNewAuthor()
                            MessageBox.Show("You have successfully added a new Author!", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            revertFormSettings()
                            generateAuthor()
                        Else
                            MessageBox.Show("A record of the same Author Name already exists!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtAuthorFirst.Focus()
                        End If
                    ElseIf dgvAuthor.Rows.Count = 0 Then
                        addNewAuthor()
                        MessageBox.Show("You have successfully added a new Author!", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        revertFormSettings()
                        generateAuthor()
                    End If
                Else
                    MessageBox.Show("Last Name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtAuthorFirst.Focus()
                End If

            Else
                MessageBox.Show("First Name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAuthorFirst.Focus()
            End If
        ElseIf btnEditAuthor.Text = "Edit" Then
            If dgvAuthor.Rows.Count > 0 Then
                btnEditAuthor.Text = "Update"
                btnRemoveAuthor.Text = "Cancel"
                btnAddAuthor.Enabled = False
                btnAddAuthor.Visible = False
                enableInput(True)
                dgvAuthor.Enabled = False
                txtAuthorFirst.Focus()
            End If

        ElseIf btnEditAuthor.Text = "Update" Then
            If Not String.IsNullOrWhiteSpace(txtAuthorFirst.Text) Then
                If Not String.IsNullOrWhiteSpace(txtAuthorLast.Text) Then
                    If dgvAuthor.Rows.Count > 0 Then
                        If LibraryDatabase.isExisting("SELECT COUNT(*) FROM author WHERE authorFirst='" + txtAuthorFirst.Text + "' AND authorMiddle='" + txtAuthorMiddle.Text + "' AND authorLast='" + txtAuthorLast.Text + "' AND authorId!=" + dgvAuthor.SelectedRows(0).Cells(0).Value.ToString + ";") = False Then

                            'update
                            editAuthor()

                            MessageBox.Show("You have successfully updated an author!", "Successfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            revertFormSettings()
                            generateAuthor()
                        Else
                            MessageBox.Show("A record of the same Author Name already exists!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtAuthorFirst.Focus()
                        End If
                    End If
                Else
                    MessageBox.Show("Last Name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtAuthorFirst.Focus()
                End If

            Else
                MessageBox.Show("First Name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAuthorFirst.Focus()
            End If
        End If
    End Sub

    Private Sub dgvAuthor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAuthor.CellContentClick

    End Sub

    Private Sub dgvAuthor_Click(sender As Object, e As EventArgs) Handles dgvAuthor.Click
        displayAuthor()
    End Sub
End Class