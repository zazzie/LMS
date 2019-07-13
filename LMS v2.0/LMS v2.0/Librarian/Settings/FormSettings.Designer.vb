<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSettings))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnAdvSettings = New System.Windows.Forms.Button()
        Me.btnManageAccount = New System.Windows.Forms.Button()
        Me.btnManageBorrower = New System.Windows.Forms.Button()
        Me.btnManageItem = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(849, 41)
        Me.Panel6.TabIndex = 377
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(17, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "     Settings"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(806, -462)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 27)
        Me.Button1.TabIndex = 213
        Me.Button1.Text = "Logout"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(22, 67)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(805, 286)
        Me.Panel4.TabIndex = 378
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Controls.Add(Me.btnAdvSettings)
        Me.Panel5.Controls.Add(Me.btnManageAccount)
        Me.Panel5.Controls.Add(Me.btnManageBorrower)
        Me.Panel5.Controls.Add(Me.btnManageItem)
        Me.Panel5.Location = New System.Drawing.Point(14, 14)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(774, 258)
        Me.Panel5.TabIndex = 229
        '
        'btnAdvSettings
        '
        Me.btnAdvSettings.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdvSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnAdvSettings.FlatAppearance.BorderSize = 0
        Me.btnAdvSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnAdvSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdvSettings.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdvSettings.Image = CType(resources.GetObject("btnAdvSettings.Image"), System.Drawing.Image)
        Me.btnAdvSettings.Location = New System.Drawing.Point(580, 43)
        Me.btnAdvSettings.Name = "btnAdvSettings"
        Me.btnAdvSettings.Size = New System.Drawing.Size(166, 161)
        Me.btnAdvSettings.TabIndex = 216
        Me.btnAdvSettings.Text = "Advanced Settings"
        Me.btnAdvSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdvSettings.UseVisualStyleBackColor = False
        '
        'btnManageAccount
        '
        Me.btnManageAccount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnManageAccount.BackColor = System.Drawing.Color.Transparent
        Me.btnManageAccount.FlatAppearance.BorderSize = 0
        Me.btnManageAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnManageAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageAccount.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageAccount.Image = CType(resources.GetObject("btnManageAccount.Image"), System.Drawing.Image)
        Me.btnManageAccount.Location = New System.Drawing.Point(394, 43)
        Me.btnManageAccount.Name = "btnManageAccount"
        Me.btnManageAccount.Size = New System.Drawing.Size(166, 161)
        Me.btnManageAccount.TabIndex = 215
        Me.btnManageAccount.Text = "Manage Accounts"
        Me.btnManageAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnManageAccount.UseVisualStyleBackColor = False
        '
        'btnManageBorrower
        '
        Me.btnManageBorrower.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnManageBorrower.BackColor = System.Drawing.Color.Transparent
        Me.btnManageBorrower.FlatAppearance.BorderSize = 0
        Me.btnManageBorrower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnManageBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageBorrower.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageBorrower.Image = CType(resources.GetObject("btnManageBorrower.Image"), System.Drawing.Image)
        Me.btnManageBorrower.Location = New System.Drawing.Point(208, 43)
        Me.btnManageBorrower.Name = "btnManageBorrower"
        Me.btnManageBorrower.Size = New System.Drawing.Size(166, 161)
        Me.btnManageBorrower.TabIndex = 214
        Me.btnManageBorrower.Text = "Manage Borrowers"
        Me.btnManageBorrower.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnManageBorrower.UseVisualStyleBackColor = False
        '
        'btnManageItem
        '
        Me.btnManageItem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnManageItem.BackColor = System.Drawing.Color.Transparent
        Me.btnManageItem.FlatAppearance.BorderSize = 0
        Me.btnManageItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnManageItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageItem.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageItem.Image = CType(resources.GetObject("btnManageItem.Image"), System.Drawing.Image)
        Me.btnManageItem.Location = New System.Drawing.Point(22, 43)
        Me.btnManageItem.Name = "btnManageItem"
        Me.btnManageItem.Size = New System.Drawing.Size(166, 161)
        Me.btnManageItem.TabIndex = 213
        Me.btnManageItem.Text = "Manage Library Items"
        Me.btnManageItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnManageItem.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(705, 368)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(122, 29)
        Me.btnClose.TabIndex = 379
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 403)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnAdvSettings As System.Windows.Forms.Button
    Friend WithEvents btnManageAccount As System.Windows.Forms.Button
    Friend WithEvents btnManageBorrower As System.Windows.Forms.Button
    Friend WithEvents btnManageItem As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
