Public Class Form1StudentLevelSection
    Private studLevelObj As New StudentLevel
    Private studSecObj As New StudentSection
    Private addSectionObj As New FormSectionNew
    Dim availableSecId As Integer
    Private viewArchiveObj As New FormSectionArchive
    Dim dsLevel As DataSet
    Dim dsSection As DataSet
    Private Sub renameColumns()
        With dgvLevel
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "" 'RENAMING COLUMNS
            .Columns(0).FillWeight = 20
            .Columns(1).HeaderCell.Value = "Student Level"
            .Columns(1).FillWeight = 100
        End With
        With dgvSection
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "" 'RENAMING COLUMNS
            .Columns(0).FillWeight = 20
            .Columns(1).HeaderCell.Value = "Section Name"
            .Columns(1).FillWeight = 100
        End With
    End Sub

    Private Sub enableButtons(ByVal flag As Boolean)
        btnAdd.Enabled = flag
        btnEdit.Enabled = flag
        btnClose.Enabled = flag
        btnRemove.Enabled = flag
        btnEditSec.Enabled = flag
        btnRemoveSec.Enabled = flag
        btnViewArchive.Enabled = flag
    End Sub

    Private Sub displayLevelInfo()
        Dim index As Integer
        If dgvLevel.Rows.Count > 0 Then
            If dsLevel.Tables(0).Rows.Count > 0 Then
                index = dgvLevel.SelectedRows(0).Cells(0).Value - 1
                txtLevel.Text = dsLevel.Tables(0).Rows(index).Item(1).ToString.Trim

                If dsLevel.Tables(0).Rows(index).Item(3).ToString.Trim = "ELEM" Then
                    rbtElementary.Checked = True
                ElseIf dsLevel.Tables(0).Rows(index).Item(3).ToString.Trim = "JH" Then
                    rbtJuniorHigh.Checked = True
                End If
            End If
        Else
            dgvLevel.Rows.Clear()
            txtLevel.Clear()
            rbtElementary.Checked = False
            rbtJuniorHigh.Checked = False
            dgvSection.Rows.Clear()
            txtSection.Clear()
        End If
    End Sub

    Private Sub generateOrderElem()
        Try
            cboLevelOrder.DataSource = LibraryDatabase.fetchSQL("SELECT DISTINCT studentLevelName FROM studentlevel WHERE studentLevelClass='ELEM' ORDER BY  studentLevelOrder ").Tables(0)
            cboLevelOrder.DisplayMember = "studentLevelName"
        Catch ex As Exception
            cboLevelOrder.Items.Clear()
            cboLevelOrder.Text = ""
        End Try
    End Sub
    Private Sub generateOrderJH()
        Try
            cboLevelOrder.DataSource = LibraryDatabase.fetchSQL("SELECT DISTINCT studentLevelName FROM studentlevel WHERE studentLevelClass='JH' ORDER BY  studentLevelOrder ").Tables(0)
            cboLevelOrder.DisplayMember = "studentLevelName"
        Catch ex As Exception
            cboLevelOrder.Items.Clear()
            cboLevelOrder.Text = ""
        End Try
    End Sub
    Private Sub displaySectionInfo()
        If dgvSection.Rows.Count > 0 Then
            txtSection.Text = dgvSection.SelectedRows(0).Cells(1).Value.ToString.Trim
        Else
            dgvSection.Rows.Clear()
            txtSection.Clear()
        End If
    End Sub
    Private Sub reOrderElem()
        Dim sqlSearch As String
        Dim sqlUpdate As String = ""
        Dim order As Integer = 10
        Try
            sqlSearch = "SELECT DISTINCT `studentLevelId`, `studentLevelName`, `studentLevelOrder`, `studentLevelClass` FROM `studentlevel` WHERE studentLevelClass='ELEM' ORDER BY studentLevelOrder ASC;"
            Dim ds As DataSet
            ds = LibraryDatabase.fetchSQL(sqlSearch)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    sqlUpdate += "UPDATE `studentlevel` SET `studentLevelOrder`=" + order + " WHERE studentLevelId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim + ";"
                    order += 10
                    index += 1
                End While
                LibraryDatabase.execSQL(sqlUpdate)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub reOrderJH()
        Dim sqlSearch As String
        Dim sqlUpdate As String = ""
        Dim order As Integer = 100
        Try
            sqlSearch = "SELECT DISTINCT `studentLevelId`, `studentLevelName`, `studentLevelOrder`, `studentLevelClass` FROM `studentlevel` WHERE studentLevelClass='JH' ORDER BY studentLevelOrder ASC;"
            Dim ds As DataSet
            ds = LibraryDatabase.fetchSQL(sqlSearch)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    sqlUpdate += "UPDATE `studentlevel` SET `studentLevelOrder`=" + order + " WHERE studentLevelId=" + ds.Tables(0).Rows(index).Item(0).ToString.Trim + ";"
                    order += 10
                    index += 1
                End While
                LibraryDatabase.execSQL(sqlUpdate)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub generateLevel()
        Dim sqlSearch As String
        Try
            sqlSearch = "SELECT DISTINCT `studentLevelId`, `studentLevelName`, `studentLevelOrder`, `studentLevelClass` FROM `studentlevel` WHERE `studentLevelClass`='ELEM' OR `studentLevelClass`='JH' ORDER BY studentLevelOrder ASC ;"
            Dim ds As DataSet
            dgvLevel.Rows.Clear()
            ds = LibraryDatabase.fetchSQL(sqlSearch)
            If ds.Tables(0).Rows.Count > 0 Then
                dsLevel = ds
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With dgvLevel
                        dgvLevel.Rows.Add(index + 1, _
                                        ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                    End With
                    index += 1
                End While
                dgvLevel.Refresh()
                dgvLevel.Select()
                displayLevelInfo()
            Else
                dgvLevel.Rows.Clear()
                txtLevel.Clear()
                rbtElementary.Checked = False
                rbtJuniorHigh.Checked = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub generateSection()
        Dim index As Integer
        Dim sqlSearch As String
        If dgvLevel.Rows.Count > 0 Then
            index = dgvLevel.SelectedRows(0).Cells(0).Value - 1
            Try
                sqlSearch = "SELECT DISTINCT `studentSectionId`, `studentSectionName`, `studentSectionLevelId`, `studentSectionStatus` FROM `studentsection` WHERE studentSectionLevelId=" + dsLevel.Tables(0).Rows(index).Item(0).ToString.Trim + " ORDER BY studentSectionName ASC ;"
                Dim ds As DataSet
                dgvSection.Rows.Clear()
                ds = LibraryDatabase.fetchSQL(sqlSearch)
                If ds.Tables(0).Rows.Count > 0 Then
                    dsSection = ds
                    Dim index1 As Integer = 0
                    While index1 < ds.Tables(0).Rows.Count
                        With dgvSection
                            dgvSection.Rows.Add(index1 + 1, _
                                            ds.Tables(0).Rows(index1).Item(1).ToString.Trim)
                        End With
                        index1 += 1
                    End While
                    dgvSection.Refresh()
                    dgvSection.Select()
                    lblNumberSections.Text = "Number of Section/s: " + dgvSection.Rows.Count.ToString + ""
                    displaySectionInfo()
                Else
                    dgvSection.Rows.Clear()
                    txtSection.Clear()
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub

    Private Sub formStudentLevelSection_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If btnClose.Enabled = False Then
            Dim ans As Integer
            ans = MsgBox("There are unsaved changes. Do you want to exit without saving?", MsgBoxStyle.YesNo, "Unsaved Changes")
            If ans = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub formStudentLevelSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLevel.Font = New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        dgvSection.Font = New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        RenameColumns()
        btnViewArchive.Visible = False
        revertFormSettings()
        generateLevel()
        displayLevelInfo()
        generateSection()
        displaySectionInfo()
    End Sub
    ''' <summary>
    ''' ADDING PA LANGGGG
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub addLevelSection()
        Dim sqlInsert As String
        studLevelObj.StudentLevelId = LibraryDatabase.GenerateID("SELECT MAX(studentLevelId) FROM studentlevel;")
        studLevelObj.StudentLevelName = txtLevel.Text

        If rbtElementary.Checked = True Then
            studLevelObj.StudentLevelClass = "ELEM"
        ElseIf rbtJuniorHigh.Checked = True Then
            studLevelObj.StudentLevelClass = "JH"
        End If

        Dim order As Integer
        Try
            order = LibraryDatabase.fetchSQL("SELECT studentLevelOrder FROM studentlevel WHERE studentLevelName='" + cboLevelOrder.Text + "'").Tables(0).Rows(0).Item(0)
            If rbtAfter.Checked = True Then
                order += 5
            ElseIf rbtBefore.Checked = True Then
                order -= 5
            End If
        Catch ex As Exception
            If rbtElementary.Checked = True Then
                order = 10
            ElseIf rbtJuniorHigh.Checked = True Then
                order = 100
            End If
        End Try


        studLevelObj.StudentLevelOrder = order

        sqlInsert = "INSERT INTO `studentlevel`(`studentLevelId`, `studentLevelName`, `studentLevelOrder`, `studentLevelClass`) VALUES (" & _
                                studLevelObj.StudentLevelId.ToString + ",'" & _
                                studLevelObj.StudentLevelName + "'," & _
                                studLevelObj.StudentLevelOrder.ToString + ",'" & _
                                studLevelObj.StudentLevelClass + "');"
        'add ing section
        Dim maxId As Integer
        maxId = LibraryDatabase.GenerateID("SELECT MAX(studentSectionId) FROM studentsection;")
        For Each row As DataGridViewRow In dgvSection.Rows
            studSecObj.StudentSectionId = maxId
            maxId += 1
            studSecObj.StudentSectionName = row.Cells(1).Value.ToString.Trim
            studSecObj.StudentSectionLevelId = studLevelObj.StudentLevelId

            sqlInsert += "INSERT INTO `studentsection`(`studentSectionId`, `studentSectionName`, `studentSectionLevelId`) VALUES (" & _
                                                studSecObj.StudentSectionId.ToString + ",'" & _
                                                studSecObj.StudentSectionName + "'," & _
                                                studSecObj.StudentSectionLevelId.ToString + ");"
        Next

        LibraryDatabase.execSQL(sqlInsert)
    End Sub

    Private Sub revertFormSettings()
        btnAdd.Text = "Add"
        btnEdit.Text = "Edit"
        btnRemove.Text = "Remove"
        btnEditSec.Text = "Edit Section"
        btnRemoveSec.Text = "Remove Section"
        enableButtons(True)
        txtLevel.Enabled = False
        txtSection.Enabled = False

        btnAdd.Enabled = True
        btnAdd.Visible = True

        panelOrder.Visible = False
        panelStudentType.Enabled = False

        dgvLevel.Enabled = True
        dgvSection.Enabled = True

    End Sub

    Private Sub txtLevel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLevel.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetterOrDigit(c) Or (c = " ") Or (c = "-") Or (c = ".") Or (c = "/") Or (c = "\") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSection_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSection.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetterOrDigit(c) Or (c = " ") Or (c = "-") Or (c = ".") Or (c = "/") Or (c = "\") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtLevel_LostFocus(sender As Object, e As EventArgs) Handles txtLevel.LostFocus
        txtLevel.Text = txtLevel.Text.ToUpper
    End Sub

    Private Sub txtSection_LostFocus(sender As Object, e As EventArgs) Handles txtSection.LostFocus
        txtSection.Text = txtSection.Text.ToUpper
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Add" Then
            enableButtons(False)
            dgvLevel.Enabled = False
            dgvSection.Enabled = True
            dgvSection.Rows.Clear()
            txtSection.Enabled = True

            panelStudentType.Enabled = True
            rbtElementary.Checked = True
            generateOrderElem()
            txtLevel.Enabled = True

            panelOrder.Visible = True

            rbtAfter.Checked = True

            btnEditSec.Text = "Add To List"
            btnRemoveSec.Text = "Remove From List"
            btnEdit.Text = "Save"
            btnRemove.Text = "Cancel"

            btnEditSec.Enabled = True
            btnRemoveSec.Enabled = True
            btnEdit.Enabled = True
            btnRemove.Enabled = True

            btnAdd.Enabled = False
            btnAdd.Visible = False

            txtLevel.Clear()
            txtSection.Clear()
            txtLevel.Focus()
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If btnRemove.Text = "Cancel" Then
            generateLevel()
            generateSection()
            revertFormSettings()
        ElseIf btnRemove.Text = "Remove" Then
            If dgvLevel.Rows.Count > 0 Then
                Dim ans As Integer
                ans = MsgBox("You are about to delete the Level: '" + txtLevel.Text + "'. By proceeding, section affiliated with this level will also be deleted. Proceed?", MsgBoxStyle.YesNo, "Remove City")
                If ans = MsgBoxResult.Yes Then
                    studLevelObj.StudentLevelId = dgvLevel.SelectedRows(0).Cells(0).Value.ToString

                    Dim sqlDelete As String
                    sqlDelete = "DELETE FROM `studentsection` " & _
                                "WHERE studentSectionLevelId= " + studLevelObj.StudentLevelId.ToString & ";" & _
                                "DELETE FROM `studentlevel` " & _
                                "WHERE studentlevelId= " + studLevelObj.StudentLevelId.ToString & ";"

                    LibraryDatabase.execSQL(sqlDelete)

                    MessageBox.Show("You have successfully deleted a city and its affiliated barangays from the record.", "Deleted City", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                    generateLevel()
                    generateSection()
                End If
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Save" Then
            If Not String.IsNullOrWhiteSpace(txtLevel.Text) Then
                If dgvLevel.Rows.Count > 0 Then
                    If LibraryDatabase.isExisting("SELECT COUNT(*) FROM studentlevel WHERE studentLevelName='" + txtLevel.Text + "';") = False Then
                        If Not dgvSection.Rows.Count = 0 Then

                            addLevelSection()

                            MessageBox.Show("You have successfully added a new Student Level in the record!", "New Level Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                            If rbtElementary.Checked = True Then
                                reOrderElem()
                            ElseIf rbtJuniorHigh.Checked = True Then
                                reOrderJH()
                            End If
                            revertFormSettings()
                            generateLevel()
                            generateSection()





                        Else
                            MessageBox.Show("At least one Section Name is required to be added along the Level!", "Required Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtLevel.Focus()
                        End If
                    Else
                        MessageBox.Show("A record of the Level Name already exists!", "Existing Level", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtLevel.Focus()
                    End If
                ElseIf dgvLevel.Rows.Count = 0 Then
                    If Not dgvSection.Rows.Count = 0 Then

                        addLevelSection()

                        MessageBox.Show("You have successfully added a new Student Level in the record!", "New Level Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        If rbtElementary.Checked = True Then
                            reOrderElem()
                        ElseIf rbtJuniorHigh.Checked = True Then
                            reOrderJH()
                        End If
                        revertFormSettings()
                        generateLevel()
                        generateSection()
                    Else
                        MessageBox.Show("At least one Section Name is required to be added along the Level!", "Required Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtLevel.Focus()
                    End If
                End If
            Else
                MessageBox.Show("Level Name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtLevel.Focus()
            End If
        ElseIf btnEdit.Text = "Edit" Then
            If dgvLevel.Rows.Count > 0 Then
                enableButtons(False)
                dgvLevel.Enabled = False
                dgvSection.Enabled = False

                panelStudentType.Enabled = True
                panelOrder.Visible = True
                If rbtElementary.Checked = True Then
                    generateOrderElem()
                ElseIf rbtJuniorHigh.Checked = True Then
                    generateOrderJH()
                End If

                btnEdit.Text = "Update"
                btnRemove.Text = "Cancel"
                btnEditSec.Text = "Add New"

                btnEditSec.Enabled = True
                btnEdit.Enabled = True
                btnRemove.Enabled = True

                btnAdd.Enabled = False
                btnAdd.Visible = False

                txtLevel.Enabled = True
                txtLevel.Focus()
            End If
        ElseIf btnEdit.Text = "Update" Then
            If Not String.IsNullOrWhiteSpace(txtLevel.Text) Then
                If dgvLevel.Rows.Count > 0 Then
                    Dim index = dgvLevel.SelectedRows(0).Cells(0).Value - 1
                    If LibraryDatabase.isExisting("SELECT COUNT(*) FROM studentlevel WHERE studentLevelName='" + txtLevel.Text + "' AND studentlevelId!=" + dsLevel.Tables(0).Rows(index).Item(0).ToString.Trim + ";") = False Then

                        'EDITTTTTTTTTT
                        If rbtElementary.Checked = True Then
                            studLevelObj.StudentLevelClass = "ELEM"
                        ElseIf rbtJuniorHigh.Checked = True Then
                            studLevelObj.StudentLevelClass = "JH"
                        End If

                        studLevelObj.StudentLevelId = dsLevel.Tables(0).Rows(index).Item(0).ToString.Trim
                        studLevelObj.StudentLevelName = txtLevel.Text
                        Dim order As Integer
                        Try
                            order = LibraryDatabase.fetchSQL("SELECT studentLevelOrder FROM studentlevel WHERE studentLevelName='" + cboLevelOrder.Text + "'").Tables(0).Rows(0).Item(0)
                            If rbtAfter.Checked = True Then
                                order += 5
                            ElseIf rbtBefore.Checked = True Then
                                order -= 5
                            End If
                        Catch ex As Exception
                            If rbtElementary.Checked = True Then
                                order = 10
                            ElseIf rbtJuniorHigh.Checked = True Then
                                order = 100
                            End If
                        End Try
                        studLevelObj.StudentLevelOrder = order

                        studLevelObj.editStudentLevel()
                        MessageBox.Show("You have successfully updtaed a Level in the record!", "Successfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        If rbtElementary.Checked = True Then
                            reOrderElem()
                        ElseIf rbtJuniorHigh.Checked = True Then
                            reOrderJH()
                        End If
                        revertFormSettings()
                        generateLevel()
                        generateSection()

                    Else
                        MessageBox.Show("A record of the Level Name already exists!", "Existing Level", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtLevel.Focus()
                    End If
                ElseIf dgvLevel.Rows.Count = 0 Then
                    'EDITTTTTTTTTT
                    Dim index = dgvLevel.SelectedRows(0).Cells(0).Value - 1
                    studLevelObj.StudentLevelId = dsLevel.Tables(0).Rows(index).Item(0).ToString.Trim
                    studLevelObj.StudentLevelName = txtLevel.Text
                    Dim order As Integer
                    Try
                        order = LibraryDatabase.fetchSQL("SELECT studentLevelOrder FROM studentlevel WHERE studentLevelName='" + cboLevelOrder.Text + "'").Tables(0).Rows(0).Item(0)
                        If rbtAfter.Checked = True Then
                            order += 5
                        ElseIf rbtBefore.Checked = True Then
                            order -= 5
                        End If
                    Catch ex As Exception
                        If rbtElementary.Checked = True Then
                            order = 10
                        ElseIf rbtJuniorHigh.Checked = True Then
                            order = 100
                        End If
                    End Try
                    studLevelObj.StudentLevelOrder = order

                    studLevelObj.editStudentLevel()
                    MessageBox.Show("You have successfully updtaed a Level in the record!", "Successfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    If rbtElementary.Checked = True Then
                        reOrderElem()
                    ElseIf rbtJuniorHigh.Checked = True Then
                        reOrderJH()
                    End If
                    revertFormSettings()
                    generateLevel()
                    generateSection()
                End If
            Else
                MessageBox.Show("Level Name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtLevel.Focus()
            End If
        End If
    End Sub

    Private Sub rbtElementary_CheckedChanged(sender As Object, e As EventArgs) Handles rbtElementary.CheckedChanged
        If rbtElementary.Checked = True Then
            generateOrderElem()
        ElseIf rbtJuniorHigh.Checked = True Then
            generateOrderJH()
        End If
    End Sub

    Private Sub rbtJuniorHigh_CheckedChanged(sender As Object, e As EventArgs) Handles rbtJuniorHigh.CheckedChanged
        If rbtElementary.Checked = True Then
            generateOrderElem()
        ElseIf rbtJuniorHigh.Checked = True Then
            generateOrderJH()
        End If
    End Sub

    Private Function isExistInList(ByVal sectionName As String) As Boolean
        Dim count As Integer = 0
        For Each row As DataGridViewRow In dgvSection.Rows
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
    Private Sub btnEditSec_Click(sender As Object, e As EventArgs) Handles btnEditSec.Click
        If btnEditSec.Text = "Add To List" Then
            If Not String.IsNullOrWhiteSpace(txtSection.Text) Then
                If isExistInList(txtSection.Text) = False Then
                    Dim addRow As String() = New String() {dgvSection.Rows.Count + 1, txtSection.Text}
                    dgvSection.Rows.Add(addRow)
                    txtSection.Clear()
                    txtSection.Focus()
                Else
                    MessageBox.Show("Section Name is already in the list!", "Already Listed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtLevel.Focus()
                End If
            Else
                MessageBox.Show("Section Name input is empty!", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSection.Focus()
            End If
        ElseIf btnEditSec.Text = "Add New" Then
            addSectionObj = New formSectionNew
            addSectionObj.LevelIdSub = dgvLevel.SelectedRows(0).Cells(0).Value.ToString
            If addSectionObj.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    generateSection()
                Catch ex As Exception
                    txtSection.Clear()
                End Try
            End If
        ElseIf btnEditSec.Text = "Edit Section" Then
            If dgvSection.RowCount > 0 Then
                Dim index As Integer
                index = dgvSection.SelectedRows(0).Cells(0).Value - 1
                Dim index2 As Integer
                index2 = dgvLevel.SelectedRows(0).Cells(0).Value - 1
                studSecObj.StudentSectionId = dsSection.Tables(0).Rows(index).Item(0)
                studSecObj.StudentSectionLevelId = dsLevel.Tables(0).Rows(index2).Item(0)
                dgvSection.Enabled = False
                dgvLevel.Enabled = False
                txtLevel.Enabled = False
                txtSection.Enabled = True
                enableButtons(False)
                btnEditSec.Text = "Update"
                btnRemoveSec.Text = "Cancel"
                btnEditSec.Enabled = True
                btnRemoveSec.Enabled = True
                txtSection.Focus()
            End If
        ElseIf btnEditSec.Text = "Update" Then
            If Not String.IsNullOrWhiteSpace(txtSection.Text) Then
                If LibraryDatabase.isExisting("SELECT COUNT(*) FROM studentsection WHERE studentsectionName='" + txtSection.Text + "' and studentsectionLevelId=" + studSecObj.StudentSectionLevelId.ToString + " and studentsectionId !=" + studSecObj.StudentSectionId.ToString + ";") = False Then
                    studSecObj.StudentSectionName = txtSection.Text
                    studSecObj.editStudentSection()
                    MessageBox.Show("You have successfully updated a section name!", "Updated Section Name", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    revertFormSettings()
                    generateLevel()
                    generateSection()
                Else
                    MessageBox.Show("Section Name already exist in " + txtLevel.Text + "!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSection.Focus()
                End If
            Else
                MessageBox.Show("Section Name input is empty!", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSection.Focus()
            End If
        End If
    End Sub

    Private Sub btnRemoveSec_Click(sender As Object, e As EventArgs) Handles btnRemoveSec.Click
        If btnRemoveSec.Text = "Remove Section" Then
            If dgvSection.RowCount > 0 Then
                Dim index As Integer = dgvSection.SelectedRows(0).Cells(0).Value - 1
                'If LibraryDatabase.isExisting("SELECT COUNT(*) FROM register WHERE registerSectionId=" + dgvSection.SelectedRows(0).Cells(0).Value.ToString + ";") = False Then
                If Not LibraryDatabase.fetchSQL("SELECT * FROM studentsection WHERE studentsectionLevelId='" + dsSection.Tables(0).Rows(index).Item(2).ToString + "';").Tables(0).Rows.Count = 1 Then
                    Dim ans As Integer
                    ans = MsgBox("Are you sure you want to remove '" + txtSection.Text + "' from the section list of " + txtLevel.Text + "?", MsgBoxStyle.YesNo, "Remove Barangay")
                    If ans = MsgBoxResult.Yes Then
                        studSecObj.StudentSectionId = dsSection.Tables(0).Rows(index).Item(0)
                        studSecObj.deleteStudentSection()
                        MessageBox.Show("You have successfully deleted " + txtSection.Text + " from the list.", "Deleted Section")
                        generateLevel()
                        generateSection()
                    End If
                Else
                    MessageBox.Show("You can't delete this section as it is the last one listed. Delete level instead from the list.", "Delete Restriction", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End If
            'Else
            '    Dim ans As Integer
            '    ans = MsgBox("You are not allowed to delete this section. An existing record from the registered borrowers is affiliated with this record. Proceed archiving this section instead. Continue?", MsgBoxStyle.YesNo, "Restriction On Delete")
            '    If ans = MsgBoxResult.Yes Then
            '        studSecObj.SectionId = dgvSection.SelectedRows(0).Cells(0).Value.ToString
            '        studSecObj.deactivateSection()
            '        MessageBox.Show("You have successfully archived the " + txtSection.Text + " from the list.", "Archived Section")
            '        refreshData()
            '    End If
            'End If
        ElseIf btnRemoveSec.Text = "Remove From List" Then
            If dgvSection.RowCount > 0 Then
                For Each removeRow As DataGridViewRow In dgvSection.SelectedRows
                    dgvSection.Rows.Remove(removeRow)
                Next
            End If
        ElseIf btnRemoveSec.Text = "Cancel" Then
            revertFormSettings()
            generateLevel()
            generateSection()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub dgvLevel_Click(sender As Object, e As EventArgs) Handles dgvLevel.Click
        displayLevelInfo()
        generateSection()
        displaySectionInfo()
    End Sub

    Private Sub dgvSection_Click(sender As Object, e As EventArgs) Handles dgvSection.Click
        displaySectionInfo()
    End Sub
End Class