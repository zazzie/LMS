Public Class FormDatabaseConfiguration

    Private Sub FormDatabaseConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'txtDatabaseName.Text = My.Settings.DatabaseName
            'txtServername.Text = My.Settings.ServerIP
            'txtPort.Text = My.Settings.PortNo
            'txtUserName.Text = My.Settings.UserName
            'txtPassword.Text = My.Settings.Password
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim str As String = "Server=" & txtServername.Text & ";Port=" & txtPort.Text _
                                      & ";Database=" & txtDatabaseName.Text & ";User=" & txtUserName.Text _
                                      & ";Password=" & txtPassword.Text & ";"
        If LibraryDatabase.TestConnection(str) = True Then
            If MessageBox.Show("A new connection has been successfully established. Do you want to save the connection?",
                            "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                My.Settings.DatabaseName = txtDatabaseName.Text
                My.Settings.ServerIP = txtServername.Text
                My.Settings.PortNo = txtPort.Text
                My.Settings.UserName = txtUserName.Text
                My.Settings.Password = txtPassword.Text
                My.Settings.Save()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Else
            MessageBox.Show("Connection failed. Please review connection fields.","", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class