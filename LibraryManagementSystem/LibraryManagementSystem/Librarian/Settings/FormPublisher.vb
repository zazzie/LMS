Public Class FormPublisher

    Dim objPublisher As New Publisher

    Private Sub renameColumns()
        With dgvPublisher
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "Publisher"
        End With
    End Sub

    Private Sub enableButtons(ByVal flag As Boolean)
        btnAddPublisher.Enabled = flag
        btnEditPublisher.Enabled = flag
        btnRemovePublisher.Enabled = flag
    End Sub

    Private Sub displayPublisher()
        If dgvPublisher.Rows.Count > 0 Then
            txtPublisher.Text = dgvPublisher.SelectedRows(0).Cells(1).Value.ToString
        End If
    End Sub

    Private Sub generatePublisher()
        Dim sqlSearch As String
        Try
            sqlSearch = "SELECT `publisherId`, `publisherName` FROM `publisher`;"
            Dim ds As DataSet
            dgvPublisher.Rows.Clear()
            ds = LibraryDatabase.fetchSQL(sqlSearch)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With dgvPublisher
                        dgvPublisher.Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                        ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                    End With
                    index += 1
                End While
                dgvPublisher.Refresh()
                dgvPublisher.Select()
                displayPublisher()
            Else
                Dim sqlInsert As String = "INSERT INTO `publisher`(`publisherId`, `publisherName`) VALUES ('PU00000001','N/A');"
                LibraryDatabase.execSQL(sqlInsert)
                generatePublisher()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub addNewPublisher()
        objPublisher.PublisherId = generateId("publisher", "publisherId", "PU")
        objPublisher.PublisherName = txtPublisher.Text
        objPublisher.addPublisher()
    End Sub

    Private Sub formPublisher_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub formPublisher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPublisher.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        renameColumns()
        generatePublisher()
    End Sub

    Private Sub txtPublisher_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPublisher.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetter(c) Or (c = " ") Or (c = "-") Or (c = ".") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPublisher_LostFocus(sender As Object, e As EventArgs) Handles txtPublisher.LostFocus
        txtPublisher.Text = txtPublisher.Text.ToUpper
    End Sub

    Private Sub txtPublisher_TextChanged(sender As Object, e As EventArgs) Handles txtPublisher.TextChanged

    End Sub

    Private Sub revertPublisherFormSettings()
        txtPublisher.Enabled = False
        btnAddPublisher.Text = "Add"
        btnEditPublisher.Text = "Edit"
        btnRemovePublisher.Text = "Remove"
        btnAddPublisher.Visible = True
        enableButtons(True)
        dgvPublisher.Enabled = True
    End Sub

    Private Sub btnAddPublisher_Click(sender As Object, e As EventArgs) Handles btnAddPublisher.Click
        btnEditPublisher.Text = "Save"
        btnRemovePublisher.Text = "Cancel"
        btnAddPublisher.Enabled = False
        btnAddPublisher.Visible = False
        txtPublisher.Enabled = True
        dgvPublisher.Enabled = False
        txtPublisher.Clear()
        txtPublisher.Focus()
    End Sub

    Private Sub btnEditPublisher_Click(sender As Object, e As EventArgs) Handles btnEditPublisher.Click
        If btnEditPublisher.Text = "Save" Then
            If Not String.IsNullOrWhiteSpace(txtPublisher.Text) Then
                If dgvPublisher.Rows.Count > 0 Then
                    If countRecord("SELECT COUNT(*) FROM publisher WHERE publisherName='" + txtPublisher.Text + "';") = 0 Then
                        addNewPublisher()
                        MessageBox.Show("You have successfully added a new publisher!", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        revertPublisherFormSettings()
                        generatePublisher()
                    Else
                        MessageBox.Show("A record of the same publisher name already exists!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtPublisher.Focus()
                    End If
                ElseIf dgvPublisher.Rows.Count = 0 Then
                    addNewPublisher()
                    MessageBox.Show("You have successfully added a new publisher!", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    revertPublisherFormSettings()
                    generatePublisher()
                End If
            Else
                MessageBox.Show("Publisher Name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPublisher.Focus()
            End If
        ElseIf btnEditPublisher.Text = "Edit" Then
            If dgvPublisher.Rows.Count > 0 Then
                btnEditPublisher.Text = "Update"
                btnRemovePublisher.Text = "Cancel"
                btnAddPublisher.Enabled = False
                btnAddPublisher.Visible = False
                txtPublisher.Enabled = True
                dgvPublisher.Enabled = False
                txtPublisher.Focus()
            End If

        ElseIf btnEditPublisher.Text = "Update" Then
            If Not String.IsNullOrWhiteSpace(txtPublisher.Text) Then
                If dgvPublisher.Rows.Count > 0 Then
                    If countRecord("SELECT COUNT(*) FROM publisher WHERE publisherName='" + txtPublisher.Text + "' and publisherId!='" + dgvPublisher.SelectedRows(0).Cells(0).Value.ToString + "';") = 0 Then

                        'update
                        objPublisher.PublisherId = dgvPublisher.SelectedRows(0).Cells(0).Value
                        objPublisher.PublisherName = txtPublisher.Text
                        objPublisher.editPublisher()

                        MessageBox.Show("You have successfully updated a publisher!", "Successfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        revertPublisherFormSettings()
                        generatePublisher()
                    Else
                        MessageBox.Show("A record of the same Publisher Name already exists!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtPublisher.Focus()
                    End If
                End If
            Else
                MessageBox.Show("Publisher Name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPublisher.Focus()
            End If
        End If
    End Sub

    Private Sub btnRemovePublisher_Click(sender As Object, e As EventArgs) Handles btnRemovePublisher.Click
        If btnRemovePublisher.Text = "Cancel" Then
            revertPublisherFormSettings()
            generatePublisher()
        ElseIf btnRemovePublisher.Text = "Remove" Then
            If dgvPublisher.Rows.Count > 0 Then
                Dim ans As Integer
                ans = MsgBox("Are you sure you want to remove '" + txtPublisher.Text + "' from the list?", MsgBoxStyle.YesNo, "Remove Record")
                If ans = MsgBoxResult.Yes Then
                    objPublisher.PublisherId = dgvPublisher.SelectedRows(0).Cells(0).Value
                    objPublisher.deletePublisher()
                    MessageBox.Show("You have successfully deleted " + txtPublisher.Text + " from the list.", "Deleted Record")
                    revertPublisherFormSettings()
                    generatePublisher()
                End If
            End If
        End If
    End Sub

    Private Sub dgvPublisher_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPublisher.CellContentClick

    End Sub

    Private Sub dgvPublisher_Click(sender As Object, e As EventArgs) Handles dgvPublisher.Click
        displayPublisher()
    End Sub
End Class