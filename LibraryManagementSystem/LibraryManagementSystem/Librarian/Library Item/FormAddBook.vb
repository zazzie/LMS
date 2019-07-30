Public Class FormAddBook
    Dim objFormPublisher As New FormPublisher
    Dim objFormCategory As New FormCategory
    Dim objFormAuthor As New FormAuthor
    Dim objFormAddBookCopy As New FormAddBookCopy
    Dim objFormEditBookCopy As New FormEditBookCopy
    Dim objBook As New Book
    Dim objBookCopy As New BookCopy
    Dim dsPublisher As DataSet
    Dim dsCategory As DataSet
    Dim dsAuthor As DataSet
    Dim countClose As Integer = 0
    Dim dsDgvCopyList As DataSet
    Dim dateToday As DateTime = DateTime.Now

    Private Sub renameColumns()
        With dgvAuthorList
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "Author"
        End With

        With dgvBookCopy
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = ""
            .Columns(1).HeaderCell.Value = "Accession Number" 'RENAMING COLUMNS
            .Columns(2).HeaderCell.Value = "Shelf"
            .Columns(3).HeaderCell.Value = "Shelf Section"
            .Columns(4).HeaderCell.Value = "Aquisition"
            .Columns(5).HeaderCell.Value = "Price"
            .Columns(6).HeaderCell.Value = "Date Added"
            
        End With
    End Sub

    Private Sub setDsCopyList()
        'set zero
        initializeDsDgvCopyList()

        'put each data
        If dgvBookCopy.Rows.Count > 0 Then
            For Each row As DataGridViewRow In dgvBookCopy.Rows
                Dim dsrow As DataRow
                dsrow = dsDgvCopyList.Tables(0).NewRow
                dsrow.Item(0) = row.Cells(1).Value.ToString
                dsDgvCopyList.Tables(0).Rows.Add(dsrow)
            Next
        End If
    End Sub

    Private Sub initializeDsDgvCopyList()
        'initialize to empty
        Try
            Dim sqlSearch As String
            sqlSearch = "SELECT bookAccessionId FROM bookcopy WHERE bookCopyAquisition='0';"
            dsDgvCopyList = LibraryDatabase.fetchSQL(sqlSearch)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub generatePublisher()
        Try
            Dim ds As New DataSet
            ds = LibraryDatabase.fetchSQL("SELECT `publisherId`, `publisherName` FROM `publisher` ORDER BY publisherName;")
            cboPublisher.Items.Clear()
            If ds.Tables(0).Rows.Count > 0 Then
                dsPublisher = ds
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With cboPublisher
                        .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                    End With
                    index += 1
                End While
                cboPublisher.Refresh()
                cboPublisher.SelectedIndex = 0
            Else
                Dim sqlInsert As String = "INSERT INTO `publisher`(`publisherId`, `publisherName`) VALUES ('PU00000001','N/A');"
                LibraryDatabase.execSQL(sqlInsert)
                generatePublisher()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub generateCategory()
        Try
            Dim ds As New DataSet
            ds = LibraryDatabase.fetchSQL("SELECT `categoryId`, `categoryName`, `categoryDescription` FROM `category` ORDER BY categoryName;")
            cboCategory.Items.Clear()
            If ds.Tables(0).Rows.Count > 0 Then
                dsCategory = ds
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With cboCategory
                        .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                    End With
                    index += 1
                End While
                cboCategory.Refresh()
                cboCategory.SelectedIndex = 0
            Else
                Dim sqlInsert As String = "INSERT INTO `category`(`categoryId`, `categoryName`) VALUES ('CA00000001','N/A');"
                LibraryDatabase.execSQL(sqlInsert)
                generateCategory()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub generateAuthor()
        Try
            Dim ds As New DataSet
            ds = LibraryDatabase.fetchSQL("SELECT `authorId`, `authorFirst`, `authorMiddle`, `authorLast` FROM `author` ORDER BY authorLast;")
            cboAuthor.Items.Clear()
            If ds.Tables(0).Rows.Count > 0 Then
                dsAuthor = ds
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With cboAuthor
                        .Items.Add(ds.Tables(0).Rows(index).Item(3).ToString.Trim + ", " + ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                    End With
                    index += 1
                End While
                cboAuthor.Refresh()
                cboAuthor.SelectedIndex = 0
            Else
                Dim sqlInsert As String = "INSERT INTO `author`(`authorId`, `authorLast`) VALUES ('AU00000001','UNKNOWN');"
                LibraryDatabase.execSQL(sqlInsert)
                generateAuthor()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnPublisher_Click(sender As Object, e As EventArgs) Handles btnPublisher.Click
        objFormPublisher = New FormPublisher
        If objFormPublisher.ShowDialog = Windows.Forms.DialogResult.OK Then
            generatePublisher()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim ans As Integer
        ans = MsgBox("There are unsaved information. Do you want to exit without saving?", MsgBoxStyle.YesNo, "Unsaved Information")
        If ans = MsgBoxResult.Yes Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Dispose()
        End If
    End Sub

    Private Sub FormAddBook_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub FormAddBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvAuthorList.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        dgvBookCopy.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        renameColumns()
        generateAuthor()
        generateCategory()
        generatePublisher()
        'initializeDsDgvCopyList()
        cboBorrowType.Text = "FOR INSIDE READING ONLY"
        txtTitle.Focus()
        lblNumberOfCopy.Text = "Number of Copies: " + dgvBookCopy.Rows.Count.ToString
    End Sub

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        objFormCategory = New FormCategory
        If objFormCategory.ShowDialog = Windows.Forms.DialogResult.OK Then
            generateCategory()
        End If
    End Sub

    Private Sub btnAuthor_Click(sender As Object, e As EventArgs) Handles btnAuthor.Click
        objFormAuthor = New FormAuthor
        If objFormAuthor.ShowDialog = Windows.Forms.DialogResult.OK Then
            generateAuthor()
        End If
    End Sub

    Private Sub txtTitle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTitle.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetterOrDigit(c) Or (c = " ") Or (c = "-") Or (c = ".") Or (c = "!") Or (c = "?") Or (c = "`") Or (c = ":") Or (c = ",") Or (c = "@") Or (c = "#") Or (c = "$") Or (c = "&") Or (c = "/") Or (c = "\") Or (c = ">") Or (c = "<") Or (c = "(") Or (c = ")") Or (c = "_") Or (c = "=") Or (c = "+") Or (c = "*") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtISBN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtISBN.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMaxDuration_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaxDuration.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtISBN_TextChanged(sender As Object, e As EventArgs) Handles txtISBN.TextChanged
        txtBookId.Text = txtISBN.Text
    End Sub

    Private Sub txtBookId_LostFocus(sender As Object, e As EventArgs) Handles txtBookId.LostFocus
        txtBookId.Text = txtBookId.Text.ToUpper
    End Sub

    Private Sub txtBookId_TextChanged(sender As Object, e As EventArgs) Handles txtBookId.TextChanged

    End Sub

    Private Sub rtbBookDescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtbBookDescription.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetterOrDigit(c) Or (c = " ") Or (c = "`") Or (c = "-") Or (c = ".") Or (c = "!") Or (c = "?") Or (c = "`") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTitle_LostFocus(sender As Object, e As EventArgs) Handles txtTitle.LostFocus
        txtTitle.Text = txtTitle.Text.ToUpper
    End Sub

    Private Sub rtbBookDescription_LostFocus(sender As Object, e As EventArgs) Handles rtbBookDescription.LostFocus
        rtbBookDescription.Text = rtbBookDescription.Text.ToUpper
    End Sub

    Private Sub cboBorrowType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBorrowType.SelectedIndexChanged
        If cboBorrowType.Text = "FOR INSIDE AND OUTSIDE USE" Then
            lblDays.Visible = True
            lblMaxDuration.Visible = True
            txtMaxDuration.Enabled = True
            txtMaxDuration.Visible = True
        ElseIf cboBorrowType.Text = "FOR INSIDE READING ONLY" Then
            lblDays.Visible = False
            lblMaxDuration.Visible = False
            txtMaxDuration.Enabled = False
            txtMaxDuration.Visible = False
            txtMaxDuration.Clear()
        End If
    End Sub

    Private Sub bntUploadPhoto_Click(sender As Object, e As EventArgs) Handles bntUploadPhoto.Click
        Try
            Dim ofd As New OpenFileDialog
            ofd.Title = "Choose a photo"
            ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            ofd.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            ofd.FilterIndex = 2
            ofd.RestoreDirectory = False
            If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If ofd.CheckFileExists = False Or ofd.CheckPathExists = False Then
                    MessageBox.Show("The file does not exist!", "No File Found", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    Dim PhotoFile As New IO.FileInfo(ofd.FileName)
                    If PhotoFile.Length <= 3500000 Then

                        Dim BookPhoto As New Bitmap(ofd.FileName)
                        pictBook.BackgroundImageLayout = ImageLayout.Zoom
                        pictBook.BackgroundImage = ResizeImage(BookPhoto)

                    Else
                        MessageBox.Show("The file size is too large!", "Large File Size", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Function ResizeImage(ByVal PhotoFile As Image) As Image
        Return New Bitmap(PhotoFile, New Size(pictBook.Width, pictBook.Height))
    End Function

    Private Sub btnAddToList_Click(sender As Object, e As EventArgs) Handles btnAddToList.Click
        Dim countInList As Integer = 0
        Dim cboAuthorIndex As Integer = cboAuthor.SelectedIndex
        For Each row As DataGridViewRow In dgvAuthorList.Rows
            If row.Cells(0).Value.ToString = dsAuthor.Tables(0).Rows(cboAuthorIndex).Item(0).ToString Then
                countInList += 1
                Exit For
            End If
        Next
        If countInList = 0 Then
            With dgvAuthorList
                .Rows.Add(dsAuthor.Tables(0).Rows(cboAuthorIndex).Item(0).ToString.Trim, _
                        dsAuthor.Tables(0).Rows(cboAuthorIndex).Item(3).ToString.Trim + ", " + dsAuthor.Tables(0).Rows(cboAuthorIndex).Item(1).ToString.Trim + " " + dsAuthor.Tables(0).Rows(cboAuthorIndex).Item(2).ToString.Trim)
            End With
            dgvAuthorList.Refresh()
            dgvAuthorList.Select()
        Else
            MessageBox.Show("The " + dsAuthor.Tables(0).Rows(cboAuthorIndex).Item(3).ToString.Trim + ", " + dsAuthor.Tables(0).Rows(cboAuthorIndex).Item(1).ToString.Trim + " " + dsAuthor.Tables(0).Rows(cboAuthorIndex).Item(2).ToString.Trim + " is  already in the list!", "Already Listed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnRemoveFromList_Click(sender As Object, e As EventArgs) Handles btnRemoveFromList.Click
        If dgvAuthorList.Rows.Count > 0 Then

            For Each removeRow As DataGridViewRow In dgvAuthorList.SelectedRows
                dgvAuthorList.Rows.Remove(removeRow)
                dgvAuthorList.Refresh()
                dgvAuthorList.Select()
            Next
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        txtBookId.Text = generateId("book", "bookId", "BK")
    End Sub

    Private Function isExistInList(ByVal bookCopyId As String, ByVal ds As DataSet) As Boolean
        For Each row As DataGridViewRow In dgvBookCopy.Rows
            If bookCopyId = row.Cells(1).Value.ToString.Trim Then
                Return True
                Exit Function
            End If
        Next

        Dim index As Integer = 0
        While index < ds.Tables(0).Rows.Count
            If bookCopyId = ds.Tables(0).Rows(index).Item(0).ToString Then
                Return True
                Exit Function
            End If
            index += 1
        End While
        Return False
    End Function

    Private Sub btnAddBookCopy_Click(sender As Object, e As EventArgs) Handles btnAddBookCopy.Click

        objFormAddBookCopy = New FormAddBookCopy
        setDsCopyList()
        'If dsDgvCopyList.Tables(0).Rows.Count > 0 Then
        '    MsgBox(dsDgvCopyList.Tables(0).Rows(0).Item(0).ToString)
        'Else
        '    MsgBox("EMPTY")
        'End If
        objFormAddBookCopy.DsCopylist = dsDgvCopyList

        If objFormAddBookCopy.ShowDialog = Windows.Forms.DialogResult.OK Then
            If objFormAddBookCopy.rbtAutoGenerate.Checked = True Then
                Dim index As Integer = 0

                'add to list loop
                Dim id As String
                Dim count As Integer
                Dim ds As DataSet
                ds = LibraryDatabase.fetchSQL("SELECT `bookAccessionId` FROM `bookcopy`;")
                count = countRecord("SELECT COUNT(*) FROM bookcopy;") + 1

                While index < Val(objFormAddBookCopy.txtCopyNumber.Text)

                    id = "AC" + count.ToString("00000000")
                    While isExistInList(id, ds) = True
                        count += 1
                        id = "AC" + count.ToString("00000000")
                    End While

                    dgvBookCopy.Rows.Add(False, id, objFormAddBookCopy.cboShelf.Text, _
                                         objFormAddBookCopy.cboShelfSection.Text, _
                                         objFormAddBookCopy.cboQuality.Text, _
                                         objFormAddBookCopy.cboAquisition.Text, _
                                         objFormAddBookCopy.txtPrice.Text, _
                                         dateToday.ToString("d"), _
                                         objFormAddBookCopy.ShelfId, _
                                         objFormAddBookCopy.ShelfSectionId)

                    count += 1
                    index += 1
                End While
                lblNumberOfCopy.Text = "Number of Copies: " + dgvBookCopy.Rows.Count.ToString
                dgvBookCopy.Refresh()
                dgvBookCopy.Select()
            ElseIf objFormAddBookCopy.rbtManualList.Checked = True Then
                If objFormAddBookCopy.dgvAccessionList.Rows.Count > 0 Then
                    For Each row As DataGridViewRow In objFormAddBookCopy.dgvAccessionList.Rows
                        dgvBookCopy.Rows.Add(False, row.Cells(1).Value.ToString, _
                                             objFormAddBookCopy.cboShelf.Text, _
                                             objFormAddBookCopy.cboShelfSection.Text, _
                                             objFormAddBookCopy.cboQuality.Text, _
                                             objFormAddBookCopy.cboAquisition.Text, _
                                             objFormAddBookCopy.txtPrice.Text, _
                                             dateToday.ToString("d"), _
                                             objFormAddBookCopy.ShelfId, _
                                             objFormAddBookCopy.ShelfSectionId)
                    Next
                    dgvBookCopy.Refresh()
                    dgvBookCopy.Select()
                End If
            End If
        End If

    End Sub

    'Private Sub btnAddBookCopy_Click(sender As Object, e As EventArgs) Handles btnAddBookCopy.Click
    '    objFormAddBookCopy = New FormAddBookCopy
    '    objFormAddBookCopy.DsCopyList = DsDgvCopyList
    '    If objFormAddBookCopy.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        Dim index As Integer = 0
    '        'dgvBookCopy.Rows.Clear()
    '        While index < objFormAddBookCopy.DsNewCopyList.Tables(0).Rows.Count

    '            With dgvBookCopy
    '                .Rows.Add(objFormAddBookCopy.DsNewCopyList.Tables(0).Rows(index).Item(0).ToString.Trim, _
    '                          objFormAddBookCopy.DsNewCopyList.Tables(0).Rows(index).Item(1).ToString.Trim, _
    '                          objFormAddBookCopy.DsNewCopyList.Tables(0).Rows(index).Item(2).ToString.Trim, _
    '                          objFormAddBookCopy.DsNewCopyList.Tables(0).Rows(index).Item(3).ToString.Trim, _
    '                          objFormAddBookCopy.DsNewCopyList.Tables(0).Rows(index).Item(4).ToString.Trim, _
    '                          objFormAddBookCopy.DsNewCopyList.Tables(0).Rows(index).Item(5).ToString.Trim)
    '            End With

    '            With DsDgvCopyList
    '                Dim dsrow As DataRow
    '                dsrow = DsDgvCopyList.Tables(0).NewRow
    '                dsrow.Item(0) = objFormAddBookCopy.DsNewCopyList.Tables(0).Rows(index).Item(0).ToString.Trim
    '                dsrow.Item(1) = objFormAddBookCopy.DsNewCopyList.Tables(0).Rows(index).Item(1).ToString.Trim
    '                dsrow.Item(2) = objFormAddBookCopy.DsNewCopyList.Tables(0).Rows(index).Item(2).ToString.Trim
    '                dsrow.Item(3) = objFormAddBookCopy.DsNewCopyList.Tables(0).Rows(index).Item(3).ToString.Trim
    '                dsrow.Item(4) = objFormAddBookCopy.DsNewCopyList.Tables(0).Rows(index).Item(4).ToString.Trim
    '                dsrow.Item(5) = objFormAddBookCopy.DsNewCopyList.Tables(0).Rows(index).Item(5).ToString.Trim
    '                dsrow.Item(6) = objFormAddBookCopy.DsNewCopyList.Tables(0).Rows(index).Item(6).ToString.Trim
    '                dsrow.Item(7) = objFormAddBookCopy.DsNewCopyList.Tables(0).Rows(index).Item(7).ToString.Trim

    '                .Tables(0).Rows.Add(dsrow)
    '            End With

    '            index += 1
    '        End While
    '        dgvBookCopy.Refresh()
    '        dgvBookCopy.Select()
    '    End If
    'End Sub

    'Private Sub btnRemoveBookCopy_Click(sender As Object, e As EventArgs) Handles btnRemoveBookCopy.Click
    '    If dgvBookCopy.Rows.Count > 0 Then
    '        Dim indexDs As Integer = 0
    '        While indexDs < DsDgvCopyList.Tables(0).Rows.Count
    '            If DsDgvCopyList.Tables(0).Rows(indexDs).Item(0).ToString.Trim = dgvBookCopy.SelectedRows(0).Cells(0).Value.ToString.Trim Then
    '                'MsgBox("HI")
    '                DsDgvCopyList.Tables(0).Rows.RemoveAt(indexDs)
    '                Exit While
    '            End If
    '            indexDs += 1
    '        End While
    '        For Each removeRow As DataGridViewRow In dgvBookCopy.SelectedRows
    '            dgvBookCopy.Rows.Remove(removeRow)
    '            dgvBookCopy.Refresh()
    '            dgvBookCopy.Select()
    '        Next
    '    End If
    'End Sub

    'Private Sub btnEditBookCopy_Click(sender As Object, e As EventArgs) Handles btnEditBookCopy.Click
    '    If dgvBookCopy.Rows.Count > 0 Then
    '        objFormEditBookCopy = New FormEditBookCopy
    '        objFormEditBookCopy.AccessionNumber = dgvBookCopy.SelectedRows(0).Cells(0).Value.ToString.Trim
    '        objFormEditBookCopy.Aquisition = dgvBookCopy.SelectedRows(0).Cells(1).Value.ToString.Trim
    '        objFormEditBookCopy.Price = dgvBookCopy.SelectedRows(0).Cells(2).Value.ToString.Trim
    '        objFormEditBookCopy.Shelf = dgvBookCopy.SelectedRows(0).Cells(4).Value.ToString.Trim
    '        objFormEditBookCopy.ShelfSection = dgvBookCopy.SelectedRows(0).Cells(5).Value.ToString.Trim
    '        If objFormEditBookCopy.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            Dim index As Integer = 0
    '            While index < DsDgvCopyList.Tables(0).Rows.Count
    '                If objFormEditBookCopy.AccessionNumber = DsDgvCopyList.Tables(0).Rows(index).Item(0).ToString Then

    '                    DsDgvCopyList.Tables(0).Rows.RemoveAt(index)

    '                    dgvBookCopy.SelectedRows(0).Cells(0).Value = objFormEditBookCopy.DsNewCopyList.Tables(0).Rows(0).Item(0).ToString
    '                    dgvBookCopy.SelectedRows(0).Cells(1).Value = objFormEditBookCopy.DsNewCopyList.Tables(0).Rows(0).Item(1).ToString
    '                    dgvBookCopy.SelectedRows(0).Cells(2).Value = objFormEditBookCopy.DsNewCopyList.Tables(0).Rows(0).Item(2).ToString
    '                    dgvBookCopy.SelectedRows(0).Cells(3).Value = objFormEditBookCopy.DsNewCopyList.Tables(0).Rows(0).Item(3).ToString
    '                    dgvBookCopy.SelectedRows(0).Cells(4).Value = objFormEditBookCopy.DsNewCopyList.Tables(0).Rows(0).Item(4).ToString
    '                    dgvBookCopy.SelectedRows(0).Cells(5).Value = objFormEditBookCopy.DsNewCopyList.Tables(0).Rows(0).Item(5).ToString

    '                    With DsDgvCopyList
    '                        Dim dsrow As DataRow
    '                        dsrow = DsDgvCopyList.Tables(0).NewRow
    '                        dsrow.Item(0) = objFormEditBookCopy.DsNewCopyList.Tables(0).Rows(0).Item(0).ToString.Trim
    '                        dsrow.Item(1) = objFormEditBookCopy.DsNewCopyList.Tables(0).Rows(0).Item(1).ToString.Trim
    '                        dsrow.Item(2) = objFormEditBookCopy.DsNewCopyList.Tables(0).Rows(0).Item(2).ToString.Trim
    '                        dsrow.Item(3) = objFormEditBookCopy.DsNewCopyList.Tables(0).Rows(0).Item(3).ToString.Trim
    '                        dsrow.Item(4) = objFormEditBookCopy.DsNewCopyList.Tables(0).Rows(0).Item(4).ToString.Trim
    '                        dsrow.Item(5) = objFormEditBookCopy.DsNewCopyList.Tables(0).Rows(0).Item(5).ToString.Trim
    '                        dsrow.Item(6) = objFormEditBookCopy.DsNewCopyList.Tables(0).Rows(0).Item(6).ToString.Trim
    '                        dsrow.Item(7) = objFormEditBookCopy.DsNewCopyList.Tables(0).Rows(0).Item(7).ToString.Trim

    '                        .Tables(0).Rows.Add(dsrow)
    '                    End With

    '                    Exit While
    '                End If
    '                index += 1
    '            End While
    '        End If
    '    End If

    'End Sub

    'Private Function countExistBookCopy() As Integer
    '    Dim count As Integer = 0
    '    For Each row As DataGridViewRow In dgvBookCopy.Rows
    '        Dim sqlCount As String
    '        sqlCount = "SELECT COUNT(*) FROM bookcopy WHERE bookAccessionId=" + row.Cells(0).Value.ToString.Trim + ";"
    '        If LibraryDatabase.isExisting(sqlCount) = True Then
    '            count += 1
    '            Dim index = row.Index
    '            dgvBookCopy.Rows(index).DefaultCellStyle.BackColor = Color.MistyRose
    '        End If
    '    Next
    '    Return count
    'End Function

    'Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
    '    If Not String.IsNullOrWhiteSpace(txtTitle.Text) Then
    '        If Not String.IsNullOrWhiteSpace(cboCategory.Text) Then
    '            If Not String.IsNullOrWhiteSpace(cboPublisher.Text) Then
    '                If dgvAuthorList.Rows.Count > 0 Then
    '                    If dgvBookCopy.Rows.Count > 0 Then
    '                        Dim countExistCopy As Integer = countExistBookCopy()
    '                        If countExistCopy = 0 Then
    '                            'adding book
    '                            Dim sqlInsert As String

    '                            objBook = New Book
    '                            objBook.BookId = txtBookId.Text
    '                            objBook.BookISBN = txtISBN.Text
    '                            objBook.BookTitle = txtTitle.Text
    '                            objBook.BookPublisherId = Val(dsPublisher.Tables(0).Rows(cboPublisher.SelectedIndex).Item(0).ToString)
    '                            objBook.BookCategoryId = Val(dsCategory.Tables(0).Rows(cboCategory.SelectedIndex).Item(0).ToString)
    '                            objBook.BookBorrowType = cboBorrowType.Text
    '                            objBook.BookDescription = rtbBookDescription.Text
    '                            If cboBorrowType.Text = "FOR INSIDE AND OUTSIDE USE" Then
    '                                objBook.BookMaxBorrowDuration = txtMaxDuration.Text
    '                            Else
    '                                objBook.BookMaxBorrowDuration = 0
    '                            End If
    '                            objBook.BookPhoto = objBook.ConvertImageTo64(pictBook.BackgroundImage)

    '                            sqlInsert = "INSERT INTO `book`(`bookId`, `bookISBN`, `bookTitle`, `bookPublisherId`, `bookCategoryId`, `bookBorrowType`, `bookDescription`, `bookMaxBorrowDuration`, `bookPhoto`) VALUES (" & _
    '                                                objBook.BookId.ToString + ",'" & _
    '                                                objBook.BookISBN + "','" & _
    '                                                objBook.BookTitle + "'," & _
    '                                                objBook.BookPublisherId.ToString + "," & _
    '                                                objBook.BookCategoryId.ToString + ",'" & _
    '                                                objBook.BookBorrowType + "','" & _
    '                                                objBook.BookDescription + "'," & _
    '                                                objBook.BookMaxBorrowDuration.ToString + ",'" & _
    '                                                objBook.BookPhoto + "');"
    '                            'adding author list
    '                            Dim id As Integer
    '                            id = LibraryDatabase.GenerateID("SELECT MAX(bookAuthorListId) from bookauthorlist;")
    '                            For Each row As DataGridViewRow In dgvAuthorList.Rows

    '                                sqlInsert += "INSERT INTO `bookauthorlist`(`bookAuthorListId`, `bookAuthorListBookId`, `bookAuthorListAuthorId`) VALUES (" & _
    '                                                            id.ToString + "," & _
    '                                                            objBook.BookId.ToString + "," & _
    '                                                            row.Cells(0).Value.ToString + ");"

    '                                id += 1
    '                            Next
    '                            'adding bookCopy\
    '                            Dim indexCopy As Integer = 0
    '                            While indexCopy < DsDgvCopyList.Tables(0).Rows.Count
    '                                objBookCopy = New BookCopy
    '                                objBookCopy.BookAccessionId = DsDgvCopyList.Tables(0).Rows(indexCopy).Item(0).ToString.Trim
    '                                objBookCopy.BookCopyBookId = txtBookId.Text
    '                                objBookCopy.BookCopyNumber = ""
    '                                objBookCopy.BookCopyQuality = "EXCELLENT" 'must fix
    '                                objBookCopy.BookCopyAquisition = DsDgvCopyList.Tables(0).Rows(indexCopy).Item(1).ToString
    '                                If DsDgvCopyList.Tables(0).Rows(indexCopy).Item(1).ToString.Trim = "BOUGHT BY SCHOOL" Then
    '                                    objBookCopy.BookCopyPrice = DsDgvCopyList.Tables(0).Rows(indexCopy).Item(2).ToString.Trim
    '                                End If
    '                                objBookCopy.BookCopyDateAdded = DsDgvCopyList.Tables(0).Rows(indexCopy).Item(3).ToString.Trim
    '                                objBookCopy.BookCopyShelfSectionId = DsDgvCopyList.Tables(0).Rows(indexCopy).Item(7).ToString.Trim
    '                                objBookCopy.BookCopyShelfId = DsDgvCopyList.Tables(0).Rows(indexCopy).Item(6).ToString.Trim

    '                                sqlInsert += "INSERT INTO `bookcopy`(`bookAccessionId`, `bookCopyBookId`, `bookCopyNumber`, `bookCopyQuality`, `bookCopyAquisition`, `bookCopyPrice`, `bookCopyDateAdded`, `bookCopyShelfId`, `bookCopyShelfSectionId`) VALUES (" & _
    '                                        objBookCopy.BookAccessionId.ToString + "," & _
    '                                        objBookCopy.BookCopyBookId.ToString + ",'" & _
    '                                        objBookCopy.BookCopyNumber + "','" & _
    '                                        objBookCopy.BookCopyQuality + "','" & _
    '                                        objBookCopy.BookCopyAquisition + "','" & _
    '                                        objBookCopy.BookCopyPrice + "','" & _
    '                                        objBookCopy.BookCopyDateAdded + "'," & _
    '                                        objBookCopy.BookCopyShelfId.ToString + "," & _
    '                                        objBookCopy.BookCopyShelfSectionId.ToString + ");"
    '                                indexCopy += 1
    '                            End While
    '                            LibraryDatabase.execSQL(sqlInsert)
    '                            MessageBox.Show("You have successfully added a new book!", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    '                            Me.DialogResult = Windows.Forms.DialogResult.OK
    '                        ElseIf countExistCopy = 1 Then
    '                            MessageBox.Show("There is one (1) copy that already exist in the database. Please check again the Accession Number.", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                        ElseIf countExistCopy > 1 Then
    '                            MessageBox.Show("There are more than one copy that already exist in the database. Check these Accession Numbers again and make necessary actions.", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                        End If
    '                    Else
    '                        MessageBox.Show("Book copy list is empty! At least one (1) copy is required to save this book.", "Required Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    End If
    '                Else
    '                    MessageBox.Show("Book Author list is empty!Add at least one (1) author.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    cboAuthor.Select()
    '                End If
    '            Else
    '                MessageBox.Show("Book Publisher is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                cboPublisher.Select()
    '            End If
    '        Else
    '            MessageBox.Show("Book Category is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            cboCategory.Select()
    '        End If
    '    Else
    '        MessageBox.Show("Book Title filed is empty!", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        txtTitle.Focus()
    '    End If
    'End Sub

    'Private Sub dgvBookCopy_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBookCopy.CellContentClick

    'End Sub

    'Private Sub dgvBookCopy_Click(sender As Object, e As EventArgs) Handles dgvBookCopy.Click

    'End Sub

    'Private Sub txtISBN_TextChanged(sender As Object, e As EventArgs) Handles txtISBN.TextChanged

    'End Sub

    'Private Sub txtMaxDuration_TextChanged(sender As Object, e As EventArgs) Handles txtMaxDuration.TextChanged

    'End Sub
    
    Private Sub btnRemoveBookCopy_Click(sender As Object, e As EventArgs) Handles btnRemoveBookCopy.Click
        If dgvBookCopy.Rows.Count > 0 Then
            Dim index As Integer = dgvBookCopy.Rows.Count - 1
            While index >= 0
                If dgvBookCopy.Rows(index).Cells(0).Value = True Then
                    dgvBookCopy.Rows.RemoveAt(index)
                End If
                index -= 1
            End While
            If dgvBookCopy.Rows.Count = 0 Then
                chbSelectAll.Checked = False
            End If
            lblNumberOfCopy.Text = "Number of Copies: " + dgvBookCopy.Rows.Count.ToString
            dgvBookCopy.Refresh()
            dgvBookCopy.Select()
        End If
    End Sub

    Private Sub chbSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles chbSelectAll.CheckedChanged
        If chbSelectAll.Checked = True Then
            For Each row As DataGridViewRow In dgvBookCopy.Rows
                row.Cells(0).Value = True
            Next
        Else
            For Each row As DataGridViewRow In dgvBookCopy.Rows
                row.Cells(0).Value = False
            Next
        End If
    End Sub

    Private Sub dgvBookCopy_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBookCopy.CellContentClick
        If e.ColumnIndex = 0 And dgvBookCopy.SelectedRows.Count > 0 Then
            If dgvBookCopy.SelectedRows(0).Cells(0).Value = False Then
                dgvBookCopy.SelectedRows(0).Cells(0).Value = True
            Else
                dgvBookCopy.SelectedRows(0).Cells(0).Value = False
            End If
        End If
    End Sub
End Class