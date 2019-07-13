Public Class FormEditBookCopy
    Dim dsBookShelf As New DataSet
    Dim dsBookShelfSection As New DataSet
    Dim objFormBookShelf As New FormBookShelf
    Public DsNewCopyList As DataSet
    Dim dateToday As DateTime = DateTime.Now
    Dim _accessionNumber, _aquisition, _price, _shelf, _shelfsection As String

    Public Property AccessionNumber
        Get
            Return _accessionNumber
        End Get
        Set(value)
            _accessionNumber = value
        End Set
    End Property
    Public Property Aquisition
        Get
            Return _aquisition
        End Get
        Set(value)
            _aquisition = value
        End Set
    End Property
    Public Property Price
        Get
            Return _price
        End Get
        Set(value)
            _price = value
        End Set
    End Property
    Public Property Shelf
        Get
            Return _shelf
        End Get
        Set(value)
            _shelf = value
        End Set
    End Property
    Public Property ShelfSection
        Get
            Return _shelfsection
        End Get
        Set(value)
            _shelfsection = value
        End Set
    End Property
    Private Sub initializeDsCopy()
        'initialize to empty
        Try
            Dim sqlSearch As String
            sqlSearch = "SELECT bookAccessionId, bookCopyAquisition, bookCopyPrice, bookCopyDateAdded, " & _
                "bookshelfName, bookShelfSectionName, bookCopyShelfId, bookCopyShelfSectionId " & _
                "FROM bookcopy JOIN bookshelf ON bookshelf.bookshelfId=bookcopy.bookCopyShelfId " & _
                "JOIN bookshelfsection ON bookshelfsection.bookShelfSectionId=bookcopy.bookCopyShelfSectionId " & _
                "WHERE bookCopyBookId=0;"
            DsNewCopyList = LibraryDatabase.fetchSQL(sqlSearch)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub getShelfData()
        Dim sqlSearch As String
        sqlSearch = "SELECT * FROM bookshelf;"
        dsBookShelf = LibraryDatabase.fetchSQL(sqlSearch)
    End Sub
    Private Sub getShelfSectionData(ByVal id As Integer)
        Dim sqlSearch As String
        sqlSearch = "SELECT * FROM `bookshelf` join bookshelfsection on bookshelfId=bookShelfSectionBookShelfId WHERE bookshelfId=" + id.ToString + ";"
        dsBookShelfSection = LibraryDatabase.fetchSQL(sqlSearch)
    End Sub
    Private Sub generateBookShelf()
        getShelfData()
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
            cboShelf.Items.Clear()
        End If
    End Sub

    Private Sub generateBookShelfSection()
        If Not String.IsNullOrWhiteSpace(cboShelf.Text) Then
            getShelfSectionData(dsBookShelf.Tables(0).Rows(cboShelf.SelectedIndex).Item(0))
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
    Private Sub identifyAquisition()
        If Not cboAquisition.Text = "BOUGHT BY SCHOOL" Then
            lblPrice.Visible = False
            txtPrice.Visible = False
        Else
            lblPrice.Visible = True
            txtPrice.Visible = True
        End If
    End Sub
    Private Sub FormEditBookCopy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeDsCopy()
        generateBookShelf()
        generateBookShelfSection()
        txtAccession1.Text = AccessionNumber
        cboAquisition.Text = Aquisition
        txtPrice.Text = Price
        cboShelf.Text = Shelf
        cboShelfSection.Text = ShelfSection
        txtPrice.Text = Val(txtPrice.Text).ToString("###,###,##0.00")
        identifyAquisition()
    End Sub

    Private Sub btnShelf_Click(sender As Object, e As EventArgs) Handles btnShelf.Click
        objFormBookShelf = New FormBookShelf
        If objFormBookShelf.ShowDialog = Windows.Forms.DialogResult.OK Then
            generateBookShelf()
            generateBookShelfSection()
        End If
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

    Private Sub cboShelf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboShelf.SelectedIndexChanged
        generateBookShelfSection()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        'Me.Dispose()
    End Sub

    Private Sub cboAquisition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAquisition.SelectedIndexChanged
        identifyAquisition()
    End Sub

    Private Sub btnEditBookCopy_Click(sender As Object, e As EventArgs) Handles btnEditBookCopy.Click
        Dim row As DataRow
        row = DsNewCopyList.Tables(0).NewRow
        row.Item(0) = txtAccession1.Text
        row.Item(1) = cboAquisition.Text
        row.Item(2) = txtPrice.Text
        row.Item(3) = dateToday.ToString("d")
        If Not cboShelf.Text = "" Then
            row.Item(4) = cboShelf.Text
            row.Item(5) = cboShelfSection.Text
            row.Item(6) = dsBookShelfSection.Tables(0).Rows(cboShelfSection.SelectedIndex).Item(0).ToString.Trim
            row.Item(7) = dsBookShelfSection.Tables(0).Rows(cboShelfSection.SelectedIndex).Item(2).ToString.Trim
        Else
            row.Item(4) = ""
            row.Item(5) = ""
            row.Item(6) = ""
            row.Item(7) = ""
        End If
        DsNewCopyList.Tables(0).Rows.Add(row)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class