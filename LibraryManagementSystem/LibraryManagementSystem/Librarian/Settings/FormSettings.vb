Public Class FormSettings
    Dim objformAdvancedSettings As New FormAdvancedSettings


    Private Sub FormSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Dispose()
    End Sub

    Private Sub btnAdvSettings_Click(sender As Object, e As EventArgs) Handles btnAdvSettings.Click
        objformAdvancedSettings = New FormAdvancedSettings
        objformAdvancedSettings.ShowDialog()
        If objformAdvancedSettings.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        ElseIf objformAdvancedSettings.DialogResult = Windows.Forms.DialogResult.Cancel Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnManageItem_Click(sender As Object, e As EventArgs) Handles btnManageItem.Click
        FormManageItem.ShowDialog()
    End Sub

    Private Sub btnManageBorrower_Click(sender As Object, e As EventArgs) Handles btnManageBorrower.Click
        FormManageBorrower.ShowDialog()
    End Sub

    Private Sub btnManageAccount_Click(sender As Object, e As EventArgs) Handles btnManageAccount.Click
        FormManageAccount.ShowDialog()
    End Sub
End Class