Public Class FormCourse
    Dim objCourse As New Course
    Dim dsCourse As DataSet

    Private Sub renameColumns()
        With dgvCourse
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "Abbreviation"
            .Columns(2).HeaderCell.Value = "Course/Program"
            .Columns(0).FillWeight = 20
            .Columns(1).FillWeight = 20
            .Columns(2).FillWeight = 60
        End With
    End Sub

    Private Sub enableButtons(ByVal flag As Boolean)
        btnAddCourse.Enabled = flag
        btnEditCourse.Enabled = flag
        btnRemoveCourse.Enabled = flag
    End Sub

    Private Sub displayCourse()
        If dgvCourse.Rows.Count > 0 Then
            txtCourse.Text = dgvCourse.SelectedRows(0).Cells(2).Value.ToString
            txtAbbr.Text = dgvCourse.SelectedRows(0).Cells(1).Value.ToString
        End If
    End Sub

    Private Sub generateCourse()
        Dim sqlSearch As String
        Try
            sqlSearch = "SELECT `studentCourseId`, `studentCourseAbbr`, `studentCourseName` FROM `studentcourse`;"
            Dim ds As DataSet
            dgvCourse.Rows.Clear()
            ds = LibraryDatabase.fetchSQL(sqlSearch)
            If ds.Tables(0).Rows.Count > 0 Then
                dsCourse = ds
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With dgvCourse
                        dgvCourse.Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
                                           ds.Tables(0).Rows(index).Item(1).ToString.Trim, _
                                           ds.Tables(0).Rows(index).Item(2).ToString.Trim)
                    End With
                    index += 1
                End While
                dgvCourse.Refresh()
                dgvCourse.Select()
                displayCourse()
            Else
                Dim sqlInsert As String = "INSERT INTO `studentcourse`(`studentCourseId`, `studentCourseName`, `studentCourseAbbr`) VALUES ('CO00000001','ACCOUNTANCY, BUSINESS AND MANAGEMENT','ABM');" & _
                    "INSERT INTO `studentcourse`(`studentCourseId`, `studentCourseName`, `studentCourseAbbr`) VALUES ('CO00000002','GENERAL ACADEMIC','GAS');" & _
                    "INSERT INTO `studentcourse`(`studentCourseId`, `studentCourseName`, `studentCourseAbbr`) VALUES ('CO00000003','HUMANITIES AND SOCIAL SCIENCES','HUMMS');" & _
                    "INSERT INTO `studentcourse`(`studentCourseId`, `studentCourseName`, `studentCourseAbbr`) VALUES ('CO00000004','SCIENCE, TECHNOLOGY, ENGINEERING AND MATHEMATICS','STEM');"
                LibraryDatabase.execSQL(sqlInsert)
                generateCourse()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub addNewCourse()
        objCourse.StudentCourseId = generateId("studentcourse", "studentCourseId", "CO")
        objCourse.StudentCourseName = txtCourse.Text
        objCourse.StudentCourseAbbr = txtAbbr.Text
        objCourse.addStudentCourse()
    End Sub

    Private Sub formCourse_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub formCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCourse.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        renameColumns()
        generateCourse()
        revertCourseFormSettings()
    End Sub

    Private Sub txtCourse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCourse.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetter(c) Or (c = " ") Or (c = "-") Or (c = ".") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCourse_LostFocus(sender As Object, e As EventArgs) Handles txtCourse.LostFocus
        txtCourse.Text = txtCourse.Text.ToUpper
    End Sub

    Private Sub revertCourseFormSettings()
        txtCourse.Enabled = False
        txtAbbr.Enabled = False
        btnAddCourse.Text = "Add"
        btnEditCourse.Text = "Edit"
        btnRemoveCourse.Text = "Remove"
        btnAddCourse.Visible = True
        enableButtons(True)
        dgvCourse.Enabled = True
    End Sub

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        If btnAddCourse.Text = "Add" Then
            btnEditCourse.Text = "Save"
            btnRemoveCourse.Text = "Cancel"
            btnAddCourse.Enabled = False
            btnAddCourse.Visible = False
            txtCourse.Enabled = True
            txtAbbr.Enabled = True
            dgvCourse.Enabled = False
            txtAbbr.Clear()
            txtCourse.Clear()
            txtCourse.Focus()
        End If
    End Sub

    Private Sub btnEditCourse_Click(sender As Object, e As EventArgs) Handles btnEditCourse.Click
        If btnEditCourse.Text = "Save" Then
            If Not String.IsNullOrWhiteSpace(txtCourse.Text) Then
                If Not String.IsNullOrWhiteSpace(txtAbbr.Text) Then
                    If dgvCourse.Rows.Count > 0 Then
                        If countRecord("SELECT COUNT(*) FROM studentcourse WHERE studentCourseName='" + txtCourse.Text + "';") = 0 Then
                            addNewCourse()
                            MessageBox.Show("You have successfully added a new Course!", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            revertCourseFormSettings()
                            generateCourse()
                        Else
                            MessageBox.Show("A record of the same Course Name already exists!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtCourse.Focus()
                        End If
                    ElseIf dgvCourse.Rows.Count = 0 Then
                        addNewCourse()
                        MessageBox.Show("You have successfully added a new Course!", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        revertCourseFormSettings()
                        generateCourse()
                    End If
                Else
                    MessageBox.Show("Abbreviation field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtAbbr.Focus()
                End If
            Else
                MessageBox.Show("Course Name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCourse.Focus()
            End If
        ElseIf btnEditCourse.Text = "Edit" Then
            If dgvCourse.Rows.Count > 0 Then
                btnEditCourse.Text = "Update"
                btnRemoveCourse.Text = "Cancel"
                btnAddCourse.Enabled = False
                btnAddCourse.Visible = False
                txtCourse.Enabled = True
                txtAbbr.Enabled = True
                dgvCourse.Enabled = False
                txtCourse.Focus()
            End If

        ElseIf btnEditCourse.Text = "Update" Then
            If Not String.IsNullOrWhiteSpace(txtCourse.Text) Then
                If Not String.IsNullOrWhiteSpace(txtAbbr.Text) Then
                    If dgvCourse.Rows.Count > 0 Then
                        If countRecord("SELECT COUNT(*) FROM studentcourse WHERE studentCourseName='" + txtCourse.Text + "' and studentCourseId!='" + dgvCourse.SelectedRows(0).Cells(0).Value.ToString + "';") = 0 Then

                            'update
                            objCourse.StudentCourseId = dgvCourse.SelectedRows(0).Cells(0).Value
                            objCourse.StudentCourseName = txtCourse.Text
                            objCourse.StudentCourseAbbr = txtAbbr.Text
                            objCourse.editStudentCourse()

                            MessageBox.Show("You have successfully updated a course!", "Successfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            revertCourseFormSettings()
                            generateCourse()
                        Else
                            MessageBox.Show("A record of the same Course Name already exists!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtCourse.Focus()
                        End If
                    End If
                Else
                    MessageBox.Show("Abbreviation field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtAbbr.Focus()
                End If
                
            Else
                MessageBox.Show("Course Name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCourse.Focus()
            End If
        End If
    End Sub

    Private Sub btnRemoveCourse_Click(sender As Object, e As EventArgs) Handles btnRemoveCourse.Click
        If btnRemoveCourse.Text = "Cancel" Then
            revertCourseFormSettings()
            generateCourse()
        ElseIf btnRemoveCourse.Text = "Remove" Then
            If dgvCourse.Rows.Count > 0 Then
                Dim ans As Integer
                ans = MsgBox("Are you sure you want to remove '" + txtCourse.Text + "' from the Course list?", MsgBoxStyle.YesNo, "Remove Record")
                If ans = MsgBoxResult.Yes Then
                    objCourse.StudentCourseId = dgvCourse.SelectedRows(0).Cells(0).Value
                    objCourse.deleteStudentCourse()
                    MessageBox.Show("You have successfully deleted " + txtCourse.Text + " from the list.", "Deleted Record")
                    revertCourseFormSettings()
                    generateCourse()
                End If
            End If
        End If
    End Sub

    Private Sub dgvCourse_Click(sender As Object, e As EventArgs) Handles dgvCourse.Click
        displayCourse()
    End Sub

    Private Sub txtAbbr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAbbr.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetter(c) Or (c = " ") Or (c = "-") Or (c = ".") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAbbr_LostFocus(sender As Object, e As EventArgs) Handles txtAbbr.LostFocus
        txtAbbr.Text = txtAbbr.Text.ToUpper
    End Sub

    Private Sub txtAbbr_TextChanged(sender As Object, e As EventArgs) Handles txtAbbr.TextChanged

    End Sub
End Class