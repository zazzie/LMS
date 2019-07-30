<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.btnLibrarianLogin = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnConfigureDB = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.linkForgotPassword = New System.Windows.Forms.LinkLabel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLibrarianLogin
        '
        Me.btnLibrarianLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnLibrarianLogin.FlatAppearance.BorderSize = 0
        Me.btnLibrarianLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnLibrarianLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLibrarianLogin.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLibrarianLogin.ForeColor = System.Drawing.Color.White
        Me.btnLibrarianLogin.Image = CType(resources.GetObject("btnLibrarianLogin.Image"), System.Drawing.Image)
        Me.btnLibrarianLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLibrarianLogin.Location = New System.Drawing.Point(163, 291)
        Me.btnLibrarianLogin.Name = "btnLibrarianLogin"
        Me.btnLibrarianLogin.Size = New System.Drawing.Size(133, 29)
        Me.btnLibrarianLogin.TabIndex = 271
        Me.btnLibrarianLogin.Text = "Login"
        Me.btnLibrarianLogin.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(319, 88)
        Me.Panel2.TabIndex = 273
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(112, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 24)
        Me.Label4.TabIndex = 215
        Me.Label4.Text = "LIBRARY"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(85, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 24)
        Me.Label3.TabIndex = 214
        Me.Label3.Text = "HIGH SCHOOL"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(59, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 24)
        Me.Label6.TabIndex = 213
        Me.Label6.Text = "RECODO NATIONAL"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 335)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(319, 27)
        Me.Panel3.TabIndex = 272
        '
        'btnConfigureDB
        '
        Me.btnConfigureDB.BackColor = System.Drawing.SystemColors.Control
        Me.btnConfigureDB.FlatAppearance.BorderSize = 0
        Me.btnConfigureDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnConfigureDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigureDB.ForeColor = System.Drawing.Color.Teal
        Me.btnConfigureDB.Location = New System.Drawing.Point(272, 94)
        Me.btnConfigureDB.Name = "btnConfigureDB"
        Me.btnConfigureDB.Size = New System.Drawing.Size(26, 25)
        Me.btnConfigureDB.TabIndex = 280
        Me.btnConfigureDB.Text = "?"
        Me.btnConfigureDB.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Image = CType(resources.GetObject("lblUsername.Image"), System.Drawing.Image)
        Me.lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUsername.Location = New System.Drawing.Point(23, 156)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(91, 20)
        Me.lblUsername.TabIndex = 275
        Me.lblUsername.Text = "     Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Image = CType(resources.GetObject("lblPassword.Image"), System.Drawing.Image)
        Me.lblPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPassword.Location = New System.Drawing.Point(23, 208)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(89, 20)
        Me.lblPassword.TabIndex = 274
        Me.lblPassword.Text = "     Password"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(25, 231)
        Me.txtPassword.MaxLength = 256
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(271, 26)
        Me.txtPassword.TabIndex = 277
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(25, 179)
        Me.txtUsername.MaxLength = 256
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(273, 26)
        Me.txtUsername.TabIndex = 276
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(89, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 23)
        Me.Label1.TabIndex = 279
        Me.Label1.Text = "       Librarian Login"
        '
        'linkForgotPassword
        '
        Me.linkForgotPassword.AutoSize = True
        Me.linkForgotPassword.LinkColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.linkForgotPassword.Location = New System.Drawing.Point(204, 266)
        Me.linkForgotPassword.Name = "linkForgotPassword"
        Me.linkForgotPassword.Size = New System.Drawing.Size(92, 13)
        Me.linkForgotPassword.TabIndex = 278
        Me.linkForgotPassword.TabStop = True
        Me.linkForgotPassword.Text = "Forgot Password?"
        Me.linkForgotPassword.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(319, 362)
        Me.Controls.Add(Me.btnLibrarianLogin)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnConfigureDB)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.linkForgotPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogin"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLibrarianLogin As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnConfigureDB As System.Windows.Forms.Button
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents linkForgotPassword As System.Windows.Forms.LinkLabel
End Class
