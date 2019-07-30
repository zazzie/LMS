<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdateUser))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.picUserPhoto = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label = New System.Windows.Forms.Label()
        Me.lblEmployeeId = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMiddle = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboRecovery = New System.Windows.Forms.ComboBox()
        Me.btnUpdateUser = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRecoveryAnswer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboUserType = New System.Windows.Forms.ComboBox()
        Me.btnUserType = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6.SuspendLayout()
        CType(Me.picUserPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel6.Size = New System.Drawing.Size(733, 37)
        Me.Panel6.TabIndex = 453
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
        Me.Label10.Size = New System.Drawing.Size(184, 19)
        Me.Label10.TabIndex = 205
        Me.Label10.Text = "      Update User Details"
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
        Me.Button3.Location = New System.Drawing.Point(690, -462)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 27)
        Me.Button3.TabIndex = 213
        Me.Button3.Text = "Logout"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
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
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.picUserPhoto)
        Me.Panel3.Location = New System.Drawing.Point(503, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(177, 154)
        Me.Panel3.TabIndex = 454
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label)
        Me.Panel1.Controls.Add(Me.lblEmployeeId)
        Me.Panel1.Controls.Add(Me.lblPosition)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblDepartment)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblMiddle)
        Me.Panel1.Controls.Add(Me.lblFirst)
        Me.Panel1.Controls.Add(Me.lblLast)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Location = New System.Drawing.Point(14, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 154)
        Me.Panel1.TabIndex = 455
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.Color.Transparent
        Me.Label.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.Black
        Me.Label.Location = New System.Drawing.Point(41, 121)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(67, 15)
        Me.Label.TabIndex = 460
        Me.Label.Text = "Position :"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmployeeId
        '
        Me.lblEmployeeId.AutoSize = True
        Me.lblEmployeeId.BackColor = System.Drawing.Color.Transparent
        Me.lblEmployeeId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeId.ForeColor = System.Drawing.Color.Black
        Me.lblEmployeeId.Location = New System.Drawing.Point(114, 29)
        Me.lblEmployeeId.Name = "lblEmployeeId"
        Me.lblEmployeeId.Size = New System.Drawing.Size(88, 15)
        Me.lblEmployeeId.TabIndex = 465
        Me.lblEmployeeId.Text = "Employee ID"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.Black
        Me.lblPosition.Location = New System.Drawing.Point(114, 121)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(60, 15)
        Me.lblPosition.TabIndex = 461
        Me.lblPosition.Text = "Position"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(13, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 15)
        Me.Label7.TabIndex = 464
        Me.Label7.Text = "Employee ID :"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lblDepartment.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.ForeColor = System.Drawing.Color.Black
        Me.lblDepartment.Location = New System.Drawing.Point(114, 106)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(85, 15)
        Me.lblDepartment.TabIndex = 459
        Me.lblDepartment.Text = "Department"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(114, 14)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(74, 15)
        Me.lblUsername.TabIndex = 463
        Me.lblUsername.Text = "Username"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(16, 106)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 15)
        Me.Label19.TabIndex = 458
        Me.Label19.Text = "Department :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(27, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 462
        Me.Label8.Text = "Username :"
        '
        'lblMiddle
        '
        Me.lblMiddle.AutoSize = True
        Me.lblMiddle.BackColor = System.Drawing.Color.Transparent
        Me.lblMiddle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddle.ForeColor = System.Drawing.Color.Black
        Me.lblMiddle.Location = New System.Drawing.Point(114, 74)
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
        Me.lblFirst.Location = New System.Drawing.Point(114, 57)
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
        Me.lblLast.Location = New System.Drawing.Point(114, 91)
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
        Me.Label16.Location = New System.Drawing.Point(10, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 15)
        Me.Label16.TabIndex = 444
        Me.Label16.Text = "Middle Name :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(23, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 15)
        Me.Label12.TabIndex = 443
        Me.Label12.Text = "First Name :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(25, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 15)
        Me.Label13.TabIndex = 442
        Me.Label13.Text = "Last Name :"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(594, 422)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 26)
        Me.btnCancel.TabIndex = 457
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(16, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(700, 177)
        Me.Panel2.TabIndex = 454
        '
        'cboRecovery
        '
        Me.cboRecovery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRecovery.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRecovery.FormattingEnabled = True
        Me.cboRecovery.Items.AddRange(New Object() {"What is your first cellphone`s brand name?", "What is your father`s middle name?", "What is your first Christmas gift when you were a child?", "What is the last name of your 3rd grade teacher?"})
        Me.cboRecovery.Location = New System.Drawing.Point(185, 122)
        Me.cboRecovery.Name = "cboRecovery"
        Me.cboRecovery.Size = New System.Drawing.Size(420, 23)
        Me.cboRecovery.TabIndex = 445
        '
        'btnUpdateUser
        '
        Me.btnUpdateUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateUser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateUser.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateUser.Image = CType(resources.GetObject("btnUpdateUser.Image"), System.Drawing.Image)
        Me.btnUpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateUser.Location = New System.Drawing.Point(414, 422)
        Me.btnUpdateUser.Name = "btnUpdateUser"
        Me.btnUpdateUser.Size = New System.Drawing.Size(174, 26)
        Me.btnUpdateUser.TabIndex = 456
        Me.btnUpdateUser.Text = "Confirm Update"
        Me.btnUpdateUser.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.cboRecovery)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtRecoveryAnswer)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.cboUserType)
        Me.Panel4.Controls.Add(Me.btnUserType)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.txtCPassword)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtPassword)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.txtUsername)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(16, 226)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(700, 187)
        Me.Panel4.TabIndex = 455
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(34, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 15)
        Me.Label5.TabIndex = 443
        Me.Label5.Text = "Recorvery Question :"
        '
        'txtRecoveryAnswer
        '
        Me.txtRecoveryAnswer.BackColor = System.Drawing.Color.White
        Me.txtRecoveryAnswer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecoveryAnswer.Location = New System.Drawing.Point(185, 148)
        Me.txtRecoveryAnswer.MaxLength = 200
        Me.txtRecoveryAnswer.Name = "txtRecoveryAnswer"
        Me.txtRecoveryAnswer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRecoveryAnswer.Size = New System.Drawing.Size(420, 23)
        Me.txtRecoveryAnswer.TabIndex = 442
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(116, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 441
        Me.Label6.Text = "Answer :"
        '
        'cboUserType
        '
        Me.cboUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUserType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUserType.FormattingEnabled = True
        Me.cboUserType.Location = New System.Drawing.Point(185, 96)
        Me.cboUserType.Name = "cboUserType"
        Me.cboUserType.Size = New System.Drawing.Size(420, 23)
        Me.cboUserType.TabIndex = 440
        '
        'btnUserType
        '
        Me.btnUserType.BackColor = System.Drawing.Color.Maroon
        Me.btnUserType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnUserType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUserType.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserType.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUserType.Location = New System.Drawing.Point(611, 96)
        Me.btnUserType.Name = "btnUserType"
        Me.btnUserType.Size = New System.Drawing.Size(31, 23)
        Me.btnUserType.TabIndex = 439
        Me.btnUserType.Text = "..."
        Me.btnUserType.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(100, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 438
        Me.Label4.Text = "User Type :"
        '
        'txtCPassword
        '
        Me.txtCPassword.BackColor = System.Drawing.Color.White
        Me.txtCPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPassword.Location = New System.Drawing.Point(185, 70)
        Me.txtCPassword.MaxLength = 30
        Me.txtCPassword.Name = "txtCPassword"
        Me.txtCPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCPassword.Size = New System.Drawing.Size(312, 23)
        Me.txtCPassword.TabIndex = 417
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(46, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 15)
        Me.Label3.TabIndex = 416
        Me.Label3.Text = "Confirm Password :"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(185, 44)
        Me.txtPassword.MaxLength = 30
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(312, 23)
        Me.txtPassword.TabIndex = 415
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(98, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 414
        Me.Label1.Text = "Password :"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(185, 18)
        Me.txtUsername.MaxLength = 30
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(312, 23)
        Me.txtUsername.TabIndex = 413
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(95, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 412
        Me.Label2.Text = "Username :"
        '
        'FormUpdateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 460)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnUpdateUser)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormUpdateUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUpdateUser"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.picUserPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents picUserPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeId As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblMiddle As System.Windows.Forms.Label
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblLast As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cboRecovery As System.Windows.Forms.ComboBox
    Friend WithEvents btnUpdateUser As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRecoveryAnswer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboUserType As System.Windows.Forms.ComboBox
    Friend WithEvents btnUserType As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
