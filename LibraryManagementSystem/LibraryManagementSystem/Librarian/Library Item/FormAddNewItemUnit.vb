'Public Class FormAddNewItemUnit
'    Dim existIDs As String = ""
'    Dim dateToday As DateTime = DateTime.Now
'    Dim objItemUnit As New LibraryItemUnit
'    Private _itemId As Integer

'    Public Property ItemId()
'        Get
'            Return _itemId
'        End Get
'        Set(value)
'            _itemId = value
'        End Set
'    End Property

'    Private Sub checkRBTs()
'        If rbtSingleQuantity.Checked = True Then
'            lblDash.Visible = False
'            txtID2.Visible = False
'            lblNumberCopy.Text = "(Quantity: 1)"
'            lblNumberCopy.ForeColor = Color.Black
'            txtID1.Focus()
'        ElseIf rbtMultiQuantity.Checked = True Then
'            lblDash.Visible = True
'            txtID2.Visible = True
'            'txtAccession1.Focus()
'            If Val(txtID2.Text) < Val(txtID1.Text) Or Val(txtID2.Text) = Val(txtID1.Text) Then
'                lblNumberCopy.Text = "(INVALID ITEM ORDER)"
'                lblNumberCopy.ForeColor = Color.Red
'            Else
'                lblNumberCopy.Text = "(Quantity: " + ((Val(txtID2.Text) - Val(txtID1.Text)) + 1).ToString + ")"
'                lblNumberCopy.ForeColor = Color.Black
'            End If
'        End If
'    End Sub

'    Private Sub FormAddNewItemUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        cboAquisition.Text = "BOUGHT BY SCHOOL"
'        rbtSingleQuantity.Checked = True
'        checkRBTs()
'        txtPrice.Text = "0.00"
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

'    Private Sub rbtSingleQuantity_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSingleQuantity.CheckedChanged
'        checkRBTs()
'    End Sub

'    Private Sub rbtMultiQuantity_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMultiQuantity.CheckedChanged
'        checkRBTs()
'    End Sub

'    Private Sub txtID1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID1.KeyPress
'        Dim c As Char
'        c = e.KeyChar
'        If Not (Char.IsDigit(c) Or Char.IsControl(c)) Then
'            e.Handled = True
'        End If
'    End Sub

'    Private Sub txtID1_TextChanged(sender As Object, e As EventArgs) Handles txtID1.TextChanged
'        checkRBTs()
'    End Sub

'    Private Sub txtID2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID2.KeyPress
'        Dim c As Char
'        c = e.KeyChar
'        If Not (Char.IsDigit(c) Or Char.IsControl(c)) Then
'            e.Handled = True
'        End If
'    End Sub

'    Private Sub txtID2_TextChanged(sender As Object, e As EventArgs) Handles txtID2.TextChanged
'        checkRBTs()
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

'    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
'        Me.DialogResult = Windows.Forms.DialogResult.Cancel
'        Me.Dispose()
'    End Sub

'    Private Function countExisting(itemUnitId As Integer) As Integer
'        Dim count As Integer = 0
'        Dim sqlCount As String = "SELECT COUNT(*) FROM `libraryitemunit` WHERE libraryItemUnitId=" + itemUnitId.ToString + ";"
'        count = countRecord(sqlCount)
'        Return count
'    End Function

'    Private Function countExisting(itemUnitId1 As Integer, itemUnitId2 As Integer) As Integer
'        existIDs = ""
'        Dim index As Integer = 0
'        Dim count As Integer = 0
'        Dim min As Integer = itemUnitId1
'        Dim maxIndex As Integer = (itemUnitId2 - itemUnitId1) + 1
'        Dim countString As String = ""
'        Dim sqlCount As String
'        While index < maxIndex
'            sqlCount = "SELECT COUNT(*) FROM `libraryitemunit` WHERE libraryItemUnitId=" + min.ToString + ";"
'            If countRecord(sqlCount) = 1 Then
'                count += 1
'                If count > 1 Then
'                    countString += ", "
'                End If
'                countString += min.ToString
'            End If
'            index += 1
'            min += 1
'        End While
'        existIDs = countString

'        Return count

'    End Function

