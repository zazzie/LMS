Public Class FormUpdateBook
    Private _bookID As Integer
    Dim countCurrentCopy As Integer = 0
    Dim countClose As Integer = 0
    Dim objFormPublisher As New FormPublisher
    Dim objFormCategory As New FormCategory
    Dim objFormAuthor As New FormAuthor
    Dim objFormAddBookCopy As New FormAddNewBookCopy
    Dim objFormEditBookCopy As New FormEditNewBookCopy
    Dim objBook As New Book
    Dim objBookCopy As New BookCopy
    Dim dsPublisher As DataSet
    Dim dsCategory As DataSet
    Dim dsAuthor As DataSet
    Dim dsBookInfo As DataSet
    Dim dsBookCopy As DataSet
    Dim dsBookAuthorList As DataSet

    Public Property BookId
        Get
            Return _bookID
        End Get
        Set(value)
            _bookID = value
        End Set

    End Property

    'SELECT 0`bookId`, 1`bookISBN`, 2`bookTitle`, 3`bookPublisherId`, 4`bookCategoryId`, 5`bookBorrowType`, 
    '6`bookDescription`, 7`bookMaxBorrowDuration`, 8`bookPhoto` FROM `book` WHERE 1
    Private Sub loadBookInfo()
        dsBookInfo = LibraryDatabase.fetchSQL("SELECT * FROM book WHERE bookId=" + BookId.ToString + ";")

        If dsBookInfo.Tables(0).Rows.Count > 0 Then
            Dim indexPublisher As Integer = 0
            Dim indexCategory As Integer = 0
            txtBookId.Text = BookId.ToString
            txtTitle.Text = dsBookInfo.Tables(0).Rows(0).Item(2).ToString.Trim
            txtISBN.Text = dsBookInfo.Tables(0).Rows(0).Item(1).ToString.Trim
            If dsCategory.Tables(0).Rows.Count > 0 Then
                While indexCategory < dsCategory.Tables(0).Rows.Count
                    If dsBookInfo.Tables(0).Rows(0).Item(4).ToString.Trim = dsCategory.Tables(0).Rows(indexCategory).Item(0).ToString.Trim Then
                        cboCategory.SelectedIndex = indexCategory
                        Exit While
                    End If
                    indexCategory += 1
                End While
            End If
            If dsPublisher.Tables(0).Rows.Count > 0 Then
                While indexPublisher < dsPublisher.Tables(0).Rows.Count
                    If dsBookInfo.Tables(0).Rows(0).Item(3).ToString.Trim = dsPublisher.Tables(0).Rows(indexPublisher).Item(0).ToString.Trim Then
                        cboPublisher.SelectedIndex = indexPublisher
                        Exit While
                    End If
                    indexPublisher += 1
                End While
            End If
            cboBorrowType.Text = dsBookInfo.Tables(0).Rows(0).Item(5).ToString.Trim
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
            End If
            rtbBookDescription.Text = dsBookInfo.Tables(0).Rows(0).Item(6).ToString.Trim
            pictBook.BackgroundImage = Base64ToImage(dsBookInfo.Tables(0).Rows(0).Item(8).ToString.Trim)
        End If
    End Sub

    'SELECT 0`bookAuthorListId`, 1`bookAuthorListBookId`, 2`bookAuthorListAuthorId` FROM `bookauthorlist` WHERE 1
    'SELECT 3`authorId`, 4`authorFirst`, 5`authorMiddle`, 6`authorLast` FROM `author` WHERE 1
    Private Sub loadAuthorList()
        dsBookAuthorList = LibraryDatabase.fetchSQL("SELECT * FROM bookauthorlist JOIN author ON bookAuthorListAuthorId=authorId WHERE bookAuthorListBookId=" + BookId.ToString + ";")

        dgvAuthorList.Rows.Clear()
        If dsBookAuthorList.Tables(0).Rows.Count > 0 Then
            Dim indexAuthor As Integer = 0
            While indexAuthor < dsBookAuthorList.Tables(0).Rows.Count
                With dgvAuthorList
                    .Rows.Add(dsBookAuthorList.Tables(0).Rows(indexAuthor).Item(3).ToString.Trim, _
                            dsBookAuthorList.Tables(0).Rows(indexAuthor).Item(6).ToString.Trim + ", " + dsBookAuthorList.Tables(0).Rows(indexAuthor).Item(4).ToString.Trim + " " + dsBookAuthorList.Tables(0).Rows(indexAuthor).Item(5).ToString.Trim)
                End With
                indexAuthor += 1
            End While
        End If
    End Sub

    'SELECT 0`bookAccessionId`, 1`bookCopyBookId`, 2`bookCopyNumber`, 3`bookCopyQuality`, 4`bookCopyAquisition`, 
    '5`bookCopyPrice`, 6`bookCopyDateAdded`, 7`bookCopyShelfId`, 8`bookCopyShelfSectionId`, 9`bookCopyStatus` FROM `bookcopy` WHERE 1
    '10`bookShelfSectionId`, 11`bookShelfSectionName`, 12`bookShelfSectionBookShelfId`
    '13`bookshelfId`, 14`bookshelfName`
    Private Sub loadBookCopy()
        dsBookCopy = LibraryDatabase.fetchSQL("SELECT * FROM `bookcopy` JOIN bookshelfsection " & _
                                              "ON bookCopyShelfSectionId=bookShelfSectionId " & _
                                              "JOIN bookshelf ON bookshelfId=bookShelfSectionBookShelfId " & _
                                              "WHERE bookCopyBookId=" + BookId.ToString + " ORDER BY bookAccessionId ASC;")
        dgvBookCopy.Rows.Clear()
        If dsBookCopy.Tables(0).Rows.Count > 0 Then
            Dim indexBookCopy As Integer = 0
            While indexBookCopy < dsBookCopy.Tables(0).Rows.Count
                With dgvBookCopy
                    .Rows.Add(dsBookCopy.Tables(0).Rows(indexBookCopy).Item(0).ToString.Trim, _
                              dsBookCopy.Tables(0).Rows(indexBookCopy).Item(4).ToString.Trim, _
                              dsBookCopy.Tables(0).Rows(indexBookCopy).Item(5).ToString.Trim, _
                              dsBookCopy.Tables(0).Rows(indexBookCopy).Item(6).ToString.Trim, _
                              dsBookCopy.Tables(0).Rows(indexBookCopy).Item(14).ToString.Trim, _
                              dsBookCopy.Tables(0).Rows(indexBookCopy).Item(11).ToString.Trim)
                End With
                indexBookCopy += 1
            End While
        End If
    End Sub

    Private Sub renameColumns()
        With dgvAuthorList
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "Author"
        End With

        With dgvBookCopy
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Accession Number" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "Aquisition"
            .Columns(2).HeaderCell.Value = "Price"
            .Columns(3).HeaderCell.Value = "Date Added"
            .Columns(4).HeaderCell.Value = "Shelf"
            .Columns(5).HeaderCell.Value = "Shelf Section"
        End With
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
                Dim sqlInsert As String = "INSERT INTO `publisher`(`publisherId`, `publisherName`) VALUES (0,'N/A');"
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
                Dim sqlInsert As String = "INSERT INTO `category`(`categoryId`, `categoryName`) VALUES (0,'UNKNOWN');"
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
                Dim sqlInsert As String = "INSERT INTO `author`(`authorId`, `authorLast`) VALUES (0,'UNKNOWN');"
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
            If row.Cells(0).Value = dsAuthor.Tables(0).Rows(cboAuthorIndex).Item(0) Then
                countInList += 1
                Exit For
            End If
        Next
        If countInList = 0 Then
            With dgvAuthorList
                dgvAuthorList.Rows.Add(dsAuthor.Tables(0).Rows(cboAuthorIndex).Item(0).ToString.Trim, _
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

    Private Sub FormUpdateBook_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub FormUpdateBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not BookId = Nothing Then
            dgvAuthorList.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
            dgvBookCopy.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
            renameColumns()
            generateAuthor()
            generateCategory()
            generatePublisher()

            Try
                loadBookInfo()
                loadAuthorList()
                loadBookCopy()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
            txtTitle.Focus()
        Else
            Panel1.Enabled = False
            btnUpdateBook.Enabled = False
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If Not countCurrentCopy = dgvBookCopy.Rows.Count Then
            Dim ans As Integer
            ans = MsgBox("Do you want to cancel book update?", MsgBoxStyle.YesNo, "Unsaved Update")
            If ans = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                countClose += 1
                Me.Dispose()
            End If
        Else
            Dim ans As Integer
            ans = MsgBox("General book information update in not saved. Proceed closing window?", MsgBoxStyle.YesNo, "Unsaved Update")
            If ans = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                countClose += 1
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub btnAddBookCopy_Click(sender As Object, e As EventArgs) Handles btnAddBookCopy.Click
        objFormAddBookCopy = New FormAddNewBookCopy
        objFormAddBookCopy.BookId = txtBookId.Text
        If objFormAddBookCopy.ShowDialog = Windows.Forms.DialogResult.OK Then
            dgvBookCopy.Rows.Clear()
            loadBookCopy()
            dgvBookCopy.Refresh()
            dgvBookCopy.Select()
        End If
    End Sub

    Private Sub btnUpdateBook_Click(sender As Object, e As EventArgs) Handles btnUpdateBook.Click
        If Not String.IsNullOrWhiteSpace(txtTitle.Text) Then
            If Not String.IsNullOrWhiteSpace(cboCategory.Text) Then
                If Not String.IsNullOrWhiteSpace(cboPublisher.Text) Then
                    If dgvAuthorList.Rows.Count > 0 Then
                        If dgvBookCopy.Rows.Count > 0 Then

                            Dim sqlInsert As String = "DELETE FROM `bookauthorlist` WHERE bookAuthorListBookId=" + txtBookId.Text + ";"

                            objBook = New Book
                            objBook.BookId = txtBookId.Text
                            objBook.BookISBN = txtISBN.Text
                            objBook.BookTitle = txtTitle.Text
                            objBook.BookPublisherId = Val(dsPublisher.Tables(0).Rows(cboPublisher.SelectedIndex).Item(0).ToString)
                            objBook.BookCategoryId = Val(dsCategory.Tables(0).Rows(cboCategory.SelectedIndex).Item(0).ToString)
                            objBook.BookBorrowType = cboBorrowType.Text
                            objBook.BookDescription = rtbBookDescription.Text
                            If cboBorrowType.Text = "FOR INSIDE AND OUTSIDE USE" Then
                                objBook.BookMaxBorrowDuration = txtMaxDuration.Text
                            Else
                                objBook.BookMaxBorrowDuration = 0
                            End If
                            objBook.BookPhoto = objBook.ConvertImageTo64(pictBook.BackgroundImage)

                            sqlInsert += "UPDATE `book` SET " & _
                                        "`bookISBN`='" + objBook.BookISBN & _
                                        "',`bookTitle`='" + objBook.BookTitle & _
                                        "',`bookPublisherId`=" + objBook.BookPublisherId.ToString & _
                                        ",`bookCategoryId`=" + objBook.BookCategoryId.ToString & _
                                        ",`bookBorrowType`='" + objBook.BookBorrowType & _
                                        "',`bookDescription`='" + objBook.BookDescription & _
                                        "',`bookMaxBorrowDuration`=" + objBook.BookMaxBorrowDuration.ToString & _
                                        ",`bookPhoto`='" + objBook.BookPhoto & _
                                        "' WHERE bookId= " + objBook.BookId.ToString & ";"
                            'adding author list
                            Dim id As Integer
                            id = LibraryDatabase.GenerateID("SELECT MAX(bookAuthorListId) from bookauthorlist;")
                            For Each row As DataGridViewRow In dgvAuthorList.Rows

                                sqlInsert += "INSERT INTO `bookauthorlist`(`bookAuthorListId`, `bookAuthorListBookId`, `bookAuthorListAuthorId`) VALUES (" & _
                                                            id.ToString + "," & _
                                                            objBook.BookId.ToString + "," & _
                                                            row.Cells(0).Value.ToString + ");"

                                id += 1
                            Next
                            Try
                                LibraryDatabase.execSQL(sqlInsert)
                                MessageBox.Show("You have successfully updated a book!", "Successfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                                Me.DialogResult = Windows.Forms.DialogResult.OK
                            Catch ex As Exception
                                MsgBox(ex.Message.ToString)
                            End Try
                        Else
                            MessageBox.Show("Book copy list is empty! At least one (1) copy is required to update this book.", "Required Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        MessageBox.Show("Book Author list is empty!Add at least one (1) author.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cboAuthor.Select()
                    End If
                Else
                    MessageBox.Show("Book Publisher is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cboPublisher.Select()
                End If
            Else
                MessageBox.Show("Book Category is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboCategory.Select()
            End If
        Else
            MessageBox.Show("Book Title field is empty!", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtTitle.Focus()
        End If
    End Sub

    Private Sub btnEditBookCopy_Click(sender As Object, e As EventArgs) Handles btnEditBookCopy.Click
        objFormEditBookCopy = New FormEditNewBookCopy
        objFormEditBookCopy.BookAccessionId = dgvBookCopy.SelectedRows(0).Cells(0).Value
        'MsgBox(dgvBookCopy.SelectedRows(0).Cells(0).Value.ToString)
        If objFormEditBookCopy.ShowDialog = Windows.Forms.DialogResult.OK Then
            loadBookCopy()
            dgvBookCopy.Refresh()
            dgvBookCopy.Select()
        End If
    End Sub

    Private Sub btnRemoveBookCopy_Click(sender As Object, e As EventArgs) Handles btnRemoveBookCopy.Click
        If dgvBookCopy.Rows.Count > 0 Then
            If dgvBookCopy.Rows.Count = 1 Then
                MessageBox.Show("You cannot delete a last copy of this book from this update book form. You may delete the book from the book list instead.", "Delete Restriction")
            Else
                Dim ans As Integer
                ans = MsgBox("Are you sure you want to remove accession number: " + dgvBookCopy.SelectedRows(0).Cells(0).Value.ToString.Trim + " from the book copy list?", MsgBoxStyle.YesNo, "Remove Book")
                If ans = MsgBoxResult.Yes Then
                    objBookCopy.BookAccessionId = dgvBookCopy.SelectedRows(0).Cells(0).Value
                    objBookCopy.deleteBookCopy()
                    MessageBox.Show("You have successfully deleted accession number: " + dgvBookCopy.SelectedRows(0).Cells(0).Value.ToString.Trim + " from the list.", "Deleted Record")
                    loadBookCopy()
                    dgvBookCopy.Refresh()
                    dgvBookCopy.Select()
                End If
            End If
            
        End If
    End Sub

End Class