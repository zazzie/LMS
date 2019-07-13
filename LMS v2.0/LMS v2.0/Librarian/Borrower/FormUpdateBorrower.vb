Public Class FormUpdateBorrower
    Private Shared _updateformBorrowerId As Integer
    Dim objBorrower As New Borrower
    Dim dsBrgy As DataSet

    Public Property UpdateformBorrowerId
        Get
            Return _updateformBorrowerId
        End Get
        Set(value)
            _updateformBorrowerId = value
        End Set
    End Property

    Private Sub generateCity()
        Try
            Dim ds As New DataSet
            ds = LibraryDatabase.fetchSQL("SELECT DISTINCT `cityId`, `cityName` FROM `city` ORDER BY cityName;")
            cboCitty.Items.Clear()
            If ds.Tables(0).Rows.Count > 0 Then
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With cboCitty
                        .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                    End With
                    index += 1
                End While
                cboCitty.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub generateBarangay()
        If Not String.IsNullOrWhiteSpace(cboCitty.Text) Then
            Dim ds As New DataSet
            Try
                ds = LibraryDatabase.fetchSQL("SELECT DISTINCT `barangayId`, `cityId`, `barangayName`, `cityName` FROM `barangay`,`city` WHERE `cityId`=`barangayCityId` AND `cityName`='" + cboCitty.Text + "'; ")
                cboBrgy.Items.Clear()
                If ds.Tables(0).Rows.Count > 0 Then
                    dsBrgy = ds
                    Dim index As Integer = 0
                    While index < ds.Tables(0).Rows.Count
                        With cboBrgy
                            .Items.Add(ds.Tables(0).Rows(index).Item(2).ToString.Trim)
                        End With
                        index += 1
                    End While
                    cboCitty.Refresh()
                End If
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub fillBorrowerInfo()
        Try
            Dim sqlFetch As String
            sqlFetch = "SELECT * FROM `borrower` WHERE borrowerId =" + UpdateformBorrowerId.ToString + ";"
            Dim ds As DataSet
            Dim birth As Date
            ds = LibraryDatabase.fetchSQL(sqlFetch)
            If ds.Tables(0).Rows.Count > 0 Then
                Dim city, brgy As String
                Try

                    city = LibraryDatabase.fetchSQL("SELECT `cityName` FROM `city` WHERE cityId=" + ds.Tables(0).Rows(0).Item(9).ToString.Trim + ";").Tables(0).Rows(0).Item(0).ToString
                    brgy = LibraryDatabase.fetchSQL("SELECT `barangayName` FROM `barangay`  WHERE `barangayId`=" + ds.Tables(0).Rows(0).Item(8).ToString.Trim + " AND `barangayCityId`=" + ds.Tables(0).Rows(0).Item(9).ToString.Trim + ";").Tables(0).Rows(0).Item(0).ToString
                Catch ex As Exception
                    city = ""
                    brgy = ""
                End Try


                txtBorrowerId.Text = ds.Tables(0).Rows(0).Item(0).ToString.Trim
                objBorrower.BorrowerId = ds.Tables(0).Rows(0).Item(0)
                txtBorrowerFirst.Text = ds.Tables(0).Rows(0).Item(1).ToString.Trim
                txtBorrowerMiddle.Text = ds.Tables(0).Rows(0).Item(2).ToString.Trim
                txtBorrowerLast.Text = ds.Tables(0).Rows(0).Item(3).ToString.Trim
                If ds.Tables(0).Rows(0).Item(10).ToString = "STUDENT" Then
                    rbtStudent.Checked = True
                ElseIf ds.Tables(0).Rows(0).Item(10).ToString = "EMPLOYEE" Then
                    rbtSchlEmployee.Checked = True
                End If
                txtContact.Text = ds.Tables(0).Rows(0).Item(6).ToString.Trim
                If ds.Tables(0).Rows(0).Item(4).ToString.Trim = "MALE" Then
                    rbtMale.Checked = True
                ElseIf ds.Tables(0).Rows(0).Item(4).ToString.Trim = "FEMALE" Then
                    rbtFemale.Checked = True
                End If
                dtpBorrowerBirth.Value = ds.Tables(0).Rows(0).Item(5)
                birth = DateTime.Parse(ds.Tables(0).Rows(0).Item(5).ToString.Trim)
                lblAge.Text = DateDiff(DateInterval.Year, birth, Now).ToString
                'lblAddress.Text = ds.Tables(0).Rows(0).Item(7).ToString.Trim + " " + brgy + ", " + city
                txtStreet.Text = ds.Tables(0).Rows(0).Item(7).ToString.Trim
                cboBrgy.Text = brgy
                cboCitty.Text = city
                picBorrowerPhoto.BackgroundImage = Base64ToImage(ds.Tables(0).Rows(0).Item(11).ToString.Trim)
            End If
        Catch ex As Exception

        End Try
        '0 borrowerId`, `1 borrowerFirst`, `2 borrowerMiddle`, `3 borrowerLast`, `4 borrowerGender`, `5 borrowerBirth`,
        '`6 borrowerPhone`, `7 borrowerStreet`, `8 borrowerBarangayId`, `9 borrowerCityId`, `10 borrowerType`, `11 borrowerPhoto`
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim ans As Integer
        ans = MsgBox("There are unsaved changes. Do you want to exit without saving?", MsgBoxStyle.YesNo, "Unsaved Changes")
        If ans = MsgBoxResult.Yes Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub txtBorrowerId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBorrowerId.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBorrowerFirst_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBorrowerFirst.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetter(c) Or (c = " ") Or (c = "-") Or (c = ".") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBorrowerMiddle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBorrowerMiddle.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetter(c) Or (c = " ") Or (c = "-") Or (c = ".") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBorrowerLast_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBorrowerLast.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetter(c) Or (c = " ") Or (c = "-") Or (c = ".") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtStreet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStreet.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsLetterOrDigit(c) Or (c = "#") Or (c = "/") Or (c = "|") Or (c = "\") Or (c = ",") Or (c = " ") Or (c = ")") Or (c = "(") Or (c = "`") Or (c = "&") Or (c = ":") Or (c = "-") Or (c = ".") Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress
        Dim c As Char
        c = e.KeyChar
        If Not (Char.IsDigit(c) Or Char.IsControl(c)) Then
            e.Handled = True
        End If
    End Sub

    'Private Sub txtBorrowerId_LostFocus(sender As Object, e As EventArgs) Handles txtBorrowerId.LostFocus
    '    txtBorrowerId.Text = txtBorrowerId.Text.ToUpper
    '    txtBorrowerId.Text = Val(txtBorrowerId.Text).ToString("000#")
    'End Sub
    Private Sub txtBorrowerFirst_LostFocus(sender As Object, e As EventArgs) Handles txtBorrowerFirst.LostFocus
        txtBorrowerFirst.Text = txtBorrowerFirst.Text.ToUpper
    End Sub

    Private Sub txtBorrowerMiddle_LostFocus(sender As Object, e As EventArgs) Handles txtBorrowerMiddle.LostFocus
        txtBorrowerMiddle.Text = txtBorrowerMiddle.Text.ToUpper
    End Sub

    Private Sub txtBorrowerLast_LostFocus(sender As Object, e As EventArgs) Handles txtBorrowerLast.LostFocus
        txtBorrowerLast.Text = txtBorrowerLast.Text.ToUpper
    End Sub

    Private Sub txtStreet_LostFocus(sender As Object, e As EventArgs) Handles txtStreet.LostFocus
        txtStreet.Text = txtStreet.Text.ToUpper
    End Sub

    Private Sub formSettingUpdateBorrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generateCity()
        generateBarangay()
        fillBorrowerInfo()
        txtBorrowerId.Focus()

    End Sub

    Private Sub btnUploadPhoto_Click(sender As Object, e As EventArgs) Handles btnUploadPhoto.Click
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

                        Dim BorrowerPhoto As New Bitmap(ofd.FileName)
                        picBorrowerPhoto.BackgroundImageLayout = ImageLayout.Zoom
                        picBorrowerPhoto.BackgroundImage = ResizeImage(BorrowerPhoto)

                    Else
                        MessageBox.Show("The file size is too large!", "Large File Size", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Function ResizeImage(ByVal PhotoFile As Image) As Image
        Return New Bitmap(PhotoFile, New Size(picBorrowerPhoto.Width, picBorrowerPhoto.Height))
    End Function

    Private Sub cboCitty_LostFocus(sender As Object, e As EventArgs) Handles cboCitty.LostFocus
        cboCitty.Text = cboCitty.Text.ToUpper
    End Sub

    Private Sub cboCitty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCitty.SelectedIndexChanged
        generateBarangay()
    End Sub

    Private Sub cboBrgy_LostFocus(sender As Object, e As EventArgs) Handles cboBrgy.LostFocus
        cboBrgy.Text = cboBrgy.Text.ToUpper
    End Sub

    Private Sub btnEditBorrower_Click(sender As Object, e As EventArgs) Handles btnEditBorrower.Click
        If Not String.IsNullOrWhiteSpace(txtBorrowerId.Text) Then
            If Not String.IsNullOrWhiteSpace(txtBorrowerFirst.Text) Then
                If Not String.IsNullOrWhiteSpace(txtBorrowerLast.Text) Then
                    If Not txtContact.TextLength < 10 Or txtContact.TextLength = 0 Then

                        objBorrower = New Borrower
                        objBorrower.BorrowerIdNew = txtBorrowerId.Text
                        objBorrower.BorrowerFirst = txtBorrowerFirst.Text
                        objBorrower.BorrowerMiddle = txtBorrowerMiddle.Text
                        objBorrower.BorrowerLast = txtBorrowerLast.Text
                        If rbtFemale.Checked = True Then
                            objBorrower.BorrowerGender = "FEMALE"
                        ElseIf rbtMale.Checked = True Then
                            objBorrower.BorrowerGender = "MALE"
                        End If
                        If rbtStudent.Checked = True Then
                            objBorrower.BorrowerType = "STUDENT"
                        ElseIf rbtSchlEmployee.Checked = True Then
                            objBorrower.BorrowerType = "SCHOOL EMPLOYEE"
                        End If
                        objBorrower.BorrowerBirth = dtpBorrowerBirth.Value.ToString("d")
                        objBorrower.BorrowerPhone = txtContact.Text
                        objBorrower.BorrowerPhoto = objBorrower.ConvertImageTo64(picBorrowerPhoto.BackgroundImage)

                        Dim index As Integer = 0
                        If Not String.IsNullOrWhiteSpace(cboCitty.Text) Then
                            While index < dsBrgy.Tables(0).Rows.Count
                                If cboBrgy.Text = dsBrgy.Tables(0).Rows(index).Item(2).ToString.Trim Then
                                    objBorrower.BorrowerBarangayId = dsBrgy.Tables(0).Rows(index).Item(0)
                                    objBorrower.BorrowerCityId = dsBrgy.Tables(0).Rows(index).Item(1)
                                    objBorrower.BorrowerStreet = txtStreet.Text
                                    Exit While
                                End If
                                index += 1
                            End While
                        End If


                        'borrowerObj.BorrowerBarangayId = cboBrgy.Text
                        'borrowerObj.BorrowerCityId = cboCity.Text
                        'Try
                        '    borrowerObj.BorrowerBarangayId = LibraryDatabase.fetchSQL("SELECT `barangayId` FROM `barangay` WHERE  `barangayCityId`=" + .RegisterLevelId.ToString + " and `sectionName`='" + cboSection.Text + "';").Tables(0).Rows(0).Item(0).ToString
                        'Catch ex As Exception

                        'End Try

                        objBorrower.editBorrower()
                        MessageBox.Show("Successfully Updated a Borrower!", "Successfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = Windows.Forms.DialogResult.OK

                    Else
                        MessageBox.Show("Invalid Contact Number!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtContact.Focus()
                    End If
                Else
                    MessageBox.Show("Required Last Name!", "Required Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtBorrowerLast.Focus()
                End If
            Else
                MessageBox.Show("Required First Name!", "Required Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtBorrowerFirst.Focus()
            End If
        Else
            MessageBox.Show("Required Borrower ID!", "Required Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBorrowerId.Focus()
        End If
    End Sub

End Class