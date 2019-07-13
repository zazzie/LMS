Public Class FormAddItemQuantity
    Public DsQuantityList As DataSet
    Public DsNewQuantityList As DataSet
    Dim dateToday As DateTime = DateTime.Now

    Private Sub initializeDsCopy()
        'initialize to empty
        Try
            Dim sqlSearch As String
            sqlSearch = "SELECT `libraryItemUnitId`, " & _
                "`libraryItemUnitAquisition`, `libraryItemUnitPrice`, `libraryItemUnitStatus`, `libraryItemUnitDateAdded` " & _
                "FROM `libraryitemunit` WHERE libraryItemUnitItemId=0;"
            DsNewQuantityList = LibraryDatabase.fetchSQL(sqlSearch)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Dispose()
    End Sub

    Private Sub checkRBTs()
        If rbtSingleQuantity.Checked = True Then
            lblDash.Visible = False
            txtID2.Visible = False
            lblNumberCopy.Text = "(Quantity: 1)"
            lblNumberCopy.ForeColor = Color.Black
            txtID1.Focus()
        ElseIf rbtMultiQuantity.Checked = True Then
            lblDash.Visible = True
            txtID2.Visible = True
            'txtAccession1.Focus()
            If Val(txtID2.Text) < Val(txtID1.Text) Or Val(txtID2.Text) = Val(txtID1.Text) Then
                lblNumberCopy.Text = "(INVALID UNIT ORDER)"
                lblNumberCopy.ForeColor = Color.Red
            Else
                lblNumberCopy.Text = "(Quantity: " + ((Val(txtID2.Text) - Val(txtID1.Text)) + 1).ToString + ")"
                lblNumberCopy.ForeColor = Color.Black
            End If
        End If
    End Sub

    Private Sub FormAddItemQuantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboAquisition.Text = "BOUGHT BY SCHOOL"
        rbtSingleQuantity.Checked = True
        checkRBTs()
        initializeDsCopy()
        txtPrice.Text = "0.00"
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


    Private Sub rbtSingleQuantity_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSingleQuantity.CheckedChanged
        checkRBTs()
    End Sub

    Private Sub rbtMultiQuantity_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMultiQuantity.CheckedChanged
        checkRBTs()
    End Sub

    Private Sub txtID1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID1.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID1_TextChanged(sender As Object, e As EventArgs) Handles txtID1.TextChanged
        checkRBTs()
    End Sub

    Private Sub txtID2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID2.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID2_TextChanged(sender As Object, e As EventArgs) Handles txtID2.TextChanged
        checkRBTs()
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

    '"SELECT `libraryItemUnitId`, ``, ``, " & _
    '"`libraryItemUnitAquisition`, `libraryItemUnitPrice`, `libraryItemUnitStatus`, `libraryItemUnitDateAdded` " & _
    '"FROM `libraryitemunit` WHERE libraryItemUnitItemId=0;"

    Private Sub btnAddQuantity_Click(sender As Object, e As EventArgs) Handles btnAddQuantity.Click
        If rbtSingleQuantity.Checked = True Then
            If String.IsNullOrWhiteSpace(txtID1.Text) = False Then
                If DsQuantityList.Tables(0).Rows.Count > 0 Then
                    Dim countExist As Integer = 0
                    Dim index As Integer = 0
                    While index < DsQuantityList.Tables(0).Rows.Count
                        If txtID1.Text = DsQuantityList.Tables(0).Rows(index).Item(0).ToString.Trim Then
                            countExist += 1
                        End If
                        index += 1
                    End While
                    If countExist = 0 Then
                        'MsgBox(countExist.ToString)
                        Dim row As DataRow
                        row = DsNewQuantityList.Tables(0).NewRow
                        row.Item(0) = txtID1.Text
                        row.Item(1) = cboAquisition.Text
                        row.Item(2) = txtPrice.Text
                        row.Item(3) = "IN"
                        row.Item(4) = dateToday.ToString("d")
                        DsNewQuantityList.Tables(0).Rows.Add(row)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Else
                        'MsgBox(countExist.ToString)
                        MessageBox.Show("Unit ID: " + txtID1.Text + " is already listed in the item unit list.", "Already Listed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtID1.Focus()
                    End If
                Else 'add this if empty table
                    Dim row As DataRow
                    row = DsNewQuantityList.Tables(0).NewRow
                    row.Item(0) = txtID1.Text
                    row.Item(1) = cboAquisition.Text
                    row.Item(2) = txtPrice.Text
                    row.Item(3) = "IN"
                    row.Item(4) = dateToday.ToString("d")
                    DsNewQuantityList.Tables(0).Rows.Add(row)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            Else
                MessageBox.Show("Please enter a valid Unit ID number.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtID1.Focus()
            End If

        ElseIf rbtMultiQuantity.Checked = True Then
            If String.IsNullOrWhiteSpace(txtID1.Text) = False Then
                If String.IsNullOrWhiteSpace(txtID2.Text) = False Then
                    If Not lblNumberCopy.Text = "(INVALID UNIT ORDER)" Or Val(txtID1.Text) >= Val(txtID2.Text) Then

                        If DsQuantityList.Tables(0).Rows.Count > 0 Then
                            Dim countExist As Integer = 0
                            Dim index As Integer = 0
                            Dim min As Integer = Val(txtID1.Text)
                            Dim index2 As Integer = min
                            Dim max As Integer = Val(txtID2.Text)
                            Dim existing As String = ""
                            While index < DsQuantityList.Tables(0).Rows.Count
                                While index2 <= max
                                    If index2.ToString = DsQuantityList.Tables(0).Rows(index).Item(0).ToString.Trim Then
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
                                Dim itemNumber As Integer = min
                                Dim row As DataRow
                                While itemNumber <= max

                                    row = DsNewQuantityList.Tables(0).NewRow
                                    row.Item(0) = itemNumber.ToString
                                    row.Item(1) = cboAquisition.Text
                                    row.Item(2) = txtPrice.Text
                                    row.Item(3) = "IN"
                                    row.Item(4) = dateToday.ToString("d")
                                    DsNewQuantityList.Tables(0).Rows.Add(row)
                                    itemNumber += 1
                                End While
                                Me.DialogResult = Windows.Forms.DialogResult.OK
                            ElseIf countExist = 1 Then
                                MessageBox.Show("Unit ID number: " + existing + " is already listed in the item unit list.", "Already Listed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtID1.Focus()
                            ElseIf countExist > 1 Then
                                MessageBox.Show("Unit ID numbers: " + existing + " are already listed in the item unit list.", "Already Listed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                txtID1.Focus()
                            End If
                        Else 'add this if empty table
                            Dim itemNumber As Integer = Val(txtID1.Text)
                            Dim max As Integer = Val(txtID2.Text)
                            Dim row As DataRow
                            While itemNumber <= max

                                row = DsNewQuantityList.Tables(0).NewRow
                                row.Item(0) = itemNumber.ToString
                                row.Item(1) = cboAquisition.Text
                                row.Item(2) = txtPrice.Text
                                row.Item(3) = "IN"
                                row.Item(4) = dateToday.ToString("d")
                                DsNewQuantityList.Tables(0).Rows.Add(row)
                                itemNumber += 1
                            End While
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        End If
                    Else
                        MessageBox.Show("Please enter a valid item unit order. It must start from lower to higher unit number.", "Invalid Unit Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtID1.Focus()
                    End If
                Else
                    MessageBox.Show("Please enter a valid unit ID number.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtID2.Focus()
                End If
            Else
                MessageBox.Show("Please enter a valid unit ID number.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtID1.Focus()
            End If
        End If
    End Sub
End Class