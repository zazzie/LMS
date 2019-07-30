'Public Class FormEditNewBookCopy
'    Dim dsBookShelf As New DataSet
'    Dim dsBookShelfSection As New DataSet
'    Dim dsBookCopy As DataSet
'    Dim objFormBookShelf As New FormBookShelf
'    Dim dateToday As DateTime = DateTime.Now
'    Dim objBookCopy As New BookCopy
'    Private _bookAccessionId As Integer
'    Public Property BookAccessionId()
'        Get
'            Return _bookAccessionId
'        End Get
'        Set(value)
'            _bookAccessionId = value
'        End Set
'    End Property

'    Private Sub loadData()
'        Try

'            dsBookCopy = LibraryDatabase.fetchSQL("SELECT * FROM bookcopy WHERE bookAccessionId=" + BookAccessionId.ToString + ";")
'            ''SELECT 0`bookAccessionId`, 1`bookCopyBookId`, 2`bookCopyNumber`, 3`bookCopyQuality`, 4`bookCopyAquisition`, 5`bookCopyPrice`, 
'            '6`bookCopyDateAdded`, 7`bookCopyShelfId`, 8`bookCopyShelfSectionId`, 9`bookCopyStatus` FROM `bookcopy` WHERE 1
'            If dsBookCopy.Tables(0).Rows.Count > 0 Then
'                Dim indexShelf As Integer = 0
'                Dim indexShelfSection As Integer = 0
'                txtAccession1.Text = BookAccessionId.ToString
'                cboAquisition.Text = dsBookCopy.Tables(0).Rows(0).Item(4).ToString.Trim
'                txtPrice.Text = dsBookCopy.Tables(0).Rows(0).Item(5).ToString.Trim

'                If dsBookShelf.Tables(0).Rows.Count > 0 Then
'                    While indexShelf < dsBookShelf.Tables(0).Rows.Count
'                        If dsBookCopy.Tables(0).Rows(0).Item(7).ToString.Trim = dsBookShelf.Tables(0).Rows(indexShelf).Item(0).ToString.Trim Then
'                            cboShelf.SelectedIndex = indexShelf
'                            Exit While
'                        End If
'                        indexShelf += 1
'                    End While
'                End If
'                generateBookShelfSection()
'                If dsBookShelfSection.Tables(0).Rows.Count > 0 Then
'                    While indexShelfSection < dsBookShelfSection.Tables(0).Rows.Count
'                        If dsBookCopy.Tables(0).Rows(0).Item(8).ToString.Trim = dsBookShelfSection.Tables(0).Rows(indexShelfSection).Item(2).ToString.Trim Then
'                            cboShelfSection.SelectedIndex = indexShelfSection
'                            Exit While
'                        End If
'                        indexShelfSection += 1
'                    End While
'                End If
'            Else
'                Panel2.Enabled = False
'                btnEditBookCopy.Enabled = False
'            End If
'        Catch ex As Exception
'            Panel2.Enabled = False
'            btnEditBookCopy.Enabled = False
'            MsgBox(ex.Message.ToString)
'        End Try

'    End Sub
'    Private Sub getShelfData()
'        Dim sqlSearch As String
'        sqlSearch = "SELECT * FROM bookshelf;"
'        dsBookShelf = LibraryDatabase.fetchSQL(sqlSearch)
'    End Sub
'    Private Sub getShelfSectionData(ByVal id As Integer)
'        Dim sqlSearch As String
'        sqlSearch = "SELECT * FROM `bookshelf` join bookshelfsection on bookshelfId=bookShelfSectionBookShelfId WHERE bookshelfId=" + id.ToString + ";"
'        dsBookShelfSection = LibraryDatabase.fetchSQL(sqlSearch)
'    End Sub
'    Private Sub generateBookShelf()
'        getShelfData()
'        If dsBookShelf.Tables(0).Rows.Count > 0 Then
'            cboShelf.Items.Clear()
'            Dim index As Integer = 0
'            While index < dsBookShelf.Tables(0).Rows.Count
'                With cboShelf
'                    .Items.Add(dsBookShelf.Tables(0).Rows(index).Item(1).ToString.Trim)
'                End With
'                index += 1
'            End While
'            cboShelf.Refresh()
'            cboShelf.SelectedIndex = 0
'        Else
'            Dim sqlInsert As String = "INSERT INTO `bookshelf`(`bookshelfId`, `bookshelfName`) VALUES (0,'N/A');" & _
'                    "INSERT INTO `bookshelfsection`(`bookShelfSectionId`, `bookShelfSectionName`, `bookShelfSectionBookShelfId`) VALUES (0,'N/A',0);"
'            LibraryDatabase.execSQL(sqlInsert)
'            generateBookShelf()
'        End If
'    End Sub

