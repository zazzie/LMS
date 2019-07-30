'Public Class FormDepartment
'    Dim deptObj As New Department

'    Private Sub renameColumns()
'        With dgvDepartment
'            .RowHeadersVisible = False
'            .Columns(0).HeaderCell.Value = "ID" 'RENAMING COLUMNS
'            .Columns(1).HeaderCell.Value = "Department"
'            .Columns(2).HeaderCell.Value = "Level"
'        End With
'    End Sub
'    Private Sub enableButtons(ByVal flag As Boolean)
'        btnAddDepartment.Enabled = flag
'        btnEditDepartment.Enabled = flag
'        btnRemoveDepartment.Enabled = flag
'    End Sub
'    Private Sub displayDepartment()
'        If dgvDepartment.Rows.Count > 0 Then
'            txtDepartment.Text = dgvDepartment.SelectedRows(0).Cells(1).Value.ToString
'            If dgvDepartment.SelectedRows(0).Cells(2).Value.ToString = "COLLEGE" Then
'                rbtCol.Checked = True
'            ElseIf dgvDepartment.SelectedRows(0).Cells(2).Value.ToString = "SENIOR HIGH" Then
'                rbtSH.Checked = True
'            ElseIf dgvDepartment.SelectedRows(0).Cells(2).Value.ToString = "JUNIOR HIGH" Then
'                rbtJH.Checked = True
'            ElseIf dgvDepartment.SelectedRows(0).Cells(2).Value.ToString = "ELEMENTARY" Then
'                rbtElem.Checked = True
'            End If
'        End If
'    End Sub
'    Private Sub generateDepartment()
'        Dim sqlSearch As String
'        Try
'            sqlSearch = "SELECT `departmentId`, `departmentName`, `departmentLevel` FROM `department` ORDER BY `departmentLevel` ASC;"
'            Dim ds As DataSet
'            dgvDepartment.Rows.Clear()
'            ds = LibraryDatabase.fetchSQL(sqlSearch)
'            If ds.Tables(0).Rows.Count > 0 Then
'                Dim index As Integer = 0
'                While index < ds.Tables(0).Rows.Count
'                    With dgvDepartment
'                        Dim level As String = ""
'                        If ds.Tables(0).Rows(index).Item(2).ToString.Trim = "COL" Then
'                            level = "COLLEGE"
'                        ElseIf ds.Tables(0).Rows(index).Item(2).ToString.Trim = "SH" Then
'                            level = "SENIOR HIGH"
'                        ElseIf ds.Tables(0).Rows(index).Item(2).ToString.Trim = "JH" Then
'                            level = "JUNIOR HIGH"
'                        ElseIf ds.Tables(0).Rows(index).Item(2).ToString.Trim = "ELEM" Then
'                            level = "ELEMENTARY"
'                        End If
'                        dgvDepartment.Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
'                                               ds.Tables(0).Rows(index).Item(1).ToString.Trim, _
'                                               level)
'                    End With
'                    index += 1
'                End While
'                dgvDepartment.Refresh()
'                dgvDepartment.Select()
'                displayDepartment()
'            Else
'                Try
'                    Dim sqlInsert As String
'                    sqlInsert = "INSERT INTO `department`(`departmentId`, `departmentName`, `departmentLevel`) VALUES (1,'ELEMENTARY','ELEM');" & _
'                        "INSERT INTO `department`(`departmentId`, `departmentName`, `departmentLevel`) VALUES (2,'JUNIOR HIGH','JH');"
'                    LibraryDatabase.execSQL(sqlInsert)
'                    generateDepartment()
'                Catch ex As Exception
'                    MsgBox(ex.Message.ToString)
'                End Try
'            End If
'        Catch ex As Exception
'            MsgBox(ex.Message.ToString)
'            dgvDepartment.Rows.Clear()
'            txtDepartment.Clear()
'        End Try
'    End Sub
'    Private Sub addNewDepartment()
'        deptObj.DepartmentId = LibraryDatabase.GenerateID("select max(departmentId) from department;")
'        deptObj.DepartmentName = txtDepartment.Text
'        If rbtCol.Checked = True Then
'            deptObj.DepartmentLevel = "COL"
'        ElseIf rbtSH.Checked = True Then
'            deptObj.DepartmentLevel = "SH"
'        ElseIf rbtJH.Checked = True Then
'            deptObj.DepartmentLevel = "JH"
'        ElseIf rbtElem.Checked = True Then
'            deptObj.DepartmentLevel = "ELEM"
'        End If

'        deptObj.addDepartment()
'    End Sub
'    Private Sub txtDepartment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDepartment.KeyPress
'        Dim c As Char
'        c = e.KeyChar
'        If Not (Char.IsLetterOrDigit(c) Or (c = " ") Or (c = "-") Or (c = ",") Or (c = "(") Or (c = "/") Or (c = ")") Or Char.IsControl(c)) Then
'            e.Handled = True
'        End If
'    End Sub

'    Private Sub txtDepartment_LostFocus(sender As Object, e As EventArgs) Handles txtDepartment.LostFocus
'        txtDepartment.Text = txtDepartment.Text.ToUpper
'    End Sub

'    Private Sub revertDepartmentFormSettings()
'        txtDepartment.Enabled = False
'        pnlLevel.Enabled = False
'        btnAddDepartment.Text = "Add"
'        btnEditDepartment.Text = "Edit"
'        btnRemoveDepartment.Text = "Remove"
'        btnAddDepartment.Visible = True
'        'btnEditDepartment.Visible = True
'        'btnRemoveDepartment.Visible = True
'        enableButtons(True)
'        dgvDepartment.Enabled = True
'    End Sub

