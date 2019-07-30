'Public Class FormNewBarangays
'    Private _id As Integer
'    Dim availableBrgyId As Integer
'    Private brgyObj As New Barangay

'    Public Property CityIdSub()
'        Get
'            Return _id
'        End Get
'        Set(ByVal value)
'            _id = value
'        End Set
'    End Property
'    Private Sub renameColumns()
'        With dgvBarangay
'            .RowHeadersVisible = False
'            .Columns(0).HeaderCell.Value = "ID" 'RENAMING COLUMNS
'            .Columns(1).HeaderCell.Value = "Barangay"
'        End With

'    End Sub
'    Private Function isExistInList(ByVal barangayName As String) As Boolean
'        Dim count As Integer = 0
'        For Each row As DataGridViewRow In dgvBarangay.Rows
'            If barangayName = row.Cells(1).Value.ToString.Trim Then
'                count += 1
'            End If
'        Next
'        If count > 0 Then
'            Return True
'        Else
'            Return False
'        End If
'    End Function
'    Private Sub formNewBarangays_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
'        If dgvBarangay.RowCount > 0 Then
'            Dim ans As Integer
'            ans = MsgBox("There are unsaved changes. Do you want to exit without saving?", MsgBoxStyle.YesNo, "Unsaved Changes")
'            If ans = MsgBoxResult.Yes Then
'                Me.Dispose()
'            Else
'                e.Cancel = True
'            End If
'        End If
'    End Sub
'    Private Sub formNewBarangays_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        dgvBarangay.Font = New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
'        availableBrgyId = LibraryDatabase.GenerateID("SELECT MAX(barangayId) FROM barangay;")
'        renameColumns()
'        txtBarangay.Focus()
'    End Sub

'    Private Sub btnAddToList_Click(sender As Object, e As EventArgs) Handles btnAddToList.Click
'        If Not String.IsNullOrWhiteSpace(txtBarangay.Text) Then
'            If LibraryDatabase.isExisting("SELECT COUNT(*) FROM barangay WHERE barangayCityId=" + CityIdSub.ToString + " and barangayName='" + txtBarangay.Text + "';") = False Then
'                If isExistInList(txtBarangay.Text) = False Then
'                    Dim addRow As String() = New String() {availableBrgyId.ToString, txtBarangay.Text}
'                    dgvBarangay.Rows.Add(addRow)
'                    availableBrgyId += 1
'                    txtBarangay.Clear()
'                    txtBarangay.Focus()
'                Else
'                    MessageBox.Show("Barangay Name is already in the list!", "Already Listed", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                    txtBarangay.Select()
'                    txtBarangay.Focus()
'                End If
'            Else
'                MessageBox.Show("Barangay Name already exist in the record!", "Existing Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
'                txtBarangay.Select()
'                txtBarangay.Focus()
'            End If
'        Else
'            MessageBox.Show("Barangay Name input is empty!", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Information)
'            txtBarangay.Focus()
'        End If
'    End Sub

'    Private Sub btnRemoveFromList_Click(sender As Object, e As EventArgs) Handles btnRemoveFromList.Click
'        If dgvBarangay.RowCount > 0 Then
'            For Each removeRow As DataGridViewRow In dgvBarangay.SelectedRows
'                dgvBarangay.Rows.Remove(removeRow)
'            Next
'        End If
'    End Sub

'    Private Sub txtBarangay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBarangay.KeyPress
'        Dim c As Char
'        c = e.KeyChar
'        If Not (Char.IsLetterOrDigit(c) Or (c = " ") Or (c = "#") Or (c = "-") Or Char.IsControl(c)) Then
'            e.Handled = True
'        End If
'    End Sub

'    Private Sub txtBarangay_LostFocus(sender As Object, e As EventArgs) Handles txtBarangay.LostFocus
'        txtBarangay.Text = txtBarangay.Text.ToUpper
'    End Sub

'    Private Sub txtBarangay_TextChanged(sender As Object, e As EventArgs) Handles txtBarangay.TextChanged

'    End Sub

'    Private Sub btnSaveAll_Click(sender As Object, e As EventArgs) Handles btnSaveAll.Click
'        If dgvBarangay.RowCount > 0 Then
'            Dim sqlInsert As String = ""
'            For Each row As DataGridViewRow In dgvBarangay.Rows
'                brgyObj.BarangayId = row.Cells(0).Value.ToString.Trim
'                brgyObj.BarangayCityId = CityIdSub
'                brgyObj.BarangayName = row.Cells(1).Value.ToString.Trim

'                sqlInsert += "INSERT INTO `barangay`(`barangayId`, `barangayCityId`, `barangayName`) VALUES (" & _
'                                                    brgyObj.BarangayId.ToString + "," & _
'                                                    brgyObj.BarangayCityId.ToString + ",'" & _
'                                                    brgyObj.BarangayName + "');"
'            Next

'            LibraryDatabase.execSQL(sqlInsert)
'            MessageBox.Show("You have successfully added new barangays/s!", "New Barangay Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
'            Me.DialogResult = Windows.Forms.DialogResult.OK
'            Me.Dispose()
'        End If
'    End Sub
'End Class