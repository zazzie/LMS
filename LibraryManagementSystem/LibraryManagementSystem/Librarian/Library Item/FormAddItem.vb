'Public Class FormAddItem
'    Dim objItem As New LibraryItem
'    Dim objItemUnit As New LibraryItemUnit
'    Dim objFormAddItemQuantity As New FormAddItemQuantity
'    Dim objFormEditItemQuantity As New FormEditItemQuantity
'    Dim objFormItemType As New FormItemType
'    Public DsItemUnitList As DataSet
'    Dim dsItemType As DataSet

'    Private Sub renameColumns()
'        With dgvItemQuantity
'            .RowHeadersVisible = False
'            .Columns(0).HeaderCell.Value = "ID" 'RENAMING COLUMNS
'            .Columns(1).HeaderCell.Value = "Aquisition"
'            .Columns(2).HeaderCell.Value = "Price"
'            .Columns(3).HeaderCell.Value = "Status"
'            .Columns(4).HeaderCell.Value = "Date Added"
'        End With
'    End Sub

'    Private Sub initializeDsItemUnitList()
'        'initialize to empty
'        Try
'            Dim sqlSearch As String
'            sqlSearch = "SELECT `libraryItemUnitId`, " & _
'                "`libraryItemUnitAquisition`, `libraryItemUnitPrice`, `libraryItemUnitStatus`, `libraryItemUnitDateAdded` " & _
'                "FROM `libraryitemunit` WHERE libraryItemUnitItemId=0;"
'            DsItemUnitList = LibraryDatabase.fetchSQL(sqlSearch)
'        Catch ex As Exception
'            MsgBox(ex.Message.ToString)
'        End Try
'    End Sub

'    Private Sub generateItemType()
'        Try
'            Dim ds As New DataSet
'            ds = LibraryDatabase.fetchSQL("SELECT * FROM `itemtype` ORDER BY itemTypeName;")
'            cboItemType.Items.Clear()
'            If ds.Tables(0).Rows.Count > 0 Then
'                dsItemType = ds
'                Dim index As Integer = 0
'                While index < ds.Tables(0).Rows.Count
'                    With cboItemType
'                        .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
'                    End With
'                    index += 1
'                End While
'                cboItemType.Refresh()
'                cboItemType.SelectedIndex = 0
'            Else
'                Dim sqlInsert As String = "INSERT INTO `itemtype`(`itemTypeId`, `itemTypeName`) VALUES (0,'UNDEFINED');"
'                LibraryDatabase.execSQL(sqlInsert)
'                generateItemType()
'            End If
'        Catch ex As Exception
'            MsgBox(ex.Message.ToString)
'        End Try
'    End Sub

'    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
'        Dim ans As Integer
'        ans = MsgBox("There are unsaved information. Do you want to exit without saving?", MsgBoxStyle.YesNo, "Unsaved Information")
'        If ans = MsgBoxResult.Yes Then
'            Me.DialogResult = Windows.Forms.DialogResult.Cancel
'            Me.Dispose()
'        End If
'    End Sub

'    Private Sub FormAddItem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
'        Me.Dispose()
'    End Sub

'    Private Sub FormAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        dgvItemQuantity.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
'        txtItemId.Text = LibraryDatabase.GenerateID("SELECT MAX(libraryItemId) FROM libraryitem;")
'        renameColumns()
'        generateItemType()
'        initializeDsItemUnitList()
'        cboBorrowType.Text = "FOR INSIDE USE ONLY"
'        txtItemName.Focus()
'    End Sub

'    Private Sub txtItemName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemName.KeyPress
'        Dim c As Char
'        c = e.KeyChar
'        If Not (Char.IsLetterOrDigit(c) Or (c = " ") Or (c = "-") Or (c = ".") Or (c = "!") Or (c = "?") Or (c = "`") Or (c = ":") Or (c = ",") Or (c = "@") Or (c = "#") Or (c = "$") Or (c = "&") Or (c = "/") Or (c = "\") Or (c = ">") Or (c = "<") Or (c = "(") Or (c = ")") Or (c = "_") Or (c = "=") Or (c = "+") Or (c = "*") Or Char.IsControl(c)) Then
'            e.Handled = True
'        End If
'    End Sub

