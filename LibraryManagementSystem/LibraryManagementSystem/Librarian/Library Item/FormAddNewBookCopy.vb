'Public Class FormAddNewBookCopy
'    Dim dsBookShelf As New DataSet
'    Dim dsBookShelfSection As New DataSet
'    Dim objFormBookShelf As New FormBookShelf
'    Dim existAccession As String = ""
'    Dim dateToday As DateTime = DateTime.Now
'    Dim objBookCopy As New BookCopy
'    Private _bookId As Integer

'    Public Property BookId()
'        Get
'            Return _bookId
'        End Get
'        Set(value)
'            _bookId = value
'        End Set
'    End Property

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

'    Private Sub checkRBTs()
'        If rbtSingleCopy.Checked = True Then
'            lblDash.Visible = False
'            txtAccession2.Visible = False
'            lblNumberCopy.Text = "(1 copy)"
'            lblNumberCopy.ForeColor = Color.Black
'            txtAccession1.Focus()
'        ElseIf rbtMultiCopy.Checked = True Then
'            lblDash.Visible = True
'            txtAccession2.Visible = True
'            'txtAccession1.Focus()
'            If Val(txtAccession2.Text) < Val(txtAccession1.Text) Or Val(txtAccession2.Text) = Val(txtAccession1.Text) Then
'                lblNumberCopy.Text = "(INVALID ACCESSION ORDER)"
'                lblNumberCopy.ForeColor = Color.Red
'            Else
'                lblNumberCopy.Text = "(" + ((Val(txtAccession2.Text) - Val(txtAccession1.Text)) + 1).ToString + " copies)"
'                lblNumberCopy.ForeColor = Color.Black
'            End If
'        End If
'    End Sub

'    Private Sub FormAddNewBookCopy_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

'    End Sub

'    Private Sub FormAddNewBookCopy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        cboAquisition.Text = "BOUGHT BY SCHOOL"
'        rbtSingleCopy.Checked = True
'        checkRBTs()
'        generateBookShelf()
'        generateBookShelfSection()
'        txtPrice.Text = "0.00"

'    End Sub
'    Private Sub btnShelf_Click(sender As Object, e As EventArgs) Handles btnShelf.Click
'        objFormBookShelf = New FormBookShelf
'        If objFormBookShelf.ShowDialog = Windows.Forms.DialogResult.OK Then
'            generateBookShelf()
'            generateBookShelfSection()
'        End If
'    End Sub

'    Private Sub cboAquisition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAquisition.SelectedIndexChanged
'        If Not cboAquisition.Text = "BOUGHT BY SCHOOL" Then
'            lblPrice.Visible = False
'            txtPrice.Visible = False
'            lblPhp.Visible = False
'        Else
'            lblPrice.Visible = True
'            txtPrice.Visible = True
'            lblPhp.Visible = True
'            txtPrice.Focus()
'        End If
'    End Sub

'    Private Sub rbtSingleCopy_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSingleCopy.CheckedChanged
'        checkRBTs()
'    End Sub

'    Private Sub rbtMultiCopy_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMultiCopy.CheckedChanged
'        checkRBTs()
'    End Sub

'    Private Sub txtAccession1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAccession1.KeyPress
'        Dim c As Char
'        c = e.KeyChar
'        If Not (Char.IsDigit(c) Or Char.IsControl(c)) Then
'            e.Handled = True
'        End If
'    End Sub

'    Private Sub txtAccession1_LostFocus(sender As Object, e As EventArgs) Handles txtAccession1.LostFocus
'        txtAccession1.Text = txtAccession1.Text.ToUpper
'    End Sub

'    Private Sub txtAccession2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAccession2.KeyPress
'        Dim c As Char
'        c = e.KeyChar
'        If Not (Char.IsDigit(c) Or Char.IsControl(c)) Then
'            e.Handled = True
'        End If
'    End Sub

'    Private Sub txtAccession2_LostFocus(sender As Object, e As EventArgs) Handles txtAccession2.LostFocus
'        txtAccession2.Text = txtAccession2.Text.ToUpper
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

'    Private Sub txtAccession2_TextChanged(sender As Object, e As EventArgs) Handles txtAccession2.TextChanged
'        checkRBTs()
'    End Sub

'    Private Sub txtAccession1_TextChanged(sender As Object, e As EventArgs) Handles txtAccession1.TextChanged
'        checkRBTs()
'    End Sub

'    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
'        Me.DialogResult = Windows.Forms.DialogResult.Cancel
'        Me.Dispose()
'    End Sub

'    Private Function countExisting(accessionNumber As Integer) As Integer
'        Dim count As Integer = 0
'        Dim sqlCount As String = "SELECT COUNT(*) FROM `bookcopy` WHERE bookAccessionId=" + accessionNumber.ToString + ";"
'        count = countRecord(sqlCount)
'        Return count
'    End Function

'    Private Function countExisting(accessionNumber1 As Integer, accessionNumber2 As Integer) As Integer
'        existAccession = ""
'        Dim index As Integer = 0
'        Dim count As Integer = 0
'        Dim minAccession As Integer = accessionNumber1
'        Dim maxIndex As Integer = (accessionNumber2 - accessionNumber1) + 1
'        Dim countString As String = ""
'        Dim sqlCount As String
'        While index < maxIndex
'            sqlCount = "SELECT COUNT(*) FROM `bookcopy` WHERE bookAccessionId=" + minAccession.ToString + ";"
'            If countRecord(sqlCount) = 1 Then
'                count += 1
'                If count > 1 Then
'                    countString += ", "
'                End If
'                countString += minAccession.ToString
'            End If
'            index += 1
'            minAccession += 1
'        End While
'        existAccession = countString

'        Return count

