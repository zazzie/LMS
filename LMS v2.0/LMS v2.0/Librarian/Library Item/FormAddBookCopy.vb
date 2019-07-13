Public Class FormAddBookCopy
    Dim dsBookShelf As New DataSet
    Dim dsBookShelfSection As New DataSet
    Dim objFormBookShelf As New FormBookShelf
    Public DsCopyList As DataSet
    Public DsNewCopyList As DataSet
    Dim dateToday As DateTime = DateTime.Now

    'Public Property DsCopyList
    '    Get
    '        Return _dsCopyList
    '    End Get
    '    Set(value)
    '        _dsCopyList = value
    '    End Set
    'End Property

    'Public Property DsNewCopyList
    '    Get
    '        Return _dsNewCopyList
    '    End Get
    '    Set(value)
    '        _dsNewCopyList = value
    '    End Set
    'End Property

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

    Private Sub FormAddBookCopy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboAquisition.Text = "BOUGHT BY SCHOOL"
        rbtSingleCopy.Checked = True
        checkRBTs()
        initializeDsCopy()
        generateBookShelf()
        generateBookShelfSection()
        txtPrice.Text = "0.00"
    End Sub

    Private Sub btnShelf_Click(sender As Object, e As EventArgs) Handles btnShelf.Click
        objFormBookShelf = New FormBookShelf
        If objFormBookShelf.ShowDialog = Windows.Forms.DialogResult.OK Then
            generateBookShelf()
            generateBookShelfSection()
        End If
    End Sub

    Private Sub checkRBTs()
        If rbtSingleCopy.Checked = True Then
            lblDash.Visible = False
            txtAccession2.Visible = False
            lblNumberCopy.Text = "(1 copy)"
            lblNumberCopy.ForeColor = Color.Black
            txtAccession1.Focus()
        ElseIf rbtMultiCopy.Checked = True Then
            lblDash.Visible = True
            txtAccession2.Visible = True
            'txtAccession1.Focus()
            If Val(txtAccession2.Text) < Val(txtAccession1.Text) Or Val(txtAccession2.Text) = Val(txtAccession1.Text) Then
                lblNumberCopy.Text = "(INVALID ACCESSION ORDER)"
                lblNumberCopy.ForeColor = Color.Red
            Else
                lblNumberCopy.Text = "(" + ((Val(txtAccession2.Text) - Val(txtAccession1.Text)) + 1).ToString + " copies)"
                lblNumberCopy.ForeColor = Color.Black
            End If
        End If
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

    Private Sub rbtSingleCopy_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSingleCopy.CheckedChanged
        checkRBTs()
    End Sub

    Private Sub rbtMultiCopy_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMultiCopy.CheckedChanged
        checkRBTs()
    End Sub

    Private Sub txtAccession1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAccession1.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAccession1_LostFocus(sender As Object, e As EventArgs) Handles txtAccession1.LostFocus
        txtAccession1.Text = txtAccession1.Text.ToUpper
    End Sub

    Private Sub txtAccession2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAccession2.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAccession2_LostFocus(sender As Object, e As EventArgs) Handles txtAccession2.LostFocus
        txtAccession2.Text = txtAccession2.Text.ToUpper
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

    Private Sub txtAccession2_TextChanged(sender As Object, e As EventArgs) Handles txtAccession2.TextChanged
        checkRBTs()
    End Sub

    Private Sub txtAccession1_TextChanged(sender As Object, e As EventArgs) Handles txtAccession1.TextChanged
        checkRBTs()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Dispose()
    End Sub

    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        If rbtSingleCopy.Checked = True Then
            If String.IsNullOrWhiteSpace(txtAccession1.Text) = False Then
                If DsCopyList.Tables(0).Rows.Count > 0 Then
                    Dim countExist As Integer = 0
                    Dim index As Integer = 0
                    While index < DsCopyList.Tables(0).Rows.Count
                        If txtAccession1.Text = DsCopyList.Tables(0).Rows(index).Item(0).ToString.Trim Then
                            countExist += 1
                        End If
                        index += 1
                    End While
                    If countExist = 0 Then
                        'MsgBox(countExist.ToString)
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
                    Else
                        'MsgBox(countExist.ToString)
                        MessageBox.Show("Accession number: " + txtAccession1.Text + " is already listed in the book copy list.", "Already Listed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtAccession1.Focus()
                    End If
                Else 'add this if empty table
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
                End If
            Else
                MessageBox.Show("Please enter a valid accession number.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAccession1.Focus()
            End If

        ElseIf rbtMultiCopy.Checked = True Then
            If String.IsNullOrWhiteSpace(txtAccession1.Text) = False Then
                If String.IsNullOrWhiteSpace(txtAccession2.Text) = False Then
                    If Not lblNumberCopy.Text = "(INVALID ACCESSION ORDER)" Or Val(txtAccession1.Text) >= Val(txtAccession2.Text) Then

                        If DsCopyList.Tables(0).Rows.Count > 0 Then
                            Dim countExist As Integer = 0
                            Dim index As Integer = 0
                            Dim min As Integer = Val(txtAccession1.Text)
                            Dim index2 As Integer = min
                            Dim max As Integer = Val(txtAccession2.Text)
                            Dim existing As String = ""
                            While index < DsCopyList.Tables(0).Rows.Count
                                While index2 <= max
                                    If index2.ToString = DsCopyList.Tables(0).Rows(index).Item(0).ToString.Trim Then
                                        countExist += 1
                                        If countExist > 1 Then
                                            existing += ", "
                                        End If
                                        existing += index2.ToString
                                        Exit While
                                    End If
                                    index2 += 1
                                End While
                                index2 = min
                                index += 1
                            End While
                            If countExist = 0 Then
                                Dim accessionNumber As Integer = min
                                Dim row As DataRow
                                While accessionNumber <= max

                                    row = DsNewCopyList.Tables(0).NewRow
                                    row.Item(0) = accessionNumber.ToString
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
                                    accessionNumber += 1
                                End While
                                Me.DialogResult = Windows.Forms.DialogResult.OK
                            ElseIf countExist = 1 Then
                                MessageBox.Show("Accession number: " + existing + " is already listed in the book copy list.", "Already Listed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtAccession1.Focus()
                            ElseIf countExist > 1 Then
                                MessageBox.Show("Accession numbers: " + existing + " are already listed in the book copy list.", "Already Listed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtAccession1.Focus()
                            End If
                        Else 'add this if empty table
                            Dim accessionNumber As Integer = Val(txtAccession1.Text)
                            Dim max As Integer = Val(txtAccession2.Text)
                            Dim row As DataRow
                            While accessionNumber <= max

                                row = DsNewCopyList.Tables(0).NewRow
                                row.Item(0) = accessionNumber.ToString
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
                                accessionNumber += 1
                            End While
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        End If
                    Else
                        MessageBox.Show("Please enter a valid accession order. It must start from lower to higher accession number.", "Invalid Accession Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtAccession1.Focus()
                    End If
                Else
                    MessageBox.Show("Please enter a valid accession number.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtAccession2.Focus()
                End If
            Else
                MessageBox.Show("Please enter a valid accession number.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAccession1.Focus()
            End If
        End If
    End Sub
End Class