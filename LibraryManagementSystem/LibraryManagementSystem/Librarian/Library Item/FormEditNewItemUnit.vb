'Public Class FormEditNewItemUnit
'    Dim dsItemUnit As DataSet
'    Dim dateToday As DateTime = DateTime.Now
'    Dim objItemUnit As New LibraryItemUnit
'    Private _itemUnitId As Integer

'    Public Property ItemUnitId()
'        Get
'            Return _itemUnitId
'        End Get
'        Set(value)
'            _itemUnitId = value
'        End Set
'    End Property

'    Private Sub loadData()
'        Try

'            dsItemUnit = LibraryDatabase.fetchSQL("SELECT * FROM libraryitemunit WHERE libraryItemUnitId=" + ItemUnitId.ToString + ";")
'            'SELECT 0`libraryItemUnitId`, 1`libraryItemUnitItemId`, 2`libraryItemUnitQuality`, 3`libraryItemUnitAquisition`, 
'            '4`libraryItemUnitPrice`, 5`libraryItemUnitStatus`, 6`libraryItemUnitDateAdded` FROM `libraryitemunit` WHERE 11
'            If dsItemUnit.Tables(0).Rows.Count > 0 Then
'                txtID1.Text = ItemUnitId.ToString
'                cboAquisition.Text = dsItemUnit.Tables(0).Rows(0).Item(3).ToString.Trim
'                txtPrice.Text = dsItemUnit.Tables(0).Rows(0).Item(4).ToString.Trim
'            Else
'                Panel2.Enabled = False
'                btnEditQuantity.Enabled = False
'            End If
'        Catch ex As Exception
'            Panel2.Enabled = False
'            btnEditQuantity.Enabled = False
'            MsgBox(ex.Message.ToString)
'        End Try

'    End Sub

'    Private Sub identifyAquisition()
'        If Not cboAquisition.Text = "BOUGHT BY SCHOOL" Then
'            lblPrice.Visible = False
'            txtPrice.Visible = False
'            lblPhp.Visible = False
'        Else
'            lblPrice.Visible = True
'            txtPrice.Visible = True
'            lblPhp.Visible = True
'        End If
'    End Sub

'    Private Sub FormEditNewItemUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        loadData()
'        txtID1.Enabled = False
'        txtPrice.Text = Val(txtPrice.Text).ToString("###,###,##0.00")
'        identifyAquisition()
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
'        'Me.Dispose()
'    End Sub

'    Private Sub cboAquisition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAquisition.SelectedIndexChanged
'        identifyAquisition()
'    End Sub

'    Private Sub btnEditQuantity_Click(sender As Object, e As EventArgs) Handles btnEditQuantity.Click
'        objItemUnit.LibraryItemUnitId = txtID1.Text
'        objItemUnit.LibraryItemUnitAquisition = cboAquisition.Text
'        If cboAquisition.Text = "BOUGHT BY SCHOOL" Then
'            objItemUnit.LibraryItemUnitPrice = txtPrice.Text
'        End If
'        Dim sqlUpdate As String

'        sqlUpdate = "UPDATE `libraryitemunit` SET " & _
'            "`libraryItemUnitAquisition`='" + objItemUnit.LibraryItemUnitAquisition & _
'            "',`libraryItemUnitPrice`='" + objItemUnit.LibraryItemUnitPrice & _
'            "' WHERE libraryItemUnitId= " + objItemUnit.LibraryItemUnitId.ToString & ";"
'        LibraryDatabase.execSQL(sqlUpdate)
'        MessageBox.Show("Successfully updated unit Id: " + txtID1.Text + ".", "Successfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
'        Me.DialogResult = Windows.Forms.DialogResult.OK
'    End Sub
'End Class