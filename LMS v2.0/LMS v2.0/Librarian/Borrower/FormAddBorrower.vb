Public Class FormAddBorrower
    Dim objBorrower As New Borrower
    Dim dsBrgy As New DataSet
    Dim objFormCity As New FormBarangayCity

    Private Sub generateCity()
        Try
            Dim ds As New DataSet
            ds = LibraryDatabase.fetchSQL("SELECT DISTINCT `cityId`, `cityName` FROM `city` ORDER BY cityName;")
            cboCity.Items.Clear()
            If ds.Tables(0).Rows.Count > 0 Then
                Dim index As Integer = 0
                While index < ds.Tables(0).Rows.Count
                    With cboCity
                        .Items.Add(ds.Tables(0).Rows(index).Item(1).ToString.Trim)
                    End With
                    index += 1
                End While
                cboCity.Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub generateBarangay()
        If Not String.IsNullOrWhiteSpace(cboCity.Text) Then
            Dim ds As New DataSet
            Try
                ds = LibraryDatabase.fetchSQL("SELECT DISTINCT `barangayId`, `cityId`, `barangayName`, `cityName` FROM `barangay`,`city` WHERE `cityId`=`barangayCityId` AND `cityName`='" + cboCity.Text + "' ORDER BY barangayName; ")
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
                    cboCity.Refresh()
                End If
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If String.IsNullOrWhiteSpace(txtBorrowerId.Text) Then
            If String.IsNullOrWhiteSpace(txtBorrowerFirst.Text) Then
                If String.IsNullOrWhiteSpace(txtBorrowerMiddle.Text) Then
                    If String.IsNullOrWhiteSpace(txtBorrowerLast.Text) Then
                        If String.IsNullOrWhiteSpace(txtContact.Text) Then
                            If String.IsNullOrWhiteSpace(txtStreet.Text) Then
                                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                            Else
                                Dim ans As Integer
                                ans = MsgBox("There are unsaved changes. Do you want to exit without saving?", MsgBoxStyle.YesNo, "Unsaved Changes")
                                If ans = MsgBoxResult.Yes Then
                                    Me.Dispose()
                                End If
                            End If
                        Else
                            Dim ans As Integer
                            ans = MsgBox("There are unsaved changes. Do you want to exit without saving?", MsgBoxStyle.YesNo, "Unsaved Changes")
                            If ans = MsgBoxResult.Yes Then
                                Me.Dispose()
                            End If
                        End If
                    Else
                        Dim ans As Integer
                        ans = MsgBox("There are unsaved changes. Do you want to exit without saving?", MsgBoxStyle.YesNo, "Unsaved Changes")
                        If ans = MsgBoxResult.Yes Then
                            Me.Dispose()
                        End If
                    End If
                Else
                    Dim ans As Integer
                    ans = MsgBox("There are unsaved changes. Do you want to exit without saving?", MsgBoxStyle.YesNo, "Unsaved Changes")
                    If ans = MsgBoxResult.Yes Then
                        Me.Dispose()
                    End If
                End If
            Else
                Dim ans As Integer
                ans = MsgBox("There are unsaved changes. Do you want to exit without saving?", MsgBoxStyle.YesNo, "Unsaved Changes")
                If ans = MsgBoxResult.Yes Then
                    Me.Dispose()
                End If
            End If
        Else
            Dim ans As Integer
            ans = MsgBox("There are unsaved changes. Do you want to exit without saving?", MsgBoxStyle.YesNo, "Unsaved Changes")
            If ans = MsgBoxResult.Yes Then
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub formSettingAddBorrower_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub formSettingAddBorrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generateCity()
        rbtMale.Checked = True
        rbtStudent.Checked = True
        txtBorrowerId.Focus()
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

    Private Sub btnAddBorrower_Click(sender As Object, e As EventArgs) Handles btnAddBorrower.Click
        If Not String.IsNullOrWhiteSpace(txtBorrowerId.Text) Then
            If Not String.IsNullOrWhiteSpace(txtBorrowerFirst.Text) Then
                If Not String.IsNullOrWhiteSpace(txtBorrowerLast.Text) Then
                    If Not txtContact.TextLength < 10 Or txtContact.TextLength = 0 Then
                        If LibraryDatabase.isExisting("SELECT COUNT(*) FROM borrower WHERE `borrowerId`=" + txtBorrowerId.Text + ";") = False Then

                            objBorrower = New Borrower
                            objBorrower.BorrowerId = txtBorrowerId.Text
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
                            If Not String.IsNullOrWhiteSpace(cboCity.Text) Then
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

                            objBorrower.addBorrower()
                            MessageBox.Show("Successfully Added New Borrower!", "Add Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        Else
                            MessageBox.Show("A borrower of the same ID already exist!", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            txtBorrowerId.Focus()
                        End If
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

    Private Sub txtBorrowerId_LostFocus(sender As Object, e As EventArgs) Handles txtBorrowerMiddle.LostFocus

    End Sub

    Private Sub txtBorrowerId_TextChanged(sender As Object, e As EventArgs) Handles txtBorrowerMiddle.TextChanged

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

    Private Sub cboCity_LostFocus(sender As Object, e As EventArgs) Handles cboCity.LostFocus
        cboCity.Text = cboCity.Text.ToUpper
    End Sub

    Private Sub cboCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCity.SelectedIndexChanged
        generateBarangay()
    End Sub

    Private Sub cboBrgy_LostFocus(sender As Object, e As EventArgs) Handles cboBrgy.LostFocus
        cboBrgy.Text = cboBrgy.Text.ToUpper
    End Sub

    Private Sub btnCity_Click(sender As Object, e As EventArgs) Handles btnCity.Click
        objFormCity = New formBarangayCity
        If objFormCity.ShowDialog = Windows.Forms.DialogResult.OK Then
            generateCity()
            generateBarangay()
        End If
    End Sub
End Class