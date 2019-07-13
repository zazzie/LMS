Public Class FormViewBook
    Private Shared _viewBookId As Integer

    Public Property ViewBookId
        Get
            Return _viewBookId
        End Get
        Set(value)
            _viewBookId = value
        End Set
    End Property

    Private Sub renameBookCopyGridColumns()
        With dgvBookCopy
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Accession Number" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "Condition"
            .Columns(2).HeaderCell.Value = "Status"
            .Columns(3).HeaderCell.Value = "Aquisition"
            .Columns(4).HeaderCell.Value = "Price"
            .Columns(5).HeaderCell.Value = "Date Added"
            .Columns(6).HeaderCell.Value = "Shelf"
            .Columns(7).HeaderCell.Value = "Shelf Section"
            .Columns(0).FillWeight = 30
            .Columns(1).FillWeight = 30
            .Columns(2).FillWeight = 20
            .Columns(3).FillWeight = 30
            .Columns(4).FillWeight = 30
            .Columns(5).FillWeight = 30
            .Columns(6).FillWeight = 30
            .Columns(7).FillWeight = 30
        End With
    End Sub

    Private Sub generateBookInfo()
        Dim sqlFetch As String
        sqlFetch = "SELECT DISTINCT `bookId`, `bookISBN`, `bookTitle`, `bookBorrowType`, `bookDescription`, `bookMaxBorrowDuration`, `bookPhoto`, category.categoryName, publisher.publisherName " & _
                        "FROM `book` " & _
                        "JOIN bookauthorlist ON book.bookId=bookauthorlist.bookAuthorListBookId " & _
                        "JOIN author ON author.authorId=bookauthorlist.bookAuthorListAuthorId " & _
                        "JOIN category ON categoryId=bookCategoryId " & _
                        "JOIN publisher ON publisherId=bookPublisherId " & _
                        "WHERE bookId =" + ViewBookId.ToString + ";"
        Dim ds As DataSet
        ds = LibraryDatabase.fetchSQL(sqlFetch)
        If ds.Tables(0).Rows.Count > 0 Then
            'author listing
            listAuthor.Items.Clear()
            Dim sqlSearchAuthor As String
            Dim authorNames As String
            sqlSearchAuthor = "SELECT DISTINCT `authorFirst`, `authorLast` FROM author join " & _
                "bookauthorlist on author.authorId=bookauthorlist.bookAuthorListAuthorId Join " & _
                "book on book.bookId=bookauthorlist.bookAuthorListBookId where bookid=" + ds.Tables(0).Rows(0).Item(0).ToString.Trim + ";"
            Dim dsAuthor As DataSet
            authorNames = ""
            dsAuthor = LibraryDatabase.fetchSQL(sqlSearchAuthor)
            If dsAuthor.Tables(0).Rows.Count > 0 Then
                Dim indexAuthor As Integer = 0
                While indexAuthor < dsAuthor.Tables(0).Rows.Count
                    listAuthor.Items.Add(dsAuthor.Tables(0).Rows(indexAuthor).Item(0).ToString.Trim + " " + dsAuthor.Tables(0).Rows(indexAuthor).Item(1).ToString.Trim)
                    indexAuthor += 1
                End While
            End If

            Dim countCopy As Integer = 0
            Dim countAvailability As Integer = 0
            Dim sqlCountCopy As String = "SELECT COUNT(*) FROM bookcopy WHERE bookCopyBookId=" + ViewBookId.ToString + ";"
            Dim sqlCountAvailable As String = "SELECT COUNT(*) FROM bookcopy WHERE bookCopyBookId=" + ViewBookId.ToString & _
                " AND bookCopyStatus='IN';"
            countCopy = countRecord(sqlCountCopy)
            countAvailability = countRecord(sqlCountAvailable)

            'arranging info
            'SELECT DISTINCT `0 bookId`, `1 bookISBN`, `2 bookTitle`, `3 bookBorrowType`, 
            '`4 bookDescription`, `5 bookMaxBorrowDuration`, `6 bookPhoto`, 7 category.categoryName, 8 publisher.publisherName

            lblBookIsbn.Text = ds.Tables(0).Rows(0).Item(1).ToString.Trim
            lblBookId.Text = ds.Tables(0).Rows(0).Item(0).ToString.Trim
            lblBookTitle.Text = ds.Tables(0).Rows(0).Item(2).ToString.Trim
            lblBookBorrowType.Text = ds.Tables(0).Rows(0).Item(3).ToString.Trim
            If ds.Tables(0).Rows(0).Item(3).ToString.Trim = "FOR INSIDE READING ONLY" Then
                lblMaxBorrow.Visible = False
                lblMaxLABEL.Visible = False
                pnlForPhoto.BackColor = Color.MistyRose
            Else
                lblMaxBorrow.Text = ds.Tables(0).Rows(0).Item(5).ToString.Trim + " Day/s"
                pnlForPhoto.BackColor = Color.PaleTurquoise
            End If
            lblBookDescription.Text = ds.Tables(0).Rows(0).Item(4).ToString.Trim
            pictBookPhoto.BackgroundImage = Base64ToImage(ds.Tables(0).Rows(0).Item(6).ToString.Trim)
            lblBookCategory.Text = ds.Tables(0).Rows(0).Item(7).ToString.Trim
            lblBookPublisher.Text = ds.Tables(0).Rows(0).Item(8).ToString.Trim
            lblBookQuantity.Text = countCopy.ToString.Trim
            lblBookAvailability.Text = countAvailability.ToString.Trim

            'bookcopies listing
            'SELECT `0 bookAccessionId`, `1 bookCopyBookId`, `2 bookCopyNumber`, `3 bookCopyQuality`, 
            '`4 bookCopyAquisition`, `5 bookCopyPrice`, `6 bookCopyDateAdded`, `7 bookCopyShelfId`, `8 bookCopyShelfSectionId`,
            ' `9 bookCopyStatus` FROM `bookcopy` WHERE 10 bookShelfSectionId`, 11`bookShelfSectionName`, 12`bookShelfSectionBookShelfId` FROM `bookshelfsection`
            'SELECT `13bookshelfId`, 14`bookshelfName` FROM `bookshelf` WHERE 1
            Dim dsCopy As DataSet
            dsCopy = LibraryDatabase.fetchSQL("SELECT * FROM bookcopy JOIN bookshelfsection " & _
                                              "ON bookCopyShelfSectionId=bookShelfSectionId " & _
                                              "JOIN bookshelf " & _
                                              "ON bookshelfId=bookShelfSectionBookShelfId " & _
                                              "WHERE bookCopyBookId=" + ViewBookId.ToString.Trim + ";")
            If dsCopy.Tables(0).Rows.Count > 0 Then
                Dim indexCopy As Integer = 0
                While indexCopy < dsCopy.Tables(0).Rows.Count
                    With dgvBookCopy
                        .Rows.Add(dsCopy.Tables(0).Rows(indexCopy).Item(0).ToString.Trim, _
                                  dsCopy.Tables(0).Rows(indexCopy).Item(3).ToString.Trim, _
                                  dsCopy.Tables(0).Rows(indexCopy).Item(9).ToString.Trim, _
                                  dsCopy.Tables(0).Rows(indexCopy).Item(4).ToString.Trim, _
                                  dsCopy.Tables(0).Rows(indexCopy).Item(5).ToString.Trim, _
                                  dsCopy.Tables(0).Rows(indexCopy).Item(6).ToString.Trim, _
                                  dsCopy.Tables(0).Rows(indexCopy).Item(14).ToString.Trim, _
                                  dsCopy.Tables(0).Rows(indexCopy).Item(11).ToString.Trim)
                    End With
                    indexCopy += 1
                End While
            End If
        End If
    End Sub

    Private Sub FormViewBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBookCopy.Font = New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        renameBookCopyGridColumns()
        Try
            generateBookInfo()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

End Class