'    Private Sub formDepartment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
'        Me.DialogResult = Windows.Forms.DialogResult.OK
'    End Sub

'    Private Sub formDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        dgvDepartment.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
'        renameColumns()
'        generateDepartment()
'    End Sub

'    Private Sub btnAddDepartment_Click(sender As Object, e As EventArgs) Handles btnAddDepartment.Click
'        If btnAddDepartment.Text = "Add" Then
'            btnEditDepartment.Text = "Save"
'            btnRemoveDepartment.Text = "Cancel"
'            btnAddDepartment.Enabled = False
'            btnAddDepartment.Visible = False
'            txtDepartment.Enabled = True
'            pnlLevel.Enabled = True
'            dgvDepartment.Enabled = False
'            txtDepartment.Clear()
'            txtDepartment.Focus()
'        End If
'    End Sub

'    Private Sub btnRemoveDepartment_Click(sender As Object, e As EventArgs) Handles btnRemoveDepartment.Click
'        If btnRemoveDepartment.Text = "Cancel" Then
'            revertDepartmentFormSettings()
'            generateDepartment()
'        ElseIf btnRemoveDepartment.Text = "Remove" Then
'            If dgvDepartment.Rows.Count > 0 Then
'                Dim ans As Integer
'                ans = MsgBox("Are you sure you want to remove '" + txtDepartment.Text + "' from the Department list?", MsgBoxStyle.YesNo, "Remove Department")
'                If ans = MsgBoxResult.Yes Then
'                    deptObj.DepartmentId = dgvDepartment.SelectedRows(0).Cells(0).Value
'                    deptObj.deleteDepartment()
'                    MessageBox.Show("You have successfully deleted " + txtDepartment.Text + " from the list.", "Deleted Record")
'                    revertDepartmentFormSettings()
'                    generateDepartment()
'                End If
'            End If
'        End If
'    End Sub

'    Private Sub btnEditDepartment_Click(sender As Object, e As EventArgs) Handles btnEditDepartment.Click
'        If btnEditDepartment.Text = "Save" Then
'            If Not String.IsNullOrWhiteSpace(txtDepartment.Text) Then
'                If dgvDepartment.Rows.Count > 0 Then
'                    If LibraryDatabase.isExisting("SELECT COUNT(*) FROM department WHERE departmentName='" + txtDepartment.Text + "';") = False Then
'                        addNewDepartment()
'                        MessageBox.Show("You have successfully added a new Department!", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
'                        revertDepartmentFormSettings()
'                        generateDepartment()
'                    Else
'                        MessageBox.Show("A record of the same Department Name already exists!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                        txtDepartment.Focus()
'                    End If
'                ElseIf dgvDepartment.Rows.Count = 0 Then
'                    addNewDepartment()
'                    MessageBox.Show("You have successfully added a new Department!", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
'                    revertDepartmentFormSettings()
'                    generateDepartment()
'                End If
'            Else
'                MessageBox.Show("Department Name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                txtDepartment.Focus()
'            End If
'        ElseIf btnEditDepartment.Text = "Edit" Then
'            If dgvDepartment.Rows.Count > 0 Then
'                btnEditDepartment.Text = "Update"
'                btnRemoveDepartment.Text = "Cancel"
'                btnAddDepartment.Enabled = False
'                btnAddDepartment.Visible = False
'                txtDepartment.Enabled = True
'                pnlLevel.Enabled = True
'                dgvDepartment.Enabled = False
'                txtDepartment.Focus()
'            End If

'        ElseIf btnEditDepartment.Text = "Update" Then
'            If Not String.IsNullOrWhiteSpace(txtDepartment.Text) Then
'                If dgvDepartment.Rows.Count > 0 Then
'                    If LibraryDatabase.isExisting("SELECT COUNT(*) FROM department WHERE departmentName='" + txtDepartment.Text + "' and departmentId!=" + dgvDepartment.SelectedRows(0).Cells(0).Value.ToString + ";") = False Then

'                        'update
'                        deptObj.DepartmentId = dgvDepartment.SelectedRows(0).Cells(0).Value
'                        deptObj.DepartmentName = txtDepartment.Text
'                        If rbtCol.Checked = True Then
'                            deptObj.DepartmentLevel = "COL"
'                        ElseIf rbtSH.Checked = True Then
'                            deptObj.DepartmentLevel = "SH"
'                        ElseIf rbtJH.Checked = True Then
'                            deptObj.DepartmentLevel = "JH"
'                        ElseIf rbtElem.Checked = True Then
'                            deptObj.DepartmentLevel = "ELEM"
'                        End If

'                        deptObj.editDepartment()

'                        MessageBox.Show("You have successfully updated a department!", "Successfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
'                        revertDepartmentFormSettings()
'                        generateDepartment()
'                    Else
'                        MessageBox.Show("A record of the same Department Name already exists!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                        txtDepartment.Focus()
'                    End If
'                End If
'            Else
'                MessageBox.Show("Department Name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                txtDepartment.Focus()
'            End If
'        End If
'    End Sub

'    Private Sub dgvDepartment_Click(sender As Object, e As EventArgs) Handles dgvDepartment.Click
'        displayDepartment()
'    End Sub

'    Private Sub txtDepartment_TextChanged(sender As Object, e As EventArgs) Handles txtDepartment.TextChanged

'    End Sub
'End Class