'    End Function

'    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
'        If rbtSingleCopy.Checked = True Then
'            If String.IsNullOrWhiteSpace(txtAccession1.Text) = False Then
'                Dim count As Integer = countExisting(Val(txtAccession1.Text))
'                If count = 0 Then
'                    objBookCopy = New BookCopy
'                    objBookCopy.BookAccessionId = txtAccession1.Text
'                    objBookCopy.BookCopyBookId = BookId.ToString
'                    objBookCopy.BookCopyNumber = ""
'                    objBookCopy.BookCopyQuality = "EXCELLENT" 'must fix
'                    objBookCopy.BookCopyAquisition = cboAquisition.Text
'                    If cboAquisition.Text = "BOUGHT BY SCHOOL" Then
'                        objBookCopy.BookCopyPrice = txtPrice.Text
'                    Else
'                        objBookCopy.BookCopyPrice = "0.00"
'                    End If
'                    objBookCopy.BookCopyDateAdded = dateToday.ToString("d")
'                    objBookCopy.BookCopyShelfSectionId = dsBookShelfSection.Tables(0).Rows(cboShelfSection.SelectedIndex).Item(2).ToString.Trim
'                    objBookCopy.BookCopyShelfId = dsBookShelf.Tables(0).Rows(cboShelf.SelectedIndex).Item(0).ToString.Trim
'                    objBookCopy.addBookCopy()
'                    MessageBox.Show("You have successfully added a new book copy.", "Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
'                    Me.DialogResult = Windows.Forms.DialogResult.OK
'                ElseIf count = 1 Then
'                    MessageBox.Show("Accession number: " + txtAccession1.Text + " already exists in the database.", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                    txtAccession1.Focus()
'                End If
'            Else
'                MessageBox.Show("Please enter a valid accession number.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                txtAccession1.Focus()
'            End If

'        ElseIf rbtMultiCopy.Checked = True Then
'            If String.IsNullOrWhiteSpace(txtAccession1.Text) = False Then
'                If String.IsNullOrWhiteSpace(txtAccession2.Text) = False Then
'                    If Not lblNumberCopy.Text = "(INVALID ACCESSION ORDER)" Or Val(txtAccession1.Text) >= Val(txtAccession2.Text) Then
'                        Dim count As Integer = countExisting(Val(txtAccession1.Text), Val(txtAccession2.Text))
'                        If count = 0 Then
'                            Dim index As Integer = 0
'                            Dim max As Integer = (Val(txtAccession2.Text) - Val(txtAccession1.Text)) + 1
'                            Dim sqlAddCopies As String = ""
'                            Dim accessionNumber As Integer = Val(txtAccession1.Text)
'                            While index < max
'                                objBookCopy = New BookCopy
'                                objBookCopy.BookAccessionId = accessionNumber.ToString
'                                objBookCopy.BookCopyBookId = BookId.ToString
'                                objBookCopy.BookCopyNumber = ""
'                                objBookCopy.BookCopyQuality = "EXCELLENT" 'must fix
'                                objBookCopy.BookCopyAquisition = cboAquisition.Text
'                                If cboAquisition.Text = "BOUGHT BY SCHOOL" Then
'                                    objBookCopy.BookCopyPrice = txtPrice.Text
'                                Else
'                                    objBookCopy.BookCopyPrice = "0.00"
'                                End If
'                                objBookCopy.BookCopyDateAdded = dateToday.ToString("d")
'                                objBookCopy.BookCopyShelfSectionId = dsBookShelfSection.Tables(0).Rows(cboShelfSection.SelectedIndex).Item(2).ToString.Trim
'                                objBookCopy.BookCopyShelfId = dsBookShelf.Tables(0).Rows(cboShelf.SelectedIndex).Item(0).ToString.Trim

'                                sqlAddCopies += "INSERT INTO `bookcopy`(`bookAccessionId`, `bookCopyBookId`, `bookCopyNumber`, `bookCopyQuality`, `bookCopyAquisition`, `bookCopyPrice`, `bookCopyDateAdded`, `bookCopyShelfSectionId`) VALUES (" & _
'                                            objBookCopy.BookAccessionId.ToString + "," & _
'                                            objBookCopy.BookCopyBookId.ToString + ",'" & _
'                                            objBookCopy.BookCopyNumber + "','" & _
'                                            objBookCopy.BookCopyQuality + "','" & _
'                                            objBookCopy.BookCopyAquisition + "','" & _
'                                            objBookCopy.BookCopyPrice + "','" & _
'                                            objBookCopy.BookCopyDateAdded + "'," & _
'                                            objBookCopy.BookCopyShelfSectionId.ToString + ");"
'                                index += 1
'                                accessionNumber += 1
'                            End While

'                            LibraryDatabase.execSQL(sqlAddCopies)
'                            MessageBox.Show("You have successfully added new book copies.", "Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
'                            Me.DialogResult = Windows.Forms.DialogResult.OK

'                        ElseIf count = 1 Then
'                            MessageBox.Show("Accession number: " + existAccession + " already exists in the database.", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                            txtAccession1.Focus()
'                        ElseIf count > 1 Then
'                            MessageBox.Show("Accession numbers: " + existAccession + " already exist in the database.", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                            txtAccession1.Focus()
'                        End If
'                    Else
'                        MessageBox.Show("Please enter a valid accession order. It must start from lower to higher accession number.", "Invalid Accession Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                        txtAccession1.Focus()
'                    End If
'                Else
'                    MessageBox.Show("Please enter a valid accession number.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                    txtAccession2.Focus()
'                End If
'            Else
'                MessageBox.Show("Please enter a valid accession number.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                txtAccession1.Focus()
'            End If
'        End If
'    End Sub
'End Class