Public Class FormViewLibraryItem
    Private Shared _viewItemId As Integer

    Public Property ViewItemId
        Get
            Return _viewItemId
        End Get
        Set(value)
            _viewItemId = value
        End Set
    End Property
    Private Sub renameItemUnitGridColumns()
        With dgvItemUnit
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID" 'RENAMING COLUMNS
            .Columns(1).HeaderCell.Value = "Condition"
            .Columns(2).HeaderCell.Value = "Status"
            .Columns(3).HeaderCell.Value = "Aquisition"
            .Columns(4).HeaderCell.Value = "Price"
            .Columns(5).HeaderCell.Value = "Date Added"
            .Columns(0).FillWeight = 30
            .Columns(1).FillWeight = 30
            .Columns(2).FillWeight = 20
            .Columns(3).FillWeight = 40
            .Columns(4).FillWeight = 25
            .Columns(5).FillWeight = 25
        End With
    End Sub
    Private Sub generateItemInfo()
        Dim sqlFetch As String
        'SELECT `libraryItemId`, `libraryItemName`, `libraryItemType`, `libraryItemBorrowType`,
        ' `libraryItemBorrowDuration`, `libraryItemDescription`, `libraryItemPhoto` FROM `libraryitem` WHERE 1
        sqlFetch = "SELECT `libraryItemId`, `libraryItemName`, `libraryItemType`, `libraryItemBorrowType`, " & _
            "`libraryItemBorrowDuration`, `libraryItemDescription`, `libraryItemPhoto`, `itemTypeName` FROM `libraryitem` " & _
            "JOIN itemtype ON itemTypeId=libraryItemType " & _
            "WHERE libraryItemId =" + ViewItemId.ToString + ";"
        Dim ds As DataSet
        ds = LibraryDatabase.fetchSQL(sqlFetch)
        If ds.Tables(0).Rows.Count > 0 Then

            Dim countQuantity As Integer = 0
            Dim countItemAvailability As Integer = 0
            Dim sqlCountQuantity As String = "SELECT COUNT(*) FROM libraryitemunit WHERE libraryItemUnitItemId=" + ViewItemId.ToString + ";"
            Dim sqlCountItemAvailable As String = "SELECT COUNT(*) FROM libraryitemunit WHERE libraryItemUnitItemId=" + ViewItemId.ToString & _
                " AND libraryItemUnitStatus='IN';"
            countQuantity = countRecord(sqlCountQuantity)
            countItemAvailability = countRecord(sqlCountItemAvailable)

            'arranging info
            'SELECT 0`libraryItemId`, 1`libraryItemName`, 2`libraryItemType`, 3`libraryItemBorrowType`,
            '4`libraryItemBorrowDuration`, 5`libraryItemDescription`, 6`libraryItemPhoto`, 7`itemTypeName` FROM `libraryitem` "

            lblItemName.Text = ds.Tables(0).Rows(0).Item(1).ToString.Trim
            lblItemId.Text = ds.Tables(0).Rows(0).Item(0).ToString.Trim
            lblItemType.Text = ds.Tables(0).Rows(0).Item(7).ToString.Trim
            lblitemBorrowType.Text = ds.Tables(0).Rows(0).Item(3).ToString.Trim
            If ds.Tables(0).Rows(0).Item(3).ToString.Trim = "FOR INSIDE USE ONLY" Then
                lblMaxBorrow.Visible = False
                lblMaxBorrowLABEL.Visible = False
                pnlForPhoto.BackColor = Color.MistyRose
            Else
                lblMaxBorrow.Text = ds.Tables(0).Rows(0).Item(4).ToString.Trim + " Day/s"
                pnlForPhoto.BackColor = Color.PaleTurquoise
            End If
            lblItemQuantity.Text = countQuantity.ToString
            lblItemAvailability.Text = countItemAvailability.ToString
            lblItemDescription.Text = ds.Tables(0).Rows(0).Item(5).ToString.Trim
            pictItemPhoto.BackgroundImage = Base64ToImage(ds.Tables(0).Rows(0).Item(6).ToString.Trim)

            'item unit listing
            'SELECT 0`libraryItemUnitId`, 1`libraryItemUnitItemId`, 2`libraryItemUnitQuality`, 3`libraryItemUnitAquisition`, 
            '4`libraryItemUnitPrice`, 5`libraryItemUnitStatus`, 6`libraryItemUnitDateAdded` FROM `libraryitemunit` WHERE 1

            Dim dsItemUnit As DataSet
            dsItemUnit = LibraryDatabase.fetchSQL("SELECT * FROM `libraryitemunit` WHERE `libraryItemUnitItemId`=" + ViewItemId.ToString + ";")
            If dsItemUnit.Tables(0).Rows.Count > 0 Then
                Dim indexItemUnit As Integer = 0
                While indexItemUnit < dsItemUnit.Tables(0).Rows.Count
                    With dgvItemUnit
                        .Rows.Add(dsItemUnit.Tables(0).Rows(indexItemUnit).Item(0).ToString.Trim, _
                                  dsItemUnit.Tables(0).Rows(indexItemUnit).Item(2).ToString.Trim, _
                                  dsItemUnit.Tables(0).Rows(indexItemUnit).Item(5).ToString.Trim, _
                                  dsItemUnit.Tables(0).Rows(indexItemUnit).Item(3).ToString.Trim, _
                                  dsItemUnit.Tables(0).Rows(indexItemUnit).Item(4).ToString.Trim, _
                                  dsItemUnit.Tables(0).Rows(indexItemUnit).Item(6).ToString.Trim)
                    End With
                    indexItemUnit += 1
                End While
            End If
        End If
    End Sub
    Private Sub FormViewLibraryItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvItemUnit.Font = New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        renameItemUnitGridColumns()
        Try
            generateItemInfo()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class