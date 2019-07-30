Public Class FormAddBookCopy
    Dim dsBookShelf As DataSet
    Dim dsBookShelfSection As DataSet
    Dim objFormBookShelf As New FormBookShelf
    Private _dsCopyList As DataSet
    Dim dateToday As DateTime = DateTime.Now
    Private _shelfId, _shelfSectionId As String

    Public Property DsCopylist
        Get
            Return _dsCopyList
        End Get
        Set(value)
            _dsCopyList = value
        End Set
    End Property

    Public Property ShelfId
        Get
            Return _shelfId
        End Get
        Set(value)
            _shelfId = value
        End Set
    End Property

    Public Property ShelfSectionId
        Get
            Return _shelfSectionId
        End Get
        Set(value)
            _shelfSectionId = value
        End Set
    End Property

    Private Sub renameColumns()
        With dgvAccessionList
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "Accession ID"
        End With
    End Sub

    Private Sub getShelfSectionData(ByVal id As String)
        Dim sqlSearch As String
        sqlSearch = "SELECT * FROM `bookshelf` join bookshelfsection on bookshelfId=bookShelfSectionBookShelfId WHERE bookshelfId='" + id + "';"
        dsBookShelfSection = LibraryDatabase.fetchSQL(sqlSearch)
    End Sub
    Private Sub generateBookShelf()
        Dim sqlSearch As String
        sqlSearch = "SELECT * FROM bookshelf;"
        dsBookShelf = LibraryDatabase.fetchSQL(sqlSearch)
        If dsBookShelf.Tables(0).Rows.Count > 0 Then

            cboShelf.Items.Clear()
            Dim index As Integer = 0
            While index < dsBookShelf.Tables(0).Rows.Count
                With cboShelf
                    .Items.Add(dsBookShelf.Tables(0).Rows(index).Item(1).ToString.Trim)
                End With
                index += 1
            End While
            cboShelf.Refresh()
            cboShelf.SelectedIndex = 0
        Else
            Dim sqlInsert As String = "INSERT INTO `bookshelf`(`bookshelfId`, `bookshelfName`) VALUES ('SH00000001','N/A');" & _
                    "INSERT INTO `bookshelfsection`(`bookShelfSectionId`, `bookShelfSectionName`, `bookShelfSectionBookShelfId`) VALUES ('SS00000001','N/A','SH00000001');"
            LibraryDatabase.execSQL(sqlInsert)
            generateBookShelf()
        End If
    End Sub

    Private Sub generateBookShelfSection()
        If Not String.IsNullOrWhiteSpace(cboShelf.Text) Then
            getShelfSectionData(dsBookShelf.Tables(0).Rows(cboShelf.SelectedIndex).Item(0).ToString)
            cboShelfSection.Items.Clear()
            Dim index As Integer = 0
            While index < dsBookShelfSection.Tables(0).Rows.Count
                With cboShelfSection
                    .Items.Add(dsBookShelfSection.Tables(0).Rows(index).Item(3).ToString.Trim)
                End With
                index += 1
            End While
            cboShelfSection.Refresh()
            cboShelfSection.SelectedIndex = 0
        Else
            cboShelfSection.Items.Clear()
        End If
    End Sub

    Private Sub FormAddBookCopy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboAquisition.Text = "BOUGHT BY SCHOOL"
        dgvAccessionList.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        renameColumns()
        cboQuality.SelectedIndex = 0
        rbtAutoGenerate.Checked = True
        checkRBTs()
        generateBookShelf()
        generateBookShelfSection()
        txtPrice.Text = "0.00"
        'DsCopyList = FormAddBook.dsDgvCopyList
        'MsgBox(DsCopyList.Tables(0).Rows(0).Item(0).ToString)
    End Sub

    Private Sub checkRBTs()
        If rbtAutoGenerate.Checked = True Then
            txtCopyNumber.Enabled = True
            pnlManualList.Enabled = False
            txtCopyNumber.Focus()
        ElseIf rbtManualList.Checked = True Then
            txtCopyNumber.Enabled = False
            pnlManualList.Enabled = True
            txtAccessionID.Focus()
        End If
    End Sub

    Private Sub btnShelf_Click(sender As Object, e As EventArgs) Handles btnShelf.Click
        objFormBookShelf = New FormBookShelf
        If objFormBookShelf.ShowDialog = Windows.Forms.DialogResult.OK Then
            generateBookShelf()
            generateBookShelfSection()
        End If
    End Sub

    Private Sub cboShelf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboShelf.SelectedIndexChanged
        generateBookShelfSection()
    End Sub

    Private Sub cboAquisition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAquisition.SelectedIndexChanged
        If Not cboAquisition.Text = "BOUGHT BY SCHOOL" Then
            lblPrice.Visible = False
            txtPrice.Visible = False
            lblPhp.Visible = False
        Else
            lblPrice.Visible = True
            txtPrice.Visible = True
            lblPhp.Visible = True
            txtPrice.Focus()
        End If
    End Sub

    Private Sub rbtManualList_CheckedChanged(sender As Object, e As EventArgs) Handles rbtManualList.CheckedChanged
        checkRBTs()
    End Sub

    Private Sub rbtAutoGenerate_CheckedChanged(sender As Object, e As EventArgs) Handles rbtAutoGenerate.CheckedChanged
        checkRBTs()
    End Sub

    Private Sub txtAccessionID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAccessionID.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetterOrDigit(c) Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAccessionID_LostFocus(sender As Object, e As EventArgs) Handles txtAccessionID.LostFocus
        txtAccessionID.Text = txtAccessionID.Text.ToUpper
    End Sub

    Private Sub txtAccessionID_TextChanged(sender As Object, e As EventArgs) Handles txtAccessionID.TextChanged

    End Sub

    Private Sub txtCopyNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCopyNumber.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCopyNumber_TextChanged(sender As Object, e As EventArgs) Handles txtCopyNumber.TextChanged

    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or (c = "." And txtPrice.Text.IndexOf(".") = -1) Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrice_LostFocus(sender As Object, e As EventArgs) Handles txtPrice.LostFocus
        txtPrice.Text = Val(txtPrice.Text).ToString("###,###,##0.00")
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Dispose()
    End Sub

    Private Sub btnAddToList_Click(sender As Object, e As EventArgs) Handles btnAddToList.Click
        If Not String.IsNullOrWhiteSpace(txtAccessionID.Text) Then
            If countRecord("SELECT COUNT(*) FROM bookcopy WHERE bookAccessionId='" + txtAccessionID.Text + "';") = 0 Then
                Dim count As Integer = 0
                For Each row As DataGridViewRow In dgvAccessionList.Rows
                    If txtAccessionID.Text = row.Cells(1).Value.ToString Then
                        count += 1

                        Exit For
                    End If
                Next

                If count = 0 Then
                    Dim index As Integer = 0
                    While index < DsCopyList.Tables(0).Rows.Count
                        If txtAccessionID.Text = DsCopyList.Tables(0).Rows(index).Item(0).ToString Then
                            count += 1
                            Exit While
                        End If
                        index += 1
                    End While
                    If count = 0 Then
                        'real adding to list
                        dgvAccessionList.Rows.Add(False, txtAccessionID.Text)
                        dgvAccessionList.Refresh()
                        txtCopyNumber.Text = dgvAccessionList.Rows.Count.ToString
                        dgvAccessionList.Select()
                        txtAccessionID.Clear()
                        txtAccessionID.Focus()
                    Else
                        MessageBox.Show("Accession ID: " + txtAccessionID.Text + " is already listed from your Add Book window.", "Already Listed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtAccessionID.Focus()
                    End If
                Else
                    MessageBox.Show("Accession ID: " + txtAccessionID.Text + " is already in the list.", "Already Listed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtAccessionID.Focus()
                End If
            Else
                MessageBox.Show("Accession ID: " + txtAccessionID.Text + " already exist in the database.", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAccessionID.Focus()
            End If
        Else
            MessageBox.Show("You have entered an empty input.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAccessionID.Focus()
        End If
        
    End Sub

    Private Sub btnRemoveFromList_Click(sender As Object, e As EventArgs) Handles btnRemoveFromList.Click
        If dgvAccessionList.Rows.Count > 0 Then
            Dim index As Integer = dgvAccessionList.Rows.Count - 1
            While index >= 0
                If dgvAccessionList.Rows(index).Cells(0).Value = True Then
                    dgvAccessionList.Rows.RemoveAt(index)
                End If
                index -= 1
            End While
            'For Each row As DataGridViewRow In dgvAccessionList.Rows
            '    If row.Cells("Column1").Value = True Then
            '        dgvAccessionList.Rows.Remove(row)
            '    End If
            'Next
            If dgvAccessionList.Rows.Count = 0 Then
                chbSelectAll.Checked = False
            End If
            txtCopyNumber.Text = dgvAccessionList.Rows.Count.ToString
            dgvAccessionList.Refresh()
            dgvAccessionList.Select()
        End If
    End Sub

    Private Sub btnAddBookCopy_Click(sender As Object, e As EventArgs) Handles btnAddBookCopy.Click
        If rbtAutoGenerate.Checked = True Then
            If Not String.IsNullOrWhiteSpace(txtCopyNumber.Text) Then
                'add
                ShelfId = dsBookShelfSection.Tables(0).Rows(cboShelfSection.SelectedIndex).Item(0).ToString.Trim
                ShelfSectionId = dsBookShelfSection.Tables(0).Rows(cboShelfSection.SelectedIndex).Item(2).ToString.Trim
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("Please enter a valid number of book copies.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCopyNumber.Focus()
            End If
        ElseIf rbtManualList.Checked = True Then
            If dgvAccessionList.Rows.Count > 0 Then
                'add
                ShelfId = dsBookShelfSection.Tables(0).Rows(cboShelfSection.SelectedIndex).Item(0).ToString.Trim
                ShelfSectionId = dsBookShelfSection.Tables(0).Rows(cboShelfSection.SelectedIndex).Item(2).ToString.Trim
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("Please add at least one Accession ID in the list.", "Empty List", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAccessionID.Focus()
            End If
        End If
    End Sub

    Private Sub chbSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles chbSelectAll.CheckedChanged
        If chbSelectAll.Checked = True Then
            For Each row As DataGridViewRow In dgvAccessionList.Rows
                row.Cells(0).Value = True
            Next
        Else
            For Each row As DataGridViewRow In dgvAccessionList.Rows
                row.Cells(0).Value = False
            Next
        End If
    End Sub

    Private Sub dgvAccessionList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccessionList.CellContentClick
        If e.ColumnIndex = 0 And dgvAccessionList.SelectedRows.Count > 0 Then
            If dgvAccessionList.SelectedRows(0).Cells(0).Value = False Then
                dgvAccessionList.SelectedRows(0).Cells(0).Value = True
            Else
                dgvAccessionList.SelectedRows(0).Cells(0).Value = False
            End If
        End If
    End Sub

    'Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBookCopy.Click
    '    If rbtSingleCopy.Checked = True Then
    '        If String.IsNullOrWhiteSpace(txtCopyNumber.Text) = False Then
    '            If DsCopyList.Tables(0).Rows.Count > 0 Then
    '                Dim countExist As Integer = 0
    '                Dim index As Integer = 0
    '                While index < DsCopyList.Tables(0).Rows.Count
    '                    If txtCopyNumber.Text = DsCopyList.Tables(0).Rows(index).Item(0).ToString.Trim Then
    '                        countExist += 1
    '                    End If
    '                    index += 1
    '                End While
    '                If countExist = 0 Then
    '                    'MsgBox(countExist.ToString)
    '                    Dim row As DataRow
    '                    row = DsNewCopyList.Tables(0).NewRow
    '                    row.Item(0) = txtCopyNumber.Text
    '                    row.Item(1) = cboAquisition.Text
    '                    row.Item(2) = txtPrice.Text
    '                    row.Item(3) = dateToday.ToString("d")
    '                    If Not cboShelf.Text = "" Then
    '                        row.Item(4) = cboShelf.Text
    '                        row.Item(5) = cboShelfSection.Text
    '                        row.Item(6) = dsBookShelfSection.Tables(0).Rows(cboShelfSection.SelectedIndex).Item(0).ToString.Trim
    '                        row.Item(7) = dsBookShelfSection.Tables(0).Rows(cboShelfSection.SelectedIndex).Item(2).ToString.Trim
    '                    Else
    '                        row.Item(4) = ""
    '                        row.Item(5) = ""
    '                        row.Item(6) = ""
    '                        row.Item(7) = ""
    '                    End If
    '                    DsNewCopyList.Tables(0).Rows.Add(row)
    '                    Me.DialogResult = Windows.Forms.DialogResult.OK
    '                Else
    '                    'MsgBox(countExist.ToString)
    '                    MessageBox.Show("Accession number: " + txtCopyNumber.Text + " is already listed in the book copy list.", "Already Listed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    txtCopyNumber.Focus()
    '                End If
    '            Else 'add this if empty table
    '                Dim row As DataRow
    '                row = DsNewCopyList.Tables(0).NewRow
    '                row.Item(0) = txtCopyNumber.Text
    '                row.Item(1) = cboAquisition.Text
    '                row.Item(2) = txtPrice.Text
    '                row.Item(3) = dateToday.ToString("d")
    '                If Not cboShelf.Text = "" Then
    '                    row.Item(4) = cboShelf.Text
    '                    row.Item(5) = cboShelfSection.Text
    '                    row.Item(6) = dsBookShelfSection.Tables(0).Rows(cboShelfSection.SelectedIndex).Item(0).ToString.Trim
    '                    row.Item(7) = dsBookShelfSection.Tables(0).Rows(cboShelfSection.SelectedIndex).Item(2).ToString.Trim
    '                Else
    '                    row.Item(4) = ""
    '                    row.Item(5) = ""
    '                    row.Item(6) = ""
    '                    row.Item(7) = ""
    '                End If
    '                DsNewCopyList.Tables(0).Rows.Add(row)
    '                Me.DialogResult = Windows.Forms.DialogResult.OK
    '            End If
    '        Else
    '            MessageBox.Show("Please enter a valid accession number.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            txtCopyNumber.Focus()
    '        End If

    '    ElseIf rbtAutoGenerate.Checked = True Then
    '        If String.IsNullOrWhiteSpace(txtCopyNumber.Text) = False Then
    '            If String.IsNullOrWhiteSpace(txtAccession2.Text) = False Then
    '                If Not lblNumberCopy.Text = "(INVALID ACCESSION ORDER)" Or Val(txtAccession1.Text) >= Val(txtAccession2.Text) Then

    '                    If DsCopyList.Tables(0).Rows.Count > 0 Then
    '                        Dim countExist As Integer = 0
    '                        Dim index As Integer = 0
    '                        Dim min As Integer = Val(txtCopyNumber.Text)
    '                        Dim index2 As Integer = min
    '                        Dim max As Integer = Val(txtAccession2.Text)
    '                        Dim existing As String = ""
    '                        While index < DsCopyList.Tables(0).Rows.Count
    '                            While index2 <= max
    '                                If index2.ToString = DsCopyList.Tables(0).Rows(index).Item(0).ToString.Trim Then
    '                                    countExist += 1
    '                                    If countExist > 1 Then
    '                                        existing += ", "
    '                                    End If
    '                                    existing += index2.ToString
    '                                    Exit While
    '                                End If
    '                                index2 += 1
    '                            End While
    '                            index2 = min
    '                            index += 1
    '                        End While
    '                        If countExist = 0 Then
    '                            Dim accessionNumber As Integer = min
    '                            Dim row As DataRow
    '                            While accessionNumber <= max

    '                                row = DsNewCopyList.Tables(0).NewRow
    '                                row.Item(0) = accessionNumber.ToString
    '                                row.Item(1) = cboAquisition.Text
    '                                row.Item(2) = txtPrice.Text
    '                                row.Item(3) = dateToday.ToString("d")
    '                                If Not cboShelf.Text = "" Then
    '                                    row.Item(4) = cboShelf.Text
    '                                    row.Item(5) = cboShelfSection.Text
    '                                    row.Item(6) = dsBookShelfSection.Tables(0).Rows(cboShelfSection.SelectedIndex).Item(0).ToString.Trim
    '                                    row.Item(7) = dsBookShelfSection.Tables(0).Rows(cboShelfSection.SelectedIndex).Item(2).ToString.Trim
    '                                Else
    '                                    row.Item(4) = ""
    '                                    row.Item(5) = ""
    '                                    row.Item(6) = ""
    '                                    row.Item(7) = ""
    '                                End If
    '                                DsNewCopyList.Tables(0).Rows.Add(row)
    '                                accessionNumber += 1
    '                            End While
    '                            Me.DialogResult = Windows.Forms.DialogResult.OK
    '                        ElseIf countExist = 1 Then
    '                            MessageBox.Show("Accession number: " + existing + " is already listed in the book copy list.", "Already Listed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                            txtCopyNumber.Focus()
    '                        ElseIf countExist > 1 Then
    '                            MessageBox.Show("Accession numbers: " + existing + " are already listed in the book copy list.", "Already Listed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                            txtCopyNumber.Focus()
    '                        End If
    '                    Else 'add this if empty table
    '                        Dim accessionNumber As Integer = Val(txtCopyNumber.Text)
    '                        Dim max As Integer = Val(txtAccession2.Text)
    '                        Dim row As DataRow
    '                        While accessionNumber <= max

    '                            row = DsNewCopyList.Tables(0).NewRow
    '                            row.Item(0) = accessionNumber.ToString
    '                            row.Item(1) = cboAquisition.Text
    '                            row.Item(2) = txtPrice.Text
    '                            row.Item(3) = dateToday.ToString("d")
    '                            If Not cboShelf.Text = "" Then
    '                                row.Item(4) = cboShelf.Text
    '                                row.Item(5) = cboShelfSection.Text
    '                                row.Item(6) = dsBookShelfSection.Tables(0).Rows(cboShelfSection.SelectedIndex).Item(0).ToString.Trim
    '                                row.Item(7) = dsBookShelfSection.Tables(0).Rows(cboShelfSection.SelectedIndex).Item(2).ToString.Trim
    '                            Else
    '                                row.Item(4) = ""
    '                                row.Item(5) = ""
    '                                row.Item(6) = ""
    '                                row.Item(7) = ""
    '                            End If
    '                            DsNewCopyList.Tables(0).Rows.Add(row)
    '                            accessionNumber += 1
    '                        End While
    '                        Me.DialogResult = Windows.Forms.DialogResult.OK
    '                    End If
    '                Else
    '                    MessageBox.Show("Please enter a valid accession order. It must start from lower to higher accession number.", "Invalid Accession Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    txtCopyNumber.Focus()
    '                End If
    '            Else
    '                MessageBox.Show("Please enter a valid accession number.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                txtAccession2.Focus()
    '            End If
    '        Else
    '            MessageBox.Show("Please enter a valid accession number.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            txtCopyNumber.Focus()
    '        End If
    '    End If
    'End Sub

    
    
    
End Class