'    Private Sub btnAddQuantity_Click(sender As Object, e As EventArgs) Handles btnAddQuantity.Click
'        If rbtSingleQuantity.Checked = True Then
'            If String.IsNullOrWhiteSpace(txtID1.Text) = False Then
'                Dim count As Integer = countExisting(Val(txtID1.Text))
'                If count = 0 Then
'                    objItemUnit = New LibraryItemUnit
'                    objItemUnit.LibraryItemUnitId = txtID1.Text
'                    objItemUnit.LibraryItemUnitItemId = ItemId.ToString
'                    objItemUnit.LibraryItemUnitStatus = "IN"
'                    objItemUnit.LibraryItemUnitQuality = "EXCELLENT" 'must fix
'                    objItemUnit.LibraryItemUnitAquisition = cboAquisition.Text
'                    If cboAquisition.Text = "BOUGHT BY SCHOOL" Then
'                        objItemUnit.LibraryItemUnitPrice = txtPrice.Text
'                    End If
'                    objItemUnit.LibraryItemUnitDateAdded = dateToday.ToString("d")
'                    objItemUnit.addLibraryItemUnit()
'                    MessageBox.Show("You have successfully added another unit.", "Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
'                    Me.DialogResult = Windows.Forms.DialogResult.OK
'                ElseIf count = 1 Then
'                    MessageBox.Show("Unit ID number: " + txtID1.Text + " already exists in the database.", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                    txtID1.Focus()
'                End If
'            Else
'                MessageBox.Show("Please enter a valid Unit ID number.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                txtID1.Focus()
'            End If

'        ElseIf rbtMultiQuantity.Checked = True Then
'            If String.IsNullOrWhiteSpace(txtID1.Text) = False Then
'                If String.IsNullOrWhiteSpace(txtID2.Text) = False Then
'                    If Not lblNumberCopy.Text = "(INVALID UNIT ORDER)" Or Val(txtID1.Text) >= Val(txtID2.Text) Then
'                        Dim count As Integer = countExisting(Val(txtID1.Text), Val(txtID2.Text))
'                        If count = 0 Then
'                            Dim index As Integer = 0
'                            Dim max As Integer = (Val(txtID2.Text) - Val(txtID1.Text)) + 1
'                            Dim sqlAddUnit As String = ""
'                            Dim unitIdNumber As Integer = Val(txtID1.Text)
'                            While index < max
'                                objItemUnit = New LibraryItemUnit
'                                objItemUnit.LibraryItemUnitId = unitIdNumber.ToString
'                                objItemUnit.LibraryItemUnitItemId = ItemId.ToString
'                                objItemUnit.LibraryItemUnitStatus = "IN"
'                                objItemUnit.LibraryItemUnitQuality = "EXCELLENT" 'must fix
'                                objItemUnit.LibraryItemUnitAquisition = cboAquisition.Text
'                                If cboAquisition.Text = "BOUGHT BY SCHOOL" Then
'                                    objItemUnit.LibraryItemUnitPrice = txtPrice.Text
'                                End If
'                                objItemUnit.LibraryItemUnitDateAdded = dateToday.ToString("d")

'                                sqlAddUnit += "INSERT INTO `libraryitemunit`(`libraryItemUnitId`, `libraryItemUnitItemId`, `libraryItemUnitQuality`, `libraryItemUnitAquisition`, `libraryItemUnitPrice`, `libraryItemUnitStatus`, `libraryItemUnitDateAdded`) VALUES (" & _
'                                                objItemUnit.LibraryItemUnitId.ToString + "," & _
'                                                objItemUnit.LibraryItemUnitItemId.ToString + ",'" & _
'                                                objItemUnit.LibraryItemUnitQuality + "','" & _
'                                                objItemUnit.LibraryItemUnitAquisition + "','" & _
'                                                objItemUnit.LibraryItemUnitPrice + "','" & _
'                                                objItemUnit.LibraryItemUnitStatus + "','" & _
'                                                objItemUnit.LibraryItemUnitDateAdded + "');"
'                                index += 1
'                                unitIdNumber += 1
'                            End While

'                            LibraryDatabase.execSQL(sqlAddUnit)
'                            MessageBox.Show("You have successfully added new unit.", "Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
'                            Me.DialogResult = Windows.Forms.DialogResult.OK

'                        ElseIf count = 1 Then
'                            MessageBox.Show("Unit ID number: " + existIDs + " already exists in the database.", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                            txtID1.Focus()
'                        ElseIf count > 1 Then
'                            MessageBox.Show("Unit ID numbers: " + existIDs + " already exist in the database.", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                            txtID1.Focus()
'                        End If
'                    Else
'                        MessageBox.Show("Please enter a valid item unit order. It must start from lower to higher unit number.", "Invalid Unit Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                        txtID1.Focus()
'                    End If
'                Else
'                    MessageBox.Show("Please enter a valid unit ID number.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                    txtID2.Focus()
'                End If
'            Else
'                MessageBox.Show("Please enter a valid unit ID number.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                txtID1.Focus()
'            End If
'        End If
'    End Sub
'End Class