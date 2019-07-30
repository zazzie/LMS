Public Class FormBookShelfSectionNew

    Private _id As String
    'Dim availableSectionId As Integer
    Private objBookshelfSection As New BookShelfSection

    Public Property BookshelfIdSub
        Get
            Return _id
        End Get
        Set(ByVal value)
            _id = value
        End Set
    End Property

    Private Sub renameColumns()
        With dgvBookshelfSection
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID" 'renaming
            .Columns(1).HeaderCell.Value = "Bookshelf Section"
        End With
    End Sub
    Private Function isExistInList(ByVal sectionName As String) As Boolean
        Dim count As Integer = 0
        For Each row As DataGridViewRow In dgvBookshelfSection.Rows
            If sectionName = row.Cells(1).Value.ToString.Trim Then
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function

    Private Function isExistInListNumber(ByVal sectionNum As String, ByVal ds As DataSet) As Boolean
        For Each row As DataGridViewRow In dgvBookshelfSection.Rows
            If sectionNum = row.Cells(0).Value.ToString.Trim Then
                Return True
                Exit Function
            End If
        Next

        Dim index As Integer = 0
        While index < ds.Tables(0).Rows.Count
            If sectionNum = ds.Tables(0).Rows(index).Item(0).ToString Then
                Return True
                Exit Function
            End If
            index += 1
        End While
        Return False
    End Function

    Private Sub FormBookShelfSectionNew_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If dgvBookshelfSection.RowCount > 0 Then
            Dim ans As Integer
            ans = MsgBox("There are unsaved changes. Do you want to exit without saving?", MsgBoxStyle.YesNo, "Unsaved Changes")
            If ans = MsgBoxResult.Yes Then
                Me.Dispose()
            Else
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub FormBookShelfSectionNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBookshelfSection.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        renameColumns()
        txtBookshelfSection.Focus()
    End Sub

    Private Sub btnAddToList_Click(sender As Object, e As EventArgs) Handles btnAddToList.Click
        If Not String.IsNullOrWhiteSpace(txtBookshelfSection.Text) Then
            Try
                If LibraryDatabase.isExisting("SELECT COUNT(*) FROM bookshelfsection WHERE bookShelfSectionBookShelfId='" + BookshelfIdSub.ToString + "' and bookShelfSectionName='" + txtBookshelfSection.Text + "';") = False Then
                    If isExistInList(txtBookshelfSection.Text) = False Then

                        Dim id As String
                        Dim count As Integer
                        Dim ds As DataSet
                        ds = LibraryDatabase.fetchSQL("SELECT `bookShelfSectionId` FROM `bookshelfsection`;")
                        count = countRecord("SELECT COUNT(*) FROM bookshelfsection;") + 1
                        id = "SS" + count.ToString("00000000")
                        While isExistInListNumber(id, ds) = True
                            count += 1
                            id = "SS" + count.ToString("00000000")
                        End While

                        Dim addRow As String() = New String() {id, txtBookshelfSection.Text}
                        dgvBookshelfSection.Rows.Add(addRow)
                        txtBookshelfSection.Clear()
                        txtBookshelfSection.Focus()

                    Else
                        MessageBox.Show("Bookshelf Section Name is already in the list!", "Already Listed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtBookshelfSection.Select()
                        txtBookshelfSection.Focus()
                    End If
                Else
                    MessageBox.Show("Bookshelf Section already exist in the record!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtBookshelfSection.Select()
                    txtBookshelfSection.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            MessageBox.Show("Bookshelf Section input field is empty!", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtBookshelfSection.Focus()
        End If
    End Sub

    Private Sub btnRemoveFromList_Click(sender As Object, e As EventArgs) Handles btnRemoveFromList.Click
        If dgvBookshelfSection.RowCount > 0 Then
            For Each removerow As DataGridViewRow In dgvBookshelfSection.SelectedRows
                dgvBookshelfSection.Rows.Remove(removerow)
            Next
        End If
    End Sub

    Private Sub txtBookshelfSection_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBookshelfSection.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetterOrDigit(c) Or (c = " ") Or (c = "#") Or (c = "-") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtBookshelfSection_LostFocus(sender As Object, e As EventArgs) Handles txtBookshelfSection.LostFocus
        txtBookshelfSection.Text = txtBookshelfSection.Text.ToUpper
    End Sub

    Private Sub btnSaveAll_Click(sender As Object, e As EventArgs) Handles btnSaveAll.Click
        If dgvBookshelfSection.RowCount > 0 Then
            Dim sqlInsert As String = ""
            For Each row As DataGridViewRow In dgvBookshelfSection.Rows
                objBookshelfSection.BookShelfSectionId = row.Cells(0).Value.ToString.Trim
                objBookshelfSection.BookShelfSectionBookShelfId = BookshelfIdSub.ToString
                objBookshelfSection.BookShelfSectionName = row.Cells(1).Value.ToString.Trim

                sqlInsert += "INSERT INTO `bookshelfsection`(`bookShelfSectionId`, `bookShelfSectionName`, `bookShelfSectionBookShelfId`) VALUES ('" & _
                    objBookshelfSection.BookShelfSectionId + "','" & _
                    objBookshelfSection.BookShelfSectionName + "','" & _
                    objBookshelfSection.BookShelfSectionBookShelfId + "');"
            Next
            Try
                LibraryDatabase.execdeleteSQL(sqlInsert)
                MessageBox.Show("You have successfully added new bookshelf section/s!", "New Bookshelf Section Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub
End Class