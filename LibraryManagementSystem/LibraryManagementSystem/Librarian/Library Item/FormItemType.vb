'Public Class FormItemType
'    Dim objItemType As New ItemType

'    Private Sub renameColumns()
'        With dgvItemType
'            .RowHeadersVisible = False
'            .Columns(0).HeaderCell.Value = "ID" 'RENAMING COLUMNS
'            .Columns(1).HeaderCell.Value = "Name"
'        End With
'    End Sub

'    Private Sub enableButtons(ByVal flag As Boolean)
'        btnAddItemType.Enabled = flag
'        btnEditItemType.Enabled = flag
'        btnRemoveItemType.Enabled = flag
'    End Sub

'    Private Sub displayItemType()
'        If dgvItemType.Rows.Count > 0 Then
'            txtItemType.Text = dgvItemType.SelectedRows(0).Cells(1).Value.ToString
'        End If
'    End Sub

'    Private Sub generateItemType()
'        Dim sqlSearch As String
'        Try
'            sqlSearch = "SELECT * FROM `itemtype`;"
'            Dim ds As DataSet
'            dgvItemType.Rows.Clear()
'            ds = LibraryDatabase.fetchSQL(sqlSearch)
'            If ds.Tables(0).Rows.Count > 0 Then
'                Dim index As Integer = 0
'                While index < ds.Tables(0).Rows.Count
'                    With dgvItemType
'                        .Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
'                            ds.Tables(0).Rows(index).Item(1).ToString.Trim)
'                    End With
'                    index += 1
'                End While
'                dgvItemType.Refresh()
'                dgvItemType.Select()
'                displayItemType()
'            Else
'                Dim sqlInsert As String = "INSERT INTO `itemtype`(`itemTypeId`, `itemTypeName`) VALUES (0,'UNDEFINED');"
'                LibraryDatabase.execSQL(sqlInsert)
'                generateItemType()
'            End If
'        Catch ex As Exception
'            MsgBox(ex.Message.ToString)
'        End Try
'    End Sub
'    Private Sub addNewItemType()
'        objItemType.ItemTypeId = LibraryDatabase.GenerateID("SELECT MAX(itemTypeId) FROM `itemtype`;")
'        objItemType.ItemTypeName = txtItemType.Text
'        objItemType.addItemType()
'    End Sub

'    Private Sub FormItemType_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
'        Me.DialogResult = Windows.Forms.DialogResult.OK
'    End Sub
'    Private Sub FormItemType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        dgvItemType.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
'        renameColumns()
'        generateItemType()
'    End Sub

'    Private Sub txtItemType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemType.KeyPress
'        Dim c As Char
'        c = e.KeyChar
'        If Not (Char.IsLetterOrDigit(c) Or (c = " ") Or (c = "-") Or (c = ".") Or (c = "`") Or Char.IsControl(c)) Then
'            e.Handled = True
'        End If
'    End Sub

'    Private Sub txtItemType_LostFocus(sender As Object, e As EventArgs) Handles txtItemType.LostFocus
'        txtItemType.Text = txtItemType.Text.ToUpper
'    End Sub

'    Private Sub revertItemTypeFormSettings()
'        btnAddItemType.Text = "Add"
'        btnEditItemType.Text = "Edit"
'        btnRemoveItemType.Text = "Remove"
'        txtItemType.Enabled = False
'        btnAddItemType.Visible = True
'        enableButtons(True)
'        dgvItemType.Enabled = True
'    End Sub

'    Private Sub txtItemType_TextChanged(sender As Object, e As EventArgs) Handles txtItemType.TextChanged

'    End Sub

'    Private Sub btnAddItemType_Click(sender As Object, e As EventArgs) Handles btnAddItemType.Click
'        btnEditItemType.Text = "Save"
'        btnRemoveItemType.Text = "Cancel"
'        btnAddItemType.Enabled = False
'        btnAddItemType.Visible = False
'        txtItemType.Enabled = True
'        dgvItemType.Enabled = False
'        txtItemType.Clear()
'        txtItemType.Focus()
'    End Sub

