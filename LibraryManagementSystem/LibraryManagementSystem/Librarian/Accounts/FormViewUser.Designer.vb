<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViewUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormViewUser))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblEmployeeId = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMiddle = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUsertype = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.picUserPhoto = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.picUserPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(419, 347)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(122, 26)
        Me.btnClose.TabIndex = 454
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(11, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 19)
        Me.Label10.TabIndex = 205
        Me.Label10.Text = "      User Details"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(510, -462)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 27)
        Me.Button3.TabIndex = 213
        Me.Button3.Text = "Logout"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(20, 53)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 15)
        Me.Label19.TabIndex = 453
        Me.Label19.Text = "Department :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmployeeId
        '
        Me.lblEmployeeId.AutoSize = True
        Me.lblEmployeeId.BackColor = System.Drawing.Color.Transparent
        Me.lblEmployeeId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeId.ForeColor = System.Drawing.Color.Black
        Me.lblEmployeeId.Location = New System.Drawing.Point(118, 35)
        Me.lblEmployeeId.Name = "lblEmployeeId"
        Me.lblEmployeeId.Size = New System.Drawing.Size(88, 15)
        Me.lblEmployeeId.TabIndex = 465
        Me.lblEmployeeId.Text = "Employee ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 464
        Me.Label3.Text = "Employee ID :"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(118, 20)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(74, 15)
        Me.lblUsername.TabIndex = 463
        Me.lblUsername.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(31, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 462
        Me.Label2.Text = "Username :"
        '
        'lblMiddle
        '
        Me.lblMiddle.AutoSize = True
        Me.lblMiddle.BackColor = System.Drawing.Color.Transparent
        Me.lblMiddle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddle.ForeColor = System.Drawing.Color.Black
        Me.lblMiddle.Location = New System.Drawing.Point(118, 80)
        Me.lblMiddle.Name = "lblMiddle"
        Me.lblMiddle.Size = New System.Drawing.Size(91, 15)
        Me.lblMiddle.TabIndex = 447
        Me.lblMiddle.Text = "Middle Name"
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.BackColor = System.Drawing.Color.Transparent
        Me.lblFirst.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.ForeColor = System.Drawing.Color.Black
        Me.lblFirst.Location = New System.Drawing.Point(118, 63)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(78, 15)
        Me.lblFirst.TabIndex = 446
        Me.lblFirst.Text = "First Name"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.BackColor = System.Drawing.Color.Transparent
        Me.lblLast.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast.ForeColor = System.Drawing.Color.Black
        Me.lblLast.Location = New System.Drawing.Point(118, 97)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(76, 15)
        Me.lblLast.TabIndex = 445
        Me.lblLast.Text = "Last Name"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(14, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 15)
        Me.Label16.TabIndex = 444
        Me.Label16.Text = "Middle Name :"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.Color.Transparent
        Me.Label.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.Black
        Me.Label.Location = New System.Drawing.Point(45, 68)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(67, 15)
        Me.Label.TabIndex = 456
        Me.Label.Text = "Position :"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.Black
        Me.lblPosition.Location = New System.Drawing.Point(118, 68)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(60, 15)
        Me.lblPosition.TabIndex = 457
        Me.lblPosition.Text = "Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(33, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 455
        Me.Label4.Text = "User Type :"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lblDepartment.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.ForeColor = System.Drawing.Color.Black
        Me.lblDepartment.Location = New System.Drawing.Point(118, 53)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(85, 15)
        Me.lblDepartment.TabIndex = 454
        Me.lblDepartment.Text = "Department"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(27, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 15)
        Me.Label12.TabIndex = 443
        Me.Label12.Text = "First Name :"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblUsertype)
        Me.Panel1.Controls.Add(Me.Label)
        Me.Panel1.Controls.Add(Me.lblPosition)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblDepartment)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Location = New System.Drawing.Point(12, 170)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(493, 107)
        Me.Panel1.TabIndex = 452
        '
        'lblUsertype
        '
        Me.lblUsertype.AutoSize = True
        Me.lblUsertype.BackColor = System.Drawing.Color.Transparent
        Me.lblUsertype.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsertype.ForeColor = System.Drawing.Color.Black
        Me.lblUsertype.Location = New System.Drawing.Point(118, 38)
        Me.lblUsertype.Name = "lblUsertype"
        Me.lblUsertype.Size = New System.Drawing.Size(72, 15)
        Me.lblUsertype.TabIndex = 459
        Me.lblUsertype.Text = "User Type"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(29, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 15)
        Me.Label13.TabIndex = 442
        Me.Label13.Text = "Last Name :"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightGray
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Button3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(553, 37)
        Me.Panel6.TabIndex = 452
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblEmployeeId)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.lblUsername)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.lblMiddle)
        Me.Panel4.Controls.Add(Me.lblFirst)
        Me.Panel4.Controls.Add(Me.lblLast)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Location = New System.Drawing.Point(12, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(310, 154)
        Me.Panel4.TabIndex = 453
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(16, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(525, 291)
        Me.Panel2.TabIndex = 453
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.picUserPhoto)
        Me.Panel3.Location = New System.Drawing.Point(328, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(177, 154)
        Me.Panel3.TabIndex = 449
        '
        'picUserPhoto
        '
        Me.picUserPhoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picUserPhoto.BackColor = System.Drawing.Color.White
        Me.picUserPhoto.BackgroundImage = CType(resources.GetObject("picUserPhoto.BackgroundImage"), System.Drawing.Image)
        Me.picUserPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picUserPhoto.Location = New System.Drawing.Point(3, 3)
        Me.picUserPhoto.Name = "picUserPhoto"
        Me.picUserPhoto.Size = New System.Drawing.Size(169, 146)
        Me.picUserPhoto.TabIndex = 3
        Me.picUserPhoto.TabStop = False
        '
        'FormViewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 385)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormViewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormViewUser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.picUserPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeId As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMiddle As System.Windows.Forms.Label
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblLast As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblUsertype As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents picUserPhoto As System.Windows.Forms.PictureBox
End Class
