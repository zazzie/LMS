Public Class FormUpdateItem
    Private _itemID As Integer
    Dim countCurrentCopy As Integer = 0
    Dim countClose As Integer = 0
    Dim objFormItemType As New FormItemType
    Dim objFormAddNewItemUnit As New FormAddNewItemUnit
    Dim objFormEditNewItemUnit As New FormEditNewItemUnit
    Dim objItem As New LibraryItem
    Dim objLibraryItemUnit As New LibraryItemUnit
    Dim dsItemType As DataSet
    Dim dsItemInfo As DataSet
    Dim dsItemUnit As DataSet

    Public Property ItemId
        Get
            Return _itemID
        End Get
        Set(value)
            _itemID = value
        End Set

    End Property

    Private Sub generateItemType()
        Try
            Dim ds As New DataSet
            ds = LibraryDatabase.fetchSQL("SELECT `itemTypeId`, `itemTypeName` FROM `itemtype` ORDER BY itemTypeName;")
            cboItemType.Items.Clear()
            If ds.Tables(0).Rows.Count > 0 Then
                dsItemType = ds
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With cboItemType
                        .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                    End With
                    index += 1
                End While
                cboItemType.Refresh()
                cboItemType.SelectedIndex = 0
            Else
                Dim sqlInsert As String = "INSERT INTO `itemtype`(`itemTypeId`, `itemTypeName`) VALUES (0,'UNDEFINED');"
                LibraryDatabase.execSQL(sqlInsert)
                generateItemType()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    'SELECT 0`libraryItemId`, 1`libraryItemName`, 2`libraryItemType`, 3`libraryItemBorrowType`, 
    '4`libraryItemBorrowDuration`, 5`libraryItemDescription`, 6`libraryItemPhoto` FROM `libraryitem` WHERE 1
    Private Sub loadItemInfo()
        dsItemInfo = LibraryDatabase.fetchSQL("SELECT * FROM libraryitem WHERE libraryItemId=" + ItemId.ToString + ";")

        If dsItemInfo.Tables(0).Rows.Count > 0 Then
            Dim indexItemType As Integer = 0
            txtItemId.Text = ItemId.ToString
            txtItemName.Text = dsItemInfo.Tables(0).Rows(0).Item(1).ToString.Trim
            If dsItemType.Tables(0).Rows.Count > 0 Then
                While indexItemType < dsItemType.Tables(0).Rows.Count
                    If dsItemInfo.Tables(0).Rows(0).Item(2).ToString.Trim = dsItemType.Tables(0).Rows(indexItemType).Item(0).ToString.Trim Then
                        cboItemType.SelectedIndex = indexItemType
                        Exit While
                    End If
                    indexItemType += 1
                End While
            End If
            cboBorrowType.Text = dsItemInfo.Tables(0).Rows(0).Item(3).ToString.Trim
            txtMaxDuration.Text = dsItemInfo.Tables(0).Rows(0).Item(4).ToString.Trim
            If cboBorrowType.Text = "FOR INSIDE AND OUTSIDE USE" Then
                lblDays.Visible = True
                lblMaxDuration.Visible = True
                txtMaxDuration.Enabled = True
                txtMaxDuration.Visible = True
            ElseIf cboBorrowType.Text = "FOR INSIDE USE ONLY" Then
                lblDays.Visible = False
                lblMaxDuration.Visible = False
                txtMaxDuration.Enabled = False
                txtMaxDuration.Visible = False
            End If
            rtbItemDescription.Text = dsItemInfo.Tables(0).Rows(0).Item(5).ToString.Trim
            pictItem.BackgroundImage = Base64ToImage(dsItemInfo.Tables(0).Rows(0).Item(6).ToString.Trim)
        End If
    End Sub

    'SELECT 0`libraryItemUnitId`, 1`libraryItemUnitItemId`, 2`libraryItemUnitQuality`, 3`libraryItemUnitAquisition`, 
    '4`libraryItemUnitPrice`, 5`libraryItemUnitStatus`, 6`libraryItemUnitDateAdded` FROM `libraryitemunit` WHERE 1
    Private Sub loadItemUnit()
        dsItemUnit = LibraryDatabase.fetchSQL("SELECT * FROM `libraryitemunit`;")
        dgvItemQuantity.Rows.Clear()
        If dsItemUnit.Tables(0).Rows.Count > 0 Then
            Dim indexItemUnit As Integer = 0
            While indexItemUnit < dsItemUnit.Tables(0).Rows.Count
                With dgvItemQuantity
                    .Rows.Add(dsItemUnit.Tables(0).Rows(indexItemUnit).Item(0).ToString.Trim, _
                              dsItemUnit.Tables(0).Rows(indexItemUnit).Item(3).ToString.Trim, _
                              dsItemUnit.Tables(0).Rows(indexItemUnit).Item(4).ToString.Trim, _
                              dsItemUnit.Tables(0).Rows(indexItemUnit).Item(5).ToString.Trim, _
                              dsItemUnit.Tables(0).Rows(indexItemUnit).Item(6).ToString.Trim)
                End With
                indexItemUnit += 1
            End While
        End If
    End Sub

    Private Sub renameColumns()
        With dgvItemQuantity
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Unit ID" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "Aquisition"
            .Columns(2).HeaderCell.Value = "Price"
            .Columns(3).HeaderCell.Value = "Status"
            .Columns(4).HeaderCell.Value = "Date Added"
        End With
    End Sub

    Private Sub FormUpdateItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not ItemId = Nothing Then
            dgvItemQuantity.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
            renameColumns()
            generateItemType()

            Try
                loadItemInfo()
                loadItemUnit()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
            txtItemName.Focus()
        Else
            Panel1.Enabled = False
            btnUpdateItem.Enabled = False
        End If
    End Sub

    Private Sub btnItemType_Click(sender As Object, e As EventArgs) Handles btnItemType.Click
        objFormItemType = New FormItemType
        If objFormItemType.ShowDialog = Windows.Forms.DialogResult.OK Then
            generateItemType()
        End If
    End Sub

    Private Sub txtItemName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemName.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetterOrDigit(c) Or (c = " ") Or (c = "-") Or (c = ".") Or (c = "!") Or (c = "?") Or (c = "`") Or (c = ":") Or (c = ",") Or (c = "@") Or (c = "#") Or (c = "$") Or (c = "&") Or (c = "/") Or (c = "\") Or (c = ">") Or (c = "<") Or (c = "(") Or (c = ")") Or (c = "_") Or (c = "=") Or (c = "+") Or (c = "*") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtItemName_LostFocus(sender As Object, e As EventArgs) Handles txtItemName.LostFocus
        txtItemName.Text = txtItemName.Text.ToUpper
    End Sub

    Private Sub txtItemName_TextChanged(sender As Object, e As EventArgs) Handles txtItemName.TextChanged

    End Sub

    Private Sub txtMaxDuration_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaxDuration.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMaxDuration_TextChanged(sender As Object, e As EventArgs) Handles txtMaxDuration.TextChanged

    End Sub

    Private Sub rtbItemDescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtbItemDescription.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetterOrDigit(c) Or (c = " ") Or (c = "`") Or (c = "-") Or (c = ".") Or (c = "!") Or (c = "?") Or (c = "`") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub rtbItemDescription_LostFocus(sender As Object, e As EventArgs) Handles rtbItemDescription.LostFocus
        rtbItemDescription.Text = rtbItemDescription.Text.ToUpper
    End Sub

    Private Sub rtbItemDescription_TextChanged(sender As Object, e As EventArgs) Handles rtbItemDescription.TextChanged

    End Sub

    Private Sub cboBorrowType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBorrowType.SelectedIndexChanged
        If cboBorrowType.Text = "FOR INSIDE AND OUTSIDE USE" Then
            lblDays.Visible = True
            lblMaxDuration.Visible = True
            txtMaxDuration.Enabled = True
            txtMaxDuration.Visible = True
        ElseIf cboBorrowType.Text = "FOR INSIDE READING ONLY" Then
            lblDays.Visible = False
            lblMaxDuration.Visible = False
            txtMaxDuration.Enabled = False
            txtMaxDuration.Visible = False
            txtMaxDuration.Clear()
        End If
    End Sub

    Private Function ResizeImage(ByVal PhotoFile As Image) As Image
        Return New Bitmap(PhotoFile, New Size(pictItem.Width, pictItem.Height))
    End Function

    Private Sub bntUploadPhoto_Click(sender As Object, e As EventArgs) Handles bntUploadPhoto.Click
        Try
            Dim ofd As New OpenFileDialog
            ofd.Title = "Choose a photo"
            ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            ofd.Filter = "Picture Files(*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            ofd.FilterIndex = 2
            ofd.RestoreDirectory = False
            If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If ofd.CheckFileExists = False Or ofd.CheckPathExists = False Then
                    MessageBox.Show("The file does not exist!", "No File Found", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    Dim PhotoFile As New IO.FileInfo(ofd.FileName)
                    If PhotoFile.Length <= 3500000 Then

                        Dim BookPhoto As New Bitmap(ofd.FileName)
                        pictItem.BackgroundImageLayout = ImageLayout.Zoom
                        pictItem.BackgroundImage = ResizeImage(BookPhoto)

                    Else
                        MessageBox.Show("The file size is too large!", "Large File Size", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If Not countCurrentCopy = dgvItemQuantity.Rows.Count Then
            Dim ans As Integer
            ans = MsgBox("Do you want to cancel item update?", MsgBoxStyle.YesNo, "Unsaved Update")
            If ans = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                countClose += 1
                Me.Dispose()
            End If
        Else
            Dim ans As Integer
            ans = MsgBox("General item information update in not saved. Proceed closing window?", MsgBoxStyle.YesNo, "Unsaved Update")
            If ans = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                countClose += 1
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub btnAddQuantity_Click(sender As Object, e As EventArgs) Handles btnAddQuantity.Click
        objFormAddNewItemUnit = New FormAddNewItemUnit
        objFormAddNewItemUnit.ItemId = txtItemId.Text
        If objFormAddNewItemUnit.ShowDialog = Windows.Forms.DialogResult.OK Then
            dgvItemQuantity.Rows.Clear()
            loadItemUnit()
            dgvItemQuantity.Refresh()
            dgvItemQuantity.Select()
        End If
    End Sub

    Private Sub btnUpdateItem_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click
        If Not String.IsNullOrWhiteSpace(txtItemName.Text) Then
            If Not String.IsNullOrWhiteSpace(cboItemType.Text) Then
                If dgvItemQuantity.Rows.Count > 0 Then

                    Dim sqlInsert As String

                    objItem = New LibraryItem
                    objItem.LibraryItemId = txtItemId.Text
                    objItem.LibraryItemName = txtItemName.Text
                    objItem.LibraryItemType = Val(dsItemType.Tables(0).Rows(cboItemType.SelectedIndex).Item(0).ToString)
                    objItem.LibraryItemBorrowType = cboBorrowType.Text

                    objItem.LibraryItemDescription = rtbItemDescription.Text
                    If cboBorrowType.Text = "FOR INSIDE AND OUTSIDE USE" Then
                        objItem.LibraryItemBorrowDuration = txtMaxDuration.Text
                    Else
                        objItem.LibraryItemBorrowDuration = 0
                    End If
                    objItem.LibraryItemPhoto = objItem.ConvertImageTo64(pictItem.BackgroundImage)

                    sqlInsert = "UPDATE `libraryitem` SET " & _
                        "`libraryItemName`='" + objItem.LibraryItemName & _
                        "',`libraryItemType`=" + objItem.LibraryItemType.ToString & _
                        ",`libraryItemBorrowType`='" + objItem.LibraryItemBorrowType & _
                        "',`libraryItemBorrowDuration`=" + objItem.LibraryItemBorrowDuration.ToString & _
                        ",`libraryItemDescription`='" + objItem.LibraryItemDescription & _
                        "',`libraryItemPhoto`='" + objItem.LibraryItemPhoto & _
                        "' WHERE libraryItemId= " + objItem.LibraryItemId.ToString & ";"
                    Try
                        LibraryDatabase.execSQL(sqlInsert)
                        MessageBox.Show("You have successfully updated an item!", "Successfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try
                Else
                    MessageBox.Show("Item unit list is empty! At least one (1) unit is required to update this item.", "Required Copy", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Item Type is empty!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboItemType.Select()
            End If
        Else
            MessageBox.Show("Item Name field is empty!", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtItemName.Focus()
        End If
    End Sub

    Private Sub btnEditQuantity_Click(sender As Object, e As EventArgs) Handles btnEditQuantity.Click
        objFormEditNewItemUnit = New FormEditNewItemUnit
        objFormEditNewItemUnit.ItemUnitId = dgvItemQuantity.SelectedRows(0).Cells(0).Value
        'MsgBox(dgvBookCopy.SelectedRows(0).Cells(0).Value.ToString)
        If objFormEditNewItemUnit.ShowDialog = Windows.Forms.DialogResult.OK Then
            loadItemUnit()
            dgvItemQuantity.Refresh()
            dgvItemQuantity.Select()
        End If
    End Sub

    Private Sub btnRemoveQuantity_Click(sender As Object, e As EventArgs) Handles btnRemoveQuantity.Click
        If dgvItemQuantity.Rows.Count > 0 Then
            If dgvItemQuantity.Rows.Count = 1 Then
                MessageBox.Show("You cannot delete a last unit of this book from this update item form. You may delete the item from the item list instead.", "Delete Restriction")
            Else
                Dim ans As Integer
                ans = MsgBox("Are you sure you want to remove unit id number: " + dgvItemQuantity.SelectedRows(0).Cells(0).Value.ToString.Trim + " from the item unit list?", MsgBoxStyle.YesNo, "Remove Unit")
                If ans = MsgBoxResult.Yes Then
                    objItem.LibraryItemId = dgvItemQuantity.SelectedRows(0).Cells(0).Value
                    objItem.deleteLibraryItem()
                    MessageBox.Show("You have successfully deleted unit id number: " + dgvItemQuantity.SelectedRows(0).Cells(0).Value.ToString.Trim + " from the list.", "Deleted Record")
                    loadItemUnit()
                    dgvItemQuantity.Refresh()
                    dgvItemQuantity.Select()
                End If
            End If
        End If
    End Sub
End Class