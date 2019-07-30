'Public Class FormEmployeePosition
'    Dim objEmployeePosition As New EmployeePosition

'    Private Sub renameColumns()
'        With dgvPosition
'            .RowHeadersVisible = False
'            .Columns(0).HeaderCell.Value = "ID" 'RENAMING COLUMNS
'            .Columns(1).HeaderCell.Value = "Position"
'        End With
'    End Sub

'    Private Sub enableButtons(ByVal flag As Boolean)
'        btnAddPosition.Enabled = flag
'        btnEditPosition.Enabled = flag
'        btnRemovePosition.Enabled = flag
'    End Sub

'    Private Sub displayEmployeePosition()
'        If dgvPosition.Rows.Count > 0 Then
'            txtPosition.Text = dgvPosition.SelectedRows(0).Cells(1).Value.ToString
'        End If
'    End Sub

'    Private Sub generateEmployeePosition()
'        Dim sqlSearch As String
'        Try
'            sqlSearch = "SELECT * FROM `employeeposition`;"
'            Dim ds As DataSet
'            dgvPosition.Rows.Clear()
'            ds = LibraryDatabase.fetchSQL(sqlSearch)
'            If ds.Tables(0).Rows.Count > 0 Then
'                Dim index As Integer = 0
'                While index < ds.Tables(0).Rows.Count
'                    With dgvPosition
'                        dgvPosition.Rows.Add(ds.Tables(0).Rows(index).Item(0).ToString.Trim, _
'                                        ds.Tables(0).Rows(index).Item(1).ToString.Trim)
'                    End With
'                    index += 1
'                End While
'                dgvPosition.Refresh()
'                dgvPosition.Select()
'                displayEmployeePosition()
'            Else
'                Dim sqlInsert As String = "INSERT INTO `employeeposition`(`employeepositionId`, `employeepositionName`) VALUES (0,'N/A');"
'                LibraryDatabase.execSQL(sqlInsert)
'                generateEmployeePosition()
'            End If
'        Catch ex As Exception
'            MsgBox(ex.Message.ToString)
'        End Try
'    End Sub
'    Private Sub addNewEmployeePosition()
'        objEmployeePosition.EmployeePositionId = LibraryDatabase.GenerateID("SELECT MAX(employeepositionId) FROM `employeeposition`;")
'        objEmployeePosition.EmployeePositionName = txtPosition.Text
'        objEmployeePosition.addEmployeePosition()
'    End Sub

'    Private Sub FormEmployeePosition_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
'        Me.DialogResult = Windows.Forms.DialogResult.OK
'    End Sub
'    Private Sub FormEmployeePosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        dgvPosition.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
'        renameColumns()
'        generateEmployeePosition()
'    End Sub

'    Private Sub txtPosition_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPosition.KeyPress
'        Dim c As Char
'        c = e.KeyChar
'        If Not (Char.IsLetter(c) Or (c = " ") Or (c = "-") Or (c = ".") Or Char.IsControl(c)) Then
'            e.Handled = True
'        End If
'    End Sub

'    Private Sub txtPosition_LostFocus(sender As Object, e As EventArgs) Handles txtPosition.LostFocus
'        txtPosition.Text = txtPosition.Text.ToUpper
'    End Sub

'    Private Sub txtPosition_TextChanged(sender As Object, e As EventArgs) Handles txtPosition.TextChanged

'    End Sub

'    Private Sub revertEmployeePositionFormSettings()
'        txtPosition.Enabled = False
'        btnAddPosition.Text = "Add"
'        btnEditPosition.Text = "Edit"
'        btnRemovePosition.Text = "Remove"
'        btnAddPosition.Visible = True
'        enableButtons(True)
'        dgvPosition.Enabled = True
'    End Sub

'    Private Sub btnAddPosition_Click(sender As Object, e As EventArgs) Handles btnAddPosition.Click
'        btnEditPosition.Text = "Save"
'        btnRemovePosition.Text = "Cancel"
'        btnAddPosition.Enabled = False
'        btnAddPosition.Visible = False
'        txtPosition.Enabled = True
'        dgvPosition.Enabled = False
'        txtPosition.Clear()
'        txtPosition.Focus()
'    End Sub

