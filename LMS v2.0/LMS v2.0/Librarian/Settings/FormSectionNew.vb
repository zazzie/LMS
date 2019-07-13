Public Class FormSectionNew
    Private _id As Integer
    Dim availableSectionId As Integer
    Private sectionObj As New StudentSection

    Public Property LevelIdSub()
        Get
            Return _id
        End Get
        Set(ByVal value)
            _id = value
        End Set
    End Property

    Private Sub renameColumns()
        With dgvSectionNew
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "Section"
        End With
    End Sub

    Private Function isExistInList(ByVal sectionName As String) As Boolean
        Dim count As Integer = 0
        For Each row As DataGridViewRow In dgvSectionNew.Rows
            If sectionName = row.Cells(1).Value.ToString.Trim Then
                count += 1
            End If
        Next
        If count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub formSectionNew_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If dgvSectionNew.RowCount > 0 Then
            Dim ans As Integer
            ans = MsgBox("There are unsaved changes. Do you want to exit without saving?", MsgBoxStyle.YesNo, "Unsaved Changes")
            If ans = MsgBoxResult.Yes Then
                Me.Dispose()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub formSectionNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvSectionNew.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        availableSectionId = LibraryDatabase.GenerateID("SELECT MAX(studentSectionId) FROM studentsection;")
        renameColumns()
        txtSection.Focus()
    End Sub


    Private Sub btnAddToList_Click(sender As Object, e As EventArgs) Handles btnAddToList.Click
        If Not String.IsNullOrWhiteSpace(txtSection.Text) Then
            If LibraryDatabase.isExisting("SELECT COUNT(*) FROM studentsection WHERE studentSectionLevelId=" + LevelIdSub.ToString + " AND studentSectionName='" + txtSection.Text + "';") = False Then
                If isExistInList(txtSection.Text) = False Then
                    Dim addRow As String() = New String() {availableSectionId.ToString, txtSection.Text}
                    dgvSectionNew.Rows.Add(addRow)
                    availableSectionId += 1
                    txtSection.Clear()
                    txtSection.Focus()
                Else
                    MessageBox.Show("Section Name is already in the list!", "Already Listed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSection.Select()
                    txtSection.Focus()
                End If
            Else
                MessageBox.Show("Section Name already exist in the record!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSection.Select()
                txtSection.Focus()
            End If
        Else
            MessageBox.Show("Section Name input is empty!", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSection.Focus()
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgvSectionNew.RowCount > 0 Then
            For Each removeRow As DataGridViewRow In dgvSectionNew.SelectedRows
                dgvSectionNew.Rows.Remove(removeRow)
            Next
        End If
    End Sub

    Private Sub txtSection_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSection.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetterOrDigit(c) Or (c = " ") Or (c = ".") Or (c = "-") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSection_LostFocus(sender As Object, e As EventArgs) Handles txtSection.LostFocus
        txtSection.Text = txtSection.Text.ToUpper
    End Sub

    Private Sub txtSection_TextChanged(sender As Object, e As EventArgs) Handles txtSection.TextChanged

    End Sub

    Private Sub btnSaveAll_Click(sender As Object, e As EventArgs) Handles btnSaveAll.Click
        If dgvSectionNew.RowCount > 0 Then
            Dim sqlInsert As String = ""
            For Each row As DataGridViewRow In dgvSectionNew.Rows
                sectionObj.StudentSectionId = row.Cells(0).Value.ToString.Trim
                sectionObj.StudentSectionLevelId = LevelIdSub
                sectionObj.StudentSectionName = row.Cells(1).Value.ToString.Trim

                sqlInsert += "INSERT INTO `studentsection`(`studentSectionId`, `studentSectionName`, `studentSectionLevelId`) VALUES (" & _
                                                    sectionObj.StudentSectionId.ToString + ",'" & _
                                                    sectionObj.StudentSectionName + "'," & _
                                                    sectionObj.StudentSectionLevelId.ToString + ");"
            Next

            LibraryDatabase.execSQL(sqlInsert)
            MessageBox.Show("You have successfully added new section/s!", "New Section Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Dispose()
        End If
    End Sub
End Class