'    Private Sub btnEditItemType_Click(sender As Object, e As EventArgs) Handles btnEditItemType.Click
'        If btnEditItemType.Text = "Save" Then
'            If Not String.IsNullOrWhiteSpace(txtItemType.Text) Then
'                If dgvItemType.Rows.Count > 0 Then
'                    If LibraryDatabase.isExisting("SELECT COUNT(*) FROM itemtype WHERE itemTypeName='" + txtItemType.Text + "';") = False Then
'                        addNewItemType()
'                        MessageBox.Show("You have successfully added a new item type!", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
'                        revertItemTypeFormSettings()
'                        generateItemType()
'                    Else
'                        MessageBox.Show("A record of the same item type name already exists!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                        txtItemType.Focus()
'                    End If
'                ElseIf dgvItemType.Rows.Count = 0 Then
'                    addNewItemType()
'                    MessageBox.Show("You have successfully added a new item type!", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
'                    revertItemTypeFormSettings()
'                    generateItemType()
'                End If
'            Else
'                MessageBox.Show("Item Type Name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                txtItemType.Focus()
'            End If
'        ElseIf btnEditItemType.Text = "Edit" Then
'            If dgvItemType.Rows.Count > 0 Then
'                btnEditItemType.Text = "Update"
'                btnRemoveItemType.Text = "Cancel"
'                btnAddItemType.Enabled = False
'                btnAddItemType.Visible = False
'                txtItemType.Enabled = True
'                dgvItemType.Enabled = False
'                txtItemType.Focus()
'            End If

'        ElseIf btnEditItemType.Text = "Update" Then
'            If Not String.IsNullOrWhiteSpace(txtItemType.Text) Then
'                If dgvItemType.Rows.Count > 0 Then
'                    If LibraryDatabase.isExisting("SELECT COUNT(*) FROM itemtype WHERE itemTypeName='" + txtItemType.Text + "' and itemTypeId!=" + dgvItemType.SelectedRows(0).Cells(0).Value.ToString + ";") = False Then

'                        'update
'                        objItemType.ItemTypeId = dgvItemType.SelectedRows(0).Cells(0).Value
'                        objItemType.ItemTypeName = txtItemType.Text
'                        objItemType.editItemType()

'                        MessageBox.Show("You have successfully updated an item type!", "Successfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
'                        revertItemTypeFormSettings()
'                        generateItemType()
'                    Else
'                        MessageBox.Show("A record of the same ItemType Name already exists!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                        txtItemType.Focus()
'                    End If
'                End If
'            Else
'                MessageBox.Show("Item Type Name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                txtItemType.Focus()
'            End If
'        End If
'    End Sub

'    Private Sub btnRemoveItemType_Click(sender As Object, e As EventArgs) Handles btnRemoveItemType.Click
'        If btnRemoveItemType.Text = "Cancel" Then
'            revertItemTypeFormSettings()
'            generateItemType()
'        ElseIf btnRemoveItemType.Text = "Remove" Then
'            If dgvItemType.Rows.Count > 0 Then
'                Dim ans As Integer
'                ans = MsgBox("Are you sure you want to remove '" + txtItemType.Text + "' from the list?", MsgBoxStyle.YesNo, "Remove Record")
'                If ans = MsgBoxResult.Yes Then
'                    objItemType.ItemTypeId = dgvItemType.SelectedRows(0).Cells(0).Value
'                    objItemType.deleteItemType()
'                    MessageBox.Show("You have successfully deleted " + txtItemType.Text + " from the list.", "Deleted Record")
'                    revertItemTypeFormSettings()
'                    generateItemType()
'                End If
'            End If
'        End If
'    End Sub

'    Private Sub dgvItemType_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemType.CellContentClick

'    End Sub

'    Private Sub dgvItemType_Click(sender As Object, e As EventArgs) Handles dgvItemType.Click
'        displayItemType()
'    End Sub
'End Class