'    Private Sub btnEditPosition_Click(sender As Object, e As EventArgs) Handles btnEditPosition.Click

'        If btnEditPosition.Text = "Save" Then
'            If Not String.IsNullOrWhiteSpace(txtPosition.Text) Then
'                If dgvPosition.Rows.Count > 0 Then
'                    If LibraryDatabase.isExisting("SELECT COUNT(*) FROM employeeposition WHERE employeepositionName='" + txtPosition.Text + "';") = False Then
'                        addNewEmployeePosition()
'                        MessageBox.Show("You have successfully added a new employee position!", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
'                        revertEmployeePositionFormSettings()
'                        generateEmployeePosition()
'                    Else
'                        MessageBox.Show("A record of the same employee position name already exists!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                        txtPosition.Focus()
'                    End If
'                ElseIf dgvPosition.Rows.Count = 0 Then
'                    addNewEmployeePosition()
'                    MessageBox.Show("You have successfully added a new employee position!", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
'                    revertEmployeePositionFormSettings()
'                    generateEmployeePosition()
'                End If
'            Else
'                MessageBox.Show("Employee Position name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                txtPosition.Focus()
'            End If
'        ElseIf btnEditPosition.Text = "Edit" Then
'            If dgvPosition.Rows.Count > 0 Then
'                btnEditPosition.Text = "Update"
'                btnRemovePosition.Text = "Cancel"
'                btnAddPosition.Enabled = False
'                btnAddPosition.Visible = False
'                txtPosition.Enabled = True
'                dgvPosition.Enabled = False
'                txtPosition.Focus()
'            End If

'        ElseIf btnEditPosition.Text = "Update" Then
'            If Not String.IsNullOrWhiteSpace(txtPosition.Text) Then
'                If dgvPosition.Rows.Count > 0 Then
'                    ' `employeepositionId`, `employeepositionName` FROM `employeeposition`
'                    If LibraryDatabase.isExisting("SELECT COUNT(*) FROM employeeposition WHERE employeepositionName='" + txtPosition.Text + "' and employeepositionId!=" + dgvPosition.SelectedRows(0).Cells(0).Value.ToString + ";") = False Then

'                        'update
'                        objEmployeePosition.EmployeePositionId = dgvPosition.SelectedRows(0).Cells(0).Value
'                        objEmployeePosition.EmployeePositionName = txtPosition.Text
'                        objEmployeePosition.editEmployeePosition()

'                        MessageBox.Show("You have successfully updated a employee position!", "Successfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
'                        revertEmployeePositionFormSettings()
'                        generateEmployeePosition()
'                    Else
'                        MessageBox.Show("A record of the same employee position name already exists!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                        txtPosition.Focus()
'                    End If
'                End If
'            Else
'                MessageBox.Show("Employee Position name field is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                txtPosition.Focus()
'            End If
'        End If
'    End Sub

'    Private Sub btnRemovePosition_Click(sender As Object, e As EventArgs) Handles btnRemovePosition.Click
'        If btnRemovePosition.Text = "Cancel" Then
'            revertEmployeePositionFormSettings()
'            generateEmployeePosition()
'        ElseIf btnRemovePosition.Text = "Remove" Then
'            If dgvPosition.Rows.Count > 0 Then
'                Dim ans As Integer
'                ans = MsgBox("Are you sure you want to remove '" + txtPosition.Text + "' from the list?", MsgBoxStyle.YesNo, "Remove Record")
'                If ans = MsgBoxResult.Yes Then
'                    objEmployeePosition.EmployeePositionId = dgvPosition.SelectedRows(0).Cells(0).Value
'                    objEmployeePosition.deleteEmployeePosition()
'                    MessageBox.Show("You have successfully deleted " + txtPosition.Text + " from the list.", "Deleted Record")
'                    revertEmployeePositionFormSettings()
'                    generateEmployeePosition()
'                End If
'            End If
'        End If
'    End Sub

'    Private Sub dgvPosition_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPosition.CellContentClick

'    End Sub

'    Private Sub dgvPosition_Click(sender As Object, e As EventArgs) Handles dgvPosition.Click
'        displayEmployeePosition()
'    End Sub
'End Class