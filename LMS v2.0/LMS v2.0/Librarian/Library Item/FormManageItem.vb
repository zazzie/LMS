Public Class FormManageItem
    Dim objFormAddBook As New FormAddBook
    Dim objFormViewBook As New FormViewBook
    Dim objFormUpdateBook As New FormUpdateBook
    Dim objFormAddItem As New FormAddItem
    Dim objFormViewItem As New FormViewLibraryItem
    Dim objFormUpdateItem As New FormUpdateItem

    Dim objBook As New Book
    Dim objItem As New LibraryItem
    Dim objAuthorlist As New BookAuthorList

    Private Sub generateBookISBN()
        Dim sqlSearch As String
        sqlSearch = "SELECT DISTINCT book.bookId, book.bookISBN, book.bookTitle, book.bookCategoryId, book.bookBorrowType, category.categoryName, publisher.publisherName " & _
            "FROM book " & _
            "JOIN bookauthorlist ON book.bookId=bookauthorlist.bookAuthorListBookId " & _
                        "JOIN author ON author.authorId=bookauthorlist.bookAuthorListAuthorId " & _
                        "JOIN category ON categoryId=bookCategoryId " & _
                        "JOIN publisher ON publisherId=bookPublisherId " & _
                        "WHERE bookISBN LIKE '" & txtSearch.Text & "%' ;"

        Dim ds As DataSet
        dgvBook.Rows.Clear()
        ds = LibraryDatabase.fetchSQL(sqlSearch)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim index As Integer = 0
            While index < ds.Tables(0).Rows.Count

                ''author listings
                Dim sqlSearchAuthor As String
                Dim authorNames As String
                sqlSearchAuthor = "SELECT DISTINCT `authorFirst`, `authorLast` FROM author join " & _
                    "bookauthorlist on author.authorId=bookauthorlist.bookAuthorListAuthorId Join " & _
                    "book on book.bookId=bookauthorlist.bookAuthorListBookId where bookid=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim + ";"
                Dim dsAuthor As DataSet
                authorNames = ""
                dsAuthor = LibraryDatabase.fetchSQL(sqlSearchAuthor)
                If dsAuthor.Tables(0).Rows.Count > 0 Then
                    Dim indexAuthor As Integer = 0
                    While indexAuthor < dsAuthor.Tables(0).Rows.Count
                        authorNames += dsAuthor.Tables(0).Rows(indexAuthor).Item(0).ToString.Trim + " " + dsAuthor.Tables(0).Rows(indexAuthor).Item(1).ToString.Trim
                        indexAuthor += 1
                        If Not indexAuthor = dsAuthor.Tables(0).Rows.Count Then
                            authorNames += ", "
                        End If
                    End While
                End If

                Dim countCopy As Integer = 0
                Dim countAvailability As Integer = 0
                Dim sqlCountCopy As String = "SELECT COUNT(*) FROM bookcopy WHERE bookCopyBookId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim + ";"
                Dim sqlCountAvailable As String = "SELECT COUNT(*) FROM bookcopy WHERE bookCopyBookId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim & _
                    " AND bookCopyStatus='IN';"
                countCopy = countRecord(sqlCountCopy)
                countAvailability = countRecord(sqlCountAvailable)
                'dgv actual listing
                ' 0 book.bookId, 1 book.bookISBN, 2 book.bookTitle, 
                '3 book.bookCategoryId, 4 book.bookBorrowType, 5 category.categoryName, 6 publisher.publisherName
                With dgvBook
                    dgvBook.Rows.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim, _
                                     ds.Tables(0).Rows(index).Item(2).ToString.Trim, _
                                     authorNames, _
                                     ds.Tables(0).Rows(index).Item(5).ToString.Trim, _
                                     ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                     countCopy.ToString.Trim, _
                                     countAvailability.ToString.Trim)
                    If ds.Tables(0).Rows(index).Item(4).ToString.Trim = "FOR INSIDE READING ONLY" Then
                        .Rows(index).DefaultCellStyle.BackColor = Color.MistyRose
                    ElseIf ds.Tables(0).Rows(index).Item(4).ToString.Trim = "FOR INSIDE AND OUTSIDE USE" Then
                        .Rows(index).DefaultCellStyle.BackColor = Color.PaleTurquoise
                    End If
                End With
                index += 1
            End While
            dgvBook.Refresh()
            dgvBook.Select()
            txtSearch.Select()
        Else
            dgvBook.Rows.Clear()
            If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                MessageBox.Show("No book results found for `" + txtSearch.Text + "'.", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSearch.Select()
            End If
        End If
    End Sub

    Private Sub generateBookTitle()
        Dim sqlSearch As String
        'SELECT  `bookPublisherId`,  ``, `bookDescription`, `bookMaxBorrowDuration`, `bookPhoto` FROM `book` WHERE
        sqlSearch = "SELECT DISTINCT book.bookId, book.bookISBN, book.bookTitle, book.bookCategoryId, book.bookBorrowType, category.categoryName, publisher.publisherName " & _
                    "FROM `book` " & _
                    "JOIN bookauthorlist ON book.bookId=bookauthorlist.bookAuthorListBookId " & _
                    "JOIN author ON author.authorId=bookauthorlist.bookAuthorListAuthorId " & _
                    "JOIN category ON categoryId=bookCategoryId " & _
                    "JOIN publisher ON publisherId=bookPublisherId " & _
                    "WHERE bookTitle LIKE '" & txtSearch.Text & "%' ;"

        Dim ds As DataSet
        dgvBook.Rows.Clear()
        ds = LibraryDatabase.fetchSQL(sqlSearch)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim index As Integer = 0
            While index < ds.Tables(0).Rows.Count

                ''author listings
                Dim sqlSearchAuthor As String
                Dim authorNames As String
                sqlSearchAuthor = "SELECT DISTINCT `authorFirst`, `authorLast` FROM author join " & _
                    "bookauthorlist on author.authorId=bookauthorlist.bookAuthorListAuthorId Join " & _
                    "book on book.bookId=bookauthorlist.bookAuthorListBookId where bookid=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim + ";"
                Dim dsAuthor As DataSet
                authorNames = ""
                dsAuthor = LibraryDatabase.fetchSQL(sqlSearchAuthor)
                If dsAuthor.Tables(0).Rows.Count > 0 Then
                    Dim indexAuthor As Integer = 0
                    While indexAuthor < dsAuthor.Tables(0).Rows.Count
                        authorNames += dsAuthor.Tables(0).Rows(indexAuthor).Item(0).ToString.Trim + " " + dsAuthor.Tables(0).Rows(indexAuthor).Item(1).ToString.Trim
                        indexAuthor += 1
                        If Not indexAuthor = dsAuthor.Tables(0).Rows.Count Then
                            authorNames += ", "
                        End If
                    End While
                End If

                Dim countCopy As Integer = 0
                Dim countAvailability As Integer = 0
                Dim sqlCountCopy As String = "SELECT COUNT(*) FROM bookcopy WHERE bookCopyBookId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim + ";"
                Dim sqlCountAvailable As String = "SELECT COUNT(*) FROM bookcopy WHERE bookCopyBookId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim & _
                    " AND bookCopyStatus='IN';"
                countCopy = countRecord(sqlCountCopy)
                countAvailability = countRecord(sqlCountAvailable)
                'dgv actual listing
                ' 0 book.bookId, 1 book.bookISBN, 2 book.bookTitle, 
                '3 book.bookCategoryId, 4 book.bookBorrowType, 5 category.categoryName, 6 publisher.publisherName
                With dgvBook
                    dgvBook.Rows.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim, _
                                     ds.Tables(0).Rows(index).Item(2).ToString.Trim, _
                                     authorNames, _
                                     ds.Tables(0).Rows(index).Item(5).ToString.Trim, _
                                     ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                     countCopy.ToString.Trim, _
                                     countAvailability.ToString.Trim)
                    If ds.Tables(0).Rows(index).Item(4).ToString.Trim = "FOR INSIDE READING ONLY" Then
                        .Rows(index).DefaultCellStyle.BackColor = Color.MistyRose
                    ElseIf ds.Tables(0).Rows(index).Item(4).ToString.Trim = "FOR INSIDE AND OUTSIDE USE" Then
                        .Rows(index).DefaultCellStyle.BackColor = Color.PaleTurquoise
                    End If
                End With
                index += 1
            End While
            dgvBook.Refresh()
            dgvBook.Select()
            txtSearch.Select()
        Else
            dgvBook.Rows.Clear()
            If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                MessageBox.Show("No book results found for `" + txtSearch.Text + "'.", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSearch.Select()
            End If
        End If
    End Sub

    Private Sub generateBookAuthor()
        Dim sqlSearch As String

        'SELECT  `bookPublisherId`,  ``, `bookDescription`, `bookMaxBorrowDuration`, `bookPhoto` FROM `book` WHERE
        sqlSearch = "SELECT DISTINCT book.bookId, book.bookISBN, book.bookTitle, book.bookCategoryId, book.bookBorrowType, category.categoryName, publisher.publisherName " & _
                    "FROM `book` " & _
                    "JOIN bookauthorlist ON book.bookId=bookauthorlist.bookAuthorListBookId " & _
                    "JOIN author ON author.authorId=bookauthorlist.bookAuthorListAuthorId " & _
                    "JOIN category ON categoryId=bookCategoryId " & _
                    "JOIN publisher ON publisherId=bookPublisherId " & _
                    "WHERE author.authorLast LIKE '" & txtSearch.Text & "%' OR " & _
                    "author.authorFirst LIKE '" & txtSearch.Text & "%' OR " & _
                    "author.authorMiddle LIKE '" & txtSearch.Text & "%' ;"

        Dim ds As DataSet
        dgvBook.Rows.Clear()
        ds = LibraryDatabase.fetchSQL(sqlSearch)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim index As Integer = 0
            While index < ds.Tables(0).Rows.Count

                ''author listings
                Dim sqlSearchAuthor As String
                Dim authorNames As String
                sqlSearchAuthor = "SELECT DISTINCT `authorFirst`, `authorLast` FROM author join " & _
                    "bookauthorlist on author.authorId=bookauthorlist.bookAuthorListAuthorId Join " & _
                    "book on book.bookId=bookauthorlist.bookAuthorListBookId where bookid=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim + ";"
                Dim dsAuthor As DataSet
                authorNames = ""
                dsAuthor = LibraryDatabase.fetchSQL(sqlSearchAuthor)
                If dsAuthor.Tables(0).Rows.Count > 0 Then
                    Dim indexAuthor As Integer = 0
                    While indexAuthor < dsAuthor.Tables(0).Rows.Count
                        authorNames += dsAuthor.Tables(0).Rows(indexAuthor).Item(0).ToString.Trim + " " + dsAuthor.Tables(0).Rows(indexAuthor).Item(1).ToString.Trim
                        indexAuthor += 1
                        If Not indexAuthor = dsAuthor.Tables(0).Rows.Count Then
                            authorNames += ", "
                        End If
                    End While
                End If

                Dim countCopy As Integer = 0
                Dim countAvailability As Integer = 0
                Dim sqlCountCopy As String = "SELECT COUNT(*) FROM bookcopy WHERE bookCopyBookId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim + ";"
                Dim sqlCountAvailable As String = "SELECT COUNT(*) FROM bookcopy WHERE bookCopyBookId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim & _
                    " AND bookCopyStatus='IN';"
                countCopy = countRecord(sqlCountCopy)
                countAvailability = countRecord(sqlCountAvailable)
                'dgv actual listing
                ' 0 book.bookId, 1 book.bookISBN, 2 book.bookTitle, 
                '3 book.bookCategoryId, 4 book.bookBorrowType, 5 category.categoryName, 6 publisher.publisherName
                With dgvBook
                    dgvBook.Rows.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim, _
                                     ds.Tables(0).Rows(index).Item(2).ToString.Trim, _
                                     authorNames, _
                                     ds.Tables(0).Rows(index).Item(5).ToString.Trim, _
                                     ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                     countCopy.ToString.Trim, _
                                     countAvailability.ToString.Trim)
                    If ds.Tables(0).Rows(index).Item(4).ToString.Trim = "FOR INSIDE READING ONLY" Then
                        .Rows(index).DefaultCellStyle.BackColor = Color.MistyRose
                    ElseIf ds.Tables(0).Rows(index).Item(4).ToString.Trim = "FOR INSIDE AND OUTSIDE USE" Then
                        .Rows(index).DefaultCellStyle.BackColor = Color.PaleTurquoise
                    End If
                End With
                index += 1
            End While
            dgvBook.Refresh()
            dgvBook.Select()
            txtSearch.Select()
        Else
            dgvBook.Rows.Clear()
            If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                MessageBox.Show("No book results found for '" + txtSearch.Text + "'.", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSearch.Select()
            End If
        End If
        
    End Sub
    Private Sub generateBookCategoryID()
        Dim sqlSearch As String

        'SELECT  `bookPublisherId`,  ``, `bookDescription`, `bookMaxBorrowDuration`, `bookPhoto` FROM `book` WHERE
        sqlSearch = "SELECT DISTINCT book.bookId, book.bookISBN, book.bookTitle, book.bookCategoryId, book.bookBorrowType, category.categoryName, publisher.publisherName " & _
                    "FROM `book` " & _
                    "JOIN bookauthorlist ON book.bookId=bookauthorlist.bookAuthorListBookId " & _
                    "JOIN author ON author.authorId=bookauthorlist.bookAuthorListAuthorId " & _
                    "JOIN category ON categoryId=bookCategoryId " & _
                    "JOIN publisher ON publisherId=bookPublisherId " & _
                    "WHERE category.categoryId = " & txtSearch.Text & " ;"

        Dim ds As DataSet
        dgvBook.Rows.Clear()
        ds = LibraryDatabase.fetchSQL(sqlSearch)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim index As Integer = 0
            While index < ds.Tables(0).Rows.Count

                ''author listings
                Dim sqlSearchAuthor As String
                Dim authorNames As String
                sqlSearchAuthor = "SELECT DISTINCT `authorFirst`, `authorLast` FROM author join " & _
                    "bookauthorlist on author.authorId=bookauthorlist.bookAuthorListAuthorId Join " & _
                    "book on book.bookId=bookauthorlist.bookAuthorListBookId where bookid=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim + ";"
                Dim dsAuthor As DataSet
                authorNames = ""
                dsAuthor = LibraryDatabase.fetchSQL(sqlSearchAuthor)
                If dsAuthor.Tables(0).Rows.Count > 0 Then
                    Dim indexAuthor As Integer = 0
                    While indexAuthor < dsAuthor.Tables(0).Rows.Count
                        authorNames += dsAuthor.Tables(0).Rows(indexAuthor).Item(0).ToString.Trim + " " + dsAuthor.Tables(0).Rows(indexAuthor).Item(1).ToString.Trim
                        indexAuthor += 1
                        If Not indexAuthor = dsAuthor.Tables(0).Rows.Count Then
                            authorNames += ", "
                        End If
                    End While
                End If

                Dim countCopy As Integer = 0
                Dim countAvailability As Integer = 0
                Dim sqlCountCopy As String = "SELECT COUNT(*) FROM bookcopy WHERE bookCopyBookId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim + ";"
                Dim sqlCountAvailable As String = "SELECT COUNT(*) FROM bookcopy WHERE bookCopyBookId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim & _
                    " AND bookCopyStatus='IN';"
                countCopy = countRecord(sqlCountCopy)
                countAvailability = countRecord(sqlCountAvailable)
                'dgv actual listing
                ' 0 book.bookId, 1 book.bookISBN, 2 book.bookTitle, 
                '3 book.bookCategoryId, 4 book.bookBorrowType, 5 category.categoryName, 6 publisher.publisherName
                With dgvBook
                    dgvBook.Rows.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim, _
                                     ds.Tables(0).Rows(index).Item(2).ToString.Trim, _
                                     authorNames, _
                                     ds.Tables(0).Rows(index).Item(5).ToString.Trim, _
                                     ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                     countCopy.ToString.Trim, _
                                     countAvailability.ToString.Trim)
                    If ds.Tables(0).Rows(index).Item(4).ToString.Trim = "FOR INSIDE READING ONLY" Then
                        .Rows(index).DefaultCellStyle.BackColor = Color.MistyRose
                    ElseIf ds.Tables(0).Rows(index).Item(4).ToString.Trim = "FOR INSIDE AND OUTSIDE USE" Then
                        .Rows(index).DefaultCellStyle.BackColor = Color.PaleTurquoise
                    End If
                End With
                index += 1
            End While
            dgvBook.Refresh()
            dgvBook.Select()
            txtSearch.Select()
        Else
            dgvBook.Rows.Clear()
            If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                MessageBox.Show("No book results found for `" + txtSearch.Text + "'.", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSearch.Select()
            End If
        End If
        
    End Sub
    Private Sub generateBookCategoryName()
        Dim sqlSearch As String
            'SELECT  `bookPublisherId`,  ``, `bookDescription`, `bookMaxBorrowDuration`, `bookPhoto` FROM `book` WHERE
            sqlSearch = "SELECT DISTINCT book.bookId, book.bookISBN, book.bookTitle, book.bookCategoryId, book.bookBorrowType, category.categoryName, publisher.publisherName " & _
                        "FROM `book` " & _
                        "JOIN bookauthorlist ON book.bookId=bookauthorlist.bookAuthorListBookId " & _
                        "JOIN author ON author.authorId=bookauthorlist.bookAuthorListAuthorId " & _
                        "JOIN category ON categoryId=bookCategoryId " & _
                        "JOIN publisher ON publisherId=bookPublisherId " & _
                        "WHERE category.categoryName LIKE '" & txtSearch.Text & "%'  ;"

            Dim ds As DataSet
            dgvBook.Rows.Clear()
            ds = LibraryDatabase.fetchSQL(sqlSearch)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count

                    ''author listings
                    Dim sqlSearchAuthor As String
                    Dim authorNames As String
                    sqlSearchAuthor = "SELECT DISTINCT `authorFirst`, `authorLast` FROM author join " & _
                        "bookauthorlist on author.authorId=bookauthorlist.bookAuthorListAuthorId Join " & _
                        "book on book.bookId=bookauthorlist.bookAuthorListBookId where bookid=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim + ";"
                    Dim dsAuthor As DataSet
                    authorNames = ""
                    dsAuthor = LibraryDatabase.fetchSQL(sqlSearchAuthor)
                    If dsAuthor.Tables(0).Rows.Count > 0 Then
                        Dim indexAuthor As Integer = 0
                        While indexAuthor < dsAuthor.Tables(0).Rows.Count
                            authorNames += dsAuthor.Tables(0).Rows(indexAuthor).Item(0).ToString.Trim + " " + dsAuthor.Tables(0).Rows(indexAuthor).Item(1).ToString.Trim
                            indexAuthor += 1
                            If Not indexAuthor = dsAuthor.Tables(0).Rows.Count Then
                                authorNames += ", "
                            End If
                        End While
                    End If

                    Dim countCopy As Integer = 0
                    Dim countAvailability As Integer = 0
                    Dim sqlCountCopy As String = "SELECT COUNT(*) FROM bookcopy WHERE bookCopyBookId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim + ";"
                    Dim sqlCountAvailable As String = "SELECT COUNT(*) FROM bookcopy WHERE bookCopyBookId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim & _
                        " AND bookCopyStatus='IN';"
                    countCopy = countRecord(sqlCountCopy)
                    countAvailability = countRecord(sqlCountAvailable)
                    'dgv actual listing
                    ' 0 book.bookId, 1 book.bookISBN, 2 book.bookTitle, 
                    '3 book.bookCategoryId, 4 book.bookBorrowType, 5 category.categoryName, 6 publisher.publisherName
                    With dgvBook
                        dgvBook.Rows.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim, _
                                         ds.Tables(0).Rows(index).Item(2).ToString.Trim, _
                                         authorNames, _
                                         ds.Tables(0).Rows(index).Item(5).ToString.Trim, _
                                         ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                         countCopy.ToString.Trim, _
                                         countAvailability.ToString.Trim)
                        If ds.Tables(0).Rows(index).Item(4).ToString.Trim = "FOR INSIDE READING ONLY" Then
                            .Rows(index).DefaultCellStyle.BackColor = Color.MistyRose
                        ElseIf ds.Tables(0).Rows(index).Item(4).ToString.Trim = "FOR INSIDE AND OUTSIDE USE" Then
                            .Rows(index).DefaultCellStyle.BackColor = Color.PaleTurquoise
                        End If
                    End With
                    index += 1
                End While
                dgvBook.Refresh()
                dgvBook.Select()
                txtSearch.Select()
            Else
                dgvBook.Rows.Clear()
                If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                MessageBox.Show("No book results found for `" + txtSearch.Text + "'.", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSearch.Select()
                End If
            End If
    End Sub

    Private Sub generateItemName()
        Dim sqlSearch As String

        'SELECT `libraryItemId`, `libraryItemName`, `libraryItemType`, `libraryItemBorrowType`,
        ' `libraryItemBorrowDuration`, `libraryItemDescription`, `libraryItemPhoto` FROM `libraryitem` WHERE 1
        sqlSearch = "SELECT DISTINCT `libraryItemId`, `libraryItemName`, `itemTypeName`, `libraryItemBorrowType` FROM `libraryitem` " & _
            "JOIN itemtype ON itemTypeId=libraryItemType " & _
            "WHERE " & _
            "libraryItemName LIKE '" & txtSearchItem.Text & "%';"

        Dim ds As DataSet
        dgvItem.Rows.Clear()
        ds = LibraryDatabase.fetchSQL(sqlSearch)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim index As Integer = 0
            While index < ds.Tables(0).Rows.Count
                Dim countQuantity As Integer = 0
                Dim countItemAvailability As Integer = 0
                Dim sqlCountQuantity As String = "SELECT COUNT(*) FROM libraryitemunit WHERE libraryItemUnitItemId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim + ";"
                Dim sqlCountItemAvailable As String = "SELECT COUNT(*) FROM libraryitemunit WHERE libraryItemUnitItemId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim & _
                    " AND libraryItemUnitStatus='IN';"
                countQuantity = countRecord(sqlCountQuantity)
                countItemAvailability = countRecord(sqlCountItemAvailable)
                'dgv actual listing
                '0`libraryItemId`, 1`libraryItemName`, 2`libraryItemType`
                With dgvItem
                    .Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                              ds.Tables(0).Rows(index).Item(1).ToString.Trim, _
                              ds.Tables(0).Rows(index).Item(2).ToString.Trim, _
                              countQuantity.ToString.Trim, _
                              countItemAvailability.ToString.Trim)
                    'libraryItemBorrowType
                    If ds.Tables(0).Rows(index).Item(3).ToString.Trim = "FOR INSIDE USE ONLY" Then
                        .Rows(index).DefaultCellStyle.BackColor = Color.MistyRose
                    ElseIf ds.Tables(0).Rows(index).Item(3).ToString.Trim = "FOR INSIDE AND OUTSIDE USE" Then
                        .Rows(index).DefaultCellStyle.BackColor = Color.PaleTurquoise
                    End If
                End With
                index += 1
            End While
            dgvItem.Refresh()
            dgvItem.Select()
            txtSearchItem.Select()
        Else
            dgvItem.Rows.Clear()
            If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                MessageBox.Show("No item results found for Item Name: `" + txtSearchItem.Text + "'.", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSearchItem.Select()
            End If
        End If
    End Sub

    Private Sub generateItemID()
        Dim sqlSearch As String

        'SELECT `libraryItemId`, `libraryItemName`, `libraryItemType`, `libraryItemBorrowType`,
        ' `libraryItemBorrowDuration`, `libraryItemDescription`, `libraryItemPhoto` FROM `libraryitem` WHERE 1
        sqlSearch = "SELECT DISTINCT `libraryItemId`, `libraryItemName`, `itemTypeName`, `libraryItemBorrowType` FROM `libraryitem` " & _
            "JOIN itemtype ON itemTypeId=libraryItemType " & _
            "WHERE " & _
            "libraryItemId=" + txtSearchItem.Text + ";"

        Dim ds As DataSet
        dgvItem.Rows.Clear()
        ds = LibraryDatabase.fetchSQL(sqlSearch)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim index As Integer = 0
            While index < ds.Tables(0).Rows.Count
                Dim countQuantity As Integer = 0
                Dim countItemAvailability As Integer = 0
                Dim sqlCountQuantity As String = "SELECT COUNT(*) FROM libraryitemunit WHERE libraryItemUnitItemId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim + ";"
                Dim sqlCountItemAvailable As String = "SELECT COUNT(*) FROM libraryitemunit WHERE libraryItemUnitItemId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim & _
                    " AND libraryItemUnitStatus='IN';"
                countQuantity = countRecord(sqlCountQuantity)
                countItemAvailability = countRecord(sqlCountItemAvailable)
                'dgv actual listing
                '0`libraryItemId`, 1`libraryItemName`, 2`libraryItemType`
                With dgvItem
                    .Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                              ds.Tables(0).Rows(index).Item(1).ToString.Trim, _
                              ds.Tables(0).Rows(index).Item(2).ToString.Trim, _
                              countQuantity.ToString.Trim, _
                              countItemAvailability.ToString.Trim)
                    'libraryItemBorrowType
                    If ds.Tables(0).Rows(index).Item(3).ToString.Trim = "FOR INSIDE USE ONLY" Then
                        .Rows(index).DefaultCellStyle.BackColor = Color.MistyRose
                    ElseIf ds.Tables(0).Rows(index).Item(3).ToString.Trim = "FOR INSIDE AND OUTSIDE USE" Then
                        .Rows(index).DefaultCellStyle.BackColor = Color.PaleTurquoise
                    End If
                End With
                index += 1
            End While
            dgvItem.Refresh()
            dgvItem.Select()
            txtSearchItem.Select()
        Else
            dgvItem.Rows.Clear()
            If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                MessageBox.Show("No item results found for Item ID: `" + txtSearchItem.Text + "'.", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSearchItem.Select()
            End If
        End If
    End Sub

    Private Sub generateBookID()
        Dim sqlSearch As String

        'SELECT  `bookPublisherId`,  ``, `bookDescription`, `bookMaxBorrowDuration`, `bookPhoto` FROM `book` WHERE
        sqlSearch = "SELECT DISTINCT book.bookId, book.bookISBN, book.bookTitle, book.bookCategoryId, book.bookBorrowType, category.categoryName, publisher.publisherName " & _
                    "FROM `book` " & _
                    "JOIN bookauthorlist ON book.bookId=bookauthorlist.bookAuthorListBookId " & _
                    "JOIN author ON author.authorId=bookauthorlist.bookAuthorListAuthorId " & _
                    "JOIN category ON categoryId=bookCategoryId " & _
                    "JOIN publisher ON publisherId=bookPublisherId " & _
                    "WHERE bookId = " & txtSearch.Text & " ;"

        Dim ds As DataSet
        dgvBook.Rows.Clear()
        ds = LibraryDatabase.fetchSQL(sqlSearch)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim index As Integer = 0
            While index < ds.Tables(0).Rows.Count

                ''author listings
                Dim sqlSearchAuthor As String
                Dim authorNames As String
                sqlSearchAuthor = "SELECT DISTINCT `authorFirst`, `authorLast` FROM author join " & _
                    "bookauthorlist on author.authorId=bookauthorlist.bookAuthorListAuthorId Join " & _
                    "book on book.bookId=bookauthorlist.bookAuthorListBookId where bookid=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim + ";"
                Dim dsAuthor As DataSet
                authorNames = ""
                dsAuthor = LibraryDatabase.fetchSQL(sqlSearchAuthor)
                If dsAuthor.Tables(0).Rows.Count > 0 Then
                    Dim indexAuthor As Integer = 0
                    While indexAuthor < dsAuthor.Tables(0).Rows.Count
                        authorNames += dsAuthor.Tables(0).Rows(indexAuthor).Item(0).ToString.Trim + " " + dsAuthor.Tables(0).Rows(indexAuthor).Item(1).ToString.Trim
                        indexAuthor += 1
                        If Not indexAuthor = dsAuthor.Tables(0).Rows.Count Then
                            authorNames += ", "
                        End If
                    End While
                End If

                Dim countCopy As Integer = 0
                Dim countAvailability As Integer = 0
                Dim sqlCountCopy As String = "SELECT COUNT(*) FROM bookcopy WHERE bookCopyBookId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim + ";"
                Dim sqlCountAvailable As String = "SELECT COUNT(*) FROM bookcopy WHERE bookCopyBookId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim & _
                    " AND bookCopyStatus='IN';"
                countCopy = countRecord(sqlCountCopy)
                countAvailability = countRecord(sqlCountAvailable)
                'dgv actual listing
                ' 0 book.bookId, 1 book.bookISBN, 2 book.bookTitle, 
                '3 book.bookCategoryId, 4 book.bookBorrowType, 5 category.categoryName, 6 publisher.publisherName
                With dgvBook
                    dgvBook.Rows.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim, _
                                     ds.Tables(0).Rows(index).Item(2).ToString.Trim, _
                                     authorNames, _
                                     ds.Tables(0).Rows(index).Item(5).ToString.Trim, _
                                     ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                     countCopy.ToString.Trim, _
                                     countAvailability.ToString.Trim)
                    If ds.Tables(0).Rows(index).Item(4).ToString.Trim = "FOR INSIDE READING ONLY" Then
                        .Rows(index).DefaultCellStyle.BackColor = Color.MistyRose
                    ElseIf ds.Tables(0).Rows(index).Item(4).ToString.Trim = "FOR INSIDE AND OUTSIDE USE" Then
                        .Rows(index).DefaultCellStyle.BackColor = Color.PaleTurquoise
                    End If
                End With
                index += 1
            End While
            dgvBook.Refresh()
            dgvBook.Select()
            txtSearch.Select()
        Else
            dgvBook.Rows.Clear()
            If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                MessageBox.Show("No book results found for '" + txtSearch.Text + "'.", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSearch.Select()
            End If
        End If
    End Sub

    Private Sub generateItemAll()
        Dim sqlSearch As String

        'SELECT `libraryItemId`, `libraryItemName`, `libraryItemType`, `libraryItemBorrowType`,
        ' `libraryItemBorrowDuration`, `libraryItemDescription`, `libraryItemPhoto` FROM `libraryitem` WHERE 1
        sqlSearch = "SELECT DISTINCT `libraryItemId`, `libraryItemName`, `itemTypeName`, `libraryItemBorrowType` FROM `libraryitem` " & _
            "JOIN itemtype ON itemTypeId=libraryItemType " & _
            "WHERE " & _
            "libraryItemName LIKE '" & txtSearchItem.Text & "%' OR " & _
            "itemTypeName LIKE '" & txtSearchItem.Text & "%' OR " & _
            "libraryItemBorrowType LIKE '" & txtSearchItem.Text & "%' ;"

        Dim ds As DataSet
        dgvItem.Rows.Clear()
        ds = LibraryDatabase.fetchSQL(sqlSearch)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim index As Integer = 0
            While index < ds.Tables(0).Rows.Count
                Dim countQuantity As Integer = 0
                Dim countItemAvailability As Integer = 0
                Dim sqlCountQuantity As String = "SELECT COUNT(*) FROM libraryitemunit WHERE libraryItemUnitItemId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim + ";"
                Dim sqlCountItemAvailable As String = "SELECT COUNT(*) FROM libraryitemunit WHERE libraryItemUnitItemId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim & _
                    " AND libraryItemUnitStatus='IN';"
                countQuantity = countRecord(sqlCountQuantity)
                countItemAvailability = countRecord(sqlCountItemAvailable)
                'dgv actual listing
                '0`libraryItemId`, 1`libraryItemName`, 2`libraryItemType`
                With dgvItem
                    .Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                              ds.Tables(0).Rows(index).Item(1).ToString.Trim, _
                              ds.Tables(0).Rows(index).Item(2).ToString.Trim, _
                              countQuantity.ToString.Trim, _
                              countItemAvailability.ToString.Trim)
                    'libraryItemBorrowType
                    If ds.Tables(0).Rows(index).Item(3).ToString.Trim = "FOR INSIDE USE ONLY" Then
                        .Rows(index).DefaultCellStyle.BackColor = Color.MistyRose
                    ElseIf ds.Tables(0).Rows(index).Item(3).ToString.Trim = "FOR INSIDE AND OUTSIDE USE" Then
                        .Rows(index).DefaultCellStyle.BackColor = Color.PaleTurquoise
                    End If
                End With
                index += 1
            End While
            dgvItem.Refresh()
            dgvItem.Select()
            txtSearchItem.Select()
        Else
            dgvItem.Rows.Clear()
            If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                MessageBox.Show("No item results found for `" + txtSearchItem.Text + "'.", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSearchItem.Select()
            End If
        End If
    End Sub

    Private Sub generateBookAll()
        Dim sqlSearch As String

        'SELECT  `bookPublisherId`,  ``, `bookDescription`, `bookMaxBorrowDuration`, `bookPhoto` FROM `book` WHERE
        sqlSearch = "SELECT DISTINCT book.bookId, book.bookISBN, book.bookTitle, book.bookCategoryId, book.bookBorrowType, category.categoryName, publisher.publisherName " & _
                    "FROM `book` " & _
                    "JOIN bookauthorlist ON book.bookId=bookauthorlist.bookAuthorListBookId " & _
                    "JOIN author ON author.authorId=bookauthorlist.bookAuthorListAuthorId " & _
                    "JOIN category ON categoryId=bookCategoryId " & _
                    "JOIN publisher ON publisherId=bookPublisherId " & _
                    "WHERE bookISBN LIKE '" & txtSearch.Text & "%' OR " & _
                    "bookTitle LIKE '" & txtSearch.Text & "%' OR " & _
                    "bookBorrowType LIKE '" & txtSearch.Text & "%' OR " & _
                    "category.categoryName LIKE '" & txtSearch.Text & "%' OR " & _
                    "author.authorFirst LIKE '" & txtSearch.Text & "%' OR " & _
                    "author.authorMiddle LIKE '" & txtSearch.Text & "%' OR " & _
                    "author.authorLast LIKE '" & txtSearch.Text & "%' OR " & _
                    "publisher.publisherName LIKE '" & txtSearch.Text & "%';"

        Dim ds As DataSet
        dgvBook.Rows.Clear()
        ds = LibraryDatabase.fetchSQL(sqlSearch)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim index As Integer = 0
            While index < ds.Tables(0).Rows.Count
                'MsgBox("index: " + index.ToString)
                ''author listings
                Dim sqlSearchAuthor As String
                Dim authorNames As String
                sqlSearchAuthor = "SELECT DISTINCT `authorFirst`, `authorLast` FROM author join " & _
                    "bookauthorlist on author.authorId=bookauthorlist.bookAuthorListAuthorId Join " & _
                    "book on book.bookId=bookauthorlist.bookAuthorListBookId where bookid=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim + ";"
                Dim dsAuthor As DataSet
                authorNames = ""
                dsAuthor = LibraryDatabase.fetchSQL(sqlSearchAuthor)
                If dsAuthor.Tables(0).Rows.Count > 0 Then
                    Dim indexAuthor As Integer = 0
                    While indexAuthor < dsAuthor.Tables(0).Rows.Count
                        authorNames += dsAuthor.Tables(0).Rows(indexAuthor).Item(0).ToString.Trim + " " + dsAuthor.Tables(0).Rows(indexAuthor).Item(1).ToString.Trim
                        indexAuthor += 1
                        If Not indexAuthor = dsAuthor.Tables(0).Rows.Count Then
                            authorNames += ", "
                        End If
                    End While
                End If

                Dim countCopy As Integer = 0
                Dim countAvailability As Integer = 0
                Dim sqlCountCopy As String = "SELECT COUNT(*) FROM bookcopy WHERE bookCopyBookId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim + ";"
                Dim sqlCountAvailable As String = "SELECT COUNT(*) FROM bookcopy WHERE bookCopyBookId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim & _
                    " AND bookCopyStatus='IN';"
                countCopy = countRecord(sqlCountCopy)
                countAvailability = countRecord(sqlCountAvailable)
                'dgv actual listing
                ' 0 book.bookId, 1 book.bookISBN, 2 book.bookTitle, 
                '3 book.bookCategoryId, 4 book.bookBorrowType, 5 category.categoryName, 6 publisher.publisherName
                With dgvBook
                    dgvBook.Rows.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim, _
                                     ds.Tables(0).Rows(index).Item(2).ToString.Trim, _
                                     authorNames, _
                                     ds.Tables(0).Rows(index).Item(5).ToString.Trim, _
                                     ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                     countCopy.ToString.Trim, _
                                     countAvailability.ToString.Trim)
                    If ds.Tables(0).Rows(index).Item(4).ToString.Trim = "FOR INSIDE READING ONLY" Then
                        .Rows(index).DefaultCellStyle.BackColor = Color.MistyRose
                    ElseIf ds.Tables(0).Rows(index).Item(4).ToString.Trim = "FOR INSIDE AND OUTSIDE USE" Then
                        .Rows(index).DefaultCellStyle.BackColor = Color.PaleTurquoise
                    End If
                End With
                index += 1
            End While
            dgvBook.Refresh()
            dgvBook.Select()
            txtSearch.Select()
        Else
            dgvBook.Rows.Clear()
            If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                MessageBox.Show("No book results found for `" + txtSearch.Text + "'.", "No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSearch.Select()
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
    End Sub

    Private Sub renameGridColumns()
        With dgvBook
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ISBN" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "TITLE"
            .Columns(2).HeaderCell.Value = "AUTHOR"
            .Columns(3).HeaderCell.Value = "CATEGORY"
            .Columns(4).HeaderCell.Value = "BOOK ID"
            .Columns(5).HeaderCell.Value = "TOTAL COPIES"
            .Columns(6).HeaderCell.Value = "AVAILABLE COPIES"
            .Columns(0).FillWeight = 30
            .Columns(1).FillWeight = 100
            .Columns(2).FillWeight = 70
            .Columns(3).FillWeight = 70
            .Columns(4).FillWeight = 20
            .Columns(5).FillWeight = 20
            .Columns(6).FillWeight = 20
        End With
        With dgvItem
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Item ID" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "Item Name"
            .Columns(2).HeaderCell.Value = "Item Type"
            .Columns(3).HeaderCell.Value = "Quantity"
            .Columns(4).HeaderCell.Value = "Availability"
            .Columns(0).FillWeight = 30
            .Columns(1).FillWeight = 100
            .Columns(2).FillWeight = 70
            .Columns(3).FillWeight = 20
            .Columns(4).FillWeight = 20
        End With
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

    Private Sub txtSearchItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchItem.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetterOrDigit(c) Or (c = "#") Or (c = "/") Or (c = "|") Or (c = "\") Or (c = ",") Or (c = " ") Or (c = ")") Or (c = "(") Or (c = "`") Or (c = "&") Or (c = ":") Or (c = "-") Or (c = ".") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSearchItem_LostFocus(sender As Object, e As EventArgs) Handles txtSearchItem.LostFocus
        txtSearchItem.Text = txtSearchItem.Text.ToUpper
    End Sub

    Private Sub FormManageItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBook.Font = New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        dgvItem.Font = New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        renameGridColumns()
        Timer1.Enabled = True
        Timer1.Interval = 1
        Dim dateToday As DateTime = DateTime.Now
        lblDate.Text = dateToday.ToString("D")
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        objFormAddBook = New FormAddBook
        objFormAddBook.ShowDialog()
    End Sub

    Private Sub btnSearchAllBook_Click(sender As Object, e As EventArgs) Handles btnSearchAllBook.Click
        Try
            generateBookAll()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnSearchISBN_Click(sender As Object, e As EventArgs) Handles btnSearchISBN.Click
        Try
            If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                generateBookISBN()
            Else
                dgvBook.Rows.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnSearchTitle_Click(sender As Object, e As EventArgs) Handles btnSearchTitle.Click
        Try
            If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                generateBookTitle()
            Else
                dgvBook.Rows.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        
    End Sub

    Private Sub btnSearchAuthor_Click(sender As Object, e As EventArgs) Handles btnSearchAuthor.Click
        Try
            If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                generateBookAuthor()
            Else
                dgvBook.Rows.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        
    End Sub

    Private Sub btnSearchCategory_Click(sender As Object, e As EventArgs) Handles btnSearchCategory.Click
        Try
            If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                If IsNumeric(txtSearch.Text) = True Then
                    generateBookCategoryID()
                Else
                    generateBookCategoryName()
                End If
            Else
                dgvBook.Rows.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        
    End Sub

    Private Sub btnSearchBookId_Click(sender As Object, e As EventArgs) Handles btnSearchBookId.Click
        Try
            If IsNumeric(txtSearch.Text) Then
                generateBookID()
            Else
                dgvBook.Rows.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        
    End Sub

    Private Sub btnDeleteBook_Click(sender As Object, e As EventArgs) Handles btnDeleteBook.Click
        If dgvBook.Rows.Count > 0 Then
            Dim ans As Integer
            ans = MsgBox("Are you sure you want to remove '" + dgvBook.SelectedRows(0).Cells(1).Value.ToString.Trim + "' from the book list including all its copies?", MsgBoxStyle.YesNo, "Remove Book")
            If ans = MsgBoxResult.Yes Then
                objBook = New Book
                objAuthorlist = New BookAuthorList
                objAuthorlist.BookAuthorListBookId = dgvBook.SelectedRows(0).Cells(4).Value
                objAuthorlist.deleteBookAuthorList()
                objBook.BookId = dgvBook.SelectedRows(0).Cells(4).Value
                objBook.deleteBook()
                MessageBox.Show("You have successfully deleted " + dgvBook.SelectedRows(0).Cells(1).Value.ToString.Trim + " from the list.", "Deleted Record")
                txtSearch.Clear()
                dgvBook.Rows.Clear()
            End If
        End If
    End Sub

    Private Sub btnViewBook_Click(sender As Object, e As EventArgs) Handles btnViewBook.Click
        If dgvBook.Rows.Count > 0 Then
            objFormViewBook = New FormViewBook
            objFormViewBook.ViewBookId = dgvBook.SelectedRows(0).Cells(4).Value
            objFormViewBook.ShowDialog()
        End If
    End Sub

    Private Sub btnUpdateBook_Click(sender As Object, e As EventArgs) Handles btnUpdateBook.Click
        If dgvBook.Rows.Count > 0 Then
            objFormUpdateBook = New FormUpdateBook
            objFormUpdateBook.BookId = dgvBook.SelectedRows(0).Cells(4).Value
            objFormUpdateBook.ShowDialog()
        End If
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        objFormAddItem = New FormAddItem
        objFormAddItem.ShowDialog()
    End Sub

    Private Sub btnSearchAllItem_Click(sender As Object, e As EventArgs) Handles btnSearchAllItem.Click
        Try
            If IsNumeric(txtSearchItem.Text) Then
                generateItemID()
            Else
                generateItemAll()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnSearchItemName_Click(sender As Object, e As EventArgs) Handles btnSearchItemName.Click
        Try
            If Not String.IsNullOrWhiteSpace(txtSearchItem.Text) Then
                generateItemName()
            Else
                dgvItem.Rows.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnSearchItemID_Click(sender As Object, e As EventArgs) Handles btnSearchItemID.Click
        Try
            If IsNumeric(txtSearchItem.Text) Then
                generateItemID()
            Else
                dgvItem.Rows.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub btnViewItem_Click(sender As Object, e As EventArgs) Handles btnViewItem.Click
        If dgvItem.Rows.Count > 0 Then
            objFormViewItem = New FormViewLibraryItem
            objFormViewItem.ViewItemId = dgvItem.SelectedRows(0).Cells(0).Value
            objFormViewItem.ShowDialog()
        End If
    End Sub

    Private Sub btnUpdateItem_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click
        If dgvItem.Rows.Count > 0 Then
            objFormUpdateItem = New FormUpdateItem
            objFormUpdateItem.ItemId = dgvItem.SelectedRows(0).Cells(0).Value
            objFormUpdateItem.ShowDialog()
        End If
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If dgvItem.Rows.Count > 0 Then
            Dim ans As Integer
            ans = MsgBox("Are you sure you want to remove '" + dgvItem.SelectedRows(0).Cells(1).Value.ToString.Trim + "' from the item list including all its units?", MsgBoxStyle.YesNo, "Remove Item")
            If ans = MsgBoxResult.Yes Then
                objItem = New LibraryItem
                objItem.LibraryItemId = dgvItem.SelectedRows(0).Cells(0).Value
                objItem.deleteLibraryItem()
                MessageBox.Show("You have successfully deleted " + dgvItem.SelectedRows(0).Cells(1).Value.ToString.Trim + " from the list.", "Deleted Record")
                txtSearchItem.Clear()
                dgvItem.Rows.Clear()
            End If
        End If
    End Sub
End Class