'    Private Sub txtItemName_LostFocus(sender As Object, e As EventArgs) Handles txtItemName.LostFocus
'        txtItemName.Text = txtItemName.Text.ToUpper
'    End Sub

'    Private Sub txtItemName_TextChanged(sender As Object, e As EventArgs) Handles txtItemName.TextChanged

'    End Sub

'    Private Sub txtMaxDuration_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaxDuration.KeyPress
'        Dim c As Char
'        c = e.KeyChar
'        If Not (Char.IsDigit(c) Or Char.IsControl(c)) Then
'            e.Handled = True
'        End If
'    End Sub

'    Private Sub txtMaxDuration_TextChanged(sender As Object, e As EventArgs) Handles txtMaxDuration.TextChanged

'    End Sub

'    Private Sub rtbItemDescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtbItemDescription.KeyPress
'        Dim c As Char
'        c = e.KeyChar
'        If Not (Char.IsLetterOrDigit(c) Or (c = " ") Or (c = "`") Or (c = "-") Or (c = ".") Or (c = "!") Or (c = "?") Or (c = "`") Or Char.IsControl(c)) Then
'            e.Handled = True
'        End If
'    End Sub

'    Private Sub rtbItemDescription_LostFocus(sender As Object, e As EventArgs) Handles rtbItemDescription.LostFocus
'        rtbItemDescription.Text = rtbItemDescription.Text.ToUpper
'    End Sub

'    Private Sub rtbItemDescription_TextChanged(sender As Object, e As EventArgs) Handles rtbItemDescription.TextChanged

'    End Sub

'    Private Sub cboBorrowType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBorrowType.SelectedIndexChanged
'        If cboBorrowType.Text = "FOR INSIDE AND OUTSIDE USE" Then
'            lblDays.Visible = True
'            lblMaxDuration.Visible = True
'            txtMaxDuration.Enabled = True
'            txtMaxDuration.Visible = True
'        ElseIf cboBorrowType.Text = "FOR INSIDE USE ONLY" Then
'            lblDays.Visible = False
'            lblMaxDuration.Visible = False
'            txtMaxDuration.Enabled = False
'            txtMaxDuration.Visible = False
'            txtMaxDuration.Clear()
'        End If
'    End Sub

'    Private Sub bntUploadPhoto_Click(sender As Object, e As EventArgs) Handles bntUploadPhoto.Click
'        Try
'            Dim ofd As New OpenFileDialog
'            ofd.Title = "Choose a photo"
'            ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
'            ofd.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
'            ofd.FilterIndex = 2
'            ofd.RestoreDirectory = False
'            If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
'                If ofd.CheckFileExists = False Or ofd.CheckPathExists = False Then
'                    MessageBox.Show("The file does not exist!", "No File Found", MessageBoxButtons.OK, MessageBoxIcon.Information)

'                Else
'                    Dim PhotoFile As New IO.FileInfo(ofd.FileName)
'                    If PhotoFile.Length <= 3500000 Then

'                        Dim BookPhoto As New Bitmap(ofd.FileName)
'                        pictItem.BackgroundImageLayout = ImageLayout.Zoom
'                        pictItem.BackgroundImage = ResizeImage(BookPhoto)

'                    Else
'                        MessageBox.Show("The file size is too large!", "Large File Size", MessageBoxButtons.OK, MessageBoxIcon.Information)

'                    End If
'                End If
'            End If
'        Catch ex As Exception
'            MsgBox(ex.Message.ToString)
'        End Try
'    End Sub

'    Private Function ResizeImage(ByVal PhotoFile As Image) As Image
'        Return New Bitmap(PhotoFile, New Size(pictItem.Width, pictItem.Height))
'    End Function