'    Private Sub generateBookShelfSection()
'        If Not String.IsNullOrWhiteSpace(cboShelf.Text) Then
'            getShelfSectionData(dsBookShelf.Tables(0).Rows(cboShelf.SelectedIndex).Item(0))
'            cboShelfSection.Items.Clear()
'            Dim index As Integer = 0
'            While index < dsBookShelfSection.Tables(0).Rows.Count
'                With cboShelfSection
'                    .Items.Add(dsBookShelfSection.Tables(0).Rows(index).Item(3).ToString.Trim)
'                End With
'                index += 1
'            End While
'            cboShelfSection.Refresh()
'            cboShelfSection.SelectedIndex = 0
'        Else
'            cboShelfSection.Items.Clear()
'        End If
'    End Sub
'    Private Sub identifyAquisition()
'        If Not cboAquisition.Text = "BOUGHT BY SCHOOL" Then
'            lblPrice.Visible = False
'            txtPrice.Visible = False
'        Else
'            lblPrice.Visible = True
'            txtPrice.Visible = True
'        End If
'    End Sub
'    Private Sub FormEditBookCopy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        generateBookShelf()
'        generateBookShelfSection()
'        loadData()
'        txtAccession1.Enabled = False
'        txtPrice.Text = Val(txtPrice.Text).ToString("###,###,##0.00")
'        identifyAquisition()
'    End Sub

'    Private Sub btnShelf_Click(sender As Object, e As EventArgs) Handles btnShelf.Click
'        objFormBookShelf = New FormBookShelf
'        If objFormBookShelf.ShowDialog = Windows.Forms.DialogResult.OK Then
'            generateBookShelf()
'            generateBookShelfSection()
'        End If
'    End Sub

'    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
'        Dim c As Char
'        c = e.KeyChar
'        If Not (Char.IsDigit(c) Or (c = "." And txtPrice.Text.IndexOf(".") = -1) Or Char.IsControl(c)) Then
'            e.Handled = True
'        End If
'    End Sub

'    Private Sub txtPrice_LostFocus(sender As Object, e As EventArgs) Handles txtPrice.LostFocus
'        txtPrice.Text = Val(txtPrice.Text).ToString("###,###,##0.00")
'    End Sub

'    Private Sub cboShelf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboShelf.SelectedIndexChanged
'        generateBookShelfSection()
'    End Sub
'    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
'        Me.DialogResult = Windows.Forms.DialogResult.Cancel
'        'Me.Dispose()
'    End Sub

'    Private Sub cboAquisition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAquisition.SelectedIndexChanged
'        identifyAquisition()
'    End Sub

'    Private Sub btnEditBookCopy_Click(sender As Object, e As EventArgs) Handles btnEditBookCopy.Click
'        objBookCopy.BookAccessionId = txtAccession1.Text
'        objBookCopy.BookCopyAquisition = cboAquisition.Text
'        If cboAquisition.Text = "BOUGHT BY SCHOOL" Then
'            objBookCopy.BookCopyPrice = txtPrice.Text
'        End If
'        objBookCopy.BookCopyShelfId = dsBookShelf.Tables(0).Rows(cboShelf.SelectedIndex).Item(0).ToString.Trim
'        objBookCopy.BookCopyShelfSectionId = dsBookShelfSection.Tables(0).Rows(cboShelfSection.SelectedIndex).Item(2).ToString.Trim
'        Dim sqlUpdate As String
'        sqlUpdate = "UPDATE `bookcopy` SET " & _
'            "`bookCopyAquisition`='" + objBookCopy.BookCopyAquisition & _
'            "',`bookCopyPrice`='" + objBookCopy.BookCopyPrice & _
'            "',`bookCopyShelfId`=" + objBookCopy.BookCopyShelfId.ToString & _
'            ",`bookCopyShelfSectionId`=" + objBookCopy.BookCopyShelfSectionId.ToString & _
'            " WHERE bookAccessionId= " + objBookCopy.BookAccessionId.ToString & ";"
'        LibraryDatabase.execSQL(sqlUpdate)
'        MessageBox.Show("Successfully updated bookcopy: " + txtAccession1.Text + ".", "Successfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
'        Me.DialogResult = Windows.Forms.DialogResult.OK
'    End Sub
'End Class