Public Class FormEditItemQuantity
    Public DsNewQuantityList As DataSet
    Dim dateToday As DateTime = DateTime.Now
    Dim _unitID, _aquisition, _price As String

    Public Property UnitID
        Get
            Return _unitID
        End Get
        Set(value)
            _unitID = value
        End Set
    End Property

    Public Property Aquisition
        Get
            Return _aquisition
        End Get
        Set(value)
            _aquisition = value
        End Set
    End Property

    Public Property Price
        Get
            Return _price
        End Get
        Set(value)
            _price = value
        End Set
    End Property

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

    Private Sub identifyAquisition()
        If Not cboAquisition.Text = "BOUGHT BY SCHOOL" Then
            lblPrice.Visible = False
            txtPrice.Visible = False
            lblPhp.Visible = False
        Else
            lblPrice.Visible = True
            txtPrice.Visible = True
            lblPhp.Visible = True
        End If
    End Sub

    Private Sub FormEditItemQuantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeDsCopy()
        txtID1.Text = UnitID
        cboAquisition.Text = Aquisition
        txtPrice.Text = Price
        txtPrice.Text = Val(txtPrice.Text).ToString("###,###,##0.00")
        identifyAquisition()
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        'Me.Dispose()
    End Sub

    Private Sub cboAquisition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAquisition.SelectedIndexChanged
        identifyAquisition()
    End Sub

    Private Sub btnEditQuantity_Click(sender As Object, e As EventArgs) Handles btnEditQuantity.Click
        Dim row As DataRow
        row = DsNewQuantityList.Tables(0).NewRow
        row.Item(0) = txtID1.Text
        row.Item(1) = cboAquisition.Text
        row.Item(2) = txtPrice.Text
        row.Item(3) = "IN"
        row.Item(4) = dateToday.ToString("d")
        DsNewQuantityList.Tables(0).Rows.Add(row)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class