'    Private Sub btnAddQuantity_Click(sender As Object, e As EventArgs) Handles btnAddQuantity.Click
'        objFormAddItemQuantity = New FormAddItemQuantity
'        objFormAddItemQuantity.DsQuantityList = DsItemUnitList
'        If objFormAddItemQuantity.ShowDialog = Windows.Forms.DialogResult.OK Then
'            Dim index As Integer = 0
'            'dgvBookCopy.Rows.Clear()
'            While index < objFormAddItemQuantity.DsNewQuantityList.Tables(0).Rows.Count

'                With dgvItemQuantity
'                    .Rows.Add(objFormAddItemQuantity.DsNewQuantityList.Tables(0).Rows(index).Item(0).ToString.Trim, _
'                              objFormAddItemQuantity.DsNewQuantityList.Tables(0).Rows(index).Item(1).ToString.Trim, _
'                              objFormAddItemQuantity.DsNewQuantityList.Tables(0).Rows(index).Item(2).ToString.Trim, _
'                              objFormAddItemQuantity.DsNewQuantityList.Tables(0).Rows(index).Item(3).ToString.Trim, _
'                              objFormAddItemQuantity.DsNewQuantityList.Tables(0).Rows(index).Item(4).ToString.Trim)
'                End With

'                With DsItemUnitList
'                    Dim dsrow As DataRow
'                    dsrow = DsItemUnitList.Tables(0).NewRow
'                    dsrow.Item(0) = objFormAddItemQuantity.DsNewQuantityList.Tables(0).Rows(index).Item(0).ToString.Trim
'                    dsrow.Item(1) = objFormAddItemQuantity.DsNewQuantityList.Tables(0).Rows(index).Item(1).ToString.Trim
'                    dsrow.Item(2) = objFormAddItemQuantity.DsNewQuantityList.Tables(0).Rows(index).Item(2).ToString.Trim
'                    dsrow.Item(3) = objFormAddItemQuantity.DsNewQuantityList.Tables(0).Rows(index).Item(3).ToString.Trim
'                    dsrow.Item(4) = objFormAddItemQuantity.DsNewQuantityList.Tables(0).Rows(index).Item(4).ToString.Trim

'                    .Tables(0).Rows.Add(dsrow)
'                End With

'                index += 1
'            End While
'            dgvItemQuantity.Refresh()
'            dgvItemQuantity.Select()
'        End If
'    End Sub

'    Private Sub btnRemoveQuantity_Click(sender As Object, e As EventArgs) Handles btnRemoveQuantity.Click
'        If dgvItemQuantity.Rows.Count > 0 Then
'            Dim indexDs As Integer = 0
'            While indexDs < DsItemUnitList.Tables(0).Rows.Count
'                If DsItemUnitList.Tables(0).Rows(indexDs).Item(0).ToString.Trim = dgvItemQuantity.SelectedRows(0).Cells(0).Value.ToString.Trim Then
'                    'MsgBox("HI")
'                    DsItemUnitList.Tables(0).Rows.RemoveAt(indexDs)
'                    Exit While
'                End If
'                indexDs += 1
'            End While
'            For Each removeRow As DataGridViewRow In dgvItemQuantity.SelectedRows
'                dgvItemQuantity.Rows.Remove(removeRow)
'                dgvItemQuantity.Refresh()
'                dgvItemQuantity.Select()
'            Next
'        End If
'    End Sub

'    Private Sub btnEditQuantity_Click(sender As Object, e As EventArgs) Handles btnEditQuantity.Click
'        If dgvItemQuantity.Rows.Count > 0 Then
'            objFormEditItemQuantity = New FormEditItemQuantity
'            objFormEditItemQuantity.UnitID = dgvItemQuantity.SelectedRows(0).Cells(0).Value.ToString.Trim
'            objFormEditItemQuantity.Aquisition = dgvItemQuantity.SelectedRows(0).Cells(1).Value.ToString.Trim
'            objFormEditItemQuantity.Price = dgvItemQuantity.SelectedRows(0).Cells(2).Value.ToString.Trim
'            If objFormEditItemQuantity.ShowDialog = Windows.Forms.DialogResult.OK Then
'                Dim index As Integer = 0
'                While index < DsItemUnitList.Tables(0).Rows.Count
'                    If objFormEditItemQuantity.UnitID = DsItemUnitList.Tables(0).Rows(index).Item(0).ToString Then

