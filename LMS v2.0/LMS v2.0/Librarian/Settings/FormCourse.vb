Public Class FormCourse
    Dim objCourse As New Course
    Dim dsDept As DataSet
    Dim dsCourse As DataSet
    Dim objFormDepartment As New FormDepartment

    Private Sub renameColumns()
        With dgvCourse
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "Course/Program"
            .Columns(2).HeaderCell.Value = "Department"
            .Columns(0).FillWeight = 10
            .Columns(1).FillWeight = 45
            .Columns(2).FillWeight = 45
        End With
    End Sub

    Private Sub enableButtons(ByVal flag As Boolean)
        btnAddCourse.Enabled = flag
        btnEditCourse.Enabled = flag
        btnRemoveCourse.Enabled = flag
    End Sub

    Private Sub displayCourse()
        If dgvCourse.Rows.Count > 0 Then
            txtCourse.Text = dgvCourse.SelectedRows(0).Cells(1).Value.ToString
            Dim index As Integer = 0
            Dim index2 As Integer = 0
            Dim idDept As Integer = 0 'just in case
            While index < dsCourse.Tables(0).Rows.Count
                If dsCourse.Tables(0).Rows(index).Item(0).ToString = dgvCourse.SelectedRows(0).Cells(0).Value.ToString Then
                    idDept = dsCourse.Tables(0).Rows(index).Item(2)
                    Exit While
                End If
                index += 1
            End While
            If Not idDept = 0 Then
                While index2 < dsDept.Tables(0).Rows.Count
                    If idDept = dsDept.Tables(0).Rows(index2).Item(0) Then
                        cboDepartment.SelectedIndex = index2
                        Exit While
                    End If
                    index2 += 1
                End While
            End If
        End If
    End Sub

    Private Sub generateDepartment()
        Dim sqlSearch As String
        Try
            sqlSearch = "SELECT `departmentId`, `departmentName`, `departmentLevel` FROM `department`;"
            Dim ds As DataSet
            ds = LibraryDatabase.fetchSQL(sqlSearch)
            dsDept = ds
            If ds.Tables(0).Rows.Count > 0 Then
                cboDepartment.Items.Clear()
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With cboDepartment
                        .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                    End With
                    index += 1
                End While
                cboDepartment.Refresh()
                cboDepartment.SelectedIndex = 0
            Else
                Dim sqlInsert As String
                sqlInsert = "INSERT INTO `department`(`departmentId`, `departmentName`, `departmentLevel`) VALUES (1,'ELEMENTARY','ELEM');" & _
                    "INSERT INTO `department`(`departmentId`, `departmentName`, `departmentLevel`) VALUES (2,'JUNIOR HIGH','JH');"
                LibraryDatabase.execSQL(sqlInsert)
                generateDepartment()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub generateCourse()
        Dim sqlSearch As String
        Try
            sqlSearch = "SELECT DISTINCT `studentCourseId`, `studentCourseName`, `studentCourseDeptId`, `departmentName` " & _
                "FROM `studentcourse` JOIN `department` ON `studentCourseDeptId`=`departmentId` ORDER BY studentCourseId ASC ;"
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
                                           ds.Tables(0).Rows(index).Item(3).ToString.Trim)
                    End With
                    index += 1
                End While
                dgvCourse.Refresh()
                dgvCourse.Select()
                displayCourse()
            Else
                dgvCourse.Rows.Clear()
                txtCourse.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub addNewCourse()
        objCourse.StudentCourseId = LibraryDatabase.GenerateID("SELECT MAX(studentCourseId) FROM `studentcourse`;")
        objCourse.StudentCourseName = txtCourse.Text
        objCourse.StudentCourseDeptId = dsDept.Tables(0).Rows(cboDepartment.SelectedIndex).Item(0)
        objCourse.addStudentCourse()
    End Sub

    Private Sub formCourse_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub formCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCourse.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        generateDepartment()
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
        btnAddCourse.Text = "Add"
        btnEditCourse.Text = "Edit"
        btnRemoveCourse.Text = "Remove"
        btnAddCourse.Visible = True
        enableButtons(True)
        dgvCourse.Enabled = True
        pnlDept.Enabled = False
    End Sub

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        If btnAddCourse.Text = "Add" Then
            btnEditCourse.Text = "Save"
            btnRemoveCourse.Text = "Cancel"
            btnAddCourse.Enabled = False
            btnAddCourse.Visible = False
            txtCourse.Enabled = True
            dgvCourse.Enabled = False
            generateDepartment()
            pnlDept.Enabled = True
            txtCourse.Clear()
            txtCourse.Focus()
        End If
    End Sub

    Private Sub btnEditCourse_Click(sender As Object, e As EventArgs) Handles btnEditCourse.Click
        If btnEditCourse.Text = "Save" Then
            If Not String.IsNullOrWhiteSpace(txtCourse.Text) Then
                If dgvCourse.Rows.Count > 0 Then
                    If LibraryDatabase.isExisting("SELECT COUNT(*) FROM studentcourse WHERE studentCourseName='" + txtCourse.Text + "';") = False Then
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
                pnlDept.Enabled = True
                dgvCourse.Enabled = False
                txtCourse.Focus()
            End If

        ElseIf btnEditCourse.Text = "Update" Then
            If Not String.IsNullOrWhiteSpace(txtCourse.Text) Then
                If dgvCourse.Rows.Count > 0 Then
                    If LibraryDatabase.isExisting("SELECT COUNT(*) FROM studentcourse WHERE studentCourseName='" + txtCourse.Text + "' and studentCourseId!=" + dgvCourse.SelectedRows(0).Cells(0).Value.ToString + ";") = False Then

                        'update
                        objCourse.StudentCourseId = dgvCourse.SelectedRows(0).Cells(0).Value
                        objCourse.StudentCourseName = txtCourse.Text
                        objCourse.StudentCourseDeptId = dsDept.Tables(0).Rows(cboDepartment.SelectedIndex).Item(0)
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

    Private Sub btnDept_Click(sender As Object, e As EventArgs) Handles btnDept.Click
        objFormDepartment = New FormDepartment
        If objFormDepartment.ShowDialog() = Windows.Forms.DialogResult.OK Then
            generateDepartment()
        End If
    End Sub
End Class