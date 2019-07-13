<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateBorrower
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdateBorrower))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.grpPersonalInfo = New System.Windows.Forms.GroupBox()
        Me.btnUploadPhoto = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picBorrowerPhoto = New System.Windows.Forms.PictureBox()
        Me.cboCitty = New System.Windows.Forms.ComboBox()
        Me.cboBrgy = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.dtpBorrowerBirth = New System.Windows.Forms.DateTimePicker()
        Me.txtBorrowerLast = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBorrowerFirst = New System.Windows.Forms.TextBox()
        Me.txtBorrowerId = New System.Windows.Forms.TextBox()
        Me.txtBorrowerMiddle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.grpGender = New System.Windows.Forms.GroupBox()
        Me.rbtSchlEmployee = New System.Windows.Forms.RadioButton()
        Me.rbtStudent = New System.Windows.Forms.RadioButton()
        Me.grpBorrowerType = New System.Windows.Forms.GroupBox()
        Me.rbtFemale = New System.Windows.Forms.RadioButton()
        Me.rbtMale = New System.Windows.Forms.RadioButton()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEditBorrower = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.grpPersonalInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picBorrowerPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGender.SuspendLayout()
        Me.grpBorrowerType.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(175, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 15)
        Me.Label7.TabIndex = 290
        Me.Label7.Text = "+63"
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.White
        Me.txtContact.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(218, 186)
        Me.txtContact.MaxLength = 10
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(256, 23)
        Me.txtContact.TabIndex = 282
        '
        'grpPersonalInfo
        '
        Me.grpPersonalInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPersonalInfo.BackColor = System.Drawing.Color.Transparent
        Me.grpPersonalInfo.Controls.Add(Me.btnUploadPhoto)
        Me.grpPersonalInfo.Controls.Add(Me.Label5)
        Me.grpPersonalInfo.Controls.Add(Me.Panel1)
        Me.grpPersonalInfo.Controls.Add(Me.cboCitty)
        Me.grpPersonalInfo.Controls.Add(Me.cboBrgy)
        Me.grpPersonalInfo.Controls.Add(Me.Label7)
        Me.grpPersonalInfo.Controls.Add(Me.Label21)
        Me.grpPersonalInfo.Controls.Add(Me.Label18)
        Me.grpPersonalInfo.Controls.Add(Me.Label15)
        Me.grpPersonalInfo.Controls.Add(Me.txtStreet)
        Me.grpPersonalInfo.Controls.Add(Me.Label9)
        Me.grpPersonalInfo.Controls.Add(Me.lblAge)
        Me.grpPersonalInfo.Controls.Add(Me.label6)
        Me.grpPersonalInfo.Controls.Add(Me.txtContact)
        Me.grpPersonalInfo.Controls.Add(Me.dtpBorrowerBirth)
        Me.grpPersonalInfo.Controls.Add(Me.txtBorrowerLast)
        Me.grpPersonalInfo.Controls.Add(Me.Label20)
        Me.grpPersonalInfo.Controls.Add(Me.Label17)
        Me.grpPersonalInfo.Controls.Add(Me.Label16)
        Me.grpPersonalInfo.Controls.Add(Me.txtBorrowerFirst)
        Me.grpPersonalInfo.Controls.Add(Me.txtBorrowerId)
        Me.grpPersonalInfo.Controls.Add(Me.txtBorrowerMiddle)
        Me.grpPersonalInfo.Controls.Add(Me.Label3)
        Me.grpPersonalInfo.Controls.Add(Me.Label1)
        Me.grpPersonalInfo.Controls.Add(Me.Label11)
        Me.grpPersonalInfo.Controls.Add(Me.Label12)
        Me.grpPersonalInfo.Controls.Add(Me.Label13)
        Me.grpPersonalInfo.Controls.Add(Me.grpGender)
        Me.grpPersonalInfo.Controls.Add(Me.grpBorrowerType)
        Me.grpPersonalInfo.Location = New System.Drawing.Point(31, 70)
        Me.grpPersonalInfo.Name = "grpPersonalInfo"
        Me.grpPersonalInfo.Size = New System.Drawing.Size(1010, 466)
        Me.grpPersonalInfo.TabIndex = 413
        Me.grpPersonalInfo.TabStop = False
        '
        'btnUploadPhoto
        '
        Me.btnUploadPhoto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUploadPhoto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnUploadPhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnUploadPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUploadPhoto.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUploadPhoto.Location = New System.Drawing.Point(706, 323)
        Me.btnUploadPhoto.Name = "btnUploadPhoto"
        Me.btnUploadPhoto.Size = New System.Drawing.Size(173, 26)
        Me.btnUploadPhoto.TabIndex = 402
        Me.btnUploadPhoto.Text = "Upload Photo"
        Me.btnUploadPhoto.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(586, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 319
        Me.Label5.Text = "Photo"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.picBorrowerPhoto)
        Me.Panel1.Location = New System.Drawing.Point(589, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(382, 284)
        Me.Panel1.TabIndex = 318
        '
        'picBorrowerPhoto
        '
        Me.picBorrowerPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBorrowerPhoto.Location = New System.Drawing.Point(62, 24)
        Me.picBorrowerPhoto.Name = "picBorrowerPhoto"
        Me.picBorrowerPhoto.Size = New System.Drawing.Size(252, 231)
        Me.picBorrowerPhoto.TabIndex = 0
        Me.picBorrowerPhoto.TabStop = False
        '
        'cboCitty
        '
        Me.cboCitty.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboCitty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCitty.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCitty.FormattingEnabled = True
        Me.cboCitty.Location = New System.Drawing.Point(172, 389)
        Me.cboCitty.Name = "cboCitty"
        Me.cboCitty.Size = New System.Drawing.Size(305, 23)
        Me.cboCitty.TabIndex = 307
        '
        'cboBrgy
        '
        Me.cboBrgy.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboBrgy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBrgy.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBrgy.FormattingEnabled = True
        Me.cboBrgy.Location = New System.Drawing.Point(172, 362)
        Me.cboBrgy.Name = "cboBrgy"
        Me.cboBrgy.Size = New System.Drawing.Size(305, 23)
        Me.cboBrgy.TabIndex = 306
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(271, 312)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 15)
        Me.Label21.TabIndex = 301
        Me.Label21.Text = "ADDRESS"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(76, 370)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 15)
        Me.Label18.TabIndex = 300
        Me.Label18.Text = "Barangay"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(112, 397)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 15)
        Me.Label15.TabIndex = 299
        Me.Label15.Text = "City"
        '
        'txtStreet
        '
        Me.txtStreet.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtStreet.BackColor = System.Drawing.Color.White
        Me.txtStreet.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreet.Location = New System.Drawing.Point(172, 335)
        Me.txtStreet.MaxLength = 256
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(305, 23)
        Me.txtStreet.TabIndex = 298
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(42, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 15)
        Me.Label9.TabIndex = 295
        Me.Label9.Text = "Borrower Type"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.Transparent
        Me.lblAge.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.Black
        Me.lblAge.Location = New System.Drawing.Point(168, 290)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(15, 15)
        Me.lblAge.TabIndex = 289
        Me.lblAge.Text = ".."
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.Black
        Me.label6.Location = New System.Drawing.Point(113, 290)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(32, 15)
        Me.label6.TabIndex = 288
        Me.label6.Text = "Age"
        '
        'dtpBorrowerBirth
        '
        Me.dtpBorrowerBirth.AllowDrop = True
        Me.dtpBorrowerBirth.CustomFormat = "mm/dd/yyyy"
        Me.dtpBorrowerBirth.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBorrowerBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBorrowerBirth.Location = New System.Drawing.Point(171, 250)
        Me.dtpBorrowerBirth.Name = "dtpBorrowerBirth"
        Me.dtpBorrowerBirth.Size = New System.Drawing.Size(306, 23)
        Me.dtpBorrowerBirth.TabIndex = 280
        Me.dtpBorrowerBirth.Value = New Date(2018, 1, 1, 0, 0, 0, 0)
        '
        'txtBorrowerLast
        '
        Me.txtBorrowerLast.BackColor = System.Drawing.Color.White
        Me.txtBorrowerLast.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowerLast.Location = New System.Drawing.Point(174, 122)
        Me.txtBorrowerLast.MaxLength = 256
        Me.txtBorrowerLast.Name = "txtBorrowerLast"
        Me.txtBorrowerLast.Size = New System.Drawing.Size(303, 23)
        Me.txtBorrowerLast.TabIndex = 278
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(77, 258)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 15)
        Me.Label20.TabIndex = 274
        Me.Label20.Text = "Birthdate"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(90, 162)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 15)
        Me.Label17.TabIndex = 271
        Me.Label17.Text = "Gender"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(54, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 15)
        Me.Label16.TabIndex = 270
        Me.Label16.Text = "Middle Name"
        '
        'txtBorrowerFirst
        '
        Me.txtBorrowerFirst.BackColor = System.Drawing.Color.White
        Me.txtBorrowerFirst.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowerFirst.Location = New System.Drawing.Point(174, 58)
        Me.txtBorrowerFirst.MaxLength = 256
        Me.txtBorrowerFirst.Name = "txtBorrowerFirst"
        Me.txtBorrowerFirst.Size = New System.Drawing.Size(303, 23)
        Me.txtBorrowerFirst.TabIndex = 267
        '
        'txtBorrowerId
        '
        Me.txtBorrowerId.BackColor = System.Drawing.Color.White
        Me.txtBorrowerId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowerId.Location = New System.Drawing.Point(174, 26)
        Me.txtBorrowerId.MaxLength = 10
        Me.txtBorrowerId.Name = "txtBorrowerId"
        Me.txtBorrowerId.Size = New System.Drawing.Size(303, 23)
        Me.txtBorrowerId.TabIndex = 266
        '
        'txtBorrowerMiddle
        '
        Me.txtBorrowerMiddle.BackColor = System.Drawing.Color.White
        Me.txtBorrowerMiddle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowerMiddle.Location = New System.Drawing.Point(174, 90)
        Me.txtBorrowerMiddle.MaxLength = 256
        Me.txtBorrowerMiddle.Name = "txtBorrowerMiddle"
        Me.txtBorrowerMiddle.Size = New System.Drawing.Size(303, 23)
        Me.txtBorrowerMiddle.TabIndex = 265
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(97, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 256
        Me.Label3.Text = "Street"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(59, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 255
        Me.Label1.Text = "Borrower ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(31, 194)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 15)
        Me.Label11.TabIndex = 253
        Me.Label11.Text = "Contact Number"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(67, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 15)
        Me.Label12.TabIndex = 252
        Me.Label12.Text = "First Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(69, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 15)
        Me.Label13.TabIndex = 251
        Me.Label13.Text = "Last Name"
        '
        'grpGender
        '
        Me.grpGender.Controls.Add(Me.rbtSchlEmployee)
        Me.grpGender.Controls.Add(Me.rbtStudent)
        Me.grpGender.Location = New System.Drawing.Point(171, 206)
        Me.grpGender.Name = "grpGender"
        Me.grpGender.Size = New System.Drawing.Size(303, 35)
        Me.grpGender.TabIndex = 309
        Me.grpGender.TabStop = False
        '
        'rbtSchlEmployee
        '
        Me.rbtSchlEmployee.AutoSize = True
        Me.rbtSchlEmployee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtSchlEmployee.Location = New System.Drawing.Point(148, 11)
        Me.rbtSchlEmployee.Name = "rbtSchlEmployee"
        Me.rbtSchlEmployee.Size = New System.Drawing.Size(137, 19)
        Me.rbtSchlEmployee.TabIndex = 296
        Me.rbtSchlEmployee.TabStop = True
        Me.rbtSchlEmployee.Text = "School Employee"
        Me.rbtSchlEmployee.UseVisualStyleBackColor = True
        '
        'rbtStudent
        '
        Me.rbtStudent.AutoSize = True
        Me.rbtStudent.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtStudent.Location = New System.Drawing.Point(6, 11)
        Me.rbtStudent.Name = "rbtStudent"
        Me.rbtStudent.Size = New System.Drawing.Size(76, 19)
        Me.rbtStudent.TabIndex = 295
        Me.rbtStudent.TabStop = True
        Me.rbtStudent.Text = "Student"
        Me.rbtStudent.UseVisualStyleBackColor = True
        '
        'grpBorrowerType
        '
        Me.grpBorrowerType.Controls.Add(Me.rbtFemale)
        Me.grpBorrowerType.Controls.Add(Me.rbtMale)
        Me.grpBorrowerType.Location = New System.Drawing.Point(174, 144)
        Me.grpBorrowerType.Name = "grpBorrowerType"
        Me.grpBorrowerType.Size = New System.Drawing.Size(303, 33)
        Me.grpBorrowerType.TabIndex = 310
        Me.grpBorrowerType.TabStop = False
        '
        'rbtFemale
        '
        Me.rbtFemale.AutoSize = True
        Me.rbtFemale.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFemale.Location = New System.Drawing.Point(148, 8)
        Me.rbtFemale.Name = "rbtFemale"
        Me.rbtFemale.Size = New System.Drawing.Size(73, 19)
        Me.rbtFemale.TabIndex = 289
        Me.rbtFemale.TabStop = True
        Me.rbtFemale.Text = "Female"
        Me.rbtFemale.UseVisualStyleBackColor = True
        '
        'rbtMale
        '
        Me.rbtMale.AutoSize = True
        Me.rbtMale.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMale.Location = New System.Drawing.Point(6, 11)
        Me.rbtMale.Name = "rbtMale"
        Me.rbtMale.Size = New System.Drawing.Size(56, 19)
        Me.rbtMale.TabIndex = 288
        Me.rbtMale.TabStop = True
        Me.rbtMale.Text = "Male"
        Me.rbtMale.UseVisualStyleBackColor = True
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
        Me.btnCancel.Location = New System.Drawing.Point(919, 555)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 26)
        Me.btnCancel.TabIndex = 416
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnEditBorrower
        '
        Me.btnEditBorrower.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditBorrower.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditBorrower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.btnEditBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditBorrower.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditBorrower.Image = CType(resources.GetObject("btnEditBorrower.Image"), System.Drawing.Image)
        Me.btnEditBorrower.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditBorrower.Location = New System.Drawing.Point(737, 555)
        Me.btnEditBorrower.Name = "btnEditBorrower"
        Me.btnEditBorrower.Size = New System.Drawing.Size(173, 26)
        Me.btnEditBorrower.TabIndex = 415
        Me.btnEditBorrower.Text = "Confirm Update"
        Me.btnEditBorrower.UseVisualStyleBackColor = False
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
        Me.Panel6.Size = New System.Drawing.Size(1065, 37)
        Me.Panel6.TabIndex = 414
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
        Me.Label10.Size = New System.Drawing.Size(164, 19)
        Me.Label10.TabIndex = 205
        Me.Label10.Text = "      Update Borrower"
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
        Me.Button3.Location = New System.Drawing.Point(1022, -462)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 27)
        Me.Button3.TabIndex = 213
        Me.Button3.Text = "Logout"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FormUpdateBorrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 590)
        Me.Controls.Add(Me.grpPersonalInfo)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEditBorrower)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormUpdateBorrower"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUpdateBorrower"
        Me.grpPersonalInfo.ResumeLayout(False)
        Me.grpPersonalInfo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.picBorrowerPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGender.ResumeLayout(False)
        Me.grpGender.PerformLayout()
        Me.grpBorrowerType.ResumeLayout(False)
        Me.grpBorrowerType.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents grpPersonalInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnUploadPhoto As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents picBorrowerPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents cboCitty As System.Windows.Forms.ComboBox
    Friend WithEvents cboBrgy As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtStreet As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents dtpBorrowerBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBorrowerLast As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtBorrowerFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtBorrowerId As System.Windows.Forms.TextBox
    Friend WithEvents txtBorrowerMiddle As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents grpGender As System.Windows.Forms.GroupBox
    Friend WithEvents rbtSchlEmployee As System.Windows.Forms.RadioButton
    Friend WithEvents rbtStudent As System.Windows.Forms.RadioButton
    Friend WithEvents grpBorrowerType As System.Windows.Forms.GroupBox
    Friend WithEvents rbtFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMale As System.Windows.Forms.RadioButton
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEditBorrower As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