'                        DsItemUnitList.Tables(0).Rows.RemoveAt(index)

'                        dgvItemQuantity.SelectedRows(0).Cells(0).Value = objFormEditItemQuantity.DsNewQuantityList.Tables(0).Rows(0).Item(0).ToString
'                        dgvItemQuantity.SelectedRows(0).Cells(1).Value = objFormEditItemQuantity.DsNewQuantityList.Tables(0).Rows(0).Item(1).ToString
'                        dgvItemQuantity.SelectedRows(0).Cells(2).Value = objFormEditItemQuantity.DsNewQuantityList.Tables(0).Rows(0).Item(2).ToString
'                        dgvItemQuantity.SelectedRows(0).Cells(3).Value = objFormEditItemQuantity.DsNewQuantityList.Tables(0).Rows(0).Item(3).ToString
'                        dgvItemQuantity.SelectedRows(0).Cells(4).Value = objFormEditItemQuantity.DsNewQuantityList.Tables(0).Rows(0).Item(4).ToString

'                        With DsItemUnitList
'                            Dim dsrow As DataRow
'                            dsrow = DsItemUnitList.Tables(0).NewRow
'                            dsrow.Item(0) = objFormEditItemQuantity.DsNewQuantityList.Tables(0).Rows(0).Item(0).ToString.Trim
'                            dsrow.Item(1) = objFormEditItemQuantity.DsNewQuantityList.Tables(0).Rows(0).Item(1).ToString.Trim
'                            dsrow.Item(2) = objFormEditItemQuantity.DsNewQuantityList.Tables(0).Rows(0).Item(2).ToString.Trim
'                            dsrow.Item(3) = objFormEditItemQuantity.DsNewQuantityList.Tables(0).Rows(0).Item(3).ToString.Trim
'                            dsrow.Item(4) = objFormEditItemQuantity.DsNewQuantityList.Tables(0).Rows(0).Item(4).ToString.Trim

'                            .Tables(0).Rows.Add(dsrow)
'                        End With

'                        Exit While
'                    End If
'                    index += 1
'                End While
'            End If
'        End If
'    End Sub

'    Private Function countExistItemCopy() As Integer
'        Dim count As Integer = 0
'        For Each row As DataGridViewRow In dgvItemQuantity.Rows
'            Dim sqlCount As String
'            sqlCount = "SELECT COUNT(*) FROM libraryitemunit WHERE libraryItemUnitId=" + row.Cells(0).Value.ToString.Trim + ";"
'            If LibraryDatabase.isExisting(sqlCount) = True Then
'                count += 1
'                Dim index = row.Index
'                dgvItemQuantity.Rows(index).DefaultCellStyle.BackColor = Color.MistyRose
'            End If
'        Next
'        Return count
'    End Function

'    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
'        If Not String.IsNullOrWhiteSpace(txtItemName.Text) Then
'            If Not String.IsNullOrWhiteSpace(cboItemType.Text) Then
'                If dgvItemQuantity.Rows.Count > 0 Then
'                    Dim countExistCopy As Integer = countExistItemCopy()
'                    If countExistCopy = 0 Then
'                        'adding item
'                        Dim sqlInsert As String

'                        objItem = New LibraryItem
'                        objItem.LibraryItemId = txtItemId.Text
'                        objItem.LibraryItemName = txtItemName.Text
'                        objItem.LibraryItemType = Val(dsItemType.Tables(0).Rows(cboItemType.SelectedIndex).Item(0).ToString)
'                        objItem.LibraryItemBorrowType = cboBorrowType.Text

'                        objItem.LibraryItemDescription = rtbItemDescription.Text
'                        If cboBorrowType.Text = "FOR INSIDE AND OUTSIDE USE" Then
'                            objItem.LibraryItemBorrowDuration = txtMaxDuration.Text
'                        Else
'                            objItem.LibraryItemBorrowDuration = 0
'                        End If
'                        objItem.LibraryItemPhoto = objItem.ConvertImageTo64(pictItem.BackgroundImage)

'                        sqlInsert = "INSERT INTO `libraryitem`(`libraryItemId`, `libraryItemName`, `libraryItemType`, `libraryItemBorrowType`, `libraryItemBorrowDuration`, `libraryItemDescription`, `libraryItemPhoto`) VALUES (" & _
'                                                objItem.LibraryItemId.ToString + ",'" & _
'                                                objItem.LibraryItemName + "'," & _
'                                                objItem.LibraryItemType.ToString + ",'" & _
'                                                objItem.LibraryItemBorrowType + "'," & _
'                                                objItem.LibraryItemBorrowDuration.ToString + ",'" & _
'                                                objItem.LibraryItemDescription + "','" & _
'                                                objItem.LibraryItemPhoto + "');"
'                        'adding bookCopy\item copy wat??
'                        Dim indexCopy As Integer = 0
'                        While indexCopy < DsItemUnitList.Tables(0).Rows.Count
'                            objItemUnit = New LibraryItemUnit
'                            objItemUnit.LibraryItemUnitId = DsItemUnitList.Tables(0).Rows(indexCopy).Item(0).ToString.Trim
'                            objItemUnit.LibraryItemUnitItemId = txtItemId.Text
'                            objItemUnit.LibraryItemUnitStatus = "IN"
'                            objItemUnit.LibraryItemUnitQuality = "EXCELLENT" 'must fix
'                            objItemUnit.LibraryItemUnitAquisition = DsItemUnitList.Tables(0).Rows(indexCopy).Item(1).ToString
'                            If DsItemUnitList.Tables(0).Rows(indexCopy).Item(1).ToString.Trim = "BOUGHT BY SCHOOL" Then
'                                objItemUnit.LibraryItemUnitPrice = DsItemUnitList.Tables(0).Rows(indexCopy).Item(2).ToString.Trim
'                            End If
'                            objItemUnit.LibraryItemUnitDateAdded = DsItemUnitList.Tables(0).Rows(indexCopy).Item(4).ToString.Trim

'                            sqlInsert += "INSERT INTO `libraryitemunit`(`libraryItemUnitId`, `libraryItemUnitItemId`, `libraryItemUnitQuality`, `libraryItemUnitAquisition`, `libraryItemUnitPrice`, `libraryItemUnitStatus`, `libraryItemUnitDateAdded`) VALUES (" & _
'                                                objItemUnit.LibraryItemUnitId.ToString + "," & _
'                                                objItemUnit.LibraryItemUnitItemId.ToString + ",'" & _
'                                                objItemUnit.LibraryItemUnitQuality + "','" & _
'                                                objItemUnit.LibraryItemUnitAquisition + "','" & _
'                                                objItemUnit.LibraryItemUnitPrice + "','" & _
'                                                objItemUnit.LibraryItemUnitStatus + "','" & _
'                                                objItemUnit.LibraryItemUnitDateAdded + "');"
'                            indexCopy += 1
'                        End While
'                        LibraryDatabase.execSQL(sqlInsert)
'                        MessageBox.Show("You have successfully added a new item!", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
'                        Me.DialogResult = Windows.Forms.DialogResult.OK
'                    ElseIf countExistCopy = 1 Then
'                        MessageBox.Show("There is one (1) unit of the item that already exist in the database. Please check again the unit ID Number from the list.", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                    ElseIf countExistCopy > 1 Then
'                        MessageBox.Show("There are more than one unit of the item that already exist in the database. Check these unit ID Numbers from the list.", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                    End If
'                Else
'                    MessageBox.Show("Item unit list is empty! At least one (1) unit is required to save this item.", "Required Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                End If
'            Else
'                MessageBox.Show("Item Type is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                cboItemType.Select()
'            End If
'        Else
'            MessageBox.Show("Item Name filed is empty!", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
'            txtItemName.Focus()
'        End If
'    End Sub

'    Private Sub btnItemType_Click(sender As Object, e As EventArgs) Handles btnItemType.Click
'        objFormItemType = New FormItemType
'        If objFormItemType.ShowDialog = Windows.Forms.DialogResult.OK Then
'            generateItemType()
'        End If
'    End Sub
'End Class